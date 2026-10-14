using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000177 RID: 375
	[DesignerGenerated]
	public partial class PromotionsView : Form
	{
		// Token: 0x060036BD RID: 14013 RVA: 0x001D8E54 File Offset: 0x001D7054
		public PromotionsView()
		{
			base.Load += this.PromotionsView_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x001D9457 File Offset: 0x001D7657
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x001D9461 File Offset: 0x001D7661
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x001D946A File Offset: 0x001D766A
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x001D9474 File Offset: 0x001D7674
		internal virtual DataGridView dgvPromotions
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x001D947D File Offset: 0x001D767D
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x001D9487 File Offset: 0x001D7687
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x001D9490 File Offset: 0x001D7690
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x001D949A File Offset: 0x001D769A
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x001D94A3 File Offset: 0x001D76A3
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x001D94B0 File Offset: 0x001D76B0
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

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x001D94F3 File Offset: 0x001D76F3
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x001D94FD File Offset: 0x001D76FD
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x001D9506 File Offset: 0x001D7706
		// (set) Token: 0x060036CD RID: 14029 RVA: 0x001D9510 File Offset: 0x001D7710
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x001D9519 File Offset: 0x001D7719
		// (set) Token: 0x060036CF RID: 14031 RVA: 0x001D9523 File Offset: 0x001D7723
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x001D952C File Offset: 0x001D772C
		// (set) Token: 0x060036D1 RID: 14033 RVA: 0x001D9536 File Offset: 0x001D7736
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x001D9540 File Offset: 0x001D7740
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "PromotionsGetGivenN";
				sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					this.dgvPromotions.DataSource = dataTable;
					this.dgvPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					MessageBox.Show("There are no promotions given during the period.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing promotions for period. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x001D96B4 File Offset: 0x001D78B4
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
			this.cboBranch.SelectedIndex = -1;
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x001D9760 File Offset: 0x001D7960
		private void PromotionsView_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error laoding form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04001778 RID: 6008
		private string _cnn;
	}
}
