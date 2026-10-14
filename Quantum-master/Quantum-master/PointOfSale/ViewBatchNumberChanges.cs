using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x0200020B RID: 523
	[DesignerGenerated]
	public partial class ViewBatchNumberChanges : Form
	{
		// Token: 0x06005E09 RID: 24073 RVA: 0x0035DBF8 File Offset: 0x0035BDF8
		public ViewBatchNumberChanges()
		{
			base.Load += this.ViewBatchNumberChanges_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06005E0C RID: 24076 RVA: 0x0035E3E9 File Offset: 0x0035C5E9
		// (set) Token: 0x06005E0D RID: 24077 RVA: 0x0035E3F3 File Offset: 0x0035C5F3
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06005E0E RID: 24078 RVA: 0x0035E3FC File Offset: 0x0035C5FC
		// (set) Token: 0x06005E0F RID: 24079 RVA: 0x0035E406 File Offset: 0x0035C606
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06005E10 RID: 24080 RVA: 0x0035E40F File Offset: 0x0035C60F
		// (set) Token: 0x06005E11 RID: 24081 RVA: 0x0035E419 File Offset: 0x0035C619
		internal virtual BindingSource ViewBatchNumberChangesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06005E12 RID: 24082 RVA: 0x0035E422 File Offset: 0x0035C622
		// (set) Token: 0x06005E13 RID: 24083 RVA: 0x0035E42C File Offset: 0x0035C62C
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06005E14 RID: 24084 RVA: 0x0035E435 File Offset: 0x0035C635
		// (set) Token: 0x06005E15 RID: 24085 RVA: 0x0035E43F File Offset: 0x0035C63F
		internal virtual ViewBatchNumberChangesTableAdapter ViewBatchNumberChangesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06005E16 RID: 24086 RVA: 0x0035E448 File Offset: 0x0035C648
		// (set) Token: 0x06005E17 RID: 24087 RVA: 0x0035E452 File Offset: 0x0035C652
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06005E18 RID: 24088 RVA: 0x0035E45B File Offset: 0x0035C65B
		// (set) Token: 0x06005E19 RID: 24089 RVA: 0x0035E465 File Offset: 0x0035C665
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06005E1A RID: 24090 RVA: 0x0035E46E File Offset: 0x0035C66E
		// (set) Token: 0x06005E1B RID: 24091 RVA: 0x0035E478 File Offset: 0x0035C678
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06005E1C RID: 24092 RVA: 0x0035E481 File Offset: 0x0035C681
		// (set) Token: 0x06005E1D RID: 24093 RVA: 0x0035E48B File Offset: 0x0035C68B
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06005E1E RID: 24094 RVA: 0x0035E494 File Offset: 0x0035C694
		// (set) Token: 0x06005E1F RID: 24095 RVA: 0x0035E49E File Offset: 0x0035C69E
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06005E20 RID: 24096 RVA: 0x0035E4A7 File Offset: 0x0035C6A7
		// (set) Token: 0x06005E21 RID: 24097 RVA: 0x0035E4B4 File Offset: 0x0035C6B4
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

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06005E22 RID: 24098 RVA: 0x0035E4F7 File Offset: 0x0035C6F7
		// (set) Token: 0x06005E23 RID: 24099 RVA: 0x0035E501 File Offset: 0x0035C701
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06005E24 RID: 24100 RVA: 0x0035E50A File Offset: 0x0035C70A
		// (set) Token: 0x06005E25 RID: 24101 RVA: 0x0035E514 File Offset: 0x0035C714
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06005E26 RID: 24102 RVA: 0x0035E51D File Offset: 0x0035C71D
		// (set) Token: 0x06005E27 RID: 24103 RVA: 0x0035E527 File Offset: 0x0035C727
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06005E28 RID: 24104 RVA: 0x0035E530 File Offset: 0x0035C730
		// (set) Token: 0x06005E29 RID: 24105 RVA: 0x0035E53A File Offset: 0x0035C73A
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x0035E544 File Offset: 0x0035C744
		private void ViewBatchNumberChanges_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0035E594 File Offset: 0x0035C794
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch.DataSource = dataTable;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x0035E634 File Offset: 0x0035C834
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ViewBatchNumberChangesTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ViewBatchNumberChangesTableAdapter.Fill(this.POSDataSet.ViewBatchNumberChanges, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002931 RID: 10545
		private string _cnn;
	}
}
