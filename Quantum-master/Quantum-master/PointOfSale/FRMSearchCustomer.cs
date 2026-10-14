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
	// Token: 0x02000061 RID: 97
	[DesignerGenerated]
	public partial class FRMSearchCustomer : Form
	{
		// Token: 0x06001418 RID: 5144 RVA: 0x000BDC4C File Offset: 0x000BBE4C
		public FRMSearchCustomer()
		{
			base.Load += this.FRMSearchCustomer_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x000BE157 File Offset: 0x000BC357
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x000BE161 File Offset: 0x000BC361
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x000BE16A File Offset: 0x000BC36A
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x000BE174 File Offset: 0x000BC374
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

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000BE1B7 File Offset: 0x000BC3B7
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x000BE1C1 File Offset: 0x000BC3C1
		internal virtual TextBox txtSearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x000BE1CA File Offset: 0x000BC3CA
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x000BE1D4 File Offset: 0x000BC3D4
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x000BE1DD File Offset: 0x000BC3DD
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x000BE1E8 File Offset: 0x000BC3E8
		internal virtual DataGridView dgvList
		{
			[CompilerGenerated]
			get
			{
				return this._dgvList;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvList_CellContentClick);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.dgvList_KeyDown);
				DataGridView dataGridView = this._dgvList;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._dgvList = value;
				dataGridView = this._dgvList;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x000BE246 File Offset: 0x000BC446
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x000BE250 File Offset: 0x000BC450
		internal virtual Label lblcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000BE259 File Offset: 0x000BC459
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x000BE263 File Offset: 0x000BC463
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000BE26C File Offset: 0x000BC46C
		private void FRMSearchCustomer_Load(object sender, EventArgs e)
		{
			try
			{
				this.searchName(this.txtSearch.Text, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				base.AcceptButton = this.Button1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error dsplaying form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000BE2F0 File Offset: 0x000BC4F0
		private void searchName(string stext, int coid, string branch)
		{
			this.dgvList.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchCustomerWildcard";
			sqlCommand.Parameters.AddWithValue("searchtext", stext);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvList.DataSource = dataTable;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Select";
				dataGridViewButtonColumn.Text = "Select";
				dataGridViewButtonColumn.Name = "Select";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvList.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Delete";
				dataGridViewButtonColumn2.Text = "Delete";
				dataGridViewButtonColumn2.Name = "Delete";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvList.Columns.Add(dataGridViewButtonColumn2);
				this.dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvList.Columns["EntryNo"].Visible = false;
				this.dgvList.Columns["coid"].Visible = false;
				this.dgvList.Columns["branch"].Visible = false;
				this.dgvList.Columns["Uploaded"].Visible = false;
				this.dgvList.Columns["BPNumber"].Visible = false;
				this.dgvList.Columns["RegisteredCoName"].Visible = false;
				this.dgvList.Columns["VATNumber"].Visible = false;
				this.dgvList.Columns["Sex"].Visible = false;
				this.dgvList.Columns["DOB"].Visible = false;
				this.dgvList.Columns["IDNumber"].Visible = false;
				this.lblcount.Text = num.ToString() + " records found.";
				this.dgvList.Focus();
				this.dgvList.CurrentCell = this.dgvList.Rows[0].Cells["Select"];
				this.dgvList.BeginEdit(true);
			}
			else
			{
				this.lblcount.Text = "No records found.";
				DataTable dataTable2 = new DataTable();
				this.dgvList.DataSource = dataTable2;
				this.txtSearch.Focus();
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000BE5F8 File Offset: 0x000BC7F8
		private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Select", false) == 0;
					if (flag2)
					{
						MyProject.Forms.Form1.SearchCustomer = dataGridView.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
						MyProject.Forms.Form1.SearchCustomerEntryno = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Entryno"].Value);
						base.Close();
					}
					else
					{
						bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
						if (flag3)
						{
							DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete this customer. This cannot be undone?", MsgBoxStyle.YesNo, null);
							bool flag4 = dialogResult == DialogResult.Yes;
							if (flag4)
							{
								bool flag5 = MyProject.Forms.Form1.IsAdmin | MyProject.Forms.Form1.IsSupervisor;
								if (flag5)
								{
									try
									{
										SqlConnection sqlConnection = new SqlConnection(this._cnn);
										SqlCommand sqlCommand = sqlConnection.CreateCommand();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "DeleteCustomer";
										sqlCommand.Parameters.AddWithValue("customername", dataGridView.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString());
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlConnection.Open();
										sqlCommand.ExecuteNonQuery();
										sqlConnection.Close();
										MessageBox.Show("Customer deleted.");
										this.searchName(this.txtSearch.Text, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
									}
									catch (SqlException ex)
									{
										bool flag6 = ex.Number == 547;
										if (flag6)
										{
											MessageBox.Show("Cannot delete Customer who has account sale information.");
										}
										else
										{
											MessageBox.Show("Error. Detail: " + ex.Message);
										}
									}
								}
								else
								{
									MessageBox.Show("Only Supervisors or Admins can delete a customer.");
								}
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error selecting option. Detail: " + ex2.Message);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x000BE918 File Offset: 0x000BCB18
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.searchName(this.txtSearch.Text, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail " + ex.Message);
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x000BE990 File Offset: 0x000BCB90
		private void dgvList_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					DataGridViewRow currentRow = this.dgvList.CurrentRow;
					MyProject.Forms.Form1.SearchCustomer = currentRow.Cells["CustomerName"].Value.ToString();
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keydown error. Continue. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000A3B RID: 2619
		private string _cnn;
	}
}
