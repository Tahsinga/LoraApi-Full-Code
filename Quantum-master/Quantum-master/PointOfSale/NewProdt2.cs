using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200007B RID: 123
	[DesignerGenerated]
	public partial class NewProdt2 : Form
	{
		// Token: 0x06001A60 RID: 6752 RVA: 0x000F138C File Offset: 0x000EF58C
		public NewProdt2()
		{
			base.Load += this.NewProdt_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.IsProductCodeGenerated = false;
			this.not_for_purchase = false;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x000F4296 File Offset: 0x000F2496
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x000F42A0 File Offset: 0x000F24A0
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x000F42A9 File Offset: 0x000F24A9
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x000F42B4 File Offset: 0x000F24B4
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

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x000F42F7 File Offset: 0x000F24F7
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x000F4301 File Offset: 0x000F2501
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000F430A File Offset: 0x000F250A
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x000F4314 File Offset: 0x000F2514
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x000F431D File Offset: 0x000F251D
		// (set) Token: 0x06001A6C RID: 6764 RVA: 0x000F4328 File Offset: 0x000F2528
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

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x000F436B File Offset: 0x000F256B
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x000F4375 File Offset: 0x000F2575
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x000F437E File Offset: 0x000F257E
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x000F4388 File Offset: 0x000F2588
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

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x000F43CB File Offset: 0x000F25CB
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x000F43D8 File Offset: 0x000F25D8
		internal virtual TextBox txtProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtProductCode_Leave);
				TextBox textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.Leave -= eventHandler;
				}
				this._txtProductCode = value;
				textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.Leave += eventHandler;
				}
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x000F441B File Offset: 0x000F261B
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x000F4425 File Offset: 0x000F2625
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x000F442E File Offset: 0x000F262E
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x000F4438 File Offset: 0x000F2638
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x000F4441 File Offset: 0x000F2641
		// (set) Token: 0x06001A78 RID: 6776 RVA: 0x000F444B File Offset: 0x000F264B
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x000F4454 File Offset: 0x000F2654
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x000F4460 File Offset: 0x000F2660
		internal virtual TextBox txtTaxRate
		{
			[CompilerGenerated]
			get
			{
				return this._txtTaxRate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtTaxRate_KeyPress);
				TextBox textBox = this._txtTaxRate;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtTaxRate = value;
				textBox = this._txtTaxRate;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000F44A3 File Offset: 0x000F26A3
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x000F44AD File Offset: 0x000F26AD
		internal virtual CheckBox ChkImported
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x000F44B6 File Offset: 0x000F26B6
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x000F44C0 File Offset: 0x000F26C0
		internal virtual ComboBox cboUOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x000F44C9 File Offset: 0x000F26C9
		// (set) Token: 0x06001A80 RID: 6784 RVA: 0x000F44D3 File Offset: 0x000F26D3
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x000F44DC File Offset: 0x000F26DC
		// (set) Token: 0x06001A82 RID: 6786 RVA: 0x000F44E6 File Offset: 0x000F26E6
		internal virtual TextBox txtbinlocation
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x000F44EF File Offset: 0x000F26EF
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x000F44F9 File Offset: 0x000F26F9
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x000F4502 File Offset: 0x000F2702
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x000F450C File Offset: 0x000F270C
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x000F4515 File Offset: 0x000F2715
		// (set) Token: 0x06001A88 RID: 6792 RVA: 0x000F451F File Offset: 0x000F271F
		internal virtual TextBox txtDesc2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x000F4528 File Offset: 0x000F2728
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x000F4534 File Offset: 0x000F2734
		internal virtual TextBox WholesaleQTY
		{
			[CompilerGenerated]
			get
			{
				return this._WholesaleQTY;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.WholesaleQTY_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.WholesaleQTY_KeyPress);
				TextBox textBox = this._WholesaleQTY;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._WholesaleQTY = value;
				textBox = this._WholesaleQTY;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x000F4592 File Offset: 0x000F2792
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x000F459C File Offset: 0x000F279C
		internal virtual Label Label12
		{
			[CompilerGenerated]
			get
			{
				return this._Label12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label12_Click);
				Label label = this._Label12;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label12 = value;
				label = this._Label12;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x000F45DF File Offset: 0x000F27DF
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x000F45EC File Offset: 0x000F27EC
		internal virtual CheckBox chkProductExpires
		{
			[CompilerGenerated]
			get
			{
				return this._chkProductExpires;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkProductExpires_CheckedChanged);
				CheckBox checkBox = this._chkProductExpires;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkProductExpires = value;
				checkBox = this._chkProductExpires;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000F462F File Offset: 0x000F282F
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x000F463C File Offset: 0x000F283C
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x000F467F File Offset: 0x000F287F
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x000F4689 File Offset: 0x000F2889
		internal virtual CheckBox chkDifferent
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x000F4692 File Offset: 0x000F2892
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x000F469C File Offset: 0x000F289C
		internal virtual CheckBox chkIsUnlimitedStockItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x000F46A5 File Offset: 0x000F28A5
		// (set) Token: 0x06001A96 RID: 6806 RVA: 0x000F46AF File Offset: 0x000F28AF
		internal virtual CheckBox chkIngridient
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x000F46B8 File Offset: 0x000F28B8
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x000F46C4 File Offset: 0x000F28C4
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x000F4707 File Offset: 0x000F2907
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x000F4714 File Offset: 0x000F2914
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

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x000F4757 File Offset: 0x000F2957
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x000F4761 File Offset: 0x000F2961
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000F476A File Offset: 0x000F296A
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x000F4774 File Offset: 0x000F2974
		internal virtual ComboBox cboSupplier
		{
			[CompilerGenerated]
			get
			{
				return this._cboSupplier;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboSupplier_KeyUp);
				EventHandler eventHandler = new EventHandler(this.cboSupplier_Leave);
				ComboBox comboBox = this._cboSupplier;
				if (comboBox != null)
				{
					comboBox.KeyUp -= keyEventHandler;
					comboBox.Leave -= eventHandler;
				}
				this._cboSupplier = value;
				comboBox = this._cboSupplier;
				if (comboBox != null)
				{
					comboBox.KeyUp += keyEventHandler;
					comboBox.Leave += eventHandler;
				}
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x000F47D2 File Offset: 0x000F29D2
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x000F47DC File Offset: 0x000F29DC
		internal virtual CheckBox chkIsCalcLxW
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x000F47E5 File Offset: 0x000F29E5
		// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x000F47EF File Offset: 0x000F29EF
		internal virtual CheckBox chkIsBooking
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x000F47F8 File Offset: 0x000F29F8
		// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x000F4804 File Offset: 0x000F2A04
		internal virtual ListBox ListBox1
		{
			[CompilerGenerated]
			get
			{
				return this._ListBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListBox1_SelectedIndexChanged);
				ListBox listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= eventHandler;
				}
				this._ListBox1 = value;
				listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x000F4847 File Offset: 0x000F2A47
		// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x000F4854 File Offset: 0x000F2A54
		internal virtual ComboBox cboProducts
		{
			[CompilerGenerated]
			get
			{
				return this._cboProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboProducts_TextChanged);
				ComboBox comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.TextChanged -= eventHandler;
				}
				this._cboProducts = value;
				comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x000F4897 File Offset: 0x000F2A97
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x000F48A1 File Offset: 0x000F2AA1
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x000F48AA File Offset: 0x000F2AAA
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x000F48B4 File Offset: 0x000F2AB4
		internal virtual TextBox txtCaseQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x000F48BD File Offset: 0x000F2ABD
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x000F48C8 File Offset: 0x000F2AC8
		internal virtual CheckBox chkIsCase
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsCase;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsCase_CheckedChanged);
				CheckBox checkBox = this._chkIsCase;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsCase = value;
				checkBox = this._chkIsCase;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x000F490B File Offset: 0x000F2B0B
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x000F4915 File Offset: 0x000F2B15
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x000F491E File Offset: 0x000F2B1E
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x000F4928 File Offset: 0x000F2B28
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x000F4931 File Offset: 0x000F2B31
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x000F493B File Offset: 0x000F2B3B
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x000F4944 File Offset: 0x000F2B44
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x000F494E File Offset: 0x000F2B4E
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x000F4957 File Offset: 0x000F2B57
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x000F4964 File Offset: 0x000F2B64
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
				TextBox textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtSellingPrice = value;
				textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x000F49A7 File Offset: 0x000F2BA7
		// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x000F49B1 File Offset: 0x000F2BB1
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x000F49BA File Offset: 0x000F2BBA
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x000F49C4 File Offset: 0x000F2BC4
		internal virtual TextBox txtCost
		{
			[CompilerGenerated]
			get
			{
				return this._txtCost;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCost_KeyPress);
				TextBox textBox = this._txtCost;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCost = value;
				textBox = this._txtCost;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x000F4A07 File Offset: 0x000F2C07
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x000F4A14 File Offset: 0x000F2C14
		internal virtual CheckBox chkIsBoth
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsBoth;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsBoth_CheckedChanged);
				CheckBox checkBox = this._chkIsBoth;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsBoth = value;
				checkBox = this._chkIsBoth;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x000F4A57 File Offset: 0x000F2C57
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x000F4A61 File Offset: 0x000F2C61
		internal virtual CheckBox chkPriceVariable
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x000F4A6A File Offset: 0x000F2C6A
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x000F4A74 File Offset: 0x000F2C74
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x000F4A7D File Offset: 0x000F2C7D
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x000F4A87 File Offset: 0x000F2C87
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000F4A90 File Offset: 0x000F2C90
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x000F4A9A File Offset: 0x000F2C9A
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x000F4AA3 File Offset: 0x000F2CA3
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x000F4AAD File Offset: 0x000F2CAD
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000F4AB6 File Offset: 0x000F2CB6
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x000F4AC0 File Offset: 0x000F2CC0
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000F4AC9 File Offset: 0x000F2CC9
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x000F4AD4 File Offset: 0x000F2CD4
		internal virtual TextBox txtQtyPurchased
		{
			[CompilerGenerated]
			get
			{
				return this._txtQtyPurchased;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox2_KeyPress);
				TextBox textBox = this._txtQtyPurchased;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQtyPurchased = value;
				textBox = this._txtQtyPurchased;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x000F4B17 File Offset: 0x000F2D17
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x000F4B21 File Offset: 0x000F2D21
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x000F4B2A File Offset: 0x000F2D2A
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x000F4B34 File Offset: 0x000F2D34
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x000F4B3D File Offset: 0x000F2D3D
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x000F4B47 File Offset: 0x000F2D47
		internal virtual TextBox txtProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x000F4B50 File Offset: 0x000F2D50
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x000F4B5C File Offset: 0x000F2D5C
		internal virtual CheckBox chkIsTaxExempt
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsTaxExempt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsTaxExempt_CheckedChanged);
				CheckBox checkBox = this._chkIsTaxExempt;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsTaxExempt = value;
				checkBox = this._chkIsTaxExempt;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000F4B9F File Offset: 0x000F2D9F
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x000F4BA9 File Offset: 0x000F2DA9
		internal virtual CheckBox chkIsDeposit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x000F4BB2 File Offset: 0x000F2DB2
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x000F4BBC File Offset: 0x000F2DBC
		internal virtual CheckBox chkIsWeighingScaleProduct
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsWeighingScaleProduct;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._chkIsWeighingScaleProduct;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsWeighingScaleProduct = value;
				checkBox = this._chkIsWeighingScaleProduct;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x000F4BFF File Offset: 0x000F2DFF
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x000F4C09 File Offset: 0x000F2E09
		internal virtual Label lblshelflife
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x000F4C12 File Offset: 0x000F2E12
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x000F4C1C File Offset: 0x000F2E1C
		internal virtual TextBox txtShelfLife
		{
			[CompilerGenerated]
			get
			{
				return this._txtShelfLife;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtShelfLife_KeyPress);
				TextBox textBox = this._txtShelfLife;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtShelfLife = value;
				textBox = this._txtShelfLife;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x000F4C5F File Offset: 0x000F2E5F
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x000F4C69 File Offset: 0x000F2E69
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000F4C72 File Offset: 0x000F2E72
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x000F4C7C File Offset: 0x000F2E7C
		internal virtual ComboBox cboManu
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x000F4C85 File Offset: 0x000F2E85
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x000F4C8F File Offset: 0x000F2E8F
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x000F4C98 File Offset: 0x000F2E98
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x000F4CA4 File Offset: 0x000F2EA4
		internal virtual TextBox txtHSCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtHSCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				TextBox textBox = this._txtHSCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtHSCode = value;
				textBox = this._txtHSCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000F4CE7 File Offset: 0x000F2EE7
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x000F4CF1 File Offset: 0x000F2EF1
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000F4CFA File Offset: 0x000F2EFA
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x000F4D04 File Offset: 0x000F2F04
		internal virtual CheckBox chkSerialNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000F4D0D File Offset: 0x000F2F0D
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x000F4D17 File Offset: 0x000F2F17
		internal virtual CheckBox chkIsProdtDescEditable
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x000F4D20 File Offset: 0x000F2F20
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x000F4D2C File Offset: 0x000F2F2C
		internal virtual TextBox txtProductWeight
		{
			[CompilerGenerated]
			get
			{
				return this._txtProductWeight;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtProductWeight_KeyPress);
				TextBox textBox = this._txtProductWeight;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtProductWeight = value;
				textBox = this._txtProductWeight;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000F4D6F File Offset: 0x000F2F6F
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x000F4D79 File Offset: 0x000F2F79
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x000F4D84 File Offset: 0x000F2F84
		private void NewProdt_Load(object sender, EventArgs e)
		{
			try
			{
				bool isbranch = MyProject.Forms.Form1.isbranch;
				if (isbranch)
				{
					MessageBox.Show("You are logged into a branch and cannot create new products from there.");
					base.Dispose();
				}
				this.LoadCategories();
				this.LoadUOM();
				this.cboSupplier.DataSource = this.publicfunction.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "SupplierID";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				this.cboSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
				bool flag = this.cboSupplier.Items.Count > 1;
				if (flag)
				{
					this.cboSupplier.SelectedIndex = -1;
				}
				else
				{
					this.cboSupplier.SelectedIndex = 0;
				}
				this.productsDatatable = this.publicfunction.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
				this.cboProducts.DataSource = this.publicfunction.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
				this.cboProducts.ValueMember = "ProductID";
				this.cboProducts.DisplayMember = "ProductDesc";
				this.cboProducts.SelectedIndex = -1;
				this.txtProductCode.Focus();
				bool flag2 = this.not_for_purchase;
				if (flag2)
				{
					this.Label27.Visible = false;
					this.txtQtyPurchased.Visible = false;
				}
				bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag3)
				{
					this.chkProductExpires.Checked = true;
					this.txtQtyPurchased.Visible = false;
					this.Label27.Visible = false;
				}
				else
				{
					this.txtQtyPurchased.Visible = true;
					this.Label27.Visible = true;
				}
				this.LoadManu();
				this.chkSerialNumber.Text = "Record " + MyProject.Forms.Form1.serialNumberName;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000F4FDC File Offset: 0x000F31DC
		private void LoadManu()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select distinct manufacturer from products";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboManu.DataSource = dataTable;
			this.cboManu.ValueMember = "Manufacturer";
			this.cboManu.DisplayMember = "Manufacturer";
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x000F5058 File Offset: 0x000F3258
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboCategory.DataSource = dataTable;
			this.cboCategory.ValueMember = "CatID";
			this.cboCategory.DisplayMember = "CatDesc";
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000F50F8 File Offset: 0x000F32F8
		private void SaveProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunSaveNewProduct");
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				int num = 0;
				bool @checked = this.ChkImported.Checked;
				if (@checked)
				{
					num = 1;
				}
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertNewProduct5";
				sqlCommand.Parameters.AddWithValue("catid", RuntimeHelpers.GetObjectValue(this.cboCategory.SelectedValue));
				sqlCommand.Parameters.AddWithValue("productdesc", this.txtProductDesc.Text);
				sqlCommand.Parameters.AddWithValue("cost", Conversions.ToDecimal(this.txtCost.Text));
				sqlCommand.Parameters.AddWithValue("sellingprice", Conversions.ToDecimal(this.txtSellingPrice.Text));
				sqlCommand.Parameters.AddWithValue("reorderlevel", Conversion.Val(this.txtReorder.Text));
				sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
				sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
				sqlCommand.Parameters.AddWithValue("productcode", this.txtProductCode.Text);
				sqlCommand.Parameters.AddWithValue("barcode", 0);
				sqlCommand.Parameters.AddWithValue("taxrate", Conversion.Val(this.txtTaxRate.Text));
				sqlCommand.Parameters.AddWithValue("imported", num);
				sqlCommand.Parameters.AddWithValue("uom", RuntimeHelpers.GetObjectValue(this.cboUOM.SelectedValue));
				sqlCommand.Parameters.AddWithValue("binloc", this.txtbinlocation.Text);
				sqlCommand.Parameters.AddWithValue("productdesc2", this.txtDesc2.Text);
				sqlCommand.Parameters.AddWithValue("new_prodtid", this.newID);
				sqlCommand.Parameters.AddWithValue("wholesaleqty", Convert.ToDecimal(this.WholesaleQTY.Text));
				int num2 = 0;
				bool checked2 = this.chkProductExpires.Checked;
				if (checked2)
				{
					num2 = 1;
				}
				sqlCommand.Parameters.AddWithValue("ProductExpires", num2);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				int num3 = 0;
				bool checked3 = this.chkDifferent.Checked;
				if (checked3)
				{
					num3 = 1;
				}
				sqlCommand.Parameters.AddWithValue("differentpriceperbranch", num3);
				bool checked4 = this.chkIsUnlimitedStockItem.Checked;
				if (checked4)
				{
					sqlCommand.Parameters.AddWithValue("isunlimitedstockitem", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isunlimitedstockitem", 0);
				}
				bool checked5 = this.chkIngridient.Checked;
				if (checked5)
				{
					sqlCommand.Parameters.AddWithValue("isingridientonly", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isingridientonly", 0);
				}
				sqlCommand.Parameters.AddWithValue("supplierid", RuntimeHelpers.GetObjectValue(this.cboSupplier.SelectedValue));
				bool checked6 = this.chkIsBooking.Checked;
				if (checked6)
				{
					sqlCommand.Parameters.AddWithValue("isbooking", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isbooking", 0);
				}
				bool checked7 = this.chkIsCalcLxW.Checked;
				if (checked7)
				{
					sqlCommand.Parameters.AddWithValue("iscalclxw", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("iscalclxw", 0);
				}
				int num4 = 0;
				bool checked8 = this.chkIsCase.Checked;
				if (checked8)
				{
					num4 = 1;
				}
				else
				{
					bool checked9 = this.chkIsBoth.Checked;
					if (checked9)
					{
						num4 = 2;
					}
				}
				sqlCommand.Parameters.AddWithValue("iscase", num4);
				sqlCommand.Parameters.AddWithValue("caseqty", Conversion.Val(this.txtCaseQty.Text));
				sqlCommand.Parameters.AddWithValue("caseparentproductid", RuntimeHelpers.GetObjectValue(this.cboProducts.SelectedValue));
				bool checked10 = this.chkPriceVariable.Checked;
				if (checked10)
				{
					sqlCommand.Parameters.AddWithValue("ispricevariable", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("ispricevariable", 0);
				}
				sqlCommand.Parameters.AddWithValue("taxexempt", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkIsTaxExempt.Checked, 1, 0)));
				sqlCommand.Parameters.AddWithValue("isdeposit", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkIsDeposit.Checked, 1, 0)));
				sqlCommand.Parameters.AddWithValue("shelflife", Conversions.ToInteger(this.txtShelfLife.Text));
				sqlCommand.Parameters.AddWithValue("isscaleproduct", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkIsWeighingScaleProduct.Checked, 1, 0)));
				sqlCommand.Parameters.AddWithValue("manu", this.cboManu.Text);
				bool flag = Operators.CompareString(this.txtHSCode.Text, "", false) == 0;
				if (!flag)
				{
					sqlCommand.Parameters.AddWithValue("hscode", this.txtHSCode.Text);
				}
				bool checked11 = this.chkSerialNumber.Checked;
				if (checked11)
				{
					sqlCommand.Parameters.AddWithValue("recordserial", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("recordserial", 0);
				}
				bool checked12 = this.chkIsProdtDescEditable.Checked;
				if (checked12)
				{
					sqlCommand.Parameters.AddWithValue("isdesceditable", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isdesceditable", 0);
				}
				sqlCommand.Parameters.AddWithValue("productweight", Conversion.Val(this.txtProductWeight.Text));
				this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				bool isProductCodeGenerated = this.IsProductCodeGenerated;
				if (isProductCodeGenerated)
				{
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandText = "UpdateProductCodeBase";
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					bool flag2 = this.txtProductCode.Text.Length == 13;
					string text;
					if (flag2)
					{
						text = this.txtProductCode.Text.Substring(3, 9);
					}
					else
					{
						text = this.txtProductCode.Text.Substring(2, checked(this.txtProductCode.Text.Length - 2));
					}
					sqlCommand.Parameters.AddWithValue("code", Conversions.ToDecimal(text));
					sqlCommand.ExecuteNonQuery();
				}
				sqlTransaction.Commit();
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving product. Detail: " + ex.Message);
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

		// Token: 0x06001AF1 RID: 6897 RVA: 0x000F5920 File Offset: 0x000F3B20
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x000F596C File Offset: 0x000F3B6C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtProductDesc.Text = this.txtProductDesc.Text.ToString().Trim();
				bool flag = Operators.CompareString(this.txtProductDesc.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter the product description first.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.txtProductCode.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please enter the product code first.");
					}
					else
					{
						bool flag3 = Operators.CompareString(this.cboSupplier.Text, "", false) == 0;
						if (flag3)
						{
							MessageBox.Show("Please select a supplier first.");
							this.cboSupplier.Focus();
						}
						else
						{
							this.SaveProduct();
							string newProductCode = this.GetNewProductCode(this.newID);
							bool isProductCodeGenerated = this.IsProductCodeGenerated;
							if (isProductCodeGenerated)
							{
								this.txtProductCode.Text = "";
								this.txtProductCode.ReadOnly = false;
							}
							MessageBox.Show("New product code is: " + newProductCode + ". Details successfully saved.");
							MyProject.Forms.Form1.newProdtID = this.newID;
							MyProject.Forms.Form1.newProdtCode = newProductCode;
							MyProject.Forms.Form1.qtypurchased = new decimal(Conversion.Val(this.txtQtyPurchased.Text));
							MyProject.Forms.Form1.supplierselected = this.cboSupplier.Text;
							bool flag4 = MyProject.Forms.Form1.usingBarcodePrintingScale == 1;
							if (flag4)
							{
								string text = "c:\\ISHIDAFILES";
								bool flag5 = !Directory.Exists(text);
								if (flag5)
								{
									Directory.CreateDirectory(text);
								}
								string text2 = text + "\\products";
								bool flag6 = !File.Exists(text2);
								if (flag6)
								{
									File.Create(text2).Dispose();
								}
								DataTable dataTable = new DataTable();
								DataGridView dataGridView = new DataGridView();
								this.dtTableToCSV(this.pf.GetishidaExportList(this._cnn), text2, true, ",");
								MessageBox.Show("Scale Update list successfully exported.");
								int num = this.pf.CheckIfIshidaExportOk(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
								bool flag7 = num > 0;
								if (flag7)
								{
									MessageBox.Show(string.Concat(new string[]
									{
										"There are ",
										Conversions.ToString(num),
										" products with product codes longer than ",
										this.pf.GetBarcodeScaleCodeLen(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString(),
										" characters. If this is not supported by your scale configuration, please change IsScale settings for the affected products."
									}));
								}
							}
							base.Dispose();
						}
					}
				}
			}
			catch (SqlException ex)
			{
				bool flag8 = ex.Number == 2627;
				if (flag8)
				{
					MessageBox.Show("Ensure that the product code entered is unique. Database error.");
				}
				else
				{
					MessageBox.Show("Database error. Detail: " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving product. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x000F5CEC File Offset: 0x000F3EEC
		private string GetNewProductCode(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "LatestProductCode";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = dataRow["ProductCode"].ToString();
			}
			else
			{
				text = Conversions.ToString(0);
			}
			return text;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000F5DD0 File Offset: 0x000F3FD0
		private void txtTaxRate_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000F5E1C File Offset: 0x000F401C
		private void LoadUOM()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetUOM";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboUOM.DataSource = dataTable;
			this.cboUOM.DisplayMember = "UOMDesc";
			this.cboUOM.ValueMember = "UOM";
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000F5E98 File Offset: 0x000F4098
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtProductCode.Text = this.publicfunction.GetNextProductCode(this._cnn, MyProject.Forms.Form1.coid);
				this.IsProductCodeGenerated = true;
				this.txtProductCode.ReadOnly = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error generating product code. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000F5F20 File Offset: 0x000F4120
		private void Button3_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
					if (flag)
					{
						bool flag2 = this.publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), MyProject.Forms.MainMenu.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
						if (flag2)
						{
							Categories categories = new Categories();
							categories.ShowDialog(this);
							categories.Dispose();
							this.LoadCategories();
							this.cboCategory.SelectedIndex = this.cboCategory.Items.Count - 1;
						}
						else
						{
							MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
						}
					}
					else
					{
						Categories categories2 = new Categories();
						categories2.ShowDialog(this);
						categories2.Dispose();
						this.LoadCategories();
						this.cboCategory.SelectedIndex = this.cboCategory.Items.Count - 1;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Main Menu Error. Details: " + ex.Message);
				}
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000F6074 File Offset: 0x000F4274
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				Suppliers suppliers = new Suppliers();
				suppliers.ShowDialog(this);
				suppliers.Dispose();
				string suppliername = MyProject.Forms.Form1.suppliername;
				this.cboSupplier.DataSource = this.publicfunction.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "SupplierID";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.SelectedIndex = -1;
				this.cboSupplier.SelectedIndex = this.cboSupplier.FindStringExact(MyProject.Forms.Form1.suppliername);
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error entering new supplier details at new stock purchase");
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboSupplier_KeyUp(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000F6154 File Offset: 0x000F4354
		private void AutoCompleteCombo_Leave(ComboBox cbo)
		{
			int num = cbo.FindStringExact(cbo.Text);
			cbo.SelectedIndex = num;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboSupplier_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x000F6178 File Offset: 0x000F4378
		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboProducts.SelectedIndex = this.cboProducts.FindStringExact(this.ListBox1.SelectedItem.ToString());
				this.ListBox1.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting from list. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000F61F4 File Offset: 0x000F43F4
		private void cboProducts_TextChanged(object sender, EventArgs e)
		{
			try
			{
				NewProdt2._Closure$__305-0 CS$<>8__locals1 = new NewProdt2._Closure$__305-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$Local_textToSearch = this.cboProducts.Text.ToLower();
				this.ListBox1.Visible = false;
				bool flag = string.IsNullOrEmpty(CS$<>8__locals1.$VB$Local_textToSearch);
				if (!flag)
				{
					var list = this.productsDatatable.AsEnumerable().Select((NewProdt2._Closure$__.$I305-0 == null) ? (NewProdt2._Closure$__.$I305-0 = (DataRow p) => new
					{
						ID = p.Field<int>("productid"),
						Name = p.Field<string>("productdesc")
					}) : NewProdt2._Closure$__.$I305-0).ToList();
					var list2 = list.Where(x => x.Name.ToLower().Contains(CS$<>8__locals1.$VB$Local_textToSearch)).ToList();
					bool flag2 = list2.Count == 0;
					if (!flag2)
					{
						this.ListBox1.Items.Clear();
						try
						{
							foreach (var anon in list2)
							{
								this.ListBox1.Items.Add(anon.Name);
							}
						}
						finally
						{
							var enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.ListBox1.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x000F6358 File Offset: 0x000F4558
		private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000F63A4 File Offset: 0x000F45A4
		private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000F63F0 File Offset: 0x000F45F0
		private void chkIsCase_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsCase.Checked;
				if (@checked)
				{
					this.txtCaseQty.Visible = true;
					this.Label18.Visible = true;
					this.cboProducts.Visible = false;
					this.Label19.Visible = false;
					this.chkIsBoth.Checked = false;
				}
				else
				{
					this.txtCaseQty.Visible = false;
					this.Label18.Visible = false;
					this.cboProducts.Visible = true;
					this.Label19.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x000F64AC File Offset: 0x000F46AC
		private void chkIsBoth_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsBoth.Checked;
				if (@checked)
				{
					this.chkIsCase.Checked = false;
					this.cboProducts.Visible = true;
					this.Label19.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x000F6518 File Offset: 0x000F4718
		private void txtProductCode_Leave(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "select productdesc from products where productcode='" + this.txtProductCode.Text + "' and coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				bool flag = dataTable.Rows.Count == 1;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					MessageBox.Show("Product already exists with that Product/Bar Code. Product: " + dataRow["ProductDesc"].ToString());
					this.txtProductCode.SelectAll();
					this.txtProductCode.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error checking productcode after leaving product code textbox. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002A30 File Offset: 0x00000C30
		private void WholesaleQTY_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x000F662C File Offset: 0x000F482C
		private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x000F6678 File Offset: 0x000F4878
		private void chkIsTaxExempt_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsTaxExempt.Checked;
				if (@checked)
				{
					this.txtTaxRate.Text = Conversions.ToString(0);
					this.txtTaxRate.Enabled = false;
				}
				else
				{
					this.txtTaxRate.Enabled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000F66EC File Offset: 0x000F48EC
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkIsWeighingScaleProduct.Checked;
			if (@checked)
			{
				this.lblshelflife.Visible = true;
				this.txtShelfLife.Visible = true;
			}
			else
			{
				this.lblshelflife.Visible = false;
				this.txtShelfLife.Visible = false;
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtShelfLife_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000F6744 File Offset: 0x000F4944
		private void chkProductExpires_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkProductExpires.Checked;
				if (@checked)
				{
					this.txtQtyPurchased.Text = "0";
					this.txtQtyPurchased.Visible = false;
					this.Label27.Visible = false;
				}
				else
				{
					this.txtQtyPurchased.Visible = true;
					this.Label27.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000F67D0 File Offset: 0x000F49D0
		private object dtTableToCSV(DataTable dt, string filename, bool headers = true, string delim = ",")
		{
			string text = filename + ".csv";
			bool flag = File.Exists(text);
			if (flag)
			{
				File.Delete(text);
			}
			int num = 0;
			checked
			{
				string text2;
				if (headers)
				{
					try
					{
						foreach (object obj in dt.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj;
							bool flag2 = num == 0;
							if (flag2)
							{
								text2 += dataColumn.ColumnName;
							}
							else
							{
								text2 = text2 + delim + dataColumn.ColumnName;
							}
							num++;
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
				text2 += "\r\n";
				num = 0;
				try
				{
					foreach (object obj2 in dt.Rows)
					{
						DataRow dataRow = (DataRow)obj2;
						string text3 = "";
						try
						{
							foreach (object obj3 in dt.Columns)
							{
								DataColumn dataColumn2 = (DataColumn)obj3;
								text3 = text3 + delim + dataRow[dataColumn2.ColumnName].ToString();
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
						bool flag3 = dt.Rows.Count - 1 == num;
						if (flag3)
						{
							text2 += text3.Substring(1);
						}
						else
						{
							text2 = text2 + text3.Substring(1) + "\r\n";
						}
						num++;
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
				using (StreamWriter streamWriter = new StreamWriter(text))
				{
					streamWriter.Write(text2);
				}
				dt.Dispose();
				return text;
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000F69E4 File Offset: 0x000F4BE4
		private void txtProductWeight_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00012800 File Offset: 0x00010A00
		private void WholesaleQTY_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x04000D01 RID: 3329
		private string _cnn;

		// Token: 0x04000D02 RID: 3330
		private int newID;

		// Token: 0x04000D03 RID: 3331
		private PublicFunctions publicfunction;

		// Token: 0x04000D04 RID: 3332
		private bool IsProductCodeGenerated;

		// Token: 0x04000D05 RID: 3333
		private DataTable productsDatatable;

		// Token: 0x04000D06 RID: 3334
		public bool not_for_purchase;

		// Token: 0x04000D07 RID: 3335
		private PublicFunctions pf;
	}
}
