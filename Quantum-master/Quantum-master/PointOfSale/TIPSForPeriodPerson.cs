using System;
using System.Collections;
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
	// Token: 0x02000204 RID: 516
	[DesignerGenerated]
	public partial class TIPSForPeriodPerson : UserControl
	{
		// Token: 0x06005C6D RID: 23661 RVA: 0x00351204 File Offset: 0x0034F404
		public TIPSForPeriodPerson()
		{
			base.Load += this.TIPSForPeriodPerson_Load;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06005C70 RID: 23664 RVA: 0x00351C29 File Offset: 0x0034FE29
		// (set) Token: 0x06005C71 RID: 23665 RVA: 0x00351C33 File Offset: 0x0034FE33
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06005C72 RID: 23666 RVA: 0x00351C3C File Offset: 0x0034FE3C
		// (set) Token: 0x06005C73 RID: 23667 RVA: 0x00351C46 File Offset: 0x0034FE46
		internal virtual DateTimePicker DTEnd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06005C74 RID: 23668 RVA: 0x00351C4F File Offset: 0x0034FE4F
		// (set) Token: 0x06005C75 RID: 23669 RVA: 0x00351C59 File Offset: 0x0034FE59
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x06005C76 RID: 23670 RVA: 0x00351C62 File Offset: 0x0034FE62
		// (set) Token: 0x06005C77 RID: 23671 RVA: 0x00351C6C File Offset: 0x0034FE6C
		internal virtual DateTimePicker DTStart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06005C78 RID: 23672 RVA: 0x00351C75 File Offset: 0x0034FE75
		// (set) Token: 0x06005C79 RID: 23673 RVA: 0x00351C7F File Offset: 0x0034FE7F
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06005C7A RID: 23674 RVA: 0x00351C88 File Offset: 0x0034FE88
		// (set) Token: 0x06005C7B RID: 23675 RVA: 0x00351C92 File Offset: 0x0034FE92
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06005C7C RID: 23676 RVA: 0x00351C9B File Offset: 0x0034FE9B
		// (set) Token: 0x06005C7D RID: 23677 RVA: 0x00351CA5 File Offset: 0x0034FEA5
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06005C7E RID: 23678 RVA: 0x00351CAE File Offset: 0x0034FEAE
		// (set) Token: 0x06005C7F RID: 23679 RVA: 0x00351CB8 File Offset: 0x0034FEB8
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click_1);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x00351CFB File Offset: 0x0034FEFB
		// (set) Token: 0x06005C81 RID: 23681 RVA: 0x00351D05 File Offset: 0x0034FF05
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x00351D0E File Offset: 0x0034FF0E
		// (set) Token: 0x06005C83 RID: 23683 RVA: 0x00351D18 File Offset: 0x0034FF18
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x00351D21 File Offset: 0x0034FF21
		// (set) Token: 0x06005C85 RID: 23685 RVA: 0x00351D2C File Offset: 0x0034FF2C
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

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x00351D6F File Offset: 0x0034FF6F
		// (set) Token: 0x06005C87 RID: 23687 RVA: 0x00351D79 File Offset: 0x0034FF79
		internal virtual DataGridView dgvTips
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06005C88 RID: 23688 RVA: 0x00351D82 File Offset: 0x0034FF82
		// (set) Token: 0x06005C89 RID: 23689 RVA: 0x00351D8C File Offset: 0x0034FF8C
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x00351DCF File Offset: 0x0034FFCF
		// (set) Token: 0x06005C8B RID: 23691 RVA: 0x00351DD9 File Offset: 0x0034FFD9
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x00351DE2 File Offset: 0x0034FFE2
		// (set) Token: 0x06005C8D RID: 23693 RVA: 0x00351DEC File Offset: 0x0034FFEC
		internal virtual Label lbltiptot
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x00351DF5 File Offset: 0x0034FFF5
		// (set) Token: 0x06005C8F RID: 23695 RVA: 0x00351DFF File Offset: 0x0034FFFF
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00351E08 File Offset: 0x00350008
		private void LoadUsers(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
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

		// Token: 0x06005C92 RID: 23698 RVA: 0x00351EB0 File Offset: 0x003500B0
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
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

		// Token: 0x06005C93 RID: 23699 RVA: 0x00351F80 File Offset: 0x00350180
		private void TIPSForPeriodPerson_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadUsers(MyProject.Forms.Form1.coid);
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00351FE4 File Offset: 0x003501E4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetTIPSForPeriodforPerson";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
				sqlCommand.Parameters.AddWithValue("startdate", Conversions.ToInteger(this.DTStart.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("enddate", Conversions.ToInteger(this.DTEnd.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("theuser", this.cboUsers.Text);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				this.dgvTips.DataSource = dataTable;
				this.dgvTips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				decimal num = 0m;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvTips.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						num = Conversions.ToDecimal(Operators.AddObject(num, dataGridViewRow.Cells["TipAmount"].Value));
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
				this.lbltiptot.Text = Conversions.ToString(num);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading tips. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00352204 File Offset: 0x00350404
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvTips.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvTips, this.SaveFileDialog1.FileName);
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

		// Token: 0x06005C96 RID: 23702 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0400287E RID: 10366
		private PublicFunctions pf;
	}
}
