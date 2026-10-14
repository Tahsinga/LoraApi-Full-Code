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
	// Token: 0x0200003E RID: 62
	[DesignerGenerated]
	public partial class DespatchForCustomer : UserControl
	{
		// Token: 0x06000E0E RID: 3598 RVA: 0x000889D4 File Offset: 0x00086BD4
		public DespatchForCustomer()
		{
			base.Load += this.DespatchForCustomer_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00089414 File Offset: 0x00087614
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00089420 File Offset: 0x00087620
		internal virtual GroupBox GroupBox1
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox1_Enter);
				GroupBox groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox1 = value;
				groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00089463 File Offset: 0x00087663
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x0008946D File Offset: 0x0008766D
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00089476 File Offset: 0x00087676
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x00089480 File Offset: 0x00087680
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

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x000894C3 File Offset: 0x000876C3
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x000894CD File Offset: 0x000876CD
		internal virtual ComboBox cboCustomers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x000894D6 File Offset: 0x000876D6
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x000894E0 File Offset: 0x000876E0
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x000894E9 File Offset: 0x000876E9
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x000894F3 File Offset: 0x000876F3
		internal virtual DateTimePicker DTEnd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000894FC File Offset: 0x000876FC
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00089506 File Offset: 0x00087706
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0008950F File Offset: 0x0008770F
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00089519 File Offset: 0x00087719
		internal virtual DateTimePicker DTStart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00089522 File Offset: 0x00087722
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x0008952C File Offset: 0x0008772C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00089535 File Offset: 0x00087735
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x0008953F File Offset: 0x0008773F
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00089548 File Offset: 0x00087748
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00089552 File Offset: 0x00087752
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0008955B File Offset: 0x0008775B
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00089565 File Offset: 0x00087765
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0008956E File Offset: 0x0008776E
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00089578 File Offset: 0x00087778
		internal virtual BindingSource DespatchForPeriodForCustomerBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00089581 File Offset: 0x00087781
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x0008958B File Offset: 0x0008778B
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00089594 File Offset: 0x00087794
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x0008959E File Offset: 0x0008779E
		internal virtual DespatchForPeriodForCustomerTableAdapter DespatchForPeriodForCustomerTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x000895A7 File Offset: 0x000877A7
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x000895B4 File Offset: 0x000877B4
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

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000895F7 File Offset: 0x000877F7
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00089601 File Offset: 0x00087801
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x0008960A File Offset: 0x0008780A
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00089614 File Offset: 0x00087814
		internal virtual ComboBox cboBranch
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranch_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranch = value;
				comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00089657 File Offset: 0x00087857
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x00089661 File Offset: 0x00087861
		internal virtual BindingSource DespatchForPeriodByInvoiceForCustomerBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0008966A File Offset: 0x0008786A
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00089674 File Offset: 0x00087874
		internal virtual DespatchForPeriodByInvoiceForCustomerTableAdapter DespatchForPeriodByInvoiceForCustomerTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00089680 File Offset: 0x00087880
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboCustomers.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please select the customer first.");
				}
				else
				{
					bool flag2 = DateTime.Compare(this.DTEnd.Value.Date, this.DTStart.Value.Date) < 0;
					if (flag2)
					{
						MessageBox.Show("Please select a start start that is earlier than the end date.");
					}
					else
					{
						Cursor.Current = Cursors.WaitCursor;
						SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
						this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
						this.DespatchForPeriodForCustomerTableAdapter.Connection = sqlConnection;
						this.DespatchForPeriodByInvoiceForCustomerTableAdapter.Connection = sqlConnection;
						ReportParameter reportParameter = new ReportParameter("shiftdateStartDesc", this.DTStart.Value.ToShortDateString());
						ReportParameter reportParameter2 = new ReportParameter("shiftdateEndDesc", this.DTEnd.Value.ToShortDateString());
						ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
						ReportParameter reportParameter4 = new ReportParameter("customername", this.cboCustomers.Text);
						ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
						this.ReportViewer1.LocalReport.SetParameters(array);
						this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
						this.DespatchForPeriodForCustomerTableAdapter.Fill(this.POSDataSet.DespatchForPeriodForCustomer, new int?(Conversions.ToInteger(this.DTStart.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnd.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboCustomers.Text);
						this.DespatchForPeriodByInvoiceForCustomerTableAdapter.Fill(this.POSDataSet.DespatchForPeriodByInvoiceForCustomer, new int?(Conversions.ToInteger(this.DTStart.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnd.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, (int?)this.cboCustomers.SelectedValue);
						this.ReportViewer1.RefreshReport();
						Cursor.Current = Cursors.Default;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00089980 File Offset: 0x00087B80
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
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

		// Token: 0x06000E3D RID: 3645 RVA: 0x00089A50 File Offset: 0x00087C50
		private void LoadCustomers(string thebranch)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", thebranch);
			sqlCommand.Parameters.AddWithValue("showactiveonly", 1);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboCustomers.DataSource = dataTable;
			this.cboCustomers.DisplayMember = "CustomerName";
			this.cboCustomers.ValueMember = "Entryno";
			this.cboCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cboCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboCustomers.SelectedIndex = -1;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00089B4C File Offset: 0x00087D4C
		private void DespatchForCustomer_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadCustomers(MyProject.Forms.Form1.branch);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00089BB0 File Offset: 0x00087DB0
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomers(this.cboBranch.Text);
			}
			catch (Exception ex)
			{
			}
		}
	}
}
