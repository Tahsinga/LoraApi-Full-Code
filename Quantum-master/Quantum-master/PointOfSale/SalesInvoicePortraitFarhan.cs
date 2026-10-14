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
	// Token: 0x020001A9 RID: 425
	[DesignerGenerated]
	public partial class SalesInvoicePortraitFarhan : Form
	{
		// Token: 0x06004C0E RID: 19470 RVA: 0x002D5E8C File Offset: 0x002D408C
		public SalesInvoicePortraitFarhan()
		{
			base.Load += this.SalesInvoicePortraitFarhan_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.isfiscal = 0;
			this.isLeafbrightfiscal = 0;
			this.hidetax = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x002D6593 File Offset: 0x002D4793
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x002D659D File Offset: 0x002D479D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x002D65A6 File Offset: 0x002D47A6
		// (set) Token: 0x06004C14 RID: 19476 RVA: 0x002D65B0 File Offset: 0x002D47B0
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x002D65B9 File Offset: 0x002D47B9
		// (set) Token: 0x06004C16 RID: 19478 RVA: 0x002D65C3 File Offset: 0x002D47C3
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x002D65CC File Offset: 0x002D47CC
		// (set) Token: 0x06004C18 RID: 19480 RVA: 0x002D65D6 File Offset: 0x002D47D6
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x002D65DF File Offset: 0x002D47DF
		// (set) Token: 0x06004C1A RID: 19482 RVA: 0x002D65E9 File Offset: 0x002D47E9
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x002D65F2 File Offset: 0x002D47F2
		// (set) Token: 0x06004C1C RID: 19484 RVA: 0x002D65FC File Offset: 0x002D47FC
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x002D6605 File Offset: 0x002D4805
		// (set) Token: 0x06004C1E RID: 19486 RVA: 0x002D660F File Offset: 0x002D480F
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x002D6618 File Offset: 0x002D4818
		// (set) Token: 0x06004C20 RID: 19488 RVA: 0x002D6622 File Offset: 0x002D4822
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x002D662B File Offset: 0x002D482B
		// (set) Token: 0x06004C22 RID: 19490 RVA: 0x002D6635 File Offset: 0x002D4835
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x002D663E File Offset: 0x002D483E
		// (set) Token: 0x06004C24 RID: 19492 RVA: 0x002D6648 File Offset: 0x002D4848
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x002D6651 File Offset: 0x002D4851
		// (set) Token: 0x06004C26 RID: 19494 RVA: 0x002D665B File Offset: 0x002D485B
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x002D6664 File Offset: 0x002D4864
		// (set) Token: 0x06004C28 RID: 19496 RVA: 0x002D666E File Offset: 0x002D486E
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06004C29 RID: 19497 RVA: 0x002D6677 File Offset: 0x002D4877
		// (set) Token: 0x06004C2A RID: 19498 RVA: 0x002D6681 File Offset: 0x002D4881
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06004C2B RID: 19499 RVA: 0x002D668A File Offset: 0x002D488A
		// (set) Token: 0x06004C2C RID: 19500 RVA: 0x002D6694 File Offset: 0x002D4894
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x002D669D File Offset: 0x002D489D
		// (set) Token: 0x06004C2E RID: 19502 RVA: 0x002D66A7 File Offset: 0x002D48A7
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x002D66B0 File Offset: 0x002D48B0
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x002D66BA File Offset: 0x002D48BA
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x002D66C3 File Offset: 0x002D48C3
		// (set) Token: 0x06004C32 RID: 19506 RVA: 0x002D66CD File Offset: 0x002D48CD
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06004C33 RID: 19507 RVA: 0x002D66D6 File Offset: 0x002D48D6
		// (set) Token: 0x06004C34 RID: 19508 RVA: 0x002D66E0 File Offset: 0x002D48E0
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x002D66EC File Offset: 0x002D48EC
		private void SalesInvoicePortraitFarhan_Load(object sender, EventArgs e)
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
				ReportParameter reportParameter11 = new ReportParameter("hidetax", Conversions.ToString(this.hidetax));
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

		// Token: 0x06004C36 RID: 19510 RVA: 0x002D6F1C File Offset: 0x002D511C
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

		// Token: 0x06004C37 RID: 19511 RVA: 0x002D6F5C File Offset: 0x002D515C
		public string FormatInvoiceNumber(int invoiceNum)
		{
			return invoiceNum.ToString("D8");
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x002D6F7C File Offset: 0x002D517C
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x002D6FA4 File Offset: 0x002D51A4
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

		// Token: 0x06004C3A RID: 19514 RVA: 0x002D706C File Offset: 0x002D526C
		private void PrintPage(object sender, PrintPageEventArgs ev)
		{
			Metafile metafile = new Metafile(this.m_streams[this.m_currentPageIndex]);
			ev.Graphics.DrawImage(metafile, ev.PageBounds);
			ref int ptr = ref this.m_currentPageIndex;
			this.m_currentPageIndex = checked(ptr + 1);
			ev.HasMorePages = this.m_currentPageIndex < this.m_streams.Count;
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x002D70CC File Offset: 0x002D52CC
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

		// Token: 0x06004C3C RID: 19516 RVA: 0x002D717C File Offset: 0x002D537C
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

		// Token: 0x04002191 RID: 8593
		public int invnum;

		// Token: 0x04002192 RID: 8594
		private string _cnn;

		// Token: 0x04002193 RID: 8595
		private PublicFunctions pf;

		// Token: 0x04002194 RID: 8596
		public string revmax_sign;

		// Token: 0x04002195 RID: 8597
		public int reprint;

		// Token: 0x04002196 RID: 8598
		public int isEltradeESDfiscal;

		// Token: 0x04002197 RID: 8599
		public string branch;

		// Token: 0x04002198 RID: 8600
		public int showinvdisc;

		// Token: 0x04002199 RID: 8601
		public int isfiscal;

		// Token: 0x0400219A RID: 8602
		private int isLeafbrightfiscal;

		// Token: 0x0400219B RID: 8603
		private int m_currentPageIndex;

		// Token: 0x0400219C RID: 8604
		private IList<Stream> m_streams;

		// Token: 0x0400219D RID: 8605
		public int hidetax;
	}
}
