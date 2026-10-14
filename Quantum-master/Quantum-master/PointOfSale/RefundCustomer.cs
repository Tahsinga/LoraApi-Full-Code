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
	// Token: 0x02000180 RID: 384
	[DesignerGenerated]
	public partial class RefundCustomer : Form
	{
		// Token: 0x0600385E RID: 14430 RVA: 0x001EA940 File Offset: 0x001E8B40
		public RefundCustomer()
		{
			base.Load += this.RefundCustomer_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.datCustomers = new DataTable();
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.TextToPrint = "";
			this.mono_rate = 0m;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x001EE681 File Offset: 0x001EC881
		// (set) Token: 0x06003862 RID: 14434 RVA: 0x001EE68C File Offset: 0x001EC88C
		internal virtual GroupBox GroupBox1
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox1_Enter);
				GroupBox groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox1 = value;
				groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x001EE6CF File Offset: 0x001EC8CF
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x001EE6D9 File Offset: 0x001EC8D9
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x001EE6E2 File Offset: 0x001EC8E2
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x001EE6EC File Offset: 0x001EC8EC
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

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x001EE74A File Offset: 0x001EC94A
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x001EE754 File Offset: 0x001EC954
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x001EE75D File Offset: 0x001EC95D
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x001EE768 File Offset: 0x001EC968
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x001EE7AB File Offset: 0x001EC9AB
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x001EE7B5 File Offset: 0x001EC9B5
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x001EE7BE File Offset: 0x001EC9BE
		// (set) Token: 0x0600386E RID: 14446 RVA: 0x001EE7C8 File Offset: 0x001EC9C8
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
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtsearch_KeyPress);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x0600386F RID: 14447 RVA: 0x001EE826 File Offset: 0x001ECA26
		// (set) Token: 0x06003870 RID: 14448 RVA: 0x001EE830 File Offset: 0x001ECA30
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06003871 RID: 14449 RVA: 0x001EE839 File Offset: 0x001ECA39
		// (set) Token: 0x06003872 RID: 14450 RVA: 0x001EE843 File Offset: 0x001ECA43
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x001EE84C File Offset: 0x001ECA4C
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x001EE856 File Offset: 0x001ECA56
		internal virtual TextBox txtOLDprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x001EE85F File Offset: 0x001ECA5F
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x001EE869 File Offset: 0x001ECA69
		internal virtual Label lblCouponInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x001EE872 File Offset: 0x001ECA72
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x001EE87C File Offset: 0x001ECA7C
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x001EE885 File Offset: 0x001ECA85
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x001EE88F File Offset: 0x001ECA8F
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x001EE898 File Offset: 0x001ECA98
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x001EE8A4 File Offset: 0x001ECAA4
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

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x001EE8E7 File Offset: 0x001ECAE7
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x001EE8F1 File Offset: 0x001ECAF1
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x001EE8FA File Offset: 0x001ECAFA
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x001EE904 File Offset: 0x001ECB04
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

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x001EE947 File Offset: 0x001ECB47
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x001EE951 File Offset: 0x001ECB51
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x001EE95A File Offset: 0x001ECB5A
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x001EE964 File Offset: 0x001ECB64
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x001EE96D File Offset: 0x001ECB6D
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x001EE978 File Offset: 0x001ECB78
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

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x001EE9BB File Offset: 0x001ECBBB
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x001EE9C5 File Offset: 0x001ECBC5
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x001EE9CE File Offset: 0x001ECBCE
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x001EE9D8 File Offset: 0x001ECBD8
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x001EE9E1 File Offset: 0x001ECBE1
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x001EE9EB File Offset: 0x001ECBEB
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600388D RID: 14477 RVA: 0x001EE9F4 File Offset: 0x001ECBF4
		// (set) Token: 0x0600388E RID: 14478 RVA: 0x001EE9FE File Offset: 0x001ECBFE
		internal virtual TextBox txtQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x001EEA07 File Offset: 0x001ECC07
		// (set) Token: 0x06003890 RID: 14480 RVA: 0x001EEA11 File Offset: 0x001ECC11
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x001EEA1A File Offset: 0x001ECC1A
		// (set) Token: 0x06003892 RID: 14482 RVA: 0x001EEA24 File Offset: 0x001ECC24
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x001EEA2D File Offset: 0x001ECC2D
		// (set) Token: 0x06003894 RID: 14484 RVA: 0x001EEA37 File Offset: 0x001ECC37
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06003895 RID: 14485 RVA: 0x001EEA40 File Offset: 0x001ECC40
		// (set) Token: 0x06003896 RID: 14486 RVA: 0x001EEA4A File Offset: 0x001ECC4A
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x001EEA53 File Offset: 0x001ECC53
		// (set) Token: 0x06003898 RID: 14488 RVA: 0x001EEA5D File Offset: 0x001ECC5D
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06003899 RID: 14489 RVA: 0x001EEA66 File Offset: 0x001ECC66
		// (set) Token: 0x0600389A RID: 14490 RVA: 0x001EEA70 File Offset: 0x001ECC70
		internal virtual Button Button5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600389B RID: 14491 RVA: 0x001EEA79 File Offset: 0x001ECC79
		// (set) Token: 0x0600389C RID: 14492 RVA: 0x001EEA83 File Offset: 0x001ECC83
		internal virtual Button btnSpecialPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x001EEA8C File Offset: 0x001ECC8C
		// (set) Token: 0x0600389E RID: 14494 RVA: 0x001EEA96 File Offset: 0x001ECC96
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600389F RID: 14495 RVA: 0x001EEA9F File Offset: 0x001ECC9F
		// (set) Token: 0x060038A0 RID: 14496 RVA: 0x001EEAAC File Offset: 0x001ECCAC
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
				DataGridViewRowsRemovedEventHandler dataGridViewRowsRemovedEventHandler = new DataGridViewRowsRemovedEventHandler(this.DataGridView1_RowsRemoved);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.RowsRemoved -= dataGridViewRowsRemovedEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.RowsRemoved += dataGridViewRowsRemovedEventHandler;
				}
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x001EEAEF File Offset: 0x001ECCEF
		// (set) Token: 0x060038A2 RID: 14498 RVA: 0x001EEAF9 File Offset: 0x001ECCF9
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x001EEB02 File Offset: 0x001ECD02
		// (set) Token: 0x060038A4 RID: 14500 RVA: 0x001EEB0C File Offset: 0x001ECD0C
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x001EEB15 File Offset: 0x001ECD15
		// (set) Token: 0x060038A6 RID: 14502 RVA: 0x001EEB1F File Offset: 0x001ECD1F
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x001EEB28 File Offset: 0x001ECD28
		// (set) Token: 0x060038A8 RID: 14504 RVA: 0x001EEB32 File Offset: 0x001ECD32
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x001EEB3B File Offset: 0x001ECD3B
		// (set) Token: 0x060038AA RID: 14506 RVA: 0x001EEB45 File Offset: 0x001ECD45
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x060038AB RID: 14507 RVA: 0x001EEB4E File Offset: 0x001ECD4E
		// (set) Token: 0x060038AC RID: 14508 RVA: 0x001EEB58 File Offset: 0x001ECD58
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x060038AD RID: 14509 RVA: 0x001EEB61 File Offset: 0x001ECD61
		// (set) Token: 0x060038AE RID: 14510 RVA: 0x001EEB6B File Offset: 0x001ECD6B
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x060038AF RID: 14511 RVA: 0x001EEB74 File Offset: 0x001ECD74
		// (set) Token: 0x060038B0 RID: 14512 RVA: 0x001EEB7E File Offset: 0x001ECD7E
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x001EEB87 File Offset: 0x001ECD87
		// (set) Token: 0x060038B2 RID: 14514 RVA: 0x001EEB91 File Offset: 0x001ECD91
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x001EEB9A File Offset: 0x001ECD9A
		// (set) Token: 0x060038B4 RID: 14516 RVA: 0x001EEBA4 File Offset: 0x001ECDA4
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x001EEBAD File Offset: 0x001ECDAD
		// (set) Token: 0x060038B6 RID: 14518 RVA: 0x001EEBB7 File Offset: 0x001ECDB7
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x001EEBC0 File Offset: 0x001ECDC0
		// (set) Token: 0x060038B8 RID: 14520 RVA: 0x001EEBCA File Offset: 0x001ECDCA
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x001EEBD3 File Offset: 0x001ECDD3
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x001EEBDD File Offset: 0x001ECDDD
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x001EEBE6 File Offset: 0x001ECDE6
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x001EEBF0 File Offset: 0x001ECDF0
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x001EEBF9 File Offset: 0x001ECDF9
		// (set) Token: 0x060038BE RID: 14526 RVA: 0x001EEC03 File Offset: 0x001ECE03
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x001EEC0C File Offset: 0x001ECE0C
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x001EEC18 File Offset: 0x001ECE18
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

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x001EEC5B File Offset: 0x001ECE5B
		// (set) Token: 0x060038C2 RID: 14530 RVA: 0x001EEC65 File Offset: 0x001ECE65
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x001EEC6E File Offset: 0x001ECE6E
		// (set) Token: 0x060038C4 RID: 14532 RVA: 0x001EEC78 File Offset: 0x001ECE78
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x001EEC81 File Offset: 0x001ECE81
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x001EEC8B File Offset: 0x001ECE8B
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x001EEC94 File Offset: 0x001ECE94
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x001EEC9E File Offset: 0x001ECE9E
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x001EECA7 File Offset: 0x001ECEA7
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x001EECB1 File Offset: 0x001ECEB1
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x001EECBA File Offset: 0x001ECEBA
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x001EECC4 File Offset: 0x001ECEC4
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x001EECCD File Offset: 0x001ECECD
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x001EECD7 File Offset: 0x001ECED7
		internal virtual Panel Panel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x001EECE0 File Offset: 0x001ECEE0
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x001EECEC File Offset: 0x001ECEEC
		internal virtual Button Button9
		{
			[CompilerGenerated]
			get
			{
				return this._Button9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button9_Click);
				Button button = this._Button9;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button9 = value;
				button = this._Button9;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x001EED2F File Offset: 0x001ECF2F
		// (set) Token: 0x060038D2 RID: 14546 RVA: 0x001EED3C File Offset: 0x001ECF3C
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

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x001EED7F File Offset: 0x001ECF7F
		// (set) Token: 0x060038D4 RID: 14548 RVA: 0x001EED89 File Offset: 0x001ECF89
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x001EED92 File Offset: 0x001ECF92
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x001EED9C File Offset: 0x001ECF9C
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

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x001EEDDF File Offset: 0x001ECFDF
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x001EEDE9 File Offset: 0x001ECFE9
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x001EEDF2 File Offset: 0x001ECFF2
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x001EEDFC File Offset: 0x001ECFFC
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x001EEE05 File Offset: 0x001ED005
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x001EEE0F File Offset: 0x001ED00F
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x001EEE18 File Offset: 0x001ED018
		// (set) Token: 0x060038DE RID: 14558 RVA: 0x001EEE24 File Offset: 0x001ED024
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

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x001EEE67 File Offset: 0x001ED067
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x001EEE71 File Offset: 0x001ED071
		internal virtual Label lblpaymeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x001EEE7A File Offset: 0x001ED07A
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x001EEE84 File Offset: 0x001ED084
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x001EEE8D File Offset: 0x001ED08D
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x001EEE98 File Offset: 0x001ED098
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

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x001EEEDB File Offset: 0x001ED0DB
		// (set) Token: 0x060038E6 RID: 14566 RVA: 0x001EEEE5 File Offset: 0x001ED0E5
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x001EEEEE File Offset: 0x001ED0EE
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x001EEEF8 File Offset: 0x001ED0F8
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x001EEF01 File Offset: 0x001ED101
		// (set) Token: 0x060038EA RID: 14570 RVA: 0x001EEF0B File Offset: 0x001ED10B
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x001EEF14 File Offset: 0x001ED114
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x001EEF1E File Offset: 0x001ED11E
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x001EEF27 File Offset: 0x001ED127
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x001EEF31 File Offset: 0x001ED131
		internal virtual TextBox txtInvDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x001EEF3A File Offset: 0x001ED13A
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x001EEF44 File Offset: 0x001ED144
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x001EEF4D File Offset: 0x001ED14D
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x001EEF57 File Offset: 0x001ED157
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x001EEF60 File Offset: 0x001ED160
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x001EEF6A File Offset: 0x001ED16A
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x001EEF73 File Offset: 0x001ED173
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x001EEF7D File Offset: 0x001ED17D
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x001EEF86 File Offset: 0x001ED186
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x001EEF90 File Offset: 0x001ED190
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x001EEF99 File Offset: 0x001ED199
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x001EEFA3 File Offset: 0x001ED1A3
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x001EEFAC File Offset: 0x001ED1AC
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x001EEFB6 File Offset: 0x001ED1B6
		internal virtual TextBox txtContactName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x001EEFBF File Offset: 0x001ED1BF
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x001EEFC9 File Offset: 0x001ED1C9
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x001EEFD2 File Offset: 0x001ED1D2
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x001EEFDC File Offset: 0x001ED1DC
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x001EEFE5 File Offset: 0x001ED1E5
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x001EEFEF File Offset: 0x001ED1EF
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x001EEFF8 File Offset: 0x001ED1F8
		// (set) Token: 0x06003904 RID: 14596 RVA: 0x001EF002 File Offset: 0x001ED202
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x001EF00B File Offset: 0x001ED20B
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x001EF015 File Offset: 0x001ED215
		internal virtual TextBox txtcustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x001EF01E File Offset: 0x001ED21E
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x001EF028 File Offset: 0x001ED228
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x001EF031 File Offset: 0x001ED231
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x001EF03B File Offset: 0x001ED23B
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x001EF044 File Offset: 0x001ED244
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x001EF04E File Offset: 0x001ED24E
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x001EF057 File Offset: 0x001ED257
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x001EF064 File Offset: 0x001ED264
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

		// Token: 0x0600390F RID: 14607 RVA: 0x001EF0A8 File Offset: 0x001ED2A8
		private void RefundCustomer_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.AllowTellerToViewStockBalances == 0;
				if (flag)
				{
					this.Label3.Visible = false;
					this.txtStockAvail.Visible = false;
				}
				bool flag2 = MyProject.Forms.Form1.ShowSpecialPrice == 1;
				if (flag2)
				{
					this.btnSpecialPrice.Visible = true;
				}
				this.GetBranchDetails();
				this.LoadPayMeths();
				this.LoadCustomers();
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
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x001EF190 File Offset: 0x001ED390
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
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x001EF230 File Offset: 0x001ED430
		private void GetBranchDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				try
				{
					this.coname = dataRow["CompanyName"].ToString();
					this.coadd = dataRow["Address"].ToString();
					this.cotel = dataRow["Tel"].ToString();
					this.cotel2 = dataRow["Tel2"].ToString();
					this.cotel3 = dataRow["Tel3"].ToString();
					this.coemail = dataRow["Email"].ToString();
					this.cobpnum = dataRow["BPNumber"].ToString();
					this.footnote = dataRow["Footnote"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x001EF3C4 File Offset: 0x001ED5C4
		private void LoadCustomers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(this.datCustomers);
			this.cboCustomers.DataSource = this.datCustomers;
			this.cboCustomers.DisplayMember = "CustomerName";
			this.cboCustomers.ValueMember = "CustomerName";
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x001EF488 File Offset: 0x001ED688
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

		// Token: 0x06003914 RID: 14612 RVA: 0x001EF510 File Offset: 0x001ED710
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

		// Token: 0x06003915 RID: 14613 RVA: 0x001EF608 File Offset: 0x001ED808
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

		// Token: 0x06003916 RID: 14614 RVA: 0x001EF714 File Offset: 0x001ED914
		private object searchDat(DataTable dt, string column, string value)
		{
			RefundCustomer._Closure$__382-0 CS$<>8__locals1 = new RefundCustomer._Closure$__382-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((RefundCustomer._Closure$__.$I382-0 == null) ? (RefundCustomer._Closure$__.$I382-0 = (object row1) => (DataRow)row1) : RefundCustomer._Closure$__.$I382-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06003917 RID: 14615 RVA: 0x001EF7F0 File Offset: 0x001ED9F0
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

		// Token: 0x06003918 RID: 14616 RVA: 0x001EF878 File Offset: 0x001EDA78
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

		// Token: 0x06003919 RID: 14617 RVA: 0x001EFA50 File Offset: 0x001EDC50
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

		// Token: 0x0600391A RID: 14618 RVA: 0x001EFAB0 File Offset: 0x001EDCB0
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

		// Token: 0x0600391B RID: 14619 RVA: 0x001EFB74 File Offset: 0x001EDD74
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtQty.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error on search. Ignore");
			}
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x001EFBD4 File Offset: 0x001EDDD4
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtPrice.Text = Conversions.ToString(0);
				this.txtQty.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x001EFCA0 File Offset: 0x001EDEA0
		private void SearchBarCode(int prodtID)
		{
			this.WholesalePriceByQty = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				decimal num2 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate);
				this.priceb4tax = num2;
				this.priceb4tax = Math.Round(this.priceb4tax, 2);
				decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num4 = decimal.Add(num2, decimal.Multiply(decimal.Divide(num3, 100m), num2));
				num4 = Math.Round(num4, 2);
				decimal num5 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
				this.priceb4taxWholesale = num5;
				this.priceb4taxWholesale = Math.Round(this.priceb4taxWholesale, 2);
				this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				this.totpriceWholesale = decimal.Add(num5, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num5));
				this.totpriceWholesale = Math.Round(this.totpriceWholesale, 2);
				bool flag2 = MyProject.Forms.Form1.IsWholesaleShop == 1;
				if (flag2)
				{
					this.txtPrice.Text = this.totpriceWholesale.ToString();
				}
				else
				{
					this.txtPrice.Text = num4.ToString();
				}
				this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num3.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentSpecialPrice = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])))), this.mono_rate);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x001F0088 File Offset: 0x001EE288
		private void SearchProductCode(string prodtcode)
		{
			this.WholesalePriceByQty = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				decimal num2 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate);
				this.priceb4tax = num2;
				this.priceb4tax = Math.Round(this.priceb4tax, 2);
				decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num4 = decimal.Add(num2, decimal.Multiply(decimal.Divide(num3, 100m), num2));
				num4 = Math.Round(num4, 2);
				decimal num5 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
				this.priceb4taxWholesale = num5;
				this.priceb4taxWholesale = Math.Round(this.priceb4taxWholesale, 2);
				this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				this.totpriceWholesale = decimal.Add(num5, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num5));
				this.totpriceWholesale = Math.Round(this.totpriceWholesale, 2);
				bool flag2 = MyProject.Forms.Form1.IsWholesaleShop == 1;
				if (flag2)
				{
					this.txtPrice.Text = this.totpriceWholesale.ToString();
				}
				else
				{
					this.txtPrice.Text = num4.ToString();
				}
				this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num3.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentSpecialPrice = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])))), this.mono_rate);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x001F0448 File Offset: 0x001EE648
		private decimal GetStockAvailable(int productid)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TotalStockIn";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0;
				}
				sqlConnection.Close();
			}
			int num3 = 0;
			SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
			SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "TotalStockOut";
			sqlCommand2.Parameters.AddWithValue("productid", productid);
			sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand2.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable2 = new DataTable();
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			using (sqlConnection3)
			{
				sqlConnection3.Open();
				int num4 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num4 > 0;
				if (flag2)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2[0])), 0, RuntimeHelpers.GetObjectValue(dataRow2[0])));
				}
				else
				{
					num3 = 0;
				}
				sqlConnection3.Close();
			}
			decimal num5 = new decimal(checked(num - num3));
			return num5;
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x001F06B4 File Offset: 0x001EE8B4
		private void AppendGrid()
		{
			int num = 0;
			int num2 = 0;
			decimal num3 = 0m;
			decimal num4 = Convert.ToDecimal(this.lbltax.Text);
			decimal num5 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num3);
			bool flag = decimal.Compare(num4, 0m) != 0;
			decimal num6;
			decimal num7;
			if (flag)
			{
				num6 = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num4, 100m))), 2);
				num7 = new decimal(Convert.ToDouble(Math.Round(decimal.Multiply(decimal.Divide(num4, 100m), num6), 2)) * Conversion.Val(this.txtQty.Text));
			}
			else
			{
				num6 = num5;
				num7 = 0m;
			}
			decimal num8 = new decimal(Conversion.Val(this.txtQty.Text) * Convert.ToDouble(num5));
			num8 = Math.Round(num8, 2);
			string[] array = new string[]
			{
				Conversions.ToString(this.CurrentID),
				this.CurrentCode,
				this.txtDesc.Text,
				num6.ToString(),
				this.txtQty.Text,
				num7.ToString(),
				num8.ToString(),
				this.lblcost.Text,
				Conversions.ToString(num),
				Conversions.ToString(Conversion.Val(this.txtOLDprice.Text)),
				Conversions.ToString(num2),
				"0",
				"",
				Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
				Conversions.ToString(this.WholesalePriceByQty)
			};
			this.DataGridView1.Rows.Add(array);
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x001F0888 File Offset: 0x001EEA88
		private void CalcTotalSale()
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
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
			this.txtTotal.Text = Conversions.ToString(num);
			this.txtTax.Text = Conversions.ToString(num2);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x001F0968 File Offset: 0x001EEB68
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Conversion.Val(this.txtPrice.Text) > 0.0) & (Conversion.Val(this.txtQty.Text) > 0.0);
				if (flag)
				{
					this.AppendGrid();
					this.CalcTotalSale();
					this.txtSearchProductCode.Text = " ";
					this.txtBarCode.Text = "0";
					this.txtQty.Text = Conversions.ToString(0);
					this.lblCouponInfo.Text = "...";
					this.txtsearch.Text = "";
					this.txtBarCode.Text = "";
					bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag2)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
					this.lblcode.Text = "";
					this.WholesalePriceByQty = 0;
					this.cboPayMeth.Enabled = false;
				}
				else
				{
					MessageBox.Show("Please enter the quantity bought.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x001F0AD8 File Offset: 0x001EECD8
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtPrice.Text = Conversions.ToString(0);
				this.txtQty.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x001F0BB0 File Offset: 0x001EEDB0
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				this.PrintHeaderQuotation();
				this.ItemsToBePrintedQuotation();
				this.PrintFooterQuotation();
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
				MessageBox.Show("Quotation print job sent to printer.");
				this.DataGridView1.Rows.Clear();
				this.cboPayMeth.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x001F0C54 File Offset: 0x001EEE54
		private void PrintHeaderQuotation()
		{
			this.TextToPrint = "";
			string text = "QUOTATION";
			int length = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - length) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				string text3 = this.coname;
				int num = text3.Length;
				string text4 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + text3 + Environment.NewLine;
				bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag)
				{
					text3 = "BP Number: " + this.cobpnum;
					num = text3.Length;
					string text5 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text3 + Environment.NewLine;
				}
				text3 = this.coadd;
				num = text3.Length;
				string text6 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text6 + text3 + Environment.NewLine;
				bool flag2 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag2)
				{
					text3 = "Email: " + this.coemail;
					num = text3.Length;
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text7 + text3 + Environment.NewLine;
				}
				bool flag3 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag3)
				{
					text3 = this.cotel;
					num = text3.Length;
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text3 + Environment.NewLine;
				}
				bool flag4 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag4)
				{
					text3 = this.cotel2 + "  " + this.cotel3;
					num = text3.Length;
					string text9 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text3 + Environment.NewLine;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text3 = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "Teller: " + MyProject.Forms.Form1.username;
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
			}
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x001F0FCC File Offset: 0x001EF1CC
		private void ItemsToBePrintedQuotation()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag = Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0;
			if (flag)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + this.txtcustomer.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Details:" + this.txtAddress.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			decimal num = 0m;
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						string text = dataGridViewRow.Cells["Desc"].Value.ToString();
						num = Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value);
						double num2 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)));
						double num3 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
						string text2 = dataGridViewRow.Cells["ProductCode"].Value.ToString();
						int num4 = (int)Math.Round(Conversion.Val(text.Length));
						bool flag2 = num4 >= 34;
						if (flag2)
						{
							text = text.Substring(0, 33);
						}
						else
						{
							int num5 = num4;
							int num6 = 34 - num5;
							text = text.PadRight(num6);
						}
						int length = text.Length;
						string text3 = text;
						string text4 = Conversions.ToString(text3.Length);
						string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine;
						decimal num7 = 0m;
						string text6 = "               ";
						bool flag3 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
						if (flag3)
						{
							decimal num8 = new decimal(unchecked(num2 * Convert.ToDouble(this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod))));
							num7 = decimal.Multiply(num8, num);
							string text7 = Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True);
							int length2 = num8.ToString().Length;
							int i = length2 - 5;
							bool flag4 = i > 0;
							if (flag4)
							{
								while (i > 0)
								{
									text6 = text6.Substring(0, text6.Length - 1);
									i--;
								}
							}
							else
							{
								bool flag5 = i < 0;
								if (flag5)
								{
								}
							}
							text3 = string.Concat(new string[]
							{
								"     ",
								num.ToString(),
								"   X        ",
								Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
								text6,
								Strings.FormatCurrency(num7.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
							});
						}
						else
						{
							string text8 = Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True);
							int length3 = text8.ToString().Length;
							int j = length3 - 5;
							bool flag6 = j > 0;
							if (flag6)
							{
								while (j > 0)
								{
									text6 = text6.Substring(0, text6.Length - 1);
									j--;
								}
							}
							else
							{
								bool flag7 = j < 0;
								if (flag7)
								{
								}
							}
							num7 = new decimal(unchecked(num2 * Convert.ToDouble(num)));
							text3 = string.Concat(new string[]
							{
								"     ",
								num.ToString(),
								"   X        ",
								Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
								text6,
								Strings.FormatCurrency(num7.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
							});
						}
						string text9 = Conversions.ToString(text3.Length);
						string text10 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine;
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
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x001F14EC File Offset: 0x001EF6EC
		private void PrintFooterQuotation()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
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
			string text = "Tax         " + Strings.FormatCurrency(num2.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
			string text2 = Conversions.ToString(text.Length);
			int length = text.Length;
			checked
			{
				string text3 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag = Operators.CompareString(text, "Tax         $0.00", false) != 0;
				if (flag)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				}
				bool flag2 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				if (flag2)
				{
					decimal num3 = new decimal(unchecked(num * Convert.ToDouble(this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod))));
					text = "Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				else
				{
					text = "Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				text2 = Conversions.ToString(length);
				string text4 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					Environment.NewLine,
					text4,
					text,
					Environment.NewLine
				});
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = "Customer:" + this.txtcustomer.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag3 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag3)
				{
				}
				text = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x001F17B0 File Offset: 0x001EF9B0
		private decimal GetRate(int paymethid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetPaymentMethRate";
			sqlCommand.Parameters.AddWithValue("paymethid", paymethid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x001F1860 File Offset: 0x001EFA60
		private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcCustomerBill(this.cboCustomers.Text);
				this.FetchCustomer(Conversions.ToString(this.cboCustomers.SelectedValue));
			}
			catch (InvalidCastException ex)
			{
			}
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x001F18BC File Offset: 0x001EFABC
		private void CalcCustomerBill(string customername)
		{
			try
			{
				this.lblCustomerBillingBal.Text = "Acc Bal $" + this.GetCustomerBillTotal(customername, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating customer bill. Proceed. Details: " + ex.Message);
			}
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x001F1948 File Offset: 0x001EFB48
		private void FetchCustomer(string customername)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCustomerDetails";
				sqlCommand.Parameters.AddWithValue("CustomerName", customername);
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
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x001F1ACC File Offset: 0x001EFCCC
		private double GetCustomerBillTotal(string customername, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCalcAccBalance";
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			double num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["bal"]));
				if (flag2)
				{
					num2 = 0.0;
				}
				else
				{
					num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["bal"]));
				}
			}
			else
			{
				num2 = 0.0;
			}
			return num2;
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x001F1BC0 File Offset: 0x001EFDC0
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			int num3 = 0;
			int num4 = 0;
			Font font = new Font("Times New Roman", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			checked
			{
				int num9 = (int)Math.Round(Math.Round((double)num5 / 1.0));
				Rectangle rectangle = new Rectangle(num7, num8, num6, num5);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				e.Graphics.MeasureString(this.TextToPrint, font, e.MarginBounds.Size, stringFormat, out num3, out num4);
				num4 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				using (StringReader stringReader = new StringReader(this.TextToPrint))
				{
					while (i < num4)
					{
						text = stringReader.ReadLine();
						bool flag = stringReader.Peek() == -1;
						if (flag)
						{
							break;
						}
						float num10 = unchecked(num2 + (float)i * font.GetHeight(e.Graphics));
						e.Graphics.DrawString(text, font, Brushes.Black, num, num10, new StringFormat());
						i++;
					}
				}
				bool flag2 = (Operators.CompareString(text, "", false) == 0) | Information.IsNothing(text);
				if (flag2)
				{
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
					this.TextToPrint = this.TextToPrint.Substring(num3);
				}
			}
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x001F1D94 File Offset: 0x001EFF94
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.mono_rate = this.GetRate(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
				this.lblpaymeth.Text = this.cboPayMeth.Text;
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x001F1E40 File Offset: 0x001F0040
		private void Button9_Click(object sender, EventArgs e)
		{
			bool flag = this.DataGridView1.Rows.Count > 0;
			if (flag)
			{
				try
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunQuotationSaveAll");
					sqlCommand.Transaction = sqlTransaction;
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "InsertQuotationDetailsHeader";
					sqlCommand.Parameters.AddWithValue("quotation_num", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
					this.quotation_number = Conversions.ToInteger(sqlCommand.ExecuteScalar());
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertQuotationDetails";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
							sqlCommand.Parameters.AddWithValue("productcode", dataGridViewRow.Cells["ProductCode"].Value.ToString());
							sqlCommand.Parameters.AddWithValue("productdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Desc"].Value));
							sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
							sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value));
							sqlCommand.Parameters.AddWithValue("sellingprice", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value));
							sqlCommand.Parameters.AddWithValue("tax", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
							sqlCommand.Parameters.AddWithValue("customerref", this.txtcustomer.Text);
							sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("createddate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("paymentmethod", this.cboPayMeth.Text);
							sqlCommand.Parameters.AddWithValue("quotationnumber", this.quotation_number);
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
					sqlTransaction.Commit();
					sqlCommand.Connection.Close();
					Quotation quotation = new Quotation();
					quotation.quotationnumber = this.quotation_number;
					quotation.ShowDialog(this);
					quotation.Dispose();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error generating quotation. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x001F2284 File Offset: 0x001F0484
		private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				bool flag = this.DataGridView1.Rows.Count == 0;
				if (flag)
				{
					this.cboPayMeth.Enabled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x001F22DC File Offset: 0x001F04DC
		private void Button7_Click(object sender, EventArgs e)
		{
			this.SaveCustomerDetails();
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x001F22E8 File Offset: 0x001F04E8
		private void SaveCustomerDetails()
		{
			try
			{
				bool flag = this.pf.IsCustomerNew(this.txtcustomer.Text, this._cnn);
				if (flag)
				{
					this.InsertNewCustomer();
				}
				else
				{
					this.UpdateCustomer();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer details. SALE COMPLETED. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x001F2364 File Offset: 0x001F0564
		private void InsertNewCustomer()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertCustomerDetails";
			sqlCommand.Parameters.AddWithValue("CustomerName", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobile.Text);
			sqlCommand.Parameters.AddWithValue("ContactName", this.txtContactName.Text);
			sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("invoicedetails1", this.txtInvDetails1.Text);
			sqlCommand.Parameters.AddWithValue("invoicedetails2", this.txtInvDetails2.Text);
			sqlCommand.Parameters.AddWithValue("tel", this.txtTel.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x001F24F4 File Offset: 0x001F06F4
		private void UpdateCustomer()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateCustomerDetails";
			sqlCommand.Parameters.AddWithValue("CustomerName", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobile.Text);
			sqlCommand.Parameters.AddWithValue("ContactName", this.txtContactName.Text);
			sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("invoicedetails1", this.txtInvDetails1.Text);
			sqlCommand.Parameters.AddWithValue("invoicedetails2", this.txtInvDetails2.Text);
			sqlCommand.Parameters.AddWithValue("tel", this.txtTel.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x001F2684 File Offset: 0x001F0884
		private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 1;
			if (flag)
			{
				bool flag2 = e.KeyChar == '\r';
				if (flag2)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x001F26E0 File Offset: 0x001F08E0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunQuotationSaveAll");
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertQuotationDetailsHeader";
				sqlCommand.Parameters.AddWithValue("quotation_num", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
				this.quotation_number = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "InsertQuotationDetails";
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
						sqlCommand.Parameters.AddWithValue("productcode", dataGridViewRow.Cells["ProductCode"].Value.ToString());
						sqlCommand.Parameters.AddWithValue("productdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Desc"].Value));
						sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
						sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value));
						sqlCommand.Parameters.AddWithValue("sellingprice", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value));
						sqlCommand.Parameters.AddWithValue("tax", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
						sqlCommand.Parameters.AddWithValue("customerref", this.txtcustomer.Text);
						sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("createddate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("paymentmethod", this.cboPayMeth.Text);
						sqlCommand.Parameters.AddWithValue("quotationnumber", this.quotation_number);
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
				sqlTransaction.Commit();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error effecting transaction. Details: " + ex.Message);
			}
		}

		// Token: 0x04001845 RID: 6213
		private string _cnn;

		// Token: 0x04001846 RID: 6214
		private int CurrentID;

		// Token: 0x04001847 RID: 6215
		private string CurrentCode;

		// Token: 0x04001848 RID: 6216
		private decimal CurrentSpecialPrice;

		// Token: 0x04001849 RID: 6217
		private DataTable datCustomers;

		// Token: 0x0400184A RID: 6218
		private decimal priceb4tax;

		// Token: 0x0400184B RID: 6219
		private decimal priceb4taxWholesale;

		// Token: 0x0400184C RID: 6220
		private decimal currentWholesaleQty;

		// Token: 0x0400184D RID: 6221
		private decimal taxdueWholesale;

		// Token: 0x0400184E RID: 6222
		private decimal totpriceWholesale;

		// Token: 0x0400184F RID: 6223
		private int WholesalePriceByQty;

		// Token: 0x04001850 RID: 6224
		private string TextToPrint;

		// Token: 0x04001851 RID: 6225
		private string coname;

		// Token: 0x04001852 RID: 6226
		private string coadd;

		// Token: 0x04001853 RID: 6227
		private string cotel;

		// Token: 0x04001854 RID: 6228
		private string coemail;

		// Token: 0x04001855 RID: 6229
		private string cobpnum;

		// Token: 0x04001856 RID: 6230
		private string cotel2;

		// Token: 0x04001857 RID: 6231
		private string cotel3;

		// Token: 0x04001858 RID: 6232
		private string footnote;

		// Token: 0x04001859 RID: 6233
		private decimal mono_rate;

		// Token: 0x0400185A RID: 6234
		private int quotation_number;

		// Token: 0x0400185B RID: 6235
		private PublicFunctions pf;
	}
}
