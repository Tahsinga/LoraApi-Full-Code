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
	// Token: 0x02000200 RID: 512
	[DesignerGenerated]
	public partial class TellerDisbursements : Form
	{
		// Token: 0x06005C0B RID: 23563 RVA: 0x0034ECB4 File Offset: 0x0034CEB4
		public TellerDisbursements()
		{
			base.Load += this.TellerDisbursements_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x0034F449 File Offset: 0x0034D649
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x0034F454 File Offset: 0x0034D654
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

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x0034F497 File Offset: 0x0034D697
		// (set) Token: 0x06005C11 RID: 23569 RVA: 0x0034F4A1 File Offset: 0x0034D6A1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x0034F4AA File Offset: 0x0034D6AA
		// (set) Token: 0x06005C13 RID: 23571 RVA: 0x0034F4B4 File Offset: 0x0034D6B4
		internal virtual ComboBox cboSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06005C14 RID: 23572 RVA: 0x0034F4BD File Offset: 0x0034D6BD
		// (set) Token: 0x06005C15 RID: 23573 RVA: 0x0034F4C7 File Offset: 0x0034D6C7
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x0034F4D0 File Offset: 0x0034D6D0
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x0034F4DA File Offset: 0x0034D6DA
		internal virtual TextBox txtreason
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x0034F4E3 File Offset: 0x0034D6E3
		// (set) Token: 0x06005C19 RID: 23577 RVA: 0x0034F4ED File Offset: 0x0034D6ED
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06005C1A RID: 23578 RVA: 0x0034F4F6 File Offset: 0x0034D6F6
		// (set) Token: 0x06005C1B RID: 23579 RVA: 0x0034F500 File Offset: 0x0034D700
		internal virtual Label lblBalance
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x0034F509 File Offset: 0x0034D709
		// (set) Token: 0x06005C1D RID: 23581 RVA: 0x0034F514 File Offset: 0x0034D714
		internal virtual TextBox txtAmount
		{
			[CompilerGenerated]
			get
			{
				return this._txtAmount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmount_KeyPress);
				TextBox textBox = this._txtAmount;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAmount = value;
				textBox = this._txtAmount;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x0034F557 File Offset: 0x0034D757
		// (set) Token: 0x06005C1F RID: 23583 RVA: 0x0034F561 File Offset: 0x0034D761
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x0034F56A File Offset: 0x0034D76A
		// (set) Token: 0x06005C21 RID: 23585 RVA: 0x0034F574 File Offset: 0x0034D774
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x0034F57D File Offset: 0x0034D77D
		// (set) Token: 0x06005C23 RID: 23587 RVA: 0x0034F588 File Offset: 0x0034D788
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

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06005C24 RID: 23588 RVA: 0x0034F5CB File Offset: 0x0034D7CB
		// (set) Token: 0x06005C25 RID: 23589 RVA: 0x0034F5D5 File Offset: 0x0034D7D5
		internal virtual ComboBox cboPaymentMethods
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x0034F5E0 File Offset: 0x0034D7E0
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
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x0034F680 File Offset: 0x0034D880
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboSource.Text, "Cash Sales", false) == 0;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cboSource.Text, "Accounts Payments", false) == 0;
					if (flag2)
					{
						num = 1;
					}
				}
				this.Disburse(MyProject.Forms.Form1.username, Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")), this.txtreason.Text, Conversions.ToInteger(this.cboPaymentMethods.SelectedValue), num, Conversion.Val(this.txtAmount.Text));
				MessageBox.Show("Funds disbursed successfully.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error disbursing funds. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x0034F770 File Offset: 0x0034D970
		private void Disburse(string username, int trandate, string reason, int paymentmethod, int source, double amount)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TellerDisburseFunds";
			sqlCommand.Parameters.AddWithValue("username", username);
			sqlCommand.Parameters.AddWithValue("trandate", trandate);
			sqlCommand.Parameters.AddWithValue("paymentmethod", paymentmethod);
			sqlCommand.Parameters.AddWithValue("source", source);
			sqlCommand.Parameters.AddWithValue("amount", amount);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x0034F84C File Offset: 0x0034DA4C
		private void TellerDisbursements_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadPaymentMethods();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form.");
			}
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x0034F890 File Offset: 0x0034DA90
		private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = ~(((-(((char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8)) > false) ? 1 : 0)) ? 1 : 0) | Strings.Asc(Conversions.ToString(Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0))) != 0;
		}

		// Token: 0x04002853 RID: 10323
		private string _cnn;
	}
}
