using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001FD RID: 509
	[DesignerGenerated]
	public partial class SupplierDeliveries : UserControl
	{
		// Token: 0x06005B81 RID: 23425 RVA: 0x0034B590 File Offset: 0x00349790
		public SupplierDeliveries()
		{
			base.Load += this.SupplierDeliveries_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06005B84 RID: 23428 RVA: 0x0034C0E6 File Offset: 0x0034A2E6
		// (set) Token: 0x06005B85 RID: 23429 RVA: 0x0034C0F0 File Offset: 0x0034A2F0
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x0034C0F9 File Offset: 0x0034A2F9
		// (set) Token: 0x06005B87 RID: 23431 RVA: 0x0034C103 File Offset: 0x0034A303
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06005B88 RID: 23432 RVA: 0x0034C10C File Offset: 0x0034A30C
		// (set) Token: 0x06005B89 RID: 23433 RVA: 0x0034C118 File Offset: 0x0034A318
		internal virtual DataGridView dgvPurchases
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPurchases;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPurchases_CellContentClick);
				DataGridView dataGridView = this._dgvPurchases;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPurchases = value;
				dataGridView = this._dgvPurchases;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06005B8A RID: 23434 RVA: 0x0034C15B File Offset: 0x0034A35B
		// (set) Token: 0x06005B8B RID: 23435 RVA: 0x0034C165 File Offset: 0x0034A365
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x0034C16E File Offset: 0x0034A36E
		// (set) Token: 0x06005B8D RID: 23437 RVA: 0x0034C178 File Offset: 0x0034A378
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x0034C181 File Offset: 0x0034A381
		// (set) Token: 0x06005B8F RID: 23439 RVA: 0x0034C18C File Offset: 0x0034A38C
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

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06005B90 RID: 23440 RVA: 0x0034C1CF File Offset: 0x0034A3CF
		// (set) Token: 0x06005B91 RID: 23441 RVA: 0x0034C1D9 File Offset: 0x0034A3D9
		internal virtual DateTimePicker DTEnd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06005B92 RID: 23442 RVA: 0x0034C1E2 File Offset: 0x0034A3E2
		// (set) Token: 0x06005B93 RID: 23443 RVA: 0x0034C1EC File Offset: 0x0034A3EC
		internal virtual DateTimePicker DTStart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06005B94 RID: 23444 RVA: 0x0034C1F5 File Offset: 0x0034A3F5
		// (set) Token: 0x06005B95 RID: 23445 RVA: 0x0034C1FF File Offset: 0x0034A3FF
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x0034C208 File Offset: 0x0034A408
		// (set) Token: 0x06005B97 RID: 23447 RVA: 0x0034C212 File Offset: 0x0034A412
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x0034C21B File Offset: 0x0034A41B
		// (set) Token: 0x06005B99 RID: 23449 RVA: 0x0034C225 File Offset: 0x0034A425
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x0034C22E File Offset: 0x0034A42E
		// (set) Token: 0x06005B9B RID: 23451 RVA: 0x0034C238 File Offset: 0x0034A438
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06005B9C RID: 23452 RVA: 0x0034C241 File Offset: 0x0034A441
		// (set) Token: 0x06005B9D RID: 23453 RVA: 0x0034C24B File Offset: 0x0034A44B
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x0034C254 File Offset: 0x0034A454
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x0034C25E File Offset: 0x0034A45E
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x0034C267 File Offset: 0x0034A467
		// (set) Token: 0x06005BA1 RID: 23457 RVA: 0x0034C271 File Offset: 0x0034A471
		internal virtual BindingSource GetPurchaseBySupplierDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x0034C27A File Offset: 0x0034A47A
		// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x0034C284 File Offset: 0x0034A484
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x0034C28D File Offset: 0x0034A48D
		// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x0034C297 File Offset: 0x0034A497
		internal virtual GetPurchaseBySupplierDetailsTableAdapter GetPurchaseBySupplierDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06005BA6 RID: 23462 RVA: 0x0034C2A0 File Offset: 0x0034A4A0
		// (set) Token: 0x06005BA7 RID: 23463 RVA: 0x0034C2AC File Offset: 0x0034A4AC
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

		// Token: 0x06005BA8 RID: 23464 RVA: 0x0034C2F0 File Offset: 0x0034A4F0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.dgvPurchases.Columns.Clear();
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetPurchaseBySupplierHeader";
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTStart.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEnd.Value.ToString("yyyyMMdd")));
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				this.dgvPurchases.DataSource = dataTable;
				this.dgvPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Items";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "View";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvPurchases.Columns.Add(dataGridViewButtonColumn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading supply heading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x0034C4A4 File Offset: 0x0034A6A4
		private void dgvPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			checked
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
							try
							{
								SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
								this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
								this.GetPurchaseBySupplierDetailsTableAdapter.Connection = sqlConnection;
								ReportParameter reportParameter = new ReportParameter("SupplierName", Conversions.ToString(this.dgvPurchases.Rows[e.RowIndex].Cells["Supplier_Name"].Value));
								ReportParameter reportParameter2 = new ReportParameter("trandate", Conversions.ToString(this.dgvPurchases.Rows[e.RowIndex].Cells["Transaction_Date"].Value));
								ReportParameter reportParameter3 = new ReportParameter("ref", Conversions.ToString(this.dgvPurchases.Rows[e.RowIndex].Cells["Reference"].Value));
								ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
								this.ReportViewer1.LocalReport.SetParameters(array);
								this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
								this.GetPurchaseBySupplierDetailsTableAdapter.Fill(this.POSDataSet.GetPurchaseBySupplierDetails, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.dgvPurchases.Rows[e.RowIndex].Cells["Reference"].Value.ToString(), this.dgvPurchases.Rows[e.RowIndex].Cells["Supplier_Name"].Value.ToString(), new int?((int)Math.Round(Conversion.Val(this.DTStart.Value.ToString("yyyyMMdd")))), new int?((int)Math.Round(Conversion.Val(this.DTEnd.Value.ToString("yyyyMMdd")))));
								this.ReportViewer1.RefreshReport();
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error displaying report. Detail: " + ex.Message);
							}
						}
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show("Error showing supplier details. Detail: " + ex2.Message);
				}
			}
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x0034C7B4 File Offset: 0x0034A9B4
		private void Label5_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x0034C804 File Offset: 0x0034AA04
		private void LoadBranch()
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
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x0034C8A4 File Offset: 0x0034AAA4
		private void SupplierDeliveries_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranch();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002816 RID: 10262
		private string _cnn;
	}
}
