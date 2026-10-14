using System;
using System.Collections;
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
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class BatchSelect : Form
	{
		// Token: 0x06000300 RID: 768 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		public BatchSelect()
		{
			base.Load += this.BatchSelect_Load;
			base.Closing += this.BatchSelect_Closing;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.da = new SqlDataAdapter();
			this.dat1 = new DataTable();
			this.ViewOnly = false;
			this.InitializeComponent();
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0001AF74 File Offset: 0x00019174
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0001AF7E File Offset: 0x0001917E
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0001AF87 File Offset: 0x00019187
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0001AF91 File Offset: 0x00019191
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0001AF9A File Offset: 0x0001919A
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0001AFA4 File Offset: 0x000191A4
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0001AFE7 File Offset: 0x000191E7
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0001AFF4 File Offset: 0x000191F4
		internal virtual DataGridView dgvBatches
		{
			[CompilerGenerated]
			get
			{
				return this._dgvBatches;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.dgvBatches_EditingControlShowing);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvBatches_CellContentClick);
				DataGridView dataGridView = this._dgvBatches;
				if (dataGridView != null)
				{
					dataGridView.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvBatches = value;
				dataGridView = this._dgvBatches;
				if (dataGridView != null)
				{
					dataGridView.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0001B052 File Offset: 0x00019252
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0001B05C File Offset: 0x0001925C
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0001B0A0 File Offset: 0x000192A0
		private void BatchSelect_Load(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.dgvBatches.DataSource = this.GetBal(0);
				MyProject.Forms.Form1.SelectedBatch = this.dat1;
				this.dgvBatches.Columns["productid"].ReadOnly = true;
				this.dgvBatches.Columns["productid"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["BatchNumber"].ReadOnly = true;
				this.dgvBatches.Columns["BatchNumber"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["ExpiryDate"].ReadOnly = true;
				this.dgvBatches.Columns["ExpiryDate"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["bal"].ReadOnly = true;
				bool viewOnly = this.ViewOnly;
				if (viewOnly)
				{
					this.Label1.Text = "STOCK BALANCES BY BATCH NUMBER AND EXPIRY DATE";
					this.Button1.Visible = false;
				}
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing product balance batch breakdown.");
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0001B230 File Offset: 0x00019430
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			bool flag = this.dgvBatches.Rows.Count > 0;
			if (flag)
			{
				this.dgvBatches.Focus();
				this.dgvBatches.CurrentCell = this.dgvBatches.Rows[0].Cells["OrderQty"];
				this.dgvBatches.BeginEdit(true);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0001B2A4 File Offset: 0x000194A4
		private DataTable GetBal(int showall)
		{
			DataTable dataTable = new DataTable();
			this.dat1 = dataTable;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			this.cmd = sqlConnection.CreateCommand();
			this.cmd.CommandType = CommandType.StoredProcedure;
			this.cmd.CommandText = "StockBalanceWarehouseCurrentBatch";
			this.cmd.Parameters.AddWithValue("productid", this.productid);
			this.cmd.Parameters.AddWithValue("coid", this.coid);
			this.cmd.Parameters.AddWithValue("branch", this.branch);
			this.cmd.Parameters.AddWithValue("showall", showall);
			this.da.SelectCommand = this.cmd;
			this.da.Fill(this.dat1);
			this.dat1.Columns.Add("OrderQty", typeof(int));
			return this.dat1;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001B3C0 File Offset: 0x000195C0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool viewOnly = this.ViewOnly;
				if (!viewOnly)
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvBatches.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Operators.CompareString(dataGridViewRow.Cells["OrderQty"].Value.ToString(), "", false) == 0;
							if (flag)
							{
								dataGridViewRow.Cells["OrderQty"].Value = 0;
							}
							try
							{
								decimal num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OrderQty"].Value));
							}
							catch (Exception ex)
							{
								MessageBox.Show("Please enter a valid quantity.");
								dataGridViewRow.Cells["OrderQty"].Value = 0;
								return;
							}
							bool flag2 = MyProject.Forms.Form1.NegativeStock == 0;
							if (flag2)
							{
								decimal num2 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value)));
								bool flag3 = Operators.ConditionalCompareObjectLess(num2, dataGridViewRow.Cells["OrderQty"].Value, false);
								if (flag3)
								{
									bool flag4 = Operators.ConditionalCompareObjectLess(dataGridViewRow.Cells["OrderQty"].Value, 0, false);
									if (flag4)
									{
										MessageBox.Show("Order quantity is less than zero for batch.");
										dataGridViewRow.Cells["OrderQty"].Value = 0;
										return;
									}
									bool flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(dataGridViewRow.Cells["OrderQty"].Value, 0, false), Operators.CompareObjectGreaterEqual(dataGridViewRow.Cells["bal"].Value, 0, false)));
									if (flag5)
									{
										MessageBox.Show("Quantity entered is greater than the stock available. Rectify.");
										dataGridViewRow.Cells["OrderQty"].Value = 0;
										dataGridViewRow.Cells["OrderQty"].Selected = true;
										return;
									}
									bool flag6 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(dataGridViewRow.Cells["OrderQty"].Value, 0, false), Operators.CompareObjectLess(dataGridViewRow.Cells["bal"].Value, 0, false)));
									if (flag6)
									{
										MessageBox.Show("Cannot sell a product that is in negative stock.");
										dataGridViewRow.Cells["OrderQty"].Value = 0;
										dataGridViewRow.Cells["OrderQty"].Selected = true;
										return;
									}
								}
							}
							else
							{
								bool flag7 = Operators.ConditionalCompareObjectGreaterEqual(dataGridViewRow.Cells["OrderQty"].Value, 0, false);
								if (!flag7)
								{
									MessageBox.Show("Quantity entered is less than zero. Kindly correct.");
									dataGridViewRow.Cells["OrderQty"].Value = 0;
									dataGridViewRow.Cells["OrderQty"].Selected = true;
									return;
								}
							}
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
					MyProject.Forms.Form1.SelectedBatch = this.dat1;
					base.Dispose();
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error submitting batch selection. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0001B7E8 File Offset: 0x000199E8
		private void dgvBatches_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			bool flag = e.Control is TextBox;
			if (flag)
			{
				TextBox textBox = e.Control as TextBox;
				textBox.KeyPress -= this.tb_KeyPress;
				bool flag2 = this.dgvBatches.CurrentCell.ColumnIndex == 4;
				if (flag2)
				{
					textBox.KeyPress += this.tb_KeyPress;
				}
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0001B858 File Offset: 0x00019A58
		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0001B8AC File Offset: 0x00019AAC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.dgvBatches.Columns.Clear();
				this.dgvBatches.DataSource = this.GetBal(0);
				this.dgvBatches.Columns["productid"].ReadOnly = true;
				this.dgvBatches.Columns["productid"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["BatchNumber"].ReadOnly = true;
				this.dgvBatches.Columns["BatchNumber"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["ExpiryDate"].ReadOnly = true;
				this.dgvBatches.Columns["ExpiryDate"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["bal"].ReadOnly = true;
				bool viewOnly = this.ViewOnly;
				if (viewOnly)
				{
					this.Label1.Text = "STOCK BALANCES BY BATCH NUMBER AND EXPIRY DATE";
					this.Button1.Visible = false;
				}
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing product balance batch breakdown.");
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0001BA38 File Offset: 0x00019C38
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.dgvBatches.Columns.Clear();
				this.dgvBatches.DataSource = this.GetBal(1);
				this.dgvBatches.Columns["productid"].ReadOnly = true;
				this.dgvBatches.Columns["productid"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["BatchNumber"].ReadOnly = true;
				this.dgvBatches.Columns["BatchNumber"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["ExpiryDate"].ReadOnly = true;
				this.dgvBatches.Columns["ExpiryDate"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvBatches.Columns["bal"].ReadOnly = true;
				bool viewOnly = this.ViewOnly;
				if (viewOnly)
				{
					this.Label1.Text = "STOCK BALANCES BY BATCH NUMBER AND EXPIRY DATE";
					this.Button1.Visible = false;
				}
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing product balance batch breakdown show all. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002A30 File Offset: 0x00000C30
		private void dgvBatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		private void BatchSelect_Closing(object sender, CancelEventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000152 RID: 338
		public int productid;

		// Token: 0x04000153 RID: 339
		public int coid;

		// Token: 0x04000154 RID: 340
		public string branch;

		// Token: 0x04000155 RID: 341
		private string _cnn;

		// Token: 0x04000156 RID: 342
		private SqlCommand cmd;

		// Token: 0x04000157 RID: 343
		private SqlDataAdapter da;

		// Token: 0x04000158 RID: 344
		private DataTable dat1;

		// Token: 0x04000159 RID: 345
		public bool ViewOnly;
	}
}
