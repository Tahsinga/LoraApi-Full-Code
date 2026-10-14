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
	// Token: 0x02000040 RID: 64
	[DesignerGenerated]
	public partial class DespatchReportForPeriod : UserControl
	{
		// Token: 0x06000E60 RID: 3680 RVA: 0x0008A784 File Offset: 0x00088984
		public DespatchReportForPeriod()
		{
			base.Load += this.DespatchReportForPeriod_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0008B02F File Offset: 0x0008922F
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x0008B039 File Offset: 0x00089239
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0008B042 File Offset: 0x00089242
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x0008B04C File Offset: 0x0008924C
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0008B055 File Offset: 0x00089255
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x0008B05F File Offset: 0x0008925F
		internal virtual BindingSource DespatchForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0008B068 File Offset: 0x00089268
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0008B072 File Offset: 0x00089272
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0008B07B File Offset: 0x0008927B
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x0008B085 File Offset: 0x00089285
		internal virtual DespatchForPeriodTableAdapter DespatchForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x0008B08E File Offset: 0x0008928E
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x0008B098 File Offset: 0x00089298
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

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x0008B0DB File Offset: 0x000892DB
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x0008B0E5 File Offset: 0x000892E5
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x0008B0EE File Offset: 0x000892EE
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x0008B0F8 File Offset: 0x000892F8
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0008B101 File Offset: 0x00089301
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x0008B10B File Offset: 0x0008930B
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0008B114 File Offset: 0x00089314
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x0008B11E File Offset: 0x0008931E
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0008B127 File Offset: 0x00089327
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x0008B131 File Offset: 0x00089331
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0008B13A File Offset: 0x0008933A
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x0008B144 File Offset: 0x00089344
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0008B14D File Offset: 0x0008934D
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x0008B157 File Offset: 0x00089357
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0008B160 File Offset: 0x00089360
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x0008B16C File Offset: 0x0008936C
		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label5_Click);
				Label label = this._Label5;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0008B1AF File Offset: 0x000893AF
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x0008B1B9 File Offset: 0x000893B9
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0008B1C2 File Offset: 0x000893C2
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x0008B1CC File Offset: 0x000893CC
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0008B1D8 File Offset: 0x000893D8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = DateTime.Compare(this.DTEndDate.Value.Date, this.DTStartDate.Value.Date) < 0;
				if (flag)
				{
					MessageBox.Show("Please select a start start that is earlier than the end date.");
				}
				else
				{
					Cursor.Current = Cursors.WaitCursor;
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
					this.DespatchForPeriodTableAdapter.Connection = sqlConnection;
					ReportParameter reportParameter = new ReportParameter("shiftdateStartDesc", this.DTStartDate.Value.ToShortDateString());
					ReportParameter reportParameter2 = new ReportParameter("shiftdateEndDesc", this.DTEndDate.Value.ToShortDateString());
					ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
					ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
					this.ReportViewer1.LocalReport.SetParameters(array);
					this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
					this.DespatchForPeriodTableAdapter.Fill(this.POSDataSet.DespatchForPeriod, new int?(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.ReportViewer1.RefreshReport();
					Cursor.Current = Cursors.Default;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0008B3E8 File Offset: 0x000895E8
		private void DespatchReportForPeriod_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0008B438 File Offset: 0x00089638
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
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x040006ED RID: 1773
		private string _cnn;
	}
}
