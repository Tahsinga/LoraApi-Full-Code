using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.QuantumPOSService;

namespace PointOfSale
{
	// Token: 0x02000023 RID: 35
	[DesignerGenerated]
	public partial class CheckConnectedbranchStatus : Form
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x00044588 File Offset: 0x00042788
		public CheckConnectedbranchStatus()
		{
			base.Load += this.CheckConnectedbranchStatus_Load;
			this.press_count = 0;
			this.pin = "AppUser123";
			this.appuname = "AppUser";
			this.InitializeComponent();
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00044A6A File Offset: 0x00042C6A
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00044A74 File Offset: 0x00042C74
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00044A7D File Offset: 0x00042C7D
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00044A87 File Offset: 0x00042C87
		internal virtual TextBox txtCoid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00044A90 File Offset: 0x00042C90
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00044A9A File Offset: 0x00042C9A
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00044AA3 File Offset: 0x00042CA3
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00044AB0 File Offset: 0x00042CB0
		internal virtual DataGridView dgvStatus
		{
			[CompilerGenerated]
			get
			{
				return this._dgvStatus;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvStatus_CellContentClick);
				DataGridView dataGridView = this._dgvStatus;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvStatus = value;
				dataGridView = this._dgvStatus;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00044AF3 File Offset: 0x00042CF3
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00044B00 File Offset: 0x00042D00
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00044B43 File Offset: 0x00042D43
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00044B50 File Offset: 0x00042D50
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00044B93 File Offset: 0x00042D93
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00044B9D File Offset: 0x00042D9D
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00044BA8 File Offset: 0x00042DA8
		private void Label2_Click(object sender, EventArgs e)
		{
			checked
			{
				this.press_count++;
				bool flag = this.press_count == 7;
				if (flag)
				{
					this.txtCoid.ReadOnly = false;
				}
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00044BE0 File Offset: 0x00042DE0
		private void CheckConnectedbranchStatus_Load(object sender, EventArgs e)
		{
			try
			{
				this.Timer1.Interval = 60000;
				this.Timer1.Start();
				this.txtCoid.Text = MyProject.Forms.Form1.coid.ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00044C50 File Offset: 0x00042E50
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.lblinfo.Text = "...";
				ServiceClient serviceClient = new ServiceClient();
				DataTable connectedbranchstatustb = serviceClient.GetConnectedBranchStatus(this.appuname, this.pin, Conversions.ToInteger(this.txtCoid.Text)).connectedbranchstatustb;
				this.dgvStatus.Columns.Clear();
				this.dgvStatus.DataSource = connectedbranchstatustb;
				this.dgvStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvStatus.Columns["branchname"].HeaderText = "Branch";
				this.dgvStatus.Columns["entryno"].HeaderText = "Entry Num";
				this.dgvStatus.Columns["product_movement_status"].HeaderText = "Product Movement Transactions Pending Download";
				this.dgvStatus.Columns["product_edits_status"].HeaderText = "Product Edits Transactions Pending Download";
				this.dgvStatus.Columns["product_branchprices_status"].HeaderText = "Branch Prices Transactions Pending Download";
				this.dgvStatus.Columns["branch_commands_status"].HeaderText = "Branch Commands Pending Execution";
				this.lblinfo.Text = Conversions.ToString(DateTime.Now);
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.Name = "RedoStockBal";
				dataGridViewButtonColumn.Text = "Redo Stock Balance";
				dataGridViewButtonColumn.HeaderText = "Send Redo Stock Bal Command";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				dataGridViewButtonColumn.DefaultCellStyle.BackColor = Color.PaleVioletRed;
				this.dgvStatus.Columns.Add(dataGridViewButtonColumn);
			}
			catch (Exception ex)
			{
				this.lblinfo.Text = ex.Message;
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00044E38 File Offset: 0x00043038
		private void dgvStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "RedoStockBal", false) == 0;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to redo stock bal calculation for this branch? IT MAY TAKE TIME AND USERS MAY FAIL TO GET STOCK BALs UNTIL THE PROCESS IS OVER." + dataGridView.Rows[e.RowIndex].Cells["branchname"].Value.ToString(), MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							ServiceClient serviceClient = new ServiceClient();
							bool flag4 = serviceClient.SetCommandForBranch(this.appuname, this.pin, Conversions.ToInteger(this.txtCoid.Text), Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["branchname"].Value), "RedoStockBal", DateTime.Now);
							if (flag4)
							{
								MessageBox.Show("Command successfully set, wait for branch to execute.");
							}
							else
							{
								MessageBox.Show("Error setting command.");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail:  " + ex.Message);
			}
		}

		// Token: 0x0400032D RID: 813
		private int press_count;

		// Token: 0x0400032E RID: 814
		private string pin;

		// Token: 0x0400032F RID: 815
		private string appuname;
	}
}
