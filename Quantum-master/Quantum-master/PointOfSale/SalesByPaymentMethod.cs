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
	// Token: 0x02000197 RID: 407
	[DesignerGenerated]
	public partial class SalesByPaymentMethod : UserControl
	{
		// Token: 0x0600484E RID: 18510 RVA: 0x002C049E File Offset: 0x002BE69E
		public SalesByPaymentMethod()
		{
			base.Load += this.SalesByPaymentMethod_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x002C10DE File Offset: 0x002BF2DE
		// (set) Token: 0x06004852 RID: 18514 RVA: 0x002C10E8 File Offset: 0x002BF2E8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x002C10F1 File Offset: 0x002BF2F1
		// (set) Token: 0x06004854 RID: 18516 RVA: 0x002C10FC File Offset: 0x002BF2FC
		internal virtual ComboBox cboUsers
		{
			[CompilerGenerated]
			get
			{
				return this._cboUsers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				ComboBox comboBox = this._cboUsers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboUsers = value;
				comboBox = this._cboUsers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x002C113F File Offset: 0x002BF33F
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x002C1149 File Offset: 0x002BF349
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x002C1152 File Offset: 0x002BF352
		// (set) Token: 0x06004858 RID: 18520 RVA: 0x002C115C File Offset: 0x002BF35C
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x002C1165 File Offset: 0x002BF365
		// (set) Token: 0x0600485A RID: 18522 RVA: 0x002C116F File Offset: 0x002BF36F
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x002C1178 File Offset: 0x002BF378
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x002C1182 File Offset: 0x002BF382
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x002C118B File Offset: 0x002BF38B
		// (set) Token: 0x0600485E RID: 18526 RVA: 0x002C1195 File Offset: 0x002BF395
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x002C119E File Offset: 0x002BF39E
		// (set) Token: 0x06004860 RID: 18528 RVA: 0x002C11A8 File Offset: 0x002BF3A8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x002C11B1 File Offset: 0x002BF3B1
		// (set) Token: 0x06004862 RID: 18530 RVA: 0x002C11BB File Offset: 0x002BF3BB
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x002C11C4 File Offset: 0x002BF3C4
		// (set) Token: 0x06004864 RID: 18532 RVA: 0x002C11CE File Offset: 0x002BF3CE
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x002C11D7 File Offset: 0x002BF3D7
		// (set) Token: 0x06004866 RID: 18534 RVA: 0x002C11E1 File Offset: 0x002BF3E1
		internal virtual ComboBox cboPaymentMethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x002C11EA File Offset: 0x002BF3EA
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x002C11F4 File Offset: 0x002BF3F4
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x002C11FD File Offset: 0x002BF3FD
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x002C1208 File Offset: 0x002BF408
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x002C124B File Offset: 0x002BF44B
		// (set) Token: 0x0600486C RID: 18540 RVA: 0x002C1255 File Offset: 0x002BF455
		internal virtual CheckBox chkAllUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x002C125E File Offset: 0x002BF45E
		// (set) Token: 0x0600486E RID: 18542 RVA: 0x002C1268 File Offset: 0x002BF468
		internal virtual Button btnRun
		{
			[CompilerGenerated]
			get
			{
				return this._btnRun;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnRun_Click);
				Button button = this._btnRun;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnRun = value;
				button = this._btnRun;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x002C12AB File Offset: 0x002BF4AB
		// (set) Token: 0x06004870 RID: 18544 RVA: 0x002C12B5 File Offset: 0x002BF4B5
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06004871 RID: 18545 RVA: 0x002C12BE File Offset: 0x002BF4BE
		// (set) Token: 0x06004872 RID: 18546 RVA: 0x002C12C8 File Offset: 0x002BF4C8
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x002C12D1 File Offset: 0x002BF4D1
		// (set) Token: 0x06004874 RID: 18548 RVA: 0x002C12DB File Offset: 0x002BF4DB
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x002C12E4 File Offset: 0x002BF4E4
		// (set) Token: 0x06004876 RID: 18550 RVA: 0x002C12EE File Offset: 0x002BF4EE
		internal virtual BindingSource SalesForPeriodByPaymentMethodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06004877 RID: 18551 RVA: 0x002C12F7 File Offset: 0x002BF4F7
		// (set) Token: 0x06004878 RID: 18552 RVA: 0x002C1301 File Offset: 0x002BF501
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x002C130A File Offset: 0x002BF50A
		// (set) Token: 0x0600487A RID: 18554 RVA: 0x002C1314 File Offset: 0x002BF514
		internal virtual SalesForPeriodByPaymentMethodTableAdapter SalesForPeriodByPaymentMethodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00002A30 File Offset: 0x00000C30
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x002C1320 File Offset: 0x002BF520
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

		// Token: 0x0600487D RID: 18557 RVA: 0x002C13E4 File Offset: 0x002BF5E4
		private void LoadUsers(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.cboUsers.DataSource = dataTable;
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.ValueMember = "Username";
			}
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x002C1484 File Offset: 0x002BF684
		private void runreport()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.SalesForPeriodByPaymentMethodTableAdapter.Connection = sqlConnection;
			ReportParameter reportParameter = new ReportParameter("shiftdateEndDesc", this.DTEnddate.Value.ToShortDateString());
			ReportParameter reportParameter2 = new ReportParameter("shiftdateStartDesc", this.DTStartdate.Value.ToShortDateString());
			ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
			ReportParameter reportParameter4 = new ReportParameter("theuser", Conversions.ToString(Interaction.IIf(this.chkAllUsers.Checked, "All Users", this.cboUsers.Text)));
			ReportParameter reportParameter5 = new ReportParameter("showall", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkAllUsers.Checked, 1, 0))));
			ReportParameter reportParameter6 = new ReportParameter("paymethoddesc", this.cboPaymentMethod.Text);
			ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.SalesForPeriodByPaymentMethodTableAdapter.Fill(this.POSDataSet.SalesForPeriodByPaymentMethod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), Conversions.ToString(Interaction.IIf(this.chkAllUsers.Checked, null, this.cboUsers.Text)), (int?)this.cboPaymentMethod.SelectedValue);
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x002C1698 File Offset: 0x002BF898
		private void btnRun_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.ConditionalCompareObjectEqual(this.cboPaymentMethod.SelectedValue, -1, false);
				if (flag)
				{
					MessageBox.Show("Please select a payment method first.");
				}
				else
				{
					bool flag2 = !this.chkAllUsers.Checked;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(this.cboUsers.Text, "", false) == 0;
						if (flag3)
						{
							MessageBox.Show("Please select a user first.");
							return;
						}
					}
					bool flag4 = Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd")) < Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"));
					if (flag4)
					{
						MessageBox.Show("The end date is older than the start date. Please correct.");
					}
					else
					{
						this.runreport();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x002C17A8 File Offset: 0x002BF9A8
		private void SalesByPaymentMethod_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadUsers(MyProject.Forms.Form1.coid);
				PublicFunctions publicFunctions = new PublicFunctions();
				this.cboPaymentMethod.DataSource = publicFunctions.GetPaymentMethods(this._cnn);
				this.cboPaymentMethod.DisplayMember = "PaymentMethodDesc";
				this.cboPaymentMethod.ValueMember = "PaymentMethodID";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04001FBC RID: 8124
		private string _cnn;
	}
}
