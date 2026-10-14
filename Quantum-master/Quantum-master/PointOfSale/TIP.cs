using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.My.Resources;

namespace PointOfSale
{
	// Token: 0x02000203 RID: 515
	[DesignerGenerated]
	public partial class TIP : Form
	{
		// Token: 0x06005C4B RID: 23627 RVA: 0x0035034A File Offset: 0x0034E54A
		public TIP()
		{
			base.Load += this.TIP_Load;
			this.invamt = 0m;
			this.InitializeComponent();
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06005C4E RID: 23630 RVA: 0x00350B89 File Offset: 0x0034ED89
		// (set) Token: 0x06005C4F RID: 23631 RVA: 0x00350B93 File Offset: 0x0034ED93
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x00350B9C File Offset: 0x0034ED9C
		// (set) Token: 0x06005C51 RID: 23633 RVA: 0x00350BA6 File Offset: 0x0034EDA6
		internal virtual Label lblInv
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x00350BAF File Offset: 0x0034EDAF
		// (set) Token: 0x06005C53 RID: 23635 RVA: 0x00350BBC File Offset: 0x0034EDBC
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

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06005C54 RID: 23636 RVA: 0x00350BFF File Offset: 0x0034EDFF
		// (set) Token: 0x06005C55 RID: 23637 RVA: 0x00350C09 File Offset: 0x0034EE09
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06005C56 RID: 23638 RVA: 0x00350C12 File Offset: 0x0034EE12
		// (set) Token: 0x06005C57 RID: 23639 RVA: 0x00350C1C File Offset: 0x0034EE1C
		internal virtual TextBox txtTIP
		{
			[CompilerGenerated]
			get
			{
				return this._txtTIP;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
				TextBox textBox = this._txtTIP;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtTIP = value;
				textBox = this._txtTIP;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06005C58 RID: 23640 RVA: 0x00350C5F File Offset: 0x0034EE5F
		// (set) Token: 0x06005C59 RID: 23641 RVA: 0x00350C6C File Offset: 0x0034EE6C
		internal virtual TextBox txtTotPaid
		{
			[CompilerGenerated]
			get
			{
				return this._txtTotPaid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox2_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtTotPaid_TextChanged);
				TextBox textBox = this._txtTotPaid;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtTotPaid = value;
				textBox = this._txtTotPaid;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x00350CCA File Offset: 0x0034EECA
		// (set) Token: 0x06005C5B RID: 23643 RVA: 0x00350CD4 File Offset: 0x0034EED4
		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return this._Button7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button7_Click);
				Button button = this._Button7;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button7 = value;
				button = this._Button7;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06005C5C RID: 23644 RVA: 0x00350D17 File Offset: 0x0034EF17
		// (set) Token: 0x06005C5D RID: 23645 RVA: 0x00350D24 File Offset: 0x0034EF24
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

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06005C5E RID: 23646 RVA: 0x00350D67 File Offset: 0x0034EF67
		// (set) Token: 0x06005C5F RID: 23647 RVA: 0x00350D74 File Offset: 0x0034EF74
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

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06005C60 RID: 23648 RVA: 0x00350DB7 File Offset: 0x0034EFB7
		// (set) Token: 0x06005C61 RID: 23649 RVA: 0x00350DC4 File Offset: 0x0034EFC4
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06005C62 RID: 23650 RVA: 0x00350E07 File Offset: 0x0034F007
		// (set) Token: 0x06005C63 RID: 23651 RVA: 0x00350E11 File Offset: 0x0034F011
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x00350E1C File Offset: 0x0034F01C
		private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x00350E68 File Offset: 0x0034F068
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x00350EB4 File Offset: 0x0034F0B4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtTotPaid.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x00350F28 File Offset: 0x0034F128
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtTIP.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x00350F9C File Offset: 0x0034F19C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Conversion.Val(this.txtTotPaid.Text) != 0.0;
				if (flag)
				{
					bool flag2 = Conversion.Val(this.lblInv.Text) > Conversion.Val(this.txtTotPaid.Text);
					if (flag2)
					{
						MessageBox.Show("Invoice Amount cannot be greater than Total Paid for Invoice including TIP");
					}
					else
					{
						decimal num = new decimal(Math.Round(Conversion.Val(this.txtTotPaid.Text) - Conversion.Val(this.lblInv.Text), 2, MidpointRounding.AwayFromZero));
						this.txtTIP.Text = num.ToString();
					}
				}
				else
				{
					MessageBox.Show("Please enter the total amount paid first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating tip. Try again. Details: " + ex.Message);
			}
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x0035108C File Offset: 0x0034F28C
		private void txtTotPaid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				decimal num = new decimal(Math.Round(Conversion.Val(this.txtTotPaid.Text) - Conversion.Val(this.lblInv.Text), 2, MidpointRounding.AwayFromZero));
				this.txtTIP.Text = num.ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x00351100 File Offset: 0x0034F300
		private void TIP_Load(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.tipamt = 0m;
				this.lblInv.Text = Conversions.ToString(this.invamt);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading tip. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x00351174 File Offset: 0x0034F374
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Conversion.Val(this.txtTIP.Text) >= 0.0;
				if (flag)
				{
					MyProject.Forms.Form1.tipamt = new decimal(Conversion.Val(this.txtTIP.Text));
					base.Dispose();
				}
				else
				{
					MessageBox.Show("TIP amount cannot be less than zero.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400286C RID: 10348
		public decimal invamt;
	}
}
