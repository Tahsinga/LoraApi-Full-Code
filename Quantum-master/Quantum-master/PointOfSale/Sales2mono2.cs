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
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BarcodeRender;
using EltradeFPAx;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using PointOfSale.My;
using QRCoder;
using Zen.Barcode;

namespace PointOfSale
{
	// Token: 0x0200018C RID: 396
	[DesignerGenerated]
	public partial class Sales2mono2 : UserControl
	{
		// Token: 0x06003ECE RID: 16078 RVA: 0x0023BF74 File Offset: 0x0023A174
		public Sales2mono2()
		{
			base.Load += this.Sales_c;
			base.Disposed += this.Sales2mono_Disposed;
			base.LocationChanged += this.Sales2mono_LocationChanged;
			base.Invalidated += this.Sales2mono_Invalidated;
			base.Enter += this.Sales2mono_Enter;
			base.Leave += this.Sales2mono_Leave;
			base.DockChanged += this.Sales2mono2_DockChanged;
			this.altdescription = "";
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.TextToPrint = "";
			this.website_og = "";
			this.website_comment = "";
			this.datCustomers = new DataTable();
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.specialprice = 0m;
			this.currenttaxrate = 0m;
			this.mono_rate = 0m;
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
			this.discPaymentMethod = 0;
			this.isInvoiceDisc = 0;
			this.discAmount = 0m;
			this.discTeller = 0m;
			this.discCoupons = 0m;
			this.discPromotion = 0m;
			this.discPromotionName = "";
			this.discDESC = "";
			this.currentUOM = "";
			this.currentExpires = false;
			this.currentIsDeposit = 0;
			this.datProm = new DataTable();
			this.PaymentMethodDiscountEffected = 0;
			this.isunedingstock = false;
			this.currentCustomerEntryNo = 0;
			this.currentCustomerLimit = 0m;
			this.RowID = 0;
			this.saledone = false;
			this.currentIsCalcLxW = false;
			this.currParentCaseID = 0;
			this.currCaseQty = 0;
			this.currBreak = 0;
			this.BreakQtyActual = 0;
			this.currQuotationNumber = 0;
			this.LINE = "_________________________________________________________________________";
			this.current_taxexempt = 0;
			this.currCustomerGroup = "";
			this.ProdtDiscTotal = 0m;
			this.DepositBarCode = "";
			this.DepositUsed = false;
			this.DepAmount = 0m;
			this.DisableEditing = false;
			this.@ref = "";
			this.dat_additionalsettings = new DataTable();
			this.DTpromos = new DataTable();
			this.pf2 = new PublicFunctions2();
			this.isLxW = 0;
			this.CurrentRecordSerial = false;
			this.PriceBeforeTax = 0m;
			this.currentIsEditable = false;
			this.txtNumeric = new DataGridViewTextBoxEditingControl();
			this.InitializeComponent();
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06003ED1 RID: 16081 RVA: 0x00243DD2 File Offset: 0x00241FD2
		// (set) Token: 0x06003ED2 RID: 16082 RVA: 0x00243DDC File Offset: 0x00241FDC
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06003ED3 RID: 16083 RVA: 0x00243DE5 File Offset: 0x00241FE5
		// (set) Token: 0x06003ED4 RID: 16084 RVA: 0x00243DF0 File Offset: 0x00241FF0
		internal virtual Label lblcost
		{
			[CompilerGenerated]
			get
			{
				return this._lblcost;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lblcost_Click);
				Label label = this._lblcost;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._lblcost = value;
				label = this._lblcost;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06003ED5 RID: 16085 RVA: 0x00243E33 File Offset: 0x00242033
		// (set) Token: 0x06003ED6 RID: 16086 RVA: 0x00243E40 File Offset: 0x00242040
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

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06003ED7 RID: 16087 RVA: 0x00243E83 File Offset: 0x00242083
		// (set) Token: 0x06003ED8 RID: 16088 RVA: 0x00243E8D File Offset: 0x0024208D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06003ED9 RID: 16089 RVA: 0x00243E96 File Offset: 0x00242096
		// (set) Token: 0x06003EDA RID: 16090 RVA: 0x00243EA0 File Offset: 0x002420A0
		internal virtual TextBox txtPrice
		{
			[CompilerGenerated]
			get
			{
				return this._txtPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPrice_KeyDown);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPrice_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtPrice_TextChanged);
				EventHandler eventHandler2 = new EventHandler(this.txtPrice_Leave);
				TextBox textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
					textBox.Leave -= eventHandler2;
				}
				this._txtPrice = value;
				textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
					textBox.Leave += eventHandler2;
				}
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x00243F40 File Offset: 0x00242140
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x00243F4A File Offset: 0x0024214A
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x00243F53 File Offset: 0x00242153
		// (set) Token: 0x06003EDE RID: 16094 RVA: 0x00243F60 File Offset: 0x00242160
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
				EventHandler eventHandler = new EventHandler(this.txtQty_TextChanged);
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.txtQty_Validating);
				TextBox textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.TextChanged -= eventHandler;
					textBox.Validating -= cancelEventHandler;
				}
				this._txtQty = value;
				textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.TextChanged += eventHandler;
					textBox.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x00244000 File Offset: 0x00242200
		// (set) Token: 0x06003EE0 RID: 16096 RVA: 0x0024400A File Offset: 0x0024220A
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06003EE1 RID: 16097 RVA: 0x00244013 File Offset: 0x00242213
		// (set) Token: 0x06003EE2 RID: 16098 RVA: 0x0024401D File Offset: 0x0024221D
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06003EE3 RID: 16099 RVA: 0x00244026 File Offset: 0x00242226
		// (set) Token: 0x06003EE4 RID: 16100 RVA: 0x00244030 File Offset: 0x00242230
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06003EE5 RID: 16101 RVA: 0x00244039 File Offset: 0x00242239
		// (set) Token: 0x06003EE6 RID: 16102 RVA: 0x00244043 File Offset: 0x00242243
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x0024404C File Offset: 0x0024224C
		// (set) Token: 0x06003EE8 RID: 16104 RVA: 0x00244056 File Offset: 0x00242256
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x0024405F File Offset: 0x0024225F
		// (set) Token: 0x06003EEA RID: 16106 RVA: 0x00244069 File Offset: 0x00242269
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06003EEB RID: 16107 RVA: 0x00244072 File Offset: 0x00242272
		// (set) Token: 0x06003EEC RID: 16108 RVA: 0x0024407C File Offset: 0x0024227C
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

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06003EED RID: 16109 RVA: 0x002440BF File Offset: 0x002422BF
		// (set) Token: 0x06003EEE RID: 16110 RVA: 0x002440C9 File Offset: 0x002422C9
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x002440D2 File Offset: 0x002422D2
		// (set) Token: 0x06003EF0 RID: 16112 RVA: 0x002440DC File Offset: 0x002422DC
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x002440E5 File Offset: 0x002422E5
		// (set) Token: 0x06003EF2 RID: 16114 RVA: 0x002440EF File Offset: 0x002422EF
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06003EF3 RID: 16115 RVA: 0x002440F8 File Offset: 0x002422F8
		// (set) Token: 0x06003EF4 RID: 16116 RVA: 0x00244102 File Offset: 0x00242302
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x0024410B File Offset: 0x0024230B
		// (set) Token: 0x06003EF6 RID: 16118 RVA: 0x00244118 File Offset: 0x00242318
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
				DataGridViewCellEventHandler dataGridViewCellEventHandler3 = new DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.DataGridView1_EditingControlShowing);
				DataGridViewRowCancelEventHandler dataGridViewRowCancelEventHandler = new DataGridViewRowCancelEventHandler(this.DataGridView1_UserDeletingRow);
				DataGridViewCellCancelEventHandler dataGridViewCellCancelEventHandler = new DataGridViewCellCancelEventHandler(this.DataGridView1_CellBeginEdit);
				EventHandler eventHandler = new EventHandler(this.DataGridView1_SelectionChanged);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow -= dataGridViewRowEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler2;
					dataGridView.CellEnter -= dataGridViewCellEventHandler3;
					dataGridView.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
					dataGridView.UserDeletingRow -= dataGridViewRowCancelEventHandler;
					dataGridView.CellBeginEdit -= dataGridViewCellCancelEventHandler;
					dataGridView.SelectionChanged -= eventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow += dataGridViewRowEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
					dataGridView.CellEndEdit += dataGridViewCellEventHandler2;
					dataGridView.CellEnter += dataGridViewCellEventHandler3;
					dataGridView.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
					dataGridView.UserDeletingRow += dataGridViewRowCancelEventHandler;
					dataGridView.CellBeginEdit += dataGridViewCellCancelEventHandler;
					dataGridView.SelectionChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x00244238 File Offset: 0x00242438
		// (set) Token: 0x06003EF8 RID: 16120 RVA: 0x00244242 File Offset: 0x00242442
		internal virtual TextBox txtChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06003EF9 RID: 16121 RVA: 0x0024424B File Offset: 0x0024244B
		// (set) Token: 0x06003EFA RID: 16122 RVA: 0x00244255 File Offset: 0x00242455
		internal virtual Label lblchange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06003EFB RID: 16123 RVA: 0x0024425E File Offset: 0x0024245E
		// (set) Token: 0x06003EFC RID: 16124 RVA: 0x00244268 File Offset: 0x00242468
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
				EventHandler eventHandler = new EventHandler(this.txtAmtPaid_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmtPaid_KeyDown);
				TextBox textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtAmtPaid = value;
				textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x002442E1 File Offset: 0x002424E1
		// (set) Token: 0x06003EFE RID: 16126 RVA: 0x002442EB File Offset: 0x002424EB
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x002442F4 File Offset: 0x002424F4
		// (set) Token: 0x06003F00 RID: 16128 RVA: 0x00244300 File Offset: 0x00242500
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

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06003F01 RID: 16129 RVA: 0x00244343 File Offset: 0x00242543
		// (set) Token: 0x06003F02 RID: 16130 RVA: 0x0024434D File Offset: 0x0024254D
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x00244356 File Offset: 0x00242556
		// (set) Token: 0x06003F04 RID: 16132 RVA: 0x00244360 File Offset: 0x00242560
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x00244369 File Offset: 0x00242569
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x00244374 File Offset: 0x00242574
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
				EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				EventHandler eventHandler2 = new EventHandler(this.cboCustomers_TextChanged);
				EventHandler eventHandler3 = new EventHandler(this.cboCustomers_Leave);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
					comboBox.TextChanged -= eventHandler2;
					comboBox.Leave -= eventHandler3;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
					comboBox.TextChanged += eventHandler2;
					comboBox.Leave += eventHandler3;
				}
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x002443ED File Offset: 0x002425ED
		// (set) Token: 0x06003F08 RID: 16136 RVA: 0x002443F7 File Offset: 0x002425F7
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x00244400 File Offset: 0x00242600
		// (set) Token: 0x06003F0A RID: 16138 RVA: 0x0024440A File Offset: 0x0024260A
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x00244413 File Offset: 0x00242613
		// (set) Token: 0x06003F0C RID: 16140 RVA: 0x0024441D File Offset: 0x0024261D
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x00244426 File Offset: 0x00242626
		// (set) Token: 0x06003F0E RID: 16142 RVA: 0x00244430 File Offset: 0x00242630
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

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x0024448E File Offset: 0x0024268E
		// (set) Token: 0x06003F10 RID: 16144 RVA: 0x00244498 File Offset: 0x00242698
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
				EventHandler eventHandler = new EventHandler(this.txtSearchProdtID_TextChanged);
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

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06003F11 RID: 16145 RVA: 0x002444DB File Offset: 0x002426DB
		// (set) Token: 0x06003F12 RID: 16146 RVA: 0x002444E5 File Offset: 0x002426E5
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06003F13 RID: 16147 RVA: 0x002444EE File Offset: 0x002426EE
		// (set) Token: 0x06003F14 RID: 16148 RVA: 0x002444F8 File Offset: 0x002426F8
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x00244501 File Offset: 0x00242701
		// (set) Token: 0x06003F16 RID: 16150 RVA: 0x0024450B File Offset: 0x0024270B
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x00244514 File Offset: 0x00242714
		// (set) Token: 0x06003F18 RID: 16152 RVA: 0x0024451E File Offset: 0x0024271E
		internal virtual TextBox txtCoupons
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06003F19 RID: 16153 RVA: 0x00244527 File Offset: 0x00242727
		// (set) Token: 0x06003F1A RID: 16154 RVA: 0x00244531 File Offset: 0x00242731
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06003F1B RID: 16155 RVA: 0x0024453A File Offset: 0x0024273A
		// (set) Token: 0x06003F1C RID: 16156 RVA: 0x00244544 File Offset: 0x00242744
		internal virtual Label lblCouponInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06003F1D RID: 16157 RVA: 0x0024454D File Offset: 0x0024274D
		// (set) Token: 0x06003F1E RID: 16158 RVA: 0x00244557 File Offset: 0x00242757
		internal virtual TextBox txtOLDprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06003F1F RID: 16159 RVA: 0x00244560 File Offset: 0x00242760
		// (set) Token: 0x06003F20 RID: 16160 RVA: 0x0024456A File Offset: 0x0024276A
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x00244573 File Offset: 0x00242773
		// (set) Token: 0x06003F22 RID: 16162 RVA: 0x0024457D File Offset: 0x0024277D
		internal virtual Label lblShiftDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x00244586 File Offset: 0x00242786
		// (set) Token: 0x06003F24 RID: 16164 RVA: 0x00244590 File Offset: 0x00242790
		internal virtual Label lblShift
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x00244599 File Offset: 0x00242799
		// (set) Token: 0x06003F26 RID: 16166 RVA: 0x002445A3 File Offset: 0x002427A3
		internal virtual Label lblUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x002445AC File Offset: 0x002427AC
		// (set) Token: 0x06003F28 RID: 16168 RVA: 0x002445B6 File Offset: 0x002427B6
		internal virtual Label lblbranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x002445BF File Offset: 0x002427BF
		// (set) Token: 0x06003F2A RID: 16170 RVA: 0x002445CC File Offset: 0x002427CC
		internal virtual Label Label9
		{
			[CompilerGenerated]
			get
			{
				return this._Label9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label9_Click_1);
				Label label = this._Label9;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label9 = value;
				label = this._Label9;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06003F2B RID: 16171 RVA: 0x0024460F File Offset: 0x0024280F
		// (set) Token: 0x06003F2C RID: 16172 RVA: 0x0024461C File Offset: 0x0024281C
		internal virtual Button btnShift
		{
			[CompilerGenerated]
			get
			{
				return this._btnShift;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnShift_Click);
				Button button = this._btnShift;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnShift = value;
				button = this._btnShift;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x0024465F File Offset: 0x0024285F
		// (set) Token: 0x06003F2E RID: 16174 RVA: 0x0024466C File Offset: 0x0024286C
		internal virtual Button btnstartshift
		{
			[CompilerGenerated]
			get
			{
				return this._btnstartshift;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._btnstartshift;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnstartshift = value;
				button = this._btnstartshift;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x002446AF File Offset: 0x002428AF
		// (set) Token: 0x06003F30 RID: 16176 RVA: 0x002446B9 File Offset: 0x002428B9
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06003F31 RID: 16177 RVA: 0x002446C2 File Offset: 0x002428C2
		// (set) Token: 0x06003F32 RID: 16178 RVA: 0x002446CC File Offset: 0x002428CC
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
				EventHandler eventHandler = new EventHandler(this.Button4_Click_2);
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

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06003F33 RID: 16179 RVA: 0x0024470F File Offset: 0x0024290F
		// (set) Token: 0x06003F34 RID: 16180 RVA: 0x0024471C File Offset: 0x0024291C
		internal virtual CheckBox chkAccount
		{
			[CompilerGenerated]
			get
			{
				return this._chkAccount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkAccount_CheckedChanged);
				CheckBox checkBox = this._chkAccount;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkAccount = value;
				checkBox = this._chkAccount;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06003F35 RID: 16181 RVA: 0x0024475F File Offset: 0x0024295F
		// (set) Token: 0x06003F36 RID: 16182 RVA: 0x00244769 File Offset: 0x00242969
		internal virtual Label lblTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06003F37 RID: 16183 RVA: 0x00244772 File Offset: 0x00242972
		// (set) Token: 0x06003F38 RID: 16184 RVA: 0x0024477C File Offset: 0x0024297C
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06003F39 RID: 16185 RVA: 0x00244785 File Offset: 0x00242985
		// (set) Token: 0x06003F3A RID: 16186 RVA: 0x0024478F File Offset: 0x0024298F
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06003F3B RID: 16187 RVA: 0x00244798 File Offset: 0x00242998
		// (set) Token: 0x06003F3C RID: 16188 RVA: 0x002447A4 File Offset: 0x002429A4
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

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06003F3D RID: 16189 RVA: 0x002447E7 File Offset: 0x002429E7
		// (set) Token: 0x06003F3E RID: 16190 RVA: 0x002447F4 File Offset: 0x002429F4
		internal virtual TextBox txtPriceChange
		{
			[CompilerGenerated]
			get
			{
				return this._txtPriceChange;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPriceChange_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtPriceChange_Leave);
				TextBox textBox = this._txtPriceChange;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.Leave -= eventHandler;
				}
				this._txtPriceChange = value;
				textBox = this._txtPriceChange;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.Leave += eventHandler;
				}
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06003F3F RID: 16191 RVA: 0x00244852 File Offset: 0x00242A52
		// (set) Token: 0x06003F40 RID: 16192 RVA: 0x0024485C File Offset: 0x00242A5C
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06003F41 RID: 16193 RVA: 0x00244865 File Offset: 0x00242A65
		// (set) Token: 0x06003F42 RID: 16194 RVA: 0x00244870 File Offset: 0x00242A70
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

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06003F43 RID: 16195 RVA: 0x002448B3 File Offset: 0x00242AB3
		// (set) Token: 0x06003F44 RID: 16196 RVA: 0x002448C0 File Offset: 0x00242AC0
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
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboPayMeth_Validating);
				EventHandler eventHandler = new EventHandler(this.cboPayMeth_SelectedIndexChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.cboPayMeth_KeyPress);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboPayMeth_KeyDown);
				ComboBox comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.Validating -= cancelEventHandler;
					comboBox.SelectedIndexChanged -= eventHandler;
					comboBox.KeyPress -= keyPressEventHandler;
					comboBox.KeyDown -= keyEventHandler;
				}
				this._cboPayMeth = value;
				comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.Validating += cancelEventHandler;
					comboBox.SelectedIndexChanged += eventHandler;
					comboBox.KeyPress += keyPressEventHandler;
					comboBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06003F45 RID: 16197 RVA: 0x00244960 File Offset: 0x00242B60
		// (set) Token: 0x06003F46 RID: 16198 RVA: 0x0024496A File Offset: 0x00242B6A
		internal virtual Label lblpaymeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06003F47 RID: 16199 RVA: 0x00244973 File Offset: 0x00242B73
		// (set) Token: 0x06003F48 RID: 16200 RVA: 0x00244980 File Offset: 0x00242B80
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

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06003F49 RID: 16201 RVA: 0x002449C3 File Offset: 0x00242BC3
		// (set) Token: 0x06003F4A RID: 16202 RVA: 0x002449CD File Offset: 0x00242BCD
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06003F4B RID: 16203 RVA: 0x002449D6 File Offset: 0x00242BD6
		// (set) Token: 0x06003F4C RID: 16204 RVA: 0x002449E0 File Offset: 0x00242BE0
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x002449E9 File Offset: 0x00242BE9
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x002449F3 File Offset: 0x00242BF3
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x002449FC File Offset: 0x00242BFC
		// (set) Token: 0x06003F50 RID: 16208 RVA: 0x00244A08 File Offset: 0x00242C08
		internal virtual TextBox txtMobile
		{
			[CompilerGenerated]
			get
			{
				return this._txtMobile;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMobile_KeyDown);
				TextBox textBox = this._txtMobile;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtMobile = value;
				textBox = this._txtMobile;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06003F51 RID: 16209 RVA: 0x00244A4B File Offset: 0x00242C4B
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x00244A55 File Offset: 0x00242C55
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x00244A5E File Offset: 0x00242C5E
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x00244A68 File Offset: 0x00242C68
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtContactName_KeyDown);
				TextBox textBox = this._txtContactName;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtContactName = value;
				textBox = this._txtContactName;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x00244AAB File Offset: 0x00242CAB
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x00244AB5 File Offset: 0x00242CB5
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x00244ABE File Offset: 0x00242CBE
		// (set) Token: 0x06003F58 RID: 16216 RVA: 0x00244AC8 File Offset: 0x00242CC8
		internal virtual TextBox txtAddress
		{
			[CompilerGenerated]
			get
			{
				return this._txtAddress;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAddress_KeyDown);
				TextBox textBox = this._txtAddress;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtAddress = value;
				textBox = this._txtAddress;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06003F59 RID: 16217 RVA: 0x00244B0B File Offset: 0x00242D0B
		// (set) Token: 0x06003F5A RID: 16218 RVA: 0x00244B15 File Offset: 0x00242D15
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x00244B1E File Offset: 0x00242D1E
		// (set) Token: 0x06003F5C RID: 16220 RVA: 0x00244B28 File Offset: 0x00242D28
		internal virtual TextBox txtcustomer
		{
			[CompilerGenerated]
			get
			{
				return this._txtcustomer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtcustomer_KeyDown);
				EventHandler eventHandler = new EventHandler(this.txtcustomer_Leave);
				TextBox textBox = this._txtcustomer;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
					textBox.Leave -= eventHandler;
				}
				this._txtcustomer = value;
				textBox = this._txtcustomer;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
					textBox.Leave += eventHandler;
				}
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06003F5D RID: 16221 RVA: 0x00244B86 File Offset: 0x00242D86
		// (set) Token: 0x06003F5E RID: 16222 RVA: 0x00244B90 File Offset: 0x00242D90
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

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06003F5F RID: 16223 RVA: 0x00244BD3 File Offset: 0x00242DD3
		// (set) Token: 0x06003F60 RID: 16224 RVA: 0x00244BDD File Offset: 0x00242DDD
		internal virtual DateTimePicker DateTimePicker2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06003F61 RID: 16225 RVA: 0x00244BE6 File Offset: 0x00242DE6
		// (set) Token: 0x06003F62 RID: 16226 RVA: 0x00244BF0 File Offset: 0x00242DF0
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

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x00244C33 File Offset: 0x00242E33
		// (set) Token: 0x06003F64 RID: 16228 RVA: 0x00244C40 File Offset: 0x00242E40
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

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06003F65 RID: 16229 RVA: 0x00244C83 File Offset: 0x00242E83
		// (set) Token: 0x06003F66 RID: 16230 RVA: 0x00244C8D File Offset: 0x00242E8D
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x00244C96 File Offset: 0x00242E96
		// (set) Token: 0x06003F68 RID: 16232 RVA: 0x00244CA0 File Offset: 0x00242EA0
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06003F69 RID: 16233 RVA: 0x00244CA9 File Offset: 0x00242EA9
		// (set) Token: 0x06003F6A RID: 16234 RVA: 0x00244CB3 File Offset: 0x00242EB3
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06003F6B RID: 16235 RVA: 0x00244CBC File Offset: 0x00242EBC
		// (set) Token: 0x06003F6C RID: 16236 RVA: 0x00244CC6 File Offset: 0x00242EC6
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06003F6D RID: 16237 RVA: 0x00244CCF File Offset: 0x00242ECF
		// (set) Token: 0x06003F6E RID: 16238 RVA: 0x00244CDC File Offset: 0x00242EDC
		internal virtual TextBox txtInvDetails1
		{
			[CompilerGenerated]
			get
			{
				return this._txtInvDetails1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtInvDetails1_KeyDown);
				TextBox textBox = this._txtInvDetails1;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtInvDetails1 = value;
				textBox = this._txtInvDetails1;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06003F6F RID: 16239 RVA: 0x00244D1F File Offset: 0x00242F1F
		// (set) Token: 0x06003F70 RID: 16240 RVA: 0x00244D29 File Offset: 0x00242F29
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x00244D32 File Offset: 0x00242F32
		// (set) Token: 0x06003F72 RID: 16242 RVA: 0x00244D3C File Offset: 0x00242F3C
		internal virtual CheckBox chkPrintDeliveryNote
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x00244D45 File Offset: 0x00242F45
		// (set) Token: 0x06003F74 RID: 16244 RVA: 0x00244D4F File Offset: 0x00242F4F
		internal virtual GroupBox grpCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x00244D58 File Offset: 0x00242F58
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x00244D62 File Offset: 0x00242F62
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x00244D6B File Offset: 0x00242F6B
		// (set) Token: 0x06003F78 RID: 16248 RVA: 0x00244D75 File Offset: 0x00242F75
		internal virtual RadioButton rdpDelivery
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x00244D7E File Offset: 0x00242F7E
		// (set) Token: 0x06003F7A RID: 16250 RVA: 0x00244D88 File Offset: 0x00242F88
		internal virtual RadioButton rdbCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06003F7B RID: 16251 RVA: 0x00244D91 File Offset: 0x00242F91
		// (set) Token: 0x06003F7C RID: 16252 RVA: 0x00244D9C File Offset: 0x00242F9C
		internal virtual TextBox txtDiscount
		{
			[CompilerGenerated]
			get
			{
				return this._txtDiscount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDiscount_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtDiscount_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDiscount_KeyDown);
				EventHandler eventHandler2 = new EventHandler(this.txtDiscount_Leave);
				TextBox textBox = this._txtDiscount;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.Leave -= eventHandler2;
				}
				this._txtDiscount = value;
				textBox = this._txtDiscount;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.Leave += eventHandler2;
				}
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x00244E3C File Offset: 0x0024303C
		// (set) Token: 0x06003F7E RID: 16254 RVA: 0x00244E46 File Offset: 0x00243046
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x00244E4F File Offset: 0x0024304F
		// (set) Token: 0x06003F80 RID: 16256 RVA: 0x00244E59 File Offset: 0x00243059
		internal virtual RadioButton rdbCollectionsNone
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x00244E62 File Offset: 0x00243062
		// (set) Token: 0x06003F82 RID: 16258 RVA: 0x00244E6C File Offset: 0x0024306C
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x00244E75 File Offset: 0x00243075
		// (set) Token: 0x06003F84 RID: 16260 RVA: 0x00244E7F File Offset: 0x0024307F
		internal virtual Panel Panel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06003F85 RID: 16261 RVA: 0x00244E88 File Offset: 0x00243088
		// (set) Token: 0x06003F86 RID: 16262 RVA: 0x00244E94 File Offset: 0x00243094
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

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x00244ED7 File Offset: 0x002430D7
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x00244EE4 File Offset: 0x002430E4
		internal virtual Button Button10
		{
			[CompilerGenerated]
			get
			{
				return this._Button10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button10_Click);
				Button button = this._Button10;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button10 = value;
				button = this._Button10;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x00244F27 File Offset: 0x00243127
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x00244F31 File Offset: 0x00243131
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x00244F3A File Offset: 0x0024313A
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x00244F44 File Offset: 0x00243144
		internal virtual Panel Panel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x00244F4D File Offset: 0x0024314D
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x00244F58 File Offset: 0x00243158
		internal virtual Button Button13
		{
			[CompilerGenerated]
			get
			{
				return this._Button13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button13_Click);
				Button button = this._Button13;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button13 = value;
				button = this._Button13;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x00244F9B File Offset: 0x0024319B
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x00244FA8 File Offset: 0x002431A8
		internal virtual Button cmdDiscount
		{
			[CompilerGenerated]
			get
			{
				return this._cmdDiscount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cmdDiscount_Click);
				Button button = this._cmdDiscount;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdDiscount = value;
				button = this._cmdDiscount;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06003F91 RID: 16273 RVA: 0x00244FEB File Offset: 0x002431EB
		// (set) Token: 0x06003F92 RID: 16274 RVA: 0x00244FF5 File Offset: 0x002431F5
		internal virtual Label Label33
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06003F93 RID: 16275 RVA: 0x00244FFE File Offset: 0x002431FE
		// (set) Token: 0x06003F94 RID: 16276 RVA: 0x00245008 File Offset: 0x00243208
		internal virtual Label Label35
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06003F95 RID: 16277 RVA: 0x00245011 File Offset: 0x00243211
		// (set) Token: 0x06003F96 RID: 16278 RVA: 0x0024501B File Offset: 0x0024321B
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x00245024 File Offset: 0x00243224
		// (set) Token: 0x06003F98 RID: 16280 RVA: 0x00245030 File Offset: 0x00243230
		internal virtual Button Button14
		{
			[CompilerGenerated]
			get
			{
				return this._Button14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button14_Click);
				Button button = this._Button14;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button14 = value;
				button = this._Button14;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x00245073 File Offset: 0x00243273
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x0024507D File Offset: 0x0024327D
		internal virtual Label txtConsultant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x00245086 File Offset: 0x00243286
		// (set) Token: 0x06003F9C RID: 16284 RVA: 0x00245090 File Offset: 0x00243290
		internal virtual ComboBox cboConsultant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x00245099 File Offset: 0x00243299
		// (set) Token: 0x06003F9E RID: 16286 RVA: 0x002450A4 File Offset: 0x002432A4
		internal virtual Button Button15
		{
			[CompilerGenerated]
			get
			{
				return this._Button15;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button15_Click);
				Button button = this._Button15;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button15 = value;
				button = this._Button15;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06003F9F RID: 16287 RVA: 0x002450E7 File Offset: 0x002432E7
		// (set) Token: 0x06003FA0 RID: 16288 RVA: 0x002450F4 File Offset: 0x002432F4
		internal virtual CheckBox chkMultiple
		{
			[CompilerGenerated]
			get
			{
				return this._chkMultiple;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkMultiple_CheckedChanged);
				CheckBox checkBox = this._chkMultiple;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkMultiple = value;
				checkBox = this._chkMultiple;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06003FA1 RID: 16289 RVA: 0x00245137 File Offset: 0x00243337
		// (set) Token: 0x06003FA2 RID: 16290 RVA: 0x00245141 File Offset: 0x00243341
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x0024514A File Offset: 0x0024334A
		// (set) Token: 0x06003FA4 RID: 16292 RVA: 0x00245154 File Offset: 0x00243354
		internal virtual Button cmdSpecialPrice
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSpecialPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button16_Click);
				Button button = this._cmdSpecialPrice;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdSpecialPrice = value;
				button = this._cmdSpecialPrice;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06003FA5 RID: 16293 RVA: 0x00245197 File Offset: 0x00243397
		// (set) Token: 0x06003FA6 RID: 16294 RVA: 0x002451A4 File Offset: 0x002433A4
		internal virtual Button Button16
		{
			[CompilerGenerated]
			get
			{
				return this._Button16;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button16_Click_1);
				Button button = this._Button16;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button16 = value;
				button = this._Button16;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x002451E7 File Offset: 0x002433E7
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x002451F4 File Offset: 0x002433F4
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

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x00245237 File Offset: 0x00243437
		// (set) Token: 0x06003FAA RID: 16298 RVA: 0x00245244 File Offset: 0x00243444
		internal virtual TextBox txtbpnumber
		{
			[CompilerGenerated]
			get
			{
				return this._txtbpnumber;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtbpnumber_KeyDown);
				TextBox textBox = this._txtbpnumber;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtbpnumber = value;
				textBox = this._txtbpnumber;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x00245287 File Offset: 0x00243487
		// (set) Token: 0x06003FAC RID: 16300 RVA: 0x00245291 File Offset: 0x00243491
		internal virtual Label lblBPNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06003FAD RID: 16301 RVA: 0x0024529A File Offset: 0x0024349A
		// (set) Token: 0x06003FAE RID: 16302 RVA: 0x002452A4 File Offset: 0x002434A4
		internal virtual TextBox txtvatnumber
		{
			[CompilerGenerated]
			get
			{
				return this._txtvatnumber;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtvatnumber_KeyDown);
				TextBox textBox = this._txtvatnumber;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtvatnumber = value;
				textBox = this._txtvatnumber;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x002452E7 File Offset: 0x002434E7
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x002452F1 File Offset: 0x002434F1
		internal virtual Label lblVATNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x002452FA File Offset: 0x002434FA
		// (set) Token: 0x06003FB2 RID: 16306 RVA: 0x00245304 File Offset: 0x00243504
		internal virtual Button Button18
		{
			[CompilerGenerated]
			get
			{
				return this._Button18;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button18_Click);
				Button button = this._Button18;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button18 = value;
				button = this._Button18;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06003FB3 RID: 16307 RVA: 0x00245347 File Offset: 0x00243547
		// (set) Token: 0x06003FB4 RID: 16308 RVA: 0x00245351 File Offset: 0x00243551
		internal virtual GroupBox grpSales
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06003FB5 RID: 16309 RVA: 0x0024535A File Offset: 0x0024355A
		// (set) Token: 0x06003FB6 RID: 16310 RVA: 0x00245364 File Offset: 0x00243564
		internal virtual GroupBox grpCustomers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06003FB7 RID: 16311 RVA: 0x0024536D File Offset: 0x0024356D
		// (set) Token: 0x06003FB8 RID: 16312 RVA: 0x00245377 File Offset: 0x00243577
		internal virtual TextBox txtcomments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x00245380 File Offset: 0x00243580
		// (set) Token: 0x06003FBA RID: 16314 RVA: 0x0024538C File Offset: 0x0024358C
		internal virtual Button btnBarFastExchange
		{
			[CompilerGenerated]
			get
			{
				return this._btnBarFastExchange;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button19_Click);
				Button button = this._btnBarFastExchange;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnBarFastExchange = value;
				button = this._btnBarFastExchange;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x002453CF File Offset: 0x002435CF
		// (set) Token: 0x06003FBC RID: 16316 RVA: 0x002453D9 File Offset: 0x002435D9
		internal virtual Label lbltotprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06003FBD RID: 16317 RVA: 0x002453E2 File Offset: 0x002435E2
		// (set) Token: 0x06003FBE RID: 16318 RVA: 0x002453EC File Offset: 0x002435EC
		internal virtual Button Button19
		{
			[CompilerGenerated]
			get
			{
				return this._Button19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button19_Click_1);
				Button button = this._Button19;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button19 = value;
				button = this._Button19;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06003FBF RID: 16319 RVA: 0x0024542F File Offset: 0x0024362F
		// (set) Token: 0x06003FC0 RID: 16320 RVA: 0x00245439 File Offset: 0x00243639
		internal virtual Label lblBinLoc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x00245442 File Offset: 0x00243642
		// (set) Token: 0x06003FC2 RID: 16322 RVA: 0x0024544C File Offset: 0x0024364C
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x00245455 File Offset: 0x00243655
		// (set) Token: 0x06003FC4 RID: 16324 RVA: 0x0024545F File Offset: 0x0024365F
		internal virtual RadioButton radSitIn
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x00245468 File Offset: 0x00243668
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x00245472 File Offset: 0x00243672
		internal virtual RadioButton radTakeAway
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x0024547B File Offset: 0x0024367B
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x00245485 File Offset: 0x00243685
		internal virtual Label Label38
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06003FC9 RID: 16329 RVA: 0x0024548E File Offset: 0x0024368E
		// (set) Token: 0x06003FCA RID: 16330 RVA: 0x00245498 File Offset: 0x00243698
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x002454A1 File Offset: 0x002436A1
		// (set) Token: 0x06003FCC RID: 16332 RVA: 0x002454AB File Offset: 0x002436AB
		internal virtual BarcodePanel BarcodePanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x002454B4 File Offset: 0x002436B4
		// (set) Token: 0x06003FCE RID: 16334 RVA: 0x002454C0 File Offset: 0x002436C0
		internal virtual PrintDocument PrintDocument2
		{
			[CompilerGenerated]
			get
			{
				return this._PrintDocument2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.pdPrint_PrintPage);
				PrintDocument printDocument = this._PrintDocument2;
				if (printDocument != null)
				{
					printDocument.PrintPage -= printPageEventHandler;
				}
				this._PrintDocument2 = value;
				printDocument = this._PrintDocument2;
				if (printDocument != null)
				{
					printDocument.PrintPage += printPageEventHandler;
				}
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x00245503 File Offset: 0x00243703
		// (set) Token: 0x06003FD0 RID: 16336 RVA: 0x0024550D File Offset: 0x0024370D
		internal virtual Button cmdDeposits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06003FD1 RID: 16337 RVA: 0x00245516 File Offset: 0x00243716
		// (set) Token: 0x06003FD2 RID: 16338 RVA: 0x00245520 File Offset: 0x00243720
		internal virtual Label Label39
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x00245529 File Offset: 0x00243729
		// (set) Token: 0x06003FD4 RID: 16340 RVA: 0x00245533 File Offset: 0x00243733
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x0024553C File Offset: 0x0024373C
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x00245546 File Offset: 0x00243746
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x0024554F File Offset: 0x0024374F
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x00245559 File Offset: 0x00243759
		internal virtual PictureBox PictureBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x00245562 File Offset: 0x00243762
		// (set) Token: 0x06003FDA RID: 16346 RVA: 0x0024556C File Offset: 0x0024376C
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06003FDB RID: 16347 RVA: 0x00245575 File Offset: 0x00243775
		// (set) Token: 0x06003FDC RID: 16348 RVA: 0x00245580 File Offset: 0x00243780
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

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x002455DE File Offset: 0x002437DE
		// (set) Token: 0x06003FDE RID: 16350 RVA: 0x002455E8 File Offset: 0x002437E8
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06003FDF RID: 16351 RVA: 0x002455F1 File Offset: 0x002437F1
		// (set) Token: 0x06003FE0 RID: 16352 RVA: 0x002455FB File Offset: 0x002437FB
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06003FE1 RID: 16353 RVA: 0x00245604 File Offset: 0x00243804
		// (set) Token: 0x06003FE2 RID: 16354 RVA: 0x00245610 File Offset: 0x00243810
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

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06003FE3 RID: 16355 RVA: 0x00245653 File Offset: 0x00243853
		// (set) Token: 0x06003FE4 RID: 16356 RVA: 0x0024565D File Offset: 0x0024385D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x00245666 File Offset: 0x00243866
		// (set) Token: 0x06003FE6 RID: 16358 RVA: 0x00245670 File Offset: 0x00243870
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
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtSearchProdtID_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtsearch_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsearch_KeyDown);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x002456E9 File Offset: 0x002438E9
		// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x002456F3 File Offset: 0x002438F3
		internal virtual Panel Panel7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x002456FC File Offset: 0x002438FC
		// (set) Token: 0x06003FEA RID: 16362 RVA: 0x00245706 File Offset: 0x00243906
		internal virtual Label lblComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x0024570F File Offset: 0x0024390F
		// (set) Token: 0x06003FEC RID: 16364 RVA: 0x0024571C File Offset: 0x0024391C
		internal virtual Button Button21
		{
			[CompilerGenerated]
			get
			{
				return this._Button21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button21_Click);
				Button button = this._Button21;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button21 = value;
				button = this._Button21;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x0024575F File Offset: 0x0024395F
		// (set) Token: 0x06003FEE RID: 16366 RVA: 0x00245769 File Offset: 0x00243969
		internal virtual TextBox txtOrderNo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06003FEF RID: 16367 RVA: 0x00245772 File Offset: 0x00243972
		// (set) Token: 0x06003FF0 RID: 16368 RVA: 0x0024577C File Offset: 0x0024397C
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x00245785 File Offset: 0x00243985
		// (set) Token: 0x06003FF2 RID: 16370 RVA: 0x00245790 File Offset: 0x00243990
		internal virtual TextBox txtQtyWeighed
		{
			[CompilerGenerated]
			get
			{
				return this._txtQtyWeighed;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtQtyWeighed_TextChanged);
				TextBox textBox = this._txtQtyWeighed;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtQtyWeighed = value;
				textBox = this._txtQtyWeighed;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x002457D3 File Offset: 0x002439D3
		// (set) Token: 0x06003FF4 RID: 16372 RVA: 0x002457E0 File Offset: 0x002439E0
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x00245823 File Offset: 0x00243A23
		// (set) Token: 0x06003FF6 RID: 16374 RVA: 0x0024582D File Offset: 0x00243A2D
		internal virtual PictureBox PicQRCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x00245836 File Offset: 0x00243A36
		// (set) Token: 0x06003FF8 RID: 16376 RVA: 0x00245840 File Offset: 0x00243A40
		internal virtual Label lblRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x00245849 File Offset: 0x00243A49
		// (set) Token: 0x06003FFA RID: 16378 RVA: 0x00245853 File Offset: 0x00243A53
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x0024585C File Offset: 0x00243A5C
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x00245866 File Offset: 0x00243A66
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06003FFD RID: 16381 RVA: 0x0024586F File Offset: 0x00243A6F
		// (set) Token: 0x06003FFE RID: 16382 RVA: 0x00245879 File Offset: 0x00243A79
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x00245882 File Offset: 0x00243A82
		// (set) Token: 0x06004000 RID: 16384 RVA: 0x0024588C File Offset: 0x00243A8C
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06004001 RID: 16385 RVA: 0x00245895 File Offset: 0x00243A95
		// (set) Token: 0x06004002 RID: 16386 RVA: 0x0024589F File Offset: 0x00243A9F
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06004003 RID: 16387 RVA: 0x002458A8 File Offset: 0x00243AA8
		// (set) Token: 0x06004004 RID: 16388 RVA: 0x002458B2 File Offset: 0x00243AB2
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x002458BB File Offset: 0x00243ABB
		// (set) Token: 0x06004006 RID: 16390 RVA: 0x002458C5 File Offset: 0x00243AC5
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x002458CE File Offset: 0x00243ACE
		// (set) Token: 0x06004008 RID: 16392 RVA: 0x002458D8 File Offset: 0x00243AD8
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x002458E1 File Offset: 0x00243AE1
		// (set) Token: 0x0600400A RID: 16394 RVA: 0x002458EB File Offset: 0x00243AEB
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x002458F4 File Offset: 0x00243AF4
		// (set) Token: 0x0600400C RID: 16396 RVA: 0x002458FE File Offset: 0x00243AFE
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x00245907 File Offset: 0x00243B07
		// (set) Token: 0x0600400E RID: 16398 RVA: 0x00245911 File Offset: 0x00243B11
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x0024591A File Offset: 0x00243B1A
		// (set) Token: 0x06004010 RID: 16400 RVA: 0x00245924 File Offset: 0x00243B24
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06004011 RID: 16401 RVA: 0x0024592D File Offset: 0x00243B2D
		// (set) Token: 0x06004012 RID: 16402 RVA: 0x00245937 File Offset: 0x00243B37
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x00245940 File Offset: 0x00243B40
		// (set) Token: 0x06004014 RID: 16404 RVA: 0x0024594A File Offset: 0x00243B4A
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x00245953 File Offset: 0x00243B53
		// (set) Token: 0x06004016 RID: 16406 RVA: 0x0024595D File Offset: 0x00243B5D
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06004017 RID: 16407 RVA: 0x00245966 File Offset: 0x00243B66
		// (set) Token: 0x06004018 RID: 16408 RVA: 0x00245970 File Offset: 0x00243B70
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x00245979 File Offset: 0x00243B79
		// (set) Token: 0x0600401A RID: 16410 RVA: 0x00245983 File Offset: 0x00243B83
		internal virtual DataGridViewTextBoxColumn DiscPaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x0024598C File Offset: 0x00243B8C
		// (set) Token: 0x0600401C RID: 16412 RVA: 0x00245996 File Offset: 0x00243B96
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x0024599F File Offset: 0x00243B9F
		// (set) Token: 0x0600401E RID: 16414 RVA: 0x002459A9 File Offset: 0x00243BA9
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x0600401F RID: 16415 RVA: 0x002459B2 File Offset: 0x00243BB2
		// (set) Token: 0x06004020 RID: 16416 RVA: 0x002459BC File Offset: 0x00243BBC
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x002459C5 File Offset: 0x00243BC5
		// (set) Token: 0x06004022 RID: 16418 RVA: 0x002459CF File Offset: 0x00243BCF
		internal virtual DataGridViewTextBoxColumn Taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06004023 RID: 16419 RVA: 0x002459D8 File Offset: 0x00243BD8
		// (set) Token: 0x06004024 RID: 16420 RVA: 0x002459E2 File Offset: 0x00243BE2
		internal virtual DataGridViewTextBoxColumn PromStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06004025 RID: 16421 RVA: 0x002459EB File Offset: 0x00243BEB
		// (set) Token: 0x06004026 RID: 16422 RVA: 0x002459F5 File Offset: 0x00243BF5
		internal virtual DataGridViewTextBoxColumn OtherDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x002459FE File Offset: 0x00243BFE
		// (set) Token: 0x06004028 RID: 16424 RVA: 0x00245A08 File Offset: 0x00243C08
		internal virtual DataGridViewTextBoxColumn IsVoucher
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x00245A11 File Offset: 0x00243C11
		// (set) Token: 0x0600402A RID: 16426 RVA: 0x00245A1B File Offset: 0x00243C1B
		internal virtual DataGridViewTextBoxColumn Comments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x00245A24 File Offset: 0x00243C24
		// (set) Token: 0x0600402C RID: 16428 RVA: 0x00245A2E File Offset: 0x00243C2E
		internal virtual DataGridViewTextBoxColumn RowNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x0600402D RID: 16429 RVA: 0x00245A37 File Offset: 0x00243C37
		// (set) Token: 0x0600402E RID: 16430 RVA: 0x00245A41 File Offset: 0x00243C41
		internal virtual DataGridViewTextBoxColumn UOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x00245A4A File Offset: 0x00243C4A
		// (set) Token: 0x06004030 RID: 16432 RVA: 0x00245A54 File Offset: 0x00243C54
		internal virtual DataGridViewTextBoxColumn Break
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x00245A5D File Offset: 0x00243C5D
		// (set) Token: 0x06004032 RID: 16434 RVA: 0x00245A67 File Offset: 0x00243C67
		internal virtual DataGridViewTextBoxColumn BreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x00245A70 File Offset: 0x00243C70
		// (set) Token: 0x06004034 RID: 16436 RVA: 0x00245A7A File Offset: 0x00243C7A
		internal virtual DataGridViewTextBoxColumn BreakParentProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x00245A83 File Offset: 0x00243C83
		// (set) Token: 0x06004036 RID: 16438 RVA: 0x00245A8D File Offset: 0x00243C8D
		internal virtual DataGridViewTextBoxColumn ActualBreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x00245A96 File Offset: 0x00243C96
		// (set) Token: 0x06004038 RID: 16440 RVA: 0x00245AA0 File Offset: 0x00243CA0
		internal virtual DataGridViewTextBoxColumn taxexempt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x00245AA9 File Offset: 0x00243CA9
		// (set) Token: 0x0600403A RID: 16442 RVA: 0x00245AB3 File Offset: 0x00243CB3
		internal virtual DataGridViewTextBoxColumn isdeposits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x0600403B RID: 16443 RVA: 0x00245ABC File Offset: 0x00243CBC
		// (set) Token: 0x0600403C RID: 16444 RVA: 0x00245AC6 File Offset: 0x00243CC6
		internal virtual DataGridViewTextBoxColumn AltDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x00245ACF File Offset: 0x00243CCF
		// (set) Token: 0x0600403E RID: 16446 RVA: 0x00245AD9 File Offset: 0x00243CD9
		internal virtual DataGridViewTextBoxColumn HSCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x00245AE2 File Offset: 0x00243CE2
		// (set) Token: 0x06004040 RID: 16448 RVA: 0x00245AEC File Offset: 0x00243CEC
		internal virtual DataGridViewTextBoxColumn IsUnlimitedStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x00245AF5 File Offset: 0x00243CF5
		// (set) Token: 0x06004042 RID: 16450 RVA: 0x00245AFF File Offset: 0x00243CFF
		internal virtual CheckBox chkHideTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00245B08 File Offset: 0x00243D08
		private void CheckShiftStatus()
		{
			this.btnstartshift.TabStop = false;
			DataTable dataTable = this.CalcShift();
			DataRow dataRow = dataTable.Rows[0];
			DateTime dateTime = DateTime.Today;
			checked
			{
				DataTable dataTable2 = this.CheckShift(Conversions.ToString(dataRow["ShiftName"]), MyProject.Forms.Form1.username, (int)Math.Round(Conversion.Val(dateTime.ToString("yyyyMMdd"))), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
				bool flag = dataTable2.Rows.Count > 0;
				if (flag)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					bool flag2 = Conversions.ToBoolean(dataRow2["IsClosed"]);
					bool flag3 = flag2;
					if (flag3)
					{
						bool flag4 = MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1;
						if (flag4)
						{
							DialogResult dialogResult = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Shift closed. Do you want to start the next shift for TOMORROW. Shift Name: ", dataRow2["shiftname"]), " shift DATE: "), DateTime.Today.AddDays(1.0)), MsgBoxStyle.YesNo, null);
							bool flag5 = dialogResult == DialogResult.Yes;
							if (flag5)
							{
								dateTime = DateTime.Today.AddDays(1.0);
								this.DTdate.Value = DateTime.Today.AddDays(1.0);
								this.InsertNewShift(MyProject.Forms.Form1.username, Conversions.ToString(dataRow["ShiftName"]), (int)Math.Round(Conversion.Val(dateTime.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))), 0, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
								this.lblShift.Text = dataRow2["Entryno"].ToString();
								this.lblShiftDate.Text = dateTime.ToShortDateString();
								this.EnableForm();
							}
						}
						else
						{
							MessageBox.Show("Your shift was closed. Cannot continue.");
						}
					}
					else
					{
						DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want to continue with your existing shift. Shift Name: ", dataRow2["shiftname"]), " shift start time: "), dataRow2["starttime"]), MsgBoxStyle.YesNo, null);
						bool flag6 = dialogResult2 == DialogResult.Yes;
						if (flag6)
						{
							this.lblShift.Text = dataRow2["EntryNo"].ToString();
							this.DTdate.Value = this.DateTimePicker2.Value;
							dateTime = this.DateTimePicker2.Value;
							this.lblShiftDate.Text = dateTime.ToShortDateString();
							MyProject.Forms.Form1.shiftdate = Conversions.ToInteger(dateTime.ToString("yyyyMMdd"));
							this.DateTimePicker2.Enabled = false;
							this.EnableForm();
						}
						else
						{
							DialogResult dialogResult3 = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want to Close your existing shift? SHift Name: ", dataRow2["shiftname"]), dataRow2["starttime"]), MsgBoxStyle.OkOnly, null);
							bool flag7 = dialogResult3 == DialogResult.Yes;
							if (flag7)
							{
								this.lblShift.Text = dataRow2["EntryNo"].ToString();
								this.CloseShift(Conversions.ToInteger(this.lblShift.Text), MyProject.Forms.Form1.coid, Conversions.ToString(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))), Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
								bool flag8 = MyProject.Forms.Form1.IsBlindCashUp == 0;
								if (flag8)
								{
									ShiftReportForm shiftReportForm = new ShiftReportForm();
									shiftReportForm.ShowDialog(this);
									shiftReportForm.Dispose();
								}
								base.Dispose();
							}
							else
							{
								MessageBox.Show("Please ensure you are logged onto a shift to continue. Click Start Shift.");
							}
						}
					}
				}
				else
				{
					DialogResult dialogResult4 = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("You are starting a new shift. Shift Name: ", dataRow["ShiftName"]), " Do you want to continue?"), MsgBoxStyle.YesNo, null);
					bool flag9 = dialogResult4 == DialogResult.Yes;
					if (flag9)
					{
						int num = this.InsertNewShift(MyProject.Forms.Form1.username, Conversions.ToString(dataRow["ShiftName"]), (int)Math.Round(Conversion.Val(dateTime.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))), 0, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
						this.lblShift.Text = Conversions.ToString(num);
						this.lblShiftDate.Text = dateTime.ToShortDateString();
						this.EnableForm();
					}
					else
					{
						MessageBox.Show("Please ensure you are logged onto a shift to continue. Click Start Shift.");
					}
				}
			}
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00246028 File Offset: 0x00244228
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
					this.coname_og = dataRow["CompanyName"].ToString();
					this.coadd_og = dataRow["Address"].ToString();
					this.coadd2_og = dataRow["Address2"].ToString();
					this.cotel_og = dataRow["Tel"].ToString();
					this.cotel2_og = dataRow["Tel2"].ToString();
					this.cotel3_og = dataRow["Tel3"].ToString();
					this.coemail_og = dataRow["Email"].ToString();
					this.cobpnum_og = dataRow["BPNumber"].ToString();
					this.footnote_og = dataRow["Footnote"].ToString();
					this.coVATNum_og = dataRow["VATNumber"].ToString();
					this.bpnum_name_og = dataRow["BPNumber_name"].ToString();
					this.vatnum_name_og = dataRow["VATNumber_name"].ToString();
					this.website_og = dataRow["websiteadd"].ToString();
					this.website_comment = dataRow["websitecomment"].ToString();
					this.lblBPNumber.Text = this.bpnum_name_og;
					this.lblVATNumber.Text = this.vatnum_name_og;
					this.scalemaxdiff = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["ScaleMaxDiff"])));
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x00246298 File Offset: 0x00244498
		private int InsertNewShift(string shiftuser, string shiftname, int shiftdate, int starttime, int endtime, string branch, int coid)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertShiftDetail";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("ShiftUser", shiftuser);
			sqlCommand.Parameters.AddWithValue("ShiftName", shiftname);
			sqlCommand.Parameters.AddWithValue("ShiftDate", shiftdate);
			sqlCommand.Parameters.AddWithValue("StartTime", starttime);
			sqlCommand.Parameters.AddWithValue("EndTime", endtime);
			sqlCommand.Parameters.AddWithValue("IsClosed", 0);
			sqlCommand.Parameters.AddWithValue("new_entryno", num);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x002463D8 File Offset: 0x002445D8
		private void EnableForm()
		{
			bool flag = MyProject.Forms.Form1.inv_template_Farhan == 1;
			if (flag)
			{
				this.chkHideTax.Visible = true;
				bool flag2 = MyProject.Forms.Form1.hidevat == 1;
				if (flag2)
				{
					this.chkHideTax.Checked = true;
				}
				else
				{
					this.chkHideTax.Checked = false;
				}
			}
			else
			{
				this.chkHideTax.Visible = false;
			}
			bool flag3 = MyProject.Forms.Form1.SHowCustomersInSalesForm == 1;
			if (flag3)
			{
				this.grpCustomers.Visible = true;
				string text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", MyProject.Forms.Form1.Constring);
				string text2 = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", MyProject.Forms.Form1.Constring);
				bool flag4 = (Operators.CompareString(text, "1", false) == 0) | (Operators.CompareString(text2, "1", false) == 0);
				if (flag4)
				{
					this.Label8.Visible = false;
					this.txtAddress.Visible = false;
				}
			}
			else
			{
				this.grpCustomers.Visible = false;
				this.GroupBox1.Height = 160;
			}
			this.grpSales.Visible = true;
			this.Panel2.Visible = true;
			this.GroupBox3.Visible = true;
			this.GroupBox2.Visible = true;
			this.btnShift.Visible = true;
			this.btnstartshift.Visible = false;
			bool flag5 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag5)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
			bool flag6 = MyProject.Forms.Form1.BarFastExchange == 1;
			if (flag6)
			{
				this.btnBarFastExchange.Visible = true;
			}
			else
			{
				this.btnBarFastExchange.Visible = false;
			}
			bool flag7 = MyProject.Forms.Form1.DisableQuotations == 1;
			if (flag7)
			{
				this.Panel6.Visible = false;
			}
			else
			{
				this.Panel6.Visible = true;
			}
			bool flag8 = MyProject.Forms.Form1.DontShowQuotationsOnSalesForm == 1;
			if (flag8)
			{
				this.GroupBox5.Visible = false;
			}
			else
			{
				this.GroupBox5.Visible = true;
			}
			this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.ShowSecondScreen();
			bool flag9 = (MyProject.Forms.Form1.FiscalRevmax == 1) & (MyProject.Forms.Form1.PrintFiscal == 1);
			if (flag9)
			{
				string deviceStatus = MyProject.Forms.Form1.myrevmax.GetDeviceStatus();
				JObject jobject = JObject.Parse(deviceStatus);
				string text3 = jobject["Message"].ToObject<string>();
				bool flag10 = Operators.CompareString(text3, "Success", false) == 0;
				if (flag10)
				{
					string text4 = jobject["Data"]["fiscalDayStatus"].ToString();
					bool flag11 = Operators.CompareString(Strings.Trim(text4), "FiscalDayOpened", false) == 0;
					if (!flag11)
					{
						MessageBox.Show("Fiscal Day closed. Please run Z-Report. Detail: " + text4);
					}
				}
				else
				{
					MessageBox.Show("Error occurred checking Revmax Device Status. Detail: " + text3);
				}
			}
			bool flag12 = MyProject.Forms.Form1.isZimraVirtFiscal == 1;
			if (flag12)
			{
				string text5 = this.pf.FiscalOpenFiscalDay(this.pf.FiscalGetDeviceID(this._cnn, this.pf.FiscalGetDeviceSerial(), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch), DateTime.Today, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				bool flag13 = Operators.CompareString(text5, "FISCAL DAY ALREADY CLOSED", false) == 0;
				if (flag13)
				{
					MessageBox.Show("FISCAL DAY Is ALREAY CLOSED And CANNOT BE OPENED");
					base.Dispose();
				}
				else
				{
					bool flag14 = Operators.CompareString(text5, "DAY OPENED", false) == 0;
					if (flag14)
					{
						MessageBox.Show("FISCAL DAY Is OPEN.");
					}
				}
			}
			DataTable dataTable = new DataTable();
			MyProject.Forms.Form1.datSerialsSelect4Sales = dataTable;
			bool flag15 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnableSalesGridQtyEditing", MyProject.Forms.Form1.Constring), "1", false) == 0;
			if (flag15)
			{
				this.DataGridView1.Columns["Qty"].ReadOnly = false;
			}
			else
			{
				this.DataGridView1.Columns["Qty"].ReadOnly = true;
			}
			bool flag16 = MyProject.Forms.Form1.AllowDirectPriceEditing == 1;
			if (flag16)
			{
				this.txtPrice.Enabled = true;
			}
			else
			{
				this.txtPrice.Enabled = false;
			}
			try
			{
				this.FetchCustomer(this.txtcustomer.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00246974 File Offset: 0x00244B74
		private void ShowSecondScreen()
		{
			bool flag = MyProject.Forms.Form1.HasSecondScreen == 1;
			if (flag)
			{
				int num = Screen.AllScreens.Count<Screen>();
				bool flag2 = num == 1;
				if (flag2)
				{
					MessageBox.Show("Failed to show Customer Screen. The computer Is Not configured to have more than 1 screen. Try setting Extend Screens in Windows Graphics Options.");
				}
				else
				{
					Screen screen = Screen.AllScreens[1];
					new SecondSalesScreen
					{
						StartPosition = FormStartPosition.Manual,
						Location = screen.Bounds.Location + (Size)new Point(100, 100)
					}.Show();
				}
			}
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00246A08 File Offset: 0x00244C08
		private int GetFirstShiftStartTime()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetFirstShiftStartTime";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["starttime"]))));
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00246A94 File Offset: 0x00244C94
		private DataTable CheckShift(string shiftname, string shiftuser, int shiftdate, string branch, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchExistingShiftDetail";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("shiftuser", shiftuser);
			sqlCommand.Parameters.AddWithValue("shiftname", shiftname);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x00246B4C File Offset: 0x00244D4C
		private DataTable CalcShift()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckShiftTime";
			sqlCommand.Parameters.AddWithValue("currenttime", Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00246BF0 File Offset: 0x00244DF0
		private void Sales_c(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
					if (flag)
					{
						try
						{
							string cardDetails = MyProject.Forms.Form1.myrevmax.GetCardDetails();
							JObject jobject = JObject.Parse(cardDetails);
							string text = jobject["Message"].ToObject<string>();
							bool flag2 = Operators.CompareString(text, "Success", false) != 0;
							if (flag2)
							{
								MessageBox.Show("Error getting card details. " + text);
							}
							else
							{
								MyProject.Forms.Form1.RevmaxDeviceSerial = jobject["DeviceSerialNumber"].ToObject<string>();
							}
							this.Button14.Visible = true;
							this.Button15.Visible = false;
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error getting Revmax fiscal device details. Detail: " + ex.Message);
						}
					}
					else
					{
						this.Button15.Visible = true;
						this.Button14.Visible = false;
					}
					bool flag3 = MyProject.Forms.Form1.ShowCostPrice == 1;
					if (flag3)
					{
						this.lblcost.Visible = true;
						this.Label39.Visible = true;
					}
					else
					{
						this.lblcost.Visible = false;
						this.Label39.Visible = false;
					}
					this.lblbranch.Text = MyProject.Forms.Form1.branch;
					this.LoadCustomers();
					this.LoadPayMeths();
					this.LoadPaymentTerms();
					this.lblUsername.Text = MyProject.Forms.Form1.username;
					int num = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
					this.GetBranchDetails();
					this.SetBranchColour();
					bool flag4 = MyProject.Forms.Form1.AllowTellerToViewStockBalances == 0;
					if (flag4)
					{
						this.Label3.Visible = false;
						this.txtStockAvail.Visible = false;
					}
					bool flag5 = MyProject.Forms.Form1.DateChange == 1;
					if (flag5)
					{
						this.DateTimePicker2.Enabled = true;
					}
					else
					{
						this.DateTimePicker2.Enabled = false;
					}
					this.og_customername = "Cash";
					bool flag6 = MyProject.Forms.Form1.IsWarehouse == 1;
					if (flag6)
					{
						this.DataGridView1.Columns["BatchNumber"].Visible = true;
						this.DataGridView1.Columns["ExpiryDate"].Visible = true;
					}
					bool flag7 = MyProject.Forms.Form1.UseCollections == 1;
					if (flag7)
					{
						this.grpCollection.Visible = true;
					}
					else
					{
						this.grpCollection.Visible = false;
					}
					bool flag8 = MyProject.Forms.Form1.AllowInvDiscount == 1;
					if (flag8)
					{
						this.cmdDiscount.Visible = true;
						this.txtDiscount.Visible = true;
						this.Label30.Visible = true;
					}
					else
					{
						this.cmdDiscount.Visible = false;
						this.txtDiscount.Visible = false;
						this.Label30.Visible = false;
					}
					this.EffectTillpointPrice();
					bool flag9 = MyProject.Forms.Form1.PrintFiscal == 1;
					if (flag9)
					{
						bool flag10 = MyProject.Forms.Form1.FiscalEltrade == 1;
						if (flag10)
						{
							this.GetEtradePortSettings(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
						}
					}
					bool flag11 = MyProject.Forms.Form1.RecordConsultant == 1;
					if (flag11)
					{
						this.LoadConsultants();
						this.txtConsultant.Visible = true;
						this.cboConsultant.Visible = true;
					}
					else
					{
						this.txtConsultant.Visible = false;
						this.cboConsultant.Visible = false;
					}
					bool flag12 = MyProject.Forms.Form1.AllowAccountSales == 1;
					if (flag12)
					{
						this.chkAccount.Visible = true;
					}
					else
					{
						this.chkAccount.Visible = false;
					}
					this.datProm.Columns.Add("PromNo", typeof(int));
					bool flag13 = MyProject.Forms.Form1.ShowSpecialPrice == 1;
					if (flag13)
					{
						this.cmdSpecialPrice.Visible = true;
					}
					else
					{
						this.cmdSpecialPrice.Visible = false;
					}
					bool flag14 = MyProject.Forms.Form1.OtherProductDetail == 1;
					if (flag14)
					{
						this.DataGridView1.Columns["OtherDetail"].Visible = true;
					}
					bool flag15 = MyProject.Forms.Form1.isRestaurant == 1;
					if (flag15)
					{
						this.Panel4.Visible = true;
						DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
						dataGridViewButtonColumn.HeaderText = "Comments";
						dataGridViewButtonColumn.Text = "Comments";
						dataGridViewButtonColumn.Name = "btnComments";
						dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
						this.DataGridView1.Columns.Add(dataGridViewButtonColumn);
						this.DataGridView1.Columns["ProductCode"].Visible = false;
					}
					this.btnstartshift.Focus();
					bool flag16 = MyProject.Forms.Form1.autoOpenSalesForm == 1;
					if (flag16)
					{
						MyProject.Forms.Form1.autoOpenSalesForm = 0;
						this.CheckShiftStatus();
						DataTable quotationDetails = this.GetQuotationDetails();
						bool flag17 = quotationDetails.Rows.Count > 0;
						if (flag17)
						{
							DataRow dataRow = quotationDetails.Rows[0];
							this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["customerRefEntryno"]);
							this.FetchCustomerByEntryno(this.currentCustomerEntryNo);
							this.currQuotationNumber = Conversions.ToInteger(dataRow["QuotationNum"]);
						}
						int num2 = MyProject.Forms.Form1.dgvQuotations.Rows.Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							this.DataGridView1.Rows.Add(MyProject.Forms.Form1.dgvQuotations.Rows[i].Cells.Cast<DataGridViewCell>().Select<DataGridViewCell, object>((Sales2mono2._Closure$__.$I883-0 == null) ? (Sales2mono2._Closure$__.$I883-0 = (DataGridViewCell c) => c.Value) : Sales2mono2._Closure$__.$I883-0).ToArray<object>());
						}
						this.CalcTotalSale();
						MyProject.Forms.Form1.quotationnumber = 0;
					}
					bool flag18 = (MyProject.Forms.Form1.allBranches.Rows.Count > 1) & (MyProject.Forms.Form1.AllowTellerToViewStockBalances == 1);
					if (flag18)
					{
						this.Button19.Visible = true;
					}
					else
					{
						this.Button19.Visible = false;
					}
					bool flag19 = MyProject.Forms.Form1.deposits_inuse != 0;
					if (flag19)
					{
						this.cmdDeposits.Visible = true;
					}
					else
					{
						this.cmdDeposits.Visible = false;
					}
					bool flag20 = MyProject.Forms.Form1.ConsultantDefaultToUsername == 1;
					if (flag20)
					{
						this.cboConsultant.SelectedIndex = this.cboConsultant.FindStringExact(MyProject.Forms.Form1.username);
					}
					this.dat_additionalsettings = this.pf.GetAdditionalSettingsPrinters(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.receipt_template);
					bool flag21 = this.dat_additionalsettings.Rows.Count > 0;
					if (flag21)
					{
						DataRow dataRow2 = this.dat_additionalsettings.Rows[0];
						this.desc_spacing = Conversions.ToInteger(dataRow2["receipt_desc_spacing"]);
						this.qty_spacing = Conversions.ToInteger(dataRow2["receipt_qty_spacing"]);
						this.unitprice_spacing = Conversions.ToInteger(dataRow2["receipt_unitprice_spacing"]);
						this.total_spacing = Conversions.ToInteger(dataRow2["receipt_total_spacing"]);
						this.tax_spacing = Conversions.ToInteger(dataRow2["receipt_tax_spacing"]);
					}
					this.DTpromos.Columns.Add("ProductID", typeof(int));
					this.DTpromos.Columns.Add("Qty", typeof(decimal));
					this.DTpromos.Columns.Add("PromoNo", typeof(int));
					DataTable dataTable = new DataTable();
					MyProject.Forms.Form1.datSerialsSelect4Sales = dataTable;
					this.receiptpaymethrate = this.pf.GetRate(this._cnn, MyProject.Forms.Form1.ReceiptDisplayPaymentMethod);
				}
				catch (Exception ex2)
				{
					MessageBox.Show("error loading form. Detail: " + ex2.Message);
				}
			}
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x0024753C File Offset: 0x0024573C
		private void EffectTillpointPrice()
		{
			bool flag = MyProject.Forms.Form1.TillPointPriceChange == 1;
			if (flag)
			{
				this.Button6.Visible = true;
				this.txtPriceChange.Visible = true;
				this.txtPriceChange.ReadOnly = true;
				bool flag2 = MyProject.Forms.Form1.DiscountEditingAllowed == 1;
				if (flag2)
				{
					this.txtPriceChange.ReadOnly = false;
				}
				else
				{
					this.txtPriceChange.ReadOnly = true;
				}
				bool flag3 = MyProject.Forms.Form1.AllowDirectPriceEditing == 1;
				if (flag3)
				{
					this.txtDiscount.Enabled = true;
					this.txtPrice.Enabled = true;
				}
				else
				{
					this.txtDiscount.Enabled = false;
					this.txtPrice.Enabled = false;
				}
			}
			else
			{
				this.Button6.Visible = false;
				this.txtPriceChange.Visible = false;
				this.txtPrice.ReadOnly = true;
				this.txtPrice.Enabled = false;
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00247648 File Offset: 0x00245848
		private DataTable GetQuotationDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select * from quotations where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" And branch='",
				MyProject.Forms.Form1.branch,
				"' and QuotationNum=",
				Conversions.ToString(MyProject.Forms.Form1.quotationnumber)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x002476F8 File Offset: 0x002458F8
		private void LoadConsultants()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboConsultant.DataSource = dataTable;
			this.cboConsultant.ValueMember = "Username";
			this.cboConsultant.DisplayMember = "UserName";
			this.cboConsultant.SelectedIndex = -1;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x002477A4 File Offset: 0x002459A4
		private void SetBranchColour()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchColour";
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					try
					{
						this.GroupBox1.BackColor = Color.FromName(dataRow[0].ToString());
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x00247894 File Offset: 0x00245A94
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

		// Token: 0x06004051 RID: 16465 RVA: 0x002479BC File Offset: 0x00245BBC
		private bool CheckIFPayMethACcurate()
		{
			bool flag2;
			try
			{
				bool flag = (Convert.ToDouble(Conversion.Val(this.pf.RemoveComma(this.txtChange.Text))) < 0.0) | (Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) < Convert.ToDouble(Conversion.Val(this.txtTotal.Text)));
				if (flag)
				{
					flag2 = false;
				}
				else
				{
					bool flag3 = (this.paymeth_fiscalgroup == 1) | (this.paymeth_fiscalgroup == 2) | (this.paymeth_fiscalgroup == 3) | (this.paymeth_fiscalgroup == 4);
					if (flag3)
					{
						double num = Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text));
						double num2 = Convert.ToDouble(Conversion.Val(this.txtChange.Text));
						decimal num3 = new decimal(Conversion.Val(this.txtChange.Text));
						string text = this.txtChange.Text.ToString().Replace(",", "");
						decimal num4 = new decimal(Conversion.Val(text));
						double num5 = Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) - Convert.ToDouble(Conversion.Val(this.txtChange.Text));
						double num6 = Convert.ToDouble(Conversion.Val(this.txtTotal.Text));
						bool flag4 = Math.Round(Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) - Convert.ToDouble(num4), 2, MidpointRounding.AwayFromZero) != Math.Round(Convert.ToDouble(Conversion.Val(this.txtTotal.Text)), 2, MidpointRounding.AwayFromZero);
						if (flag4)
						{
							return false;
						}
					}
					else
					{
						bool flag5 = Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) != Convert.ToDouble(Conversion.Val(this.txtTotal.Text));
						if (flag5)
						{
							MessageBox.Show("Change not allowed for payment method.");
							return false;
						}
					}
					flag2 = true;
				}
			}
			catch (Exception ex)
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProdtID_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x00247BE4 File Offset: 0x00245DE4
		private void txtSearchProdtID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtPrice.Text = Conversions.ToString(0);
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

		// Token: 0x06004054 RID: 16468 RVA: 0x00247CEC File Offset: 0x00245EEC
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
					num = decimal.Add(num, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
					num2 = decimal.Add(num2, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
					bool flag = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
					if (flag)
					{
						this.DataGridView1.Rows.RemoveAt(checked(this.DataGridView1.Rows.Count - 1));
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
			num = Math.Round(num, 2, MidpointRounding.AwayFromZero);
			bool flag2 = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedPerc, 0m) != 0;
			if (flag2)
			{
				num3 = Math.Round(decimal.Multiply(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m), num), 5, MidpointRounding.AwayFromZero);
				ref string ptr = ref this.discDESC;
				this.discDESC = ptr + "Invoice Discount Approved by " + MyProject.Forms.Form1.Approvedby;
			}
			else
			{
				num3 = 0m;
			}
			bool flag3 = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedAmt, 0m) != 0;
			if (flag3)
			{
				num3 = MyProject.Forms.Form1.DiscountApprovedAmt;
				ref string ptr = ref this.discDESC;
				this.discDESC = ptr + "Invoice Discount Approved by " + MyProject.Forms.Form1.Approvedby;
			}
			else
			{
				num3 = 0m;
			}
			bool flag4 = MyProject.Forms.Form1.AllowDirectPriceEditing == 1;
			if (flag4)
			{
				num3 = Conversions.ToDecimal(Conversions.ToString(num3) + Conversions.ToString(Conversion.Val(this.txtDiscount.Text)));
			}
			this.txtDiscount.Text = num3.ToString();
			num = decimal.Subtract(num, num3);
			this.txtTotal.Text = Conversions.ToString(Math.Round(num, 2, MidpointRounding.AwayFromZero));
			this.txtTax.Text = Conversions.ToString(Math.Round(num2, 2, MidpointRounding.AwayFromZero));
			MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
			double num4 = Conversion.Val(this.txtAmtPaid.Text) - Conversion.Val(this.txtTotal.Text);
			this.txtChange.Text = num4.ToString("#,0.00");
			this.UpdateCustomerDisplayVFD(this.txtTotal.Text);
			checked
			{
				int num5 = this.DataGridView1.Rows.Count - 1;
				for (int i = 0; i <= num5; i++)
				{
					this.DataGridView1.Rows[i].HeaderCell.Value = "Del";
				}
				this.DataGridView1.RowHeadersWidth = 60;
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0024803C File Offset: 0x0024623C
		private decimal FetchProductTaxRateByCode(string productcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			bool flag = Operators.ConditionalCompareObjectEqual(dataRow["TaxRate"], 0, false);
			decimal num2;
			if (flag)
			{
				num2 = 1m;
			}
			else
			{
				num2 = Conversions.ToDecimal(Operators.AddObject(1, Operators.DivideObject(dataRow["TaxRate"], 100)));
			}
			return num2;
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x00248124 File Offset: 0x00246324
		private void FetchProdtDetails(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcost.Text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
				{
					Operators.MultiplyObject(dataRow["Cost"], this.mono_rate),
					2,
					MidpointRounding.AwayFromZero
				}, null, null, null));
				double num2 = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])));
				this.currenttaxrate = new decimal(num2);
				double num3 = Conversions.ToDouble(dataRow["SellingPrice"]);
				num3 += num3 * num2;
				this.txtPrice.Text = num3.ToString();
				this.currprice = Conversions.ToDouble(num3.ToString());
				this.lbltax.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])));
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.currentIsDeposit = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])), 0, RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])));
				bool flag2 = Operators.CompareString(this.txtSearchProductCode.Text, "", false) != 0;
				if (flag2)
				{
					this.currentUOM = dataRow["UOM"].ToString();
					this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, MyProject.Forms.Form1.IsWarehouse, this.currentExpires, "", 0, false));
				}
			}
			else
			{
				this.txtDesc.Text = "Nothing matching product ID";
			}
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x0024841C File Offset: 0x0024661C
		private void AppendGrid()
		{
			bool flag = !this.DisableEditing;
			checked
			{
				if (flag)
				{
					bool flag2 = this.CurrentID == 0;
					if (!flag2)
					{
						bool flag3 = !this.currentIsCalcLxW;
						if (flag3)
						{
							bool flag4 = (Operators.CompareString(this.CurrentCode, "1", false) != 0) & (MyProject.Forms.Form1.isRestaurant != 1) & (MyProject.Forms.Form1.OtherProductDetail != 1);
							if (flag4)
							{
								int num = this.DataGridView1.RowCount - 1;
								for (int i = 0; i <= num; i++)
								{
									decimal num2 = Math.Round(decimal.Add(Convert.ToDecimal(unchecked(Convert.ToDouble(Convert.ToDecimal(this.txtPrice.Text)) - Conversion.Val(this.txtPriceChange.Text)) / Convert.ToDouble(decimal.Add(1m, decimal.Divide(Convert.ToDecimal(this.lbltax.Text), 100m)))), this.discTeller), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
									bool flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridView1.Rows[i].Cells["ProdtID"].Value, this.CurrentID, false), decimal.Compare(Conversions.ToDecimal(this.DataGridView1.Rows[i].Cells["UnitPrice"].Value), num2) == 0));
									if (flag5)
									{
										decimal num3 = Conversions.ToDecimal(Operators.DivideObject(this.DataGridView1.Rows[i].Cells["Tax"].Value, this.DataGridView1.Rows[i].Cells["Qty"].Value));
										decimal num4 = Conversions.ToDecimal(Operators.AddObject(this.DataGridView1.Rows[i].Cells["Qty"].Value, Conversions.ToDecimal(this.txtQty.Text)));
										decimal stockAvailable = this.pf.GetStockAvailable(MyProject.Forms.Form1.Constring, this.CurrentID, this.DataGridView1, this.currentUOM, MyProject.Forms.Form1.isRestaurant, MyProject.Forms.Form1.IsWarehouse, false, "", 0, false);
										bool flag6 = (decimal.Compare(Conversions.ToDecimal(this.txtQty.Text), stockAvailable) <= 0) & ((MyProject.Forms.Form1.NegativeStock == 0) | !this.isunedingstock);
										if (flag6)
										{
											this.DataGridView1.Rows[i].Cells["Qty"].Value = Operators.AddObject(this.DataGridView1.Rows[i].Cells["Qty"].Value, Conversions.ToDecimal(this.txtQty.Text));
											this.DataGridView1.Rows[i].Cells["Tax"].Value = Operators.MultiplyObject(num3, this.DataGridView1.Rows[i].Cells["Qty"].Value);
											this.DataGridView1.Rows[i].Cells["Total"].Value = Operators.AddObject(Operators.MultiplyObject(this.DataGridView1.Rows[i].Cells["UnitPrice"].Value, this.DataGridView1.Rows[i].Cells["Qty"].Value), this.DataGridView1.Rows[i].Cells["Tax"].Value);
											this.DataGridView1.Rows[i].Cells["RowNumber"].Value = this.RowID.ToString();
											this.RowID++;
											this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
											bool flag7 = (MyProject.Forms.Form1.TillPointPriceChange == 1) & (MyProject.Forms.Form1.DiscountEditingAllowed == 1);
											if (flag7)
											{
												this.txtPriceChange.ReadOnly = false;
											}
											else
											{
												this.txtPriceChange.ReadOnly = true;
											}
											this.txtPriceChange.Text = "";
											this.discDESC = "";
											this.CheckPromotions();
											this.txtQty.ReadOnly = false;
											this.CalcTotalSale();
											return;
										}
									}
								}
							}
						}
						string text = "";
						bool flag8 = this.currentIsCalcLxW;
						if (flag8)
						{
							text = "Length: " + MyProject.Forms.Form1.calcLxWLength.ToString() + ", Width: " + MyProject.Forms.Form1.calcLxWWidth.ToString();
						}
						int num5 = 0;
						int num6 = 0;
						decimal num7 = 0m;
						this.discTeller = 0m;
						this.discDESC = "";
						bool flag9 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
						bool flag11;
						unchecked
						{
							if (flag9)
							{
								this.discTeller = Convert.ToDecimal(this.txtPriceChange.Text);
								this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
								num6 = 1;
								decimal num8 = new decimal(Conversion.Val(this.txtPrice.Text) + Convert.ToDouble(this.discTeller));
								this.txtPrice.Text = num8.ToString();
							}
							else
							{
								this.discTeller = 0m;
								num6 = 0;
							}
							bool flag10 = Conversion.Val(this.lbltax.Text) > 0.0;
							if (flag10)
							{
								this.priceb4tax = new decimal(Math.Round(Conversion.Val(this.txtPrice.Text) / (1.0 + Conversion.Val(this.lbltax.Text) / 100.0), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
							}
							else
							{
								this.priceb4tax = new decimal(Math.Round(Conversion.Val(this.txtPrice.Text), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
							}
							flag11 = !this.currentExpires;
						}
						if (flag11)
						{
							bool flag12 = Conversion.Val(this.txtQty.Text) == 0.0;
							if (flag12)
							{
								MessageBox.Show("Please enter a valid quantity.");
								return;
							}
							bool flag13 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
							if (flag13)
							{
								num5 = (int)Math.Round(Conversion.Val(this.txtCoupons.Text));
							}
							bool flag14 = MyProject.Forms.Form1.AllowDirectPriceEditing == 1;
							if (flag14)
							{
							}
							decimal num9 = Convert.ToDecimal(this.lbltax.Text);
							string[] array;
							unchecked
							{
								decimal num10 = new decimal(Convert.ToDouble(Math.Round(decimal.Multiply(decimal.Divide(num9, 100m), this.priceb4tax), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text));
								this.PriceBeforeTax = this.priceb4tax;
								decimal num11 = new decimal(Convert.ToDouble(this.priceb4tax) + Convert.ToDouble(num10) / Conversion.Val(this.txtQty.Text));
								bool flag15 = decimal.Compare(num9, 0m) != 0;
								decimal num12;
								decimal num13;
								decimal num14;
								if (flag15)
								{
									num12 = Math.Round(this.PriceBeforeTax, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
									num13 = num10;
									num14 = decimal.Divide(num9, 100m);
								}
								else
								{
									num12 = Math.Round(num11, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
									num13 = 0m;
									num14 = 0m;
								}
								decimal num15 = new decimal(Math.Round(Convert.ToDouble(num12) * Conversion.Val(this.txtQty.Text) + Convert.ToDouble(num13), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
								string text2 = "";
								string text3 = Conversions.ToString(this.discAmount);
								bool flag16 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
								if (flag16)
								{
									text2 = this.discPaymentMethod.ToString();
								}
								bool flag17 = decimal.Compare(this.discTeller, 0m) != 0;
								if (flag17)
								{
									num7 = decimal.Add(num7, this.discTeller);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + "Product Discount, " + MyProject.Forms.Form1.Approvedby;
								}
								bool flag18 = decimal.Compare(this.discAmount, 0m) != 0;
								if (flag18)
								{
									num7 = decimal.Add(num7, this.discAmount);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
								}
								bool flag19 = decimal.Compare(this.discCoupons, 0m) != 0;
								if (flag19)
								{
									num7 = decimal.Add(num7, this.discCoupons);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + "Coupon Discount, ";
								}
								bool flag20 = decimal.Compare(this.discPromotion, 0m) != 0;
								if (flag20)
								{
									num7 = decimal.Add(num7, this.discPromotion);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + this.discPromotionName + ", ";
								}
								array = new string[]
								{
									Conversions.ToString(this.CurrentID),
									this.CurrentCode,
									this.txtDesc.Text + " " + this.altdescription,
									num12.ToString(),
									this.txtQty.Text,
									num13.ToString(),
									Conversions.ToString(num15),
									this.lblcost.Text,
									Conversions.ToString(num5),
									Conversions.ToString(this.priceb4tax),
									Conversions.ToString(num6),
									"0",
									"",
									Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
									Conversions.ToString(this.WholesalePriceByQty),
									this.discDESC,
									text2,
									num7.ToString(),
									"",
									Conversions.ToString(0),
									Conversions.ToString(num14),
									"",
									MyProject.Forms.Form1.OtherDetail,
									Conversions.ToString(this.CurrentIsVoucher),
									text,
									this.RowID.ToString(),
									this.currentUOM,
									Conversions.ToString(this.currBreak),
									Conversions.ToString(this.currCaseQty),
									Conversions.ToString(this.currParentCaseID),
									Conversions.ToString(this.BreakQtyActual),
									Conversions.ToString(this.current_taxexempt),
									Conversions.ToString(this.currentIsDeposit),
									this.altdescription,
									this.CurrentHSCode,
									Conversions.ToString(this.isunedingstock)
								};
							}
							this.RowID++;
							this.DataGridView1.Rows.Add(array);
						}
						else
						{
							DataTable selectedBatch = MyProject.Forms.Form1.SelectedBatch;
							bool flag21 = selectedBatch.Rows.Count > 0;
							if (flag21)
							{
								try
								{
									foreach (object obj in selectedBatch.Rows)
									{
										DataRow dataRow = (DataRow)obj;
										int num16;
										try
										{
											num16 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"]));
										}
										catch (Exception ex)
										{
											num16 = 0;
										}
										bool flag22 = num16 != 0;
										if (flag22)
										{
											this.txtQty.Text = num16.ToString();
											bool flag23 = MyProject.Forms.Form1.UsePriceMatrix == 1;
											if (flag23)
											{
												this.setPriceMatrix();
											}
											bool flag24 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
											if (flag24)
											{
												num5 = (int)Math.Round(Conversion.Val(this.txtCoupons.Text));
											}
											decimal num17 = 0m;
											decimal num18 = Convert.ToDecimal(this.lbltax.Text);
											decimal num19 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num17);
											bool flag25 = decimal.Compare(num18, 0m) != 0;
											string[] array2;
											unchecked
											{
												decimal num12;
												decimal num13;
												decimal num14;
												if (flag25)
												{
													num12 = decimal.Divide(num19, decimal.Add(1m, decimal.Divide(num18, 100m)));
													num12 = num12;
													num13 = new decimal(Math.Round(Convert.ToDouble(num12) * Conversion.Val(this.txtQty.Text) * Convert.ToDouble(decimal.Divide(num18, 100m)), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
													num14 = Math.Round(decimal.Divide(num18, 100m), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
												}
												else
												{
													num12 = num19;
													num13 = 0m;
													num14 = 0m;
												}
												decimal num20 = new decimal(Math.Round(Convert.ToDouble(num12) * Conversion.Val(this.txtQty.Text) * Convert.ToDouble(decimal.Add(1m, decimal.Divide(num18, 100m))), 2, MidpointRounding.AwayFromZero));
												string text4 = "";
												bool flag26 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
												if (flag26)
												{
													text4 = this.discPaymentMethod.ToString();
												}
												bool flag27 = decimal.Compare(this.discTeller, 0m) != 0;
												if (flag27)
												{
													num7 = decimal.Add(num7, this.discTeller);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + "Cashier Discount, " + MyProject.Forms.Form1.Approvedby;
												}
												bool flag28 = decimal.Compare(this.discAmount, 0m) != 0;
												if (flag28)
												{
													num7 = decimal.Add(num7, this.discAmount);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
												}
												bool flag29 = decimal.Compare(this.discCoupons, 0m) != 0;
												if (flag29)
												{
													num7 = decimal.Add(num7, this.discCoupons);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + "Coupon Discount, ";
												}
												bool flag30 = decimal.Compare(this.discPromotion, 0m) != 0;
												if (flag30)
												{
													num7 = decimal.Add(num7, this.discPromotion);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + this.discPromotionName + ", ";
												}
												array2 = new string[]
												{
													Conversions.ToString(this.CurrentID),
													this.CurrentCode,
													this.txtDesc.Text + " " + this.altdescription,
													num12.ToString(),
													num16.ToString(),
													num13.ToString(),
													num20.ToString(),
													this.lblcost.Text,
													Conversions.ToString(num5),
													Conversions.ToString(this.priceb4tax),
													Conversions.ToString(num6),
													"0",
													"",
													Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
													Conversions.ToString(this.WholesalePriceByQty),
													this.discDESC,
													text4,
													num7.ToString(),
													dataRow["BatchNumber"].ToString(),
													dataRow["ExpiryDate"].ToString(),
													Conversions.ToString(num14),
													"",
													MyProject.Forms.Form1.OtherDetail,
													Conversions.ToString(this.CurrentIsVoucher),
													text,
													this.RowID.ToString(),
													this.currentUOM,
													Conversions.ToString(this.currBreak),
													Conversions.ToString(this.currCaseQty),
													Conversions.ToString(this.currParentCaseID),
													Conversions.ToString(this.BreakQtyActual),
													Conversions.ToString(this.current_taxexempt),
													Conversions.ToString(this.currentIsDeposit),
													this.altdescription,
													this.CurrentHSCode,
													Conversions.ToString(this.isunedingstock)
												};
											}
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
						bool flag31 = (MyProject.Forms.Form1.TillPointPriceChange == 1) & (MyProject.Forms.Form1.DiscountEditingAllowed == 1);
						if (flag31)
						{
							this.txtPriceChange.ReadOnly = false;
						}
						else
						{
							this.txtPriceChange.ReadOnly = true;
						}
						bool flag32 = MyProject.Forms.Form1.pendinginvoice_entryno != 0;
						if (flag32)
						{
							this.UpdatePendingInv();
						}
						this.txtPriceChange.Text = "";
						this.discTeller = 0m;
						this.discDESC = "";
						this.CheckPromotions();
						this.txtQty.ReadOnly = false;
						this.CurrentID = 0;
						this.txtStockAvail.Text = "0";
						this.txtPrice.Text = "0";
						this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
						text = "";
						this.currComment = "";
						this.currBreak = 0;
						this.lbltotprice.Text = "...";
						MyProject.Forms.Form1.DiscountApproved = 0;
						MyProject.Forms.Form1.approved = false;
						DataTable dataTable = new DataTable();
						this.DGVSearch.DataSource = dataTable;
						this.txtPrice.Text = Conversions.ToString(0);
						this.txtStockAvail.Text = Conversions.ToString(0);
					}
				}
				else
				{
					MessageBox.Show("Editing not allowed for pending invoice.");
				}
			}
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x002497F4 File Offset: 0x002479F4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.EnterProduct();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending data. Details: " + ex.Message);
			}
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00249844 File Offset: 0x00247A44
		private void EnterProduct()
		{
			bool flag = this.currentExpires;
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
				bool flag4 = this.currentIsCalcLxW;
				if (flag4)
				{
					CalcLxW calcLxW = new CalcLxW();
					calcLxW.currDesc = Conversions.ToString(this.CurrentID);
					calcLxW.ShowDialog(this);
					calcLxW.Dispose();
					this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.calcLxWTOTAL);
					this.EnterItem();
					MyProject.Forms.Form1.calcLxWLength = 0m;
					MyProject.Forms.Form1.calcLxWTOTAL = 0m;
					MyProject.Forms.Form1.calcLxWWidth = 0m;
				}
				else
				{
					bool flag5 = (Operators.CompareString(this.txtQty.Text, "", false) != 0) | (Conversion.Val(this.txtQty.Text) != 0.0);
					if (flag5)
					{
						bool currentRecordSerial = this.CurrentRecordSerial;
						if (currentRecordSerial)
						{
							SelectSerialNumbers selectSerialNumbers = new SelectSerialNumbers();
							selectSerialNumbers.productid = this.CurrentID;
							selectSerialNumbers.productdesc = this.txtDesc.Text;
							selectSerialNumbers.numofproducts = checked((int)Math.Round(Conversion.Val(this.txtQty.Text)));
							selectSerialNumbers.ShowDialog(this);
							selectSerialNumbers.Dispose();
							bool flag6 = (double)MyProject.Forms.Form1.datSerialsSelect4Sales.Rows.Count == Conversion.Val(this.txtQty.Text);
							if (flag6)
							{
								this.EnterItem();
							}
							else
							{
								MessageBox.Show("Insufficient serial numbers selected. " + MyProject.Forms.Form1.serialNumberName + ". Cannot continue.");
							}
						}
						else
						{
							this.EnterItem();
						}
					}
					else
					{
						MessageBox.Show("Please enter the qty first.");
						this.txtQty.Focus();
					}
				}
			}
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00249AFC File Offset: 0x00247CFC
		private void EnterItem()
		{
			this.EffectTillpointPrice();
			bool flag = this.Verify();
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txtCoupons.Text, "", false) == 0;
				bool flag3 = flag2 || this.ProcessCoupon();
				bool flag4 = flag3;
				if (flag4)
				{
					bool flag5 = MyProject.Forms.Form1.OtherProductDetail == 1;
					if (flag5)
					{
						OtherProductDetail otherProductDetail = new OtherProductDetail();
						otherProductDetail.ShowDialog(this);
						otherProductDetail.Dispose();
					}
					string otherDetail = MyProject.Forms.Form1.OtherDetail;
					bool flag6 = MyProject.Forms.Form1.UseConnectedScale != 0;
					if (flag6)
					{
						bool flag7 = this.currentIsWeighed;
						if (flag7)
						{
							this.StartWeighedItemVerification();
						}
						else
						{
							this.AppendGrid();
							this.CalcTotalSale();
						}
					}
					else
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

		// Token: 0x0600405B RID: 16475 RVA: 0x00249C18 File Offset: 0x00247E18
		private void EnterItemClear()
		{
			this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.lblCouponInfo.Text = "...";
			this.txtCoupons.Text = "";
			this.txtsearch.Text = "";
			this.txtBarCode.Text = "";
			this.txtPriceChange.Text = "";
			this.lblcode.Text = "";
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

		// Token: 0x0600405C RID: 16476 RVA: 0x00249CF8 File Offset: 0x00247EF8
		private void UpdateCustomerDisplayVFD(string total)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.hascustomerdisplayvfd == 1;
				if (flag)
				{
					SerialPort serialPort = new SerialPort();
					serialPort.PortName = MyProject.Forms.Form1.customerdisplayCOMPORT;
					serialPort.BaudRate = 9600;
					serialPort.Parity = Parity.None;
					serialPort.DataBits = 8;
					serialPort.StopBits = StopBits.One;
					serialPort.Open();
					serialPort.Write(Convert.ToString('\f'));
					serialPort.WriteLine("Current Total: " + MyProject.Forms.Form1.basecurrency + total);
					serialPort.WriteLine(Convert.ToString('\r') + MyProject.Forms.Form1.customerdisplayvfdMessage);
					serialPort.Close();
					serialPort.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error updating second screen");
			}
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00249DF8 File Offset: 0x00247FF8
		public bool Verify()
		{
			this.currBreak = 0;
			bool flag = true;
			bool flag2 = (MyProject.Forms.Form1.NegativeStock == 1) | this.isunedingstock;
			bool flag5;
			if (flag2)
			{
				bool flag3 = MyProject.Forms.Form1.autoBreakCase == 1;
				if (flag3)
				{
					bool flag4 = this.currParentCaseID == 0;
					if (flag4)
					{
						this.currBreak = 0;
						flag = true;
						flag5 = flag;
					}
					else
					{
						bool flag6 = Conversion.Val(this.txtQty.Text) < Conversion.Val(this.txtStockAvail.Text);
						if (flag6)
						{
							int num = Convert.ToInt32(this.pf.GetStockAvailable(this._cnn, this.currParentCaseID, this.DataGridView1, "EA", 0, 0, false, "", 0, false));
							bool flag7 = (double)(checked(num * this.currCaseQty)) + Conversion.Val(this.txtStockAvail.Text) >= Conversion.Val(this.txtQty.Text);
							checked
							{
								if (flag7)
								{
									this.BreakQtyActual = (int)Math.Round(Math.Ceiling(unchecked(Conversion.Val(this.txtQty.Text) - Conversion.Val(this.txtStockAvail.Text)) / (double)this.currCaseQty));
									this.currBreak = 1;
									flag = true;
									flag5 = flag;
								}
								else
								{
									this.currBreak = 0;
									flag = true;
									flag5 = flag;
								}
							}
						}
						else
						{
							this.currBreak = 0;
							flag = true;
							flag5 = flag;
						}
					}
				}
				else
				{
					this.currBreak = 0;
					flag = true;
					flag5 = flag;
				}
			}
			else
			{
				bool flag8 = MyProject.Forms.Form1.NegativeStock == 0;
				if (flag8)
				{
					bool flag9 = this.isunedingstock;
					if (flag9)
					{
						this.currBreak = 0;
						return true;
					}
					decimal num2 = decimal.Subtract(Convert.ToDecimal(this.txtStockAvail.Text), Convert.ToDecimal(this.txtQty.Text));
					bool flag10 = decimal.Compare(num2, 0m) < 0;
					if (flag10)
					{
						bool flag11 = MyProject.Forms.Form1.autoBreakCase == 1;
						if (!flag11)
						{
							this.currBreak = 0;
							return false;
						}
						bool flag12 = this.currParentCaseID == 0;
						if (flag12)
						{
							this.currBreak = 0;
							return false;
						}
						int num3 = Convert.ToInt32(this.pf.GetStockAvailable(this._cnn, this.currParentCaseID, this.DataGridView1, "EA", 0, 0, false, "", 0, false));
						bool flag13 = (double)(checked(num3 * this.currCaseQty)) + Conversion.Val(this.txtStockAvail.Text) >= Conversion.Val(this.txtQty.Text);
						checked
						{
							if (flag13)
							{
								this.BreakQtyActual = (int)Math.Round(Math.Ceiling(unchecked(Conversion.Val(this.txtQty.Text) - Conversion.Val(this.txtStockAvail.Text)) / (double)this.currCaseQty));
								this.currBreak = 1;
								return true;
							}
							this.currBreak = 0;
							return false;
						}
					}
				}
				bool flag14 = Conversion.Val(this.txtPrice.Text) == 0.0;
				if (flag14)
				{
					this.currBreak = 0;
					flag = false;
					flag5 = flag;
				}
				else
				{
					this.currBreak = 0;
					flag5 = flag;
				}
			}
			return flag5;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0024A138 File Offset: 0x00248338
		private int GetInvoiceNumSales()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetSalesInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenumber", 0);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0024A254 File Offset: 0x00248454
		private void InsertSale(int prodtid, decimal saleqty, double unitcost, double salesprice, int paymentmethod, int invnum, string prodcode, int thetime, double taxamt, string shift, int shiftdate, int pricewholesale, int pricewholesalebyqty, string saletype, string batchnumber, int expirydate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewSale3";
			sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			sqlCommand.Parameters.AddWithValue("productid", prodtid);
			sqlCommand.Parameters.AddWithValue("isstockin", 0);
			sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("quantity", saleqty);
			sqlCommand.Parameters.AddWithValue("unitcost", unitcost);
			sqlCommand.Parameters.AddWithValue("salesprice", salesprice);
			sqlCommand.Parameters.AddWithValue("paymentmethod", paymentmethod);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("trancode", 3);
			sqlCommand.Parameters.AddWithValue("prodcode", prodcode);
			sqlCommand.Parameters.AddWithValue("TranTime", thetime);
			sqlCommand.Parameters.AddWithValue("taxamt", taxamt);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("shift", shift);
			sqlCommand.Parameters.AddWithValue("ShiftDate", shiftdate);
			sqlCommand.Parameters.AddWithValue("iswholesaleprice", pricewholesale);
			sqlCommand.Parameters.AddWithValue("iswholesalepricebyqty", pricewholesalebyqty);
			sqlCommand.Parameters.AddWithValue("saletype", saletype);
			sqlCommand.Parameters.AddWithValue("batchnumber", batchnumber);
			sqlCommand.Parameters.AddWithValue("expirydate", expirydate);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0024A524 File Offset: 0x00248724
		private void MarkCouponAsUsed(object coupnum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateCoupon";
			sqlCommand.Parameters.AddWithValue("CouponNumber", RuntimeHelpers.GetObjectValue(coupnum));
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x0024A5A8 File Offset: 0x002487A8
		private void ProcessSale()
		{
			try
			{
				bool flag = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", MyProject.Forms.Form1.Constring), "1", false) == 0;
				if (flag)
				{
					bool flag2 = (Operators.CompareString(this.txtcustomer.Text, "", false) == 0) | (Operators.CompareString(this.txtcustomer.Text, "Cash", false) == 0);
					if (flag2)
					{
						MessageBox.Show("Please enter a customer first for fiscalisation.");
						return;
					}
				}
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
						MessageBox.Show("Please select a product And press ENTER first.");
					}
				}
				else
				{
					MessageBox.Show("Sales are Not allowed on this computer.");
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
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error performing sale. Detail:  " + ex.Message);
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x0024A740 File Offset: 0x00248940
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.Button2.Enabled = false;
				Cursor.Current = Cursors.WaitCursor;
				this.ProcessSale();
			}
			finally
			{
				Cursor.Current = Cursors.Default;
				this.Button2.Enabled = true;
			}
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x0024A79C File Offset: 0x0024899C
		private int GetInvNumberSales()
		{
			int num;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetSalesInvoiceNumber";
				sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
				bool flag = (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1) | (MyProject.Forms.Form1.DateChange == 1);
				if (flag)
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
				sqlCommand.Parameters.AddWithValue("OrderNo", this.txtOrderNo.Text);
				bool flag2 = MyProject.Forms.Form1.isZimraVirtFiscal == 1;
				if (flag2)
				{
					sqlCommand.Parameters.AddWithValue("FiscalDay", this.pf.GetFiscalDayNo(this.pf.FiscalGetDeviceID(this._cnn, this.pf.FiscalGetDeviceSerial(), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch), DateTime.Today, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn));
					sqlCommand.Parameters.AddWithValue("receipttype", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.PrintReceipt == 1, "Receipt48", "InvoiceA4")));
				}
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				this.invnum = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
				num = this.invnum;
			}
			catch (Exception ex)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x0024AA70 File Offset: 0x00248C70
		private void ConfirmSale()
		{
			string text = "";
			this.DepositUsed = false;
			bool flag = this.DataGridView1.Rows.Count < 1;
			checked
			{
				if (flag)
				{
					MessageBox.Show("There are no products selected. Cannot proceed.");
				}
				else
				{
					string text2 = "";
					bool flag2 = MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1;
					if (!flag2)
					{
						bool flag3 = DateTime.Compare(this.DTdate.Value.Date, DateTime.Today.Date) > 0;
						if (flag3)
						{
							MessageBox.Show("Date selected is greater than today's date. Cannot proceed.");
							return;
						}
					}
					Cursor.Current = Cursors.WaitCursor;
					bool flag4 = this.paymeth_requiresref;
					if (flag4)
					{
						PayMethRef payMethRef = new PayMethRef();
						bool flag5 = payMethRef.ShowDialog() == DialogResult.OK;
						if (flag5)
						{
							text2 = this.paymeth_desc + " ref: " + payMethRef.txtRef.Text;
						}
					}
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					try
					{
						this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Ascending);
						sqlConnection.Open();
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand.CommandType = CommandType.StoredProcedure;
						DataTable dataTable = new DataTable();
						dataTable.Columns.Add("productid", typeof(int));
						dataTable.Columns.Add("qty", typeof(decimal));
						bool flag6 = !this.chkAccount.Checked;
						if (flag6)
						{
							bool flag7 = this.CheckIFPayMethACcurate();
							if (!flag7)
							{
								MessageBox.Show("Check payment methods. Sale cannot proceed.");
								return;
							}
							this.UpdateCustomer();
							bool flag8 = this.rdbCollection.Checked | this.rdpDelivery.Checked;
							if (flag8)
							{
								bool flag9 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) == 0;
								if (flag9)
								{
									MessageBox.Show("For delivery or collection, please select the Customer.");
									return;
								}
							}
							bool flag10 = Conversion.Val(this.txtTotal.Text) == 0.0;
							if (flag10)
							{
								MessageBox.Show("Total sale is 0. Cannot proceed.");
								return;
							}
							int num = 0;
							num = 1;
							bool flag11 = (MyProject.Forms.Form1.RecordConsultant == 1) & (MyProject.Forms.Form1.ConsultantSalesOnly == 1);
							if (flag11)
							{
								bool flag12 = Operators.CompareString(this.cboConsultant.Text, "", false) == 0;
								if (flag12)
								{
									MessageBox.Show("Please select the consultant first.");
									sqlTransaction.Rollback();
									sqlConnection.Close();
									return;
								}
							}
							bool flag13 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
							if (flag13)
							{
								string text3 = "";
								try
								{
									text3 = MyProject.Forms.Form1.myrevmax.GetCardDetails();
									JObject jobject = JObject.Parse(text3);
									string text4 = jobject["Message"].ToObject<string>();
									bool flag14 = Operators.CompareString(text4, "Success", false) != 0;
									if (flag14)
									{
										MessageBox.Show("Error getting card details. " + text4);
									}
								}
								catch (Exception ex)
								{
									MessageBox.Show("Revmax Fiscal Device Error. Sale cannot proceed. Check the device first. Error Details: " + ex.Message + " " + text3);
									return;
								}
							}
							bool flag15 = (MyProject.Forms.Form1.NegativeStock == 0) & (Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "RecheckStockBal", MyProject.Forms.Form1.Constring), "1", false) == 0);
							if (flag15)
							{
								try
								{
									foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
									{
										DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
										bool flag16 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
										if (!flag16)
										{
											bool flag17 = Conversions.ToBoolean(dataGridViewRow.Cells["IsUnlimitedStock"].Value);
											int num2 = Conversions.ToInteger(dataGridViewRow.Cells["Break"].Value);
											bool flag18 = flag17 | (num2 == 1);
											if (!flag18)
											{
												decimal stockAvailable = this.pf.GetStockAvailable(MyProject.Forms.Form1.Constring, Conversions.ToInteger(dataGridViewRow.Cells["Prodtid"].Value), this.DataGridView1, Conversions.ToString(dataGridViewRow.Cells["UOM"].Value), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, true);
												bool flag19 = Operators.ConditionalCompareObjectLess(stockAvailable, dataGridViewRow.Cells["Qty"].Value, false);
												if (flag19)
												{
													MessageBox.Show("Product: " + dataGridViewRow.Cells["Desc"].Value.ToString() + " has insufficient stock. Cannot proceed.");
													return;
												}
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
							this.invnum = this.GetInvNumberSales();
							bool flag20 = this.invnum == 0;
							if (flag20)
							{
								MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
								sqlTransaction.Rollback();
								sqlConnection.Close();
								return;
							}
							string text5 = DateAndTime.TimeOfDay.ToString("HHmm");
							DateTime dateTime = Conversions.ToDate(this.lblShiftDate.Text);
							try
							{
								foreach (object obj2 in ((IEnumerable)this.DataGridView1.Rows))
								{
									DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
									bool flag21 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Prodtid"].Value));
									if (!flag21)
									{
										text = "Current product: " + dataGridViewRow2.Cells["Prodtid"].Value.ToString();
										int num3 = 0;
										bool flag22 = dataGridViewRow2.Cells["Break"].Value != null && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Break"].Value));
										if (flag22)
										{
											int.TryParse(dataGridViewRow2.Cells["Break"].Value.ToString(), out num3);
										}
										bool flag23 = num3 == 1;
										if (flag23)
										{
											text = text + ", breakvalue is " + num3.ToString();
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "GetProductConvertedNumber";
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
											int coid = MyProject.Forms.Form1.coid;
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("newconvertednum", 0);
											int num4 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "InsertProductsConverted";
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("formulaname", "Auto Break Case");
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case");
											sqlCommand.Parameters.AddWithValue("QTYCalculated", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("QTYActual", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["prodtid"].Value));
											sqlCommand.Parameters.AddWithValue("type", "BREAK");
											sqlCommand.Parameters.AddWithValue("convertedproductid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BreakParentProductID"].Value));
											sqlCommand.Parameters.AddWithValue("invnumber", num4);
											sqlCommand.ExecuteNonQuery();
											text = text + ", breakparentprodID: " + dataGridViewRow2.Cells["BreakParentProductID"].Value.ToString();
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertNewStock2Warehouse";
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("invoicenum", num4);
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BreakParentProductID"].Value));
											sqlCommand.Parameters.AddWithValue("isstockin", 0);
											sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case parent");
											sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ActualBreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("cost", 0);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("trancode", 9);
											string productCodeFromID = this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow2.Cells["BreakParentProductID"].Value), this._cnn);
											bool flag24 = Operators.CompareString(productCodeFromID, "", false) == 0;
											if (flag24)
											{
												MessageBox.Show("Error prodcode is empty for product " + dataGridViewRow2.Cells["prodtid"].Value.ToString());
												sqlTransaction.Rollback();
												sqlConnection.Close();
												return;
											}
											sqlCommand.Parameters.AddWithValue("productcode", productCodeFromID);
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("BatchNumber", "");
											sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
											sqlCommand.Parameters.AddWithValue("suppliername", "");
											sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
											sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
											sqlCommand.ExecuteNonQuery();
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertNewStock2Warehouse";
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("invoicenum", num4);
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["prodtid"].Value));
											sqlCommand.Parameters.AddWithValue("isstockin", 1);
											sqlCommand.Parameters.AddWithValue("ref", "Auto Break case child");
											sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataGridViewRow2.Cells["ActualBreakQty"].Value, dataGridViewRow2.Cells["BreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("cost", 0);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("trancode", 9);
											string productCodeFromID2 = this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow2.Cells["prodtid"].Value), this._cnn);
											bool flag25 = Operators.CompareString(productCodeFromID2, "", false) == 0;
											if (flag25)
											{
												MessageBox.Show("Error prodcode2 is empty for product " + dataGridViewRow2.Cells["prodtid"].Value.ToString());
												sqlTransaction.Rollback();
												sqlConnection.Close();
												return;
											}
											sqlCommand.Parameters.AddWithValue("productcode", productCodeFromID2);
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("BatchNumber", "");
											sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
											sqlCommand.Parameters.AddWithValue("suppliername", "");
											sqlCommand.Parameters.AddWithValue("sellingprice", 0);
											sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
											sqlCommand.ExecuteNonQuery();
										}
										decimal num5 = 0m;
										bool flag26 = MyProject.Forms.Form1.isRestaurant == 1;
										if (flag26)
										{
											text += ", at is restaurant";
											DataTable productIngridients = this.pf.GetProductIngridients(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(dataGridViewRow2.Cells["Prodtid"].Value), this._cnn);
											bool flag27 = productIngridients.Rows.Count == 0;
											if (flag27)
											{
												num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitCost"].Value));
											}
											try
											{
												foreach (object obj3 in productIngridients.Rows)
												{
													DataRow dataRow = (DataRow)obj3;
													sqlCommand.Parameters.Clear();
													sqlCommand.CommandText = "InsertNewSale2Warehouse3";
													bool flag28 = MyProject.Forms.Form1.DateChange == 1;
													if (flag28)
													{
														sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
													}
													sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
													sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataRow["productid"]));
													sqlCommand.Parameters.AddWithValue("isstockin", 0);
													sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
													sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataRow["qty"], Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value))));
													num5 = decimal.Add(num5, decimal.Multiply(Convert.ToDecimal(Operators.MultiplyObject(dataRow["Cost"], dataRow["qty"])), this.mono_rate));
													sqlCommand.Parameters.AddWithValue("unitcost", 0);
													sqlCommand.Parameters.AddWithValue("salesprice", 0);
													sqlCommand.Parameters.AddWithValue("paymentmethod", num);
													sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
													bool flag29 = MyProject.Forms.Form1.DateChange == 1;
													if (flag29)
													{
														sqlCommand.Parameters.AddWithValue("donewhen", this.DTdate.Value.ToString("yyyyMMdd"));
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
													}
													sqlCommand.Parameters.AddWithValue("trancode", 3);
													sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow2.Cells["prodtid"].Value), this._cnn));
													sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Tax"].Value)));
													sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
													sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
													sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
													bool flag30 = MyProject.Forms.Form1.DateChange == 1;
													if (flag30)
													{
														sqlCommand.Parameters.AddWithValue("ShiftDate", this.DTdate.Value.ToString("yyyyMMdd"));
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
													}
													sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BatchNumber"].Value));
													sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ExpiryDate"].Value)))));
													sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
													sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscAmount2"].Value)));
													sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
													sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text));
													sqlCommand.Parameters.AddWithValue("collection", "");
													sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscDetails"].Value));
													sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
													sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["taxexempt"].Value));
													sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
													sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
													sqlCommand.ExecuteNonQuery();
												}
											}
											finally
											{
												IEnumerator enumerator3;
												if (enumerator3 is IDisposable)
												{
													(enumerator3 as IDisposable).Dispose();
												}
											}
										}
										bool flag31 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["isvoucher"].Value.ToString(), "", false) == 0, false, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["isvoucher"].Value)), true, false);
										if (flag31)
										{
											dataTable.Rows.Add(new object[]
											{
												dataGridViewRow2.Cells["Prodtid"].Value,
												Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value))
											});
										}
										bool flag32 = this.currQuotationNumber != 0;
										if (flag32)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.Text;
											sqlCommand.CommandText = string.Concat(new string[]
											{
												"update quotations set invoicenum=",
												Conversions.ToString(this.invnum),
												", invoicedate=",
												DateTime.Today.ToString("yyyyMMdd"),
												", invoicedby='",
												MyProject.Forms.Form1.username,
												"', invoice_machinename='",
												Environment.MachineName,
												"' where quotationnumber=",
												Conversions.ToString(this.currQuotationNumber),
												" and coid=",
												Conversions.ToString(MyProject.Forms.Form1.coid),
												" and branch='",
												MyProject.Forms.Form1.branch,
												"'"
											});
											sqlCommand.ExecuteNonQuery();
										}
										text += ", at actual sale insert";
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "InsertNewSale2Warehouse3";
										bool flag33 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
										if (flag33)
										{
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
										}
										sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 0);
										sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
										sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value)));
										bool flag34 = MyProject.Forms.Form1.isRestaurant == 1;
										if (flag34)
										{
											sqlCommand.Parameters.AddWithValue("unitcost", num5);
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitCost"].Value)));
										}
										sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitPrice"].Value)), this.mono_rate));
										sqlCommand.Parameters.AddWithValue("paymentmethod", num);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										bool flag35 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
										if (flag35)
										{
											sqlCommand.Parameters.AddWithValue("donewhen", this.DTdate.Value.ToString("yyyyMMdd"));
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
										}
										sqlCommand.Parameters.AddWithValue("trancode", 3);
										sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ProductCode"].Value));
										sqlCommand.Parameters.AddWithValue("TranTime", text5);
										sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Tax"].Value)) / Convert.ToDouble(this.mono_rate));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
										bool flag36 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
										if (flag36)
										{
											sqlCommand.Parameters.AddWithValue("ShiftDate", this.DTdate.Value.ToString("yyyyMMdd"));
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
										}
										sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BatchNumber"].Value));
										sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ExpiryDate"].Value)))));
										sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
										sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
										sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
										sqlCommand.Parameters.AddWithValue("discountamount", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscAmount2"].Value)), this.mono_rate));
										sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
										sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text) / Convert.ToDouble(this.mono_rate));
										string text6 = "";
										bool @checked = this.rdbCollection.Checked;
										if (@checked)
										{
											text6 = "COLLECTION";
										}
										else
										{
											bool checked2 = this.rdpDelivery.Checked;
											if (checked2)
											{
												text6 = "DELIVERY";
											}
										}
										sqlCommand.Parameters.AddWithValue("collection", text6);
										sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscDetails"].Value));
										sqlCommand.Parameters.AddWithValue("otherdetail", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["OtherDetail"].Value));
										bool flag37 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
										if (flag37)
										{
											sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["comments"].Value));
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["comments"].Value));
										}
										sqlCommand.Parameters.AddWithValue("paymethref", text2);
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("quotationnum", this.currQuotationNumber);
										sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["taxexempt"].Value));
										sqlCommand.Parameters.AddWithValue("taxrate", Operators.MultiplyObject(dataGridViewRow2.Cells["taxr"].Value, 100));
										bool flag38 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["isdeposits"].Value));
										if (!flag38)
										{
											bool flag39 = Operators.CompareString(dataGridViewRow2.Cells["isdeposits"].Value.ToString(), "1", false) == 0;
											if (flag39)
											{
												sqlCommand.Parameters.AddWithValue("isdeposit", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["isdeposits"].Value));
												this.DepositUsed = true;
											}
										}
										bool flag40 = MyProject.Forms.Form1.IsWarehouse == 1;
										if (flag40)
										{
											sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
										}
										else
										{
											bool flag41 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ExpiryDate"].Value)), 0, false);
											if (flag41)
											{
												sqlCommand.Parameters.AddWithValue("iswarehouse", 1);
											}
											else
											{
												sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
											}
										}
										sqlCommand.Parameters.AddWithValue("altdescription", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["AltDesc"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["AltDesc"].Value))));
										sqlCommand.ExecuteNonQuery();
										bool flag42 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["CouponNumber"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["CouponNumber"].Value)), 0, false);
										if (flag42)
										{
											int num6 = Conversions.ToInteger(dataGridViewRow2.Cells["CouponNumber"].Value);
											bool flag43 = num6 != 1;
											if (flag43)
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandText = "UpdateCoupon";
												sqlCommand.Parameters.AddWithValue("CouponNumber", num6);
												sqlCommand.ExecuteNonQuery();
											}
											text += ", at insert discount";
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertDiscount2";
											sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
											sqlCommand.Parameters.AddWithValue("TranDate", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Prodtid"].Value));
											sqlCommand.Parameters.AddWithValue("DiscountAmt", Operators.DivideObject(dataGridViewRow2.Cells["DiscAmount2"].Value, this.mono_rate));
											sqlCommand.Parameters.AddWithValue("pricebefore", Operators.DivideObject(dataGridViewRow2.Cells["OldPrice"].Value, this.mono_rate));
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("couponnumber", num6);
											sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value));
											sqlCommand.Parameters.AddWithValue("discounttype", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscDetails"].Value));
											sqlCommand.Parameters.AddWithValue("discountperinvoice", this.isInvoiceDisc);
											sqlCommand.Parameters.AddWithValue("@discountpaymethod", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscPaymethod"].Value));
											sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
											sqlCommand.ExecuteNonQuery();
										}
										bool flag44 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(dataGridViewRow2.Cells["PriceChange"]), 0, RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["PriceChange"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["PriceChange"].Value)))), 1, false);
										if (flag44)
										{
											text += ", at insert price change";
											decimal num7 = new decimal(unchecked(Convert.ToDouble(decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitPrice"].Value)), this.mono_rate)) - (Convert.ToDouble(decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["OldPrice"].Value)), this.mono_rate)) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Tax"].Value)) / Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value)))));
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "PCInsertPriceChange";
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Prodtid"].Value));
											sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value));
											sqlCommand.Parameters.AddWithValue("pricechange", num7);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("donetime", DateTime.Now.ToString("HHmm"));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("invoiceno", this.invnum);
											sqlCommand.Parameters.AddWithValue("normalprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["OldPrice"].Value)), this.mono_rate));
											sqlCommand.Parameters.AddWithValue("costprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitCost"].Value)));
											sqlCommand.Parameters.AddWithValue("approvedby", MyProject.Forms.Form1.Approvedby);
											sqlCommand.ExecuteNonQuery();
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							bool checked3 = this.chkMultiple.Checked;
							if (checked3)
							{
								text += ", at multiple pay";
								try
								{
									foreach (object obj4 in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
									{
										DataRow dataRow2 = (DataRow)obj4;
										bool flag45 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["amtpaid"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["amtpaid"])), 0, false);
										if (flag45)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertActualPaymentMethods";
											sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
											sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(dataRow2["paymentmethodid"]));
											sqlCommand.Parameters.AddWithValue("paydesc", RuntimeHelpers.GetObjectValue(dataRow2["paymentmethoddesc"]));
											sqlCommand.Parameters.AddWithValue("amt", RuntimeHelpers.GetObjectValue(dataRow2["amtpaid"]));
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("rate", RuntimeHelpers.GetObjectValue(dataRow2["rate"]));
											sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
											sqlCommand.ExecuteNonQuery();
										}
									}
								}
								finally
								{
									IEnumerator enumerator4;
									if (enumerator4 is IDisposable)
									{
										(enumerator4 as IDisposable).Dispose();
									}
								}
							}
							else
							{
								text += ", at insert pay";
								decimal num8 = Convert.ToDecimal(this.txtTotal.Text);
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertActualPaymentMethods";
								sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
								sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
								sqlCommand.Parameters.AddWithValue("paydesc", this.cboPayMeth.Text);
								sqlCommand.Parameters.AddWithValue("amt", num8);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
								sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
								sqlCommand.ExecuteNonQuery();
							}
							bool flag46 = MyProject.Forms.Form1.CollectEcocashDetails == 1;
							if (flag46)
							{
								bool flag47 = (Operators.CompareString(this.cboPayMeth.Text, "Ecocash", false) == 0) | (Operators.CompareString(this.cboPayMeth.Text, "ECOCASH", false) == 0) | (Operators.CompareString(this.cboPayMeth.Text, "ecocash", false) == 0);
								if (flag47)
								{
									MessageBox.Show("Function is disable. Contact your system administrator.");
								}
							}
						}
						else
						{
							bool flag48 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0;
							if (!flag48)
							{
								MessageBox.Show("Please select/enter a customer name first before confirming the sale.");
								sqlTransaction.Rollback();
								sqlConnection.Close();
								Cursor.Current = Cursors.Default;
								return;
							}
							bool flag49 = this.DataGridView1.Rows.Count < 1;
							if (flag49)
							{
								MessageBox.Show("There are no products selected. Cannot proceed.");
								return;
							}
							bool flag50 = Operators.CompareString(this.cboTerms.Text, "", false) == 0;
							if (flag50)
							{
								MessageBox.Show("Please select the account terms first.");
								return;
							}
							bool flag51 = Conversion.Val(this.txtTotal.Text) == 0.0;
							if (flag51)
							{
								MessageBox.Show("Total sale is 0. Cannot proceed.");
								return;
							}
							int num9 = 0;
							this.UpdateCustomer();
							bool flag52 = !this.pf.isCustomerAccOK(this.txtcustomer.Text, new decimal(Conversions.ToDouble(this.txtTotal.Text) / Convert.ToDouble(this.mono_rate)), this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
							if (flag52)
							{
								MessageBox.Show("Customer account limit reached or account inactive. Sale cannot proceed.");
								return;
							}
							num9 = 10;
							bool flag53 = (MyProject.Forms.Form1.RecordConsultant == 1) & (MyProject.Forms.Form1.ConsultantSalesOnly == 1);
							if (flag53)
							{
								bool flag54 = Operators.CompareString(this.cboConsultant.Text, "", false) == 0;
								if (flag54)
								{
									MessageBox.Show("Please select the consultant first.");
									sqlTransaction.Rollback();
									sqlConnection.Close();
									return;
								}
							}
							bool flag55 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
							if (flag55)
							{
								string text7 = "";
								try
								{
									text7 = MyProject.Forms.Form1.myrevmax.GetCardDetails();
									JObject jobject2 = JObject.Parse(text7);
									string text8 = jobject2["Message"].ToObject<string>();
									bool flag56 = Operators.CompareString(text8, "Success", false) != 0;
									if (flag56)
									{
										MessageBox.Show("Error getting card details. " + text8);
									}
								}
								catch (Exception ex2)
								{
									MessageBox.Show("Revmax Fiscal Device Error. Sale cannot proceed. Check the device first. Error Details: " + ex2.Message + " " + text7);
									return;
								}
							}
							bool flag57 = (MyProject.Forms.Form1.NegativeStock == 0) & (Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "RecheckStockBal", MyProject.Forms.Form1.Constring), "1", false) == 0);
							if (flag57)
							{
								try
								{
									foreach (object obj5 in ((IEnumerable)this.DataGridView1.Rows))
									{
										DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj5;
										bool flag58 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Prodtid"].Value));
										if (!flag58)
										{
											bool flag59 = Conversions.ToBoolean(dataGridViewRow3.Cells["IsUnlimitedStock"].Value);
											int num10 = Conversions.ToInteger(dataGridViewRow3.Cells["Break"].Value);
											bool flag60 = flag59 | (num10 == 1);
											if (!flag60)
											{
												decimal stockAvailable2 = this.pf.GetStockAvailable(MyProject.Forms.Form1.Constring, Conversions.ToInteger(dataGridViewRow3.Cells["Prodtid"].Value), this.DataGridView1, Conversions.ToString(dataGridViewRow3.Cells["UOM"].Value), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, true);
												bool flag61 = Operators.ConditionalCompareObjectLess(stockAvailable2, dataGridViewRow3.Cells["Qty"].Value, false);
												if (flag61)
												{
													MessageBox.Show("Product: " + dataGridViewRow3.Cells["Desc"].Value.ToString() + " has insufficient stock. Cannot proceed.");
													return;
												}
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator5;
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
							}
							this.invnum = this.GetInvNumberSales();
							bool flag62 = this.invnum == 0;
							if (flag62)
							{
								MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
								sqlTransaction.Rollback();
								sqlConnection.Close();
								return;
							}
							int num11 = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
							DateTime dateTime2 = Conversions.ToDate(this.lblShiftDate.Text);
							try
							{
								foreach (object obj6 in ((IEnumerable)this.DataGridView1.Rows))
								{
									DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj6;
									bool flag63 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Prodtid"].Value));
									if (!flag63)
									{
										bool flag64 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow4.Cells["Break"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Break"].Value)), 1, false);
										if (flag64)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "GetProductConvertedNumber";
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
											int coid2 = MyProject.Forms.Form1.coid;
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("newconvertednum", 0);
											int num12 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "InsertProductsConverted";
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("formulaname", "Auto Break Case");
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case");
											sqlCommand.Parameters.AddWithValue("QTYCalculated", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["BreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("QTYActual", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["BreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["prodtid"].Value));
											sqlCommand.Parameters.AddWithValue("type", "BREAK");
											sqlCommand.Parameters.AddWithValue("convertedproductid", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["BreakParentProductID"].Value));
											sqlCommand.Parameters.AddWithValue("invnumber", num12);
											sqlCommand.ExecuteNonQuery();
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertNewStock2Warehouse";
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("invoicenum", num12);
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["BreakParentProductID"].Value));
											sqlCommand.Parameters.AddWithValue("isstockin", 0);
											sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case parent");
											sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["ActualBreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("cost", 0);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("trancode", 9);
											sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow4.Cells["BreakParentProductID"].Value), this._cnn));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("BatchNumber", "");
											sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
											sqlCommand.Parameters.AddWithValue("suppliername", "");
											sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
											sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
											sqlCommand.ExecuteNonQuery();
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertNewStock2Warehouse";
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("invoicenum", num12);
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["prodtid"].Value));
											sqlCommand.Parameters.AddWithValue("isstockin", 1);
											sqlCommand.Parameters.AddWithValue("ref", "Auto Break case child");
											sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataGridViewRow4.Cells["ActualBreakQty"].Value, dataGridViewRow4.Cells["BreakQty"].Value));
											sqlCommand.Parameters.AddWithValue("cost", 0);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("trancode", 9);
											sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow4.Cells["prodtid"].Value), this._cnn));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("BatchNumber", "");
											sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
											sqlCommand.Parameters.AddWithValue("suppliername", "");
											sqlCommand.Parameters.AddWithValue("sellingprice", 0);
											sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
											sqlCommand.ExecuteNonQuery();
										}
										decimal num13 = 0m;
										bool flag65 = MyProject.Forms.Form1.isRestaurant == 1;
										if (flag65)
										{
											DataTable productIngridients2 = this.pf.GetProductIngridients(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(dataGridViewRow4.Cells["Prodtid"].Value), this._cnn);
											bool flag66 = productIngridients2.Rows.Count == 0;
											if (flag66)
											{
												num13 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["UnitCost"].Value));
											}
											try
											{
												foreach (object obj7 in productIngridients2.Rows)
												{
													DataRow dataRow3 = (DataRow)obj7;
													sqlCommand.Parameters.Clear();
													sqlCommand.CommandText = "InsertNewSale2Warehouse3";
													bool flag67 = MyProject.Forms.Form1.DateChange == 1;
													if (flag67)
													{
														sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
													}
													sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
													sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataRow3["productid"]));
													sqlCommand.Parameters.AddWithValue("isstockin", 0);
													sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
													sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataRow3["qty"], Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Qty"].Value))));
													num13 = decimal.Add(num13, Convert.ToDecimal(Operators.MultiplyObject(dataRow3["Cost"], dataRow3["qty"])));
													sqlCommand.Parameters.AddWithValue("unitcost", 0);
													sqlCommand.Parameters.AddWithValue("salesprice", 0);
													sqlCommand.Parameters.AddWithValue("paymentmethod", num9);
													sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
													bool flag68 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
													if (flag68)
													{
														sqlCommand.Parameters.AddWithValue("donewhen", this.DTdate.Value.ToString("yyyyMMdd"));
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
													}
													sqlCommand.Parameters.AddWithValue("trancode", 3);
													sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow4.Cells["prodtid"].Value), this._cnn));
													sqlCommand.Parameters.AddWithValue("TranTime", num11);
													sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Tax"].Value)));
													sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
													sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
													sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
													bool flag69 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
													if (flag69)
													{
														sqlCommand.Parameters.AddWithValue("ShiftDate", this.DTdate.Value.ToString("yyyyMMdd"));
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
													}
													sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["BatchNumber"].Value));
													sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow4.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["ExpiryDate"].Value)))));
													sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
													sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["DiscAmount2"].Value)));
													sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
													sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text));
													sqlCommand.Parameters.AddWithValue("collection", "");
													sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["DiscDetails"].Value));
													sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
													sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["taxexempt"].Value));
													sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
													sqlCommand.ExecuteNonQuery();
												}
											}
											finally
											{
												IEnumerator enumerator7;
												if (enumerator7 is IDisposable)
												{
													(enumerator7 as IDisposable).Dispose();
												}
											}
										}
										bool flag70 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow4.Cells["isvoucher"].Value.ToString(), "", false) == 0, false, RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["isvoucher"].Value)), true, false);
										if (flag70)
										{
											dataTable.Rows.Add(new object[]
											{
												dataGridViewRow4.Cells["Prodtid"].Value,
												Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Qty"].Value))
											});
										}
										bool flag71 = this.currQuotationNumber != 0;
										if (flag71)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.Text;
											sqlCommand.CommandText = string.Concat(new string[]
											{
												"update quotations set invoicenum=",
												Conversions.ToString(this.invnum),
												", invoicedate=",
												DateTime.Today.ToString("yyyyMMdd"),
												", invoicedby='",
												MyProject.Forms.Form1.username,
												"', invoice_machinename='",
												Environment.MachineName,
												"' where quotationnumber=",
												Conversions.ToString(this.currQuotationNumber),
												" and coid=",
												Conversions.ToString(MyProject.Forms.Form1.coid),
												" and branch='",
												MyProject.Forms.Form1.branch,
												"'"
											});
											sqlCommand.ExecuteNonQuery();
										}
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "InsertNewSale2Warehouse3";
										bool flag72 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
										if (flag72)
										{
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
										}
										sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 0);
										sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
										sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Qty"].Value)));
										bool flag73 = MyProject.Forms.Form1.isRestaurant == 1;
										if (flag73)
										{
											sqlCommand.Parameters.AddWithValue("unitcost", num13);
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["UnitCost"].Value)));
										}
										sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["UnitPrice"].Value)), this.mono_rate));
										sqlCommand.Parameters.AddWithValue("paymentmethod", num9);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										bool flag74 = MyProject.Forms.Form1.DateChange == 1;
										if (flag74)
										{
											sqlCommand.Parameters.AddWithValue("donewhen", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
										}
										sqlCommand.Parameters.AddWithValue("trancode", 3);
										sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["ProductCode"].Value));
										sqlCommand.Parameters.AddWithValue("TranTime", num11);
										sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Tax"].Value)) / Convert.ToDouble(this.mono_rate));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
										sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["BatchNumber"].Value));
										sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow4.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["ExpiryDate"].Value)))));
										sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
										sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
										sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
										sqlCommand.Parameters.AddWithValue("discountamount", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["DiscAmount2"].Value)), this.mono_rate));
										sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
										sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text) / Convert.ToDouble(this.mono_rate));
										string text9 = "";
										bool checked4 = this.rdbCollection.Checked;
										if (checked4)
										{
											text9 = "COLLECTION";
										}
										else
										{
											bool checked5 = this.rdpDelivery.Checked;
											if (checked5)
											{
												text9 = "DELIVERY";
											}
										}
										sqlCommand.Parameters.AddWithValue("collection", text9);
										sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["DiscDetails"].Value));
										sqlCommand.Parameters.AddWithValue("otherdetail", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["OtherDetail"].Value));
										bool flag75 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
										if (flag75)
										{
											sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["comments"].Value));
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["comments"].Value));
										}
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("quotationnum", this.currQuotationNumber);
										sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["taxexempt"].Value));
										bool flag76 = MyProject.Forms.Form1.IsWarehouse == 1;
										if (flag76)
										{
											sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
										}
										else
										{
											bool flag77 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow4.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["ExpiryDate"].Value)), 0, false);
											if (flag77)
											{
												sqlCommand.Parameters.AddWithValue("iswarehouse", 1);
											}
											else
											{
												sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
											}
										}
										sqlCommand.Parameters.AddWithValue("altdescription", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["AltDesc"].Value));
										sqlCommand.Parameters.AddWithValue("taxrate", Operators.MultiplyObject(dataGridViewRow4.Cells["taxr"].Value, 100));
										sqlCommand.ExecuteNonQuery();
										bool flag78 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Operators.CompareString(dataGridViewRow4.Cells["CouponNumber"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["CouponNumber"].Value)), 0, false);
										if (flag78)
										{
											int num14 = Conversions.ToInteger(dataGridViewRow4.Cells["CouponNumber"].Value);
											bool flag79 = num14 != 1;
											if (flag79)
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandText = "UpdateCoupon";
												sqlCommand.Parameters.AddWithValue("CouponNumber", num14);
												sqlCommand.ExecuteNonQuery();
											}
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertDiscount2";
											sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
											sqlCommand.Parameters.AddWithValue("TranDate", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Prodtid"].Value));
											sqlCommand.Parameters.AddWithValue("DiscountAmt", Operators.DivideObject(dataGridViewRow4.Cells["DiscAmount2"].Value, this.mono_rate));
											sqlCommand.Parameters.AddWithValue("pricebefore", Operators.DivideObject(dataGridViewRow4.Cells["OldPrice"].Value, this.mono_rate));
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("couponnumber", num14);
											sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Qty"].Value));
											sqlCommand.Parameters.AddWithValue("discounttype", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["DiscDetails"].Value));
											sqlCommand.Parameters.AddWithValue("discountperinvoice", this.isInvoiceDisc);
											sqlCommand.Parameters.AddWithValue("@discountpaymethod", RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["DiscPaymethod"].Value));
											sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
											sqlCommand.ExecuteNonQuery();
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator6;
								if (enumerator6 is IDisposable)
								{
									(enumerator6 as IDisposable).Dispose();
								}
							}
							DateTime dateTime3 = this.DTdate.Value.AddDays((double)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue)));
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "BillingInsertAccSale2";
							sqlCommand.Parameters.AddWithValue("customername", this.txtcustomer.Text);
							sqlCommand.Parameters.AddWithValue("invoicenumber", this.invnum);
							sqlCommand.Parameters.AddWithValue("amount", decimal.Divide(Convert.ToDecimal(this.txtTotal.Text), this.mono_rate));
							sqlCommand.Parameters.AddWithValue("shiftdate", dateTime2.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("trantime", num11);
							sqlCommand.Parameters.AddWithValue("teller", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("terms", RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue));
							sqlCommand.Parameters.AddWithValue("DueDate", Convert.ToInt32(dateTime3.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
							sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
							sqlCommand.Parameters.AddWithValue("paymentmethodiddesc", this.cboPayMeth.Text);
							sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text) / Convert.ToDouble(this.mono_rate));
							sqlCommand.Parameters.AddWithValue("comment", this.txtcomments.Text);
							sqlCommand.Parameters.AddWithValue("termsdesc", this.cboTerms.Text);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("customerrefentryno", this.currentCustomerEntryNo);
							sqlCommand.ExecuteNonQuery();
						}
						bool flag80 = MyProject.Forms.Form1.pendinginvoice_entryno != 0;
						if (flag80)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.Text;
							sqlCommand.CommandText = string.Concat(new string[]
							{
								"update pendinginvoices set isdone=1,isreopened=1,ReopenedBy='",
								MyProject.Forms.Form1.username,
								" - ",
								Conversions.ToString(this.invnum),
								"' where entryno=",
								Conversions.ToString(MyProject.Forms.Form1.pendinginvoice_entryno)
							});
							sqlCommand.ExecuteNonQuery();
						}
						try
						{
							foreach (object obj8 in dataTable.Rows)
							{
								DataRow dataRow4 = (DataRow)obj8;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "EconetAirtimeUpdateSale";
								sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
								sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataRow4["qty"]));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataRow4["productid"]));
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.ExecuteNonQuery();
							}
						}
						finally
						{
							IEnumerator enumerator8;
							if (enumerator8 is IDisposable)
							{
								(enumerator8 as IDisposable).Dispose();
							}
						}
						try
						{
							foreach (object obj9 in MyProject.Forms.Form1.datSerialsSelect4Sales.Rows)
							{
								DataRow dataRow5 = (DataRow)obj9;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "UpdateSerial";
								sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
								sqlCommand.Parameters.AddWithValue("serialnumber", RuntimeHelpers.GetObjectValue(dataRow5["SerialNumber"]));
								sqlCommand.Parameters.AddWithValue("entryno", RuntimeHelpers.GetObjectValue(dataRow5["EntryNo"]));
								sqlCommand.ExecuteNonQuery();
							}
						}
						finally
						{
							IEnumerator enumerator9;
							if (enumerator9 is IDisposable)
							{
								(enumerator9 as IDisposable).Dispose();
							}
						}
						sqlTransaction.Commit();
						sqlConnection.Close();
						text = "sale committed.";
						bool flag81 = (MyProject.Forms.Form1.SelectA4InvatPOS == 1) & (MyProject.Forms.Form1.PrintFiscal == 0);
						if (flag81)
						{
							int num15 = 0;
							PrintReceiptOrInvoice printReceiptOrInvoice = new PrintReceiptOrInvoice();
							bool flag82 = printReceiptOrInvoice.ShowDialog() == DialogResult.OK;
							if (flag82)
							{
								num15 = printReceiptOrInvoice.printcode;
							}
							bool flag83 = num15 == 1;
							if (flag83)
							{
								this.PrintInvoice("", 0);
							}
							else
							{
								bool flag84 = num15 == 2;
								if (flag84)
								{
									bool flag85 = MyProject.Forms.Form1.PrintReceipt == 1;
									if (flag85)
									{
										bool flag86 = MyProject.Forms.Form1.PrintFiscal == 0;
										if (flag86)
										{
											bool flag87 = MyProject.Forms.Form1.ReceiptsOptional == 1;
											int i;
											if (flag87)
											{
												try
												{
													PrintReceipts printReceipts = new PrintReceipts();
													bool flag88 = printReceipts.ShowDialog() == DialogResult.OK;
													if (flag88)
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
												catch (Exception ex3)
												{
													MessageBox.Show("Keypad error. Details: " + ex3.Message);
												}
											}
											else
											{
												i = MyProject.Forms.Form1.NumOfReceiptsPrint;
											}
											int num16 = 0;
											while (i > 0)
											{
												num16++;
												bool flag89 = num16 > 1;
												if (flag89)
												{
													this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, MyProject.Forms.Form1.receipt_copy_name, "", "", "");
												}
												else
												{
													this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "", "", "", "");
												}
												bool flag90 = dataTable.Rows.Count > 0;
												if (flag90)
												{
													this.printEconetAirtimeVoucher(this.invnum);
												}
												i--;
											}
										}
										else
										{
											bool flag91 = MyProject.Forms.Form1.PrintFiscal == 1;
											if (flag91)
											{
												bool flag92 = MyProject.Forms.Form1.FiscalEltrade == 1;
												if (flag92)
												{
													EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
													DataTable dataTable2 = this.createDTFromGrid(this.DataGridView1);
													string text10 = this.PrintEltradeInvoice(dataTable2, this.pf.GetFiscalGroup(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), this.cboPayMeth.Text, Conversion.Val(this.txtAmtPaid.Text), MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, this.pf.GetEltradeFiscalCountryID(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), 3, MyProject.Forms.Form1.username, this.invnum, this.txtbpnumber.Text, this.txtvatnumber.Text, MyProject.Forms.Form1.companyname, "", this.txtAddress.Text, "MOL", this.txtcustomer.Text, eltradeFprn);
													bool flag93 = Operators.CompareString(Strings.Trim(text10), "SUCCESS", false) != 0;
													if (flag93)
													{
														this.saledone = true;
														MessageBox.Show("Sale done. Fiscal Error. " + text10);
														this.ClearForm();
														eltradeFprn.Close();
													}
													else
													{
														eltradeFprn.Close();
													}
												}
												else
												{
													bool flag94 = MyProject.Forms.Form1.FiscalRevmax == 1;
													if (flag94)
													{
														string text11 = "";
														try
														{
															DataTable dataTable3 = this.pf.RunRevmaxDATItems(this.DataGridView1);
															string text12 = this.pf.BuildItemsXML(dataTable3);
															string text13 = this.pf.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
															bool flag95 = MyProject.Forms.Form1.RevmaxTest == 1;
															if (flag95)
															{
																MessageBox.Show(text12);
																MessageBox.Show(text13);
																MessageBox.Show("total: " + this.txtTotal.Text + " tax: " + this.txtTax.Text);
															}
															text11 = MyProject.Forms.Form1.myrevmax.TransactM(this.paymeth_currency, this.txtEmail.Text, this.invnum.ToString(), this.txtcustomer.Text, this.txtvatnumber.Text, this.txtAddress.Text, this.txtMobile.Text, this.txtbpnumber.Text, this.txtTotal.Text, this.txtTax.Text, "01", "", "", text12, text13);
															bool flag96 = MyProject.Forms.Form1.RevmaxTest == 1;
															if (flag96)
															{
																MessageBox.Show(text11);
															}
															JObject jobject3 = JObject.Parse(text11);
															string text14 = jobject3["Message"].ToObject<string>();
															bool flag97 = text14.Contains("Success");
															if (!flag97)
															{
																MessageBox.Show("Sale Done but Revmax Fiscalisation Error: " + text14);
															}
															Bitmap qrcodeImageFromRevmaxJSON = this.pf2.GetQRCodeImageFromRevmaxJSON(text11);
															this.QRCodeVariable = qrcodeImageFromRevmaxJSON;
															this.qrveri_code = jobject3["VerificationCode"].ToObject<string>();
															this.qrveri_link = jobject3["VerificationLink"].ToObject<string>();
															this.zimra_invnum = (string)jobject3["Data"]["receipt"]["receiptGlobalNo"];
															this.fiscalday_number = jobject3["FiscalDay"].ToObject<string>();
															this.deviceno = jobject3["DeviceID"].ToObject<string>();
															bool flag98 = MyProject.Forms.Form1.RevmaxTest == 1;
															if (flag98)
															{
																MessageBox.Show("1. fiscal day: " + this.fiscalday_number);
															}
															this.pf.SaveDigSig(qrcodeImageFromRevmaxJSON, this.invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this.qrveri_code, this.qrveri_link, this.zimra_invnum, this.fiscalday_number, this.zimra_invnum, this.deviceno, MyProject.Forms.Form1.Constring);
															this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "", "", "", "");
														}
														catch (Exception ex4)
														{
															MessageBox.Show("Error fiscalising. Check settings first. Return: " + text11 + " ex:" + ex4.Message);
														}
													}
													else
													{
														bool flag99 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
														if (flag99)
														{
															bool flag100 = MyProject.Forms.Form1.PrintToFile == 1;
															if (flag100)
															{
																this.PrintHeader("");
																this.ItemsToBePrinted(this.invnum);
																this.PrintFooter("");
																bool flag101 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "TXT", false) == 0;
																if (flag101)
																{
																	File.WriteAllText(Path.Combine(MyProject.Forms.Form1.PrintFilePath, this.invnum.ToString() + ".txt"), this.TextToPrint);
																}
																else
																{
																	bool flag102 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "PDF", false) == 0;
																	if (flag102)
																	{
																		Document document = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
																		PdfWriter.GetInstance(document, new FileStream(MyProject.Forms.Form1.PrintFilePath, FileMode.Create));
																		Paragraph paragraph = new Paragraph(this.TextToPrint);
																		document.Open();
																		document.Add(paragraph);
																		document.Close();
																		document.Dispose();
																	}
																}
															}
															else
															{
																this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "", "", "", "");
															}
														}
													}
												}
											}
										}
									}
								}
								else
								{
									bool flag103 = num15 == 3;
									if (flag103)
									{
									}
								}
							}
						}
						else
						{
							bool flag104 = MyProject.Forms.Form1.PrintReceipt == 1;
							if (flag104)
							{
								bool flag105 = MyProject.Forms.Form1.PrintFiscal == 0;
								if (flag105)
								{
									bool flag106 = MyProject.Forms.Form1.ReceiptsOptional == 1;
									int j;
									if (flag106)
									{
										try
										{
											PrintReceipts printReceipts2 = new PrintReceipts();
											bool flag107 = printReceipts2.ShowDialog() == DialogResult.OK;
											if (flag107)
											{
												bool printRec2 = printReceipts2.printRec;
												if (printRec2)
												{
													j = printReceipts2.printNum;
												}
												else
												{
													this.TextToPrint = "";
													this.stringToRead = new StringReader(this.TextToPrint);
													try
													{
														StandardPrintController standardPrintController2 = new StandardPrintController();
														this.PrintDocument1.PrintController = standardPrintController2;
														this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
														this.PrintDocument1.Print();
													}
													finally
													{
														this.stringToRead.Close();
													}
													j = 0;
												}
											}
										}
										catch (Exception ex5)
										{
											MessageBox.Show("Keypad error. Details: " + ex5.Message);
										}
									}
									else
									{
										j = MyProject.Forms.Form1.NumOfReceiptsPrint;
									}
									int num17 = 0;
									while (j > 0)
									{
										num17++;
										bool flag108 = num17 > 1;
										if (flag108)
										{
											this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, MyProject.Forms.Form1.receipt_copy_name, "", "", "");
										}
										else
										{
											this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "", "", "", "");
										}
										bool flag109 = dataTable.Rows.Count > 0;
										if (flag109)
										{
											this.printEconetAirtimeVoucher(this.invnum);
										}
										j--;
									}
									bool flag110 = Operators.CompareString(MyProject.Forms.Form1.defaultSecondaryPrinter, "", false) != 0;
									if (flag110)
									{
										this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultSecondaryPrinter, MyProject.Forms.Form1.receipt_copy_name, "", "", "");
									}
								}
								else
								{
									bool flag111 = MyProject.Forms.Form1.PrintFiscal == 1;
									if (flag111)
									{
										bool flag112 = MyProject.Forms.Form1.FiscalEltrade == 1;
										if (flag112)
										{
											EltradeFprn eltradeFprn2 = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
											DataTable dataTable4 = this.createDTFromGrid(this.DataGridView1);
											string text15 = this.PrintEltradeInvoice(dataTable4, this.pf.GetFiscalGroup(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), this.cboPayMeth.Text, Conversion.Val(this.txtAmtPaid.Text), MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, this.pf.GetEltradeFiscalCountryID(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), 3, MyProject.Forms.Form1.username, this.invnum, this.txtbpnumber.Text, this.txtvatnumber.Text, MyProject.Forms.Form1.companyname, "", this.txtAddress.Text, "MOL", this.txtcustomer.Text, eltradeFprn2);
											bool flag113 = Operators.CompareString(Strings.Trim(text15), "SUCCESS", false) != 0;
											if (flag113)
											{
												this.saledone = true;
												MessageBox.Show("Sale done. Fiscal Error. " + text15);
												this.ClearForm();
												eltradeFprn2.Close();
											}
											else
											{
												eltradeFprn2.Close();
											}
										}
										else
										{
											bool flag114 = MyProject.Forms.Form1.FiscalRevmax == 1;
											if (flag114)
											{
												string text16 = "";
												try
												{
													DataTable dataTable5 = this.pf.RunRevmaxDATItems(this.DataGridView1);
													decimal num18 = new decimal(unchecked(Conversion.Val(this.txtTotal.Text) - Conversion.Val(this.txtTax.Text)));
													string text17 = this.pf.BuildItemsXML(dataTable5);
													string text18 = this.pf.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
													bool flag115 = MyProject.Forms.Form1.RevmaxTest == 1;
													if (flag115)
													{
														MessageBox.Show(text17);
														MessageBox.Show(text18);
														MessageBox.Show("total: " + this.txtTotal.Text + " tax: " + this.txtTax.Text);
													}
													text16 = MyProject.Forms.Form1.myrevmax.TransactM(this.paymeth_currency, this.txtEmail.Text, this.invnum.ToString(), this.txtcustomer.Text, this.txtvatnumber.Text, this.txtAddress.Text, this.txtMobile.Text, this.txtbpnumber.Text, this.txtTotal.Text, this.txtTax.Text, "01", "", "", text17, text18);
													bool flag116 = MyProject.Forms.Form1.RevmaxTest == 1;
													if (flag116)
													{
														MessageBox.Show(text16);
													}
													JObject jobject4 = JObject.Parse(text16);
													string text19 = jobject4["Message"].ToObject<string>();
													bool flag117 = text19.Contains("Success");
													if (!flag117)
													{
														MessageBox.Show("Sale Done but Revmax Fiscalisation Error: " + text19);
													}
													Bitmap qrcodeImageFromRevmaxJSON2 = this.pf2.GetQRCodeImageFromRevmaxJSON(text16);
													this.QRCodeVariable = qrcodeImageFromRevmaxJSON2;
													this.PicQRCode.Image = qrcodeImageFromRevmaxJSON2;
													this.qrveri_code = jobject4["VerificationCode"].ToObject<string>();
													this.qrveri_link = jobject4["VerificationLink"].ToObject<string>();
													string text20 = jobject4["FiscalDay"].ToObject<string>();
													string text21 = jobject4["DeviceID"].ToObject<string>();
													string text22 = (string)jobject4["Data"]["receipt"]["receiptGlobalNo"];
													bool flag118 = MyProject.Forms.Form1.RevmaxTest == 1;
													if (flag118)
													{
														MessageBox.Show("3 fiscal day: " + text20);
													}
													this.pf.SaveDigSig(qrcodeImageFromRevmaxJSON2, this.invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this.qrveri_code, this.qrveri_link, text22, text20, text22, text21, MyProject.Forms.Form1.Constring);
													bool flag119 = MyProject.Forms.Form1.RevmaxTest == 1;
													if (flag119)
													{
														MessageBox.Show("About to print receipt. fiscal day is: " + text20);
													}
													this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "", text20, text22, text21);
												}
												catch (Exception ex6)
												{
													MessageBox.Show("Error fiscalising. Check settings first. Return: " + text16 + " ex:" + ex6.Message);
												}
											}
											else
											{
												bool flag120 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
												if (flag120)
												{
													bool flag121 = MyProject.Forms.Form1.PrintToFile == 1;
													if (flag121)
													{
														this.PrintHeader("");
														this.ItemsToBePrinted(this.invnum);
														this.PrintFooter("");
														bool flag122 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "TXT", false) == 0;
														if (flag122)
														{
															File.WriteAllText(Path.Combine(MyProject.Forms.Form1.PrintFilePath, this.invnum.ToString() + ".txt"), this.TextToPrint);
														}
														else
														{
															bool flag123 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "PDF", false) == 0;
															if (flag123)
															{
																Document document2 = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
																PdfWriter.GetInstance(document2, new FileStream(MyProject.Forms.Form1.PrintFilePath + "\\" + this.invnum.ToString() + ".pdf", FileMode.Create));
																Paragraph paragraph2 = new Paragraph(this.TextToPrint);
																document2.Open();
																document2.Add(paragraph2);
																document2.Close();
																document2.Dispose();
															}
														}
													}
													else
													{
														this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "", "", "", "");
													}
												}
											}
										}
									}
								}
							}
							bool flag124 = MyProject.Forms.Form1.PrintInvoice == 1;
							if (flag124)
							{
								bool flag125 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
								if (flag125)
								{
									string text23 = "";
									try
									{
										DataTable dataTable6 = this.pf.RunRevmaxDATItems(this.DataGridView1);
										string text24 = this.pf.BuildItemsXML(dataTable6);
										string text25 = this.pf.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
										bool flag126 = MyProject.Forms.Form1.RevmaxTest == 1;
										if (flag126)
										{
											MessageBox.Show(text24);
											MessageBox.Show(text25);
											MessageBox.Show("total: " + this.txtTotal.Text + " tax: " + this.txtTax.Text);
										}
										text23 = MyProject.Forms.Form1.myrevmax.TransactM(this.paymeth_currency, this.txtEmail.Text, this.invnum.ToString(), this.txtcustomer.Text, this.txtvatnumber.Text, this.txtAddress.Text, this.txtMobile.Text, this.txtbpnumber.Text, this.txtTotal.Text, this.txtTax.Text, "01", "", "", text24, text25);
										bool flag127 = MyProject.Forms.Form1.RevmaxTest == 1;
										if (flag127)
										{
											MessageBox.Show(text23);
										}
										JObject jobject5 = JObject.Parse(text23);
										string text26 = jobject5["Message"].ToObject<string>();
										bool flag128 = text26.Contains("Success");
										if (!flag128)
										{
											MessageBox.Show("Sale Done but Revmax Fiscalisation Error: " + text26);
										}
										Bitmap qrcodeImageFromRevmaxJSON3 = this.pf2.GetQRCodeImageFromRevmaxJSON(text23);
										this.qrveri_code = jobject5["VerificationCode"].ToObject<string>();
										this.qrveri_link = jobject5["VerificationLink"].ToObject<string>();
										string text27 = jobject5["FiscalDay"].ToObject<string>();
										string text28 = jobject5["DeviceID"].ToObject<string>();
										string text29 = (string)jobject5["Data"]["receipt"]["receiptGlobalNo"];
										bool flag129 = MyProject.Forms.Form1.RevmaxTest == 1;
										if (flag129)
										{
											MessageBox.Show("2 fiscal day: " + text27);
										}
										this.pf.SaveDigSig(qrcodeImageFromRevmaxJSON3, this.invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this.qrveri_code, this.qrveri_link, text29, text27, text29, text28, MyProject.Forms.Form1.Constring);
										this.PrintInvoice("", 0);
									}
									catch (Exception ex7)
									{
										this.saledone = true;
										MessageBox.Show("SALE DONE BUT Error fiscalising. Check settings first. Return: " + text23 + " ex:" + ex7.Message);
										this.ClearForm();
										return;
									}
								}
								else
								{
									bool flag130 = (MyProject.Forms.Form1.PrintInvoice == 1) & (MyProject.Forms.Form1.FiscalEltradeESD == 1);
									if (flag130)
									{
										this.PrintInvoice("", 1);
									}
									else
									{
										bool flag131 = (MyProject.Forms.Form1.PrintInvoice == 1) & (MyProject.Forms.Form1.PrintFiscal == 0);
										if (flag131)
										{
											this.PrintInvoice("", 0);
										}
									}
								}
							}
						}
						bool checked6 = this.chkPrintDeliveryNote.Checked;
						if (checked6)
						{
							bool flag132 = MyProject.Forms.Form1.PrintReceipt == 1;
							if (flag132)
							{
								try
								{
									this.printDeliveryNote80mm(this.pf.GetInvoiceDetails(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.invnum, this._cnn), 72);
								}
								catch (Exception ex8)
								{
									bool flag133 = MyProject.Forms.Form1.RevmaxTest == 1;
									if (flag133)
									{
										MessageBox.Show("Handled Error immediately after PrintDeliveryNote80mm procedure.");
									}
								}
								bool flag134 = MyProject.Forms.Form1.RevmaxTest == 1;
								if (flag134)
								{
									MessageBox.Show("Printing D Note done.");
								}
							}
							else
							{
								bool flag135 = MyProject.Forms.Form1.PrintInvoice == 1;
								if (flag135)
								{
									DeliveryNoteWarehouse deliveryNoteWarehouse = new DeliveryNoteWarehouse();
									deliveryNoteWarehouse.invnum = this.invnum;
									deliveryNoteWarehouse.ShowDialog(this);
									deliveryNoteWarehouse.Dispose();
								}
							}
						}
						bool flag136 = (MyProject.Forms.Form1.deposits_inuse == 1) & this.DepositUsed & (MyProject.Forms.Form1.useOldPrintingService == 1);
						if (flag136)
						{
							bool flag137 = MyProject.Forms.Form1.RevmaxTest == 1;
							if (flag137)
							{
								MessageBox.Show("Get Deposits stage.");
							}
							DataTable deposits = this.GetDeposits(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.invnum);
							bool flag138 = deposits.Rows.Count > 0;
							if (flag138)
							{
								try
								{
									foreach (object obj10 in deposits.Rows)
									{
										DataRow dataRow6 = (DataRow)obj10;
										this.PrintBarCode("999" + dataRow6["ID"].ToString(), Conversions.ToDecimal(dataRow6["deposit_amount"]));
									}
								}
								finally
								{
									IEnumerator enumerator10;
									if (enumerator10 is IDisposable)
									{
										(enumerator10 as IDisposable).Dispose();
									}
								}
							}
						}
						this.ClearForm();
						Cursor.Current = Cursors.Default;
						bool flag139 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
						if (flag139)
						{
							this.txtsearch.Focus();
						}
						else
						{
							this.txtBarCode.Focus();
						}
						MessageBox.Show("Sale Done. Invoice number: " + this.invnum.ToString());
						this.saledone = true;
					}
					catch (Exception ex9)
					{
						try
						{
							MessageBox.Show("Error confirming sale. Attempting rollback. Detail: " + text + ": " + ex9.Message);
							Cursor.Current = Cursors.Default;
							this.Button2.TabStop = false;
							SqlTransaction sqlTransaction;
							sqlTransaction.Rollback();
							sqlConnection.Close();
							Cursor.Current = Cursors.Default;
							bool flag140 = this.saledone;
							if (flag140)
							{
								this.ClearForm();
							}
						}
						catch (Exception ex10)
						{
						}
					}
				}
			}
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00251AC0 File Offset: 0x0024FCC0
		private void printDeliveryNote80mm(DataTable invoicedetailsDAT, int papersize)
		{
			bool flag = MyProject.Forms.Form1.RevmaxTest == 1;
			if (flag)
			{
				MessageBox.Show("About to start d note 80mm string formatting");
			}
			string text = "DELIVERY NOTE";
			string text2 = this.pf.StringPadCentre(text, papersize);
			DataRow dataRow = invoicedetailsDAT.Rows[0];
			DataTable customerDetails = this.pf.GetCustomerDetails(this._cnn, Conversions.ToString(dataRow["Ref"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			text2 = text2 + this.pf.StringPadCentre(text2, papersize) + Environment.NewLine;
			string branch = MyProject.Forms.Form1.branch;
			int coid = MyProject.Forms.Form1.coid;
			this.TextToPrint = text2;
			this.coname = this.pf.StringPadCentre(this.coname, papersize);
			text2 = this.coname;
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			bool flag2 = Operators.CompareString(this.cobpnum, "", false) != 0;
			if (flag2)
			{
				text2 = this.bpnum_name + " " + this.cobpnum;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag3 = Operators.CompareString(this.coVATNum, "", false) != 0;
			if (flag3)
			{
				text2 = this.vatnum_name + " " + this.coVATNum;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			text2 = this.coadd;
			text2 = this.pf.StringPadCentre(text2, papersize);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			text2 = this.coadd2;
			text2 = this.pf.StringPadCentre(text2, papersize);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			bool flag4 = Operators.CompareString(this.coemail, "", false) != 0;
			if (flag4)
			{
				text2 = this.coemail;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag5 = Operators.CompareString(this.cotel, "", false) != 0;
			if (flag5)
			{
				text2 = this.cotel;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag6 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
			if (flag6)
			{
				text2 = this.cotel2 + "  " + this.cotel3;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			text2 = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			text2 = "Teller: " + MyProject.Forms.Form1.username + Environment.NewLine + Environment.NewLine;
			text2 = text2 + "Delivery note number: D" + dataRow["Invoice_Number"].ToString();
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine + Environment.NewLine;
			DataRow dataRow2 = customerDetails.Rows[0];
			text2 = "CUSTOMER DETAILS" + Environment.NewLine;
			bool flag7 = Operators.CompareString(this.@ref, "", false) != 0;
			if (flag7)
			{
				text2 = text2 + "Ref: " + this.@ref + Environment.NewLine;
			}
			string text3 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["CustomerName"])), "", dataRow2["CustomerName"].ToString()));
			string text4 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["ContactName"])), "", dataRow2["ContactName"].ToString()));
			string text5 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Address"])), "", dataRow2["Address"].ToString()));
			string text6 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Mobile"])), "", dataRow2["Mobile"].ToString()));
			bool flag8 = Operators.CompareString(text3, "", false) != 0;
			if (flag8)
			{
				text2 = text2 + text3 + Environment.NewLine;
			}
			bool flag9 = Operators.CompareString(text4, "", false) != 0;
			if (flag9)
			{
				text2 = text2 + text4 + Environment.NewLine;
			}
			bool flag10 = Operators.CompareString(text5, "", false) != 0;
			if (flag10)
			{
				text2 = text2 + text5 + Environment.NewLine;
			}
			bool flag11 = Operators.CompareString(text6, "", false) != 0;
			if (flag11)
			{
				text2 = text2 + text6 + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			text2 = "DELIVERY ITEMS" + Environment.NewLine;
			text2 = text2 + "Description/Quantity" + Environment.NewLine + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2;
			bool flag12 = false;
			try
			{
				foreach (object obj in invoicedetailsDAT.Rows)
				{
					dataRow = (DataRow)obj;
					string text7 = "[" + dataRow["BinLocation"].ToString() + "] " + dataRow["Description"].ToString();
					text7 = text7.PadRight(40, ' ');
					bool flag13 = text7.Length >= 40;
					if (flag13)
					{
						text7 = text7.Substring(0, 40);
					}
					string text8 = Conversions.ToString(dataRow["uom"]);
					bool flag14 = Operators.CompareString(text8, "EA", false) == 0;
					string text9;
					if (flag14)
					{
						DataRow dataRow3;
						object[] array;
						bool[] array2;
						object obj2 = NewLateBinding.LateGet(null, typeof(Math), "Floor", array = new object[] { (dataRow3 = dataRow)["Quantity"] }, null, null, array2 = new bool[] { true });
						if (array2[0])
						{
							dataRow3["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						text9 = obj2.ToString();
					}
					else
					{
						text9 = dataRow["Quantity"].ToString();
						flag12 = true;
					}
					text2 = text7 + Environment.NewLine;
					text2 = text2 + "  X  " + text9 + Environment.NewLine;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text2;
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
			bool flag15 = flag12;
			if (flag15)
			{
				text2 = Environment.NewLine + "Total number of items: " + invoicedetailsDAT.Compute("sum(Quantity)", "").ToString() + Environment.NewLine;
			}
			else
			{
				text2 = Environment.NewLine + "Total number of items: " + NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
				{
					invoicedetailsDAT.Compute("sum(Quantity)", ""),
					0
				}, null, null, null).ToString() + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2;
			text2 = Environment.NewLine + "Received by:__________________________________" + Environment.NewLine + Environment.NewLine;
			text2 += "Signature:____________________________________";
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2;
			this.stringToRead = new StringReader(this.TextToPrint);
			bool flag16 = MyProject.Forms.Form1.RevmaxTest == 1;
			if (flag16)
			{
				MessageBox.Show("D Note string formatted. Printing now.");
			}
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			finally
			{
				this.stringToRead.Close();
			}
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x002523E4 File Offset: 0x002505E4
		private DataTable GetEconetAirtimeVouchers(int invnum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "EconetAirtimeGet";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x00252494 File Offset: 0x00250694
		private void printEconetAirtimeVoucher(int invoice_number)
		{
			this.TextToPrint = "";
			string text = "ECONET AIRTIME VOUCHER" + Environment.NewLine;
			int length = text.Length;
			string text2 = new string(' ', checked((int)Math.Round(Math.Round((double)(50 - length) / 2.0))));
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + text + Environment.NewLine;
			DataTable econetAirtimeVouchers = this.GetEconetAirtimeVouchers(this.invnum);
			try
			{
				foreach (object obj in econetAirtimeVouchers.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text3 = this.pf.Decrypt(Conversions.ToString(dataRow["airtimevoucher"]), Conversions.ToString(MyProject.Forms.Form1.coid));
					string text4 = Conversions.ToString(dataRow["SerialNumber"]);
					string text5 = Conversions.ToString(dataRow["BatchNumber"]);
					string text6 = Conversions.ToString(dataRow["Denomination"]);
					string text7 = Conversions.ToString(dataRow["ExpiryDate"]);
					text = "Voucher Number:" + Environment.NewLine;
					text = text + text3 + Environment.NewLine + Environment.NewLine;
					text = text + "Denomination: " + text6 + Environment.NewLine;
					text = text + "Serial Number: " + text4 + Environment.NewLine;
					text = text + "Batch Number: " + text5 + Environment.NewLine;
					text = string.Concat(new string[]
					{
						text,
						"Expiry Date: ",
						text7,
						Environment.NewLine,
						Environment.NewLine,
						Environment.NewLine
					});
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text;
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
			this.stringToRead = new StringReader(this.TextToPrint);
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			finally
			{
				this.stringToRead.Close();
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0025273C File Offset: 0x0025093C
		private void InsertPayMethod(int invoicenumber, int payid, string paydesc, double amt, string branch, int coid, decimal rate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertActualPaymentMethods";
			sqlCommand.Parameters.AddWithValue("invnum", invoicenumber);
			sqlCommand.Parameters.AddWithValue("payid", payid);
			sqlCommand.Parameters.AddWithValue("paydesc", paydesc);
			sqlCommand.Parameters.AddWithValue("amt", amt);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("rate", rate);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00252844 File Offset: 0x00250A44
		private void ClearForm()
		{
			this.currentIsEditable = false;
			bool flag = MyProject.Forms.Form1.hidevat == 1;
			if (flag)
			{
				this.chkHideTax.Checked = true;
			}
			else
			{
				this.chkHideTax.Checked = false;
			}
			this.LoadCustomers();
			this.DataGridView1.Rows.Clear();
			this.txtStockAvail.Text = Conversions.ToString(0);
			this.txtPrice.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.txtSearchProductCode.Text = Conversions.ToString(0);
			this.txtTotal.Text = Conversions.ToString(0);
			this.currentCustomerEntryNo = 0;
			this.txtcustomer.Text = "Cash";
			this.FetchCustomer(this.txtcustomer.Text);
			this.txtAddress.Text = "";
			this.txtMobile.Text = "";
			this.txtEmail.Text = "";
			this.txtMobile.Text = "";
			this.txtChange.Text = "";
			this.txtAmtPaid.Text = "";
			this.txtContactName.Text = "";
			this.txtTel.Text = "";
			this.txtbpnumber.Text = "";
			this.txtvatnumber.Text = "";
			this.og_customername = this.txtcustomer.Text;
			this.og_address = this.txtAddress.Text;
			this.og_contactname = this.txtContactName.Text;
			this.og_mobile = this.txtMobile.Text;
			this.og_email = this.txtEmail.Text;
			this.og_tel = this.txtTel.Text;
			this.og_invdetail1 = this.txtInvDetails1.Text;
			this.og_invdetail2 = this.txtInvDetails2.Text;
			this.og_bpnumber = this.txtbpnumber.Text;
			this.og_vatnumber = this.txtvatnumber.Text;
			this.txtTax.Text = Conversions.ToString(0);
			this.txtPriceChange.Text = "";
			this.lblcode.Text = "";
			bool flag2 = MyProject.Forms.Form1.TillPointPriceChange == 0;
			if (flag2)
			{
				this.txtPriceChange.Visible = false;
			}
			else
			{
				this.txtPriceChange.Visible = true;
			}
			this.txtBarCode.Text = "";
			this.Button2.TabStop = false;
			this.rdbCollectionsNone.Checked = true;
			this.txtDiscount.Text = "0";
			this.txtDiscount.ReadOnly = true;
			this.txtPriceChange.ReadOnly = true;
			this.discDESC = "";
			this.discAmount = 0m;
			DataTable dataTable = new DataTable();
			this.datProm = dataTable;
			this.datProm.Columns.Add("PromNo", typeof(int));
			this.chkAccount.Checked = false;
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
			this.chkMultiple.Checked = false;
			bool flag3 = MyProject.Forms.Form1.DiscountEditingAllowed == 1;
			if (flag3)
			{
				this.txtPriceChange.ReadOnly = false;
			}
			else
			{
				this.txtPriceChange.ReadOnly = true;
			}
			this.cboPayMeth.Enabled = true;
			this.PaymentMethodDiscountEffected = 0;
			this.isunedingstock = false;
			this.specialprice = 0m;
			this.currenttaxrate = 0m;
			this.RowID = 0;
			bool flag4 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag4)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
			this.currentCustomerLimit = 0m;
			this.cboCustomers.Text = "";
			bool flag5 = Operators.CompareString(MyProject.Forms.Form1.ChangePaymentMethod, "", false) != 0;
			if (flag5)
			{
				this.cboPayMeth.SelectedIndex = this.cboPayMeth.FindStringExact(MyProject.Forms.Form1.ChangePaymentMethod);
			}
			else
			{
				this.cboPayMeth.SelectedIndex = 0;
			}
			this.currentIsCalcLxW = false;
			this.currComment = "";
			this.lbltotprice.Text = "...";
			this.currQuotationNumber = 0;
			this.EffectTillpointPrice();
			this.UpdateCustomerDisplayVFD("0.00");
			this.lblBinLoc.Text = "...";
			MyProject.Forms.Form1.discountApprovedIsPerc = false;
			MyProject.Forms.Form1.DiscountApprovedAmt = 0m;
			MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
			MyProject.Forms.Form1.Approvedby = "";
			this.radTakeAway.Checked = false;
			this.radSitIn.Checked = false;
			this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
			this.DepositUsed = false;
			MyProject.Forms.Form1.DiscountApproved = 0;
			bool flag6 = MyProject.Forms.Form1.ConsultantDefaultToUsername == 1;
			if (flag6)
			{
				this.cboConsultant.SelectedIndex = this.cboConsultant.FindStringExact(MyProject.Forms.Form1.username);
			}
			else
			{
				this.cboConsultant.SelectedIndex = -1;
			}
			this.DisableEditing = false;
			this.@ref = "";
			this.altdescription = "";
			this.txtOrderNo.Text = "";
			this.txtQtyWeighed.Text = "0";
			try
			{
			}
			catch (Exception ex)
			{
				bool flag7 = MyProject.Forms.Form1.RevmaxTest == 1;
				if (flag7)
				{
					MessageBox.Show("Error in clear form handled.");
				}
			}
			this.qrveri_code = "";
			this.qrveri_link = "";
			MyProject.Forms.Form1.pendinginvoice_entryno = 0;
			MyProject.Forms.Form1.pendinginvoice_ref = 0;
			this.lblRef.Text = "...";
			this.currBreak = 0;
			DataTable dataTable2 = new DataTable();
			MyProject.Forms.Form1.datSerialsSelect4Sales = dataTable2;
			this.PicQRCode.Image = null;
			DataTable dataTable3 = new DataTable();
			this.DGVSearch.DataSource = dataTable3;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00252F88 File Offset: 0x00251188
		private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x00252FD4 File Offset: 0x002511D4
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

		// Token: 0x0600406D RID: 16493 RVA: 0x00253058 File Offset: 0x00251258
		private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				this.CalcTotalSale();
				bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag)
				{
					this.txtSearchProductCode.Focus();
				}
				else
				{
					this.txtBarCode.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting row. Restart SALE.");
			}
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x002530D0 File Offset: 0x002512D0
		private void PrintAirtimeVoucher(int invnum, int coid, string branch)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"Select * from EconetAirtime where InvNum = ",
					invnum.ToString(),
					" and coid= ",
					coid.ToString(),
					" and branch = '",
					branch,
					"'"
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					string text = this.pf.AirtimeVoucherTEXT(dataTable, "ECONET AIRTIME");
					this.stringToRead = new StringReader(text);
					try
					{
						StandardPrintController standardPrintController = new StandardPrintController();
						bool flag2 = Operators.CompareString(MyProject.Forms.Form1.defaultReceiptPrinter, "", false) != 0;
						if (flag2)
						{
							this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
						}
						this.PrintDocument1.PrintController = standardPrintController;
						this.PrintDocument1.Print();
					}
					finally
					{
						this.stringToRead.Close();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x0025324C File Offset: 0x0025144C
		private bool PrintBarCode(string barcodeID, decimal deposit_amt)
		{
			this.DepAmount = deposit_amt;
			BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39NC;
			this.BarcodePanel1.Text = string.Empty;
			this.BarcodePanel1.Symbology = barcodeSymbology;
			this.BarcodePanel1.Text = barcodeID;
			string text = "Barcode";
			this.PrintDocument2.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
			this.PrintDocument2.PrintController = new StandardPrintController();
			this.PrintDocument2.PrinterSettings.Copies = 1;
			bool isValid = this.PrintDocument2.PrinterSettings.IsValid;
			if (isValid)
			{
				this.PrintDocument2.DocumentName = text;
				this.PrintDocument2.Print();
			}
			return true;
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00253310 File Offset: 0x00251510
		private void pdPrint_PrintPage(object sender, PrintPageEventArgs e)
		{
			BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39NC;
			SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, this.DepositBarCode, 20);
			global::System.Drawing.Font font = new global::System.Drawing.Font("Verdana", (float)MyProject.Forms.Form1.ReceiptFontSize);
			StringFormat stringFormat = new StringFormat();
			stringFormat.LineAlignment = StringAlignment.Center;
			iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(70f, 185f, 280f, 15f);
			int num = 10;
			e.Graphics.DrawImage(symbologyTestCase.BarcodeImage, new Point(num, Convert.ToInt32(MyProject.Forms.Form1.FSYbarcode)));
			e.Graphics.DrawString(this.BarcodePanel1.Text, font, SystemBrushes.WindowText, new PointF((float)num, Convert.ToSingle(MyProject.Forms.Form1.FSYbarcodetext)));
			e.Graphics.DrawString(Conversions.ToString(this.DepAmount), font, SystemBrushes.WindowText, new PointF((float)num, Convert.ToSingle(MyProject.Forms.Form1.FSYprice)));
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x00253418 File Offset: 0x00251618
		private void GenerateBarcode()
		{
			BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39NC;
			SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, this.DepositBarCode, 20);
			iTextSharp.text.Font font = new iTextSharp.text.Font((iTextSharp.text.Font.FontFamily)Conversions.ToInteger("Verdana"), (float)MyProject.Forms.Form1.ReceiptFontSize);
			StringFormat stringFormat = new StringFormat();
			stringFormat.LineAlignment = StringAlignment.Center;
			iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(70f, 185f, 280f, 15f);
			this.PictureBox2.Image = symbologyTestCase.BarcodeImage;
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x00253498 File Offset: 0x00251698
		private void PrintReceipt(int invnumber, string revmaxdigital_signature, string printername, string copyname, string vfiscaldaynumber = "", string vGlobalRec = "", string vDeviceNo = "")
		{
			bool flag = MyProject.Forms.Form1.RevmaxTest == 1;
			if (flag)
			{
				MessageBox.Show("Printing PrintReceipt. Fiscal Day: " + vfiscaldaynumber.ToString());
			}
			bool flag2 = MyProject.Forms.Form1.useOldPrintingService == 1;
			checked
			{
				if (flag2)
				{
					this.PrintHeader(copyname);
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
				else
				{
					try
					{
						PrinterClass printerClass = new PrinterClass(printername, Application.StartupPath);
						PrinterClass printerClass2 = printerClass;
						int receipt_logo_space = MyProject.Forms.Form1.receipt_logo_space;
						bool flag3 = File.Exists("C:\\Quantum\\logo.bmp");
						if (flag3)
						{
							printerClass2.RTL = false;
							printerClass2.PrintLogo(receipt_logo_space);
							printerClass2.FeedPaper(3);
						}
						printerClass2.FontName = "Courier New";
						this.PrintHeader(copyname);
						this.ItemsToBePrinted(invnumber);
						this.PrintFooter(revmaxdigital_signature);
						printerClass2.NormalFont();
						printerClass2.FontSize = (float)MyProject.Forms.Form1.ReceiptFontSize;
						printerClass2.WriteChars(this.TextToPrint);
						bool flag4 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
						if (flag4)
						{
							try
							{
								global::System.Drawing.Image image = this.PictureBox1.Image;
								BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39C;
								SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, invnumber.ToString(), 20);
								this.PictureBox1.Image = symbologyTestCase.BarcodeImage;
								printerClass2.PrintBarcodeImage(this.PictureBox1, receipt_logo_space);
							}
							catch (Exception ex)
							{
								MessageBox.Show("Failed to print barcode on receipt. Error: " + ex.Message);
							}
						}
						bool flag5 = (MyProject.Forms.Form1.deposits_inuse == 1) & this.DepositUsed;
						if (flag5)
						{
							try
							{
								DataTable deposits = this.GetDeposits(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.invnum);
								try
								{
									foreach (object obj in deposits.Rows)
									{
										DataRow dataRow = (DataRow)obj;
										this.GenerateBarcode();
										printerClass2.PrintBarcodeImage(this.PictureBox2, receipt_logo_space);
										string text = Conversions.ToString(Operators.ConcatenateObject(string.Concat(new string[]
										{
											Environment.NewLine,
											Environment.NewLine,
											"999",
											dataRow["ID"].ToString(),
											Environment.NewLine,
											"Deposit amount: ",
											MyProject.Forms.Form1.basecurrency
										}), dataRow["deposit_amount"]));
										printerClass2.WriteChars(text);
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
							catch (Exception ex2)
							{
								MessageBox.Show("Failed to print barcode on receipt. Error: " + ex2.Message);
							}
						}
						bool flag6 = !Information.IsNothing(this.PicQRCode.Image);
						if (flag6)
						{
							string text2 = string.Concat(new string[]
							{
								"Verification Code: ",
								this.qrveri_code,
								Environment.NewLine,
								"You can verifty this receipt manually at: ",
								Environment.NewLine,
								this.qrveri_link,
								Environment.NewLine,
								"Fiscal Day: ",
								vfiscaldaynumber,
								Environment.NewLine,
								"Receipt Global No: ",
								vGlobalRec,
								Environment.NewLine,
								"Device ID: ",
								vDeviceNo
							});
							printerClass2.WriteChars(text2);
							printerClass2.WriteLine(" ");
							printerClass2.PrintBarcodeImage(this.PicQRCode, (int)Math.Round(unchecked((double)receipt_logo_space - (double)receipt_logo_space / 2.0)));
							printerClass2.WriteLine(" ");
							printerClass2.WriteLine(" ");
							printerClass2.WriteLine(" ");
							printerClass2.WriteLine(" ");
							printerClass2.WriteLine(" ");
							printerClass2.WriteLine(" ");
							printerClass2.WriteLine(" ");
						}
						bool flag7 = Operators.CompareString(this.website_og, "", false) != 0;
						if (flag7)
						{
							try
							{
								Bitmap bitmap = this.pf.GenerateQrImage(this.website_og, MyProject.Forms.Form1.QRCodeSize);
								this.PicQRCode.Image = bitmap;
								printerClass2.WriteChars(this.website_comment);
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
								printerClass2.PrintBarcodeImage(this.PicQRCode, receipt_logo_space);
							}
							catch (Exception ex3)
							{
								MessageBox.Show("error with website url qr code. Details: " + ex3.Message);
							}
						}
						int num = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "ReceiptExtraSpace", MyProject.Forms.Form1.Constring)));
						string text3 = "";
						bool flag8 = num > 0;
						if (flag8)
						{
							text3 += string.Concat(Enumerable.Repeat<string>(Environment.NewLine, num));
							printerClass2.WriteChars(text3);
						}
						printerClass2.CutPaper();
						printerClass2.EndDoc();
						printerClass2 = null;
					}
					catch (Exception ex4)
					{
						MessageBox.Show("Error printing. Detail: " + ex4.Message);
					}
				}
			}
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x00253B34 File Offset: 0x00251D34
		private void PrintReceipt2(int invnumber, string revmaxdigital_signature, string printername, string copyname, string vfiscaldaynumber = "", string vGlobalRec = "", string vDeviceNo = "")
		{
			bool flag = MyProject.Forms.Form1.RevmaxTest == 1;
			if (flag)
			{
				MessageBox.Show("Printing PrintReceipt. Fiscal Day: " + vfiscaldaynumber.ToString());
			}
			bool flag2 = MyProject.Forms.Form1.useOldPrintingService == 1;
			if (flag2)
			{
				this.PrintHeader(copyname);
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
			else
			{
				try
				{
					PrinterClass2 printerClass = new PrinterClass2("C:\\Quantum");
					PrinterClass2 printerClass2 = printerClass;
					int receipt_logo_space = MyProject.Forms.Form1.receipt_logo_space;
					bool flag3 = File.Exists("C:\\Quantum\\logo.bmp");
					if (flag3)
					{
						printerClass2.RTL = false;
						printerClass2.PrintLogo(receipt_logo_space);
						printerClass2.FeedPaper(3);
					}
					printerClass2.FontName = "Courier New";
					this.PrintHeader(copyname);
					this.ItemsToBePrinted(invnumber);
					this.PrintFooter(revmaxdigital_signature);
					printerClass2.NormalFont();
					printerClass2.FontSize = (float)MyProject.Forms.Form1.ReceiptFontSize;
					printerClass2.WriteChars(this.TextToPrint);
					bool flag4 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
					if (flag4)
					{
						try
						{
							global::System.Drawing.Image image = this.PictureBox1.Image;
							BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39C;
							SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, invnumber.ToString(), 20);
							this.PictureBox1.Image = symbologyTestCase.BarcodeImage;
							printerClass2.PrintBarcodeImage(this.PictureBox1, receipt_logo_space);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Failed to print barcode on receipt. Error: " + ex.Message);
						}
					}
					bool flag5 = (MyProject.Forms.Form1.deposits_inuse == 1) & this.DepositUsed;
					if (flag5)
					{
						try
						{
							DataTable deposits = this.GetDeposits(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.invnum);
							try
							{
								foreach (object obj in deposits.Rows)
								{
									DataRow dataRow = (DataRow)obj;
									this.GenerateBarcode();
									printerClass2.PrintBarcodeImage(this.PictureBox2, receipt_logo_space);
									string text = Conversions.ToString(Operators.ConcatenateObject(string.Concat(new string[]
									{
										Environment.NewLine,
										Environment.NewLine,
										"999",
										dataRow["ID"].ToString(),
										Environment.NewLine,
										"Deposit amount: ",
										MyProject.Forms.Form1.basecurrency
									}), dataRow["deposit_amount"]));
									printerClass2.WriteChars(text);
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
						catch (Exception ex2)
						{
							MessageBox.Show("Failed to print barcode on receipt. Error: " + ex2.Message);
						}
					}
					bool flag6 = !Information.IsNothing(this.PicQRCode.Image);
					if (flag6)
					{
						string text2 = string.Concat(new string[]
						{
							"Verification Code: ",
							this.qrveri_code,
							Environment.NewLine,
							"You can verifty this receipt manually at: ",
							Environment.NewLine,
							this.qrveri_link,
							Environment.NewLine,
							"Fiscal Day: ",
							vfiscaldaynumber,
							Environment.NewLine,
							"Receipt Global No: ",
							vGlobalRec,
							Environment.NewLine,
							"Device ID: ",
							vDeviceNo
						});
						printerClass2.WriteChars(text2);
						printerClass2.WriteLine(" ");
						printerClass2.PrintBarcodeImage(this.PicQRCode, receipt_logo_space);
					}
					bool flag7 = Operators.CompareString(this.website_og, "", false) != 0;
					if (flag7)
					{
						try
						{
							global::System.Drawing.Image image2 = this.PictureBox1.Image;
							BarcodeSymbology barcodeSymbology2 = BarcodeSymbology.CodeQr;
							SymbologyTestCase symbologyTestCase2 = new SymbologyTestCase(barcodeSymbology2, this.website_og, 15);
							this.PicQRCode.Image = symbologyTestCase2.BarcodeImage;
							printerClass2.WriteChars(this.website_comment);
							printerClass2.WriteLine(" ");
							printerClass2.PrintBarcodeImage(this.PicQRCode, receipt_logo_space);
						}
						catch (Exception ex3)
						{
							MessageBox.Show("error with website url qr code. Details: " + ex3.Message);
						}
					}
					printerClass2.CutPaper();
					printerClass2.Print();
					printerClass2.EndDoc();
					printerClass2 = null;
				}
				catch (Exception ex4)
				{
					MessageBox.Show("Error printing. Detail: " + ex4.Message);
				}
			}
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x002540D0 File Offset: 0x002522D0
		private void PrintReceipt58(int invnumber)
		{
			this.PrintHeader58();
			this.ItemsToBePrinted58(invnumber);
			this.PrintFooter58();
			StandardPrintController standardPrintController = new StandardPrintController();
			this.PrintDocument1.PrintController = standardPrintController;
			this.PrintDocument1.Print();
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00254114 File Offset: 0x00252314
		public void PrintHeader(string copyname)
		{
			this.coname = this.coname_og;
			this.coadd = this.coadd_og;
			this.coadd2 = this.coadd2_og;
			this.cotel = this.cotel_og;
			this.cotel2 = this.cotel2_og;
			this.cotel3 = this.cotel3_og;
			this.coemail = this.coemail_og;
			this.coVATNum = this.coVATNum_og;
			this.cobpnum = this.cobpnum_og;
			this.bpnum_name = this.bpnum_name_og;
			this.vatnum_name = this.vatnum_name_og;
			this.footnote = this.footnote_og;
			bool flag = MyProject.Forms.Form1.ReceiptSize80 == 1;
			checked
			{
				int num;
				if (flag)
				{
					num = MyProject.Forms.Form1.ReceiptSpacingSize;
				}
				else
				{
					num = (int)Math.Round(unchecked(0.6666666666666666 * (double)MyProject.Forms.Form1.ReceiptSpacingSize));
				}
				this.TextToPrint = " ";
				bool flag2 = copyname.Length > 0;
				if (flag2)
				{
					this.TextToPrint = copyname + Environment.NewLine + Environment.NewLine;
				}
				bool flag3 = MyProject.Forms.Form1.PrintFiscal == 1;
				string text;
				if (flag3)
				{
					text = "FISCAL TAX INVOICE";
				}
				else
				{
					text = MyProject.Forms.Form1.InvoiceHeaderText;
				}
				text = this.pf.StringPadCentre(text, num);
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag4 = this.coname.Length > 80;
				if (flag4)
				{
					this.coname = this.coname;
				}
				else
				{
					this.coname = this.pf.StringPadCentre(this.coname, num);
				}
				text = this.coname;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag5 = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag5)
				{
					text = this.bpnum_name + " " + this.cobpnum;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag6 = Operators.CompareString(this.coVATNum, "", false) != 0;
				if (flag6)
				{
					text = this.vatnum_name + " " + this.coVATNum;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				text = this.coadd;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = this.coadd2;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag7 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag7)
				{
					text = this.coemail;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag8 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag8)
				{
					text = this.cotel;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag9 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag9)
				{
					text = this.cotel2 + "  " + this.cotel3;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				text = "Teller: " + MyProject.Forms.Form1.username;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00254524 File Offset: 0x00252724
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
			text = this.coadd2;
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

		// Token: 0x06004077 RID: 16503 RVA: 0x00254750 File Offset: 0x00252950
		public void ItemsToBePrinted(int invnumber)
		{
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
			DataRow dataRow = dataTable.Rows[0];
			DataTable customerDetails = this.pf.GetCustomerDetails(this._cnn, Conversions.ToString(dataRow["ref"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			bool flag = customerDetails.Rows.Count > 0;
			DataRow dataRow2;
			if (flag)
			{
				dataRow2 = customerDetails.Rows[0];
			}
			decimal num2 = 0m;
			bool flag2 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NORMAL", false) == 0;
			checked
			{
				ref string ptr;
				string text5;
				if (flag2)
				{
					this.ProdtDiscTotal = 0m;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					bool flag3 = !this.chkAccount.Checked;
					if (flag3)
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
					}
					else
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "ACCOUNT SALE" + Environment.NewLine;
					}
					bool flag4 = Operators.CompareString(this.@ref, "", false) != 0;
					if (flag4)
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Ref: " + this.@ref + Environment.NewLine;
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					bool flag5 = MyProject.Forms.Form1.ShowOrderNo == 1;
					if (flag5)
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = string.Concat(new string[]
						{
							ptr,
							"*****ORDER NUMBER: ",
							dataRow["ReceiptCounter"].ToString(),
							" *****",
							Environment.NewLine
						});
					}
					bool flag6 = MyProject.Forms.Form1.FiscalRevmax == 1;
					if (flag6)
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Invoice Number: " + dataRow["ReceiptGlobalNo"].ToString() + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Document Number: " + Conversions.ToString(invnumber) + Environment.NewLine;
					}
					else
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Invoice Number: " + Conversions.ToString(invnumber) + Environment.NewLine;
					}
					string text = Conversions.ToString(dataRow["trantime"]);
					string text2 = Conversions.ToString(dataRow["Sale_Date"]);
					string text3 = "yyyyMMdd";
					DateTime dateTime = DateTime.ParseExact(text2.ToString(), text3, CultureInfo.InvariantCulture);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "Invoice Date: " + dateTime.ToShortDateString() + Environment.NewLine;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "Invoice Time: " + text + Environment.NewLine;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					string text4 = dataRow["ref"].ToString();
					bool flag7 = Operators.CompareString(dataRow["ref"].ToString(), "Cash", false) != 0;
					if (flag7)
					{
						text5 = "Customer Name: " + dataRow2["CustomerName"].ToString();
						bool flag8 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", MyProject.Forms.Form1.Constring), "1", false) == 0;
						if (flag8)
						{
							text5 = string.Concat(new string[]
							{
								text5,
								Environment.NewLine,
								"Customer Address: ",
								dataRow2["StreetNumber"].ToString(),
								", ",
								dataRow2["Address"].ToString(),
								", ",
								dataRow2["City"].ToString(),
								", ",
								dataRow2["Province"].ToString()
							});
							bool flag9 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
							if (flag9)
							{
								text5 = text5 + Environment.NewLine + "Customer Phone #: " + dataRow2["Mobile"].ToString();
							}
							bool flag10 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
							if (flag10)
							{
								text5 = string.Concat(new string[]
								{
									text5,
									Environment.NewLine,
									this.bpnum_name,
									" ",
									dataRow2["BPNumber"].ToString()
								});
							}
							bool flag11 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
							if (flag11)
							{
								text5 = string.Concat(new string[]
								{
									text5,
									Environment.NewLine,
									this.vatnum_name,
									" ",
									dataRow2["VATNumber"].ToString()
								});
							}
							bool flag12 = Operators.CompareString(dataRow2["Email"].ToString(), "", false) != 0;
							if (flag12)
							{
								text5 = text5 + Environment.NewLine + "Customer Email: " + dataRow2["Email"].ToString();
							}
						}
						else
						{
							bool flag13 = Operators.CompareString(dataRow2["StreetNumber"].ToString(), "", false) != 0;
							if (flag13)
							{
								text5 = text5 + Environment.NewLine + "Customer Street Number: " + dataRow2["StreetNumber"].ToString();
							}
							bool flag14 = Operators.CompareString(dataRow2["Address"].ToString(), "", false) != 0;
							if (flag14)
							{
								text5 = text5 + Environment.NewLine + "Customer Address: " + dataRow2["Address"].ToString();
							}
							bool flag15 = Operators.CompareString(dataRow2["City"].ToString(), "", false) != 0;
							if (flag15)
							{
								text5 = text5 + Environment.NewLine + "Customer City: " + dataRow2["City"].ToString();
							}
							bool flag16 = Operators.CompareString(dataRow2["Province"].ToString(), "", false) != 0;
							if (flag16)
							{
								text5 = text5 + Environment.NewLine + "Customer Province: " + dataRow2["Province"].ToString();
							}
							bool flag17 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
							if (flag17)
							{
								text5 = text5 + Environment.NewLine + "Customer Phone #: " + dataRow2["Mobile"].ToString();
							}
							bool flag18 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
							if (flag18)
							{
								text5 = string.Concat(new string[]
								{
									text5,
									Environment.NewLine,
									this.bpnum_name,
									" ",
									dataRow2["BPNumber"].ToString()
								});
							}
							bool flag19 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
							if (flag19)
							{
								text5 = string.Concat(new string[]
								{
									text5,
									Environment.NewLine,
									this.vatnum_name,
									" ",
									dataRow2["VATNumber"].ToString()
								});
							}
							bool flag20 = Operators.CompareString(dataRow2["Email"].ToString(), "", false) != 0;
							if (flag20)
							{
								text5 = text5 + Environment.NewLine + "Customer Email: " + dataRow2["Email"].ToString();
							}
						}
						text5 = text5 + Environment.NewLine + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text5;
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "HS Code : Description " + this.paymeth_currency;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine + this.LINE;
					bool flag21 = this.radSitIn.Checked | this.radTakeAway.Checked;
					if (flag21)
					{
						bool @checked = this.radSitIn.Checked;
						if (@checked)
						{
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + Environment.NewLine + "SIT IN" + Environment.NewLine;
						}
						else
						{
							bool checked2 = this.radTakeAway.Checked;
							if (checked2)
							{
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + Environment.NewLine + "TAKE AWAY" + Environment.NewLine;
							}
						}
					}
					decimal num3 = 0m;
					string text6 = "Qty";
					string text7 = "UnitPrice";
					string text8 = "VAT";
					string text9 = "Amount(Incl)";
					text5 = string.Concat(new string[]
					{
						Environment.NewLine,
						text6.PadLeft(this.qty_spacing, ' '),
						text7.PadLeft(this.unitprice_spacing, ' '),
						text8.PadLeft(this.tax_spacing, ' '),
						text9.PadLeft(this.total_spacing, ' ')
					});
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + Environment.NewLine;
					bool flag22 = num > 0;
					if (flag22)
					{
						int num4 = 0;
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow3 = (DataRow)obj;
								num4++;
								bool flag23 = decimal.Compare(Conversions.ToDecimal(dataRow3["Unit_Selling_Price"]), 0m) != 0;
								if (flag23)
								{
									string text10 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["HSCode"], " : "), dataRow3["Description"]));
									string text11 = Conversions.ToString(dataRow3["UOM"]);
									bool flag24 = Operators.CompareString(text11, "EA", false) == 0;
									if (flag24)
									{
										object obj2 = null;
										Type typeFromHandle = typeof(Math);
										string text12 = "Round";
										DataRow dataRow4;
										object[] array2;
										object[] array = (array2 = new object[]
										{
											(dataRow4 = dataRow3)["Quantity"],
											0
										});
										string[] array3 = null;
										Type[] array4 = null;
										bool[] array5 = new bool[2];
										array5[0] = true;
										bool[] array6 = array5;
										object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text12, array, array3, array4, array5);
										if (array6[0])
										{
											dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
										}
										num3 = Conversions.ToDecimal(obj3);
									}
									else
									{
										object obj4 = null;
										Type typeFromHandle2 = typeof(Math);
										string text13 = "Round";
										DataRow dataRow4;
										object[] array2;
										object[] array7 = (array2 = new object[]
										{
											(dataRow4 = dataRow3)["Quantity"],
											2
										});
										string[] array8 = null;
										Type[] array9 = null;
										bool[] array10 = new bool[2];
										array10[0] = true;
										bool[] array6 = array10;
										object obj3 = NewLateBinding.LateGet(obj4, typeFromHandle2, text13, array7, array8, array9, array10);
										if (array6[0])
										{
											dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
										}
										num3 = Conversions.ToDecimal(obj3);
									}
									num2 = decimal.Add(num2, num3);
									bool flag25 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
									double num5;
									if (flag25)
									{
										num5 = Conversions.ToDouble(dataRow3["Unit_Selling_Price"]);
									}
									else
									{
										num5 = Conversions.ToDouble(dataRow3["Unit_Selling_Price"]);
									}
									double num6 = Conversions.ToDouble(dataRow3["Sub_Total"]);
									string text14 = Conversions.ToString(dataRow3["Product_Code"]);
									int num7 = (int)Math.Round(Conversion.Val(text10.Length));
									bool flag26 = num7 >= 51;
									if (flag26)
									{
										text10 = text10.Substring(0, 50);
									}
									bool flag27 = Operators.CompareString(dataRow3["paymethref"].ToString(), "", false) != 0;
									if (flag27)
									{
										text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["paymethref"], Environment.NewLine), Environment.NewLine));
									}
									bool flag28 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
									if (flag28)
									{
										DataTable productDetailsByBarCode = this.pf.GetProductDetailsByBarCode(dataRow3["Product_Code"].ToString(), this._cnn);
										DataRow dataRow5 = productDetailsByBarCode.Rows[0];
										decimal num8 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow5["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow5["TaxRate"])));
										int num9 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow5["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow5["taxexempt"])));
										bool flag29 = decimal.Compare(num8, 0m) > 0;
										if (flag29)
										{
											text10 = "T: " + text10;
										}
										else
										{
											bool flag30 = num9 == 1;
											if (flag30)
											{
												text10 = "E: " + text10;
											}
											else
											{
												text10 = "Z: " + text10;
											}
										}
									}
									decimal num10 = 0m;
									bool flag31 = dataRow3["DiscountAmt"].ToString().Length > 0;
									if (flag31)
									{
										bool flag32 = Operators.CompareString(dataRow3["DiscountAmt"].ToString(), "0.00", false) == 0;
										if (!flag32)
										{
											this.ProdtDiscTotal = Conversions.ToDecimal(Operators.MultiplyObject(dataRow3["DiscountAmt"], dataRow3["Quantity"]));
											text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Discount Given per unit: ", dataRow3["DiscountAmt"]), Environment.NewLine));
											ptr = ref this.TextToPrint;
											this.TextToPrint = ptr + text5;
										}
									}
									bool flag33 = dataRow3["Comments"].ToString().Length > 50;
									if (flag33)
									{
										text5 = dataRow3["Comments"].ToString().Substring(0, 49) + Environment.NewLine;
										text5 = text5 + dataRow3["Comments"].ToString().Substring(50, 50) + Environment.NewLine;
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text5;
									}
									else
									{
										bool flag34 = dataRow3["Comments"].ToString().Length > 0;
										if (flag34)
										{
											bool flag35 = Operators.CompareString(dataRow3["comments"].ToString(), "0", false) == 0;
											if (!flag35)
											{
												text5 = Conversions.ToString(Operators.ConcatenateObject(dataRow3["Comments"], Environment.NewLine));
												ptr = ref this.TextToPrint;
												this.TextToPrint = ptr + text5;
											}
										}
									}
									decimal num11 = new decimal(num5);
									num10 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(num11, num3), dataRow3["Tax"]));
									string text15 = Strings.Format(num11, "N2");
									string text16 = Strings.Format(num10, "N2");
									bool flag36 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 1, false);
									string text17;
									if (flag36)
									{
										text17 = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "TaxExemptSymbol", MyProject.Forms.Form1.Constring);
									}
									else
									{
										text17 = Strings.Format(RuntimeHelpers.GetObjectValue(dataRow3["Tax"]), "N2");
									}
									string text18 = num3.ToString();
									text5 = text10 + Environment.NewLine;
									string text19 = text18.ToString().PadLeft(this.qty_spacing, ' ');
									string text20 = text15.PadLeft(this.unitprice_spacing, ' ');
									string text21 = text17.PadLeft(this.tax_spacing, ' ');
									string text22 = text16.PadLeft(this.total_spacing, ' ');
									text5 = string.Concat(new string[]
									{
										text5,
										text18.ToString().PadLeft(this.qty_spacing, ' '),
										text15.PadLeft(this.unitprice_spacing, ' '),
										text17.PadLeft(this.tax_spacing, ' '),
										text16.PadLeft(this.total_spacing, ' ')
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
				else
				{
					bool flag37 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NO VAT COLUMN", false) == 0;
					if (flag37)
					{
						this.ProdtDiscTotal = 0m;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
						bool flag38 = !this.chkAccount.Checked;
						if (flag38)
						{
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
						}
						else
						{
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + "ACCOUNT SALE" + Environment.NewLine;
						}
						bool flag39 = Operators.CompareString(this.@ref, "", false) != 0;
						if (flag39)
						{
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + "Ref: " + this.@ref + Environment.NewLine;
						}
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Invoice Number: " + Conversions.ToString(invnumber) + Environment.NewLine;
						string text23 = Conversions.ToString(dataRow["trantime"]);
						string text24 = Conversions.ToString(dataRow["Sale_Date"]);
						string text25 = "yyyyMMdd";
						DateTime dateTime2 = DateTime.ParseExact(text24.ToString(), text25, CultureInfo.InvariantCulture);
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Invoice Date: " + dateTime2.ToShortDateString() + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Invoice Time: " + text23 + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
						bool flag40 = Operators.CompareString(dataRow["ref"].ToString(), "Cash", false) != 0;
						if (flag40)
						{
							text5 = Environment.NewLine + "Customer: " + dataRow2["CustomerName"].ToString();
							bool flag41 = Operators.CompareString(dataRow2["Address"].ToString(), "", false) != 0;
							if (flag41)
							{
								text5 = text5 + Environment.NewLine + "Address: " + dataRow2["Address"].ToString();
							}
							bool flag42 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
							if (flag42)
							{
								text5 = text5 + Environment.NewLine + "Phone #: " + dataRow2["Mobile"].ToString();
							}
							bool flag43 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
							if (flag43)
							{
								text5 = string.Concat(new string[]
								{
									text5,
									Environment.NewLine,
									this.bpnum_name,
									" ",
									dataRow2["BPNumber"].ToString()
								});
							}
							bool flag44 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
							if (flag44)
							{
								text5 = string.Concat(new string[]
								{
									text5,
									Environment.NewLine,
									this.vatnum_name,
									" ",
									dataRow2["VATNumber"].ToString()
								});
							}
							text5 = text5 + Environment.NewLine + Environment.NewLine;
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text5;
						}
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Description - " + this.paymeth_currency;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine + this.LINE;
						bool flag45 = this.radSitIn.Checked | this.radTakeAway.Checked;
						if (flag45)
						{
							bool checked3 = this.radSitIn.Checked;
							if (checked3)
							{
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + Environment.NewLine + "SIT IN" + Environment.NewLine;
							}
							else
							{
								bool checked4 = this.radTakeAway.Checked;
								if (checked4)
								{
									ptr = ref this.TextToPrint;
									this.TextToPrint = ptr + Environment.NewLine + "TAKE AWAY" + Environment.NewLine;
								}
							}
						}
						decimal num12 = 0m;
						string text26 = "Qty";
						string text27 = "UnitPrice";
						string text28 = "SubTotal";
						text5 = Environment.NewLine + text26.PadLeft(this.qty_spacing, ' ') + text27.PadLeft(this.unitprice_spacing, ' ') + text28.PadLeft(this.total_spacing, ' ');
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text5 + Environment.NewLine;
						bool flag46 = num > 0;
						if (flag46)
						{
							int num13 = 0;
							try
							{
								foreach (object obj5 in dataTable.Rows)
								{
									DataRow dataRow6 = (DataRow)obj5;
									num13++;
									bool flag47 = decimal.Compare(Conversions.ToDecimal(dataRow6["Unit_Selling_Price"]), 0m) != 0;
									if (flag47)
									{
										string text29 = Conversions.ToString(dataRow6["Description"]);
										string text30 = Conversions.ToString(dataRow6["UOM"]);
										bool flag48 = Operators.CompareString(text30, "EA", false) == 0;
										if (flag48)
										{
											object obj6 = null;
											Type typeFromHandle3 = typeof(Math);
											string text31 = "Round";
											DataRow dataRow4;
											object[] array2;
											object[] array11 = (array2 = new object[]
											{
												(dataRow4 = dataRow6)["Quantity"],
												0
											});
											string[] array12 = null;
											Type[] array13 = null;
											bool[] array14 = new bool[2];
											array14[0] = true;
											bool[] array6 = array14;
											object obj3 = NewLateBinding.LateGet(obj6, typeFromHandle3, text31, array11, array12, array13, array14);
											if (array6[0])
											{
												dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
											}
											num12 = Conversions.ToDecimal(obj3);
										}
										else
										{
											object obj7 = null;
											Type typeFromHandle4 = typeof(Math);
											string text32 = "Round";
											DataRow dataRow4;
											object[] array2;
											object[] array15 = (array2 = new object[]
											{
												(dataRow4 = dataRow6)["Quantity"],
												2
											});
											string[] array16 = null;
											Type[] array17 = null;
											bool[] array18 = new bool[2];
											array18[0] = true;
											bool[] array6 = array18;
											object obj3 = NewLateBinding.LateGet(obj7, typeFromHandle4, text32, array15, array16, array17, array18);
											if (array6[0])
											{
												dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
											}
											num12 = Conversions.ToDecimal(obj3);
										}
										num2 = decimal.Add(num2, num12);
										double num14 = Conversions.ToDouble(Operators.AddObject(dataRow6["Unit_Selling_Price"], Operators.DivideObject(dataRow6["Tax"], dataRow6["Quantity"])));
										double num15 = Conversions.ToDouble(dataRow6["Sub_Total"]);
										string text33 = Conversions.ToString(dataRow6["Product_Code"]);
										int num16 = (int)Math.Round(Conversion.Val(text29.Length));
										bool flag49 = num16 >= 34;
										if (flag49)
										{
											text29 = text29.Substring(0, 30);
										}
										bool flag50 = Operators.CompareString(dataRow6["paymethref"].ToString(), "", false) != 0;
										if (flag50)
										{
											text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow6["paymethref"], Environment.NewLine), Environment.NewLine));
										}
										int length = text29.Length;
										bool flag51 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
										if (flag51)
										{
											decimal num17 = Conversions.ToDecimal(dataRow6["TaxRate"]);
											bool flag52 = decimal.Compare(num17, 0m) > 0;
											if (flag52)
											{
												text29 = "T: " + text29;
											}
											else
											{
												text29 = "E: " + text29;
											}
										}
										decimal num18 = 0m;
										bool flag53 = dataRow6["DiscountAmt"].ToString().Length > 0;
										if (flag53)
										{
											bool flag54 = Operators.CompareString(dataRow6["DiscountAmt"].ToString(), "0.00", false) == 0;
											if (!flag54)
											{
												this.ProdtDiscTotal = Conversions.ToDecimal(Operators.MultiplyObject(dataRow6["DiscountAmt"], dataRow6["Quantity"]));
												text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Discount Given per unit: ", dataRow6["DiscountAmt"]), Environment.NewLine));
												ptr = ref this.TextToPrint;
												this.TextToPrint = ptr + text5;
											}
										}
										bool flag55 = dataRow6["Comments"].ToString().Length > 50;
										if (flag55)
										{
											text5 = dataRow6["Comments"].ToString().Substring(0, 49) + Environment.NewLine;
											text5 = text5 + dataRow6["Comments"].ToString().Substring(50, 50) + Environment.NewLine;
											ptr = ref this.TextToPrint;
											this.TextToPrint = ptr + text5;
										}
										else
										{
											bool flag56 = dataRow6["Comments"].ToString().Length > 0;
											if (flag56)
											{
												bool flag57 = Operators.CompareString(dataRow6["comments"].ToString(), "0", false) == 0;
												if (!flag57)
												{
													text5 = Conversions.ToString(Operators.ConcatenateObject(dataRow6["Comments"], Environment.NewLine));
													ptr = ref this.TextToPrint;
													this.TextToPrint = ptr + text5;
												}
											}
										}
										decimal num19 = new decimal(Math.Round(num14, 2, MidpointRounding.AwayFromZero));
										num18 = Conversions.ToDecimal(dataRow6["Sub_Total"]);
										string text34 = Strings.Format(num19, "N2");
										string text35 = Strings.Format(num18, "N2");
										bool flag58 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow6["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow6["taxexempt"])), 1, false);
										if (!flag58)
										{
											string text36 = Strings.Format(dataRow6["Tax"].ToString(), "");
										}
										string text37 = num12.ToString();
										text5 = text29 + Environment.NewLine;
										text5 = text5 + text37.ToString().PadLeft(this.qty_spacing, ' ') + text34.PadLeft(this.unitprice_spacing, ' ') + text35.PadLeft(this.total_spacing, ' ');
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text5 + Environment.NewLine;
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
				}
				text5 = Environment.NewLine + Environment.NewLine + "The number of items sold is: " + num2.ToString();
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text5 + Environment.NewLine;
			}
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x00256428 File Offset: 0x00254628
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

		// Token: 0x06004079 RID: 16505 RVA: 0x00256864 File Offset: 0x00254A64
		private void PrintFooter(string RevmaxDigital_Signature)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			int num = 0;
			int num2 = num;
			string text = "  ";
			bool flag = MyProject.Forms.Form1.ReceiptSize80 == 1;
			if (flag)
			{
				string text2 = new string(' ', Convert.ToInt32(Math.Round(new decimal(checked(26 - num2)))));
			}
			int num3 = 20;
			int num4 = 10;
			decimal num5 = Conversions.ToDecimal(Strings.Format(Conversion.Val(this.txtTotal.Text) + Conversion.Val(this.txtDiscount.Text), "N2"));
			bool flag2 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
			string text4;
			if (flag2)
			{
				int receiptDisplayPaymentMethod = MyProject.Forms.Form1.ReceiptDisplayPaymentMethod;
				decimal num6 = decimal.Multiply(Convert.ToDecimal(num5), this.receiptpaymethrate);
				num6 = Math.Round(num6, 2, MidpointRounding.AwayFromZero);
				string text3 = string.Format(string.Concat(new string[]
				{
					"{0,-",
					Conversions.ToString(num3),
					"}{1,",
					Conversions.ToString(num4),
					"}"
				}), "Inv. Subtotal:", num6.ToString("N2"));
				text4 = text3;
			}
			else
			{
				decimal num7 = Math.Round(num5, 2, MidpointRounding.AwayFromZero);
				string text5 = string.Format(string.Concat(new string[]
				{
					"{0,-",
					Conversions.ToString(num3),
					"}{1,",
					Conversions.ToString(num4),
					"}"
				}), "Inv. Subtotal:", num7.ToString("N2"));
				text4 = text5;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + text4 + Environment.NewLine;
			bool flag3 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NO VAT COLUMN", false) == 0;
			if (!flag3)
			{
				decimal num8 = new decimal(Math.Round(Conversion.Val(this.txtTax.Text), 2, MidpointRounding.AwayFromZero));
				string text6 = string.Format(string.Concat(new string[]
				{
					"{0,-",
					Conversions.ToString(num3),
					"}{1,",
					Conversions.ToString(num4),
					"}"
				}), "Total VAT:", num8.ToString("N2"));
				text4 = text6;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + text4 + Environment.NewLine;
			}
			decimal num9 = new decimal(Math.Round(Conversion.Val(this.txtDiscount.Text), 2, MidpointRounding.AwayFromZero));
			decimal num10 = new decimal(Math.Round(Conversion.Val(this.txtTotal.Text), 2, MidpointRounding.AwayFromZero));
			string text7 = string.Format(string.Concat(new string[]
			{
				"{0,-",
				Conversions.ToString(num3),
				"}{1,",
				Conversions.ToString(num4),
				"}"
			}), "Inv. Discount:", num9.ToString("N2"));
			string text8 = string.Format(string.Concat(new string[]
			{
				"{0,-",
				Conversions.ToString(num3),
				"}{1,",
				Conversions.ToString(num4),
				"}"
			}), "Invoice Total:", num10.ToString("N2"));
			text4 = text + text7 + Environment.NewLine;
			text4 = string.Concat(new string[]
			{
				text4,
				text,
				text8,
				Environment.NewLine,
				Environment.NewLine
			});
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text4;
			bool flag4 = Operators.CompareString(this.txtAmtPaid.Text, "", false) == 0;
			double num11;
			if (flag4)
			{
				num11 = 0.0;
			}
			else
			{
				num11 = Conversion.Val(this.txtAmtPaid.Text);
			}
			bool flag5 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
			if (flag5)
			{
				num11 *= Convert.ToDouble(this.receiptpaymethrate);
			}
			string text9 = string.Format(string.Concat(new string[]
			{
				"{0,-",
				Conversions.ToString(10),
				"}{1,",
				Conversions.ToString(10),
				"}"
			}), "PAID:", num11.ToString("N2"));
			text4 = text9;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text4;
			string text10 = string.Format(string.Concat(new string[]
			{
				"{0,-",
				Conversions.ToString(10),
				"}{1,",
				Conversions.ToString(10),
				"}"
			}), "CHANGE:", Conversion.Val(this.pf.RemoveComma(this.txtChange.Text)).ToString("N2"));
			text4 = text10;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine + text4 + Environment.NewLine;
			bool flag6 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
			if (flag6)
			{
				bool @checked = this.chkAccount.Checked;
				string text11;
				if (@checked)
				{
					text11 = "Account";
				}
				else
				{
					text11 = "COD";
				}
				text4 = this.LINE;
				text4 = text4 + Environment.NewLine + "Payment Method:" + text11;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + Environment.NewLine;
				bool flag7 = !this.chkAccount.Checked;
				if (flag7)
				{
					bool checked2 = this.chkMultiple.Checked;
					if (checked2)
					{
						try
						{
							foreach (object obj in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								bool flag8 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["amtpaid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["amtpaid"])), 0, false);
								if (flag8)
								{
									text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["paymentmethoddesc"], ": "), Strings.Format(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["amtpaid"])), "N2")));
									ptr = ref this.TextToPrint;
									this.TextToPrint = ptr + text4 + Environment.NewLine + Environment.NewLine;
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
						text4 = this.cboPayMeth.Text + ": " + Strings.Format(Conversion.Val(this.txtAmtPaid.Text), "N2");
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text4 + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
					}
				}
			}
			bool checked3 = this.chkAccount.Checked;
			if (checked3)
			{
				decimal num12 = new decimal(this.pf.GetCustomerBillTotal(this.currentCustomerEntryNo, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn));
				text4 = "Account balance: " + MyProject.Forms.Form1.basecurrency + Conversions.ToString(num12);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
			}
			text4 = this.footnote;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text4 + Environment.NewLine + Environment.NewLine;
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x00257078 File Offset: 0x00255278
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
				text = "Customer:" + this.txtcustomer.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool @checked = this.chkAccount.Checked;
				string text7;
				if (@checked)
				{
					text7 = "Account";
				}
				else
				{
					text7 = "COD";
				}
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

		// Token: 0x0600407B RID: 16507 RVA: 0x00257430 File Offset: 0x00255630
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			global::System.Drawing.Font font = new global::System.Drawing.Font("Consolas", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int i;
			bool flag3;
			checked
			{
				int num7 = (int)Math.Round(Math.Round((double)num3 / 1.0));
				iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle((float)num5, (float)num6, (float)num4, (float)num3);
				global::System.Drawing.Rectangle rectangle2 = default(global::System.Drawing.Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				int num8 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				i = 0;
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
				bool flag2 = MyProject.Forms.Form1.RevmaxTest == 1;
				if (flag2)
				{
					MessageBox.Show("QR Code printing stage.");
				}
				string text2 = "https://yourdomain.com/receipt/12345";
				QRCodeGenerator qrcodeGenerator = new QRCodeGenerator();
				QRCodeData qrcodeData = qrcodeGenerator.CreateQrCode(text2, QRCodeGenerator.ECCLevel.Q, false, false, QRCodeGenerator.EciMode.Default, -1);
				QRCode qrcode = new QRCode(qrcodeData);
				Bitmap graphic = qrcode.GetGraphic(5);
				int num10 = 10;
				int num11 = (int)Math.Round((double)(unchecked(num2 + (float)i * font.GetHeight(e.Graphics))));
				e.Graphics.DrawImage(graphic, num10, num11, 100, 100);
				flag3 = text == null;
			}
			if (flag3)
			{
				Graphics graphics = e.Graphics;
				try
				{
					bool flag4 = this.PicQRCode.Image != null;
					if (flag4)
					{
						this.PicQRCode.Image.Dispose();
					}
					bool flag5 = this.QRCodeVariable != null;
					if (flag5)
					{
						bool flag6 = MyProject.Forms.Form1.RevmaxTest == 1;
						if (flag6)
						{
							MessageBox.Show("QRCode Var is not nothing.");
						}
						this.PicQRCode.Image = this.QRCodeVariable;
						graphics.DrawImage(this.PicQRCode.Image, 0, 0, 100, 100);
						float num9 = num2 + (float)i * font.GetHeight(e.Graphics);
						graphics.DrawString("Verify code from the following link etc TEST", font, Brushes.Black, num, num9, new StringFormat());
					}
				}
				catch (Exception ex)
				{
				}
				e.HasMorePages = false;
			}
			else
			{
				e.HasMorePages = true;
			}
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x002576FC File Offset: 0x002558FC
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00257724 File Offset: 0x00255924
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

		// Token: 0x0600407E RID: 16510 RVA: 0x002577A8 File Offset: 0x002559A8
		private void PrintPage(object sender, PrintPageEventArgs ev)
		{
			Metafile metafile = new Metafile(this.m_streams[this.m_currentPageIndex]);
			checked
			{
				global::System.Drawing.Rectangle rectangle = new global::System.Drawing.Rectangle(ev.PageBounds.Left - (int)Math.Round((double)ev.PageSettings.HardMarginX), ev.PageBounds.Top - (int)Math.Round((double)ev.PageSettings.HardMarginY), ev.PageBounds.Width, ev.PageBounds.Height);
				ev.Graphics.FillRectangle(Brushes.White, rectangle);
				ev.Graphics.DrawImage(metafile, rectangle);
				ref int ptr = ref this.m_currentPageIndex;
				this.m_currentPageIndex = ptr + 1;
				ev.HasMorePages = this.m_currentPageIndex < this.m_streams.Count;
			}
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x0025787C File Offset: 0x00255A7C
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

		// Token: 0x06004080 RID: 16512 RVA: 0x002578FC File Offset: 0x00255AFC
		private void PrintInvoice(string revmax_digsig, int isEltradeESDfiscal)
		{
			bool flag = MyProject.Forms.Form1.inv_template_normal == 1;
			if (flag)
			{
				SalesInvoicePortrait salesInvoicePortrait = new SalesInvoicePortrait();
				salesInvoicePortrait.invnum = this.invnum;
				salesInvoicePortrait.revmax_sign = revmax_digsig;
				salesInvoicePortrait.isEltradeESDfiscal = isEltradeESDfiscal;
				salesInvoicePortrait.branch = MyProject.Forms.Form1.branch;
				salesInvoicePortrait.hidevat = 0;
				bool flag2 = MyProject.Forms.Form1.AllowInvDiscount == 1;
				if (flag2)
				{
					salesInvoicePortrait.showinvdisc = 1;
				}
				salesInvoicePortrait.ShowDialog(this);
				salesInvoicePortrait.Dispose();
			}
			else
			{
				bool flag3 = MyProject.Forms.Form1.inv_template_pharma == 1;
				if (flag3)
				{
					SalesInvoicePortraitPharma salesInvoicePortraitPharma = new SalesInvoicePortraitPharma();
					salesInvoicePortraitPharma.invnum = this.invnum;
					salesInvoicePortraitPharma.revmax_sign = revmax_digsig;
					salesInvoicePortraitPharma.isEltradeESDfiscal = isEltradeESDfiscal;
					salesInvoicePortraitPharma.branch = MyProject.Forms.Form1.branch;
					bool flag4 = MyProject.Forms.Form1.AllowInvDiscount == 1;
					if (flag4)
					{
						salesInvoicePortraitPharma.showinvdisc = 1;
					}
					salesInvoicePortraitPharma.ShowDialog(this);
					salesInvoicePortraitPharma.Dispose();
				}
				else
				{
					bool flag5 = MyProject.Forms.Form1.inv_template_incotex == 1;
					if (flag5)
					{
						SalesInvoicePortraitInco salesInvoicePortraitInco = new SalesInvoicePortraitInco();
						salesInvoicePortraitInco.invnum = this.invnum;
						salesInvoicePortraitInco.revmax_sign = revmax_digsig;
						salesInvoicePortraitInco.isEltradeESDfiscal = isEltradeESDfiscal;
						salesInvoicePortraitInco.branch = MyProject.Forms.Form1.branch;
						bool flag6 = MyProject.Forms.Form1.AllowInvDiscount == 1;
						if (flag6)
						{
							salesInvoicePortraitInco.showinvdisc = 1;
						}
						salesInvoicePortraitInco.ShowDialog(this);
						salesInvoicePortraitInco.Dispose();
					}
					else
					{
						bool flag7 = MyProject.Forms.Form1.inv_template_revmax == 1;
						if (flag7)
						{
							SalesInvoiceRevmax salesInvoiceRevmax = new SalesInvoiceRevmax();
							salesInvoiceRevmax.invnum = this.invnum;
							salesInvoiceRevmax.revmax_sign = revmax_digsig;
							salesInvoiceRevmax.isEltradeESDfiscal = isEltradeESDfiscal;
							salesInvoiceRevmax.branch = MyProject.Forms.Form1.branch;
							bool flag8 = MyProject.Forms.Form1.AllowInvDiscount == 1;
							if (flag8)
							{
								salesInvoiceRevmax.showinvdisc = 1;
							}
							salesInvoiceRevmax.ShowDialog(this);
							salesInvoiceRevmax.Dispose();
						}
						else
						{
							bool flag9 = MyProject.Forms.Form1.inv_template_tongaat == 1;
							if (flag9)
							{
								SalesInvoicePortraitTongaat salesInvoicePortraitTongaat = new SalesInvoicePortraitTongaat();
								salesInvoicePortraitTongaat.invnum = this.invnum;
								salesInvoicePortraitTongaat.revmax_sign = revmax_digsig;
								salesInvoicePortraitTongaat.isEltradeESDfiscal = isEltradeESDfiscal;
								salesInvoicePortraitTongaat.branch = MyProject.Forms.Form1.branch;
								bool flag10 = MyProject.Forms.Form1.AllowInvDiscount == 1;
								if (flag10)
								{
									salesInvoicePortraitTongaat.showinvdisc = 1;
								}
								salesInvoicePortraitTongaat.ShowDialog(this);
								salesInvoicePortraitTongaat.Dispose();
							}
							else
							{
								bool flag11 = MyProject.Forms.Form1.inv_template_lea == 1;
								if (flag11)
								{
									SalesInvoicePortraitLea salesInvoicePortraitLea = new SalesInvoicePortraitLea();
									salesInvoicePortraitLea.invnum = this.invnum;
									salesInvoicePortraitLea.revmax_sign = revmax_digsig;
									salesInvoicePortraitLea.isEltradeESDfiscal = isEltradeESDfiscal;
									salesInvoicePortraitLea.branch = MyProject.Forms.Form1.branch;
									bool flag12 = MyProject.Forms.Form1.AllowInvDiscount == 1;
									if (flag12)
									{
										salesInvoicePortraitLea.showinvdisc = 1;
									}
									salesInvoicePortraitLea.ShowDialog(this);
									salesInvoicePortraitLea.Dispose();
								}
								else
								{
									bool flag13 = MyProject.Forms.Form1.inv_template_FDMS == 1;
									if (flag13)
									{
										SalesInvoicePortraitFDMS salesInvoicePortraitFDMS = new SalesInvoicePortraitFDMS();
										salesInvoicePortraitFDMS.invnum = this.invnum;
										salesInvoicePortraitFDMS.revmax_sign = revmax_digsig;
										salesInvoicePortraitFDMS.isEltradeESDfiscal = isEltradeESDfiscal;
										salesInvoicePortraitFDMS.branch = MyProject.Forms.Form1.branch;
										bool flag14 = MyProject.Forms.Form1.AllowInvDiscount == 1;
										if (flag14)
										{
											salesInvoicePortraitFDMS.showinvdisc = 1;
										}
										salesInvoicePortraitFDMS.ShowDialog(this);
										salesInvoicePortraitFDMS.Dispose();
									}
									else
									{
										bool flag15 = MyProject.Forms.Form1.inv_template_GetPro == 1;
										if (flag15)
										{
											SalesInvoicePortraitGetpro salesInvoicePortraitGetpro = new SalesInvoicePortraitGetpro();
											salesInvoicePortraitGetpro.invnum = this.invnum;
											salesInvoicePortraitGetpro.revmax_sign = revmax_digsig;
											salesInvoicePortraitGetpro.isEltradeESDfiscal = isEltradeESDfiscal;
											salesInvoicePortraitGetpro.isfiscal = 1;
											salesInvoicePortraitGetpro.branch = MyProject.Forms.Form1.branch;
											bool flag16 = MyProject.Forms.Form1.AllowInvDiscount == 1;
											if (flag16)
											{
												salesInvoicePortraitGetpro.showinvdisc = 1;
											}
											salesInvoicePortraitGetpro.ShowDialog(this);
											salesInvoicePortraitGetpro.Dispose();
										}
										else
										{
											bool flag17 = MyProject.Forms.Form1.inv_template_Binum == 1;
											if (flag17)
											{
												SalesInvoicePortraitBinum salesInvoicePortraitBinum = new SalesInvoicePortraitBinum();
												salesInvoicePortraitBinum.invnum = this.invnum;
												salesInvoicePortraitBinum.revmax_sign = revmax_digsig;
												salesInvoicePortraitBinum.isEltradeESDfiscal = isEltradeESDfiscal;
												salesInvoicePortraitBinum.isfiscal = 1;
												salesInvoicePortraitBinum.branch = MyProject.Forms.Form1.branch;
												bool flag18 = MyProject.Forms.Form1.AllowInvDiscount == 1;
												if (flag18)
												{
													salesInvoicePortraitBinum.showinvdisc = 1;
												}
												salesInvoicePortraitBinum.ShowDialog(this);
												salesInvoicePortraitBinum.Dispose();
											}
											else
											{
												bool flag19 = MyProject.Forms.Form1.inv_template_Farhan == 1;
												if (flag19)
												{
													SalesInvoicePortraitFarhan salesInvoicePortraitFarhan = new SalesInvoicePortraitFarhan();
													salesInvoicePortraitFarhan.invnum = this.invnum;
													salesInvoicePortraitFarhan.revmax_sign = revmax_digsig;
													salesInvoicePortraitFarhan.isEltradeESDfiscal = isEltradeESDfiscal;
													salesInvoicePortraitFarhan.isfiscal = 1;
													salesInvoicePortraitFarhan.branch = MyProject.Forms.Form1.branch;
													bool flag20 = MyProject.Forms.Form1.AllowInvDiscount == 1;
													if (flag20)
													{
														salesInvoicePortraitFarhan.showinvdisc = 1;
													}
													salesInvoicePortraitFarhan.hidetax = Conversions.ToInteger(Interaction.IIf(this.chkHideTax.Checked, 1, 0));
													salesInvoicePortraitFarhan.ShowDialog(this);
													salesInvoicePortraitFarhan.Dispose();
												}
												else
												{
													SalesInvoicePortrait salesInvoicePortrait2 = new SalesInvoicePortrait();
													salesInvoicePortrait2.invnum = this.invnum;
													salesInvoicePortrait2.revmax_sign = revmax_digsig;
													salesInvoicePortrait2.isEltradeESDfiscal = isEltradeESDfiscal;
													salesInvoicePortrait2.branch = MyProject.Forms.Form1.branch;
													salesInvoicePortrait2.hidevat = 0;
													bool flag21 = MyProject.Forms.Form1.AllowInvDiscount == 1;
													if (flag21)
													{
														salesInvoicePortrait2.showinvdisc = 1;
													}
													salesInvoicePortrait2.ShowDialog(this);
													salesInvoicePortrait2.Dispose();
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x00257F28 File Offset: 0x00256128
		private DataTable LoadCompanyDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetCompanyDetails";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x00257F7C File Offset: 0x0025617C
		private void GetCompanyDetails()
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
					this.coname_og = dataRow["CompanyName"].ToString();
					this.coadd_og = dataRow["Address"].ToString();
					this.coadd2_og = dataRow["Address2"].ToString();
					this.cotel_og = dataRow["Tel"].ToString();
					this.cotel2_og = dataRow["Tel2"].ToString();
					this.cotel3_og = dataRow["Tel3"].ToString();
					this.coemail_og = dataRow["Email"].ToString();
					this.cobpnum_og = dataRow["BPNumber"].ToString();
					this.footnote_og = dataRow["Footnote"].ToString();
					this.coVATNum_og = dataRow["VATNumber"].ToString();
					this.bpnum_name_og = Conversions.ToString(dataRow["BPNumber_name"]);
					this.vatnum_name_og = Conversions.ToString(dataRow["VATNumber_name"]);
					this.lblBPNumber.Text = this.bpnum_name_og;
					this.lblVATNumber.Text = this.vatnum_name_og;
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0025819C File Offset: 0x0025639C
		private DataTable LoadInvoiceDetails(int invoicenumber)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesByInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenumber);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0025822C File Offset: 0x0025642C
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchCustomer(Conversions.ToString(this.cboCustomers.SelectedValue));
			}
			catch (InvalidCastException ex)
			{
			}
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00258274 File Offset: 0x00256474
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
					this.txtInvDetails1.Text = Conversions.ToString(dataRow["InvoiceDetails1"]);
					this.txtInvDetails2.Text = Conversions.ToString(dataRow["InvoiceDetails2"]);
					this.txtbpnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
					this.txtvatnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])));
					this.og_customername = this.txtcustomer.Text;
					this.og_address = this.txtAddress.Text;
					this.og_contactname = this.txtContactName.Text;
					this.og_mobile = this.txtMobile.Text;
					this.og_email = this.txtEmail.Text;
					this.og_tel = this.txtTel.Text;
					this.og_invdetail1 = this.txtInvDetails1.Text;
					this.og_invdetail2 = this.txtInvDetails2.Text;
					this.og_vatnumber = this.txtvatnumber.Text;
					this.og_bpnumber = this.txtbpnumber.Text;
					this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					this.currentCustomerLimit = Conversions.ToDecimal(Operators.DivideObject(dataRow["AccountLimit"], this.mono_rate));
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

		// Token: 0x06004086 RID: 16518 RVA: 0x002585DC File Offset: 0x002567DC
		private void FetchCustomerByEntryno(int entryno)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCustomerDetailsByEntryno";
				sqlCommand.Parameters.AddWithValue("entryno", entryno);
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
					this.txtInvDetails1.Text = Conversions.ToString(dataRow["InvoiceDetails1"]);
					this.txtInvDetails2.Text = Conversions.ToString(dataRow["InvoiceDetails2"]);
					this.txtbpnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
					this.txtvatnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])));
					this.og_customername = this.txtcustomer.Text;
					this.og_address = this.txtAddress.Text;
					this.og_contactname = this.txtContactName.Text;
					this.og_mobile = this.txtMobile.Text;
					this.og_email = this.txtEmail.Text;
					this.og_tel = this.txtTel.Text;
					this.og_invdetail1 = this.txtInvDetails1.Text;
					this.og_invdetail2 = this.txtInvDetails2.Text;
					this.og_vatnumber = this.txtvatnumber.Text;
					this.og_bpnumber = this.txtbpnumber.Text;
					this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					this.currentCustomerLimit = Conversions.ToDecimal(Operators.DivideObject(dataRow["AccountLimit"], this.mono_rate));
					this.currCustomerGroup = Conversions.ToString(dataRow["CategoryName"]);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x0025893C File Offset: 0x00256B3C
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

		// Token: 0x06004088 RID: 16520 RVA: 0x00258994 File Offset: 0x00256B94
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

		// Token: 0x06004089 RID: 16521 RVA: 0x00258A98 File Offset: 0x00256C98
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
			sqlCommand.Parameters.AddWithValue("invoicedetails1", "");
			sqlCommand.Parameters.AddWithValue("invoicedetails2", "");
			sqlCommand.Parameters.AddWithValue("tel", "");
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x00258C18 File Offset: 0x00256E18
		private void UpdateCustomer()
		{
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
			sqlCommand.Parameters.AddWithValue("invoicedetails1", this.txtInvDetails1.Text);
			sqlCommand.Parameters.AddWithValue("invoicedetails2", this.txtInvDetails2.Text);
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
			bool flag = this.currentCustomerEntryNo == 0;
			if (flag)
			{
				this.currentCustomerEntryNo = this.GetCustomerEntryNo(this.txtcustomer.Text);
			}
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00258E24 File Offset: 0x00257024
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

		// Token: 0x0600408C RID: 16524 RVA: 0x00258F04 File Offset: 0x00257104
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

		// Token: 0x0600408D RID: 16525 RVA: 0x00259014 File Offset: 0x00257214
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

		// Token: 0x0600408E RID: 16526 RVA: 0x0025909C File Offset: 0x0025729C
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

		// Token: 0x0600408F RID: 16527 RVA: 0x00259194 File Offset: 0x00257394
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

		// Token: 0x06004090 RID: 16528 RVA: 0x002592D0 File Offset: 0x002574D0
		private object searchDat(DataTable dt, string column, string value)
		{
			Sales2mono2._Closure$__952-0 CS$<>8__locals1 = new Sales2mono2._Closure$__952-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((Sales2mono2._Closure$__.$I952-0 == null) ? (Sales2mono2._Closure$__.$I952-0 = (object row1) => (DataRow)row1) : Sales2mono2._Closure$__.$I952-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06004091 RID: 16529 RVA: 0x002593AC File Offset: 0x002575AC
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

		// Token: 0x06004092 RID: 16530 RVA: 0x0025946C File Offset: 0x0025766C
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

		// Token: 0x06004093 RID: 16531 RVA: 0x0025967C File Offset: 0x0025787C
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

		// Token: 0x06004094 RID: 16532 RVA: 0x002596DC File Offset: 0x002578DC
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

		// Token: 0x06004095 RID: 16533 RVA: 0x002597A0 File Offset: 0x002579A0
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.EnterProduct();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x002597FC File Offset: 0x002579FC
		private void SearchBarCode(int prodtID)
		{
			this.txtPriceChange.Text = "";
			this.WholesalePriceByQty = 0;
			this.currCaseQty = 0;
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
					this.lblBinLoc.Text = Conversions.ToString(Operators.ConcatenateObject("Bin Loc: ", Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BinLocation"])), "", RuntimeHelpers.GetObjectValue(dataRow["BinLocation"]))));
					this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
					this.current_taxexempt = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow["taxexempt"])));
					this.currentIsCalcLxW = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isCalculatedLxW"])), false, RuntimeHelpers.GetObjectValue(dataRow["isCalculatedLxW"])));
					this.currParentCaseID = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["caseparentproductid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["caseparentproductid"])));
					this.CurrentRecordSerial = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])), false, RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])));
					try
					{
						bool flag3 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Iseditable"]));
						if (flag3)
						{
							this.currentIsEditable = false;
						}
						else
						{
							bool flag4 = Operators.ConditionalCompareObjectEqual(dataRow["Iseditable"], 1, false);
							if (flag4)
							{
								this.currentIsEditable = true;
							}
							else
							{
								this.currentIsEditable = false;
							}
						}
					}
					catch (Exception ex)
					{
					}
					bool flag5 = (MyProject.Forms.Form1.autoBreakCase == 1) & (this.currParentCaseID != 0);
					if (flag5)
					{
						DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, this.currParentCaseID, this._cnn);
						bool flag6 = productDetails == null;
						if (flag6)
						{
							this.currCaseQty = 0;
							MessageBox.Show("Parent Product NOT FOUND.");
						}
						else
						{
							this.currCaseQty = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])), 0, RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])));
						}
					}
					int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
					this.isunedingstock = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
					try
					{
						bool flag7 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ispricevariable"])), 0, RuntimeHelpers.GetObjectValue(dataRow["ispricevariable"])), 1, false);
						if (flag7)
						{
							this.txtPrice.Enabled = true;
							this.txtPrice.ReadOnly = false;
						}
						else
						{
							this.EffectTillpointPrice();
						}
					}
					catch (Exception ex2)
					{
					}
					bool flag8 = num2 == 0;
					decimal num4;
					decimal num5;
					if (flag8)
					{
						DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag9 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
						if (flag9)
						{
							this.txtCoupons.Text = "1";
							this.txtOLDprice.Text = Conversions.ToString(productPayMethodDiscount["oldprice"]);
							this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount["paymethod"]);
							this.discAmount = Conversions.ToDecimal(productPayMethodDiscount["disc"]);
							this.PaymentMethodDiscountEffected = 1;
						}
						else
						{
							this.txtCoupons.Text = "";
							this.discAmount = 0m;
						}
						bool flag10 = MyProject.Forms.Form1.CalcBackwards == 1;
						if (flag10)
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
						this.PriceBeforeTax = num4;
						num5 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
						this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
						this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["specialprice"]))));
					}
					else
					{
						DataRow productPayMethodDiscount2 = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag11 = Operators.ConditionalCompareObjectGreater(productPayMethodDiscount2["disc"], 0, false);
						if (flag11)
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
						this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"]))));
						this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
					}
					decimal num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					bool flag12 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
					if (flag12)
					{
						bool flag13 = MyProject.Forms.Form1.CalcBackwards == 1;
						decimal num7;
						if (flag13)
						{
							this.priceb4tax = Conversions.ToDecimal(Operators.DivideObject(num4, Operators.AddObject(1, dataRow["TaxRate"])));
							num7 = Math.Round(num4, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						}
						else
						{
							this.priceb4tax = num4;
							num7 = Math.Round(decimal.Add(num4, Math.Round(decimal.Multiply(decimal.Divide(num6, 100m), num4), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						}
						this.PriceBeforeTax = num4;
						num7 = num7;
						this.priceb4taxWholesale = num5;
						this.priceb4taxWholesale = this.priceb4taxWholesale;
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = decimal.Add(num5, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num5));
						this.totpriceWholesale = this.totpriceWholesale;
						bool flag14 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag14)
						{
							this.txtPrice.Text = Math.Round(this.totpriceWholesale, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
						}
						else
						{
							this.txtPrice.Text = Math.Round(num7, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
						}
					}
					else
					{
						num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						decimal num8 = decimal.Add(1m, Math.Round(decimal.Divide(num6, 100m), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
						this.priceb4tax = Math.Round(decimal.Divide(num4, num8), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						this.currenttaxrate = num6;
						decimal num9 = Math.Round(num4, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						this.priceb4taxWholesale = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num6, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = num5;
						bool flag15 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag15)
						{
							this.txtPrice.Text = this.totpriceWholesale.ToString();
						}
						else
						{
							this.txtPrice.Text = num9.ToString();
						}
					}
					this.lblcost.Text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
					{
						Operators.MultiplyObject(dataRow["Cost"], this.mono_rate),
						2,
						MidpointRounding.AwayFromZero
					}, null, null, null));
					this.lbltax.Text = Math.Round(num6, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
					this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.currenttaxrate = Conversions.ToDecimal(dataRow["taxrate"]);
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]), RuntimeHelpers.GetObjectValue(dataRow["HSCode"])));
					this.currentIsWeighed = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isweighed"])), false, RuntimeHelpers.GetObjectValue(dataRow["isweighed"])));
					bool flag16 = this.currentIsWeighed;
					if (flag16)
					{
						this.txtQty.ReadOnly = true;
					}
					else
					{
						this.txtQty.ReadOnly = false;
					}
					this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
					this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
					bool flag17 = this.currentExpires;
					if (flag17)
					{
						this.txtQty.Visible = false;
						this.Label4.Visible = false;
						this.Button1.Text = "SELECT";
					}
					else
					{
						bool flag18 = this.currentIsCalcLxW;
						if (flag18)
						{
							this.Button1.Text = "Select LxW";
							this.txtQty.Enabled = false;
						}
						else
						{
							this.txtQty.Visible = true;
							this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
							this.Label4.Visible = true;
							this.Button1.Text = "Enter";
							this.txtQty.Enabled = true;
						}
					}
					this.currentUOM = dataRow["UOM"].ToString();
					this.currentIsDeposit = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])), 0, RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])));
					this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
				}
				else
				{
					this.txtSearchProductCode.Text = "";
				}
			}
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x0025A960 File Offset: 0x00258B60
		private void SearchProductCode(string prodtcode, int use_price_from_scale = 0, decimal price_from_scale = 0m, decimal qty_from_scale = 0m)
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
						this.txtDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"]))), ")"));
						this.lblBinLoc.Text = Conversions.ToString(Operators.ConcatenateObject("Bin Loc: ", Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BinLocation"])), "", RuntimeHelpers.GetObjectValue(dataRow["BinLocation"]))));
						this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
						this.current_taxexempt = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow["taxexempt"])));
						this.currentIsCalcLxW = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isCalculatedLxW"])), false, RuntimeHelpers.GetObjectValue(dataRow["isCalculatedLxW"])));
						this.currParentCaseID = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["caseparentproductid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["caseparentproductid"])));
						this.CurrentRecordSerial = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])), false, RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])));
						try
						{
							bool flag4 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Iseditable"]));
							if (flag4)
							{
								this.currentIsEditable = false;
							}
							else
							{
								bool flag5 = Operators.ConditionalCompareObjectEqual(dataRow["Iseditable"], 1, false);
								if (flag5)
								{
									this.currentIsEditable = true;
								}
								else
								{
									this.currentIsEditable = false;
								}
							}
						}
						catch (Exception ex)
						{
						}
						bool flag6 = (MyProject.Forms.Form1.autoBreakCase == 1) & (this.currParentCaseID != 0);
						if (flag6)
						{
							DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, this.currParentCaseID, this._cnn);
							this.currCaseQty = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])), 0, RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])));
						}
						int num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
						this.isunedingstock = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
						try
						{
							bool flag7 = Operators.ConditionalCompareObjectEqual(dataRow["ispricevariable"], 1, false);
							if (flag7)
							{
								this.txtPrice.Enabled = true;
								this.txtPrice.ReadOnly = false;
							}
							else
							{
								this.EffectTillpointPrice();
							}
						}
						catch (Exception ex2)
						{
						}
						DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataRow["ProductID"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag8 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
						if (flag8)
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
						bool flag9 = num3 == 0;
						decimal num5;
						decimal num6;
						if (flag9)
						{
							bool flag10 = MyProject.Forms.Form1.CalcBackwards == 1;
							if (flag10)
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
						this.PriceBeforeTax = num5;
						decimal num7 = 0m;
						bool flag11 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
						if (flag11)
						{
							num7 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							bool flag12 = MyProject.Forms.Form1.CalcBackwards == 1;
							decimal num8;
							if (flag12)
							{
								this.priceb4tax = Conversions.ToDecimal(Operators.DivideObject(num5, Operators.AddObject(1, dataRow["TaxRate"])));
								num8 = Math.Round(num5, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
							}
							else
							{
								this.priceb4tax = num5;
								num8 = decimal.Add(num5, Math.Round(decimal.Multiply(Math.Round(decimal.Divide(num7, 100m), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero), num5), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
							}
							this.priceb4tax = this.priceb4tax;
							num8 = num8;
							this.priceb4taxWholesale = num6;
							this.priceb4taxWholesale = this.priceb4taxWholesale;
							this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							this.totpriceWholesale = decimal.Add(num6, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num6));
							this.totpriceWholesale = this.totpriceWholesale;
							bool flag13 = MyProject.Forms.Form1.IsWholesaleShop == 1;
							if (flag13)
							{
								bool flag14 = use_price_from_scale == 1;
								if (flag14)
								{
									this.txtPrice.Text = Conversions.ToString(price_from_scale);
								}
								else
								{
									this.txtPrice.Text = Math.Round(this.totpriceWholesale, 8, MidpointRounding.AwayFromZero).ToString();
								}
							}
							else
							{
								bool flag15 = use_price_from_scale == 1;
								if (flag15)
								{
									this.txtPrice.Text = Conversions.ToString(price_from_scale);
								}
								else
								{
									this.txtPrice.Text = Math.Round(num8, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
								}
							}
						}
						else
						{
							num7 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							decimal num9 = decimal.Add(1m, Math.Round(decimal.Divide(num7, 100m), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
							this.priceb4tax = Math.Round(decimal.Divide(num5, num9), 5, MidpointRounding.AwayFromZero);
							this.currenttaxrate = num7;
							decimal num10 = Math.Round(num5, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
							num10 = num10;
							this.priceb4taxWholesale = Math.Round(decimal.Divide(num6, decimal.Add(1m, decimal.Divide(num7, 100m))), 5, MidpointRounding.AwayFromZero);
							this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							this.totpriceWholesale = num6;
							bool flag16 = MyProject.Forms.Form1.IsWholesaleShop == 1;
							if (flag16)
							{
								bool flag17 = use_price_from_scale == 1;
								if (flag17)
								{
									this.txtPrice.Text = Conversions.ToString(price_from_scale);
								}
								else
								{
									this.txtPrice.Text = this.totpriceWholesale.ToString();
								}
							}
							else
							{
								bool flag18 = use_price_from_scale == 1;
								if (flag18)
								{
									this.txtPrice.Text = Conversions.ToString(price_from_scale);
								}
								else
								{
									this.txtPrice.Text = num10.ToString();
								}
							}
						}
						this.lblcost.Text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.MultiplyObject(dataRow["Cost"], this.mono_rate),
							2,
							MidpointRounding.AwayFromZero
						}, null, null, null));
						this.lbltax.Text = Math.Round(num7, 5, MidpointRounding.AwayFromZero).ToString();
						this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
						this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
						this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]), RuntimeHelpers.GetObjectValue(dataRow["HSCode"])));
						this.currentIsWeighed = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isweighed"])), false, RuntimeHelpers.GetObjectValue(dataRow["isweighed"])));
						bool flag19 = this.currentIsWeighed;
						if (flag19)
						{
							this.txtQty.ReadOnly = true;
						}
						else
						{
							this.txtQty.ReadOnly = false;
						}
						this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
						this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
						bool flag20 = this.currentExpires;
						if (flag20)
						{
							this.txtQty.Visible = false;
							this.Label4.Visible = false;
							this.Button1.Text = "SELECT";
						}
						else
						{
							bool flag21 = this.currentIsCalcLxW;
							if (flag21)
							{
								this.Button1.Text = "Select LxW";
								this.txtQty.Enabled = false;
							}
							else
							{
								this.txtQty.Visible = true;
								this.Label4.Visible = true;
								this.Button1.Text = "Enter";
								this.txtQty.Enabled = true;
							}
						}
						this.currentUOM = dataRow["UOM"].ToString();
						this.currentIsDeposit = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])), 0, RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])));
						this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
						bool flag22 = Operators.CompareString(this.txtBarCode.Text, "1", false) == 0;
						if (flag22)
						{
							this.txtPrice.Focus();
						}
						else
						{
							bool flag23 = MyProject.Forms.Form1.DontAutoAppendAfterBarcodeSearch == 1;
							if (flag23)
							{
								bool flag24 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
								if (flag24)
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
							else
							{
								this.EnterItem();
							}
						}
					}
				}
				else
				{
					this.txtSearchProductCode.Text = "";
					bool flag25 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag25)
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

		// Token: 0x06004098 RID: 16536 RVA: 0x0025BB5C File Offset: 0x00259D5C
		private bool ProcessCoupon()
		{
			bool flag = Operators.CompareString(this.txtCoupons.Text, "1", false) != 0;
			bool flag5;
			if (flag)
			{
				this.lblCouponInfo.Text = "...";
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SelectCouponDetails";
				sqlCommand.Parameters.AddWithValue("couponnum", Conversion.Val(this.txtCoupons.Text));
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					int num2 = Conversions.ToInteger(dataRow["QtyRequired"]);
					int num3 = Conversions.ToInteger(dataRow["ProductID"]);
					bool flag3 = Conversions.ToBoolean(dataRow["Used"]);
					double num4 = Conversions.ToDouble(dataRow["DiscountPercentage"]);
					bool flag4 = flag3;
					if (flag4)
					{
						this.lblCouponInfo.Text = "Coupon has already been used.";
						flag5 = false;
					}
					else
					{
						bool flag6 = this.CurrentID != num3;
						if (flag6)
						{
							this.lblCouponInfo.Text = "Coupon is not valid for this product.";
							flag5 = false;
						}
						else
						{
							bool flag7 = (double)num2 != Conversion.Val(this.txtQty.Text);
							if (flag7)
							{
								this.lblCouponInfo.Text = "Coupon valid for " + num2.ToString() + " items";
								flag5 = false;
							}
							else
							{
								bool flag8 = this.NotSelected(checked((int)Math.Round(Conversion.Val(this.txtCoupons.Text))));
								if (flag8)
								{
									double num5 = Conversion.Val(this.txtPrice.Text);
									this.txtOLDprice.Text = num5.ToString();
									double num6 = Math.Round(num5 - num5 * (num4 / 100.0), 2, MidpointRounding.AwayFromZero);
									this.txtPrice.Text = num6.ToString();
									MessageBox.Show("Discount Success!.", "Discount");
									flag5 = true;
								}
								else
								{
									this.lblCouponInfo.Text = "Please use a different coupon number. The one entered has already been selected for this sale.";
									flag5 = false;
								}
							}
						}
					}
				}
				else
				{
					flag5 = false;
				}
			}
			else
			{
				flag5 = true;
			}
			return flag5;
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0025BDAC File Offset: 0x00259FAC
		private bool NotSelected(int couponnum)
		{
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["CouponNumber"].Value, couponnum, false);
						if (flag)
						{
							num++;
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
				bool flag2 = num > 0;
				return !flag2;
			}
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0025BE50 File Offset: 0x0025A050
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

		// Token: 0x0600409B RID: 16539 RVA: 0x0025BF00 File Offset: 0x0025A100
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.CheckShiftStatus();
			}
			catch (SqlException ex)
			{
				bool flag = ex.Number == 2627;
				if (flag)
				{
					MessageBox.Show("Shift has already been opened and closed for the day. Refer to the Supervisor to open your shift");
				}
				else
				{
					MessageBox.Show("Error. Other SQLException Detail: " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Othe Exception has occurred. Detail: " + ex2.Message);
			}
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x0025BFA0 File Offset: 0x0025A1A0
		private void btnShift_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure your shift has ended and you want to exit?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.CloseShift(Conversions.ToInteger(this.lblShift.Text), MyProject.Forms.Form1.coid, DateAndTime.TimeOfDay.ToString("HHmm"), Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
					bool flag2 = MyProject.Forms.Form1.isZimraVirtFiscal == 1;
					if (flag2)
					{
					}
					bool flag3 = MyProject.Forms.Form1.IsBlindCashUp == 0;
					if (flag3)
					{
						ShiftReportForm shiftReportForm = new ShiftReportForm();
						shiftReportForm.shift_entryno = Conversions.ToInteger(this.lblShift.Text);
						shiftReportForm.ShowDialog(this);
						shiftReportForm.Dispose();
					}
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing shift. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0025C0C0 File Offset: 0x0025A2C0
		private void CloseShift(int entryno, int coid, string endtime, int shiftenddate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CloseShift2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("endtime", endtime);
			sqlCommand.Parameters.AddWithValue("shiftenddate", shiftenddate);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("theuser", MyProject.Forms.Form1.username);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0025C1C4 File Offset: 0x0025A3C4
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag17;
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
								bool flag5 = msg.WParam.ToInt32() == 113;
								if (flag5)
								{
									this.cboPayMeth.Focus();
								}
								else
								{
									bool flag6 = msg.WParam.ToInt32() == 114;
									if (flag6)
									{
										this.cboCustomers.Focus();
									}
									else
									{
										bool flag7 = msg.WParam.ToInt32() == 115;
										if (flag7)
										{
											this.Button6.Focus();
										}
										else
										{
											bool flag8 = msg.WParam.ToInt32() == 121;
											if (flag8)
											{
												bool @checked = this.chkMultiple.Checked;
												if (@checked)
												{
													this.chkMultiple.Checked = false;
												}
												else
												{
													this.chkMultiple.Checked = true;
												}
											}
											else
											{
												bool flag9 = msg.WParam.ToInt32() == 122;
												if (flag9)
												{
													bool flag10 = MyProject.Forms.Form1.FiscalRevmax == 1;
													if (!flag10)
													{
														this.ProcessMultipay();
													}
												}
												else
												{
													bool flag11 = msg.WParam.ToInt32() == 116;
													if (flag11)
													{
														this.ProcessSale();
													}
													else
													{
														bool flag12 = msg.WParam.ToInt32() == 123;
														if (flag12)
														{
															bool flag13 = MyProject.Forms.Form1.BarFastExchange == 1;
															if (flag13)
															{
																ChangeProductSold changeProductSold = new ChangeProductSold();
																changeProductSold.shift = this.lblShift.Text;
																changeProductSold.ShowDialog();
																changeProductSold.Dispose();
																this.ClearForm();
															}
														}
														else
														{
															bool flag14 = msg.WParam.ToInt32() == 117;
															if (flag14)
															{
																this.radSitIn.Checked = true;
															}
															else
															{
																bool flag15 = msg.WParam.ToInt32() == 118;
																if (flag15)
																{
																	this.radTakeAway.Checked = true;
																}
																else
																{
																	bool flag16 = msg.WParam.ToInt32() == 119;
																	if (flag16)
																	{
																		this.DataGridView1.Focus();
																		this.DataGridView1.CurrentCell = this.DataGridView1.Rows[0].Cells[4];
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				flag17 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag17;
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0025C510 File Offset: 0x0025A710
		private void dgvpay_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.ProcessSale();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore" + ex.Message);
			}
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x0025C578 File Offset: 0x0025A778
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

		// Token: 0x060040A2 RID: 16546 RVA: 0x0025C600 File Offset: 0x0025A800
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
						bool flag3 = !this.txtQty.Text.Contains(".");
						if (flag3)
						{
							bool flag4 = this.txtQty.Text.Length > 4;
							if (flag4)
							{
								DialogResult dialogResult = (DialogResult)Interaction.MsgBox("CHECK QUANTITY- IS IT CORRECT? QTY is: " + this.txtQty.Text, MsgBoxStyle.YesNoCancel, null);
								bool flag5 = (dialogResult == DialogResult.No) | (dialogResult == DialogResult.Cancel);
								if (flag5)
								{
									this.txtQty.Text = Conversions.ToString(0);
								}
							}
						}
						this.EnterItem();
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

		// Token: 0x060040A3 RID: 16547 RVA: 0x0025C6F8 File Offset: 0x0025A8F8
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				try
				{
					this.lblerror.Text = "";
					this.txtStockAvail.Text = Conversions.ToString(0);
					this.txtPrice.Text = Conversions.ToString(0);
					this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
					this.txtDesc.Text = "No product matches your search.";
					bool flag2 = MyProject.Forms.Form1.deposits_inuse == 1;
					if (flag2)
					{
						bool flag3 = this.txtBarCode.Text.Length > 2;
						if (flag3)
						{
							string text = this.txtBarCode.Text.Substring(0, 3);
							bool flag4 = Operators.CompareString(text, "999", false) == 0;
							if (flag4)
							{
								PayDeposit payDeposit = new PayDeposit();
								payDeposit.depBarcode = this.txtBarCode.Text;
								payDeposit.coid = MyProject.Forms.Form1.coid;
								payDeposit.branch = MyProject.Forms.Form1.branch;
								payDeposit.ShowDialog(this);
								payDeposit.Dispose();
								this.txtBarCode.Select();
								return;
							}
						}
					}
					bool flag5 = MyProject.Forms.Form1.usingBarcodePrintingScale == 1;
					if (flag5)
					{
						DataRow butcheryProductDetails = this.GetButcheryProductDetails(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
						bool flag6 = Operators.ConditionalCompareObjectEqual(butcheryProductDetails[2], 1, false);
						if (flag6)
						{
							this.txtQty.Text = butcheryProductDetails["productqty"].ToString();
							this.SearchProductCode(Conversions.ToString(butcheryProductDetails["productcode"]), 0, 0m, 0m);
						}
						else
						{
							this.txtDesc.Text = this.txtDesc.Text + " BARCODE PRODUCT NOT FOUND";
							this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)), 0, 0m, 0m);
						}
					}
					else
					{
						this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)), 0, 0m, 0m);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bar code error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x0025C9F8 File Offset: 0x0025ABF8
		private DataTable createDTFromGrid(DataGridView dgv)
		{
			DataTable dataTable = new DataTable();
			try
			{
				foreach (object obj in dgv.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					dataTable.Columns.Add(dataGridViewColumn.Name);
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
			try
			{
				foreach (object obj2 in ((IEnumerable)dgv.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
					DataRow dataRow = dataTable.NewRow();
					try
					{
						foreach (object obj3 in dataGridViewRow.Cells)
						{
							DataGridViewCell dataGridViewCell = (DataGridViewCell)obj3;
							dataRow[dataGridViewCell.ColumnIndex] = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value);
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					dataTable.Rows.Add(dataRow);
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x0025CB4C File Offset: 0x0025AD4C
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void OpenCashDrawer()
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(1, AppDomain.CurrentDomain.BaseDirectory + "open.txt", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
			FileSystem.PrintLine(1, new object[] { "\u001bp\0\u0019" + Conversions.ToString(Strings.Chr(250)) });
			FileSystem.FileClose(new int[] { 1 });
			Interaction.Shell("print /d:com1 open.txt", AppWinStyle.Hide, false, -1);
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x0025CBC8 File Offset: 0x0025ADC8
		private void cboCustomers_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x0025CBFC File Offset: 0x0025ADFC
		private DataTable searchDat(string stext)
		{
			DataTable dataTable = new DataTable();
			return this.datCustomers.Select("CustomerName LIKE '%" + stext + "%'").CopyToDataTable<DataRow>();
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboCustomers_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0025CC38 File Offset: 0x0025AE38
		private void AutoCompleteCombo_Leave(ComboBox cbo)
		{
			int num = cbo.FindStringExact(cbo.Text);
			cbo.SelectedIndex = num;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0025CC5C File Offset: 0x0025AE5C
		private void Button4_Click_2(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.cboCustomers.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				int searchCustomerEntryno = MyProject.Forms.Form1.SearchCustomerEntryno;
				this.FetchCustomerByEntryno(searchCustomerEntryno);
				this.txtsearch.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x0025CCF4 File Offset: 0x0025AEF4
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

		// Token: 0x060040AD RID: 16557 RVA: 0x0025CD94 File Offset: 0x0025AF94
		private void chkAccount_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkAccount.Checked;
				if (@checked)
				{
					this.Label7.Visible = false;
					this.lblTerms.Visible = true;
					this.cboTerms.Visible = true;
					this.lblchange.Visible = false;
					this.txtChange.Visible = false;
					this.Label10.Visible = false;
					this.txtAmtPaid.Text = "0";
					this.txtAmtPaid.Visible = false;
					this.txtcomments.Visible = true;
					this.lblComment.Visible = true;
				}
				else
				{
					this.Label7.Visible = true;
					this.lblTerms.Visible = false;
					this.cboTerms.Visible = false;
					this.lblchange.Visible = true;
					this.txtChange.Visible = true;
					this.Label10.Visible = true;
					this.txtAmtPaid.Text = "";
					this.txtAmtPaid.Visible = true;
					this.txtcomments.Visible = false;
					this.lblComment.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0025CEF8 File Offset: 0x0025B0F8
		private double GetCustomerBillTotal(string customername, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingTotalForCustomer";
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
				bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AccBalance"]));
				if (flag2)
				{
					num2 = 0.0;
				}
				else
				{
					num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["AccBalance"]));
				}
			}
			else
			{
				num2 = 0.0;
			}
			return num2;
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0025CFEC File Offset: 0x0025B1EC
		private void InsertNewBillLog(string customername, int invoicenumber, double amount, int shiftdate, int trandate, string trantime, string teller, int coid, string branch, int terms, int DueDate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingInsertAccSale";
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("invoicenumber", invoicenumber);
			sqlCommand.Parameters.AddWithValue("amount", amount);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			sqlCommand.Parameters.AddWithValue("trandate", trandate);
			sqlCommand.Parameters.AddWithValue("trantime", trantime);
			sqlCommand.Parameters.AddWithValue("teller", teller);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("terms", terms);
			sqlCommand.Parameters.AddWithValue("DueDate", DueDate);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0025D148 File Offset: 0x0025B348
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				BillingEnterPaymentfrm billingEnterPaymentfrm = new BillingEnterPaymentfrm();
				billingEnterPaymentfrm.TheCustomerName = this.txtcustomer.Text;
				billingEnterPaymentfrm.TheShiftDate = MyProject.Forms.Form1.shiftdate;
				billingEnterPaymentfrm.ShowDialog(this);
				billingEnterPaymentfrm.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening Pay Bill form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x0025D1CC File Offset: 0x0025B3CC
		private void txtPriceChange_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x0025D234 File Offset: 0x0025B434
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtPrice.Text, "", false) != 0;
				if (flag)
				{
					SupervisorApproval supervisorApproval = new SupervisorApproval();
					supervisorApproval.prod_desc = "Product: " + this.txtDesc.Text;
					supervisorApproval.prod_cost = Conversions.ToDecimal(this.lblcost.Text);
					bool flag2 = MyProject.Forms.Form1.ShowCostPrice == 1;
					if (flag2)
					{
						supervisorApproval.prod_selling = Conversions.ToDecimal(this.txtPrice.Text);
					}
					supervisorApproval.ShowDialog();
					bool flag3 = (decimal.Compare(MyProject.Forms.Form1.DiscountApprovedPerc, 0m) != 0) | (decimal.Compare(MyProject.Forms.Form1.DiscountApprovedAmt, 0m) != 0);
					if (flag3)
					{
						bool discountApprovedIsPerc = MyProject.Forms.Form1.discountApprovedIsPerc;
						if (discountApprovedIsPerc)
						{
							bool discountApprovedIncrease = MyProject.Forms.Form1.discountApprovedIncrease;
							decimal num;
							if (discountApprovedIncrease)
							{
								num = new decimal(Convert.ToDouble(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m)) * Conversion.Val(this.txtPrice.Text));
							}
							else
							{
								num = new decimal(Convert.ToDouble(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m)) * Conversion.Val(this.txtPrice.Text) * -1.0);
							}
							this.txtPriceChange.Text = num.ToString();
							ref string ptr = ref this.discDESC;
							this.discDESC = ptr + "Product Discount Approved by " + MyProject.Forms.Form1.Approvedby;
							MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
							this.Button1.Focus();
						}
						else
						{
							bool discountApprovedIncrease2 = MyProject.Forms.Form1.discountApprovedIncrease;
							decimal num2;
							if (discountApprovedIncrease2)
							{
								num2 = MyProject.Forms.Form1.DiscountApprovedAmt;
							}
							else
							{
								num2 = decimal.Multiply(MyProject.Forms.Form1.DiscountApprovedAmt, -1m);
							}
							this.txtPriceChange.Text = num2.ToString();
							ref string ptr = ref this.discDESC;
							this.discDESC = ptr + "Product Discount Approved by " + MyProject.Forms.Form1.Approvedby;
							MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
							MyProject.Forms.Form1.DiscountApprovedAmt = 0m;
							this.Button1.Focus();
						}
					}
				}
				else
				{
					MessageBox.Show("Please select a product first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error confirming admin users. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x0025D52C File Offset: 0x0025B72C
		private void cboPayMeth_Validating(object sender, CancelEventArgs e)
		{
			bool flag = this.DataGridView1.RowCount > 0;
			if (flag)
			{
			}
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x0025D550 File Offset: 0x0025B750
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

		// Token: 0x060040B5 RID: 16565 RVA: 0x0025D5D0 File Offset: 0x0025B7D0
		private void GetEtradePortSettings(int paymentmethodid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "getEltradePortSettings";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			MyProject.Forms.Form1.FiscalcomPortNum = Conversions.ToInteger(dataRow["ComPort"]);
			MyProject.Forms.Form1.FiscalcomPortSpeed = Conversions.ToInteger(dataRow["ComSpeed"]);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0025D680 File Offset: 0x0025B880
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.chkMultiple.Checked = false;
				this.txtAmtPaid.Text = "0";
				bool flag = MyProject.Forms.Form1.PrintFiscal == 1;
				if (flag)
				{
					bool flag2 = MyProject.Forms.Form1.FiscalEltrade == 1;
					if (flag2)
					{
						this.GetEtradePortSettings(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
					}
				}
				decimal num = this.mono_rate;
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
				this.lblpaymeth.Text = this.cboPayMeth.Text;
				decimal num2 = this.mono_rate;
				bool flag3 = this.DataGridView1.Rows.Count > 0;
				if (flag3)
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							DataTable prodtDetails = this.GetProdtDetails(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value));
							int count = prodtDetails.Rows.Count;
							int num3 = 0;
							bool flag4 = count > 0;
							if (flag4)
							{
								DataRow dataRow = prodtDetails.Rows[0];
								object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value);
								object objectValue2 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscPaymethod"].Value);
								double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value));
								decimal num5 = Conversions.ToDecimal(dataRow["TaxRate"]);
								bool flag5 = num4 != 0.0;
								if (flag5)
								{
									bool flag6 = objectValue.ToString().Contains("Payment Method Discount");
									if (flag6)
									{
										dataGridViewRow.Cells["UnitPrice"].Value = Operators.AddObject(dataGridViewRow.Cells["UnitPrice"].Value, Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)) * -1.0);
										dataGridViewRow.Cells["DiscAmount2"].Value = 0;
									}
									else
									{
										num3 = 1;
									}
								}
								bool flag7 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Promstatus"].Value)) == 3.0;
								DataRow dataRow2;
								if (flag7)
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
								bool flag8 = Operators.ConditionalCompareObjectNotEqual(dataRow2["disc"], 0, false);
								if (flag8)
								{
									this.PaymentMethodDiscountEffected = 1;
									dataGridViewRow.Cells["CouponNumber"].Value = 1;
									dataGridViewRow.Cells["OldPrice"].Value = RuntimeHelpers.GetObjectValue(dataRow2["oldprice"]);
									dataGridViewRow.Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
									decimal num6 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])));
									dataGridViewRow.Cells["UnitPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["DiscDetails"].Value = "Payment Method Discount";
									dataGridViewRow.Cells["DiscPaymethod"].Value = RuntimeHelpers.GetObjectValue(dataRow2["paymethod"]);
									bool flag9 = decimal.Compare(num5, 0m) != 0;
									if (flag9)
									{
										dataGridViewRow.Cells["Tax"].Value = Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, decimal.Add(1m, decimal.Divide(num5, 100m)));
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
									bool flag10 = num3 == 0;
									if (flag10)
									{
										dataGridViewRow.Cells["CouponNumber"].Value = 0;
										dataGridViewRow.Cells["DiscDetails"].Value = "";
									}
									decimal num7 = Conversions.ToDecimal(dataRow["wholesaleqty"]);
									bool flag11 = (MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1) & (Convert.ToDouble(num7) >= Conversions.ToDouble(this.txtQty.Text));
									decimal num8;
									if (flag11)
									{
										num8 = Conversions.ToDecimal(dataRow["SellingPriceWholesale"]);
									}
									else
									{
										num8 = Conversions.ToDecimal(dataRow["SellingPrice"]);
									}
									bool flag12 = (MyProject.Forms.Form1.CalcBackwards == 1) | (MyProject.Forms.Form1.PricesAreAfterTax == 1);
									if (flag12)
									{
										decimal num9 = Math.Round(num8, 2, MidpointRounding.AwayFromZero);
										num9 = decimal.Multiply(num9, this.mono_rate);
										decimal num10 = Math.Round(decimal.Divide(num9, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
										dataGridViewRow.Cells["UnitPrice"].Value = num10;
										dataGridViewRow.Cells["Tax"].Value = Operators.MultiplyObject(Math.Round(decimal.Multiply(num10, decimal.Divide(num5, 100m)), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero), dataGridViewRow.Cells["Qty"].Value);
									}
									else
									{
										decimal num9 = Math.Round(decimal.Multiply(num8, decimal.Add(1m, decimal.Divide(num5, 100m))), 2, MidpointRounding.AwayFromZero);
										num9 = decimal.Multiply(num9, this.mono_rate);
										decimal num11 = Math.Round(decimal.Divide(num9, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
										dataGridViewRow.Cells["UnitPrice"].Value = num11;
										dataGridViewRow.Cells["Tax"].Value = Operators.MultiplyObject(Math.Round(decimal.Multiply(num11, decimal.Divide(num5, 100m)), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero), dataGridViewRow.Cells["Qty"].Value);
									}
									dataGridViewRow.Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 2, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["OldPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["UnitCost"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
									bool flag13 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
									decimal num13;
									if (flag13)
									{
										object obj2 = null;
										Type typeFromHandle = typeof(Math);
										string text = "Round";
										object[] array = new object[3];
										array[0] = Operators.AddObject(Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, dataGridViewRow.Cells["Qty"].Value), dataGridViewRow.Cells["Tax"].Value);
										int num12 = 1;
										Form1 form = MyProject.Forms.Form1;
										ref int ptr = ref form.DecimalPlaces;
										array[num12] = form.DecimalPlaces;
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
										num13 = Conversions.ToDecimal(obj3);
									}
									else
									{
										object obj4 = null;
										Type typeFromHandle2 = typeof(Math);
										string text2 = "Round";
										object[] array7 = new object[3];
										array7[0] = Operators.AddObject(Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, dataGridViewRow.Cells["Qty"].Value), dataGridViewRow.Cells["Tax"].Value);
										int num14 = 1;
										Form1 form2 = MyProject.Forms.Form1;
										ref int ptr = ref form2.DecimalPlaces;
										array7[num14] = form2.DecimalPlaces;
										array7[2] = MidpointRounding.AwayFromZero;
										object[] array2 = array7;
										string[] array8 = null;
										Type[] array9 = null;
										bool[] array10 = new bool[3];
										array10[1] = true;
										bool[] array6 = array10;
										object obj3 = NewLateBinding.LateGet(obj4, typeFromHandle2, text2, array7, array8, array9, array10);
										if (array6[1])
										{
											ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
										}
										num13 = Conversions.ToDecimal(obj3);
									}
									dataGridViewRow.Cells["Total"].Value = num13;
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
				bool flag14 = Operators.CompareString(this.txtBarCode.Text, "", false) == 0;
				if (flag14)
				{
					this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
				}
				else
				{
					this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)), 0, 0m, 0m);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x0025E41C File Offset: 0x0025C61C
		private void GetPayMethDetails(int paymethid)
		{
			DataTable paymentMethodDetails = this.pf.GetPaymentMethodDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn);
			bool flag = paymentMethodDetails.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = paymentMethodDetails.Rows[0];
				this.paymeth_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				this.mono_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				this.paymeth_fiscalgroup = Conversions.ToInteger(dataRow["FiscalGroup"]);
				this.paymeth_desc = Conversions.ToString(dataRow["PaymentMethodDesc"]);
				this.paymeth_currency = Conversions.ToString(dataRow["Currency"]);
				this.paymeth_requiresref = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["RequiresRef"])), false, RuntimeHelpers.GetObjectValue(dataRow["RequiresRef"])));
			}
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x0025E528 File Offset: 0x0025C728
		private void txtQty_TextChanged(object sender, EventArgs e)
		{
			try
			{
				decimal num = this.totpriceWholesale;
				bool flag = Operators.CompareString(this.txtQty.Text, "", false) != 0;
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.txtQty.Text, "0", false) != 0;
					if (flag2)
					{
						this.lbltotprice.Text = Conversions.ToString(Conversion.Val(this.txtQty.Text) * Conversion.Val(this.txtPrice.Text));
						bool flag3 = MyProject.Forms.Form1.IsWholesaleShop != 1;
						if (flag3)
						{
							bool flag4 = MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1;
							if (flag4)
							{
								bool flag5 = decimal.Compare(this.currentWholesaleQty, 0m) != 0;
								if (flag5)
								{
									bool flag6 = decimal.Compare(Convert.ToDecimal(this.txtQty.Text), this.currentWholesaleQty) >= 0;
									if (flag6)
									{
										DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Quantity has reached wholesale level. Do you want to change the price to wholesale? " + this.totpriceWholesale.ToString(), MsgBoxStyle.YesNo, null);
										bool flag7 = dialogResult == DialogResult.Yes;
										if (flag7)
										{
											this.txtPrice.Text = this.totpriceWholesale.ToString();
											this.priceb4tax = decimal.Divide(this.totpriceWholesale, decimal.Add(1m, decimal.Divide(this.taxdueWholesale, 100m)));
											this.WholesalePriceByQty = 1;
											this.EnterItem();
										}
									}
								}
							}
						}
						bool flag8 = MyProject.Forms.Form1.UsePriceMatrix == 1;
						if (flag8)
						{
							this.setPriceMatrix();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x0025E704 File Offset: 0x0025C904
		private void setPriceMatrix()
		{
			decimal priceMatrixForProduct = this.pf.GetPriceMatrixForProduct(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.CurrentID, checked((int)Math.Round(Conversion.Val(this.txtQty.Text))), this._cnn);
			bool flag = MyProject.Forms.Form1.PricesAreAfterTax == 1;
			if (flag)
			{
				this.txtPrice.Text = priceMatrixForProduct.ToString();
				this.priceb4tax = new decimal(Convert.ToDouble(priceMatrixForProduct) / (1.0 + Conversion.Val(this.lbltax.Text) / 100.0));
			}
			else
			{
				this.priceb4tax = priceMatrixForProduct;
				this.txtPrice.Text = Conversions.ToString(Convert.ToDouble(priceMatrixForProduct) * (1.0 + Conversion.Val(this.lbltax.Text) / 100.0));
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0025E808 File Offset: 0x0025CA08
		private void txtAmtPaid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ProcessSale();
				e.Handled = true;
			}
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0025E838 File Offset: 0x0025CA38
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

		// Token: 0x060040BE RID: 16574 RVA: 0x0025E8B4 File Offset: 0x0025CAB4
		private void RunSaveCustomer()
		{
			this.SaveCustomerDetails();
			this.og_customername = this.txtcustomer.Text;
			this.og_address = this.txtAddress.Text;
			this.og_contactname = this.txtContactName.Text;
			this.og_mobile = this.txtMobile.Text;
			this.og_email = this.txtEmail.Text;
			this.og_tel = this.txtTel.Text;
			this.og_invdetail1 = this.txtInvDetails1.Text;
			this.og_invdetail2 = this.txtInvDetails2.Text;
			this.og_vatnumber = this.txtvatnumber.Text;
			this.og_bpnumber = this.txtbpnumber.Text;
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0025E974 File Offset: 0x0025CB74
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
				this.txtInvDetails1.Text = "";
				this.txtInvDetails2.Text = "";
				this.txtvatnumber.Text = "";
				this.txtbpnumber.Text = "";
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_contactname = this.txtContactName.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_tel = this.txtTel.Text;
				this.og_invdetail1 = this.txtInvDetails1.Text;
				this.og_invdetail2 = this.txtInvDetails2.Text;
				this.og_bpnumber = this.txtbpnumber.Text;
				this.og_vatnumber = this.txtvatnumber.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error clearing customer details: " + ex.Message);
			}
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0025EB1C File Offset: 0x0025CD1C
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
								bool flag8 = Operators.CompareString(Strings.Trim(this.txtInvDetails1.Text), Strings.Trim(this.og_invdetail1), false) != 0;
								if (flag8)
								{
									flag = true;
									flag3 = flag;
								}
								else
								{
									bool flag9 = Operators.CompareString(Strings.Trim(this.txtInvDetails2.Text), Strings.Trim(this.og_invdetail2), false) != 0;
									if (flag9)
									{
										flag = true;
										flag3 = flag;
									}
									else
									{
										bool flag10 = Operators.CompareString(Strings.Trim(this.txtbpnumber.Text), Strings.Trim(this.og_bpnumber), false) != 0;
										if (flag10)
										{
											flag = true;
											flag3 = flag;
										}
										else
										{
											bool flag11 = Operators.CompareString(Strings.Trim(this.txtvatnumber.Text), Strings.Trim(this.og_vatnumber), false) != 0;
											if (flag11)
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
				}
			}
			return flag3;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002A30 File Offset: 0x00000C30
		private void lblcost_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x0025ECF8 File Offset: 0x0025CEF8
		private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x0025ED44 File Offset: 0x0025CF44
		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x0025ED78 File Offset: 0x0025CF78
		private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.Button2.TabStop = true;
					this.txtAmtPaid.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error tab key. IGNORE. Details: " + ex.Message);
			}
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x0025EDE8 File Offset: 0x0025CFE8
		private void Button10_Click(object sender, EventArgs e)
		{
			try
			{
				this.coname = this.coname_og;
				this.coadd = this.coadd_og;
				this.coadd2 = this.coadd2_og;
				this.cotel = this.cotel_og;
				this.cotel2 = this.cotel2_og;
				this.cotel3 = this.cotel3_og;
				this.coemail = this.coemail_og;
				this.coVATNum = this.coVATNum_og;
				this.cobpnum = this.cobpnum_og;
				this.bpnum_name = this.bpnum_name_og;
				this.vatnum_name = this.vatnum_name_og;
				this.footnote = this.footnote_og;
				bool flag = this.CheckIfCustomerDetailsChanged();
				if (flag)
				{
					this.UpdateCustomer();
				}
				this.PrintHeaderQuotation(this.SaveQuotation());
				this.ItemsToBePrintedQuotation();
				this.PrintFooterQuotation();
				this.stringToRead = new StringReader(this.TextToPrint);
				try
				{
					StandardPrintController standardPrintController = new StandardPrintController();
					this.PrintDocument1.PrintController = standardPrintController;
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.defaultReceiptPrinter, "", false) != 0;
					if (flag2)
					{
						this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
					}
					this.PrintDocument1.Print();
				}
				finally
				{
					this.stringToRead.Close();
				}
				MessageBox.Show("Quotation print job sent to printer.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x0025EFA4 File Offset: 0x0025D1A4
		private void PrintHeaderQuotation(int quotation_num)
		{
			this.TextToPrint = "";
			string text = "QUOTATION";
			int length = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - length) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Quotation # " + quotation_num.ToString() + Environment.NewLine;
				string text3 = this.coname;
				int num = text3.Length;
				string text4 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + text3 + Environment.NewLine;
				bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag)
				{
					text3 = this.bpnum_name + " " + this.cobpnum;
					num = text3.Length;
					string text5 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text3 + Environment.NewLine;
				}
				text3 = this.coadd;
				num = text3.Length;
				string text6 = new string(' ', (int)Math.Round(Math.Round((double)(100 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text6 + text3 + Environment.NewLine;
				text3 = this.coadd2;
				num = text3.Length;
				string text7 = new string(' ', (int)Math.Round(Math.Round((double)(100 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text7 + text3 + Environment.NewLine;
				bool flag2 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag2)
				{
					text3 = "Email: " + this.coemail;
					num = text3.Length;
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text3 + Environment.NewLine;
				}
				bool flag3 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag3)
				{
					text3 = this.cotel;
					num = text3.Length;
					string text9 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text3 + Environment.NewLine;
				}
				bool flag4 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag4)
				{
					text3 = this.cotel2 + "  " + this.cotel3;
					num = text3.Length;
					string text10 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text10 + text3 + Environment.NewLine;
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

		// Token: 0x060040C7 RID: 16583 RVA: 0x0025F390 File Offset: 0x0025D590
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
			this.TextToPrint = ptr + "Payment Method: " + this.cboPayMeth.Text;
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
						string text2 = dataGridViewRow.Cells["Desc"].Value.ToString();
						num = Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value);
						double num2 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)));
						double num3 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
						string text3 = dataGridViewRow.Cells["ProductCode"].Value.ToString();
						string text4 = "";
						int num4 = (int)Math.Round(Conversion.Val(text.Length));
						bool flag2 = num4 >= 41;
						if (flag2)
						{
							text = text.Substring(0, 40);
							text4 = text2.Substring(40, num4 - 41);
						}
						else
						{
							int num5 = num4;
							int num6 = 50 - num5;
							text = text.PadRight(num6);
						}
						string text5 = text;
						bool flag3 = text.Length > 0;
						if (flag3)
						{
							text5 = text5 + Environment.NewLine + text4;
						}
						string text6 = Conversions.ToString(text5.Length);
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text5 + Environment.NewLine;
						decimal num7 = 0m;
						string text7 = "               ";
						bool flag4 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
						if (flag4)
						{
							decimal num8 = new decimal(unchecked(num2 * Convert.ToDouble(this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn))));
							num7 = decimal.Multiply(num8, num);
							string text8 = Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True);
							int length = num8.ToString().Length;
							int i = length - 5;
							bool flag5 = i > 0;
							if (flag5)
							{
								while (i > 0)
								{
									text7 = text7.Substring(0, text7.Length - 1);
									i--;
								}
							}
							else
							{
								bool flag6 = i < 0;
								if (flag6)
								{
								}
							}
							text5 = string.Concat(new string[]
							{
								"     ",
								num.ToString().PadRight(8, ' '),
								"X        ",
								Strings.Format(num8, "N2").PadLeft(12, ' '),
								Strings.Format(num7, "N2").PadLeft(32, ' ')
							});
						}
						else
						{
							string text9 = Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True);
							int length2 = text9.ToString().Length;
							int j = length2 - 5;
							bool flag7 = j > 0;
							if (flag7)
							{
								while (j > 0)
								{
									text7 = text7.Substring(0, text7.Length - 1);
									j--;
								}
							}
							else
							{
								bool flag8 = j < 0;
								if (flag8)
								{
								}
							}
							num7 = new decimal(unchecked(num2 * Convert.ToDouble(num)));
							text5 = string.Concat(new string[]
							{
								"     ",
								num.ToString(),
								"   X        ",
								Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
								text7,
								Strings.FormatCurrency(num7.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
							});
						}
						string text10 = Conversions.ToString(text5.Length);
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text5 + Environment.NewLine;
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

		// Token: 0x060040C8 RID: 16584 RVA: 0x0025F914 File Offset: 0x0025DB14
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
					decimal num3 = new decimal(unchecked(num * Convert.ToDouble(this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn))));
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
					bool @checked = this.chkAccount.Checked;
					if (@checked)
					{
					}
				}
				text = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x0025FC00 File Offset: 0x0025DE00
		private void Button13_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.DataGridView1.RowCount < 1;
				if (flag)
				{
					MessageBox.Show("Please select items for the quotation before saving.");
					bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag2)
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
					bool flag3 = MyProject.Forms.Form1.ConsultantSalesOnly == 1;
					if (flag3)
					{
						bool flag4 = Operators.CompareString(this.cboConsultant.Text, "", false) == 0;
						if (flag4)
						{
							MessageBox.Show("Please select a consultant first.");
							this.cboConsultant.Focus();
							return;
						}
					}
					bool flag5 = MyProject.Forms.Form1.pendinginvoice_entryno == 0;
					if (flag5)
					{
						string text = "Enter a reference or name of the customer";
						string text2 = "Enter Pending Invoice Details";
						string text3 = "";
						object obj = Interaction.InputBox(text, text2, text3, -1, -1);
						this.RunSaveCustomer();
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.Connection = sqlConnection;
						sqlConnection.Open();
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunQuotationSaveAll");
						sqlCommand.Transaction = sqlTransaction;
						try
						{
							int num = 0;
							int num2 = 0;
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "GetNextQuotationNumber";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("thedate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("quotation_number", num);
							num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "PendingInvoiceInsert";
							sqlCommand.Parameters.AddWithValue("ref", num);
							sqlCommand.Parameters.AddWithValue("datesaved", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("timesaved", DateTime.Now.ToString("HHmm"));
							sqlCommand.Parameters.AddWithValue("savedby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("CustomerID", this.txtcustomer.Text);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("consultant", this.cboConsultant.Text);
							sqlCommand.Parameters.AddWithValue("new_entryno", num2);
							sqlCommand.Parameters.AddWithValue("paymethodid", this.cboPayMeth.Text);
							sqlCommand.Parameters.AddWithValue("ref2", obj.ToString());
							num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
							try
							{
								foreach (object obj2 in ((IEnumerable)this.DataGridView1.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "PendingInvoiceDetailsInsert";
									sqlCommand.Parameters.AddWithValue("ref", num);
									sqlCommand.Parameters.AddWithValue("productid", Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value));
									sqlCommand.Parameters.AddWithValue("productcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
									sqlCommand.Parameters.AddWithValue("productdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Desc"].Value));
									sqlCommand.Parameters.AddWithValue("unitprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)));
									sqlCommand.Parameters.AddWithValue("quantity", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
									sqlCommand.Parameters.AddWithValue("tax", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
									sqlCommand.Parameters.AddWithValue("total", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
									sqlCommand.Parameters.AddWithValue("col1", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
									sqlCommand.Parameters.AddWithValue("couponnumber", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["CouponNumber"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CouponNumber"].Value)))));
									sqlCommand.Parameters.AddWithValue("oldprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)));
									sqlCommand.Parameters.AddWithValue("pricechange", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["PriceChange"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PriceChange"].Value)))));
									sqlCommand.Parameters.AddWithValue("isairtime", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["isairtime"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isairtime"].Value)))));
									string text4 = dataGridViewRow.Cells["MNO"].Value.ToString();
									bool flag6 = Operators.CompareString(text4, "", false) == 0;
									int num3;
									if (flag6)
									{
										num3 = 0;
									}
									else
									{
										num3 = Conversions.ToInteger(dataGridViewRow.Cells["MNO"].Value);
									}
									sqlCommand.Parameters.AddWithValue("mno", num3);
									sqlCommand.Parameters.AddWithValue("iswholesaleprice", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["iswholesaleprice"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["iswholesaleprice"].Value)))));
									sqlCommand.Parameters.AddWithValue("wholesaleqtydiscount", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["wholesaleqtydiscount"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["wholesaleqtydiscount"].Value)))));
									sqlCommand.Parameters.AddWithValue("entryno", num2);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("consultant", this.cboConsultant.Text);
									sqlCommand.Parameters.AddWithValue("promstatus", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PromStatus"].Value));
									sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
									sqlCommand.Parameters.AddWithValue("ExpiryDate", Conversions.ToInteger(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value))));
									sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value))));
									sqlCommand.Parameters.AddWithValue("otherdetail", dataGridViewRow.Cells["OtherDetail"].Value.ToString());
									sqlCommand.Parameters.AddWithValue("isvoucher", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isvoucher"].Value));
									sqlCommand.Parameters.AddWithValue("Comments", dataGridViewRow.Cells["comments"].Value.ToString());
									sqlCommand.Parameters.AddWithValue("RowNumber", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["RowNumber"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["RowNumber"].Value))));
									sqlCommand.Parameters.AddWithValue("uom", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UOM"].Value));
									sqlCommand.Parameters.AddWithValue("ref2", obj.ToString());
									sqlCommand.Parameters.AddWithValue("break", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Break"].Value));
									sqlCommand.Parameters.AddWithValue("breakqty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakQty"].Value));
									sqlCommand.Parameters.AddWithValue("breakparentproductid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakParentProductID"].Value));
									sqlCommand.Parameters.AddWithValue("actualbreakqty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ActualBreakQty"].Value));
									sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxexempt"].Value));
									int num4 = 0;
									bool flag7 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isdeposits"].Value));
									if (!flag7)
									{
										bool flag8 = Operators.CompareString(dataGridViewRow.Cells["isdeposits"].Value.ToString(), "", false) != 0;
										if (flag8)
										{
											num4 = Conversions.ToInteger(dataGridViewRow.Cells["isdeposits"].Value);
										}
									}
									sqlCommand.Parameters.AddWithValue("isdeposits", num4);
									sqlCommand.Parameters.AddWithValue("altdesc", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["AltDesc"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["AltDesc"].Value))));
									sqlCommand.Parameters.AddWithValue("taxr", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxr"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxr"].Value))));
									sqlCommand.Parameters.AddWithValue("hscode", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["HSCode"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["HSCode"].Value))));
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
							sqlConnection.Close();
							bool flag9 = MyProject.Forms.Form1.PrintReceipt == 1;
							if (flag9)
							{
								this.Print_Quotation_Ref(num);
							}
							MessageBox.Show("Invoice saved as pending. Ref number: " + num.ToString());
							this.ClearForm();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error saving quotation for invoicing. Detail: " + ex.Message);
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
					else
					{
						this.UpdatePendingInv();
						MessageBox.Show("Invoice for ref: " + this.lblRef.Text + " has been updated successfully.");
						this.ClearForm();
					}
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error saving quotation. Detail: " + ex3.Message);
			}
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x00260B2C File Offset: 0x0025ED2C
		private void UpdatePendingInv()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunQuotationSaveAll");
			sqlCommand.Transaction = sqlTransaction;
			sqlCommand.Parameters.Clear();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"delete pendinginvoicedetail where entryno=",
				Conversions.ToString(MyProject.Forms.Form1.pendinginvoice_entryno),
				" and coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"'"
			});
			sqlCommand.ExecuteNonQuery();
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "PendingInvoiceDetailsInsert";
					sqlCommand.Parameters.AddWithValue("ref", MyProject.Forms.Form1.pendinginvoice_ref);
					sqlCommand.Parameters.AddWithValue("productid", Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value));
					sqlCommand.Parameters.AddWithValue("productcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
					sqlCommand.Parameters.AddWithValue("productdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Desc"].Value));
					sqlCommand.Parameters.AddWithValue("unitprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)));
					sqlCommand.Parameters.AddWithValue("quantity", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
					sqlCommand.Parameters.AddWithValue("tax", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
					sqlCommand.Parameters.AddWithValue("total", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
					sqlCommand.Parameters.AddWithValue("col1", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
					sqlCommand.Parameters.AddWithValue("couponnumber", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CouponNumber"].Value)));
					sqlCommand.Parameters.AddWithValue("oldprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)));
					sqlCommand.Parameters.AddWithValue("pricechange", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PriceChange"].Value)));
					sqlCommand.Parameters.AddWithValue("isairtime", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isairtime"].Value)));
					string text = dataGridViewRow.Cells["MNO"].Value.ToString();
					bool flag = Operators.CompareString(text, "", false) == 0;
					int num;
					if (flag)
					{
						num = 0;
					}
					else
					{
						num = Conversions.ToInteger(dataGridViewRow.Cells["MNO"].Value);
					}
					sqlCommand.Parameters.AddWithValue("mno", num);
					sqlCommand.Parameters.AddWithValue("iswholesaleprice", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["iswholesaleprice"].Value)));
					sqlCommand.Parameters.AddWithValue("wholesaleqtydiscount", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["wholesaleqtydiscount"].Value)));
					sqlCommand.Parameters.AddWithValue("entryno", MyProject.Forms.Form1.pendinginvoice_entryno);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("consultant", this.cboConsultant.Text);
					sqlCommand.Parameters.AddWithValue("promstatus", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PromStatus"].Value));
					sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
					sqlCommand.Parameters.AddWithValue("ExpiryDate", Conversions.ToInteger(dataGridViewRow.Cells["ExpiryDate"].Value));
					sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value))));
					sqlCommand.Parameters.AddWithValue("otherdetail", dataGridViewRow.Cells["OtherDetail"].Value.ToString());
					sqlCommand.Parameters.AddWithValue("isvoucher", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isvoucher"].Value));
					sqlCommand.Parameters.AddWithValue("Comments", dataGridViewRow.Cells["comments"].Value.ToString());
					sqlCommand.Parameters.AddWithValue("RowNumber", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["RowNumber"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["RowNumber"].Value))));
					sqlCommand.Parameters.AddWithValue("uom", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UOM"].Value));
					sqlCommand.Parameters.AddWithValue("ref2", this.lblRef.Text);
					sqlCommand.Parameters.AddWithValue("break", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Break"].Value));
					sqlCommand.Parameters.AddWithValue("breakqty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakQty"].Value));
					sqlCommand.Parameters.AddWithValue("breakparentproductid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakParentProductID"].Value));
					sqlCommand.Parameters.AddWithValue("actualbreakqty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ActualBreakQty"].Value));
					sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxexempt"].Value));
					int num2 = 0;
					bool flag2 = Operators.CompareString(dataGridViewRow.Cells["isdeposits"].Value.ToString(), "", false) != 0;
					if (flag2)
					{
						num2 = Conversions.ToInteger(dataGridViewRow.Cells["isdeposits"].Value);
					}
					sqlCommand.Parameters.AddWithValue("isdeposits", num2);
					sqlCommand.Parameters.AddWithValue("altdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["AltDesc"].Value));
					sqlCommand.Parameters.AddWithValue("taxr", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxr"].Value));
					sqlCommand.Parameters.AddWithValue("hscode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["HSCode"].Value));
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
			sqlConnection.Close();
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x00261464 File Offset: 0x0025F664
		private void Print_Quotation_Ref(int quote_num)
		{
			this.TextToPrint = "";
			string text = "QUOTATION REFERENCE";
			int length = text.Length;
			string text2 = new string(' ', checked((int)Math.Round(Math.Round((double)(50 - length) / 2.0))));
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = string.Concat(new string[]
			{
				ptr,
				text2,
				text,
				Environment.NewLine,
				Environment.NewLine
			});
			string text3 = "Consultant: " + MyProject.Forms.Form1.username;
			int num = text3.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine;
			text3 = "Ref: " + Conversions.ToString(quote_num);
			num = text3.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine;
			text3 = this.paymeth_currency + " Total: " + this.txtTotal.Text;
			num = text3.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine;
			text3 = this.DTdate.Value.ToShortDateString();
			num = text3.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine;
			this.stringToRead = new StringReader(this.TextToPrint);
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrintController = standardPrintController;
				bool flag = Operators.CompareString(MyProject.Forms.Form1.defaultReceiptPrinter, "", false) != 0;
				if (flag)
				{
					this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
				}
				this.PrintDocument1.Print();
			}
			finally
			{
				this.stringToRead.Close();
			}
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x00261654 File Offset: 0x0025F854
		private int SaveQuotation()
		{
			int num = 0;
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
					sqlCommand.Parameters.AddWithValue("quotation_num", num);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
					num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
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
							sqlCommand.Parameters.AddWithValue("quotationnumber", num);
							sqlCommand.Parameters.AddWithValue("discamt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value));
							sqlCommand.Parameters.AddWithValue("customerentryno", this.currentCustomerEntryNo);
							sqlCommand.Parameters.AddWithValue("oldprice", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value));
							sqlCommand.Parameters.AddWithValue("taxrate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxr"].Value));
							sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
							sqlCommand.Parameters.AddWithValue("ExpiryDate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
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
					MessageBox.Show("Error generating quotation. Detail: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Please enter products into the grid first");
			}
			return num;
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x00261B90 File Offset: 0x0025FD90
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CheckIfCustomerDetailsChanged();
				if (flag)
				{
					this.UpdateCustomer();
				}
				new Quotation
				{
					quotationnumber = this.SaveQuotation(),
					branch = MyProject.Forms.Form1.branch,
					coid = MyProject.Forms.Form1.coid
				}.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x00261C30 File Offset: 0x0025FE30
		private void cmdDiscount_Click(object sender, EventArgs e)
		{
			try
			{
				SupervisorApproval supervisorApproval = new SupervisorApproval();
				supervisorApproval.ShowDialog();
				this.CalcTotalSale();
				bool flag = MyProject.Forms.Form1.InvDiscountEditingAllowed == 1;
				if (flag)
				{
					this.txtDiscount.ReadOnly = false;
				}
				else
				{
					this.txtDiscount.ReadOnly = true;
				}
				this.txtAmtPaid.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error authorising discount. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x00261CCC File Offset: 0x0025FECC
		private void Button14_Click(object sender, EventArgs e)
		{
			try
			{
				string text = MyProject.Forms.Form1.myrevmax.ZReport();
				MessageBox.Show("Z Report feedback: " + text);
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to print Z Report?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.TextToPrint = "";
					string text2 = "Z REPORT" + Environment.NewLine + Environment.NewLine;
					text2 += text;
					this.stringToRead = new StringReader(this.TextToPrint);
					try
					{
						StandardPrintController standardPrintController = new StandardPrintController();
						this.PrintDocument1.PrintController = standardPrintController;
						this.PrintDocument1.Print();
					}
					finally
					{
						this.stringToRead.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Z Report error. Description: " + ex.Message);
			}
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00261DCC File Offset: 0x0025FFCC
		private void CheckPromotions()
		{
			checked
			{
				try
				{
					string text = "";
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool isNewRow = dataGridViewRow.IsNewRow;
							if (!isNewRow)
							{
								string value = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PromStatus"].Value));
								bool flag = (Operators.CompareString(value, "2", false) == 0) | (Operators.CompareString(value, "", false) == 0);
								if (flag)
								{
									text = text + ";" + dataGridViewRow.Cells["ProdtID"].Value.ToString() + ";";
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
					DataTable dataTable = this.getpromnumbers(Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")), text);
					int count = dataTable.Rows.Count;
					bool flag2 = count > 0;
					if (flag2)
					{
						int num = 0;
						try
						{
							foreach (object obj2 in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj2;
								num = 0;
								DataTable promDetails = this.getPromDetails(Conversions.ToInteger(dataRow["PromotionNo"]));
								try
								{
									foreach (object obj3 in promDetails.Rows)
									{
										DataRow dataRow2 = (DataRow)obj3;
										try
										{
											foreach (object obj4 in ((IEnumerable)this.DataGridView1.Rows))
											{
												DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
												string value2 = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["PromStatus"].Value));
												bool flag3 = (Operators.CompareString(value2, "2", false) == 0) | (Operators.CompareString(value2, "", false) == 0);
												if (flag3)
												{
													bool flag4 = Operators.ConditionalCompareObjectEqual(dataRow2["RequiredProductID"], dataGridViewRow2.Cells["ProdtID"].Value, false);
													if (flag4)
													{
														bool flag5 = Operators.ConditionalCompareObjectGreaterEqual(dataGridViewRow2.Cells["Qty"].Value, dataRow2["RequiredQty"], false);
														if (flag5)
														{
															dataGridViewRow2.Cells["PromStatus"].Value = "1";
														}
													}
												}
											}
										}
										finally
										{
											IEnumerator enumerator4;
											if (enumerator4 is IDisposable)
											{
												(enumerator4 as IDisposable).Dispose();
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
								try
								{
									foreach (object obj5 in ((IEnumerable)this.DataGridView1.Rows))
									{
										DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj5;
										bool flag6 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["PromStatus"].Value, "1", false);
										if (flag6)
										{
											num++;
										}
									}
								}
								finally
								{
									IEnumerator enumerator5;
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
								bool flag7 = num == promDetails.Rows.Count;
								if (flag7)
								{
									this.DataGridView1.AllowUserToDeleteRows = false;
									DataTable promBenefits = this.getPromBenefits(Conversions.ToInteger(dataRow["PromotionNo"]));
									try
									{
										foreach (object obj6 in promBenefits.Rows)
										{
											DataRow dataRow3 = (DataRow)obj6;
											int num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow3["BenefitType"]));
											if (num2 != 1)
											{
												if (num2 != 2)
												{
													MessageBox.Show("Benefit type for promotion not known. Advise the System Administrator. Click OK to continue.");
												}
												else
												{
													DataTable dataTable2 = this.FetchProductDetailsbyID(Conversions.ToInteger(dataRow3["ProductID"]));
													DataRow dataRow4 = dataTable2.Rows[0];
													decimal num3 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
													{
														Operators.MultiplyObject(Operators.MultiplyObject(Operators.DivideObject(dataRow4["TaxRate"], 100), dataRow3["DiscountPrice"]), dataRow3["DiscountQty"]),
														2,
														MidpointRounding.AwayFromZero
													}, null, null, null));
													decimal num4 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
													{
														Operators.AddObject(Operators.MultiplyObject(dataRow3["DiscountQty"], dataRow3["DiscountPrice"]), num3),
														2,
														MidpointRounding.AwayFromZero
													}, null, null, null));
													string[] array = new string[]
													{
														dataRow3["ProductID"].ToString(),
														dataRow4["ProductCode"].ToString(),
														dataRow4["ProductDesc"].ToString(),
														dataRow3["DiscountPrice"].ToString(),
														dataRow3["DiscountQty"].ToString(),
														num3.ToString(),
														num4.ToString(),
														NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
														{
															Operators.MultiplyObject(dataRow4["Cost"], this.mono_rate),
															2,
															MidpointRounding.AwayFromZero
														}, null, null, null).ToString(),
														"0",
														"0",
														"",
														"",
														"0",
														Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
														Conversions.ToString(0),
														"Promotion",
														"",
														"0",
														"",
														"0",
														dataRow4["TaxRate"].ToString(),
														"3"
													};
													this.DataGridView1.Rows.Add(array);
													this.datProm.Rows.Add(new object[] { Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["PromotionNo"])) });
													MessageBox.Show("PROMOTION EFFECTED. New product automatically added.", "PROMOTION", MessageBoxButtons.OK);
												}
											}
											else
											{
												try
												{
													foreach (object obj7 in ((IEnumerable)this.DataGridView1.Rows))
													{
														DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj7;
														string value3 = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["PromStatus"].Value));
														bool flag8 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow4.Cells["ProdtID"].Value, dataRow3["ProductID"], false), Operators.CompareString(value3, "1", false) == 0));
														if (flag8)
														{
															decimal num5 = Conversions.ToDecimal(dataGridViewRow4.Cells["UnitPrice"].Value);
															decimal num6 = Conversions.ToDecimal(dataRow3["DiscountAmt"]);
															dataGridViewRow4.Cells["UnitPrice"].Value = Operators.SubtractObject(Operators.MultiplyObject(Operators.DivideObject(dataGridViewRow4.Cells["UnitPrice"].Value, this.mono_rate), this.mono_rate), Operators.MultiplyObject(dataRow3["DiscountAmt"], this.mono_rate));
															dataGridViewRow4.Cells["DiscAmount2"].Value = Operators.MultiplyObject(dataRow3["DiscountAmt"], this.mono_rate);
															dataGridViewRow4.Cells["Tax"].Value = Operators.MultiplyObject(Operators.MultiplyObject(dataGridViewRow4.Cells["UnitPrice"].Value, dataGridViewRow4.Cells["Taxr"].Value), dataGridViewRow4.Cells["Qty"].Value);
															dataGridViewRow4.Cells["Total"].Value = decimal.Add(decimal.Multiply(decimal.Multiply(Convert.ToDecimal(Operators.DivideObject(dataGridViewRow4.Cells["UnitPrice"].Value, this.mono_rate)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Qty"].Value))), this.mono_rate), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["Tax"].Value)));
															dataGridViewRow4.Cells["PromStatus"].Value = "3";
														}
													}
												}
												finally
												{
													IEnumerator enumerator7;
													if (enumerator7 is IDisposable)
													{
														(enumerator7 as IDisposable).Dispose();
													}
												}
												this.datProm.Rows.Add(new object[] { Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["PromotionNo"])) });
												MessageBox.Show("PROMOTION EFFECTED. Discount added.", "PROMOTION", MessageBoxButtons.OK);
											}
										}
									}
									finally
									{
										IEnumerator enumerator6;
										if (enumerator6 is IDisposable)
										{
											(enumerator6 as IDisposable).Dispose();
										}
									}
								}
								else
								{
									bool flag9 = num > 0;
									if (flag9)
									{
										try
										{
											foreach (object obj8 in ((IEnumerable)this.DataGridView1.Rows))
											{
												DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj8;
												string value4 = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells["PromStatus"].Value));
												bool flag10 = (Operators.CompareString(value4, "2", false) == 0) | (Operators.CompareString(value4, "", false) == 0);
												if (flag10)
												{
													dataGridViewRow5.Cells["PromStatus"].Value = "2";
												}
											}
										}
										finally
										{
											IEnumerator enumerator8;
											if (enumerator8 is IDisposable)
											{
												(enumerator8 as IDisposable).Dispose();
											}
										}
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					else
					{
						flag2 = count == 0;
						if (flag2)
						{
							try
							{
								foreach (object obj9 in ((IEnumerable)this.DataGridView1.Rows))
								{
									DataGridViewRow dataGridViewRow6 = (DataGridViewRow)obj9;
									string value5 = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow6.Cells["PromStatus"].Value));
									bool flag11 = (Operators.CompareString(value5, "2", false) == 0) | (Operators.CompareString(value5, "", false) == 0);
									if (flag11)
									{
										dataGridViewRow6.Cells["PromStatus"].Value = "0";
									}
								}
							}
							finally
							{
								IEnumerator enumerator9;
								if (enumerator9 is IDisposable)
								{
									(enumerator9 as IDisposable).Dispose();
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Promotion calculation error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x00262A74 File Offset: 0x00260C74
		private DataTable getPromBenefits(int promnum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionGetBenefitsN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x00262B24 File Offset: 0x00260D24
		private DataTable getPromDetails(int promnum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionGetDetailsN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x00262BD4 File Offset: 0x00260DD4
		private DataTable getpromnumbers(int theday, string prodlist)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionsCheckMultpileN";
			sqlCommand.Parameters.AddWithValue("productidlist", prodlist);
			sqlCommand.Parameters.AddWithValue("theday", theday);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x00262C94 File Offset: 0x00260E94
		private void InsertPromGiven(int invnumber, int promno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionGivenInsertN";
			sqlCommand.Parameters.AddWithValue("theday", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("invnum", invnumber);
			sqlCommand.Parameters.AddWithValue("promotionno", promno);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x00262DA8 File Offset: 0x00260FA8
		public string GetValue(object Value)
		{
			bool flag = Value != null;
			string text;
			if (flag)
			{
				text = Value.ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x00262DD4 File Offset: 0x00260FD4
		private DataTable FetchProductDetailsbyID(int prodid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00262E64 File Offset: 0x00261064
		private DataTable FetchProductDetailsbyCode(string prodcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x00262EF0 File Offset: 0x002610F0
		private void ProcessMultipay()
		{
			this.PaymentMethodDiscountEffected = 0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = dataGridViewRow.Cells["DiscDetails"].Value.ToString().Contains("Payment Method Discount") & (Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)) != 0.0);
					if (flag)
					{
						this.PaymentMethodDiscountEffected = 1;
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
			bool flag2 = this.PaymentMethodDiscountEffected == 0;
			if (flag2)
			{
				bool flag3 = !this.chkMultiple.Checked;
				if (flag3)
				{
					this.chkMultiple.Checked = true;
				}
				MultiPayMethods multiPayMethods = new MultiPayMethods();
				multiPayMethods.invtotal = new decimal(Conversion.Val(this.txtTotal.Text));
				multiPayMethods.invpaymethrate = this.paymeth_rate;
				multiPayMethods.lblpaymethod.Text = this.paymeth_desc;
				multiPayMethods.ShowDialog(this);
				multiPayMethods.Dispose();
				this.txtAmtPaid.Text = Conversions.ToString(MyProject.Forms.Form1.Multipay_amtpaid);
				this.Button2.Focus();
			}
			else
			{
				MessageBox.Show("Payment method based discount applied. Cannot process multi payments for this invoice.");
			}
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x00263078 File Offset: 0x00261278
		private void Button15_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.DataGridView1.Rows.Count > 0;
				if (flag)
				{
					this.ProcessMultipay();
				}
				else
				{
					MessageBox.Show("Please select products to be bought first and get total sale amount.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error with multiple payments. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x002630F0 File Offset: 0x002612F0
		private void chkMultiple_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkMultiple.Checked;
			if (@checked)
			{
				this.txtAmtPaid.Enabled = false;
			}
			else
			{
				this.txtAmtPaid.Enabled = true;
				this.txtAmtPaid.Text = "0";
			}
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00238959 File Offset: 0x00236B59
		private void cboPayMeth_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !((Strings.Asc(e.KeyChar) == 65366) | (Strings.Asc(e.KeyChar) == 65365));
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x00263140 File Offset: 0x00261340
		private void cboPayMeth_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = (e.KeyValue == 13) | (e.KeyValue == 34);
			if (flag)
			{
				this.txtAmtPaid.Focus();
				e.Handled = true;
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x00263180 File Offset: 0x00261380
		private void Sales2mono_Disposed(object sender, EventArgs e)
		{
			try
			{
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
				this.UpdateCustomerDisplayVFD("0.00");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(Conversions.ToString(Operators.CompareString("Error Disposing. Detail: ", ex.Message, false) == 0));
			}
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x0026324C File Offset: 0x0026144C
		private string PrintEltradeInvoice(DataTable datproducts, int paymentmethodnumber, string paymentmethoddesc, double paymentamount, int comport, int comspeed, int receiptcurrencyID, int bontype, string cashiername, int invoicenumber, string customerTaxNumber, string customerVATNumber, string invcompany, string invcity, string invaddress, string invMOL, string invReceipient, EltradeFprn peltrade)
		{
			bool flag = peltrade.Init(comport, comspeed, 0, 0, 0, "") == 0;
			string text;
			if (flag)
			{
				peltrade.CurrencyID = receiptcurrencyID;
				bool flag2 = peltrade.StartBon(bontype, 0, cashiername, Conversions.ToString(invoicenumber), customerTaxNumber, customerVATNumber, invcompany, invcompany, invaddress, invMOL, invReceipient) == 0;
				if (flag2)
				{
					try
					{
						foreach (object obj in datproducts.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							bool flag3 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]));
							if (flag3)
							{
								peltrade.PLUCurrencyID = receiptcurrencyID;
								bool flag4 = peltrade.AddPLU(Conversions.ToString(dataRow["ProductCode"]), Conversions.ToString(dataRow["Desc"]), Conversions.ToDouble(Operators.MultiplyObject(dataRow["UnitPrice"], this.FetchProductTaxRateByCode(Conversions.ToString(dataRow["ProductCode"])))), Conversions.ToDouble(dataRow["Qty"]), this.GetVATGroup(Conversions.ToInteger(dataRow["ProdtID"]))) == 0;
								if (!flag4)
								{
									return "Adding PLU error. Detail. " + peltrade.GetLastError(1);
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
					bool flag5 = peltrade.AddPayment(paymentmethodnumber, paymentmethoddesc, paymentamount, 1.0) == 0;
					if (flag5)
					{
						bool flag6 = peltrade.EndBon() == 0;
						if (flag6)
						{
							text = "SUCCESS";
						}
						else
						{
							text = "Error printing bon. Detail: " + peltrade.GetLastError(1);
						}
					}
					else
					{
						text = "Error adding payment. Detail: " + peltrade.GetLastError(1);
					}
				}
				else
				{
					text = "Start Bon error. Details: " + peltrade.GetLastError(1);
				}
			}
			else
			{
				text = "Fiscal Device initialisation Error. Detail: " + peltrade.GetLastError(1);
			}
			return text;
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00263474 File Offset: 0x00261674
		private int GetVATGroup(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select TaxRate  from products where productid = " + productid.ToString();
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Operators.ConditionalCompareObjectGreater(dataRow["TaxRate"], 0, false);
				if (flag2)
				{
					num2 = 2;
				}
				else
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 1;
			}
			return num2;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00263514 File Offset: 0x00261714
		private void Button16_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = decimal.Compare(this.currenttaxrate, 0m) > 0;
				decimal num;
				if (flag)
				{
					bool flag2 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
					if (flag2)
					{
						num = this.specialprice;
						this.priceb4tax = decimal.Divide(this.specialprice, decimal.Add(1m, decimal.Divide(this.currenttaxrate, 100m)));
					}
					else
					{
						this.priceb4tax = this.specialprice;
						num = decimal.Multiply(this.specialprice, decimal.Add(1m, decimal.Divide(this.currenttaxrate, 100m)));
					}
				}
				else
				{
					num = this.specialprice;
					this.priceb4tax = num;
				}
				this.txtPrice.Text = Conversions.ToString(decimal.Multiply(num, this.mono_rate));
				MessageBox.Show("Special Price applied. If payment method is changed- special price is removed.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error using special price. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x00263638 File Offset: 0x00261838
		private void Button16_Click_1(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				MyProject.Forms.Form1.PendingItemsDAT = dataTable;
				PendingInvoices pendingInvoices = new PendingInvoices();
				pendingInvoices.ShowDialog(this);
				pendingInvoices.Dispose();
				bool flag = MyProject.Forms.Form1.PendingItemsDAT.Rows.Count > 0;
				if (flag)
				{
					this.LoadCustomers();
					this.@ref = MyProject.Forms.Form1.ref2;
					this.lblRef.Text = this.@ref;
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.custid, "Cash", false) == 0;
					if (!flag2)
					{
						this.FetchCustomer(MyProject.Forms.Form1.custid);
					}
					this.DataGridView1.Rows.Clear();
					DataRow dataRow = MyProject.Forms.Form1.PendingItemsDAT.Rows[0];
					this.cboConsultant.SelectedIndex = this.cboConsultant.FindStringExact(dataRow["consultant"].ToString());
					this.cboPayMeth.SelectedIndex = this.cboPayMeth.FindStringExact(MyProject.Forms.Form1.pendinginv_paymethodid);
					try
					{
						foreach (object obj in MyProject.Forms.Form1.PendingItemsDAT.Rows)
						{
							DataRow dataRow2 = (DataRow)obj;
							string[] array = new string[]
							{
								Conversions.ToString(dataRow2["ProductID"]),
								Conversions.ToString(dataRow2["ProductCode"]),
								Conversions.ToString(dataRow2["productdesc"]),
								Conversions.ToString(dataRow2["UnitPrice"]),
								Conversions.ToString(dataRow2["Quantity"]),
								Conversions.ToString(dataRow2["Tax"]),
								Conversions.ToString(dataRow2["Total"]),
								Conversions.ToString(dataRow2["Col1"]),
								Conversions.ToString(dataRow2["CouponNumber"]),
								Conversions.ToString(dataRow2["OldPrice"]),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["pricechange"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["pricechange"]))),
								Conversions.ToString(dataRow2["isairtime"]),
								Conversions.ToString(dataRow2["MNO"]),
								Conversions.ToString(dataRow2["iswholesaleprice"]),
								Conversions.ToString(dataRow2["wholesaleqtydiscount"]),
								"",
								"",
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["DiscountAmt"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["DiscountAmt"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BatchNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow2["BatchNumber"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["ExpiryDate"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["ExpiryDate"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Taxr"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["Taxr"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["promstatus"])), "", RuntimeHelpers.GetObjectValue(dataRow2["promstatus"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["OtherDetail"])), "", RuntimeHelpers.GetObjectValue(dataRow2["OtherDetail"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["isvoucher"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["isvoucher"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Comments"])), "", RuntimeHelpers.GetObjectValue(dataRow2["Comments"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["rownumber"])), "", RuntimeHelpers.GetObjectValue(dataRow2["rownumber"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["uom"])), "", RuntimeHelpers.GetObjectValue(dataRow2["uom"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["break"])), "0", RuntimeHelpers.GetObjectValue(dataRow2["break"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["breakqty"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["breakqty"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BreakParentProductID"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["BreakParentProductID"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["ActualBreakQty"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["ActualBreakQty"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["taxexempt"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["altdesc"])), "", RuntimeHelpers.GetObjectValue(dataRow2["altdesc"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["hscode"])), "", RuntimeHelpers.GetObjectValue(dataRow2["hscode"])))
							};
							this.DataGridView1.Rows.Add(array);
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
					bool flag3 = MyProject.Forms.Form1.PendingItemsDAT.Rows.Count > 0;
					if (flag3)
					{
						bool flag4 = MyProject.Forms.Form1.DisableEditingPendingInv == 1;
						if (flag4)
						{
							this.DisableEditing = true;
							this.DataGridView1.Enabled = false;
						}
					}
					MyProject.Forms.Form1.PendingItemsDAT.Clear();
					MessageBox.Show("Quotation Loaded.");
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
			catch (Exception ex)
			{
				MessageBox.Show("Failed to show saved quotations. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x00263E84 File Offset: 0x00262084
		private void GetBarcodeScaleSettings()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BarcodeScaleSettingsSelect";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			bool flag = Conversions.ToBoolean(dataRow["hasweight"]);
			if (flag)
			{
				this.BCweightlength = Conversions.ToInteger(dataRow["WeightLength"]);
				this.BCweightstartposition = Conversions.ToInteger(dataRow["WeightStartPosition"]);
			}
			else
			{
				this.BCpricelength = Conversions.ToInteger(dataRow["PriceLength"]);
				this.BCpricestartposition = Conversions.ToInteger(dataRow["PriceStartPosition"]);
			}
			this.BCcodestartposition = Conversions.ToInteger(dataRow["CodeStartPosition"]);
			this.BCcodelength = Conversions.ToInteger(dataRow["CodeLength"]);
			this.BCstartchar = Conversions.ToInteger(dataRow["startchar"]);
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x00263FE0 File Offset: 0x002621E0
		private DataRow GetButcheryProductDetails(string barcode)
		{
			DataRow dataRow = new DataTable
			{
				Columns = 
				{
					{
						"productcode",
						typeof(string)
					},
					{
						"productqty",
						typeof(decimal)
					},
					{
						"isvalidbutchery",
						typeof(int)
					},
					{
						"productprice",
						typeof(decimal)
					},
					{
						"use_price_from_scale",
						typeof(int)
					}
				}
			}.NewRow();
			DataRow dataRow2;
			try
			{
				this.GetBarcodeScaleSettings();
				string text = barcode.Substring(0, 1);
				bool flag = Conversions.ToDouble(text) == (double)this.BCstartchar;
				if (flag)
				{
					bool flag2 = MyProject.Forms.Form1.BarcodePrintingScaleWeight == 1;
					if (flag2)
					{
						string text2 = barcode.Substring(this.BCcodestartposition, this.BCcodelength);
						dataRow[4] = 0;
						dataRow[0] = text2;
						string text3 = barcode.Substring(this.BCweightstartposition, this.BCweightlength);
						bool flag3 = this.BCweightlength == 5;
						int num;
						if (flag3)
						{
							num = 1000;
						}
						else
						{
							bool flag4 = this.BCweightlength == 4;
							if (flag4)
							{
								num = 100;
							}
						}
						decimal num2 = decimal.Divide(Conversions.ToDecimal(text3), new decimal(num));
						dataRow[1] = Math.Round(num2, 4);
						dataRow[2] = 1;
						dataRow[3] = 0;
						dataRow2 = dataRow;
					}
					else
					{
						bool flag5 = MyProject.Forms.Form1.BarcodePrintingScalePrice == 1;
						if (flag5)
						{
							dataRow[4] = 1;
							string text4 = barcode.Substring(this.BCcodestartposition, this.BCcodelength);
							DataTable dataTable = this.FetchProductDetailsbyCode(text4);
							DataRow dataRow3 = dataTable.Rows[0];
							decimal num3 = Conversions.ToDecimal(dataRow3["SellingPrice"]);
							string text5 = barcode.Substring(this.BCpricestartposition, this.BCpricelength);
							decimal num4 = Conversions.ToDecimal(text5);
							num4 = Math.Round(decimal.Divide(num4, 100m), 2);
							string text6 = Conversions.ToString(dataRow3["UOM"]);
							bool flag6 = Operators.CompareString(text6, "EA", false) == 0;
							decimal num5;
							if (flag6)
							{
								num5 = 1m;
							}
							else
							{
								num5 = Math.Round(decimal.Divide(num4, num3), 5);
							}
							dataRow[0] = text4;
							dataRow[1] = num5;
							dataRow[2] = 1;
							dataRow[3] = num4;
							dataRow2 = dataRow;
						}
					}
				}
				else
				{
					dataRow[0] = " Then0";
					dataRow[1] = 0;
					dataRow[2] = 0;
					dataRow2 = dataRow;
				}
			}
			catch (Exception ex)
			{
				dataRow[0] = "0";
				dataRow[1] = 0;
				dataRow[2] = 0;
				dataRow2 = dataRow;
			}
			return dataRow2;
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x00264338 File Offset: 0x00262538
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

		// Token: 0x060040E5 RID: 16613 RVA: 0x002643F0 File Offset: 0x002625F0
		private void Button18_Click(object sender, EventArgs e)
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
					int num;
					sqlCommand.Parameters.AddWithValue("quotation_num", num);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
					num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
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
							sqlCommand.Parameters.AddWithValue("paymentmethod", MyProject.Forms.Form1.basecurrency);
							sqlCommand.Parameters.AddWithValue("quotationnumber", num);
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
					new Quotation
					{
						quotationnumber = num
					}.Show();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error generating quotation. Detail: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("There are no items to save.");
			}
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x00264824 File Offset: 0x00262A24
		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "btnComments", false) == 0;
					if (flag2)
					{
						ProductOrderComments productOrderComments = new ProductOrderComments();
						productOrderComments.productid = Conversions.ToInteger(this.DataGridView1.Rows[e.RowIndex].Cells["ProdtID"].Value);
						bool flag3 = productOrderComments.ShowDialog() == DialogResult.OK;
						if (flag3)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["Comments"].Value = productOrderComments.comment;
							bool flag4 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
							if (flag4)
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
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00264978 File Offset: 0x00262B78
		private void txtPrice_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					bool flag2 = Conversion.Val(this.txtQty.Text) > 0.0;
					if (flag2)
					{
						this.EnterItem();
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

		// Token: 0x060040E8 RID: 16616 RVA: 0x002649F0 File Offset: 0x00262BF0
		private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00264A3C File Offset: 0x00262C3C
		private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Qty", false) == 0;
				if (flag)
				{
					this.currentDGVRowIndex = e.RowIndex;
					DataTable prodtDetails = this.GetProdtDetails(MyProject.Forms.Form1.coid, Conversions.ToInteger(this.DataGridView1.Rows[e.RowIndex].Cells["ProdtID"].Value));
					int count = prodtDetails.Rows.Count;
					bool flag2 = count > 0;
					if (!flag2)
					{
						MessageBox.Show("Product not found. Input error.");
						return;
					}
					DataRow dataRow = prodtDetails.Rows[0];
					int num = Conversions.ToInteger(dataRow["caseparentproductid"]);
					decimal num2 = Conversions.ToDecimal(this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value);
					int num3 = Convert.ToInt32(this.pf.GetStockAvailable(this._cnn, Conversions.ToInteger(this.DataGridView1.Rows[e.RowIndex].Cells["ProdtID"].Value), this.DataGridView1, "EA", 0, 0, false, "", 0, true));
					bool flag3 = MyProject.Forms.Form1.NegativeStock == 0;
					if (flag3)
					{
						bool flag4 = (MyProject.Forms.Form1.autoBreakCase == 1) & (decimal.Compare(new decimal(num3), num2) < 0);
						if (flag4)
						{
							DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, num, this._cnn);
							bool flag5 = productDetails == null;
							if (flag5)
							{
								this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value = this.currentQty;
								MessageBox.Show("Parent Product NOT FOUND.");
								return;
							}
							int num4 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])), 0, RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])));
							bool flag6 = num4 == 0;
							if (flag6)
							{
								this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value = this.currentQty;
								MessageBox.Show("Parent case quantity is zero. Cannot proceed.");
								return;
							}
							int num5 = Convert.ToInt32(this.pf.GetStockAvailable(this._cnn, num, this.DataGridView1, "EA", 0, 0, false, "", 0, false));
							bool flag7 = decimal.Compare(new decimal(checked(num5 * num4 + num3)), num2) >= 0;
							if (!flag7)
							{
								this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value = this.currentQty;
								MessageBox.Show("Cannot edit quantity to result in negative stock of Parent Child setup.");
								return;
							}
							this.BreakQtyActual = Convert.ToInt32(Math.Ceiling(decimal.Divide(decimal.Subtract(num2, new decimal(num3)), new decimal(num4))));
							this.DataGridView1.Rows[e.RowIndex].Cells["Break"].Value = 1;
							this.DataGridView1.Rows[e.RowIndex].Cells["BreakQty"].Value = num4;
							this.DataGridView1.Rows[e.RowIndex].Cells["BreakParentProductID"].Value = num;
							this.DataGridView1.Rows[e.RowIndex].Cells["ActualBreakQty"].Value = this.BreakQtyActual;
						}
						else
						{
							bool flag8 = num3 < 0;
							if (flag8)
							{
								this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value = this.currentQty;
								MessageBox.Show("Cannot edit quantity to result in negative stock.");
								return;
							}
						}
					}
					bool flag9 = decimal.Compare(num2, this.currentQty) == 0;
					if (flag9)
					{
						return;
					}
					bool flag10 = decimal.Compare(num2, 0m) == 0;
					if (flag10)
					{
						this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value = this.currentQty;
						try
						{
							foreach (object obj in this.DataGridView1.SelectedRows)
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								dataGridViewRow.Selected = false;
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
						this.DataGridView1.Rows[e.RowIndex].Selected = true;
						this.DataGridView1.Rows.Remove(this.DataGridView1.SelectedRows[0]);
						return;
					}
					int num6 = 0;
					object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscDetails"].Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscPaymethod"].Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value);
					decimal num7 = Conversions.ToDecimal(dataRow["TaxRate"]);
					bool flag11 = Operators.ConditionalCompareObjectNotEqual(objectValue3, 0, false);
					if (flag11)
					{
						bool flag12 = objectValue.ToString().Contains("Payment Method Discount");
						if (flag12)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Operators.AddObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value)) * -1.0);
							this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value = 0;
						}
						else
						{
							num6 = 1;
						}
					}
					bool flag13 = Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[e.RowIndex].Cells["Promstatus"].Value, 3, false);
					DataRow dataRow2;
					if (flag13)
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
						dataRow2 = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(this.DataGridView1.Rows[e.RowIndex].Cells["ProdtID"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
					}
					bool flag14 = Operators.ConditionalCompareObjectNotEqual(dataRow2["disc"], 0, false);
					if (flag14)
					{
						this.PaymentMethodDiscountEffected = 1;
						this.DataGridView1.Rows[e.RowIndex].Cells["CouponNumber"].Value = 1;
						this.DataGridView1.Rows[e.RowIndex].Cells["OldPrice"].Value = RuntimeHelpers.GetObjectValue(dataRow2["oldprice"]);
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
						decimal num8 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])));
						this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscDetails"].Value = "Payment Method Discount";
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscPaymethod"].Value = RuntimeHelpers.GetObjectValue(dataRow2["paymethod"]);
						bool flag15 = decimal.Compare(num7, 0m) != 0;
						if (flag15)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value = Operators.MultiplyObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, decimal.Add(1m, decimal.Divide(num7, 100m)));
						}
						else
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value = 0;
						}
						this.DataGridView1.Rows[e.RowIndex].Cells["UnitCost"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["UnitCost"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate), 2, MidpointRounding.AwayFromZero);
						this.DataGridView1.Rows[e.RowIndex].Cells["Total"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.AddObject(Operators.MultiplyObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value), this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value),
							2,
							MidpointRounding.AwayFromZero
						}, null, null, null));
					}
					else
					{
						bool flag16 = num6 == 0;
						if (flag16)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["CouponNumber"].Value = 0;
							this.DataGridView1.Rows[e.RowIndex].Cells["DiscDetails"].Value = "";
						}
						decimal num9 = Conversions.ToDecimal(dataRow["wholesaleqty"]);
						bool flag17 = (MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1) & (Convert.ToDouble(num9) >= Conversions.ToDouble(this.txtQty.Text));
						decimal num10;
						if (flag17)
						{
							num10 = Conversions.ToDecimal(dataRow["SellingPriceWholesale"]);
						}
						else
						{
							num10 = Conversions.ToDecimal(dataRow["SellingPrice"]);
						}
						bool flag18 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
						if (flag18)
						{
							num10 = Conversions.ToDecimal(Operators.DivideObject(num10, Operators.AddObject(1, Operators.DivideObject(dataRow["TaxRate"], 100))));
						}
						bool flag19 = MyProject.Forms.Form1.CalcBackwards == 1;
						ref int ptr;
						object[] array2;
						bool[] array6;
						object obj4;
						if (flag19)
						{
							object obj2 = num10;
							object obj3 = null;
							Type typeFromHandle = typeof(Math);
							string text = "Round";
							object[] array = new object[3];
							array[0] = Operators.MultiplyObject(Operators.DivideObject(dataRow["TaxRate"], 100), num10);
							int num11 = 1;
							Form1 form = MyProject.Forms.Form1;
							ptr = ref form.DecimalPlaces;
							array[num11] = form.DecimalPlaces;
							array[2] = MidpointRounding.AwayFromZero;
							array2 = array;
							string[] array3 = null;
							Type[] array4 = null;
							bool[] array5 = new bool[3];
							array5[1] = true;
							array6 = array5;
							obj4 = NewLateBinding.LateGet(obj3, typeFromHandle, text, array, array3, array4, array5);
							if (array6[1])
							{
								ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
							}
							decimal num12 = Conversions.ToDecimal(Operators.MultiplyObject(Operators.AddObject(obj2, obj4), this.mono_rate));
							decimal num13 = Conversions.ToDecimal(Operators.DivideObject(num12, Operators.AddObject(1, Operators.DivideObject(dataRow["TaxRate"], 100))));
							decimal num14 = Conversions.ToDecimal(Operators.MultiplyObject(decimal.Subtract(num12, num13), this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value));
							this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Math.Round(num13, 4, MidpointRounding.AwayFromZero);
							this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value = Math.Round(num14, 4, MidpointRounding.AwayFromZero);
						}
						else
						{
							decimal num12 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(num10), this.mono_rate), dataRow2["disc"]));
							this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Math.Round(num12, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
							int decimalPlaces = MyProject.Forms.Form1.DecimalPlaces;
							DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[e.RowIndex].Cells["Tax"];
							object obj5 = null;
							Type typeFromHandle2 = typeof(Math);
							string text2 = "Round";
							object[] array7 = new object[3];
							array7[0] = Operators.MultiplyObject(decimal.Divide(num7, 100m), this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value);
							int num15 = 1;
							Form1 form2 = MyProject.Forms.Form1;
							ptr = ref form2.DecimalPlaces;
							array7[num15] = form2.DecimalPlaces;
							array7[2] = MidpointRounding.AwayFromZero;
							array2 = array7;
							string[] array8 = null;
							Type[] array9 = null;
							bool[] array10 = new bool[3];
							array10[1] = true;
							array6 = array10;
							obj4 = NewLateBinding.LateGet(obj5, typeFromHandle2, text2, array7, array8, array9, array10);
							if (array6[1])
							{
								ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
							}
							dataGridViewCell.Value = Operators.MultiplyObject(obj4, this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value);
							DataGridViewCell dataGridViewCell2 = this.DataGridView1.Rows[e.RowIndex].Cells["Tax"];
							object obj6 = null;
							Type typeFromHandle3 = typeof(Math);
							string text3 = "Round";
							object[] array11 = new object[3];
							array11[0] = Operators.MultiplyObject(Operators.MultiplyObject(decimal.Divide(num7, 100m), this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value), this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value);
							int num16 = 1;
							Form1 form3 = MyProject.Forms.Form1;
							ptr = ref form3.DecimalPlaces;
							array11[num16] = form3.DecimalPlaces;
							array11[2] = MidpointRounding.AwayFromZero;
							array2 = array11;
							string[] array12 = null;
							Type[] array13 = null;
							bool[] array14 = new bool[3];
							array14[1] = true;
							array6 = array14;
							obj4 = NewLateBinding.LateGet(obj6, typeFromHandle3, text3, array11, array12, array13, array14);
							if (array6[1])
							{
								ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
							}
							dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(obj4);
						}
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate), 2, MidpointRounding.AwayFromZero);
						this.DataGridView1.Rows[e.RowIndex].Cells["OldPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["OldPrice"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
						this.DataGridView1.Rows[e.RowIndex].Cells["UnitCost"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["UnitCost"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
						object obj7 = null;
						Type typeFromHandle4 = typeof(Math);
						string text4 = "Round";
						object[] array15 = new object[3];
						array15[0] = Operators.AddObject(Operators.MultiplyObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value), this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value);
						int num17 = 1;
						Form1 form4 = MyProject.Forms.Form1;
						ptr = ref form4.DecimalPlaces;
						array15[num17] = form4.DecimalPlaces;
						array15[2] = MidpointRounding.AwayFromZero;
						array2 = array15;
						string[] array16 = null;
						Type[] array17 = null;
						bool[] array18 = new bool[3];
						array18[1] = true;
						array6 = array18;
						obj4 = NewLateBinding.LateGet(obj7, typeFromHandle4, text4, array15, array16, array17, array18);
						if (array6[1])
						{
							ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
						}
						decimal num18 = Conversions.ToDecimal(obj4);
						this.DataGridView1.Rows[e.RowIndex].Cells["Total"].Value = num18;
					}
					this.CalcTotalSale();
				}
				bool flag20 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag20)
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
			}
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x00266054 File Offset: 0x00264254
		private void Button19_Click(object sender, EventArgs e)
		{
			try
			{
				ChangeProductSold changeProductSold = new ChangeProductSold();
				changeProductSold.shift = this.lblShift.Text;
				changeProductSold.ShowDialog();
				changeProductSold.Dispose();
				this.ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Change product form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x002660C8 File Offset: 0x002642C8
		private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Qty", false) == 0;
				if (flag)
				{
					this.currentQty = Conversions.ToDecimal(this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting current qty. Detail: " + ex.Message);
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x00266178 File Offset: 0x00264378
		// (set) Token: 0x060040EE RID: 16622 RVA: 0x00266184 File Offset: 0x00264384
		private virtual DataGridViewTextBoxEditingControl txtNumeric
		{
			[CompilerGenerated]
			get
			{
				return this._txtNumeric;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNumeric_KeyDown);
				DataGridViewTextBoxEditingControl dataGridViewTextBoxEditingControl = this._txtNumeric;
				if (dataGridViewTextBoxEditingControl != null)
				{
					dataGridViewTextBoxEditingControl.KeyDown -= keyEventHandler;
				}
				this._txtNumeric = value;
				dataGridViewTextBoxEditingControl = this._txtNumeric;
				if (dataGridViewTextBoxEditingControl != null)
				{
					dataGridViewTextBoxEditingControl.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x002661C7 File Offset: 0x002643C7
		private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			this.txtNumeric = (DataGridViewTextBoxEditingControl)e.Control;
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x002661DC File Offset: 0x002643DC
		private void txtNumeric_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				string text = Conversions.ToString(this.DataGridView1.Rows[this.currentDGVRowIndex].Cells["UOM"].Value);
				bool flag = (e.KeyData >= Keys.A) & (e.KeyData <= Keys.Z);
				if (flag)
				{
					bool flag2 = (e.KeyData != Keys.Back) | (e.KeyData != Keys.Delete);
					if (flag2)
					{
						e.SuppressKeyPress = true;
						e.Handled = true;
					}
				}
				bool flag3 = Operators.CompareString(text, "EA", false) == 0;
				if (flag3)
				{
					bool flag4 = !((e.KeyData >= Keys.D0) & (e.KeyData <= Keys.D9));
					if (flag4)
					{
						bool flag5 = (e.KeyData < Keys.NumPad0) & (e.KeyData <= Keys.NumPad9);
						if (flag5)
						{
							bool flag6 = e.KeyData != Keys.Back;
							if (flag6)
							{
								bool flag7 = e.KeyData != Keys.Delete;
								if (flag7)
								{
									e.SuppressKeyPress = true;
									e.Handled = true;
								}
							}
						}
					}
				}
				else
				{
					bool flag8 = !((e.KeyData >= Keys.D0) & (e.KeyData <= Keys.D9));
					if (flag8)
					{
						bool flag9 = e.KeyData != Keys.OemPeriod;
						if (flag9)
						{
							bool flag10 = e.KeyData != Keys.Back;
							if (flag10)
							{
								bool flag11 = e.KeyData != Keys.Delete;
								if (flag11)
								{
									bool flag12 = (e.KeyData < Keys.NumPad0) & (e.KeyData <= Keys.NumPad9);
									if (flag12)
									{
										e.SuppressKeyPress = true;
										e.Handled = true;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_LocationChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_Invalidated(object sender, InvalidateEventArgs e)
		{
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x002663D0 File Offset: 0x002645D0
		private void Button19_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID == 0;
				if (flag)
				{
					MessageBox.Show("Please select a product first.");
					bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag2)
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
					CheckBranchStock checkBranchStock = new CheckBranchStock();
					checkBranchStock.productid = this.CurrentID;
					checkBranchStock.trandate = Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd"));
					checkBranchStock.prodcode = this.CurrentCode;
					checkBranchStock.proddesc = this.txtDesc.Text;
					checkBranchStock.ShowDialog(this);
					checkBranchStock.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error checking prices. Detail: " + ex.Message);
			}
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x002664CC File Offset: 0x002646CC
		private void txtcustomer_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.txtAddress.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x00266524 File Offset: 0x00264724
		private void txtAddress_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.txtMobile.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x0026657C File Offset: 0x0026477C
		private void txtMobile_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.txtContactName.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x002665D4 File Offset: 0x002647D4
		private void txtContactName_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.txtvatnumber.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0026662C File Offset: 0x0026482C
		private void txtvatnumber_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.txtbpnumber.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x00266684 File Offset: 0x00264884
		private void txtInvDetails1_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.txtInvDetails2.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x002666DC File Offset: 0x002648DC
		private void txtbpnumber_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.txtInvDetails1.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x00266734 File Offset: 0x00264934
		private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.approve_till_void == 1) | (MyProject.Forms.Form1.pendinginvoice_entryno != 0);
				if (flag)
				{
					ApprovalForm approvalForm = new ApprovalForm();
					approvalForm.ShowDialog();
					approvalForm.Dispose();
					bool flag2 = !MyProject.Forms.Form1.approved;
					if (flag2)
					{
						MessageBox.Show("Item void NOT approved.");
						e.Cancel = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x002667D4 File Offset: 0x002649D4
		public DataTable GetDeposits(int coid, string branch, int invnumber)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select ID,deposit_amount from deposits where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' and inv_number=",
				Conversions.ToString(invnumber)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x0026685C File Offset: 0x00264A5C
		private void txtDiscount_Leave(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotalSale();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00266894 File Offset: 0x00264A94
		private void txtPriceChange_Leave(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.DiscountApproved == 1;
				if (!flag)
				{
					bool flag2 = decimal.Compare(MyProject.Forms.Form1.MaxDiscPerc, 0m) != 0;
					if (flag2)
					{
						decimal num = decimal.Multiply(decimal.Divide(MyProject.Forms.Form1.MaxDiscPerc, 100m), Conversions.ToDecimal(this.txtPrice.Text));
						bool flag3 = decimal.Compare(Conversions.ToDecimal(this.txtPriceChange.Text), 0m) > 0;
						if (flag3)
						{
							bool flag4 = decimal.Compare(Conversions.ToDecimal(this.txtPriceChange.Text), num) > 0;
							if (flag4)
							{
								MessageBox.Show("Discount entered is greater than the maximum discount percentage allowed. Cannot proceed. Changing discount from " + this.txtPriceChange.Text + " to Zero");
								this.txtPriceChange.Text = "0";
							}
						}
						else
						{
							bool flag5 = decimal.Compare(Conversions.ToDecimal(this.txtPriceChange.Text), decimal.Multiply(num, -1m)) < 0;
							if (flag5)
							{
								MessageBox.Show("Discount entered is greater than the maximum discount percentage allowed. Cannot proceed. Changing discount from " + this.txtPriceChange.Text + " to Zero");
								this.txtPriceChange.Text = "0";
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00266A1C File Offset: 0x00264C1C
		private void Button21_Click(object sender, EventArgs e)
		{
			try
			{
				PayMethRef payMethRef = new PayMethRef();
				bool flag = payMethRef.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.altdescription = payMethRef.txtRef.Text;
					this.txtDesc.Text = this.txtDesc.Text + " " + this.altdescription;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding alternative description");
			}
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00266AA8 File Offset: 0x00264CA8
		private bool IsWeightOk()
		{
			decimal num = new decimal((Conversion.Val(this.txtQty.Text) - Conversion.Val(this.txtQtyWeighed.Text)) / Conversion.Val(this.txtQty.Text) * 100.0);
			bool flag = decimal.Compare(num, 0m) < 0;
			if (flag)
			{
				num = decimal.Multiply(num, -1m);
			}
			return decimal.Compare(num, this.scalemaxdiff) <= 0;
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtQtyWeighed_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono2_DockChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00266B3C File Offset: 0x00264D3C
		private void StartWeighedItemVerification()
		{
			try
			{
				this.txtQtyWeighed.Visible = true;
				this.Timer1.Start();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00266B88 File Offset: 0x00264D88
		private bool VerifyWieghtOk()
		{
			decimal num = new decimal((Conversion.Val(this.txtQty.Text) - Conversion.Val(this.txtQtyWeighed.Text)) / Conversion.Val(this.txtQty.Text) * 100.0);
			bool flag = decimal.Compare(num, 0m) < 0;
			if (flag)
			{
				num = decimal.Multiply(num, -1m);
			}
			return decimal.Compare(num, this.scalemaxdiff) <= 0;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GetSerialData()
		{
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00266C1C File Offset: 0x00264E1C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.txtQtyWeighed.Text = "0";
				this.GetSerialData();
				try
				{
					bool flag = this.VerifyWieghtOk();
					if (flag)
					{
						this.Timer1.Stop();
						this.txtQtyWeighed.BackColor = Color.Green;
						MessageBox.Show("Verified.");
						this.txtQtyWeighed.Text = "0";
						this.txtQtyWeighed.Visible = false;
						this.AppendGrid();
						this.CalcTotalSale();
						this.EnterItemClear();
					}
					else
					{
						this.txtQtyWeighed.BackColor = Color.OrangeRed;
					}
				}
				catch (Exception ex)
				{
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00266D00 File Offset: 0x00264F00
		private void Button20_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = this.pf.RunRevmaxDATItems(this.DataGridView1);
				string text = this.pf.BuildItemsXML(dataTable);
				MessageBox.Show(text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00266D58 File Offset: 0x00264F58
		private void txtQty_Validating(object sender, CancelEventArgs e)
		{
			try
			{
				bool flag = !this.txtQty.Text.Contains(".");
				if (flag)
				{
					string text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "MaxSellingQty", MyProject.Forms.Form1.Constring);
					bool flag2 = (Operators.CompareString(text, "0", false) != 0) & (Operators.CompareString(text, "", false) != 0);
					if (flag2)
					{
						bool flag3 = Conversion.Val(this.txtQty.Text) >= Conversion.Val(text);
						if (flag3)
						{
							MessageBox.Show("Sale invoice quantity is above limit of " + text.ToString());
							this.txtQty.Text = Conversions.ToString(0);
							e.Cancel = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00266E60 File Offset: 0x00265060
		private void Button20_Click_1(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = this.pf.RunRevmaxDATItems(this.DataGridView1);
				decimal num = new decimal(Conversion.Val(this.txtTotal.Text) - Conversion.Val(this.txtTax.Text));
				string text = this.pf.BuildItemsXML(dataTable);
				string text2 = this.pf.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
				MessageBox.Show(text);
				MessageBox.Show(text2);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex.Message);
			}
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtPrice_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00266F28 File Offset: 0x00265128
		private void txtPrice_Leave(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.AllowDirectPriceEditing == 1;
				if (flag)
				{
					bool flag2 = decimal.Compare(this.currenttaxrate, 0m) != 0;
					if (flag2)
					{
						this.priceb4tax = new decimal(Math.Round(Conversion.Val(this.txtPrice.Text) / Convert.ToDouble(decimal.Add(1m, decimal.Divide(this.currenttaxrate, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
					}
					else
					{
						this.priceb4tax = new decimal(Conversion.Val(this.txtPrice.Text));
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00267000 File Offset: 0x00265200
		private void txtcustomer_Leave(object sender, EventArgs e)
		{
			try
			{
				this.FetchCustomer(this.txtcustomer.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00267044 File Offset: 0x00265244
		private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			bool flag = e.RowIndex >= 0;
			if (flag)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["Break"].Value);
				bool flag2 = objectValue != null && Operators.CompareString(objectValue.ToString(), "1", false) == 0;
				if (flag2)
				{
					e.Cancel = true;
				}
			}
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x002670BC File Offset: 0x002652BC
		private void DeleteSelectedRow()
		{
			bool flag = this.DataGridView1.SelectedRows.Count > 0;
			if (flag)
			{
				bool flag2 = MyProject.Forms.Form1.IsAdmin | MyProject.Forms.Form1.IsSupervisor;
				if (flag2)
				{
					DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					bool flag3 = dialogResult == DialogResult.Yes;
					if (flag3)
					{
						this.DataGridView1.Rows.Remove(this.DataGridView1.SelectedRows[0]);
						this.CalcTotalSale();
					}
				}
				else
				{
					bool flag4 = Operators.CompareString(this.lblRef.Text, "...", false) != 0;
					if (flag4)
					{
						MessageBox.Show("Cannot delete. Check with your supervisor.");
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00267198 File Offset: 0x00265398
		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.DataGridView1.SelectedRows.Count == 1;
			if (flag)
			{
				this.DeleteSelectedRow();
			}
		}

		// Token: 0x04001BB5 RID: 7093
		private decimal receiptpaymethrate;

		// Token: 0x04001BB6 RID: 7094
		private string altdescription;

		// Token: 0x04001BB7 RID: 7095
		private string _cnn;

		// Token: 0x04001BB8 RID: 7096
		private PublicFunctions pf;

		// Token: 0x04001BB9 RID: 7097
		private int CurrentID;

		// Token: 0x04001BBA RID: 7098
		private string CurrentCode;

		// Token: 0x04001BBB RID: 7099
		private string CurrentHSCode;

		// Token: 0x04001BBC RID: 7100
		private string TextToPrint;

		// Token: 0x04001BBD RID: 7101
		private string coname;

		// Token: 0x04001BBE RID: 7102
		private string coadd;

		// Token: 0x04001BBF RID: 7103
		private string coadd2;

		// Token: 0x04001BC0 RID: 7104
		private string cotel;

		// Token: 0x04001BC1 RID: 7105
		private string coemail;

		// Token: 0x04001BC2 RID: 7106
		private string cobpnum;

		// Token: 0x04001BC3 RID: 7107
		private string footnote;

		// Token: 0x04001BC4 RID: 7108
		private string cotel2;

		// Token: 0x04001BC5 RID: 7109
		private string cotel3;

		// Token: 0x04001BC6 RID: 7110
		private string coVATNum;

		// Token: 0x04001BC7 RID: 7111
		private string bpnum_name;

		// Token: 0x04001BC8 RID: 7112
		private string vatnum_name;

		// Token: 0x04001BC9 RID: 7113
		private string coname_og;

		// Token: 0x04001BCA RID: 7114
		private string coadd_og;

		// Token: 0x04001BCB RID: 7115
		private string coadd2_og;

		// Token: 0x04001BCC RID: 7116
		private string cotel_og;

		// Token: 0x04001BCD RID: 7117
		private string coemail_og;

		// Token: 0x04001BCE RID: 7118
		private string cobpnum_og;

		// Token: 0x04001BCF RID: 7119
		private string footnote_og;

		// Token: 0x04001BD0 RID: 7120
		private string cotel2_og;

		// Token: 0x04001BD1 RID: 7121
		private string cotel3_og;

		// Token: 0x04001BD2 RID: 7122
		private string coVATNum_og;

		// Token: 0x04001BD3 RID: 7123
		private string bpnum_name_og;

		// Token: 0x04001BD4 RID: 7124
		private string vatnum_name_og;

		// Token: 0x04001BD5 RID: 7125
		private string website_og;

		// Token: 0x04001BD6 RID: 7126
		private string website_comment;

		// Token: 0x04001BD7 RID: 7127
		private int invnum;

		// Token: 0x04001BD8 RID: 7128
		private double currprice;

		// Token: 0x04001BD9 RID: 7129
		private bool Match;

		// Token: 0x04001BDA RID: 7130
		private DataTable datCustomers;

		// Token: 0x04001BDB RID: 7131
		private int m_currentPageIndex;

		// Token: 0x04001BDC RID: 7132
		private IList<Stream> m_streams;

		// Token: 0x04001BDD RID: 7133
		private decimal priceb4tax;

		// Token: 0x04001BDE RID: 7134
		private decimal priceb4taxWholesale;

		// Token: 0x04001BDF RID: 7135
		private decimal currentWholesaleQty;

		// Token: 0x04001BE0 RID: 7136
		private decimal taxdueWholesale;

		// Token: 0x04001BE1 RID: 7137
		private decimal totpriceWholesale;

		// Token: 0x04001BE2 RID: 7138
		private int WholesalePriceByQty;

		// Token: 0x04001BE3 RID: 7139
		private decimal specialprice;

		// Token: 0x04001BE4 RID: 7140
		private decimal currenttaxrate;

		// Token: 0x04001BE5 RID: 7141
		private decimal mono_rate;

		// Token: 0x04001BE6 RID: 7142
		private string og_customername;

		// Token: 0x04001BE7 RID: 7143
		private string og_address;

		// Token: 0x04001BE8 RID: 7144
		private string og_contactname;

		// Token: 0x04001BE9 RID: 7145
		private string og_mobile;

		// Token: 0x04001BEA RID: 7146
		private string og_email;

		// Token: 0x04001BEB RID: 7147
		private string og_tel;

		// Token: 0x04001BEC RID: 7148
		private string og_invdetail1;

		// Token: 0x04001BED RID: 7149
		private string og_invdetail2;

		// Token: 0x04001BEE RID: 7150
		private string og_vatnumber;

		// Token: 0x04001BEF RID: 7151
		private string og_bpnumber;

		// Token: 0x04001BF0 RID: 7152
		private int TexttoPrintLen;

		// Token: 0x04001BF1 RID: 7153
		private int discPaymentMethod;

		// Token: 0x04001BF2 RID: 7154
		private int isInvoiceDisc;

		// Token: 0x04001BF3 RID: 7155
		private decimal discAmount;

		// Token: 0x04001BF4 RID: 7156
		private decimal discTeller;

		// Token: 0x04001BF5 RID: 7157
		private decimal discCoupons;

		// Token: 0x04001BF6 RID: 7158
		private decimal discPromotion;

		// Token: 0x04001BF7 RID: 7159
		private string discPromotionName;

		// Token: 0x04001BF8 RID: 7160
		private string discDESC;

		// Token: 0x04001BF9 RID: 7161
		private string currentUOM;

		// Token: 0x04001BFA RID: 7162
		private bool currentExpires;

		// Token: 0x04001BFB RID: 7163
		private bool CurrentIsVoucher;

		// Token: 0x04001BFC RID: 7164
		private int currentIsDeposit;

		// Token: 0x04001BFD RID: 7165
		private StringReader stringToRead;

		// Token: 0x04001BFE RID: 7166
		private decimal paymeth_rate;

		// Token: 0x04001BFF RID: 7167
		private int paymeth_fiscalgroup;

		// Token: 0x04001C00 RID: 7168
		private string paymeth_desc;

		// Token: 0x04001C01 RID: 7169
		private string paymeth_currency;

		// Token: 0x04001C02 RID: 7170
		private bool paymeth_requiresref;

		// Token: 0x04001C03 RID: 7171
		private DataTable datProm;

		// Token: 0x04001C04 RID: 7172
		private int PaymentMethodDiscountEffected;

		// Token: 0x04001C05 RID: 7173
		private bool isunedingstock;

		// Token: 0x04001C06 RID: 7174
		private int currentCustomerEntryNo;

		// Token: 0x04001C07 RID: 7175
		private decimal currentCustomerLimit;

		// Token: 0x04001C08 RID: 7176
		private int BCweightlength;

		// Token: 0x04001C09 RID: 7177
		private int BCweightstartposition;

		// Token: 0x04001C0A RID: 7178
		private int BCpricelength;

		// Token: 0x04001C0B RID: 7179
		private int BCpricestartposition;

		// Token: 0x04001C0C RID: 7180
		private int BCcodestartposition;

		// Token: 0x04001C0D RID: 7181
		private int BCcodelength;

		// Token: 0x04001C0E RID: 7182
		private int BCstartchar;

		// Token: 0x04001C0F RID: 7183
		private int RowID;

		// Token: 0x04001C10 RID: 7184
		private bool saledone;

		// Token: 0x04001C11 RID: 7185
		private decimal currentQty;

		// Token: 0x04001C12 RID: 7186
		private int currentDGVRowIndex;

		// Token: 0x04001C13 RID: 7187
		private bool currentIsCalcLxW;

		// Token: 0x04001C14 RID: 7188
		private string currComment;

		// Token: 0x04001C15 RID: 7189
		private int currParentCaseID;

		// Token: 0x04001C16 RID: 7190
		private int currCaseQty;

		// Token: 0x04001C17 RID: 7191
		private int currBreak;

		// Token: 0x04001C18 RID: 7192
		private int BreakQtyActual;

		// Token: 0x04001C19 RID: 7193
		private int currQuotationNumber;

		// Token: 0x04001C1A RID: 7194
		private string LINE;

		// Token: 0x04001C1B RID: 7195
		private int current_taxexempt;

		// Token: 0x04001C1C RID: 7196
		private string currCustomerGroup;

		// Token: 0x04001C1D RID: 7197
		private decimal ProdtDiscTotal;

		// Token: 0x04001C1E RID: 7198
		private string DepositBarCode;

		// Token: 0x04001C1F RID: 7199
		private bool DepositUsed;

		// Token: 0x04001C20 RID: 7200
		private decimal DepAmount;

		// Token: 0x04001C21 RID: 7201
		private bool DisableEditing;

		// Token: 0x04001C22 RID: 7202
		private string @ref;

		// Token: 0x04001C23 RID: 7203
		private DataTable dat_additionalsettings;

		// Token: 0x04001C24 RID: 7204
		private int desc_spacing;

		// Token: 0x04001C25 RID: 7205
		private int qty_spacing;

		// Token: 0x04001C26 RID: 7206
		private int unitprice_spacing;

		// Token: 0x04001C27 RID: 7207
		private int total_spacing;

		// Token: 0x04001C28 RID: 7208
		private int tax_spacing;

		// Token: 0x04001C29 RID: 7209
		private decimal scalemaxdiff;

		// Token: 0x04001C2A RID: 7210
		private DataTable DTpromos;

		// Token: 0x04001C2B RID: 7211
		private bool currentIsWeighed;

		// Token: 0x04001C2C RID: 7212
		private PublicFunctions2 pf2;

		// Token: 0x04001C2D RID: 7213
		private Bitmap QRCodeVariable;

		// Token: 0x04001C2E RID: 7214
		private string qrveri_code;

		// Token: 0x04001C2F RID: 7215
		private string qrveri_link;

		// Token: 0x04001C30 RID: 7216
		private string zimra_invnum;

		// Token: 0x04001C31 RID: 7217
		private string fiscalday_number;

		// Token: 0x04001C32 RID: 7218
		private string deviceno;

		// Token: 0x04001C33 RID: 7219
		private string receiptGlobalNo;

		// Token: 0x04001C34 RID: 7220
		private int isLxW;

		// Token: 0x04001C35 RID: 7221
		private bool CurrentRecordSerial;

		// Token: 0x04001C36 RID: 7222
		private decimal PriceBeforeTax;

		// Token: 0x04001C37 RID: 7223
		private bool currentIsEditable;
	}
}
