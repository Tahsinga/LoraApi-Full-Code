using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000218 RID: 536
	[DesignerGenerated]
	public partial class ViewStockPurchases : UserControl
	{
		// Token: 0x06006034 RID: 24628 RVA: 0x0036F3B4 File Offset: 0x0036D5B4
		public ViewStockPurchases()
		{
			base.Load += this.ViewStockPurchases_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.TextToPrint = "";
			this.InitializeComponent();
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06006037 RID: 24631 RVA: 0x0036FED8 File Offset: 0x0036E0D8
		// (set) Token: 0x06006038 RID: 24632 RVA: 0x0036FEE2 File Offset: 0x0036E0E2
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x0036FEEB File Offset: 0x0036E0EB
		// (set) Token: 0x0600603A RID: 24634 RVA: 0x0036FEF5 File Offset: 0x0036E0F5
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x0036FEFE File Offset: 0x0036E0FE
		// (set) Token: 0x0600603C RID: 24636 RVA: 0x0036FF08 File Offset: 0x0036E108
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600603D RID: 24637 RVA: 0x0036FF11 File Offset: 0x0036E111
		// (set) Token: 0x0600603E RID: 24638 RVA: 0x0036FF1B File Offset: 0x0036E11B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x0036FF24 File Offset: 0x0036E124
		// (set) Token: 0x06006040 RID: 24640 RVA: 0x0036FF30 File Offset: 0x0036E130
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x06006041 RID: 24641 RVA: 0x0036FF73 File Offset: 0x0036E173
		// (set) Token: 0x06006042 RID: 24642 RVA: 0x0036FF7D File Offset: 0x0036E17D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x0036FF86 File Offset: 0x0036E186
		// (set) Token: 0x06006044 RID: 24644 RVA: 0x0036FF90 File Offset: 0x0036E190
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x06006045 RID: 24645 RVA: 0x0036FF99 File Offset: 0x0036E199
		// (set) Token: 0x06006046 RID: 24646 RVA: 0x0036FFA4 File Offset: 0x0036E1A4
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x06006047 RID: 24647 RVA: 0x0036FFE7 File Offset: 0x0036E1E7
		// (set) Token: 0x06006048 RID: 24648 RVA: 0x0036FFF1 File Offset: 0x0036E1F1
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06006049 RID: 24649 RVA: 0x0036FFFA File Offset: 0x0036E1FA
		// (set) Token: 0x0600604A RID: 24650 RVA: 0x00370004 File Offset: 0x0036E204
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600604B RID: 24651 RVA: 0x0037000D File Offset: 0x0036E20D
		// (set) Token: 0x0600604C RID: 24652 RVA: 0x00370017 File Offset: 0x0036E217
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600604D RID: 24653 RVA: 0x00370020 File Offset: 0x0036E220
		// (set) Token: 0x0600604E RID: 24654 RVA: 0x0037002A File Offset: 0x0036E22A
		internal virtual BindingSource FetchStockPurchasesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600604F RID: 24655 RVA: 0x00370033 File Offset: 0x0036E233
		// (set) Token: 0x06006050 RID: 24656 RVA: 0x0037003D File Offset: 0x0036E23D
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x00370046 File Offset: 0x0036E246
		// (set) Token: 0x06006052 RID: 24658 RVA: 0x00370050 File Offset: 0x0036E250
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x00370059 File Offset: 0x0036E259
		// (set) Token: 0x06006054 RID: 24660 RVA: 0x00370063 File Offset: 0x0036E263
		internal virtual FetchStockPurchasesTableAdapter FetchStockPurchasesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x0037006C File Offset: 0x0036E26C
		// (set) Token: 0x06006056 RID: 24662 RVA: 0x00370076 File Offset: 0x0036E276
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x0037007F File Offset: 0x0036E27F
		// (set) Token: 0x06006058 RID: 24664 RVA: 0x0037008C File Offset: 0x0036E28C
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x003700CF File Offset: 0x0036E2CF
		// (set) Token: 0x0600605A RID: 24666 RVA: 0x003700DC File Offset: 0x0036E2DC
		internal virtual PrintDocument PrintDocument1
		{
			[CompilerGenerated]
			get
			{
				return this._PrintDocument1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
				PrintDocument printDocument = this._PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage -= printPageEventHandler;
				}
				this._PrintDocument1 = value;
				printDocument = this._PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage += printPageEventHandler;
				}
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x0037011F File Offset: 0x0036E31F
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x00370129 File Offset: 0x0036E329
		internal virtual BindingSource FetchStockPurchasesGroupedTaxBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x00370132 File Offset: 0x0036E332
		// (set) Token: 0x0600605E RID: 24670 RVA: 0x0037013C File Offset: 0x0036E33C
		internal virtual FetchStockPurchasesGroupedTaxTableAdapter FetchStockPurchasesGroupedTaxTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x00370148 File Offset: 0x0036E348
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			int coid = MyProject.Forms.Form1.coid;
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch.DataSource = dataTable;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x00370220 File Offset: 0x0036E420
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.FetchStockPurchasesTableAdapter.Connection = sqlConnection;
				this.FetchStockPurchasesGroupedTaxTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.FetchStockPurchasesTableAdapter.Fill(this.POSDataSet.FetchStockPurchases, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.FetchStockPurchasesGroupedTaxTableAdapter.Fill(this.POSDataSet.FetchStockPurchasesGroupedTax, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x003704D4 File Offset: 0x0036E6D4
		private void ViewStockPurchases_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x00370524 File Offset: 0x0036E724
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.GetBranchDetails();
				this.PrintHeaderQuotation();
				this.ItemsToBePrintedQuotation();
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
				MessageBox.Show("Print job sent to printer.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x003705AC File Offset: 0x0036E7AC
		private void PrintHeaderQuotation()
		{
			this.TextToPrint = "";
			string text = "STOCKS PURCHASED";
			int length = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - length) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				string text3 = this.coname;
				int num = text3.Length;
				string text4 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + text3 + Environment.NewLine;
				bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag)
				{
					text3 = "BP Number: " + this.cobpnum;
					num = text3.Length;
					string text5 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text3 + Environment.NewLine;
				}
				text3 = this.coadd;
				num = text3.Length;
				string text6 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text6 + text3 + Environment.NewLine;
				bool flag2 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag2)
				{
					text3 = "Email: " + this.coemail;
					num = text3.Length;
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text7 + text3 + Environment.NewLine;
				}
				bool flag3 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag3)
				{
					text3 = this.cotel;
					num = text3.Length;
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text3 + Environment.NewLine;
				}
				bool flag4 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag4)
				{
					text3 = this.cotel2 + "  " + this.cotel3;
					num = text3.Length;
					string text9 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text3 + Environment.NewLine;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text3 = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "Purchases from " + this.DTStartdate.Value.ToString("dd-MM-yyyy") + " to " + this.DTEnddate.Value.ToString("dd-M-yyyy");
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
			}
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x0037094C File Offset: 0x0036EB4C
		private DataTable GetPurchases(int startdate, int enddate, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchStockPurchases";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x003709F8 File Offset: 0x0036EBF8
		private void ItemsToBePrintedQuotation()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			decimal num = 0m;
			double num2 = 0.0;
			DataTable purchases = this.GetPurchases(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd")), Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd")), MyProject.Forms.Form1.coid, this.cboBranch.Text);
			string text3;
			try
			{
				foreach (object obj in purchases.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text = Conversions.ToString(dataRow["Description_1"]);
					string text2 = Conversions.ToString(dataRow["Product_Code"]);
					num = Conversions.ToDecimal(dataRow["Quantity"]);
					num2 += Convert.ToDouble(num);
					checked
					{
						int num3 = (int)Math.Round(Conversion.Val(text.Length));
						bool flag = num3 >= 34;
						if (flag)
						{
							text = text.Substring(0, 33);
						}
						else
						{
							int num4 = num3;
							int num5 = 34 - num4;
							text = text.PadRight(num5);
						}
						int length = text.Length;
						text3 = text2 + ": " + text;
						string text4 = Conversions.ToString(text3.Length);
						string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine;
						text3 = "     " + num.ToString();
						string text6 = Conversions.ToString(text3.Length);
						string text7 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
					}
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
			text3 = "TOTAL NUMBER OF ITEMS PURCHASED: " + Conversions.ToString(num2);
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x00370C90 File Offset: 0x0036EE90
		private void GetBranchDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				try
				{
					this.coname = dataRow["CompanyName"].ToString();
					this.coadd = dataRow["Address"].ToString();
					this.cotel = dataRow["Tel"].ToString();
					this.cotel2 = dataRow["Tel2"].ToString();
					this.cotel3 = dataRow["Tel3"].ToString();
					this.coemail = dataRow["Email"].ToString();
					this.cobpnum = dataRow["BPNumber"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x00370E0C File Offset: 0x0036F00C
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			int num3 = 0;
			int num4 = 0;
			Font font = new Font("Times New Roman", 10f, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			checked
			{
				int num9 = (int)Math.Round(Math.Round((double)num5 / 1.0));
				Rectangle rectangle = new Rectangle(num7, num8, num6, num5);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				e.Graphics.MeasureString(this.TextToPrint, font, e.MarginBounds.Size, stringFormat, out num3, out num4);
				num4 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				using (StringReader stringReader = new StringReader(this.TextToPrint))
				{
					while (i < num4)
					{
						text = stringReader.ReadLine();
						bool flag = stringReader.Peek() == -1;
						if (flag)
						{
							break;
						}
						float num10 = unchecked(num2 + (float)i * font.GetHeight(e.Graphics));
						e.Graphics.DrawString(text, font, Brushes.Black, num, num10, new StringFormat());
						i++;
					}
				}
				bool flag2 = (Operators.CompareString(text, "", false) == 0) | Information.IsNothing(text);
				if (flag2)
				{
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
					this.TextToPrint = this.TextToPrint.Substring(num3);
				}
			}
		}

		// Token: 0x04002A5E RID: 10846
		private string _cnn;

		// Token: 0x04002A5F RID: 10847
		private string TextToPrint;

		// Token: 0x04002A60 RID: 10848
		private string coname;

		// Token: 0x04002A61 RID: 10849
		private string coadd;

		// Token: 0x04002A62 RID: 10850
		private string cotel;

		// Token: 0x04002A63 RID: 10851
		private string coemail;

		// Token: 0x04002A64 RID: 10852
		private string cobpnum;

		// Token: 0x04002A65 RID: 10853
		private string cotel2;

		// Token: 0x04002A66 RID: 10854
		private string cotel3;
	}
}
