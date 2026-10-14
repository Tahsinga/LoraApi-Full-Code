using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using PointOfSale.My;
using ZXing;
using ZXing.QrCode;

namespace PointOfSale
{
	// Token: 0x02000179 RID: 377
	public class PublicFunctions2
	{
		// Token: 0x0600376A RID: 14186 RVA: 0x001E37B8 File Offset: 0x001E19B8
		public bool PrintToFile(int invnum, string SaveAs, string theTextToBePrinted, string prefix)
		{
			bool flag3;
			try
			{
				bool flag = Operators.CompareString(SaveAs, "TXT", false) == 0;
				if (flag)
				{
					File.WriteAllText(Path.Combine(MyProject.Forms.Form1.PrintFilePath, invnum.ToString() + "CR.txt"), theTextToBePrinted);
				}
				else
				{
					bool flag2 = Operators.CompareString(SaveAs, "PDF", false) == 0;
					if (flag2)
					{
						Document document = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
						PdfWriter.GetInstance(document, new FileStream(string.Concat(new string[]
						{
							MyProject.Forms.Form1.PrintFilePath,
							"\\",
							prefix,
							invnum.ToString(),
							"CR.pdf"
						}), FileMode.Create));
						Paragraph paragraph = new Paragraph(theTextToBePrinted);
						document.Open();
						document.Add(paragraph);
						document.Close();
						document.Dispose();
					}
				}
				flag3 = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred printing to file: " + ex.Message);
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x001E38F0 File Offset: 0x001E1AF0
		public Bitmap GetQRCodeImageFromRevmaxJSON(string rev_json)
		{
			JObject jobject = JObject.Parse(rev_json);
			string text = jobject["QRcode"].ToObject<string>();
			BarcodeWriter barcodeWriter = new BarcodeWriter();
			barcodeWriter.Format = BarcodeFormat.QR_CODE;
			barcodeWriter.Options = new QrCodeEncodingOptions
			{
				DisableECI = true,
				CharacterSet = "UTF-8",
				Width = 200,
				Height = 200
			};
			string text2 = text;
			return barcodeWriter.Write(text2);
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x001E397C File Offset: 0x001E1B7C
		public string BuildItemsXML(DataTable prodt_items)
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("ITEMS");
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in prodt_items.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						num++;
						this.MakeItems(xmlWriter, num, Conversions.ToString(dataRow["ProductCode"]), Conversions.ToString(dataRow["ProductDesc"]), Conversions.ToString(dataRow["ProductDesc"]), Conversions.ToDecimal(dataRow["Qty"]), Conversions.ToDecimal(dataRow["SellingPrice"]), Conversions.ToDecimal(dataRow["Total"]), Conversions.ToDecimal(dataRow["Tax"]), Conversions.ToDecimal(dataRow["Taxr"]));
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndDocument();
				xmlWriter.Flush();
				StreamReader streamReader = new StreamReader(memoryStream);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadToEnd();
				xmlWriter.Close();
				return text;
			}
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x001E3AF4 File Offset: 0x001E1CF4
		private void MakeItems(XmlWriter xml_text_writer, int item_number, string item_code, string item_desc, string item_desc2, decimal item_qty, decimal item_price, decimal item_amt, decimal item_tax, decimal item_taxr)
		{
			xml_text_writer.WriteStartElement("ITEM");
			xml_text_writer.WriteStartElement("HH");
			xml_text_writer.WriteString(Conversions.ToString(item_number));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMCODE");
			xml_text_writer.WriteString(item_code);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMNAME1");
			xml_text_writer.WriteString(item_desc);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMNAME2");
			xml_text_writer.WriteString(item_desc2);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("QTY");
			xml_text_writer.WriteString(Conversions.ToString(item_qty));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("PRICE");
			xml_text_writer.WriteString(Conversions.ToString(item_price));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("AMT");
			xml_text_writer.WriteString(Conversions.ToString(item_amt));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("TAX");
			xml_text_writer.WriteString(Conversions.ToString(item_tax));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("TAXR");
			xml_text_writer.WriteString(Conversions.ToString(item_taxr));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteEndElement();
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x001E3C30 File Offset: 0x001E1E30
		private void MakeCurrency(XmlWriter xml_text_writer, string Name, decimal curr_amt, decimal rate)
		{
			xml_text_writer.WriteStartElement("Currency");
			xml_text_writer.WriteStartElement("Name");
			xml_text_writer.WriteString(Name);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("Amount");
			xml_text_writer.WriteString(Conversions.ToString(curr_amt));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("Rate");
			xml_text_writer.WriteString(Conversions.ToString(rate));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteEndElement();
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x001E3CB0 File Offset: 0x001E1EB0
		public string BuildCurrencyXML(string currency_desc, decimal currency_amt, decimal currency_rate)
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("CurrenciesReceived");
			bool flag = Operators.CompareString(currency_desc, "USD", false) == 0;
			if (flag)
			{
				this.MakeCurrency(xmlWriter, "ZWG", 0m, 130m);
				this.MakeCurrency(xmlWriter, currency_desc, currency_amt, currency_rate);
			}
			else
			{
				bool flag2 = Operators.CompareString(currency_desc, "ZWG", false) == 0;
				if (flag2)
				{
					this.MakeCurrency(xmlWriter, currency_desc, currency_amt, currency_rate);
					this.MakeCurrency(xmlWriter, "USD", 0m, 1m);
				}
				else
				{
					MessageBox.Show("Currency is not USD or ZWG. Contact System Developer.");
				}
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			StreamReader streamReader = new StreamReader(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			string text = streamReader.ReadToEnd();
			xmlWriter.Close();
			return text;
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x001E3DBC File Offset: 0x001E1FBC
		public DataTable GetRemaxQRDetails(int invnum, int coid, string branch, int isinvoice, int iscreditnote, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetRevmaxDetails";
			sqlCommand.Parameters.AddWithValue("invnum", invnum);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isinvoice", isinvoice);
			sqlCommand.Parameters.AddWithValue("iscreditnote", iscreditnote);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x001E3E88 File Offset: 0x001E2088
		public int GetExistingSupplierIDorCreate(string suppliername, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select supplierid from suppliers where suppliername='" + suppliername + "'";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["supplierid"]);
			}
			else
			{
				num2 = this.CreateNewSupplier(suppliername, "", "", "", "", "", "", coid, "");
			}
			return num2;
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x001E3F48 File Offset: 0x001E2148
		public int CreateNewSupplier(string suppliername, string contactperson, string contactnumber, string email, string theaddress, string taxnumber, string detail, int coid, string comments)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewSupplier";
			sqlCommand.Parameters.AddWithValue("suppliername", suppliername);
			sqlCommand.Parameters.AddWithValue("contactperson", contactperson);
			sqlCommand.Parameters.AddWithValue("address", theaddress);
			sqlCommand.Parameters.AddWithValue("contactnumber", contactnumber);
			sqlCommand.Parameters.AddWithValue("email", email);
			sqlCommand.Parameters.AddWithValue("comments", comments);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("taxnumber", taxnumber);
			sqlCommand.Parameters.AddWithValue("detail1", detail);
			sqlCommand.Parameters.AddWithValue("new_suppid", num);
			SqlConnection sqlConnection2 = sqlConnection;
			sqlConnection2.Open();
			num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
			sqlConnection2.Close();
			return num;
		}
	}
}
