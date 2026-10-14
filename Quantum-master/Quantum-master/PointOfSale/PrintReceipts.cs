using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My.Resources;

namespace PointOfSale
{
	// Token: 0x0200016E RID: 366
	[DesignerGenerated]
	public partial class PrintReceipts : Form
	{
		// Token: 0x06003353 RID: 13139 RVA: 0x001BC660 File Offset: 0x001BA860
		public PrintReceipts()
		{
			base.Load += this.PrintReceipts_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x001BCA5C File Offset: 0x001BAC5C
		// (set) Token: 0x06003357 RID: 13143 RVA: 0x001BCA66 File Offset: 0x001BAC66
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x001BCA6F File Offset: 0x001BAC6F
		// (set) Token: 0x06003359 RID: 13145 RVA: 0x001BCA7C File Offset: 0x001BAC7C
		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
				TextBox textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._TextBox1 = value;
				textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x001BCABF File Offset: 0x001BACBF
		// (set) Token: 0x0600335B RID: 13147 RVA: 0x001BCACC File Offset: 0x001BACCC
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

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x0600335C RID: 13148 RVA: 0x001BCB0F File Offset: 0x001BAD0F
		// (set) Token: 0x0600335D RID: 13149 RVA: 0x001BCB1C File Offset: 0x001BAD1C
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

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x001BCB5F File Offset: 0x001BAD5F
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x001BCB6C File Offset: 0x001BAD6C
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

		// Token: 0x06003360 RID: 13152 RVA: 0x001BCBB0 File Offset: 0x001BADB0
		private void PrintReceipts_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x001BCBEC File Offset: 0x001BADEC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.printRec = true;
				this.printNum = checked((int)Math.Round(Conversion.Val(this.TextBox1.Text)));
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00012800 File Offset: 0x00010A00
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x001BCC48 File Offset: 0x001BAE48
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.printRec = false;
				this.printNum = checked((int)Math.Round(Conversion.Val(this.TextBox1.Text)));
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x001BCCA4 File Offset: 0x001BAEA4
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.TextBox1.Text = dialogNumeric.lblamt.Text;
					this.printRec = true;
					this.printNum = checked((int)Math.Round(Conversion.Val(this.TextBox1.Text)));
					base.DialogResult = DialogResult.OK;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x040015FA RID: 5626
		public bool printRec;

		// Token: 0x040015FB RID: 5627
		public int printNum;
	}
}
