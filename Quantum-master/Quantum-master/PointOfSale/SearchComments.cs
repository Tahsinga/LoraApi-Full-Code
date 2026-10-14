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

namespace PointOfSale
{
	// Token: 0x020001B5 RID: 437
	[DesignerGenerated]
	public partial class SearchComments : Form
	{
		// Token: 0x06004F60 RID: 20320 RVA: 0x002F8388 File Offset: 0x002F6588
		public SearchComments()
		{
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x002F8AE0 File Offset: 0x002F6CE0
		// (set) Token: 0x06004F64 RID: 20324 RVA: 0x002F8AEA File Offset: 0x002F6CEA
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06004F65 RID: 20325 RVA: 0x002F8AF3 File Offset: 0x002F6CF3
		// (set) Token: 0x06004F66 RID: 20326 RVA: 0x002F8B00 File Offset: 0x002F6D00
		internal virtual DataGridView dgvResult
		{
			[CompilerGenerated]
			get
			{
				return this._dgvResult;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvResult_CellContentClick);
				DataGridView dataGridView = this._dgvResult;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvResult = value;
				dataGridView = this._dgvResult;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06004F67 RID: 20327 RVA: 0x002F8B43 File Offset: 0x002F6D43
		// (set) Token: 0x06004F68 RID: 20328 RVA: 0x002F8B50 File Offset: 0x002F6D50
		internal virtual TextBox txtSearch
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				TextBox textBox = this._txtSearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearch = value;
				textBox = this._txtSearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06004F69 RID: 20329 RVA: 0x002F8B93 File Offset: 0x002F6D93
		// (set) Token: 0x06004F6A RID: 20330 RVA: 0x002F8B9D File Offset: 0x002F6D9D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06004F6B RID: 20331 RVA: 0x002F8BA6 File Offset: 0x002F6DA6
		// (set) Token: 0x06004F6C RID: 20332 RVA: 0x002F8BB0 File Offset: 0x002F6DB0
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

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06004F6D RID: 20333 RVA: 0x002F8BF3 File Offset: 0x002F6DF3
		// (set) Token: 0x06004F6E RID: 20334 RVA: 0x002F8BFD File Offset: 0x002F6DFD
		internal virtual CheckBox chkAllDates
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06004F6F RID: 20335 RVA: 0x002F8C06 File Offset: 0x002F6E06
		// (set) Token: 0x06004F70 RID: 20336 RVA: 0x002F8C10 File Offset: 0x002F6E10
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06004F71 RID: 20337 RVA: 0x002F8C19 File Offset: 0x002F6E19
		// (set) Token: 0x06004F72 RID: 20338 RVA: 0x002F8C23 File Offset: 0x002F6E23
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x002F8C2C File Offset: 0x002F6E2C
		// (set) Token: 0x06004F74 RID: 20340 RVA: 0x002F8C36 File Offset: 0x002F6E36
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06004F75 RID: 20341 RVA: 0x002F8C3F File Offset: 0x002F6E3F
		// (set) Token: 0x06004F76 RID: 20342 RVA: 0x002F8C49 File Offset: 0x002F6E49
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x002F8C52 File Offset: 0x002F6E52
		// (set) Token: 0x06004F78 RID: 20344 RVA: 0x002F8C5C File Offset: 0x002F6E5C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x002F8C68 File Offset: 0x002F6E68
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtSearch.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter the search text first.");
					this.txtSearch.Focus();
				}
				else
				{
					this.LoadResults();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x002F8CF0 File Offset: 0x002F6EF0
		private void LoadResults()
		{
			Cursor.Current = Cursors.WaitCursor;
			this.dgvResult.Columns.Clear();
			DataTable dataTable = this.pf.SearchInvoiceComments(MyProject.Forms.Form1.Constring, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtSearch.Text, Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd")), Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd")), Conversions.ToInteger(Interaction.IIf(this.chkAllDates.Checked, 1, 0)));
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				this.dgvResult.DataSource = dataTable;
				this.dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dataGridViewButtonColumn.HeaderText = "View Invoice";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "view";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvResult.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				this.dgvResult.DataSource = dataTable;
				this.dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dataGridViewButtonColumn2.HeaderText = "Edit Comment";
				dataGridViewButtonColumn2.Text = "Edit";
				dataGridViewButtonColumn2.Name = "Edit";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvResult.Columns.Add(dataGridViewButtonColumn2);
			}
			else
			{
				MessageBox.Show("There are no invoices that match the comments search.");
				DataTable dataTable2 = new DataTable();
				this.dgvResult.Columns.Clear();
				this.dgvResult.DataSource = dataTable2;
			}
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x002F8ED4 File Offset: 0x002F70D4
		private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "view", false) == 0;
					if (flag2)
					{
						SalesInvoicePortrait salesInvoicePortrait = new SalesInvoicePortrait();
						salesInvoicePortrait.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["InvoiceNumber"].Value));
						salesInvoicePortrait.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["InvoiceNumber"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
						salesInvoicePortrait.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
						salesInvoicePortrait.reprint = 1;
						salesInvoicePortrait.branch = MyProject.Forms.Form1.branch;
						bool flag3 = MyProject.Forms.Form1.AllowInvDiscount == 1;
						if (flag3)
						{
							salesInvoicePortrait.showinvdisc = 1;
						}
						salesInvoicePortrait.ShowDialog(this);
						salesInvoicePortrait.Dispose();
					}
					else
					{
						bool flag4 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Edit", false) == 0;
						if (flag4)
						{
							bool flag5 = Operators.ConditionalCompareObjectLessEqual(Operators.SubtractObject(dataGridView.Rows[e.RowIndex].Cells["TransactionDate"].Value, Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd"))), 2, false);
							if (flag5)
							{
								EditComment editComment = new EditComment();
								editComment.invdate = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["TransactionDate"].Value);
								editComment.invnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["InvoiceNumber"].Value);
							}
							else
							{
								MessageBox.Show("Invoice is older than 2 days - comments can no loner be edited.");
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

		// Token: 0x04002372 RID: 9074
		private PublicFunctions pf;

		// Token: 0x04002373 RID: 9075
		private string _cnn;
	}
}
