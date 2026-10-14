using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001A5 RID: 421
	[DesignerGenerated]
	public partial class SalesInvoicePortrait : Form
	{
		// Token: 0x06004B4F RID: 19279 RVA: 0x002D1A68 File Offset: 0x002CFC68
		public SalesInvoicePortrait()
		{
			base.Load += this.SalesInvoicePortrait_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.hidevat = 0;
			this.isLeafbrightfiscal = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06004B52 RID: 19282 RVA: 0x002D2292 File Offset: 0x002D0492
		// (set) Token: 0x06004B53 RID: 19283 RVA: 0x002D229C File Offset: 0x002D049C
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06004B54 RID: 19284 RVA: 0x002D22A5 File Offset: 0x002D04A5
		// (set) Token: 0x06004B55 RID: 19285 RVA: 0x002D22AF File Offset: 0x002D04AF
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06004B56 RID: 19286 RVA: 0x002D22B8 File Offset: 0x002D04B8
		// (set) Token: 0x06004B57 RID: 19287 RVA: 0x002D22C2 File Offset: 0x002D04C2
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x002D22CB File Offset: 0x002D04CB
		// (set) Token: 0x06004B59 RID: 19289 RVA: 0x002D22D5 File Offset: 0x002D04D5
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06004B5A RID: 19290 RVA: 0x002D22DE File Offset: 0x002D04DE
		// (set) Token: 0x06004B5B RID: 19291 RVA: 0x002D22E8 File Offset: 0x002D04E8
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x002D22F1 File Offset: 0x002D04F1
		// (set) Token: 0x06004B5D RID: 19293 RVA: 0x002D22FB File Offset: 0x002D04FB
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06004B5E RID: 19294 RVA: 0x002D2304 File Offset: 0x002D0504
		// (set) Token: 0x06004B5F RID: 19295 RVA: 0x002D230E File Offset: 0x002D050E
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06004B60 RID: 19296 RVA: 0x002D2317 File Offset: 0x002D0517
		// (set) Token: 0x06004B61 RID: 19297 RVA: 0x002D2321 File Offset: 0x002D0521
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x002D232A File Offset: 0x002D052A
		// (set) Token: 0x06004B63 RID: 19299 RVA: 0x002D2334 File Offset: 0x002D0534
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x002D233D File Offset: 0x002D053D
		// (set) Token: 0x06004B65 RID: 19301 RVA: 0x002D2347 File Offset: 0x002D0547
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x002D2350 File Offset: 0x002D0550
		// (set) Token: 0x06004B67 RID: 19303 RVA: 0x002D235A File Offset: 0x002D055A
		internal virtual BindingSource GetBranchDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06004B68 RID: 19304 RVA: 0x002D2363 File Offset: 0x002D0563
		// (set) Token: 0x06004B69 RID: 19305 RVA: 0x002D236D File Offset: 0x002D056D
		internal virtual GetBranchDetailsTableAdapter GetBranchDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06004B6A RID: 19306 RVA: 0x002D2376 File Offset: 0x002D0576
		// (set) Token: 0x06004B6B RID: 19307 RVA: 0x002D2380 File Offset: 0x002D0580
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x002D2389 File Offset: 0x002D0589
		// (set) Token: 0x06004B6D RID: 19309 RVA: 0x002D2393 File Offset: 0x002D0593
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06004B6E RID: 19310 RVA: 0x002D239C File Offset: 0x002D059C
		// (set) Token: 0x06004B6F RID: 19311 RVA: 0x002D23A6 File Offset: 0x002D05A6
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x002D23AF File Offset: 0x002D05AF
		// (set) Token: 0x06004B71 RID: 19313 RVA: 0x002D23B9 File Offset: 0x002D05B9
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x002D23C2 File Offset: 0x002D05C2
		// (set) Token: 0x06004B73 RID: 19315 RVA: 0x002D23CC File Offset: 0x002D05CC
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x002D23D5 File Offset: 0x002D05D5
		// (set) Token: 0x06004B75 RID: 19317 RVA: 0x002D23DF File Offset: 0x002D05DF
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x002D23E8 File Offset: 0x002D05E8
		// (set) Token: 0x06004B77 RID: 19319 RVA: 0x002D23F2 File Offset: 0x002D05F2
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x002D23FB File Offset: 0x002D05FB
		// (set) Token: 0x06004B79 RID: 19321 RVA: 0x002D2405 File Offset: 0x002D0605
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x002D240E File Offset: 0x002D060E
		// (set) Token: 0x06004B7B RID: 19323 RVA: 0x002D2418 File Offset: 0x002D0618
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x002D2421 File Offset: 0x002D0621
		// (set) Token: 0x06004B7D RID: 19325 RVA: 0x002D242B File Offset: 0x002D062B
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x002D2434 File Offset: 0x002D0634
		private void SalesInvoicePortrait_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, this.branch, "LeafbrightA4", this._cnn), "1", false) == 0;
				if (flag)
				{
					this.isLeafbrightfiscal = 1;
				}
				else
				{
					this.isLeafbrightfiscal = 0;
				}
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromInvTableAdapter.Connection = sqlConnection;
				this.GetBranchDetails1TableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTotalsTableAdapter.Connection = sqlConnection;
				string text = " ";
				DataTable branches = this.pf.GetBranches(this._cnn);
				bool flag2 = branches.Rows.Count > 0;
				if (flag2)
				{
					text = "Branch Network" + Environment.NewLine + Environment.NewLine;
					try
					{
						foreach (object obj in branches.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							text = string.Concat(new string[]
							{
								text,
								dataRow["Branch"].ToString(),
								" ",
								dataRow["Tel"].ToString(),
								Environment.NewLine,
								dataRow["Address"].ToString(),
								", ",
								dataRow["Address2"].ToString(),
								Environment.NewLine,
								Environment.NewLine
							});
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
				}
				bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
				bool flag4 = flag3;
				ReportParameter reportParameter = new ReportParameter("BranchNetwork", text);
				ReportParameter reportParameter2 = new ReportParameter("IsWarehouse", Conversions.ToString(flag4));
				ReportParameter reportParameter3 = new ReportParameter("digsig", this.revmax_sign);
				ReportParameter reportParameter4 = new ReportParameter("paymentmethod", this.GetPayMethName(this.GetInvPayDisplayDetails()));
				ReportParameter reportParameter5 = new ReportParameter("reprint", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.reprint == 1, 1, 0))));
				int num = 0;
				bool flag5 = Operators.CompareString(this.revmax_sign, "", false) != 0;
				if (flag5)
				{
					num = 1;
				}
				bool flag6 = this.isEltradeESDfiscal == 1;
				if (flag6)
				{
					num = 1;
				}
				ReportParameter reportParameter6 = new ReportParameter("isfiscal", Conversions.ToString(num));
				ReportParameter reportParameter7 = new ReportParameter("ShowFooter", Conversions.ToString(MyProject.Forms.Form1.showfooter));
				ReportParameter reportParameter8 = new ReportParameter("invheader", MyProject.Forms.Form1.InvoiceHeaderText);
				ReportParameter reportParameter9 = new ReportParameter("ShowInvDisc", Conversions.ToString(this.showinvdisc));
				ReportParameter reportParameter10 = new ReportParameter("hidevat", Conversions.ToString(this.hidevat));
				ReportParameter reportParameter11 = new ReportParameter("LeafbrightA4", Conversions.ToString(this.isLeafbrightfiscal));
				ReportParameter[] array = new ReportParameter[]
				{
					reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8, reportParameter9, reportParameter10,
					reportParameter11
				};
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumber, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, this.branch, new int?(MyProject.Forms.Form1.coid), new int?(this.GetInvPayDisplayDetails()));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTotalsTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberTotals, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.ReportViewer1.RefreshReport();
				bool flag7 = (Operators.CompareString(MyProject.Forms.Form1.PrintFilePath, "", false) != 0) & (MyProject.Forms.Form1.PrintToFile == 1) & (this.reprint == 0);
				checked
				{
					if (flag7)
					{
						this.pf.SaveReportToPDF(this.ReportViewer1, MyProject.Forms.Form1.PrintFilePath, this.invnum);
						base.Dispose();
					}
					else
					{
						bool flag8 = (this.isLeafbrightfiscal == 1) & (this.reprint == 0);
						if (flag8)
						{
							string text2 = "<DeviceInfo>  <OutputFormat>EMF</OutputFormat>  <PageWidth>8.5in</PageWidth>  <PageHeight>11in</PageHeight>  <MarginTop>0.25in</MarginTop>  <MarginLeft>0.25in</MarginLeft>  <MarginRight>0.25in</MarginRight>  <MarginBottom>0.25in</MarginBottom></DeviceInfo>";
							this.m_streams = new List<Stream>();
							Warning[] array2;
							this.ReportViewer1.LocalReport.Render("Image", text2, new CreateStreamCallback(this.CreateStream), out array2);
							try
							{
								foreach (Stream stream in this.m_streams)
								{
									stream.Position = 0L;
								}
							}
							finally
							{
								IEnumerator<Stream> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
							this.Print();
							string text3 = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, this.branch, "LBFolderPath", MyProject.Forms.Form1.Constring);
							bool flag9 = Directory.Exists(text3);
							if (flag9)
							{
								string text4 = text3 + "\\" + this.FormatInvoiceNumber(this.invnum) + ".pdf";
								Cursor.Current = Cursors.WaitCursor;
								ToastNotification toastNotification = new ToastNotification("Please wait- retrieving the invoice.", 3000, "General Notice");
								toastNotification.Show();
								int num2 = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBWaitTime", MyProject.Forms.Form1.Constring)));
								Thread.Sleep(num2 - 3000);
								bool flag10 = File.Exists(text4);
								if (flag10)
								{
									Process.Start("explorer.exe", text4);
								}
								else
								{
									MessageBox.Show("Signed invoice is not yet ready. Please check.");
								}
							}
							else
							{
								MessageBox.Show("Folder not found: " + text3);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x002D2C94 File Offset: 0x002D0E94
		private async void RunAsyncTaskDelayProcessing(string filepath)
		{
			checked
			{
				int d = (int)Math.Round(Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBWaitTime", MyProject.Forms.Form1.Constring))));
				await Task.Delay(d - 4000);
				if (File.Exists(filepath))
				{
					Process.Start("explorer.exe", filepath);
				}
				else
				{
					MessageBox.Show("Signed invoice is not yet ready. Please check.");
				}
			}
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x002D2CD4 File Offset: 0x002D0ED4
		public string FormatInvoiceNumber(int invoiceNum)
		{
			return invoiceNum.ToString("D8");
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x002D2CF4 File Offset: 0x002D0EF4
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x002D2D1C File Offset: 0x002D0F1C
		private void Print()
		{
			bool flag = this.m_streams == null || this.m_streams.Count == 0;
			if (flag)
			{
				throw new Exception("No streams to print.");
			}
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrinterSettings.PrinterName = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBPrinterName", MyProject.Forms.Form1.Constring);
			bool flag2 = !printDocument.PrinterSettings.IsValid;
			if (flag2)
			{
				throw new Exception("Invalid printer.");
			}
			printDocument.PrintPage += this.PrintPage;
			this.m_currentPageIndex = 0;
			printDocument.Print();
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x002D2DE4 File Offset: 0x002D0FE4
		private void PrintPage(object sender, PrintPageEventArgs ev)
		{
			Metafile metafile = new Metafile(this.m_streams[this.m_currentPageIndex]);
			ev.Graphics.DrawImage(metafile, ev.PageBounds);
			ref int ptr = ref this.m_currentPageIndex;
			this.m_currentPageIndex = checked(ptr + 1);
			ev.HasMorePages = this.m_currentPageIndex < this.m_streams.Count;
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x002D2E44 File Offset: 0x002D1044
		private int GetInvPayDisplayDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesByInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToInteger(dataRow["ReceiptDisplayPaymentMethod"]);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x002D2EF4 File Offset: 0x002D10F4
		private string GetPayMethName(int paymethid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetpayMethDetails";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymethid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToString(dataRow["Currency"]);
		}

		// Token: 0x0400211F RID: 8479
		public int invnum;

		// Token: 0x04002120 RID: 8480
		private string _cnn;

		// Token: 0x04002121 RID: 8481
		private PublicFunctions pf;

		// Token: 0x04002122 RID: 8482
		public string revmax_sign;

		// Token: 0x04002123 RID: 8483
		public int reprint;

		// Token: 0x04002124 RID: 8484
		public int isEltradeESDfiscal;

		// Token: 0x04002125 RID: 8485
		public string branch;

		// Token: 0x04002126 RID: 8486
		public int showinvdisc;

		// Token: 0x04002127 RID: 8487
		public int hidevat;

		// Token: 0x04002128 RID: 8488
		private int isLeafbrightfiscal;

		// Token: 0x04002129 RID: 8489
		private int m_currentPageIndex;

		// Token: 0x0400212A RID: 8490
		private IList<Stream> m_streams;
	}
}
