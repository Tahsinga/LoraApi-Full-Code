using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000189 RID: 393
	[DesignerGenerated]
	public partial class Sales : UserControl
	{
		// Token: 0x06003AA2 RID: 15010 RVA: 0x001FCB28 File Offset: 0x001FAD28
		public Sales()
		{
			base.Load += this.Sales_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.TextToPrint = "";
			this.InitializeComponent();
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x001FE761 File Offset: 0x001FC961
		// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x001FE76B File Offset: 0x001FC96B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x001FE774 File Offset: 0x001FC974
		// (set) Token: 0x06003AA8 RID: 15016 RVA: 0x001FE77E File Offset: 0x001FC97E
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x001FE787 File Offset: 0x001FC987
		// (set) Token: 0x06003AAA RID: 15018 RVA: 0x001FE791 File Offset: 0x001FC991
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06003AAB RID: 15019 RVA: 0x001FE79A File Offset: 0x001FC99A
		// (set) Token: 0x06003AAC RID: 15020 RVA: 0x001FE7A4 File Offset: 0x001FC9A4
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x001FE7AD File Offset: 0x001FC9AD
		// (set) Token: 0x06003AAE RID: 15022 RVA: 0x001FE7B7 File Offset: 0x001FC9B7
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x001FE7C0 File Offset: 0x001FC9C0
		// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x001FE7CA File Offset: 0x001FC9CA
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x001FE7D3 File Offset: 0x001FC9D3
		// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x001FE7DD File Offset: 0x001FC9DD
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x001FE7E6 File Offset: 0x001FC9E6
		// (set) Token: 0x06003AB4 RID: 15028 RVA: 0x001FE7F0 File Offset: 0x001FC9F0
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

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x001FE84E File Offset: 0x001FCA4E
		// (set) Token: 0x06003AB6 RID: 15030 RVA: 0x001FE858 File Offset: 0x001FCA58
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x001FE861 File Offset: 0x001FCA61
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x001FE86B File Offset: 0x001FCA6B
		internal virtual TextBox txtQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x001FE874 File Offset: 0x001FCA74
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x001FE87E File Offset: 0x001FCA7E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x001FE887 File Offset: 0x001FCA87
		// (set) Token: 0x06003ABC RID: 15036 RVA: 0x001FE891 File Offset: 0x001FCA91
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x001FE89A File Offset: 0x001FCA9A
		// (set) Token: 0x06003ABE RID: 15038 RVA: 0x001FE8A4 File Offset: 0x001FCAA4
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x001FE8AD File Offset: 0x001FCAAD
		// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x001FE8B8 File Offset: 0x001FCAB8
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
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPrice_KeyPress);
				TextBox textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPrice = value;
				textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x001FE8FB File Offset: 0x001FCAFB
		// (set) Token: 0x06003AC2 RID: 15042 RVA: 0x001FE908 File Offset: 0x001FCB08
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

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x001FE94B File Offset: 0x001FCB4B
		// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x001FE958 File Offset: 0x001FCB58
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

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x001FE99B File Offset: 0x001FCB9B
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x001FE9A5 File Offset: 0x001FCBA5
		internal virtual ComboBox cboPaymentMethods
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x001FE9AE File Offset: 0x001FCBAE
		// (set) Token: 0x06003AC8 RID: 15048 RVA: 0x001FE9B8 File Offset: 0x001FCBB8
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x001FE9C1 File Offset: 0x001FCBC1
		// (set) Token: 0x06003ACA RID: 15050 RVA: 0x001FE9CB File Offset: 0x001FCBCB
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x001FE9D4 File Offset: 0x001FCBD4
		// (set) Token: 0x06003ACC RID: 15052 RVA: 0x001FE9DE File Offset: 0x001FCBDE
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x001FE9E7 File Offset: 0x001FCBE7
		// (set) Token: 0x06003ACE RID: 15054 RVA: 0x001FE9F1 File Offset: 0x001FCBF1
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x001FE9FA File Offset: 0x001FCBFA
		// (set) Token: 0x06003AD0 RID: 15056 RVA: 0x001FEA04 File Offset: 0x001FCC04
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x001FEA0D File Offset: 0x001FCC0D
		// (set) Token: 0x06003AD2 RID: 15058 RVA: 0x001FEA18 File Offset: 0x001FCC18
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
				EventHandler eventHandler = new EventHandler(this.Label9_Click);
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

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x001FEA5B File Offset: 0x001FCC5B
		// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x001FEA65 File Offset: 0x001FCC65
		internal virtual TextBox txtChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x001FEA6E File Offset: 0x001FCC6E
		// (set) Token: 0x06003AD6 RID: 15062 RVA: 0x001FEA78 File Offset: 0x001FCC78
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x001FEA81 File Offset: 0x001FCC81
		// (set) Token: 0x06003AD8 RID: 15064 RVA: 0x001FEA8C File Offset: 0x001FCC8C
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
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
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

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x001FEAEA File Offset: 0x001FCCEA
		// (set) Token: 0x06003ADA RID: 15066 RVA: 0x001FEAF4 File Offset: 0x001FCCF4
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x001FEAFD File Offset: 0x001FCCFD
		// (set) Token: 0x06003ADC RID: 15068 RVA: 0x001FEB08 File Offset: 0x001FCD08
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

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x001FEB4B File Offset: 0x001FCD4B
		// (set) Token: 0x06003ADE RID: 15070 RVA: 0x001FEB58 File Offset: 0x001FCD58
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

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x001FEB9B File Offset: 0x001FCD9B
		// (set) Token: 0x06003AE0 RID: 15072 RVA: 0x001FEBA5 File Offset: 0x001FCDA5
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x001FEBAE File Offset: 0x001FCDAE
		// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x001FEBB8 File Offset: 0x001FCDB8
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x001FEBC1 File Offset: 0x001FCDC1
		// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x001FEBCB File Offset: 0x001FCDCB
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x001FEBD4 File Offset: 0x001FCDD4
		// (set) Token: 0x06003AE6 RID: 15078 RVA: 0x001FEBDE File Offset: 0x001FCDDE
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x001FEBE7 File Offset: 0x001FCDE7
		// (set) Token: 0x06003AE8 RID: 15080 RVA: 0x001FEBF1 File Offset: 0x001FCDF1
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x001FEBFA File Offset: 0x001FCDFA
		// (set) Token: 0x06003AEA RID: 15082 RVA: 0x001FEC04 File Offset: 0x001FCE04
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x001FEC0D File Offset: 0x001FCE0D
		// (set) Token: 0x06003AEC RID: 15084 RVA: 0x001FEC17 File Offset: 0x001FCE17
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x001FEC20 File Offset: 0x001FCE20
		// (set) Token: 0x06003AEE RID: 15086 RVA: 0x001FEC2C File Offset: 0x001FCE2C
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DGVSearch_CellContentClick);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler2;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler2;
				}
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x001FECA5 File Offset: 0x001FCEA5
		// (set) Token: 0x06003AF0 RID: 15088 RVA: 0x001FECAF File Offset: 0x001FCEAF
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06003AF1 RID: 15089 RVA: 0x001FECB8 File Offset: 0x001FCEB8
		// (set) Token: 0x06003AF2 RID: 15090 RVA: 0x001FECC4 File Offset: 0x001FCEC4
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

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x001FED07 File Offset: 0x001FCF07
		// (set) Token: 0x06003AF4 RID: 15092 RVA: 0x001FED11 File Offset: 0x001FCF11
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x001FED1A File Offset: 0x001FCF1A
		// (set) Token: 0x06003AF6 RID: 15094 RVA: 0x001FED24 File Offset: 0x001FCF24
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

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06003AF7 RID: 15095 RVA: 0x001FED67 File Offset: 0x001FCF67
		// (set) Token: 0x06003AF8 RID: 15096 RVA: 0x001FED71 File Offset: 0x001FCF71
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x001FED7C File Offset: 0x001FCF7C
		private void Sales_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.PrintReceipt == 1;
				if (flag)
				{
					this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.PrinterName;
					this.GetCompanyDetails();
				}
				this.LoadPaymentMethods();
				this.txtsearch.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x001FEE18 File Offset: 0x001FD018
		private void LoadPaymentMethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPaymentMethods.DataSource = dataTable;
			this.cboPaymentMethods.ValueMember = "PaymentMethodID";
			this.cboPaymentMethods.DisplayMember = "PaymentMethodDesc";
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x001FEEB8 File Offset: 0x001FD0B8
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

		// Token: 0x06003AFC RID: 15100 RVA: 0x001FF124 File Offset: 0x001FD324
		private void txtSearchProdtID_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x001FF170 File Offset: 0x001FD370
		private void txtSearchProdtID_TextChanged(object sender, EventArgs e)
		{
			this.txtStockAvail.Text = Conversions.ToString(0);
			this.txtPrice.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(0);
			this.FetchProdtDetails(checked((int)Math.Round(Conversion.Val(this.txtSearchProdtID.Text))));
			bool flag = Operators.CompareString(this.txtSearchProdtID.Text, "", false) != 0;
			if (flag)
			{
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(Conversions.ToInteger(this.txtSearchProdtID.Text)));
			}
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x001FF218 File Offset: 0x001FD418
		private void CalcTotalSale()
		{
			double num = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
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
			this.txtTotal.Text = num.ToString("#,0.00");
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x001FF2BC File Offset: 0x001FD4BC
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
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				double num2 = Conversions.ToDouble(dataRow["SellingPrice"]);
				this.txtPrice.Text = num2.ToString("#,0.00");
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
			}
			else
			{
				this.txtDesc.Text = "Nothing matching product ID";
			}
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x001FF3D8 File Offset: 0x001FD5D8
		private void AppendGrid()
		{
			double num = Conversion.Val(this.txtQty.Text) * Conversion.Val(this.txtPrice.Text);
			double num2 = Conversion.Val(this.txtPrice.Text);
			string[] array = new string[]
			{
				this.txtSearchProdtID.Text,
				this.txtDesc.Text,
				num2.ToString("#,0.00"),
				this.txtQty.Text,
				num.ToString("#,0.00"),
				this.lblcost.Text
			};
			this.DataGridView1.Rows.Add(array);
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x001FF488 File Offset: 0x001FD688
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Verify();
				if (flag)
				{
					bool flag2 = Conversion.Val(this.txtQty.Text) > 0.0;
					if (flag2)
					{
						this.AppendGrid();
						this.CalcTotalSale();
						this.txtSearchProdtID.Text = "";
						this.txtsearch.Text = "";
						this.txtsearch.Focus();
						this.txtQty.Text = Conversions.ToString(0);
					}
					else
					{
						MessageBox.Show("Please enter the quantity bought.");
					}
				}
				else
				{
					MessageBox.Show("Please make sure that sales and quanity details are entered.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending data. Details: " + ex.Message);
			}
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x001FF56C File Offset: 0x001FD76C
		public bool Verify()
		{
			bool flag = (Conversion.Val(this.txtQty.Text) <= 0.0) | (Conversion.Val(this.txtPrice.Text) <= 0.0);
			bool flag3;
			if (flag)
			{
				bool flag2 = false;
				flag3 = flag2;
			}
			else
			{
				bool flag2 = true;
				flag3 = flag2;
			}
			return flag3;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x001FF5CC File Offset: 0x001FD7CC
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

		// Token: 0x06003B04 RID: 15108 RVA: 0x001FF6A4 File Offset: 0x001FD8A4
		private void InsertSale(int prodtid, decimal saleqty, double unitcost, double salesprice, int paymentmethod, int invnum, int thetime)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewSale";
			sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			sqlCommand.Parameters.AddWithValue("productid", prodtid);
			sqlCommand.Parameters.AddWithValue("isstockin", 0);
			sqlCommand.Parameters.AddWithValue("ref", "");
			sqlCommand.Parameters.AddWithValue("quantity", saleqty);
			sqlCommand.Parameters.AddWithValue("unitcost", unitcost);
			sqlCommand.Parameters.AddWithValue("salesprice", salesprice);
			sqlCommand.Parameters.AddWithValue("paymentmethod", paymentmethod);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("trancode", 3);
			sqlCommand.Parameters.AddWithValue("TranTime", thetime);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x001FF8AC File Offset: 0x001FDAAC
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.invnum = this.GetInvoiceNumSales();
					int num = (int)Math.Round(Conversion.Val(DateTime.Today.ToString("HHmm")));
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							this.InsertSale((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value))), new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value))), Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)), Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), Conversions.ToInteger(this.cboPaymentMethods.SelectedValue), this.invnum, num);
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
					bool flag = MyProject.Forms.Form1.PrintReceipt == 1;
					if (flag)
					{
						this.PrintReceipt();
					}
					MessageBox.Show("Sale Successfull.", "Sale Complete", MessageBoxButtons.OK);
					this.ClearForm();
					this.txtsearch.Focus();
				}
				catch (Exception ex)
				{
					MessageBox.Show("ERROR confirming sale. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x001FFA78 File Offset: 0x001FDC78
		private void ClearForm()
		{
			this.DataGridView1.Rows.Clear();
			this.txtStockAvail.Text = Conversions.ToString(0);
			this.txtPrice.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(0);
			this.txtSearchProdtID.Text = Conversions.ToString(0);
			this.txtTotal.Text = Conversions.ToString(0);
			this.txtChange.Text = Conversions.ToString(0);
			this.txtAmtPaid.Text = Conversions.ToString(0);
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x001FFB18 File Offset: 0x001FDD18
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x001FFB64 File Offset: 0x001FDD64
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			double num = Conversion.Val(this.txtAmtPaid.Text) - Conversion.Val(this.txtTotal.Text);
			this.txtChange.Text = num.ToString("#,0.00");
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x001FFBAC File Offset: 0x001FDDAC
		private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x001FFBF8 File Offset: 0x001FDDF8
		private void GetCompanyDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetCompanyDetails";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.coname = Conversions.ToString(dataRow["Company"]);
				this.coadd = Conversions.ToString(dataRow["Address"]);
				this.cotel = Conversions.ToString(dataRow["Tel"]);
			}
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x001FFCA4 File Offset: 0x001FDEA4
		public void PrintHeader()
		{
			this.TextToPrint = "";
			string text = this.coname;
			int num = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(33 - num) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				text = this.coadd;
				num = text.Length;
				string text3 = new string(' ', (int)Math.Round(Math.Round((double)(33 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				text = this.cotel;
				num = text.Length;
				string text4 = new string(' ', (int)Math.Round(Math.Round((double)(33 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + text + Environment.NewLine;
			}
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x001FFD9C File Offset: 0x001FDF9C
		public void ItemsToBePrinted()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description" + Environment.NewLine;
			string text = "";
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
			bool flag = num > 0;
			checked
			{
				if (flag)
				{
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							string text2 = Conversions.ToString(dataRow["Description"]);
							int num2 = Conversions.ToInteger(dataRow["Quantity"]);
							double num3 = Conversions.ToDouble(dataRow["Unit_Selling_Price"]);
							double num4 = Conversions.ToDouble(dataRow["Sub_Total"]);
							int num5 = (int)Math.Round(Conversion.Val(text2.Length));
							bool flag2 = num5 > 20;
							if (flag2)
							{
								text2 = text2.Substring(0, 20);
							}
							else
							{
								int num6 = num5;
								for (int i = 20 - num6; i != 0; i--)
								{
									text2 += " ";
								}
							}
							int num7 = (int)Math.Round(Conversion.Val(num2.ToString().Length));
							bool flag3 = num7 == 1;
							if (flag3)
							{
								text = num2.ToString() + " ";
							}
							else
							{
								bool flag4 = num7 == 2;
								if (flag4)
								{
									text = num2.ToString();
								}
							}
							int num8 = (int)Math.Round(Conversion.Val(num3.ToString().Length));
							bool flag5 = num8 == 5;
							if (!flag5)
							{
								bool flag6 = num8 == 4;
								if (flag6)
								{
								}
							}
							string text3 = string.Concat(new string[]
							{
								text2,
								" ",
								text,
								" @ ",
								Strings.FormatCurrency(num3, 2, TriState.True, TriState.True, TriState.True)
							});
							string text4 = Conversions.ToString(text3.Length);
							string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(40.0 - Conversions.ToDouble(text4)))));
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

		// Token: 0x06003B0E RID: 15118 RVA: 0x002000D4 File Offset: 0x001FE2D4
		private void PrintFooter()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine + Environment.NewLine;
			string text = "Sub Total   " + Strings.FormatCurrency(this.txtTotal.Text, -1, TriState.True, TriState.True, TriState.True);
			string text2 = Conversions.ToString(text.Length);
			int length = text.Length;
			checked
			{
				string text3 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					Environment.NewLine,
					text3,
					text,
					Environment.NewLine
				});
				text = "Cash        " + Strings.FormatCurrency(this.txtAmtPaid.Text, -1, TriState.True, TriState.True, TriState.True);
				text2 = Conversions.ToString(length);
				string text4 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag = Operators.CompareString(text, "Cash        $0.00", false) != 0;
				if (flag)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text4 + text + Environment.NewLine;
				}
				text = "Change      " + Strings.FormatCurrency(this.txtChange.Text, -1, TriState.True, TriState.True, TriState.True);
				text2 = Conversions.ToString(length);
				string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					Environment.NewLine,
					text5,
					text,
					Environment.NewLine
				});
			}
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x00200284 File Offset: 0x001FE484
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

		// Token: 0x06003B10 RID: 15120 RVA: 0x00200458 File Offset: 0x001FE658
		private void PrintReceipt()
		{
			this.PrintHeader();
			this.ItemsToBePrinted();
			this.PrintFooter();
			StandardPrintController standardPrintController = new StandardPrintController();
			this.PrintDocument1.PrintController = standardPrintController;
			this.PrintDocument1.Print();
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x0020049C File Offset: 0x001FE69C
		private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				this.CalcTotalSale();
				this.txtSearchProdtID.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deletting row. Restart SALE.");
			}
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x002004EC File Offset: 0x001FE6EC
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

		// Token: 0x06003B13 RID: 15123 RVA: 0x00200558 File Offset: 0x001FE758
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

		// Token: 0x06003B14 RID: 15124 RVA: 0x00200634 File Offset: 0x001FE834
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

		// Token: 0x06003B15 RID: 15125 RVA: 0x00200780 File Offset: 0x001FE980
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

		// Token: 0x06003B16 RID: 15126 RVA: 0x002007E0 File Offset: 0x001FE9E0
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

		// Token: 0x06003B17 RID: 15127 RVA: 0x002008A4 File Offset: 0x001FEAA4
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

		// Token: 0x06003B18 RID: 15128 RVA: 0x00002A30 File Offset: 0x00000C30
		private void DGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04001928 RID: 6440
		private string _cnn;

		// Token: 0x04001929 RID: 6441
		private string TextToPrint;

		// Token: 0x0400192A RID: 6442
		private string coname;

		// Token: 0x0400192B RID: 6443
		private string coadd;

		// Token: 0x0400192C RID: 6444
		private string cotel;

		// Token: 0x0400192D RID: 6445
		private int invnum;
	}
}
