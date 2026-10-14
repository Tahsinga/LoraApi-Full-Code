using System.Drawing.Printing;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace POSViewer;

public static class ReceiptPrinter
{
    public static async Task<(bool Success, string Error)> TryPrintInvoiceReprintAsync(
        string printerName,
        string connectionString,
        string invoiceNumber,
        string branch)
    {
        if (string.IsNullOrWhiteSpace(printerName))
        {
            return (false, "No receipt printer is selected.");
        }

        if (!int.TryParse(invoiceNumber, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsedInvoiceNumber))
        {
            return (false, "Invoice number must be numeric.");
        }

        try
        {
            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var companyCommand = new SqlCommand(@"
                SELECT TOP (1) coid
                FROM [dbo].[Movement]
                WHERE InvoiceNum = @invoiceNumber
                  AND UPPER(LTRIM(RTRIM(CAST(Branch AS nvarchar(100))))) = UPPER(LTRIM(RTRIM(@branch)));", connection);
            companyCommand.Parameters.AddWithValue("@invoiceNumber", parsedInvoiceNumber);
            companyCommand.Parameters.AddWithValue("@branch", branch);
            var companyIdValue = await companyCommand.ExecuteScalarAsync();
            if (companyIdValue is null || companyIdValue is DBNull)
            {
                return (false, $"Invoice {invoiceNumber} was not found for branch {branch}.");
            }

            var companyId = Convert.ToInt32(companyIdValue, CultureInfo.InvariantCulture);
            var invoiceDetails = await LoadProcedureAsync(connection, "SalesForPeriodByInvoiceDetails",
                ("@invoicenum", parsedInvoiceNumber), ("@coid", companyId), ("@branch", branch));
            if (invoiceDetails.Rows.Count == 0)
            {
                return (false, $"No invoice details were found for invoice {invoiceNumber}.");
            }

            var invoice = invoiceDetails.Rows[0];
            var customerDetails = await LoadProcedureAsync(connection, "FetchCustomerDetails",
                ("@customername", GetText(invoice, "ref")), ("@branch", branch), ("@coid", companyId));
            var branchDetails = await LoadProcedureAsync(connection, "GetBranchDetails",
                ("@coid", companyId), ("@branch", branch));
            var paymentDetails = await LoadProcedureAsync(connection, "GetInvoicePayDetailsFiscal",
                ("@invoicenum", parsedInvoiceNumber), ("@branch", branch), ("@coid", companyId));

            var receipt = BuildInvoiceReprintText(invoiceNumber, invoiceDetails, customerDetails, branchDetails, paymentDetails);
            return TryPrintInvoiceText(printerName, receipt, out var printError)
                ? (true, string.Empty)
                : (false, printError);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    private static async Task<DataTable> LoadProcedureAsync(
        SqlConnection connection,
        string procedureName,
        params (string Name, object Value)[] parameters)
    {
        using var command = new SqlCommand(procedureName, connection)
        {
            CommandType = CommandType.StoredProcedure
        };
        foreach (var parameter in parameters)
        {
            command.Parameters.AddWithValue(parameter.Name, parameter.Value ?? DBNull.Value);
        }

        using var reader = await command.ExecuteReaderAsync();
        var table = new DataTable();
        table.Load(reader);
        return table;
    }

    private static string BuildInvoiceReprintText(
        string invoiceNumber,
        DataTable invoiceDetails,
        DataTable customerDetails,
        DataTable branchDetails,
        DataTable paymentDetails)
    {
        var receipt = new StringBuilder();
        var invoice = invoiceDetails.Rows[0];
        var branchInfo = branchDetails.Rows.Count > 0 ? branchDetails.Rows[0] : null;
        var customer = customerDetails.Rows.Count > 0 ? customerDetails.Rows[0] : null;
        var width = 42;

        AppendCentered(receipt, "FISCAL TAX INVOICE", width);
        if (branchInfo is not null)
        {
            AppendCentered(receipt, GetText(branchInfo, "CompanyName"), width);
            AppendCentered(receipt, JoinLabel(GetText(branchInfo, "BPNumber_name"), GetText(branchInfo, "BPNumber")), width);
            AppendCentered(receipt, JoinLabel(GetText(branchInfo, "VATNumber_name"), GetText(branchInfo, "VATNumber")), width);
            AppendCentered(receipt, GetText(branchInfo, "Address"), width);
            AppendCentered(receipt, GetText(branchInfo, "Address2"), width);
            AppendCentered(receipt, GetText(branchInfo, "Email"), width);
            AppendCentered(receipt, GetText(branchInfo, "Tel"), width);
            AppendCentered(receipt, string.Join("  ", new[] { GetText(branchInfo, "Tel2"), GetText(branchInfo, "Tel3") }.Where(value => !string.IsNullOrWhiteSpace(value))), width);
        }

        receipt.AppendLine($"Teller: {GetText(invoice, "Done_By")}");
        receipt.AppendLine();
        receipt.AppendLine("RE-PRINT");
        receipt.AppendLine(GetDecimal(invoice, "PaymentMethod") == 10m ? "ACCOUNT SALE" : "CASH SALE");
        receipt.AppendLine();
        receipt.AppendLine($"Invoice Number: {invoiceNumber}");

        var saleDateText = GetText(invoice, "Sale_Date");
        if (DateTime.TryParseExact(saleDateText, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var saleDate)
            || DateTime.TryParse(saleDateText, CultureInfo.CurrentCulture, DateTimeStyles.None, out saleDate))
        {
            receipt.AppendLine($"Invoice Date: {saleDate.ToShortDateString()}");
        }
        receipt.AppendLine($"Invoice Time: {GetText(invoice, "trantime")}");
        receipt.AppendLine();

        if (!string.Equals(GetText(invoice, "ref"), "Cash", StringComparison.OrdinalIgnoreCase) && customer is not null)
        {
            AppendOptional(receipt, "Customer Address", string.Join(", ", new[]
            {
                GetText(customer, "StreetNumber"), GetText(customer, "Address"), GetText(customer, "City"), GetText(customer, "Province")
            }.Where(value => !string.IsNullOrWhiteSpace(value))));
            AppendOptional(receipt, "Customer Phone #", GetText(customer, "Mobile"));
            AppendOptional(receipt, GetText(branchInfo, "BPNumber_name"), GetText(customer, "BPNumber"));
            AppendOptional(receipt, GetText(branchInfo, "VATNumber_name"), GetText(customer, "VATNumber"));
            AppendOptional(receipt, "Customer Email", GetText(customer, "Email"));
            receipt.AppendLine();
        }

        var currency = GetText(invoice, "Currency");
        receipt.AppendLine($"HS Code : Description {currency}");
        receipt.AppendLine(new string('-', width));
        receipt.AppendLine($"{"Qty",6}{"UnitPrice",10}{"VAT",8}{"Amount(Incl)",14}");

        decimal taxTotal = 0m;
        decimal subtotal = 0m;
        decimal invoiceDiscount = GetDecimal(invoice, "invdiscount");
        foreach (DataRow row in invoiceDetails.Rows)
        {
            var unitPrice = GetDecimal(row, "Unit_Selling_Price");
            if (unitPrice == 0m)
            {
                continue;
            }

            var quantity = GetDecimal(row, "Quantity");
            if (string.Equals(GetText(row, "UOM"), "EA", StringComparison.OrdinalIgnoreCase))
            {
                quantity = Math.Round(quantity, 0, MidpointRounding.AwayFromZero);
            }
            else
            {
                quantity = Math.Round(quantity, 2, MidpointRounding.AwayFromZero);
            }

            var tax = GetDecimal(row, "Tax");
            var lineSubtotal = GetDecimal(row, "Sub_Total");
            var lineTotal = unitPrice * quantity + tax;
            var description = string.Join(" - ", new[] { GetText(row, "HSCode"), GetText(row, "Description") }
                .Where(value => !string.IsNullOrWhiteSpace(value)));
            if (description.Length > 50)
            {
                description = description[..50];
            }

            receipt.AppendLine(description);
            receipt.AppendLine($"{quantity.ToString("0.##", CultureInfo.InvariantCulture),6}{unitPrice.ToString("N2", CultureInfo.CurrentCulture),10}{tax.ToString("N2", CultureInfo.CurrentCulture),8}{lineTotal.ToString("N2", CultureInfo.CurrentCulture),14}");
            if (GetDecimal(row, "DiscountAmt") != 0m)
            {
                receipt.AppendLine($"Discount Given per unit: {GetDecimal(row, "DiscountAmt").ToString("N2", CultureInfo.CurrentCulture)}");
            }
            AppendOptional(receipt, string.Empty, GetText(row, "Comments"));
            subtotal += lineSubtotal;
            taxTotal += tax;
        }

        subtotal += taxTotal;
        AppendTotal(receipt, "Inv. Subtotal:", subtotal);
        AppendTotal(receipt, "Total VAT:", taxTotal);
        AppendTotal(receipt, "Inv. Discount:", invoiceDiscount);
        AppendTotal(receipt, "Invoice Total:", subtotal - invoiceDiscount);
        receipt.AppendLine();

        var isAccountSale = GetDecimal(invoice, "PaymentMethod") == 10m;
        receipt.AppendLine($"Payment Method:{(isAccountSale ? "Account" : "COD")}");
        if (!isAccountSale)
        {
            foreach (DataRow payment in paymentDetails.Rows)
            {
                receipt.AppendLine($"{GetText(payment, "PaymentMethodDesc")}: {GetDecimal(payment, "AmountPaid").ToString("N2", CultureInfo.CurrentCulture)}");
            }
        }

        if (branchInfo is not null && !string.IsNullOrWhiteSpace(GetText(branchInfo, "Footnote")))
        {
            receipt.AppendLine();
            receipt.AppendLine(GetText(branchInfo, "Footnote"));
        }

        return receipt.ToString();
    }

    private static bool TryPrintInvoiceText(string printerName, string text, out string error)
    {
        error = string.Empty;
        try
        {
            using var document = new PrintDocument();
            document.PrinterSettings.PrinterName = printerName;
            if (!document.PrinterSettings.IsValid)
            {
                error = $"The selected printer is unavailable: {printerName}";
                return false;
            }

            var lines = text.Split(Environment.NewLine, StringSplitOptions.None);
            var lineIndex = 0;
            document.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 315, Math.Clamp(lines.Length * 18 + 80, 600, 10000));
            document.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            document.PrintPage += (_, eventArgs) =>
            {
                using var font = new Font("Times New Roman", 9F, FontStyle.Bold);
                var graphics = eventArgs.Graphics!;
                var y = (float)eventArgs.MarginBounds.Top;
                var lineHeight = font.GetHeight(graphics);
                while (lineIndex < lines.Length && y + lineHeight < eventArgs.MarginBounds.Bottom)
                {
                    graphics.DrawString(lines[lineIndex++], font, Brushes.Black, eventArgs.MarginBounds.Left, y);
                    y += lineHeight;
                }

                eventArgs.HasMorePages = lineIndex < lines.Length;
            };

            document.Print();
            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }

    private static void AppendCentered(StringBuilder receipt, string value, int width)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            var trimmed = value.Trim();
            receipt.AppendLine(trimmed.Length >= width ? trimmed : trimmed.PadLeft((width + trimmed.Length) / 2).PadRight(width));
        }
    }

    private static void AppendOptional(StringBuilder receipt, string label, string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            receipt.AppendLine(string.IsNullOrWhiteSpace(label) ? value : $"{label}: {value}");
        }
    }

    private static void AppendTotal(StringBuilder receipt, string label, decimal amount)
    {
        receipt.AppendLine($"     {label,-20}{amount.ToString("N2", CultureInfo.CurrentCulture),10}");
    }

    private static string JoinLabel(string label, string value)
    {
        return string.Join(" ", new[] { label, value }.Where(part => !string.IsNullOrWhiteSpace(part)));
    }

    private static string GetText(DataRow? row, string columnName)
    {
        return row is not null && row.Table.Columns.Contains(columnName) && !row.IsNull(columnName)
            ? Convert.ToString(row[columnName], CultureInfo.InvariantCulture) ?? string.Empty
            : string.Empty;
    }

    private static decimal GetDecimal(DataRow row, string columnName)
    {
        return row.Table.Columns.Contains(columnName) && !row.IsNull(columnName)
            ? Convert.ToDecimal(row[columnName], CultureInfo.InvariantCulture)
            : 0m;
    }

    public static bool TryPrintMovementReport(
        string printerName,
        string title,
        DataTable table,
        string branch,
        DateTime reportDate,
        out string error)
    {
        error = string.Empty;

        if (string.IsNullOrWhiteSpace(printerName))
        {
            error = "No receipt printer is selected.";
            return false;
        }

        try
        {
            using var document = new PrintDocument();
            document.PrinterSettings.PrinterName = printerName;
            if (!document.PrinterSettings.IsValid)
            {
                error = $"The selected printer is unavailable: {printerName}";
                return false;
            }

            var cashierColumn = table.Columns.IndexOf("Cashier");
            var paymentMethodColumn = table.Columns.IndexOf("PaymentMethod");
            var currencyColumn = table.Columns.IndexOf("Currency");
            var rateColumn = table.Columns.IndexOf("Rate");
            var totalColumn = table.Columns.IndexOf("Total");
            var taxTotalColumn = table.Columns.IndexOf("TaxTotal");
            var invoiceColumn = table.Columns.IndexOf("InvoiceNumber");
            var cashierPaymentMethods = new Dictionary<string, HashSet<string>>(StringComparer.Ordinal);
            var reportPaymentMethods = new HashSet<string>(StringComparer.Ordinal);
            foreach (DataRow tableRow in table.Rows)
            {
                var rowCashier = cashierColumn >= 0 ? tableRow[cashierColumn]?.ToString() ?? "Unknown" : "Unknown";
                var paymentMethod = paymentMethodColumn >= 0 ? tableRow[paymentMethodColumn]?.ToString() ?? "Unknown" : "Unknown";
                var currency = currencyColumn >= 0 ? tableRow[currencyColumn]?.ToString() ?? "UNKNOWN" : "UNKNOWN";
                var paymentKey = $"{paymentMethod} ({currency})";
                reportPaymentMethods.Add(paymentKey);
                if (!cashierPaymentMethods.TryGetValue(rowCashier, out var cashierMethods))
                {
                    cashierMethods = new HashSet<string>(StringComparer.Ordinal);
                    cashierPaymentMethods[rowCashier] = cashierMethods;
                }

                cashierMethods.Add(paymentKey);
            }

            var cashierPaymentLineCount = cashierPaymentMethods.Values.Sum(methods => methods.Count);
            var pageHeight = Math.Clamp(
                400 + cashierPaymentMethods.Count * 74 + cashierPaymentLineCount * 16 + reportPaymentMethods.Count * 32,
                700,
                3200);
            document.DefaultPageSettings.PaperSize = new PaperSize("Sales Report", 315, pageHeight);
            document.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            document.PrintPage += (_, eventArgs) =>
            {
                using var titleFont = new Font("Arial", 13F, FontStyle.Bold);
                using var bodyFont = new Font("Arial", 9F, FontStyle.Regular);
                using var boldFont = new Font("Arial", 9F, FontStyle.Bold);
                var bounds = eventArgs.MarginBounds;
                var y = bounds.Top + 40;

                eventArgs.Graphics!.DrawString(title, titleFont, Brushes.Black, bounds.Left, y);
                y += 24;
                eventArgs.Graphics.DrawString($"Branch: {branch}", bodyFont, Brushes.Black, bounds.Left, y);
                y += 20;
                eventArgs.Graphics.DrawString($"Date: {reportDate:yyyy-MM-dd}", bodyFont, Brushes.Black, bounds.Left, y);
                y += 20;
                eventArgs.Graphics.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y);
                y += 10;

                var receiptCountsByCashier = new Dictionary<string, long>(StringComparer.Ordinal);
                var invoicesByCashier = new Dictionary<string, HashSet<string>>(StringComparer.Ordinal);
                var totalsByPaymentMethod = new Dictionary<string, decimal>(StringComparer.Ordinal);
                var taxesByPaymentMethod = new Dictionary<string, decimal>(StringComparer.Ordinal);
                var totalsByCashier = new Dictionary<string, Dictionary<string, decimal>>(StringComparer.Ordinal);
                var totalsByCashierCurrency = new Dictionary<string, Dictionary<string, decimal>>(StringComparer.Ordinal);
                var totalsByCashierUsd = new Dictionary<string, decimal>(StringComparer.Ordinal);
                var salesByCurrency = new Dictionary<string, decimal>(StringComparer.Ordinal);
                var taxesByCurrency = new Dictionary<string, decimal>(StringComparer.Ordinal);
                var allInvoices = new HashSet<string>(StringComparer.Ordinal);
                var totalReceiptCount = 0L;
                decimal totalUsdTax = 0m;
                if (invoiceColumn >= 0)
                {
                    foreach (DataRow tableRow in table.Rows)
                    {
                        var rowCashier = cashierColumn >= 0 ? tableRow[cashierColumn]?.ToString() ?? "Unknown" : "Unknown";
                        var invoiceNumber = tableRow[invoiceColumn]?.ToString() ?? string.Empty;
                        if (string.IsNullOrWhiteSpace(invoiceNumber))
                        {
                            continue;
                        }

                        if (!invoicesByCashier.TryGetValue(rowCashier, out var cashierInvoices))
                        {
                            cashierInvoices = new HashSet<string>(StringComparer.Ordinal);
                            invoicesByCashier[rowCashier] = cashierInvoices;
                        }

                        cashierInvoices.Add(invoiceNumber);
                        allInvoices.Add(invoiceNumber);
                    }

                    totalReceiptCount = allInvoices.Count;
                    foreach (var cashierInvoices in invoicesByCashier)
                    {
                        receiptCountsByCashier[cashierInvoices.Key] = cashierInvoices.Value.Count;
                    }
                }
                foreach (DataRow tableRow in table.Rows)
                {
                    var rowCashier = cashierColumn >= 0 ? tableRow[cashierColumn]?.ToString() ?? "Unknown" : "Unknown";
                    var paymentMethod = paymentMethodColumn >= 0 ? tableRow[paymentMethodColumn]?.ToString() ?? "Unknown" : "Unknown";
                    var currency = currencyColumn >= 0 ? tableRow[currencyColumn]?.ToString() ?? "UNKNOWN" : "UNKNOWN";
                    var currencyCode = string.IsNullOrWhiteSpace(currency) ? "UNKNOWN" : currency.Trim().ToUpperInvariant();
                    var paymentKey = $"{paymentMethod} ({currencyCode})";
                    var rate = rateColumn >= 0 && decimal.TryParse(tableRow[rateColumn]?.ToString(), out var parsedRate) && parsedRate > 0m
                        ? parsedRate
                        : 1m;
                    if (totalColumn >= 0 && decimal.TryParse(tableRow[totalColumn]?.ToString(), out var rowTotal))
                    {
                        salesByCurrency[currencyCode] = salesByCurrency.GetValueOrDefault(currencyCode) + rowTotal;
                        totalsByPaymentMethod[paymentKey] = totalsByPaymentMethod.GetValueOrDefault(paymentKey) + rowTotal;
                        if (!totalsByCashier.TryGetValue(rowCashier, out var cashierTotals))
                        {
                            cashierTotals = new Dictionary<string, decimal>(StringComparer.Ordinal);
                            totalsByCashier[rowCashier] = cashierTotals;
                        }

                        cashierTotals[paymentKey] = cashierTotals.GetValueOrDefault(paymentKey) + rowTotal;
                        if (!totalsByCashierCurrency.TryGetValue(rowCashier, out var cashierCurrencyTotals))
                        {
                            cashierCurrencyTotals = new Dictionary<string, decimal>(StringComparer.Ordinal);
                            totalsByCashierCurrency[rowCashier] = cashierCurrencyTotals;
                        }

                        cashierCurrencyTotals[currencyCode] = cashierCurrencyTotals.GetValueOrDefault(currencyCode) + rowTotal;
                        totalsByCashierUsd[rowCashier] = totalsByCashierUsd.GetValueOrDefault(rowCashier)
                            + ConvertToUsd(rowTotal, currencyCode, rate);
                    }

                    if (taxTotalColumn >= 0 && decimal.TryParse(tableRow[taxTotalColumn]?.ToString(), out var rowTax))
                    {
                        totalUsdTax += ConvertToUsd(rowTax, currencyCode, rate);
                        taxesByCurrency[currencyCode] = taxesByCurrency.GetValueOrDefault(currencyCode) + rowTax;
                        taxesByPaymentMethod[paymentKey] = taxesByPaymentMethod.GetValueOrDefault(paymentKey) + rowTax;
                    }
                }

                eventArgs.Graphics.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y);
                y += 10;
                eventArgs.Graphics.DrawString("CASHIER PAYMENT TOTALS", boldFont, Brushes.Black, bounds.Left, y);
                y += 20;
                foreach (var cashierTotal in receiptCountsByCashier.OrderBy(entry => entry.Key))
                {
                    eventArgs.Graphics.DrawString(cashierTotal.Key, boldFont, Brushes.Black, bounds.Left, y);
                    y += 18;
                    eventArgs.Graphics.DrawString($"Receipts: {cashierTotal.Value}", bodyFont, Brushes.Black, bounds.Left + 10, y);
                    y += 16;
                    if (totalsByCashier.TryGetValue(cashierTotal.Key, out var cashierPayments))
                    {
                        foreach (var cashierPayment in cashierPayments.OrderBy(entry => entry.Key))
                        {
                            eventArgs.Graphics.DrawString($"{cashierPayment.Key}: {cashierPayment.Value:0.00}", bodyFont, Brushes.Black, bounds.Left + 10, y);
                            y += 16;
                        }
                    }
                }

                eventArgs.Graphics.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y);
                y += 10;
                eventArgs.Graphics.DrawString("REPORT SUMMARY", boldFont, Brushes.Black, bounds.Left, y);
                y += 20;
                eventArgs.Graphics.DrawString("ALL USERS TOTALS BY PAYMENT METHOD", boldFont, Brushes.Black, bounds.Left, y);
                y += 20;
                foreach (var paymentTotal in totalsByPaymentMethod.OrderBy(entry => entry.Key))
                {
                    eventArgs.Graphics.DrawString($"{paymentTotal.Key}: {paymentTotal.Value:0.00}", bodyFont, Brushes.Black, bounds.Left, y);
                    y += 16;
                    if (taxesByPaymentMethod.TryGetValue(paymentTotal.Key, out var paymentTax))
                    {
                        eventArgs.Graphics.DrawString($"Tax: {paymentTax:0.00}", bodyFont, Brushes.Black, bounds.Left + 10, y);
                        y += 16;
                    }
                }
                eventArgs.Graphics.DrawString($"All users total: {totalsByPaymentMethod.Values.Sum():0.00}", boldFont, Brushes.Black, bounds.Left, y);
                y += 18;
                eventArgs.Graphics.DrawString($"Total tax: {taxesByPaymentMethod.Values.Sum():0.00}", boldFont, Brushes.Black, bounds.Left, y);
                y += 18;
                eventArgs.Graphics.DrawString($"Total receipts: {totalReceiptCount}", boldFont, Brushes.Black, bounds.Left, y);
                y += 22;
                eventArgs.Graphics.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y);
                y += 10;
                foreach (var cashierTotal in receiptCountsByCashier.OrderBy(entry => entry.Key))
                {
                    eventArgs.Graphics.DrawString($"{cashierTotal.Key}: {cashierTotal.Value} receipt(s)", bodyFont, Brushes.Black, bounds.Left, y);
                    y += 18;
                }
                y += 6;
                eventArgs.Graphics.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y);
                eventArgs.HasMorePages = false;
            };

            document.Print();
            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }

    private static decimal ConvertToUsd(decimal amount, string currency, decimal rate)
    {
        return string.Equals(currency, "USD", StringComparison.OrdinalIgnoreCase)
            ? amount
            : rate > 0m ? amount / rate : amount;
    }

    public static bool TryPrint(
        string printerName,
        string title,
        IReadOnlyList<(string Label, string Value)> details,
        out string error)
    {
        error = string.Empty;

        if (string.IsNullOrWhiteSpace(printerName))
        {
            error = "No receipt printer is selected.";
            return false;
        }

        try
        {
            using var document = new PrintDocument();
            document.PrinterSettings.PrinterName = printerName;
            if (!document.PrinterSettings.IsValid)
            {
                error = $"The selected printer is unavailable: {printerName}";
                return false;
            }

            document.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 315, 1200);
            document.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            document.PrintPage += (_, eventArgs) =>
            {
                using var titleFont = new Font("Arial", 11F, FontStyle.Bold);
                using var bodyFont = new Font("Arial", 8.5F, FontStyle.Regular);
                using var boldFont = new Font("Arial", 8.5F, FontStyle.Bold);
                var bounds = eventArgs.MarginBounds;
                var y = bounds.Top;

                eventArgs.Graphics!.DrawString(title, titleFont, Brushes.Black, bounds.Left, y);
                y += 26;
                eventArgs.Graphics.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y);
                y += 10;

                foreach (var detail in details)
                {
                    var label = $"{detail.Label}:";
                    if (string.Equals(detail.Label, "Products", StringComparison.OrdinalIgnoreCase))
                    {
                        eventArgs.Graphics.DrawString(label, boldFont, Brushes.Black, bounds.Left, y);
                        y += 18;
                        var productLines = (detail.Value ?? string.Empty).Split(Environment.NewLine, StringSplitOptions.None);
                        foreach (var productLine in productLines)
                        {
                            var productBounds = new RectangleF(bounds.Left + 10, y, bounds.Width - 10, 60);
                            var productSize = eventArgs.Graphics.MeasureString(productLine, bodyFont, productBounds.Size);
                            eventArgs.Graphics.DrawString(productLine, bodyFont, Brushes.Black, productBounds);
                            y += Math.Max(16, (int)Math.Ceiling(productSize.Height + 2));
                        }
                        continue;
                    }

                    eventArgs.Graphics.DrawString(label, boldFont, Brushes.Black, bounds.Left, y);
                    var labelWidth = eventArgs.Graphics.MeasureString(label, boldFont).Width + 4;
                    var valueBounds = new RectangleF(bounds.Left + labelWidth, y, bounds.Width - labelWidth, 60);
                    var valueSize = eventArgs.Graphics.MeasureString(detail.Value ?? string.Empty, bodyFont, valueBounds.Size);
                    eventArgs.Graphics.DrawString(detail.Value ?? string.Empty, bodyFont, Brushes.Black, valueBounds);
                    y += Math.Max(18, (int)Math.Ceiling(valueSize.Height + 4));
                }

                y += 8;
                eventArgs.Graphics.DrawLine(Pens.Black, bounds.Left, y, bounds.Right, y);
                y += 10;
                eventArgs.Graphics.DrawString("Thank you", bodyFont, Brushes.Black, bounds.Left, y);
                eventArgs.HasMorePages = false;
            };

            document.Print();
            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }
}
