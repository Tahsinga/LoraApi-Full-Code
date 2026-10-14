using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000087 RID: 135
	[DesignerGenerated]
	public partial class PayDeposit : Form
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x00113D68 File Offset: 0x00111F68
		public PayDeposit()
		{
			base.Load += this.PayDeposit_Load;
			this.depBarcode = "";
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.mono_rate = 0m;
			this.paymeth_currency = "";
			this.paymeth_desc = "";
			this.paymeth_rate = 0m;
			this.laID = 0;
			this.laInvNum = 0;
			this.laMvtEntry = 0;
			this.InitializeComponent();
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0011459C File Offset: 0x0011279C
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x001145A6 File Offset: 0x001127A6
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x001145AF File Offset: 0x001127AF
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x001145BC File Offset: 0x001127BC
		internal virtual TextBox txtBarcode
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarcode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBarcode_KeyDown);
				TextBox textBox = this._txtBarcode;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtBarcode = value;
				textBox = this._txtBarcode;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x001145FF File Offset: 0x001127FF
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x00114609 File Offset: 0x00112809
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00114612 File Offset: 0x00112812
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x0011461C File Offset: 0x0011281C
		internal virtual Label lblDepAmt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00114625 File Offset: 0x00112825
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0011462F File Offset: 0x0011282F
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00114638 File Offset: 0x00112838
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x00114642 File Offset: 0x00112842
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x0011464B File Offset: 0x0011284B
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00114658 File Offset: 0x00112858
		internal virtual ComboBox cboPayMeth
		{
			[CompilerGenerated]
			get
			{
				return this._cboPayMeth;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPayMeth_SelectedIndexChanged);
				ComboBox comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPayMeth = value;
				comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0011469B File Offset: 0x0011289B
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x001146A8 File Offset: 0x001128A8
		internal virtual TextBox txtamt
		{
			[CompilerGenerated]
			get
			{
				return this._txtamt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtamt_KeyPress);
				TextBox textBox = this._txtamt;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtamt = value;
				textBox = this._txtamt;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x001146EB File Offset: 0x001128EB
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x001146F5 File Offset: 0x001128F5
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x001146FE File Offset: 0x001128FE
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00114708 File Offset: 0x00112908
		internal virtual Button cmdPay
		{
			[CompilerGenerated]
			get
			{
				return this._cmdPay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._cmdPay;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdPay = value;
				button = this._cmdPay;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0011474B File Offset: 0x0011294B
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x00114758 File Offset: 0x00112958
		internal virtual PrintDocument PrintDocument1
		{
			[CompilerGenerated]
			get
			{
				return this._PrintDocument1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
				PrintDocument printDocument = this._PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage -= printPageEventHandler;
				}
				this._PrintDocument1 = value;
				printDocument = this._PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage += printPageEventHandler;
				}
			}
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0011479C File Offset: 0x0011299C
		private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x001147E8 File Offset: 0x001129E8
		private void PayDeposit_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadPayMeths();
				bool flag = this.depBarcode.Length > 3;
				if (flag)
				{
					this.txtBarcode.Text = this.depBarcode;
					this.Check();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00114864 File Offset: 0x00112A64
		private void Check()
		{
			bool flag = this.PayDeposit();
			if (flag)
			{
				this.txtamt.Focus();
				this.cmdPay.Visible = true;
				this.txtamt.Focus();
			}
			else
			{
				this.cmdPay.Visible = false;
				base.Dispose();
			}
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x001148BC File Offset: 0x00112ABC
		private bool PayDeposit()
		{
			bool flag = this.txtBarcode.Text.Length > 2;
			bool flag4;
			if (flag)
			{
				DataTable dataTable = this.ProcessBarcode(this.depBarcode, this.coid, this.branch);
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.lblDepAmt.Text = Conversions.ToString(dataRow["deposit_amount"]);
					this.laID = Conversions.ToInteger(dataRow["ID"]);
					this.laInvNum = Conversions.ToInteger(dataRow["inv_number"]);
					this.laMvtEntry = Conversions.ToInteger(dataRow["mvt_entryno"]);
					int num = Conversions.ToInteger(dataRow["trandate"]);
					bool flag3 = (MyProject.Forms.Form1.deposits_1dayvalid == 1) & (num != Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
					if (flag3)
					{
						this.lblDepAmt.Text = "0";
						MessageBox.Show("deposit date no longer valid. DO NOT PAY.");
						flag4 = false;
					}
					else
					{
						bool flag5 = Operators.ConditionalCompareObjectEqual(dataRow["deposit_amount"], dataRow["amount_returned"], false);
						if (flag5)
						{
							this.lblDepAmt.Text = "0";
							MessageBox.Show("Deposit already paid. DO NOT PAY.");
							flag4 = false;
						}
						else
						{
							flag4 = true;
						}
					}
				}
				else
				{
					MessageBox.Show("Barcode not found. DO NOT PAY.");
					flag4 = false;
				}
			}
			else
			{
				MessageBox.Show("Invalid barcode entered.");
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00114A58 File Offset: 0x00112C58
		private void LoadPayMeths()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPayMeth.DataSource = dataTable;
			this.cboPayMeth.ValueMember = "PaymentMethodID";
			this.cboPayMeth.DisplayMember = "PaymentMethodDesc";
			bool flag = Operators.CompareString(MyProject.Forms.Form1.ChangePaymentMethod, "", false) != 0;
			if (flag)
			{
				this.cboPayMeth.SelectedIndex = this.cboPayMeth.FindStringExact(MyProject.Forms.Form1.ChangePaymentMethod);
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
			}
			else
			{
				this.cboPayMeth.SelectedIndex = 0;
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00114B80 File Offset: 0x00112D80
		private void GetPayMethDetails(int paymethid)
		{
			DataTable paymentMethodDetails = this.pf.GetPaymentMethodDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn);
			bool flag = paymentMethodDetails.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = paymentMethodDetails.Rows[0];
				this.paymeth_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				this.mono_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				this.paymeth_desc = Conversions.ToString(dataRow["PaymentMethodDesc"]);
				this.paymeth_currency = Conversions.ToString(dataRow["Currency"]);
				this.CalcDep();
			}
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00114C40 File Offset: 0x00112E40
		private void CalcDep()
		{
			try
			{
				this.lblDepAmt.Text = decimal.Multiply(Conversions.ToDecimal(this.lblDepAmt.Text), this.mono_rate).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00114CA0 File Offset: 0x00112EA0
		private DataTable ProcessBarcode(string Barcode, int coid, string branch)
		{
			int num = Conversions.ToInteger(Barcode.Substring(3, checked(Barcode.Length - 3)));
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select * from Deposits where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' and ID=",
				Conversions.ToString(num)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00114D40 File Offset: 0x00112F40
		private void clearform()
		{
			this.depBarcode = "";
			this.cmdPay.Visible = false;
			this.lblDepAmt.Text = "0";
			this.txtamt.Text = "0";
			this.laID = 0;
			this.laInvNum = 0;
			this.laMvtEntry = 0;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00114DA0 File Offset: 0x00112FA0
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblDepAmt.Text, "0", false) == 0;
			if (flag)
			{
				MessageBox.Show("deposit amount error.");
			}
			else
			{
				bool flag2 = decimal.Compare(Conversions.ToDecimal(this.txtamt.Text), Conversions.ToDecimal(this.lblDepAmt.Text)) > 0;
				if (flag2)
				{
					MessageBox.Show("Cannot return more than the deposit amount.");
					this.txtamt.Select();
				}
				else
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
					sqlCommand.Transaction = sqlTransaction;
					try
					{
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"update deposits set amount_returned=",
							Conversions.ToString(Conversions.ToDecimal(this.txtamt.Text)),
							", trandateReturn=",
							Conversions.ToString(Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd"))),
							", doneby='",
							MyProject.Forms.Form1.username,
							"', computername='",
							Environment.MachineName,
							"' where ID=",
							Conversions.ToString(this.laID)
						});
						sqlCommand.ExecuteNonQuery();
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"update movement set trancode=4 where coid=",
							Conversions.ToString(this.coid),
							" and branch='",
							this.branch,
							"' and entryno=",
							Conversions.ToString(this.laMvtEntry)
						});
						sqlCommand.ExecuteNonQuery();
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "InsertActualPaymentMethods";
						sqlCommand.Parameters.AddWithValue("invnum", this.laInvNum);
						sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
						sqlCommand.Parameters.AddWithValue("paydesc", this.cboPayMeth.Text);
						sqlCommand.Parameters.AddWithValue("amt", decimal.Divide(decimal.Multiply(Conversions.ToDecimal(this.txtamt.Text), -1m), this.mono_rate));
						sqlCommand.Parameters.AddWithValue("branch", this.branch);
						sqlCommand.Parameters.AddWithValue("coid", this.coid);
						sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
						sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
						sqlCommand.ExecuteNonQuery();
						sqlTransaction.Commit();
						sqlConnection.Close();
						string text = "     DEPOSIT PAID BACK: " + this.txtamt.Text;
						this.stringToRead = new StringReader(text);
						try
						{
							StandardPrintController standardPrintController = new StandardPrintController();
							this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
							this.PrintDocument1.PrintController = standardPrintController;
							this.PrintDocument1.Print();
						}
						finally
						{
							this.stringToRead.Close();
						}
						base.Dispose();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error. Details: " + ex.Message);
						sqlTransaction.Rollback();
						sqlConnection.Close();
					}
				}
			}
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00115190 File Offset: 0x00113390
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x001151D8 File Offset: 0x001133D8
		private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.Check();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Details: " + ex.Message);
			}
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00115238 File Offset: 0x00113438
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			Font font = new Font("Times New Roman", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			checked
			{
				int num7 = (int)Math.Round(Math.Round((double)num3 / 1.0));
				Rectangle rectangle = new Rectangle(num5, num6, num4, num3);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				int num8 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				while (i < num8)
				{
					text = this.stringToRead.ReadLine();
					bool flag = text == null;
					if (flag)
					{
						break;
					}
					float num9 = unchecked(num2 + (float)i * font.GetHeight(e.Graphics));
					e.Graphics.DrawString(text, font, Brushes.Black, num, num9, new StringFormat());
					i++;
				}
				bool flag2 = text == null;
				if (flag2)
				{
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
				}
			}
		}

		// Token: 0x04000EB8 RID: 3768
		public string depBarcode;

		// Token: 0x04000EB9 RID: 3769
		public int coid;

		// Token: 0x04000EBA RID: 3770
		public string branch;

		// Token: 0x04000EBB RID: 3771
		private string _cnn;

		// Token: 0x04000EBC RID: 3772
		private PublicFunctions pf;

		// Token: 0x04000EBD RID: 3773
		private decimal mono_rate;

		// Token: 0x04000EBE RID: 3774
		private string paymeth_currency;

		// Token: 0x04000EBF RID: 3775
		private string paymeth_desc;

		// Token: 0x04000EC0 RID: 3776
		private decimal paymeth_rate;

		// Token: 0x04000EC1 RID: 3777
		private int laID;

		// Token: 0x04000EC2 RID: 3778
		private int laInvNum;

		// Token: 0x04000EC3 RID: 3779
		private int laMvtEntry;

		// Token: 0x04000EC4 RID: 3780
		private StringReader stringToRead;
	}
}
