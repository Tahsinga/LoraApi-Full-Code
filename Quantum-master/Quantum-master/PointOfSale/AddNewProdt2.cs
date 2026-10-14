using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class AddNewProdt2 : Form
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
		public AddNewProdt2()
		{
			base.Load += this.AddNewProdt_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.IsProductCodeGenerated = false;
			this.InitializeComponent();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00010D01 File Offset: 0x0000EF01
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00010D0B File Offset: 0x0000EF0B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00010D14 File Offset: 0x0000EF14
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00010D1E File Offset: 0x0000EF1E
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00010D27 File Offset: 0x0000EF27
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00010D31 File Offset: 0x0000EF31
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00010D3A File Offset: 0x0000EF3A
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00010D44 File Offset: 0x0000EF44
		internal virtual TextBox txtReorder
		{
			[CompilerGenerated]
			get
			{
				return this._txtReorder;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtReorder_KeyPress);
				TextBox textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtReorder = value;
				textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00010D87 File Offset: 0x0000EF87
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00010D91 File Offset: 0x0000EF91
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00010D9A File Offset: 0x0000EF9A
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00010DA4 File Offset: 0x0000EFA4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00010DAD File Offset: 0x0000EFAD
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00010DB7 File Offset: 0x0000EFB7
		internal virtual ComboBox cboCategory
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00010DC0 File Offset: 0x0000EFC0
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00010DCA File Offset: 0x0000EFCA
		internal virtual TextBox txtdesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00010DD3 File Offset: 0x0000EFD3
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00010DE0 File Offset: 0x0000EFE0
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00010E23 File Offset: 0x0000F023
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00010E2D File Offset: 0x0000F02D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00010E36 File Offset: 0x0000F036
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00010E40 File Offset: 0x0000F040
		internal virtual TextBox txtproductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00010E49 File Offset: 0x0000F049
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00010E53 File Offset: 0x0000F053
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00010E5C File Offset: 0x0000F05C
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00010E66 File Offset: 0x0000F066
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00010E6F File Offset: 0x0000F06F
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00010E79 File Offset: 0x0000F079
		internal virtual TextBox txtBarCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00010E82 File Offset: 0x0000F082
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00010E8C File Offset: 0x0000F08C
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00010E95 File Offset: 0x0000F095
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		internal virtual TextBox txtTaxRate
		{
			[CompilerGenerated]
			get
			{
				return this._txtTaxRate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtTaxRate_KeyPress);
				TextBox textBox = this._txtTaxRate;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtTaxRate = value;
				textBox = this._txtTaxRate;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00010EE3 File Offset: 0x0000F0E3
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00010EED File Offset: 0x0000F0ED
		internal virtual DataGridView DgvProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00010EF6 File Offset: 0x0000F0F6
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00010F00 File Offset: 0x0000F100
		internal virtual CheckBox ChkImported
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00010F09 File Offset: 0x0000F109
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00010F13 File Offset: 0x0000F113
		internal virtual ComboBox cboUOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00010F1C File Offset: 0x0000F11C
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00010F26 File Offset: 0x0000F126
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00010F2F File Offset: 0x0000F12F
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00010F39 File Offset: 0x0000F139
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00010F42 File Offset: 0x0000F142
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00010F4C File Offset: 0x0000F14C
		internal virtual TextBox txtBinLocation
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00010F55 File Offset: 0x0000F155
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00010F5F File Offset: 0x0000F15F
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00010F68 File Offset: 0x0000F168
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00010F72 File Offset: 0x0000F172
		internal virtual TextBox txtdesc2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00010F7B File Offset: 0x0000F17B
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00010F88 File Offset: 0x0000F188
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00010FCB File Offset: 0x0000F1CB
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00010FD5 File Offset: 0x0000F1D5
		internal virtual CheckBox chkDifferent
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00010FDE File Offset: 0x0000F1DE
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		internal virtual CheckBox chkProductExpires
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00010FF1 File Offset: 0x0000F1F1
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00010FFB File Offset: 0x0000F1FB
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00011004 File Offset: 0x0000F204
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0001100E File Offset: 0x0000F20E
		internal virtual TextBox WholesaleQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00011017 File Offset: 0x0000F217
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00011021 File Offset: 0x0000F221
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0001102A File Offset: 0x0000F22A
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00011034 File Offset: 0x0000F234
		internal virtual CheckBox chkIsUnlimitedStockItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001103D File Offset: 0x0000F23D
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00011047 File Offset: 0x0000F247
		internal virtual CheckBox chkIngridient
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00011050 File Offset: 0x0000F250
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0001105A File Offset: 0x0000F25A
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00011063 File Offset: 0x0000F263
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0001106D File Offset: 0x0000F26D
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00011076 File Offset: 0x0000F276
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00011080 File Offset: 0x0000F280
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00011089 File Offset: 0x0000F289
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00011094 File Offset: 0x0000F294
		internal virtual TextBox txtSellingPrice
		{
			[CompilerGenerated]
			get
			{
				return this._txtSellingPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtSellingPrice_KeyPress);
				TextBox textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtSellingPrice = value;
				textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000110D7 File Offset: 0x0000F2D7
		// (set) Token: 0x060001CF RID: 463 RVA: 0x000110E1 File Offset: 0x0000F2E1
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000110EA File Offset: 0x0000F2EA
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x000110F4 File Offset: 0x0000F2F4
		internal virtual TextBox txtCost
		{
			[CompilerGenerated]
			get
			{
				return this._txtCost;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCost_KeyPress);
				TextBox textBox = this._txtCost;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCost = value;
				textBox = this._txtCost;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00011137 File Offset: 0x0000F337
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00011144 File Offset: 0x0000F344
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00011187 File Offset: 0x0000F387
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00011191 File Offset: 0x0000F391
		internal virtual CheckBox chkIsBooking
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001119A File Offset: 0x0000F39A
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000111A4 File Offset: 0x0000F3A4
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000111AD File Offset: 0x0000F3AD
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000111B7 File Offset: 0x0000F3B7
		internal virtual ComboBox cboSupplier
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000111C0 File Offset: 0x0000F3C0
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000111CC File Offset: 0x0000F3CC
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0001120F File Offset: 0x0000F40F
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00011219 File Offset: 0x0000F419
		internal virtual CheckBox chkIsCalcLxW
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00011222 File Offset: 0x0000F422
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0001122C File Offset: 0x0000F42C
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00011235 File Offset: 0x0000F435
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00011240 File Offset: 0x0000F440
		internal virtual TextBox txtCaseQty
		{
			[CompilerGenerated]
			get
			{
				return this._txtCaseQty;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCaseQty_KeyPress);
				TextBox textBox = this._txtCaseQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCaseQty = value;
				textBox = this._txtCaseQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00011283 File Offset: 0x0000F483
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00011290 File Offset: 0x0000F490
		internal virtual CheckBox chkIsCase
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsCase;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsCase_CheckedChanged);
				CheckBox checkBox = this._chkIsCase;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsCase = value;
				checkBox = this._chkIsCase;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000112D3 File Offset: 0x0000F4D3
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x000112DD File Offset: 0x0000F4DD
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000112E6 File Offset: 0x0000F4E6
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000112F0 File Offset: 0x0000F4F0
		internal virtual ComboBox cboProducts
		{
			[CompilerGenerated]
			get
			{
				return this._cboProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboProducts_SelectedIndexChanged);
				EventHandler eventHandler2 = new EventHandler(this.cboProducts_TextChanged);
				ComboBox comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
					comboBox.TextChanged -= eventHandler2;
				}
				this._cboProducts = value;
				comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
					comboBox.TextChanged += eventHandler2;
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0001134E File Offset: 0x0000F54E
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00011358 File Offset: 0x0000F558
		internal virtual ListBox ListBox1
		{
			[CompilerGenerated]
			get
			{
				return this._ListBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListBox1_SelectedIndexChanged);
				ListBox listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= eventHandler;
				}
				this._ListBox1 = value;
				listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0001139B File Offset: 0x0000F59B
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000113A8 File Offset: 0x0000F5A8
		internal virtual CheckBox chkIsBoth
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsBoth;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsBoth_CheckedChanged);
				CheckBox checkBox = this._chkIsBoth;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsBoth = value;
				checkBox = this._chkIsBoth;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000113EB File Offset: 0x0000F5EB
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000113F8 File Offset: 0x0000F5F8
		internal virtual CheckBox chkPriceVariable
		{
			[CompilerGenerated]
			get
			{
				return this._chkPriceVariable;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._chkPriceVariable;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkPriceVariable = value;
				checkBox = this._chkPriceVariable;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0001143B File Offset: 0x0000F63B
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00011448 File Offset: 0x0000F648
		internal virtual Label Label22
		{
			[CompilerGenerated]
			get
			{
				return this._Label22;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label22_Click);
				Label label = this._Label22;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label22 = value;
				label = this._Label22;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0001148B File Offset: 0x0000F68B
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00011495 File Offset: 0x0000F695
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0001149E File Offset: 0x0000F69E
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x000114A8 File Offset: 0x0000F6A8
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000114B1 File Offset: 0x0000F6B1
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x000114BB File Offset: 0x0000F6BB
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000114C4 File Offset: 0x0000F6C4
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x000114CE File Offset: 0x0000F6CE
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000114D7 File Offset: 0x0000F6D7
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000114E4 File Offset: 0x0000F6E4
		internal virtual CheckBox chkIsTaxExempt
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsTaxExempt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsTaxExempt_CheckedChanged);
				CheckBox checkBox = this._chkIsTaxExempt;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsTaxExempt = value;
				checkBox = this._chkIsTaxExempt;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00011528 File Offset: 0x0000F728
		private void AddNewProdt_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategories();
				this.LoadProducts();
				this.LoadUOM();
				this.cboSupplier.DataSource = this.publicfunction.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "SupplierID";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				this.cboSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
				bool flag = this.cboSupplier.Items.Count > 1;
				if (flag)
				{
					this.cboSupplier.SelectedIndex = -1;
				}
				else
				{
					this.cboSupplier.SelectedIndex = 0;
				}
				this.productsDatatable = this.publicfunction.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
				this.cboProducts.DataSource = this.publicfunction.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
				this.cboProducts.ValueMember = "ProductID";
				this.cboProducts.DisplayMember = "ProductDesc";
				this.cboProducts.SelectedIndex = -1;
				base.WindowState = FormWindowState.Maximized;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading New Product Form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000116AC File Offset: 0x0000F8AC
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboCategory.DataSource = dataTable;
			this.cboCategory.ValueMember = "CatID";
			this.cboCategory.DisplayMember = "CatDesc";
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001174C File Offset: 0x0000F94C
		private void SaveProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunSaveNewProduct");
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				int num = 0;
				bool @checked = this.ChkImported.Checked;
				if (@checked)
				{
					num = 1;
				}
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertNewProduct5";
				sqlCommand.Parameters.AddWithValue("catid", RuntimeHelpers.GetObjectValue(this.cboCategory.SelectedValue));
				sqlCommand.Parameters.AddWithValue("productdesc", this.txtdesc.Text);
				sqlCommand.Parameters.AddWithValue("cost", Conversions.ToDecimal(this.txtCost.Text));
				sqlCommand.Parameters.AddWithValue("sellingprice", Conversions.ToDecimal(this.txtSellingPrice.Text));
				sqlCommand.Parameters.AddWithValue("reorderlevel", Conversion.Val(this.txtReorder.Text));
				sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
				sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
				sqlCommand.Parameters.AddWithValue("productcode", this.txtproductCode.Text);
				sqlCommand.Parameters.AddWithValue("barcode", this.txtBarCode.Text);
				sqlCommand.Parameters.AddWithValue("taxrate", Conversion.Val(this.txtTaxRate.Text));
				sqlCommand.Parameters.AddWithValue("imported", num);
				sqlCommand.Parameters.AddWithValue("uom", RuntimeHelpers.GetObjectValue(this.cboUOM.SelectedValue));
				sqlCommand.Parameters.AddWithValue("binloc", this.txtBinLocation.Text);
				sqlCommand.Parameters.AddWithValue("productdesc2", this.txtdesc2.Text);
				sqlCommand.Parameters.AddWithValue("new_prodtid", this.newID);
				sqlCommand.Parameters.AddWithValue("wholesaleqty", Convert.ToDecimal(this.WholesaleQTY.Text));
				int num2 = 0;
				bool checked2 = this.chkProductExpires.Checked;
				if (checked2)
				{
					num2 = 1;
				}
				sqlCommand.Parameters.AddWithValue("ProductExpires", num2);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				int num3 = 0;
				bool checked3 = this.chkDifferent.Checked;
				if (checked3)
				{
					num3 = 1;
				}
				sqlCommand.Parameters.AddWithValue("differentpriceperbranch", num3);
				bool checked4 = this.chkIsUnlimitedStockItem.Checked;
				if (checked4)
				{
					sqlCommand.Parameters.AddWithValue("isunlimitedstockitem", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isunlimitedstockitem", 0);
				}
				bool checked5 = this.chkIngridient.Checked;
				if (checked5)
				{
					sqlCommand.Parameters.AddWithValue("isingridientonly", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isingridientonly", 0);
				}
				bool checked6 = this.chkIsBooking.Checked;
				if (checked6)
				{
					sqlCommand.Parameters.AddWithValue("isbooking", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isbooking", 0);
				}
				sqlCommand.Parameters.AddWithValue("supplierid", RuntimeHelpers.GetObjectValue(this.cboSupplier.SelectedValue));
				bool checked7 = this.chkIsCalcLxW.Checked;
				if (checked7)
				{
					sqlCommand.Parameters.AddWithValue("iscalclxw", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("iscalclxw", 0);
				}
				int num4 = 0;
				bool checked8 = this.chkIsCase.Checked;
				if (checked8)
				{
					num4 = 1;
				}
				else
				{
					bool checked9 = this.chkIsBoth.Checked;
					if (checked9)
					{
						num4 = 2;
					}
				}
				sqlCommand.Parameters.AddWithValue("iscase", num4);
				sqlCommand.Parameters.AddWithValue("caseqty", Conversion.Val(this.txtCaseQty.Text));
				sqlCommand.Parameters.AddWithValue("caseparentproductid", RuntimeHelpers.GetObjectValue(this.cboProducts.SelectedValue));
				bool checked10 = this.chkPriceVariable.Checked;
				if (checked10)
				{
					sqlCommand.Parameters.AddWithValue("ispricevariable", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("ispricevariable", 0);
				}
				sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkIsTaxExempt.Checked, 1, 0)));
				this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				bool isProductCodeGenerated = this.IsProductCodeGenerated;
				if (isProductCodeGenerated)
				{
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandText = "UpdateProductCodeBase";
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("code", Convert.ToInt32(this.txtproductCode.Text.Substring(2)));
					sqlCommand.ExecuteNonQuery();
				}
				sqlTransaction.Commit();
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving product. Detail: " + ex.Message);
				try
				{
					sqlTransaction.Rollback();
					sqlConnection.Close();
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00011D98 File Offset: 0x0000FF98
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboSupplier.SelectedIndex == -1;
				if (flag)
				{
					MessageBox.Show("Please select a supplier first.");
					this.cboSupplier.Focus();
				}
				else
				{
					this.txtdesc.Text = this.txtdesc.Text.ToString().Trim();
					bool flag2 = (Operators.CompareString(this.txtproductCode.Text, "", false) != 0) & (Operators.CompareString(this.txtdesc.Text, "", false) != 0);
					if (flag2)
					{
						this.lblinfo.Text = "...";
						this.SaveProduct();
						this.lblinfo.Text = "Product saved with product ID: " + Conversions.ToString(this.newID);
						this.txtdesc.Text = "";
						this.txtReorder.Text = Conversions.ToString(0);
						this.chkDifferent.Checked = false;
						this.chkProductExpires.Checked = false;
						this.chkIngridient.Checked = false;
						this.WholesaleQTY.Text = "0";
						this.chkIsUnlimitedStockItem.Checked = false;
						this.LoadProducts();
						bool isProductCodeGenerated = this.IsProductCodeGenerated;
						if (isProductCodeGenerated)
						{
							this.txtproductCode.Text = "";
							this.txtproductCode.ReadOnly = false;
						}
						this.txtCost.Text = "0";
						this.txtSellingPrice.Text = "0";
						this.chkIsCalcLxW.Checked = false;
						this.chkIsBooking.Checked = false;
						MessageBox.Show("Product added successfully.");
					}
					else
					{
						MessageBox.Show("Cannot proceed without a Product Code or Product Description.", "Error");
					}
				}
			}
			catch (SqlException ex)
			{
				bool flag3 = ex.Number == 2627;
				if (flag3)
				{
					MessageBox.Show("Ensure that the product code entered is unique. Database error.");
				}
				else
				{
					MessageBox.Show("Database error. Detail: " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving product. Detail: " + ex2.Message);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00012054 File Offset: 0x00010254
		private void LoadProducts()
		{
			this.DgvProducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectLastAddedProducts";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.DgvProducts.DataSource = dataTable;
			this.DgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DgvProducts.Columns["ProductID"].Visible = false;
			this.DgvProducts.Columns["ProductCode"].HeaderText = "Product Code";
			this.DgvProducts.Columns["Product_Description"].HeaderText = "Description";
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001214C File Offset: 0x0001034C
		private void DeleteProduct(int ID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteProduct";
			sqlCommand.Parameters.AddWithValue("prodtID", ID);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
			SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
			SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "InsertDeletedItem";
			sqlCommand2.Parameters.AddWithValue("TBName", "Products");
			sqlCommand2.Parameters.AddWithValue("KeyColumn", "ProductID");
			sqlCommand2.Parameters.AddWithValue("KeyColumnType", "int");
			sqlCommand2.Parameters.AddWithValue("KeyValue", ID.ToString());
			using (sqlConnection3)
			{
				sqlConnection3.Open();
				sqlCommand2.ExecuteNonQuery();
				sqlConnection3.Close();
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00012288 File Offset: 0x00010488
		private void dgvproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					this.DeleteProduct(Conversions.ToInteger(this.DgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value));
					this.LoadProducts();
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Integrity error. Cannot delete a product that has sales data.");
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error deleting product. Details: " + ex2.Message);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00012368 File Offset: 0x00010568
		private void txtTaxRate_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000123B4 File Offset: 0x000105B4
		private void LoadUOM()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetUOM";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboUOM.DataSource = dataTable;
			this.cboUOM.DisplayMember = "UOMDesc";
			this.cboUOM.ValueMember = "UOM";
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00012430 File Offset: 0x00010630
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtproductCode.Text = this.GetNextProductCode(MyProject.Forms.Form1.coid);
				this.IsProductCodeGenerated = true;
				this.txtproductCode.ReadOnly = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error generating product code. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000124AC File Offset: 0x000106AC
		private string GetNextProductCode(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchNextProductCode";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return dataRow["NextProductCode"].ToString();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00012534 File Offset: 0x00010734
		private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00012580 File Offset: 0x00010780
		private void Button3_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
					if (flag)
					{
						bool flag2 = this.publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), MyProject.Forms.MainMenu.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
						if (flag2)
						{
							Categories categories = new Categories();
							categories.ShowDialog(this);
							categories.Dispose();
							this.LoadCategories();
							this.cboCategory.SelectedIndex = this.cboCategory.Items.Count - 1;
						}
						else
						{
							MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
						}
					}
					else
					{
						Categories categories2 = new Categories();
						categories2.ShowDialog(this);
						categories2.Dispose();
						this.LoadCategories();
						this.cboCategory.SelectedIndex = this.cboCategory.Items.Count - 1;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Main Menu Error. Details: " + ex.Message);
				}
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000126D4 File Offset: 0x000108D4
		private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00012720 File Offset: 0x00010920
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				Suppliers suppliers = new Suppliers();
				suppliers.ShowDialog(this);
				suppliers.Dispose();
				string suppliername = MyProject.Forms.Form1.suppliername;
				this.cboSupplier.DataSource = this.publicfunction.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "SupplierID";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.SelectedIndex = -1;
				this.cboSupplier.SelectedIndex = this.cboSupplier.FindStringExact(MyProject.Forms.Form1.suppliername);
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error entering new supplier details at new stock purchase");
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtCaseQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00012828 File Offset: 0x00010A28
		private void chkIsCase_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsCase.Checked;
				if (@checked)
				{
					this.txtCaseQty.Visible = true;
					this.Label18.Visible = true;
					this.cboProducts.Visible = false;
					this.Label19.Visible = false;
					this.chkIsBoth.Checked = false;
				}
				else
				{
					this.txtCaseQty.Visible = false;
					this.Label18.Visible = false;
					this.cboProducts.Visible = true;
					this.Label19.Visible = true;
					this.txtCaseQty.Text = "0";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000128F4 File Offset: 0x00010AF4
		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboProducts.SelectedIndex = this.cboProducts.FindStringExact(this.ListBox1.SelectedItem.ToString());
				this.ListBox1.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting from list. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00012970 File Offset: 0x00010B70
		private void cboProducts_TextChanged(object sender, EventArgs e)
		{
			try
			{
				AddNewProdt2._Closure$__261-0 CS$<>8__locals1 = new AddNewProdt2._Closure$__261-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$Local_textToSearch = this.cboProducts.Text.ToLower();
				this.ListBox1.Visible = false;
				bool flag = string.IsNullOrEmpty(CS$<>8__locals1.$VB$Local_textToSearch);
				if (!flag)
				{
					var list = this.productsDatatable.AsEnumerable().Select((AddNewProdt2._Closure$__.$I261-0 == null) ? (AddNewProdt2._Closure$__.$I261-0 = (DataRow p) => new
					{
						ID = p.Field<int>("productid"),
						Name = p.Field<string>("productdesc")
					}) : AddNewProdt2._Closure$__.$I261-0).ToList();
					var list2 = list.Where(x => x.Name.ToLower().Contains(CS$<>8__locals1.$VB$Local_textToSearch)).ToList();
					bool flag2 = list2.Count == 0;
					if (!flag2)
					{
						this.ListBox1.Items.Clear();
						try
						{
							foreach (var anon in list2)
							{
								this.ListBox1.Items.Add(anon.Name);
							}
						}
						finally
						{
							var enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.ListBox1.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00012AD4 File Offset: 0x00010CD4
		private void chkIsBoth_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsBoth.Checked;
				if (@checked)
				{
					this.chkIsCase.Checked = false;
					this.cboProducts.Visible = true;
					this.Label19.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002A30 File Offset: 0x00000C30
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label22_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00012B40 File Offset: 0x00010D40
		private void chkIsTaxExempt_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsTaxExempt.Checked;
				if (@checked)
				{
					this.txtTaxRate.Text = "0";
					this.txtTaxRate.Enabled = false;
				}
				else
				{
					this.txtTaxRate.Enabled = true;
				}
				this.txtTaxRate.Text = "0";
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040000E0 RID: 224
		private string _cnn;

		// Token: 0x040000E1 RID: 225
		private int newID;

		// Token: 0x040000E2 RID: 226
		private PublicFunctions publicfunction;

		// Token: 0x040000E3 RID: 227
		private bool IsProductCodeGenerated;

		// Token: 0x040000E4 RID: 228
		private DataTable productsDatatable;
	}
}
