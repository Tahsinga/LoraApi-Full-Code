using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000065 RID: 101
	[DesignerGenerated]
	public partial class GoodsReveivedV : UserControl
	{
		// Token: 0x06001598 RID: 5528 RVA: 0x000CA598 File Offset: 0x000C8798
		public GoodsReveivedV()
		{
			base.Load += this.GoodsReveivedV_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x000CAFAF File Offset: 0x000C91AF
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x000CAFB9 File Offset: 0x000C91B9
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x000CAFC2 File Offset: 0x000C91C2
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x000CAFCC File Offset: 0x000C91CC
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x000CAFD5 File Offset: 0x000C91D5
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x000CAFE0 File Offset: 0x000C91E0
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x000CB023 File Offset: 0x000C9223
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x000CB02D File Offset: 0x000C922D
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x000CB036 File Offset: 0x000C9236
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x000CB040 File Offset: 0x000C9240
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000CB049 File Offset: 0x000C9249
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x000CB053 File Offset: 0x000C9253
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000CB05C File Offset: 0x000C925C
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x000CB066 File Offset: 0x000C9266
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000CB06F File Offset: 0x000C926F
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x000CB079 File Offset: 0x000C9279
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x000CB082 File Offset: 0x000C9282
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x000CB08C File Offset: 0x000C928C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x000CB095 File Offset: 0x000C9295
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x000CB09F File Offset: 0x000C929F
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x000CB0A8 File Offset: 0x000C92A8
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x000CB0B4 File Offset: 0x000C92B4
		internal virtual DataGridView DGVPurchases
		{
			[CompilerGenerated]
			get
			{
				return this._DGVPurchases;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVPurchases_CellContentClick);
				DataGridView dataGridView = this._DGVPurchases;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._DGVPurchases = value;
				dataGridView = this._DGVPurchases;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000CB0F7 File Offset: 0x000C92F7
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x000CB101 File Offset: 0x000C9301
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000CB10A File Offset: 0x000C930A
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x000CB114 File Offset: 0x000C9314
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x000CB11D File Offset: 0x000C931D
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x000CB127 File Offset: 0x000C9327
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x000CB130 File Offset: 0x000C9330
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x000CB13A File Offset: 0x000C933A
		internal virtual BindingSource GetPurchasesForSupplierBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x000CB143 File Offset: 0x000C9343
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x000CB14D File Offset: 0x000C934D
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x000CB156 File Offset: 0x000C9356
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x000CB160 File Offset: 0x000C9360
		internal virtual GetPurchasesForSupplierTableAdapter GetPurchasesForSupplierTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x000CB169 File Offset: 0x000C9369
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x000CB174 File Offset: 0x000C9374
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

		// Token: 0x060015BF RID: 5567 RVA: 0x000CB1B8 File Offset: 0x000C93B8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetPurchasesForPeriodHeaders";
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd")));
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				this.DGVPurchases.DataSource = dataTable;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View GRV";
				dataGridViewButtonColumn.Text = "View GRV";
				dataGridViewButtonColumn.Name = "View";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.DGVPurchases.Columns.Insert(3, dataGridViewButtonColumn);
				this.DGVPurchases.Columns["trandate"].Visible = false;
				this.DGVPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying distinct purchases. Detail: " + ex.Message);
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000CB374 File Offset: 0x000C9574
		private void DGVPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
							this.GetPurchasesForSupplierTableAdapter.Connection = sqlConnection;
							ReportParameter reportParameter = new ReportParameter("datereceived", Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Tran_Date"].Value));
							ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
							ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
							ReportParameter reportParameter4 = new ReportParameter("ref", Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Reference"].Value));
							ReportParameter reportParameter5 = new ReportParameter("suppliername", Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Supplier_Name"].Value));
							ReportParameter[] array = new ReportParameter[] { reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter };
							this.ReportViewer1.LocalReport.SetParameters(array);
							this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
							this.GetPurchasesForSupplierTableAdapter.Fill(this.POSDataSet.GetPurchasesForSupplier, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.DGVPurchases.Rows[e.RowIndex].Cells["Reference"].Value.ToString(), this.DGVPurchases.Rows[e.RowIndex].Cells["Supplier_Name"].Value.ToString(), new int?(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.DGVPurchases.Rows[e.RowIndex].Cells["trandate"].Value))));
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
				MessageBox.Show("error displaying report. Detail: " + ex2.Message);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000CB6AC File Offset: 0x000C98AC
		private void GoodsReveivedV_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboBranch.DataSource = this.pf.LoadBranches(this._cnn);
				this.cboBranch.DisplayMember = "branch";
				this.cboBranch.ValueMember = "branch";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x04000AE4 RID: 2788
		private string _cnn;

		// Token: 0x04000AE5 RID: 2789
		private PublicFunctions pf;
	}
}
