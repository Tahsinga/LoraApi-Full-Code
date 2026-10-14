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
	// Token: 0x0200005B RID: 91
	[DesignerGenerated]
	public partial class FloatManagement : Form
	{
		// Token: 0x060012FB RID: 4859 RVA: 0x000B5238 File Offset: 0x000B3438
		public FloatManagement()
		{
			base.Load += this.FloatManagement_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x000B64BE File Offset: 0x000B46BE
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x000B64C8 File Offset: 0x000B46C8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x000B64D1 File Offset: 0x000B46D1
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x000B64DB File Offset: 0x000B46DB
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x000B64E4 File Offset: 0x000B46E4
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x000B64F0 File Offset: 0x000B46F0
		internal virtual ComboBox cboTranType
		{
			[CompilerGenerated]
			get
			{
				return this._cboTranType;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboTranType_SelectedIndexChanged);
				ComboBox comboBox = this._cboTranType;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboTranType = value;
				comboBox = this._cboTranType;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x000B6533 File Offset: 0x000B4733
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x000B653D File Offset: 0x000B473D
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x000B6546 File Offset: 0x000B4746
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x000B6550 File Offset: 0x000B4750
		internal virtual TextBox txtComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x000B6559 File Offset: 0x000B4759
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x000B6564 File Offset: 0x000B4764
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

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x000B65A7 File Offset: 0x000B47A7
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x000B65B1 File Offset: 0x000B47B1
		internal virtual Label lblEffectiveAmtPaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x000B65BA File Offset: 0x000B47BA
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x000B65C4 File Offset: 0x000B47C4
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x000B65CD File Offset: 0x000B47CD
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x000B65D8 File Offset: 0x000B47D8
		internal virtual TextBox txtAmtPaid
		{
			[CompilerGenerated]
			get
			{
				return this._txtAmtPaid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtAmtPaid_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmtPaid_KeyPress);
				TextBox textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAmtPaid = value;
				textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x000B6636 File Offset: 0x000B4836
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x000B6640 File Offset: 0x000B4840
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x000B6649 File Offset: 0x000B4849
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x000B6653 File Offset: 0x000B4853
		internal virtual Label lblRate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x000B665C File Offset: 0x000B485C
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x000B6666 File Offset: 0x000B4866
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x000B666F File Offset: 0x000B486F
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x000B667C File Offset: 0x000B487C
		internal virtual ComboBox cboPaymentMethods
		{
			[CompilerGenerated]
			get
			{
				return this._cboPaymentMethods;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPaymentMethods_SelectedIndexChanged);
				ComboBox comboBox = this._cboPaymentMethods;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPaymentMethods = value;
				comboBox = this._cboPaymentMethods;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x000B66BF File Offset: 0x000B48BF
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x000B66C9 File Offset: 0x000B48C9
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x000B66D2 File Offset: 0x000B48D2
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x000B66DC File Offset: 0x000B48DC
		internal virtual ComboBox cboTeller
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x000B66E5 File Offset: 0x000B48E5
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x000B66EF File Offset: 0x000B48EF
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x000B66F8 File Offset: 0x000B48F8
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x000B6702 File Offset: 0x000B4902
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000B670B File Offset: 0x000B490B
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x000B6718 File Offset: 0x000B4918
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

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x000B675B File Offset: 0x000B495B
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x000B6765 File Offset: 0x000B4965
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x000B676E File Offset: 0x000B496E
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x000B6778 File Offset: 0x000B4978
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x000B6781 File Offset: 0x000B4981
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x000B678B File Offset: 0x000B498B
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x000B6794 File Offset: 0x000B4994
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x000B679E File Offset: 0x000B499E
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x000B67A7 File Offset: 0x000B49A7
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x000B67B1 File Offset: 0x000B49B1
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x000B67BA File Offset: 0x000B49BA
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x000B67C4 File Offset: 0x000B49C4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x000B67CD File Offset: 0x000B49CD
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x000B67D7 File Offset: 0x000B49D7
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x000B67E0 File Offset: 0x000B49E0
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x000B67EA File Offset: 0x000B49EA
		internal virtual DateTimePicker dtTranDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000B67F3 File Offset: 0x000B49F3
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000B67FD File Offset: 0x000B49FD
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x000B6806 File Offset: 0x000B4A06
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x000B6810 File Offset: 0x000B4A10
		internal virtual DataGridView dgvFloat
		{
			[CompilerGenerated]
			get
			{
				return this._dgvFloat;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvFloat_CellContentClick);
				DataGridView dataGridView = this._dgvFloat;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvFloat = value;
				dataGridView = this._dgvFloat;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x000B6853 File Offset: 0x000B4A53
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x000B685D File Offset: 0x000B4A5D
		internal virtual CheckBox chkAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x000B6866 File Offset: 0x000B4A66
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x000B6870 File Offset: 0x000B4A70
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x000B6879 File Offset: 0x000B4A79
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x000B6883 File Offset: 0x000B4A83
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000B688C File Offset: 0x000B4A8C
		private void cboTranType_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboTranType.Text, "FLOAT COLLECTION", false) == 0;
				if (flag)
				{
					this.ismoneyin = 0;
					this.Button2.Text = "COLLECT FLOAT";
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cboTranType.Text, "NEW FLOAT IN", false) == 0;
					if (flag2)
					{
						this.ismoneyin = 1;
						this.Button2.Text = "ENTER FLOAT IN";
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000B692C File Offset: 0x000B4B2C
		private void LoadPaymentMethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPaymentMethods.DataSource = dataTable;
			this.cboPaymentMethods.ValueMember = "PaymentMethodID";
			this.cboPaymentMethods.DisplayMember = "PaymentMethodDesc";
			this.cboPaymentMethods.SelectedIndex = -1;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000B69D8 File Offset: 0x000B4BD8
		private void FloatManagement_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadPaymentMethods();
				this.LoadUsers();
				bool flag = MyProject.Forms.Form1.backdatevalue == 1;
				if (flag)
				{
					this.dtTranDate.Enabled = true;
				}
				else
				{
					this.dtTranDate.Enabled = false;
				}
				this.cboBranches.DataSource = MyProject.Forms.Form1.allBranches;
				this.cboBranches.ValueMember = "branch";
				this.cboBranches.DisplayMember = "branch";
				this.cboBranches.SelectedIndex = this.cboBranches.FindStringExact(MyProject.Forms.Form1.branch);
				this.LoadFloatTransactions(this.dtTranDate.Value, this.dtTranDate.Value, checked((short)MyProject.Forms.Form1.coid), this.cboBranches.Text, 0);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000B6B08 File Offset: 0x000B4D08
		private void cboPaymentMethods_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetPaymentMethRate";
				sqlCommand.Parameters.AddWithValue("paymethid", RuntimeHelpers.GetObjectValue(this.cboPaymentMethods.SelectedValue));
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.lblRate.Text = dataRow["Rate"].ToString();
					this.CalcEffectiveAmt();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000B6BFC File Offset: 0x000B4DFC
		private void CalcEffectiveAmt()
		{
			this.lblEffectiveAmtPaid.Text = decimal.Divide(Convert.ToDecimal(this.txtAmtPaid.Text), Convert.ToDecimal(this.lblRate.Text)).ToString();
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000B6C44 File Offset: 0x000B4E44
		private void txtAmtPaid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcEffectiveAmt();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000B6C7C File Offset: 0x000B4E7C
		private void LoadUsers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboTeller.DataSource = dataTable;
			this.cboTeller.ValueMember = "Username";
			this.cboTeller.DisplayMember = "UserName";
			this.cboTeller.SelectedIndex = -1;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000B6D28 File Offset: 0x000B4F28
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.cboTranType.Text, "", false) != 0) | (Operators.CompareString(this.cboTeller.Text, "", false) != 0);
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "InsertFloatMgt";
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
					sqlCommand.Parameters.AddWithValue("trantype", this.cboTranType.Text);
					sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPaymentMethods.SelectedValue));
					sqlCommand.Parameters.AddWithValue("amount", Convert.ToDecimal(this.lblRate.Text));
					sqlCommand.Parameters.AddWithValue("comment", this.txtComment.Text);
					sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
					sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
					sqlCommand.Parameters.AddWithValue("ismoneyin", this.ismoneyin);
					sqlCommand.Parameters.AddWithValue("TILL", this.cboTeller.Text);
					sqlCommand.Parameters.AddWithValue("rate", Convert.ToDecimal(this.lblRate.Text));
					sqlCommand.Parameters.AddWithValue("trandate", this.dtTranDate.Value);
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					this.LoadFloatTransactions(this.dtTranDate.Value, this.dtTranDate.Value, checked((short)MyProject.Forms.Form1.coid), this.cboBranches.Text, 0);
					MessageBox.Show("Transaction processed.");
					this.clearform();
				}
				else
				{
					MessageBox.Show("Please select a Transaction Type Or Teller first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error sving transaction. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000B6FEC File Offset: 0x000B51EC
		private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000B7038 File Offset: 0x000B5238
		private void LoadFloatTransactions(DateTime lastartdate, DateTime laenddate, short coid, string branch, int alltrans)
		{
			this.dgvFloat.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetFloatTransactions";
			sqlCommand.Parameters.AddWithValue("startdate", lastartdate);
			sqlCommand.Parameters.AddWithValue("enddate", laenddate);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("alltransactions", alltrans);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvFloat.DataSource = dataTable;
			this.dgvFloat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvFloat.Columns["EntryNo"].Visible = false;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.Name = "colDel";
			dataGridViewButtonColumn.HeaderText = "Delete Float Transaction";
			dataGridViewButtonColumn.Text = "Delete";
			this.dgvFloat.Columns.Add(dataGridViewButtonColumn);
			bool flag = alltrans == 1;
			string text;
			if (flag)
			{
				text = "All Float Transactions";
			}
			else
			{
				text = "Active Float Transactions";
			}
			this.GroupBox2.Text = string.Concat(new string[]
			{
				"Showing ",
				text,
				" for branch ",
				branch,
				" and period starting: ",
				Conversions.ToString(lastartdate),
				" ending ",
				Conversions.ToString(laenddate)
			});
			bool flag2 = num == 0;
			if (flag2)
			{
				MessageBox.Show("There are no transactions for the period to show.");
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000B720C File Offset: 0x000B540C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkAll.Checked;
				int num;
				if (@checked)
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				this.LoadFloatTransactions(this.DTStartDate.Value, this.DTEndDate.Value, checked((short)MyProject.Forms.Form1.coid), this.cboBranches.Text, num);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error retrieving data. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000B72A4 File Offset: 0x000B54A4
		private void dgvFloat_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					this.DeleteFloatTransaction(Conversions.ToInteger(this.dgvFloat.Rows[e.RowIndex].Cells["EntryNo"].Value), MyProject.Forms.Form1.username, Environment.MachineName);
					this.LoadFloatTransactions(this.dtTranDate.Value, this.dtTranDate.Value, checked((short)MyProject.Forms.Form1.coid), this.cboBranches.Text, 0);
					MessageBox.Show("Transaction marked as deleted.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x000B73B0 File Offset: 0x000B55B0
		private void DeleteFloatTransaction(int entryno, string deletedby, string deletedmachinename)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteFloatTransaction";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("deletedby", deletedby);
			sqlCommand.Parameters.AddWithValue("deletedmachinename", deletedmachinename);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000B7458 File Offset: 0x000B5658
		private void clearform()
		{
			this.cboTeller.SelectedIndex = -1;
			this.cboTranType.SelectedIndex = -1;
			this.cboPaymentMethods.SelectedIndex = -1;
			this.txtAmtPaid.Text = "";
			this.txtComment.Text = "";
		}

		// Token: 0x04000907 RID: 2311
		private int ismoneyin;

		// Token: 0x04000908 RID: 2312
		private string _cnn;
	}
}
