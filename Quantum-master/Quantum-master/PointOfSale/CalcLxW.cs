using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class CalcLxW : Form
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x00033EF4 File Offset: 0x000320F4
		public CalcLxW()
		{
			base.Load += this.CalcLxW_Load;
			this.currDesc = "";
			this.InitializeComponent();
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0003456F File Offset: 0x0003276F
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00034579 File Offset: 0x00032779
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00034582 File Offset: 0x00032782
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0003458C File Offset: 0x0003278C
		internal virtual TextBox txtL
		{
			[CompilerGenerated]
			get
			{
				return this._txtL;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.TextBox1_KeyDown);
				KeyEventHandler keyEventHandler2 = new KeyEventHandler(this.txtL_KeyUp);
				TextBox textBox = this._txtL;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyUp -= keyEventHandler2;
				}
				this._txtL = value;
				textBox = this._txtL;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.KeyUp += keyEventHandler2;
				}
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00034605 File Offset: 0x00032805
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00034610 File Offset: 0x00032810
		internal virtual TextBox txtW
		{
			[CompilerGenerated]
			get
			{
				return this._txtW;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox2_KeyPress);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtW_KeyDown);
				KeyEventHandler keyEventHandler2 = new KeyEventHandler(this.txtW_KeyUp);
				TextBox textBox = this._txtW;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyUp -= keyEventHandler2;
				}
				this._txtW = value;
				textBox = this._txtW;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.KeyUp += keyEventHandler2;
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00034689 File Offset: 0x00032889
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00034693 File Offset: 0x00032893
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0003469C File Offset: 0x0003289C
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x000346A6 File Offset: 0x000328A6
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x000346AF File Offset: 0x000328AF
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x000346B9 File Offset: 0x000328B9
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x000346C2 File Offset: 0x000328C2
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x000346CC File Offset: 0x000328CC
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0003470F File Offset: 0x0003290F
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00034719 File Offset: 0x00032919
		internal virtual Label lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00034722 File Offset: 0x00032922
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0003472C File Offset: 0x0003292C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00034738 File Offset: 0x00032938
		private void CalcLxW_Load(object sender, EventArgs e)
		{
			try
			{
				this.lblDesc.Text = this.currDesc;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00034794 File Offset: 0x00032994
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000347E0 File Offset: 0x000329E0
		private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtW_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0003482C File Offset: 0x00032A2C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.calcLxWTOTAL = new decimal(Conversion.Val(this.txtTotal.Text));
				MyProject.Forms.Form1.calcLxWLength = new decimal(Conversion.Val(this.txtL.Text));
				MyProject.Forms.Form1.calcLxWWidth = new decimal(Conversion.Val(this.txtW.Text));
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving calculation. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000348E8 File Offset: 0x00032AE8
		private void txtL_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				this.txtTotal.Text = (Conversion.Val(this.txtL.Text) * Conversion.Val(this.txtW.Text)).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00034964 File Offset: 0x00032B64
		private void txtW_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				this.txtTotal.Text = (Conversion.Val(this.txtL.Text) * Conversion.Val(this.txtW.Text)).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000264 RID: 612
		public string currDesc;
	}
}
