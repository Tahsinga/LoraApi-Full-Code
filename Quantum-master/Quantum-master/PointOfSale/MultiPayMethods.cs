using System;
using System.Collections;
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
	// Token: 0x02000071 RID: 113
	[DesignerGenerated]
	public partial class MultiPayMethods : Form
	{
		// Token: 0x060019B6 RID: 6582 RVA: 0x000ED300 File Offset: 0x000EB500
		public MultiPayMethods()
		{
			base.Load += this.MultiPayMethods_Load;
			this.selectedrowindex = 0;
			this.auto_calculate = 0;
			this.InitializeComponent();
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x000EDA7C File Offset: 0x000EBC7C
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x000EDA86 File Offset: 0x000EBC86
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x000EDA8F File Offset: 0x000EBC8F
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x000EDA9C File Offset: 0x000EBC9C
		internal virtual DataGridView dgvPay
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPay_CellEndEdit);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.dgvPay_CellEnter);
				DataGridViewCellCancelEventHandler dataGridViewCellCancelEventHandler = new DataGridViewCellCancelEventHandler(this.dgvPay_CellBeginEdit);
				DataGridViewCellEventHandler dataGridViewCellEventHandler3 = new DataGridViewCellEventHandler(this.dgvPay_CellClick);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgvPay_CellValidating);
				DataGridView dataGridView = this._dgvPay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler2;
					dataGridView.CellBeginEdit -= dataGridViewCellCancelEventHandler;
					dataGridView.CellClick -= dataGridViewCellEventHandler3;
					dataGridView.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgvPay = value;
				dataGridView = this._dgvPay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler2;
					dataGridView.CellBeginEdit += dataGridViewCellCancelEventHandler;
					dataGridView.CellClick += dataGridViewCellEventHandler3;
					dataGridView.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x000EDB5C File Offset: 0x000EBD5C
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x000EDB66 File Offset: 0x000EBD66
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x000EDB6F File Offset: 0x000EBD6F
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x000EDB79 File Offset: 0x000EBD79
		internal virtual TextBox txtbal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x000EDB82 File Offset: 0x000EBD82
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x000EDB8C File Offset: 0x000EBD8C
		internal virtual TextBox txtamtpaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x000EDB95 File Offset: 0x000EBD95
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x000EDB9F File Offset: 0x000EBD9F
		internal virtual TextBox txtInvTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x000EDBA8 File Offset: 0x000EBDA8
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x000EDBB2 File Offset: 0x000EBDB2
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000EDBBB File Offset: 0x000EBDBB
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x000EDBC5 File Offset: 0x000EBDC5
		internal virtual Label lblpaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x000EDBCE File Offset: 0x000EBDCE
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x000EDBD8 File Offset: 0x000EBDD8
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x000EDBE1 File Offset: 0x000EBDE1
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x000EDBEB File Offset: 0x000EBDEB
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x000EDBF4 File Offset: 0x000EBDF4
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x000EDC00 File Offset: 0x000EBE00
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

		// Token: 0x060019CF RID: 6607 RVA: 0x000EDC44 File Offset: 0x000EBE44
		private void MultiPayMethods_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtInvTotal.Text = this.invtotal.ToString();
				this.dgvPay.DataSource = MyProject.Forms.Form1.MultiPayMethodsDAT;
				this.dgvPay.Columns["paymentmethodid"].Visible = false;
				this.dgvPay.Columns["currency"].Visible = false;
				this.dgvPay.Columns["uploaded"].Visible = false;
				this.dgvPay.Columns["rate"].Visible = false;
				this.dgvPay.Columns["fiscalgroup"].Visible = false;
				this.dgvPay.Columns["discountperc"].Visible = false;
				this.dgvPay.Columns["paymentmethoddesc"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvPay.Columns["paymentmethoddesc"].ReadOnly = true;
				this.dgvPay.Columns["equiv"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvPay.Columns["equiv"].ReadOnly = true;
				this.dgvPay.Columns["equiv"].HeaderText = "Equivalent in " + this.lblpaymethod.Text;
				this.dgvPay.Columns["amtpaid"].HeaderText = "Actual Amount Paid";
				this.dgvPay.Columns["paymentmethoddesc"].HeaderText = "Payment Method";
				this.dgvPay.Columns["CurrencyIDEltrade"].Visible = false;
				this.dgvPay.Columns["RequiresRef"].Visible = false;
				this.dgvPay.Columns["BPNumber"].Visible = false;
				this.dgvPay.Columns["VATNumber"].Visible = false;
				this.dgvPay.Columns["coid"].Visible = false;
				this.dgvPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvPay.Focus();
				DataGridViewRow dataGridViewRow = this.dgvPay.Rows[0];
				dataGridViewRow.Selected = true;
				dataGridViewRow.Cells["amtpaid"].Selected = true;
				this.CalcTotal();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x000EDF44 File Offset: 0x000EC144
		private void CalcTotal()
		{
			decimal num = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvPay.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["amtpaid"].Value)), "", dataGridViewRow.Cells["amtpaid"].ToString()));
					bool flag = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["amtpaid"].Value)), "", dataGridViewRow.Cells["amtpaid"].ToString()), "", false);
					if (flag)
					{
						object obj2 = char.IsDigit(Conversions.ToChar(dataGridViewRow.Cells["amtpaid"].Value));
						DataGridViewCell dataGridViewCell;
						object[] array;
						bool[] array2;
						object obj3 = NewLateBinding.LateGet(null, typeof(Strings), "Asc", array = new object[] { (dataGridViewCell = dataGridViewRow.Cells["amtpaid"]).Value }, null, null, array2 = new bool[] { true });
						if (array2[0])
						{
							dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						bool flag2 = Conversions.ToBoolean(Operators.NotObject(Operators.OrObject(obj2, Operators.CompareObjectEqual(obj3, 8, false))));
						if (flag2)
						{
							dataGridViewRow.Cells["amtpaid"].Value = "0";
							return;
						}
						decimal num2 = 0m;
						try
						{
							num2 = decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscountPerc"].Value)), 100m);
						}
						catch (Exception ex)
						{
							num2 = 0m;
						}
						bool flag3 = decimal.Compare(num2, 0m) > 0;
						if (flag3)
						{
							MessageBox.Show("Payment Method Discount Effected.");
						}
						dataGridViewRow.Cells["equiv"].Value = Operators.MultiplyObject(Operators.DivideObject(dataGridViewRow.Cells["amtpaid"].Value, Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["rate"].Value))), this.invpaymethrate).ToString();
						dataGridViewRow.Cells["equiv"].Value = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["equiv"].Value)) - Convert.ToDouble(num2) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["equiv"].Value))).ToString();
						num = Conversions.ToDecimal(Operators.AddObject(num, dataGridViewRow.Cells["equiv"].Value));
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
			this.txtamtpaid.Text = num.ToString();
			this.txtbal.Text = decimal.Subtract(this.invtotal, num).ToString();
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x000EE2E0 File Offset: 0x000EC4E0
		private void dgvPay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.CalcTotal();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error end edit. Detail: " + ex.Message);
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x000EE330 File Offset: 0x000EC530
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag4;
			try
			{
				bool flag = msg.WParam.ToInt32() == 116;
				if (flag)
				{
					this.SAVE_F5();
				}
				else
				{
					bool flag2 = msg.WParam.ToInt32() == 27;
					if (flag2)
					{
						try
						{
							foreach (object obj in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								dataRow["amtpaid"] = 0;
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
						DataGridViewRow dataGridViewRow = this.dgvPay.Rows[0];
						dataGridViewRow.Selected = true;
						dataGridViewRow.Cells["amtpaid"].Selected = true;
						this.CalcTotal();
					}
					else
					{
						bool flag3 = msg.WParam.ToInt32() == 13;
						if (flag3)
						{
							this.dgvPay.Rows[this.selectedrowindex].Cells["amtpaid"].Value = Operators.MultiplyObject(Conversion.Val(this.txtbal.Text) / Convert.ToDouble(this.invpaymethrate), this.dgvPay.Rows[this.selectedrowindex].Cells["rate"].Value);
							this.CalcTotal();
						}
					}
				}
				flag4 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag4;
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x000EE510 File Offset: 0x000EC710
		private void dgvPay_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.selectedrowindex = e.RowIndex;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000EE520 File Offset: 0x000EC720
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.SAVE_F5();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving. Detail: " + ex.Message);
			}
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000EE570 File Offset: 0x000EC770
		private void SAVE_F5()
		{
			bool flag = Conversion.Val(this.txtbal.Text) < 0.0;
			if (flag)
			{
				MessageBox.Show("Overpaid. correct.");
			}
			else
			{
				bool flag2 = Conversion.Val(this.txtbal.Text) > 0.0;
				if (flag2)
				{
					MessageBox.Show("Insufficient payment. correct");
				}
				else
				{
					MyProject.Forms.Form1.Multipay_amtpaid = new decimal(Conversion.Val(this.txtamtpaid.Text));
					base.Dispose();
				}
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000EE608 File Offset: 0x000EC808
		private void dgvPay_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			bool flag = MyProject.Forms.Form1.istouchscreen == 1;
			if (flag)
			{
				try
				{
					DialogNumeric dialogNumeric = new DialogNumeric();
					dialogNumeric.enable_autcalc = 1;
					bool flag2 = dialogNumeric.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.dgvPay.CurrentCell.Value = dialogNumeric.lblamt.Text;
						this.auto_calculate = dialogNumeric.auto_calc;
						bool flag3 = this.auto_calculate == 1;
						if (flag3)
						{
							this.dgvPay.Rows[this.selectedrowindex].Cells["amtpaid"].Value = Operators.MultiplyObject(Conversion.Val(this.txtbal.Text) / Convert.ToDouble(this.invpaymethrate), this.dgvPay.Rows[this.selectedrowindex].Cells["rate"].Value);
						}
						this.CalcTotal();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Keypad error. Details: " + ex.Message);
				}
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x000EE744 File Offset: 0x000EC944
		private void dgvPay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = MyProject.Forms.Form1.istouchscreen == 1;
			if (flag)
			{
				try
				{
					DialogNumeric dialogNumeric = new DialogNumeric();
					dialogNumeric.enable_autcalc = 1;
					bool flag2 = dialogNumeric.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.dgvPay.CurrentCell.Value = dialogNumeric.lblamt.Text;
						this.auto_calculate = dialogNumeric.auto_calc;
						bool flag3 = this.auto_calculate == 1;
						if (flag3)
						{
							this.dgvPay.Rows[this.selectedrowindex].Cells["amtpaid"].Value = Operators.MultiplyObject(Conversion.Val(this.txtbal.Text) / Convert.ToDouble(this.invpaymethrate), this.dgvPay.Rows[this.selectedrowindex].Cells["rate"].Value);
						}
						this.CalcTotal();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Keypad error. Details: " + ex.Message);
				}
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000EE880 File Offset: 0x000ECA80
		private void dgvPay_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			try
			{
				this.dgvPay.Rows[e.RowIndex].ErrorText = "";
				bool flag = Operators.CompareString(this.dgvPay.Columns[e.ColumnIndex].Name, "amtpaid", false) == 0;
				if (flag)
				{
					bool isNewRow = this.dgvPay.Rows[e.RowIndex].IsNewRow;
					if (!isNewRow)
					{
						decimal num;
						bool flag2 = !decimal.TryParse(Conversions.ToString(Interaction.IIf(Conversions.ToBoolean(e.FormattedValue.ToString()), "0", e.FormattedValue.ToString())), out num) || decimal.Compare(num, 0m) < 0;
						if (flag2)
						{
							e.Cancel = true;
							this.dgvPay.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000C7B RID: 3195
		public decimal invtotal;

		// Token: 0x04000C7C RID: 3196
		public decimal invpaymethrate;

		// Token: 0x04000C7D RID: 3197
		private int selectedrowindex;

		// Token: 0x04000C7E RID: 3198
		private int auto_calculate;
	}
}
