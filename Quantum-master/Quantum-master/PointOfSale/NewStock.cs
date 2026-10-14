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
	// Token: 0x0200007C RID: 124
	[DesignerGenerated]
	public partial class NewStock : Form
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x000F6A30 File Offset: 0x000F4C30
		public NewStock()
		{
			base.Load += this.NewStock_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.first = false;
			this.InitializeComponent();
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x000F8DE3 File Offset: 0x000F6FE3
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x000F8DED File Offset: 0x000F6FED
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x000F8DF6 File Offset: 0x000F6FF6
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x000F8E00 File Offset: 0x000F7000
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x000F8E09 File Offset: 0x000F7009
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x000F8E14 File Offset: 0x000F7014
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

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x000F8E57 File Offset: 0x000F7057
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x000F8E64 File Offset: 0x000F7064
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

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x000F8EA7 File Offset: 0x000F70A7
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x000F8EB1 File Offset: 0x000F70B1
		internal virtual TextBox txtref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000F8EBA File Offset: 0x000F70BA
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x000F8EC4 File Offset: 0x000F70C4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x000F8ECD File Offset: 0x000F70CD
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x000F8ED7 File Offset: 0x000F70D7
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x000F8EE0 File Offset: 0x000F70E0
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x000F8EEA File Offset: 0x000F70EA
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x000F8EF3 File Offset: 0x000F70F3
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x000F8EFD File Offset: 0x000F70FD
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x000F8F06 File Offset: 0x000F7106
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x000F8F10 File Offset: 0x000F7110
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x000F8F19 File Offset: 0x000F7119
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x000F8F23 File Offset: 0x000F7123
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x000F8F2C File Offset: 0x000F712C
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x000F8F38 File Offset: 0x000F7138
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

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x000F8F96 File Offset: 0x000F7196
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x000F8FA0 File Offset: 0x000F71A0
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x000F8FA9 File Offset: 0x000F71A9
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x000F8FB4 File Offset: 0x000F71B4
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

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x000F9012 File Offset: 0x000F7212
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x000F901C File Offset: 0x000F721C
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x000F9025 File Offset: 0x000F7225
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x000F902F File Offset: 0x000F722F
		internal virtual TextBox txtCostperUnit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x000F9038 File Offset: 0x000F7238
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x000F9042 File Offset: 0x000F7242
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x000F904B File Offset: 0x000F724B
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x000F9058 File Offset: 0x000F7258
		internal virtual TextBox txtCostOnePack
		{
			[CompilerGenerated]
			get
			{
				return this._txtCostOnePack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCostOnePack_KeyPress);
				TextBox textBox = this._txtCostOnePack;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCostOnePack = value;
				textBox = this._txtCostOnePack;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x000F909B File Offset: 0x000F729B
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x000F90A5 File Offset: 0x000F72A5
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x000F90AE File Offset: 0x000F72AE
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x000F90B8 File Offset: 0x000F72B8
		internal virtual TextBox txtNumUnitsinPack
		{
			[CompilerGenerated]
			get
			{
				return this._txtNumUnitsinPack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNumUnitsinPack_KeyPress);
				TextBox textBox = this._txtNumUnitsinPack;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNumUnitsinPack = value;
				textBox = this._txtNumUnitsinPack;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x000F90FB File Offset: 0x000F72FB
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x000F9105 File Offset: 0x000F7305
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x000F910E File Offset: 0x000F730E
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x000F9118 File Offset: 0x000F7318
		internal virtual TextBox txtPacks
		{
			[CompilerGenerated]
			get
			{
				return this._txtPacks;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPacks_KeyPress);
				TextBox textBox = this._txtPacks;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPacks = value;
				textBox = this._txtPacks;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000F915B File Offset: 0x000F735B
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x000F9165 File Offset: 0x000F7365
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x000F916E File Offset: 0x000F736E
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x000F9178 File Offset: 0x000F7378
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x000F9181 File Offset: 0x000F7381
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x000F918C File Offset: 0x000F738C
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

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x000F91CF File Offset: 0x000F73CF
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x000F91D9 File Offset: 0x000F73D9
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x000F91E2 File Offset: 0x000F73E2
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x000F91EC File Offset: 0x000F73EC
		internal virtual TextBox lblCostOfStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x000F91F5 File Offset: 0x000F73F5
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x000F91FF File Offset: 0x000F73FF
		internal virtual TextBox lblCalcGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x000F9208 File Offset: 0x000F7408
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x000F9212 File Offset: 0x000F7412
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x000F921B File Offset: 0x000F741B
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x000F9225 File Offset: 0x000F7425
		internal virtual TextBox lblNumUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x000F922E File Offset: 0x000F742E
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x000F9238 File Offset: 0x000F7438
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x000F9241 File Offset: 0x000F7441
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x000F924C File Offset: 0x000F744C
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x000F928F File Offset: 0x000F748F
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x000F929C File Offset: 0x000F749C
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x000F92DF File Offset: 0x000F74DF
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x000F92E9 File Offset: 0x000F74E9
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x000F92F2 File Offset: 0x000F74F2
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x000F92FC File Offset: 0x000F74FC
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x000F9305 File Offset: 0x000F7505
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x000F930F File Offset: 0x000F750F
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x000F9318 File Offset: 0x000F7518
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x000F9324 File Offset: 0x000F7524
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

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000F9382 File Offset: 0x000F7582
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x000F938C File Offset: 0x000F758C
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x000F9395 File Offset: 0x000F7595
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x000F939F File Offset: 0x000F759F
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x000F93A8 File Offset: 0x000F75A8
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x000F93B2 File Offset: 0x000F75B2
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x000F93BB File Offset: 0x000F75BB
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x000F93C5 File Offset: 0x000F75C5
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x000F93CE File Offset: 0x000F75CE
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x000F93D8 File Offset: 0x000F75D8
		internal virtual DataGridViewTextBoxColumn NumUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x000F93E1 File Offset: 0x000F75E1
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x000F93EB File Offset: 0x000F75EB
		internal virtual DataGridViewTextBoxColumn Packs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000F93F4 File Offset: 0x000F75F4
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x000F93FE File Offset: 0x000F75FE
		internal virtual DataGridViewTextBoxColumn Reorder
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000F9407 File Offset: 0x000F7607
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x000F9411 File Offset: 0x000F7611
		internal virtual DataGridViewTextBoxColumn TotalUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x000F941A File Offset: 0x000F761A
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x000F9424 File Offset: 0x000F7624
		internal virtual DataGridViewTextBoxColumn CostPerUnit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x000F942D File Offset: 0x000F762D
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x000F9437 File Offset: 0x000F7637
		internal virtual DataGridViewTextBoxColumn SellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x000F9440 File Offset: 0x000F7640
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x000F944A File Offset: 0x000F764A
		internal virtual DataGridViewTextBoxColumn Gross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x000F9453 File Offset: 0x000F7653
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x000F945D File Offset: 0x000F765D
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000F9466 File Offset: 0x000F7666
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x000F9470 File Offset: 0x000F7670
		internal virtual Label lblTotalGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x000F9479 File Offset: 0x000F7679
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x000F9483 File Offset: 0x000F7683
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x000F948C File Offset: 0x000F768C
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x000F9496 File Offset: 0x000F7696
		internal virtual Label lbltotalcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x000F949F File Offset: 0x000F769F
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x000F94A9 File Offset: 0x000F76A9
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000F94B2 File Offset: 0x000F76B2
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x000F94BC File Offset: 0x000F76BC
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

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000F94FF File Offset: 0x000F76FF
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x000F9509 File Offset: 0x000F7709
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x000F9512 File Offset: 0x000F7712
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x000F951C File Offset: 0x000F771C
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x000F9525 File Offset: 0x000F7725
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x000F9530 File Offset: 0x000F7730
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x000F958E File Offset: 0x000F778E
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x000F9598 File Offset: 0x000F7798
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x000F95A1 File Offset: 0x000F77A1
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x000F95AC File Offset: 0x000F77AC
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

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x000F95EF File Offset: 0x000F77EF
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x000F95F9 File Offset: 0x000F77F9
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x000F9602 File Offset: 0x000F7802
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x000F960C File Offset: 0x000F780C
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
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x000F964F File Offset: 0x000F784F
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x000F9659 File Offset: 0x000F7859
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000F9664 File Offset: 0x000F7864
		private void NewStock_Load(object sender, EventArgs e)
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

		// Token: 0x06001B90 RID: 7056 RVA: 0x000F96CC File Offset: 0x000F78CC
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

		// Token: 0x06001B91 RID: 7057 RVA: 0x000F976C File Offset: 0x000F796C
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

		// Token: 0x06001B92 RID: 7058 RVA: 0x000F9824 File Offset: 0x000F7A24
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
				this.txtNumUnitsinPack.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["UnitsPerPack"])), 0, RuntimeHelpers.GetObjectValue(dataRow["UnitsPerPack"])));
				this.txtSellingPrice.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtCostOnePack.Text = Conversions.ToString(Operators.MultiplyObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["cost"])), Conversion.Val(this.txtNumUnitsinPack.Text)));
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.ClearForm();
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000F9A28 File Offset: 0x000F7C28
		private void CalcStats()
		{
			try
			{
				double num = Conversion.Val(this.txtCostOnePack.Text) * Conversion.Val(this.txtPacks.Text);
				double num2 = Conversion.Val(this.txtCostOnePack.Text) / Conversion.Val(this.txtNumUnitsinPack.Text);
				double num3 = Conversion.Val(this.txtNumUnitsinPack.Text) * Conversion.Val(this.txtPacks.Text) * Conversion.Val(this.txtSellingPrice.Text) - num;
				this.lblCostOfStock.Text = Conversions.ToString(num);
				this.lblCalcGross.Text = Conversions.ToString(num3);
				this.txtCostperUnit.Text = Conversions.ToString(num2);
				this.lblNumUnits.Text = Conversions.ToString(Conversion.Val(this.txtNumUnitsinPack.Text) * Conversion.Val(this.txtPacks.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating.");
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000F9B48 File Offset: 0x000F7D48
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

		// Token: 0x06001B95 RID: 7061 RVA: 0x000F9B90 File Offset: 0x000F7D90
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

		// Token: 0x06001B96 RID: 7062 RVA: 0x000F9C80 File Offset: 0x000F7E80
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

		// Token: 0x06001B97 RID: 7063 RVA: 0x000F9CD0 File Offset: 0x000F7ED0
		private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000F9D1C File Offset: 0x000F7F1C
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

		// Token: 0x06001B99 RID: 7065 RVA: 0x000F9D6C File Offset: 0x000F7F6C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				NewProdt newProdt = new NewProdt();
				newProdt.ShowDialog(this);
				newProdt.Dispose();
				int newProdtID = MyProject.Forms.Form1.newProdtID;
				this.txtSearchProdtID.Text = Conversions.ToString(newProdtID);
				this.txtPacks.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("New product error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000F9DF8 File Offset: 0x000F7FF8
		private void txtCostOnePack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000F9E44 File Offset: 0x000F8044
		private void txtNumUnitsinPack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtPacks_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtSearchProdtID_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000F9E90 File Offset: 0x000F8090
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.CalcStats();
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
					this.InsertStock(this.invnum);
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

		// Token: 0x06001BA0 RID: 7072 RVA: 0x000F9F54 File Offset: 0x000F8154
		private bool verify()
		{
			bool flag = (Conversion.Val(this.txtCostperUnit.Text) <= 0.0) | (Conversion.Val(this.lblNumUnits.Text) <= 0.0);
			return !flag;
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000F9FB4 File Offset: 0x000F81B4
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

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000FA02C File Offset: 0x000F822C
		private void UpdateProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Updateproduct";
			sqlCommand.Parameters.AddWithValue("productid", Conversion.Val(this.txtSearchProdtID.Text));
			sqlCommand.Parameters.AddWithValue("unitsperpack", Conversion.Val(this.txtNumUnitsinPack.Text));
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

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000FA1D0 File Offset: 0x000F83D0
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

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000FA2A8 File Offset: 0x000F84A8
		private void InsertStock(int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock2";
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

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000FA49C File Offset: 0x000F869C
		private void AppendGrid()
		{
			string[] array = new string[]
			{
				this.lblDesc.Text,
				this.txtNumUnitsinPack.Text,
				this.txtPacks.Text,
				this.txtReorder.Text,
				this.lblNumUnits.Text,
				this.txtCostperUnit.Text,
				this.txtSellingPrice.Text,
				this.lblCalcGross.Text
			};
			this.DataGridView1.Rows.Add(array);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000FA534 File Offset: 0x000F8734
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

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000FA634 File Offset: 0x000F8834
		private void ClearForm()
		{
			this.txtref.Text = "";
			this.txtSellingPrice.Text = Conversions.ToString(0);
			this.txtPacks.Text = Conversions.ToString(0);
			this.txtCostperUnit.Text = Conversions.ToString(0);
			this.lblCalcGross.Text = Conversions.ToString(0);
			this.txtCostOnePack.Text = Conversions.ToString(0);
			this.txtNumUnitsinPack.Text = Conversions.ToString(0);
			this.txtReorder.Text = Conversions.ToString(0);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000FA6D4 File Offset: 0x000F88D4
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

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000FA724 File Offset: 0x000F8924
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

		// Token: 0x06001BAA RID: 7082 RVA: 0x000FA784 File Offset: 0x000F8984
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

		// Token: 0x06001BAB RID: 7083 RVA: 0x000FA858 File Offset: 0x000F8A58
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.SearchByDesc(this.txtsearch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x000FA8C4 File Offset: 0x000F8AC4
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000FA9A0 File Offset: 0x000F8BA0
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts";
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
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000FAAEC File Offset: 0x000F8CEC
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

		// Token: 0x06001BAF RID: 7087 RVA: 0x000FAB4C File Offset: 0x000F8D4C
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProdtID.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000FAC10 File Offset: 0x000F8E10
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtPacks.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x04000D47 RID: 3399
		private string _cnn;

		// Token: 0x04000D48 RID: 3400
		private PublicFunctions publicfunction;

		// Token: 0x04000D49 RID: 3401
		public int newID;

		// Token: 0x04000D4A RID: 3402
		private bool first;

		// Token: 0x04000D4B RID: 3403
		private int invnum;
	}
}
