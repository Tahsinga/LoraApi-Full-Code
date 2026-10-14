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
	// Token: 0x02000038 RID: 56
	[DesignerGenerated]
	public partial class CustomerList : UserControl
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x00079DC8 File Offset: 0x00077FC8
		public CustomerList()
		{
			base.Load += this.CustomerList_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0007A469 File Offset: 0x00078669
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x0007A473 File Offset: 0x00078673
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0007A47C File Offset: 0x0007867C
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x0007A486 File Offset: 0x00078686
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0007A48F File Offset: 0x0007868F
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x0007A49C File Offset: 0x0007869C
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0007A4DF File Offset: 0x000786DF
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x0007A4EC File Offset: 0x000786EC
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0007A52F File Offset: 0x0007872F
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x0007A539 File Offset: 0x00078739
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0007A542 File Offset: 0x00078742
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x0007A54C File Offset: 0x0007874C
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0007A555 File Offset: 0x00078755
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x0007A55F File Offset: 0x0007875F
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0007A568 File Offset: 0x00078768
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x0007A572 File Offset: 0x00078772
		internal virtual BindingSource FetchAllCustomersBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0007A57B File Offset: 0x0007877B
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x0007A585 File Offset: 0x00078785
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0007A58E File Offset: 0x0007878E
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0007A598 File Offset: 0x00078798
		internal virtual FetchAllCustomersTableAdapter FetchAllCustomersTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0007A5A1 File Offset: 0x000787A1
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x0007A5AB File Offset: 0x000787AB
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0007A5B4 File Offset: 0x000787B4
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x0007A5BE File Offset: 0x000787BE
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0007A5C8 File Offset: 0x000787C8
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

		// Token: 0x06000C50 RID: 3152 RVA: 0x0007A668 File Offset: 0x00078868
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.FetchAllCustomersTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter2 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.FetchAllCustomersTableAdapter.Fill(this.POSDataSet.FetchAllCustomers, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0007A790 File Offset: 0x00078990
		private void CustomerList_Load(object sender, EventArgs e)
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

		// Token: 0x040005D3 RID: 1491
		private string _cnn;
	}
}
