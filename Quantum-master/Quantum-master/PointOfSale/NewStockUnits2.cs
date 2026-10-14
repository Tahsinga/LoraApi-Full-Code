using System;
using System.Collections;
using System.Collections.Generic;
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
	// Token: 0x0200007F RID: 127
	[DesignerGenerated]
	public partial class NewStockUnits2 : Form
	{
		// Token: 0x06001CBC RID: 7356 RVA: 0x001016B4 File Offset: 0x000FF8B4
		public NewStockUnits2()
		{
			base.Load += this.NewStockUnits_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.first = false;
			this.CurrentRecordSerial = false;
			this.CurrentExpires = false;
			this.pf = new PublicFunctions();
			this.CurrentIsVoucher = false;
			this.@ref = "";
			this.prodtcode = "";
			this.InitializeComponent();
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00105B88 File Offset: 0x00103D88
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x00105B92 File Offset: 0x00103D92
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00105B9B File Offset: 0x00103D9B
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x00105BA5 File Offset: 0x00103DA5
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00105BAE File Offset: 0x00103DAE
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x00105BB8 File Offset: 0x00103DB8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00105BC1 File Offset: 0x00103DC1
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00105BCB File Offset: 0x00103DCB
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00105BD4 File Offset: 0x00103DD4
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x00105BE0 File Offset: 0x00103DE0
		internal virtual TextBox lblDesc
		{
			[CompilerGenerated]
			get
			{
				return this._lblDesc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lblDesc_TextChanged);
				TextBox textBox = this._lblDesc;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._lblDesc = value;
				textBox = this._lblDesc;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00105C23 File Offset: 0x00103E23
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x00105C30 File Offset: 0x00103E30
		internal virtual TextBox txtSearchProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtSearchProductCode_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode_TextChanged);
				TextBox textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode = value;
				textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00105C8E File Offset: 0x00103E8E
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x00105C98 File Offset: 0x00103E98
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

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00105CDB File Offset: 0x00103EDB
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x00105CE8 File Offset: 0x00103EE8
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

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00105D2B File Offset: 0x00103F2B
		// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x00105D35 File Offset: 0x00103F35
		internal virtual TextBox lblCalcGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00105D3E File Offset: 0x00103F3E
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x00105D48 File Offset: 0x00103F48
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x00105D51 File Offset: 0x00103F51
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x00105D5C File Offset: 0x00103F5C
		internal virtual TextBox lblNumUnits
		{
			[CompilerGenerated]
			get
			{
				return this._lblNumUnits;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.lblNumUnits_KeyPress);
				EventHandler eventHandler = new EventHandler(this.lblNumUnits_TextChanged);
				TextBox textBox = this._lblNumUnits;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._lblNumUnits = value;
				textBox = this._lblNumUnits;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x00105DBA File Offset: 0x00103FBA
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x00105DC4 File Offset: 0x00103FC4
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x00105DCD File Offset: 0x00103FCD
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x00105DD7 File Offset: 0x00103FD7
		internal virtual TextBox lblCostOfStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x00105DE0 File Offset: 0x00103FE0
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x00105DEC File Offset: 0x00103FEC
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

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00105E2F File Offset: 0x0010402F
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x00105E39 File Offset: 0x00104039
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x00105E42 File Offset: 0x00104042
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x00105E4C File Offset: 0x0010404C
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x00105E55 File Offset: 0x00104055
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x00105E60 File Offset: 0x00104060
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
				EventHandler eventHandler = new EventHandler(this.txtSellingPrice_TextChanged);
				TextBox textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtSellingPrice = value;
				textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x00105EBE File Offset: 0x001040BE
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x00105EC8 File Offset: 0x001040C8
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x00105ED1 File Offset: 0x001040D1
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x00105EDC File Offset: 0x001040DC
		internal virtual TextBox txtCostperUnit
		{
			[CompilerGenerated]
			get
			{
				return this._txtCostperUnit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCostperUnit_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtCostperUnit_TextChanged);
				TextBox textBox = this._txtCostperUnit;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtCostperUnit = value;
				textBox = this._txtCostperUnit;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x00105F3A File Offset: 0x0010413A
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x00105F44 File Offset: 0x00104144
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x00105F4D File Offset: 0x0010414D
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x00105F58 File Offset: 0x00104158
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

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x00105F9B File Offset: 0x0010419B
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x00105FA8 File Offset: 0x001041A8
		internal virtual TextBox txtref
		{
			[CompilerGenerated]
			get
			{
				return this._txtref;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtref_KeyDown);
				TextBox textBox = this._txtref;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtref = value;
				textBox = this._txtref;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x00105FEB File Offset: 0x001041EB
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x00105FF5 File Offset: 0x001041F5
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x00105FFE File Offset: 0x001041FE
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x00106008 File Offset: 0x00104208
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x00106011 File Offset: 0x00104211
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0010601B File Offset: 0x0010421B
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x00106024 File Offset: 0x00104224
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0010602E File Offset: 0x0010422E
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x00106037 File Offset: 0x00104237
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00106041 File Offset: 0x00104241
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0010604A File Offset: 0x0010424A
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x00106054 File Offset: 0x00104254
		internal virtual Label lblTotalGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0010605D File Offset: 0x0010425D
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x00106067 File Offset: 0x00104267
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x00106070 File Offset: 0x00104270
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0010607A File Offset: 0x0010427A
		internal virtual Label lbltotalcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x00106083 File Offset: 0x00104283
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0010608D File Offset: 0x0010428D
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00106096 File Offset: 0x00104296
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x001060A0 File Offset: 0x001042A0
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x001060A9 File Offset: 0x001042A9
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x001060B3 File Offset: 0x001042B3
		internal virtual DataGridViewTextBoxColumn Reorder
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x001060BC File Offset: 0x001042BC
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x001060C6 File Offset: 0x001042C6
		internal virtual DataGridViewTextBoxColumn TotalUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x001060CF File Offset: 0x001042CF
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x001060D9 File Offset: 0x001042D9
		internal virtual DataGridViewTextBoxColumn CostPerUnit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x001060E2 File Offset: 0x001042E2
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x001060EC File Offset: 0x001042EC
		internal virtual DataGridViewTextBoxColumn SellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x001060F5 File Offset: 0x001042F5
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x001060FF File Offset: 0x001042FF
		internal virtual DataGridViewTextBoxColumn Gross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00106108 File Offset: 0x00104308
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00106114 File Offset: 0x00104314
		internal virtual TextBox txtBarCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBarCode_KeyDown);
				EventHandler eventHandler = new EventHandler(this.txtBarCode_TextChanged);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00106172 File Offset: 0x00104372
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0010617C File Offset: 0x0010437C
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00106185 File Offset: 0x00104385
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0010618F File Offset: 0x0010438F
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00106198 File Offset: 0x00104398
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x001061A2 File Offset: 0x001043A2
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x001061AB File Offset: 0x001043AB
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x001061B8 File Offset: 0x001043B8
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

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x001061FB File Offset: 0x001043FB
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x00106205 File Offset: 0x00104405
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0010620E File Offset: 0x0010440E
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x00106218 File Offset: 0x00104418
		internal virtual TextBox txtsearch
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsearch_KeyDown);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00106276 File Offset: 0x00104476
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x00106280 File Offset: 0x00104480
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00106289 File Offset: 0x00104489
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x00106294 File Offset: 0x00104494
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x001062D7 File Offset: 0x001044D7
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x001062E1 File Offset: 0x001044E1
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x001062EA File Offset: 0x001044EA
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x001062F4 File Offset: 0x001044F4
		internal virtual DateTimePicker dtExpDate
		{
			[CompilerGenerated]
			get
			{
				return this._dtExpDate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.dtExpDate_ValueChanged);
				DateTimePicker dateTimePicker = this._dtExpDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._dtExpDate = value;
				dateTimePicker = this._dtExpDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00106337 File Offset: 0x00104537
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x00106341 File Offset: 0x00104541
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0010634A File Offset: 0x0010454A
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x00106354 File Offset: 0x00104554
		internal virtual TextBox txtQtyInPack
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0010635D File Offset: 0x0010455D
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x00106367 File Offset: 0x00104567
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00106370 File Offset: 0x00104570
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0010637A File Offset: 0x0010457A
		internal virtual TextBox txtNumPacks
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00106383 File Offset: 0x00104583
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0010638D File Offset: 0x0010458D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00106396 File Offset: 0x00104596
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x001063A0 File Offset: 0x001045A0
		internal virtual TextBox txtCostPerPack
		{
			[CompilerGenerated]
			get
			{
				return this._txtCostPerPack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtCostPerPack_Leave);
				TextBox textBox = this._txtCostPerPack;
				if (textBox != null)
				{
					textBox.Leave -= eventHandler;
				}
				this._txtCostPerPack = value;
				textBox = this._txtCostPerPack;
				if (textBox != null)
				{
					textBox.Leave += eventHandler;
				}
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x001063E3 File Offset: 0x001045E3
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x001063ED File Offset: 0x001045ED
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x001063F6 File Offset: 0x001045F6
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x00106400 File Offset: 0x00104600
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button6_Click);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00106443 File Offset: 0x00104643
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x00106450 File Offset: 0x00104650
		internal virtual Label Label24
		{
			[CompilerGenerated]
			get
			{
				return this._Label24;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label24_Click);
				Label label = this._Label24;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label24 = value;
				label = this._Label24;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00106493 File Offset: 0x00104693
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x001064A0 File Offset: 0x001046A0
		internal virtual TextBox txtMarkUp
		{
			[CompilerGenerated]
			get
			{
				return this._txtMarkUp;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtMarkUp_TextChanged);
				TextBox textBox = this._txtMarkUp;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtMarkUp = value;
				textBox = this._txtMarkUp;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x001064E3 File Offset: 0x001046E3
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x001064ED File Offset: 0x001046ED
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x001064F6 File Offset: 0x001046F6
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x00106500 File Offset: 0x00104700
		internal virtual Label lblTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00106509 File Offset: 0x00104709
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00106513 File Offset: 0x00104713
		internal virtual TextBox txtBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0010651C File Offset: 0x0010471C
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x00106526 File Offset: 0x00104726
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x0010652F File Offset: 0x0010472F
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0010653C File Offset: 0x0010473C
		internal virtual TextBox txtSellingPriceWholesale
		{
			[CompilerGenerated]
			get
			{
				return this._txtSellingPriceWholesale;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
				TextBox textBox = this._txtSellingPriceWholesale;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtSellingPriceWholesale = value;
				textBox = this._txtSellingPriceWholesale;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0010657F File Offset: 0x0010477F
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00106589 File Offset: 0x00104789
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00106592 File Offset: 0x00104792
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0010659C File Offset: 0x0010479C
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x001065A5 File Offset: 0x001047A5
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x001065AF File Offset: 0x001047AF
		internal virtual ComboBox cboSupplier
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x001065B8 File Offset: 0x001047B8
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x001065C4 File Offset: 0x001047C4
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

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00106607 File Offset: 0x00104807
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x00106611 File Offset: 0x00104811
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0010661A File Offset: 0x0010481A
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x00106624 File Offset: 0x00104824
		internal virtual ComboBox cboPayMethod
		{
			[CompilerGenerated]
			get
			{
				return this._cboPayMethod;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPayMethod_SelectedIndexChanged);
				ComboBox comboBox = this._cboPayMethod;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPayMethod = value;
				comboBox = this._cboPayMethod;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x00106667 File Offset: 0x00104867
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x00106674 File Offset: 0x00104874
		internal virtual TextBox txtcostbypaymethod
		{
			[CompilerGenerated]
			get
			{
				return this._txtcostbypaymethod;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtcostbypaymethod_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtcostbypaymethod_TextChanged);
				TextBox textBox = this._txtcostbypaymethod;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtcostbypaymethod = value;
				textBox = this._txtcostbypaymethod;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x001066D2 File Offset: 0x001048D2
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x001066DC File Offset: 0x001048DC
		internal virtual DataGridView DGVSearch
		{
			[CompilerGenerated]
			get
			{
				return this._DGVSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DGVSearch_CellContentClick);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler2;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler2;
				}
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00106755 File Offset: 0x00104955
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x0010675F File Offset: 0x0010495F
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00106768 File Offset: 0x00104968
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x00106772 File Offset: 0x00104972
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x0010677B File Offset: 0x0010497B
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x00106785 File Offset: 0x00104985
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x0010678E File Offset: 0x0010498E
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00106798 File Offset: 0x00104998
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x001067A1 File Offset: 0x001049A1
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x001067AB File Offset: 0x001049AB
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x001067B4 File Offset: 0x001049B4
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x001067BE File Offset: 0x001049BE
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x001067C7 File Offset: 0x001049C7
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x001067D1 File Offset: 0x001049D1
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x001067DA File Offset: 0x001049DA
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x001067E4 File Offset: 0x001049E4
		internal virtual Label Label33
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x001067ED File Offset: 0x001049ED
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x001067F7 File Offset: 0x001049F7
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00106800 File Offset: 0x00104A00
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x0010680A File Offset: 0x00104A0A
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00106813 File Offset: 0x00104A13
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x0010681D File Offset: 0x00104A1D
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00106826 File Offset: 0x00104A26
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x00106830 File Offset: 0x00104A30
		internal virtual Label Label35
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00106839 File Offset: 0x00104A39
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x00106844 File Offset: 0x00104A44
		internal virtual CheckBox chkUseSameSupplier
		{
			[CompilerGenerated]
			get
			{
				return this._chkUseSameSupplier;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkUseSameSupplier_CheckedChanged);
				CheckBox checkBox = this._chkUseSameSupplier;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkUseSameSupplier = value;
				checkBox = this._chkUseSameSupplier;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00106887 File Offset: 0x00104A87
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00106894 File Offset: 0x00104A94
		internal virtual Label lblsupplierid
		{
			[CompilerGenerated]
			get
			{
				return this._lblsupplierid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lblsupplierid_TextChanged_1);
				Label label = this._lblsupplierid;
				if (label != null)
				{
					label.TextChanged -= eventHandler;
				}
				this._lblsupplierid = value;
				label = this._lblsupplierid;
				if (label != null)
				{
					label.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x001068D7 File Offset: 0x00104AD7
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x001068E4 File Offset: 0x00104AE4
		internal virtual CheckBox chkUseBulkEntering
		{
			[CompilerGenerated]
			get
			{
				return this._chkUseBulkEntering;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkUseBulkEntering_CheckedChanged);
				CheckBox checkBox = this._chkUseBulkEntering;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkUseBulkEntering = value;
				checkBox = this._chkUseBulkEntering;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00106927 File Offset: 0x00104B27
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x00106934 File Offset: 0x00104B34
		internal virtual CheckBox chkOnAcc
		{
			[CompilerGenerated]
			get
			{
				return this._chkOnAcc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkOnAcc_CheckedChanged);
				CheckBox checkBox = this._chkOnAcc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkOnAcc = value;
				checkBox = this._chkOnAcc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00106977 File Offset: 0x00104B77
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00106981 File Offset: 0x00104B81
		internal virtual Panel Panel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x0010698A File Offset: 0x00104B8A
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00106994 File Offset: 0x00104B94
		internal virtual TextBox txtSupplierInvnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x0010699D File Offset: 0x00104B9D
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x001069A7 File Offset: 0x00104BA7
		internal virtual Label Label39
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x001069B0 File Offset: 0x00104BB0
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x001069BA File Offset: 0x00104BBA
		internal virtual TextBox txtTaxAmt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x001069C3 File Offset: 0x00104BC3
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x001069CD File Offset: 0x00104BCD
		internal virtual Label Label38
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x001069D6 File Offset: 0x00104BD6
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x001069E0 File Offset: 0x00104BE0
		internal virtual Label Label37
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x001069E9 File Offset: 0x00104BE9
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x001069F3 File Offset: 0x00104BF3
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x001069FC File Offset: 0x00104BFC
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x00106A06 File Offset: 0x00104C06
		internal virtual TextBox txtComments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x00106A0F File Offset: 0x00104C0F
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x00106A19 File Offset: 0x00104C19
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x00106A22 File Offset: 0x00104C22
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x00106A2C File Offset: 0x00104C2C
		internal virtual Label lblStockBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00106A35 File Offset: 0x00104C35
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x00106A40 File Offset: 0x00104C40
		internal virtual Button Button8
		{
			[CompilerGenerated]
			get
			{
				return this._Button8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button8_Click);
				Button button = this._Button8;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button8 = value;
				button = this._Button8;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00106A84 File Offset: 0x00104C84
		private void NewStockUnits_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtMarkUp.Text = MyProject.Forms.Form1.MarkUp.ToString();
				this.dtExpDate.Format = DateTimePickerFormat.Custom;
				this.dtExpDate.CustomFormat = " ";
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					this.dtExpDate.Visible = true;
					this.Label17.Visible = true;
					this.txtBatchNumber.Visible = true;
					this.Label26.Visible = true;
				}
				else
				{
					this.dtExpDate.Visible = false;
					this.Label17.Visible = false;
					this.txtBatchNumber.Visible = false;
					this.Label26.Visible = false;
				}
				this.LoadSuppliers();
				this.cboPayMethod.DataSource = this.pf.GetPaymentMethods(this._cnn);
				this.cboPayMethod.DisplayMember = "PaymentMethodDesc";
				this.cboPayMethod.ValueMember = "PaymentMethodID";
				this.LoadBranches();
				this.txtref.Text = "NEW" + DateTime.Today.ToString("yyyyMMdd");
				base.WindowState = FormWindowState.Maximized;
				bool flag2 = Operators.CompareString(this.@ref, "", false) != 0;
				if (flag2)
				{
					this.txtref.Text = this.@ref;
					this.txtBarCode.Text = this.prodtcode;
					this.FetchProdtDetails(this.txtBarCode.Text, MyProject.Forms.Form1.coid);
					this.lblNumUnits.Focus();
				}
				this.LoadPaymentTerms();
				bool flag3 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag3)
				{
					this.txtsearch.Focus();
				}
				else
				{
					this.txtBarCode.Focus();
				}
				bool flag4 = MyProject.Forms.Form1.DateChange == 1;
				if (flag4)
				{
					this.DTdate.Enabled = true;
				}
				else
				{
					this.DTdate.Enabled = false;
				}
				MyProject.Forms.Form1.datSerials.Rows.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00106D10 File Offset: 0x00104F10
		private void LoadSuppliers()
		{
			this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
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
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00106DB4 File Offset: 0x00104FB4
		private void FetchProdtDetails(string prodtcode, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtReorder.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ReorderLevel"])), 0, RuntimeHelpers.GetObjectValue(dataRow["ReorderLevel"])));
				this.txtSellingPrice.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
				this.lblDesc.Text = dataRow["ProductDesc"].ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
				this.CurrentRecordSerial = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])), false, RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])));
				bool currentExpires = this.CurrentExpires;
				if (currentExpires)
				{
					this.txtBatchNumber.Visible = true;
					this.dtExpDate.Visible = true;
					this.Label17.Visible = true;
					this.Label26.Visible = true;
				}
				else
				{
					this.txtBatchNumber.Visible = false;
					this.dtExpDate.Visible = false;
					this.Label17.Visible = false;
					this.Label26.Visible = false;
				}
				this.txtCostperUnit.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Cost"])));
				this.old_costprice = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Cost"])));
				bool flag2 = Operators.CompareString(this.cboPayMethod.Text, "", false) != 0;
				if (flag2)
				{
					this.txtcostbypaymethod.Text = Conversions.ToString(decimal.Multiply(this.rate, this.old_costprice));
				}
				this.old_sellingprice = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
				this.old_wholesaleqty = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQty"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQty"])));
				this.old_wholesaleprice = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])));
				this.txtSellingPriceWholesale.Text = this.old_wholesaleprice.ToString();
				this.txtCostperUnit.Text = this.old_costprice.ToString();
				this.currentUOM = Conversions.ToString(dataRow["UOM"]);
				this.lblsupplierid.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["supplierid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["supplierid"])));
				this.CheckSupplierName();
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.ClearForm();
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00107254 File Offset: 0x00105454
		private void CalcStats()
		{
			try
			{
				double num = Conversion.Val(this.lblNumUnits.Text) * Conversion.Val(this.txtCostperUnit.Text);
				double num2 = Conversion.Val(this.lblNumUnits.Text) * Conversion.Val(this.txtSellingPrice.Text);
				double num3 = num2 - num;
				this.lblCostOfStock.Text = Conversions.ToString(num);
				this.lblCalcGross.Text = Conversions.ToString(num3);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating.");
			}
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x001072FC File Offset: 0x001054FC
		private void lblsupplierid_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting supplier name. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00107344 File Offset: 0x00105544
		private void CheckSupplierName()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select suppliername from suppliers where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid) + " and supplierid=" + Conversions.ToString(Conversions.ToInteger(this.lblsupplierid.Text));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool @checked = this.chkUseSameSupplier.Checked;
				if (!@checked)
				{
					this.cboSupplier.SelectedIndex = this.cboSupplier.FindStringExact(Conversions.ToString(dataRow["suppliername"]));
				}
			}
			else
			{
				bool flag2 = !this.chkUseSameSupplier.Checked;
				if (flag2)
				{
					bool flag3 = this.cboSupplier.Items.Count == 1;
					if (flag3)
					{
						this.cboSupplier.SelectedIndex = 0;
					}
					else
					{
						this.cboSupplier.SelectedIndex = -1;
					}
				}
			}
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0010746C File Offset: 0x0010566C
		private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x001074B8 File Offset: 0x001056B8
		private void txtSellingPrice_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcStats();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating statistics. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x00107508 File Offset: 0x00105708
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				NewProdt2 newProdt = new NewProdt2();
				newProdt.ShowDialog(this);
				newProdt.Dispose();
				string newProdtCode = MyProject.Forms.Form1.newProdtCode;
				MyProject.Forms.Form1.newProdtCode = Conversions.ToString(0);
				MyProject.Forms.Form1.newProdtID = 0;
				this.txtSearchProductCode.Text = newProdtCode;
				this.lblNumUnits.Text = Conversions.ToString(MyProject.Forms.Form1.qtypurchased);
				MyProject.Forms.Form1.qtypurchased = 0m;
				this.LoadSuppliers();
				bool flag = Operators.CompareString(MyProject.Forms.Form1.supplierselected, "", false) != 0;
				if (flag)
				{
					this.cboSupplier.SelectedIndex = this.cboSupplier.FindStringExact(MyProject.Forms.Form1.supplierselected);
				}
				bool flag2 = (Operators.CompareString(this.lblNumUnits.Text, "0", false) != 0) & (MyProject.Forms.Form1.IsWarehouse != 1) & !this.CurrentExpires;
				if (flag2)
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox(string.Concat(new string[]
					{
						"Do you want to save purchase of ",
						this.lblNumUnits.Text,
						" X ",
						this.lblDesc.Text,
						"?"
					}), MsgBoxStyle.YesNo, null);
					bool flag3 = dialogResult == DialogResult.Yes;
					if (flag3)
					{
						bool currentIsVoucher = this.CurrentIsVoucher;
						if (currentIsVoucher)
						{
							MessageBox.Show("Product is a voucher and new stock cannot be added through this form. ");
						}
						else
						{
							bool flag4 = Operators.CompareString(this.cboBranch.Text, "", false) == 0;
							if (flag4)
							{
								MessageBox.Show("Select the branch first.");
							}
							else
							{
								this.SavePurchase();
							}
						}
					}
					else
					{
						this.txtsearch.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("New product error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x00107734 File Offset: 0x00105934
		private void txtCostOnePack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNumUnitsinPack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtPacks_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProductCode_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00107780 File Offset: 0x00105980
		private void SavePurchase()
		{
			bool flag = (Operators.CompareString(this.txtref.Text, "", false) != 0) & (Operators.CompareString(this.cboSupplier.Text, "", false) != 0);
			if (flag)
			{
				bool @checked = this.chkOnAcc.Checked;
				if (@checked)
				{
					bool flag2 = this.cboTerms.SelectedIndex == -1;
					if (flag2)
					{
						MessageBox.Show("Please select the Terms of the Credit purchacse before continuing.");
						this.cboTerms.Focus();
						return;
					}
				}
				bool flag3 = (Operators.CompareString(this.cboPayMethod.Text, "", false) == 0) & !this.chkOnAcc.Checked;
				if (flag3)
				{
					MessageBox.Show("Please select a payment method or check credit purchase.");
				}
				else
				{
					bool flag4 = (MyProject.Forms.Form1.IsWarehouse == 1) | this.CurrentExpires;
					if (flag4)
					{
						bool flag5 = Operators.CompareString(this.txtBatchNumber.Text, "", false) == 0;
						if (flag5)
						{
							DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Batch Number is not entered. Do you want to continue like that?" + this.lblNumUnits.Text, MsgBoxStyle.YesNo, null);
							bool flag6 = dialogResult == DialogResult.Yes;
							if (!flag6)
							{
								MessageBox.Show("Purchase NOT saved.");
								return;
							}
						}
					}
					bool currentRecordSerial = this.CurrentRecordSerial;
					if (currentRecordSerial)
					{
						EnterSerialNumbers enterSerialNumbers = new EnterSerialNumbers();
						enterSerialNumbers.productdesc = this.lblDesc.Text;
						enterSerialNumbers.numofproducts = checked((int)Math.Round(Conversion.Val(this.lblNumUnits.Text)));
						enterSerialNumbers.productid = this.CurrentID;
						enterSerialNumbers.ShowDialog(this);
						enterSerialNumbers.Dispose();
						bool flag7 = MyProject.Forms.Form1.datSerials.Rows.Count == 0;
						if (flag7)
						{
							MessageBox.Show("Cannot proceed without all " + MyProject.Forms.Form1.serialNumberName + " entered.");
							return;
						}
					}
					int num = 0;
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunNewStockSave");
					sqlCommand.Transaction = sqlTransaction;
					try
					{
						bool flag8 = this.CurrentID != 0;
						if (flag8)
						{
							bool flag9 = this.verify();
							if (flag9)
							{
								bool flag10 = this.first;
								if (flag10)
								{
									this.first = false;
								}
								bool flag11 = false;
								bool flag12 = false;
								bool flag13 = false;
								bool flag14 = decimal.Compare(this.old_sellingprice, Convert.ToDecimal(this.txtSellingPrice.Text)) != 0;
								if (flag14)
								{
									flag11 = true;
								}
								bool flag15 = decimal.Compare(this.old_wholesaleprice, Convert.ToDecimal(this.txtSellingPriceWholesale.Text)) != 0;
								if (flag15)
								{
									flag12 = true;
								}
								bool flag16 = decimal.Compare(this.old_costprice, Convert.ToDecimal(this.txtCostperUnit.Text)) != 0;
								if (flag16)
								{
									flag13 = true;
								}
								bool flag17 = flag11 || flag12 || flag13;
								if (flag17)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "Audit_PriceChangeInsert";
									sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("systemdate", DateTime.Now);
									sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", flag13);
									sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", flag11);
									sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", flag12);
									sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", false);
									sqlCommand.Parameters.AddWithValue("Old_CostPrice", this.old_costprice);
									sqlCommand.Parameters.AddWithValue("New_CostPrice", Convert.ToDecimal(this.txtCostperUnit.Text));
									sqlCommand.Parameters.AddWithValue("Old_SellingPrice", this.old_sellingprice);
									sqlCommand.Parameters.AddWithValue("New_SellingPrice", Convert.ToDecimal(this.txtSellingPrice.Text));
									sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", this.old_wholesaleprice);
									sqlCommand.Parameters.AddWithValue("New_WholesalePrice", Convert.ToDecimal(this.txtSellingPriceWholesale.Text));
									sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", this.old_wholesaleqty);
									sqlCommand.Parameters.AddWithValue("New_WholesaleQty", this.old_wholesaleqty);
									sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("comment", "NEW STOCK IN");
									sqlCommand.Parameters.AddWithValue("new_entryno", num);
									num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
								}
								bool flag18 = (MyProject.Forms.Form1.UseApprovals == 1) & (flag11 || flag12 || flag13);
								if (flag18)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "UpdateproductApproval";
									sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("unitsperpack", 0);
									sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
									sqlCommand.Parameters.AddWithValue("sellingprice", Conversion.Val(this.txtSellingPrice.Text));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(this.DTdate.Value.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("reorderlevel", Conversion.Val(this.txtReorder.Text));
									sqlCommand.Parameters.AddWithValue("wholesaleprice", Convert.ToDecimal(this.txtSellingPriceWholesale.Text));
									sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("productdesc", this.lblDesc.Text);
									sqlCommand.Parameters.AddWithValue("approval_audit_entryno", num);
									sqlCommand.ExecuteNonQuery();
								}
								else
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "Updateproduct";
									sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("unitsperpack", 0);
									sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
									sqlCommand.Parameters.AddWithValue("sellingprice", Conversion.Val(this.txtSellingPrice.Text));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("reorderlevel", Conversion.Val(this.txtReorder.Text));
									sqlCommand.Parameters.AddWithValue("wholesaleprice", Convert.ToDecimal(this.txtSellingPriceWholesale.Text));
									sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("approval_audit_entryno", num);
									sqlCommand.Parameters.AddWithValue("supplierid", RuntimeHelpers.GetObjectValue(this.cboSupplier.SelectedValue));
									sqlCommand.ExecuteNonQuery();
								}
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "GetNewInvoiceNumber";
								sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
								sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
								int num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertNewStock2Warehouse";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", num2);
								sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
								sqlCommand.Parameters.AddWithValue("isstockin", 1);
								sqlCommand.Parameters.AddWithValue("ref", this.txtref.Text);
								sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(this.lblNumUnits.Text));
								sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("trancode", 1);
								sqlCommand.Parameters.AddWithValue("productcode", this.txtSearchProductCode.Text);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
								sqlCommand.Parameters.AddWithValue("suppliername", this.cboSupplier.Text);
								sqlCommand.Parameters.AddWithValue("sellingprice", Conversion.Val(this.txtSellingPrice.Text));
								bool flag19 = MyProject.Forms.Form1.IsWarehouse == 1;
								if (flag19)
								{
									bool currentExpires = this.CurrentExpires;
									if (currentExpires)
									{
										sqlCommand.Parameters.AddWithValue("BatchNumber", this.txtBatchNumber.Text);
										sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(this.dtExpDate.Value.ToString("yyyyMMdd")));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("BatchNumber", "");
										sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
									}
								}
								else
								{
									sqlCommand.Parameters.AddWithValue("BatchNumber", "");
									sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
								}
								sqlCommand.Parameters.AddWithValue("paymentmethod", RuntimeHelpers.GetObjectValue(this.cboPayMethod.SelectedValue));
								sqlCommand.Parameters.AddWithValue("paymentmethodrate", this.rate);
								sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
								sqlCommand.Parameters.AddWithValue("iswarehouse", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.IsWarehouse == 1, 1, 0)));
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
								sqlCommand.ExecuteNonQuery();
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertBatchExpiry";
								sqlCommand.Parameters.AddWithValue("prodtid", this.CurrentID);
								sqlCommand.Parameters.AddWithValue("qty", Conversion.Val(this.lblNumUnits.Text));
								sqlCommand.Parameters.AddWithValue("expdate", Convert.ToInt32(this.dtExpDate.Value.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("purchasedate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
								sqlCommand.ExecuteNonQuery();
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertCreditorLog";
								sqlCommand.Parameters.AddWithValue("@SupplierID", RuntimeHelpers.GetObjectValue(this.cboSupplier.SelectedValue));
								sqlCommand.Parameters.AddWithValue("@TranType", 1);
								sqlCommand.Parameters.AddWithValue("@InvoiceNumber", this.txtSupplierInvnumber.Text);
								sqlCommand.Parameters.AddWithValue("@ref", this.txtComments.Text);
								sqlCommand.Parameters.AddWithValue("@AmtChargedTotal", Conversion.Val(this.txtCostperUnit.Text) * Conversion.Val(this.lblNumUnits.Text));
								sqlCommand.Parameters.AddWithValue("@TaxAmt", Conversion.Val(this.txtTaxAmt.Text));
								decimal num3 = 0m;
								bool checked2 = this.chkOnAcc.Checked;
								if (checked2)
								{
									num3 = 0m;
								}
								else
								{
									num3 = new decimal(Conversion.Val(this.lblNumUnits.Text) * Conversion.Val(this.txtCostperUnit.Text));
								}
								sqlCommand.Parameters.AddWithValue("@AmtPaid", num3);
								sqlCommand.Parameters.AddWithValue("@Bal", 0);
								sqlCommand.Parameters.AddWithValue("@TranDate", Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("@TranTime", DateTime.Now.ToString("hh:mm"));
								sqlCommand.Parameters.AddWithValue("@Coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("@Branch", this.cboBranch.Text);
								int num4 = 0;
								bool checked3 = this.chkOnAcc.Checked;
								if (checked3)
								{
									num4 = Conversions.ToInteger(this.cboTerms.SelectedValue);
								}
								sqlCommand.Parameters.AddWithValue("@Terms", num4);
								sqlCommand.Parameters.AddWithValue("@DueDate", Conversions.ToInteger(DateAndTime.DateAdd(DateInterval.Day, (double)num4, this.DTdate.Value).ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("@PaymentMethodID", 1);
								sqlCommand.Parameters.AddWithValue("@PaymentMethodDesc", this.cboPayMethod.Text);
								sqlCommand.Parameters.AddWithValue("@Comment", this.txtComments.Text);
								sqlCommand.Parameters.AddWithValue("@rate", this.rate);
								sqlCommand.Parameters.AddWithValue("@Uploaded", 0);
								sqlCommand.Parameters.AddWithValue("@doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("@machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("@MvtRef", num2);
								int num5;
								sqlCommand.Parameters.AddWithValue("@new_identity", num5);
								sqlCommand.ExecuteNonQuery();
								bool currentRecordSerial2 = this.CurrentRecordSerial;
								if (currentRecordSerial2)
								{
									try
									{
										foreach (object obj in MyProject.Forms.Form1.datSerials.Rows)
										{
											DataRow dataRow = (DataRow)obj;
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "SerialNumberInsert";
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
											sqlCommand.Parameters.AddWithValue("DateIn", this.DTdate.Value);
											sqlCommand.Parameters.AddWithValue("SupplierID", RuntimeHelpers.GetObjectValue(this.cboSupplier.SelectedValue));
											sqlCommand.Parameters.AddWithValue("SupplierInvoiceRef", this.txtref.Text);
											sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataRow["ProductID"]));
											sqlCommand.Parameters.AddWithValue("SerialNumber", RuntimeHelpers.GetObjectValue(dataRow["SerialNumber"]));
											sqlCommand.ExecuteNonQuery();
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
								sqlTransaction.Commit();
								sqlCommand.Connection.Close();
								MessageBox.Show("New stock added successfully.");
								this.AppendGrid();
								this.UpdateTotals();
								this.ClearForm();
							}
							else
							{
								MessageBox.Show("Please ensure that the number of units and cost of the units details are entered before proceeding.", "Error");
							}
						}
						else
						{
							MessageBox.Show("Please select the product first.");
							sqlConnection.Close();
						}
					}
					catch (SqlException ex)
					{
						bool flag20 = ex.Number == 547;
						if (flag20)
						{
							MessageBox.Show("This product has sales transactions and therefore cannot be deleted.", "Logical Error");
						}
						else
						{
							bool flag21 = ex.Number == 2627;
							if (flag21)
							{
								MessageBox.Show("Duplicate serial number for this product. Cannot enter. Change serial number. Chek Serial Numbers.");
							}
							else
							{
								MessageBox.Show("Database error. Cannot add product. Details" + ex.Message, "Database error");
							}
						}
						sqlTransaction.Rollback();
						sqlCommand.Connection.Close();
					}
					catch (Exception ex2)
					{
						MessageBox.Show("Error occurred. Detail: " + ex2.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("Ensure the reference and supplier details are entered.");
				this.txtref.Focus();
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00108BE8 File Offset: 0x00106DE8
		private void Button2_Click(object sender, EventArgs e)
		{
			bool currentIsVoucher = this.CurrentIsVoucher;
			if (currentIsVoucher)
			{
				MessageBox.Show("Product is a voucher and new stock cannot be added through this form. ");
			}
			else
			{
				bool flag = Operators.CompareString(this.cboBranch.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Select the branch first.");
				}
				else
				{
					this.SavePurchase();
				}
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00108C44 File Offset: 0x00106E44
		private bool verify()
		{
			bool flag = (Conversion.Val(this.txtCostperUnit.Text) <= 0.0) | (Conversion.Val(this.lblNumUnits.Text) <= 0.0);
			return !flag;
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00108CA4 File Offset: 0x00106EA4
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(this.txtSearchProductCode.Text, MyProject.Forms.Form1.coid);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00108D0C File Offset: 0x00106F0C
		private int GetInvoiceNum()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNewInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00108DE4 File Offset: 0x00106FE4
		private void InsertStock(int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock2";
			sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
			sqlCommand.Parameters.AddWithValue("isstockin", 1);
			sqlCommand.Parameters.AddWithValue("ref", this.txtref.Text);
			sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(this.lblNumUnits.Text));
			sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("trancode", 1);
			sqlCommand.Parameters.AddWithValue("productcode", this.txtSearchProductCode.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("suppliername", this.cboSupplier.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00109010 File Offset: 0x00107210
		private void InsertStockWarehouse(int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock2Warehouse";
			sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
			sqlCommand.Parameters.AddWithValue("isstockin", 1);
			sqlCommand.Parameters.AddWithValue("ref", this.txtref.Text);
			sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(this.lblNumUnits.Text));
			sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("trancode", 1);
			sqlCommand.Parameters.AddWithValue("productcode", this.txtSearchProductCode.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("BatchNumber", this.txtBatchNumber.Text);
			sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(this.dtExpDate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("suppliername", this.cboSupplier.Text);
			sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x001092DC File Offset: 0x001074DC
		private void AppendGrid()
		{
			string[] array = new string[]
			{
				this.lblDesc.Text,
				this.txtReorder.Text,
				this.lblNumUnits.Text,
				this.txtCostperUnit.Text,
				this.txtSellingPrice.Text,
				this.lblCalcGross.Text
			};
			this.DataGridView1.Rows.Add(array);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00109358 File Offset: 0x00107558
		private void UpdateTotals()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num = decimal.Add(num, decimal.Multiply(Conversions.ToDecimal(dataGridViewRow.Cells["CostperUnit"].Value), Conversions.ToDecimal(dataGridViewRow.Cells["TotalUnits"].Value)));
					num2 = decimal.Add(num2, Conversions.ToDecimal(dataGridViewRow.Cells["Gross"].Value));
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
			this.lbltotalcost.Text = Conversions.ToString(num);
			this.lblTotalGross.Text = Conversions.ToString(num2);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00109450 File Offset: 0x00107650
		private void ClearForm()
		{
			this.txtcostbypaymethod.Text = Conversions.ToString(0);
			this.lblDesc.Text = "";
			this.txtSellingPrice.Text = Conversions.ToString(0);
			this.lblNumUnits.Text = Conversions.ToString(0);
			this.CurrentID = 0;
			this.txtCostperUnit.Text = Conversions.ToString(0);
			this.lblCalcGross.Text = Conversions.ToString(0);
			this.txtReorder.Text = Conversions.ToString(0);
			this.dtExpDate.Format = DateTimePickerFormat.Custom;
			this.dtExpDate.CustomFormat = " ";
			this.txtBatchNumber.Text = "";
			this.txtSellingPriceWholesale.Text = Conversions.ToString(0);
			bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
			bool flag2 = Operators.CompareString(MyProject.Forms.Form1.ChangePaymentMethod, "", false) != 0;
			if (flag2)
			{
				this.cboPayMethod.SelectedIndex = this.cboPayMethod.FindStringExact(MyProject.Forms.Form1.ChangePaymentMethod);
			}
			else
			{
				this.cboPayMethod.SelectedIndex = 0;
			}
			bool flag3 = !this.chkUseSameSupplier.Checked;
			if (flag3)
			{
				this.cboSupplier.SelectedIndex = -1;
			}
			this.lblStockBal.Text = ".....";
			MyProject.Forms.Form1.datSerials.Rows.Clear();
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x001095FC File Offset: 0x001077FC
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.CalcStats();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating statistics. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0010964C File Offset: 0x0010784C
		private void lblNumUnits_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.currentUOM, "EA", false) == 0;
				if (flag)
				{
					e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
				}
				else
				{
					e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x001096FC File Offset: 0x001078FC
		private void txtCostperUnit_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00109748 File Offset: 0x00107948
		private void SearchBarCode(int barcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProductBarCode";
			sqlCommand.Parameters.AddWithValue("barcode", barcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtSearchProductCode.Text = Conversions.ToString(dataRow["ProductCode"]);
			}
			else
			{
				this.txtSearchProductCode.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0010981C File Offset: 0x00107A1C
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0010987C File Offset: 0x00107A7C
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DGVSearch.Columns["CatDesc"].Visible = false;
				this.DGVSearch.Columns["Reorder_Level"].Visible = false;
				this.DGVSearch.Columns["Unit_Selling_Price"].Visible = false;
				this.DGVSearch.Columns["Unit_Cost"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00109A54 File Offset: 0x00107C54
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = (e.KeyCode == Keys.Return) | (e.KeyCode == Keys.Tab);
				if (flag)
				{
					this.lblNumUnits.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00109AC0 File Offset: 0x00107CC0
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtSearchProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00109B80 File Offset: 0x00107D80
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00109C08 File Offset: 0x00107E08
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00109D00 File Offset: 0x00107F00
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtMarkUp.Text, "", false) != 0;
				if (flag)
				{
					decimal num = Convert.ToDecimal(this.txtCostperUnit.Text);
					decimal num2 = new decimal(Convert.ToDouble(num) + Convert.ToDouble(num) * ((double)Convert.ToInt32(this.txtMarkUp.Text) / 100.0));
					this.txtSellingPrice.Text = num2.ToString();
					this.Button2.Focus();
				}
				else
				{
					MessageBox.Show("Enter the mark up percentage first.");
					this.txtMarkUp.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating. Enter selling price manually. Detail: " + ex.Message);
				this.txtSellingPrice.Text = "0";
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00109DF0 File Offset: 0x00107FF0
		private void InsertBatchExp(int prodtid, double qty, int expdate, int purchasedate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertBatchExpiry";
			sqlCommand.Parameters.AddWithValue("prodtid", prodtid);
			sqlCommand.Parameters.AddWithValue("qty", qty);
			sqlCommand.Parameters.AddWithValue("expdate", expdate);
			sqlCommand.Parameters.AddWithValue("purchasedate", purchasedate);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00109EB8 File Offset: 0x001080B8
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				int num = checked(Convert.ToInt32(this.txtNumPacks.Text) * Convert.ToInt32(this.txtQtyInPack.Text));
				decimal num2 = decimal.Divide(Convert.ToDecimal(this.txtCostPerPack.Text), new decimal(Convert.ToInt32(this.txtQtyInPack.Text)));
				num2 = Math.Round(num2, 2);
				this.lblNumUnits.Text = num.ToString();
				this.txtCostperUnit.Text = Conversions.ToString(num2);
				this.txtNumPacks.Text = "";
				this.txtQtyInPack.Text = "";
				this.txtCostPerPack.Text = "";
				this.lblTotal.Text = "...";
				this.Button5.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00109FCC File Offset: 0x001081CC
		private void txtCostPerPack_Leave(object sender, EventArgs e)
		{
			try
			{
				decimal num = decimal.Multiply(new decimal(Convert.ToInt32(this.txtNumPacks.Text)), Convert.ToDecimal(this.txtCostPerPack.Text));
				this.lblTotal.Text = Math.Round(num, 2).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0010A044 File Offset: 0x00108244
		private void dtExpDate_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.dtExpDate.Format = DateTimePickerFormat.Short;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0010A084 File Offset: 0x00108284
		private void txtsearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.DGVSearch.Focus();
					e.Handled = true;
				}
				else
				{
					bool flag2 = e.KeyCode == Keys.Return;
					if (flag2)
					{
						this.lblerror.Text = "...";
						this.SearchByDescAdvanced(this.txtsearch.Text);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0010A10C File Offset: 0x0010830C
		private void SearchByDescAdvanced(string searchtext)
		{
			string[] array = searchtext.Split(new char[] { ' ' });
			int num = 1;
			DataTable dataTable = new DataTable();
			checked
			{
				foreach (string text in array)
				{
					bool flag = num == 1;
					if (flag)
					{
						dataTable = this.searchDB(text);
					}
					else
					{
						DataTable dataTable2 = new DataTable();
						dataTable2 = (DataTable)this.searchDat(dataTable, "ProductDesc", text);
						dataTable = dataTable2;
					}
					num++;
				}
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
				{
					this.DGVSearch.DataSource = dataTable;
					this.DGVSearch.Columns["ProductCode"].Visible = false;
					this.DGVSearch.Columns["ProductID"].Visible = false;
					this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					this.lblerror.Text = "No products match your search.";
				}
			}
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0010A218 File Offset: 0x00108418
		private object searchDat(DataTable dt, string column, string value)
		{
			NewStockUnits2._Closure$__452-0 CS$<>8__locals1 = new NewStockUnits2._Closure$__452-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((NewStockUnits2._Closure$__.$I452-0 == null) ? (NewStockUnits2._Closure$__.$I452-0 = (object row1) => (DataRow)row1) : NewStockUnits2._Closure$__.$I452-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
				{
					dataTable.ImportRow(dataRow);
				}
			}
			finally
			{
				IEnumerator<DataRow> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0010A2F4 File Offset: 0x001084F4
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0010A37C File Offset: 0x0010857C
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0010A3C8 File Offset: 0x001085C8
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				Suppliers suppliers = new Suppliers();
				suppliers.ShowDialog(this);
				suppliers.Dispose();
				string suppliername = MyProject.Forms.Form1.suppliername;
				this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "SupplierID";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.SelectedIndex = -1;
				this.cboSupplier.SelectedIndex = this.cboSupplier.FindStringExact(MyProject.Forms.Form1.suppliername);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error entering new supplier details at new stock purchase");
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0010A49C File Offset: 0x0010869C
		private void txtcostbypaymethod_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0010A4E8 File Offset: 0x001086E8
		private void txtcostbypaymethod_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtCostperUnit.Text = (Conversion.Val(this.txtcostbypaymethod.Text) / Convert.ToDouble(this.rate)).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating cost price in base currency. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0010A560 File Offset: 0x00108760
		private void cboPayMethod_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.rate = this.pf.GetRate(Conversions.ToInteger(this.cboPayMethod.SelectedValue), this._cnn);
				bool flag = (Operators.CompareString(this.txtcostbypaymethod.Text, "", false) != 0) | (Conversion.Val(this.txtcostbypaymethod.Text) != 0.0);
				if (flag)
				{
					this.txtCostperUnit.Text = (Conversion.Val(this.txtcostbypaymethod.Text) / Convert.ToDouble(this.rate)).ToString();
				}
				else
				{
					this.txtcostbypaymethod.Text = decimal.Multiply(this.old_costprice, this.rate).ToString();
				}
				this.Label7.Visible = true;
				this.txtcostbypaymethod.Visible = true;
				this.txtcostbypaymethod.Focus();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0010A674 File Offset: 0x00108874
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag6;
			try
			{
				bool flag = msg.WParam.ToInt32() == 34;
				if (flag)
				{
					this.SavePurchase();
				}
				else
				{
					bool flag2 = msg.WParam.ToInt32() == 33;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
						if (flag3)
						{
							this.txtsearch.Focus();
						}
						else
						{
							this.txtBarCode.Focus();
						}
					}
					else
					{
						bool flag4 = msg.WParam.ToInt32() == 112;
						if (flag4)
						{
							this.txtBarCode.Text = "";
							this.txtBarCode.Focus();
						}
						else
						{
							bool flag5 = msg.WParam.ToInt32() == 27;
							if (flag5)
							{
								this.ClearForm();
							}
						}
					}
				}
				flag6 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag6;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x0010A778 File Offset: 0x00108978
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
			int num = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
			this.cboBranch.SelectedIndex = num;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0010A844 File Offset: 0x00108A44
		private void chkUseSameSupplier_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.cboSupplier.SelectedIndex == -1) & this.chkUseSameSupplier.Checked;
				if (flag)
				{
					MessageBox.Show("Please select a supplier.");
					this.cboSupplier.Focus();
				}
				bool @checked = this.chkUseSameSupplier.Checked;
				if (@checked)
				{
					MessageBox.Show("Please note that the supplier for all products in this session will be changed to the current selected supplier.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002A30 File Offset: 0x00000C30
		private void DGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0010A8C8 File Offset: 0x00108AC8
		private void chkUseBulkEntering_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkUseBulkEntering.Checked;
				if (@checked)
				{
					this.GroupBox1.Visible = true;
				}
				else
				{
					this.GroupBox1.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0010A928 File Offset: 0x00108B28
		private void txtCostperUnit_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcStats();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0010A960 File Offset: 0x00108B60
		private void lblNumUnits_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcStats();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0010A998 File Offset: 0x00108B98
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.FetchProdtDetails(this.txtBarCode.Text, MyProject.Forms.Form1.coid);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0010AA10 File Offset: 0x00108C10
		private void txtref_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0010AA48 File Offset: 0x00108C48
		private void LoadPaymentTerms()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentTerms";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboTerms.DataSource = dataTable;
			this.cboTerms.DisplayMember = "Description";
			this.cboTerms.ValueMember = "TermsDays";
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0010AAE8 File Offset: 0x00108CE8
		private void chkOnAcc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkOnAcc.Checked;
				if (@checked)
				{
					this.cboTerms.Visible = true;
					this.Label37.Visible = true;
					this.Panel5.Visible = true;
				}
				else
				{
					this.cboTerms.Visible = false;
					this.Label37.Visible = false;
					this.Panel5.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label24_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0010AB7C File Offset: 0x00108D7C
		private void lblDesc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblStockBal.Text = ".....";
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0010ABC0 File Offset: 0x00108DC0
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.IsWarehouse | ((-((this.CurrentExpires > false) ? 1 : 0)) ? 1 : 0)) != 0;
				if (flag)
				{
					BatchSelect batchSelect = new BatchSelect();
					batchSelect.productid = this.CurrentID;
					batchSelect.coid = MyProject.Forms.Form1.coid;
					batchSelect.branch = MyProject.Forms.Form1.branch;
					batchSelect.ViewOnly = true;
					batchSelect.ShowDialog(this);
					batchSelect.Dispose();
				}
				else
				{
					this.lblStockBal.Text = this.pf.GetStockBalSimple(this._cnn, this.CurrentID, MyProject.Forms.Form1.coid, this.cboBranch.Text).ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock balance. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtMarkUp_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000E20 RID: 3616
		private string _cnn;

		// Token: 0x04000E21 RID: 3617
		private bool first;

		// Token: 0x04000E22 RID: 3618
		private int CurrentID;

		// Token: 0x04000E23 RID: 3619
		private bool CurrentRecordSerial;

		// Token: 0x04000E24 RID: 3620
		private bool CurrentExpires;

		// Token: 0x04000E25 RID: 3621
		private decimal old_costprice;

		// Token: 0x04000E26 RID: 3622
		private decimal old_sellingprice;

		// Token: 0x04000E27 RID: 3623
		private decimal old_wholesaleprice;

		// Token: 0x04000E28 RID: 3624
		private decimal old_wholesaleqty;

		// Token: 0x04000E29 RID: 3625
		private PublicFunctions pf;

		// Token: 0x04000E2A RID: 3626
		private string currentUOM;

		// Token: 0x04000E2B RID: 3627
		private decimal rate;

		// Token: 0x04000E2C RID: 3628
		private bool CurrentIsVoucher;

		// Token: 0x04000E2D RID: 3629
		public string @ref;

		// Token: 0x04000E2E RID: 3630
		public string prodtcode;
	}
}
