using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200017E RID: 382
	[DesignerGenerated]
	public partial class Quotations_Invoices_Report : UserControl
	{
		// Token: 0x06003833 RID: 14387 RVA: 0x001E98C0 File Offset: 0x001E7AC0
		public Quotations_Invoices_Report()
		{
			base.Load += this.Quotations_Invoices_Report_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x001EA31D File Offset: 0x001E851D
		// (set) Token: 0x06003837 RID: 14391 RVA: 0x001EA328 File Offset: 0x001E8528
		internal virtual GroupBox GroupBox1
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox1_Enter);
				GroupBox groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox1 = value;
				groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x001EA36B File Offset: 0x001E856B
		// (set) Token: 0x06003839 RID: 14393 RVA: 0x001EA375 File Offset: 0x001E8575
		internal virtual DataGridView dgvTrans
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x001EA37E File Offset: 0x001E857E
		// (set) Token: 0x0600383B RID: 14395 RVA: 0x001EA388 File Offset: 0x001E8588
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

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x001EA3CB File Offset: 0x001E85CB
		// (set) Token: 0x0600383D RID: 14397 RVA: 0x001EA3D5 File Offset: 0x001E85D5
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600383E RID: 14398 RVA: 0x001EA3DE File Offset: 0x001E85DE
		// (set) Token: 0x0600383F RID: 14399 RVA: 0x001EA3E8 File Offset: 0x001E85E8
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

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06003840 RID: 14400 RVA: 0x001EA42B File Offset: 0x001E862B
		// (set) Token: 0x06003841 RID: 14401 RVA: 0x001EA435 File Offset: 0x001E8635
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06003842 RID: 14402 RVA: 0x001EA43E File Offset: 0x001E863E
		// (set) Token: 0x06003843 RID: 14403 RVA: 0x001EA448 File Offset: 0x001E8648
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06003844 RID: 14404 RVA: 0x001EA451 File Offset: 0x001E8651
		// (set) Token: 0x06003845 RID: 14405 RVA: 0x001EA45B File Offset: 0x001E865B
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x001EA464 File Offset: 0x001E8664
		// (set) Token: 0x06003847 RID: 14407 RVA: 0x001EA46E File Offset: 0x001E866E
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06003848 RID: 14408 RVA: 0x001EA477 File Offset: 0x001E8677
		// (set) Token: 0x06003849 RID: 14409 RVA: 0x001EA481 File Offset: 0x001E8681
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x0600384A RID: 14410 RVA: 0x001EA48A File Offset: 0x001E868A
		// (set) Token: 0x0600384B RID: 14411 RVA: 0x001EA494 File Offset: 0x001E8694
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x0600384C RID: 14412 RVA: 0x001EA49D File Offset: 0x001E869D
		// (set) Token: 0x0600384D RID: 14413 RVA: 0x001EA4A7 File Offset: 0x001E86A7
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x001EA4B0 File Offset: 0x001E86B0
		// (set) Token: 0x0600384F RID: 14415 RVA: 0x001EA4BA File Offset: 0x001E86BA
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x001EA4C3 File Offset: 0x001E86C3
		// (set) Token: 0x06003851 RID: 14417 RVA: 0x001EA4CD File Offset: 0x001E86CD
		internal virtual CheckBox chkAllUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x001EA4D6 File Offset: 0x001E86D6
		// (set) Token: 0x06003853 RID: 14419 RVA: 0x001EA4E0 File Offset: 0x001E86E0
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x001EA4E9 File Offset: 0x001E86E9
		// (set) Token: 0x06003855 RID: 14421 RVA: 0x001EA4F4 File Offset: 0x001E86F4
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

		// Token: 0x06003856 RID: 14422 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x001EA538 File Offset: 0x001E8738
		private void Quotations_Invoices_Report_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadUsers(MyProject.Forms.Form1.coid);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x001EA59C File Offset: 0x001E879C
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

		// Token: 0x06003859 RID: 14425 RVA: 0x001EA660 File Offset: 0x001E8860
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "ReportQuotationsToInvoices ";
				sqlCommand.Parameters.AddWithValue("startdate", Conversion.Val(this.DTstart.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("enddate", Conversion.Val(this.DTend.Value.ToString("yyyyMMdd")));
				bool @checked = this.chkAllUsers.Checked;
				if (!@checked)
				{
					sqlCommand.Parameters.AddWithValue("doneby", this.cboUsers.Text);
				}
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				this.dgvTrans.DataSource = dataTable;
				this.dgvTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x001EA7E8 File Offset: 0x001E89E8
		private void LoadUsers(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.cboUsers.DataSource = dataTable;
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.ValueMember = "Username";
			}
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x001EA888 File Offset: 0x001E8A88
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvTrans.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvTrans, this.SaveFileDialog1.FileName);
					}
					MessageBox.Show("Data exported to excel.");
				}
				else
				{
					MessageBox.Show("There are no items to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x040017EB RID: 6123
		private string _cnn;

		// Token: 0x040017EC RID: 6124
		private PublicFunctions pf;
	}
}
