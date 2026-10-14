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
	// Token: 0x02000032 RID: 50
	[DesignerGenerated]
	public partial class CreditNote2 : Form
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x00065D44 File Offset: 0x00063F44
		public CreditNote2()
		{
			base.Load += this.CreditNote2_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.datCustomers = new DataTable();
			this.pf = new PublicFunctions();
			this.datInvDetails = new DataTable();
			this.datPayDetails = new DataTable();
			this.datCustomerDetails = new DataTable();
			this.TextToPrint = "";
			this.tax_amount = 0m;
			this.the_tax_amount = 0m;
			this.sub_total = 0m;
			this.InitializeComponent();
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00069824 File Offset: 0x00067A24
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x0006982E File Offset: 0x00067A2E
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00069837 File Offset: 0x00067A37
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00069841 File Offset: 0x00067A41
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0006984A File Offset: 0x00067A4A
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00069854 File Offset: 0x00067A54
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

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000698B2 File Offset: 0x00067AB2
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x000698BC File Offset: 0x00067ABC
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000698C5 File Offset: 0x00067AC5
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x000698D0 File Offset: 0x00067AD0
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00069913 File Offset: 0x00067B13
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0006991D File Offset: 0x00067B1D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00069926 File Offset: 0x00067B26
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00069930 File Offset: 0x00067B30
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00069973 File Offset: 0x00067B73
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0006997D File Offset: 0x00067B7D
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00069986 File Offset: 0x00067B86
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00069990 File Offset: 0x00067B90
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboCustomers_KeyUp);
				EventHandler eventHandler = new EventHandler(this.cboCustomers_Leave);
				EventHandler eventHandler2 = new EventHandler(this.cboCustomers_SelectedIndexChanged);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.KeyUp -= keyEventHandler;
					comboBox.Leave -= eventHandler;
					comboBox.SelectedIndexChanged -= eventHandler2;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.KeyUp += keyEventHandler;
					comboBox.Leave += eventHandler;
					comboBox.SelectedIndexChanged += eventHandler2;
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00069A09 File Offset: 0x00067C09
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00069A13 File Offset: 0x00067C13
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00069A1C File Offset: 0x00067C1C
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00069A28 File Offset: 0x00067C28
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00069A6B File Offset: 0x00067C6B
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00069A75 File Offset: 0x00067C75
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00069A7E File Offset: 0x00067C7E
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00069A88 File Offset: 0x00067C88
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00069ACB File Offset: 0x00067CCB
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00069AD5 File Offset: 0x00067CD5
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00069ADE File Offset: 0x00067CDE
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00069AE8 File Offset: 0x00067CE8
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00069AF1 File Offset: 0x00067CF1
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00069AFB File Offset: 0x00067CFB
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00069B04 File Offset: 0x00067D04
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00069B0E File Offset: 0x00067D0E
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00069B17 File Offset: 0x00067D17
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00069B21 File Offset: 0x00067D21
		internal virtual TextBox txtInvDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00069B2A File Offset: 0x00067D2A
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00069B34 File Offset: 0x00067D34
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00069B3D File Offset: 0x00067D3D
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00069B47 File Offset: 0x00067D47
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00069B50 File Offset: 0x00067D50
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00069B5A File Offset: 0x00067D5A
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00069B63 File Offset: 0x00067D63
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00069B6D File Offset: 0x00067D6D
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00069B76 File Offset: 0x00067D76
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00069B80 File Offset: 0x00067D80
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00069B89 File Offset: 0x00067D89
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00069B93 File Offset: 0x00067D93
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00069B9C File Offset: 0x00067D9C
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00069BA6 File Offset: 0x00067DA6
		internal virtual TextBox txtContactName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00069BAF File Offset: 0x00067DAF
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00069BB9 File Offset: 0x00067DB9
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00069BC2 File Offset: 0x00067DC2
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00069BCC File Offset: 0x00067DCC
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00069BD5 File Offset: 0x00067DD5
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00069BDF File Offset: 0x00067DDF
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00069BE8 File Offset: 0x00067DE8
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00069BF2 File Offset: 0x00067DF2
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00069BFB File Offset: 0x00067DFB
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00069C05 File Offset: 0x00067E05
		internal virtual TextBox txtcustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00069C0E File Offset: 0x00067E0E
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00069C18 File Offset: 0x00067E18
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00069C21 File Offset: 0x00067E21
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00069C2B File Offset: 0x00067E2B
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00069C34 File Offset: 0x00067E34
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00069C40 File Offset: 0x00067E40
		internal virtual TextBox txtQtyReturned
		{
			[CompilerGenerated]
			get
			{
				return this._txtQtyReturned;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtQtyReturned_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQtyReturned_KeyPress);
				EventHandler eventHandler2 = new EventHandler(this.txtQtyReturned_Leave);
				TextBox textBox = this._txtQtyReturned;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
					textBox.Leave -= eventHandler2;
				}
				this._txtQtyReturned = value;
				textBox = this._txtQtyReturned;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
					textBox.Leave += eventHandler2;
				}
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00069CB9 File Offset: 0x00067EB9
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00069CC3 File Offset: 0x00067EC3
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00069CCC File Offset: 0x00067ECC
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00069CD8 File Offset: 0x00067ED8
		internal virtual TextBox txtAmtCharged
		{
			[CompilerGenerated]
			get
			{
				return this._txtAmtCharged;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmtCharged_KeyPress);
				TextBox textBox = this._txtAmtCharged;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAmtCharged = value;
				textBox = this._txtAmtCharged;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00069D1B File Offset: 0x00067F1B
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00069D25 File Offset: 0x00067F25
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00069D2E File Offset: 0x00067F2E
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00069D38 File Offset: 0x00067F38
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

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00069D7B File Offset: 0x00067F7B
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00069D85 File Offset: 0x00067F85
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00069D8E File Offset: 0x00067F8E
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00069D98 File Offset: 0x00067F98
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00069DA1 File Offset: 0x00067FA1
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00069DAB File Offset: 0x00067FAB
		internal virtual DataGridView dgvDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00069DB4 File Offset: 0x00067FB4
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00069DBE File Offset: 0x00067FBE
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00069DC7 File Offset: 0x00067FC7
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00069DD4 File Offset: 0x00067FD4
		internal virtual ComboBox cboPayType
		{
			[CompilerGenerated]
			get
			{
				return this._cboPayType;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPayType_SelectedIndexChanged);
				ComboBox comboBox = this._cboPayType;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPayType = value;
				comboBox = this._cboPayType;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00069E17 File Offset: 0x00068017
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00069E24 File Offset: 0x00068024
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvpay_CellEndEdit);
				DataGridView dataGridView = this._dgvpay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
				}
				this._dgvpay = value;
				dataGridView = this._dgvpay;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00069E67 File Offset: 0x00068067
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00069E74 File Offset: 0x00068074
		internal virtual GroupBox GroupBox5
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox5_Enter);
				GroupBox groupBox = this._GroupBox5;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox5 = value;
				groupBox = this._GroupBox5;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00069EB7 File Offset: 0x000680B7
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00069EC4 File Offset: 0x000680C4
		internal virtual TextBox txtCurrentID
		{
			[CompilerGenerated]
			get
			{
				return this._txtCurrentID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtCurrentID_TextChanged_1);
				TextBox textBox = this._txtCurrentID;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtCurrentID = value;
				textBox = this._txtCurrentID;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00069F07 File Offset: 0x00068107
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00069F11 File Offset: 0x00068111
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00069F1A File Offset: 0x0006811A
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00069F24 File Offset: 0x00068124
		internal virtual ComboBox cboInvoices
		{
			[CompilerGenerated]
			get
			{
				return this._cboInvoices;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboInvoices_SelectedIndexChanged_1);
				ComboBox comboBox = this._cboInvoices;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboInvoices = value;
				comboBox = this._cboInvoices;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00069F67 File Offset: 0x00068167
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00069F71 File Offset: 0x00068171
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00069F7A File Offset: 0x0006817A
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00069F84 File Offset: 0x00068184
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00069F8D File Offset: 0x0006818D
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00069F98 File Offset: 0x00068198
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
				EventHandler eventHandler = new EventHandler(this.txtBarCode_TextChanged_1);
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00069FDB File Offset: 0x000681DB
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00069FE8 File Offset: 0x000681E8
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
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode_TextChanged_2);
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0006A02B File Offset: 0x0006822B
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0006A035 File Offset: 0x00068235
		internal virtual TextBox txtDoneby
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0006A03E File Offset: 0x0006823E
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x0006A048 File Offset: 0x00068248
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0006A051 File Offset: 0x00068251
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0006A05B File Offset: 0x0006825B
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0006A064 File Offset: 0x00068264
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0006A06E File Offset: 0x0006826E
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0006A077 File Offset: 0x00068277
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0006A084 File Offset: 0x00068284
		internal virtual DateTimePicker DateTimePicker1
		{
			[CompilerGenerated]
			get
			{
				return this._DateTimePicker1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DateTimePicker1_ValueChanged_1);
				DateTimePicker dateTimePicker = this._DateTimePicker1;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DateTimePicker1 = value;
				dateTimePicker = this._DateTimePicker1;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0006A0C7 File Offset: 0x000682C7
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0006A0D1 File Offset: 0x000682D1
		internal virtual TextBox txtAmtPaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0006A0DA File Offset: 0x000682DA
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0006A0E4 File Offset: 0x000682E4
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0006A127 File Offset: 0x00068327
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0006A131 File Offset: 0x00068331
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0006A13A File Offset: 0x0006833A
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0006A144 File Offset: 0x00068344
		internal virtual TextBox txtCharges
		{
			[CompilerGenerated]
			get
			{
				return this._txtCharges;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtCharges_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCharges_KeyPress);
				EventHandler eventHandler2 = new EventHandler(this.txtCharges_Leave);
				TextBox textBox = this._txtCharges;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
					textBox.Leave -= eventHandler2;
				}
				this._txtCharges = value;
				textBox = this._txtCharges;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
					textBox.Leave += eventHandler2;
				}
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0006A1BD File Offset: 0x000683BD
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0006A1C7 File Offset: 0x000683C7
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0006A1D0 File Offset: 0x000683D0
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0006A1DA File Offset: 0x000683DA
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0006A1E3 File Offset: 0x000683E3
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0006A1ED File Offset: 0x000683ED
		internal virtual Label lbExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0006A1F6 File Offset: 0x000683F6
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0006A200 File Offset: 0x00068400
		internal virtual Label lblBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0006A209 File Offset: 0x00068409
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0006A213 File Offset: 0x00068413
		internal virtual TextBox txtBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0006A21C File Offset: 0x0006841C
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0006A226 File Offset: 0x00068426
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0006A22F File Offset: 0x0006842F
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0006A239 File Offset: 0x00068439
		internal virtual Label lblEffectiveAmtPaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0006A242 File Offset: 0x00068442
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0006A24C File Offset: 0x0006844C
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0006A255 File Offset: 0x00068455
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0006A260 File Offset: 0x00068460
		internal virtual TextBox TextBox2
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox2_TextChanged);
				TextBox textBox = this._TextBox2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._TextBox2 = value;
				textBox = this._TextBox2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0006A2A3 File Offset: 0x000684A3
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0006A2AD File Offset: 0x000684AD
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0006A2B6 File Offset: 0x000684B6
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0006A2C0 File Offset: 0x000684C0
		internal virtual Label lblRate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0006A2C9 File Offset: 0x000684C9
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0006A2D3 File Offset: 0x000684D3
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0006A2DC File Offset: 0x000684DC
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0006A2E8 File Offset: 0x000684E8
		internal virtual ComboBox cboPaymentMethods
		{
			[CompilerGenerated]
			get
			{
				return this._cboPaymentMethods;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPaymentMethods_SelectedIndexChanged);
				ComboBox comboBox = this._cboPaymentMethods;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPaymentMethods = value;
				comboBox = this._cboPaymentMethods;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0006A32B File Offset: 0x0006852B
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x0006A335 File Offset: 0x00068535
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0006A33E File Offset: 0x0006853E
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x0006A348 File Offset: 0x00068548
		internal virtual TextBox txtComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0006A351 File Offset: 0x00068551
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x0006A35B File Offset: 0x0006855B
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0006A364 File Offset: 0x00068564
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0006A36E File Offset: 0x0006856E
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0006A377 File Offset: 0x00068577
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x0006A381 File Offset: 0x00068581
		internal virtual GroupBox GroupBox7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0006A38A File Offset: 0x0006858A
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x0006A394 File Offset: 0x00068594
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0006A39D File Offset: 0x0006859D
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x0006A3A8 File Offset: 0x000685A8
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0006A3EB File Offset: 0x000685EB
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0006A3F5 File Offset: 0x000685F5
		internal virtual TextBox DTexp
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0006A400 File Offset: 0x00068600
		private void CreditNote2_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadCustomers();
				this.LoadPaymentMethods();
				this.LoadPaymentMethodsCBO();
				bool flag = MyProject.Forms.Form1.AllowAccountSales == 0;
				if (flag)
				{
					this.cboPayType.SelectedIndex = 0;
					this.cboPayType.Enabled = false;
					this.GroupBox2.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0006A4A4 File Offset: 0x000686A4
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

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0006A52C File Offset: 0x0006872C
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

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0006A624 File Offset: 0x00068824
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

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0006A730 File Offset: 0x00068930
		private object searchDat(DataTable dt, string column, string value)
		{
			CreditNote2._Closure$__350-0 CS$<>8__locals1 = new CreditNote2._Closure$__350-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((CreditNote2._Closure$__.$I350-0 == null) ? (CreditNote2._Closure$__.$I350-0 = (object row1) => (DataRow)row1) : CreditNote2._Closure$__.$I350-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0006A80C File Offset: 0x00068A0C
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

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0006A894 File Offset: 0x00068A94
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

		// Token: 0x06000ADA RID: 2778 RVA: 0x0006AA6C File Offset: 0x00068C6C
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

		// Token: 0x06000ADB RID: 2779 RVA: 0x0006AACC File Offset: 0x00068CCC
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

		// Token: 0x06000ADC RID: 2780 RVA: 0x0006AB90 File Offset: 0x00068D90
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtQtyReturned.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error on search. Ignore");
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0006ABF0 File Offset: 0x00068DF0
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtQtyReturned.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0006AC98 File Offset: 0x00068E98
		private void SearchBarCode(int prodtID)
		{
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
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = num2 == 0;
				decimal num3;
				if (flag2)
				{
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
					decimal num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"]))));
				}
				else
				{
					DataRow branchPrices = this.GetBranchPrices(Conversions.ToInteger(dataRow["productid"]));
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"]))));
					decimal num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"]))));
				}
				decimal num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num6 = decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3));
				this.CurrentPrice = num6;
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				this.txtCurrentID.Text = Conversions.ToString(this.CurrentID);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0006AF90 File Offset: 0x00069190
		private void SearchProductCode(string prodtcode)
		{
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
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = num2 == 0;
				decimal num3;
				if (flag2)
				{
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
					decimal num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"]))));
				}
				else
				{
					DataRow branchPrices = this.GetBranchPrices(Conversions.ToInteger(dataRow["productid"]));
					num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"]))));
					decimal num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"]))));
				}
				decimal num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num6 = decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3));
				num6 = num6;
				this.CurrentPrice = num6;
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				this.txtCurrentID.Text = Conversions.ToString(this.CurrentID);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0006B290 File Offset: 0x00069490
		private void txtCurrentID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID != 0;
				if (flag)
				{
					this.LoadInvoiceNumbers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.CurrentID, Convert.ToInt32(this.DateTimePicker1.Value.ToString("yyyyMMdd")));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0006B318 File Offset: 0x00069518
		private void LoadInvoiceNumbers(int coid, string branch, int productid, int trandate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetInvoiceNumbersForProductForDay";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("trandate", trandate);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.cboInvoices.DataSource = dataTable;
				this.cboInvoices.ValueMember = "InvoiceNum";
				this.cboInvoices.DisplayMember = "InvoiceNum";
			}
			else
			{
				DataTable dataTable2 = new DataTable();
				this.cboInvoices.DataSource = dataTable2;
				this.LoadDetails(0, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0006B438 File Offset: 0x00069638
		private void LoadDetails(int inv, int coid, string branch)
		{
			this.GroupBox3.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetInvoiceDetailsFiscal";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvDetails.DataSource = dataTable;
				this.dgvDetails.Columns["Product_Code"].Visible = false;
				this.dgvDetails.Columns["ProductCode"].Visible = false;
				this.dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.GroupBox3.Text = "Showing details for invoice: " + Conversions.ToString(inv);
				DataRow dataRow = dataTable.Rows[0];
				this.txtDoneby.Text = dataRow["Done_By"].ToString();
				string text = Conversions.ToString(dataRow["ref"]);
				bool flag2 = Operators.CompareString(text, "Cash", false) != 0;
				if (flag2)
				{
					this.cboCustomers.SelectedIndex = this.cboCustomers.FindStringExact(text);
				}
				else
				{
					this.cboCustomers.SelectedIndex = -1;
					this.clearcustomerdetails();
				}
				DataRow[] array = dataTable.Select("ProdtID='" + Conversions.ToString(this.CurrentID) + "'");
				bool flag3 = array.Length > 0;
				if (flag3)
				{
					this.txtAmtCharged.Text = NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
					{
						Operators.AddObject(array[0]["UnitPrice"], Operators.DivideObject(array[0]["Tax"], array[0]["Qty"])),
						2,
						MidpointRounding.AwayFromZero
					}, null, null, null).ToString();
					this.tax_amount = Conversions.ToDecimal(Operators.DivideObject(array[0]["Tax"], array[0]["Qty"]));
					this.CurrentQTY = Conversions.ToDecimal(array[0]["Qty"]);
					this.currentRate = Conversions.ToDecimal(array[0]["therate"]);
					this.lblRate.Text = this.currentRate.ToString();
					this.currentPayMeth = Conversions.ToInteger(array[0]["ReceiptDisplayPaymentMethod"]);
					bool flag4 = this.CurrentExpires | (MyProject.Forms.Form1.IsWarehouse == 1);
					if (flag4)
					{
						this.txtBatchNumber.Text = Conversions.ToString(array[0]["BatchNumber"]);
						this.DTexp.Text = Conversions.ToString(array[0]["ExpiryDate"]);
					}
				}
				this.CurrInvSum = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataTable.Compute("SUM(Qty)", "ProdtID=" + Conversions.ToString(this.CurrentID))));
				this.SearchProductfromGrid(this.CurrentID, this.dgvDetails);
			}
			else
			{
				DataTable dataTable2 = new DataTable();
				this.dgvDetails.DataSource = dataTable2;
				this.GroupBox3.Text = "No details availablefor invoice: " + Conversions.ToString(inv);
				this.txtAmtCharged.Text = "";
				this.txtDoneby.Text = "";
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0006B80C File Offset: 0x00069A0C
		private void cboInvoices_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadDetails(Conversions.ToInteger(this.cboInvoices.SelectedValue), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0006B874 File Offset: 0x00069A74
		private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID != 0;
				if (flag)
				{
					this.LoadInvoiceNumbers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.CurrentID, Convert.ToInt32(this.DateTimePicker1.Value.ToString("yyyyMMdd")));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0006B8FC File Offset: 0x00069AFC
		private void txtSearchProductCode_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0006B9A0 File Offset: 0x00069BA0
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveCustomerDetails();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer details. Detai: " + ex.Message);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0006B9F0 File Offset: 0x00069BF0
		private void SaveCustomerDetails()
		{
			try
			{
				bool flag = this.IsCustomerNew(this.txtcustomer.Text);
				if (flag)
				{
					this.InsertNewCustomer();
				}
				else
				{
					this.UpdateCustomer();
				}
				this.LoadCustomers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer details. SALE COMPLETED. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0006BA68 File Offset: 0x00069C68
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

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0006BB54 File Offset: 0x00069D54
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
			this.cboCustomers.ValueMember = "Entryno";
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0006BC18 File Offset: 0x00069E18
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

		// Token: 0x06000AEB RID: 2795 RVA: 0x0006BDA8 File Offset: 0x00069FA8
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

		// Token: 0x06000AEC RID: 2796 RVA: 0x0006BF38 File Offset: 0x0006A138
		private void Button4_Click(object sender, EventArgs e)
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

		// Token: 0x06000AED RID: 2797 RVA: 0x0006BFF0 File Offset: 0x0006A1F0
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

		// Token: 0x06000AEE RID: 2798 RVA: 0x0006C0F8 File Offset: 0x0006A2F8
		public void AutoCompleteCombo_Leave(ComboBox cbo)
		{
			int num = cbo.FindStringExact(cbo.Text);
			cbo.SelectedIndex = num;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0006C11C File Offset: 0x0006A31C
		private void cboCustomers_Leave(object sender, EventArgs e)
		{
			this.AutoCompleteCombo_Leave(this.cboCustomers);
			DataRowView dataRowView = (DataRowView)this.cboCustomers.SelectedItem;
			bool flag = dataRowView == null;
			if (flag)
			{
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0006C154 File Offset: 0x0006A354
		private decimal GetCountAlreadyCreditedForInvoice(int coid, string branch, int productid, int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckPreviousCredits";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("oldinvnum", invoicenum);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["qty_returned"]);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0006C21C File Offset: 0x0006A41C
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = (Operators.CompareString(this.cboPayType.Text, "CASH", false) == 0) & (decimal.Compare(Convert.ToDecimal(Conversion.Val(this.txtAmtPaid.Text)), Convert.ToDecimal(Conversion.Val(this.txtTotal.Text))) != 0);
			if (flag)
			{
				MessageBox.Show("Enter the payment method in the grid to the right and make sure the amounts are mataching.");
				this.dgvpay.Focus();
				this.dgvpay.CurrentCell = this.dgvpay.Rows[0].Cells["ActCol"];
				this.dgvpay.BeginEdit(true);
			}
			else
			{
				bool flag2 = (Operators.CompareString(this.cboPayType.Text, "ACCOUNT", false) == 0) & (Operators.CompareString(this.txtcustomer.Text, "Cash", false) == 0);
				if (flag2)
				{
					MessageBox.Show("Account payment method selected, please select the account first.");
					this.cboCustomers.Focus();
				}
				else
				{
					bool flag3 = Operators.CompareString(this.cboPayType.Text, "", false) == 0;
					if (flag3)
					{
						MessageBox.Show("Select Cash or Account first. How the credit will be settled.");
						this.cboPayType.Focus();
					}
					else
					{
						bool flag4 = (Operators.CompareString(this.txtTotal.Text, "", false) == 0) | (Operators.CompareString(this.txtQtyReturned.Text, "", false) == 0) | (Conversion.Val(this.txtQtyReturned.Text) == 0.0);
						if (flag4)
						{
							MessageBox.Show("Total due has not been calculated. Check quantity returned.");
							this.txtQtyReturned.Focus();
						}
						else
						{
							bool flag5 = Operators.CompareString(this.cboPayType.Text, "ACCOUNT", false) == 0;
							if (flag5)
							{
								bool flag6 = decimal.Compare(Convert.ToDecimal(this.txtTotal.Text), Convert.ToDecimal(this.lblEffectiveAmtPaid.Text)) != 0;
								if (flag6)
								{
									MessageBox.Show("Amounts entered for account do not match.");
									this.TextBox2.Focus();
									return;
								}
							}
							bool flag7 = MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice == 0;
							if (flag7)
							{
								bool flag8 = Operators.CompareString(this.cboInvoices.Text, "", false) == 0;
								if (flag8)
								{
									MessageBox.Show("Please select the original invoice first before generating a credit note. Select the date then the invoice number");
									this.DateTimePicker1.Focus();
									return;
								}
								bool flag9 = decimal.Compare(Convert.ToDecimal(Conversion.Val(this.txtQtyReturned.Text)), this.CurrInvSum) > 0;
								if (flag9)
								{
									MessageBox.Show("Quantity entered for return is greater than what was sold. Please rectify.");
									this.txtQtyReturned.Focus();
									return;
								}
								bool flag10 = decimal.Compare(Convert.ToDecimal(Conversion.Val(this.txtQtyReturned.Text)), this.CurrInvSum) > 0;
								if (flag10)
								{
									MessageBox.Show("The sum of the current quanity to be credited and previous credits on the same invoice is now greater than what was sold initialy on the same invoice. Rectify.");
									return;
								}
							}
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							try
							{
								bool flag11 = this.CurrentID != 0;
								if (flag11)
								{
									bool flag12 = Operators.CompareString(this.txtAmtCharged.Text, "", false) != 0;
									if (flag12)
									{
										sqlCommand.Connection = sqlConnection;
										sqlConnection.Open();
										SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunCreditNote");
										sqlCommand.Transaction = sqlTransaction;
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "GetNewInvoiceNumberCredit";
										sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
										sqlCommand.Parameters.Add("newinvoicenum", SqlDbType.Int);
										sqlCommand.Parameters["newinvoicenum"].Direction = ParameterDirection.Output;
										sqlCommand.ExecuteNonQuery();
										int num = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenum"].Value);
										bool flag13 = num == 0;
										if (flag13)
										{
											MessageBox.Show("0 invnum. Date entered is inaccurate. Cannot proceed");
											sqlTransaction.Rollback();
											sqlConnection.Close();
										}
										else
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertProductCredited";
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("trandate", DateTime.Now);
											sqlCommand.Parameters.AddWithValue("entryno", num);
											sqlCommand.Parameters.AddWithValue("donotlink", MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice);
											bool flag14 = Operators.CompareString(this.cboInvoices.Text, "", false) == 0;
											int num2;
											if (flag14)
											{
												num2 = 0;
											}
											else
											{
												num2 = Convert.ToInt32(this.cboInvoices.Text);
											}
											sqlCommand.Parameters.AddWithValue("oldinvnum", num2);
											sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
											sqlCommand.Parameters.AddWithValue("qty", Convert.ToDecimal(this.txtQtyReturned.Text));
											sqlCommand.Parameters.AddWithValue("sellingprice", Convert.ToDecimal(this.txtAmtCharged.Text));
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("charges", Convert.ToDecimal(this.txtCharges.Text));
											sqlCommand.Parameters.AddWithValue("comment", this.txtComment.Text);
											sqlCommand.Parameters.AddWithValue("paytype", this.cboPayType.Text);
											sqlCommand.Parameters.AddWithValue("customer", this.txtcustomer.Text);
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("receiptdisplayrate", this.currentRate);
											sqlCommand.Parameters.AddWithValue("taxamt", this.the_tax_amount);
											sqlCommand.Parameters.AddWithValue("batchnumber", this.txtBatchNumber.Text);
											sqlCommand.Parameters.AddWithValue("expirydate", this.DTexp.Text);
											sqlCommand.Parameters.AddWithValue("userceiptdisplay", 1);
											sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", this.currentPayMeth);
											sqlCommand.Parameters.AddWithValue("creditinvnum", num);
											sqlCommand.ExecuteNonQuery();
											bool flag15 = MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice == 1;
											if (flag15)
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandType = CommandType.StoredProcedure;
												sqlCommand.CommandText = "InsertNewSale2Warehouse2";
												sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
												sqlCommand.Parameters.AddWithValue("invoicenum", num);
												sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
												sqlCommand.Parameters.AddWithValue("isstockin", 1);
												sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
												sqlCommand.Parameters.AddWithValue("quantity", Convert.ToDecimal(this.txtQtyReturned.Text));
												sqlCommand.Parameters.AddWithValue("unitcost", 0);
												sqlCommand.Parameters.AddWithValue("salesprice", Conversions.ToDecimal(this.txtAmtCharged.Text));
												bool flag16 = Operators.CompareString(this.cboPayType.Text, "CASH", false) == 0;
												if (flag16)
												{
													sqlCommand.Parameters.AddWithValue("paymentmethod", 1);
												}
												else
												{
													bool flag17 = Operators.CompareString(this.cboPayType.Text, "ACCOUNT", false) == 0;
													if (flag17)
													{
														sqlCommand.Parameters.AddWithValue("paymentmethod", 10);
													}
												}
												sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
												sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
												sqlCommand.Parameters.AddWithValue("trancode", 8);
												sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, this.CurrentID, this._cnn));
												sqlCommand.Parameters.AddWithValue("TranTime", Convert.ToInt32(DateTime.Now.ToString("HHmm")));
												sqlCommand.Parameters.AddWithValue("taxamt", 0);
												sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
												sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
												sqlCommand.Parameters.AddWithValue("shift", "DAY");
												sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
												bool flag18 = MyProject.Forms.Form1.IsWarehouse == 1;
												if (flag18)
												{
													bool currentExpires = this.CurrentExpires;
													if (currentExpires)
													{
														sqlCommand.Parameters.AddWithValue("BatchNumber", this.txtBatchNumber.Text);
														sqlCommand.Parameters.AddWithValue("ExpiryDate", this.DTexp.Text);
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("BatchNumber", "");
														sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
													}
												}
												else
												{
													bool flag19 = MyProject.Forms.Form1.IsWarehouse == 0;
													if (flag19)
													{
														sqlCommand.Parameters.AddWithValue("BatchNumber", "");
														sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
													}
												}
												sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
												bool flag20 = Operators.CompareString(this.cboPayType.Text, "CASH", false) == 0;
												if (flag20)
												{
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", this.currentPayMeth);
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.currentRate);
												}
												else
												{
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", this.currentPayMeth);
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.currentRate);
												}
												sqlCommand.Parameters.AddWithValue("discountamount", 0);
												sqlCommand.Parameters.AddWithValue("comments", this.txtComment.Text);
												sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
												sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
												sqlCommand.ExecuteNonQuery();
											}
											else
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandType = CommandType.Text;
												sqlCommand.CommandText = string.Concat(new string[]
												{
													"update movement set uploaded=0, quantity=quantity-",
													Conversions.ToString(Conversions.ToDecimal(this.txtQtyReturned.Text)),
													",comments='Single product credit note' ,taxamt=(taxamt/Quantity)*(Quantity-",
													Conversions.ToString(Conversions.ToDecimal(this.txtQtyReturned.Text)),
													")  where trancode=3 and invoicenum=",
													Conversions.ToString(num2),
													" and branch='",
													MyProject.Forms.Form1.branch,
													"' and coid=",
													Conversions.ToString(MyProject.Forms.Form1.coid),
													" and productid=",
													Conversions.ToString(this.CurrentID)
												});
												sqlCommand.ExecuteNonQuery();
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandType = CommandType.StoredProcedure;
												sqlCommand.CommandText = "InsertNewSale2Warehouse2";
												sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
												sqlCommand.Parameters.AddWithValue("invoicenum", num);
												sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
												sqlCommand.Parameters.AddWithValue("isstockin", 1);
												sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
												sqlCommand.Parameters.AddWithValue("quantity", 0);
												sqlCommand.Parameters.AddWithValue("unitcost", 0);
												sqlCommand.Parameters.AddWithValue("salesprice", Conversions.ToDecimal(this.txtAmtCharged.Text));
												bool flag21 = Operators.CompareString(this.cboPayType.Text, "CASH", false) == 0;
												if (flag21)
												{
													sqlCommand.Parameters.AddWithValue("paymentmethod", 1);
												}
												else
												{
													bool flag22 = Operators.CompareString(this.cboPayType.Text, "ACCOUNT", false) == 0;
													if (flag22)
													{
														sqlCommand.Parameters.AddWithValue("paymentmethod", 10);
													}
												}
												sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
												sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
												sqlCommand.Parameters.AddWithValue("trancode", 8);
												sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, this.CurrentID, this._cnn));
												sqlCommand.Parameters.AddWithValue("TranTime", Convert.ToInt32(DateTime.Now.ToString("HHmm")));
												sqlCommand.Parameters.AddWithValue("taxamt", 0);
												sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
												sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
												sqlCommand.Parameters.AddWithValue("shift", "DAY");
												sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
												bool flag23 = MyProject.Forms.Form1.IsWarehouse == 1;
												if (flag23)
												{
													bool currentExpires2 = this.CurrentExpires;
													if (currentExpires2)
													{
														sqlCommand.Parameters.AddWithValue("BatchNumber", this.txtBatchNumber.Text);
														sqlCommand.Parameters.AddWithValue("ExpiryDate", this.DTexp.Text);
													}
													else
													{
														sqlCommand.Parameters.AddWithValue("BatchNumber", "");
														sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
													}
												}
												else
												{
													bool flag24 = MyProject.Forms.Form1.IsWarehouse == 0;
													if (flag24)
													{
														sqlCommand.Parameters.AddWithValue("BatchNumber", "");
														sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
													}
												}
												sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
												bool flag25 = Operators.CompareString(this.cboPayType.Text, "CASH", false) == 0;
												if (flag25)
												{
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", this.currentPayMeth);
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.currentRate);
												}
												else
												{
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", this.currentPayMeth);
													sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.currentRate);
												}
												sqlCommand.Parameters.AddWithValue("discountamount", 0);
												sqlCommand.Parameters.AddWithValue("comments", this.txtComment.Text);
												sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
												sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
												sqlCommand.ExecuteNonQuery();
											}
											bool flag26 = MyProject.Forms.Form1.IsWarehouse == 1;
											if (flag26)
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandType = CommandType.Text;
												sqlCommand.CommandText = string.Concat(new string[]
												{
													"update ProductStockBalances set StockBal=StockBal+",
													Conversions.ToString(Conversions.ToDecimal(this.txtQtyReturned.Text)),
													",MvtEntryNo=0 where productid=",
													Conversions.ToString(this.CurrentID),
													"and coid=",
													Conversions.ToString(MyProject.Forms.Form1.coid),
													" and branch='",
													MyProject.Forms.Form1.branch,
													"' and batchnumber=",
													this.txtBatchNumber.Text,
													" and expirydate=",
													Conversions.ToString(Conversions.ToInteger(this.DTexp.Text))
												});
												sqlCommand.ExecuteNonQuery();
											}
											else
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandType = CommandType.Text;
												sqlCommand.CommandText = string.Concat(new string[]
												{
													"update ProductStockBalances set StockBal=StockBal+",
													Conversions.ToString(Conversions.ToDecimal(this.txtQtyReturned.Text)),
													",MvtEntryNo=0 where productid=",
													Conversions.ToString(this.CurrentID),
													"and coid=",
													Conversions.ToString(MyProject.Forms.Form1.coid),
													" and branch='",
													MyProject.Forms.Form1.branch,
													"'"
												});
												sqlCommand.ExecuteNonQuery();
											}
											bool flag27 = Operators.CompareString(this.cboPayType.Text, "CASH", false) == 0;
											if (flag27)
											{
												bool flag28 = MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice == 1;
												if (flag28)
												{
													MessageBox.Show("Error here. Please advise system developer.");
													sqlTransaction.Rollback();
													sqlConnection.Close();
													return;
												}
												try
												{
													foreach (object obj in ((IEnumerable)this.dgvpay.Rows))
													{
														DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
														int count = this.dgvpay.Rows.Count;
														double num3 = 0.0;
														bool flag29 = Operators.CompareString(dataGridViewRow.Cells["Qtycol"].Value.ToString(), "", false) != 0;
														if (flag29)
														{
															bool flag30 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["Actcol"].Value, 0, false);
															if (flag30)
															{
																double num4 = 0.0;
																bool flag31 = num4 == 0.0;
																if (flag31)
																{
																	num3 = Conversions.ToDouble(dataGridViewRow.Cells["QTYcol"].Value);
																}
																num3 *= -1.0;
																sqlCommand.Parameters.Clear();
																sqlCommand.CommandType = CommandType.StoredProcedure;
																sqlCommand.CommandText = "InsertActualPaymentMethodsCredit";
																sqlCommand.Parameters.AddWithValue("invnum", num);
																sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PaymentMethodID"].Value));
																sqlCommand.Parameters.AddWithValue("paydesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PaymentMethodDesc"].Value));
																sqlCommand.Parameters.AddWithValue("amt", num3);
																sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
																sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
																sqlCommand.Parameters.AddWithValue("rate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Rate"].Value));
																sqlCommand.Parameters.AddWithValue("paytype", this.cboPayType.Text);
																sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
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
											}
											else
											{
												bool flag32 = Operators.CompareString(this.cboPayType.Text, "ACCOUNT", false) == 0;
												if (flag32)
												{
													bool flag33 = Operators.CompareString(this.txtcustomer.Text, "", false) != 0;
													if (flag33)
													{
														bool flag34 = this.IsCustomerNew(this.txtcustomer.Text);
														if (flag34)
														{
															this.InsertNewCustomer();
														}
														else
														{
															this.UpdateCustomer();
														}
														int num5 = 0;
														sqlCommand.Parameters.Clear();
														sqlCommand.CommandType = CommandType.StoredProcedure;
														sqlCommand.CommandText = "BillingInsertAccPayment";
														sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
														sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
														sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
														sqlCommand.Parameters.AddWithValue("shiftdate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
														sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
														sqlCommand.Parameters.AddWithValue("amount", Convert.ToDecimal(this.txtTotal.Text));
														sqlCommand.Parameters.AddWithValue("teller", MyProject.Forms.Form1.username);
														sqlCommand.Parameters.AddWithValue("paymentmethodid", this.currentPayMeth);
														sqlCommand.Parameters.AddWithValue("paymentmethoddesc", this.pf.getPayMethDesc(this.currentPayMeth, MyProject.Forms.Form1.coid, this._cnn));
														sqlCommand.Parameters.AddWithValue("rate", Convert.ToDecimal(this.lblRate.Text));
														sqlCommand.Parameters.AddWithValue("ref", num);
														sqlCommand.Parameters.AddWithValue("customername", this.txtcustomer.Text);
														sqlCommand.Parameters.AddWithValue("transactiontype", "CREDIT NOTE");
														sqlCommand.Parameters.AddWithValue("Comment", this.txtComment.Text);
														sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
														sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
														sqlCommand.Parameters.AddWithValue("isrefund", 0);
														sqlCommand.Parameters.AddWithValue("entryno", num5);
														sqlCommand.ExecuteNonQuery();
													}
													else
													{
														MessageBox.Show("Please select the account before proceeding.");
														sqlTransaction.Rollback();
														sqlConnection.Close();
														this.cboCustomers.Focus();
													}
												}
											}
											sqlTransaction.Commit();
											sqlConnection.Close();
											MessageBox.Show("Credit Note successfuly generated. Printing");
											this.PrintReceipt(Conversions.ToInteger(this.cboInvoices.Text), num);
											this.clearform();
										}
									}
									else
									{
										MessageBox.Show("Amount charged is not selected or entered. Please correct.");
										this.txtAmtCharged.Focus();
									}
								}
								else
								{
									MessageBox.Show("Please select the product first from the Search area or by using the Bar Code");
									bool flag35 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
									if (flag35)
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
								MessageBox.Show("Error generating credit note. Detail: " + ex.Message);
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
					}
				}
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0006DC90 File Offset: 0x0006BE90
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

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0006DD40 File Offset: 0x0006BF40
		private void clearform()
		{
			this.CurrentID = 0;
			this.txtSearchProductCode.Text = "";
			this.txtBarCode.Text = "";
			this.txtDesc.Text = "";
			this.txtAmtCharged.Text = "";
			this.txtQtyReturned.Text = "";
			this.txtCharges.Text = "0";
			this.txtTotal.Text = "";
			this.txtDoneby.Text = "";
			this.cboPayType.SelectedIndex = -1;
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
			this.lblEffectiveAmtPaid.Text = "0";
			this.TextBox2.Text = "0";
			this.cboPaymentMethods.SelectedIndex = -1;
			DataTable dataTable = new DataTable();
			this.cboInvoices.DataSource = dataTable;
			bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
			if (flag)
			{
				this.txtsearch.Focus();
			}
			else
			{
				this.txtBarCode.Focus();
			}
			this.CurrentQTY = 0m;
			this.clearcustomerdetails();
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0006DEFC File Offset: 0x0006C0FC
		private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcCustomerBill(Conversions.ToInteger(this.cboCustomers.SelectedValue));
				this.FetchCustomer(Conversions.ToInteger(this.cboCustomers.SelectedValue));
			}
			catch (InvalidCastException ex)
			{
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0006DF5C File Offset: 0x0006C15C
		private void CalcCustomerBill(int customerentryno)
		{
			try
			{
				this.lblCustomerBillingBal.Text = "Acc Bal $" + this.GetCustomerBillTotal(customerentryno, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating customer bill. Proceed. Details: " + ex.Message);
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0006DFE8 File Offset: 0x0006C1E8
		private double GetCustomerBillTotal(int customerentryno, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCalcAccBalance";
			sqlCommand.Parameters.AddWithValue("customerentryno", customerentryno);
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

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0006E0E0 File Offset: 0x0006C2E0
		private void FetchCustomer(int customer_entryno)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCustomerDetailsEntryNo";
				sqlCommand.Parameters.AddWithValue("CustomerEntryNo", customer_entryno);
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
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0006E2C0 File Offset: 0x0006C4C0
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
			this.dgvpay.Columns["CurrencyIDEltrade"].Visible = false;
			this.dgvpay.Columns["RequiresRef"].Visible = false;
			this.dgvpay.Columns["PaymentMethodDesc"].HeaderText = "Payment Method";
			this.dgvpay.Columns["BPNumber"].Visible = false;
			this.dgvpay.Columns["VatNumber"].Visible = false;
			this.dgvpay.Columns["coid"].Visible = false;
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

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0006E61C File Offset: 0x0006C81C
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
							num2 = Conversions.ToDecimal(Operators.MultiplyObject(dataGridViewRow.Cells["ActCol"].Value, dataGridViewRow.Cells["Rate"].Value));
							num2 = decimal.Subtract(num2, decimal.Multiply(num3, num2));
							dataGridViewRow.Cells["QTYCol"].Value = Math.Round(num2, 2, MidpointRounding.AwayFromZero);
							num = Conversions.ToDouble(Operators.AddObject(num, dataGridViewRow.Cells["ActCol"].Value));
						}
						else
						{
							bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ActCol"].Value, "", false);
							if (flag3)
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

		// Token: 0x06000AFA RID: 2810 RVA: 0x0006E930 File Offset: 0x0006CB30
		private void LoadPaymentMethodsCBO()
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
			this.cboPaymentMethods.SelectedIndex = -1;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0006E9DC File Offset: 0x0006CBDC
		private void cboPayType_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboPayType.Text, "CASH", false) == 0;
				if (flag)
				{
					this.dgvpay.Visible = true;
					this.txtAmtPaid.Visible = true;
					this.GroupBox6.Visible = false;
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cboPayType.Text, "ACCOUNT", false) == 0;
					if (flag2)
					{
						this.dgvpay.Visible = false;
						this.txtAmtPaid.Visible = false;
						this.GroupBox6.Visible = true;
						this.lblEffectiveAmtPaid.Text = this.txtTotal.Text;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0006EAB0 File Offset: 0x0006CCB0
		private void txtSearchProductCode_TextChanged_2(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0006EB54 File Offset: 0x0006CD54
		private void txtBarCode_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0006EBE8 File Offset: 0x0006CDE8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtAmtCharged.Text = Conversions.ToString(Math.Round(this.CurrentPrice, 2, MidpointRounding.AwayFromZero));
				this.CalcTotal();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating current price. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0006EC54 File Offset: 0x0006CE54
		private int GetInvoiceNumCreditNote()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNewInvoiceNumberCredit";
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

		// Token: 0x06000B00 RID: 2816 RVA: 0x0006ED2C File Offset: 0x0006CF2C
		private void txtQtyReturned_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0006ED64 File Offset: 0x0006CF64
		private void CalcTotal()
		{
			decimal num = decimal.Subtract(decimal.Multiply(Convert.ToDecimal(this.txtAmtCharged.Text), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(this.txtQtyReturned.Text, "", false) == 0, 0, this.txtQtyReturned.Text)))), Convert.ToDecimal(this.txtCharges.Text));
			this.txtTotal.Text = Conversions.ToString(Math.Round(num, 2, MidpointRounding.AwayFromZero));
			this.the_tax_amount = decimal.Multiply(this.tax_amount, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(this.txtQtyReturned.Text, "", false) == 0, 0, this.txtQtyReturned.Text))));
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0006EE3C File Offset: 0x0006D03C
		private void txtCharges_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0006EE74 File Offset: 0x0006D074
		private void txtQtyReturned_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0006EEC0 File Offset: 0x0006D0C0
		private void txtCharges_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0006EF0C File Offset: 0x0006D10C
		private void txtCurrentID_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					bool currentExpires = this.CurrentExpires;
					if (currentExpires)
					{
						this.lblBatchNumber.Visible = true;
						this.txtBatchNumber.Visible = true;
						this.lbExpiryDate.Visible = true;
						this.DTexp.Visible = true;
					}
					else
					{
						this.lblBatchNumber.Visible = false;
						this.txtBatchNumber.Visible = false;
						this.txtBatchNumber.Text = "";
						this.lbExpiryDate.Visible = false;
						this.DTexp.Visible = false;
					}
				}
				else
				{
					this.lblBatchNumber.Visible = false;
					this.txtBatchNumber.Visible = false;
					this.lbExpiryDate.Visible = false;
					this.DTexp.Visible = false;
				}
				this.LoadInvoiceNumbers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.CurrentID, Convert.ToInt32(this.DateTimePicker1.Value.ToString("yyyyMMdd")));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002A30 File Offset: 0x00000C30
		private void DTexp_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0006F06C File Offset: 0x0006D26C
		private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
		{
			try
			{
				this.LoadInvoiceNumbers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.CurrentID, Convert.ToInt32(this.DateTimePicker1.Value.ToString("yyyyMMdd")));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0006F0E8 File Offset: 0x0006D2E8
		private void cboInvoices_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			try
			{
				this.LoadDetails(Convert.ToInt32(this.cboInvoices.Text), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				this.CalcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0006F158 File Offset: 0x0006D358
		private void dgvpay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
							num2 = Conversions.ToDecimal(Operators.MultiplyObject(dataGridViewRow.Cells["ActCol"].Value, dataGridViewRow.Cells["Rate"].Value));
							num2 = decimal.Subtract(num2, decimal.Multiply(num3, num2));
							dataGridViewRow.Cells["QTYCol"].Value = Math.Round(num2, 2, MidpointRounding.AwayFromZero);
							num = Conversions.ToDouble(Operators.AddObject(num, dataGridViewRow.Cells["ActCol"].Value));
							this.currentPayMeth = Conversions.ToInteger(dataGridViewRow.Cells["PaymentMethodID"].Value);
							this.currentRate = Conversions.ToDecimal(dataGridViewRow.Cells["Rate"].Value);
						}
						else
						{
							bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ActCol"].Value, "", false);
							if (flag3)
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
			catch (Exception ex)
			{
				MessageBox.Show("Error leaving payment grid. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0006F44C File Offset: 0x0006D64C
		private void cboPaymentMethods_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetPaymentMethRate";
				sqlCommand.Parameters.AddWithValue("paymethid", RuntimeHelpers.GetObjectValue(this.cboPaymentMethods.SelectedValue));
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.lblRate.Text = dataRow["Rate"].ToString();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0006F53C File Offset: 0x0006D73C
		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblEffectiveAmtPaid.Text = decimal.Divide(Convert.ToDecimal(this.TextBox2.Text), Convert.ToDecimal(this.lblRate.Text)).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0006F5A8 File Offset: 0x0006D7A8
		private void txtQtyReturned_Leave(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice == 0;
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.cboInvoices.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please select the invoice first.");
						this.txtQtyReturned.Text = "0";
						this.cboInvoices.Focus();
						return;
					}
					bool flag3 = decimal.Compare(Conversions.ToDecimal(this.txtQtyReturned.Text), this.CurrentQTY) > 0;
					if (flag3)
					{
						MessageBox.Show("Cannot return more than what was sold for this invoice number. Please check.");
						this.txtQtyReturned.Text = "0";
					}
				}
				this.CalcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0006F684 File Offset: 0x0006D884
		private void txtCharges_Leave(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtCharges.Text, "", false) == 0;
				if (flag)
				{
					this.txtCharges.Text = "0";
				}
				this.CalcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0006F6EC File Offset: 0x0006D8EC
		private DataRow GetBranchPrices(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchPriceForProduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows[0];
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0006F7A8 File Offset: 0x0006D9A8
		private void SearchProductfromGrid(int productid, DataGridView dgv)
		{
			bool flag = dgv.RowCount > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in ((IEnumerable)dgv.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProdtID"].Value, productid, false);
						if (flag2)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.LightBlue;
							dataGridViewRow.Selected = true;
							this.dgvDetails.CurrentCell = dataGridViewRow.Cells["ProdtID"];
							this.dgvDetails.BeginEdit(true);
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

		// Token: 0x06000B10 RID: 2832 RVA: 0x0006F884 File Offset: 0x0006DA84
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag3;
			try
			{
				bool flag = msg.WParam.ToInt32() == 112;
				if (flag)
				{
					this.txtBarCode.Focus();
				}
				else
				{
					bool flag2 = msg.WParam.ToInt32() == 27;
					if (flag2)
					{
						this.clearform();
					}
				}
				flag3 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag3;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0006F904 File Offset: 0x0006DB04
		private void txtAmtCharged_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0006F950 File Offset: 0x0006DB50
		private void PrintReceipt(int invnumber, int creditnote_num)
		{
			this.PrintHeader();
			this.ItemsToBePrinted(Conversions.ToInteger(this.cboInvoices.Text), this.cboPayType.Text, this.txtcustomer.Text, "", -1m, 1m, Conversions.ToString(creditnote_num), this.txtComment.Text);
			this.PrintFooter(this.tax_amount.ToString(), this.cboPayType.Text, this.sub_total);
			this.stringToRead = new StringReader(this.TextToPrint);
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				bool flag = Operators.CompareString(MyProject.Forms.Form1.defaultReceiptPrinter, "", false) != 0;
				if (flag)
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

		// Token: 0x06000B13 RID: 2835 RVA: 0x0006FA6C File Offset: 0x0006DC6C
		private DataTable GetCancelledProducts(int invnum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetCancelledInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0006FB1C File Offset: 0x0006DD1C
		private DataTable GetPayDetails(int invnum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetInvoicePayDetailsFiscal";
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0006FBCC File Offset: 0x0006DDCC
		public void PrintHeader()
		{
			this.TextToPrint = "";
			bool flag = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
			if (flag)
			{
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					this.TextToPrint,
					Environment.NewLine,
					Environment.NewLine,
					Environment.NewLine,
					Environment.NewLine,
					Environment.NewLine
				});
			}
			string text = MyProject.Forms.Form1.companyname;
			int num = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				text = "";
				num = text.Length;
				bool flag2 = num > 49;
				if (flag2)
				{
					string text3 = text.Substring(0, 50);
					string text4 = text.Substring(50, num - 50);
					string text5 = new string(' ', (int)Math.Round(Math.Round((double)(50 - text3.Length) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text + Environment.NewLine;
					string text6 = new string(' ', (int)Math.Round(Math.Round((double)(50 - text4.Length) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text6 + text + Environment.NewLine;
				}
				else
				{
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text7 + text + Environment.NewLine;
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

		// Token: 0x06000B16 RID: 2838 RVA: 0x0006FE34 File Offset: 0x0006E034
		public void ItemsToBePrinted(int invnumber, string saletype, string customername, string customeraddress, decimal invrate, decimal invdisc, string invoicenum_display, string comments)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "PRODUCT CREDIT NOTE" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Comments: " + comments + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Credit Note Number:" + invoicenum_display;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Invoice Number:" + invnumber.ToString();
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag = Operators.CompareString(customername, "Cash", false) != 0;
			if (flag)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + customername;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Details:" + customeraddress;
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
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select * from productscredited where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"' and oldinvnum=",
				Conversions.ToString(invnumber),
				" and productid=",
				Conversions.ToString(this.CurrentID)
			});
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
							DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataRow["productid"]), this._cnn);
							string text = Conversions.ToString(productDetails["ProductDesc"]);
							string text2 = Conversions.ToString(productDetails["UOM"]);
							decimal num2 = Conversions.ToDecimal(dataRow["qty"]);
							bool flag3 = Operators.CompareString(text2, "EA", false) == 0;
							if (flag3)
							{
								num2 = new decimal(Convert.ToInt32(num2));
							}
							decimal num3 = Conversions.ToDecimal(dataRow["SellingPrice"]);
							this.tax_amount = Conversions.ToDecimal(dataRow["taxamt"]);
							string text3 = Conversions.ToString(productDetails["ProductCode"]);
							this.sub_total = decimal.Multiply(num3, num2);
							int num4 = (int)Math.Round(Conversion.Val(text.Length));
							bool flag4 = num4 >= 34;
							if (flag4)
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
							string text4 = text;
							string text5 = Conversions.ToString(text4.Length);
							string text6 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text5)))));
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text4 + Environment.NewLine;
							decimal num7 = 0m;
							bool flag5 = dataRow["Comment"].ToString().Length > 50;
							if (flag5)
							{
								text4 = dataRow["Comment"].ToString().Substring(0, 49) + Environment.NewLine;
								text4 = text4 + dataRow["Comment"].ToString().Substring(50, 50) + Environment.NewLine;
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text4;
							}
							else
							{
								bool flag6 = dataRow["Comment"].ToString().Length > 0;
								if (flag6)
								{
									text4 = Conversions.ToString(Operators.ConcatenateObject(dataRow["Comment"], Environment.NewLine));
									ptr = ref this.TextToPrint;
									this.TextToPrint = ptr + text4;
								}
							}
							bool flag7 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
							if (flag7)
							{
								decimal num8 = decimal.Multiply(num3, this.pf.GetRate(this._cnn, MyProject.Forms.Form1.ReceiptDisplayPaymentMethod));
								num7 = decimal.Multiply(num8, num2);
								text4 = string.Concat(new string[]
								{
									"     ",
									num2.ToString(),
									"   X        ",
									num8.ToString(),
									"            ",
									num7.ToString()
								});
							}
							else
							{
								num7 = Math.Round(decimal.Multiply(num3, num2), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
								text4 = string.Concat(new string[]
								{
									"     ",
									num2.ToString(),
									"   X        ",
									num3.ToString(),
									"            ",
									num7.ToString()
								});
							}
							string text7 = Conversions.ToString(text4.Length);
							string text8 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text5)))));
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text4 + Environment.NewLine;
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

		// Token: 0x06000B17 RID: 2839 RVA: 0x000704B4 File Offset: 0x0006E6B4
		private void PrintFooter(string tax, string saletype, decimal subtotal)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			string text = "Tax         " + Math.Round(Conversion.Val(tax), 2, MidpointRounding.AwayFromZero).ToString();
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
					decimal num = decimal.Multiply(Convert.ToDecimal(subtotal), this.pf.GetRate(this._cnn, MyProject.Forms.Form1.ReceiptDisplayPaymentMethod));
					string text4 = Math.Round(num, 2, MidpointRounding.AwayFromZero).ToString();
					text = string.Format("{0,20}", "Sub-tot: " + text4.PadLeft(33 - text4.Length, ' '));
				}
				else
				{
					string text5 = Math.Round(subtotal, 2, MidpointRounding.AwayFromZero).ToString();
					text = string.Format("{0,20}", "Sub-tot: " + text5.PadLeft(33 - text5.Length, ' '));
				}
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
				decimal num2 = Conversions.ToDecimal(this.txtCharges.Text);
				string text7 = Math.Round(num2, 2, MidpointRounding.AwayFromZero).ToString();
				text = string.Format("{0,20}", "Charge: " + text7.PadLeft(34 - text7.Length, ' '));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text6 + text + Environment.NewLine;
				string text8 = Math.Round(decimal.Subtract(subtotal, num2), 2, MidpointRounding.AwayFromZero).ToString();
				text = string.Format("{0,20}", "Total: " + text8.PadLeft(36 - text8.Length, ' '));
				text2 = Conversions.ToString(length);
				string text9 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag3 = Operators.CompareString(text, "Cash        $0.00", false) != 0;
				if (flag3)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text + Environment.NewLine;
				}
				bool flag4 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag4)
				{
					bool flag5 = Conversions.ToBoolean(saletype);
					string text10;
					if (flag5)
					{
						text10 = "Account";
					}
					else
					{
						text10 = "COD";
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					text = "Payment Method:" + text10;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
					bool flag6 = Operators.CompareString(text10, "COD", false) == 0;
					if (flag6)
					{
						try
						{
							foreach (object obj in this.datPayDetails.Rows)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(obj);
								string text11 = NewLateBinding.LateIndexGet(objectValue, new object[] { "PaymentMethodDesc" }, null).ToString();
								string text12 = ": ";
								object obj2 = null;
								Type typeFromHandle = typeof(Math);
								string text13 = "Round";
								object[] array = new object[3];
								int num3 = 0;
								object obj3 = objectValue;
								object obj4 = obj3;
								object[] array2 = new object[1];
								object obj5 = (array2[0] = "AmountPaid");
								array[num3] = NewLateBinding.LateIndexGet(obj4, array2, null);
								array[1] = 2;
								array[2] = MidpointRounding.AwayFromZero;
								object[] array3 = array;
								string[] array4 = null;
								Type[] array5 = null;
								bool[] array6 = new bool[3];
								array6[0] = true;
								bool[] array7 = array6;
								object obj6 = NewLateBinding.LateGet(obj2, typeFromHandle, text13, array, array4, array5, array6);
								if (array7[0])
								{
									NewLateBinding.LateIndexSetComplex(obj3, new object[]
									{
										obj5,
										array3[0]
									}, null, true, false);
								}
								text = text11 + text12 + obj6.ToString();
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text + Environment.NewLine;
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
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = "";
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000709D0 File Offset: 0x0006EBD0
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

		// Token: 0x06000B19 RID: 2841 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox5_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00070B38 File Offset: 0x0006ED38
		private void clearcustomerdetails()
		{
			try
			{
				foreach (object obj in this.Panel1.Controls)
				{
					Control control = (Control)obj;
					bool flag = control is TextBox;
					if (flag)
					{
						((TextBox)control).Clear();
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

		// Token: 0x04000529 RID: 1321
		private string _cnn;

		// Token: 0x0400052A RID: 1322
		private int CurrentID;

		// Token: 0x0400052B RID: 1323
		private bool CurrentExpires;

		// Token: 0x0400052C RID: 1324
		private decimal CurrentPrice;

		// Token: 0x0400052D RID: 1325
		private DataTable datCustomers;

		// Token: 0x0400052E RID: 1326
		private PublicFunctions pf;

		// Token: 0x0400052F RID: 1327
		private decimal CurrInvSum;

		// Token: 0x04000530 RID: 1328
		private int currentPayMeth;

		// Token: 0x04000531 RID: 1329
		private decimal currentRate;

		// Token: 0x04000532 RID: 1330
		private decimal CurrentQTY;

		// Token: 0x04000533 RID: 1331
		private StringReader stringToRead;

		// Token: 0x04000534 RID: 1332
		private DataTable datInvDetails;

		// Token: 0x04000535 RID: 1333
		private DataTable datPayDetails;

		// Token: 0x04000536 RID: 1334
		private DataTable datCustomerDetails;

		// Token: 0x04000537 RID: 1335
		private string TextToPrint;

		// Token: 0x04000538 RID: 1336
		private decimal tax_amount;

		// Token: 0x04000539 RID: 1337
		private decimal the_tax_amount;

		// Token: 0x0400053A RID: 1338
		private decimal sub_total;
	}
}
