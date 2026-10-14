using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000042 RID: 66
	[DesignerGenerated]
	public partial class DespatchViewCancel : UserControl
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x0008B6D4 File Offset: 0x000898D4
		public DespatchViewCancel()
		{
			base.Load += this.DespatchViewCancel_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.TextToPrint = "";
			this.InitializeComponent();
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0008C2C9 File Offset: 0x0008A4C9
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0008C2D3 File Offset: 0x0008A4D3
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0008C2DC File Offset: 0x0008A4DC
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x0008C2E6 File Offset: 0x0008A4E6
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0008C2EF File Offset: 0x0008A4EF
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x0008C2FC File Offset: 0x0008A4FC
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

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0008C33F File Offset: 0x0008A53F
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x0008C34C File Offset: 0x0008A54C
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0008C38F File Offset: 0x0008A58F
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0008C399 File Offset: 0x0008A599
		internal virtual TextBox txtinvnum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0008C3A2 File Offset: 0x0008A5A2
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x0008C3AC File Offset: 0x0008A5AC
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0008C3B5 File Offset: 0x0008A5B5
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0008C3BF File Offset: 0x0008A5BF
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0008C3C8 File Offset: 0x0008A5C8
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x0008C3D2 File Offset: 0x0008A5D2
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0008C3DB File Offset: 0x0008A5DB
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0008C42B File Offset: 0x0008A62B
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0008C435 File Offset: 0x0008A635
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0008C43E File Offset: 0x0008A63E
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0008C448 File Offset: 0x0008A648
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0008C451 File Offset: 0x0008A651
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0008C45C File Offset: 0x0008A65C
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0008C49F File Offset: 0x0008A69F
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0008C4A9 File Offset: 0x0008A6A9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0008C4B2 File Offset: 0x0008A6B2
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x0008C4BC File Offset: 0x0008A6BC
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0008C4C5 File Offset: 0x0008A6C5
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0008C4CF File Offset: 0x0008A6CF
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0008C4D8 File Offset: 0x0008A6D8
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0008C4E4 File Offset: 0x0008A6E4
		internal virtual DataGridView dgvInvoices
		{
			[CompilerGenerated]
			get
			{
				return this._dgvInvoices;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
				DataGridView dataGridView = this._dgvInvoices;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvInvoices = value;
				dataGridView = this._dgvInvoices;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0008C527 File Offset: 0x0008A727
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x0008C531 File Offset: 0x0008A731
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0008C53C File Offset: 0x0008A73C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.LoadSales();
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading sales for period. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0008C5A4 File Offset: 0x0008A7A4
		private void LoadSales()
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DespatchForPeriodByInvoice";
			sqlCommand.Parameters.AddWithValue("startdate", Conversion.Val(this.DTstart.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Conversion.Val(this.DTend.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvInvoices.DataSource = dataTable;
				this.dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Cancel Despatch";
				dataGridViewButtonColumn.Text = "Cancel";
				dataGridViewButtonColumn.Name = "cancel";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Reprint Despatch";
				dataGridViewButtonColumn2.Text = "Reprint";
				dataGridViewButtonColumn2.Name = "reprint";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn2);
			}
			else
			{
				MessageBox.Show("There are no sales for the period selected.");
				DataTable dataTable2 = new DataTable();
				this.dgvInvoices.DataSource = dataTable2;
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0008C78C File Offset: 0x0008A98C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboBranch.Text, "", false) != 0;
				if (flag)
				{
					this.Cursor = Cursors.WaitCursor;
					this.loadSalesbyInvNumber(checked((int)Math.Round(Conversion.Val(this.txtinvnum.Text))));
					this.Cursor = Cursors.Default;
				}
				else
				{
					MessageBox.Show("Please select the branch first.");
					this.cboBranch.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading sales for period. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0008C844 File Offset: 0x0008AA44
		private void loadSalesbyInvNumber(int invoicenumber)
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DespatchByInvoiceNumberEntered";
			sqlCommand.Parameters.AddWithValue("invoicenumber", invoicenumber);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvInvoices.DataSource = dataTable;
				this.dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Cancel Despatch";
				dataGridViewButtonColumn.Text = "Cancel";
				dataGridViewButtonColumn.Name = "cancel";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Reprint Despatch Note";
				dataGridViewButtonColumn2.Text = "Reprint";
				dataGridViewButtonColumn2.Name = "reprint";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn2);
			}
			else
			{
				SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
				SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
				sqlCommand2.CommandType = CommandType.StoredProcedure;
				sqlCommand2.CommandText = "CheckIfDespatchCancelled";
				sqlCommand2.Parameters.AddWithValue("invoicenumber", invoicenumber);
				sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable2 = new DataTable();
				SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
				int num2 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num2 > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable2.Rows[0];
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					string text = DateTime.ParseExact(dataRow["trandate"].ToString(), "yyyyMMdd", invariantCulture).ToString();
					string text2 = DateTime.ParseExact(dataRow["DateCancelled"].ToString(), "yyyyMMdd", invariantCulture).ToString();
					MessageBox.Show("This invoice has been cancelled. Sale date: " + text.Substring(0, 10) + ", Date cancelled: " + text2.Substring(0, 10));
				}
				else
				{
					MessageBox.Show("Invoice not found.");
					DataTable dataTable3 = new DataTable();
					this.dgvInvoices.DataSource = dataTable3;
				}
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0008CB04 File Offset: 0x0008AD04
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvInvoices.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.Cursor = Cursors.WaitCursor;
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvInvoices, this.SaveFileDialog1.FileName);
						this.Cursor = Cursors.Default;
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

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0008CBD4 File Offset: 0x0008ADD4
		private void GetBranchDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				try
				{
					this.coname = dataRow["CompanyName"].ToString();
					this.coadd = dataRow["Address"].ToString();
					this.cotel = dataRow["Tel"].ToString();
					this.cotel2 = dataRow["Tel2"].ToString();
					this.cotel3 = dataRow["Tel3"].ToString();
					this.coemail = dataRow["Email"].ToString();
					this.cobpnum = dataRow["BPNumber"].ToString();
					this.footnote = dataRow["Footnote"].ToString();
					this.coVATNum = dataRow["VATNumber"].ToString();
					this.bpnum_name = Conversions.ToString(dataRow["BPNumber_name"]);
					this.vatnum_name = Conversions.ToString(dataRow["VATNumber_name"]);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0008CDB4 File Offset: 0x0008AFB4
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

		// Token: 0x06000EBA RID: 3770 RVA: 0x0008CE78 File Offset: 0x0008B078
		private void DespatchViewCancel_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.GetBranchDetails();
				bool isAdmin = MyProject.Forms.Form1.IsAdmin;
				if (isAdmin)
				{
					this.cboBranch.Enabled = true;
				}
				else
				{
					this.cboBranch.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0008CF00 File Offset: 0x0008B100
		private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "reprint", false) == 0;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Do you want to show the Selling Price on the Despatch Note?", MsgBoxStyle.YesNo, null);
						int num = 0;
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							num = 1;
						}
						else
						{
							bool flag4 = dialogResult == DialogResult.No;
							if (flag4)
							{
								num = 0;
							}
						}
						DespatchNoteForm despatchNoteForm = new DespatchNoteForm();
						despatchNoteForm.invnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
						despatchNoteForm.revmax_sign = "";
						despatchNoteForm.isEltradeESDfiscal = 0;
						despatchNoteForm.isfiscal = 1;
						despatchNoteForm.branch = MyProject.Forms.Form1.branch;
						bool flag5 = MyProject.Forms.Form1.AllowInvDiscount == 1;
						if (flag5)
						{
							despatchNoteForm.showinvdisc = 1;
						}
						despatchNoteForm.showSellingPrice = num;
						despatchNoteForm.ShowDialog(this);
						despatchNoteForm.Dispose();
					}
					else
					{
						bool flag6 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "cancel", false) == 0;
						if (flag6)
						{
							DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Are you sure you want to cancel this selected despatch? " + dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value.ToString(), MsgBoxStyle.YesNo, null);
							bool flag7 = dialogResult2 == DialogResult.Yes;
							if (flag7)
							{
								bool flag8 = MyProject.Forms.Form1.IsSupervisor | MyProject.Forms.Form1.IsAdmin;
								if (flag8)
								{
									string text = "Enter the reason for cancellation";
									string text2 = "Despatch Cancellation Reason";
									string text3 = Interaction.InputBox(text, text2, "", -1, -1);
									this.CancelDespatch(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Customer"].Value), text3);
									MessageBox.Show("Despatch Cancelled.");
									this.Cursor = Cursors.WaitCursor;
									this.LoadSales();
									this.Cursor = Cursors.Default;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0008D1DC File Offset: 0x0008B3DC
		private void CancelDespatch(int inv, string customername, string comment)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CancelDespatch";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
			sqlCommand.Parameters.AddWithValue("Cancelledby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("datecancelled", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
			sqlCommand.Parameters.AddWithValue("approval", 0);
			sqlCommand.Parameters.AddWithValue("comment", comment);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04000702 RID: 1794
		private string _cnn;

		// Token: 0x04000703 RID: 1795
		private PublicFunctions pf;

		// Token: 0x04000704 RID: 1796
		private string TextToPrint;

		// Token: 0x04000705 RID: 1797
		private string coname;

		// Token: 0x04000706 RID: 1798
		private string coadd;

		// Token: 0x04000707 RID: 1799
		private string cotel;

		// Token: 0x04000708 RID: 1800
		private string coemail;

		// Token: 0x04000709 RID: 1801
		private string cobpnum;

		// Token: 0x0400070A RID: 1802
		private string cotel2;

		// Token: 0x0400070B RID: 1803
		private string cotel3;

		// Token: 0x0400070C RID: 1804
		private string footnote;

		// Token: 0x0400070D RID: 1805
		private int invnum;

		// Token: 0x0400070E RID: 1806
		private string coVATNum;

		// Token: 0x0400070F RID: 1807
		private string bpnum_name;

		// Token: 0x04000710 RID: 1808
		private string vatnum_name;
	}
}
