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
	// Token: 0x02000039 RID: 57
	[DesignerGenerated]
	public partial class CustomerListBySales : UserControl
	{
		// Token: 0x06000C53 RID: 3155 RVA: 0x0007A7E0 File Offset: 0x000789E0
		public CustomerListBySales()
		{
			base.Load += this.CustomerListBySales_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0007B073 File Offset: 0x00079273
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0007B07D File Offset: 0x0007927D
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0007B086 File Offset: 0x00079286
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0007B090 File Offset: 0x00079290
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0007B099 File Offset: 0x00079299
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0007B0A4 File Offset: 0x000792A4
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

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0007B0E7 File Offset: 0x000792E7
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0007B0F4 File Offset: 0x000792F4
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

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0007B137 File Offset: 0x00079337
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0007B141 File Offset: 0x00079341
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0007B14A File Offset: 0x0007934A
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0007B154 File Offset: 0x00079354
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0007B15D File Offset: 0x0007935D
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x0007B167 File Offset: 0x00079367
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0007B170 File Offset: 0x00079370
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x0007B17A File Offset: 0x0007937A
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0007B183 File Offset: 0x00079383
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0007B18D File Offset: 0x0007938D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0007B196 File Offset: 0x00079396
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x0007B1A0 File Offset: 0x000793A0
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0007B1A9 File Offset: 0x000793A9
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x0007B1B3 File Offset: 0x000793B3
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0007B1BC File Offset: 0x000793BC
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0007B1C6 File Offset: 0x000793C6
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x0007B1CF File Offset: 0x000793CF
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x0007B1D9 File Offset: 0x000793D9
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0007B1E2 File Offset: 0x000793E2
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x0007B1EC File Offset: 0x000793EC
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0007B1F5 File Offset: 0x000793F5
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x0007B1FF File Offset: 0x000793FF
		internal virtual BindingSource SelectCustomersBySales2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0007B208 File Offset: 0x00079408
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0007B212 File Offset: 0x00079412
		internal virtual SelectCustomersBySales2TableAdapter SelectCustomersBySales2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0007B21C File Offset: 0x0007941C
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

		// Token: 0x06000C77 RID: 3191 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0007B2BC File Offset: 0x000794BC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.SelectCustomersBySales2TableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter5, reportParameter6, reportParameter, reportParameter3, reportParameter2, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.SelectCustomersBySales2TableAdapter.Fill(this.POSDataSet.SelectCustomersBySales2, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0007B4E8 File Offset: 0x000796E8
		private void CustomerListBySales_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x040005E5 RID: 1509
		private string _cnn;
	}
}
