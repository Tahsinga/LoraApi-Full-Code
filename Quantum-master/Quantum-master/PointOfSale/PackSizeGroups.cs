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
	// Token: 0x02000086 RID: 134
	[DesignerGenerated]
	public partial class PackSizeGroups : UserControl
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x001128A0 File Offset: 0x00110AA0
		public PackSizeGroups()
		{
			base.Load += this.PackSizeGroups_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x0011329E File Offset: 0x0011149E
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x001132A8 File Offset: 0x001114A8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x001132B1 File Offset: 0x001114B1
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x001132BB File Offset: 0x001114BB
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x001132C4 File Offset: 0x001114C4
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x001132D0 File Offset: 0x001114D0
		internal virtual DataGridView dgvPSGroups
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPSGroups;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPSGroups_CellContentClick);
				DataGridView dataGridView = this._dgvPSGroups;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPSGroups = value;
				dataGridView = this._dgvPSGroups;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00113313 File Offset: 0x00111513
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00113320 File Offset: 0x00111520
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
				EventHandler eventHandler = new EventHandler(this.Label1_Click);
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

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00113363 File Offset: 0x00111563
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x0011336D File Offset: 0x0011156D
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x00113376 File Offset: 0x00111576
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x00113380 File Offset: 0x00111580
		internal virtual DataGridView dgvPSGroupDetails
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPSGroupDetails;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPSGroupDetails_CellContentClick);
				DataGridView dataGridView = this._dgvPSGroupDetails;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPSGroupDetails = value;
				dataGridView = this._dgvPSGroupDetails;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x001133C3 File Offset: 0x001115C3
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x001133D0 File Offset: 0x001115D0
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

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00113413 File Offset: 0x00111613
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x0011341D File Offset: 0x0011161D
		internal virtual TextBox txtPSGroupName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x00113426 File Offset: 0x00111626
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x00113430 File Offset: 0x00111630
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x00113439 File Offset: 0x00111639
		// (set) Token: 0x06001EDB RID: 7899 RVA: 0x00113444 File Offset: 0x00111644
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

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00113487 File Offset: 0x00111687
		// (set) Token: 0x06001EDD RID: 7901 RVA: 0x00113491 File Offset: 0x00111691
		internal virtual ComboBox cboPackSizes
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x0011349A File Offset: 0x0011169A
		// (set) Token: 0x06001EDF RID: 7903 RVA: 0x001134A4 File Offset: 0x001116A4
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x001134AD File Offset: 0x001116AD
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x001134B7 File Offset: 0x001116B7
		internal virtual Label lblpsgrpID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x001134C0 File Offset: 0x001116C0
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x001134CA File Offset: 0x001116CA
		internal virtual Label lblPSgroupname
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x001134D3 File Offset: 0x001116D3
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x001134DD File Offset: 0x001116DD
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x001134E8 File Offset: 0x001116E8
		private void Label1_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00113520 File Offset: 0x00111720
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtPSGroupName.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter a group name.");
				}
				else
				{
					using (SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring))
					{
						string text = "Insert into PacketSizegroupHeader (PSGroupName,coid) values (@psgroupname,@coid)";
						using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
						{
							sqlCommand.CommandType = CommandType.Text;
							sqlCommand.Parameters.AddWithValue("psgroupname", this.txtPSGroupName.Text);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
					}
					this.LoadPSGroups();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00113658 File Offset: 0x00111858
		private void LoadPSGroups()
		{
			this.dgvPSGroups.Columns.Clear();
			DataTable packetSizeGroups = this.pf.getPacketSizeGroups(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
			this.dgvPSGroups.DataSource = packetSizeGroups;
			this.dgvPSGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPSGroups.Columns["coid"].Visible = false;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.Text = "View Pack Size Group Details";
			dataGridViewButtonColumn.Name = "View";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvPSGroups.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00113710 File Offset: 0x00111910
		private void dgvPSGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
					if (flag2)
					{
						this.lblPSgroupname.Text = Conversions.ToString(this.dgvPSGroups.Rows[e.RowIndex].Cells["PSGroupname"].Value);
						this.lblpsgrpID.Text = Conversions.ToString(this.dgvPSGroups.Rows[e.RowIndex].Cells["GroupID"].Value);
						this.LoadPSGroupDetail(Conversions.ToInteger(this.lblpsgrpID.Text));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00113848 File Offset: 0x00111A48
		private void LoadPackSizes()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select PacketSizeName,Entryno from PacketSizes where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPackSizes.DataSource = dataTable;
			this.cboPackSizes.DisplayMember = "PacketSizeName";
			this.cboPackSizes.ValueMember = "Entryno";
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x001138DC File Offset: 0x00111ADC
		private void PackSizeGroups_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadPackSizes();
				this.LoadPSGroups();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00113934 File Offset: 0x00111B34
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring))
				{
					string text = "Insert into PacketSizeGroupDetail (GroupID,PacketSizesEntryno) values (@groupid,@psentryno)";
					using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
					{
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.Parameters.AddWithValue("groupid", Conversion.Val(this.lblpsgrpID.Text));
						sqlCommand.Parameters.AddWithValue("psentryno", RuntimeHelpers.GetObjectValue(this.cboPackSizes.SelectedValue));
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
				}
				MessageBox.Show("Packet Size added to group.");
				this.LoadPSGroupDetail(Conversions.ToInteger(this.lblpsgrpID.Text));
			}
			catch (SqlException ex)
			{
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00113A78 File Offset: 0x00111C78
		private void LoadPSGroupDetail(int groupid)
		{
			this.dgvPSGroupDetails.Columns.Clear();
			using (SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring))
			{
				string text = "select pd.groupid as GroupID,ph.psgroupname as Group_Name,p.packetsizename as Packet_Size_Name,p.packetsizeqty as Packet_Size_Qty, pd.entryno from packetsizegroupdetail pd inner join packetsizegroupheader ph on pd.groupid=ph.groupid inner join PacketSizes p on pd.packetsizesentryno=p.entryno where pd.groupid=@groupid";
				using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
				{
					sqlCommand.Parameters.AddWithValue("groupid", groupid);
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
					{
						sqlDataAdapter.SelectCommand = sqlCommand;
						using (DataTable dataTable = new DataTable())
						{
							sqlDataAdapter.Fill(dataTable);
							this.dgvPSGroupDetails.DataSource = dataTable;
							this.dgvPSGroupDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
							this.dgvPSGroupDetails.Columns["entryno"].Visible = false;
							DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
							dataGridViewButtonColumn.Text = "Delete";
							dataGridViewButtonColumn.HeaderText = "Delete";
							dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
							this.dgvPSGroupDetails.Columns.Add(dataGridViewButtonColumn);
						}
					}
				}
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00113BD8 File Offset: 0x00111DD8
		private void dgvPSGroupDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						using (SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring))
						{
							string text = "delete packetsizegroupdetail where entryno=@entryno";
							using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
							{
								sqlCommand.CommandType = CommandType.Text;
								sqlCommand.Parameters.AddWithValue("entryno", RuntimeHelpers.GetObjectValue(this.dgvPSGroupDetails.Rows[e.RowIndex].Cells["Entryno"].Value));
								sqlConnection.Open();
								sqlCommand.ExecuteNonQuery();
								sqlConnection.Close();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000EAA RID: 3754
		private string _cnn;

		// Token: 0x04000EAB RID: 3755
		private PublicFunctions pf;
	}
}
