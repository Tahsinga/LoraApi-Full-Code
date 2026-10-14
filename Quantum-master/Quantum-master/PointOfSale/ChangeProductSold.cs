using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class ChangeProductSold : Form
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x00037870 File Offset: 0x00035A70
		public ChangeProductSold()
		{
			base.Load += this.ChangeProductSold_Load;
			this.selected_mode = 1;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.specialprice = 0m;
			this.currenttaxrate = 0m;
			this.mono_rate = 0m;
			this.discAmount = 0m;
			this.discTeller = 0m;
			this.discCoupons = 0m;
			this.discPromotion = 0m;
			this.discPromotionName = "";
			this.discDESC = "";
			this.pf = new PublicFunctions();
			this.CurrentID = 0;
			this.CurrentCode = "";
			this.PaymentMethodDiscountEffected = 0;
			this.discPaymentMethod = 0;
			this.RowID = 0;
			this.currentExpires = false;
			this.customer_name = "";
			this.TextToPrint = "";
			this.InitializeComponent();
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0003A798 File Offset: 0x00038998
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0003A7A2 File Offset: 0x000389A2
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0003A7AB File Offset: 0x000389AB
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0003A7B5 File Offset: 0x000389B5
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0003A7BE File Offset: 0x000389BE
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0003A7C8 File Offset: 0x000389C8
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
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0003A826 File Offset: 0x00038A26
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0003A830 File Offset: 0x00038A30
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0003A839 File Offset: 0x00038A39
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0003A843 File Offset: 0x00038A43
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0003A84C File Offset: 0x00038A4C
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0003A858 File Offset: 0x00038A58
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0003A89B File Offset: 0x00038A9B
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x0003A8A5 File Offset: 0x00038AA5
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0003A8AE File Offset: 0x00038AAE
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x0003A8B8 File Offset: 0x00038AB8
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsearch_KeyDown);
				EventHandler eventHandler = new EventHandler(this.txtsearch_TextChanged);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0003A916 File Offset: 0x00038B16
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x0003A920 File Offset: 0x00038B20
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0003A929 File Offset: 0x00038B29
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x0003A933 File Offset: 0x00038B33
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0003A93C File Offset: 0x00038B3C
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x0003A946 File Offset: 0x00038B46
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0003A94F File Offset: 0x00038B4F
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0003A959 File Offset: 0x00038B59
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0003A962 File Offset: 0x00038B62
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x0003A96C File Offset: 0x00038B6C
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0003A9AF File Offset: 0x00038BAF
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x0003A9BC File Offset: 0x00038BBC
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtQty_KeyDown);
				TextBox textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtQty = value;
				textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0003AA1A File Offset: 0x00038C1A
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0003AA24 File Offset: 0x00038C24
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0003AA2D File Offset: 0x00038C2D
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x0003AA37 File Offset: 0x00038C37
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0003AA40 File Offset: 0x00038C40
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x0003AA4A File Offset: 0x00038C4A
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0003AA53 File Offset: 0x00038C53
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0003AA60 File Offset: 0x00038C60
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0003AAA3 File Offset: 0x00038CA3
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0003AAB0 File Offset: 0x00038CB0
		internal virtual RadioButton radCorrect
		{
			[CompilerGenerated]
			get
			{
				return this._radCorrect;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.radCorrect_CheckedChanged);
				RadioButton radioButton = this._radCorrect;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._radCorrect = value;
				radioButton = this._radCorrect;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0003AAF3 File Offset: 0x00038CF3
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0003AB00 File Offset: 0x00038D00
		internal virtual RadioButton radTobeChanged
		{
			[CompilerGenerated]
			get
			{
				return this._radTobeChanged;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RadioButton1_CheckedChanged);
				RadioButton radioButton = this._radTobeChanged;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._radTobeChanged = value;
				radioButton = this._radTobeChanged;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0003AB43 File Offset: 0x00038D43
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0003AB4D File Offset: 0x00038D4D
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0003AB56 File Offset: 0x00038D56
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0003AB60 File Offset: 0x00038D60
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0003AB69 File Offset: 0x00038D69
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0003AB74 File Offset: 0x00038D74
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

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0003ABB7 File Offset: 0x00038DB7
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0003ABC1 File Offset: 0x00038DC1
		internal virtual Label lblSummary
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0003ABCA File Offset: 0x00038DCA
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x0003ABD4 File Offset: 0x00038DD4
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0003ABDD File Offset: 0x00038DDD
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0003ABE7 File Offset: 0x00038DE7
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0003ABF0 File Offset: 0x00038DF0
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x0003ABFA File Offset: 0x00038DFA
		internal virtual Label Label35
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0003AC03 File Offset: 0x00038E03
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0003AC0D File Offset: 0x00038E0D
		internal virtual Label lblpaymeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0003AC16 File Offset: 0x00038E16
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0003AC20 File Offset: 0x00038E20
		internal virtual TextBox txtAmtPaid
		{
			[CompilerGenerated]
			get
			{
				return this._txtAmtPaid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmtPaid_KeyPress);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmtPaid_KeyDown);
				EventHandler eventHandler = new EventHandler(this.txtAmtPaid_TextChanged);
				TextBox textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtAmtPaid = value;
				textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0003AC99 File Offset: 0x00038E99
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0003ACA3 File Offset: 0x00038EA3
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0003ACAC File Offset: 0x00038EAC
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0003ACB6 File Offset: 0x00038EB6
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0003ACBF File Offset: 0x00038EBF
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0003ACC9 File Offset: 0x00038EC9
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0003ACD2 File Offset: 0x00038ED2
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0003ACDC File Offset: 0x00038EDC
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0003ACE5 File Offset: 0x00038EE5
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x0003ACF0 File Offset: 0x00038EF0
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0003AD33 File Offset: 0x00038F33
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0003AD3D File Offset: 0x00038F3D
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0003AD46 File Offset: 0x00038F46
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x0003AD50 File Offset: 0x00038F50
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0003AD59 File Offset: 0x00038F59
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x0003AD63 File Offset: 0x00038F63
		internal virtual TextBox txtCoupons
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0003AD6C File Offset: 0x00038F6C
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0003AD76 File Offset: 0x00038F76
		internal virtual TextBox txtOLDprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0003AD7F File Offset: 0x00038F7F
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0003AD89 File Offset: 0x00038F89
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0003AD92 File Offset: 0x00038F92
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x0003AD9C File Offset: 0x00038F9C
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

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0003ADDF File Offset: 0x00038FDF
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x0003ADE9 File Offset: 0x00038FE9
		internal virtual TextBox txtPriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0003ADF2 File Offset: 0x00038FF2
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0003ADFC File Offset: 0x00038FFC
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0003AE05 File Offset: 0x00039005
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0003AE0F File Offset: 0x0003900F
		internal virtual TextBox txtTotReplaced
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0003AE18 File Offset: 0x00039018
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x0003AE22 File Offset: 0x00039022
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0003AE2B File Offset: 0x0003902B
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0003AE35 File Offset: 0x00039035
		internal virtual TextBox txtTotReturned
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0003AE3E File Offset: 0x0003903E
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0003AE48 File Offset: 0x00039048
		internal virtual TextBox txtChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0003AE51 File Offset: 0x00039051
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0003AE5B File Offset: 0x0003905B
		internal virtual Label lblchange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0003AE64 File Offset: 0x00039064
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x0003AE70 File Offset: 0x00039070
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0003AEB3 File Offset: 0x000390B3
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x0003AEBD File Offset: 0x000390BD
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0003AEC6 File Offset: 0x000390C6
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x0003AED0 File Offset: 0x000390D0
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0003AED9 File Offset: 0x000390D9
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x0003AEE3 File Offset: 0x000390E3
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0003AEEC File Offset: 0x000390EC
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0003AEF6 File Offset: 0x000390F6
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0003AEFF File Offset: 0x000390FF
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x0003AF09 File Offset: 0x00039109
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0003AF12 File Offset: 0x00039112
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x0003AF1C File Offset: 0x0003911C
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0003AF25 File Offset: 0x00039125
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x0003AF2F File Offset: 0x0003912F
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0003AF38 File Offset: 0x00039138
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0003AF42 File Offset: 0x00039142
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0003AF4B File Offset: 0x0003914B
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x0003AF55 File Offset: 0x00039155
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0003AF5E File Offset: 0x0003915E
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x0003AF68 File Offset: 0x00039168
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0003AF71 File Offset: 0x00039171
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x0003AF7B File Offset: 0x0003917B
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0003AF84 File Offset: 0x00039184
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0003AF8E File Offset: 0x0003918E
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0003AF97 File Offset: 0x00039197
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x0003AFA1 File Offset: 0x000391A1
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0003AFAA File Offset: 0x000391AA
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x0003AFB4 File Offset: 0x000391B4
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0003AFBD File Offset: 0x000391BD
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x0003AFC7 File Offset: 0x000391C7
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0003AFD0 File Offset: 0x000391D0
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0003AFDA File Offset: 0x000391DA
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0003AFE3 File Offset: 0x000391E3
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x0003AFED File Offset: 0x000391ED
		internal virtual DataGridViewTextBoxColumn DiscPaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0003AFF6 File Offset: 0x000391F6
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x0003B000 File Offset: 0x00039200
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0003B009 File Offset: 0x00039209
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x0003B013 File Offset: 0x00039213
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0003B01C File Offset: 0x0003921C
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x0003B026 File Offset: 0x00039226
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0003B02F File Offset: 0x0003922F
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x0003B039 File Offset: 0x00039239
		internal virtual DataGridViewTextBoxColumn Taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0003B042 File Offset: 0x00039242
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x0003B04C File Offset: 0x0003924C
		internal virtual DataGridViewTextBoxColumn PromStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0003B055 File Offset: 0x00039255
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x0003B05F File Offset: 0x0003925F
		internal virtual DataGridViewTextBoxColumn OtherDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0003B068 File Offset: 0x00039268
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x0003B072 File Offset: 0x00039272
		internal virtual DataGridViewTextBoxColumn IsVoucher
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0003B07B File Offset: 0x0003927B
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x0003B085 File Offset: 0x00039285
		internal virtual DataGridViewTextBoxColumn Comments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0003B08E File Offset: 0x0003928E
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x0003B098 File Offset: 0x00039298
		internal virtual DataGridViewTextBoxColumn RowNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0003B0A1 File Offset: 0x000392A1
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x0003B0AB File Offset: 0x000392AB
		internal virtual DataGridViewTextBoxColumn mode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0003B0B4 File Offset: 0x000392B4
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x0003B0BE File Offset: 0x000392BE
		internal virtual DataGridViewTextBoxColumn InvoiceNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0003B0C7 File Offset: 0x000392C7
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x0003B0D1 File Offset: 0x000392D1
		internal virtual DataGridViewTextBoxColumn InvoiceEntryNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0003B0DA File Offset: 0x000392DA
		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.RadToBeChangedProcedure();
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0003B0E4 File Offset: 0x000392E4
		private void RadToBeChangedProcedure()
		{
			try
			{
				bool @checked = this.radTobeChanged.Checked;
				if (@checked)
				{
					this.GroupBox1.BackColor = Color.Red;
					this.selected_mode = 1;
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error changing");
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0003B17C File Offset: 0x0003937C
		private void radCorrect_CheckedChanged(object sender, EventArgs e)
		{
			this.RadCorrectProcedure();
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0003B188 File Offset: 0x00039388
		private void RadCorrectProcedure()
		{
			try
			{
				bool @checked = this.radCorrect.Checked;
				if (@checked)
				{
					this.GroupBox1.BackColor = Color.Green;
					this.selected_mode = 2;
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting invoice number (radcorrect). Detail: " + ex.Message);
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0003B22C File Offset: 0x0003942C
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag7;
			try
			{
				bool flag = msg.WParam.ToInt32() == 34;
				if (flag)
				{
					this.Button2.TabStop = true;
					this.txtAmtPaid.Focus();
				}
				else
				{
					bool flag2 = msg.WParam.ToInt32() == 33;
					if (flag2)
					{
						this.Button2.TabStop = false;
						this.txtsearch.Focus();
					}
					else
					{
						bool flag3 = msg.WParam.ToInt32() == 112;
						if (flag3)
						{
							this.txtBarCode.Text = "";
							this.txtBarCode.Focus();
						}
						else
						{
							bool flag4 = msg.WParam.ToInt32() == 27;
							if (flag4)
							{
								this.ClearForm();
							}
							else
							{
								bool flag5 = msg.WParam.ToInt32() == 118;
								if (flag5)
								{
									this.radTobeChanged.Checked = true;
									this.selected_mode = 1;
								}
								else
								{
									bool flag6 = msg.WParam.ToInt32() == 119;
									if (flag6)
									{
										this.radCorrect.Checked = true;
										this.selected_mode = 2;
									}
								}
							}
						}
					}
				}
				flag7 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag7;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0003B394 File Offset: 0x00039594
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

		// Token: 0x0600064A RID: 1610 RVA: 0x0003B41C File Offset: 0x0003961C
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

		// Token: 0x0600064B RID: 1611 RVA: 0x0003B4A4 File Offset: 0x000396A4
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

		// Token: 0x0600064C RID: 1612 RVA: 0x0003B5B0 File Offset: 0x000397B0
		private object searchDat(DataTable dt, string column, string value)
		{
			ChangeProductSold._Closure$__367-0 CS$<>8__locals1 = new ChangeProductSold._Closure$__367-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((ChangeProductSold._Closure$__.$I367-0 == null) ? (ChangeProductSold._Closure$__.$I367-0 = (object row1) => (DataRow)row1) : ChangeProductSold._Closure$__.$I367-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x0600064D RID: 1613 RVA: 0x0003B68C File Offset: 0x0003988C
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

		// Token: 0x0600064E RID: 1614 RVA: 0x0003B74C File Offset: 0x0003994C
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

		// Token: 0x0600064F RID: 1615 RVA: 0x0003B95C File Offset: 0x00039B5C
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

		// Token: 0x06000650 RID: 1616 RVA: 0x0003B9BC File Offset: 0x00039BBC
		private void ClearForm()
		{
			this.DataGridView1.Rows.Clear();
			this.txtPrice.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(1);
			this.txtSearchProductCode.Text = Conversions.ToString(0);
			this.txtTotal.Text = Conversions.ToString(0);
			this.txtAmtPaid.Text = "";
			this.txtTax.Text = Conversions.ToString(0);
			this.lblcode.Text = "";
			this.txtBarCode.Text = "";
			this.Button2.TabStop = false;
			bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
			this.radTobeChanged.Checked = true;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0003BAB8 File Offset: 0x00039CB8
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
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0003BB18 File Offset: 0x00039D18
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

		// Token: 0x06000653 RID: 1619 RVA: 0x0003BBDC File Offset: 0x00039DDC
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtPrice.Text = Conversions.ToString(0);
				this.txtQty.Text = Conversions.ToString(0);
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

		// Token: 0x06000654 RID: 1620 RVA: 0x0003BCC4 File Offset: 0x00039EC4
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
					this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
					this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
					int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
					bool flag3 = num2 == 0;
					decimal num4;
					decimal num5;
					if (flag3)
					{
						DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag4 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
						if (!flag4)
						{
							this.txtCoupons.Text = "";
							this.discAmount = 0m;
						}
						bool flag5 = MyProject.Forms.Form1.CalcBackwards == 1;
						if (flag5)
						{
							object obj = dataRow["SellingPrice"];
							object obj2 = null;
							Type typeFromHandle = typeof(Math);
							string text = "Round";
							object[] array = new object[3];
							array[0] = Operators.MultiplyObject(Operators.DivideObject(dataRow["TaxRate"], 100), dataRow["SellingPrice"]);
							int num3 = 1;
							Form1 form = MyProject.Forms.Form1;
							ref int ptr = ref form.DecimalPlaces;
							array[num3] = form.DecimalPlaces;
							array[2] = MidpointRounding.AwayFromZero;
							object[] array2 = array;
							string[] array3 = null;
							Type[] array4 = null;
							bool[] array5 = new bool[3];
							array5[1] = true;
							bool[] array6 = array5;
							object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text, array, array3, array4, array5);
							if (array6[1])
							{
								ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
							}
							num4 = Conversions.ToDecimal(Operators.MultiplyObject(Operators.AddObject(obj, obj3), this.mono_rate));
						}
						else
						{
							num4 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), productPayMethodDiscount["disc"]));
						}
						num5 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
					}
					else
					{
						DataRow productPayMethodDiscount2 = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag6 = Operators.ConditionalCompareObjectGreater(productPayMethodDiscount2["disc"], 0, false);
						if (flag6)
						{
							this.txtCoupons.Text = "1";
							this.txtOLDprice.Text = Conversions.ToString(productPayMethodDiscount2["oldprice"]);
							this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount2["paymethod"]);
							this.discAmount = Conversions.ToDecimal(productPayMethodDiscount2["disc"]);
							this.cboPayMeth.Enabled = false;
							this.PaymentMethodDiscountEffected = 1;
						}
						DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
						num4 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate), productPayMethodDiscount2["disc"]));
						num5 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
					}
					decimal num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					bool flag7 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
					if (flag7)
					{
						bool flag8 = MyProject.Forms.Form1.CalcBackwards == 1;
						decimal num7;
						if (flag8)
						{
							this.priceb4tax = Conversions.ToDecimal(Operators.DivideObject(num4, Operators.AddObject(1, dataRow["TaxRate"])));
							num7 = Math.Round(num4, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						}
						else
						{
							this.priceb4tax = num4;
							num7 = decimal.Add(num4, Math.Round(decimal.Multiply(decimal.Divide(num6, 100m), num4), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
						}
						this.priceb4tax = this.priceb4tax;
						num7 = num7;
						this.txtPrice.Text = num7.ToString();
						this.priceb4taxWholesale = num5;
						this.priceb4taxWholesale = this.priceb4taxWholesale;
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = decimal.Add(num5, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num5));
						this.totpriceWholesale = this.totpriceWholesale;
						bool flag9 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag9)
						{
							this.txtPrice.Text = Math.Round(this.totpriceWholesale, 8, MidpointRounding.AwayFromZero).ToString();
						}
						else
						{
							this.txtPrice.Text = Math.Round(num7, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
						}
					}
					else
					{
						num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.priceb4tax = Math.Round(decimal.Divide(num4, decimal.Add(1m, decimal.Divide(num6, 100m))), 5, MidpointRounding.AwayFromZero);
						this.currenttaxrate = num6;
						decimal num8 = num4;
						num8 = num8;
						this.priceb4taxWholesale = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num6, 100m))), 5, MidpointRounding.AwayFromZero);
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = num5;
						bool flag10 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag10)
						{
							this.txtPrice.Text = this.totpriceWholesale.ToString();
						}
						else
						{
							this.txtPrice.Text = num8.ToString();
						}
					}
					this.lblcost.Text = Conversions.ToString(Operators.MultiplyObject(dataRow["Cost"], this.mono_rate));
					this.lbltax.Text = Math.Round(num6, 5, MidpointRounding.AwayFromZero).ToString();
					this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
					this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
					bool flag11 = Operators.CompareString(this.txtSearchProductCode.Text, "", false) != 0;
					if (flag11)
					{
						this.currentUOM = dataRow["UOM"].ToString();
					}
				}
				else
				{
					this.txtSearchProductCode.Text = "";
				}
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0003C688 File Offset: 0x0003A888
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.AppendGrid();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending grid. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		private void AppendGrid()
		{
			bool flag = this.CurrentID == 0;
			checked
			{
				if (!flag)
				{
					bool flag2 = this.selected_mode == 1;
					if (flag2)
					{
						this.GetInvoice(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.CurrentID, new decimal(Conversion.Val(this.txtQty.Text)), Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
						bool flag3 = this.invnum == 0;
						if (flag3)
						{
							return;
						}
					}
					else
					{
						this.invnum = 0;
						this.inv_entyrno = 0;
					}
					int num = 0;
					int num2 = 0;
					decimal num3 = 0m;
					this.discTeller = 0m;
					this.discDESC = "";
					bool flag4 = (MyProject.Forms.Form1.IsWarehouse == 0) | ((MyProject.Forms.Form1.IsWarehouse == 1) & !this.currentExpires);
					if (flag4)
					{
						bool flag5 = Conversion.Val(this.txtQty.Text) == 0.0;
						if (flag5)
						{
							MessageBox.Show("Please enter a valid quantity.");
							return;
						}
						bool flag6 = this.selected_mode == 2;
						if (flag6)
						{
							decimal stockAvailable = this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, this.currentUOM, MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false);
							bool flag7 = Conversion.Val(this.txtQty.Text) > Convert.ToDouble(stockAvailable);
							if (flag7)
							{
								MessageBox.Show("Insufficient stock balance to exchange product.");
								return;
							}
						}
						bool flag8 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
						if (flag8)
						{
							num = (int)Math.Round(Conversion.Val(this.txtCoupons.Text));
						}
						bool flag9 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
						if (flag9)
						{
							this.discTeller = Convert.ToDecimal(this.txtPriceChange.Text);
							this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
							num2 = 1;
							this.priceb4tax = decimal.Add(this.priceb4tax, this.discTeller);
						}
						else
						{
							this.discTeller = 0m;
							num2 = 0;
						}
						decimal num4 = Convert.ToDecimal(this.lbltax.Text);
						decimal num5 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), this.discTeller);
						this.priceb4tax = decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num4, 100m)));
						bool flag10 = decimal.Compare(num4, 0m) != 0;
						string[] array;
						unchecked
						{
							decimal num6;
							decimal num7;
							decimal num8;
							if (flag10)
							{
								num6 = Math.Round(this.priceb4tax, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
								bool flag11 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
								if (flag11)
								{
									num7 = new decimal(Math.Round(Convert.ToDouble(decimal.Multiply(decimal.Divide(num4, 100m), num6)) * Conversion.Val(this.txtQty.Text), 2, MidpointRounding.AwayFromZero));
								}
								else
								{
									num7 = new decimal(Convert.ToDouble(Math.Round(decimal.Multiply(decimal.Divide(num4, 100m), num6), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text));
								}
								num8 = decimal.Divide(num4, 100m);
							}
							else
							{
								num6 = Math.Round(num5, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
								num7 = 0m;
								num8 = 0m;
							}
							bool flag12 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
							decimal num9;
							if (flag12)
							{
								num9 = new decimal(Convert.ToDouble(Math.Round(decimal.Add(num6, decimal.Multiply(num6, decimal.Divide(num4, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text));
							}
							else
							{
								num9 = new decimal(Convert.ToDouble(Math.Round(decimal.Add(num6, decimal.Multiply(num6, decimal.Divide(num4, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text));
							}
							string text = "";
							string text2 = Conversions.ToString(this.discAmount);
							bool flag13 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
							if (flag13)
							{
								text = this.discPaymentMethod.ToString();
							}
							bool flag14 = decimal.Compare(this.discTeller, 0m) != 0;
							if (flag14)
							{
								num3 = decimal.Add(num3, this.discTeller);
								ref string ptr = ref this.discDESC;
								this.discDESC = ptr + "Product Discount, " + MyProject.Forms.Form1.Approvedby;
							}
							bool flag15 = decimal.Compare(this.discAmount, 0m) != 0;
							if (flag15)
							{
								num3 = decimal.Add(num3, this.discAmount);
								ref string ptr = ref this.discDESC;
								this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
							}
							bool flag16 = decimal.Compare(this.discCoupons, 0m) != 0;
							if (flag16)
							{
								num3 = decimal.Add(num3, this.discCoupons);
								ref string ptr = ref this.discDESC;
								this.discDESC = ptr + "Coupon Discount, ";
							}
							bool flag17 = decimal.Compare(this.discPromotion, 0m) != 0;
							if (flag17)
							{
								num3 = decimal.Add(num3, this.discPromotion);
								ref string ptr = ref this.discDESC;
								this.discDESC = ptr + this.discPromotionName + ", ";
							}
							array = new string[]
							{
								Conversions.ToString(this.CurrentID),
								this.CurrentCode,
								this.txtDesc.Text,
								num6.ToString(),
								this.txtQty.Text,
								num7.ToString(),
								Conversions.ToString(num9),
								this.lblcost.Text,
								Conversions.ToString(num),
								Conversions.ToString(Conversion.Val(this.txtOLDprice.Text)),
								Conversions.ToString(num2),
								"0",
								"",
								Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
								Conversions.ToString(this.WholesalePriceByQty),
								this.discDESC,
								text,
								num3.ToString(),
								"",
								Conversions.ToString(0),
								Conversions.ToString(num8),
								"",
								MyProject.Forms.Form1.OtherDetail,
								Conversions.ToString(this.CurrentIsVoucher),
								"",
								this.RowID.ToString(),
								Conversions.ToString(this.selected_mode),
								Conversions.ToString(this.invnum),
								Conversions.ToString(this.inv_entyrno)
							};
						}
						this.RowID++;
						this.DataGridView1.Rows.Add(array);
					}
					else
					{
						bool flag18 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.currentExpires;
						if (flag18)
						{
							DataTable selectedBatch = MyProject.Forms.Form1.SelectedBatch;
							bool flag19 = selectedBatch.Rows.Count > 0;
							if (flag19)
							{
								try
								{
									foreach (object obj in selectedBatch.Rows)
									{
										DataRow dataRow = (DataRow)obj;
										int num10 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"]));
										bool flag20 = num10 != 0;
										if (flag20)
										{
											bool flag21 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
											if (flag21)
											{
												num = (int)Math.Round(Conversion.Val(this.txtCoupons.Text));
											}
											decimal num11 = 0m;
											bool flag22 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
											if (flag22)
											{
												num11 = Convert.ToDecimal(this.txtPriceChange.Text);
												this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
												num2 = 1;
												this.priceb4tax = decimal.Add(this.priceb4tax, num11);
											}
											decimal num12 = Convert.ToDecimal(this.lbltax.Text);
											decimal num13 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num11);
											bool flag23 = decimal.Compare(num12, 0m) != 0;
											decimal num6;
											decimal num7;
											decimal num8;
											if (flag23)
											{
												num6 = decimal.Divide(num13, decimal.Add(1m, decimal.Divide(num12, 100m)));
												num7 = Conversions.ToDecimal(Strings.Format(decimal.Multiply(Math.Round(decimal.Multiply(decimal.Divide(num12, 100m), num6), 2), new decimal(num10)), "N2"));
												num8 = decimal.Divide(num12, 100m);
											}
											else
											{
												num6 = num13;
												num7 = 0m;
												num8 = 0m;
											}
											decimal num14 = decimal.Multiply(new decimal(num10), num13);
											num14 = num14;
											string text3 = "";
											bool flag24 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
											if (flag24)
											{
												text3 = this.discPaymentMethod.ToString();
											}
											bool flag25 = decimal.Compare(this.discTeller, 0m) != 0;
											if (flag25)
											{
												num3 = decimal.Add(num3, this.discTeller);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + "Cashier Discount, " + MyProject.Forms.Form1.Approvedby;
											}
											bool flag26 = decimal.Compare(this.discAmount, 0m) != 0;
											if (flag26)
											{
												num3 = decimal.Add(num3, this.discAmount);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
											}
											bool flag27 = decimal.Compare(this.discCoupons, 0m) != 0;
											if (flag27)
											{
												num3 = decimal.Add(num3, this.discCoupons);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + "Coupon Discount, ";
											}
											bool flag28 = decimal.Compare(this.discPromotion, 0m) != 0;
											if (flag28)
											{
												num3 = decimal.Add(num3, this.discPromotion);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + this.discPromotionName + ", ";
											}
											string[] array2 = new string[]
											{
												Conversions.ToString(this.CurrentID),
												this.CurrentCode,
												this.txtDesc.Text,
												num6.ToString(),
												num10.ToString(),
												num7.ToString(),
												num14.ToString(),
												this.lblcost.Text,
												Conversions.ToString(num),
												Conversions.ToString(Conversion.Val(this.txtOLDprice.Text)),
												Conversions.ToString(num2),
												"0",
												"",
												Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
												Conversions.ToString(this.WholesalePriceByQty),
												this.discDESC,
												text3,
												num3.ToString(),
												dataRow["BatchNumber"].ToString(),
												dataRow["ExpiryDate"].ToString(),
												Conversions.ToString(num8),
												"",
												MyProject.Forms.Form1.OtherDetail,
												Conversions.ToString(this.CurrentIsVoucher),
												"",
												this.RowID.ToString()
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
					}
					bool flag29 = (MyProject.Forms.Form1.TillPointPriceChange == 1) & (MyProject.Forms.Form1.DiscountEditingAllowed == 1);
					if (flag29)
					{
						this.txtPriceChange.ReadOnly = false;
					}
					else
					{
						this.txtPriceChange.ReadOnly = true;
					}
					this.txtPriceChange.Text = "";
					this.discDESC = "";
					this.txtQty.ReadOnly = false;
					this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
					this.FixColours();
					this.CalcTotalSale();
					this.txtBarCode.Text = "0";
					this.txtQty.Text = Conversions.ToString(1);
					this.txtCoupons.Text = "";
					this.txtsearch.Text = "";
					this.txtBarCode.Text = "";
					this.txtPriceChange.Text = "";
					this.lblcode.Text = "";
					bool flag30 = this.selected_mode == 1;
					if (flag30)
					{
						this.radCorrect.Checked = true;
					}
					else
					{
						this.radTobeChanged.Checked = true;
					}
					bool flag31 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag31)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
				}
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0003D578 File Offset: 0x0003B778
		private void CalcTotalSale()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			decimal num3 = 0m;
			decimal num4 = 0m;
			decimal num5 = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["mode"].Value, 1, false);
					if (flag)
					{
						num4 = decimal.Add(num4, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
					}
					else
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["mode"].Value, 2, false);
						if (flag2)
						{
							num5 = decimal.Add(num5, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
						}
					}
					this.txtTotReturned.Text = Math.Round(num4, 2).ToString();
					this.txtTotReplaced.Text = Math.Round(num5, 2).ToString();
					num = decimal.Subtract(num5, num4);
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
			bool flag3 = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedPerc, 0m) != 0;
			if (flag3)
			{
				num3 = Math.Round(decimal.Multiply(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m), num), 5, MidpointRounding.AwayFromZero);
				ref string ptr = ref this.discDESC;
				this.discDESC = ptr + "Invoice Discount Approved by " + MyProject.Forms.Form1.Approvedby;
			}
			else
			{
				num3 = 0m;
			}
			num = decimal.Subtract(num, num3);
			this.txtTotal.Text = Conversions.ToString(Interaction.IIf(decimal.Compare(Math.Round(num, 2, MidpointRounding.AwayFromZero), 0m) < 0, decimal.Multiply(Math.Round(num, 2, MidpointRounding.AwayFromZero), -1m), Math.Round(num, 2, MidpointRounding.AwayFromZero)));
			bool flag4 = decimal.Compare(num, 0m) > 0;
			if (flag4)
			{
				this.txtTotal.BackColor = Color.Red;
				this.lblSummary.Text = "CUSTOMER MUST PAY: ";
			}
			else
			{
				bool flag5 = decimal.Compare(num, 0m) == 0;
				if (flag5)
				{
					this.txtTotal.BackColor = Color.White;
					this.lblSummary.Text = "DONT PAY OR GIVE: ";
				}
				else
				{
					bool flag6 = decimal.Compare(num, 0m) < 0;
					if (flag6)
					{
						this.txtTotal.BackColor = Color.Green;
						this.lblSummary.Text = "GIVE CUSTOMER: ";
					}
				}
			}
			this.txtTax.Text = Conversions.ToString(Math.Round(num2, 2, MidpointRounding.AwayFromZero));
			MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
			this.txtAmtPaid.Text = "";
			double num6 = Conversion.Val(this.txtAmtPaid.Text) - Conversion.Val(this.txtTotal.Text);
			this.txtChange.Text = num6.ToString("#,0.00");
			DataTable dataTable = this.pf.ConvertDatagridviewToDataTable(this.DataGridView1, false);
			DataTable dataTable2 = new DataTable();
			MyProject.Forms.Form1.salesdatagrid = dataTable2;
			MyProject.Forms.Form1.salesdatagrid = dataTable;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0003D940 File Offset: 0x0003BB40
		private void ChangeProductSold_Load(object sender, EventArgs e)
		{
			try
			{
				this.Panel2.Visible = true;
				this.LoadPayMeths();
				bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag)
				{
					this.txtsearch.Focus();
				}
				else
				{
					this.txtBarCode.Focus();
				}
				base.WindowState = FormWindowState.Maximized;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0003D9D8 File Offset: 0x0003BBD8
		private void FixColours()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["mode"].Value, 1, false);
					if (flag)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
					}
					else
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["mode"].Value, 2, false);
						if (flag2)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.LightGreen;
						}
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

		// Token: 0x0600065A RID: 1626 RVA: 0x0003DAAC File Offset: 0x0003BCAC
		private void GetPayMethDetails(int paymethid)
		{
			DataTable paymentMethodDetails = this.pf.GetPaymentMethodDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn);
			bool flag = paymentMethodDetails.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = paymentMethodDetails.Rows[0];
				this.mono_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				this.paymeth_fiscalgroup = Conversions.ToInteger(dataRow["FiscalGroup"]);
				this.paymeth_desc = Conversions.ToString(dataRow["PaymentMethodDesc"]);
				this.paymeth_currency = Conversions.ToString(dataRow["Currency"]);
				this.paymeth_requiresref = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["RequiresRef"])), false, RuntimeHelpers.GetObjectValue(dataRow["RequiresRef"])));
			}
			else
			{
				MessageBox.Show("Payment method details error. Please fix the payment methods.");
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0003DBA8 File Offset: 0x0003BDA8
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
			bool flag = Operators.CompareString(MyProject.Forms.Form1.ChangePaymentMethod, "", false) != 0;
			if (flag)
			{
				this.cboPayMeth.SelectedIndex = this.cboPayMeth.FindStringExact(MyProject.Forms.Form1.ChangePaymentMethod);
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
			}
			else
			{
				this.cboPayMeth.SelectedIndex = 0;
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0003DCD0 File Offset: 0x0003BED0
		private DataTable SearchDatatable(DataTable sdat, int prodtid, decimal qty)
		{
			DataTable dataTable = sdat.Clone();
			string text = "[productid]=" + prodtid.ToString() + " and quantity>=" + qty.ToString();
			DataRow[] array = sdat.Select(text);
			foreach (DataRow dataRow in array)
			{
				try
				{
					foreach (object obj in sdat.Rows)
					{
						DataRow dataRow2 = (DataRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow2["invoicenum"], dataRow["invoicenum"], false);
						if (flag)
						{
							dataTable.ImportRow(dataRow2);
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
			return dataTable;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0003DDC0 File Offset: 0x0003BFC0
		private void GetInvoice(int coid, string branch, int prodid, decimal qty, int trandate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select entryno,InvoiceNum, ref, productid,Quantity from Movement where trancode=3 and trandate=",
				Conversions.ToString(trandate),
				" and coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' and productid=",
				Conversions.ToString(prodid),
				" and quantity>=",
				Conversions.ToString(qty)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				int num = Conversions.ToInteger(dataRow["InvoiceNum"]);
				bool flag2 = (num != this.invnum) & (this.invnum != 0);
				if (flag2)
				{
					MessageBox.Show("Cannot return products from different invoices.");
					this.invnum = 0;
					this.inv_entyrno = 0;
				}
				else
				{
					this.invnum = num;
					this.inv_entyrno = Conversions.ToInteger(dataRow["entryno"]);
				}
			}
			else
			{
				this.invnum = 0;
				this.inv_entyrno = 0;
				MessageBox.Show("Product not sold today on the same invoice in that quantity. Cannot return.");
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0003DF12 File Offset: 0x0003C112
		private void Button2_Click(object sender, EventArgs e)
		{
			this.ProcessSale();
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0003DF1C File Offset: 0x0003C11C
		private void ConfirmSale()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			try
			{
				sqlConnection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.CommandType = CommandType.StoredProcedure;
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						decimal num = 0m;
						bool flag = MyProject.Forms.Form1.isRestaurant == 1;
						if (flag)
						{
						}
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["isvoucher"].Value, true, false);
						if (flag2)
						{
							MessageBox.Show("Voucher cannot be returned and replaced using this form.");
							sqlTransaction.Rollback();
							sqlConnection.Close();
							return;
						}
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "insertProductExchanged";
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
						sqlCommand.Parameters.AddWithValue("qty", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
						sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("tranmode", this.selected_mode);
						sqlCommand.Parameters.AddWithValue("trandesc", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.selected_mode == 1, "Product to be returned", "Product Issued to Exchange")));
						sqlCommand.Parameters.AddWithValue("invoicenumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["InvoiceNumber"].Value));
						sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
						sqlCommand.Parameters.AddWithValue("invnumentryno", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["InvoiceEntryNumber"].Value)));
						sqlCommand.Parameters.AddWithValue("@new_entryid", 0);
						int num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
						bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["mode"].Value, 1, false);
						if (flag3)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "UpdateSaleDetails";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("invnum", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["InvoiceNumber"].Value));
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
							sqlCommand.Parameters.AddWithValue("entryno", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["InvoiceEntryNumber"].Value));
							sqlCommand.Parameters.AddWithValue("qtyreturned", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["QTY"].Value));
							sqlCommand.ExecuteNonQuery();
						}
						else
						{
							bool flag4 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["mode"].Value, 2, false);
							if (flag4)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewSale2Warehouse3";
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
								sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["InvoiceNumber"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", this.customer_name);
								sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
								bool flag5 = MyProject.Forms.Form1.isRestaurant == 1;
								if (flag5)
								{
									sqlCommand.Parameters.AddWithValue("unitcost", num);
								}
								else
								{
									sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
								}
								sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), this.mono_rate));
								sqlCommand.Parameters.AddWithValue("paymentmethod", 1);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("trancode", 3);
								sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
								sqlCommand.Parameters.AddWithValue("TranTime", Conversions.ToInteger(DateAndTime.TimeOfDay.ToString("HHmm")));
								sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)) / Convert.ToDouble(this.mono_rate));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("shift", this.shift);
								sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)));
								sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
								sqlCommand.Parameters.AddWithValue("discountamount", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)), this.mono_rate));
								sqlCommand.Parameters.AddWithValue("consultant", "");
								sqlCommand.Parameters.AddWithValue("invdiscount", 0);
								string text = "";
								sqlCommand.Parameters.AddWithValue("collection", text);
								sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
								sqlCommand.Parameters.AddWithValue("otherdetail", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OtherDetail"].Value));
								bool flag6 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
								if (flag6)
								{
									sqlCommand.Parameters.AddWithValue("comments", Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataGridViewRow.Cells["comments"].Value, " "), num2.ToString()), " :"), MyProject.Forms.Form1.FiscalEltradeESDSerial), ": "), DateAndTime.Now.ToString()));
								}
								else
								{
									sqlCommand.Parameters.AddWithValue("comments", Operators.ConcatenateObject(Operators.ConcatenateObject(dataGridViewRow.Cells["comments"].Value, " "), num2.ToString()));
								}
								sqlCommand.Parameters.AddWithValue("paymethref", "");
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("donewhen", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
								sqlCommand.ExecuteNonQuery();
							}
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
				decimal num3 = Convert.ToDecimal(this.txtTotal.Text);
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandText = "InsertActualPaymentMethods";
				sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
				sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
				sqlCommand.Parameters.AddWithValue("paydesc", this.cboPayMeth.Text);
				sqlCommand.Parameters.AddWithValue("amt", num3);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
				sqlCommand.ExecuteNonQuery();
				sqlTransaction.Commit();
				sqlConnection.Close();
				this.PrintReceiptForExchange();
				MessageBox.Show("Product exchanged. Done. ");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error confirming sale. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		private DataTable GetProductIngridients(int coid, string branch, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulaIngridients";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("formulaname", this.GetProductFormulaName(productid, coid));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0003EB7C File Offset: 0x0003CD7C
		private string GetProductFormulaName(int productid, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulasTop1";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = dataRow["FormulaName"].ToString();
			}
			else
			{
				text = "0";
			}
			return text;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0003EC30 File Offset: 0x0003CE30
		private void ProcessSale()
		{
			try
			{
				bool flag = this.invnum == 0;
				if (flag)
				{
					MessageBox.Show("Invoice for product to be returned was not found under today's invoices. Cannot change product.");
				}
				else
				{
					bool flag2 = this.CheckIFPayMethACcurate();
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.AllowSalesonComputer == 1;
						if (flag3)
						{
							bool flag4 = this.DataGridView1.Rows.Count > 0;
							if (flag4)
							{
								Cursor.Current = Cursors.WaitCursor;
								this.ConfirmSale();
								Cursor.Current = Cursors.Default;
							}
							else
							{
								MessageBox.Show("Please select a product and press ENTER first.");
							}
						}
						else
						{
							MessageBox.Show("Sales are not allowed on this computer.");
							bool flag5 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
							if (flag5)
							{
								this.txtsearch.Focus();
							}
							else
							{
								this.txtBarCode.Focus();
							}
						}
					}
					else
					{
						MessageBox.Show("Check payment methods. Sale cannot proceed.");
					}
				}
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error performing sale. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0003ED60 File Offset: 0x0003CF60
		private bool CheckIFPayMethACcurate()
		{
			bool flag8;
			try
			{
				bool flag = Conversion.Val(this.txtTotal.Text) < 0.0;
				if (flag)
				{
					bool flag2 = Conversion.Val(this.txtAmtPaid.Text) > 0.0;
					if (flag2)
					{
						return false;
					}
				}
				bool flag3 = Conversion.Val(this.txtTotal.Text) > 0.0;
				if (flag3)
				{
					bool flag4 = (Convert.ToDouble(Conversion.Val(this.txtChange.Text)) < 0.0) | (Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) < Convert.ToDouble(Conversion.Val(this.txtTotal.Text)));
					if (flag4)
					{
						return false;
					}
				}
				bool flag5 = (this.paymeth_fiscalgroup == 1) | (this.paymeth_fiscalgroup == 2) | (this.paymeth_fiscalgroup == 3) | (this.paymeth_fiscalgroup == 4);
				if (flag5)
				{
					double num = Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text));
					double num2 = Convert.ToDouble(Conversion.Val(this.txtChange.Text));
					double num3 = Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) - Convert.ToDouble(Conversion.Val(this.txtChange.Text));
					double num4 = Convert.ToDouble(Conversion.Val(this.txtTotal.Text));
					bool flag6 = Math.Round(Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) - Convert.ToDouble(Conversion.Val(this.txtChange.Text)), 2, MidpointRounding.AwayFromZero) != Math.Round(Convert.ToDouble(Conversion.Val(this.txtTotal.Text)), 2, MidpointRounding.AwayFromZero);
					if (flag6)
					{
						return false;
					}
				}
				else
				{
					bool flag7 = Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) != Convert.ToDouble(Conversion.Val(this.txtTotal.Text));
					if (flag7)
					{
						MessageBox.Show("Change not allowed for payment method.");
						return false;
					}
				}
				flag8 = true;
			}
			catch (Exception ex)
			{
				flag8 = false;
			}
			return flag8;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0003EFB0 File Offset: 0x0003D1B0
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

		// Token: 0x06000665 RID: 1637 RVA: 0x0003F060 File Offset: 0x0003D260
		private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0003F0C8 File Offset: 0x0003D2C8
		private void txtAmtPaid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ProcessSale();
				e.Handled = true;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0003F0F8 File Offset: 0x0003D2F8
		private void txtAmtPaid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double num = Conversion.Val(this.txtAmtPaid.Text) - Conversion.Val(this.txtTotal.Text);
				this.txtChange.Text = num.ToString("#,0.00");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating change. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0003F17C File Offset: 0x0003D37C
		private void txtQty_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					bool flag2 = Conversion.Val(this.txtQty.Text) > 0.0;
					if (flag2)
					{
						this.AppendGrid();
					}
					else
					{
						MessageBox.Show("Please enter a quantity value.");
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0003F1F4 File Offset: 0x0003D3F4
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtAmtPaid.Text = "0";
				decimal num = this.mono_rate;
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
				this.lblpaymeth.Text = this.cboPayMeth.Text;
				bool flag = this.DataGridView1.Rows.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							DataTable prodtDetails = this.GetProdtDetails(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value));
							int count = prodtDetails.Rows.Count;
							int num2 = 0;
							bool flag2 = count > 0;
							if (flag2)
							{
								DataRow dataRow = prodtDetails.Rows[0];
								object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value);
								object objectValue2 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscPaymethod"].Value);
								object objectValue3 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value);
								decimal num3 = Conversions.ToDecimal(dataRow["TaxRate"]);
								bool flag3 = Operators.ConditionalCompareObjectNotEqual(objectValue3, 0, false);
								if (flag3)
								{
									bool flag4 = objectValue.ToString().Contains("Payment Method Discount");
									if (flag4)
									{
										dataGridViewRow.Cells["UnitPrice"].Value = Operators.AddObject(dataGridViewRow.Cells["UnitPrice"].Value, Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)) * -1.0);
										dataGridViewRow.Cells["DiscAmount2"].Value = 0;
									}
									else
									{
										num2 = 1;
									}
								}
								bool flag5 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Promstatus"].Value, 3, false);
								DataRow dataRow2;
								if (flag5)
								{
									dataRow2 = new DataTable
									{
										Columns = 
										{
											{
												"disc",
												typeof(decimal)
											},
											{
												"oldprice",
												typeof(decimal)
											},
											{
												"paymethod",
												typeof(int)
											}
										},
										Rows = { new object[] { 0, 0, 0 } }
									}.AsEnumerable().ElementAtOrDefault<DataRow>(0);
								}
								else
								{
									dataRow2 = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
								}
								bool flag6 = Operators.ConditionalCompareObjectNotEqual(dataRow2["disc"], 0, false);
								if (flag6)
								{
									this.PaymentMethodDiscountEffected = 1;
									dataGridViewRow.Cells["CouponNumber"].Value = 1;
									dataGridViewRow.Cells["OldPrice"].Value = RuntimeHelpers.GetObjectValue(dataRow2["oldprice"]);
									dataGridViewRow.Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
									decimal num4 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])));
									dataGridViewRow.Cells["UnitPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["DiscDetails"].Value = "Payment Method Discount";
									dataGridViewRow.Cells["DiscPaymethod"].Value = RuntimeHelpers.GetObjectValue(dataRow2["paymethod"]);
									bool flag7 = decimal.Compare(num3, 0m) != 0;
									if (flag7)
									{
										dataGridViewRow.Cells["Tax"].Value = Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, decimal.Add(1m, decimal.Divide(num3, 100m)));
									}
									else
									{
										dataGridViewRow.Cells["Tax"].Value = 0;
									}
									dataGridViewRow.Cells["UnitCost"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 2, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["Total"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
									{
										Operators.AddObject(Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, dataGridViewRow.Cells["Qty"].Value), dataGridViewRow.Cells["Tax"].Value),
										2,
										MidpointRounding.AwayFromZero
									}, null, null, null));
								}
								else
								{
									bool flag8 = num2 == 0;
									if (flag8)
									{
										dataGridViewRow.Cells["CouponNumber"].Value = 0;
										dataGridViewRow.Cells["DiscDetails"].Value = "";
									}
									bool flag9 = MyProject.Forms.Form1.CalcBackwards == 1;
									if (flag9)
									{
										object obj2 = dataRow["SellingPrice"];
										object obj3 = null;
										Type typeFromHandle = typeof(Math);
										string text = "Round";
										object[] array = new object[3];
										array[0] = Operators.MultiplyObject(Operators.DivideObject(dataRow["TaxRate"], 100), dataRow["SellingPrice"]);
										int num5 = 1;
										Form1 form = MyProject.Forms.Form1;
										ref int ptr = ref form.DecimalPlaces;
										array[num5] = form.DecimalPlaces;
										array[2] = MidpointRounding.AwayFromZero;
										object[] array2 = array;
										string[] array3 = null;
										Type[] array4 = null;
										bool[] array5 = new bool[3];
										array5[1] = true;
										bool[] array6 = array5;
										object obj4 = NewLateBinding.LateGet(obj3, typeFromHandle, text, array, array3, array4, array5);
										if (array6[1])
										{
											ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
										}
										decimal num6 = Conversions.ToDecimal(Operators.MultiplyObject(Operators.AddObject(obj2, obj4), this.mono_rate));
										decimal num7 = Conversions.ToDecimal(Operators.DivideObject(num6, Operators.AddObject(1, Operators.DivideObject(dataRow["TaxRate"], 100))));
										decimal num8 = Conversions.ToDecimal(Operators.MultiplyObject(decimal.Subtract(num6, num7), dataGridViewRow.Cells["Qty"].Value));
										dataGridViewRow.Cells["UnitPrice"].Value = Math.Round(num7, 4, MidpointRounding.AwayFromZero);
										dataGridViewRow.Cells["Tax"].Value = Math.Round(num8, 4, MidpointRounding.AwayFromZero);
									}
									else
									{
										decimal num6 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), dataRow2["disc"]));
										dataGridViewRow.Cells["UnitPrice"].Value = Math.Round(num6, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
										DataGridViewCell dataGridViewCell = dataGridViewRow.Cells["Tax"];
										object obj5 = null;
										Type typeFromHandle2 = typeof(Math);
										string text2 = "Round";
										object[] array7 = new object[3];
										array7[0] = Operators.MultiplyObject(decimal.Divide(num3, 100m), dataGridViewRow.Cells["UnitPrice"].Value);
										int num9 = 1;
										Form1 form2 = MyProject.Forms.Form1;
										ref int ptr = ref form2.DecimalPlaces;
										array7[num9] = form2.DecimalPlaces;
										array7[2] = MidpointRounding.AwayFromZero;
										object[] array2 = array7;
										string[] array8 = null;
										Type[] array9 = null;
										bool[] array10 = new bool[3];
										array10[1] = true;
										bool[] array6 = array10;
										object obj4 = NewLateBinding.LateGet(obj5, typeFromHandle2, text2, array7, array8, array9, array10);
										if (array6[1])
										{
											ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
										}
										dataGridViewCell.Value = Operators.MultiplyObject(obj4, dataGridViewRow.Cells["Qty"].Value);
									}
									dataGridViewRow.Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 2, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["OldPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["UnitCost"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
									bool flag10 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
									decimal num10;
									if (flag10)
									{
										num10 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
										{
											Operators.AddObject(dataGridViewRow.Cells["UnitPrice"].Value, Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, decimal.Divide(num3, 100m))),
											2,
											MidpointRounding.AwayFromZero
										}, null, null, null));
									}
									else
									{
										object obj6 = null;
										Type typeFromHandle3 = typeof(Math);
										string text3 = "Round";
										object[] array11 = new object[3];
										array11[0] = Operators.AddObject(Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, dataGridViewRow.Cells["Qty"].Value), dataGridViewRow.Cells["Tax"].Value);
										int num11 = 1;
										Form1 form3 = MyProject.Forms.Form1;
										ref int ptr = ref form3.DecimalPlaces;
										array11[num11] = form3.DecimalPlaces;
										array11[2] = MidpointRounding.AwayFromZero;
										object[] array2 = array11;
										string[] array12 = null;
										Type[] array13 = null;
										bool[] array14 = new bool[3];
										array14[1] = true;
										bool[] array6 = array14;
										object obj4 = NewLateBinding.LateGet(obj6, typeFromHandle3, text3, array11, array12, array13, array14);
										if (array6[1])
										{
											ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
										}
										num10 = Conversions.ToDecimal(obj4);
									}
									dataGridViewRow.Cells["Total"].Value = num10;
								}
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
					this.CalcTotalSale();
					this.txtAmtPaid.Text = "0";
				}
				bool flag11 = Operators.CompareString(this.txtBarCode.Text, "", false) == 0;
				if (flag11)
				{
					this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
				}
				else
				{
					this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0003FF1C File Offset: 0x0003E11C
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				try
				{
					this.lblerror.Text = "";
					this.txtPrice.Text = Conversions.ToString(0);
					this.txtQty.Text = Conversions.ToString(1);
					this.txtDesc.Text = "No product matches your search.";
					this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bar code error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		private DataTable GetProdtDetails(int coid, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00040078 File Offset: 0x0003E278
		private void SearchProductCode(string prodtcode)
		{
			this.WholesalePriceByQty = 0;
			this.txtPriceChange.Text = "";
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
						this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
						this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
						int num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
						DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataRow["ProductID"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag4 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
						if (flag4)
						{
							this.txtCoupons.Text = "1";
							this.txtOLDprice.Text = Conversions.ToString(productPayMethodDiscount["oldprice"]);
							this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount["paymethod"]);
							this.discAmount = Conversions.ToDecimal(productPayMethodDiscount["disc"]);
							this.cboPayMeth.Enabled = false;
							this.PaymentMethodDiscountEffected = 1;
						}
						else
						{
							this.txtCoupons.Text = "";
							this.discAmount = 0m;
						}
						bool flag5 = num3 == 0;
						decimal num5;
						decimal num6;
						if (flag5)
						{
							bool flag6 = MyProject.Forms.Form1.CalcBackwards == 1;
							if (flag6)
							{
								object obj = dataRow["SellingPrice"];
								object obj2 = null;
								Type typeFromHandle = typeof(Math);
								string text = "Round";
								object[] array = new object[3];
								array[0] = Operators.MultiplyObject(Operators.DivideObject(dataRow["TaxRate"], 100), dataRow["SellingPrice"]);
								int num4 = 1;
								Form1 form = MyProject.Forms.Form1;
								ref int ptr = ref form.DecimalPlaces;
								array[num4] = form.DecimalPlaces;
								array[2] = MidpointRounding.AwayFromZero;
								object[] array2 = array;
								string[] array3 = null;
								Type[] array4 = null;
								bool[] array5 = new bool[3];
								array5[1] = true;
								bool[] array6 = array5;
								object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text, array, array3, array4, array5);
								if (array6[1])
								{
									ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
								}
								num5 = Conversions.ToDecimal(Operators.MultiplyObject(Operators.AddObject(obj, obj3), this.mono_rate));
							}
							else
							{
								num5 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), productPayMethodDiscount["disc"]));
							}
							num6 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
							this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
							this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["specialprice"]))));
						}
						else
						{
							DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
							num5 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate), productPayMethodDiscount["disc"]));
							num6 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
							this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"]))));
							this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
						}
						decimal num7 = 0m;
						bool flag7 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
						if (flag7)
						{
							num7 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							bool flag8 = MyProject.Forms.Form1.CalcBackwards == 1;
							decimal num8;
							if (flag8)
							{
								this.priceb4tax = Conversions.ToDecimal(Operators.DivideObject(num5, Operators.AddObject(1, dataRow["TaxRate"])));
								num8 = Math.Round(num5, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
							}
							else
							{
								this.priceb4tax = num5;
								num8 = decimal.Add(num5, Math.Round(decimal.Multiply(decimal.Divide(num7, 100m), num5), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
							}
							this.priceb4tax = this.priceb4tax;
							num8 = num8;
							this.priceb4taxWholesale = num6;
							this.priceb4taxWholesale = this.priceb4taxWholesale;
							this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							this.totpriceWholesale = decimal.Add(num6, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num6));
							this.totpriceWholesale = this.totpriceWholesale;
							bool flag9 = MyProject.Forms.Form1.IsWholesaleShop == 1;
							if (flag9)
							{
								this.txtPrice.Text = Math.Round(this.totpriceWholesale, 8, MidpointRounding.AwayFromZero).ToString();
							}
							else
							{
								this.txtPrice.Text = Math.Round(num8, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
							}
						}
						else
						{
							num7 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							this.priceb4tax = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num7, 100m))), 5, MidpointRounding.AwayFromZero);
							this.currenttaxrate = num7;
							decimal num9 = num5;
							num9 = num9;
							this.priceb4taxWholesale = Math.Round(decimal.Divide(num6, decimal.Add(1m, decimal.Divide(num7, 100m))), 5, MidpointRounding.AwayFromZero);
							this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							this.totpriceWholesale = num6;
							bool flag10 = MyProject.Forms.Form1.IsWholesaleShop == 1;
							if (flag10)
							{
								this.txtPrice.Text = this.totpriceWholesale.ToString();
							}
							else
							{
								this.txtPrice.Text = num9.ToString();
							}
						}
						this.lblcost.Text = Conversions.ToString(Operators.MultiplyObject(dataRow["Cost"], this.mono_rate));
						this.lbltax.Text = Math.Round(num7, 5, MidpointRounding.AwayFromZero).ToString();
						this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
						this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
						this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
						this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
						bool flag11 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.currentExpires;
						if (flag11)
						{
							this.txtQty.Visible = false;
							this.Label4.Visible = false;
							this.Button1.Text = "SELECT";
						}
						else
						{
							bool flag12 = MyProject.Forms.Form1.usingBarcodePrintingScale == 1;
							if (flag12)
							{
								this.Label4.Visible = true;
								this.Button1.Text = "Enter";
							}
							else
							{
								this.txtQty.Visible = true;
								this.txtQty.Text = Conversions.ToString(1);
								this.Label4.Visible = true;
								this.Button1.Text = "Enter";
							}
						}
						this.currentUOM = dataRow["UOM"].ToString();
						bool flag13 = Operators.CompareString(this.txtBarCode.Text, "1", false) == 0;
						if (flag13)
						{
							this.txtPrice.Focus();
						}
						else
						{
							this.AppendGrid();
						}
					}
				}
				else
				{
					this.txtSearchProductCode.Text = "";
					bool flag14 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag14)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
						this.txtBarCode.Focus();
					}
				}
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00040C8C File Offset: 0x0003EE8C
		private void PrintReceiptForExchange()
		{
			bool flag = MyProject.Forms.Form1.ReceiptsOptional == 1;
			int i;
			if (flag)
			{
				try
				{
					PrintReceipts printReceipts = new PrintReceipts();
					bool flag2 = printReceipts.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						bool printRec = printReceipts.printRec;
						if (printRec)
						{
							i = printReceipts.printNum;
						}
						else
						{
							this.TextToPrint = "";
							this.stringToRead = new StringReader(this.TextToPrint);
							try
							{
								StandardPrintController standardPrintController = new StandardPrintController();
								this.PrintDocument1.PrintController = standardPrintController;
								this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
								this.PrintDocument1.Print();
							}
							finally
							{
								this.stringToRead.Close();
							}
							i = 0;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Keypad error. Details: " + ex.Message);
				}
			}
			else
			{
				i = MyProject.Forms.Form1.NumOfReceiptsPrint;
			}
			checked
			{
				while (i > 0)
				{
					bool flag3 = MyProject.Forms.Form1.ReceiptSize80 == 1;
					if (flag3)
					{
						this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter);
					}
					else
					{
						bool flag4 = MyProject.Forms.Form1.ReceiptSize80 == 0;
						if (flag4)
						{
							this.PrintReceipt58(this.invnum);
						}
					}
					i--;
				}
				bool flag5 = Operators.CompareString(MyProject.Forms.Form1.defaultSecondaryPrinter, "", false) != 0;
				if (flag5)
				{
					this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultSecondaryPrinter);
				}
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00040E6C File Offset: 0x0003F06C
		private void PrintReceipt(int invnumber, string revmaxdigital_signature, string printername)
		{
			this.PrintHeader();
			this.ItemsToBePrinted(invnumber);
			this.PrintFooter(revmaxdigital_signature);
			this.stringToRead = new StringReader(this.TextToPrint);
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = printername;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			finally
			{
				this.stringToRead.Close();
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00040EF8 File Offset: 0x0003F0F8
		private void PrintReceipt58(int invnumber)
		{
			this.PrintHeader58();
			this.ItemsToBePrinted58(invnumber);
			this.PrintFooter58();
			StandardPrintController standardPrintController = new StandardPrintController();
			this.PrintDocument1.PrintController = standardPrintController;
			this.PrintDocument1.Print();
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00040F3C File Offset: 0x0003F13C
		public void PrintHeader()
		{
			this.TextToPrint = "";
			bool flag = MyProject.Forms.Form1.PrintFiscal == 1;
			string text;
			if (flag)
			{
				text = "FISCAL TAX INVOICE";
			}
			else
			{
				text = "INVOICE";
			}
			int num = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				text = this.coname;
				num = text.Length;
				string text3 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				bool flag2 = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag2)
				{
					text = "BP Number: " + this.cobpnum;
					num = text.Length;
					string text4 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text4 + text + Environment.NewLine;
				}
				bool flag3 = Operators.CompareString(this.coVATNum, "", false) != 0;
				if (flag3)
				{
					text = "VAT Number: " + this.coVATNum;
					num = text.Length;
					string text5 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text + Environment.NewLine;
				}
				text = this.coadd;
				num = text.Length;
				string text6 = "";
				bool flag4 = num > 70;
				if (!flag4)
				{
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(70 - num) / 2.0)));
					text6 = text7;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					text6,
					text,
					text6,
					Environment.NewLine
				});
				bool flag5 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag5)
				{
					text = "Email: " + this.coemail;
					num = text.Length;
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text + Environment.NewLine;
				}
				bool flag6 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag6)
				{
					text = this.cotel;
					num = text.Length;
					string text9 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text + Environment.NewLine;
				}
				bool flag7 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag7)
				{
					text = this.cotel2 + "  " + this.cotel3;
					num = text.Length;
					string text10 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text10 + text + Environment.NewLine;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				text = "Teller: " + MyProject.Forms.Form1.username;
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00041368 File Offset: 0x0003F568
		public void PrintHeader58()
		{
			this.TextToPrint = "";
			string text = this.coname;
			int num = text.Length;
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			text = this.coadd;
			num = text.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			text = this.cotel;
			num = text.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			bool flag = Operators.CompareString(this.coemail, "", false) != 0;
			if (flag)
			{
				text = "Email: " + this.coemail;
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			bool flag2 = Operators.CompareString(this.cotel, "", false) != 0;
			if (flag2)
			{
				text = this.cotel;
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			bool flag3 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
			if (flag3)
			{
				text = this.cotel2 + " , " + this.cotel3;
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			text = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
			num = text.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			text = "Teller: " + MyProject.Forms.Form1.username;
			num = text.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00041570 File Offset: 0x0003F770
		public void ItemsToBePrinted(int invnumber)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Invoice Number:" + Conversions.ToString(invnumber);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag = Operators.CompareString(this.customer_name, "Cash", false) != 0;
			if (flag)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + this.customer_name;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Details:";
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description - " + this.paymeth_currency + Environment.NewLine;
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag2 = num2 > 0;
			checked
			{
				if (flag2)
				{
					int num3 = 0;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							num3++;
							bool flag3 = decimal.Compare(Conversions.ToDecimal(dataRow["Unit_Selling_Price"]), 0m) != 0;
							if (flag3)
							{
								string text = Conversions.ToString(dataRow["Description"]);
								string text2 = Conversions.ToString(dataRow["UOM"]);
								bool flag4 = Operators.CompareString(text2, "EA", false) == 0;
								if (flag4)
								{
									object obj2 = null;
									Type typeFromHandle = typeof(Math);
									string text3 = "Round";
									DataRow dataRow2;
									object[] array2;
									object[] array = (array2 = new object[]
									{
										(dataRow2 = dataRow)["Quantity"],
										0
									});
									string[] array3 = null;
									Type[] array4 = null;
									bool[] array5 = new bool[2];
									array5[0] = true;
									bool[] array6 = array5;
									object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text3, array, array3, array4, array5);
									if (array6[0])
									{
										dataRow2["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
									}
									num = Conversions.ToDecimal(obj3);
								}
								else
								{
									num = Conversions.ToDecimal(dataRow["Quantity"]);
								}
								double num4 = Conversions.ToDouble(dataRow["Unit_Selling_Price"]);
								double num5 = Conversions.ToDouble(dataRow["Sub_Total"]);
								string text4 = Conversions.ToString(dataRow["Product_Code"]);
								int num6 = (int)Math.Round(Conversion.Val(text.Length));
								bool flag5 = num6 >= 34;
								if (flag5)
								{
									text = text.Substring(0, 33);
								}
								else
								{
									int num7 = num6;
									int num8 = 34 - num7;
									text = text.PadRight(num8);
								}
								bool flag6 = num3 == 1;
								string text5;
								if (flag6)
								{
									text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["paymethref"], Environment.NewLine), Environment.NewLine));
								}
								int length = text.Length;
								bool flag7 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
								if (flag7)
								{
									DataTable productDetailsByBarCode = this.pf.GetProductDetailsByBarCode(dataRow["Product_Code"].ToString(), this._cnn);
									DataRow dataRow3 = productDetailsByBarCode.Rows[0];
									decimal num9 = Conversions.ToDecimal(dataRow3["TaxRate"]);
									bool flag8 = decimal.Compare(num9, 0m) > 0;
									if (flag8)
									{
										text = "T: " + text;
									}
									else
									{
										text = "E: " + text;
									}
								}
								bool flag9 = num3 != 1;
								if (flag9)
								{
									text5 = text;
								}
								else
								{
									text5 += text;
								}
								string text6 = Conversions.ToString(text5.Length);
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text5 + Environment.NewLine;
								decimal num10 = 0m;
								bool flag10 = MyProject.Forms.Form1.isRestaurant == 1;
								if (flag10)
								{
									bool flag11 = dataRow["Comments"].ToString().Length > 50;
									if (flag11)
									{
										text5 = dataRow["Comments"].ToString().Substring(0, 49) + Environment.NewLine;
										text5 = text5 + dataRow["Comments"].ToString().Substring(50, 50) + Environment.NewLine;
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text5;
									}
									else
									{
										bool flag12 = dataRow["Comments"].ToString().Length > 0;
										if (flag12)
										{
											text5 = Conversions.ToString(Operators.ConcatenateObject(dataRow["Comments"], Environment.NewLine));
											ptr = ref this.TextToPrint;
											this.TextToPrint = ptr + text5;
										}
									}
								}
								decimal num11 = new decimal(Math.Round(num4, 2, MidpointRounding.AwayFromZero));
								num10 = decimal.Multiply(num11, num);
								text5 = string.Concat(new string[]
								{
									"     ",
									num.ToString().PadRight(8, ' '),
									"X        ",
									Strings.Format(num11, "N2").PadLeft(12, ' '),
									Strings.Format(num10, "N2").PadLeft(32, ' ')
								});
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text5 + Environment.NewLine;
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
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00041C48 File Offset: 0x0003FE48
		public void ItemsToBePrinted58(int invnumber)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Invoice Number:" + Conversions.ToString(invnumber);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag = Operators.CompareString(this.customer_name, "Cash", false) != 0;
			if (flag)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + this.customer_name;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Details:";
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag2 = num > 0;
			if (flag2)
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						string text = Conversions.ToString(dataRow["Description"]);
						int num2 = Conversions.ToInteger(dataRow["Quantity"]);
						double num3 = Conversions.ToDouble(dataRow["Unit_Selling_Price"]);
						double num4 = Conversions.ToDouble(dataRow["Sub_Total"]);
						string text2 = Conversions.ToString(dataRow["Product_Code"]);
						string text3;
						checked
						{
							int num5 = (int)Math.Round(Conversion.Val(text.Length));
							bool flag3 = num5 >= 20;
							if (flag3)
							{
								text = text.Substring(0, 19);
							}
							else
							{
								int num6 = num5;
								int num7 = 20 - num6;
								text = text.PadRight(num7);
							}
							int length = text.Length;
							text3 = text;
							string text4 = Conversions.ToString(text3.Length);
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text3 + Environment.NewLine;
						}
						decimal num8 = new decimal(num3 * (double)num2);
						text3 = string.Concat(new string[]
						{
							"     ",
							num2.ToString(),
							"   X        ",
							Strings.FormatCurrency(num3.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
							"            ",
							Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
						});
						string text5 = Conversions.ToString(text3.Length);
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

		// Token: 0x06000674 RID: 1652 RVA: 0x0004206C File Offset: 0x0004026C
		private void PrintFooter(string RevmaxDigital_Signature)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			string text = "Tax         " + Strings.Format(Conversion.Val(this.txtTax.Text), "N2");
			string text2 = Conversions.ToString(text.Length);
			int length = text.Length;
			double num2;
			bool flag4;
			checked
			{
				string text3 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag = Operators.CompareString(text, "Tax          0.00", false) != 0;
				if (flag)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				}
				bool flag2 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
				if (flag2)
				{
					decimal num = decimal.Multiply(Convert.ToDecimal(this.txtTotal.Text), this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn));
					text = "Total       " + Strings.Format(num, "N2").PadLeft(18, '\0');
				}
				else
				{
					text = "Total       " + Strings.Format(Conversion.Val(this.txtTotal.Text), "N2").PadLeft(18, ' ');
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
				bool flag3 = Operators.CompareString(this.txtAmtPaid.Text, "", false) == 0;
				if (flag3)
				{
					num2 = 0.0;
				}
				else
				{
					num2 = Conversion.Val(this.txtAmtPaid.Text);
				}
				flag4 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
			}
			if (flag4)
			{
				num2 *= Convert.ToDouble(this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn));
			}
			text = "Paid        " + Strings.Format(num2, "N2").PadLeft(18, ' ');
			text2 = Conversions.ToString(length);
			checked
			{
				string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag5 = Operators.CompareString(text, "Cash        $0.00", false) != 0;
				if (flag5)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text + Environment.NewLine;
				}
				text = "Change: " + Strings.Format(Conversion.Val(this.txtChange.Text), "N2").PadLeft(20, ' ');
				text2 = Conversions.ToString(length);
				string text6 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					Environment.NewLine,
					text6,
					text,
					Environment.NewLine
				});
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = "Customer:" + this.customer_name;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag6 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag6)
				{
					string text7 = "COD";
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					text = "Payment Method:" + text7;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
					text = this.cboPayMeth.Text + ": " + Strings.Format(Conversion.Val(this.txtAmtPaid.Text), "N2");
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
				}
				text = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				bool flag7 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1) & (MyProject.Forms.Form1.PrintReceipt == 1);
				if (flag7)
				{
					text = "";
					int length2 = RevmaxDigital_Signature.Length;
					for (int i = 0; i <= length2; i += 50)
					{
						int num3 = length2 - i;
						bool flag8 = num3 > 50;
						if (flag8)
						{
							num3 = 50;
						}
						text = text + RevmaxDigital_Signature.Substring(i, num3) + Environment.NewLine;
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				}
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000425E4 File Offset: 0x000407E4
		private void PrintFooter58()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			string text = "Tax         " + Strings.FormatCurrency(this.txtTax.Text, -1, TriState.UseDefault, TriState.True, TriState.True);
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
				text = "Total       " + Strings.FormatCurrency(this.txtTotal.Text, -1, TriState.UseDefault, TriState.True, TriState.True);
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
				bool flag2 = Operators.CompareString(this.txtAmtPaid.Text, "", false) == 0;
				double num;
				if (flag2)
				{
					num = 0.0;
				}
				else
				{
					num = Conversion.Val(this.txtAmtPaid.Text);
				}
				text = "Paid        " + Strings.FormatCurrency(num, -1, TriState.UseDefault, TriState.True, TriState.True);
				text2 = Conversions.ToString(length);
				string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag3 = Operators.CompareString(text, "Cash        $0.00", false) != 0;
				if (flag3)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text + Environment.NewLine;
				}
				text = "Change: " + Strings.FormatCurrency(this.txtChange.Text, -1, TriState.UseDefault, TriState.True, TriState.True);
				text2 = Conversions.ToString(length);
				string text6 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					Environment.NewLine,
					text6,
					text,
					Environment.NewLine
				});
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = "Customer:" + this.customer_name;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				string text7 = "COD";
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = "Payment Method:" + text7;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = this.cboPayMeth.Text + ": " + this.txtTotal.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				bool flag4 = Operators.CompareString(MyProject.Forms.Form1.ReceiptFootnote, "", false) != 0;
				if (flag4)
				{
					text = MyProject.Forms.Form1.ReceiptFootnote;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00042978 File Offset: 0x00040B78
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			Font font = new Font("Times New Roman", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			checked
			{
				int num7 = (int)Math.Round(Math.Round((double)num3 / 1.0));
				Rectangle rectangle = new Rectangle(num5, num6, num4, num3);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				int num8 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				while (i < num8)
				{
					text = this.stringToRead.ReadLine();
					bool flag = text == null;
					if (flag)
					{
						break;
					}
					float num9 = unchecked(num2 + (float)i * font.GetHeight(e.Graphics));
					e.Graphics.DrawString(text, font, Brushes.Black, num, num9, new StringFormat());
					i++;
				}
				bool flag2 = text == null;
				if (flag2)
				{
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
				}
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00042ACC File Offset: 0x00040CCC
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00042AF4 File Offset: 0x00040CF4
		private void Export(LocalReport report)
		{
			string text = "<DeviceInfo><OutputFormat>EMF</OutputFormat><PageWidth>8.5in</PageWidth><PageHeight>11in</PageHeight><MarginTop>0.25in</MarginTop><MarginLeft>0.25in</MarginLeft><MarginRight>0.25in</MarginRight><MarginBottom>0.25in</MarginBottom></DeviceInfo>";
			this.m_streams = new List<Stream>();
			Warning[] array;
			report.Render("Image", text, new CreateStreamCallback(this.CreateStream), out array);
			try
			{
				foreach (Stream stream in this.m_streams)
				{
					stream.Position = 0L;
				}
			}
			finally
			{
				IEnumerator<Stream> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00042B78 File Offset: 0x00040D78
		private void PrintPage(object sender, PrintPageEventArgs ev)
		{
			Metafile metafile = new Metafile(this.m_streams[this.m_currentPageIndex]);
			checked
			{
				Rectangle rectangle = new Rectangle(ev.PageBounds.Left - (int)Math.Round((double)ev.PageSettings.HardMarginX), ev.PageBounds.Top - (int)Math.Round((double)ev.PageSettings.HardMarginY), ev.PageBounds.Width, ev.PageBounds.Height);
				ev.Graphics.FillRectangle(Brushes.White, rectangle);
				ev.Graphics.DrawImage(metafile, rectangle);
				ref int ptr = ref this.m_currentPageIndex;
				this.m_currentPageIndex = ptr + 1;
				ev.HasMorePages = this.m_currentPageIndex < this.m_streams.Count;
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00042C4C File Offset: 0x00040E4C
		private void Print()
		{
			bool flag = this.m_streams == null || this.m_streams.Count == 0;
			if (flag)
			{
				throw new Exception("Error: no stream to print.");
			}
			PrintDocument printDocument = new PrintDocument();
			bool flag2 = !printDocument.PrinterSettings.IsValid;
			if (flag2)
			{
				throw new Exception("Error: cannot find the default printer.");
			}
			printDocument.PrintPage += this.PrintPage;
			this.m_currentPageIndex = 0;
			printDocument.Print();
		}

		// Token: 0x040002D6 RID: 726
		private int selected_mode;

		// Token: 0x040002D7 RID: 727
		private string _cnn;

		// Token: 0x040002D8 RID: 728
		private decimal priceb4tax;

		// Token: 0x040002D9 RID: 729
		private decimal priceb4taxWholesale;

		// Token: 0x040002DA RID: 730
		private decimal currentWholesaleQty;

		// Token: 0x040002DB RID: 731
		private decimal taxdueWholesale;

		// Token: 0x040002DC RID: 732
		private decimal totpriceWholesale;

		// Token: 0x040002DD RID: 733
		private int WholesalePriceByQty;

		// Token: 0x040002DE RID: 734
		private decimal specialprice;

		// Token: 0x040002DF RID: 735
		private decimal currenttaxrate;

		// Token: 0x040002E0 RID: 736
		private decimal mono_rate;

		// Token: 0x040002E1 RID: 737
		private decimal discAmount;

		// Token: 0x040002E2 RID: 738
		private decimal discTeller;

		// Token: 0x040002E3 RID: 739
		private decimal discCoupons;

		// Token: 0x040002E4 RID: 740
		private decimal discPromotion;

		// Token: 0x040002E5 RID: 741
		private string discPromotionName;

		// Token: 0x040002E6 RID: 742
		private string discDESC;

		// Token: 0x040002E7 RID: 743
		private PublicFunctions pf;

		// Token: 0x040002E8 RID: 744
		private int CurrentID;

		// Token: 0x040002E9 RID: 745
		private string currentUOM;

		// Token: 0x040002EA RID: 746
		private string CurrentCode;

		// Token: 0x040002EB RID: 747
		private int PaymentMethodDiscountEffected;

		// Token: 0x040002EC RID: 748
		private int discPaymentMethod;

		// Token: 0x040002ED RID: 749
		private int RowID;

		// Token: 0x040002EE RID: 750
		private bool currentExpires;

		// Token: 0x040002EF RID: 751
		private bool CurrentIsVoucher;

		// Token: 0x040002F0 RID: 752
		private int invnum;

		// Token: 0x040002F1 RID: 753
		private int inv_entyrno;

		// Token: 0x040002F2 RID: 754
		private string customer_name;

		// Token: 0x040002F3 RID: 755
		public string shift;

		// Token: 0x040002F4 RID: 756
		private int paymeth_fiscalgroup;

		// Token: 0x040002F5 RID: 757
		private string paymeth_desc;

		// Token: 0x040002F6 RID: 758
		private string paymeth_currency;

		// Token: 0x040002F7 RID: 759
		private bool paymeth_requiresref;

		// Token: 0x040002F8 RID: 760
		private int m_currentPageIndex;

		// Token: 0x040002F9 RID: 761
		private IList<Stream> m_streams;

		// Token: 0x040002FA RID: 762
		private string TextToPrint;

		// Token: 0x040002FB RID: 763
		private string coname;

		// Token: 0x040002FC RID: 764
		private string coadd;

		// Token: 0x040002FD RID: 765
		private string cotel;

		// Token: 0x040002FE RID: 766
		private string coemail;

		// Token: 0x040002FF RID: 767
		private string cobpnum;

		// Token: 0x04000300 RID: 768
		private string footnote;

		// Token: 0x04000301 RID: 769
		private string cotel2;

		// Token: 0x04000302 RID: 770
		private string cotel3;

		// Token: 0x04000303 RID: 771
		private string coVATNum;

		// Token: 0x04000304 RID: 772
		private StringReader stringToRead;
	}
}
