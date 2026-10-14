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
	// Token: 0x02000183 RID: 387
	[DesignerGenerated]
	public partial class RepairsView : UserControl
	{
		// Token: 0x06003997 RID: 14743 RVA: 0x001F4F34 File Offset: 0x001F3134
		public RepairsView()
		{
			base.Load += this.RepairsView_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x001F5767 File Offset: 0x001F3967
		// (set) Token: 0x0600399B RID: 14747 RVA: 0x001F5771 File Offset: 0x001F3971
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x001F577A File Offset: 0x001F397A
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x001F5784 File Offset: 0x001F3984
		internal virtual DataGridView dgvRepairs
		{
			[CompilerGenerated]
			get
			{
				return this._dgvRepairs;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvRepairs_CellContentClick);
				DataGridView dataGridView = this._dgvRepairs;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvRepairs = value;
				dataGridView = this._dgvRepairs;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x001F57C7 File Offset: 0x001F39C7
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x001F57D4 File Offset: 0x001F39D4
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

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x001F5817 File Offset: 0x001F3A17
		// (set) Token: 0x060039A1 RID: 14753 RVA: 0x001F5821 File Offset: 0x001F3A21
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060039A2 RID: 14754 RVA: 0x001F582A File Offset: 0x001F3A2A
		// (set) Token: 0x060039A3 RID: 14755 RVA: 0x001F5834 File Offset: 0x001F3A34
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

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060039A4 RID: 14756 RVA: 0x001F5877 File Offset: 0x001F3A77
		// (set) Token: 0x060039A5 RID: 14757 RVA: 0x001F5881 File Offset: 0x001F3A81
		internal virtual DateTimePicker DTEnd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060039A6 RID: 14758 RVA: 0x001F588A File Offset: 0x001F3A8A
		// (set) Token: 0x060039A7 RID: 14759 RVA: 0x001F5894 File Offset: 0x001F3A94
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x001F589D File Offset: 0x001F3A9D
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x001F58A7 File Offset: 0x001F3AA7
		internal virtual DateTimePicker DTStart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060039AA RID: 14762 RVA: 0x001F58B0 File Offset: 0x001F3AB0
		// (set) Token: 0x060039AB RID: 14763 RVA: 0x001F58BA File Offset: 0x001F3ABA
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x001F58C3 File Offset: 0x001F3AC3
		// (set) Token: 0x060039AD RID: 14765 RVA: 0x001F58CD File Offset: 0x001F3ACD
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x001F58D6 File Offset: 0x001F3AD6
		// (set) Token: 0x060039AF RID: 14767 RVA: 0x001F58E0 File Offset: 0x001F3AE0
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x001F58E9 File Offset: 0x001F3AE9
		// (set) Token: 0x060039B1 RID: 14769 RVA: 0x001F58F4 File Offset: 0x001F3AF4
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

		// Token: 0x060039B2 RID: 14770 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x001F5938 File Offset: 0x001F3B38
		private void LoadActiveRepairs(int vtype)
		{
			this.dgvRepairs.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			bool flag = vtype == 1;
			if (flag)
			{
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"Select * from Repairs where IsCheckedOut<>1 or IsCheckedOut is null and coid=",
					Conversions.ToString(MyProject.Forms.Form1.coid),
					" and branch='",
					MyProject.Forms.Form1.branch,
					"'"
				});
				this.lblinfo.Text = "Showing active Repairs";
			}
			else
			{
				bool flag2 = vtype == 2;
				if (flag2)
				{
					sqlCommand.CommandText = string.Concat(new string[]
					{
						"Select * from Repairs where coid=",
						Conversions.ToString(MyProject.Forms.Form1.coid),
						" and branch='",
						MyProject.Forms.Form1.branch,
						"'"
					});
					this.lblinfo.Text = "Showing all Repairs checked in and checked out";
				}
				else
				{
					bool flag3 = vtype == 3;
					if (flag3)
					{
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"Select * from Repairs where coid=",
							Conversions.ToString(MyProject.Forms.Form1.coid),
							" and branch='",
							MyProject.Forms.Form1.branch,
							"' and DateIn>=convert(date,'",
							this.DTStart.Value.ToString("MM-dd-yyyy"),
							"') and DateIn<=convert(date,'",
							this.DTEnd.Value.ToString("MM-dd-yyyy"),
							"')"
						});
						this.lblinfo.Text = "Showing all Repairs for the period";
					}
				}
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvRepairs.DataSource = dataTable;
			this.dgvRepairs.Columns["Photo1"].Visible = false;
			this.dgvRepairs.Columns["Photo2"].Visible = false;
			this.dgvRepairs.Columns["Photo3"].Visible = false;
			this.dgvRepairs.Columns["PaymentMethodID"].Visible = false;
			this.dgvRepairs.Columns["Rate"].Visible = false;
			this.dgvRepairs.Columns["InBy"].Visible = false;
			this.dgvRepairs.Columns["InDate"].Visible = false;
			this.dgvRepairs.Columns["InMachinename"].Visible = false;
			this.dgvRepairs.Columns["OutDate"].Visible = false;
			this.dgvRepairs.Columns["OutMachinename"].Visible = false;
			this.dgvRepairs.Columns["coid"].Visible = false;
			this.dgvRepairs.Columns["branch"].Visible = false;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Check Out";
			dataGridViewButtonColumn.Text = "Check Out";
			dataGridViewButtonColumn.Name = "Check Out";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvRepairs.Columns.Add(dataGridViewButtonColumn);
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn2.HeaderText = "Reprint Check In";
			dataGridViewButtonColumn2.Text = "Reprint";
			dataGridViewButtonColumn2.Name = "Reprint";
			dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
			this.dgvRepairs.Columns.Add(dataGridViewButtonColumn2);
			DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn3.HeaderText = "Reprint Check Out";
			dataGridViewButtonColumn3.Text = "Reprint Check Out";
			dataGridViewButtonColumn3.Name = "Reprint Check Out";
			dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
			this.dgvRepairs.Columns.Add(dataGridViewButtonColumn3);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x001F5D68 File Offset: 0x001F3F68
		private void RepairsView_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadActiveRepairs(1);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x001F5DB8 File Offset: 0x001F3FB8
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadActiveRepairs(2);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading all repairs. Detail: " + ex.Message);
			}
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x001F5E08 File Offset: 0x001F4008
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadActiveRepairs(3);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x001F5E58 File Offset: 0x001F4058
		private void dgvRepairs_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Reprint", false) == 0;
					if (flag2)
					{
						RepairsCheckIn repairsCheckIn = new RepairsCheckIn();
						repairsCheckIn.CheckInEntryno = Conversions.ToInteger(this.dgvRepairs.Rows[e.RowIndex].Cells["EntryNo"].Value);
						repairsCheckIn.ShowDialog(this);
						repairsCheckIn.Dispose();
					}
					else
					{
						bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Check Out", false) == 0;
						if (flag3)
						{
							DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to Check Out this product? " + dataGridView.Rows[e.RowIndex].Cells["ProductDesc"].Value.ToString(), MsgBoxStyle.YesNo, null);
							bool flag4 = dialogResult == DialogResult.Yes;
							if (flag4)
							{
								string text = "Enter the Technicians Comments";
								string text2 = "Technician Comment";
								string text3 = Interaction.InputBox(text, text2, "", -1, -1);
								this.CheckOut(Conversions.ToInteger(this.dgvRepairs.Rows[e.RowIndex].Cells["EntryNo"].Value), text3);
								ReparisCheckOut reparisCheckOut = new ReparisCheckOut();
								reparisCheckOut.CheckInEntryNo = Conversions.ToInteger(this.dgvRepairs.Rows[e.RowIndex].Cells["EntryNo"].Value);
								reparisCheckOut.ShowDialog(this);
								reparisCheckOut.Dispose();
							}
						}
						else
						{
							bool flag5 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Reprint Check Out", false) == 0;
							if (flag5)
							{
								bool flag6 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvRepairs.Rows[e.RowIndex].Cells["IsCheckedOut"].Value)), false, RuntimeHelpers.GetObjectValue(this.dgvRepairs.Rows[e.RowIndex].Cells["IsCheckedOut"].Value)), true, false);
								if (flag6)
								{
									ReparisCheckOut reparisCheckOut2 = new ReparisCheckOut();
									reparisCheckOut2.CheckInEntryNo = Conversions.ToInteger(this.dgvRepairs.Rows[e.RowIndex].Cells["EntryNo"].Value);
									reparisCheckOut2.ShowDialog(this);
									reparisCheckOut2.Dispose();
								}
								else
								{
									MessageBox.Show("Product has not been checked out yet.");
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x001F6190 File Offset: 0x001F4390
		private void CheckOut(int entryno, string techcomment)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "RepairsCheckOut";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("techcomment", techcomment);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("donedate", DateTime.Now);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04001898 RID: 6296
		private string _cnn;
	}
}
