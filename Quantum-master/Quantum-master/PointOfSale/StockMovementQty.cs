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
	// Token: 0x020001EB RID: 491
	[DesignerGenerated]
	public partial class StockMovementQty : UserControl
	{
		// Token: 0x060056B3 RID: 22195 RVA: 0x00320740 File Offset: 0x0031E940
		public StockMovementQty()
		{
			base.Load += this.StockMovementQty_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x060056B6 RID: 22198 RVA: 0x00320FD5 File Offset: 0x0031F1D5
		// (set) Token: 0x060056B7 RID: 22199 RVA: 0x00320FDF File Offset: 0x0031F1DF
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x060056B8 RID: 22200 RVA: 0x00320FE8 File Offset: 0x0031F1E8
		// (set) Token: 0x060056B9 RID: 22201 RVA: 0x00320FF4 File Offset: 0x0031F1F4
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

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x060056BA RID: 22202 RVA: 0x00321037 File Offset: 0x0031F237
		// (set) Token: 0x060056BB RID: 22203 RVA: 0x00321041 File Offset: 0x0031F241
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x0032104A File Offset: 0x0031F24A
		// (set) Token: 0x060056BD RID: 22205 RVA: 0x00321054 File Offset: 0x0031F254
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x0032105D File Offset: 0x0031F25D
		// (set) Token: 0x060056BF RID: 22207 RVA: 0x00321068 File Offset: 0x0031F268
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

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x003210AB File Offset: 0x0031F2AB
		// (set) Token: 0x060056C1 RID: 22209 RVA: 0x003210B5 File Offset: 0x0031F2B5
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x060056C2 RID: 22210 RVA: 0x003210BE File Offset: 0x0031F2BE
		// (set) Token: 0x060056C3 RID: 22211 RVA: 0x003210C8 File Offset: 0x0031F2C8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x060056C4 RID: 22212 RVA: 0x003210D1 File Offset: 0x0031F2D1
		// (set) Token: 0x060056C5 RID: 22213 RVA: 0x003210DB File Offset: 0x0031F2DB
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x003210E4 File Offset: 0x0031F2E4
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x003210EE File Offset: 0x0031F2EE
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x003210F7 File Offset: 0x0031F2F7
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x00321101 File Offset: 0x0031F301
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x060056CA RID: 22218 RVA: 0x0032110A File Offset: 0x0031F30A
		// (set) Token: 0x060056CB RID: 22219 RVA: 0x00321114 File Offset: 0x0031F314
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x0032111D File Offset: 0x0031F31D
		// (set) Token: 0x060056CD RID: 22221 RVA: 0x00321127 File Offset: 0x0031F327
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x00321130 File Offset: 0x0031F330
		// (set) Token: 0x060056CF RID: 22223 RVA: 0x0032113A File Offset: 0x0031F33A
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x060056D0 RID: 22224 RVA: 0x00321143 File Offset: 0x0031F343
		// (set) Token: 0x060056D1 RID: 22225 RVA: 0x0032114D File Offset: 0x0031F34D
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x00321156 File Offset: 0x0031F356
		// (set) Token: 0x060056D3 RID: 22227 RVA: 0x00321160 File Offset: 0x0031F360
		internal virtual BindingSource StockMovementByQtyPerBranchBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x060056D4 RID: 22228 RVA: 0x00321169 File Offset: 0x0031F369
		// (set) Token: 0x060056D5 RID: 22229 RVA: 0x00321173 File Offset: 0x0031F373
		internal virtual StockMovementByQtyPerBranchTableAdapter StockMovementByQtyPerBranchTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x0032117C File Offset: 0x0031F37C
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

		// Token: 0x060056D7 RID: 22231 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x0032121C File Offset: 0x0031F41C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.StockMovementByQtyPerBranchTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.StockMovementByQtyPerBranchTableAdapter.Fill(this.POSDataSet.StockMovementByQtyPerBranch, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x00321448 File Offset: 0x0031F648
		private void StockMovementQty_Load(object sender, EventArgs e)
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

		// Token: 0x040025E3 RID: 9699
		private string _cnn;
	}
}
