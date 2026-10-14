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
	// Token: 0x0200007E RID: 126
	[DesignerGenerated]
	public partial class NewStockUnits : Form
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x000FE448 File Offset: 0x000FC648
		public NewStockUnits()
		{
			base.Load += this.NewStockUnits_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.first = false;
			this.InitializeComponent();
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x000FFF85 File Offset: 0x000FE185
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x000FFF8F File Offset: 0x000FE18F
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000FFF98 File Offset: 0x000FE198
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x000FFFA2 File Offset: 0x000FE1A2
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x000FFFAB File Offset: 0x000FE1AB
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x000FFFB5 File Offset: 0x000FE1B5
		internal virtual Label lblTotalGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x000FFFBE File Offset: 0x000FE1BE
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x000FFFC8 File Offset: 0x000FE1C8
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x000FFFD1 File Offset: 0x000FE1D1
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x000FFFDB File Offset: 0x000FE1DB
		internal virtual Label lbltotalcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x000FFFE4 File Offset: 0x000FE1E4
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x000FFFF0 File Offset: 0x000FE1F0
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

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00100033 File Offset: 0x000FE233
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00100040 File Offset: 0x000FE240
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

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00100083 File Offset: 0x000FE283
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0010008D File Offset: 0x000FE28D
		internal virtual TextBox lblCalcGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00100096 File Offset: 0x000FE296
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x001000A0 File Offset: 0x000FE2A0
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x001000A9 File Offset: 0x000FE2A9
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x001000B4 File Offset: 0x000FE2B4
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
				TextBox textBox = this._lblNumUnits;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._lblNumUnits = value;
				textBox = this._lblNumUnits;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x001000F7 File Offset: 0x000FE2F7
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x00100101 File Offset: 0x000FE301
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0010010A File Offset: 0x000FE30A
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x00100114 File Offset: 0x000FE314
		internal virtual TextBox lblCostOfStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x0010011D File Offset: 0x000FE31D
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x00100128 File Offset: 0x000FE328
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

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0010016B File Offset: 0x000FE36B
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x00100175 File Offset: 0x000FE375
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0010017E File Offset: 0x000FE37E
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x00100188 File Offset: 0x000FE388
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00100191 File Offset: 0x000FE391
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0010019C File Offset: 0x000FE39C
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

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x001001FA File Offset: 0x000FE3FA
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x00100204 File Offset: 0x000FE404
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0010020D File Offset: 0x000FE40D
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x00100217 File Offset: 0x000FE417
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x00100220 File Offset: 0x000FE420
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x0010022A File Offset: 0x000FE42A
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00100233 File Offset: 0x000FE433
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0010023D File Offset: 0x000FE43D
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x00100246 File Offset: 0x000FE446
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x00100250 File Offset: 0x000FE450
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00100259 File Offset: 0x000FE459
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x00100264 File Offset: 0x000FE464
		internal virtual TextBox txtSearchProdtID
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProdtID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtSearchProdtID_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtSearchProdtID_TextChanged);
				TextBox textBox = this._txtSearchProdtID;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProdtID = value;
				textBox = this._txtSearchProdtID;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x001002C2 File Offset: 0x000FE4C2
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x001002CC File Offset: 0x000FE4CC
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x001002D5 File Offset: 0x000FE4D5
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x001002E0 File Offset: 0x000FE4E0
		internal virtual ComboBox cboCategory
		{
			[CompilerGenerated]
			get
			{
				return this._cboCategory;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCategory_SelectedIndexChanged);
				ComboBox comboBox = this._cboCategory;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCategory = value;
				comboBox = this._cboCategory;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00100323 File Offset: 0x000FE523
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x0010032D File Offset: 0x000FE52D
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00100336 File Offset: 0x000FE536
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x00100340 File Offset: 0x000FE540
		internal virtual ComboBox cboProdt
		{
			[CompilerGenerated]
			get
			{
				return this._cboProdt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboProdt_KeyUp);
				EventHandler eventHandler = new EventHandler(this.cboProdt_SelectedIndexChanged);
				ComboBox comboBox = this._cboProdt;
				if (comboBox != null)
				{
					comboBox.KeyUp -= keyEventHandler;
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboProdt = value;
				comboBox = this._cboProdt;
				if (comboBox != null)
				{
					comboBox.KeyUp += keyEventHandler;
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x0010039E File Offset: 0x000FE59E
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x001003A8 File Offset: 0x000FE5A8
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x001003B1 File Offset: 0x000FE5B1
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x001003BB File Offset: 0x000FE5BB
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x001003C4 File Offset: 0x000FE5C4
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x001003CE File Offset: 0x000FE5CE
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x001003D7 File Offset: 0x000FE5D7
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x001003E4 File Offset: 0x000FE5E4
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
				TextBox textBox = this._txtCostperUnit;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCostperUnit = value;
				textBox = this._txtCostperUnit;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x00100427 File Offset: 0x000FE627
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x00100431 File Offset: 0x000FE631
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x0010043A File Offset: 0x000FE63A
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x00100444 File Offset: 0x000FE644
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0010044D File Offset: 0x000FE64D
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x00100458 File Offset: 0x000FE658
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

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0010049B File Offset: 0x000FE69B
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x001004A5 File Offset: 0x000FE6A5
		internal virtual TextBox txtref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x001004AE File Offset: 0x000FE6AE
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x001004B8 File Offset: 0x000FE6B8
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x001004C1 File Offset: 0x000FE6C1
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x001004CB File Offset: 0x000FE6CB
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x001004D4 File Offset: 0x000FE6D4
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x001004DE File Offset: 0x000FE6DE
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x001004E7 File Offset: 0x000FE6E7
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x001004F1 File Offset: 0x000FE6F1
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x001004FA File Offset: 0x000FE6FA
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00100504 File Offset: 0x000FE704
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x0010050D File Offset: 0x000FE70D
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x00100517 File Offset: 0x000FE717
		internal virtual DataGridViewTextBoxColumn Reorder
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00100520 File Offset: 0x000FE720
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0010052A File Offset: 0x000FE72A
		internal virtual DataGridViewTextBoxColumn TotalUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00100533 File Offset: 0x000FE733
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x0010053D File Offset: 0x000FE73D
		internal virtual DataGridViewTextBoxColumn CostPerUnit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00100546 File Offset: 0x000FE746
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00100550 File Offset: 0x000FE750
		internal virtual DataGridViewTextBoxColumn SellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00100559 File Offset: 0x000FE759
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00100563 File Offset: 0x000FE763
		internal virtual DataGridViewTextBoxColumn Gross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0010056C File Offset: 0x000FE76C
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x00100576 File Offset: 0x000FE776
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0010057F File Offset: 0x000FE77F
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0010058C File Offset: 0x000FE78C
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
				EventHandler eventHandler = new EventHandler(this.txtBarCode_TextChanged);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x001005CF File Offset: 0x000FE7CF
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x001005D9 File Offset: 0x000FE7D9
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x001005E4 File Offset: 0x000FE7E4
		private void NewStockUnits_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategories();
				this.LoadProducts(Conversions.ToInteger(this.cboCategory.SelectedValue));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0010064C File Offset: 0x000FE84C
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboCategory.DataSource = dataTable;
			this.cboCategory.ValueMember = "CatID";
			this.cboCategory.DisplayMember = "CatDesc";
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x001006EC File Offset: 0x000FE8EC
		private void LoadProducts(int catid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductsByCategory";
			sqlCommand.Parameters.AddWithValue("category", catid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboProdt.DataSource = dataTable;
			this.cboProdt.ValueMember = "ProductID";
			this.cboProdt.DisplayMember = "ProductDesc";
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x001007A4 File Offset: 0x000FE9A4
		private void FetchProdtDetails(int prodtid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtReorder.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ReorderLevel"])), 0, RuntimeHelpers.GetObjectValue(dataRow["ReorderLevel"])));
				this.txtSellingPrice.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.ClearForm();
			}
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00100908 File Offset: 0x000FEB08
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

		// Token: 0x06001CA3 RID: 7331 RVA: 0x001009B0 File Offset: 0x000FEBB0
		private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadProducts(Conversions.ToInteger(this.cboCategory.SelectedValue));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x001009F8 File Offset: 0x000FEBF8
		private void cboProdt_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = (e.KeyCode == Keys.Back) | (e.KeyCode == Keys.Left) | (e.KeyCode == Keys.Right) | (e.KeyCode == Keys.Up) | (e.KeyCode == Keys.Delete) | (e.KeyCode == Keys.Down) | (e.KeyCode == Keys.Prior) | (e.KeyCode == Keys.Next) | (e.KeyCode == Keys.Home) | (e.KeyCode == Keys.End);
			if (!flag)
			{
				string text = this.cboProdt.Text;
				int num = this.cboProdt.FindString(text);
				bool flag2 = num > -1;
				if (flag2)
				{
					string text2 = this.cboProdt.Items[num].ToString();
					this.cboProdt.SelectedIndex = num;
					this.cboProdt.SelectionStart = text.Length;
					this.cboProdt.SelectionLength = text2.Length;
				}
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00100AE8 File Offset: 0x000FECE8
		private void cboProdt_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtSearchProdtID.Text = Conversions.ToString(this.cboProdt.SelectedValue);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00100B38 File Offset: 0x000FED38
		private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00100B84 File Offset: 0x000FED84
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

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00100BD4 File Offset: 0x000FEDD4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				NewProdt newProdt = new NewProdt();
				newProdt.ShowDialog(this);
				newProdt.Dispose();
				int newProdtID = MyProject.Forms.Form1.newProdtID;
				this.txtSearchProdtID.Text = Conversions.ToString(newProdtID);
				this.lblNumUnits.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("New product error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00100C60 File Offset: 0x000FEE60
		private void txtCostOnePack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNumUnitsinPack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtPacks_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtSearchProdtID_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00100CAC File Offset: 0x000FEEAC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.verify();
				if (flag)
				{
					bool flag2 = this.first;
					if (flag2)
					{
						this.invnum = this.GetInvoiceNum();
						this.first = false;
					}
					this.UpdateProduct();
					this.InsertStock(this.GetInvoiceNum());
					this.AppendGrid();
					this.UpdateTotals();
					this.ClearForm();
					this.txtSearchProdtID.Focus();
				}
				else
				{
					MessageBox.Show("Please ensure that the number of units and cost of the units details are entered before proceeding.", "Error");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving new stock item. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00100D68 File Offset: 0x000FEF68
		private bool verify()
		{
			bool flag = (Conversion.Val(this.txtCostperUnit.Text) <= 0.0) | (Conversion.Val(this.lblNumUnits.Text) <= 0.0);
			return !flag;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00100DC8 File Offset: 0x000FEFC8
		private void txtSearchProdtID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboProdt.Text = "-";
				this.FetchProdtDetails(checked((int)Math.Round(Conversion.Val(this.txtSearchProdtID.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00100E40 File Offset: 0x000FF040
		private void UpdateProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Updateproduct";
			sqlCommand.Parameters.AddWithValue("productid", Conversion.Val(this.txtSearchProdtID.Text));
			sqlCommand.Parameters.AddWithValue("unitsperpack", 0);
			sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
			sqlCommand.Parameters.AddWithValue("sellingprice", Conversion.Val(this.txtSellingPrice.Text));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("reorderlevel", Conversion.Val(this.txtReorder.Text));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00100FD4 File Offset: 0x000FF1D4
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

		// Token: 0x06001CB3 RID: 7347 RVA: 0x001010AC File Offset: 0x000FF2AC
		private void InsertStock(int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock";
			sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", this.txtSearchProdtID.Text);
			sqlCommand.Parameters.AddWithValue("isstockin", 1);
			sqlCommand.Parameters.AddWithValue("ref", this.txtref.Text);
			sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(this.lblNumUnits.Text));
			sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("trancode", 1);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x001012A0 File Offset: 0x000FF4A0
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

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0010131C File Offset: 0x000FF51C
		private void UpdateTotals()
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CostperUnit"].Value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TotalUnits"].Value));
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Gross"].Value));
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

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0010141C File Offset: 0x000FF61C
		private void ClearForm()
		{
			this.txtref.Text = "";
			this.txtSellingPrice.Text = Conversions.ToString(0);
			this.lblNumUnits.Text = Conversions.ToString(0);
			this.txtCostperUnit.Text = Conversions.ToString(0);
			this.lblCalcGross.Text = Conversions.ToString(0);
			this.txtReorder.Text = Conversions.ToString(0);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00101498 File Offset: 0x000FF698
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

		// Token: 0x06001CB8 RID: 7352 RVA: 0x001014E8 File Offset: 0x000FF6E8
		private void lblNumUnits_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00101534 File Offset: 0x000FF734
		private void txtCostperUnit_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00101580 File Offset: 0x000FF780
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
				this.txtSearchProdtID.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProdtID.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00101654 File Offset: 0x000FF854
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SearchBarCode(Conversions.ToInteger(this.txtBarCode.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching bar code. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000DBA RID: 3514
		private string _cnn;

		// Token: 0x04000DBB RID: 3515
		private bool first;

		// Token: 0x04000DBC RID: 3516
		private int invnum;
	}
}
