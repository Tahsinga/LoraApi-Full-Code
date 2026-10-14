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
	// Token: 0x02000219 RID: 537
	[DesignerGenerated]
	public partial class ViewStockTransfers : UserControl
	{
		// Token: 0x06006069 RID: 24681 RVA: 0x00370FD8 File Offset: 0x0036F1D8
		public ViewStockTransfers()
		{
			base.Load += this.ViewStockTransfers_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.TextToPrint = "";
			this.InitializeComponent();
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x0600606C RID: 24684 RVA: 0x0037207F File Offset: 0x0037027F
		// (set) Token: 0x0600606D RID: 24685 RVA: 0x00372089 File Offset: 0x00370289
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x00372092 File Offset: 0x00370292
		// (set) Token: 0x0600606F RID: 24687 RVA: 0x0037209C File Offset: 0x0037029C
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

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x003720DF File Offset: 0x003702DF
		// (set) Token: 0x06006071 RID: 24689 RVA: 0x003720E9 File Offset: 0x003702E9
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x003720F2 File Offset: 0x003702F2
		// (set) Token: 0x06006073 RID: 24691 RVA: 0x003720FC File Offset: 0x003702FC
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x06006074 RID: 24692 RVA: 0x00372105 File Offset: 0x00370305
		// (set) Token: 0x06006075 RID: 24693 RVA: 0x0037210F File Offset: 0x0037030F
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x06006076 RID: 24694 RVA: 0x00372118 File Offset: 0x00370318
		// (set) Token: 0x06006077 RID: 24695 RVA: 0x00372122 File Offset: 0x00370322
		internal virtual ComboBox cboTransfers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x0037212B File Offset: 0x0037032B
		// (set) Token: 0x06006079 RID: 24697 RVA: 0x00372135 File Offset: 0x00370335
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x0037213E File Offset: 0x0037033E
		// (set) Token: 0x0600607B RID: 24699 RVA: 0x00372148 File Offset: 0x00370348
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x00372151 File Offset: 0x00370351
		// (set) Token: 0x0600607D RID: 24701 RVA: 0x0037215C File Offset: 0x0037035C
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600607E RID: 24702 RVA: 0x0037219F File Offset: 0x0037039F
		// (set) Token: 0x0600607F RID: 24703 RVA: 0x003721AC File Offset: 0x003703AC
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

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06006080 RID: 24704 RVA: 0x003721EF File Offset: 0x003703EF
		// (set) Token: 0x06006081 RID: 24705 RVA: 0x003721F9 File Offset: 0x003703F9
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06006082 RID: 24706 RVA: 0x00372202 File Offset: 0x00370402
		// (set) Token: 0x06006083 RID: 24707 RVA: 0x0037220C File Offset: 0x0037040C
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x06006084 RID: 24708 RVA: 0x00372215 File Offset: 0x00370415
		// (set) Token: 0x06006085 RID: 24709 RVA: 0x0037221F File Offset: 0x0037041F
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x06006086 RID: 24710 RVA: 0x00372228 File Offset: 0x00370428
		// (set) Token: 0x06006087 RID: 24711 RVA: 0x00372232 File Offset: 0x00370432
		internal virtual BindingSource FetchTransferDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06006088 RID: 24712 RVA: 0x0037223B File Offset: 0x0037043B
		// (set) Token: 0x06006089 RID: 24713 RVA: 0x00372245 File Offset: 0x00370445
		internal virtual BindingSource FetchBranchToforTransferBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600608A RID: 24714 RVA: 0x0037224E File Offset: 0x0037044E
		// (set) Token: 0x0600608B RID: 24715 RVA: 0x00372258 File Offset: 0x00370458
		internal virtual BindingSource FetchBranchFromforTransferBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x00372261 File Offset: 0x00370461
		// (set) Token: 0x0600608D RID: 24717 RVA: 0x0037226B File Offset: 0x0037046B
		internal virtual BindingSource FetchTransferDetailsToBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600608E RID: 24718 RVA: 0x00372274 File Offset: 0x00370474
		// (set) Token: 0x0600608F RID: 24719 RVA: 0x0037227E File Offset: 0x0037047E
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x06006090 RID: 24720 RVA: 0x00372287 File Offset: 0x00370487
		// (set) Token: 0x06006091 RID: 24721 RVA: 0x00372291 File Offset: 0x00370491
		internal virtual FetchTransferDetailsTableAdapter FetchTransferDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06006092 RID: 24722 RVA: 0x0037229A File Offset: 0x0037049A
		// (set) Token: 0x06006093 RID: 24723 RVA: 0x003722A4 File Offset: 0x003704A4
		internal virtual FetchBranchToforTransferTableAdapter FetchBranchToforTransferTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06006094 RID: 24724 RVA: 0x003722AD File Offset: 0x003704AD
		// (set) Token: 0x06006095 RID: 24725 RVA: 0x003722B7 File Offset: 0x003704B7
		internal virtual FetchBranchFromforTransferTableAdapter FetchBranchFromforTransferTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06006096 RID: 24726 RVA: 0x003722C0 File Offset: 0x003704C0
		// (set) Token: 0x06006097 RID: 24727 RVA: 0x003722CA File Offset: 0x003704CA
		internal virtual FetchTransferDetailsToTableAdapter FetchTransferDetailsToTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06006098 RID: 24728 RVA: 0x003722D3 File Offset: 0x003704D3
		// (set) Token: 0x06006099 RID: 24729 RVA: 0x003722DD File Offset: 0x003704DD
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x003722E6 File Offset: 0x003704E6
		// (set) Token: 0x0600609B RID: 24731 RVA: 0x003722F0 File Offset: 0x003704F0
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600609C RID: 24732 RVA: 0x00372333 File Offset: 0x00370533
		// (set) Token: 0x0600609D RID: 24733 RVA: 0x00372340 File Offset: 0x00370540
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

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600609E RID: 24734 RVA: 0x00372383 File Offset: 0x00370583
		// (set) Token: 0x0600609F RID: 24735 RVA: 0x0037238D File Offset: 0x0037058D
		internal virtual TextBox txtFontSize
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x060060A0 RID: 24736 RVA: 0x00372396 File Offset: 0x00370596
		// (set) Token: 0x060060A1 RID: 24737 RVA: 0x003723A0 File Offset: 0x003705A0
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x003723A9 File Offset: 0x003705A9
		// (set) Token: 0x060060A3 RID: 24739 RVA: 0x003723B3 File Offset: 0x003705B3
		internal virtual ComboBox cboPrinters
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x060060A4 RID: 24740 RVA: 0x003723BC File Offset: 0x003705BC
		// (set) Token: 0x060060A5 RID: 24741 RVA: 0x003723C6 File Offset: 0x003705C6
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x060060A6 RID: 24742 RVA: 0x003723CF File Offset: 0x003705CF
		// (set) Token: 0x060060A7 RID: 24743 RVA: 0x003723D9 File Offset: 0x003705D9
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x003723E2 File Offset: 0x003705E2
		// (set) Token: 0x060060A9 RID: 24745 RVA: 0x003723EC File Offset: 0x003705EC
		internal virtual CheckBox chkShowCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x003723F8 File Offset: 0x003705F8
		private void RunReport(int invoicenumber)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.FetchBranchFromforTransferTableAdapter.Connection = sqlConnection;
			this.FetchBranchToforTransferTableAdapter.Connection = sqlConnection;
			this.FetchTransferDetailsTableAdapter.Connection = sqlConnection;
			this.FetchTransferDetailsToTableAdapter.Connection = sqlConnection;
			ReportParameter reportParameter = new ReportParameter("invoicenum", Conversions.ToString(invoicenumber));
			ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
			ReportParameter reportParameter3 = new ReportParameter("IsWarehouse", Conversions.ToString(MyProject.Forms.Form1.IsWarehouse));
			ReportParameter reportParameter4 = new ReportParameter("showcost", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkShowCost.Checked, 1, 0))));
			ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.FetchBranchFromforTransferTableAdapter.Fill(this.POSDataSet.FetchBranchFromforTransfer, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
			this.FetchBranchToforTransferTableAdapter.Fill(this.POSDataSet.FetchBranchToforTransfer, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
			this.FetchTransferDetailsTableAdapter.Fill(this.POSDataSet.FetchTransferDetails, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
			this.FetchTransferDetailsToTableAdapter.Fill(this.POSDataSet.FetchTransferDetailsTo, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x003725F0 File Offset: 0x003707F0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.RunReport(Conversions.ToInteger(this.cboTransfers.SelectedValue));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00372650 File Offset: 0x00370850
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadTransfers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading transfer list. Detail: " + ex.Message);
			}
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x003726A0 File Offset: 0x003708A0
		private void LoadTransfers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectTransfers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("startdate", Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd")));
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboTransfers.DataSource = dataTable;
			this.cboTransfers.ValueMember = "InvoiceNum";
			this.cboTransfers.DisplayMember = "ref";
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x003727A8 File Offset: 0x003709A8
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboPrinters.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please select the printer first.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cboTransfers.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please load the transfers for the period first.");
						this.Button1.Focus();
					}
					else
					{
						this.GetBranchDetails();
						this.PrintHeaderQuotation();
						this.ItemsToBePrintedQuotation();
						this.stringToRead = new StringReader(this.TextToPrint);
						StandardPrintController standardPrintController = new StandardPrintController();
						this.PrintDocument1.PrintController = standardPrintController;
						this.PrintDocument1.PrinterSettings.PrinterName = this.cboPrinters.Text;
						this.PrintDocument1.Print();
						MessageBox.Show("Print job sent to printer.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x003728C4 File Offset: 0x00370AC4
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

		// Token: 0x060060B1 RID: 24753 RVA: 0x00372A40 File Offset: 0x00370C40
		private void PrintHeaderQuotation()
		{
			this.TextToPrint = "";
			string text = "STOCKS TRANSFERED";
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
				text3 = "Transfers from " + this.DTStartDate.Value.ToString("dd-MM-yyyy") + " to " + this.DTEndDate.Value.ToString("dd-M-yyyy");
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "Branch From: " + this.GetBranchFrom(MyProject.Forms.Form1.coid, Conversions.ToInteger(this.cboTransfers.SelectedValue));
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
				text3 = "Branch To: " + this.GetBranchTo(MyProject.Forms.Form1.coid, Conversions.ToInteger(this.cboTransfers.SelectedValue));
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "REF: " + this.cboTransfers.Text;
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00372EC4 File Offset: 0x003710C4
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
			decimal num3 = 0m;
			DataTable transfers = this.GetTransfers(MyProject.Forms.Form1.coid, Conversions.ToInteger(this.cboTransfers.SelectedValue));
			object[] array2;
			bool[] array6;
			object obj3;
			string text5;
			try
			{
				foreach (object obj in transfers.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text = Conversions.ToString(dataRow["ProductDesc"]);
					string text2 = Conversions.ToString(dataRow["ProductCode"]);
					num = Conversions.ToDecimal(dataRow["Quantity"]);
					string text3 = Conversions.ToString(dataRow["uom"]);
					bool flag = Operators.CompareString(text3, "EA", false) == 0;
					if (flag)
					{
						num = Math.Round(num, 0);
					}
					object obj2 = null;
					Type typeFromHandle = typeof(Math);
					string text4 = "Round";
					DataRow dataRow2;
					object[] array = (array2 = new object[]
					{
						(dataRow2 = dataRow)["Cost"],
						2,
						MidpointRounding.AwayFromZero
					});
					string[] array3 = null;
					Type[] array4 = null;
					bool[] array5 = new bool[3];
					array5[0] = true;
					array6 = array5;
					obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text4, array, array3, array4, array5);
					if (array6[0])
					{
						dataRow2["Cost"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
					}
					num3 = Conversions.ToDecimal(obj3);
					num2 += Convert.ToDouble(num);
					checked
					{
						int num4 = (int)Math.Round(Conversion.Val(text.Length));
						bool flag2 = num4 >= 34;
						if (flag2)
						{
							text = text.Substring(0, 33);
						}
						else
						{
							int num5 = num4;
							int num6 = 34 - num5;
							text = text.PadRight(num6);
						}
						int length = text.Length;
						text5 = text2 + ": " + text;
						string text6 = Conversions.ToString(text5.Length);
						string text7 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text6)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text5 + Environment.NewLine;
						string text8 = MyProject.Forms.Form1.basecurrency + num3.ToString();
						text5 = "X     " + num.ToString() + "    " + text8.PadLeft(18, ' ');
						string text9 = Conversions.ToString(text5.Length);
						string text10 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text6)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text5 + Environment.NewLine + Environment.NewLine;
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
			object obj4 = RuntimeHelpers.GetObjectValue(transfers.Compute("SUM(Summation)", ""));
			string text11 = "TOTAL VALUE OF TRANSFER: ";
			string basecurrency = MyProject.Forms.Form1.basecurrency;
			object obj5 = null;
			Type typeFromHandle2 = typeof(Math);
			string text12 = "Round";
			object[] array7 = (array2 = new object[] { obj4, 2 });
			string[] array8 = null;
			Type[] array9 = null;
			bool[] array10 = new bool[2];
			array10[0] = true;
			array6 = array10;
			obj3 = NewLateBinding.LateGet(obj5, typeFromHandle2, text12, array7, array8, array9, array10);
			if (array6[0])
			{
				obj4 = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			text5 = text11 + basecurrency + obj3.ToString() + Environment.NewLine;
			text5 = text5 + "TOTAL ITEMS TRANSFERED: " + Conversions.ToString(num2);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text5 + Environment.NewLine;
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x003732B4 File Offset: 0x003714B4
		private DataTable GetTransfers(int coid, int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchTransferDetailsTo";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00373334 File Offset: 0x00371534
		private string GetBranchFrom(int coid, int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranchFromforTransfer";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToString(dataRow["BranchFrom"]);
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x003733D4 File Offset: 0x003715D4
		private string GetBranchTo(int coid, int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranchToforTransfer";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToString(dataRow["BranchTo"]);
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00373474 File Offset: 0x00371674
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			Font font = new Font("Times New Roman", (float)Conversions.ToInteger(this.txtFontSize.Text), FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			checked
			{
				int num7 = (int)Math.Round(Math.Round((double)num3 / 1.0));
				Rectangle rectangle = new Rectangle(num5, num6, num4, num3);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				int num8 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				while (i < num8)
				{
					text = this.stringToRead.ReadLine();
					bool flag = text == null;
					if (flag)
					{
						break;
					}
					float num9 = unchecked(num2 + (float)i * font.GetHeight(e.Graphics));
					e.Graphics.DrawString(text, font, Brushes.Black, num, num9, new StringFormat());
					i++;
				}
				bool flag2 = text == null;
				if (flag2)
				{
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
				}
			}
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x003735C8 File Offset: 0x003717C8
		private void loadInstalledPrinters()
		{
			this.cboPrinters.Items.Clear();
			try
			{
				foreach (object obj in PrinterSettings.InstalledPrinters)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					this.cboPrinters.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
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
			this.cboPrinters.SelectedIndex = this.cboPrinters.FindStringExact(MyProject.Forms.Form1.defaultReceiptPrinter);
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x00373670 File Offset: 0x00371870
		private void ViewStockTransfers_Load(object sender, EventArgs e)
		{
			try
			{
				this.loadInstalledPrinters();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error installing. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002A87 RID: 10887
		private string _cnn;

		// Token: 0x04002A88 RID: 10888
		private string TextToPrint;

		// Token: 0x04002A89 RID: 10889
		private string coname;

		// Token: 0x04002A8A RID: 10890
		private string coadd;

		// Token: 0x04002A8B RID: 10891
		private string cotel;

		// Token: 0x04002A8C RID: 10892
		private string coemail;

		// Token: 0x04002A8D RID: 10893
		private string cobpnum;

		// Token: 0x04002A8E RID: 10894
		private string cotel2;

		// Token: 0x04002A8F RID: 10895
		private string cotel3;

		// Token: 0x04002A90 RID: 10896
		private StringReader stringToRead;
	}
}
