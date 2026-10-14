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
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using BarcodeRender;
using EltradeFPAx;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using RJCP.IO.Ports;
using Zen.Barcode;

namespace PointOfSale
{
	// Token: 0x0200018B RID: 395
	[DesignerGenerated]
	public partial class Sales2mono : UserControl
	{
		// Token: 0x06003CA3 RID: 15523 RVA: 0x00215BDC File Offset: 0x00213DDC
		public Sales2mono()
		{
			base.Load += this.Sales_c;
			base.Disposed += this.Sales2mono_Disposed;
			base.LocationChanged += this.Sales2mono_LocationChanged;
			base.Invalidated += this.Sales2mono_Invalidated;
			base.Enter += this.Sales2mono_Enter;
			base.Leave += this.Sales2mono_Leave;
			this.s = new SerialPortStream("COM" + Conversions.ToString(MyProject.Forms.Form1.ConnectedScalePortNum), 115200, 8, RJCP.IO.Ports.Parity.None, RJCP.IO.Ports.StopBits.One);
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.TextToPrint = "";
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
			this.txtNumeric = new DataGridViewTextBoxEditingControl();
			this.InitializeComponent();
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06003CA6 RID: 15526 RVA: 0x0021D551 File Offset: 0x0021B751
		// (set) Token: 0x06003CA7 RID: 15527 RVA: 0x0021D55B File Offset: 0x0021B75B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x0021D564 File Offset: 0x0021B764
		// (set) Token: 0x06003CA9 RID: 15529 RVA: 0x0021D570 File Offset: 0x0021B770
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

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06003CAA RID: 15530 RVA: 0x0021D5B3 File Offset: 0x0021B7B3
		// (set) Token: 0x06003CAB RID: 15531 RVA: 0x0021D5C0 File Offset: 0x0021B7C0
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

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x0021D603 File Offset: 0x0021B803
		// (set) Token: 0x06003CAD RID: 15533 RVA: 0x0021D60D File Offset: 0x0021B80D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06003CAE RID: 15534 RVA: 0x0021D616 File Offset: 0x0021B816
		// (set) Token: 0x06003CAF RID: 15535 RVA: 0x0021D620 File Offset: 0x0021B820
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
				TextBox textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPrice = value;
				textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x0021D67E File Offset: 0x0021B87E
		// (set) Token: 0x06003CB1 RID: 15537 RVA: 0x0021D688 File Offset: 0x0021B888
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x0021D691 File Offset: 0x0021B891
		// (set) Token: 0x06003CB3 RID: 15539 RVA: 0x0021D69C File Offset: 0x0021B89C
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
				TextBox textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtQty = value;
				textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06003CB4 RID: 15540 RVA: 0x0021D715 File Offset: 0x0021B915
		// (set) Token: 0x06003CB5 RID: 15541 RVA: 0x0021D71F File Offset: 0x0021B91F
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x0021D728 File Offset: 0x0021B928
		// (set) Token: 0x06003CB7 RID: 15543 RVA: 0x0021D732 File Offset: 0x0021B932
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x0021D73B File Offset: 0x0021B93B
		// (set) Token: 0x06003CB9 RID: 15545 RVA: 0x0021D745 File Offset: 0x0021B945
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06003CBA RID: 15546 RVA: 0x0021D74E File Offset: 0x0021B94E
		// (set) Token: 0x06003CBB RID: 15547 RVA: 0x0021D758 File Offset: 0x0021B958
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06003CBC RID: 15548 RVA: 0x0021D761 File Offset: 0x0021B961
		// (set) Token: 0x06003CBD RID: 15549 RVA: 0x0021D76B File Offset: 0x0021B96B
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06003CBE RID: 15550 RVA: 0x0021D774 File Offset: 0x0021B974
		// (set) Token: 0x06003CBF RID: 15551 RVA: 0x0021D77E File Offset: 0x0021B97E
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x0021D787 File Offset: 0x0021B987
		// (set) Token: 0x06003CC1 RID: 15553 RVA: 0x0021D794 File Offset: 0x0021B994
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

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x0021D7D7 File Offset: 0x0021B9D7
		// (set) Token: 0x06003CC3 RID: 15555 RVA: 0x0021D7E1 File Offset: 0x0021B9E1
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x0021D7EA File Offset: 0x0021B9EA
		// (set) Token: 0x06003CC5 RID: 15557 RVA: 0x0021D7F4 File Offset: 0x0021B9F4
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x0021D7FD File Offset: 0x0021B9FD
		// (set) Token: 0x06003CC7 RID: 15559 RVA: 0x0021D807 File Offset: 0x0021BA07
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x0021D810 File Offset: 0x0021BA10
		// (set) Token: 0x06003CC9 RID: 15561 RVA: 0x0021D81A File Offset: 0x0021BA1A
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x0021D823 File Offset: 0x0021BA23
		// (set) Token: 0x06003CCB RID: 15563 RVA: 0x0021D830 File Offset: 0x0021BA30
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
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow -= dataGridViewRowEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler2;
					dataGridView.CellEnter -= dataGridViewCellEventHandler3;
					dataGridView.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
					dataGridView.UserDeletingRow -= dataGridViewRowCancelEventHandler;
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
				}
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06003CCC RID: 15564 RVA: 0x0021D910 File Offset: 0x0021BB10
		// (set) Token: 0x06003CCD RID: 15565 RVA: 0x0021D91A File Offset: 0x0021BB1A
		internal virtual TextBox txtChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06003CCE RID: 15566 RVA: 0x0021D923 File Offset: 0x0021BB23
		// (set) Token: 0x06003CCF RID: 15567 RVA: 0x0021D92D File Offset: 0x0021BB2D
		internal virtual Label lblchange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x0021D936 File Offset: 0x0021BB36
		// (set) Token: 0x06003CD1 RID: 15569 RVA: 0x0021D940 File Offset: 0x0021BB40
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

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x0021D9B9 File Offset: 0x0021BBB9
		// (set) Token: 0x06003CD3 RID: 15571 RVA: 0x0021D9C3 File Offset: 0x0021BBC3
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x0021D9CC File Offset: 0x0021BBCC
		// (set) Token: 0x06003CD5 RID: 15573 RVA: 0x0021D9D8 File Offset: 0x0021BBD8
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

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x0021DA1B File Offset: 0x0021BC1B
		// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x0021DA25 File Offset: 0x0021BC25
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x0021DA2E File Offset: 0x0021BC2E
		// (set) Token: 0x06003CD9 RID: 15577 RVA: 0x0021DA38 File Offset: 0x0021BC38
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x0021DA41 File Offset: 0x0021BC41
		// (set) Token: 0x06003CDB RID: 15579 RVA: 0x0021DA4C File Offset: 0x0021BC4C
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboCustomers_KeyUp);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
					comboBox.TextChanged -= eventHandler2;
					comboBox.Leave -= eventHandler3;
					comboBox.KeyUp -= keyEventHandler;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
					comboBox.TextChanged += eventHandler2;
					comboBox.Leave += eventHandler3;
					comboBox.KeyUp += keyEventHandler;
				}
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x0021DAEC File Offset: 0x0021BCEC
		// (set) Token: 0x06003CDD RID: 15581 RVA: 0x0021DAF6 File Offset: 0x0021BCF6
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06003CDE RID: 15582 RVA: 0x0021DAFF File Offset: 0x0021BCFF
		// (set) Token: 0x06003CDF RID: 15583 RVA: 0x0021DB09 File Offset: 0x0021BD09
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x0021DB12 File Offset: 0x0021BD12
		// (set) Token: 0x06003CE1 RID: 15585 RVA: 0x0021DB1C File Offset: 0x0021BD1C
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

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x0021DB7A File Offset: 0x0021BD7A
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x0021DB84 File Offset: 0x0021BD84
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x0021DB8D File Offset: 0x0021BD8D
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x0021DB97 File Offset: 0x0021BD97
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x0021DBA0 File Offset: 0x0021BDA0
		// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x0021DBAC File Offset: 0x0021BDAC
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

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x0021DC0A File Offset: 0x0021BE0A
		// (set) Token: 0x06003CE9 RID: 15593 RVA: 0x0021DC14 File Offset: 0x0021BE14
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

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06003CEA RID: 15594 RVA: 0x0021DC57 File Offset: 0x0021BE57
		// (set) Token: 0x06003CEB RID: 15595 RVA: 0x0021DC61 File Offset: 0x0021BE61
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x0021DC6A File Offset: 0x0021BE6A
		// (set) Token: 0x06003CED RID: 15597 RVA: 0x0021DC74 File Offset: 0x0021BE74
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x0021DC7D File Offset: 0x0021BE7D
		// (set) Token: 0x06003CEF RID: 15599 RVA: 0x0021DC87 File Offset: 0x0021BE87
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x0021DC90 File Offset: 0x0021BE90
		// (set) Token: 0x06003CF1 RID: 15601 RVA: 0x0021DC9A File Offset: 0x0021BE9A
		internal virtual TextBox txtCoupons
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x0021DCA3 File Offset: 0x0021BEA3
		// (set) Token: 0x06003CF3 RID: 15603 RVA: 0x0021DCAD File Offset: 0x0021BEAD
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x0021DCB6 File Offset: 0x0021BEB6
		// (set) Token: 0x06003CF5 RID: 15605 RVA: 0x0021DCC0 File Offset: 0x0021BEC0
		internal virtual Label lblCouponInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x0021DCC9 File Offset: 0x0021BEC9
		// (set) Token: 0x06003CF7 RID: 15607 RVA: 0x0021DCD3 File Offset: 0x0021BED3
		internal virtual TextBox txtOLDprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x0021DCDC File Offset: 0x0021BEDC
		// (set) Token: 0x06003CF9 RID: 15609 RVA: 0x0021DCE6 File Offset: 0x0021BEE6
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06003CFA RID: 15610 RVA: 0x0021DCEF File Offset: 0x0021BEEF
		// (set) Token: 0x06003CFB RID: 15611 RVA: 0x0021DCF9 File Offset: 0x0021BEF9
		internal virtual Label lblShiftDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x0021DD02 File Offset: 0x0021BF02
		// (set) Token: 0x06003CFD RID: 15613 RVA: 0x0021DD0C File Offset: 0x0021BF0C
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x0021DD15 File Offset: 0x0021BF15
		// (set) Token: 0x06003CFF RID: 15615 RVA: 0x0021DD1F File Offset: 0x0021BF1F
		internal virtual Label lblShift
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06003D00 RID: 15616 RVA: 0x0021DD28 File Offset: 0x0021BF28
		// (set) Token: 0x06003D01 RID: 15617 RVA: 0x0021DD32 File Offset: 0x0021BF32
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06003D02 RID: 15618 RVA: 0x0021DD3B File Offset: 0x0021BF3B
		// (set) Token: 0x06003D03 RID: 15619 RVA: 0x0021DD45 File Offset: 0x0021BF45
		internal virtual Label lblUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x0021DD4E File Offset: 0x0021BF4E
		// (set) Token: 0x06003D05 RID: 15621 RVA: 0x0021DD58 File Offset: 0x0021BF58
		internal virtual Label lblbranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x0021DD61 File Offset: 0x0021BF61
		// (set) Token: 0x06003D07 RID: 15623 RVA: 0x0021DD6C File Offset: 0x0021BF6C
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

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x0021DDAF File Offset: 0x0021BFAF
		// (set) Token: 0x06003D09 RID: 15625 RVA: 0x0021DDB9 File Offset: 0x0021BFB9
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x0021DDC2 File Offset: 0x0021BFC2
		// (set) Token: 0x06003D0B RID: 15627 RVA: 0x0021DDCC File Offset: 0x0021BFCC
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

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06003D0C RID: 15628 RVA: 0x0021DE0F File Offset: 0x0021C00F
		// (set) Token: 0x06003D0D RID: 15629 RVA: 0x0021DE1C File Offset: 0x0021C01C
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

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x0021DE5F File Offset: 0x0021C05F
		// (set) Token: 0x06003D0F RID: 15631 RVA: 0x0021DE69 File Offset: 0x0021C069
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x0021DE72 File Offset: 0x0021C072
		// (set) Token: 0x06003D11 RID: 15633 RVA: 0x0021DE7C File Offset: 0x0021C07C
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

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06003D12 RID: 15634 RVA: 0x0021DEBF File Offset: 0x0021C0BF
		// (set) Token: 0x06003D13 RID: 15635 RVA: 0x0021DEC9 File Offset: 0x0021C0C9
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06003D14 RID: 15636 RVA: 0x0021DED2 File Offset: 0x0021C0D2
		// (set) Token: 0x06003D15 RID: 15637 RVA: 0x0021DEDC File Offset: 0x0021C0DC
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

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x0021DF3A File Offset: 0x0021C13A
		// (set) Token: 0x06003D17 RID: 15639 RVA: 0x0021DF44 File Offset: 0x0021C144
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x0021DF4D File Offset: 0x0021C14D
		// (set) Token: 0x06003D19 RID: 15641 RVA: 0x0021DF58 File Offset: 0x0021C158
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

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x0021DF9B File Offset: 0x0021C19B
		// (set) Token: 0x06003D1B RID: 15643 RVA: 0x0021DFA8 File Offset: 0x0021C1A8
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

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06003D1C RID: 15644 RVA: 0x0021DFEB File Offset: 0x0021C1EB
		// (set) Token: 0x06003D1D RID: 15645 RVA: 0x0021DFF5 File Offset: 0x0021C1F5
		internal virtual Label lblTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x0021DFFE File Offset: 0x0021C1FE
		// (set) Token: 0x06003D1F RID: 15647 RVA: 0x0021E008 File Offset: 0x0021C208
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x0021E011 File Offset: 0x0021C211
		// (set) Token: 0x06003D21 RID: 15649 RVA: 0x0021E01B File Offset: 0x0021C21B
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06003D22 RID: 15650 RVA: 0x0021E024 File Offset: 0x0021C224
		// (set) Token: 0x06003D23 RID: 15651 RVA: 0x0021E030 File Offset: 0x0021C230
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

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x0021E073 File Offset: 0x0021C273
		// (set) Token: 0x06003D25 RID: 15653 RVA: 0x0021E080 File Offset: 0x0021C280
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

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x0021E0DE File Offset: 0x0021C2DE
		// (set) Token: 0x06003D27 RID: 15655 RVA: 0x0021E0E8 File Offset: 0x0021C2E8
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x0021E0F1 File Offset: 0x0021C2F1
		// (set) Token: 0x06003D29 RID: 15657 RVA: 0x0021E0FC File Offset: 0x0021C2FC
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

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06003D2A RID: 15658 RVA: 0x0021E13F File Offset: 0x0021C33F
		// (set) Token: 0x06003D2B RID: 15659 RVA: 0x0021E14C File Offset: 0x0021C34C
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x0021E1EC File Offset: 0x0021C3EC
		// (set) Token: 0x06003D2D RID: 15661 RVA: 0x0021E1F6 File Offset: 0x0021C3F6
		internal virtual Label lblpaymeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x0021E1FF File Offset: 0x0021C3FF
		// (set) Token: 0x06003D2F RID: 15663 RVA: 0x0021E20C File Offset: 0x0021C40C
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

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06003D30 RID: 15664 RVA: 0x0021E24F File Offset: 0x0021C44F
		// (set) Token: 0x06003D31 RID: 15665 RVA: 0x0021E259 File Offset: 0x0021C459
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06003D32 RID: 15666 RVA: 0x0021E262 File Offset: 0x0021C462
		// (set) Token: 0x06003D33 RID: 15667 RVA: 0x0021E26C File Offset: 0x0021C46C
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06003D34 RID: 15668 RVA: 0x0021E275 File Offset: 0x0021C475
		// (set) Token: 0x06003D35 RID: 15669 RVA: 0x0021E27F File Offset: 0x0021C47F
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x0021E288 File Offset: 0x0021C488
		// (set) Token: 0x06003D37 RID: 15671 RVA: 0x0021E294 File Offset: 0x0021C494
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

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x0021E2D7 File Offset: 0x0021C4D7
		// (set) Token: 0x06003D39 RID: 15673 RVA: 0x0021E2E1 File Offset: 0x0021C4E1
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x0021E2EA File Offset: 0x0021C4EA
		// (set) Token: 0x06003D3B RID: 15675 RVA: 0x0021E2F4 File Offset: 0x0021C4F4
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

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x0021E337 File Offset: 0x0021C537
		// (set) Token: 0x06003D3D RID: 15677 RVA: 0x0021E341 File Offset: 0x0021C541
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x0021E34A File Offset: 0x0021C54A
		// (set) Token: 0x06003D3F RID: 15679 RVA: 0x0021E354 File Offset: 0x0021C554
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

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x0021E397 File Offset: 0x0021C597
		// (set) Token: 0x06003D41 RID: 15681 RVA: 0x0021E3A1 File Offset: 0x0021C5A1
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x0021E3AA File Offset: 0x0021C5AA
		// (set) Token: 0x06003D43 RID: 15683 RVA: 0x0021E3B4 File Offset: 0x0021C5B4
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
				TextBox textBox = this._txtcustomer;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtcustomer = value;
				textBox = this._txtcustomer;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06003D44 RID: 15684 RVA: 0x0021E3F7 File Offset: 0x0021C5F7
		// (set) Token: 0x06003D45 RID: 15685 RVA: 0x0021E404 File Offset: 0x0021C604
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

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x0021E447 File Offset: 0x0021C647
		// (set) Token: 0x06003D47 RID: 15687 RVA: 0x0021E451 File Offset: 0x0021C651
		internal virtual DateTimePicker DateTimePicker2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x0021E45A File Offset: 0x0021C65A
		// (set) Token: 0x06003D49 RID: 15689 RVA: 0x0021E464 File Offset: 0x0021C664
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

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x0021E4A7 File Offset: 0x0021C6A7
		// (set) Token: 0x06003D4B RID: 15691 RVA: 0x0021E4B4 File Offset: 0x0021C6B4
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

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x0021E4F7 File Offset: 0x0021C6F7
		// (set) Token: 0x06003D4D RID: 15693 RVA: 0x0021E501 File Offset: 0x0021C701
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x0021E50A File Offset: 0x0021C70A
		// (set) Token: 0x06003D4F RID: 15695 RVA: 0x0021E514 File Offset: 0x0021C714
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x0021E51D File Offset: 0x0021C71D
		// (set) Token: 0x06003D51 RID: 15697 RVA: 0x0021E527 File Offset: 0x0021C727
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06003D52 RID: 15698 RVA: 0x0021E530 File Offset: 0x0021C730
		// (set) Token: 0x06003D53 RID: 15699 RVA: 0x0021E53A File Offset: 0x0021C73A
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06003D54 RID: 15700 RVA: 0x0021E543 File Offset: 0x0021C743
		// (set) Token: 0x06003D55 RID: 15701 RVA: 0x0021E550 File Offset: 0x0021C750
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

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x0021E593 File Offset: 0x0021C793
		// (set) Token: 0x06003D57 RID: 15703 RVA: 0x0021E59D File Offset: 0x0021C79D
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x0021E5A6 File Offset: 0x0021C7A6
		// (set) Token: 0x06003D59 RID: 15705 RVA: 0x0021E5B0 File Offset: 0x0021C7B0
		internal virtual CheckBox chkPrintDeliveryNote
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x0021E5B9 File Offset: 0x0021C7B9
		// (set) Token: 0x06003D5B RID: 15707 RVA: 0x0021E5C3 File Offset: 0x0021C7C3
		internal virtual GroupBox grpCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x0021E5CC File Offset: 0x0021C7CC
		// (set) Token: 0x06003D5D RID: 15709 RVA: 0x0021E5D6 File Offset: 0x0021C7D6
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x0021E5DF File Offset: 0x0021C7DF
		// (set) Token: 0x06003D5F RID: 15711 RVA: 0x0021E5E9 File Offset: 0x0021C7E9
		internal virtual RadioButton rdpDelivery
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x0021E5F2 File Offset: 0x0021C7F2
		// (set) Token: 0x06003D61 RID: 15713 RVA: 0x0021E5FC File Offset: 0x0021C7FC
		internal virtual RadioButton rdbCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x0021E605 File Offset: 0x0021C805
		// (set) Token: 0x06003D63 RID: 15715 RVA: 0x0021E610 File Offset: 0x0021C810
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

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x0021E6B0 File Offset: 0x0021C8B0
		// (set) Token: 0x06003D65 RID: 15717 RVA: 0x0021E6BA File Offset: 0x0021C8BA
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x0021E6C3 File Offset: 0x0021C8C3
		// (set) Token: 0x06003D67 RID: 15719 RVA: 0x0021E6CD File Offset: 0x0021C8CD
		internal virtual RadioButton rdbCollectionsNone
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x0021E6D6 File Offset: 0x0021C8D6
		// (set) Token: 0x06003D69 RID: 15721 RVA: 0x0021E6E0 File Offset: 0x0021C8E0
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x0021E6E9 File Offset: 0x0021C8E9
		// (set) Token: 0x06003D6B RID: 15723 RVA: 0x0021E6F3 File Offset: 0x0021C8F3
		internal virtual Panel Panel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x0021E6FC File Offset: 0x0021C8FC
		// (set) Token: 0x06003D6D RID: 15725 RVA: 0x0021E708 File Offset: 0x0021C908
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

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x0021E74B File Offset: 0x0021C94B
		// (set) Token: 0x06003D6F RID: 15727 RVA: 0x0021E758 File Offset: 0x0021C958
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

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x0021E79B File Offset: 0x0021C99B
		// (set) Token: 0x06003D71 RID: 15729 RVA: 0x0021E7A5 File Offset: 0x0021C9A5
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x0021E7AE File Offset: 0x0021C9AE
		// (set) Token: 0x06003D73 RID: 15731 RVA: 0x0021E7B8 File Offset: 0x0021C9B8
		internal virtual Panel Panel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06003D74 RID: 15732 RVA: 0x0021E7C1 File Offset: 0x0021C9C1
		// (set) Token: 0x06003D75 RID: 15733 RVA: 0x0021E7CC File Offset: 0x0021C9CC
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

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06003D76 RID: 15734 RVA: 0x0021E80F File Offset: 0x0021CA0F
		// (set) Token: 0x06003D77 RID: 15735 RVA: 0x0021E81C File Offset: 0x0021CA1C
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

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06003D78 RID: 15736 RVA: 0x0021E85F File Offset: 0x0021CA5F
		// (set) Token: 0x06003D79 RID: 15737 RVA: 0x0021E869 File Offset: 0x0021CA69
		internal virtual Label Label33
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06003D7A RID: 15738 RVA: 0x0021E872 File Offset: 0x0021CA72
		// (set) Token: 0x06003D7B RID: 15739 RVA: 0x0021E87C File Offset: 0x0021CA7C
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06003D7C RID: 15740 RVA: 0x0021E885 File Offset: 0x0021CA85
		// (set) Token: 0x06003D7D RID: 15741 RVA: 0x0021E88F File Offset: 0x0021CA8F
		internal virtual Label Label35
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06003D7E RID: 15742 RVA: 0x0021E898 File Offset: 0x0021CA98
		// (set) Token: 0x06003D7F RID: 15743 RVA: 0x0021E8A2 File Offset: 0x0021CAA2
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x0021E8AB File Offset: 0x0021CAAB
		// (set) Token: 0x06003D81 RID: 15745 RVA: 0x0021E8B8 File Offset: 0x0021CAB8
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

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x0021E8FB File Offset: 0x0021CAFB
		// (set) Token: 0x06003D83 RID: 15747 RVA: 0x0021E905 File Offset: 0x0021CB05
		internal virtual Label txtConsultant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x0021E90E File Offset: 0x0021CB0E
		// (set) Token: 0x06003D85 RID: 15749 RVA: 0x0021E918 File Offset: 0x0021CB18
		internal virtual ComboBox cboConsultant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06003D86 RID: 15750 RVA: 0x0021E921 File Offset: 0x0021CB21
		// (set) Token: 0x06003D87 RID: 15751 RVA: 0x0021E92C File Offset: 0x0021CB2C
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

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06003D88 RID: 15752 RVA: 0x0021E96F File Offset: 0x0021CB6F
		// (set) Token: 0x06003D89 RID: 15753 RVA: 0x0021E97C File Offset: 0x0021CB7C
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

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x0021E9BF File Offset: 0x0021CBBF
		// (set) Token: 0x06003D8B RID: 15755 RVA: 0x0021E9C9 File Offset: 0x0021CBC9
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06003D8C RID: 15756 RVA: 0x0021E9D2 File Offset: 0x0021CBD2
		// (set) Token: 0x06003D8D RID: 15757 RVA: 0x0021E9DC File Offset: 0x0021CBDC
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

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x0021EA1F File Offset: 0x0021CC1F
		// (set) Token: 0x06003D8F RID: 15759 RVA: 0x0021EA2C File Offset: 0x0021CC2C
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

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06003D90 RID: 15760 RVA: 0x0021EA6F File Offset: 0x0021CC6F
		// (set) Token: 0x06003D91 RID: 15761 RVA: 0x0021EA7C File Offset: 0x0021CC7C
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

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06003D92 RID: 15762 RVA: 0x0021EABF File Offset: 0x0021CCBF
		// (set) Token: 0x06003D93 RID: 15763 RVA: 0x0021EACC File Offset: 0x0021CCCC
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

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06003D94 RID: 15764 RVA: 0x0021EB0F File Offset: 0x0021CD0F
		// (set) Token: 0x06003D95 RID: 15765 RVA: 0x0021EB19 File Offset: 0x0021CD19
		internal virtual Label Label37
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06003D96 RID: 15766 RVA: 0x0021EB22 File Offset: 0x0021CD22
		// (set) Token: 0x06003D97 RID: 15767 RVA: 0x0021EB2C File Offset: 0x0021CD2C
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

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x0021EB6F File Offset: 0x0021CD6F
		// (set) Token: 0x06003D99 RID: 15769 RVA: 0x0021EB79 File Offset: 0x0021CD79
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06003D9A RID: 15770 RVA: 0x0021EB82 File Offset: 0x0021CD82
		// (set) Token: 0x06003D9B RID: 15771 RVA: 0x0021EB8C File Offset: 0x0021CD8C
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

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06003D9C RID: 15772 RVA: 0x0021EBCF File Offset: 0x0021CDCF
		// (set) Token: 0x06003D9D RID: 15773 RVA: 0x0021EBD9 File Offset: 0x0021CDD9
		internal virtual GroupBox grpSales
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x0021EBE2 File Offset: 0x0021CDE2
		// (set) Token: 0x06003D9F RID: 15775 RVA: 0x0021EBEC File Offset: 0x0021CDEC
		internal virtual GroupBox grpCustomers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x0021EBF5 File Offset: 0x0021CDF5
		// (set) Token: 0x06003DA1 RID: 15777 RVA: 0x0021EBFF File Offset: 0x0021CDFF
		internal virtual TextBox txtcomments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x0021EC08 File Offset: 0x0021CE08
		// (set) Token: 0x06003DA3 RID: 15779 RVA: 0x0021EC14 File Offset: 0x0021CE14
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

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x0021EC57 File Offset: 0x0021CE57
		// (set) Token: 0x06003DA5 RID: 15781 RVA: 0x0021EC61 File Offset: 0x0021CE61
		internal virtual Label lbltotprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x0021EC6A File Offset: 0x0021CE6A
		// (set) Token: 0x06003DA7 RID: 15783 RVA: 0x0021EC74 File Offset: 0x0021CE74
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

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06003DA8 RID: 15784 RVA: 0x0021ECB7 File Offset: 0x0021CEB7
		// (set) Token: 0x06003DA9 RID: 15785 RVA: 0x0021ECC1 File Offset: 0x0021CEC1
		internal virtual Label lblBinLoc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06003DAA RID: 15786 RVA: 0x0021ECCA File Offset: 0x0021CECA
		// (set) Token: 0x06003DAB RID: 15787 RVA: 0x0021ECD4 File Offset: 0x0021CED4
		internal virtual Button Button20
		{
			[CompilerGenerated]
			get
			{
				return this._Button20;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button20_Click);
				Button button = this._Button20;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button20 = value;
				button = this._Button20;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x0021ED17 File Offset: 0x0021CF17
		// (set) Token: 0x06003DAD RID: 15789 RVA: 0x0021ED21 File Offset: 0x0021CF21
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x0021ED2A File Offset: 0x0021CF2A
		// (set) Token: 0x06003DAF RID: 15791 RVA: 0x0021ED34 File Offset: 0x0021CF34
		internal virtual RadioButton radSitIn
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x0021ED3D File Offset: 0x0021CF3D
		// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x0021ED47 File Offset: 0x0021CF47
		internal virtual RadioButton radTakeAway
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x0021ED50 File Offset: 0x0021CF50
		// (set) Token: 0x06003DB3 RID: 15795 RVA: 0x0021ED5A File Offset: 0x0021CF5A
		internal virtual Label Label38
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x0021ED63 File Offset: 0x0021CF63
		// (set) Token: 0x06003DB5 RID: 15797 RVA: 0x0021ED6D File Offset: 0x0021CF6D
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x0021ED76 File Offset: 0x0021CF76
		// (set) Token: 0x06003DB7 RID: 15799 RVA: 0x0021ED80 File Offset: 0x0021CF80
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x0021ED89 File Offset: 0x0021CF89
		// (set) Token: 0x06003DB9 RID: 15801 RVA: 0x0021ED93 File Offset: 0x0021CF93
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x0021ED9C File Offset: 0x0021CF9C
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x0021EDA6 File Offset: 0x0021CFA6
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x0021EDAF File Offset: 0x0021CFAF
		// (set) Token: 0x06003DBD RID: 15805 RVA: 0x0021EDB9 File Offset: 0x0021CFB9
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x0021EDC2 File Offset: 0x0021CFC2
		// (set) Token: 0x06003DBF RID: 15807 RVA: 0x0021EDCC File Offset: 0x0021CFCC
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x0021EDD5 File Offset: 0x0021CFD5
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x0021EDDF File Offset: 0x0021CFDF
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x0021EDE8 File Offset: 0x0021CFE8
		// (set) Token: 0x06003DC3 RID: 15811 RVA: 0x0021EDF2 File Offset: 0x0021CFF2
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06003DC4 RID: 15812 RVA: 0x0021EDFB File Offset: 0x0021CFFB
		// (set) Token: 0x06003DC5 RID: 15813 RVA: 0x0021EE05 File Offset: 0x0021D005
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x0021EE0E File Offset: 0x0021D00E
		// (set) Token: 0x06003DC7 RID: 15815 RVA: 0x0021EE18 File Offset: 0x0021D018
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x0021EE21 File Offset: 0x0021D021
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x0021EE2B File Offset: 0x0021D02B
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x0021EE34 File Offset: 0x0021D034
		// (set) Token: 0x06003DCB RID: 15819 RVA: 0x0021EE3E File Offset: 0x0021D03E
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x0021EE47 File Offset: 0x0021D047
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x0021EE51 File Offset: 0x0021D051
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x0021EE5A File Offset: 0x0021D05A
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x0021EE64 File Offset: 0x0021D064
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x0021EE6D File Offset: 0x0021D06D
		// (set) Token: 0x06003DD1 RID: 15825 RVA: 0x0021EE77 File Offset: 0x0021D077
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06003DD2 RID: 15826 RVA: 0x0021EE80 File Offset: 0x0021D080
		// (set) Token: 0x06003DD3 RID: 15827 RVA: 0x0021EE8A File Offset: 0x0021D08A
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x0021EE93 File Offset: 0x0021D093
		// (set) Token: 0x06003DD5 RID: 15829 RVA: 0x0021EE9D File Offset: 0x0021D09D
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x0021EEA6 File Offset: 0x0021D0A6
		// (set) Token: 0x06003DD7 RID: 15831 RVA: 0x0021EEB0 File Offset: 0x0021D0B0
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x0021EEB9 File Offset: 0x0021D0B9
		// (set) Token: 0x06003DD9 RID: 15833 RVA: 0x0021EEC3 File Offset: 0x0021D0C3
		internal virtual DataGridViewTextBoxColumn DiscPaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x0021EECC File Offset: 0x0021D0CC
		// (set) Token: 0x06003DDB RID: 15835 RVA: 0x0021EED6 File Offset: 0x0021D0D6
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x0021EEDF File Offset: 0x0021D0DF
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x0021EEE9 File Offset: 0x0021D0E9
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x0021EEF2 File Offset: 0x0021D0F2
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x0021EEFC File Offset: 0x0021D0FC
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x0021EF05 File Offset: 0x0021D105
		// (set) Token: 0x06003DE1 RID: 15841 RVA: 0x0021EF0F File Offset: 0x0021D10F
		internal virtual DataGridViewTextBoxColumn Taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0021EF18 File Offset: 0x0021D118
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x0021EF22 File Offset: 0x0021D122
		internal virtual DataGridViewTextBoxColumn PromStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x0021EF2B File Offset: 0x0021D12B
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x0021EF35 File Offset: 0x0021D135
		internal virtual DataGridViewTextBoxColumn OtherDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x0021EF3E File Offset: 0x0021D13E
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x0021EF48 File Offset: 0x0021D148
		internal virtual DataGridViewTextBoxColumn IsVoucher
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0021EF51 File Offset: 0x0021D151
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0021EF5B File Offset: 0x0021D15B
		internal virtual DataGridViewTextBoxColumn Comments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0021EF64 File Offset: 0x0021D164
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0021EF6E File Offset: 0x0021D16E
		internal virtual DataGridViewTextBoxColumn RowNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0021EF77 File Offset: 0x0021D177
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x0021EF81 File Offset: 0x0021D181
		internal virtual DataGridViewTextBoxColumn UOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x0021EF8A File Offset: 0x0021D18A
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x0021EF94 File Offset: 0x0021D194
		internal virtual DataGridViewTextBoxColumn Break
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x0021EF9D File Offset: 0x0021D19D
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x0021EFA7 File Offset: 0x0021D1A7
		internal virtual DataGridViewTextBoxColumn BreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x0021EFB0 File Offset: 0x0021D1B0
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x0021EFBA File Offset: 0x0021D1BA
		internal virtual DataGridViewTextBoxColumn BreakParentProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x0021EFC3 File Offset: 0x0021D1C3
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x0021EFCD File Offset: 0x0021D1CD
		internal virtual DataGridViewTextBoxColumn ActualBreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x0021EFD6 File Offset: 0x0021D1D6
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x0021EFE0 File Offset: 0x0021D1E0
		internal virtual DataGridViewTextBoxColumn taxexempt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x0021EFE9 File Offset: 0x0021D1E9
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x0021EFF3 File Offset: 0x0021D1F3
		internal virtual DataGridViewTextBoxColumn isdeposits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x0021EFFC File Offset: 0x0021D1FC
		// (set) Token: 0x06003DFB RID: 15867 RVA: 0x0021F006 File Offset: 0x0021D206
		internal virtual BarcodePanel BarcodePanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x0021F00F File Offset: 0x0021D20F
		// (set) Token: 0x06003DFD RID: 15869 RVA: 0x0021F01C File Offset: 0x0021D21C
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

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x0021F05F File Offset: 0x0021D25F
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x0021F069 File Offset: 0x0021D269
		internal virtual Button cmdDeposits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x0021F072 File Offset: 0x0021D272
		// (set) Token: 0x06003E01 RID: 15873 RVA: 0x0021F07C File Offset: 0x0021D27C
		internal virtual PictureBox PictureBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x0021F085 File Offset: 0x0021D285
		// (set) Token: 0x06003E03 RID: 15875 RVA: 0x0021F08F File Offset: 0x0021D28F
		internal virtual Label Label39
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x0021F098 File Offset: 0x0021D298
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x0021F0A2 File Offset: 0x0021D2A2
		internal virtual TextBox txtQtyW
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x0021F0AB File Offset: 0x0021D2AB
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x0021F0B8 File Offset: 0x0021D2B8
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

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x0021F0FB File Offset: 0x0021D2FB
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x0021F108 File Offset: 0x0021D308
		private virtual SerialPortStream s
		{
			[CompilerGenerated]
			get
			{
				return this._s;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler<RJCP.IO.Ports.SerialDataReceivedEventArgs> eventHandler = new EventHandler<RJCP.IO.Ports.SerialDataReceivedEventArgs>(this.s_DataReceived);
				SerialPortStream serialPortStream = this._s;
				if (serialPortStream != null)
				{
					serialPortStream.DataReceived -= eventHandler;
				}
				this._s = value;
				serialPortStream = this._s;
				if (serialPortStream != null)
				{
					serialPortStream.DataReceived += eventHandler;
				}
			}
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x0021F14C File Offset: 0x0021D34C
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
								this.lblShift.Text = dataRow["ShiftName"].ToString();
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
							this.lblShift.Text = dataRow2["shiftname"].ToString();
							this.DTdate.Value = this.DateTimePicker2.Value;
							dateTime = this.DateTimePicker2.Value;
							this.lblShiftDate.Text = dateTime.ToShortDateString();
							MyProject.Forms.Form1.shiftdate = Conversions.ToInteger(dateTime.ToString("yyyyMMdd"));
							this.DateTimePicker2.Enabled = false;
							this.EnableForm();
						}
						else
						{
							MessageBox.Show("Please ensure you are logged onto a shift to continue. Click Start Shift.");
						}
					}
				}
				else
				{
					DialogResult dialogResult3 = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("You are starting a new shift. Shift Name: ", dataRow["ShiftName"]), " Do you want to continue?"), MsgBoxStyle.YesNo, null);
					bool flag7 = dialogResult3 == DialogResult.Yes;
					if (flag7)
					{
						this.InsertNewShift(MyProject.Forms.Form1.username, Conversions.ToString(dataRow["ShiftName"]), (int)Math.Round(Conversion.Val(dateTime.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))), 0, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
						this.lblShift.Text = dataRow["ShiftName"].ToString();
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

		// Token: 0x06003E0B RID: 15883 RVA: 0x0021F57C File Offset: 0x0021D77C
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
					this.cotel_og = dataRow["Tel"].ToString();
					this.cotel2_og = dataRow["Tel2"].ToString();
					this.cotel3_og = dataRow["Tel3"].ToString();
					this.coemail_og = dataRow["Email"].ToString();
					this.cobpnum_og = dataRow["BPNumber"].ToString();
					this.footnote_og = dataRow["Footnote"].ToString();
					this.coVATNum_og = dataRow["VATNumber"].ToString();
					this.bpnum_name_og = dataRow["BPNumber_name"].ToString();
					this.vatnum_name_og = dataRow["VATNumber_name"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0021F760 File Offset: 0x0021D960
		private void InsertNewShift(string shiftuser, string shiftname, int shiftdate, int starttime, int endtime, string branch, int coid)
		{
			try
			{
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
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x0021F898 File Offset: 0x0021DA98
		private void EnableForm()
		{
			bool flag = MyProject.Forms.Form1.SHowCustomersInSalesForm == 1;
			if (flag)
			{
				this.grpCustomers.Visible = true;
				this.GroupBox1.Height = 332;
			}
			else
			{
				this.grpCustomers.Visible = false;
				this.GroupBox1.Height = 250;
			}
			this.grpSales.Visible = true;
			this.Panel2.Visible = true;
			this.GroupBox3.Visible = true;
			this.GroupBox2.Visible = true;
			this.btnShift.Visible = true;
			this.btnstartshift.Visible = false;
			bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag2)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
			bool flag3 = MyProject.Forms.Form1.BarFastExchange == 1;
			if (flag3)
			{
				this.btnBarFastExchange.Visible = true;
			}
			else
			{
				this.btnBarFastExchange.Visible = false;
			}
			bool flag4 = MyProject.Forms.Form1.DisableQuotations == 1;
			if (flag4)
			{
				this.Panel6.Visible = false;
			}
			else
			{
				this.Panel6.Visible = true;
			}
			bool flag5 = MyProject.Forms.Form1.DontShowQuotationsOnSalesForm == 1;
			if (flag5)
			{
				this.GroupBox5.Visible = false;
			}
			else
			{
				this.GroupBox5.Visible = true;
			}
			this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.ShowSecondScreen();
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0021FA48 File Offset: 0x0021DC48
		private void ShowSecondScreen()
		{
			bool flag = MyProject.Forms.Form1.HasSecondScreen == 1;
			if (flag)
			{
				Screen screen = Screen.AllScreens[1];
				new SecondSalesScreen
				{
					StartPosition = FormStartPosition.Manual,
					Location = screen.Bounds.Location + (Size)new Point(100, 100)
				}.Show();
			}
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0021FAB4 File Offset: 0x0021DCB4
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

		// Token: 0x06003E10 RID: 15888 RVA: 0x0021FB40 File Offset: 0x0021DD40
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

		// Token: 0x06003E11 RID: 15889 RVA: 0x0021FBF8 File Offset: 0x0021DDF8
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

		// Token: 0x06003E12 RID: 15890 RVA: 0x0021FC9C File Offset: 0x0021DE9C
		private void Sales_c(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = MyProject.Forms.Form1.UseConnectedScale == 1;
					if (flag)
					{
						this.s.Open();
					}
					bool flag2 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
					if (flag2)
					{
						try
						{
							string cardDetails = MyProject.Forms.Form1.myrevmax.GetCardDetails();
							string[] array = cardDetails.Split(new char[] { '#' });
							MyProject.Forms.Form1.RevmaxDeviceSerial = array[0];
							this.Button14.Visible = true;
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error getting Revmax fiscal device details. Detail: " + ex.Message);
						}
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
						this.DataGridView1.Columns.Insert(24, dataGridViewButtonColumn);
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
							this.DataGridView1.Rows.Add(MyProject.Forms.Form1.dgvQuotations.Rows[i].Cells.Cast<DataGridViewCell>().Select<DataGridViewCell, object>((Sales2mono._Closure$__.$I826-0 == null) ? (Sales2mono._Closure$__.$I826-0 = (DataGridViewCell c) => c.Value) : Sales2mono._Closure$__.$I826-0).ToArray<object>());
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
				}
				catch (Exception ex2)
				{
					MessageBox.Show("error loading form. Detail: " + ex2.Message);
				}
			}
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x00220418 File Offset: 0x0021E618
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

		// Token: 0x06003E14 RID: 15892 RVA: 0x00220524 File Offset: 0x0021E724
		private DataTable GetQuotationDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select * from quotations where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"' and QuotationNum=",
				Conversions.ToString(MyProject.Forms.Form1.quotationnumber)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x002205D4 File Offset: 0x0021E7D4
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

		// Token: 0x06003E16 RID: 15894 RVA: 0x00220680 File Offset: 0x0021E880
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

		// Token: 0x06003E17 RID: 15895 RVA: 0x00220770 File Offset: 0x0021E970
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

		// Token: 0x06003E18 RID: 15896 RVA: 0x00220898 File Offset: 0x0021EA98
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

		// Token: 0x06003E19 RID: 15897 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProdtID_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x00220AC0 File Offset: 0x0021ECC0
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

		// Token: 0x06003E1B RID: 15899 RVA: 0x00220BC8 File Offset: 0x0021EDC8
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
			bool flag = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedPerc, 0m) != 0;
			if (flag)
			{
				num3 = Math.Round(decimal.Multiply(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m), num), 5, MidpointRounding.AwayFromZero);
				ref string ptr = ref this.discDESC;
				this.discDESC = ptr + "Invoice Discount Approved by " + MyProject.Forms.Form1.Approvedby;
			}
			else
			{
				num3 = 0m;
			}
			bool flag2 = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedAmt, 0m) != 0;
			if (flag2)
			{
				num3 = MyProject.Forms.Form1.DiscountApprovedAmt;
				ref string ptr = ref this.discDESC;
				this.discDESC = ptr + "Invoice Discount Approved by " + MyProject.Forms.Form1.Approvedby;
			}
			else
			{
				num3 = 0m;
			}
			bool flag3 = MyProject.Forms.Form1.AllowDirectPriceEditing == 1;
			if (flag3)
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
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00220E70 File Offset: 0x0021F070
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

		// Token: 0x06003E1D RID: 15901 RVA: 0x00220F58 File Offset: 0x0021F158
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
					this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
				}
			}
			else
			{
				this.txtDesc.Text = "Nothing matching product ID";
			}
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x0022122C File Offset: 0x0021F42C
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
										this.DataGridView1.Rows[i].Cells["Qty"].Value = Operators.AddObject(this.DataGridView1.Rows[i].Cells["Qty"].Value, Conversions.ToDecimal(this.txtQty.Text));
										this.DataGridView1.Rows[i].Cells["Tax"].Value = Operators.MultiplyObject(num3, this.DataGridView1.Rows[i].Cells["Qty"].Value);
										this.DataGridView1.Rows[i].Cells["Total"].Value = Operators.AddObject(Operators.MultiplyObject(this.DataGridView1.Rows[i].Cells["UnitPrice"].Value, this.DataGridView1.Rows[i].Cells["Qty"].Value), this.DataGridView1.Rows[i].Cells["Tax"].Value);
										this.DataGridView1.Rows[i].Cells["RowNumber"].Value = this.RowID.ToString();
										this.RowID++;
										this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
										bool flag6 = (MyProject.Forms.Form1.TillPointPriceChange == 1) & (MyProject.Forms.Form1.DiscountEditingAllowed == 1);
										if (flag6)
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
						string text = "";
						bool flag7 = this.currentIsCalcLxW;
						if (flag7)
						{
							text = "Length: " + MyProject.Forms.Form1.calcLxWLength.ToString() + ", Width: " + MyProject.Forms.Form1.calcLxWWidth.ToString();
						}
						int num4 = 0;
						int num5 = 0;
						decimal num6 = 0m;
						this.discTeller = 0m;
						this.discDESC = "";
						bool flag8 = (MyProject.Forms.Form1.IsWarehouse == 0) | ((MyProject.Forms.Form1.IsWarehouse == 1) & !this.currentExpires);
						if (flag8)
						{
							bool flag9 = Conversion.Val(this.txtQty.Text) == 0.0;
							if (flag9)
							{
								MessageBox.Show("Please enter a valid quantity.");
								return;
							}
							bool flag10 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
							if (flag10)
							{
								num4 = (int)Math.Round(Conversion.Val(this.txtCoupons.Text));
							}
							bool flag11 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
							if (flag11)
							{
								this.discTeller = Convert.ToDecimal(this.txtPriceChange.Text);
								this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
								num5 = 1;
								this.priceb4tax = decimal.Add(this.priceb4tax, this.discTeller);
							}
							else
							{
								this.discTeller = 0m;
								num5 = 0;
							}
							decimal num7 = Convert.ToDecimal(this.lbltax.Text);
							decimal num8 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), this.discTeller);
							this.priceb4tax = decimal.Divide(num8, decimal.Add(1m, decimal.Divide(num7, 100m)));
							bool flag12 = decimal.Compare(num7, 0m) != 0;
							string[] array;
							unchecked
							{
								decimal num9;
								decimal num10;
								decimal num11;
								if (flag12)
								{
									num9 = Math.Round(this.priceb4tax, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
									bool flag13 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
									if (flag13)
									{
										num10 = new decimal(Math.Round(Convert.ToDouble(decimal.Multiply(decimal.Divide(num7, 100m), num9)) * Conversion.Val(this.txtQty.Text), 2, MidpointRounding.AwayFromZero));
									}
									else
									{
										num10 = new decimal(Convert.ToDouble(Math.Round(decimal.Multiply(decimal.Divide(num7, 100m), num9), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text));
									}
									num11 = decimal.Divide(num7, 100m);
								}
								else
								{
									num9 = Math.Round(num8, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
									num10 = 0m;
									num11 = 0m;
								}
								bool flag14 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
								decimal num12;
								if (flag14)
								{
									num12 = new decimal(Convert.ToDouble(Math.Round(decimal.Add(num9, decimal.Multiply(num9, decimal.Divide(num7, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text));
								}
								else
								{
									num12 = new decimal(Convert.ToDouble(Math.Round(decimal.Add(num9, decimal.Multiply(num9, decimal.Divide(num7, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text));
									num12 = Math.Round(num12, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
								}
								string text2 = "";
								string text3 = Conversions.ToString(this.discAmount);
								bool flag15 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
								if (flag15)
								{
									text2 = this.discPaymentMethod.ToString();
								}
								bool flag16 = decimal.Compare(this.discTeller, 0m) != 0;
								if (flag16)
								{
									num6 = decimal.Add(num6, this.discTeller);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + "Product Discount, " + MyProject.Forms.Form1.Approvedby;
								}
								bool flag17 = decimal.Compare(this.discAmount, 0m) != 0;
								if (flag17)
								{
									num6 = decimal.Add(num6, this.discAmount);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
								}
								bool flag18 = decimal.Compare(this.discCoupons, 0m) != 0;
								if (flag18)
								{
									num6 = decimal.Add(num6, this.discCoupons);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + "Coupon Discount, ";
								}
								bool flag19 = decimal.Compare(this.discPromotion, 0m) != 0;
								if (flag19)
								{
									num6 = decimal.Add(num6, this.discPromotion);
									ref string ptr = ref this.discDESC;
									this.discDESC = ptr + this.discPromotionName + ", ";
								}
								array = new string[]
								{
									Conversions.ToString(this.CurrentID),
									this.CurrentCode,
									this.txtDesc.Text,
									num9.ToString(),
									this.txtQty.Text,
									num10.ToString(),
									Conversions.ToString(num12),
									this.lblcost.Text,
									Conversions.ToString(num4),
									Conversions.ToString(this.priceb4tax),
									Conversions.ToString(num5),
									"0",
									"",
									Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
									Conversions.ToString(this.WholesalePriceByQty),
									this.discDESC,
									text2,
									num6.ToString(),
									"",
									Conversions.ToString(0),
									Conversions.ToString(num11),
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
									Conversions.ToString(this.currentIsDeposit)
								};
							}
							this.RowID++;
							this.DataGridView1.Rows.Add(array);
						}
						else
						{
							bool flag20 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.currentExpires;
							if (flag20)
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
											int num13 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"]));
											bool flag22 = num13 != 0;
											if (flag22)
											{
												bool flag23 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
												if (flag23)
												{
													num4 = (int)Math.Round(Conversion.Val(this.txtCoupons.Text));
												}
												decimal num14 = 0m;
												bool flag24 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
												if (flag24)
												{
													num14 = Convert.ToDecimal(this.txtPriceChange.Text);
													this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
													num5 = 1;
													this.priceb4tax = decimal.Add(this.priceb4tax, num14);
												}
												decimal num15 = Convert.ToDecimal(this.lbltax.Text);
												decimal num16 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num14);
												bool flag25 = decimal.Compare(num15, 0m) != 0;
												decimal num9;
												decimal num10;
												decimal num11;
												if (flag25)
												{
													num9 = decimal.Divide(num16, decimal.Add(1m, decimal.Divide(num15, 100m)));
													num10 = Conversions.ToDecimal(Strings.Format(decimal.Multiply(Math.Round(decimal.Multiply(decimal.Divide(num15, 100m), num9), 2), new decimal(num13)), "N2"));
													num11 = decimal.Divide(num15, 100m);
												}
												else
												{
													num9 = num16;
													num10 = 0m;
													num11 = 0m;
												}
												decimal num17 = decimal.Multiply(new decimal(num13), num16);
												num17 = num17;
												string text4 = "";
												bool flag26 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
												if (flag26)
												{
													text4 = this.discPaymentMethod.ToString();
												}
												bool flag27 = decimal.Compare(this.discTeller, 0m) != 0;
												if (flag27)
												{
													num6 = decimal.Add(num6, this.discTeller);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + "Cashier Discount, " + MyProject.Forms.Form1.Approvedby;
												}
												bool flag28 = decimal.Compare(this.discAmount, 0m) != 0;
												if (flag28)
												{
													num6 = decimal.Add(num6, this.discAmount);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
												}
												bool flag29 = decimal.Compare(this.discCoupons, 0m) != 0;
												if (flag29)
												{
													num6 = decimal.Add(num6, this.discCoupons);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + "Coupon Discount, ";
												}
												bool flag30 = decimal.Compare(this.discPromotion, 0m) != 0;
												if (flag30)
												{
													num6 = decimal.Add(num6, this.discPromotion);
													ref string ptr = ref this.discDESC;
													this.discDESC = ptr + this.discPromotionName + ", ";
												}
												string[] array2 = new string[]
												{
													Conversions.ToString(this.CurrentID),
													this.CurrentCode,
													this.txtDesc.Text,
													num9.ToString(),
													num13.ToString(),
													num10.ToString(),
													num17.ToString(),
													this.lblcost.Text,
													Conversions.ToString(num4),
													Conversions.ToString(this.priceb4tax),
													Conversions.ToString(num5),
													"0",
													"",
													Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
													Conversions.ToString(this.WholesalePriceByQty),
													this.discDESC,
													text4,
													num6.ToString(),
													dataRow["BatchNumber"].ToString(),
													dataRow["ExpiryDate"].ToString(),
													Conversions.ToString(num11),
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
													Conversions.ToString(this.currentIsDeposit)
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
						bool flag31 = (MyProject.Forms.Form1.TillPointPriceChange == 1) & (MyProject.Forms.Form1.DiscountEditingAllowed == 1);
						if (flag31)
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
						this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
						this.currComment = "";
						this.currBreak = 0;
						this.lbltotprice.Text = "...";
						MyProject.Forms.Form1.DiscountApproved = 0;
					}
				}
				else
				{
					MessageBox.Show("Editing not allowed for pending invoice.");
				}
			}
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x0022244C File Offset: 0x0022064C
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
						this.EnterItem();
					}
				}
				else
				{
					bool flag3 = this.currentIsCalcLxW;
					if (flag3)
					{
						CalcLxW calcLxW = new CalcLxW();
						calcLxW.currDesc = Conversions.ToString(this.CurrentID);
						calcLxW.ShowDialog(this);
						calcLxW.Dispose();
						this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.calcLxWTOTAL);
						this.EnterItem();
					}
					else
					{
						bool flag4 = (Operators.CompareString(this.txtQty.Text, "", false) != 0) | (Conversion.Val(this.txtQty.Text) != 0.0);
						if (flag4)
						{
							this.EnterItem();
						}
						else
						{
							MessageBox.Show("Please enter the qty first.");
							this.txtQty.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending data. Details: " + ex.Message);
			}
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x00222614 File Offset: 0x00220814
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
					this.AppendGrid();
					this.CalcTotalSale();
					this.txtBarCode.Text = "0";
					this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
					this.lblCouponInfo.Text = "...";
					this.txtCoupons.Text = "";
					this.txtsearch.Text = "";
					this.txtBarCode.Text = "";
					this.txtPriceChange.Text = "";
					this.lblcode.Text = "";
					this.CurrentID = 0;
					this.txtDesc.Text = "";
					bool flag6 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag6)
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
					MessageBox.Show("Coupon error. Check message under coupon, fix and retry.");
				}
			}
			else
			{
				MessageBox.Show("Please make sure that sales, quanity and stock available details are correct.");
			}
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x002227C8 File Offset: 0x002209C8
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
					serialPort.Parity = global::System.IO.Ports.Parity.None;
					serialPort.DataBits = 8;
					serialPort.StopBits = global::System.IO.Ports.StopBits.One;
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

		// Token: 0x06003E22 RID: 15906 RVA: 0x002228C8 File Offset: 0x00220AC8
		public bool Verify()
		{
			bool flag = true;
			bool flag2 = (MyProject.Forms.Form1.NegativeStock == 1) | this.isunedingstock;
			if (flag2)
			{
				flag = true;
			}
			else
			{
				bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag3)
				{
					return true;
				}
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
						bool flag6 = MyProject.Forms.Form1.autoBreakCase == 1;
						if (!flag6)
						{
							return false;
						}
						bool flag7 = this.currParentCaseID == 0;
						if (flag7)
						{
							return false;
						}
						int num2 = Convert.ToInt32(this.pf.GetStockAvailable(this._cnn, this.currParentCaseID, this.DataGridView1, "EA", 0, 0, false, "", 0, false));
						bool flag8 = (double)(checked(num2 * this.currCaseQty)) + Conversion.Val(this.txtStockAvail.Text) >= Conversion.Val(this.txtQty.Text);
						if (!flag8)
						{
							return false;
						}
						checked
						{
							this.BreakQtyActual = (int)Math.Round(Math.Ceiling(unchecked(Conversion.Val(this.txtQty.Text) - Conversion.Val(this.txtStockAvail.Text)) / (double)this.currCaseQty));
							this.currBreak = 1;
							flag = true;
						}
					}
				}
			}
			bool flag9 = Conversion.Val(this.txtPrice.Text) == 0.0;
			bool flag10;
			if (flag9)
			{
				flag = false;
				flag10 = flag;
			}
			else
			{
				flag10 = flag;
			}
			return flag10;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x00222A98 File Offset: 0x00220C98
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

		// Token: 0x06003E24 RID: 15908 RVA: 0x00222BB4 File Offset: 0x00220DB4
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

		// Token: 0x06003E25 RID: 15909 RVA: 0x00222E84 File Offset: 0x00221084
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

		// Token: 0x06003E26 RID: 15910 RVA: 0x00222F08 File Offset: 0x00221108
		private void ProcessSale()
		{
			try
			{
				bool flag = MyProject.Forms.Form1.AllowSalesonComputer == 1;
				if (flag)
				{
					bool flag2 = this.DataGridView1.Rows.Count > 0;
					if (flag2)
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
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error performing sale. Detail:  " + ex.Message);
			}
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00222FF8 File Offset: 0x002211F8
		private void Button2_Click(object sender, EventArgs e)
		{
			this.ProcessSale();
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00223004 File Offset: 0x00221204
		private void ConfirmSale()
		{
			this.DepositUsed = false;
			bool flag = this.DataGridView1.Rows.Count < 1;
			if (flag)
			{
				MessageBox.Show("There are no products selected. Cannot proceed.");
			}
			else
			{
				string text = "";
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
				bool flag4 = this.paymeth_requiresref;
				if (flag4)
				{
					PayMethRef payMethRef = new PayMethRef();
					bool flag5 = payMethRef.ShowDialog() == DialogResult.OK;
					if (flag5)
					{
						text = this.paymeth_desc + " ref: " + payMethRef.txtRef.Text;
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
						bool flag8 = this.CheckIfCustomerDetailsChanged();
						if (flag8)
						{
							this.UpdateCustomer();
						}
						bool flag9 = this.rdbCollection.Checked | this.rdpDelivery.Checked;
						if (flag9)
						{
							bool flag10 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) == 0;
							if (flag10)
							{
								MessageBox.Show("For delivery or collection, please select the Customer.");
								return;
							}
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
							string text2 = "";
							try
							{
								text2 = MyProject.Forms.Form1.myrevmax.GetCardDetails();
							}
							catch (Exception ex)
							{
								MessageBox.Show("Revmax Fiscal Device Error. Sale cannot proceed. Check the device first. Error Details: " + ex.Message + " " + text2);
								return;
							}
						}
						sqlCommand.CommandText = "GetSalesInvoiceNumber";
						sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						bool flag14 = (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1) | (MyProject.Forms.Form1.DateChange == 1);
						if (flag14)
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
						this.invnum = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
						bool flag15 = this.invnum == 0;
						if (flag15)
						{
							MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
							sqlTransaction.Rollback();
							sqlConnection.Close();
							return;
						}
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "InsertNextSalesInvNumber";
						sqlCommand.Parameters.AddWithValue("desc", this.DTdate.Value.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						sqlCommand.Parameters.AddWithValue("newinvnumber", this.invnum);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.ExecuteNonQuery();
						int num2 = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
						DateTime dateTime = Conversions.ToDate(this.lblShiftDate.Text);
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag16 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
								if (!flag16)
								{
									bool flag17 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["Break"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Break"].Value)), 1, false);
									if (flag17)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "GetProductConvertedNumber";
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
										int coid = MyProject.Forms.Form1.coid;
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("newconvertednum", 0);
										int num3 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "InsertProductsConverted";
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("formulaname", "Auto Break Case");
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case");
										sqlCommand.Parameters.AddWithValue("QTYCalculated", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakQty"].Value));
										sqlCommand.Parameters.AddWithValue("QTYActual", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakQty"].Value));
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("type", "BREAK");
										sqlCommand.Parameters.AddWithValue("convertedproductid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakParentProductID"].Value));
										sqlCommand.Parameters.AddWithValue("invnumber", num3);
										sqlCommand.ExecuteNonQuery();
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "InsertNewStock2Warehouse";
										sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("invoicenum", num3);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BreakParentProductID"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 0);
										sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case parent");
										sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ActualBreakQty"].Value));
										sqlCommand.Parameters.AddWithValue("cost", 0);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("trancode", 9);
										sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["BreakParentProductID"].Value), this._cnn));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("BatchNumber", "");
										sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
										sqlCommand.Parameters.AddWithValue("suppliername", "");
										sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
										sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
										sqlCommand.ExecuteNonQuery();
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "InsertNewStock2Warehouse";
										sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("invoicenum", num3);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 1);
										sqlCommand.Parameters.AddWithValue("ref", "Auto Break case child");
										sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataGridViewRow.Cells["ActualBreakQty"].Value, dataGridViewRow.Cells["BreakQty"].Value));
										sqlCommand.Parameters.AddWithValue("cost", 0);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("trancode", 9);
										sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["prodtid"].Value), this._cnn));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("BatchNumber", "");
										sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
										sqlCommand.Parameters.AddWithValue("suppliername", "");
										sqlCommand.Parameters.AddWithValue("sellingprice", 0);
										sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
										sqlCommand.ExecuteNonQuery();
									}
									decimal num4 = 0m;
									bool flag18 = MyProject.Forms.Form1.isRestaurant == 1;
									if (flag18)
									{
										DataTable productIngridients = this.GetProductIngridients(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(dataGridViewRow.Cells["Prodtid"].Value));
										bool flag19 = productIngridients.Rows.Count == 0;
										if (flag19)
										{
											num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value));
										}
										try
										{
											foreach (object obj2 in productIngridients.Rows)
											{
												DataRow dataRow = (DataRow)obj2;
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandText = "InsertNewSale2Warehouse3";
												bool flag20 = MyProject.Forms.Form1.DateChange == 1;
												if (flag20)
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
												sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataRow["qty"], Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value))));
												num4 = decimal.Add(num4, decimal.Multiply(Convert.ToDecimal(Operators.MultiplyObject(dataRow["Cost"], dataRow["qty"])), this.mono_rate));
												sqlCommand.Parameters.AddWithValue("unitcost", 0);
												sqlCommand.Parameters.AddWithValue("salesprice", 0);
												sqlCommand.Parameters.AddWithValue("paymentmethod", num);
												sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
												bool flag21 = MyProject.Forms.Form1.DateChange == 1;
												if (flag21)
												{
													sqlCommand.Parameters.AddWithValue("donewhen", this.DTdate.Value.ToString("yyyyMMdd"));
												}
												else
												{
													sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
												}
												sqlCommand.Parameters.AddWithValue("trancode", 3);
												sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["prodtid"].Value), this._cnn));
												sqlCommand.Parameters.AddWithValue("TranTime", num2);
												sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
												sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
												sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
												sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
												bool flag22 = MyProject.Forms.Form1.DateChange == 1;
												if (flag22)
												{
													sqlCommand.Parameters.AddWithValue("ShiftDate", this.DTdate.Value.ToString("yyyyMMdd"));
												}
												else
												{
													sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
												}
												sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
												sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)))));
												sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
												sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
												sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
												sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)));
												sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
												sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text));
												sqlCommand.Parameters.AddWithValue("collection", "");
												sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
												sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
												sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxexempt"].Value));
												sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
												sqlCommand.ExecuteNonQuery();
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
									bool flag23 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["isvoucher"].Value.ToString(), "", false) == 0, false, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isvoucher"].Value)), true, false);
									if (flag23)
									{
										dataTable.Rows.Add(new object[]
										{
											dataGridViewRow.Cells["Prodtid"].Value,
											Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value))
										});
									}
									bool flag24 = this.currQuotationNumber != 0;
									if (flag24)
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
									bool flag25 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
									if (flag25)
									{
										sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
									}
									sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("isstockin", 0);
									sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
									sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
									bool flag26 = MyProject.Forms.Form1.isRestaurant == 1;
									if (flag26)
									{
										sqlCommand.Parameters.AddWithValue("unitcost", num4);
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
									}
									sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), this.mono_rate));
									sqlCommand.Parameters.AddWithValue("paymentmethod", num);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									bool flag27 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
									if (flag27)
									{
										sqlCommand.Parameters.AddWithValue("donewhen", this.DTdate.Value.ToString("yyyyMMdd"));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									}
									sqlCommand.Parameters.AddWithValue("trancode", 3);
									sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
									sqlCommand.Parameters.AddWithValue("TranTime", num2);
									sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)) / Convert.ToDouble(this.mono_rate));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
									bool flag28 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
									if (flag28)
									{
										sqlCommand.Parameters.AddWithValue("ShiftDate", this.DTdate.Value.ToString("yyyyMMdd"));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
									}
									sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
									sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)))));
									sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
									sqlCommand.Parameters.AddWithValue("discountamount", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)), this.mono_rate));
									sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
									sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text) / Convert.ToDouble(this.mono_rate));
									string text3 = "";
									bool @checked = this.rdbCollection.Checked;
									if (@checked)
									{
										text3 = "COLLECTION";
									}
									else
									{
										bool checked2 = this.rdpDelivery.Checked;
										if (checked2)
										{
											text3 = "DELIVERY";
										}
									}
									sqlCommand.Parameters.AddWithValue("collection", text3);
									sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
									sqlCommand.Parameters.AddWithValue("otherdetail", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OtherDetail"].Value));
									bool flag29 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
									if (flag29)
									{
										sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["comments"].Value));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["comments"].Value));
									}
									sqlCommand.Parameters.AddWithValue("paymethref", text);
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("quotationnum", this.currQuotationNumber);
									sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxexempt"].Value));
									sqlCommand.Parameters.AddWithValue("taxrate", Operators.MultiplyObject(dataGridViewRow.Cells["taxr"].Value, 100));
									bool flag30 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["isdeposits"].Value, 1, false);
									if (flag30)
									{
										sqlCommand.Parameters.AddWithValue("isdeposit", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isdeposits"].Value));
										this.DepositUsed = true;
									}
									sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
									sqlCommand.ExecuteNonQuery();
									bool flag31 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["CouponNumber"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CouponNumber"].Value)), 0, false);
									if (flag31)
									{
										int num5 = Conversions.ToInteger(dataGridViewRow.Cells["CouponNumber"].Value);
										bool flag32 = num5 != 1;
										if (flag32)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "UpdateCoupon";
											sqlCommand.Parameters.AddWithValue("CouponNumber", num5);
											sqlCommand.ExecuteNonQuery();
										}
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "InsertDiscount2";
										sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
										sqlCommand.Parameters.AddWithValue("TranDate", this.DTdate.Value.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("DiscountAmt", Operators.DivideObject(dataGridViewRow.Cells["DiscAmount2"].Value, this.mono_rate));
										sqlCommand.Parameters.AddWithValue("pricebefore", Operators.DivideObject(dataGridViewRow.Cells["OldPrice"].Value, this.mono_rate));
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("couponnumber", num5);
										sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
										sqlCommand.Parameters.AddWithValue("discounttype", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
										sqlCommand.Parameters.AddWithValue("discountperinvoice", this.isInvoiceDisc);
										sqlCommand.Parameters.AddWithValue("@discountpaymethod", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscPaymethod"].Value));
										sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
										sqlCommand.ExecuteNonQuery();
									}
									bool flag33 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(dataGridViewRow.Cells["PriceChange"]), 0, RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["PriceChange"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PriceChange"].Value)))), 1, false);
									if (flag33)
									{
										decimal num6 = new decimal(Convert.ToDouble(decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), this.mono_rate)) - (Convert.ToDouble(decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)), this.mono_rate)) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)) / Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value))));
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "PCInsertPriceChange";
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
										sqlCommand.Parameters.AddWithValue("pricechange", num6);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("donetime", DateTime.Now.ToString("HH:mm"));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("invoiceno", this.invnum);
										sqlCommand.Parameters.AddWithValue("normalprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)), this.mono_rate));
										sqlCommand.Parameters.AddWithValue("costprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
										sqlCommand.Parameters.AddWithValue("approvedby", MyProject.Forms.Form1.Approvedby);
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
						bool checked3 = this.chkMultiple.Checked;
						if (checked3)
						{
							try
							{
								foreach (object obj3 in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
								{
									DataRow dataRow2 = (DataRow)obj3;
									bool flag34 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["amtpaid"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["amtpaid"])), 0, false);
									if (flag34)
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
								IEnumerator enumerator3;
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
						}
						else
						{
							decimal num7 = Convert.ToDecimal(this.txtTotal.Text);
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "InsertActualPaymentMethods";
							sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
							sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
							sqlCommand.Parameters.AddWithValue("paydesc", this.cboPayMeth.Text);
							sqlCommand.Parameters.AddWithValue("amt", num7);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
							sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.ExecuteNonQuery();
						}
						bool flag35 = MyProject.Forms.Form1.CollectEcocashDetails == 1;
						if (flag35)
						{
							bool flag36 = (Operators.CompareString(this.cboPayMeth.Text, "Ecocash", false) == 0) | (Operators.CompareString(this.cboPayMeth.Text, "ECOCASH", false) == 0) | (Operators.CompareString(this.cboPayMeth.Text, "ecocash", false) == 0);
							if (flag36)
							{
								MessageBox.Show("Function is disable. Contact your system administrator.");
							}
						}
					}
					else
					{
						bool flag37 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0;
						if (!flag37)
						{
							MessageBox.Show("Please select/enter a customer name first before confirming the sale.");
							sqlTransaction.Rollback();
							sqlConnection.Close();
							Cursor.Current = Cursors.Default;
							return;
						}
						bool flag38 = this.DataGridView1.Rows.Count < 1;
						if (flag38)
						{
							MessageBox.Show("There are no products selected. Cannot proceed.");
							return;
						}
						bool flag39 = Conversion.Val(this.txtTotal.Text) == 0.0;
						if (flag39)
						{
							MessageBox.Show("Total sale is 0. Cannot proceed.");
							return;
						}
						int num8 = 0;
						bool flag40 = this.CheckIfCustomerDetailsChanged();
						if (flag40)
						{
							this.UpdateCustomer();
						}
						bool flag41 = !this.pf.isCustomerAccOK(this.txtcustomer.Text, new decimal(Conversions.ToDouble(this.txtTotal.Text) / Convert.ToDouble(this.mono_rate)), this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
						if (flag41)
						{
							MessageBox.Show("Customer account limit reached or account inactive. Sale cannot proceed.");
							return;
						}
						num8 = 10;
						bool flag42 = (MyProject.Forms.Form1.RecordConsultant == 1) & (MyProject.Forms.Form1.ConsultantSalesOnly == 1);
						if (flag42)
						{
							bool flag43 = Operators.CompareString(this.cboConsultant.Text, "", false) == 0;
							if (flag43)
							{
								MessageBox.Show("Please select the consultant first.");
								sqlTransaction.Rollback();
								sqlConnection.Close();
								return;
							}
						}
						bool flag44 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
						if (flag44)
						{
							string text4 = "";
							try
							{
								text4 = MyProject.Forms.Form1.myrevmax.GetCardDetails();
							}
							catch (Exception ex2)
							{
								MessageBox.Show("Revmax Fiscal Device Error. Sale cannot proceed. Check the device first. Error Details: " + ex2.Message + " " + text4);
								return;
							}
						}
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "GetSalesInvoiceNumber";
						sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						bool flag45 = (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1) | (MyProject.Forms.Form1.DateChange == 1);
						if (flag45)
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
						this.invnum = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
						bool flag46 = this.invnum == 0;
						if (flag46)
						{
							MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
							sqlTransaction.Rollback();
							sqlConnection.Close();
							return;
						}
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "InsertNextSalesInvNumber";
						sqlCommand.Parameters.AddWithValue("desc", this.DTdate.Value.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						sqlCommand.Parameters.AddWithValue("newinvnumber", this.invnum);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.ExecuteNonQuery();
						int num9 = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
						DateTime dateTime2 = Conversions.ToDate(this.lblShiftDate.Text);
						try
						{
							foreach (object obj4 in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
								bool flag47 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Prodtid"].Value));
								if (!flag47)
								{
									bool flag48 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["Break"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Break"].Value)), 1, false);
									if (flag48)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "GetProductConvertedNumber";
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
										int coid2 = MyProject.Forms.Form1.coid;
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("newconvertednum", 0);
										int num10 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
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
										sqlCommand.Parameters.AddWithValue("invnumber", num10);
										sqlCommand.ExecuteNonQuery();
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "InsertNewStock2Warehouse";
										sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("invoicenum", num10);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BreakParentProductID"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 0);
										sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case parent");
										sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ActualBreakQty"].Value));
										sqlCommand.Parameters.AddWithValue("cost", 0);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("trancode", 9);
										sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow2.Cells["BreakParentProductID"].Value), this._cnn));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("BatchNumber", "");
										sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
										sqlCommand.Parameters.AddWithValue("suppliername", "");
										sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
										sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
										sqlCommand.ExecuteNonQuery();
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "InsertNewStock2Warehouse";
										sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("invoicenum", num10);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["prodtid"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 1);
										sqlCommand.Parameters.AddWithValue("ref", "Auto Break case child");
										sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataGridViewRow2.Cells["ActualBreakQty"].Value, dataGridViewRow2.Cells["BreakQty"].Value));
										sqlCommand.Parameters.AddWithValue("cost", 0);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("trancode", 9);
										sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow2.Cells["prodtid"].Value), this._cnn));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("BatchNumber", "");
										sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
										sqlCommand.Parameters.AddWithValue("suppliername", "");
										sqlCommand.Parameters.AddWithValue("sellingprice", 0);
										sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
										sqlCommand.ExecuteNonQuery();
									}
									decimal num11 = 0m;
									bool flag49 = MyProject.Forms.Form1.isRestaurant == 1;
									if (flag49)
									{
										DataTable productIngridients2 = this.GetProductIngridients(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(dataGridViewRow2.Cells["Prodtid"].Value));
										bool flag50 = productIngridients2.Rows.Count == 0;
										if (flag50)
										{
											num11 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitCost"].Value));
										}
										try
										{
											foreach (object obj5 in productIngridients2.Rows)
											{
												DataRow dataRow3 = (DataRow)obj5;
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandText = "InsertNewSale2Warehouse3";
												bool flag51 = MyProject.Forms.Form1.DateChange == 1;
												if (flag51)
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
												sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataRow3["qty"], Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value))));
												num11 = decimal.Add(num11, Convert.ToDecimal(Operators.MultiplyObject(dataRow3["Cost"], dataRow3["qty"])));
												sqlCommand.Parameters.AddWithValue("unitcost", 0);
												sqlCommand.Parameters.AddWithValue("salesprice", 0);
												sqlCommand.Parameters.AddWithValue("paymentmethod", num8);
												sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
												bool flag52 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
												if (flag52)
												{
													sqlCommand.Parameters.AddWithValue("donewhen", this.DTdate.Value.ToString("yyyyMMdd"));
												}
												else
												{
													sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
												}
												sqlCommand.Parameters.AddWithValue("trancode", 3);
												sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow2.Cells["prodtid"].Value), this._cnn));
												sqlCommand.Parameters.AddWithValue("TranTime", num9);
												sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Tax"].Value)));
												sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
												sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
												sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
												bool flag53 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
												if (flag53)
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
												sqlCommand.ExecuteNonQuery();
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
									bool flag54 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["isvoucher"].Value.ToString(), "", false) == 0, false, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["isvoucher"].Value)), true, false);
									if (flag54)
									{
										dataTable.Rows.Add(new object[]
										{
											dataGridViewRow2.Cells["Prodtid"].Value,
											Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value))
										});
									}
									bool flag55 = this.currQuotationNumber != 0;
									if (flag55)
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
									bool flag56 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
									if (flag56)
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
									bool flag57 = MyProject.Forms.Form1.isRestaurant == 1;
									if (flag57)
									{
										sqlCommand.Parameters.AddWithValue("unitcost", num11);
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitCost"].Value)));
									}
									sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitPrice"].Value)), this.mono_rate));
									sqlCommand.Parameters.AddWithValue("paymentmethod", num8);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									bool flag58 = MyProject.Forms.Form1.DateChange == 1;
									if (flag58)
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
									sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ProductCode"].Value));
									sqlCommand.Parameters.AddWithValue("TranTime", num9);
									sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Tax"].Value)) / Convert.ToDouble(this.mono_rate));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
									sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BatchNumber"].Value));
									sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["ExpiryDate"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ExpiryDate"].Value)))));
									sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
									sqlCommand.Parameters.AddWithValue("discountamount", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscAmount2"].Value)), this.mono_rate));
									sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
									sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text) / Convert.ToDouble(this.mono_rate));
									string text5 = "";
									bool checked4 = this.rdbCollection.Checked;
									if (checked4)
									{
										text5 = "COLLECTION";
									}
									else
									{
										bool checked5 = this.rdpDelivery.Checked;
										if (checked5)
										{
											text5 = "DELIVERY";
										}
									}
									sqlCommand.Parameters.AddWithValue("collection", text5);
									sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscDetails"].Value));
									sqlCommand.Parameters.AddWithValue("otherdetail", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["OtherDetail"].Value));
									bool flag59 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
									if (flag59)
									{
										sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["comments"].Value));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["comments"].Value));
									}
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("quotationnum", this.currQuotationNumber);
									sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["taxexempt"].Value));
									sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
									sqlCommand.ExecuteNonQuery();
									bool flag60 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Operators.CompareString(dataGridViewRow2.Cells["CouponNumber"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["CouponNumber"].Value)), 0, false);
									if (flag60)
									{
										int num12 = Conversions.ToInteger(dataGridViewRow2.Cells["CouponNumber"].Value);
										bool flag61 = num12 != 1;
										if (flag61)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "UpdateCoupon";
											sqlCommand.Parameters.AddWithValue("CouponNumber", num12);
											sqlCommand.ExecuteNonQuery();
										}
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
										sqlCommand.Parameters.AddWithValue("couponnumber", num12);
										sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value));
										sqlCommand.Parameters.AddWithValue("discounttype", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscDetails"].Value));
										sqlCommand.Parameters.AddWithValue("discountperinvoice", this.isInvoiceDisc);
										sqlCommand.Parameters.AddWithValue("@discountpaymethod", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscPaymethod"].Value));
										sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
										sqlCommand.ExecuteNonQuery();
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
						DateTime dateTime3 = this.DTdate.Value.AddDays((double)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue)));
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "BillingInsertAccSale2";
						sqlCommand.Parameters.AddWithValue("customername", this.txtcustomer.Text);
						sqlCommand.Parameters.AddWithValue("invoicenumber", this.invnum);
						sqlCommand.Parameters.AddWithValue("amount", decimal.Divide(Convert.ToDecimal(this.txtTotal.Text), this.mono_rate));
						sqlCommand.Parameters.AddWithValue("shiftdate", dateTime2.ToString("yyyyMMdd"));
						sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("trantime", num9);
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
					try
					{
						foreach (object obj6 in dataTable.Rows)
						{
							DataRow dataRow4 = (DataRow)obj6;
							sqlCommand.Parameters.Clear();
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
						IEnumerator enumerator6;
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
					}
					sqlTransaction.Commit();
					sqlConnection.Close();
					bool flag62 = (MyProject.Forms.Form1.SelectA4InvatPOS == 1) & (MyProject.Forms.Form1.PrintFiscal == 0);
					if (flag62)
					{
						int num13 = 0;
						PrintReceiptOrInvoice printReceiptOrInvoice = new PrintReceiptOrInvoice();
						bool flag63 = printReceiptOrInvoice.ShowDialog() == DialogResult.OK;
						if (flag63)
						{
							num13 = printReceiptOrInvoice.printcode;
						}
						bool flag64 = num13 == 1;
						if (flag64)
						{
							this.PrintInvoice("", 0);
						}
						else
						{
							bool flag65 = num13 == 2;
							if (flag65)
							{
								bool flag66 = MyProject.Forms.Form1.PrintReceipt == 1;
								if (flag66)
								{
									bool flag67 = MyProject.Forms.Form1.PrintFiscal == 0;
									if (flag67)
									{
										bool flag68 = MyProject.Forms.Form1.ReceiptsOptional == 1;
										int i;
										if (flag68)
										{
											try
											{
												PrintReceipts printReceipts = new PrintReceipts();
												bool flag69 = printReceipts.ShowDialog() == DialogResult.OK;
												if (flag69)
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
										int num14 = 0;
										checked
										{
											while (i > 0)
											{
												num14++;
												bool flag70 = MyProject.Forms.Form1.ReceiptSize80 == 1;
												if (flag70)
												{
													bool flag71 = num14 > 1;
													if (flag71)
													{
														this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, MyProject.Forms.Form1.receipt_copy_name);
													}
													else
													{
														this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "");
													}
													bool flag72 = dataTable.Rows.Count > 0;
													if (flag72)
													{
														this.printEconetAirtimeVoucher(this.invnum);
													}
												}
												else
												{
													bool flag73 = MyProject.Forms.Form1.ReceiptSize80 == 0;
													if (flag73)
													{
														this.PrintReceipt58(this.invnum);
													}
												}
												i--;
											}
										}
									}
									else
									{
										bool flag74 = MyProject.Forms.Form1.PrintFiscal == 1;
										if (flag74)
										{
											bool flag75 = MyProject.Forms.Form1.FiscalEltrade == 1;
											if (flag75)
											{
												EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
												DataTable dataTable2 = this.createDTFromGrid(this.DataGridView1);
												string text6 = this.PrintEltradeInvoice(dataTable2, this.pf.GetFiscalGroup(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), this.cboPayMeth.Text, Conversion.Val(this.txtAmtPaid.Text), MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, this.pf.GetEltradeFiscalCountryID(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), 3, MyProject.Forms.Form1.username, this.invnum, this.txtbpnumber.Text, this.txtvatnumber.Text, MyProject.Forms.Form1.companyname, "", this.txtAddress.Text, "MOL", this.txtcustomer.Text, eltradeFprn);
												bool flag76 = Operators.CompareString(Strings.Trim(text6), "SUCCESS", false) != 0;
												if (flag76)
												{
													this.saledone = true;
													MessageBox.Show("Sale done. Fiscal Error. " + text6);
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
												bool flag77 = MyProject.Forms.Form1.FiscalRevmax == 1;
												if (flag77)
												{
													string text7 = "";
													try
													{
														DataTable dataTable3 = new DataTable();
														dataTable3.Columns.Add("ProductCode", typeof(string));
														dataTable3.Columns.Add("ProductDesc", typeof(string));
														dataTable3.Columns.Add("Qty", typeof(decimal));
														dataTable3.Columns.Add("SellingPrice", typeof(decimal));
														dataTable3.Columns.Add("Total", typeof(decimal));
														dataTable3.Columns.Add("Tax", typeof(decimal));
														dataTable3.Columns.Add("Taxr", typeof(decimal));
														try
														{
															foreach (object obj7 in ((IEnumerable)this.DataGridView1.Rows))
															{
																DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj7;
																dataTable3.Rows.Add(new object[]
																{
																	dataGridViewRow3.Cells["ProductCode"].Value,
																	dataGridViewRow3.Cells["Desc"].Value,
																	dataGridViewRow3.Cells["Qty"].Value,
																	dataGridViewRow3.Cells["UnitPrice"].Value,
																	dataGridViewRow3.Cells["Total"].Value,
																	dataGridViewRow3.Cells["Tax"].Value,
																	dataGridViewRow3.Cells["taxr"].Value
																});
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
														decimal num15 = new decimal(Conversion.Val(this.txtTotal.Text) - Conversion.Val(this.txtTax.Text));
														string text8 = this.BuildItemsXML(dataTable3);
														string text9 = this.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
														text7 = MyProject.Forms.Form1.myrevmax.TransactM(this.paymeth_currency, MyProject.Forms.Form1.branch, this.invnum.ToString(), this.txtcustomer.Text, "000", "na", "na", "na", num15.ToString(), this.txtTax.Text, "01", "na", "na", text8, text9);
														string[] array = text7.Split(new char[] { '#' });
														this.SaveDigSig(array[2], this.invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
														this.PrintReceipt(this.invnum, array[2], MyProject.Forms.Form1.defaultReceiptPrinter, "");
													}
													catch (Exception ex4)
													{
														MessageBox.Show("Error fiscalising. Check settings first. Return: " + text7 + " ex:" + ex4.Message);
													}
												}
												else
												{
													bool flag78 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
													if (flag78)
													{
														bool flag79 = MyProject.Forms.Form1.PrintToFile == 1;
														if (flag79)
														{
															this.PrintHeader("");
															this.ItemsToBePrinted(this.invnum);
															this.PrintFooter("");
															bool flag80 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "TXT", false) == 0;
															if (flag80)
															{
																File.WriteAllText(Path.Combine(MyProject.Forms.Form1.PrintFilePath, this.invnum.ToString() + ".txt"), this.TextToPrint);
															}
															else
															{
																bool flag81 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "PDF", false) == 0;
																if (flag81)
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
															this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "");
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
								bool flag82 = num13 == 3;
								if (flag82)
								{
								}
							}
						}
					}
					else
					{
						bool flag83 = MyProject.Forms.Form1.PrintReceipt == 1;
						if (flag83)
						{
							bool flag84 = MyProject.Forms.Form1.PrintFiscal == 0;
							if (flag84)
							{
								bool flag85 = MyProject.Forms.Form1.ReceiptsOptional == 1;
								int j;
								if (flag85)
								{
									try
									{
										PrintReceipts printReceipts2 = new PrintReceipts();
										bool flag86 = printReceipts2.ShowDialog() == DialogResult.OK;
										if (flag86)
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
								int num16 = 0;
								checked
								{
									while (j > 0)
									{
										num16++;
										bool flag87 = MyProject.Forms.Form1.ReceiptSize80 == 1;
										if (flag87)
										{
											bool flag88 = num16 > 1;
											if (flag88)
											{
												this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, MyProject.Forms.Form1.receipt_copy_name);
											}
											else
											{
												this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "");
											}
											bool flag89 = dataTable.Rows.Count > 0;
											if (flag89)
											{
												this.printEconetAirtimeVoucher(this.invnum);
											}
										}
										else
										{
											bool flag90 = MyProject.Forms.Form1.ReceiptSize80 == 0;
											if (flag90)
											{
												this.PrintReceipt58(this.invnum);
											}
										}
										j--;
									}
									bool flag91 = Operators.CompareString(MyProject.Forms.Form1.defaultSecondaryPrinter, "", false) != 0;
									if (flag91)
									{
										this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultSecondaryPrinter, MyProject.Forms.Form1.receipt_copy_name);
									}
								}
							}
							else
							{
								bool flag92 = MyProject.Forms.Form1.PrintFiscal == 1;
								if (flag92)
								{
									bool flag93 = MyProject.Forms.Form1.FiscalEltrade == 1;
									if (flag93)
									{
										EltradeFprn eltradeFprn2 = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
										DataTable dataTable4 = this.createDTFromGrid(this.DataGridView1);
										string text10 = this.PrintEltradeInvoice(dataTable4, this.pf.GetFiscalGroup(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), this.cboPayMeth.Text, Conversion.Val(this.txtAmtPaid.Text), MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, this.pf.GetEltradeFiscalCountryID(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn), 3, MyProject.Forms.Form1.username, this.invnum, this.txtbpnumber.Text, this.txtvatnumber.Text, MyProject.Forms.Form1.companyname, "", this.txtAddress.Text, "MOL", this.txtcustomer.Text, eltradeFprn2);
										bool flag94 = Operators.CompareString(Strings.Trim(text10), "SUCCESS", false) != 0;
										if (flag94)
										{
											this.saledone = true;
											MessageBox.Show("Sale done. Fiscal Error. " + text10);
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
										bool flag95 = MyProject.Forms.Form1.FiscalRevmax == 1;
										if (flag95)
										{
											string text11 = "";
											try
											{
												DataTable dataTable5 = new DataTable();
												dataTable5.Columns.Add("ProductCode", typeof(string));
												dataTable5.Columns.Add("ProductDesc", typeof(string));
												dataTable5.Columns.Add("Qty", typeof(decimal));
												dataTable5.Columns.Add("SellingPrice", typeof(decimal));
												dataTable5.Columns.Add("Total", typeof(decimal));
												dataTable5.Columns.Add("Tax", typeof(decimal));
												dataTable5.Columns.Add("Taxr", typeof(decimal));
												try
												{
													foreach (object obj8 in ((IEnumerable)this.DataGridView1.Rows))
													{
														DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj8;
														dataTable5.Rows.Add(new object[]
														{
															dataGridViewRow4.Cells["ProductCode"].Value,
															dataGridViewRow4.Cells["Desc"].Value,
															dataGridViewRow4.Cells["Qty"].Value,
															dataGridViewRow4.Cells["UnitPrice"].Value,
															dataGridViewRow4.Cells["Total"].Value,
															dataGridViewRow4.Cells["Tax"].Value,
															dataGridViewRow4.Cells["taxr"].Value
														});
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
												decimal num17 = new decimal(Conversion.Val(this.txtTotal.Text) - Conversion.Val(this.txtTax.Text));
												string text12 = this.BuildItemsXML(dataTable5);
												string text13 = this.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
												text11 = MyProject.Forms.Form1.myrevmax.TransactM(this.paymeth_currency, MyProject.Forms.Form1.branch, this.invnum.ToString(), this.txtcustomer.Text, "000", "na", "na", "na", num17.ToString(), this.txtTax.Text, "01", "na", "na", text12, text13);
												string[] array2 = text11.Split(new char[] { '#' });
												this.SaveDigSig(array2[2], this.invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
												this.PrintReceipt(this.invnum, array2[2], MyProject.Forms.Form1.defaultReceiptPrinter, "");
											}
											catch (Exception ex6)
											{
												MessageBox.Show("Error fiscalising. Check settings first. Return: " + text11 + " ex:" + ex6.Message);
											}
										}
										else
										{
											bool flag96 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
											if (flag96)
											{
												bool flag97 = MyProject.Forms.Form1.PrintToFile == 1;
												if (flag97)
												{
													this.PrintHeader("");
													this.ItemsToBePrinted(this.invnum);
													this.PrintFooter("");
													bool flag98 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "TXT", false) == 0;
													if (flag98)
													{
														File.WriteAllText(Path.Combine(MyProject.Forms.Form1.PrintFilePath, this.invnum.ToString() + ".txt"), this.TextToPrint);
													}
													else
													{
														bool flag99 = Operators.CompareString(MyProject.Forms.Form1.InterfacedFiscalSaveas, "PDF", false) == 0;
														if (flag99)
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
													this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, "");
												}
											}
										}
									}
								}
							}
						}
						bool flag100 = MyProject.Forms.Form1.PrintInvoice == 1;
						if (flag100)
						{
							bool flag101 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
							if (flag101)
							{
								string text14 = "";
								try
								{
									DataTable dataTable6 = new DataTable();
									dataTable6.Columns.Add("ProductCode", typeof(string));
									dataTable6.Columns.Add("ProductDesc", typeof(string));
									dataTable6.Columns.Add("Qty", typeof(decimal));
									dataTable6.Columns.Add("SellingPrice", typeof(decimal));
									dataTable6.Columns.Add("Total", typeof(decimal));
									dataTable6.Columns.Add("Tax", typeof(decimal));
									dataTable6.Columns.Add("Taxr", typeof(decimal));
									try
									{
										foreach (object obj9 in ((IEnumerable)this.DataGridView1.Rows))
										{
											DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj9;
											dataTable6.Rows.Add(new object[]
											{
												dataGridViewRow5.Cells["ProductCode"].Value,
												dataGridViewRow5.Cells["Desc"].Value,
												dataGridViewRow5.Cells["Qty"].Value,
												dataGridViewRow5.Cells["UnitPrice"].Value,
												dataGridViewRow5.Cells["Total"].Value,
												dataGridViewRow5.Cells["Tax"].Value,
												dataGridViewRow5.Cells["taxr"].Value
											});
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
									decimal num18 = new decimal(Conversion.Val(this.txtTotal.Text) - Conversion.Val(this.txtTax.Text));
									string text15 = this.BuildItemsXML(dataTable6);
									string text16 = this.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
									text14 = MyProject.Forms.Form1.myrevmax.TransactM(this.paymeth_currency, MyProject.Forms.Form1.branch, this.invnum.ToString(), this.txtcustomer.Text, "000", "na", "na", "na", num18.ToString(), this.txtTax.Text, "01", "na", "na", text15, text16);
									string[] array3 = text14.Split(new char[] { '#' });
									this.SaveDigSig(array3[2], this.invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
									this.PrintInvoice(array3[2], 0);
								}
								catch (Exception ex7)
								{
									this.saledone = true;
									MessageBox.Show("SALE DONE BUT Error fiscalising. Check settings first. Return: " + text14 + " ex:" + ex7.Message);
									this.ClearForm();
									return;
								}
							}
							else
							{
								bool flag102 = (MyProject.Forms.Form1.PrintInvoice == 1) & (MyProject.Forms.Form1.FiscalEltradeESD == 1);
								if (flag102)
								{
									this.PrintInvoice("", 1);
								}
								else
								{
									bool flag103 = (MyProject.Forms.Form1.PrintInvoice == 1) & (MyProject.Forms.Form1.PrintFiscal == 0);
									if (flag103)
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
						bool flag104 = MyProject.Forms.Form1.PrintReceipt == 1;
						if (flag104)
						{
							this.printDeliveryNote80mm(this.pf.GetInvoiceDetails(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.invnum, this._cnn), 72);
						}
						else
						{
							bool flag105 = MyProject.Forms.Form1.PrintInvoice == 1;
							if (flag105)
							{
								DeliveryNoteWarehouse deliveryNoteWarehouse = new DeliveryNoteWarehouse();
								deliveryNoteWarehouse.invnum = this.invnum;
								deliveryNoteWarehouse.ShowDialog(this);
								deliveryNoteWarehouse.Dispose();
							}
						}
					}
					this.PrintAirtimeVoucher(this.invnum, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
					bool flag106 = (MyProject.Forms.Form1.deposits_inuse == 1) & this.DepositUsed & (MyProject.Forms.Form1.useOldPrintingService == 1);
					if (flag106)
					{
						DataTable deposits = this.GetDeposits(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.invnum);
						bool flag107 = deposits.Rows.Count > 0;
						if (flag107)
						{
							try
							{
								foreach (object obj10 in deposits.Rows)
								{
									DataRow dataRow5 = (DataRow)obj10;
									this.PrintBarCode("999" + dataRow5["ID"].ToString(), Conversions.ToDecimal(dataRow5["deposit_amount"]));
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
					bool flag108 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag108)
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
				catch (Exception ex8)
				{
					try
					{
						MessageBox.Show("Error confirming sale. Attempting rollback. Detail: " + ex8.Message);
						this.Button2.TabStop = false;
						SqlTransaction sqlTransaction;
						sqlTransaction.Rollback();
						sqlConnection.Close();
						Cursor.Current = Cursors.Default;
						bool flag109 = this.saledone;
						if (flag109)
						{
							this.ClearForm();
						}
					}
					catch (Exception ex9)
					{
					}
				}
			}
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x002298B4 File Offset: 0x00227AB4
		private void printDeliveryNote80mm(DataTable invoicedetailsDAT, int papersize)
		{
			string text = "DELIVERY NOTE";
			string text2 = this.pf.StringPadCentre(text, papersize);
			DataRow dataRow = invoicedetailsDAT.Rows[0];
			DataTable customerDetails = this.pf.GetCustomerDetails(this._cnn, Conversions.ToString(dataRow["Ref"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			text2 = text2 + this.pf.StringPadCentre(text2, papersize) + Environment.NewLine;
			this.TextToPrint = text2;
			this.coname = this.pf.StringPadCentre(this.coname, papersize);
			text2 = this.coname;
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
			if (flag)
			{
				text2 = this.bpnum_name + " " + this.cobpnum;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag2 = Operators.CompareString(this.coVATNum, "", false) != 0;
			if (flag2)
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
			bool flag3 = Operators.CompareString(this.coemail, "", false) != 0;
			if (flag3)
			{
				text2 = this.coemail;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag4 = Operators.CompareString(this.cotel, "", false) != 0;
			if (flag4)
			{
				text2 = this.cotel;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag5 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
			if (flag5)
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
			string text3 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["CustomerName"])), "", dataRow2["CustomerName"].ToString()));
			string text4 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["ContactName"])), "", dataRow2["ContactName"].ToString()));
			string text5 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Address"])), "", dataRow2["Address"].ToString()));
			string text6 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Mobile"])), "", dataRow2["Mobile"].ToString()));
			bool flag6 = Operators.CompareString(text3, "", false) != 0;
			if (flag6)
			{
				text2 = text2 + text3 + Environment.NewLine;
			}
			bool flag7 = Operators.CompareString(text4, "", false) != 0;
			if (flag7)
			{
				text2 = text2 + text4 + Environment.NewLine;
			}
			bool flag8 = Operators.CompareString(text5, "", false) != 0;
			if (flag8)
			{
				text2 = text2 + text5 + Environment.NewLine;
			}
			bool flag9 = Operators.CompareString(text6, "", false) != 0;
			if (flag9)
			{
				text2 = text2 + text6 + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			text2 = "DELIVERY ITEMS" + Environment.NewLine;
			text2 = text2 + "Description/Quantity" + Environment.NewLine + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2;
			bool flag10 = false;
			try
			{
				foreach (object obj in invoicedetailsDAT.Rows)
				{
					dataRow = (DataRow)obj;
					string text7 = dataRow["Description"].ToString();
					text7 = text7.PadRight(40, ' ');
					bool flag11 = text7.Length >= 40;
					if (flag11)
					{
						text7 = text7.Substring(0, 40);
					}
					string text8 = Conversions.ToString(dataRow["uom"]);
					bool flag12 = Operators.CompareString(text8, "EA", false) == 0;
					string text9;
					if (flag12)
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
						flag10 = true;
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
			bool flag13 = flag10;
			if (flag13)
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

		// Token: 0x06003E2A RID: 15914 RVA: 0x0022A0EC File Offset: 0x002282EC
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

		// Token: 0x06003E2B RID: 15915 RVA: 0x0022A19C File Offset: 0x0022839C
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

		// Token: 0x06003E2C RID: 15916 RVA: 0x0022A444 File Offset: 0x00228644
		private void SaveDigSig(string digsig, int invnum, string branch, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"update movement set digsig='",
				digsig,
				"' where invoicenum=",
				invnum.ToString(),
				" and branch='",
				branch,
				"' and coid=",
				coid.ToString(),
				" and trancode=3"
			});
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0022A4FC File Offset: 0x002286FC
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

		// Token: 0x06003E2E RID: 15918 RVA: 0x0022A580 File Offset: 0x00228780
		private string GetProductFormulaName(int productid, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulasTop1_pos";
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

		// Token: 0x06003E2F RID: 15919 RVA: 0x0022A634 File Offset: 0x00228834
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

		// Token: 0x06003E30 RID: 15920 RVA: 0x0022A73C File Offset: 0x0022893C
		private void ClearForm()
		{
			this.DataGridView1.Rows.Clear();
			this.txtStockAvail.Text = Conversions.ToString(0);
			this.txtPrice.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.txtSearchProductCode.Text = Conversions.ToString(0);
			this.txtTotal.Text = Conversions.ToString(0);
			this.txtcustomer.Text = "Cash";
			this.txtAddress.Text = "";
			this.txtMobile.Text = "";
			this.txtEmail.Text = "";
			this.txtMobile.Text = "";
			this.txtChange.Text = "";
			this.txtAmtPaid.Text = "";
			this.txtContactName.Text = "";
			this.txtTel.Text = "";
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
			bool flag = MyProject.Forms.Form1.TillPointPriceChange == 0;
			if (flag)
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
			bool flag2 = MyProject.Forms.Form1.DiscountEditingAllowed == 1;
			if (flag2)
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
			bool flag3 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag3)
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
			bool flag4 = Operators.CompareString(MyProject.Forms.Form1.ChangePaymentMethod, "", false) != 0;
			if (flag4)
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
			bool flag5 = MyProject.Forms.Form1.ConsultantDefaultToUsername == 1;
			if (flag5)
			{
				this.cboConsultant.SelectedIndex = this.cboConsultant.FindStringExact(MyProject.Forms.Form1.username);
			}
			else
			{
				this.cboConsultant.SelectedIndex = -1;
			}
			this.DisableEditing = false;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0022ACFC File Offset: 0x00228EFC
		private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0022AD48 File Offset: 0x00228F48
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

		// Token: 0x06003E34 RID: 15924 RVA: 0x0022ADCC File Offset: 0x00228FCC
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
				MessageBox.Show("Error deletting row. Restart SALE.");
			}
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x0022AE44 File Offset: 0x00229044
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

		// Token: 0x06003E36 RID: 15926 RVA: 0x0022AFC0 File Offset: 0x002291C0
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

		// Token: 0x06003E37 RID: 15927 RVA: 0x0022B084 File Offset: 0x00229284
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

		// Token: 0x06003E38 RID: 15928 RVA: 0x0022B18C File Offset: 0x0022938C
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

		// Token: 0x06003E39 RID: 15929 RVA: 0x0022B20C File Offset: 0x0022940C
		private void PrintReceipt(int invnumber, string revmaxdigital_signature, string printername, string copyname)
		{
			bool flag = MyProject.Forms.Form1.useOldPrintingService == 1;
			if (flag)
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
					bool flag2 = File.Exists("C:\\Quantum\\logo.bmp");
					if (flag2)
					{
						printerClass2.RTL = false;
						printerClass2.PrintLogo(checked((int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LogoSpacePadding", MyProject.Forms.Form1.Constring)))));
						printerClass2.FeedPaper(3);
					}
					this.PrintHeader(copyname);
					this.ItemsToBePrinted(invnumber);
					this.PrintFooter(revmaxdigital_signature);
					printerClass2.NormalFont();
					printerClass2.FontSize = (float)MyProject.Forms.Form1.ReceiptFontSize;
					printerClass2.WriteChars(this.TextToPrint);
					bool flag3 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
					if (flag3)
					{
						try
						{
							global::System.Drawing.Image image = this.PictureBox1.Image;
							BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39C;
							SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, invnumber.ToString(), 20);
							this.PictureBox1.Image = symbologyTestCase.BarcodeImage;
							printerClass2.PrintBarcodeImage(this.PictureBox1, 1200);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Failed to print barcode on receipt. Error: " + ex.Message);
						}
					}
					bool flag4 = (MyProject.Forms.Form1.deposits_inuse == 1) & this.DepositUsed;
					if (flag4)
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
									printerClass2.PrintBarcodeImage(this.PictureBox2, 1200);
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
					printerClass2.CutPaper();
					printerClass2.EndDoc();
					printerClass2 = null;
				}
				catch (Exception ex3)
				{
					MessageBox.Show("Error printing. Detail: " + ex3.Message);
				}
			}
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x0022B608 File Offset: 0x00229808
		private void PrintReceipt58(int invnumber)
		{
			this.PrintHeader58();
			this.ItemsToBePrinted58(invnumber);
			this.PrintFooter58();
			StandardPrintController standardPrintController = new StandardPrintController();
			this.PrintDocument1.PrintController = standardPrintController;
			this.PrintDocument1.Print();
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x0022B64C File Offset: 0x0022984C
		public void PrintHeader(string copyname)
		{
			this.coname = this.coname_og;
			this.coadd = this.coadd_og;
			this.cotel = this.cotel_og;
			this.cotel2 = this.cotel2_og;
			this.cotel3 = this.cotel3_og;
			this.coemail = this.coemail_og;
			this.coVATNum = this.coVATNum_og;
			this.cobpnum = this.cobpnum_og;
			this.bpnum_name = this.bpnum_name_og;
			this.vatnum_name = this.vatnum_name_og;
			this.footnote = this.footnote_og;
			int num = 80;
			this.TextToPrint = "";
			bool flag = copyname.Length > 0;
			if (flag)
			{
				this.TextToPrint = copyname + Environment.NewLine + Environment.NewLine;
			}
			bool flag2 = MyProject.Forms.Form1.PrintFiscal == 1;
			string text;
			if (flag2)
			{
				text = "FISCAL TAX INVOICE";
			}
			else
			{
				text = MyProject.Forms.Form1.InvoiceHeaderText;
			}
			int num2 = text.Length;
			text = this.pf.StringPadCentre(text, num);
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			this.coname = this.pf.StringPadCentre(this.coname, num);
			text = this.coname;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			bool flag3 = Operators.CompareString(this.cobpnum, "", false) != 0;
			if (flag3)
			{
				text = this.bpnum_name + " " + this.cobpnum;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			bool flag4 = Operators.CompareString(this.coVATNum, "", false) != 0;
			if (flag4)
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
			bool flag5 = Operators.CompareString(this.coemail, "", false) != 0;
			if (flag5)
			{
				text = this.coemail;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			bool flag6 = Operators.CompareString(this.cotel, "", false) != 0;
			if (flag6)
			{
				text = this.cotel;
				text = this.pf.StringPadCentre(text, 72);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			bool flag7 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
			if (flag7)
			{
				text = this.cotel2 + "  " + this.cotel3;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			text = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
			num2 = text.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			text = "Teller: " + MyProject.Forms.Form1.username;
			num2 = text.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0022BA20 File Offset: 0x00229C20
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

		// Token: 0x06003E3D RID: 15933 RVA: 0x0022BC28 File Offset: 0x00229E28
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
			DataRow dataRow2 = customerDetails.Rows[0];
			bool flag = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NORMAL", false) == 0;
			checked
			{
				if (flag)
				{
					int num2 = 30;
					int num3 = 20;
					int num4 = 20;
					int num5 = 15;
					this.ProdtDiscTotal = 0m;
					ref string ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					bool flag2 = !this.chkAccount.Checked;
					if (flag2)
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
					}
					else
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "ACCOUNT SALE" + Environment.NewLine;
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "Invoice Number: " + Conversions.ToString(invnumber);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					bool flag3 = Operators.CompareString(dataRow["ref"].ToString(), "Cash", false) != 0;
					string text;
					if (flag3)
					{
						text = Environment.NewLine + "Customer: " + dataRow2["CustomerName"].ToString();
						bool flag4 = Operators.CompareString(dataRow2["Address"].ToString(), "", false) != 0;
						if (flag4)
						{
							text = text + Environment.NewLine + "Address: " + dataRow2["Address"].ToString();
						}
						bool flag5 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
						if (flag5)
						{
							text = text + Environment.NewLine + "Phone #: " + dataRow2["Mobile"].ToString();
						}
						bool flag6 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
						if (flag6)
						{
							text = string.Concat(new string[]
							{
								text,
								Environment.NewLine,
								this.bpnum_name,
								" ",
								dataRow2["BPNumber"].ToString()
							});
						}
						bool flag7 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
						if (flag7)
						{
							text = string.Concat(new string[]
							{
								text,
								Environment.NewLine,
								this.vatnum_name,
								" ",
								dataRow2["VATNumber"].ToString()
							});
						}
						text = text + Environment.NewLine + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text;
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "Description - " + this.paymeth_currency;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine + this.LINE;
					bool flag8 = this.radSitIn.Checked | this.radTakeAway.Checked;
					if (flag8)
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
					decimal num6 = 0m;
					string text2 = "Qty";
					string text3 = "UnitPrice";
					string text4 = "VAT";
					string text5 = "SubTotal";
					text = string.Concat(new string[]
					{
						Environment.NewLine,
						text2.PadLeft(num2, ' '),
						text3.PadLeft(num3, ' '),
						text4.PadLeft(num5, ' '),
						text5.PadLeft(num4, ' ')
					});
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
					bool flag9 = num > 0;
					if (flag9)
					{
						int num7 = 0;
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow3 = (DataRow)obj;
								num7++;
								bool flag10 = decimal.Compare(Conversions.ToDecimal(dataRow3["Unit_Selling_Price"]), 0m) != 0;
								if (flag10)
								{
									string text6 = Conversions.ToString(dataRow3["Description"]);
									string text7 = Conversions.ToString(dataRow3["UOM"]);
									bool flag11 = Operators.CompareString(text7, "EA", false) == 0;
									if (flag11)
									{
										object obj2 = null;
										Type typeFromHandle = typeof(Math);
										string text8 = "Round";
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
										object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text8, array, array3, array4, array5);
										if (array6[0])
										{
											dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
										}
										num6 = Conversions.ToDecimal(obj3);
									}
									else
									{
										object obj4 = null;
										Type typeFromHandle2 = typeof(Math);
										string text9 = "Round";
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
										object obj3 = NewLateBinding.LateGet(obj4, typeFromHandle2, text9, array7, array8, array9, array10);
										if (array6[0])
										{
											dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
										}
										num6 = Conversions.ToDecimal(obj3);
									}
									bool flag12 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
									double num8;
									if (flag12)
									{
										num8 = Conversions.ToDouble(dataRow3["Unit_Selling_Price"]);
									}
									else
									{
										num8 = Conversions.ToDouble(dataRow3["Unit_Selling_Price"]);
									}
									double num9 = Conversions.ToDouble(dataRow3["Sub_Total"]);
									string text10 = Conversions.ToString(dataRow3["Product_Code"]);
									int num10 = (int)Math.Round(Conversion.Val(text6.Length));
									bool flag13 = num10 >= 34;
									if (flag13)
									{
										text6 = text6.Substring(0, 30);
									}
									bool flag14 = Operators.CompareString(dataRow3["paymethref"].ToString(), "", false) != 0;
									if (flag14)
									{
										text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["paymethref"], Environment.NewLine), Environment.NewLine));
									}
									int length = text6.Length;
									bool flag15 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
									if (flag15)
									{
										DataTable productDetailsByBarCode = this.pf.GetProductDetailsByBarCode(dataRow3["Product_Code"].ToString(), this._cnn);
										DataRow dataRow5 = productDetailsByBarCode.Rows[0];
										decimal num11 = Conversions.ToDecimal(dataRow5["TaxRate"]);
										bool flag16 = decimal.Compare(num11, 0m) > 0;
										if (flag16)
										{
											text6 = "T: " + text6;
										}
										else
										{
											text6 = "E: " + text6;
										}
									}
									decimal num12 = 0m;
									bool flag17 = dataRow3["DiscountAmt"].ToString().Length > 0;
									if (flag17)
									{
										bool flag18 = Operators.CompareString(dataRow3["DiscountAmt"].ToString(), "0.00", false) == 0;
										if (!flag18)
										{
											this.ProdtDiscTotal = Conversions.ToDecimal(Operators.MultiplyObject(dataRow3["DiscountAmt"], dataRow3["Quantity"]));
											text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Discount Given per unit: ", dataRow3["DiscountAmt"]), Environment.NewLine));
											ptr = ref this.TextToPrint;
											this.TextToPrint = ptr + text;
										}
									}
									bool flag19 = dataRow3["Comments"].ToString().Length > 50;
									if (flag19)
									{
										text = dataRow3["Comments"].ToString().Substring(0, 49) + Environment.NewLine;
										text = text + dataRow3["Comments"].ToString().Substring(50, 50) + Environment.NewLine;
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text;
									}
									else
									{
										bool flag20 = dataRow3["Comments"].ToString().Length > 0;
										if (flag20)
										{
											bool flag21 = Operators.CompareString(dataRow3["comments"].ToString(), "0", false) == 0;
											if (!flag21)
											{
												text = Conversions.ToString(Operators.ConcatenateObject(dataRow3["Comments"], Environment.NewLine));
												ptr = ref this.TextToPrint;
												this.TextToPrint = ptr + text;
											}
										}
									}
									decimal num13 = new decimal(Math.Round(num8, 2, MidpointRounding.AwayFromZero));
									num12 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(num13, num6), dataRow3["Tax"]));
									string text11 = Strings.Format(num13, "N2");
									string text12 = Strings.Format(num12, "N2");
									bool flag22 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 1, false);
									string text13;
									if (flag22)
									{
										text13 = "  -  ";
									}
									else
									{
										text13 = Strings.Format(dataRow3["Tax"].ToString(), "");
									}
									string text14 = num6.ToString();
									text = text6 + Environment.NewLine;
									text = string.Concat(new string[]
									{
										text,
										text14.ToString().PadLeft(num2, ' '),
										text11.PadLeft(num3, ' '),
										text13.PadLeft(num5, ' '),
										text12.PadLeft(num4, ' ')
									});
									ptr = ref this.TextToPrint;
									this.TextToPrint = ptr + text + Environment.NewLine;
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
					bool flag23 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NO VAT COLUMN", false) == 0;
					if (flag23)
					{
						int num14 = 30;
						int num15 = 27;
						int num16 = 27;
						this.ProdtDiscTotal = 0m;
						ref string ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
						bool flag24 = !this.chkAccount.Checked;
						if (flag24)
						{
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
						}
						else
						{
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + "ACCOUNT SALE" + Environment.NewLine;
						}
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Invoice Number: " + Conversions.ToString(invnumber);
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
						bool flag25 = Operators.CompareString(dataRow["ref"].ToString(), "Cash", false) != 0;
						string text;
						if (flag25)
						{
							text = Environment.NewLine + "Customer: " + dataRow2["CustomerName"].ToString();
							bool flag26 = Operators.CompareString(dataRow2["Address"].ToString(), "", false) != 0;
							if (flag26)
							{
								text = text + Environment.NewLine + "Address: " + dataRow2["Address"].ToString();
							}
							bool flag27 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
							if (flag27)
							{
								text = text + Environment.NewLine + "Phone #: " + dataRow2["Mobile"].ToString();
							}
							bool flag28 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
							if (flag28)
							{
								text = string.Concat(new string[]
								{
									text,
									Environment.NewLine,
									this.bpnum_name,
									" ",
									dataRow2["BPNumber"].ToString()
								});
							}
							bool flag29 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
							if (flag29)
							{
								text = string.Concat(new string[]
								{
									text,
									Environment.NewLine,
									this.vatnum_name,
									" ",
									dataRow2["VATNumber"].ToString()
								});
							}
							text = text + Environment.NewLine + Environment.NewLine;
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text;
						}
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + "Description - " + this.paymeth_currency;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine + this.LINE;
						bool flag30 = this.radSitIn.Checked | this.radTakeAway.Checked;
						if (flag30)
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
						decimal num17 = 0m;
						string text15 = "Qty";
						string text16 = "UnitPrice";
						string text17 = "SubTotal";
						text = Environment.NewLine + text15.PadLeft(num14, ' ') + text16.PadLeft(num15, ' ') + text17.PadLeft(num16, ' ');
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text + Environment.NewLine;
						bool flag31 = num > 0;
						if (flag31)
						{
							int num18 = 0;
							try
							{
								foreach (object obj5 in dataTable.Rows)
								{
									DataRow dataRow6 = (DataRow)obj5;
									num18++;
									bool flag32 = decimal.Compare(Conversions.ToDecimal(dataRow6["Unit_Selling_Price"]), 0m) != 0;
									if (flag32)
									{
										string text18 = Conversions.ToString(dataRow6["Description"]);
										string text19 = Conversions.ToString(dataRow6["UOM"]);
										bool flag33 = Operators.CompareString(text19, "EA", false) == 0;
										if (flag33)
										{
											object obj6 = null;
											Type typeFromHandle3 = typeof(Math);
											string text20 = "Round";
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
											object obj3 = NewLateBinding.LateGet(obj6, typeFromHandle3, text20, array11, array12, array13, array14);
											if (array6[0])
											{
												dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
											}
											num17 = Conversions.ToDecimal(obj3);
										}
										else
										{
											object obj7 = null;
											Type typeFromHandle4 = typeof(Math);
											string text21 = "Round";
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
											object obj3 = NewLateBinding.LateGet(obj7, typeFromHandle4, text21, array15, array16, array17, array18);
											if (array6[0])
											{
												dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
											}
											num17 = Conversions.ToDecimal(obj3);
										}
										double num19 = Conversions.ToDouble(Operators.AddObject(dataRow6["Unit_Selling_Price"], Operators.DivideObject(dataRow6["Tax"], dataRow6["Quantity"])));
										double num20 = Conversions.ToDouble(dataRow6["Sub_Total"]);
										string text22 = Conversions.ToString(dataRow6["Product_Code"]);
										int num21 = (int)Math.Round(Conversion.Val(text18.Length));
										bool flag34 = num21 >= 34;
										if (flag34)
										{
											text18 = text18.Substring(0, 30);
										}
										bool flag35 = Operators.CompareString(dataRow6["paymethref"].ToString(), "", false) != 0;
										if (flag35)
										{
											text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow6["paymethref"], Environment.NewLine), Environment.NewLine));
										}
										int length2 = text18.Length;
										bool flag36 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
										if (flag36)
										{
											DataTable productDetailsByBarCode2 = this.pf.GetProductDetailsByBarCode(dataRow6["Product_Code"].ToString(), this._cnn);
											DataRow dataRow7 = productDetailsByBarCode2.Rows[0];
											decimal num22 = Conversions.ToDecimal(dataRow7["TaxRate"]);
											bool flag37 = decimal.Compare(num22, 0m) > 0;
											if (flag37)
											{
												text18 = "T: " + text18;
											}
											else
											{
												text18 = "E: " + text18;
											}
										}
										decimal num23 = 0m;
										bool flag38 = dataRow6["DiscountAmt"].ToString().Length > 0;
										if (flag38)
										{
											bool flag39 = Operators.CompareString(dataRow6["DiscountAmt"].ToString(), "0.00", false) == 0;
											if (!flag39)
											{
												this.ProdtDiscTotal = Conversions.ToDecimal(Operators.MultiplyObject(dataRow6["DiscountAmt"], dataRow6["Quantity"]));
												text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Discount Given per unit: ", dataRow6["DiscountAmt"]), Environment.NewLine));
												ptr = ref this.TextToPrint;
												this.TextToPrint = ptr + text;
											}
										}
										bool flag40 = dataRow6["Comments"].ToString().Length > 50;
										if (flag40)
										{
											text = dataRow6["Comments"].ToString().Substring(0, 49) + Environment.NewLine;
											text = text + dataRow6["Comments"].ToString().Substring(50, 50) + Environment.NewLine;
											ptr = ref this.TextToPrint;
											this.TextToPrint = ptr + text;
										}
										else
										{
											bool flag41 = dataRow6["Comments"].ToString().Length > 0;
											if (flag41)
											{
												bool flag42 = Operators.CompareString(dataRow6["comments"].ToString(), "0", false) == 0;
												if (!flag42)
												{
													text = Conversions.ToString(Operators.ConcatenateObject(dataRow6["Comments"], Environment.NewLine));
													ptr = ref this.TextToPrint;
													this.TextToPrint = ptr + text;
												}
											}
										}
										decimal num24 = new decimal(Math.Round(num19, 2, MidpointRounding.AwayFromZero));
										num23 = Conversions.ToDecimal(dataRow6["Sub_Total"]);
										string text23 = Strings.Format(num24, "N2");
										string text24 = Strings.Format(num23, "N2");
										bool flag43 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow6["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow6["taxexempt"])), 1, false);
										if (!flag43)
										{
											string text25 = Strings.Format(dataRow6["Tax"].ToString(), "");
										}
										string text26 = num17.ToString();
										text = text18 + Environment.NewLine;
										text = text + text26.ToString().PadLeft(num14, ' ') + text23.PadLeft(num15, ' ') + text24.PadLeft(num16, ' ');
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text + Environment.NewLine;
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
			}
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0022D1E8 File Offset: 0x0022B3E8
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

		// Token: 0x06003E3F RID: 15935 RVA: 0x0022D624 File Offset: 0x0022B824
		private void PrintFooter(string RevmaxDigital_Signature)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			string text = "TOTAL VAT:     ";
			string text2 = Strings.Format(Conversion.Val(this.txtTax.Text), "N2");
			string text3 = text.PadRight(15, ' ') + text2.PadRight(30, ' ');
			string text4 = Conversions.ToString(text3.Length);
			int length = text3.Length;
			bool flag = Conversions.ToDouble(text4) < 63.0;
			double num4;
			bool flag7;
			checked
			{
				if (flag)
				{
					string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(63.0 - Conversions.ToDouble(text4)))));
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + string.Format("{0,20}", text3);
				bool flag2 = decimal.Compare(this.ProdtDiscTotal, 0m) != 0;
				if (flag2)
				{
					string text6 = Math.Round(this.ProdtDiscTotal, 2, MidpointRounding.AwayFromZero).ToString();
					text3 = string.Format("{0,20}", "Prodt Disc Total: " + text6.PadLeft(30, ' '));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine + text3;
				}
				text3 = "";
				bool flag3 = Conversion.Val(this.txtDiscount.Text) > 0.0;
				if (flag3)
				{
					decimal num = new decimal(unchecked(Conversion.Val(this.txtTotal.Text) + Conversion.Val(this.txtDiscount.Text)));
					string text7 = Strings.Format(num, "N2");
					decimal num2 = new decimal(Conversion.Val(this.txtDiscount.Text));
					string text8 = Strings.Format(num2, "N2");
					text3 += string.Format("{0,20}", "Inv. Subtotal: " + text7.PadLeft(30, ' '));
					text3 = text3 + Environment.NewLine + string.Format("{0,20}", "Inv. Discount: " + text8.PadLeft(31 - text8.Length, ' ')) + Environment.NewLine;
				}
				string text9 = "INVOICE TOTAL:";
				bool flag4 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
				if (flag4)
				{
					decimal num3 = decimal.Multiply(Convert.ToDecimal(this.txtTotal.Text), this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn));
					string text10 = Strings.Format(num3, "N2");
					text3 += string.Format("{0,20}", text9.PadRight(15, ' ') + text10);
				}
				else
				{
					string text11 = Strings.Format(Conversion.Val(this.txtTotal.Text), "N2");
					text3 += string.Format("{0,20}", text9.PadRight(15, ' ') + text11);
				}
				text3 = text3 + Environment.NewLine + this.LINE;
				text4 = Conversions.ToString(text3.Length);
				bool flag5 = Conversions.ToDouble(text4) < 63.0;
				if (flag5)
				{
					string text12 = new string(' ', (int)Math.Round(Math.Round(unchecked(63.0 - Conversions.ToDouble(text4)))));
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					Environment.NewLine,
					text3,
					Environment.NewLine,
					Environment.NewLine
				});
				bool flag6 = Operators.CompareString(this.txtAmtPaid.Text, "", false) == 0;
				if (flag6)
				{
					num4 = 0.0;
				}
				else
				{
					num4 = Conversion.Val(this.txtAmtPaid.Text);
				}
				flag7 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
			}
			if (flag7)
			{
				num4 *= Convert.ToDouble(this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn));
			}
			string text13 = "PAID: ";
			string text14 = Strings.Format(num4, "N2");
			text3 = text13 + text14;
			text4 = Conversions.ToString(length);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3;
			string text15 = "CHANGE: ";
			string text16 = Strings.Format(Conversion.Val(this.pf.RemoveComma(this.txtChange.Text)), "N2");
			text3 = text15 + text16;
			text4 = Conversions.ToString(length);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine + text3 + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			text3 = "CUSTOMER: " + this.txtcustomer.Text;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine;
			bool flag8 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
			if (flag8)
			{
				bool @checked = this.chkAccount.Checked;
				string text17;
				if (@checked)
				{
					text17 = "Account";
				}
				else
				{
					text17 = "COD";
				}
				text3 = this.LINE;
				text3 = text3 + Environment.NewLine + "Payment Method:" + text17;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
				bool flag9 = !this.chkAccount.Checked;
				if (flag9)
				{
					bool checked2 = this.chkMultiple.Checked;
					if (checked2)
					{
						try
						{
							foreach (object obj in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								bool flag10 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["amtpaid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["amtpaid"])), 0, false);
								if (flag10)
								{
									text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["paymentmethoddesc"], ": "), Strings.Format(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["amtpaid"])), "N2")));
									ptr = ref this.TextToPrint;
									this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
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
						text3 = this.cboPayMeth.Text + ": " + Strings.Format(Conversion.Val(this.txtAmtPaid.Text), "N2");
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
					}
				}
			}
			bool checked3 = this.chkAccount.Checked;
			if (checked3)
			{
				decimal num5 = new decimal(this.pf.GetCustomerBillTotal(Conversions.ToInteger(this.txtcustomer.Text), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn));
				text3 = "Account balance: " + MyProject.Forms.Form1.basecurrency + Conversions.ToString(num5);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
			}
			text3 = this.footnote;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
			bool flag11 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1) & (MyProject.Forms.Form1.PrintReceipt == 1);
			checked
			{
				if (flag11)
				{
					text3 = "";
					int length2 = RevmaxDigital_Signature.Length;
					for (int i = 0; i <= length2; i += 50)
					{
						int num6 = length2 - i;
						bool flag12 = num6 > 50;
						if (flag12)
						{
							num6 = 50;
						}
						text3 = text3 + RevmaxDigital_Signature.Substring(i, num6) + Environment.NewLine;
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				}
			}
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0022DF48 File Offset: 0x0022C148
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

		// Token: 0x06003E41 RID: 15937 RVA: 0x0022E300 File Offset: 0x0022C500
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			global::System.Drawing.Font font = new global::System.Drawing.Font("Times New Roman", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			checked
			{
				int num7 = (int)Math.Round(Math.Round((double)num3 / 1.0));
				iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle((float)num5, (float)num6, (float)num4, (float)num3);
				global::System.Drawing.Rectangle rectangle2 = default(global::System.Drawing.Rectangle);
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

		// Token: 0x06003E42 RID: 15938 RVA: 0x0022E458 File Offset: 0x0022C658
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x0022E480 File Offset: 0x0022C680
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

		// Token: 0x06003E44 RID: 15940 RVA: 0x0022E504 File Offset: 0x0022C704
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

		// Token: 0x06003E45 RID: 15941 RVA: 0x0022E5D8 File Offset: 0x0022C7D8
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

		// Token: 0x06003E46 RID: 15942 RVA: 0x0022E658 File Offset: 0x0022C858
		private void PrintInvoice(string revmax_digsig, int isEltradeESDfiscal)
		{
			bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
			if (flag)
			{
				SalesInvoiceWholesale salesInvoiceWholesale = new SalesInvoiceWholesale();
				salesInvoiceWholesale.invnum = this.invnum;
				salesInvoiceWholesale.ShowDialog(this);
				salesInvoiceWholesale.Dispose();
			}
			else
			{
				bool flag2 = MyProject.Forms.Form1.inv_template_normal == 1;
				if (flag2)
				{
					SalesInvoicePortrait salesInvoicePortrait = new SalesInvoicePortrait();
					salesInvoicePortrait.invnum = this.invnum;
					salesInvoicePortrait.revmax_sign = revmax_digsig;
					salesInvoicePortrait.isEltradeESDfiscal = isEltradeESDfiscal;
					salesInvoicePortrait.branch = MyProject.Forms.Form1.branch;
					bool flag3 = MyProject.Forms.Form1.AllowInvDiscount == 1;
					if (flag3)
					{
						salesInvoicePortrait.showinvdisc = 1;
					}
					salesInvoicePortrait.ShowDialog(this);
					salesInvoicePortrait.Dispose();
				}
				else
				{
					bool flag4 = MyProject.Forms.Form1.inv_template_incotex == 1;
					if (flag4)
					{
						SalesInvoicePortraitInco salesInvoicePortraitInco = new SalesInvoicePortraitInco();
						salesInvoicePortraitInco.invnum = this.invnum;
						salesInvoicePortraitInco.revmax_sign = revmax_digsig;
						salesInvoicePortraitInco.isEltradeESDfiscal = isEltradeESDfiscal;
						salesInvoicePortraitInco.branch = MyProject.Forms.Form1.branch;
						bool flag5 = MyProject.Forms.Form1.AllowInvDiscount == 1;
						if (flag5)
						{
							salesInvoicePortraitInco.showinvdisc = 1;
						}
						salesInvoicePortraitInco.ShowDialog(this);
						salesInvoicePortraitInco.Dispose();
					}
					else
					{
						bool flag6 = MyProject.Forms.Form1.inv_template_revmax == 1;
						if (flag6)
						{
							SalesInvoiceRevmax salesInvoiceRevmax = new SalesInvoiceRevmax();
							salesInvoiceRevmax.invnum = this.invnum;
							salesInvoiceRevmax.revmax_sign = revmax_digsig;
							salesInvoiceRevmax.isEltradeESDfiscal = isEltradeESDfiscal;
							salesInvoiceRevmax.branch = MyProject.Forms.Form1.branch;
							bool flag7 = MyProject.Forms.Form1.AllowInvDiscount == 1;
							if (flag7)
							{
								salesInvoiceRevmax.showinvdisc = 1;
							}
							salesInvoiceRevmax.ShowDialog(this);
							salesInvoiceRevmax.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x0022E838 File Offset: 0x0022CA38
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

		// Token: 0x06003E48 RID: 15944 RVA: 0x0022E88C File Offset: 0x0022CA8C
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
					this.cotel_og = dataRow["Tel"].ToString();
					this.cotel2_og = dataRow["Tel2"].ToString();
					this.cotel3_og = dataRow["Tel3"].ToString();
					this.coemail_og = dataRow["Email"].ToString();
					this.cobpnum_og = dataRow["BPNumber"].ToString();
					this.footnote_og = dataRow["Footnote"].ToString();
					this.coVATNum_og = dataRow["VATNumber"].ToString();
					this.bpnum_name_og = Conversions.ToString(dataRow["BPNumber_name"]);
					this.vatnum_name_og = Conversions.ToString(dataRow["VATNumber_name"]);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x0022EA70 File Offset: 0x0022CC70
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

		// Token: 0x06003E4A RID: 15946 RVA: 0x0022EB00 File Offset: 0x0022CD00
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

		// Token: 0x06003E4B RID: 15947 RVA: 0x0022EB48 File Offset: 0x0022CD48
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

		// Token: 0x06003E4C RID: 15948 RVA: 0x0022EEB0 File Offset: 0x0022D0B0
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

		// Token: 0x06003E4D RID: 15949 RVA: 0x0022F210 File Offset: 0x0022D410
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

		// Token: 0x06003E4E RID: 15950 RVA: 0x0022F268 File Offset: 0x0022D468
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

		// Token: 0x06003E4F RID: 15951 RVA: 0x0022F36C File Offset: 0x0022D56C
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

		// Token: 0x06003E50 RID: 15952 RVA: 0x0022F4EC File Offset: 0x0022D6EC
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
			bool flag3 = this.currentCustomerEntryNo == 0;
			if (flag3)
			{
				this.GetCustomerEntryNo(this.txtcustomer.Text);
			}
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0022F718 File Offset: 0x0022D918
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

		// Token: 0x06003E52 RID: 15954 RVA: 0x0022F7F8 File Offset: 0x0022D9F8
		private void LoadCustomers()
		{
			this.datCustomers.Clear();
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
			this.cboCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cboCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x0022F8E4 File Offset: 0x0022DAE4
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

		// Token: 0x06003E54 RID: 15956 RVA: 0x0022F96C File Offset: 0x0022DB6C
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

		// Token: 0x06003E55 RID: 15957 RVA: 0x0022FA64 File Offset: 0x0022DC64
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

		// Token: 0x06003E56 RID: 15958 RVA: 0x0022FB70 File Offset: 0x0022DD70
		private object searchDat(DataTable dt, string column, string value)
		{
			Sales2mono._Closure$__894-0 CS$<>8__locals1 = new Sales2mono._Closure$__894-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((Sales2mono._Closure$__.$I894-0 == null) ? (Sales2mono._Closure$__.$I894-0 = (object row1) => (DataRow)row1) : Sales2mono._Closure$__.$I894-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06003E57 RID: 15959 RVA: 0x0022FC4C File Offset: 0x0022DE4C
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

		// Token: 0x06003E58 RID: 15960 RVA: 0x0022FD0C File Offset: 0x0022DF0C
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

		// Token: 0x06003E59 RID: 15961 RVA: 0x0022FF1C File Offset: 0x0022E11C
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

		// Token: 0x06003E5A RID: 15962 RVA: 0x0022FF7C File Offset: 0x0022E17C
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

		// Token: 0x06003E5B RID: 15963 RVA: 0x00230040 File Offset: 0x0022E240
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

		// Token: 0x06003E5C RID: 15964 RVA: 0x002300A0 File Offset: 0x0022E2A0
		private void SearchBarCode(int prodtID)
		{
			this.txtPriceChange.Text = "";
			this.WholesalePriceByQty = 0;
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
					bool flag3 = (MyProject.Forms.Form1.autoBreakCase == 1) & (this.currParentCaseID != 0);
					if (flag3)
					{
						DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, this.currParentCaseID, this._cnn);
						this.currCaseQty = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])), 0, RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])));
					}
					int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
					this.isunedingstock = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
					try
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(dataRow["ispricevariable"], 1, false);
						if (flag4)
						{
							this.txtPrice.Enabled = true;
							this.txtPrice.ReadOnly = false;
						}
						else
						{
							this.EffectTillpointPrice();
						}
					}
					catch (Exception ex)
					{
					}
					bool flag5 = num2 == 0;
					decimal num4;
					decimal num5;
					if (flag5)
					{
						DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag6 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
						if (flag6)
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
						bool flag7 = MyProject.Forms.Form1.CalcBackwards == 1;
						if (flag7)
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
						this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
						this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["specialprice"]))));
					}
					else
					{
						DataRow productPayMethodDiscount2 = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag8 = Operators.ConditionalCompareObjectGreater(productPayMethodDiscount2["disc"], 0, false);
						if (flag8)
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
					bool flag9 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
					if (flag9)
					{
						bool flag10 = MyProject.Forms.Form1.CalcBackwards == 1;
						decimal num7;
						if (flag10)
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
						this.priceb4taxWholesale = num5;
						this.priceb4taxWholesale = this.priceb4taxWholesale;
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = decimal.Add(num5, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num5));
						this.totpriceWholesale = this.totpriceWholesale;
						bool flag11 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag11)
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
						this.priceb4tax = Math.Round(decimal.Divide(num4, decimal.Add(1m, decimal.Divide(num6, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						this.currenttaxrate = num6;
						decimal num8 = num4;
						num8 = num8;
						this.priceb4taxWholesale = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num6, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = num5;
						bool flag12 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag12)
						{
							this.txtPrice.Text = this.totpriceWholesale.ToString();
						}
						else
						{
							this.txtPrice.Text = num8.ToString();
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
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
					this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
					bool flag13 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.currentExpires;
					if (flag13)
					{
						this.txtQty.Visible = false;
						this.Label4.Visible = false;
						this.Button1.Text = "SELECT";
					}
					else
					{
						bool flag14 = this.currentIsCalcLxW;
						if (flag14)
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

		// Token: 0x06003E5D RID: 15965 RVA: 0x00230FF8 File Offset: 0x0022F1F8
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
						bool flag4 = (MyProject.Forms.Form1.autoBreakCase == 1) & (this.currParentCaseID != 0);
						if (flag4)
						{
							DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, this.currParentCaseID, this._cnn);
							this.currCaseQty = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])), 0, RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])));
						}
						int num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
						this.isunedingstock = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
						try
						{
							bool flag5 = Operators.ConditionalCompareObjectEqual(dataRow["ispricevariable"], 1, false);
							if (flag5)
							{
								this.txtPrice.Enabled = true;
								this.txtPrice.ReadOnly = false;
							}
							else
							{
								this.EffectTillpointPrice();
							}
						}
						catch (Exception ex)
						{
						}
						DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataRow["ProductID"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag6 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
						if (flag6)
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
						bool flag7 = num3 == 0;
						decimal num5;
						decimal num6;
						if (flag7)
						{
							bool flag8 = MyProject.Forms.Form1.CalcBackwards == 1;
							if (flag8)
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
						bool flag9 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
						if (flag9)
						{
							num7 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							bool flag10 = MyProject.Forms.Form1.CalcBackwards == 1;
							decimal num8;
							if (flag10)
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
							bool flag11 = MyProject.Forms.Form1.IsWholesaleShop == 1;
							if (flag11)
							{
								bool flag12 = use_price_from_scale == 1;
								if (flag12)
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
								bool flag13 = use_price_from_scale == 1;
								if (flag13)
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
							this.priceb4tax = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num7, 100m))), 5, MidpointRounding.AwayFromZero);
							this.currenttaxrate = num7;
							decimal num9 = num5;
							num9 = num9;
							this.priceb4taxWholesale = Math.Round(decimal.Divide(num6, decimal.Add(1m, decimal.Divide(num7, 100m))), 5, MidpointRounding.AwayFromZero);
							this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
							this.totpriceWholesale = num6;
							bool flag14 = MyProject.Forms.Form1.IsWholesaleShop == 1;
							if (flag14)
							{
								bool flag15 = use_price_from_scale == 1;
								if (flag15)
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
								bool flag16 = use_price_from_scale == 1;
								if (flag16)
								{
									this.txtPrice.Text = Conversions.ToString(price_from_scale);
								}
								else
								{
									this.txtPrice.Text = num9.ToString();
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
						this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
						this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
						bool flag17 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.currentExpires;
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
								this.Label4.Visible = true;
								this.Button1.Text = "Enter";
								this.txtQty.Enabled = true;
							}
						}
						this.currentUOM = dataRow["UOM"].ToString();
						this.currentIsDeposit = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])), 0, RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])));
						this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
						bool flag19 = Operators.CompareString(this.txtBarCode.Text, "1", false) == 0;
						if (flag19)
						{
							this.txtPrice.Focus();
						}
						else
						{
							bool flag20 = MyProject.Forms.Form1.DontAutoAppendAfterBarcodeSearch == 1;
							if (flag20)
							{
								bool flag21 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
								if (flag21)
								{
									this.txtsearch.Focus();
								}
								else
								{
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
					bool flag22 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag22)
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

		// Token: 0x06003E5E RID: 15966 RVA: 0x00232030 File Offset: 0x00230230
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

		// Token: 0x06003E5F RID: 15967 RVA: 0x00232280 File Offset: 0x00230480
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

		// Token: 0x06003E60 RID: 15968 RVA: 0x00232324 File Offset: 0x00230524
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

		// Token: 0x06003E61 RID: 15969 RVA: 0x002323D4 File Offset: 0x002305D4
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.CheckShiftStatus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00232424 File Offset: 0x00230624
		private void btnShift_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure your shift has ended and you want to exit?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.CloseShift(MyProject.Forms.Form1.shiftdate, this.lblShift.Text, MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")))));
					bool flag2 = MyProject.Forms.Form1.IsBlindCashUp == 0;
					if (flag2)
					{
						ShiftReportForm shiftReportForm = new ShiftReportForm();
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

		// Token: 0x06003E63 RID: 15971 RVA: 0x00232520 File Offset: 0x00230720
		private void CloseShift(int shiftdate, string shiftname, string shiftuser, int coid, int endtime)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CloseShift";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			sqlCommand.Parameters.AddWithValue("shiftuser", shiftuser);
			sqlCommand.Parameters.AddWithValue("shiftname", shiftname);
			sqlCommand.Parameters.AddWithValue("endtime", endtime);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x002325F8 File Offset: 0x002307F8
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag15;
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
													this.ProcessMultipay();
												}
												else
												{
													bool flag10 = msg.WParam.ToInt32() == 116;
													if (flag10)
													{
														this.ProcessSale();
													}
													else
													{
														bool flag11 = msg.WParam.ToInt32() == 123;
														if (flag11)
														{
															bool flag12 = MyProject.Forms.Form1.BarFastExchange == 1;
															if (flag12)
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
															bool flag13 = msg.WParam.ToInt32() == 117;
															if (flag13)
															{
																this.radSitIn.Checked = true;
															}
															else
															{
																bool flag14 = msg.WParam.ToInt32() == 118;
																if (flag14)
																{
																	this.radTakeAway.Checked = true;
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
				flag15 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag15;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x002328D4 File Offset: 0x00230AD4
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

		// Token: 0x06003E67 RID: 15975 RVA: 0x0023293C File Offset: 0x00230B3C
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

		// Token: 0x06003E68 RID: 15976 RVA: 0x002329C4 File Offset: 0x00230BC4
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

		// Token: 0x06003E69 RID: 15977 RVA: 0x00232A3C File Offset: 0x00230C3C
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

		// Token: 0x06003E6A RID: 15978 RVA: 0x00232D3C File Offset: 0x00230F3C
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

		// Token: 0x06003E6B RID: 15979 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x00232E90 File Offset: 0x00231090
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void OpenCashDrawer()
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(1, AppDomain.CurrentDomain.BaseDirectory + "open.txt", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
			FileSystem.PrintLine(1, new object[] { "\u001bp\0\u0019" + Conversions.ToString(Strings.Chr(250)) });
			FileSystem.FileClose(new int[] { 1 });
			Interaction.Shell("print /d:com1 open.txt", AppWinStyle.Hide, false, -1);
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x00232F0C File Offset: 0x0023110C
		private void cboCustomers_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x00232F40 File Offset: 0x00231140
		private DataTable searchDat(string stext)
		{
			DataTable dataTable = new DataTable();
			return this.datCustomers.Select("CustomerName LIKE '%" + stext + "%'").CopyToDataTable<DataRow>();
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboCustomers_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x00232F7C File Offset: 0x0023117C
		private void AutoCompleteCombo_Leave(ComboBox cbo)
		{
			int num = cbo.FindStringExact(cbo.Text);
			cbo.SelectedIndex = num;
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboCustomers_KeyUp(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x00232FA0 File Offset: 0x002311A0
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

		// Token: 0x06003E73 RID: 15987 RVA: 0x00233038 File Offset: 0x00231238
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

		// Token: 0x06003E74 RID: 15988 RVA: 0x002330D8 File Offset: 0x002312D8
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
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0023321C File Offset: 0x0023141C
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

		// Token: 0x06003E76 RID: 15990 RVA: 0x00233310 File Offset: 0x00231510
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

		// Token: 0x06003E77 RID: 15991 RVA: 0x0023346C File Offset: 0x0023166C
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

		// Token: 0x06003E78 RID: 15992 RVA: 0x002334F0 File Offset: 0x002316F0
		private void txtPriceChange_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00233558 File Offset: 0x00231758
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
							decimal num = new decimal(Convert.ToDouble(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m)) * Conversion.Val(this.txtPrice.Text) * -1.0);
							this.txtPriceChange.Text = num.ToString();
							ref string ptr = ref this.discDESC;
							this.discDESC = ptr + "Product Discount Approved by " + MyProject.Forms.Form1.Approvedby;
							MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
							this.Button1.Focus();
						}
						else
						{
							decimal num2 = decimal.Multiply(MyProject.Forms.Form1.DiscountApprovedAmt, -1m);
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

		// Token: 0x06003E7A RID: 15994 RVA: 0x002337D4 File Offset: 0x002319D4
		private void cboPayMeth_Validating(object sender, CancelEventArgs e)
		{
			bool flag = this.DataGridView1.RowCount > 0;
			if (flag)
			{
			}
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x002337F8 File Offset: 0x002319F8
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

		// Token: 0x06003E7C RID: 15996 RVA: 0x00233878 File Offset: 0x00231A78
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

		// Token: 0x06003E7D RID: 15997 RVA: 0x00233928 File Offset: 0x00231B28
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
										decimal num9 = Math.Round(num8, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
										num9 = decimal.Multiply(num9, this.mono_rate);
										decimal num10 = Math.Round(decimal.Divide(num9, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
										dataGridViewRow.Cells["UnitPrice"].Value = num10;
										dataGridViewRow.Cells["Tax"].Value = Operators.MultiplyObject(Math.Round(decimal.Multiply(num10, decimal.Divide(num5, 100m)), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero), dataGridViewRow.Cells["Qty"].Value);
									}
									else
									{
										decimal num9 = Math.Round(decimal.Multiply(num8, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
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

		// Token: 0x06003E7E RID: 15998 RVA: 0x002346E0 File Offset: 0x002328E0
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

		// Token: 0x06003E7F RID: 15999 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x002347EC File Offset: 0x002329EC
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
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Wholesale qty error. disregard.");
			}
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x002349B4 File Offset: 0x00232BB4
		private void txtAmtPaid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ProcessSale();
				e.Handled = true;
			}
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x002349E4 File Offset: 0x00232BE4
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

		// Token: 0x06003E84 RID: 16004 RVA: 0x00234A60 File Offset: 0x00232C60
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

		// Token: 0x06003E85 RID: 16005 RVA: 0x00234B20 File Offset: 0x00232D20
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

		// Token: 0x06003E86 RID: 16006 RVA: 0x00234CC8 File Offset: 0x00232EC8
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

		// Token: 0x06003E87 RID: 16007 RVA: 0x00002A30 File Offset: 0x00000C30
		private void lblcost_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x00234EA4 File Offset: 0x002330A4
		private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x00234EF0 File Offset: 0x002330F0
		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x00234F24 File Offset: 0x00233124
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

		// Token: 0x06003E8B RID: 16011 RVA: 0x00234F94 File Offset: 0x00233194
		private void Button10_Click(object sender, EventArgs e)
		{
			try
			{
				this.coname = this.coname_og;
				this.coadd = this.coadd_og;
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

		// Token: 0x06003E8C RID: 16012 RVA: 0x00235144 File Offset: 0x00233344
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

		// Token: 0x06003E8D RID: 16013 RVA: 0x002354E4 File Offset: 0x002336E4
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

		// Token: 0x06003E8E RID: 16014 RVA: 0x00235A68 File Offset: 0x00233C68
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

		// Token: 0x06003E8F RID: 16015 RVA: 0x00235D54 File Offset: 0x00233F54
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
						sqlCommand.Parameters.AddWithValue("timesaved", DateTime.Now.ToString("HH:mm"));
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
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
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
								sqlCommand.Parameters.AddWithValue("mno", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["MNO"].Value));
								sqlCommand.Parameters.AddWithValue("iswholesaleprice", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["iswholesaleprice"].Value)));
								sqlCommand.Parameters.AddWithValue("wholesaleqtydiscount", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["wholesaleqtydiscount"].Value)));
								sqlCommand.Parameters.AddWithValue("entryno", num2);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("consultant", this.cboConsultant.Text);
								sqlCommand.Parameters.AddWithValue("promstatus", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PromStatus"].Value));
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("ExpiryDate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
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
								sqlCommand.Parameters.AddWithValue("isdeposits", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isdeposits"].Value));
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
						bool flag5 = MyProject.Forms.Form1.PrintReceipt == 1;
						if (flag5)
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
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error saving quotation. Detail: " + ex3.Message);
			}
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x00236910 File Offset: 0x00234B10
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

		// Token: 0x06003E91 RID: 16017 RVA: 0x00236B00 File Offset: 0x00234D00
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

		// Token: 0x06003E92 RID: 16018 RVA: 0x00236FE0 File Offset: 0x002351E0
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

		// Token: 0x06003E93 RID: 16019 RVA: 0x00237080 File Offset: 0x00235280
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

		// Token: 0x06003E94 RID: 16020 RVA: 0x0023711C File Offset: 0x0023531C
		private string BuildItemsXML(DataTable prodt_items)
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("ITEMS");
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in prodt_items.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						num++;
						this.MakeItems(xmlWriter, num, Conversions.ToString(dataRow["ProductCode"]), Conversions.ToString(dataRow["ProductDesc"]), Conversions.ToString(dataRow["ProductDesc"]), Conversions.ToDecimal(dataRow["Qty"]), Conversions.ToDecimal(dataRow["SellingPrice"]), Conversions.ToDecimal(dataRow["Total"]), Conversions.ToDecimal(dataRow["Tax"]), Conversions.ToDecimal(dataRow["Taxr"]));
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
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndDocument();
				xmlWriter.Flush();
				StreamReader streamReader = new StreamReader(memoryStream);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadToEnd();
				xmlWriter.Close();
				return text;
			}
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x00237294 File Offset: 0x00235494
		private void MakeItems(XmlWriter xml_text_writer, int item_number, string item_code, string item_desc, string item_desc2, decimal item_qty, decimal item_price, decimal item_amt, decimal item_tax, decimal item_taxr)
		{
			xml_text_writer.WriteStartElement("ITEM");
			xml_text_writer.WriteStartElement("HH");
			xml_text_writer.WriteString(Conversions.ToString(item_number));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMCODE");
			xml_text_writer.WriteString(item_code);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMNAME1");
			xml_text_writer.WriteString(item_desc);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMNAME2");
			xml_text_writer.WriteString(item_desc2);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("QTY");
			xml_text_writer.WriteString(Conversions.ToString(item_qty));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("PRICE");
			xml_text_writer.WriteString(Conversions.ToString(item_price));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("AMT");
			xml_text_writer.WriteString(Conversions.ToString(item_amt));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("TAX");
			xml_text_writer.WriteString(Conversions.ToString(item_tax));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("TAXR");
			xml_text_writer.WriteString(Conversions.ToString(item_taxr));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteEndElement();
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x002373D0 File Offset: 0x002355D0
		private void MakeCurrency(XmlWriter xml_text_writer, string Name, decimal curr_amt, decimal rate)
		{
			xml_text_writer.WriteStartElement("Currency");
			xml_text_writer.WriteStartElement("Name");
			xml_text_writer.WriteString(Name);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("Amount");
			xml_text_writer.WriteString(Conversions.ToString(curr_amt));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("Rate");
			xml_text_writer.WriteString(Conversions.ToString(rate));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteEndElement();
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00237450 File Offset: 0x00235650
		private string BuildCurrencyXML(string currency_desc, decimal currency_amt, decimal currency_rate)
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("CurrenciesReceived");
			bool flag = Operators.CompareString(currency_desc, "USD", false) == 0;
			if (flag)
			{
				this.MakeCurrency(xmlWriter, "ZWL", 0m, 130m);
				this.MakeCurrency(xmlWriter, currency_desc, currency_amt, currency_rate);
			}
			else
			{
				bool flag2 = Operators.CompareString(currency_desc, "ZWL", false) == 0;
				if (flag2)
				{
					this.MakeCurrency(xmlWriter, currency_desc, currency_amt, currency_rate);
					this.MakeCurrency(xmlWriter, "USD", 0m, 1m);
				}
				else
				{
					MessageBox.Show("Currency is not USD or ZWL. Contact System Developer.");
				}
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			StreamReader streamReader = new StreamReader(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			string text = streamReader.ReadToEnd();
			xmlWriter.Close();
			return text;
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x0023755C File Offset: 0x0023575C
		private void Button14_Click(object sender, EventArgs e)
		{
			try
			{
				string text = MyProject.Forms.Form1.myrevmax.ZReport();
				MessageBox.Show("Z Report feedback: " + text);
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete this customer?", MsgBoxStyle.YesNo, null);
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

		// Token: 0x06003E99 RID: 16025 RVA: 0x0023765C File Offset: 0x0023585C
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
							string value = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PromStatus"].Value));
							bool flag = (Operators.CompareString(value, "2", false) == 0) | (Operators.CompareString(value, "", false) == 0);
							if (flag)
							{
								text = text + ";" + dataGridViewRow.Cells["ProdtID"].Value.ToString() + ";";
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

		// Token: 0x06003E9A RID: 16026 RVA: 0x00238290 File Offset: 0x00236490
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

		// Token: 0x06003E9B RID: 16027 RVA: 0x00238340 File Offset: 0x00236540
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

		// Token: 0x06003E9C RID: 16028 RVA: 0x002383F0 File Offset: 0x002365F0
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

		// Token: 0x06003E9D RID: 16029 RVA: 0x002384B0 File Offset: 0x002366B0
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

		// Token: 0x06003E9E RID: 16030 RVA: 0x002385C4 File Offset: 0x002367C4
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

		// Token: 0x06003E9F RID: 16031 RVA: 0x002385F0 File Offset: 0x002367F0
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

		// Token: 0x06003EA0 RID: 16032 RVA: 0x00238680 File Offset: 0x00236880
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

		// Token: 0x06003EA1 RID: 16033 RVA: 0x0023870C File Offset: 0x0023690C
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

		// Token: 0x06003EA2 RID: 16034 RVA: 0x00238894 File Offset: 0x00236A94
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

		// Token: 0x06003EA3 RID: 16035 RVA: 0x0023890C File Offset: 0x00236B0C
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

		// Token: 0x06003EA4 RID: 16036 RVA: 0x00238959 File Offset: 0x00236B59
		private void cboPayMeth_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !((Strings.Asc(e.KeyChar) == 65366) | (Strings.Asc(e.KeyChar) == 65365));
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x0023898C File Offset: 0x00236B8C
		private void cboPayMeth_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = (e.KeyValue == 13) | (e.KeyValue == 34);
			if (flag)
			{
				this.txtAmtPaid.Focus();
				e.Handled = true;
			}
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x002389CC File Offset: 0x00236BCC
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
				bool flag = MyProject.Forms.Form1.UseConnectedScale == 1;
				if (flag)
				{
					this.s.Close();
				}
			}
			catch (ObjectDisposedException ex)
			{
			}
			catch (Exception ex2)
			{
				MessageBox.Show(Conversions.ToString(Operators.CompareString("Error Disposing. Detail: ", ex2.Message, false) == 0));
			}
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00238AD4 File Offset: 0x00236CD4
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
							peltrade.PLUCurrencyID = receiptcurrencyID;
							bool flag3 = peltrade.AddPLU(Conversions.ToString(dataRow["ProductCode"]), Conversions.ToString(dataRow["Desc"]), Conversions.ToDouble(Operators.MultiplyObject(dataRow["UnitPrice"], this.FetchProductTaxRateByCode(Conversions.ToString(dataRow["ProductCode"])))), Conversions.ToDouble(dataRow["Qty"]), this.GetVATGroup(Conversions.ToInteger(dataRow["ProdtID"]))) == 0;
							if (!flag3)
							{
								return "Adding PLU error. Detail. " + peltrade.GetLastError(1);
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
					bool flag4 = peltrade.AddPayment(paymentmethodnumber, paymentmethoddesc, paymentamount, 1.0) == 0;
					if (flag4)
					{
						bool flag5 = peltrade.EndBon() == 0;
						if (flag5)
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

		// Token: 0x06003EA8 RID: 16040 RVA: 0x00238CCC File Offset: 0x00236ECC
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

		// Token: 0x06003EA9 RID: 16041 RVA: 0x00238D6C File Offset: 0x00236F6C
		private void Button16_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = decimal.Compare(this.currenttaxrate, 0m) > 0;
				if (flag)
				{
					decimal num = decimal.Multiply(this.specialprice, decimal.Add(1m, decimal.Divide(this.currenttaxrate, 100m)));
				}
				else
				{
					decimal num = this.specialprice;
				}
				this.txtPrice.Text = this.specialprice.ToString();
				MessageBox.Show("Special Price applied.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error using special price. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x00238E24 File Offset: 0x00237024
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
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Tax"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["Tax"]))),
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
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"])))
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
					this.txtAmtPaid.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to show saved quotations. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x002395AC File Offset: 0x002377AC
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

		// Token: 0x06003EAC RID: 16044 RVA: 0x00239708 File Offset: 0x00237908
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
			bool flag = barcode.Length == 13;
			DataRow dataRow2;
			if (flag)
			{
				try
				{
					this.GetBarcodeScaleSettings();
					string text = barcode.Substring(0, 1);
					bool flag2 = Conversions.ToDouble(text) == (double)this.BCstartchar;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.BarcodePrintingScaleWeight == 1;
						if (flag3)
						{
							string text2 = barcode.Substring(this.BCcodestartposition, this.BCcodelength);
							dataRow[4] = 0;
							dataRow[0] = text2;
							string text3 = barcode.Substring(this.BCweightstartposition, this.BCweightlength);
							bool flag4 = this.BCweightlength == 4;
							int num;
							if (flag4)
							{
								num = 1000;
							}
							else
							{
								bool flag5 = this.BCweightlength == 5;
								if (flag5)
								{
									num = 10000;
								}
								else
								{
									bool flag6 = this.BCweightlength == 6;
									if (flag6)
									{
										num = 100000;
									}
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
							bool flag7 = MyProject.Forms.Form1.BarcodePrintingScalePrice == 1;
							if (flag7)
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
								bool flag8 = Operators.CompareString(text6, "EA", false) == 0;
								decimal num5;
								if (flag8)
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
			}
			else
			{
				dataRow[0] = "0";
				dataRow[1] = 0;
				dataRow[2] = 0;
				dataRow2 = dataRow;
			}
			return dataRow2;
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x00239AC4 File Offset: 0x00237CC4
		private void Button17_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtcustomer.Text, "Cash", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please Select an existing customer first.");
				}
				else
				{
					ExtraCustomerDetails extraCustomerDetails = new ExtraCustomerDetails();
					extraCustomerDetails.txtcustomername.Text = this.txtcustomer.Text;
					string text = this.txtEmail.Text;
					extraCustomerDetails.txtEmail.Text = this.og_email;
					extraCustomerDetails.txttel.Text = this.og_tel;
					extraCustomerDetails.currCusGroup = this.currCustomerGroup;
					bool flag2 = extraCustomerDetails.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.FetchCustomer(this.txtcustomer.Text);
						this.txtEmail.Text = extraCustomerDetails.txtEmail.Text;
						this.txtTel.Text = extraCustomerDetails.txttel.Text;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x00239BE4 File Offset: 0x00237DE4
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

		// Token: 0x06003EAF RID: 16047 RVA: 0x0023A018 File Offset: 0x00238218
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
				MessageBox.Show("Error DGV Cell Click. Details: " + ex.Message);
			}
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x0023A184 File Offset: 0x00238384
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

		// Token: 0x06003EB1 RID: 16049 RVA: 0x0023A1FC File Offset: 0x002383FC
		private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x0023A248 File Offset: 0x00238448
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
					decimal num = Conversions.ToDecimal(this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value);
					bool flag3 = MyProject.Forms.Form1.NegativeStock == 0;
					if (flag3)
					{
						decimal stockAvailable = this.pf.GetStockAvailable(this._cnn, Conversions.ToInteger(this.DataGridView1.Rows[e.RowIndex].Cells["ProdtID"].Value), this.DataGridView1, Conversions.ToString(dataRow["UOM"]), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false);
						bool flag4 = decimal.Compare(stockAvailable, 0m) < 0;
						if (flag4)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value = this.currentQty;
							MessageBox.Show("Cannot edit quantity to result in negative stock.");
							return;
						}
					}
					bool flag5 = decimal.Compare(num, this.currentQty) == 0;
					if (flag5)
					{
						return;
					}
					bool flag6 = decimal.Compare(num, 0m) == 0;
					if (flag6)
					{
						this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value = this.currentQty;
						return;
					}
					int num2 = 0;
					object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscDetails"].Value);
					object objectValue2 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscPaymethod"].Value);
					object objectValue3 = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value);
					decimal num3 = Conversions.ToDecimal(dataRow["TaxRate"]);
					bool flag7 = Operators.ConditionalCompareObjectNotEqual(objectValue3, 0, false);
					if (flag7)
					{
						bool flag8 = objectValue.ToString().Contains("Payment Method Discount");
						if (flag8)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Operators.AddObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value)) * -1.0);
							this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value = 0;
						}
						else
						{
							num2 = 1;
						}
					}
					bool flag9 = Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[e.RowIndex].Cells["Promstatus"].Value, 3, false);
					DataRow dataRow2;
					if (flag9)
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
					bool flag10 = Operators.ConditionalCompareObjectNotEqual(dataRow2["disc"], 0, false);
					if (flag10)
					{
						this.PaymentMethodDiscountEffected = 1;
						this.DataGridView1.Rows[e.RowIndex].Cells["CouponNumber"].Value = 1;
						this.DataGridView1.Rows[e.RowIndex].Cells["OldPrice"].Value = RuntimeHelpers.GetObjectValue(dataRow2["oldprice"]);
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
						decimal num4 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])));
						this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscDetails"].Value = "Payment Method Discount";
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscPaymethod"].Value = RuntimeHelpers.GetObjectValue(dataRow2["paymethod"]);
						bool flag11 = decimal.Compare(num3, 0m) != 0;
						if (flag11)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value = Operators.MultiplyObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, decimal.Add(1m, decimal.Divide(num3, 100m)));
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
						bool flag12 = num2 == 0;
						if (flag12)
						{
							this.DataGridView1.Rows[e.RowIndex].Cells["CouponNumber"].Value = 0;
							this.DataGridView1.Rows[e.RowIndex].Cells["DiscDetails"].Value = "";
						}
						decimal num5 = Conversions.ToDecimal(dataRow["wholesaleqty"]);
						bool flag13 = (MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1) & (Convert.ToDouble(num5) >= Conversions.ToDouble(this.txtQty.Text));
						decimal num6;
						if (flag13)
						{
							num6 = Conversions.ToDecimal(dataRow["SellingPriceWholesale"]);
						}
						else
						{
							num6 = Conversions.ToDecimal(dataRow["SellingPrice"]);
						}
						bool flag14 = MyProject.Forms.Form1.CalcBackwards == 1;
						if (flag14)
						{
							object obj = num6;
							object obj2 = null;
							Type typeFromHandle = typeof(Math);
							string text = "Round";
							object[] array = new object[3];
							array[0] = Operators.MultiplyObject(Operators.DivideObject(dataRow["TaxRate"], 100), num6);
							int num7 = 1;
							Form1 form = MyProject.Forms.Form1;
							ref int ptr = ref form.DecimalPlaces;
							array[num7] = form.DecimalPlaces;
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
							decimal num8 = Conversions.ToDecimal(Operators.MultiplyObject(Operators.AddObject(obj, obj3), this.mono_rate));
							decimal num9 = Conversions.ToDecimal(Operators.DivideObject(num8, Operators.AddObject(1, Operators.DivideObject(dataRow["TaxRate"], 100))));
							decimal num10 = Conversions.ToDecimal(Operators.MultiplyObject(decimal.Subtract(num8, num9), this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value));
							this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Math.Round(num9, 4, MidpointRounding.AwayFromZero);
							this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value = Math.Round(num10, 4, MidpointRounding.AwayFromZero);
						}
						else
						{
							decimal num8 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(num6), this.mono_rate), dataRow2["disc"]));
							this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = Math.Round(num8, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
							DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[e.RowIndex].Cells["Tax"];
							object obj4 = null;
							Type typeFromHandle2 = typeof(Math);
							string text2 = "Round";
							object[] array7 = new object[3];
							array7[0] = Operators.MultiplyObject(decimal.Divide(num3, 100m), this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value);
							int num11 = 1;
							Form1 form2 = MyProject.Forms.Form1;
							ref int ptr = ref form2.DecimalPlaces;
							array7[num11] = form2.DecimalPlaces;
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
							dataGridViewCell.Value = Operators.MultiplyObject(obj3, this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value);
						}
						this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["DiscAmount2"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate), 2, MidpointRounding.AwayFromZero);
						this.DataGridView1.Rows[e.RowIndex].Cells["OldPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["OldPrice"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
						this.DataGridView1.Rows[e.RowIndex].Cells["UnitCost"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["UnitCost"].Value)) / Convert.ToDouble(this.mono_rate) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
						bool flag15 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
						decimal num12;
						if (flag15)
						{
							num12 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.AddObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, Operators.MultiplyObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, decimal.Divide(num3, 100m))),
								2,
								MidpointRounding.AwayFromZero
							}, null, null, null));
						}
						else
						{
							object obj5 = null;
							Type typeFromHandle3 = typeof(Math);
							string text3 = "Round";
							object[] array11 = new object[3];
							array11[0] = Operators.AddObject(Operators.MultiplyObject(this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value, this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value), this.DataGridView1.Rows[e.RowIndex].Cells["Tax"].Value);
							int num13 = 1;
							Form1 form3 = MyProject.Forms.Form1;
							ref int ptr = ref form3.DecimalPlaces;
							array11[num13] = form3.DecimalPlaces;
							array11[2] = MidpointRounding.AwayFromZero;
							object[] array2 = array11;
							string[] array12 = null;
							Type[] array13 = null;
							bool[] array14 = new bool[3];
							array14[1] = true;
							bool[] array6 = array14;
							object obj3 = NewLateBinding.LateGet(obj5, typeFromHandle3, text3, array11, array12, array13, array14);
							if (array6[1])
							{
								ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
							}
							num12 = Conversions.ToDecimal(obj3);
						}
						this.DataGridView1.Rows[e.RowIndex].Cells["Total"].Value = num12;
					}
					this.CalcTotalSale();
				}
				bool flag16 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag16)
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

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0023B454 File Offset: 0x00239654
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

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0023B4C8 File Offset: 0x002396C8
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

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x0023B578 File Offset: 0x00239778
		// (set) Token: 0x06003EB7 RID: 16055 RVA: 0x0023B584 File Offset: 0x00239784
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

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0023B5C7 File Offset: 0x002397C7
		private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			this.txtNumeric = (DataGridViewTextBoxEditingControl)e.Control;
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0023B5DC File Offset: 0x002397DC
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

		// Token: 0x06003EBA RID: 16058 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_LocationChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_Invalidated(object sender, InvalidateEventArgs e)
		{
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0023B7D0 File Offset: 0x002399D0
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

		// Token: 0x06003EBE RID: 16062 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Sales2mono_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x0023B8CC File Offset: 0x00239ACC
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

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0023B924 File Offset: 0x00239B24
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

		// Token: 0x06003EC1 RID: 16065 RVA: 0x0023B97C File Offset: 0x00239B7C
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

		// Token: 0x06003EC2 RID: 16066 RVA: 0x0023B9D4 File Offset: 0x00239BD4
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

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0023BA2C File Offset: 0x00239C2C
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

		// Token: 0x06003EC4 RID: 16068 RVA: 0x0023BA84 File Offset: 0x00239C84
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

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0023BADC File Offset: 0x00239CDC
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

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0023BB34 File Offset: 0x00239D34
		private void Button20_Click(object sender, EventArgs e)
		{
			DataTable dataTable = this.createDTFromGrid(this.DataGridView1);
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					decimal num = Conversions.ToDecimal(NewLateBinding.LateIndexGet(objectValue, new object[] { "UnitPrice" }, null));
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

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0023BBBC File Offset: 0x00239DBC
		private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.approve_till_void == 1;
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

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0023BC48 File Offset: 0x00239E48
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

		// Token: 0x06003EC9 RID: 16073 RVA: 0x0023BCD0 File Offset: 0x00239ED0
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

		// Token: 0x06003ECA RID: 16074 RVA: 0x0023BD08 File Offset: 0x00239F08
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

		// Token: 0x06003ECB RID: 16075 RVA: 0x0023BE90 File Offset: 0x0023A090
		private void s_DataReceived(object sender, RJCP.IO.Ports.SerialDataReceivedEventArgs e)
		{
			string text = this.s.ReadExisting();
			this.UpdateTextBox(text);
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0023BEB4 File Offset: 0x0023A0B4
		private void UpdateTextBox(string data)
		{
			bool invokeRequired = this.txtQtyW.InvokeRequired;
			if (invokeRequired)
			{
				this.txtQtyW.Invoke(new VB$AnonymousDelegate_0(delegate
				{
					this.UpdateTextBox(data);
				}));
			}
			else
			{
				this.txtQtyW.AppendText(data);
			}
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0023BF14 File Offset: 0x0023A114
		private void Button21_Click(object sender, EventArgs e)
		{
			try
			{
				this.s.Close();
				this.s.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error refreshing scale. Detail: " + ex.Message);
			}
		}

		// Token: 0x04001A94 RID: 6804
		private string _cnn;

		// Token: 0x04001A95 RID: 6805
		private PublicFunctions pf;

		// Token: 0x04001A96 RID: 6806
		private int CurrentID;

		// Token: 0x04001A97 RID: 6807
		private string CurrentCode;

		// Token: 0x04001A98 RID: 6808
		private string TextToPrint;

		// Token: 0x04001A99 RID: 6809
		private string coname;

		// Token: 0x04001A9A RID: 6810
		private string coadd;

		// Token: 0x04001A9B RID: 6811
		private string cotel;

		// Token: 0x04001A9C RID: 6812
		private string coemail;

		// Token: 0x04001A9D RID: 6813
		private string cobpnum;

		// Token: 0x04001A9E RID: 6814
		private string footnote;

		// Token: 0x04001A9F RID: 6815
		private string cotel2;

		// Token: 0x04001AA0 RID: 6816
		private string cotel3;

		// Token: 0x04001AA1 RID: 6817
		private string coVATNum;

		// Token: 0x04001AA2 RID: 6818
		private string bpnum_name;

		// Token: 0x04001AA3 RID: 6819
		private string vatnum_name;

		// Token: 0x04001AA4 RID: 6820
		private string coname_og;

		// Token: 0x04001AA5 RID: 6821
		private string coadd_og;

		// Token: 0x04001AA6 RID: 6822
		private string cotel_og;

		// Token: 0x04001AA7 RID: 6823
		private string coemail_og;

		// Token: 0x04001AA8 RID: 6824
		private string cobpnum_og;

		// Token: 0x04001AA9 RID: 6825
		private string footnote_og;

		// Token: 0x04001AAA RID: 6826
		private string cotel2_og;

		// Token: 0x04001AAB RID: 6827
		private string cotel3_og;

		// Token: 0x04001AAC RID: 6828
		private string coVATNum_og;

		// Token: 0x04001AAD RID: 6829
		private string bpnum_name_og;

		// Token: 0x04001AAE RID: 6830
		private string vatnum_name_og;

		// Token: 0x04001AAF RID: 6831
		private int invnum;

		// Token: 0x04001AB0 RID: 6832
		private double currprice;

		// Token: 0x04001AB1 RID: 6833
		private bool Match;

		// Token: 0x04001AB2 RID: 6834
		private DataTable datCustomers;

		// Token: 0x04001AB3 RID: 6835
		private int m_currentPageIndex;

		// Token: 0x04001AB4 RID: 6836
		private IList<Stream> m_streams;

		// Token: 0x04001AB5 RID: 6837
		private decimal priceb4tax;

		// Token: 0x04001AB6 RID: 6838
		private decimal priceb4taxWholesale;

		// Token: 0x04001AB7 RID: 6839
		private decimal currentWholesaleQty;

		// Token: 0x04001AB8 RID: 6840
		private decimal taxdueWholesale;

		// Token: 0x04001AB9 RID: 6841
		private decimal totpriceWholesale;

		// Token: 0x04001ABA RID: 6842
		private int WholesalePriceByQty;

		// Token: 0x04001ABB RID: 6843
		private decimal specialprice;

		// Token: 0x04001ABC RID: 6844
		private decimal currenttaxrate;

		// Token: 0x04001ABD RID: 6845
		private decimal mono_rate;

		// Token: 0x04001ABE RID: 6846
		private string og_customername;

		// Token: 0x04001ABF RID: 6847
		private string og_address;

		// Token: 0x04001AC0 RID: 6848
		private string og_contactname;

		// Token: 0x04001AC1 RID: 6849
		private string og_mobile;

		// Token: 0x04001AC2 RID: 6850
		private string og_email;

		// Token: 0x04001AC3 RID: 6851
		private string og_tel;

		// Token: 0x04001AC4 RID: 6852
		private string og_invdetail1;

		// Token: 0x04001AC5 RID: 6853
		private string og_invdetail2;

		// Token: 0x04001AC6 RID: 6854
		private string og_vatnumber;

		// Token: 0x04001AC7 RID: 6855
		private string og_bpnumber;

		// Token: 0x04001AC8 RID: 6856
		private int TexttoPrintLen;

		// Token: 0x04001AC9 RID: 6857
		private int discPaymentMethod;

		// Token: 0x04001ACA RID: 6858
		private int isInvoiceDisc;

		// Token: 0x04001ACB RID: 6859
		private decimal discAmount;

		// Token: 0x04001ACC RID: 6860
		private decimal discTeller;

		// Token: 0x04001ACD RID: 6861
		private decimal discCoupons;

		// Token: 0x04001ACE RID: 6862
		private decimal discPromotion;

		// Token: 0x04001ACF RID: 6863
		private string discPromotionName;

		// Token: 0x04001AD0 RID: 6864
		private string discDESC;

		// Token: 0x04001AD1 RID: 6865
		private string currentUOM;

		// Token: 0x04001AD2 RID: 6866
		private bool currentExpires;

		// Token: 0x04001AD3 RID: 6867
		private bool CurrentIsVoucher;

		// Token: 0x04001AD4 RID: 6868
		private int currentIsDeposit;

		// Token: 0x04001AD5 RID: 6869
		private StringReader stringToRead;

		// Token: 0x04001AD6 RID: 6870
		private decimal paymeth_rate;

		// Token: 0x04001AD7 RID: 6871
		private int paymeth_fiscalgroup;

		// Token: 0x04001AD8 RID: 6872
		private string paymeth_desc;

		// Token: 0x04001AD9 RID: 6873
		private string paymeth_currency;

		// Token: 0x04001ADA RID: 6874
		private bool paymeth_requiresref;

		// Token: 0x04001ADB RID: 6875
		private DataTable datProm;

		// Token: 0x04001ADC RID: 6876
		private int PaymentMethodDiscountEffected;

		// Token: 0x04001ADD RID: 6877
		private bool isunedingstock;

		// Token: 0x04001ADE RID: 6878
		private int currentCustomerEntryNo;

		// Token: 0x04001ADF RID: 6879
		private decimal currentCustomerLimit;

		// Token: 0x04001AE0 RID: 6880
		private int BCweightlength;

		// Token: 0x04001AE1 RID: 6881
		private int BCweightstartposition;

		// Token: 0x04001AE2 RID: 6882
		private int BCpricelength;

		// Token: 0x04001AE3 RID: 6883
		private int BCpricestartposition;

		// Token: 0x04001AE4 RID: 6884
		private int BCcodestartposition;

		// Token: 0x04001AE5 RID: 6885
		private int BCcodelength;

		// Token: 0x04001AE6 RID: 6886
		private int BCstartchar;

		// Token: 0x04001AE7 RID: 6887
		private int RowID;

		// Token: 0x04001AE8 RID: 6888
		private bool saledone;

		// Token: 0x04001AE9 RID: 6889
		private decimal currentQty;

		// Token: 0x04001AEA RID: 6890
		private int currentDGVRowIndex;

		// Token: 0x04001AEB RID: 6891
		private bool currentIsCalcLxW;

		// Token: 0x04001AEC RID: 6892
		private string currComment;

		// Token: 0x04001AED RID: 6893
		private int currParentCaseID;

		// Token: 0x04001AEE RID: 6894
		private int currCaseQty;

		// Token: 0x04001AEF RID: 6895
		private int currBreak;

		// Token: 0x04001AF0 RID: 6896
		private int BreakQtyActual;

		// Token: 0x04001AF1 RID: 6897
		private int currQuotationNumber;

		// Token: 0x04001AF2 RID: 6898
		private string LINE;

		// Token: 0x04001AF3 RID: 6899
		private int current_taxexempt;

		// Token: 0x04001AF4 RID: 6900
		private string currCustomerGroup;

		// Token: 0x04001AF5 RID: 6901
		private decimal ProdtDiscTotal;

		// Token: 0x04001AF6 RID: 6902
		private string DepositBarCode;

		// Token: 0x04001AF7 RID: 6903
		private bool DepositUsed;

		// Token: 0x04001AF8 RID: 6904
		private decimal DepAmount;

		// Token: 0x04001AF9 RID: 6905
		private bool DisableEditing;
	}
}
