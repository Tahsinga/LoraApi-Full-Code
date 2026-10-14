using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000069 RID: 105
	[DesignerGenerated]
	public partial class KitchenDisplay : Form
	{
		// Token: 0x06001607 RID: 5639 RVA: 0x000CD4A2 File Offset: 0x000CB6A2
		public KitchenDisplay()
		{
			base.Load += this.KitchenDisplay_Load;
			this.kduID = 0;
			this.rownum = 0;
			this.rowgroup = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x000CDF1D File Offset: 0x000CC11D
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x000CDF27 File Offset: 0x000CC127
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000CDF30 File Offset: 0x000CC130
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x000CDF3C File Offset: 0x000CC13C
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000CDF7F File Offset: 0x000CC17F
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x000CDF8C File Offset: 0x000CC18C
		internal virtual DataGridView dgvDisplay
		{
			[CompilerGenerated]
			get
			{
				return this._dgvDisplay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick);
				DataGridView dataGridView = this._dgvDisplay;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvDisplay = value;
				dataGridView = this._dgvDisplay;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x000CDFCF File Offset: 0x000CC1CF
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x000CDFDC File Offset: 0x000CC1DC
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x000CE01F File Offset: 0x000CC21F
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x000CE02C File Offset: 0x000CC22C
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000CE06F File Offset: 0x000CC26F
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x000CE07C File Offset: 0x000CC27C
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
				EventHandler eventHandler = new EventHandler(this.Button2_Click_1);
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

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x000CE0BF File Offset: 0x000CC2BF
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x000CE0C9 File Offset: 0x000CC2C9
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x000CE0D2 File Offset: 0x000CC2D2
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x000CE0DC File Offset: 0x000CC2DC
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x000CE0E5 File Offset: 0x000CC2E5
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x000CE0EF File Offset: 0x000CC2EF
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x000CE0F8 File Offset: 0x000CC2F8
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x000CE102 File Offset: 0x000CC302
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x000CE10B File Offset: 0x000CC30B
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x000CE115 File Offset: 0x000CC315
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000CE11E File Offset: 0x000CC31E
		// (set) Token: 0x06001621 RID: 5665 RVA: 0x000CE128 File Offset: 0x000CC328
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x000CE131 File Offset: 0x000CC331
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x000CE13B File Offset: 0x000CC33B
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x000CE144 File Offset: 0x000CC344
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x000CE14E File Offset: 0x000CC34E
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x000CE157 File Offset: 0x000CC357
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x000CE161 File Offset: 0x000CC361
		internal virtual CheckBox chkHideDesc2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x000CE16A File Offset: 0x000CC36A
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x000CE174 File Offset: 0x000CC374
		internal virtual CheckBox chkHideComments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000CE180 File Offset: 0x000CC380
		private void KitchenDisplay_Load(object sender, EventArgs e)
		{
			try
			{
				SelectKDU selectKDU = new SelectKDU();
				selectKDU.ShowDialog(this);
				selectKDU.Dispose();
				this.kduID = MyProject.Forms.Form1.kduID;
				base.FormBorderStyle = FormBorderStyle.None;
				base.WindowState = FormWindowState.Maximized;
				this.Button1.BackColor = Color.Green;
				this.Timer1.Interval = 10000;
				this.Timer1.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000CE230 File Offset: 0x000CC430
		private void LoadDisplay()
		{
			this.dgvDisplay.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetKDUProducts";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("kduID", this.kduID);
			bool flag = this.Button1.BackColor == Color.Green;
			if (flag)
			{
				sqlCommand.Parameters.AddWithValue("viewall", 0);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("viewall", 1);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvDisplay.DataSource = dataTable;
			this.dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvDisplay.Columns["invoicenum"].Visible = false;
			this.dgvDisplay.Columns["NumberOfRows"].Visible = false;
			this.dgvDisplay.Columns["OrderNo"].Visible = false;
			this.dgvDisplay.Columns["ReceiptCounter"].Visible = false;
			this.dgvDisplay.Columns["UOM"].Visible = false;
			bool @checked = this.chkHideDesc2.Checked;
			if (@checked)
			{
				this.dgvDisplay.Columns["ProductDesc2"].Visible = false;
			}
			bool checked2 = this.chkHideComments.Checked;
			if (checked2)
			{
				this.dgvDisplay.Columns["Comments"].Visible = false;
			}
			this.dgvDisplay.Columns["ReceiptCounter"].HeaderText = "Order Number";
			this.dgvDisplay.Columns["ProductDesc"].HeaderText = "Product Description";
			this.dgvDisplay.Columns["ProductDesc2"].HeaderText = "Description 2";
			this.dgvDisplay.Columns["Quantity"].HeaderText = "Qty";
			this.dgvDisplay.Columns["Quantity"].Width = 150;
			this.dgvDisplay.DefaultCellStyle.Font = new Font("Arial", (float)Conversion.Val(this.TextBox1.Text));
			checked
			{
				int num2 = (int)Math.Round(Conversion.Val(this.TextBox1.Text));
				this.dgvDisplay.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 20f, FontStyle.Bold);
				this.dgvDisplay.RowsDefaultCellStyle.Font = new Font("Arial", (float)num2, FontStyle.Bold);
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.Name = "Action";
				dataGridViewButtonColumn.HeaderText = "Action Click when Done";
				dataGridViewButtonColumn.Text = "Click";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvDisplay.Columns.Add(dataGridViewButtonColumn);
				this.dgvDisplay.CellPainting += this.DataGridView1_CellPainting;
				this.dgvDisplay.CellClick += this.DataGridView1_CellClick;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvDisplay.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["UOM"].Value, "EA", false);
						if (flag2)
						{
							dataGridViewRow.Cells["Quantity"].Value = Conversions.ToInteger(dataGridViewRow.Cells["Quantity"].Value);
						}
						int num3 = Conversions.ToInteger(dataGridViewRow.Cells["ReceiptCounter"].Value);
						this.rownum++;
						bool flag3 = this.rownum == 1;
						if (flag3)
						{
							this.rowgroup = num3;
							this.rowcolor = Color.LightGreen;
						}
						bool flag4 = this.rowgroup == num3;
						if (flag4)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = this.rowcolor;
						}
						else
						{
							bool flag5 = this.rowcolor == Color.LightGreen;
							if (flag5)
							{
								this.rowcolor = Color.Yellow;
								dataGridViewRow.DefaultCellStyle.BackColor = this.rowcolor;
							}
							else
							{
								bool flag6 = this.rowcolor == Color.Yellow;
								if (flag6)
								{
									this.rowcolor = Color.LightGreen;
									dataGridViewRow.DefaultCellStyle.BackColor = this.rowcolor;
								}
							}
							this.rowgroup = num3;
						}
						bool flag7 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["OrderNo"].Value, 1, false);
						if (flag7)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
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
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002A30 File Offset: 0x00000C30
		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000CE814 File Offset: 0x000CCA14
		private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			bool flag = e.ColumnIndex == this.dgvDisplay.Columns["Action"].Index && e.RowIndex >= 0;
			checked
			{
				if (flag)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
					string text = "";
					int num = Conversions.ToInteger(this.dgvDisplay.Rows[e.RowIndex].Cells["ReceiptCounter"].Value);
					int num2 = e.RowIndex;
					while (num2 > 0 && Conversions.ToInteger(this.dgvDisplay.Rows[num2 - 1].Cells["ReceiptCounter"].Value) == num)
					{
						text = this.dgvDisplay.Rows[num2 - 1].Cells["ReceiptCounter"].Value.ToString();
						num2--;
					}
					int num3 = e.RowIndex;
					while (num3 < this.dgvDisplay.Rows.Count - 1 && Conversions.ToInteger(this.dgvDisplay.Rows[num3 + 1].Cells["ReceiptCounter"].Value) == num)
					{
						num3++;
					}
					Rectangle rectangle = e.CellBounds;
					int num4 = num2;
					int num5 = num3;
					for (int i = num4; i <= num5; i++)
					{
						rectangle = Rectangle.Union(rectangle, this.dgvDisplay.GetCellDisplayRectangle(e.ColumnIndex, i, true));
					}
					Graphics graphics = e.Graphics;
					ButtonRenderer.DrawButton(e.Graphics, rectangle, text, this.dgvDisplay.Font, false, PushButtonState.Normal);
					using (SolidBrush solidBrush = new SolidBrush(this.dgvDisplay.Rows[e.RowIndex].DefaultCellStyle.BackColor))
					{
						e.Graphics.FillRectangle(solidBrush, rectangle);
					}
					Font font = new Font("Arial", (float)Conversion.Val(this.TextBox1.Text), FontStyle.Italic, GraphicsUnit.Point);
					TextRenderer.DrawText(e.Graphics, Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(this.dgvDisplay.Rows[e.RowIndex].Cells["OrderNo"].Value, 0, false), "ORDER NUM: " + this.dgvDisplay.Rows[e.RowIndex].Cells["ReceiptCounter"].Value.ToString(), "ORDER ALREADY DONE")), font, rectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000CEAF0 File Offset: 0x000CCCF0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.Button1.BackColor = Color.Green;
				this.Button2.BackColor = Color.White;
				this.LoadDisplay();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading display. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000CEB60 File Offset: 0x000CCD60
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.rownum = 0;
				this.LoadDisplay();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000CEBB8 File Offset: 0x000CCDB8
		private void Button2_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.Button1.BackColor = Color.White;
				this.Button2.BackColor = Color.Green;
				this.LoadDisplay();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading display. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000CEC28 File Offset: 0x000CCE28
		private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = e.ColumnIndex == this.dgvDisplay.Columns["Action"].Index && e.RowIndex >= 0;
				if (flag)
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to Complete Order " + this.dgvDisplay.Rows[e.RowIndex].Cells["ReceiptCounter"].Value.ToString(), MsgBoxStyle.YesNo, null);
					bool flag2 = dialogResult == DialogResult.Yes;
					if (flag2)
					{
						this.CompleteOrder(Conversions.ToInteger(this.dgvDisplay.Rows[e.RowIndex].Cells["InvoiceNum"].Value));
						this.LoadDisplay();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x000CED34 File Offset: 0x000CCF34
		private void CompleteOrder(int invNumber)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"update invoicenumberssales set orderno=1 where salesno=",
				Conversions.ToString(invNumber),
				" and coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"'"
			});
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04000B14 RID: 2836
		public int kduID;

		// Token: 0x04000B15 RID: 2837
		private int rownum;

		// Token: 0x04000B16 RID: 2838
		private int rowgroup;

		// Token: 0x04000B17 RID: 2839
		private Color rowcolor;
	}
}
