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
	// Token: 0x020001A7 RID: 423
	[DesignerGenerated]
	public partial class SalesInvoicePortraitBinum : Form
	{
		// Token: 0x06004BB1 RID: 19377 RVA: 0x002D3850 File Offset: 0x002D1A50
		public SalesInvoicePortraitBinum()
		{
			base.Load += this.SalesInvoicePortraitBinum_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.isfiscal = 0;
			this.isLeafbrightfiscal = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x002D3F84 File Offset: 0x002D2184
		// (set) Token: 0x06004BB5 RID: 19381 RVA: 0x002D3F8E File Offset: 0x002D218E
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x002D3F97 File Offset: 0x002D2197
		// (set) Token: 0x06004BB7 RID: 19383 RVA: 0x002D3FA1 File Offset: 0x002D21A1
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06004BB8 RID: 19384 RVA: 0x002D3FAA File Offset: 0x002D21AA
		// (set) Token: 0x06004BB9 RID: 19385 RVA: 0x002D3FB4 File Offset: 0x002D21B4
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x002D3FBD File Offset: 0x002D21BD
		// (set) Token: 0x06004BBB RID: 19387 RVA: 0x002D3FC7 File Offset: 0x002D21C7
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06004BBC RID: 19388 RVA: 0x002D3FD0 File Offset: 0x002D21D0
		// (set) Token: 0x06004BBD RID: 19389 RVA: 0x002D3FDA File Offset: 0x002D21DA
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x002D3FE3 File Offset: 0x002D21E3
		// (set) Token: 0x06004BBF RID: 19391 RVA: 0x002D3FED File Offset: 0x002D21ED
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x002D3FF6 File Offset: 0x002D21F6
		// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x002D4000 File Offset: 0x002D2200
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x002D4009 File Offset: 0x002D2209
		// (set) Token: 0x06004BC3 RID: 19395 RVA: 0x002D4013 File Offset: 0x002D2213
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x002D401C File Offset: 0x002D221C
		// (set) Token: 0x06004BC5 RID: 19397 RVA: 0x002D4026 File Offset: 0x002D2226
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x002D402F File Offset: 0x002D222F
		// (set) Token: 0x06004BC7 RID: 19399 RVA: 0x002D4039 File Offset: 0x002D2239
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x002D4042 File Offset: 0x002D2242
		// (set) Token: 0x06004BC9 RID: 19401 RVA: 0x002D404C File Offset: 0x002D224C
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06004BCA RID: 19402 RVA: 0x002D4055 File Offset: 0x002D2255
		// (set) Token: 0x06004BCB RID: 19403 RVA: 0x002D405F File Offset: 0x002D225F
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06004BCC RID: 19404 RVA: 0x002D4068 File Offset: 0x002D2268
		// (set) Token: 0x06004BCD RID: 19405 RVA: 0x002D4072 File Offset: 0x002D2272
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x002D407B File Offset: 0x002D227B
		// (set) Token: 0x06004BCF RID: 19407 RVA: 0x002D4085 File Offset: 0x002D2285
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06004BD0 RID: 19408 RVA: 0x002D408E File Offset: 0x002D228E
		// (set) Token: 0x06004BD1 RID: 19409 RVA: 0x002D4098 File Offset: 0x002D2298
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x002D40A1 File Offset: 0x002D22A1
		// (set) Token: 0x06004BD3 RID: 19411 RVA: 0x002D40AB File Offset: 0x002D22AB
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x002D40B4 File Offset: 0x002D22B4
		// (set) Token: 0x06004BD5 RID: 19413 RVA: 0x002D40BE File Offset: 0x002D22BE
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x002D40C7 File Offset: 0x002D22C7
		// (set) Token: 0x06004BD7 RID: 19415 RVA: 0x002D40D1 File Offset: 0x002D22D1
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x002D40DC File Offset: 0x002D22DC
		private void SalesInvoicePortraitBinum_Load(object sender, EventArgs e)
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
				bool flag5 = Operators.CompareString(this.revmax_sign, "", false) != 0;
				if (flag5)
				{
					this.isfiscal = 1;
				}
				bool flag6 = this.isEltradeESDfiscal == 1;
				if (flag6)
				{
					this.isfiscal = 1;
				}
				ReportParameter reportParameter6 = new ReportParameter("isfiscal", Conversions.ToString(this.isfiscal));
				ReportParameter reportParameter7 = new ReportParameter("ShowFooter", Conversions.ToString(MyProject.Forms.Form1.showfooter));
				ReportParameter reportParameter8 = new ReportParameter("invheader", MyProject.Forms.Form1.InvoiceHeaderText);
				ReportParameter reportParameter9 = new ReportParameter("ShowInvDisc", Conversions.ToString(this.showinvdisc));
				ReportParameter reportParameter10 = new ReportParameter("LeafbrightA4", Conversions.ToString(this.isLeafbrightfiscal));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8, reportParameter9, reportParameter10 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumber, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, this.branch, new int?(MyProject.Forms.Form1.coid), new int?(this.GetInvPayDisplayDetails()));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
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
								int num = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBWaitTime", MyProject.Forms.Form1.Constring)));
								Thread.Sleep(num - 3000);
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
				MessageBox.Show("Error processing report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x002D48F0 File Offset: 0x002D2AF0
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

		// Token: 0x06004BDA RID: 19418 RVA: 0x002D4930 File Offset: 0x002D2B30
		public string FormatInvoiceNumber(int invoiceNum)
		{
			return invoiceNum.ToString("D8");
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x002D4950 File Offset: 0x002D2B50
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x002D4978 File Offset: 0x002D2B78
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

		// Token: 0x06004BDD RID: 19421 RVA: 0x002D4A40 File Offset: 0x002D2C40
		private void PrintPage(object sender, PrintPageEventArgs ev)
		{
			Metafile metafile = new Metafile(this.m_streams[this.m_currentPageIndex]);
			ev.Graphics.DrawImage(metafile, ev.PageBounds);
			ref int ptr = ref this.m_currentPageIndex;
			this.m_currentPageIndex = checked(ptr + 1);
			ev.HasMorePages = this.m_currentPageIndex < this.m_streams.Count;
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x002D4AA0 File Offset: 0x002D2CA0
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

		// Token: 0x06004BDF RID: 19423 RVA: 0x002D4B50 File Offset: 0x002D2D50
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

		// Token: 0x04002153 RID: 8531
		public int invnum;

		// Token: 0x04002154 RID: 8532
		private string _cnn;

		// Token: 0x04002155 RID: 8533
		private PublicFunctions pf;

		// Token: 0x04002156 RID: 8534
		public string revmax_sign;

		// Token: 0x04002157 RID: 8535
		public int reprint;

		// Token: 0x04002158 RID: 8536
		public int isEltradeESDfiscal;

		// Token: 0x04002159 RID: 8537
		public string branch;

		// Token: 0x0400215A RID: 8538
		public int showinvdisc;

		// Token: 0x0400215B RID: 8539
		public int isfiscal;

		// Token: 0x0400215C RID: 8540
		private int isLeafbrightfiscal;

		// Token: 0x0400215D RID: 8541
		private int m_currentPageIndex;

		// Token: 0x0400215E RID: 8542
		private IList<Stream> m_streams;
	}
}
