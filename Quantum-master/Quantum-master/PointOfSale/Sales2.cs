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
	// Token: 0x0200018A RID: 394
	[DesignerGenerated]
	public partial class Sales2 : UserControl
	{
		// Token: 0x06003B19 RID: 15129 RVA: 0x00200904 File Offset: 0x001FEB04
		public Sales2()
		{
			base.Load += this.Sales_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.CurrentExpires = false;
			this.TextToPrint = "";
			this.datCustomers = new DataTable();
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.datProm = new DataTable();
			this.invtotal = 0m;
			this.og_customername = "";
			this.og_address = "";
			this.og_contactname = "";
			this.og_mobile = "";
			this.og_email = "";
			this.og_tel = "";
			this.og_invdetail1 = "";
			this.og_invdetail2 = "";
			this.currentUOM = "";
			this.invrate = 0m;
			this.invdisc = 0m;
			this.inv_discounted = false;
			this.discDescription = "";
			this.InitializeComponent();
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x00206759 File Offset: 0x00204959
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x00206763 File Offset: 0x00204963
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0020676C File Offset: 0x0020496C
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x00206776 File Offset: 0x00204976
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x0020677F File Offset: 0x0020497F
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x0020678C File Offset: 0x0020498C
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

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x002067CF File Offset: 0x002049CF
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x002067D9 File Offset: 0x002049D9
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x002067E2 File Offset: 0x002049E2
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x002067EC File Offset: 0x002049EC
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x002067F5 File Offset: 0x002049F5
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x002067FF File Offset: 0x002049FF
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x00206808 File Offset: 0x00204A08
		// (set) Token: 0x06003B29 RID: 15145 RVA: 0x00206814 File Offset: 0x00204A14
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

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x0020688D File Offset: 0x00204A8D
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x00206897 File Offset: 0x00204A97
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x002068A0 File Offset: 0x00204AA0
		// (set) Token: 0x06003B2D RID: 15149 RVA: 0x002068AA File Offset: 0x00204AAA
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x002068B3 File Offset: 0x00204AB3
		// (set) Token: 0x06003B2F RID: 15151 RVA: 0x002068BD File Offset: 0x00204ABD
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x002068C6 File Offset: 0x00204AC6
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x002068D0 File Offset: 0x00204AD0
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x002068D9 File Offset: 0x00204AD9
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x002068E3 File Offset: 0x00204AE3
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x002068EC File Offset: 0x00204AEC
		// (set) Token: 0x06003B35 RID: 15157 RVA: 0x002068F6 File Offset: 0x00204AF6
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x002068FF File Offset: 0x00204AFF
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x0020690C File Offset: 0x00204B0C
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

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x0020694F File Offset: 0x00204B4F
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x00206959 File Offset: 0x00204B59
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x00206962 File Offset: 0x00204B62
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x0020696C File Offset: 0x00204B6C
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x00206975 File Offset: 0x00204B75
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x0020697F File Offset: 0x00204B7F
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x00206988 File Offset: 0x00204B88
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x00206994 File Offset: 0x00204B94
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

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x002069D7 File Offset: 0x00204BD7
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x002069E1 File Offset: 0x00204BE1
		internal virtual TextBox txtChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x002069EA File Offset: 0x00204BEA
		// (set) Token: 0x06003B43 RID: 15171 RVA: 0x002069F4 File Offset: 0x00204BF4
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
				TextBox textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtAmtPaid = value;
				textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x00206A52 File Offset: 0x00204C52
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x00206A5C File Offset: 0x00204C5C
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x00206A65 File Offset: 0x00204C65
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x00206A70 File Offset: 0x00204C70
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

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00206AB3 File Offset: 0x00204CB3
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x00206AC0 File Offset: 0x00204CC0
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

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x00206B60 File Offset: 0x00204D60
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x00206B6A File Offset: 0x00204D6A
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x00206B73 File Offset: 0x00204D73
		// (set) Token: 0x06003B4D RID: 15181 RVA: 0x00206B7D File Offset: 0x00204D7D
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x00206B86 File Offset: 0x00204D86
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x00206B90 File Offset: 0x00204D90
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

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x00206BEE File Offset: 0x00204DEE
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x00206BF8 File Offset: 0x00204DF8
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x00206C01 File Offset: 0x00204E01
		// (set) Token: 0x06003B53 RID: 15187 RVA: 0x00206C0B File Offset: 0x00204E0B
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x00206C14 File Offset: 0x00204E14
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x00206C20 File Offset: 0x00204E20
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

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x00206C7E File Offset: 0x00204E7E
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x00206C88 File Offset: 0x00204E88
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x00206C91 File Offset: 0x00204E91
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x00206C9C File Offset: 0x00204E9C
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

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x00206CDF File Offset: 0x00204EDF
		// (set) Token: 0x06003B5B RID: 15195 RVA: 0x00206CE9 File Offset: 0x00204EE9
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x00206CF2 File Offset: 0x00204EF2
		// (set) Token: 0x06003B5D RID: 15197 RVA: 0x00206CFC File Offset: 0x00204EFC
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x00206D05 File Offset: 0x00204F05
		// (set) Token: 0x06003B5F RID: 15199 RVA: 0x00206D0F File Offset: 0x00204F0F
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x00206D18 File Offset: 0x00204F18
		// (set) Token: 0x06003B61 RID: 15201 RVA: 0x00206D22 File Offset: 0x00204F22
		internal virtual TextBox txtCoupons
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x00206D2B File Offset: 0x00204F2B
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x00206D35 File Offset: 0x00204F35
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x00206D3E File Offset: 0x00204F3E
		// (set) Token: 0x06003B65 RID: 15205 RVA: 0x00206D48 File Offset: 0x00204F48
		internal virtual Label lblCouponInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x00206D51 File Offset: 0x00204F51
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x00206D5B File Offset: 0x00204F5B
		internal virtual TextBox txtOLDprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x00206D64 File Offset: 0x00204F64
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x00206D70 File Offset: 0x00204F70
		internal virtual DataGridView dgvpay
		{
			[CompilerGenerated]
			get
			{
				return this._dgvpay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvpay_CellLeave);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.dgvpay_KeyDown);
				DataGridView dataGridView = this._dgvpay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._dgvpay = value;
				dataGridView = this._dgvpay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x00206DCE File Offset: 0x00204FCE
		// (set) Token: 0x06003B6B RID: 15211 RVA: 0x00206DD8 File Offset: 0x00204FD8
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x00206DE1 File Offset: 0x00204FE1
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x00206DEB File Offset: 0x00204FEB
		internal virtual Label lblShiftDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x00206DF4 File Offset: 0x00204FF4
		// (set) Token: 0x06003B6F RID: 15215 RVA: 0x00206DFE File Offset: 0x00204FFE
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x00206E07 File Offset: 0x00205007
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x00206E11 File Offset: 0x00205011
		internal virtual Label lblShift
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x00206E1A File Offset: 0x0020501A
		// (set) Token: 0x06003B73 RID: 15219 RVA: 0x00206E24 File Offset: 0x00205024
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06003B74 RID: 15220 RVA: 0x00206E2D File Offset: 0x0020502D
		// (set) Token: 0x06003B75 RID: 15221 RVA: 0x00206E37 File Offset: 0x00205037
		internal virtual Label lblUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06003B76 RID: 15222 RVA: 0x00206E40 File Offset: 0x00205040
		// (set) Token: 0x06003B77 RID: 15223 RVA: 0x00206E4A File Offset: 0x0020504A
		internal virtual Label lblbranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06003B78 RID: 15224 RVA: 0x00206E53 File Offset: 0x00205053
		// (set) Token: 0x06003B79 RID: 15225 RVA: 0x00206E60 File Offset: 0x00205060
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

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06003B7A RID: 15226 RVA: 0x00206EA3 File Offset: 0x002050A3
		// (set) Token: 0x06003B7B RID: 15227 RVA: 0x00206EAD File Offset: 0x002050AD
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x00206EB6 File Offset: 0x002050B6
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x00206EC0 File Offset: 0x002050C0
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

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x00206F03 File Offset: 0x00205103
		// (set) Token: 0x06003B7F RID: 15231 RVA: 0x00206F10 File Offset: 0x00205110
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

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x00206F53 File Offset: 0x00205153
		// (set) Token: 0x06003B81 RID: 15233 RVA: 0x00206F5D File Offset: 0x0020515D
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x00206F66 File Offset: 0x00205166
		// (set) Token: 0x06003B83 RID: 15235 RVA: 0x00206F70 File Offset: 0x00205170
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06003B84 RID: 15236 RVA: 0x00206F79 File Offset: 0x00205179
		// (set) Token: 0x06003B85 RID: 15237 RVA: 0x00206F84 File Offset: 0x00205184
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

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x00206FC7 File Offset: 0x002051C7
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x00206FD1 File Offset: 0x002051D1
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x00206FDA File Offset: 0x002051DA
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x00206FE4 File Offset: 0x002051E4
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
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtsearch_KeyPress);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x0020705D File Offset: 0x0020525D
		// (set) Token: 0x06003B8B RID: 15243 RVA: 0x00207067 File Offset: 0x00205267
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x00207070 File Offset: 0x00205270
		// (set) Token: 0x06003B8D RID: 15245 RVA: 0x0020707A File Offset: 0x0020527A
		internal virtual ComboBox cboChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x00207083 File Offset: 0x00205283
		// (set) Token: 0x06003B8F RID: 15247 RVA: 0x0020708D File Offset: 0x0020528D
		internal virtual Label lblchangedesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x00207096 File Offset: 0x00205296
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x002070A0 File Offset: 0x002052A0
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

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x002070E3 File Offset: 0x002052E3
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x002070F0 File Offset: 0x002052F0
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

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x00207133 File Offset: 0x00205333
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x0020713D File Offset: 0x0020533D
		internal virtual Label lblTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x00207146 File Offset: 0x00205346
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x00207150 File Offset: 0x00205350
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x00207159 File Offset: 0x00205359
		// (set) Token: 0x06003B99 RID: 15257 RVA: 0x00207163 File Offset: 0x00205363
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x0020716C File Offset: 0x0020536C
		// (set) Token: 0x06003B9B RID: 15259 RVA: 0x00207178 File Offset: 0x00205378
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

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x002071BB File Offset: 0x002053BB
		// (set) Token: 0x06003B9D RID: 15261 RVA: 0x002071C5 File Offset: 0x002053C5
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06003B9E RID: 15262 RVA: 0x002071CE File Offset: 0x002053CE
		// (set) Token: 0x06003B9F RID: 15263 RVA: 0x002071D8 File Offset: 0x002053D8
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

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x0020721B File Offset: 0x0020541B
		// (set) Token: 0x06003BA1 RID: 15265 RVA: 0x00207225 File Offset: 0x00205425
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x0020722E File Offset: 0x0020542E
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x00207238 File Offset: 0x00205438
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

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x0020727B File Offset: 0x0020547B
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x00207285 File Offset: 0x00205485
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x0020728E File Offset: 0x0020548E
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x00207298 File Offset: 0x00205498
		internal virtual Panel Panel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x002072A1 File Offset: 0x002054A1
		// (set) Token: 0x06003BA9 RID: 15273 RVA: 0x002072AC File Offset: 0x002054AC
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

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x002072EF File Offset: 0x002054EF
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x002072F9 File Offset: 0x002054F9
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x00207302 File Offset: 0x00205502
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x0020730C File Offset: 0x0020550C
		internal virtual Panel Panel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x00207315 File Offset: 0x00205515
		// (set) Token: 0x06003BAF RID: 15279 RVA: 0x0020731F File Offset: 0x0020551F
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00207328 File Offset: 0x00205528
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x00207334 File Offset: 0x00205534
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

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x00207377 File Offset: 0x00205577
		// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x00207384 File Offset: 0x00205584
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

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x002073C7 File Offset: 0x002055C7
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x002073D4 File Offset: 0x002055D4
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

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x00207417 File Offset: 0x00205617
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x00207424 File Offset: 0x00205624
		internal virtual Button btnSpecialPrice
		{
			[CompilerGenerated]
			get
			{
				return this._btnSpecialPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button11_Click);
				Button button = this._btnSpecialPrice;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnSpecialPrice = value;
				button = this._btnSpecialPrice;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x00207467 File Offset: 0x00205667
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x00207471 File Offset: 0x00205671
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06003BBA RID: 15290 RVA: 0x0020747A File Offset: 0x0020567A
		// (set) Token: 0x06003BBB RID: 15291 RVA: 0x00207484 File Offset: 0x00205684
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
				EventHandler eventHandler = new EventHandler(this.Button11_Click_1);
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

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x002074C7 File Offset: 0x002056C7
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x002074D1 File Offset: 0x002056D1
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x002074DA File Offset: 0x002056DA
		// (set) Token: 0x06003BBF RID: 15295 RVA: 0x002074E4 File Offset: 0x002056E4
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x002074ED File Offset: 0x002056ED
		// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x002074F7 File Offset: 0x002056F7
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x00207500 File Offset: 0x00205700
		// (set) Token: 0x06003BC3 RID: 15299 RVA: 0x0020750A File Offset: 0x0020570A
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x00207513 File Offset: 0x00205713
		// (set) Token: 0x06003BC5 RID: 15301 RVA: 0x0020751D File Offset: 0x0020571D
		internal virtual TextBox txtInvDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x00207526 File Offset: 0x00205726
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x00207530 File Offset: 0x00205730
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x00207539 File Offset: 0x00205739
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x00207543 File Offset: 0x00205743
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x0020754C File Offset: 0x0020574C
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x00207556 File Offset: 0x00205756
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x0020755F File Offset: 0x0020575F
		// (set) Token: 0x06003BCD RID: 15309 RVA: 0x00207569 File Offset: 0x00205769
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x00207572 File Offset: 0x00205772
		// (set) Token: 0x06003BCF RID: 15311 RVA: 0x0020757C File Offset: 0x0020577C
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x00207585 File Offset: 0x00205785
		// (set) Token: 0x06003BD1 RID: 15313 RVA: 0x0020758F File Offset: 0x0020578F
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x00207598 File Offset: 0x00205798
		// (set) Token: 0x06003BD3 RID: 15315 RVA: 0x002075A2 File Offset: 0x002057A2
		internal virtual TextBox txtContactName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06003BD4 RID: 15316 RVA: 0x002075AB File Offset: 0x002057AB
		// (set) Token: 0x06003BD5 RID: 15317 RVA: 0x002075B5 File Offset: 0x002057B5
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x002075BE File Offset: 0x002057BE
		// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x002075C8 File Offset: 0x002057C8
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06003BD8 RID: 15320 RVA: 0x002075D1 File Offset: 0x002057D1
		// (set) Token: 0x06003BD9 RID: 15321 RVA: 0x002075DB File Offset: 0x002057DB
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06003BDA RID: 15322 RVA: 0x002075E4 File Offset: 0x002057E4
		// (set) Token: 0x06003BDB RID: 15323 RVA: 0x002075EE File Offset: 0x002057EE
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06003BDC RID: 15324 RVA: 0x002075F7 File Offset: 0x002057F7
		// (set) Token: 0x06003BDD RID: 15325 RVA: 0x00207601 File Offset: 0x00205801
		internal virtual TextBox txtcustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x0020760A File Offset: 0x0020580A
		// (set) Token: 0x06003BDF RID: 15327 RVA: 0x00207614 File Offset: 0x00205814
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x0020761D File Offset: 0x0020581D
		// (set) Token: 0x06003BE1 RID: 15329 RVA: 0x00207627 File Offset: 0x00205827
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x00207630 File Offset: 0x00205830
		// (set) Token: 0x06003BE3 RID: 15331 RVA: 0x0020763A File Offset: 0x0020583A
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x00207643 File Offset: 0x00205843
		// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x0020764D File Offset: 0x0020584D
		internal virtual DateTimePicker DateTimePicker2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00207656 File Offset: 0x00205856
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x00207660 File Offset: 0x00205860
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

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x002076A3 File Offset: 0x002058A3
		// (set) Token: 0x06003BE9 RID: 15337 RVA: 0x002076B0 File Offset: 0x002058B0
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

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06003BEA RID: 15338 RVA: 0x002076F3 File Offset: 0x002058F3
		// (set) Token: 0x06003BEB RID: 15339 RVA: 0x00207700 File Offset: 0x00205900
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
				EventHandler eventHandler = new EventHandler(this.txtDiscount_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDiscount_KeyPress);
				TextBox textBox = this._txtDiscount;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtDiscount = value;
				textBox = this._txtDiscount;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x0020775E File Offset: 0x0020595E
		// (set) Token: 0x06003BED RID: 15341 RVA: 0x00207768 File Offset: 0x00205968
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x00207771 File Offset: 0x00205971
		// (set) Token: 0x06003BEF RID: 15343 RVA: 0x0020777B File Offset: 0x0020597B
		internal virtual GroupBox grpCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x00207784 File Offset: 0x00205984
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x0020778E File Offset: 0x0020598E
		internal virtual RadioButton rdbCollectionsNone
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x00207797 File Offset: 0x00205997
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x002077A1 File Offset: 0x002059A1
		internal virtual Label Label33
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x002077AA File Offset: 0x002059AA
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x002077B4 File Offset: 0x002059B4
		internal virtual RadioButton rdpDelivery
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x002077BD File Offset: 0x002059BD
		// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x002077C7 File Offset: 0x002059C7
		internal virtual RadioButton rdbCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x002077D0 File Offset: 0x002059D0
		// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x002077DC File Offset: 0x002059DC
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
				EventHandler eventHandler = new EventHandler(this.Button14_Click);
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

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06003BFA RID: 15354 RVA: 0x0020781F File Offset: 0x00205A1F
		// (set) Token: 0x06003BFB RID: 15355 RVA: 0x00207829 File Offset: 0x00205A29
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x00207832 File Offset: 0x00205A32
		// (set) Token: 0x06003BFD RID: 15357 RVA: 0x0020783C File Offset: 0x00205A3C
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06003BFE RID: 15358 RVA: 0x00207845 File Offset: 0x00205A45
		// (set) Token: 0x06003BFF RID: 15359 RVA: 0x0020784F File Offset: 0x00205A4F
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x00207858 File Offset: 0x00205A58
		// (set) Token: 0x06003C01 RID: 15361 RVA: 0x00207862 File Offset: 0x00205A62
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06003C02 RID: 15362 RVA: 0x0020786B File Offset: 0x00205A6B
		// (set) Token: 0x06003C03 RID: 15363 RVA: 0x00207875 File Offset: 0x00205A75
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06003C04 RID: 15364 RVA: 0x0020787E File Offset: 0x00205A7E
		// (set) Token: 0x06003C05 RID: 15365 RVA: 0x00207888 File Offset: 0x00205A88
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x00207891 File Offset: 0x00205A91
		// (set) Token: 0x06003C07 RID: 15367 RVA: 0x0020789B File Offset: 0x00205A9B
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06003C08 RID: 15368 RVA: 0x002078A4 File Offset: 0x00205AA4
		// (set) Token: 0x06003C09 RID: 15369 RVA: 0x002078AE File Offset: 0x00205AAE
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x002078B7 File Offset: 0x00205AB7
		// (set) Token: 0x06003C0B RID: 15371 RVA: 0x002078C1 File Offset: 0x00205AC1
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x002078CA File Offset: 0x00205ACA
		// (set) Token: 0x06003C0D RID: 15373 RVA: 0x002078D4 File Offset: 0x00205AD4
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x002078DD File Offset: 0x00205ADD
		// (set) Token: 0x06003C0F RID: 15375 RVA: 0x002078E7 File Offset: 0x00205AE7
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06003C10 RID: 15376 RVA: 0x002078F0 File Offset: 0x00205AF0
		// (set) Token: 0x06003C11 RID: 15377 RVA: 0x002078FA File Offset: 0x00205AFA
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00207903 File Offset: 0x00205B03
		// (set) Token: 0x06003C13 RID: 15379 RVA: 0x0020790D File Offset: 0x00205B0D
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00207916 File Offset: 0x00205B16
		// (set) Token: 0x06003C15 RID: 15381 RVA: 0x00207920 File Offset: 0x00205B20
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x00207929 File Offset: 0x00205B29
		// (set) Token: 0x06003C17 RID: 15383 RVA: 0x00207933 File Offset: 0x00205B33
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x0020793C File Offset: 0x00205B3C
		// (set) Token: 0x06003C19 RID: 15385 RVA: 0x00207946 File Offset: 0x00205B46
		internal virtual DataGridViewTextBoxColumn PromStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06003C1A RID: 15386 RVA: 0x0020794F File Offset: 0x00205B4F
		// (set) Token: 0x06003C1B RID: 15387 RVA: 0x00207959 File Offset: 0x00205B59
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x00207962 File Offset: 0x00205B62
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x0020796C File Offset: 0x00205B6C
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x00207975 File Offset: 0x00205B75
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x0020797F File Offset: 0x00205B7F
		internal virtual DataGridViewTextBoxColumn DiscountAmt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x00207988 File Offset: 0x00205B88
		// (set) Token: 0x06003C21 RID: 15393 RVA: 0x00207992 File Offset: 0x00205B92
		internal virtual DataGridViewTextBoxColumn ApprovedBy
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x0020799B File Offset: 0x00205B9B
		// (set) Token: 0x06003C23 RID: 15395 RVA: 0x002079A5 File Offset: 0x00205BA5
		internal virtual DataGridViewTextBoxColumn taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x002079AE File Offset: 0x00205BAE
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x002079B8 File Offset: 0x00205BB8
		internal virtual DataGridViewTextBoxColumn DiscDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x002079C4 File Offset: 0x00205BC4
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
						MessageBox.Show("Your shift was closed. Cannot Continue. Contact you supervisor.");
					}
					else
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want To Continue With your existing shift. Shift Name: ", dataRow2["shiftname"]), " shift start time: "), dataRow2["starttime"]), MsgBoxStyle.YesNo, null);
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
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x00207D0C File Offset: 0x00205F0C
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

		// Token: 0x06003C28 RID: 15400 RVA: 0x00207E24 File Offset: 0x00206024
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
			this.dgvpay.Visible = true;
			bool flag2 = MyProject.Forms.Form1.ShowSpecialPrice == 1;
			if (flag2)
			{
				this.btnSpecialPrice.Visible = true;
			}
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00207EE8 File Offset: 0x002060E8
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

		// Token: 0x06003C2A RID: 15402 RVA: 0x00207F74 File Offset: 0x00206174
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

		// Token: 0x06003C2B RID: 15403 RVA: 0x0020802C File Offset: 0x0020622C
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

		// Token: 0x06003C2C RID: 15404 RVA: 0x002080D0 File Offset: 0x002062D0
		private void Sales_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.TillPointPriceChange == 0;
				if (flag)
				{
					this.txtPriceChange.Visible = false;
					this.Label11.Visible = false;
					this.Button6.Visible = false;
				}
				else
				{
					bool flag2 = MyProject.Forms.Form1.TillPointPriceChange == 1;
					if (flag2)
					{
						this.txtPriceChange.Visible = true;
						this.Label11.Visible = true;
						this.Button6.Visible = true;
					}
				}
				this.lblbranch.Text = MyProject.Forms.Form1.branch;
				this.LoadCustomers();
				this.LoadPaymentMethods();
				this.loadchangepaymentmethods();
				this.LoadPaymentTerms();
				this.lblUsername.Text = MyProject.Forms.Form1.username;
				int num = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
				this.GetBranchDetails();
				this.SetBranchColour();
				bool flag3 = MyProject.Forms.Form1.AllowTellerToViewStockBalances == 0;
				if (flag3)
				{
					this.Label3.Visible = false;
					this.txtStockAvail.Visible = false;
				}
				this.dgvpay.Visible = true;
				this.chkAccount.Visible = true;
				this.cboTerms.Visible = true;
				this.lblTerms.Visible = true;
				this.Button2.Visible = true;
				this.datProm.Columns.Add("PromNo", typeof(int));
				bool flag4 = MyProject.Forms.Form1.DateChange == 1;
				if (flag4)
				{
					this.DateTimePicker2.Enabled = true;
				}
				else
				{
					this.DateTimePicker2.Enabled = false;
				}
				bool flag5 = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag5)
				{
					this.txtQty.Visible = false;
				}
				this.og_customername = "Cash";
				bool flag6 = MyProject.Forms.Form1.ConsultantSalesOnly == 0;
				if (flag6)
				{
					this.sales_consultant = "";
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
					MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
					MyProject.Forms.Form1.DiscountApproved = 0;
					bool flag9 = MyProject.Forms.Form1.TillPointPriceChange == 1;
					if (flag9)
					{
						this.txtDiscount.Enabled = true;
					}
				}
				else
				{
					this.cmdDiscount.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00208400 File Offset: 0x00206600
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

		// Token: 0x06003C2E RID: 15406 RVA: 0x002084F0 File Offset: 0x002066F0
		private void loadchangepaymentmethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboChange.DataSource = dataTable;
			this.cboChange.ValueMember = "PaymentMethodID";
			this.cboChange.DisplayMember = "PaymentMethodDesc";
			this.SetDefaultChangePayMethod();
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x00208598 File Offset: 0x00206798
		private void SetDefaultChangePayMethod()
		{
			checked
			{
				int num = this.cboChange.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRowView dataRowView = (DataRowView)this.cboChange.Items[i];
					int num2 = Conversions.ToInteger(dataRowView["PaymentMethodID"]);
					bool flag = (double)num2 == Conversions.ToDouble(MyProject.Forms.Form1.ChangePaymentMethod);
					if (flag)
					{
						this.cboChange.SelectedIndex = i;
						break;
					}
				}
			}
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0020861C File Offset: 0x0020681C
		private void LoadPaymentMethods()
		{
			this.dgvpay.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvpay.DataSource = dataTable;
			this.dgvpay.Columns["PaymentMethodID"].Visible = false;
			this.dgvpay.Columns["Uploaded"].Visible = false;
			this.dgvpay.Columns["FiscalGroup"].Visible = false;
			this.dgvpay.Columns["Currency"].Visible = false;
			this.dgvpay.Columns["PaymentMethodDesc"].HeaderText = "Payment Method";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "Amount To be Paid";
			dataGridViewTextBoxColumn.Name = "QTYcol";
			dataGridViewTextBoxColumn.DataPropertyName = "QTYcol";
			dataGridViewTextBoxColumn.CellTemplate = new DataGridViewTextBoxCell();
			this.dgvpay.Columns.Insert(4, dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2.HeaderText = "Base Amount";
			dataGridViewTextBoxColumn2.Name = "ActCol";
			dataGridViewTextBoxColumn2.DataPropertyName = "ActCol";
			dataGridViewTextBoxColumn2.CellTemplate = new DataGridViewTextBoxCell();
			this.dgvpay.Columns.Insert(5, dataGridViewTextBoxColumn2);
			this.dgvpay.Columns["PaymentMethodDesc"].ReadOnly = true;
			this.dgvpay.Columns["Rate"].ReadOnly = true;
			this.dgvpay.Columns["Qtycol"].ReadOnly = true;
			this.dgvpay.Columns["DiscountPerc"].ReadOnly = true;
			this.dgvpay.Columns["PaymentMethodDesc"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvpay.Columns["Rate"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvpay.Columns["Qtycol"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvpay.Columns["DiscountPerc"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvpay.Columns["DiscountPerc"].Visible = false;
			this.dgvpay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00208908 File Offset: 0x00206B08
		private bool CheckIFPayMethACcurate()
		{
			checked
			{
				bool flag2;
				try
				{
					bool flag = Convert.ToDouble(Conversion.Val(this.txtChange.Text)) < 0.0;
					if (flag)
					{
						flag2 = false;
					}
					else
					{
						double num = 0.0;
						int num2 = this.dgvpay.Rows.Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							double num3 = 0.0;
							try
							{
								num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgvpay.Rows[i].Cells["ActCol"].Value));
							}
							catch (Exception ex)
							{
								num3 = 0.0;
							}
							bool flag3 = num3 != 0.0;
							if (flag3)
							{
								double num4 = Conversions.ToDouble(this.dgvpay.Rows[i].Cells["ActCol"].Value);
								object objectValue = RuntimeHelpers.GetObjectValue(this.dgvpay.Rows[i].Cells["PaymentMethodDesc"].Value);
								object objectValue2 = RuntimeHelpers.GetObjectValue(this.dgvpay.Rows[i].Cells["PaymentMethodID"].Value);
								num = unchecked(num + num4 - Convert.ToDouble(Conversion.Val(this.txtChange.Text)));
							}
						}
						decimal num5 = Convert.ToDecimal(Strings.Format(num, "0.00"));
						decimal num6 = Convert.ToDecimal(Conversion.Val(this.txtTotal.Text));
						bool flag4 = Conversion.Val(this.txtChange.Text) >= 0.0;
						if (flag4)
						{
							bool flag5 = decimal.Compare(num5, decimal.Add(num6, Convert.ToDecimal(Conversion.Val(this.txtChange.Text)))) == 0;
							if (flag5)
							{
								flag2 = true;
							}
							else
							{
								flag2 = false;
							}
						}
						else
						{
							flag2 = false;
						}
					}
				}
				catch (Exception ex2)
				{
					flag2 = false;
				}
				return flag2;
			}
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProdtID_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00208B64 File Offset: 0x00206D64
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

		// Token: 0x06003C34 RID: 15412 RVA: 0x00208C3C File Offset: 0x00206E3C
		private void CalcTotalSale()
		{
			double num = 0.0;
			double num2 = 0.0;
			decimal num3 = 0m;
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
			this.txtDiscount.Text = num3.ToString();
			num -= Convert.ToDouble(num3);
			this.txtTotal.Text = num.ToString();
			this.txtTax.Text = num2.ToString();
			MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00208D60 File Offset: 0x00206F60
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
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				bool flag2 = Operators.CompareString(this.txtSearchProductCode.Text, "", false) != 0;
				if (flag2)
				{
					this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.CurrentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
				}
			}
			else
			{
				this.txtDesc.Text = "Nothing matching product ID";
			}
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00208FB4 File Offset: 0x002071B4
		private void AppendGrid()
		{
			int num = 0;
			int num2 = 0;
			bool flag = (MyProject.Forms.Form1.IsWarehouse == 0) | ((MyProject.Forms.Form1.IsWarehouse == 1) & !this.CurrentExpires);
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
					num6 = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num4, 100m))), 2, MidpointRounding.AwayFromZero);
					num7 = new decimal(Math.Round(Convert.ToDouble(Math.Round(decimal.Multiply(decimal.Divide(num4, 100m), num6), 2, MidpointRounding.AwayFromZero)) * Conversion.Val(this.txtQty.Text), 2, MidpointRounding.AwayFromZero));
				}
				else
				{
					num6 = num5;
					num7 = 0m;
				}
				decimal num8 = new decimal(Conversions.ToDouble(this.txtQty.Text) * Convert.ToDouble(num5));
				num8 = num8;
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
					"",
					"",
					"",
					Conversions.ToString(0),
					MyProject.Forms.Form1.Approvedby,
					Conversions.ToString(num4),
					this.discDescription
				};
				this.DataGridView1.Rows.Add(array);
			}
			else
			{
				bool flag5 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.CurrentExpires;
				if (flag5)
				{
					decimal num9 = 0m;
					decimal num10 = Convert.ToDecimal(this.lbltax.Text);
					decimal num11 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num9);
					DataTable selectedBatch = MyProject.Forms.Form1.SelectedBatch;
					bool flag6 = selectedBatch.Rows.Count > 0;
					if (flag6)
					{
						try
						{
							foreach (object obj in selectedBatch.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								int num12 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"]));
								bool flag7 = num12 != 0;
								if (flag7)
								{
									decimal num13 = decimal.Multiply(new decimal(num12), num11);
									num13 = num13;
									bool flag8 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
									if (flag8)
									{
										num = checked((int)Math.Round(Conversion.Val(this.txtCoupons.Text)));
									}
									bool flag9 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
									if (flag9)
									{
										num9 = Convert.ToDecimal(this.txtPriceChange.Text);
										this.txtOLDprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
										num2 = 1;
										this.priceb4tax = decimal.Add(this.priceb4tax, num9);
									}
									bool flag10 = decimal.Compare(num10, 0m) != 0;
									decimal num6;
									decimal num7;
									if (flag10)
									{
										num6 = decimal.Divide(num11, decimal.Add(1m, decimal.Divide(num10, 100m)));
										num7 = decimal.Multiply(Math.Round(decimal.Multiply(decimal.Divide(num10, 100m), num6), 2), new decimal(num12));
									}
									else
									{
										num6 = num11;
										num7 = 0m;
									}
									string[] array2 = new string[]
									{
										Conversions.ToString(this.CurrentID),
										this.CurrentCode,
										this.txtDesc.Text,
										num6.ToString(),
										num12.ToString(),
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
										"",
										dataRow["BatchNumber"].ToString(),
										dataRow["ExpiryDate"].ToString(),
										MyProject.Forms.Form1.Approvedby,
										Conversions.ToString(num10),
										this.discDescription
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
						MessageBox.Show("No products selected.");
					}
				}
			}
			this.CheckPromotions();
			this.txtPriceChange.ReadOnly = true;
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00209644 File Offset: 0x00207844
		private DataTable GetBal()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "StockBalanceWarehouse";
			sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			new SqlDataAdapter(sqlCommand)
			{
				SelectCommand = sqlCommand
			}.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00209710 File Offset: 0x00207910
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.IsWarehouse == 1) & this.CurrentExpires;
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
				}
				this.EnterItem();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending data. Details: " + ex.Message);
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x002097E0 File Offset: 0x002079E0
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
					bool flag5 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag5)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
					this.txtPriceChange.Text = "";
					this.lblcode.Text = "";
					this.WholesalePriceByQty = 0;
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

		// Token: 0x06003C3A RID: 15418 RVA: 0x0020993C File Offset: 0x00207B3C
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

		// Token: 0x06003C3B RID: 15419 RVA: 0x002099F8 File Offset: 0x00207BF8
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

		// Token: 0x06003C3C RID: 15420 RVA: 0x00209AD0 File Offset: 0x00207CD0
		private void InsertSale(int prodtid, decimal saleqty, double unitcost, double salesprice, int paymentmethod, int invnum, string prodcode, int thetime, double taxamt, string shift, int shiftdate, int pricewholesale, int pricewholesalebyqty, string saletype, decimal discamt, string vbatchnumber, int vExpirydate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewSale2Warehouse2";
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
			sqlCommand.Parameters.AddWithValue("BatchNumber", vbatchnumber);
			sqlCommand.Parameters.AddWithValue("ExpiryDate", vExpirydate);
			sqlCommand.Parameters.AddWithValue("usereceiptdisplay", MyProject.Forms.Form1.UseReceiptDisplay);
			sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", MyProject.Forms.Form1.ReceiptDisplayPaymentMethod);
			bool flag = MyProject.Forms.Form1.UseReceiptDisplay == 1;
			if (flag)
			{
				sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod));
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", 1);
			}
			sqlCommand.Parameters.AddWithValue("discountamount", discamt);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x00209E34 File Offset: 0x00208034
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

		// Token: 0x06003C3E RID: 15422 RVA: 0x00209EB8 File Offset: 0x002080B8
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.AllowSalesonComputer == 1;
				if (flag)
				{
					bool flag2 = MyProject.Forms.Form1.ConsultantSalesOnly == 1;
					if (flag2)
					{
						bool flag3 = this.sales_consultant == null;
						if (flag3)
						{
							MessageBox.Show("Only sales from consultants allowed. Go to quotations and select a ref to proceed.");
							return;
						}
					}
					Cursor.Current = Cursors.WaitCursor;
					this.invtotal = 0m;
					this.ConfirmSale();
					Cursor.Current = Cursors.Default;
				}
				else
				{
					MessageBox.Show("Sales are not allowed on this computer.");
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
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error performing sale. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x00209FC4 File Offset: 0x002081C4
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
					sqlCommand.CommandTimeout = 420;
					bool flag = !this.chkAccount.Checked;
					if (flag)
					{
						bool flag2 = this.CheckIFPayMethACcurate();
						if (!flag2)
						{
							MessageBox.Show("Check payment methods. Sale cannot proceed.");
							Cursor.Current = Cursors.Default;
							try
							{
								sqlTransaction.Rollback();
								sqlConnection.Close();
							}
							catch (Exception ex)
							{
							}
							this.dgvpay.Focus();
							this.dgvpay.CurrentCell = this.dgvpay.Rows[0].Cells["QTYCol"];
							this.dgvpay.BeginEdit(true);
							return;
						}
						int num = 1;
						bool flag3 = this.CheckIfCustomerDetailsChanged();
						if (flag3)
						{
							this.UpdateCustomer();
						}
						sqlCommand.CommandType = CommandType.StoredProcedure;
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
								sqlCommand.Parameters.AddWithValue("salesprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)));
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
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value)), "", dataGridViewRow.Cells["BatchNumber"].Value.ToString())));
								bool flag5 = Operators.CompareString(dataGridViewRow.Cells["ExpiryDate"].Value.ToString(), "", false) == 0;
								if (flag5)
								{
									sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
								}
								else
								{
									int num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
									sqlCommand.Parameters.AddWithValue("ExpiryDate", num3);
								}
								sqlCommand.Parameters.AddWithValue("usereceiptdisplay", MyProject.Forms.Form1.UseReceiptDisplay);
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", MyProject.Forms.Form1.ReceiptDisplayPaymentMethod);
								bool flag6 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
								if (flag6)
								{
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod));
								}
								else
								{
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", 1);
								}
								sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["discountamt"].Value)));
								sqlCommand.Parameters.AddWithValue("consultant", this.sales_consultant);
								sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text));
								string text = "";
								bool @checked = this.rdbCollection.Checked;
								if (@checked)
								{
									text = "COLLECTION";
								}
								else
								{
									bool checked2 = this.rdpDelivery.Checked;
									if (checked2)
									{
										text = "DELIVERY";
									}
								}
								sqlCommand.Parameters.AddWithValue("collection", text);
								sqlCommand.Parameters.AddWithValue("discountdesc", this.discDescription);
								sqlCommand.ExecuteNonQuery();
								bool flag7 = Operators.ConditionalCompareObjectGreater(dataGridViewRow.Cells["CouponNumber"].Value, 0, false);
								if (flag7)
								{
									int num4 = Conversions.ToInteger(dataGridViewRow.Cells["CouponNumber"].Value);
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "UpdateCoupon";
									sqlCommand.Parameters.AddWithValue("CouponNumber", num4);
									sqlCommand.ExecuteNonQuery();
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "InsertDiscount";
									sqlCommand.Parameters.AddWithValue("TranDate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value));
									sqlCommand.Parameters.AddWithValue("pricebefore", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("couponnumber", num4);
									sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
									sqlCommand.Parameters.AddWithValue("discounttype", "");
									sqlCommand.Parameters.AddWithValue("discountperinvoice", "");
									sqlCommand.ExecuteNonQuery();
								}
								bool flag8 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["PriceChange"].Value, 1, false);
								if (flag8)
								{
									decimal num5 = decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)));
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "PCInsertPriceChange";
									sqlCommand.Parameters.AddWithValue("productid", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value)));
									sqlCommand.Parameters.AddWithValue("qty", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
									sqlCommand.Parameters.AddWithValue("pricechange", num5);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("donetime", DateTime.Now.ToString("HH:mm"));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("invoiceno", this.invnum);
									sqlCommand.Parameters.AddWithValue("normalprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)));
									sqlCommand.Parameters.AddWithValue("costprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
									sqlCommand.Parameters.AddWithValue("approvedby", dataGridViewRow.Cells["ApprovedBy"].Value.ToString());
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
						try
						{
							foreach (object obj2 in ((IEnumerable)this.dgvpay.Rows))
							{
								DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
								int count = this.dgvpay.Rows.Count;
								double num6 = 0.0;
								bool flag9 = Operators.CompareString(dataGridViewRow2.Cells["Qtycol"].Value.ToString(), "", false) != 0;
								if (flag9)
								{
									bool flag10 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow2.Cells["Actcol"].Value, 0, false);
									if (flag10)
									{
										double num7 = Convert.ToDouble(Conversion.Val(this.txtChange.Text));
										bool flag11 = num7 == 0.0;
										if (flag11)
										{
											num6 = Conversions.ToDouble(dataGridViewRow2.Cells["QTYcol"].Value);
										}
										else
										{
											bool flag12 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["PaymentMethodID"].Value)) == Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboChange.SelectedValue));
											if (flag12)
											{
												num6 = Conversions.ToDouble(Operators.SubtractObject(dataGridViewRow2.Cells["QTYcol"].Value, num7));
											}
										}
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "InsertActualPaymentMethods";
										sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
										sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["PaymentMethodID"].Value));
										sqlCommand.Parameters.AddWithValue("paydesc", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["PaymentMethodDesc"].Value));
										sqlCommand.Parameters.AddWithValue("amt", num6);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("rate", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Rate"].Value));
										sqlCommand.ExecuteNonQuery();
										bool flag13 = MyProject.Forms.Form1.CollectEcocashDetails == 1;
										if (flag13)
										{
											bool flag14 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["paymentMethodDesc"].Value, "Ecocash", false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["paymentMethodDesc"].Value, "ECOCASH", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["paymentMethodDesc"].Value, "ecocash", false)));
											if (flag14)
											{
												EcocashDetails ecocashDetails = new EcocashDetails();
												ecocashDetails.invoice_number = this.invnum;
												ecocashDetails.fullcusname = this.txtcustomer.Text;
												ecocashDetails.ecoexpected = new decimal(num6);
												ecocashDetails.ShowDialog(this);
												ecocashDetails.Dispose();
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
						bool flag15 = this.datProm.Rows.Count > 0;
						if (flag15)
						{
							try
							{
								foreach (object obj3 in this.datProm.Rows)
								{
									DataRow dataRow = (DataRow)obj3;
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "PromotionGivenInsertN";
									sqlCommand.Parameters.AddWithValue("theday", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
									sqlCommand.Parameters.AddWithValue("promotionno", RuntimeHelpers.GetObjectValue(dataRow["PromNo"]));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
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
					}
					else
					{
						bool flag16 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0;
						if (!flag16)
						{
							try
							{
								MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
								MyProject.Forms.Form1.DiscountApproved = 0;
								MessageBox.Show("Please select/enter a customer name first before confirming the sale.");
								Cursor.Current = Cursors.Default;
								sqlTransaction.Rollback();
								sqlConnection.Close();
							}
							catch (Exception ex2)
							{
							}
							return;
						}
						bool flag17 = this.CheckIfCustomerDetailsChanged();
						if (flag17)
						{
							this.UpdateCustomer();
						}
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "GetSalesInvoiceNumber";
						sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						sqlCommand.Parameters.AddWithValue("allowbackdated", MyProject.Forms.Form1.DateChange);
						sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
						sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
						sqlCommand.ExecuteNonQuery();
						this.invnum = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
						bool flag18 = this.invnum == 0;
						if (flag18)
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
						int num8 = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
						DateTime dateTime2 = Conversions.ToDate(this.lblShiftDate.Text);
						try
						{
							foreach (object obj4 in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj4;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertNewSale2Warehouse3";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Prodtid"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
								sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Qty"].Value)));
								sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["UnitCost"].Value)));
								sqlCommand.Parameters.AddWithValue("salesprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["UnitPrice"].Value)));
								sqlCommand.Parameters.AddWithValue("paymentmethod", 10);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 3);
								sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["ProductCode"].Value));
								sqlCommand.Parameters.AddWithValue("TranTime", num8);
								sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Tax"].Value)));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
								sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(dateTime2.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["BatchNumber"].Value)), "", dataGridViewRow3.Cells["BatchNumber"].Value.ToString())));
								bool flag19 = Operators.CompareString(dataGridViewRow3.Cells["ExpiryDate"].Value.ToString(), "", false) == 0;
								if (flag19)
								{
									sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
								}
								else
								{
									int num9 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["ExpiryDate"].Value));
									sqlCommand.Parameters.AddWithValue("ExpiryDate", num9);
								}
								sqlCommand.Parameters.AddWithValue("usereceiptdisplay", MyProject.Forms.Form1.UseReceiptDisplay);
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", MyProject.Forms.Form1.ReceiptDisplayPaymentMethod);
								bool flag20 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
								if (flag20)
								{
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod));
								}
								else
								{
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", 1);
								}
								sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["discountamt"].Value)));
								sqlCommand.Parameters.AddWithValue("consultant", this.sales_consultant);
								sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text));
								string text2 = "";
								bool checked3 = this.rdbCollection.Checked;
								if (checked3)
								{
									text2 = "COLLECTION";
								}
								else
								{
									bool checked4 = this.rdpDelivery.Checked;
									if (checked4)
									{
										text2 = "DELIVERY";
									}
								}
								sqlCommand.Parameters.AddWithValue("collection", text2);
								sqlCommand.Parameters.AddWithValue("discountdesc", this.discDescription);
								sqlCommand.ExecuteNonQuery();
								bool flag21 = Operators.ConditionalCompareObjectGreater(dataGridViewRow3.Cells["CouponNumber"].Value, 0, false);
								if (flag21)
								{
									int num10 = Conversions.ToInteger(dataGridViewRow3.Cells["CouponNumber"].Value);
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "UpdateCoupon";
									sqlCommand.Parameters.AddWithValue("CouponNumber", num10);
									sqlCommand.ExecuteNonQuery();
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "InsertDiscount";
									sqlCommand.Parameters.AddWithValue("TranDate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["UnitPrice"].Value));
									sqlCommand.Parameters.AddWithValue("pricebefore", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["OldPrice"].Value));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("couponnumber", num10);
									sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Qty"].Value));
									sqlCommand.Parameters.AddWithValue("discounttype", "");
									sqlCommand.Parameters.AddWithValue("discountperinvoice", "");
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
						DateTime dateTime3 = this.DTdate.Value.AddDays((double)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue)));
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "BillingInsertAccSale2";
						sqlCommand.Parameters.AddWithValue("customername", this.txtcustomer.Text);
						sqlCommand.Parameters.AddWithValue("invoicenumber", this.invnum);
						sqlCommand.Parameters.AddWithValue("amount", Convert.ToDecimal(this.txtTotal.Text));
						sqlCommand.Parameters.AddWithValue("shiftdate", dateTime2.ToString("yyyyMMdd"));
						sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("trantime", num8);
						sqlCommand.Parameters.AddWithValue("teller", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("terms", RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue));
						sqlCommand.Parameters.AddWithValue("DueDate", Convert.ToInt32(dateTime3.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("rate", 1);
						sqlCommand.Parameters.AddWithValue("paymentmethodid", 0);
						sqlCommand.Parameters.AddWithValue("paymentmethodiddesc", "");
						sqlCommand.Parameters.AddWithValue("invdiscount", 0);
						sqlCommand.ExecuteNonQuery();
						bool flag22 = this.datProm.Rows.Count > 0;
						if (flag22)
						{
							try
							{
								foreach (object obj5 in this.datProm.Rows)
								{
									DataRow dataRow2 = (DataRow)obj5;
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "PromotionGivenInsertN";
									sqlCommand.Parameters.AddWithValue("theday", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
									sqlCommand.Parameters.AddWithValue("promotionno", RuntimeHelpers.GetObjectValue(dataRow2["PromNo"]));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
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
					}
					sqlTransaction.Commit();
					sqlConnection.Close();
					bool flag23 = MyProject.Forms.Form1.PrintReceipt == 1;
					if (flag23)
					{
						bool flag24 = MyProject.Forms.Form1.PrintFiscal == 0;
						if (flag24)
						{
							for (int i = MyProject.Forms.Form1.NumOfReceiptsPrint; i > 0; i--)
							{
								bool flag25 = MyProject.Forms.Form1.ReceiptSize80 == 1;
								if (flag25)
								{
									this.PrintReceipt(this.invnum);
								}
								else
								{
									bool flag26 = MyProject.Forms.Form1.ReceiptSize80 == 0;
									if (flag26)
									{
										this.PrintReceipt58(this.invnum);
									}
								}
							}
						}
						else
						{
							bool flag27 = MyProject.Forms.Form1.PrintFiscal == 1;
							if (flag27)
							{
								MessageBox.Show("ELTRADE NOT CONFIGURED");
								return;
							}
						}
					}
					bool flag28 = MyProject.Forms.Form1.PrintInvoice == 1;
					if (flag28)
					{
						this.PrintInvoice();
					}
					this.ClearForm();
					bool flag29 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag29)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
					MessageBox.Show("Sale Done. Invoice number: " + this.invnum.ToString());
				}
				catch (Exception ex3)
				{
					try
					{
						MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
						MyProject.Forms.Form1.DiscountApproved = 0;
						MessageBox.Show("Error confirming sale. Attempting rollback. Detail: " + ex3.Message);
						this.Button2.TabStop = false;
						Cursor.Current = Cursors.Default;
						SqlTransaction sqlTransaction;
						sqlTransaction.Rollback();
						sqlConnection.Close();
					}
					catch (Exception ex4)
					{
					}
				}
			}
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x0020C20C File Offset: 0x0020A40C
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

		// Token: 0x06003C41 RID: 15425 RVA: 0x0020C314 File Offset: 0x0020A514
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
			this.txtContactName.Text = "";
			this.txtMobile.Text = "";
			this.txtEmail.Text = "";
			this.txtTel.Text = "";
			this.txtInvDetails1.Text = "";
			this.txtInvDetails2.Text = "";
			this.og_customername = this.txtcustomer.Text;
			this.og_address = this.txtAddress.Text;
			this.og_contactname = this.txtContactName.Text;
			this.og_mobile = this.txtMobile.Text;
			this.og_email = this.txtEmail.Text;
			this.og_tel = this.txtTel.Text;
			this.og_invdetail1 = this.txtInvDetails1.Text;
			this.og_invdetail2 = this.txtInvDetails2.Text;
			this.txtChange.Text = "";
			this.txtAmtPaid.Text = "";
			this.txtContactName.Text = "";
			this.txtTax.Text = Conversions.ToString(0);
			this.txtPriceChange.Text = "";
			this.lblcode.Text = "";
			this.Button2.TabStop = false;
			this.txtDiscount.Text = "0";
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvpay.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells["QTYcol"].Value = "";
					dataGridViewRow.Cells["ActCol"].Value = "";
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
			this.SetDefaultChangePayMethod();
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
			this.LoadPaymentMethods();
			this.WholesalePriceByQty = 0;
			this.sales_consultant = "";
			this.rdbCollectionsNone.Checked = true;
			MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
			MyProject.Forms.Form1.DiscountApproved = 0;
			this.inv_discounted = false;
			try
			{
				foreach (object obj2 in ((IEnumerable)this.dgvpay.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					dataGridViewRow2.ReadOnly = false;
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
			this.discDescription = "";
			this.txtPriceChange.ReadOnly = true;
			this.txtDiscount.ReadOnly = true;
			DataTable dataTable = new DataTable();
			this.datProm = dataTable;
			this.datProm.Columns.Add("PromNo", typeof(int));
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x0020C704 File Offset: 0x0020A904
		private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x0020C750 File Offset: 0x0020A950
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

		// Token: 0x06003C45 RID: 15429 RVA: 0x0020C7D4 File Offset: 0x0020A9D4
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

		// Token: 0x06003C46 RID: 15430 RVA: 0x0020C84C File Offset: 0x0020AA4C
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

		// Token: 0x06003C47 RID: 15431 RVA: 0x0020C8C4 File Offset: 0x0020AAC4
		private void PrintReceipt58(int invnumber)
		{
			this.PrintHeader58();
			this.ItemsToBePrinted58(invnumber);
			this.PrintFooter58();
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

		// Token: 0x06003C48 RID: 15432 RVA: 0x0020C93C File Offset: 0x0020AB3C
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

		// Token: 0x06003C49 RID: 15433 RVA: 0x0020CD14 File Offset: 0x0020AF14
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

		// Token: 0x06003C4A RID: 15434 RVA: 0x0020CF1C File Offset: 0x0020B11C
		public void ItemsToBePrinted(int invnumber)
		{
			this.invtotal = 0m;
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool @checked = this.chkAccount.Checked;
			if (@checked)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "CREDIT SALE" + Environment.NewLine;
			}
			else
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
			}
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
			decimal num = 0m;
			decimal num2 = 0m;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", invnumber);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num3 = sqlDataAdapter.Fill(dataTable);
			bool flag2 = num3 > 0;
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
							num = Conversions.ToDecimal(dataRow["Quantity"]);
							double num4 = Conversions.ToDouble(dataRow["Unit_Selling_Price"]);
							double num5 = Conversions.ToDouble(dataRow["Sub_Total"]);
							string text2 = Conversions.ToString(dataRow["Product_Code"]);
							num2 = Conversions.ToDecimal(dataRow["DiscountAmt"]);
							this.invrate = Conversions.ToDecimal(dataRow["therate"]);
							this.invdisc = Conversions.ToDecimal(dataRow["invdiscount"]);
							int num6 = (int)Math.Round(Conversion.Val(text.Length));
							bool flag3 = num6 >= 34;
							if (flag3)
							{
								text = text.Substring(0, 33);
							}
							else
							{
								int num7 = num6;
								int num8 = 34 - num7;
								text = text.PadRight(num8);
							}
							int length = text.Length;
							string text3 = text;
							string text4 = Conversions.ToString(text3.Length);
							string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text3 + Environment.NewLine;
							decimal num9 = 0m;
							bool flag4 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
							unchecked
							{
								if (flag4)
								{
									decimal rate = this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod);
									num2 = decimal.Multiply(num2, rate);
									decimal num10 = new decimal(num4 * Convert.ToDouble(rate));
									decimal num11 = new decimal(num4 * Convert.ToDouble(rate) + Convert.ToDouble(num2));
									num9 = decimal.Multiply(num10, num);
									this.invtotal = decimal.Add(this.invtotal, num9);
									text3 = "";
									bool flag5 = decimal.Compare(num2, 0m) > 0;
									if (flag5)
									{
										text3 = string.Concat(new string[]
										{
											Strings.FormatCurrency(num11.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
											"     LESS DISCOUNT ",
											Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
											" > ",
											Strings.FormatCurrency(num10.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
											Environment.NewLine
										});
									}
									text3 = string.Concat(new string[]
									{
										text3,
										"     ",
										num.ToString(),
										"   X        ",
										Strings.FormatCurrency(num10.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
										"            ",
										Strings.FormatCurrency(num9.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
									});
								}
								else
								{
									decimal num12 = new decimal(num4);
									decimal num13 = new decimal(num4 + Convert.ToDouble(num2));
									num9 = decimal.Multiply(num12, num);
									this.invtotal = decimal.Add(this.invtotal, num9);
									text3 = "";
									bool flag6 = decimal.Compare(num2, 0m) > 0;
									if (flag6)
									{
										text3 = string.Concat(new string[]
										{
											Strings.FormatCurrency(num13.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
											"     LESS DISCOUNT ",
											Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
											" > ",
											Strings.FormatCurrency(num12.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
											Environment.NewLine
										});
									}
									text3 = string.Concat(new string[]
									{
										text3,
										"     ",
										num.ToString(),
										"   X        ",
										Strings.FormatCurrency(num12.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
										"            ",
										Strings.FormatCurrency(num9.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
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

		// Token: 0x06003C4B RID: 15435 RVA: 0x0020D640 File Offset: 0x0020B840
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

		// Token: 0x06003C4C RID: 15436 RVA: 0x0020D6F0 File Offset: 0x0020B8F0
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

		// Token: 0x06003C4D RID: 15437 RVA: 0x0020DB2C File Offset: 0x0020BD2C
		private void PrintFooter()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
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
				bool flag2 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				if (flag2)
				{
					decimal num = this.invtotal;
					text = "Sub-Tot       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				else
				{
					text = "Sub-Tot       " + Strings.FormatCurrency(this.invtotal, -1, TriState.UseDefault, TriState.True, TriState.True);
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
				text2 = Conversions.ToString(length);
				string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag3 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				if (flag3)
				{
					decimal num2 = decimal.Multiply(this.invdisc, this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod));
					text = "Disc          " + Strings.FormatCurrency(num2, -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				else
				{
					text = "Disc          " + Strings.FormatCurrency(this.invdisc, -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text5 + text + Environment.NewLine;
				text2 = Conversions.ToString(length);
				string text6 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				text = "Total           " + Strings.FormatCurrency(decimal.Subtract(this.invtotal, this.invdisc), -1, TriState.UseDefault, TriState.True, TriState.True);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text6 + text + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = "Customer:" + this.txtcustomer.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag4 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag4)
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
					bool flag5 = !this.chkAccount.Checked;
					if (flag5)
					{
						try
						{
							foreach (object obj in ((IEnumerable)this.dgvpay.Rows))
							{
								object objectValue = RuntimeHelpers.GetObjectValue(obj);
								bool flag6 = Operators.CompareString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[] { "Qtycol" }, null, null, null), null, "Value", new object[0], null, null, null).ToString(), "", false) != 0;
								if (flag6)
								{
									text = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[] { "PaymentMethodDesc" }, null, null, null), null, "value", new object[0], null, null, null).ToString() + ": $" + NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[] { "Qtycol" }, null, null, null), null, "value", new object[0], null, null, null).ToString();
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
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
					}
				}
				text = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x0020E05C File Offset: 0x0020C25C
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
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvpay.Rows))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						bool flag4 = Operators.CompareString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[] { "Qtycol" }, null, null, null), null, "Value", new object[0], null, null, null).ToString(), "", false) != 0;
						if (flag4)
						{
							text = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[] { "PaymentMethodDesc" }, null, null, null), null, "value", new object[0], null, null, null).ToString() + ": $" + NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[] { "Qtycol" }, null, null, null), null, "value", new object[0], null, null, null).ToString();
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
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				bool flag5 = Operators.CompareString(MyProject.Forms.Form1.ReceiptFootnote, "", false) != 0;
				if (flag5)
				{
					text = MyProject.Forms.Form1.ReceiptFootnote;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				}
			}
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0020E528 File Offset: 0x0020C728
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

		// Token: 0x06003C50 RID: 15440 RVA: 0x0020E684 File Offset: 0x0020C884
		private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
		{
			Stream stream = new MemoryStream();
			this.m_streams.Add(stream);
			return stream;
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x0020E6AC File Offset: 0x0020C8AC
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

		// Token: 0x06003C52 RID: 15442 RVA: 0x0020E730 File Offset: 0x0020C930
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

		// Token: 0x06003C53 RID: 15443 RVA: 0x0020E804 File Offset: 0x0020CA04
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

		// Token: 0x06003C54 RID: 15444 RVA: 0x0020E884 File Offset: 0x0020CA84
		private void PrintInvoice()
		{
			SalesInvoicePortrait salesInvoicePortrait = new SalesInvoicePortrait();
			salesInvoicePortrait.invnum = this.invnum;
			salesInvoicePortrait.ShowDialog(this);
			salesInvoicePortrait.Dispose();
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x0020E8B4 File Offset: 0x0020CAB4
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

		// Token: 0x06003C56 RID: 15446 RVA: 0x0020E908 File Offset: 0x0020CB08
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

		// Token: 0x06003C57 RID: 15447 RVA: 0x0020EAB4 File Offset: 0x0020CCB4
		private void GetCompanyDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectCoDetails";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				try
				{
					this.coname = dataRow["Company"].ToString();
					this.coadd = dataRow["Address"].ToString();
					this.cotel = dataRow["Tel"].ToString();
					this.cotel2 = dataRow["Tel2"].ToString();
					this.cotel3 = dataRow["Tel3"].ToString();
					this.coemail = dataRow["Email"].ToString();
					this.cobpnum = dataRow["BPNumber"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x0020EBEC File Offset: 0x0020CDEC
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

		// Token: 0x06003C59 RID: 15449 RVA: 0x0020EC7C File Offset: 0x0020CE7C
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

		// Token: 0x06003C5A RID: 15450 RVA: 0x0020ECD8 File Offset: 0x0020CED8
		private void SaveCustomerDetails()
		{
			try
			{
				this.UpdateCustomer();
				this.LoadCustomers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer details. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x0020ED30 File Offset: 0x0020CF30
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

		// Token: 0x06003C5C RID: 15452 RVA: 0x0020EE1C File Offset: 0x0020D01C
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

		// Token: 0x06003C5D RID: 15453 RVA: 0x0020EEE0 File Offset: 0x0020D0E0
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

		// Token: 0x06003C5E RID: 15454 RVA: 0x0020EF68 File Offset: 0x0020D168
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

		// Token: 0x06003C5F RID: 15455 RVA: 0x0020F060 File Offset: 0x0020D260
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

		// Token: 0x06003C60 RID: 15456 RVA: 0x0020F16C File Offset: 0x0020D36C
		private object searchDat(DataTable dt, string column, string value)
		{
			Sales2._Closure$__639-0 CS$<>8__locals1 = new Sales2._Closure$__639-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((Sales2._Closure$__.$I639-0 == null) ? (Sales2._Closure$__.$I639-0 = (object row1) => (DataRow)row1) : Sales2._Closure$__.$I639-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06003C61 RID: 15457 RVA: 0x0020F248 File Offset: 0x0020D448
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

		// Token: 0x06003C62 RID: 15458 RVA: 0x0020F2D0 File Offset: 0x0020D4D0
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

		// Token: 0x06003C63 RID: 15459 RVA: 0x0020F4A8 File Offset: 0x0020D6A8
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

		// Token: 0x06003C64 RID: 15460 RVA: 0x0020F508 File Offset: 0x0020D708
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

		// Token: 0x06003C65 RID: 15461 RVA: 0x0020F5CC File Offset: 0x0020D7CC
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

		// Token: 0x06003C66 RID: 15462 RVA: 0x0020F62C File Offset: 0x0020D82C
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

		// Token: 0x06003C67 RID: 15463 RVA: 0x0020F6F8 File Offset: 0x0020D8F8
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
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = num2 == 0;
				decimal num3;
				decimal num4;
				if (flag2)
				{
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
					num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"]))));
					this.CurrentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				}
				else
				{
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"]))));
					num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"]))));
					this.CurrentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
				}
				decimal num5 = 0m;
				bool flag3 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
				if (flag3)
				{
					this.priceb4tax = num3;
					this.priceb4tax = this.priceb4tax;
					num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					decimal num6 = Math.Round(decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3)), 2, MidpointRounding.AwayFromZero);
					num6 = num6;
					this.priceb4taxWholesale = num4;
					this.priceb4taxWholesale = this.priceb4taxWholesale;
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num4));
					this.totpriceWholesale = Math.Round(this.totpriceWholesale, 2, MidpointRounding.AwayFromZero);
					bool flag4 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag4)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num6.ToString();
					}
				}
				else
				{
					this.priceb4tax = num3;
					this.priceb4tax = this.priceb4tax;
					num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					decimal num7 = Math.Round(num3, 2, MidpointRounding.AwayFromZero);
					num7 = num7;
					this.priceb4taxWholesale = num4;
					this.priceb4taxWholesale = this.priceb4taxWholesale;
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num4));
					this.totpriceWholesale = Math.Round(this.totpriceWholesale, 2, MidpointRounding.AwayFromZero);
					bool flag5 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag5)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num7.ToString();
					}
				}
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num5.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				bool flag6 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.CurrentExpires;
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

		// Token: 0x06003C68 RID: 15464 RVA: 0x0020FE94 File Offset: 0x0020E094
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
				this.txtDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = num2 == 0;
				decimal num3;
				decimal num4;
				if (flag2)
				{
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
					num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"]))));
					this.CurrentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				}
				else
				{
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"]))));
					num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"]))));
					this.CurrentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
				}
				decimal num5 = 0m;
				bool flag3 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
				if (flag3)
				{
					this.priceb4tax = num3;
					this.priceb4tax = this.priceb4tax;
					num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					decimal num6 = Math.Round(decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3)), 2, MidpointRounding.AwayFromZero);
					num6 = num6;
					this.priceb4taxWholesale = num4;
					this.priceb4taxWholesale = this.priceb4taxWholesale;
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num4));
					this.totpriceWholesale = Math.Round(this.totpriceWholesale, 2, MidpointRounding.AwayFromZero);
					bool flag4 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag4)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num6.ToString();
					}
				}
				else
				{
					this.priceb4tax = num3;
					this.priceb4tax = this.priceb4tax;
					num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					decimal num7 = Math.Round(num3, 2, MidpointRounding.AwayFromZero);
					num7 = num7;
					this.priceb4taxWholesale = num4;
					this.priceb4taxWholesale = this.priceb4taxWholesale;
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num4));
					this.totpriceWholesale = Math.Round(this.totpriceWholesale, 2, MidpointRounding.AwayFromZero);
					bool flag5 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag5)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num7.ToString();
					}
				}
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num5.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				bool flag6 = (MyProject.Forms.Form1.IsWarehouse == 1) & this.CurrentExpires;
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

		// Token: 0x06003C69 RID: 15465 RVA: 0x0021062C File Offset: 0x0020E82C
		private bool ProcessCoupon()
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
			bool flag = num > 0;
			bool flag4;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				int num2 = Conversions.ToInteger(dataRow["QtyRequired"]);
				int num3 = Conversions.ToInteger(dataRow["ProductID"]);
				bool flag2 = Conversions.ToBoolean(dataRow["Used"]);
				double num4 = Conversions.ToDouble(dataRow["DiscountPercentage"]);
				bool flag3 = flag2;
				if (flag3)
				{
					this.lblCouponInfo.Text = "Coupon has already been used.";
					flag4 = false;
				}
				else
				{
					bool flag5 = this.CurrentID != num3;
					if (flag5)
					{
						this.lblCouponInfo.Text = "Coupon is not valid for this product.";
						flag4 = false;
					}
					else
					{
						bool flag6 = (double)num2 != Conversion.Val(this.txtQty.Text);
						if (flag6)
						{
							this.lblCouponInfo.Text = "Coupon valid for " + num2.ToString() + " items";
							flag4 = false;
						}
						else
						{
							bool flag7 = this.notselected(checked((int)Math.Round(Conversion.Val(this.txtCoupons.Text))));
							if (flag7)
							{
								double num5 = Conversion.Val(this.txtPrice.Text);
								this.txtOLDprice.Text = num5.ToString();
								double num6 = Math.Round(num5 - num5 * (num4 / 100.0), 2, MidpointRounding.AwayFromZero);
								this.txtPrice.Text = num6.ToString();
								MessageBox.Show("Discount Success!.", "Discount");
								flag4 = true;
							}
							else
							{
								this.lblCouponInfo.Text = "Please use a different coupon number. The one entered has already been selected for this sale.";
								flag4 = false;
							}
						}
					}
				}
			}
			else
			{
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x00210854 File Offset: 0x0020EA54
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

		// Token: 0x06003C6B RID: 15467 RVA: 0x002108F8 File Offset: 0x0020EAF8
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

		// Token: 0x06003C6C RID: 15468 RVA: 0x00210988 File Offset: 0x0020EB88
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

		// Token: 0x06003C6D RID: 15469 RVA: 0x002109D8 File Offset: 0x0020EBD8
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

		// Token: 0x06003C6E RID: 15470 RVA: 0x00210AB4 File Offset: 0x0020ECB4
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

		// Token: 0x06003C6F RID: 15471 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x00210B8C File Offset: 0x0020ED8C
		private void dgvpay_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				double num = 0.0;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvpay.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["ActCol"].Value, "", false);
						if (flag)
						{
							object obj2 = char.IsDigit(Conversions.ToChar(dataGridViewRow.Cells["ActCol"].Value));
							DataGridViewCell dataGridViewCell;
							object[] array;
							bool[] array2;
							object obj3 = NewLateBinding.LateGet(null, typeof(Strings), "Asc", array = new object[] { (dataGridViewCell = dataGridViewRow.Cells["ActCol"]).Value }, null, null, array2 = new bool[] { true });
							if (array2[0])
							{
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
							}
							bool flag2 = Conversions.ToBoolean(Operators.NotObject(Operators.OrObject(obj2, Operators.CompareObjectEqual(obj3, 8, false))));
							if (flag2)
							{
								dataGridViewRow.Cells["ActCol"].Value = "0";
								return;
							}
							decimal num2 = 0m;
							decimal num3 = 0m;
							try
							{
								num3 = decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscountPerc"].Value)), 100m);
							}
							catch (Exception ex)
							{
								num3 = 0m;
							}
							bool flag3 = decimal.Compare(num3, 0m) > 0;
							if (flag3)
							{
								MessageBox.Show("Payment Method Discount Effected.");
							}
							num2 = Conversions.ToDecimal(Operators.MultiplyObject(dataGridViewRow.Cells["ActCol"].Value, dataGridViewRow.Cells["Rate"].Value));
							num2 = decimal.Subtract(num2, decimal.Multiply(num3, num2));
							dataGridViewRow.Cells["QTYCol"].Value = Math.Round(num2, 2, MidpointRounding.AwayFromZero);
							num = Conversions.ToDouble(Operators.AddObject(num, dataGridViewRow.Cells["ActCol"].Value));
						}
						else
						{
							bool flag4 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ActCol"].Value, "", false);
							if (flag4)
							{
								dataGridViewRow.Cells["QTYCol"].Value = "";
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
				this.txtAmtPaid.Text = num.ToString();
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error leaving payment grid. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00210EC4 File Offset: 0x0020F0C4
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag5;
			try
			{
				bool flag = msg.WParam.ToInt32() == 34;
				if (flag)
				{
					this.dgvpay.Focus();
					this.dgvpay.CurrentCell = this.dgvpay.Rows[0].Cells["ActCol"];
					this.dgvpay.BeginEdit(true);
					this.Button2.TabStop = true;
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
							this.txtBarCode.Focus();
							this.Button2.TabStop = false;
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

		// Token: 0x06003C72 RID: 15474 RVA: 0x00211000 File Offset: 0x0020F200
		private void dgvpay_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					try
					{
						bool flag2 = MyProject.Forms.Form1.AllowSalesonComputer == 1;
						if (flag2)
						{
							bool flag3 = MyProject.Forms.Form1.ConsultantSalesOnly == 1;
							if (flag3)
							{
								bool flag4 = this.sales_consultant == null;
								if (flag4)
								{
									MessageBox.Show("Only sales from consultants allowed. Go to quotations and select a ref to proceed.");
									return;
								}
							}
							Cursor.Current = Cursors.WaitCursor;
							this.invtotal = 0m;
							this.ConfirmSale();
							Cursor.Current = Cursors.Default;
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
					catch (Exception ex)
					{
						Cursor.Current = Cursors.Default;
						MessageBox.Show("Error performing sale. Detail: " + ex.Message);
					}
					e.Handled = true;
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Key down error. Ignore" + ex2.Message);
			}
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x00211178 File Offset: 0x0020F378
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

		// Token: 0x06003C74 RID: 15476 RVA: 0x00211200 File Offset: 0x0020F400
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

		// Token: 0x06003C75 RID: 15477 RVA: 0x00211278 File Offset: 0x0020F478
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txtQty.Focus();
				e.Handled = true;
			}
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x002112AC File Offset: 0x0020F4AC
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

		// Token: 0x06003C77 RID: 15479 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x00211400 File Offset: 0x0020F600
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void OpenCashDrawer()
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(1, AppDomain.CurrentDomain.BaseDirectory + "open.txt", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
			FileSystem.PrintLine(1, new object[] { "\u001bp\0\u0019" + Conversions.ToString(Strings.Chr(250)) });
			FileSystem.FileClose(new int[] { 1 });
			Interaction.Shell("print /d:com1 open.txt", AppWinStyle.Hide, false, -1);
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x0021147C File Offset: 0x0020F67C
		private void cboCustomers_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x002114B0 File Offset: 0x0020F6B0
		private DataTable searchDat(string stext)
		{
			DataTable dataTable = new DataTable();
			return this.datCustomers.Select("CustomerName LIKE '%" + stext + "%'").CopyToDataTable<DataRow>();
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x002114EC File Offset: 0x0020F6EC
		private void cboCustomers_Leave(object sender, EventArgs e)
		{
			this.AutoCompleteCombo_Leave(this.cboCustomers);
			DataRowView dataRowView = (DataRowView)this.cboCustomers.SelectedItem;
			bool flag = dataRowView == null;
			if (flag)
			{
			}
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x00211524 File Offset: 0x0020F724
		public void AutoCompleteCombo_Leave(ComboBox cbo)
		{
			int num = cbo.FindStringExact(cbo.Text);
			cbo.SelectedIndex = num;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x00211548 File Offset: 0x0020F748
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

		// Token: 0x06003C7E RID: 15486 RVA: 0x00211650 File Offset: 0x0020F850
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

		// Token: 0x06003C7F RID: 15487 RVA: 0x00211708 File Offset: 0x0020F908
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

		// Token: 0x06003C80 RID: 15488 RVA: 0x002117A8 File Offset: 0x0020F9A8
		private void chkAccount_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkAccount.Checked;
				if (@checked)
				{
					this.dgvpay.Visible = false;
					this.lblTerms.Visible = true;
					this.cboTerms.Visible = true;
					this.txtChange.Visible = false;
					this.lblchangedesc.Visible = false;
					this.cboChange.Visible = false;
				}
				else
				{
					this.dgvpay.Visible = true;
					this.lblTerms.Visible = false;
					this.cboTerms.Visible = false;
					this.txtChange.Visible = true;
					this.lblchangedesc.Visible = true;
					this.cboChange.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x0021188C File Offset: 0x0020FA8C
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

		// Token: 0x06003C82 RID: 15490 RVA: 0x00211918 File Offset: 0x0020FB18
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

		// Token: 0x06003C83 RID: 15491 RVA: 0x00211A0C File Offset: 0x0020FC0C
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

		// Token: 0x06003C84 RID: 15492 RVA: 0x00211B68 File Offset: 0x0020FD68
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

		// Token: 0x06003C85 RID: 15493 RVA: 0x00211BEC File Offset: 0x0020FDEC
		private void txtPriceChange_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00211C54 File Offset: 0x0020FE54
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtPrice.Text, "", false) != 0;
				if (flag)
				{
					SupervisorApproval supervisorApproval = new SupervisorApproval();
					supervisorApproval.ShowDialog();
					bool flag2 = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedPerc, 0m) != 0;
					if (flag2)
					{
						decimal num = new decimal(Convert.ToDouble(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m)) * Conversion.Val(this.txtPrice.Text) * -1.0);
						this.txtPriceChange.Text = num.ToString();
						ref string ptr = ref this.discDescription;
						this.discDescription = ptr + "Product Discount Approved by " + MyProject.Forms.Form1.Approvedby;
						MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
						bool flag3 = MyProject.Forms.Form1.DiscountEditingAllowed == 1;
						if (flag3)
						{
							this.txtPriceChange.ReadOnly = false;
						}
						else
						{
							this.txtPriceChange.ReadOnly = true;
						}
						this.Button1.Focus();
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

		// Token: 0x06003C87 RID: 15495 RVA: 0x00211DE0 File Offset: 0x0020FFE0
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

		// Token: 0x06003C88 RID: 15496 RVA: 0x00211F34 File Offset: 0x00210134
		private void Button7_Click(object sender, EventArgs e)
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
						sqlCommand.Parameters.AddWithValue("consultant", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("new_entryno", num2);
						num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
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
								sqlCommand.Parameters.AddWithValue("consultant", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("promstatus", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PromStatus"].Value));
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("ExpiryDate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
								sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscountAmt"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscountAmt"].Value))));
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
						this.Print_Quotation_Ref(num);
						MessageBox.Show("Quotation saved for invoicing. Ref number: " + num.ToString());
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

		// Token: 0x06003C89 RID: 15497 RVA: 0x002127B8 File Offset: 0x002109B8
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
			text3 = this.DTdate.Value.ToShortDateString();
			num = text3.Length;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine;
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

		// Token: 0x06003C8A RID: 15498 RVA: 0x00212928 File Offset: 0x00210B28
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

		// Token: 0x06003C8B RID: 15499 RVA: 0x00212CA0 File Offset: 0x00210EA0
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
			this.TextToPrint = ptr + "Payment Method: " + MyProject.Forms.Form1.basecurrency;
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

		// Token: 0x06003C8C RID: 15500 RVA: 0x002131FC File Offset: 0x002113FC
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

		// Token: 0x06003C8D RID: 15501 RVA: 0x002134DC File Offset: 0x002116DC
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				this.PrintHeaderQuotation();
				this.ItemsToBePrintedQuotation();
				this.PrintFooterQuotation();
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
				MessageBox.Show("Quotation print job sent to receipt printer.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00213594 File Offset: 0x00211794
		private void Button10_Click(object sender, EventArgs e)
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
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.custid, "Cash", false) == 0;
					if (!flag2)
					{
						this.FetchCustomer(MyProject.Forms.Form1.custid);
					}
					this.DataGridView1.Rows.Clear();
					DataRow dataRow = MyProject.Forms.Form1.PendingItemsDAT.Rows[0];
					this.sales_consultant = dataRow["consultant"].ToString();
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
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["promstatus"])), "", RuntimeHelpers.GetObjectValue(dataRow2["promstatus"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BatchNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow2["BatchNumber"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["ExpiryDate"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["ExpiryDate"]))),
								Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["DiscountAmt"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["DiscountAmt"])))
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
					MyProject.Forms.Form1.PendingItemsDAT.Clear();
					MessageBox.Show("Quotation Loaded.");
					this.dgvpay.Focus();
					this.dgvpay.CurrentCell = this.dgvpay.Rows[0].Cells["ActCol"];
					this.dgvpay.BeginEdit(true);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to show saved quotations. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x002139F4 File Offset: 0x00211BF4
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
						quotationnumber = num,
						branch = MyProject.Forms.Form1.branch,
						coid = MyProject.Forms.Form1.coid
					}.Show();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error generating quotation. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x00213E44 File Offset: 0x00212044
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				VerifyOpenImpReports verifyOpenImpReports = new VerifyOpenImpReports();
				verifyOpenImpReports.ShowDialog(this);
				verifyOpenImpReports.Dispose();
				bool flag = MyProject.Forms.Form1.OpenImpReports == 1;
				if (flag)
				{
					this.txtPrice.Text = Conversions.ToString(this.CurrentSpecialPrice);
					MessageBox.Show("Special price effected.");
				}
				else
				{
					MessageBox.Show("Incorrect special price password. ");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Special price error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00213EE8 File Offset: 0x002120E8
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

		// Token: 0x06003C92 RID: 15506 RVA: 0x00214078 File Offset: 0x00212278
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
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x00214208 File Offset: 0x00212408
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
					this.txtTel.Text = Conversions.ToString(dataRow["Tel"]);
					this.txtInvDetails1.Text = Conversions.ToString(dataRow["InvoiceDetails1"]);
					this.txtInvDetails2.Text = Conversions.ToString(dataRow["InvoiceDetails2"]);
					this.og_customername = this.txtcustomer.Text;
					this.og_address = this.txtAddress.Text;
					this.og_contactname = this.txtContactName.Text;
					this.og_mobile = this.txtMobile.Text;
					this.og_email = this.txtEmail.Text;
					this.og_tel = this.txtTel.Text;
					this.og_invdetail1 = this.txtInvDetails1.Text;
					this.og_invdetail2 = this.txtInvDetails2.Text;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00214468 File Offset: 0x00212668
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

		// Token: 0x06003C95 RID: 15509 RVA: 0x002145DC File Offset: 0x002127DC
		private void Button11_Click_1(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.SaveCustomerDetails();
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_contactname = this.txtContactName.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_tel = this.txtTel.Text;
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

		// Token: 0x06003C96 RID: 15510 RVA: 0x002146E0 File Offset: 0x002128E0
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

		// Token: 0x06003C97 RID: 15511 RVA: 0x0021473C File Offset: 0x0021293C
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

		// Token: 0x06003C98 RID: 15512 RVA: 0x00214768 File Offset: 0x00212968
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
															num++;
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
								bool flag6 = num == promDetails.Rows.Count;
								if (flag6)
								{
									this.DataGridView1.AllowUserToDeleteRows = false;
									DataTable promBenefits = this.getPromBenefits(Conversions.ToInteger(dataRow["PromotionNo"]));
									try
									{
										foreach (object obj5 in promBenefits.Rows)
										{
											DataRow dataRow3 = (DataRow)obj5;
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
													string[] array = new string[]
													{
														dataRow3["ProductID"].ToString(),
														dataRow4["ProductCode"].ToString(),
														dataRow4["ProductDesc"].ToString(),
														dataRow3["DiscountPrice"].ToString(),
														dataRow3["DiscountQty"].ToString(),
														"0",
														Convert.ToString(Operators.MultiplyObject(dataRow3["DiscountQty"], dataRow3["DiscountPrice"])),
														dataRow4["Cost"].ToString(),
														"0",
														"0",
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
													foreach (object obj6 in ((IEnumerable)this.DataGridView1.Rows))
													{
														DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj6;
														string value3 = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["PromStatus"].Value));
														bool flag7 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["ProdtID"].Value, dataRow3["ProductID"], false), Operators.CompareString(value3, "1", false) == 0));
														if (flag7)
														{
															dataGridViewRow3.Cells["UnitPrice"].Value = Operators.SubtractObject(dataGridViewRow3.Cells["UnitPrice"].Value, dataRow3["DiscountAmt"]);
															dataGridViewRow3.Cells["DiscountAmt"].Value = RuntimeHelpers.GetObjectValue(dataRow3["DiscountAmt"]);
															dataGridViewRow3.Cells["Total"].Value = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["UnitPrice"].Value)), new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Qty"].Value))));
															dataGridViewRow3.Cells["PromStatus"].Value = "3";
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
												this.datProm.Rows.Add(new object[] { Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["PromotionNo"])) });
												MessageBox.Show("PROMOTION EFFECTED. Discount added.", "PROMOTION", MessageBoxButtons.OK);
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
								else
								{
									bool flag8 = num > 0;
									if (flag8)
									{
										try
										{
											foreach (object obj7 in ((IEnumerable)this.DataGridView1.Rows))
											{
												DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj7;
												string value4 = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells["PromStatus"].Value));
												bool flag9 = (Operators.CompareString(value4, "2", false) == 0) | (Operators.CompareString(value4, "", false) == 0);
												if (flag9)
												{
													dataGridViewRow4.Cells["PromStatus"].Value = "2";
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
								foreach (object obj8 in ((IEnumerable)this.DataGridView1.Rows))
								{
									DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj8;
									string value5 = this.GetValue(RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells["PromStatus"].Value));
									bool flag10 = (Operators.CompareString(value5, "2", false) == 0) | (Operators.CompareString(value5, "", false) == 0);
									if (flag10)
									{
										dataGridViewRow5.Cells["PromStatus"].Value = "0";
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
				catch (Exception ex)
				{
					MessageBox.Show("Promotion calculation error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x002150F0 File Offset: 0x002132F0
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

		// Token: 0x06003C9A RID: 15514 RVA: 0x002151A0 File Offset: 0x002133A0
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

		// Token: 0x06003C9B RID: 15515 RVA: 0x00215250 File Offset: 0x00213450
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

		// Token: 0x06003C9C RID: 15516 RVA: 0x00215310 File Offset: 0x00213510
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

		// Token: 0x06003C9D RID: 15517 RVA: 0x00215424 File Offset: 0x00213624
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

		// Token: 0x06003C9E RID: 15518 RVA: 0x002154B4 File Offset: 0x002136B4
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
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_contactname = this.txtContactName.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_tel = this.txtTel.Text;
				this.og_invdetail1 = this.txtInvDetails1.Text;
				this.og_invdetail2 = this.txtInvDetails2.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error clearing customer details: " + ex.Message);
			}
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00215618 File Offset: 0x00213818
		private void Button13_Click(object sender, EventArgs e)
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

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00215714 File Offset: 0x00213914
		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotalSale();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x0021574C File Offset: 0x0021394C
		private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00215798 File Offset: 0x00213998
		private void Button14_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.DataGridView1.Rows.Count > 0) & !this.inv_discounted;
				if (flag)
				{
					SupervisorApproval supervisorApproval = new SupervisorApproval();
					supervisorApproval.ShowDialog();
					bool flag2 = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedPerc, 0m) != 0;
					if (flag2)
					{
						ref string ptr = ref this.discDescription;
						this.discDescription = ptr + "Invoice Discount Approved by " + MyProject.Forms.Form1.Approvedby;
						bool flag3 = MyProject.Forms.Form1.InvDiscountEditingAllowed == 1;
						if (flag3)
						{
							this.txtDiscount.ReadOnly = false;
						}
						else
						{
							this.txtDiscount.ReadOnly = true;
						}
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag4 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
								if (!flag4)
								{
									decimal num = Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value);
									decimal num2 = Conversions.ToDecimal(dataGridViewRow.Cells["UnitPrice"].Value);
									decimal num3 = Conversions.ToDecimal(dataGridViewRow.Cells["Tax"].Value);
									bool flag5 = decimal.Compare(num3, 0m) == 0;
									decimal num4;
									if (flag5)
									{
										num4 = 0m;
									}
									else
									{
										num4 = decimal.Divide(decimal.Divide(num3, num), num2);
									}
									dataGridViewRow.Cells["PriceChange"].Value = 1;
									dataGridViewRow.Cells["OldPrice"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value);
									dataGridViewRow.Cells["ApprovedBy"].Value = MyProject.Forms.Form1.Approvedby;
									num2 = Math.Round(decimal.Subtract(num2, decimal.Multiply(num2, decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m))), 2, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["UnitPrice"].Value = num2;
									dataGridViewRow.Cells["Tax"].Value = Math.Round(decimal.Multiply(decimal.Multiply(num2, num4), num), 2, MidpointRounding.AwayFromZero);
									dataGridViewRow.Cells["Total"].Value = Operators.AddObject(Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, num), dataGridViewRow.Cells["Tax"].Value);
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
						this.inv_discounted = true;
					}
				}
				else
				{
					MessageBox.Show("There are no products selected for discount OR discount already applied.");
				}
				bool flag6 = MyProject.Forms.Form1.DiscountLimitPayMethods == 1;
				if (flag6)
				{
					try
					{
						foreach (object obj2 in ((IEnumerable)this.dgvpay.Rows))
						{
							DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
							bool flag7 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow2.Cells["PaymentMethodID"].Value, MyProject.Forms.Form1.DiscountPayMethod, false);
							if (flag7)
							{
								dataGridViewRow2.ReadOnly = true;
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
				this.CalcTotalSale();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error authorising discount. Detail: " + ex.Message);
			}
		}

		// Token: 0x040019B4 RID: 6580
		private string _cnn;

		// Token: 0x040019B5 RID: 6581
		private PublicFunctions pf;

		// Token: 0x040019B6 RID: 6582
		private int CurrentID;

		// Token: 0x040019B7 RID: 6583
		private string CurrentCode;

		// Token: 0x040019B8 RID: 6584
		private decimal CurrentSpecialPrice;

		// Token: 0x040019B9 RID: 6585
		private bool CurrentExpires;

		// Token: 0x040019BA RID: 6586
		private string TextToPrint;

		// Token: 0x040019BB RID: 6587
		private string coname;

		// Token: 0x040019BC RID: 6588
		private string coadd;

		// Token: 0x040019BD RID: 6589
		private string cotel;

		// Token: 0x040019BE RID: 6590
		private string coemail;

		// Token: 0x040019BF RID: 6591
		private string cobpnum;

		// Token: 0x040019C0 RID: 6592
		private string cotel2;

		// Token: 0x040019C1 RID: 6593
		private string cotel3;

		// Token: 0x040019C2 RID: 6594
		private string footnote;

		// Token: 0x040019C3 RID: 6595
		private string coVATNum;

		// Token: 0x040019C4 RID: 6596
		private int invnum;

		// Token: 0x040019C5 RID: 6597
		private double currprice;

		// Token: 0x040019C6 RID: 6598
		private bool Match;

		// Token: 0x040019C7 RID: 6599
		private DataTable datCustomers;

		// Token: 0x040019C8 RID: 6600
		private int m_currentPageIndex;

		// Token: 0x040019C9 RID: 6601
		private IList<Stream> m_streams;

		// Token: 0x040019CA RID: 6602
		private decimal priceb4tax;

		// Token: 0x040019CB RID: 6603
		private decimal priceb4taxWholesale;

		// Token: 0x040019CC RID: 6604
		private decimal currentWholesaleQty;

		// Token: 0x040019CD RID: 6605
		private decimal taxdueWholesale;

		// Token: 0x040019CE RID: 6606
		private decimal totpriceWholesale;

		// Token: 0x040019CF RID: 6607
		private int WholesalePriceByQty;

		// Token: 0x040019D0 RID: 6608
		private DataTable datProm;

		// Token: 0x040019D1 RID: 6609
		private decimal invtotal;

		// Token: 0x040019D2 RID: 6610
		private string og_customername;

		// Token: 0x040019D3 RID: 6611
		private string og_address;

		// Token: 0x040019D4 RID: 6612
		private string og_contactname;

		// Token: 0x040019D5 RID: 6613
		private string og_mobile;

		// Token: 0x040019D6 RID: 6614
		private string og_email;

		// Token: 0x040019D7 RID: 6615
		private string og_tel;

		// Token: 0x040019D8 RID: 6616
		private string og_invdetail1;

		// Token: 0x040019D9 RID: 6617
		private string og_invdetail2;

		// Token: 0x040019DA RID: 6618
		private string sales_consultant;

		// Token: 0x040019DB RID: 6619
		private string currentUOM;

		// Token: 0x040019DC RID: 6620
		private StringReader stringToRead;

		// Token: 0x040019DD RID: 6621
		private decimal invrate;

		// Token: 0x040019DE RID: 6622
		private decimal invdisc;

		// Token: 0x040019DF RID: 6623
		private bool inv_discounted;

		// Token: 0x040019E0 RID: 6624
		private string discDescription;
	}
}
