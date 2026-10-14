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
	// Token: 0x0200018D RID: 397
	[DesignerGenerated]
	public partial class Sales2monoPharmacy : UserControl
	{
		// Token: 0x06004112 RID: 16658 RVA: 0x002671C8 File Offset: 0x002653C8
		public Sales2monoPharmacy()
		{
			base.Load += this.Sales_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.TextToPrint = "";
			this.datCustomers = new DataTable();
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.mono_rate = 0m;
			this.og_customername = "";
			this.og_address = "";
			this.og_ID = "";
			this.og_mobile = "";
			this.og_email = "";
			this.og_DOB = "";
			this.og_invdetail1 = "";
			this.og_invdetail2 = "";
			this.discPaymentMethod = 0;
			this.isInvoiceDisc = 0;
			this.discAmount = 0m;
			this.currentUOM = "";
			this.currentExpires = 0;
			this.InitializeComponent();
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x0026B90E File Offset: 0x00269B0E
		// (set) Token: 0x06004116 RID: 16662 RVA: 0x0026B918 File Offset: 0x00269B18
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x0026B921 File Offset: 0x00269B21
		// (set) Token: 0x06004118 RID: 16664 RVA: 0x0026B92C File Offset: 0x00269B2C
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

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x0026B96F File Offset: 0x00269B6F
		// (set) Token: 0x0600411A RID: 16666 RVA: 0x0026B97C File Offset: 0x00269B7C
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

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x0026B9BF File Offset: 0x00269BBF
		// (set) Token: 0x0600411C RID: 16668 RVA: 0x0026B9C9 File Offset: 0x00269BC9
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x0026B9D2 File Offset: 0x00269BD2
		// (set) Token: 0x0600411E RID: 16670 RVA: 0x0026B9DC File Offset: 0x00269BDC
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x0026B9E5 File Offset: 0x00269BE5
		// (set) Token: 0x06004120 RID: 16672 RVA: 0x0026B9EF File Offset: 0x00269BEF
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x0026B9F8 File Offset: 0x00269BF8
		// (set) Token: 0x06004122 RID: 16674 RVA: 0x0026BA04 File Offset: 0x00269C04
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

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06004123 RID: 16675 RVA: 0x0026BA7D File Offset: 0x00269C7D
		// (set) Token: 0x06004124 RID: 16676 RVA: 0x0026BA87 File Offset: 0x00269C87
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x0026BA90 File Offset: 0x00269C90
		// (set) Token: 0x06004126 RID: 16678 RVA: 0x0026BA9A File Offset: 0x00269C9A
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x0026BAA3 File Offset: 0x00269CA3
		// (set) Token: 0x06004128 RID: 16680 RVA: 0x0026BAAD File Offset: 0x00269CAD
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x0026BAB6 File Offset: 0x00269CB6
		// (set) Token: 0x0600412A RID: 16682 RVA: 0x0026BAC0 File Offset: 0x00269CC0
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x0026BAC9 File Offset: 0x00269CC9
		// (set) Token: 0x0600412C RID: 16684 RVA: 0x0026BAD3 File Offset: 0x00269CD3
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x0026BADC File Offset: 0x00269CDC
		// (set) Token: 0x0600412E RID: 16686 RVA: 0x0026BAE6 File Offset: 0x00269CE6
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x0026BAEF File Offset: 0x00269CEF
		// (set) Token: 0x06004130 RID: 16688 RVA: 0x0026BAFC File Offset: 0x00269CFC
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

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x0026BB3F File Offset: 0x00269D3F
		// (set) Token: 0x06004132 RID: 16690 RVA: 0x0026BB49 File Offset: 0x00269D49
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x0026BB52 File Offset: 0x00269D52
		// (set) Token: 0x06004134 RID: 16692 RVA: 0x0026BB5C File Offset: 0x00269D5C
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x0026BB65 File Offset: 0x00269D65
		// (set) Token: 0x06004136 RID: 16694 RVA: 0x0026BB6F File Offset: 0x00269D6F
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x0026BB78 File Offset: 0x00269D78
		// (set) Token: 0x06004138 RID: 16696 RVA: 0x0026BB82 File Offset: 0x00269D82
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x0026BB8B File Offset: 0x00269D8B
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x0026BB98 File Offset: 0x00269D98
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

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x0026BBDB File Offset: 0x00269DDB
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x0026BBE5 File Offset: 0x00269DE5
		internal virtual TextBox txtChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x0026BBEE File Offset: 0x00269DEE
		// (set) Token: 0x0600413E RID: 16702 RVA: 0x0026BBF8 File Offset: 0x00269DF8
		internal virtual Label lblchange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x0026BC01 File Offset: 0x00269E01
		// (set) Token: 0x06004140 RID: 16704 RVA: 0x0026BC0C File Offset: 0x00269E0C
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

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x0026BC85 File Offset: 0x00269E85
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x0026BC8F File Offset: 0x00269E8F
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x0026BC98 File Offset: 0x00269E98
		// (set) Token: 0x06004144 RID: 16708 RVA: 0x0026BCA4 File Offset: 0x00269EA4
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

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x0026BCE7 File Offset: 0x00269EE7
		// (set) Token: 0x06004146 RID: 16710 RVA: 0x0026BCF1 File Offset: 0x00269EF1
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x0026BCFA File Offset: 0x00269EFA
		// (set) Token: 0x06004148 RID: 16712 RVA: 0x0026BD04 File Offset: 0x00269F04
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x0026BD0D File Offset: 0x00269F0D
		// (set) Token: 0x0600414A RID: 16714 RVA: 0x0026BD18 File Offset: 0x00269F18
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

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x0026BDB8 File Offset: 0x00269FB8
		// (set) Token: 0x0600414C RID: 16716 RVA: 0x0026BDC2 File Offset: 0x00269FC2
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x0026BDCB File Offset: 0x00269FCB
		// (set) Token: 0x0600414E RID: 16718 RVA: 0x0026BDD5 File Offset: 0x00269FD5
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x0026BDDE File Offset: 0x00269FDE
		// (set) Token: 0x06004150 RID: 16720 RVA: 0x0026BDE8 File Offset: 0x00269FE8
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

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x0026BE46 File Offset: 0x0026A046
		// (set) Token: 0x06004152 RID: 16722 RVA: 0x0026BE50 File Offset: 0x0026A050
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x0026BE59 File Offset: 0x0026A059
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x0026BE63 File Offset: 0x0026A063
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x0026BE6C File Offset: 0x0026A06C
		// (set) Token: 0x06004156 RID: 16726 RVA: 0x0026BE78 File Offset: 0x0026A078
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBarCode_KeyDown);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x0026BED6 File Offset: 0x0026A0D6
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x0026BEE0 File Offset: 0x0026A0E0
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x0026BEE9 File Offset: 0x0026A0E9
		// (set) Token: 0x0600415A RID: 16730 RVA: 0x0026BEF4 File Offset: 0x0026A0F4
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

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x0026BF37 File Offset: 0x0026A137
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x0026BF41 File Offset: 0x0026A141
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x0026BF4A File Offset: 0x0026A14A
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x0026BF54 File Offset: 0x0026A154
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x0026BF5D File Offset: 0x0026A15D
		// (set) Token: 0x06004160 RID: 16736 RVA: 0x0026BF67 File Offset: 0x0026A167
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x0026BF70 File Offset: 0x0026A170
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x0026BF7A File Offset: 0x0026A17A
		internal virtual TextBox txtCoupons
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x0026BF83 File Offset: 0x0026A183
		// (set) Token: 0x06004164 RID: 16740 RVA: 0x0026BF8D File Offset: 0x0026A18D
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x0026BF96 File Offset: 0x0026A196
		// (set) Token: 0x06004166 RID: 16742 RVA: 0x0026BFA0 File Offset: 0x0026A1A0
		internal virtual Label lblCouponInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x0026BFA9 File Offset: 0x0026A1A9
		// (set) Token: 0x06004168 RID: 16744 RVA: 0x0026BFB3 File Offset: 0x0026A1B3
		internal virtual TextBox txtOLDprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x0026BFBC File Offset: 0x0026A1BC
		// (set) Token: 0x0600416A RID: 16746 RVA: 0x0026BFC6 File Offset: 0x0026A1C6
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x0026BFCF File Offset: 0x0026A1CF
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x0026BFD9 File Offset: 0x0026A1D9
		internal virtual Label lblShiftDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x0026BFE2 File Offset: 0x0026A1E2
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x0026BFEC File Offset: 0x0026A1EC
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x0026BFF5 File Offset: 0x0026A1F5
		// (set) Token: 0x06004170 RID: 16752 RVA: 0x0026BFFF File Offset: 0x0026A1FF
		internal virtual Label lblShift
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x0026C008 File Offset: 0x0026A208
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x0026C012 File Offset: 0x0026A212
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x0026C01B File Offset: 0x0026A21B
		// (set) Token: 0x06004174 RID: 16756 RVA: 0x0026C025 File Offset: 0x0026A225
		internal virtual Label lblUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x0026C02E File Offset: 0x0026A22E
		// (set) Token: 0x06004176 RID: 16758 RVA: 0x0026C038 File Offset: 0x0026A238
		internal virtual Label lblbranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x0026C041 File Offset: 0x0026A241
		// (set) Token: 0x06004178 RID: 16760 RVA: 0x0026C04C File Offset: 0x0026A24C
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

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x0026C08F File Offset: 0x0026A28F
		// (set) Token: 0x0600417A RID: 16762 RVA: 0x0026C099 File Offset: 0x0026A299
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x0026C0A2 File Offset: 0x0026A2A2
		// (set) Token: 0x0600417C RID: 16764 RVA: 0x0026C0AC File Offset: 0x0026A2AC
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

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x0026C0EF File Offset: 0x0026A2EF
		// (set) Token: 0x0600417E RID: 16766 RVA: 0x0026C0FC File Offset: 0x0026A2FC
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

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x0026C13F File Offset: 0x0026A33F
		// (set) Token: 0x06004180 RID: 16768 RVA: 0x0026C149 File Offset: 0x0026A349
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x0026C152 File Offset: 0x0026A352
		// (set) Token: 0x06004182 RID: 16770 RVA: 0x0026C15C File Offset: 0x0026A35C
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x0026C165 File Offset: 0x0026A365
		// (set) Token: 0x06004184 RID: 16772 RVA: 0x0026C170 File Offset: 0x0026A370
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

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x0026C1B3 File Offset: 0x0026A3B3
		// (set) Token: 0x06004186 RID: 16774 RVA: 0x0026C1BD File Offset: 0x0026A3BD
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x0026C1C6 File Offset: 0x0026A3C6
		// (set) Token: 0x06004188 RID: 16776 RVA: 0x0026C1D0 File Offset: 0x0026A3D0
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

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x0026C22E File Offset: 0x0026A42E
		// (set) Token: 0x0600418A RID: 16778 RVA: 0x0026C238 File Offset: 0x0026A438
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x0026C241 File Offset: 0x0026A441
		// (set) Token: 0x0600418C RID: 16780 RVA: 0x0026C24C File Offset: 0x0026A44C
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

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x0026C28F File Offset: 0x0026A48F
		// (set) Token: 0x0600418E RID: 16782 RVA: 0x0026C29C File Offset: 0x0026A49C
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

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x0026C2DF File Offset: 0x0026A4DF
		// (set) Token: 0x06004190 RID: 16784 RVA: 0x0026C2E9 File Offset: 0x0026A4E9
		internal virtual Label lblTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x0026C2F2 File Offset: 0x0026A4F2
		// (set) Token: 0x06004192 RID: 16786 RVA: 0x0026C2FC File Offset: 0x0026A4FC
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x0026C305 File Offset: 0x0026A505
		// (set) Token: 0x06004194 RID: 16788 RVA: 0x0026C30F File Offset: 0x0026A50F
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x0026C318 File Offset: 0x0026A518
		// (set) Token: 0x06004196 RID: 16790 RVA: 0x0026C324 File Offset: 0x0026A524
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

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06004197 RID: 16791 RVA: 0x0026C367 File Offset: 0x0026A567
		// (set) Token: 0x06004198 RID: 16792 RVA: 0x0026C371 File Offset: 0x0026A571
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06004199 RID: 16793 RVA: 0x0026C37A File Offset: 0x0026A57A
		// (set) Token: 0x0600419A RID: 16794 RVA: 0x0026C384 File Offset: 0x0026A584
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
				TextBox textBox = this._txtPriceChange;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPriceChange = value;
				textBox = this._txtPriceChange;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x0026C3C7 File Offset: 0x0026A5C7
		// (set) Token: 0x0600419C RID: 16796 RVA: 0x0026C3D1 File Offset: 0x0026A5D1
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x0026C3DA File Offset: 0x0026A5DA
		// (set) Token: 0x0600419E RID: 16798 RVA: 0x0026C3E4 File Offset: 0x0026A5E4
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

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x0600419F RID: 16799 RVA: 0x0026C427 File Offset: 0x0026A627
		// (set) Token: 0x060041A0 RID: 16800 RVA: 0x0026C434 File Offset: 0x0026A634
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
				ComboBox comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.Validating -= cancelEventHandler;
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPayMeth = value;
				comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.Validating += cancelEventHandler;
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x0026C492 File Offset: 0x0026A692
		// (set) Token: 0x060041A2 RID: 16802 RVA: 0x0026C49C File Offset: 0x0026A69C
		internal virtual Label lblpaymeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x0026C4A5 File Offset: 0x0026A6A5
		// (set) Token: 0x060041A4 RID: 16804 RVA: 0x0026C4B0 File Offset: 0x0026A6B0
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

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x0026C4F3 File Offset: 0x0026A6F3
		// (set) Token: 0x060041A6 RID: 16806 RVA: 0x0026C4FD File Offset: 0x0026A6FD
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x0026C506 File Offset: 0x0026A706
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x0026C510 File Offset: 0x0026A710
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x0026C519 File Offset: 0x0026A719
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x0026C523 File Offset: 0x0026A723
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x0026C52C File Offset: 0x0026A72C
		// (set) Token: 0x060041AC RID: 16812 RVA: 0x0026C536 File Offset: 0x0026A736
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x0026C53F File Offset: 0x0026A73F
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x0026C549 File Offset: 0x0026A749
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x060041AF RID: 16815 RVA: 0x0026C552 File Offset: 0x0026A752
		// (set) Token: 0x060041B0 RID: 16816 RVA: 0x0026C55C File Offset: 0x0026A75C
		internal virtual TextBox txtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x060041B1 RID: 16817 RVA: 0x0026C565 File Offset: 0x0026A765
		// (set) Token: 0x060041B2 RID: 16818 RVA: 0x0026C56F File Offset: 0x0026A76F
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x0026C578 File Offset: 0x0026A778
		// (set) Token: 0x060041B4 RID: 16820 RVA: 0x0026C582 File Offset: 0x0026A782
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x0026C58B File Offset: 0x0026A78B
		// (set) Token: 0x060041B6 RID: 16822 RVA: 0x0026C595 File Offset: 0x0026A795
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x0026C59E File Offset: 0x0026A79E
		// (set) Token: 0x060041B8 RID: 16824 RVA: 0x0026C5A8 File Offset: 0x0026A7A8
		internal virtual TextBox txtcustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x0026C5B1 File Offset: 0x0026A7B1
		// (set) Token: 0x060041BA RID: 16826 RVA: 0x0026C5BC File Offset: 0x0026A7BC
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

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x0026C5FF File Offset: 0x0026A7FF
		// (set) Token: 0x060041BC RID: 16828 RVA: 0x0026C609 File Offset: 0x0026A809
		internal virtual DateTimePicker DateTimePicker2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x060041BD RID: 16829 RVA: 0x0026C612 File Offset: 0x0026A812
		// (set) Token: 0x060041BE RID: 16830 RVA: 0x0026C61C File Offset: 0x0026A81C
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

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x060041BF RID: 16831 RVA: 0x0026C65F File Offset: 0x0026A85F
		// (set) Token: 0x060041C0 RID: 16832 RVA: 0x0026C66C File Offset: 0x0026A86C
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

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x0026C6AF File Offset: 0x0026A8AF
		// (set) Token: 0x060041C2 RID: 16834 RVA: 0x0026C6B9 File Offset: 0x0026A8B9
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x0026C6C2 File Offset: 0x0026A8C2
		// (set) Token: 0x060041C4 RID: 16836 RVA: 0x0026C6CC File Offset: 0x0026A8CC
		internal virtual TextBox txtDOB
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x0026C6D5 File Offset: 0x0026A8D5
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x0026C6DF File Offset: 0x0026A8DF
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x0026C6E8 File Offset: 0x0026A8E8
		// (set) Token: 0x060041C8 RID: 16840 RVA: 0x0026C6F2 File Offset: 0x0026A8F2
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x0026C6FB File Offset: 0x0026A8FB
		// (set) Token: 0x060041CA RID: 16842 RVA: 0x0026C705 File Offset: 0x0026A905
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x0026C70E File Offset: 0x0026A90E
		// (set) Token: 0x060041CC RID: 16844 RVA: 0x0026C718 File Offset: 0x0026A918
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x0026C721 File Offset: 0x0026A921
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x0026C72B File Offset: 0x0026A92B
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x0026C734 File Offset: 0x0026A934
		// (set) Token: 0x060041D0 RID: 16848 RVA: 0x0026C73E File Offset: 0x0026A93E
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x0026C747 File Offset: 0x0026A947
		// (set) Token: 0x060041D2 RID: 16850 RVA: 0x0026C751 File Offset: 0x0026A951
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x0026C75A File Offset: 0x0026A95A
		// (set) Token: 0x060041D4 RID: 16852 RVA: 0x0026C764 File Offset: 0x0026A964
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x0026C76D File Offset: 0x0026A96D
		// (set) Token: 0x060041D6 RID: 16854 RVA: 0x0026C777 File Offset: 0x0026A977
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x0026C780 File Offset: 0x0026A980
		// (set) Token: 0x060041D8 RID: 16856 RVA: 0x0026C78A File Offset: 0x0026A98A
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x0026C793 File Offset: 0x0026A993
		// (set) Token: 0x060041DA RID: 16858 RVA: 0x0026C79D File Offset: 0x0026A99D
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x0026C7A6 File Offset: 0x0026A9A6
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x0026C7B0 File Offset: 0x0026A9B0
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x0026C7B9 File Offset: 0x0026A9B9
		// (set) Token: 0x060041DE RID: 16862 RVA: 0x0026C7C3 File Offset: 0x0026A9C3
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x060041DF RID: 16863 RVA: 0x0026C7CC File Offset: 0x0026A9CC
		// (set) Token: 0x060041E0 RID: 16864 RVA: 0x0026C7D6 File Offset: 0x0026A9D6
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x060041E1 RID: 16865 RVA: 0x0026C7DF File Offset: 0x0026A9DF
		// (set) Token: 0x060041E2 RID: 16866 RVA: 0x0026C7E9 File Offset: 0x0026A9E9
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x0026C7F2 File Offset: 0x0026A9F2
		// (set) Token: 0x060041E4 RID: 16868 RVA: 0x0026C7FC File Offset: 0x0026A9FC
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x0026C805 File Offset: 0x0026AA05
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x0026C80F File Offset: 0x0026AA0F
		internal virtual DataGridViewTextBoxColumn DiscPaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x0026C818 File Offset: 0x0026AA18
		// (set) Token: 0x060041E8 RID: 16872 RVA: 0x0026C822 File Offset: 0x0026AA22
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x0026C82B File Offset: 0x0026AA2B
		// (set) Token: 0x060041EA RID: 16874 RVA: 0x0026C835 File Offset: 0x0026AA35
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x0026C83E File Offset: 0x0026AA3E
		// (set) Token: 0x060041EC RID: 16876 RVA: 0x0026C848 File Offset: 0x0026AA48
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x0026C851 File Offset: 0x0026AA51
		// (set) Token: 0x060041EE RID: 16878 RVA: 0x0026C85B File Offset: 0x0026AA5B
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x0026C864 File Offset: 0x0026AA64
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x0026C86E File Offset: 0x0026AA6E
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x0026C877 File Offset: 0x0026AA77
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x0026C881 File Offset: 0x0026AA81
		internal virtual TextBox txtInvDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x0026C88A File Offset: 0x0026AA8A
		// (set) Token: 0x060041F4 RID: 16884 RVA: 0x0026C894 File Offset: 0x0026AA94
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x0026C89D File Offset: 0x0026AA9D
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x0026C8A7 File Offset: 0x0026AAA7
		internal virtual CheckBox chkPrintDeliveryNote
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x0026C8B0 File Offset: 0x0026AAB0
		private void CheckShiftStatus()
		{
			DataTable dataTable = this.CalcShift();
			DataRow dataRow = dataTable.Rows[0];
			bool flag = Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")) < (double)this.GetFirstShiftStartTime();
			DateTime dateTime;
			if (flag)
			{
				dateTime = DateTime.Today.AddDays(-1.0);
			}
			else
			{
				dateTime = DateTime.Today;
			}
			checked
			{
				DataTable dataTable2 = this.CheckShift(Conversions.ToString(dataRow["ShiftName"]), MyProject.Forms.Form1.username, (int)Math.Round(Conversion.Val(dateTime.ToString("yyyyMMdd"))), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
				bool flag2 = dataTable2.Rows.Count > 0;
				if (flag2)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					bool flag3 = Conversions.ToBoolean(dataRow2["IsClosed"]);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("Your shift was closed. Cannot continue. Contact you supervisor.");
					}
					else
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want to continue with your existing shift. Shift Name: ", dataRow2["shiftname"]), " shift start time: "), dataRow2["starttime"]), MsgBoxStyle.YesNo, null);
						bool flag5 = dialogResult == DialogResult.Yes;
						if (flag5)
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
					DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("You are starting a new shift. Shift Name: ", dataRow["ShiftName"]), " Do you want to continue?"), MsgBoxStyle.YesNo, null);
					bool flag6 = dialogResult2 == DialogResult.Yes;
					if (flag6)
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

		// Token: 0x060041F8 RID: 16888 RVA: 0x0026CBA8 File Offset: 0x0026ADA8
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
					this.coVATNum = dataRow["VATNumber"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x0026CD54 File Offset: 0x0026AF54
		private void InsertNewShift(string shiftuser, string shiftname, int shiftdate, int starttime, int endtime, string branch, int coid)
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

		// Token: 0x060041FA RID: 16890 RVA: 0x0026CE6C File Offset: 0x0026B06C
		private void EnableForm()
		{
			this.Panel4.Visible = false;
			this.Panel2.Visible = true;
			this.GroupBox3.Visible = true;
			this.GroupBox2.Visible = true;
			this.btnShift.Visible = true;
			this.btnstartshift.Visible = false;
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

		// Token: 0x060041FB RID: 16891 RVA: 0x0026CEFC File Offset: 0x0026B0FC
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

		// Token: 0x060041FC RID: 16892 RVA: 0x0026CF88 File Offset: 0x0026B188
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

		// Token: 0x060041FD RID: 16893 RVA: 0x0026D040 File Offset: 0x0026B240
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

		// Token: 0x060041FE RID: 16894 RVA: 0x0026D0E4 File Offset: 0x0026B2E4
		private void Sales_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.TillPointPriceChange == 0;
				if (flag)
				{
					this.txtPriceChange.Visible = false;
					this.Label11.Visible = false;
				}
				else
				{
					bool flag2 = MyProject.Forms.Form1.TillPointPriceChange == 1;
					if (flag2)
					{
						this.txtPriceChange.Visible = true;
						this.Label11.Visible = true;
						this.Button6.Visible = false;
					}
				}
				this.lblbranch.Text = MyProject.Forms.Form1.branch;
				this.LoadCustomers();
				this.LoadPayMeths();
				this.LoadPaymentTerms();
				this.lblUsername.Text = MyProject.Forms.Form1.username;
				int num = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
				this.txtsearch.Focus();
				this.GetBranchDetails();
				this.SetBranchColour();
				bool flag3 = MyProject.Forms.Form1.AllowTellerToViewStockBalances == 0;
				if (flag3)
				{
					this.Label3.Visible = false;
					this.txtStockAvail.Visible = false;
				}
				bool flag4 = MyProject.Forms.Form1.DateChange == 1;
				if (flag4)
				{
					this.DateTimePicker2.Enabled = true;
				}
				else
				{
					this.DateTimePicker2.Enabled = false;
				}
				this.og_customername = "Cash";
				bool flag5 = MyProject.Forms.Form1.IsWarehouse == -1;
				if (flag5)
				{
					this.DataGridView1.Columns["BatchNumber"].Visible = true;
					this.DataGridView1.Columns["ExpiryDate"].Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x0026D2F8 File Offset: 0x0026B4F8
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

		// Token: 0x06004200 RID: 16896 RVA: 0x0026D3E8 File Offset: 0x0026B5E8
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

		// Token: 0x06004201 RID: 16897 RVA: 0x0026D488 File Offset: 0x0026B688
		private bool CheckIFPayMethACcurate()
		{
			try
			{
				bool flag = (Convert.ToDouble(Conversion.Val(this.txtChange.Text)) < 0.0) | (Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) < Convert.ToDouble(Conversion.Val(this.txtTotal.Text)));
				if (flag)
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProdtID_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x0026D518 File Offset: 0x0026B718
		private void txtSearchProdtID_TextChanged(object sender, EventArgs e)
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

		// Token: 0x06004204 RID: 16900 RVA: 0x0026D5F0 File Offset: 0x0026B7F0
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
			num = Math.Round(num, 2, MidpointRounding.AwayFromZero);
			this.txtTotal.Text = Conversions.ToString(num);
			this.txtTax.Text = Conversions.ToString(num2);
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x0026D6D8 File Offset: 0x0026B8D8
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
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				double num2 = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])));
				double num3 = Conversions.ToDouble(dataRow["SellingPrice"]);
				num3 += num3 * num2;
				this.txtPrice.Text = num3.ToString();
				this.currprice = Conversions.ToDouble(num3.ToString());
				this.lbltax.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])));
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
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

		// Token: 0x06004206 RID: 16902 RVA: 0x0026D92C File Offset: 0x0026BB2C
		private void AppendGrid()
		{
			int num = 0;
			int num2 = 0;
			bool flag = (MyProject.Forms.Form1.IsWarehouse == 0) | ((MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == 0));
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
				if (flag2)
				{
					num = checked((int)Math.Round(Conversion.Val(this.txtCoupons.Text)));
				}
				decimal num3 = 0m;
				bool flag3 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
				if (flag3)
				{
					num3 = Convert.ToDecimal(this.txtPriceChange.Text);
					this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
					num2 = 1;
					this.priceb4tax = decimal.Add(this.priceb4tax, num3);
				}
				decimal num4 = Convert.ToDecimal(this.lbltax.Text);
				decimal num5 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num3);
				bool flag4 = decimal.Compare(num4, 0m) != 0;
				decimal num6;
				decimal num7;
				if (flag4)
				{
					num6 = decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num4, 100m)));
					num7 = new decimal(Convert.ToDouble(Math.Round(decimal.Multiply(decimal.Divide(num4, 100m), num6), 2)) * Conversion.Val(this.txtQty.Text));
				}
				else
				{
					num6 = num5;
					num7 = 0m;
				}
				decimal num8 = new decimal(Conversion.Val(this.txtQty.Text) * Convert.ToDouble(num5));
				num8 = num8;
				string text = "";
				string text2 = "";
				string text3 = Conversions.ToString(this.discAmount);
				bool flag5 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
				if (flag5)
				{
					text = "Payment Method Based Discount";
					text2 = this.discPaymentMethod.ToString();
				}
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
					Conversions.ToString(this.WholesalePriceByQty),
					text,
					text2,
					text3,
					"",
					Conversions.ToString(0)
				};
				this.DataGridView1.Rows.Add(array);
			}
			else
			{
				bool flag6 = (MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == -1);
				if (flag6)
				{
					DataTable selectedBatch = MyProject.Forms.Form1.SelectedBatch;
					bool flag7 = selectedBatch.Rows.Count > 0;
					if (flag7)
					{
						try
						{
							foreach (object obj in selectedBatch.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								int num9 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"]));
								bool flag8 = num9 != 0;
								if (flag8)
								{
									bool flag9 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
									if (flag9)
									{
										num = checked((int)Math.Round(Conversion.Val(this.txtCoupons.Text)));
									}
									decimal num10 = 0m;
									bool flag10 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
									if (flag10)
									{
										num10 = Convert.ToDecimal(this.txtPriceChange.Text);
										this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
										num2 = 1;
										this.priceb4tax = decimal.Add(this.priceb4tax, num10);
									}
									decimal num11 = Convert.ToDecimal(this.lbltax.Text);
									decimal num12 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num10);
									bool flag11 = decimal.Compare(num11, 0m) != 0;
									decimal num6;
									decimal num7;
									if (flag11)
									{
										num6 = decimal.Divide(num12, decimal.Add(1m, decimal.Divide(num11, 100m)));
										num7 = decimal.Multiply(Math.Round(decimal.Multiply(decimal.Divide(num11, 100m), num6), 2), new decimal(num9));
									}
									else
									{
										num6 = num12;
										num7 = 0m;
									}
									decimal num13 = decimal.Multiply(new decimal(num9), num12);
									num13 = num13;
									string text4 = "";
									string text5 = "";
									string text6 = Conversions.ToString(this.discAmount);
									bool flag12 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
									if (flag12)
									{
										text4 = "Payment Method Based Discount";
										text5 = this.discPaymentMethod.ToString();
									}
									string[] array2 = new string[]
									{
										Conversions.ToString(this.CurrentID),
										this.CurrentCode,
										this.txtDesc.Text,
										num6.ToString(),
										num9.ToString(),
										num7.ToString(),
										num13.ToString(),
										this.lblcost.Text,
										Conversions.ToString(num),
										Conversions.ToString(Conversion.Val(this.txtOLDprice.Text)),
										Conversions.ToString(num2),
										"0",
										"",
										Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
										Conversions.ToString(this.WholesalePriceByQty),
										text4,
										text5,
										text6,
										dataRow["BatchNumber"].ToString(),
										dataRow["ExpiryDate"].ToString()
									};
									this.DataGridView1.Rows.Add(array2);
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
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x0026DFF4 File Offset: 0x0026C1F4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == -1);
				if (flag)
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
				else
				{
					this.EnterItem();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending data. Details: " + ex.Message);
			}
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x0026E0D0 File Offset: 0x0026C2D0
		private void EnterItem()
		{
			bool flag = this.Verify();
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txtCoupons.Text, "", false) == 0;
				bool flag3 = flag2 || this.ProcessCoupon();
				bool flag4 = flag3;
				if (flag4)
				{
					this.AppendGrid();
					this.CalcTotalSale();
					this.txtSearchProductCode.Text = " ";
					this.txtBarCode.Text = "0";
					this.txtQty.Text = Conversions.ToString(0);
					this.lblCouponInfo.Text = "...";
					this.txtCoupons.Text = "";
					this.txtsearch.Text = "";
					this.txtBarCode.Text = "";
					this.txtPriceChange.Text = "";
					this.lblcode.Text = "";
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

		// Token: 0x06004209 RID: 16905 RVA: 0x0026E224 File Offset: 0x0026C424
		public bool Verify()
		{
			bool flag = true;
			bool flag2 = MyProject.Forms.Form1.NegativeStock == 1;
			if (flag2)
			{
				flag = true;
			}
			else
			{
				bool flag3 = MyProject.Forms.Form1.IsWarehouse == 0;
				if (flag3)
				{
					decimal num = decimal.Subtract(Convert.ToDecimal(this.txtStockAvail.Text), Convert.ToDecimal(this.txtQty.Text));
					bool flag4 = decimal.Compare(num, 0m) < 0;
					if (flag4)
					{
						return false;
					}
				}
			}
			bool flag5 = Conversion.Val(this.txtPrice.Text) <= 0.0;
			bool flag6;
			if (flag5)
			{
				flag = false;
				flag6 = flag;
			}
			else
			{
				flag6 = flag;
			}
			return flag6;
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x0026E2E0 File Offset: 0x0026C4E0
		private int GetInvoiceNumSales()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetSalesInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenumber", 0);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x0026E3B8 File Offset: 0x0026C5B8
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

		// Token: 0x0600420C RID: 16908 RVA: 0x0026E688 File Offset: 0x0026C888
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

		// Token: 0x0600420D RID: 16909 RVA: 0x0026E70C File Offset: 0x0026C90C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.AllowSalesonComputer == 1;
				if (flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					this.ConfirmSale();
					Cursor.Current = Cursors.Default;
				}
				else
				{
					MessageBox.Show("Sales are not allowed on this computer.");
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
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error performing sale. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x0026E7D4 File Offset: 0x0026C9D4
		private void ConfirmSale()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			checked
			{
				try
				{
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
					sqlCommand.Transaction = sqlTransaction;
					sqlCommand.CommandType = CommandType.StoredProcedure;
					bool flag = !this.chkAccount.Checked;
					if (flag)
					{
						bool flag2 = this.CheckIFPayMethACcurate();
						if (!flag2)
						{
							MessageBox.Show("Check payment methods. Sale cannot proceed.");
							return;
						}
						bool flag3 = this.CheckIfCustomerDetailsChanged();
						if (flag3)
						{
							this.UpdateCustomer();
						}
						int num = 1;
						sqlCommand.CommandText = "GetSalesInvoiceNumber";
						sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						sqlCommand.Parameters.AddWithValue("allowbackdated", MyProject.Forms.Form1.DateChange);
						sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
						sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
						sqlCommand.ExecuteNonQuery();
						this.invnum = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
						bool flag4 = this.invnum == 0;
						if (flag4)
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
						sqlCommand.ExecuteNonQuery();
						int num2 = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
						DateTime dateTime = Conversions.ToDate(this.lblShiftDate.Text);
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertNewSale2Warehouse3";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
								sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
								sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
								sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), this.mono_rate));
								sqlCommand.Parameters.AddWithValue("paymentmethod", num);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 3);
								sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
								sqlCommand.Parameters.AddWithValue("TranTime", num2);
								sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
								sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(dateTime.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)));
								sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.GetRate(Conversions.ToInteger(this.cboPayMeth.SelectedValue)));
								sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)));
								sqlCommand.Parameters.AddWithValue("consultant", "");
								sqlCommand.ExecuteNonQuery();
								bool flag5 = Operators.ConditionalCompareObjectGreater(dataGridViewRow.Cells["CouponNumber"].Value, 0, false);
								if (flag5)
								{
									int num3 = Conversions.ToInteger(dataGridViewRow.Cells["CouponNumber"].Value);
									bool flag6 = num3 != 1;
									if (flag6)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "UpdateCoupon";
										sqlCommand.Parameters.AddWithValue("CouponNumber", num3);
										sqlCommand.ExecuteNonQuery();
									}
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "InsertDiscount2";
									sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
									sqlCommand.Parameters.AddWithValue("TranDate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value));
									sqlCommand.Parameters.AddWithValue("pricebefore", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("couponnumber", num3);
									sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
									sqlCommand.Parameters.AddWithValue("discounttype", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
									sqlCommand.Parameters.AddWithValue("discountperinvoice", this.isInvoiceDisc);
									sqlCommand.Parameters.AddWithValue("@discountpaymethod", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscPaymethod"].Value));
									sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
									sqlCommand.ExecuteNonQuery();
								}
								bool flag7 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["PriceChange"].Value, 1, false);
								if (flag7)
								{
									decimal num4 = decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)));
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "PCInsertPriceChange";
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
									sqlCommand.Parameters.AddWithValue("pricechange", num4);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("donetime", DateTime.Now.ToString("HH:mm"));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("invoiceno", this.invnum);
									sqlCommand.Parameters.AddWithValue("normalprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)));
									sqlCommand.Parameters.AddWithValue("costprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
									sqlCommand.Parameters.AddWithValue("approvedby", MyProject.Forms.Form1.Approvedby);
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
						decimal num5 = Convert.ToDecimal(this.txtTotal.Text);
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "InsertActualPaymentMethods";
						sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
						sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
						sqlCommand.Parameters.AddWithValue("paydesc", this.cboPayMeth.Text);
						sqlCommand.Parameters.AddWithValue("amt", num5);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
						sqlCommand.ExecuteNonQuery();
						bool flag8 = MyProject.Forms.Form1.CollectEcocashDetails == 1;
						if (flag8)
						{
							bool flag9 = (Operators.CompareString(this.cboPayMeth.Text, "Ecocash", false) == 0) | (Operators.CompareString(this.cboPayMeth.Text, "ECOCASH", false) == 0) | (Operators.CompareString(this.cboPayMeth.Text, "ecocash", false) == 0);
							if (flag9)
							{
								EcocashDetails ecocashDetails = new EcocashDetails();
								ecocashDetails.invoice_number = this.invnum;
								ecocashDetails.fullcusname = this.txtcustomer.Text;
								ecocashDetails.ecoexpected = num5;
								ecocashDetails.ShowDialog(this);
								ecocashDetails.Dispose();
							}
						}
					}
					else
					{
						bool flag10 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0;
						if (!flag10)
						{
							MessageBox.Show("Please select/enter a customer name first before confirming the sale.");
							sqlTransaction.Rollback();
							sqlConnection.Close();
							Cursor.Current = Cursors.Default;
							return;
						}
						bool flag11 = this.CheckIfCustomerDetailsChanged();
						if (flag11)
						{
							this.UpdateCustomer();
						}
						int num6 = 10;
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "GetSalesInvoiceNumber";
						sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						sqlCommand.Parameters.AddWithValue("allowbackdated", MyProject.Forms.Form1.DateChange);
						sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
						sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
						sqlCommand.ExecuteNonQuery();
						this.invnum = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
						bool flag12 = this.invnum == 0;
						if (flag12)
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
						sqlCommand.ExecuteNonQuery();
						int num7 = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
						DateTime dateTime2 = Conversions.ToDate(this.lblShiftDate.Text);
						try
						{
							foreach (object obj2 in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertNewSale2Warehouse3";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Prodtid"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
								sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value)));
								sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitCost"].Value)));
								sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["UnitPrice"].Value)), this.mono_rate));
								sqlCommand.Parameters.AddWithValue("paymentmethod", num6);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 3);
								sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ProductCode"].Value));
								sqlCommand.Parameters.AddWithValue("TranTime", num7);
								sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Tax"].Value)));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
								sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(dateTime2.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["ExpiryDate"].Value)));
								sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.GetRate(Conversions.ToInteger(this.cboPayMeth.SelectedValue)));
								sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscAmount2"].Value)));
								sqlCommand.Parameters.AddWithValue("consultant", "");
								sqlCommand.ExecuteNonQuery();
								bool flag13 = Operators.ConditionalCompareObjectGreater(dataGridViewRow2.Cells["CouponNumber"].Value, 0, false);
								if (flag13)
								{
									int num8 = Conversions.ToInteger(dataGridViewRow2.Cells["CouponNumber"].Value);
									bool flag14 = num8 != 1;
									if (flag14)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "UpdateCoupon";
										sqlCommand.Parameters.AddWithValue("CouponNumber", num8);
										sqlCommand.ExecuteNonQuery();
									}
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "InsertDiscount2";
									sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
									sqlCommand.Parameters.AddWithValue("TranDate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscAmount2"].Value));
									sqlCommand.Parameters.AddWithValue("pricebefore", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["OldPrice"].Value));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("couponnumber", num8);
									sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Qty"].Value));
									sqlCommand.Parameters.AddWithValue("discounttype", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscDetails"].Value));
									sqlCommand.Parameters.AddWithValue("discountperinvoice", this.isInvoiceDisc);
									sqlCommand.Parameters.AddWithValue("@discountpaymethod", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["DiscPaymethod"].Value));
									sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
									sqlCommand.ExecuteNonQuery();
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
						DateTime dateTime3 = this.DTdate.Value.AddDays((double)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue)));
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "BillingInsertAccSale";
						sqlCommand.Parameters.AddWithValue("customername", this.txtcustomer.Text);
						sqlCommand.Parameters.AddWithValue("invoicenumber", this.invnum);
						sqlCommand.Parameters.AddWithValue("amount", Convert.ToDouble(this.txtTotal.Text));
						sqlCommand.Parameters.AddWithValue("shiftdate", dateTime2.ToString("yyyyMMdd"));
						sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("trantime", num7);
						sqlCommand.Parameters.AddWithValue("teller", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("terms", RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue));
						sqlCommand.Parameters.AddWithValue("DueDate", Convert.ToInt32(dateTime3.ToString("yyyyMMdd")));
						sqlCommand.ExecuteNonQuery();
					}
					sqlTransaction.Commit();
					sqlConnection.Close();
					bool flag15 = MyProject.Forms.Form1.PrintReceipt == 1;
					if (flag15)
					{
						bool flag16 = MyProject.Forms.Form1.PrintFiscal == 0;
						if (flag16)
						{
							for (int i = MyProject.Forms.Form1.NumOfReceiptsPrint; i > 0; i--)
							{
								bool flag17 = MyProject.Forms.Form1.ReceiptSize80 == 1;
								if (flag17)
								{
									this.PrintReceipt(this.invnum);
								}
								else
								{
									bool flag18 = MyProject.Forms.Form1.ReceiptSize80 == 0;
									if (flag18)
									{
										this.PrintReceipt58(this.invnum);
									}
								}
							}
						}
						else
						{
							bool flag19 = MyProject.Forms.Form1.PrintFiscal == 1;
							if (flag19)
							{
								Cursor.Current = Cursors.Default;
								MessageBox.Show("Fiscal printing disable. Contact the developer.");
							}
						}
					}
					bool flag20 = MyProject.Forms.Form1.PrintInvoice == 1;
					if (flag20)
					{
						this.PrintInvoice();
					}
					bool @checked = this.chkPrintDeliveryNote.Checked;
					if (@checked)
					{
						DeliveryNoteWarehouse deliveryNoteWarehouse = new DeliveryNoteWarehouse();
						deliveryNoteWarehouse.invnum = this.invnum;
						deliveryNoteWarehouse.ShowDialog(this);
						deliveryNoteWarehouse.Dispose();
					}
					this.ClearForm();
					bool flag21 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag21)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
					MessageBox.Show("Sale Done. Invoice number: " + this.invnum.ToString());
				}
				catch (Exception ex)
				{
					try
					{
						MessageBox.Show("Error confirming sale. Attempting rollback. Detail: " + ex.Message);
						this.Button2.TabStop = false;
						SqlTransaction sqlTransaction;
						sqlTransaction.Rollback();
						sqlConnection.Close();
						Cursor.Current = Cursors.Default;
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x002702C8 File Offset: 0x0026E4C8
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

		// Token: 0x06004210 RID: 16912 RVA: 0x002703D0 File Offset: 0x0026E5D0
		private void ClearForm()
		{
			this.DataGridView1.Rows.Clear();
			this.txtStockAvail.Text = Conversions.ToString(0);
			this.txtPrice.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(0);
			this.txtSearchProductCode.Text = Conversions.ToString(0);
			this.txtTotal.Text = Conversions.ToString(0);
			this.txtcustomer.Text = "Cash";
			this.txtAddress.Text = "";
			this.txtMobile.Text = "";
			this.txtEmail.Text = "";
			this.txtMobile.Text = "";
			this.txtChange.Text = "";
			this.txtAmtPaid.Text = "";
			this.txtID.Text = "";
			this.txtDOB.Text = "";
			this.og_customername = this.txtcustomer.Text;
			this.og_address = this.txtAddress.Text;
			this.og_ID = this.txtID.Text;
			this.og_mobile = this.txtMobile.Text;
			this.og_email = this.txtEmail.Text;
			this.og_DOB = this.txtDOB.Text;
			this.og_invdetail1 = this.txtInvDetails1.Text;
			this.og_invdetail2 = this.txtInvDetails2.Text;
			this.txtTax.Text = Conversions.ToString(0);
			this.txtPriceChange.Text = "";
			this.lblcode.Text = "";
			bool flag = MyProject.Forms.Form1.TillPointPriceChange == 0;
			if (flag)
			{
				this.txtPriceChange.Visible = false;
				this.Label11.Visible = false;
			}
			else
			{
				this.txtPriceChange.Visible = true;
				this.Label11.Visible = true;
			}
			this.txtBarCode.Text = "";
			this.Button2.TabStop = false;
			this.chkPrintDeliveryNote.Checked = false;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x00270618 File Offset: 0x0026E818
		private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x00270664 File Offset: 0x0026E864
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

		// Token: 0x06004214 RID: 16916 RVA: 0x002706E8 File Offset: 0x0026E8E8
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

		// Token: 0x06004215 RID: 16917 RVA: 0x00270760 File Offset: 0x0026E960
		private void PrintReceipt(int invnumber)
		{
			this.PrintHeader();
			this.ItemsToBePrinted(invnumber);
			this.PrintFooter();
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

		// Token: 0x06004216 RID: 16918 RVA: 0x002707D8 File Offset: 0x0026E9D8
		private void PrintReceipt58(int invnumber)
		{
			this.PrintHeader58();
			this.ItemsToBePrinted58(invnumber);
			this.PrintFooter58();
			StandardPrintController standardPrintController = new StandardPrintController();
			this.PrintDocument1.PrintController = standardPrintController;
			this.PrintDocument1.Print();
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x0027081C File Offset: 0x0026EA1C
		public void PrintHeader()
		{
			this.TextToPrint = "";
			string text = "TAX INVOICE";
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
				bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag)
				{
					text = "BP Number: " + this.cobpnum;
					num = text.Length;
					string text4 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text4 + text + Environment.NewLine;
				}
				bool flag2 = Operators.CompareString(this.coVATNum, "", false) != 0;
				if (flag2)
				{
					text = "VAT Number: " + this.coVATNum;
					num = text.Length;
					string text5 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text + Environment.NewLine;
				}
				text = this.coadd;
				num = text.Length;
				string text6 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text6 + text + Environment.NewLine;
				bool flag3 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag3)
				{
					text = "Email: " + this.coemail;
					num = text.Length;
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text7 + text + Environment.NewLine;
				}
				bool flag4 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag4)
				{
					text = this.cotel;
					num = text.Length;
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text + Environment.NewLine;
				}
				bool flag5 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag5)
				{
					text = this.cotel2 + "  " + this.cotel3;
					num = text.Length;
					string text9 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text + Environment.NewLine;
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

		// Token: 0x06004218 RID: 16920 RVA: 0x00270BF4 File Offset: 0x0026EDF4
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

		// Token: 0x06004219 RID: 16921 RVA: 0x00270DFC File Offset: 0x0026EFFC
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
			checked
			{
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
							int num5 = (int)Math.Round(Conversion.Val(text.Length));
							bool flag3 = num5 >= 34;
							if (flag3)
							{
								text = text.Substring(0, 33);
							}
							else
							{
								int num6 = num5;
								int num7 = 34 - num6;
								text = text.PadRight(num7);
							}
							int length = text.Length;
							string text3 = text;
							string text4 = Conversions.ToString(text3.Length);
							string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text3 + Environment.NewLine;
							decimal num8 = 0m;
							bool flag4 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
							unchecked
							{
								if (flag4)
								{
									decimal num9 = new decimal(num3 * Convert.ToDouble(this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod)));
									num8 = decimal.Multiply(num9, new decimal(num2));
									text3 = string.Concat(new string[]
									{
										"     ",
										num2.ToString(),
										"   X        ",
										Strings.FormatCurrency(num9.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
										"            ",
										Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
									});
								}
								else
								{
									num8 = new decimal(num3 * Convert.ToDouble(this.mono_rate) * (double)num2);
									decimal num10 = new decimal(num3 * Convert.ToDouble(this.mono_rate));
									text3 = string.Concat(new string[]
									{
										"     ",
										num2.ToString(),
										"   X        ",
										Strings.FormatCurrency(num10.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
										"            ",
										Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
									});
								}
								string text6 = Conversions.ToString(text3.Length);
							}
							string text7 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
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
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x00271368 File Offset: 0x0026F568
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

		// Token: 0x0600421B RID: 16923 RVA: 0x002717A4 File Offset: 0x0026F9A4
		private void PrintFooter()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			string text = "Tax         " + Strings.FormatCurrency(this.txtTax.Text, -1, TriState.UseDefault, TriState.True, TriState.True);
			string text2 = Conversions.ToString(text.Length);
			int length = text.Length;
			double num;
			bool flag4;
			checked
			{
				string text3 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag = Operators.CompareString(text, "Tax         $0.00", false) != 0;
				if (flag)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				}
				bool flag2 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
				if (flag2)
				{
					text = "Total       " + Strings.FormatCurrency(decimal.Multiply(Convert.ToDecimal(this.txtTotal.Text), this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod)).ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				else
				{
					text = "Total       " + Strings.FormatCurrency(this.txtTotal.Text, -1, TriState.UseDefault, TriState.True, TriState.True);
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
					num = 0.0;
				}
				else
				{
					num = Conversion.Val(this.txtAmtPaid.Text);
				}
				flag4 = (MyProject.Forms.Form1.UseReceiptDisplay == 1) & (decimal.Compare(this.mono_rate, 1m) == 0);
			}
			if (flag4)
			{
				num *= Convert.ToDouble(this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod));
			}
			text = "Paid        " + Strings.FormatCurrency(num, -1, TriState.UseDefault, TriState.True, TriState.True);
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
				bool flag6 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag6)
				{
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
					bool flag7 = !this.chkAccount.Checked;
					if (flag7)
					{
						text = this.cboPayMeth.Text + ": $" + this.txtAmtPaid.Text;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
					}
				}
				text = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x00271C28 File Offset: 0x0026FE28
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

		// Token: 0x0600421D RID: 16925 RVA: 0x00271FE0 File Offset: 0x002701E0
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			Font font = new Font("Times New Roman", 10f, FontStyle.Bold);
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
				bool flag2 = (Operators.CompareString(text, "", false) == 0) | Information.IsNothing(text);
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

		// Token: 0x0600421E RID: 16926 RVA: 0x0027213C File Offset: 0x0027033C
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x00272164 File Offset: 0x00270364
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

		// Token: 0x06004220 RID: 16928 RVA: 0x002721E8 File Offset: 0x002703E8
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

		// Token: 0x06004221 RID: 16929 RVA: 0x002722BC File Offset: 0x002704BC
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

		// Token: 0x06004222 RID: 16930 RVA: 0x0027233C File Offset: 0x0027053C
		private void PrintInvoice()
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
				SalesInvoicePortrait salesInvoicePortrait = new SalesInvoicePortrait();
				salesInvoicePortrait.invnum = this.invnum;
				salesInvoicePortrait.ShowDialog(this);
				salesInvoicePortrait.Dispose();
			}
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x002723A8 File Offset: 0x002705A8
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

		// Token: 0x06004224 RID: 16932 RVA: 0x002723FC File Offset: 0x002705FC
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
					this.coname = dataRow["CompanyName"].ToString();
					this.coadd = dataRow["Address"].ToString();
					this.cotel = dataRow["Tel"].ToString();
					this.cotel2 = dataRow["Tel2"].ToString();
					this.cotel3 = dataRow["Tel3"].ToString();
					this.coemail = dataRow["Email"].ToString();
					this.cobpnum = dataRow["BPNumber"].ToString();
					this.footnote = dataRow["Footnote"].ToString();
					this.coVATNum = dataRow["VATNumber"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x002725A8 File Offset: 0x002707A8
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

		// Token: 0x06004226 RID: 16934 RVA: 0x00272638 File Offset: 0x00270838
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

		// Token: 0x06004227 RID: 16935 RVA: 0x00272680 File Offset: 0x00270880
		private void FetchCustomer(string customername)
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
				this.txtID.Text = Conversions.ToString(dataRow["ContactName"]);
				this.txtMobile.Text = Conversions.ToString(dataRow["Mobile"]);
				this.txtEmail.Text = Conversions.ToString(dataRow["Email"]);
				this.txtDOB.Text = Conversions.ToString(dataRow["Tel"]);
				this.txtInvDetails1.Text = Conversions.ToString(dataRow["InvoiceDetails1"]);
				this.txtInvDetails2.Text = Conversions.ToString(dataRow["InvoiceDetails2"]);
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_ID = this.txtID.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_DOB = this.txtDOB.Text;
				this.og_invdetail1 = this.txtInvDetails1.Text;
				this.og_invdetail2 = this.txtInvDetails2.Text;
			}
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x002728B0 File Offset: 0x00270AB0
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

		// Token: 0x06004229 RID: 16937 RVA: 0x00272908 File Offset: 0x00270B08
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
				flag3 = !flag2;
			}
			else
			{
				flag3 = true;
			}
			return flag3;
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x002729F4 File Offset: 0x00270BF4
		private void InsertNewCustomer()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertCustomerDetails";
			sqlCommand.Parameters.AddWithValue("CustomerName", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobile.Text);
			sqlCommand.Parameters.AddWithValue("ContactName", this.txtID.Text);
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

		// Token: 0x0600422B RID: 16939 RVA: 0x00272B74 File Offset: 0x00270D74
		private void UpdateCustomer()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateCustomerDetails3";
			sqlCommand.Parameters.AddWithValue("CustomerName", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobile.Text);
			sqlCommand.Parameters.AddWithValue("IDNumber", this.txtID.Text);
			sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("invoicedetails1", "");
			sqlCommand.Parameters.AddWithValue("invoicedetails2", "");
			sqlCommand.Parameters.AddWithValue("DOB", this.txtDOB.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00272CF8 File Offset: 0x00270EF8
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

		// Token: 0x0600422D RID: 16941 RVA: 0x00272DBC File Offset: 0x00270FBC
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

		// Token: 0x0600422E RID: 16942 RVA: 0x00272E44 File Offset: 0x00271044
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

		// Token: 0x0600422F RID: 16943 RVA: 0x00272F3C File Offset: 0x0027113C
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

		// Token: 0x06004230 RID: 16944 RVA: 0x00273048 File Offset: 0x00271248
		private object searchDat(DataTable dt, string column, string value)
		{
			Sales2monoPharmacy._Closure$__555-0 CS$<>8__locals1 = new Sales2monoPharmacy._Closure$__555-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((Sales2monoPharmacy._Closure$__.$I555-0 == null) ? (Sales2monoPharmacy._Closure$__.$I555-0 = (object row1) => (DataRow)row1) : Sales2monoPharmacy._Closure$__.$I555-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06004231 RID: 16945 RVA: 0x00273124 File Offset: 0x00271324
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

		// Token: 0x06004232 RID: 16946 RVA: 0x002731AC File Offset: 0x002713AC
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

		// Token: 0x06004233 RID: 16947 RVA: 0x00273384 File Offset: 0x00271584
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

		// Token: 0x06004234 RID: 16948 RVA: 0x002733E4 File Offset: 0x002715E4
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

		// Token: 0x06004235 RID: 16949 RVA: 0x002734A8 File Offset: 0x002716A8
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

		// Token: 0x06004236 RID: 16950 RVA: 0x00273508 File Offset: 0x00271708
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

		// Token: 0x06004237 RID: 16951 RVA: 0x002735D4 File Offset: 0x002717D4
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
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = num2 == 0;
				decimal num3;
				decimal num4;
				if (flag2)
				{
					DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
					bool flag3 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
					if (flag3)
					{
						this.txtCoupons.Text = "1";
						this.txtOLDprice.Text = Conversions.ToString(productPayMethodDiscount["oldprice"]);
						this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount["paymethod"]);
						this.discAmount = Conversions.ToDecimal(productPayMethodDiscount["disc"]);
					}
					else
					{
						this.txtCoupons.Text = "";
					}
					num3 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), productPayMethodDiscount["disc"]));
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				}
				else
				{
					DataRow productPayMethodDiscount2 = this.pf.GetProductPayMethodDiscount(this._cnn, prodtID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
					bool flag4 = Operators.ConditionalCompareObjectGreater(productPayMethodDiscount2["disc"], 0, false);
					if (flag4)
					{
						this.txtCoupons.Text = "1";
						this.txtOLDprice.Text = Conversions.ToString(productPayMethodDiscount2["oldprice"]);
						this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount2["paymethod"]);
						this.discAmount = Conversions.ToDecimal(productPayMethodDiscount2["disc"]);
					}
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					num3 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate), productPayMethodDiscount2["disc"]));
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
				}
				this.priceb4tax = num3;
				this.priceb4tax = this.priceb4tax;
				decimal num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num6 = decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3));
				num6 = num6;
				this.priceb4taxWholesale = num4;
				this.priceb4taxWholesale = this.priceb4taxWholesale;
				this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num4));
				this.totpriceWholesale = this.totpriceWholesale;
				bool flag5 = MyProject.Forms.Form1.IsWholesaleShop == 1;
				if (flag5)
				{
					this.txtPrice.Text = this.totpriceWholesale.ToString();
				}
				else
				{
					this.txtPrice.Text = num6.ToString();
				}
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num5.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.currentExpires = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				bool flag6 = (MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == -1);
				if (flag6)
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
				}
				this.currentUOM = dataRow["UOM"].ToString();
				this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00273D84 File Offset: 0x00271F84
		private void SearchProductCode(string prodtcode)
		{
			this.WholesalePriceByQty = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
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
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataRow["ProductID"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
				if (flag2)
				{
					this.txtCoupons.Text = "1";
					this.txtOLDprice.Text = Conversions.ToString(productPayMethodDiscount["oldprice"]);
					this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount["paymethod"]);
					this.discAmount = Conversions.ToDecimal(productPayMethodDiscount["disc"]);
				}
				else
				{
					this.txtCoupons.Text = "";
				}
				bool flag3 = num2 == 0;
				decimal num3;
				decimal num4;
				if (flag3)
				{
					num3 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), productPayMethodDiscount["disc"]));
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				}
				else
				{
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					num3 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate), productPayMethodDiscount["disc"]));
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
				}
				this.priceb4tax = num3;
				this.priceb4tax = Math.Round(this.priceb4tax, 2);
				decimal num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num6 = decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3));
				num6 = Math.Round(num6, 2);
				this.priceb4taxWholesale = num4;
				this.priceb4taxWholesale = Math.Round(this.priceb4taxWholesale, 2);
				this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num4));
				this.totpriceWholesale = Math.Round(this.totpriceWholesale, 2);
				bool flag4 = MyProject.Forms.Form1.IsWholesaleShop == 1;
				if (flag4)
				{
					this.txtPrice.Text = this.totpriceWholesale.ToString();
				}
				else
				{
					this.txtPrice.Text = num6.ToString();
				}
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num5.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.currentExpires = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				bool flag5 = (MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == -1);
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
				}
				this.currentUOM = dataRow["UOM"].ToString();
				this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x00274480 File Offset: 0x00272680
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
								bool flag8 = this.notselected(checked((int)Math.Round(Conversion.Val(this.txtCoupons.Text))));
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

		// Token: 0x0600423A RID: 16954 RVA: 0x002746D0 File Offset: 0x002728D0
		private bool notselected(int couponnum)
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

		// Token: 0x0600423B RID: 16955 RVA: 0x00274774 File Offset: 0x00272974
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

		// Token: 0x0600423C RID: 16956 RVA: 0x00274824 File Offset: 0x00272A24
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

		// Token: 0x0600423D RID: 16957 RVA: 0x00274874 File Offset: 0x00272A74
		private void btnShift_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure your shift has ended and you want to exit?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.CloseShift(MyProject.Forms.Form1.shiftdate, this.lblShift.Text, MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")))));
					ShiftReportForm shiftReportForm = new ShiftReportForm();
					shiftReportForm.ShowDialog(this);
					shiftReportForm.Dispose();
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing shift. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x00274950 File Offset: 0x00272B50
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

		// Token: 0x0600423F RID: 16959 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00274A28 File Offset: 0x00272C28
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag5;
			try
			{
				bool flag = msg.WParam.ToInt32() == 34;
				if (flag)
				{
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
						}
					}
				}
				flag5 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag5;
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00274B18 File Offset: 0x00272D18
		private void dgvpay_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.ConfirmSale();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore" + ex.Message);
			}
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x00274B80 File Offset: 0x00272D80
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

		// Token: 0x06004243 RID: 16963 RVA: 0x00274C08 File Offset: 0x00272E08
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

		// Token: 0x06004244 RID: 16964 RVA: 0x00274C80 File Offset: 0x00272E80
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txtQty.Focus();
				e.Handled = true;
			}
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00274CB4 File Offset: 0x00272EB4
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

		// Token: 0x06004246 RID: 16966 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00274E08 File Offset: 0x00273008
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void OpenCashDrawer()
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(1, AppDomain.CurrentDomain.BaseDirectory + "open.txt", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
			FileSystem.PrintLine(1, new object[] { "\u001bp\0\u0019" + Conversions.ToString(Strings.Chr(250)) });
			FileSystem.FileClose(new int[] { 1 });
			Interaction.Shell("print /d:com1 open.txt", AppWinStyle.Hide, false, -1);
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00274E84 File Offset: 0x00273084
		private void cboCustomers_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00274EB8 File Offset: 0x002730B8
		private DataTable searchDat(string stext)
		{
			DataTable dataTable = new DataTable();
			return this.datCustomers.Select("CustomerName LIKE '%" + stext + "%'").CopyToDataTable<DataRow>();
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x00274EF4 File Offset: 0x002730F4
		private void cboCustomers_Leave(object sender, EventArgs e)
		{
			this.AutoCompleteCombo_Leave(this.cboCustomers);
			DataRowView dataRowView = (DataRowView)this.cboCustomers.SelectedItem;
			bool flag = dataRowView == null;
			if (flag)
			{
			}
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x00274F2C File Offset: 0x0027312C
		public void AutoCompleteCombo_Leave(ComboBox cbo)
		{
			int num = cbo.FindStringExact(cbo.Text);
			cbo.SelectedIndex = num;
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x00274F50 File Offset: 0x00273150
		private void cboCustomers_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				Keys keyCode = e.KeyCode;
				if (keyCode != Keys.Back)
				{
					switch (keyCode)
					{
					case Keys.Left:
					case Keys.Up:
					case Keys.Right:
					case Keys.Down:
						break;
					default:
						if (keyCode != Keys.Delete)
						{
							string text = this.cboCustomers.Text;
							int num = this.cboCustomers.FindString(text);
							bool flag = num >= 0;
							if (flag)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(this.cboCustomers.Items[num]);
								string itemText = this.cboCustomers.GetItemText(RuntimeHelpers.GetObjectValue(objectValue));
								string text2 = itemText.Substring(text.Length);
								this.cboCustomers.Text = text + text2;
								this.cboCustomers.SelectionStart = text.Length;
								this.cboCustomers.SelectionLength = text2.Length;
							}
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x00275058 File Offset: 0x00273258
		private void Button4_Click_2(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.cboCustomers.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				string searchCustomer = MyProject.Forms.Form1.SearchCustomer;
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindString(MyProject.Forms.Form1.SearchCustomer);
				this.txtsearch.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x00275110 File Offset: 0x00273310
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

		// Token: 0x0600424F RID: 16975 RVA: 0x002751B0 File Offset: 0x002733B0
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
				}
				else
				{
					this.Label7.Visible = true;
					this.lblTerms.Visible = false;
					this.cboTerms.Visible = false;
					this.lblchange.Visible = true;
					this.txtChange.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00275278 File Offset: 0x00273478
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

		// Token: 0x06004251 RID: 16977 RVA: 0x0027536C File Offset: 0x0027356C
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

		// Token: 0x06004252 RID: 16978 RVA: 0x002754C8 File Offset: 0x002736C8
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

		// Token: 0x06004253 RID: 16979 RVA: 0x0027554C File Offset: 0x0027374C
		private void txtPriceChange_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x002755B4 File Offset: 0x002737B4
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				frmConfirmAdminUser frmConfirmAdminUser = new frmConfirmAdminUser();
				frmConfirmAdminUser.ShowDialog(this);
				frmConfirmAdminUser.Dispose();
				bool flag = MyProject.Forms.Form1.tillchangeprice == 1;
				if (flag)
				{
					this.txtPriceChange.Visible = true;
					this.Label11.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error confirming admin users. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x00275644 File Offset: 0x00273844
		private void cboPayMeth_Validating(object sender, CancelEventArgs e)
		{
			bool flag = this.DataGridView1.RowCount > 0;
			if (flag)
			{
			}
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00275668 File Offset: 0x00273868
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

		// Token: 0x06004257 RID: 16983 RVA: 0x002756E8 File Offset: 0x002738E8
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.mono_rate = this.GetRate(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
				this.lblpaymeth.Text = this.cboPayMeth.Text;
				bool flag = Operators.CompareString(this.txtBarCode.Text, "", false) == 0;
				if (flag)
				{
					this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
				}
				else
				{
					this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
				}
				bool flag2 = this.DataGridView1.Rows.Count > 0;
				if (flag2)
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							DataTable prodtDetails = this.GetProdtDetails(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value));
							int count = prodtDetails.Rows.Count;
							bool flag3 = count > 0;
							if (flag3)
							{
								DataRow dataRow = prodtDetails.Rows[0];
								DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
								bool flag4 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
								if (flag4)
								{
									dataGridViewRow.Cells["CouponNumber"].Value = 1;
									dataGridViewRow.Cells["OldPrice"].Value = RuntimeHelpers.GetObjectValue(productPayMethodDiscount["oldprice"]);
									dataGridViewRow.Cells["DiscDetails"].Value = "Payment Method Based Discount";
									dataGridViewRow.Cells["DiscPaymethod"].Value = RuntimeHelpers.GetObjectValue(productPayMethodDiscount["paymethod"]);
									dataGridViewRow.Cells["DiscAmount2"].Value = RuntimeHelpers.GetObjectValue(productPayMethodDiscount["disc"]);
								}
								else
								{
									dataGridViewRow.Cells["CouponNumber"].Value = 0;
								}
								decimal num = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), productPayMethodDiscount["disc"]));
								decimal num2 = num;
								num2 = Math.Round(num2, 2);
								decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
								decimal num4 = Conversions.ToDecimal(Operators.MultiplyObject(Math.Round(decimal.Multiply(decimal.Divide(num3, 100m), num2), 2), dataGridViewRow.Cells["Qty"].Value));
								decimal num5 = decimal.Add(num, decimal.Multiply(decimal.Divide(num3, 100m), num));
								num5 = Math.Round(num5, 2);
								decimal num6 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
								decimal num7 = num6;
								num7 = Math.Round(num7, 2);
								decimal num8 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
								decimal num9 = Conversions.ToDecimal(Operators.MultiplyObject(Math.Round(decimal.Multiply(decimal.Divide(num8, 100m), num7), 2), dataGridViewRow.Cells["Qty"].Value));
								decimal num10 = decimal.Add(num6, decimal.Multiply(decimal.Divide(num8, 100m), num6));
								num10 = Math.Round(num10, 2);
								decimal num11 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
								bool flag5 = MyProject.Forms.Form1.IsWholesaleShop == 1;
								if (flag5)
								{
									dataGridViewRow.Cells["UnitPrice"].Value = num10.ToString();
									dataGridViewRow.Cells["Tax"].Value = num9.ToString();
								}
								else
								{
									bool flag6 = MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1;
									if (flag6)
									{
										bool flag7 = Operators.ConditionalCompareObjectGreaterEqual(dataGridViewRow.Cells["Qty"].Value, num11, false);
										if (flag7)
										{
											dataGridViewRow.Cells["UnitPrice"].Value = num10.ToString();
											dataGridViewRow.Cells["Tax"].Value = num9.ToString();
										}
										else
										{
											dataGridViewRow.Cells["UnitPrice"].Value = num5.ToString();
											dataGridViewRow.Cells["Tax"].Value = num4.ToString();
										}
									}
									else
									{
										dataGridViewRow.Cells["UnitPrice"].Value = num5.ToString();
										dataGridViewRow.Cells["Tax"].Value = num4.ToString();
									}
								}
								dataGridViewRow.Cells["UnitCost"].Value = RuntimeHelpers.GetObjectValue(dataRow["Cost"]);
								dataGridViewRow.Cells["Total"].Value = Operators.AddObject(Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, dataGridViewRow.Cells["Qty"].Value), dataGridViewRow.Cells["Tax"].Value);
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
					this.txtAmtPaid.Focus();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00275E58 File Offset: 0x00274058
		private decimal GetRate(int paymethid)
		{
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetRateForPayMeth";
			sqlCommand.Parameters.AddWithValue("paymethid", paymethid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag = num2 > 0;
			decimal num3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				num3 = num;
			}
			else
			{
				num3 = num;
			}
			return num3;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00275F28 File Offset: 0x00274128
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
										DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Quantity has reached wholesale level. Do you want to change the price to wholesale?", MsgBoxStyle.YesNo, null);
										bool flag7 = dialogResult == DialogResult.Yes;
										if (flag7)
										{
											this.txtPrice.Text = this.totpriceWholesale.ToString();
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

		// Token: 0x0600425B RID: 16987 RVA: 0x0027607C File Offset: 0x0027427C
		private void txtAmtPaid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ConfirmSale();
				e.Handled = true;
			}
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x002760AC File Offset: 0x002742AC
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.SaveCustomerDetails();
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_ID = this.txtID.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_DOB = this.txtDOB.Text;
				this.og_invdetail1 = this.txtInvDetails1.Text;
				this.og_invdetail2 = this.txtInvDetails2.Text;
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Customer details saved successfuly.");
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error saving customer details. Detai: " + ex.Message);
			}
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x002761B0 File Offset: 0x002743B0
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtcustomer.Text = "Cash";
				this.txtAddress.Text = "";
				this.txtID.Text = "";
				this.txtMobile.Text = "";
				this.txtEmail.Text = "";
				this.txtDOB.Text = "";
				this.txtInvDetails1.Text = "";
				this.txtInvDetails2.Text = "";
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_ID = this.txtID.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_DOB = this.txtDOB.Text;
				this.og_invdetail1 = this.txtInvDetails1.Text;
				this.og_invdetail2 = this.txtInvDetails2.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error clearing customer details: " + ex.Message);
			}
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00276314 File Offset: 0x00274514
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
					bool flag5 = Operators.CompareString(Strings.Trim(this.txtID.Text), Strings.Trim(this.og_ID), false) != 0;
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
										bool flag10 = Operators.CompareString(Strings.Trim(this.txtDOB.Text), Strings.Trim(this.og_DOB), false) != 0;
										if (flag10)
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
			return flag3;
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x00002A30 File Offset: 0x00000C30
		private void lblcost_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04001CAB RID: 7339
		private string _cnn;

		// Token: 0x04001CAC RID: 7340
		private PublicFunctions pf;

		// Token: 0x04001CAD RID: 7341
		private int CurrentID;

		// Token: 0x04001CAE RID: 7342
		private string CurrentCode;

		// Token: 0x04001CAF RID: 7343
		private string TextToPrint;

		// Token: 0x04001CB0 RID: 7344
		private string coname;

		// Token: 0x04001CB1 RID: 7345
		private string coadd;

		// Token: 0x04001CB2 RID: 7346
		private string cotel;

		// Token: 0x04001CB3 RID: 7347
		private string coemail;

		// Token: 0x04001CB4 RID: 7348
		private string cobpnum;

		// Token: 0x04001CB5 RID: 7349
		private string footnote;

		// Token: 0x04001CB6 RID: 7350
		private string cotel2;

		// Token: 0x04001CB7 RID: 7351
		private string cotel3;

		// Token: 0x04001CB8 RID: 7352
		private string coVATNum;

		// Token: 0x04001CB9 RID: 7353
		private int invnum;

		// Token: 0x04001CBA RID: 7354
		private double currprice;

		// Token: 0x04001CBB RID: 7355
		private bool Match;

		// Token: 0x04001CBC RID: 7356
		private DataTable datCustomers;

		// Token: 0x04001CBD RID: 7357
		private int m_currentPageIndex;

		// Token: 0x04001CBE RID: 7358
		private IList<Stream> m_streams;

		// Token: 0x04001CBF RID: 7359
		private decimal priceb4tax;

		// Token: 0x04001CC0 RID: 7360
		private decimal priceb4taxWholesale;

		// Token: 0x04001CC1 RID: 7361
		private decimal currentWholesaleQty;

		// Token: 0x04001CC2 RID: 7362
		private decimal taxdueWholesale;

		// Token: 0x04001CC3 RID: 7363
		private decimal totpriceWholesale;

		// Token: 0x04001CC4 RID: 7364
		private int WholesalePriceByQty;

		// Token: 0x04001CC5 RID: 7365
		private decimal mono_rate;

		// Token: 0x04001CC6 RID: 7366
		private string og_customername;

		// Token: 0x04001CC7 RID: 7367
		private string og_address;

		// Token: 0x04001CC8 RID: 7368
		private string og_ID;

		// Token: 0x04001CC9 RID: 7369
		private string og_mobile;

		// Token: 0x04001CCA RID: 7370
		private string og_email;

		// Token: 0x04001CCB RID: 7371
		private string og_DOB;

		// Token: 0x04001CCC RID: 7372
		private string og_invdetail1;

		// Token: 0x04001CCD RID: 7373
		private string og_invdetail2;

		// Token: 0x04001CCE RID: 7374
		private int TexttoPrintLen;

		// Token: 0x04001CCF RID: 7375
		private int discPaymentMethod;

		// Token: 0x04001CD0 RID: 7376
		private int isInvoiceDisc;

		// Token: 0x04001CD1 RID: 7377
		private decimal discAmount;

		// Token: 0x04001CD2 RID: 7378
		private string currentUOM;

		// Token: 0x04001CD3 RID: 7379
		private int currentExpires;

		// Token: 0x04001CD4 RID: 7380
		private StringReader stringToRead;
	}
}
