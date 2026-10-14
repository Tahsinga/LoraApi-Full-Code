using System;
using System.Collections;
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
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public partial class BillingEnterPaymentfrm : Form
	{
		// Token: 0x06000317 RID: 791 RVA: 0x0001BC04 File Offset: 0x00019E04
		public BillingEnterPaymentfrm()
		{
			base.Load += this.BillingEnterPaymentfrm_Load;
			this.TheCustomerName = "";
			this._cnn = MyProject.Forms.Form1.Constring;
			this.TheShiftDate = 0;
			this.payRef = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001CDBE File Offset: 0x0001AFBE
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0001CDC8 File Offset: 0x0001AFC8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001CDD1 File Offset: 0x0001AFD1
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0001CDDB File Offset: 0x0001AFDB
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0001CDEE File Offset: 0x0001AFEE
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001CDF7 File Offset: 0x0001AFF7
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0001CE01 File Offset: 0x0001B001
		internal virtual DataGridView dgvAccountTransactions
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001CE0A File Offset: 0x0001B00A
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0001CE14 File Offset: 0x0001B014
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001CE1D File Offset: 0x0001B01D
		// (set) Token: 0x06000325 RID: 805 RVA: 0x0001CE27 File Offset: 0x0001B027
		internal virtual TextBox txtAmtPaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001CE30 File Offset: 0x0001B030
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0001CE3A File Offset: 0x0001B03A
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001CE43 File Offset: 0x0001B043
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0001CE4D File Offset: 0x0001B04D
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001CE56 File Offset: 0x0001B056
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0001CE60 File Offset: 0x0001B060
		internal virtual TextBox txtBalance
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001CE69 File Offset: 0x0001B069
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0001CE74 File Offset: 0x0001B074
		internal virtual DataGridView dgvAccPay
		{
			[CompilerGenerated]
			get
			{
				return this._dgvAccPay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvAccPay_CellEndEdit);
				DataGridView dataGridView = this._dgvAccPay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
				}
				this._dgvAccPay = value;
				dataGridView = this._dgvAccPay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001CEB7 File Offset: 0x0001B0B7
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0001CEC1 File Offset: 0x0001B0C1
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001CECA File Offset: 0x0001B0CA
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0001CED4 File Offset: 0x0001B0D4
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0001CF17 File Offset: 0x0001B117
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0001CF21 File Offset: 0x0001B121
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0001CF2A File Offset: 0x0001B12A
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0001CF34 File Offset: 0x0001B134
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001CF3D File Offset: 0x0001B13D
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0001CF47 File Offset: 0x0001B147
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001CF50 File Offset: 0x0001B150
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0001CF5A File Offset: 0x0001B15A
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001CF63 File Offset: 0x0001B163
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0001CF6D File Offset: 0x0001B16D
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001CF76 File Offset: 0x0001B176
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0001CF80 File Offset: 0x0001B180
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001CF89 File Offset: 0x0001B189
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0001CF93 File Offset: 0x0001B193
		internal virtual TextBox txtContactName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001CF9C File Offset: 0x0001B19C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0001CFA6 File Offset: 0x0001B1A6
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001CFAF File Offset: 0x0001B1AF
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0001CFB9 File Offset: 0x0001B1B9
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0001CFC2 File Offset: 0x0001B1C2
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0001CFCC File Offset: 0x0001B1CC
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0001CFD5 File Offset: 0x0001B1D5
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0001CFDF File Offset: 0x0001B1DF
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0001CFE8 File Offset: 0x0001B1E8
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0001CFF2 File Offset: 0x0001B1F2
		internal virtual TextBox txtcustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001CFFC File Offset: 0x0001B1FC
		private void BillingEnterPaymentfrm_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadPaymentMethods();
				this.LoadCustomerDetails(this.TheCustomerName);
				this.GetCustomerTransactions(this.TheCustomerName, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				this.txtBalance.Text = Conversions.ToString(this.GetCustomerBillTotal(this.TheCustomerName, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch));
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error has occurred while loading the form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
		private void LoadCustomerDetails(string customername)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCustomerDetails";
			sqlCommand.Parameters.AddWithValue("CustomerName", customername);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtcustomer.Text = Conversions.ToString(dataRow["CustomerName"]);
				this.txtAddress.Text = Conversions.ToString(dataRow["Address"]);
				this.txtContactName.Text = Conversions.ToString(dataRow["ContactName"]);
				this.txtMobile.Text = Conversions.ToString(dataRow["Mobile"]);
				this.txtEmail.Text = Conversions.ToString(dataRow["Email"]);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001D214 File Offset: 0x0001B414
		private void GetCustomerTransactions(string customername, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCustomerTransactions";
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvAccountTransactions.DataSource = dataTable;
				this.dgvAccountTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
		private double GetCustomerBillTotal(string customername, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingTotalForCustomer";
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			double num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["AccBalance"]));
			}
			else
			{
				num2 = 0.0;
			}
			return num2;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001D38C File Offset: 0x0001B58C
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
			this.dgvAccPay.DataSource = dataTable;
			this.dgvAccPay.Columns["PaymentMethodID"].Visible = false;
			this.dgvAccPay.Columns["Uploaded"].Visible = false;
			this.dgvAccPay.Columns["PaymentMethodDesc"].HeaderText = "Payment Method";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "Amount Paid";
			dataGridViewTextBoxColumn.Name = "QTYcol";
			dataGridViewTextBoxColumn.DataPropertyName = "QTYcol";
			dataGridViewTextBoxColumn.CellTemplate = new DataGridViewTextBoxCell();
			this.dgvAccPay.Columns.Insert(4, dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2.HeaderText = "Actual Amount";
			dataGridViewTextBoxColumn2.Name = "ActCol";
			dataGridViewTextBoxColumn2.DataPropertyName = "ActCol";
			dataGridViewTextBoxColumn2.CellTemplate = new DataGridViewTextBoxCell();
			dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dgvAccPay.Columns.Insert(5, dataGridViewTextBoxColumn2);
			this.dgvAccPay.Columns["PaymentMethodDesc"].ReadOnly = true;
			this.dgvAccPay.Columns["Rate"].ReadOnly = true;
			this.dgvAccPay.Columns["ActCol"].ReadOnly = true;
			this.dgvAccPay.Columns["PaymentMethodDesc"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvAccPay.Columns["Rate"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvAccPay.Columns["ActCol"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvAccPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
		private void dgvAccPay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				double num = 0.0;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAccPay.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["QtyCol"].Value, "", false);
						if (flag)
						{
							double num2 = Conversions.ToDouble(Operators.DivideObject(dataGridViewRow.Cells["QTYCol"].Value, dataGridViewRow.Cells["Rate"].Value));
							dataGridViewRow.Cells["ActCol"].Value = Math.Round(num2, 2, MidpointRounding.AwayFromZero);
							num = Conversions.ToDouble(Operators.AddObject(num, dataGridViewRow.Cells["ActCol"].Value));
						}
						else
						{
							bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["QtyCol"].Value, "", false);
							if (flag2)
							{
								dataGridViewRow.Cells["ActCol"].Value = "";
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.txtAmtPaid.Text = num.ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001D780 File Offset: 0x0001B980
		private void InsertNewAccountPayment(string customername, double amount, int shiftdate, int trandate, string trantime, string teller, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingInsertNewPayment";
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("amount", amount);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			sqlCommand.Parameters.AddWithValue("trandate", trandate);
			sqlCommand.Parameters.AddWithValue("trantime", trantime);
			sqlCommand.Parameters.AddWithValue("teller", teller);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				this.payRef = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.InsertNewAccountPayment(this.TheCustomerName, Convert.ToDouble(Convert.ToDecimal(this.txtAmtPaid.Text)), this.TheShiftDate, Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")), DateTime.Now.ToString("HHmm"), MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				this.InsertPaymentMethod(this.payRef);
				this.GetCustomerTransactions(this.TheCustomerName, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				this.txtBalance.Text = this.GetCustomerBillTotal(this.TheCustomerName, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString();
				this.txtAmtPaid.Text = "0";
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAccPay.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["ActCol"].Value = "";
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				MessageBox.Show("Payment received.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error receiving payment has occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		private void InsertPaymentMethod(int @ref)
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvAccPay.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["QTYcol"].Value, "", false);
					if (flag)
					{
						double num = Conversions.ToDouble(dataGridViewRow.Cells["QTYcol"].Value);
						this.InsertPayMethod(@ref, this.TheCustomerName, Conversions.ToDecimal(dataGridViewRow.Cells["Rate"].Value), Conversions.ToInteger(dataGridViewRow.Cells["PaymentMethodID"].Value), Conversions.ToString(dataGridViewRow.Cells["PaymentMethodDesc"].Value), num, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		private void InsertPayMethod(int @ref, string customername, decimal rate, int payid, string paydesc, double amt, string branch, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingInsertActualPaymentMethods";
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("paydesc", paydesc);
			sqlCommand.Parameters.AddWithValue("amt", amt);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("payid", payid);
			sqlCommand.Parameters.AddWithValue("rate", rate);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04000173 RID: 371
		public string TheCustomerName;

		// Token: 0x04000174 RID: 372
		private string _cnn;

		// Token: 0x04000175 RID: 373
		public int TheShiftDate;

		// Token: 0x04000176 RID: 374
		private int payRef;
	}
}
