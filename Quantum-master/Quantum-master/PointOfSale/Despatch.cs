using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200003D RID: 61
	[DesignerGenerated]
	public partial class Despatch : UserControl
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x00081570 File Offset: 0x0007F770
		public Despatch()
		{
			base.Load += this.Despatch_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.isunedingstock = false;
			this.currentUOM = "";
			this.currentWeight = 0m;
			this.RowID = 0;
			this.og_customername = "";
			this.og_address = "";
			this.og_contactname = "";
			this.og_mobile = "";
			this.og_email = "";
			this.og_tel = "";
			this.og_invdetail1 = "";
			this.og_invdetail2 = "";
			this.og_vatnumber = "";
			this.og_bpnumber = "";
			this.currCustomerGroup = "";
			this.currentCustomerEntryNo = 0;
			this.currentCustomerLimit = 0m;
			this.datCustomers = new DataTable();
			this.TextToPrint = "";
			this.LINE = "_________________________________________________________________________";
			this.InitializeComponent();
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00084A80 File Offset: 0x00082C80
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00084A8A File Offset: 0x00082C8A
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00084A93 File Offset: 0x00082C93
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00084A9D File Offset: 0x00082C9D
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00084AA6 File Offset: 0x00082CA6
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00084AB0 File Offset: 0x00082CB0
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DGVSearch_CellContentClick);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler2;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler2;
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00084B0E File Offset: 0x00082D0E
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00084B18 File Offset: 0x00082D18
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00084B21 File Offset: 0x00082D21
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00084B2B File Offset: 0x00082D2B
		internal virtual Panel Panel7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00084B34 File Offset: 0x00082D34
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00084B3E File Offset: 0x00082D3E
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00084B47 File Offset: 0x00082D47
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00084B54 File Offset: 0x00082D54
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
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00084B97 File Offset: 0x00082D97
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00084BA1 File Offset: 0x00082DA1
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00084BAA File Offset: 0x00082DAA
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00084BB4 File Offset: 0x00082DB4
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00084BBD File Offset: 0x00082DBD
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00084BC8 File Offset: 0x00082DC8
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00084C0B File Offset: 0x00082E0B
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00084C15 File Offset: 0x00082E15
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00084C1E File Offset: 0x00082E1E
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00084C28 File Offset: 0x00082E28
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

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00084C6B File Offset: 0x00082E6B
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x00084C75 File Offset: 0x00082E75
		internal virtual GroupBox grpCustomers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00084C7E File Offset: 0x00082E7E
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x00084C88 File Offset: 0x00082E88
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00084C91 File Offset: 0x00082E91
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x00084C9B File Offset: 0x00082E9B
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00084CA4 File Offset: 0x00082EA4
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x00084CAE File Offset: 0x00082EAE
		internal virtual Button Button4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00084CB7 File Offset: 0x00082EB7
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00084CC1 File Offset: 0x00082EC1
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00084CCA File Offset: 0x00082ECA
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x00084CD4 File Offset: 0x00082ED4
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00084CDD File Offset: 0x00082EDD
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x00084CE7 File Offset: 0x00082EE7
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00084CF0 File Offset: 0x00082EF0
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00084CFC File Offset: 0x00082EFC
		internal virtual Button Button17
		{
			[CompilerGenerated]
			get
			{
				return this._Button17;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button17_Click);
				Button button = this._Button17;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button17 = value;
				button = this._Button17;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00084D3F File Offset: 0x00082F3F
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00084D49 File Offset: 0x00082F49
		internal virtual TextBox txtbpnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00084D52 File Offset: 0x00082F52
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00084D5C File Offset: 0x00082F5C
		internal virtual Label Label37
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00084D65 File Offset: 0x00082F65
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00084D6F File Offset: 0x00082F6F
		internal virtual TextBox txtvatnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00084D78 File Offset: 0x00082F78
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00084D82 File Offset: 0x00082F82
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00084D8B File Offset: 0x00082F8B
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00084D98 File Offset: 0x00082F98
		internal virtual Button Button12
		{
			[CompilerGenerated]
			get
			{
				return this._Button12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button12_Click);
				Button button = this._Button12;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button12 = value;
				button = this._Button12;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00084DDB File Offset: 0x00082FDB
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00084DE8 File Offset: 0x00082FE8
		internal virtual Button Button11
		{
			[CompilerGenerated]
			get
			{
				return this._Button11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button11_Click);
				Button button = this._Button11;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button11 = value;
				button = this._Button11;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00084E2B File Offset: 0x0008302B
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00084E35 File Offset: 0x00083035
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00084E3E File Offset: 0x0008303E
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00084E48 File Offset: 0x00083048
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00084E51 File Offset: 0x00083051
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00084E5B File Offset: 0x0008305B
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00084E64 File Offset: 0x00083064
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00084E6E File Offset: 0x0008306E
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00084E77 File Offset: 0x00083077
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00084E81 File Offset: 0x00083081
		internal virtual TextBox txtcustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00084E8A File Offset: 0x0008308A
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x00084E94 File Offset: 0x00083094
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00084E9D File Offset: 0x0008309D
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x00084EA8 File Offset: 0x000830A8
		internal virtual ComboBox cboCustomers
		{
			[CompilerGenerated]
			get
			{
				return this._cboCustomers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCustomers_SelectedIndexChanged);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00084EEB File Offset: 0x000830EB
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00084EF5 File Offset: 0x000830F5
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00084EFE File Offset: 0x000830FE
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00084F08 File Offset: 0x00083108
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00084F11 File Offset: 0x00083111
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00084F1B File Offset: 0x0008311B
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00084F24 File Offset: 0x00083124
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00084F2E File Offset: 0x0008312E
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00084F37 File Offset: 0x00083137
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00084F41 File Offset: 0x00083141
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00084F4A File Offset: 0x0008314A
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00084F54 File Offset: 0x00083154
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00084F5D File Offset: 0x0008315D
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00084F68 File Offset: 0x00083168
		internal virtual TextBox txtQty
		{
			[CompilerGenerated]
			get
			{
				return this._txtQty;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQty_KeyPress);
				TextBox textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQty = value;
				textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00084FAB File Offset: 0x000831AB
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00084FB5 File Offset: 0x000831B5
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00084FBE File Offset: 0x000831BE
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00084FC8 File Offset: 0x000831C8
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0008500B File Offset: 0x0008320B
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x00085015 File Offset: 0x00083215
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0008501E File Offset: 0x0008321E
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00085028 File Offset: 0x00083228
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00085031 File Offset: 0x00083231
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x0008503C File Offset: 0x0008323C
		internal virtual DataGridView DataGridView1
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridView1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewRowEventHandler dataGridViewRowEventHandler = new DataGridViewRowEventHandler(this.DataGridView1_UserDeletedRow);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow -= dataGridViewRowEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow += dataGridViewRowEventHandler;
				}
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0008507F File Offset: 0x0008327F
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x0008508C File Offset: 0x0008328C
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x000850CF File Offset: 0x000832CF
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x000850D9 File Offset: 0x000832D9
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x000850E2 File Offset: 0x000832E2
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x000850EC File Offset: 0x000832EC
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x000850F5 File Offset: 0x000832F5
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x000850FF File Offset: 0x000832FF
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00085108 File Offset: 0x00083308
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00085114 File Offset: 0x00083314
		internal virtual TextBox txtContactName
		{
			[CompilerGenerated]
			get
			{
				return this._txtContactName;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtContactName_TextChanged);
				TextBox textBox = this._txtContactName;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtContactName = value;
				textBox = this._txtContactName;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00085157 File Offset: 0x00083357
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00085161 File Offset: 0x00083361
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0008516A File Offset: 0x0008336A
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x00085174 File Offset: 0x00083374
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
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode_TextChanged);
				TextBox textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode = value;
				textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x000851B7 File Offset: 0x000833B7
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x000851C1 File Offset: 0x000833C1
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x000851CA File Offset: 0x000833CA
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x000851D4 File Offset: 0x000833D4
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x000851DD File Offset: 0x000833DD
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x000851E7 File Offset: 0x000833E7
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x000851F0 File Offset: 0x000833F0
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x000851FA File Offset: 0x000833FA
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00085203 File Offset: 0x00083403
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00085210 File Offset: 0x00083410
		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label5_Click);
				Label label = this._Label5;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00085253 File Offset: 0x00083453
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00085260 File Offset: 0x00083460
		internal virtual TextBox txtQtyInPack
		{
			[CompilerGenerated]
			get
			{
				return this._txtQtyInPack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQtyInPack_KeyPress);
				TextBox textBox = this._txtQtyInPack;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQtyInPack = value;
				textBox = this._txtQtyInPack;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x000852A3 File Offset: 0x000834A3
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x000852AD File Offset: 0x000834AD
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x000852B6 File Offset: 0x000834B6
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x000852C0 File Offset: 0x000834C0
		internal virtual TextBox txtNumPacks
		{
			[CompilerGenerated]
			get
			{
				return this._txtNumPacks;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNumPacks_KeyPress);
				TextBox textBox = this._txtNumPacks;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNumPacks = value;
				textBox = this._txtNumPacks;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00085303 File Offset: 0x00083503
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x0008530D File Offset: 0x0008350D
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00085316 File Offset: 0x00083516
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00085320 File Offset: 0x00083520
		internal virtual PrintDocument PrintDocument1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00085329 File Offset: 0x00083529
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00085333 File Offset: 0x00083533
		internal virtual CheckBox chkShowSellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0008533C File Offset: 0x0008353C
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00085346 File Offset: 0x00083546
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0008534F File Offset: 0x0008354F
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00085359 File Offset: 0x00083559
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00085362 File Offset: 0x00083562
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x0008536C File Offset: 0x0008356C
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00085375 File Offset: 0x00083575
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x0008537F File Offset: 0x0008357F
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00085388 File Offset: 0x00083588
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x00085392 File Offset: 0x00083592
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0008539B File Offset: 0x0008359B
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x000853A5 File Offset: 0x000835A5
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x000853AE File Offset: 0x000835AE
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x000853B8 File Offset: 0x000835B8
		internal virtual DataGridViewTextBoxColumn RowNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x000853C1 File Offset: 0x000835C1
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x000853CB File Offset: 0x000835CB
		internal virtual DataGridViewTextBoxColumn NumOfPacks
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x000853D4 File Offset: 0x000835D4
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x000853DE File Offset: 0x000835DE
		internal virtual DataGridViewTextBoxColumn QtyInPack
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x000853E7 File Offset: 0x000835E7
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x000853F1 File Offset: 0x000835F1
		internal virtual DataGridViewTextBoxColumn ProductWeight
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000853FA File Offset: 0x000835FA
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x00085404 File Offset: 0x00083604
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0008540D File Offset: 0x0008360D
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x00085417 File Offset: 0x00083617
		internal virtual Label lblweight
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00085420 File Offset: 0x00083620
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				try
				{
					this.lblerror.Text = "";
					this.txtStockAvail.Text = Conversions.ToString(0);
					this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
					this.txtDesc.Text = "No product matches your search.";
					this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)), 0, 0m, 0m);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bar code error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00085514 File Offset: 0x00083714
		private void SearchProductCode(string prodtcode, int use_price_from_scale = 0, decimal price_from_scale = 0m, decimal qty_from_scale = 0m)
		{
			bool flag = (Operators.CompareString(prodtcode, "0", false) == 0) | (Operators.CompareString(prodtcode, "", false) == 0);
			if (flag)
			{
				this.txtSearchProductCode.Text = "";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByCode2";
				sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					int num2 = Conversions.ToInteger(dataRow["catid"]);
					bool flag3 = !this.pf.IsCATIDForUser(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, num2, this._cnn);
					if (flag3)
					{
						MessageBox.Show("Product is restricted for this user.");
					}
					else
					{
						this.txtDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"]))), ")"));
						this.isunedingstock = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
						this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
						this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
						this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]), RuntimeHelpers.GetObjectValue(dataRow["HSCode"])));
						this.currentIsWeighed = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isweighed"])), false, RuntimeHelpers.GetObjectValue(dataRow["isweighed"])));
						bool flag4 = this.currentIsWeighed;
						if (flag4)
						{
							this.txtQty.ReadOnly = true;
						}
						else
						{
							this.txtQty.ReadOnly = false;
						}
						bool flag5 = this.currentExpires;
						if (flag5)
						{
							this.txtQty.Visible = false;
							this.Label4.Visible = false;
							this.Button1.Text = "SELECT";
						}
						else
						{
							this.txtQty.Visible = true;
							this.Label4.Visible = true;
							this.Button1.Text = "Enter";
							this.txtQty.Enabled = true;
						}
						this.currentUOM = dataRow["UOM"].ToString();
						this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
						bool flag6 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
						if (flag6)
						{
							this.txtsearch.Focus();
						}
						else
						{
							this.txtBarCode.Text = "";
							this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
							this.txtBarCode.Focus();
						}
					}
				}
				else
				{
					this.txtSearchProductCode.Text = "";
					bool flag7 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag7)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Text = "";
						this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
						this.txtBarCode.Focus();
					}
				}
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000859A8 File Offset: 0x00083BA8
		private void Button3_Click(object sender, EventArgs e)
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

		// Token: 0x06000DEA RID: 3562 RVA: 0x00085A08 File Offset: 0x00083C08
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
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

		// Token: 0x06000DEB RID: 3563 RVA: 0x00085C18 File Offset: 0x00083E18
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00085CDC File Offset: 0x00083EDC
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
				this.txtDesc.Text = "No product matches your search.";
				bool flag = Operators.CompareString(this.txtSearchProductCode.Text, " ", false) != 0;
				if (flag)
				{
					this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00085DD0 File Offset: 0x00083FD0
		private void SearchBarCode(int prodtID)
		{
			bool flag = prodtID == 0;
			if (flag)
			{
				this.txtSearchProductCode.Text = "";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByID2";
				sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.txtDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"]))), ")"));
					this.isunedingstock = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
					this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]), RuntimeHelpers.GetObjectValue(dataRow["HSCode"])));
					this.currentIsWeighed = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isweighed"])), false, RuntimeHelpers.GetObjectValue(dataRow["isweighed"])));
					bool flag3 = this.currentIsWeighed;
					if (flag3)
					{
						this.txtQty.ReadOnly = true;
					}
					else
					{
						this.txtQty.ReadOnly = false;
					}
					this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
					bool flag4 = this.currentExpires;
					if (flag4)
					{
						this.txtQty.Visible = false;
						this.Label4.Visible = false;
						this.Button1.Text = "SELECT";
					}
					else
					{
						this.txtQty.Visible = true;
						this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
						this.Label4.Visible = true;
						this.Button1.Text = "Enter";
						this.txtQty.Enabled = true;
					}
					this.currentUOM = dataRow["UOM"].ToString();
					this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
					this.currentWeight = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["productweight"])), 0, RuntimeHelpers.GetObjectValue(dataRow["productweight"])));
				}
				else
				{
					this.txtSearchProductCode.Text = "";
				}
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000861C4 File Offset: 0x000843C4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.IsWarehouse == 1) | this.currentExpires;
				if (flag)
				{
					bool flag2 = this.CurrentID == 0;
					if (flag2)
					{
						MessageBox.Show("Please select a product first");
					}
					else
					{
						DataTable dataTable = new DataTable();
						MyProject.Forms.Form1.SelectedBatch = dataTable;
						BatchSelect batchSelect = new BatchSelect();
						batchSelect.productid = this.CurrentID;
						batchSelect.coid = MyProject.Forms.Form1.coid;
						batchSelect.branch = MyProject.Forms.Form1.branch;
						batchSelect.ShowDialog(this);
						batchSelect.Dispose();
						DataTable selectedBatch = MyProject.Forms.Form1.SelectedBatch;
						bool flag3 = MyProject.Forms.Form1.SelectedBatch.Rows.Count > 0;
						if (flag3)
						{
							this.EnterItem();
						}
					}
				}
				else
				{
					bool flag4 = (Operators.CompareString(this.txtQty.Text, "", false) != 0) | (Conversion.Val(this.txtQty.Text) != 0.0);
					if (flag4)
					{
						bool flag5 = Conversion.Val(this.txtNumPacks.Text) != 0.0;
						if (flag5)
						{
							bool flag6 = Conversion.Val(this.txtNumPacks.Text) * Conversion.Val(this.txtQtyInPack.Text) != Conversion.Val(this.txtQty.Text);
							if (flag6)
							{
								MessageBox.Show("Quantity is not matching number of packs and quantity in packs. Please correct.");
								return;
							}
						}
						this.EnterItem();
					}
					else
					{
						MessageBox.Show("Please enter the qty first.");
						this.txtQty.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending data. Details: " + ex.Message);
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000863D0 File Offset: 0x000845D0
		private void EnterItem()
		{
			bool flag = true;
			bool flag2 = this.Verify();
			if (flag2)
			{
				bool flag3 = flag;
				if (flag3)
				{
					bool flag4 = MyProject.Forms.Form1.OtherProductDetail == 1;
					if (flag4)
					{
						OtherProductDetail otherProductDetail = new OtherProductDetail();
						otherProductDetail.ShowDialog(this);
						otherProductDetail.Dispose();
					}
					string otherDetail = MyProject.Forms.Form1.OtherDetail;
					bool flag5 = MyProject.Forms.Form1.UseConnectedScale != 0;
					if (!flag5)
					{
						this.AppendGrid();
						this.CalcTotalSale();
						this.EnterItemClear();
					}
				}
				else
				{
					MessageBox.Show("Coupon error. Check message under coupon, fix and retry.");
				}
			}
			else
			{
				MessageBox.Show("Please make sure that sales, quanity and stock available details are correct.");
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0008648C File Offset: 0x0008468C
		private void AppendGrid()
		{
			bool flag = this.CurrentID == 0;
			checked
			{
				if (!flag)
				{
					decimal num = 0m;
					bool flag2 = !this.currentExpires;
					if (flag2)
					{
						bool flag3 = Conversion.Val(this.txtQty.Text) == 0.0;
						if (flag3)
						{
							MessageBox.Show("Please enter a valid quantity.");
							return;
						}
						string[] array = new string[]
						{
							Conversions.ToString(this.CurrentID),
							this.CurrentCode,
							this.txtDesc.Text,
							this.txtQty.Text,
							"",
							Conversions.ToString(0),
							Conversions.ToString(this.RowID),
							this.txtNumPacks.Text,
							this.txtQtyInPack.Text,
							Conversions.ToString(this.currentWeight)
						};
						this.RowID++;
						this.DataGridView1.Rows.Add(array);
					}
					else
					{
						DataTable selectedBatch = MyProject.Forms.Form1.SelectedBatch;
						bool flag4 = selectedBatch.Rows.Count > 0;
						if (flag4)
						{
							try
							{
								foreach (object obj in selectedBatch.Rows)
								{
									DataRow dataRow = (DataRow)obj;
									int num2;
									try
									{
										num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"]));
									}
									catch (Exception ex)
									{
										num2 = 0;
									}
									bool flag5 = num2 != 0;
									if (flag5)
									{
										this.txtQty.Text = num2.ToString();
										string[] array2 = new string[]
										{
											Conversions.ToString(this.CurrentID),
											this.CurrentCode,
											this.txtDesc.Text,
											num2.ToString(),
											dataRow["BatchNumber"].ToString(),
											dataRow["ExpiryDate"].ToString(),
											Conversions.ToString(this.RowID),
											this.txtNumPacks.Text,
											this.txtQtyInPack.Text,
											Conversions.ToString(this.currentWeight)
										};
										this.RowID++;
										this.DataGridView1.Rows.Add(array2);
										this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
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
						else
						{
							MessageBox.Show("No product selected.");
						}
					}
					this.txtQty.ReadOnly = false;
					this.CurrentID = 0;
					this.txtStockAvail.Text = "0";
					this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
					MyProject.Forms.Form1.DiscountApproved = 0;
					MyProject.Forms.Form1.approved = false;
					this.txtQtyInPack.Text = Conversions.ToString(0);
					this.txtNumPacks.Text = Conversions.ToString(0);
					this.currentWeight = 0m;
				}
			}
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0008683C File Offset: 0x00084A3C
		private void CalcTotalSale()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			decimal num3 = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num = decimal.Add(num, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
					num3 = decimal.Add(num3, decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productweight"].Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value))));
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
			num = Math.Round(num, 2, MidpointRounding.AwayFromZero);
			this.txtTotal.Text = num.ToString();
			this.lblweight.Text = num3.ToString();
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00086960 File Offset: 0x00084B60
		private void EnterItemClear()
		{
			this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.txtsearch.Text = "";
			this.txtBarCode.Text = "";
			this.CurrentID = 0;
			this.txtDesc.Text = "";
			bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000869FC File Offset: 0x00084BFC
		public bool Verify()
		{
			bool flag = true;
			bool flag2 = (MyProject.Forms.Form1.NegativeStock == 1) | this.isunedingstock;
			bool flag3;
			if (flag2)
			{
				flag = true;
				flag3 = flag;
			}
			else
			{
				bool flag4 = this.isunedingstock;
				if (flag4)
				{
					flag = true;
				}
				else
				{
					decimal num = decimal.Subtract(Convert.ToDecimal(this.txtStockAvail.Text), Convert.ToDecimal(this.txtQty.Text));
					bool flag5 = decimal.Compare(num, 0m) < 0;
					if (flag5)
					{
						return false;
					}
				}
				flag3 = flag;
			}
			return flag3;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00086A8C File Offset: 0x00084C8C
		private void Button17_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtcustomer.Text, "Cash", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please Select an existing customer first or enter the new customer trade name.");
				}
				else
				{
					this.RunSaveCustomer();
					bool flag2 = new ExtraCustomerDetails
					{
						txtcustomername = 
						{
							Text = this.txtcustomer.Text
						}
					}.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.FetchCustomer(this.txtcustomer.Text);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00086B44 File Offset: 0x00084D44
		private void FetchCustomer(string customername)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCustomerDetails";
				sqlCommand.Parameters.AddWithValue("Customername", customername);
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
					this.txtTel.Text = Conversions.ToString(dataRow["Tel"]);
					this.txtbpnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
					this.txtvatnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])));
					this.og_customername = this.txtcustomer.Text;
					this.og_address = this.txtAddress.Text;
					this.og_contactname = this.txtContactName.Text;
					this.og_mobile = this.txtMobile.Text;
					this.og_email = this.txtEmail.Text;
					this.og_tel = this.txtTel.Text;
					this.og_vatnumber = this.txtvatnumber.Text;
					this.og_bpnumber = this.txtbpnumber.Text;
					this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					this.currCustomerGroup = Conversions.ToString(dataRow["CategoryName"]);
				}
				else
				{
					this.currentCustomerEntryNo = 0;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00086E28 File Offset: 0x00085028
		private void RunSaveCustomer()
		{
			this.SaveCustomerDetails();
			this.og_customername = this.txtcustomer.Text;
			this.og_address = this.txtAddress.Text;
			this.og_contactname = this.txtContactName.Text;
			this.og_mobile = this.txtMobile.Text;
			this.og_email = this.txtEmail.Text;
			this.og_tel = this.txtTel.Text;
			this.og_vatnumber = this.txtvatnumber.Text;
			this.og_bpnumber = this.txtbpnumber.Text;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00086EC8 File Offset: 0x000850C8
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtcustomer.Text = "Cash";
				this.txtAddress.Text = "";
				this.txtContactName.Text = "";
				this.txtMobile.Text = "";
				this.txtEmail.Text = "";
				this.txtTel.Text = "";
				this.txtvatnumber.Text = "";
				this.txtbpnumber.Text = "";
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_contactname = this.txtContactName.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_tel = this.txtTel.Text;
				this.og_bpnumber = this.txtbpnumber.Text;
				this.og_vatnumber = this.txtvatnumber.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error clearing customer details: " + ex.Message);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0008702C File Offset: 0x0008522C
		private bool CheckIfCustomerDetailsChanged()
		{
			bool flag = false;
			bool flag2 = Operators.CompareString(Strings.Trim(this.txtcustomer.Text), Strings.Trim(this.og_customername), false) != 0;
			bool flag3;
			if (flag2)
			{
				flag = true;
				flag3 = flag;
			}
			else
			{
				bool flag4 = Operators.CompareString(Strings.Trim(this.txtAddress.Text), Strings.Trim(this.og_address), false) != 0;
				if (flag4)
				{
					flag = true;
					flag3 = flag;
				}
				else
				{
					bool flag5 = Operators.CompareString(Strings.Trim(this.txtContactName.Text), Strings.Trim(this.og_contactname), false) != 0;
					if (flag5)
					{
						flag = true;
						flag3 = flag;
					}
					else
					{
						bool flag6 = Operators.CompareString(Strings.Trim(this.txtMobile.Text), Strings.Trim(this.og_mobile), false) != 0;
						if (flag6)
						{
							flag = true;
							flag3 = flag;
						}
						else
						{
							bool flag7 = Operators.CompareString(Strings.Trim(this.txtEmail.Text), Strings.Trim(this.og_email), false) != 0;
							if (flag7)
							{
								flag = true;
								flag3 = flag;
							}
							else
							{
								bool flag8 = Operators.CompareString(Strings.Trim(this.txtbpnumber.Text), Strings.Trim(this.og_bpnumber), false) != 0;
								if (flag8)
								{
									flag = true;
									flag3 = flag;
								}
								else
								{
									bool flag9 = Operators.CompareString(Strings.Trim(this.txtvatnumber.Text), Strings.Trim(this.og_vatnumber), false) != 0;
									if (flag9)
									{
										flag = true;
										flag3 = flag;
									}
									else
									{
										flag3 = flag;
									}
								}
							}
						}
					}
				}
			}
			return flag3;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000871A0 File Offset: 0x000853A0
		private void SaveCustomerDetails()
		{
			try
			{
				this.UpdateCustomer();
				this.LoadCustomers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer details. SALE COMPLETED. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000871F8 File Offset: 0x000853F8
		private void UpdateCustomer()
		{
			bool flag = this.IsCustomerNew(this.txtcustomer.Text);
			bool flag2 = flag;
			if (flag2)
			{
				this.currentCustomerEntryNo = 0;
			}
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateCustomerDetails2";
			sqlCommand.Parameters.AddWithValue("CustomerName", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobile.Text);
			sqlCommand.Parameters.AddWithValue("ContactName", this.txtContactName.Text);
			sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("invoicedetails1", "");
			sqlCommand.Parameters.AddWithValue("invoicedetails2", "");
			sqlCommand.Parameters.AddWithValue("tel", this.txtTel.Text);
			sqlCommand.Parameters.AddWithValue("vatnumber", this.txtvatnumber.Text);
			sqlCommand.Parameters.AddWithValue("bpnumber", this.txtbpnumber.Text);
			sqlCommand.Parameters.AddWithValue("entryno", this.currentCustomerEntryNo);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
			bool flag3 = this.currentCustomerEntryNo == 0;
			if (flag3)
			{
				this.GetCustomerEntryNo(this.txtcustomer.Text);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00087418 File Offset: 0x00085618
		private int GetCustomerEntryNo(string customername)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select entryno from customerdetails where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"' and customername='",
				this.txtcustomer.Text,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["entryno"]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000874F8 File Offset: 0x000856F8
		private void LoadCustomers()
		{
			this.datCustomers.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("showactiveonly", 1);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(this.datCustomers);
			this.cboCustomers.DataSource = this.datCustomers;
			this.cboCustomers.DisplayMember = "CustomerName";
			this.cboCustomers.ValueMember = "CustomerName";
			this.cboCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cboCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cboCustomers.SelectedIndex = -1;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00087608 File Offset: 0x00085808
		private bool IsCustomerNew(string CustomerName)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CountCustomer";
			sqlCommand.Parameters.AddWithValue("CustomerName", CustomerName);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			bool flag3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Operators.ConditionalCompareObjectGreater(dataRow["Customer_Count"], 0, false);
				if (flag2)
				{
					this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					flag3 = false;
				}
				else
				{
					flag3 = true;
				}
			}
			else
			{
				flag3 = true;
			}
			return flag3;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0008770C File Offset: 0x0008590C
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.RunSaveCustomer();
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Customer details saved successfuly.");
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error saving customer details. Detai: " + ex.Message);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00087788 File Offset: 0x00085988
		private void Button2_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to Despatch?", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0;
				if (flag2)
				{
					bool flag3 = this.CheckIfCustomerDetailsChanged();
					if (flag3)
					{
						this.UpdateCustomer();
					}
					string text = DateTime.Today.ToString("HHmm");
					int num = 0;
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					try
					{
						sqlConnection.Open();
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "GetDespatchInvoiceNumber";
						sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						bool flag4 = (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1) | (MyProject.Forms.Form1.DateChange == 1);
						if (flag4)
						{
							sqlCommand.Parameters.AddWithValue("allowbackdated", 1);
						}
						else
						{
							sqlCommand.Parameters.AddWithValue("allowbackdated", 0);
						}
						sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
						sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.ExecuteNonQuery();
						num = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
						bool flag5 = num == 0;
						if (flag5)
						{
							MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
							sqlTransaction.Rollback();
							sqlConnection.Close();
						}
						else
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "InsertNextDespatchInvNumber";
							sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
							sqlCommand.Parameters.AddWithValue("newinvnumber", num);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.ExecuteNonQuery();
							try
							{
								foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									bool flag6 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
									if (!flag6)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "InsertDespatch";
										sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("invoicenum", num);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 0);
										sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
										sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
										sqlCommand.Parameters.AddWithValue("unitcost", 0);
										sqlCommand.Parameters.AddWithValue("salesprice", 0);
										sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("trancode", 10);
										sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
										sqlCommand.Parameters.AddWithValue("TranTime", text);
										sqlCommand.Parameters.AddWithValue("taxamt", 0);
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("shift", "");
										sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
										sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)))));
										sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
										sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", 0);
										sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", 0);
										sqlCommand.Parameters.AddWithValue("discountamount", 0);
										sqlCommand.Parameters.AddWithValue("consultant", "");
										sqlCommand.Parameters.AddWithValue("invdiscount", 0);
										string text2 = "";
										sqlCommand.Parameters.AddWithValue("collection", text2);
										sqlCommand.Parameters.AddWithValue("otherdetail", dataGridViewRow.Cells["NumofPacks"].Value.ToString());
										sqlCommand.Parameters.AddWithValue("discountdesc", "");
										sqlCommand.Parameters.AddWithValue("comments", dataGridViewRow.Cells["QtyInPack"].Value.ToString());
										sqlCommand.Parameters.AddWithValue("paymethref", "");
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("quotationnum", 0);
										sqlCommand.Parameters.AddWithValue("taxexempt", "");
										sqlCommand.Parameters.AddWithValue("taxrate", 0);
										sqlCommand.Parameters.AddWithValue("isdeposit", 0);
										sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
										sqlCommand.Parameters.AddWithValue("altdescription", "");
										sqlCommand.ExecuteNonQuery();
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
							sqlTransaction.Commit();
							sqlConnection.Close();
							DespatchNoteForm despatchNoteForm = new DespatchNoteForm();
							despatchNoteForm.invnum = num;
							despatchNoteForm.revmax_sign = "";
							despatchNoteForm.isEltradeESDfiscal = 0;
							despatchNoteForm.isfiscal = 1;
							despatchNoteForm.branch = MyProject.Forms.Form1.branch;
							bool flag7 = MyProject.Forms.Form1.AllowInvDiscount == 1;
							if (flag7)
							{
								despatchNoteForm.showinvdisc = 1;
							}
							despatchNoteForm.showSellingPrice = Conversions.ToInteger(Interaction.IIf(this.chkShowSellingPrice.Checked, 1, 0));
							despatchNoteForm.ShowDialog(this);
							despatchNoteForm.Dispose();
							this.ClearForm();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error despatching. Details: " + ex.Message);
						try
						{
							SqlTransaction sqlTransaction;
							sqlTransaction.Rollback();
							sqlConnection.Close();
						}
						catch (Exception ex2)
						{
						}
					}
				}
				else
				{
					MessageBox.Show("Please enter the Customer/Company name first.");
					this.txtcustomer.Focus();
				}
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00088174 File Offset: 0x00086374
		private void Despatch_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomers();
				bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag)
				{
					this.txtsearch.Focus();
				}
				else
				{
					this.txtBarCode.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000881F8 File Offset: 0x000863F8
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

		// Token: 0x06000E02 RID: 3586 RVA: 0x00088280 File Offset: 0x00086480
		private void SearchByDescAdvanced(string searchtext)
		{
			bool flag = Operators.CompareString(searchtext, "", false) == 0;
			checked
			{
				if (!flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					string[] array = searchtext.Split(new char[] { ' ' });
					int num = 1;
					DataTable dataTable = new DataTable();
					foreach (string text in array)
					{
						bool flag2 = num == 1;
						if (flag2)
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
					bool flag3 = dataTable.Rows.Count > 0;
					if (flag3)
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
					Cursor.Current = Cursors.Default;
				}
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000883BC File Offset: 0x000865BC
		private object searchDat(DataTable dt, string column, string value)
		{
			Despatch._Closure$__369-0 CS$<>8__locals1 = new Despatch._Closure$__369-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((Despatch._Closure$__.$I369-0 == null) ? (Despatch._Closure$__.$I369-0 = (object row1) => (DataRow)row1) : Despatch._Closure$__.$I369-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06000E04 RID: 3588 RVA: 0x00088498 File Offset: 0x00086698
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00088558 File Offset: 0x00086758
		private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchCustomer(Conversions.ToString(this.cboCustomers.SelectedValue));
			}
			catch (InvalidCastException ex)
			{
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000885A0 File Offset: 0x000867A0
		private void ClearForm()
		{
			this.DataGridView1.Rows.Clear();
			this.txtStockAvail.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.txtSearchProductCode.Text = Conversions.ToString(0);
			this.txtTotal.Text = Conversions.ToString(0);
			this.txtcustomer.Text = "Cash";
			this.txtAddress.Text = "";
			this.txtMobile.Text = "";
			this.txtEmail.Text = "";
			this.txtMobile.Text = "";
			this.txtContactName.Text = "";
			this.txtTel.Text = "";
			this.og_customername = this.txtcustomer.Text;
			this.og_address = this.txtAddress.Text;
			this.og_contactname = this.txtContactName.Text;
			this.og_mobile = this.txtMobile.Text;
			this.og_email = this.txtEmail.Text;
			this.og_tel = this.txtTel.Text;
			this.og_invdetail1 = "";
			this.og_invdetail2 = "";
			this.og_bpnumber = this.txtbpnumber.Text;
			this.og_vatnumber = this.txtvatnumber.Text;
			this.txtBarCode.Text = "";
			this.Button2.TabStop = false;
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
			this.isunedingstock = false;
			this.RowID = 0;
			bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
			this.currentCustomerEntryNo = 0;
			this.currentCustomerLimit = 0m;
			this.cboCustomers.Text = "";
			MyProject.Forms.Form1.discountApprovedIsPerc = false;
			MyProject.Forms.Form1.DiscountApprovedAmt = 0m;
			MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
			MyProject.Forms.Form1.Approvedby = "";
			this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
			MyProject.Forms.Form1.DiscountApproved = 0;
			try
			{
			}
			catch (Exception ex)
			{
				bool flag2 = MyProject.Forms.Form1.RevmaxTest == 1;
				if (flag2)
				{
					MessageBox.Show("Error in clear form handled.");
				}
			}
			MyProject.Forms.Form1.pendinginvoice_entryno = 0;
			MyProject.Forms.Form1.pendinginvoice_ref = 0;
			DataTable dataTable = new DataTable();
			MyProject.Forms.Form1.datSerialsSelect4Sales = dataTable;
			this.txtNumPacks.Text = "0";
			this.txtQtyInPack.Text = "0";
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtContactName_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00088938 File Offset: 0x00086B38
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNumPacks_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtQtyInPack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00002A30 File Offset: 0x00000C30
		private void DGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00088984 File Offset: 0x00086B84
		private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				this.CalcTotalSale();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error after row deleted. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000689 RID: 1673
		private string _cnn;

		// Token: 0x0400068A RID: 1674
		private PublicFunctions pf;

		// Token: 0x0400068B RID: 1675
		private bool isunedingstock;

		// Token: 0x0400068C RID: 1676
		private int CurrentID;

		// Token: 0x0400068D RID: 1677
		private string CurrentCode;

		// Token: 0x0400068E RID: 1678
		private string CurrentHSCode;

		// Token: 0x0400068F RID: 1679
		private bool currentIsWeighed;

		// Token: 0x04000690 RID: 1680
		private string currentUOM;

		// Token: 0x04000691 RID: 1681
		private decimal currentWeight;

		// Token: 0x04000692 RID: 1682
		private bool currentExpires;

		// Token: 0x04000693 RID: 1683
		private int RowID;

		// Token: 0x04000694 RID: 1684
		private string og_customername;

		// Token: 0x04000695 RID: 1685
		private string og_address;

		// Token: 0x04000696 RID: 1686
		private string og_contactname;

		// Token: 0x04000697 RID: 1687
		private string og_mobile;

		// Token: 0x04000698 RID: 1688
		private string og_email;

		// Token: 0x04000699 RID: 1689
		private string og_tel;

		// Token: 0x0400069A RID: 1690
		private string og_invdetail1;

		// Token: 0x0400069B RID: 1691
		private string og_invdetail2;

		// Token: 0x0400069C RID: 1692
		private string og_vatnumber;

		// Token: 0x0400069D RID: 1693
		private string og_bpnumber;

		// Token: 0x0400069E RID: 1694
		private string currCustomerGroup;

		// Token: 0x0400069F RID: 1695
		private int currentCustomerEntryNo;

		// Token: 0x040006A0 RID: 1696
		private decimal currentCustomerLimit;

		// Token: 0x040006A1 RID: 1697
		private DataTable datCustomers;

		// Token: 0x040006A2 RID: 1698
		private string TextToPrint;

		// Token: 0x040006A3 RID: 1699
		private StringReader stringToRead;

		// Token: 0x040006A4 RID: 1700
		private string coname;

		// Token: 0x040006A5 RID: 1701
		private string coadd;

		// Token: 0x040006A6 RID: 1702
		private string coadd2;

		// Token: 0x040006A7 RID: 1703
		private string cotel;

		// Token: 0x040006A8 RID: 1704
		private string coemail;

		// Token: 0x040006A9 RID: 1705
		private string cobpnum;

		// Token: 0x040006AA RID: 1706
		private string footnote;

		// Token: 0x040006AB RID: 1707
		private string cotel2;

		// Token: 0x040006AC RID: 1708
		private string cotel3;

		// Token: 0x040006AD RID: 1709
		private string LINE;
	}
}
