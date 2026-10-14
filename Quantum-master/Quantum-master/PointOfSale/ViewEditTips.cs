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
	// Token: 0x0200020E RID: 526
	[DesignerGenerated]
	public partial class ViewEditTips : UserControl
	{
		// Token: 0x06005E88 RID: 24200 RVA: 0x003631C0 File Offset: 0x003613C0
		public ViewEditTips()
		{
			base.Load += this.ViewEditTips_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x06005E8B RID: 24203 RVA: 0x00363A2C File Offset: 0x00361C2C
		// (set) Token: 0x06005E8C RID: 24204 RVA: 0x00363A36 File Offset: 0x00361C36
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x00363A3F File Offset: 0x00361C3F
		// (set) Token: 0x06005E8E RID: 24206 RVA: 0x00363A4C File Offset: 0x00361C4C
		internal virtual DataGridView dgvTips
		{
			[CompilerGenerated]
			get
			{
				return this._dgvTips;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvTips_CellContentClick);
				DataGridView dataGridView = this._dgvTips;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvTips = value;
				dataGridView = this._dgvTips;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x06005E8F RID: 24207 RVA: 0x00363A8F File Offset: 0x00361C8F
		// (set) Token: 0x06005E90 RID: 24208 RVA: 0x00363A99 File Offset: 0x00361C99
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x06005E91 RID: 24209 RVA: 0x00363AA2 File Offset: 0x00361CA2
		// (set) Token: 0x06005E92 RID: 24210 RVA: 0x00363AAC File Offset: 0x00361CAC
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x06005E93 RID: 24211 RVA: 0x00363AB5 File Offset: 0x00361CB5
		// (set) Token: 0x06005E94 RID: 24212 RVA: 0x00363ABF File Offset: 0x00361CBF
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x06005E95 RID: 24213 RVA: 0x00363AC8 File Offset: 0x00361CC8
		// (set) Token: 0x06005E96 RID: 24214 RVA: 0x00363AD2 File Offset: 0x00361CD2
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06005E97 RID: 24215 RVA: 0x00363ADB File Offset: 0x00361CDB
		// (set) Token: 0x06005E98 RID: 24216 RVA: 0x00363AE5 File Offset: 0x00361CE5
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x00363AEE File Offset: 0x00361CEE
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x00363AF8 File Offset: 0x00361CF8
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x00363B01 File Offset: 0x00361D01
		// (set) Token: 0x06005E9C RID: 24220 RVA: 0x00363B0B File Offset: 0x00361D0B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x06005E9D RID: 24221 RVA: 0x00363B14 File Offset: 0x00361D14
		// (set) Token: 0x06005E9E RID: 24222 RVA: 0x00363B20 File Offset: 0x00361D20
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

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x06005E9F RID: 24223 RVA: 0x00363B63 File Offset: 0x00361D63
		// (set) Token: 0x06005EA0 RID: 24224 RVA: 0x00363B70 File Offset: 0x00361D70
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

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x00363BB3 File Offset: 0x00361DB3
		// (set) Token: 0x06005EA2 RID: 24226 RVA: 0x00363BBD File Offset: 0x00361DBD
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x00363BC6 File Offset: 0x00361DC6
		// (set) Token: 0x06005EA4 RID: 24228 RVA: 0x00363BD0 File Offset: 0x00361DD0
		internal virtual CheckBox chkIncDeleted
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x00363BDC File Offset: 0x00361DDC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadTips();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading tips. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x00363C2C File Offset: 0x00361E2C
		private void dgvTips_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "delete", false) == 0;
					if (flag2)
					{
						this.DeleteTip(Conversions.ToInteger(this.dgvTips.Rows[e.RowIndex].Cells["entryno"].Value));
						this.LoadTips();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error detail: " + ex.Message);
			}
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x00363D10 File Offset: 0x00361F10
		private void DeleteTip(int entryno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TipDelete";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("deletedby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("deleteddate", DateTime.Now);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x00363DE4 File Offset: 0x00361FE4
		private void LoadTips()
		{
			this.dgvTips.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TipView";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("tipsfor", this.cboUsers.Text);
			sqlCommand.Parameters.AddWithValue("startdate", this.DTStartDate.Value);
			sqlCommand.Parameters.AddWithValue("enddate", this.DTEndDate.Value);
			bool @checked = this.chkIncDeleted.Checked;
			if (@checked)
			{
				sqlCommand.Parameters.AddWithValue("include_deleted", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("include_deleted", 0);
			}
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvTips.DataSource = dataTable;
			this.dgvTips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.Name = "delete";
			dataGridViewButtonColumn.Text = "Delete";
			this.dgvTips.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x00363F78 File Offset: 0x00362178
		private void ViewEditTips_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboUsers.DataSource = RuntimeHelpers.GetObjectValue(this.pf.GetSystemUsers(this._cnn, MyProject.Forms.Form1.coid));
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.ValueMember = "Username";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400298B RID: 10635
		private string _cnn;

		// Token: 0x0400298C RID: 10636
		private PublicFunctions pf;
	}
}
