using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x020001F4 RID: 500
	[DesignerGenerated]
	public partial class StockTakeCumulative : Form
	{
		// Token: 0x0600586F RID: 22639 RVA: 0x0032E9E0 File Offset: 0x0032CBE0
		public StockTakeCumulative()
		{
			base.Load += this.StockTakeCumulative_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.firstbalrun = false;
			this.InitializeComponent();
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x0033203B File Offset: 0x0033023B
		// (set) Token: 0x06005873 RID: 22643 RVA: 0x00332048 File Offset: 0x00330248
		internal virtual TabControl TabControl1
		{
			[CompilerGenerated]
			get
			{
				return this._TabControl1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabControl1_SelectedIndexChanged);
				TabControl tabControl = this._TabControl1;
				if (tabControl != null)
				{
					tabControl.SelectedIndexChanged -= eventHandler;
				}
				this._TabControl1 = value;
				tabControl = this._TabControl1;
				if (tabControl != null)
				{
					tabControl.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x0033208B File Offset: 0x0033028B
		// (set) Token: 0x06005875 RID: 22645 RVA: 0x00332095 File Offset: 0x00330295
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06005876 RID: 22646 RVA: 0x0033209E File Offset: 0x0033029E
		// (set) Token: 0x06005877 RID: 22647 RVA: 0x003320A8 File Offset: 0x003302A8
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06005878 RID: 22648 RVA: 0x003320B1 File Offset: 0x003302B1
		// (set) Token: 0x06005879 RID: 22649 RVA: 0x003320BC File Offset: 0x003302BC
		internal virtual DataGridView dgvStockTakes
		{
			[CompilerGenerated]
			get
			{
				return this._dgvStockTakes;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvStockTakes_CellContentClick);
				DataGridView dataGridView = this._dgvStockTakes;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvStockTakes = value;
				dataGridView = this._dgvStockTakes;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x003320FF File Offset: 0x003302FF
		// (set) Token: 0x0600587B RID: 22651 RVA: 0x00332109 File Offset: 0x00330309
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x0600587C RID: 22652 RVA: 0x00332112 File Offset: 0x00330312
		// (set) Token: 0x0600587D RID: 22653 RVA: 0x0033211C File Offset: 0x0033031C
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

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x0600587E RID: 22654 RVA: 0x0033215F File Offset: 0x0033035F
		// (set) Token: 0x0600587F RID: 22655 RVA: 0x00332169 File Offset: 0x00330369
		internal virtual TextBox txtref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06005880 RID: 22656 RVA: 0x00332172 File Offset: 0x00330372
		// (set) Token: 0x06005881 RID: 22657 RVA: 0x0033217C File Offset: 0x0033037C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06005882 RID: 22658 RVA: 0x00332185 File Offset: 0x00330385
		// (set) Token: 0x06005883 RID: 22659 RVA: 0x00332190 File Offset: 0x00330390
		internal virtual DataGridView dgvStockTakeItems
		{
			[CompilerGenerated]
			get
			{
				return this._dgvStockTakeItems;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvStockTakeItems_CellContentClick);
				DataGridView dataGridView = this._dgvStockTakeItems;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvStockTakeItems = value;
				dataGridView = this._dgvStockTakeItems;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06005884 RID: 22660 RVA: 0x003321D3 File Offset: 0x003303D3
		// (set) Token: 0x06005885 RID: 22661 RVA: 0x003321DD File Offset: 0x003303DD
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06005886 RID: 22662 RVA: 0x003321E6 File Offset: 0x003303E6
		// (set) Token: 0x06005887 RID: 22663 RVA: 0x003321F0 File Offset: 0x003303F0
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06005888 RID: 22664 RVA: 0x003321F9 File Offset: 0x003303F9
		// (set) Token: 0x06005889 RID: 22665 RVA: 0x00332203 File Offset: 0x00330403
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x0600588A RID: 22666 RVA: 0x0033220C File Offset: 0x0033040C
		// (set) Token: 0x0600588B RID: 22667 RVA: 0x00332216 File Offset: 0x00330416
		internal virtual TextBox txtDisplayCreatedBy
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x0600588C RID: 22668 RVA: 0x0033221F File Offset: 0x0033041F
		// (set) Token: 0x0600588D RID: 22669 RVA: 0x00332229 File Offset: 0x00330429
		internal virtual TextBox txtDisplayDateCreated
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x00332232 File Offset: 0x00330432
		// (set) Token: 0x0600588F RID: 22671 RVA: 0x0033223C File Offset: 0x0033043C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06005890 RID: 22672 RVA: 0x00332245 File Offset: 0x00330445
		// (set) Token: 0x06005891 RID: 22673 RVA: 0x0033224F File Offset: 0x0033044F
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x00332258 File Offset: 0x00330458
		// (set) Token: 0x06005893 RID: 22675 RVA: 0x00332262 File Offset: 0x00330462
		internal virtual TextBox txtDisplayRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x0033226B File Offset: 0x0033046B
		// (set) Token: 0x06005895 RID: 22677 RVA: 0x00332275 File Offset: 0x00330475
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06005896 RID: 22678 RVA: 0x0033227E File Offset: 0x0033047E
		// (set) Token: 0x06005897 RID: 22679 RVA: 0x00332288 File Offset: 0x00330488
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

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06005898 RID: 22680 RVA: 0x003322E6 File Offset: 0x003304E6
		// (set) Token: 0x06005899 RID: 22681 RVA: 0x003322F0 File Offset: 0x003304F0
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x003322F9 File Offset: 0x003304F9
		// (set) Token: 0x0600589B RID: 22683 RVA: 0x00332304 File Offset: 0x00330504
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

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x00332347 File Offset: 0x00330547
		// (set) Token: 0x0600589D RID: 22685 RVA: 0x00332351 File Offset: 0x00330551
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x0033235A File Offset: 0x0033055A
		// (set) Token: 0x0600589F RID: 22687 RVA: 0x00332364 File Offset: 0x00330564
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

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x003323A7 File Offset: 0x003305A7
		// (set) Token: 0x060058A1 RID: 22689 RVA: 0x003323B1 File Offset: 0x003305B1
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x060058A2 RID: 22690 RVA: 0x003323BA File Offset: 0x003305BA
		// (set) Token: 0x060058A3 RID: 22691 RVA: 0x003323C4 File Offset: 0x003305C4
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

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x060058A4 RID: 22692 RVA: 0x00332407 File Offset: 0x00330607
		// (set) Token: 0x060058A5 RID: 22693 RVA: 0x00332411 File Offset: 0x00330611
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x060058A6 RID: 22694 RVA: 0x0033241A File Offset: 0x0033061A
		// (set) Token: 0x060058A7 RID: 22695 RVA: 0x00332424 File Offset: 0x00330624
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

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x060058A8 RID: 22696 RVA: 0x00332467 File Offset: 0x00330667
		// (set) Token: 0x060058A9 RID: 22697 RVA: 0x00332471 File Offset: 0x00330671
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x060058AA RID: 22698 RVA: 0x0033247A File Offset: 0x0033067A
		// (set) Token: 0x060058AB RID: 22699 RVA: 0x00332484 File Offset: 0x00330684
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x060058AC RID: 22700 RVA: 0x0033248D File Offset: 0x0033068D
		// (set) Token: 0x060058AD RID: 22701 RVA: 0x00332497 File Offset: 0x00330697
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x003324A0 File Offset: 0x003306A0
		// (set) Token: 0x060058AF RID: 22703 RVA: 0x003324AA File Offset: 0x003306AA
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x060058B0 RID: 22704 RVA: 0x003324B3 File Offset: 0x003306B3
		// (set) Token: 0x060058B1 RID: 22705 RVA: 0x003324BD File Offset: 0x003306BD
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x060058B2 RID: 22706 RVA: 0x003324C6 File Offset: 0x003306C6
		// (set) Token: 0x060058B3 RID: 22707 RVA: 0x003324D0 File Offset: 0x003306D0
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x060058B4 RID: 22708 RVA: 0x003324D9 File Offset: 0x003306D9
		// (set) Token: 0x060058B5 RID: 22709 RVA: 0x003324E4 File Offset: 0x003306E4
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

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x00332542 File Offset: 0x00330742
		// (set) Token: 0x060058B7 RID: 22711 RVA: 0x0033254C File Offset: 0x0033074C
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x00332555 File Offset: 0x00330755
		// (set) Token: 0x060058B9 RID: 22713 RVA: 0x00332560 File Offset: 0x00330760
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

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x060058BA RID: 22714 RVA: 0x003325A3 File Offset: 0x003307A3
		// (set) Token: 0x060058BB RID: 22715 RVA: 0x003325AD File Offset: 0x003307AD
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x060058BC RID: 22716 RVA: 0x003325B6 File Offset: 0x003307B6
		// (set) Token: 0x060058BD RID: 22717 RVA: 0x003325C0 File Offset: 0x003307C0
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x003325C9 File Offset: 0x003307C9
		// (set) Token: 0x060058BF RID: 22719 RVA: 0x003325D3 File Offset: 0x003307D3
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x060058C0 RID: 22720 RVA: 0x003325DC File Offset: 0x003307DC
		// (set) Token: 0x060058C1 RID: 22721 RVA: 0x003325E6 File Offset: 0x003307E6
		internal virtual TextBox txtDisplayCreatedBy2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x003325EF File Offset: 0x003307EF
		// (set) Token: 0x060058C3 RID: 22723 RVA: 0x003325F9 File Offset: 0x003307F9
		internal virtual TextBox txtDisplayDateCreated2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x060058C4 RID: 22724 RVA: 0x00332602 File Offset: 0x00330802
		// (set) Token: 0x060058C5 RID: 22725 RVA: 0x0033260C File Offset: 0x0033080C
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x060058C6 RID: 22726 RVA: 0x00332615 File Offset: 0x00330815
		// (set) Token: 0x060058C7 RID: 22727 RVA: 0x0033261F File Offset: 0x0033081F
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x00332628 File Offset: 0x00330828
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x00332632 File Offset: 0x00330832
		internal virtual TextBox txtDisplayRef2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x0033263B File Offset: 0x0033083B
		// (set) Token: 0x060058CB RID: 22731 RVA: 0x00332645 File Offset: 0x00330845
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x0033264E File Offset: 0x0033084E
		// (set) Token: 0x060058CD RID: 22733 RVA: 0x00332658 File Offset: 0x00330858
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

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x0033269B File Offset: 0x0033089B
		// (set) Token: 0x060058CF RID: 22735 RVA: 0x003326A5 File Offset: 0x003308A5
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x003326AE File Offset: 0x003308AE
		// (set) Token: 0x060058D1 RID: 22737 RVA: 0x003326B8 File Offset: 0x003308B8
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x003326C1 File Offset: 0x003308C1
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x003326CB File Offset: 0x003308CB
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x060058D4 RID: 22740 RVA: 0x003326D4 File Offset: 0x003308D4
		// (set) Token: 0x060058D5 RID: 22741 RVA: 0x003326E0 File Offset: 0x003308E0
		internal virtual DataGridView dgvSearch2
		{
			[CompilerGenerated]
			get
			{
				return this._dgvSearch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvSearch2_CellEnter);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.dgvSearch2_KeyDown);
				DataGridView dataGridView = this._dgvSearch2;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._dgvSearch2 = value;
				dataGridView = this._dgvSearch2;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x060058D6 RID: 22742 RVA: 0x0033273E File Offset: 0x0033093E
		// (set) Token: 0x060058D7 RID: 22743 RVA: 0x00332748 File Offset: 0x00330948
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x060058D8 RID: 22744 RVA: 0x00332751 File Offset: 0x00330951
		// (set) Token: 0x060058D9 RID: 22745 RVA: 0x0033275C File Offset: 0x0033095C
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

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x0033279F File Offset: 0x0033099F
		// (set) Token: 0x060058DB RID: 22747 RVA: 0x003327A9 File Offset: 0x003309A9
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x060058DC RID: 22748 RVA: 0x003327B2 File Offset: 0x003309B2
		// (set) Token: 0x060058DD RID: 22749 RVA: 0x003327BC File Offset: 0x003309BC
		internal virtual TextBox txtsearch2
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch2_TextChanged);
				TextBox textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch2 = value;
				textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x003327FF File Offset: 0x003309FF
		// (set) Token: 0x060058DF RID: 22751 RVA: 0x0033280C File Offset: 0x00330A0C
		internal virtual TextBox txtSearchProductCode2
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCode2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode2_TextChanged);
				TextBox textBox = this._txtSearchProductCode2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode2 = value;
				textBox = this._txtSearchProductCode2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x0033284F File Offset: 0x00330A4F
		// (set) Token: 0x060058E1 RID: 22753 RVA: 0x00332859 File Offset: 0x00330A59
		internal virtual Label lblcode2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x00332862 File Offset: 0x00330A62
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x0033286C File Offset: 0x00330A6C
		internal virtual Label lblerror2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x00332875 File Offset: 0x00330A75
		// (set) Token: 0x060058E5 RID: 22757 RVA: 0x0033287F File Offset: 0x00330A7F
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x00332888 File Offset: 0x00330A88
		// (set) Token: 0x060058E7 RID: 22759 RVA: 0x00332892 File Offset: 0x00330A92
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x0033289B File Offset: 0x00330A9B
		// (set) Token: 0x060058E9 RID: 22761 RVA: 0x003328A8 File Offset: 0x00330AA8
		internal virtual TextBox txtBarCode2
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarCode2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox4_TextChanged);
				EventHandler eventHandler2 = new EventHandler(this.txtBarCode2_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBarCode2_KeyDown);
				TextBox textBox = this._txtBarCode2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.TextChanged -= eventHandler2;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtBarCode2 = value;
				textBox = this._txtBarCode2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.TextChanged += eventHandler2;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x060058EA RID: 22762 RVA: 0x00332921 File Offset: 0x00330B21
		// (set) Token: 0x060058EB RID: 22763 RVA: 0x0033292B File Offset: 0x00330B2B
		internal virtual GroupBox GroupBox7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x060058EC RID: 22764 RVA: 0x00332934 File Offset: 0x00330B34
		// (set) Token: 0x060058ED RID: 22765 RVA: 0x0033293E File Offset: 0x00330B3E
		internal virtual RadioButton RadioButton2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x00332947 File Offset: 0x00330B47
		// (set) Token: 0x060058EF RID: 22767 RVA: 0x00332951 File Offset: 0x00330B51
		internal virtual RadioButton RadioButton1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x060058F0 RID: 22768 RVA: 0x0033295A File Offset: 0x00330B5A
		// (set) Token: 0x060058F1 RID: 22769 RVA: 0x00332964 File Offset: 0x00330B64
		internal virtual Label lblDisplayTreatedAsZero2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x060058F2 RID: 22770 RVA: 0x0033296D File Offset: 0x00330B6D
		// (set) Token: 0x060058F3 RID: 22771 RVA: 0x00332977 File Offset: 0x00330B77
		internal virtual Label lblDisplayNotEnteredTreatedAs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x060058F4 RID: 22772 RVA: 0x00332980 File Offset: 0x00330B80
		// (set) Token: 0x060058F5 RID: 22773 RVA: 0x0033298A File Offset: 0x00330B8A
		internal virtual Label lblIsVoucher
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x060058F6 RID: 22774 RVA: 0x00332993 File Offset: 0x00330B93
		// (set) Token: 0x060058F7 RID: 22775 RVA: 0x0033299D File Offset: 0x00330B9D
		internal virtual TextBox txtDisplayEntryNo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x003329A6 File Offset: 0x00330BA6
		// (set) Token: 0x060058F9 RID: 22777 RVA: 0x003329B0 File Offset: 0x00330BB0
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x003329B9 File Offset: 0x00330BB9
		// (set) Token: 0x060058FB RID: 22779 RVA: 0x003329C3 File Offset: 0x00330BC3
		internal virtual TextBox txtDisplayEntryno2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x003329CC File Offset: 0x00330BCC
		// (set) Token: 0x060058FD RID: 22781 RVA: 0x003329D6 File Offset: 0x00330BD6
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x060058FE RID: 22782 RVA: 0x003329DF File Offset: 0x00330BDF
		// (set) Token: 0x060058FF RID: 22783 RVA: 0x003329EC File Offset: 0x00330BEC
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
				EventHandler eventHandler = new EventHandler(this.Button5_Click_1);
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

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06005900 RID: 22784 RVA: 0x00332A2F File Offset: 0x00330C2F
		// (set) Token: 0x06005901 RID: 22785 RVA: 0x00332A3C File Offset: 0x00330C3C
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

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06005902 RID: 22786 RVA: 0x00332A7F File Offset: 0x00330C7F
		// (set) Token: 0x06005903 RID: 22787 RVA: 0x00332A8C File Offset: 0x00330C8C
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

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06005904 RID: 22788 RVA: 0x00332ACF File Offset: 0x00330CCF
		// (set) Token: 0x06005905 RID: 22789 RVA: 0x00332ADC File Offset: 0x00330CDC
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

		// Token: 0x06005906 RID: 22790 RVA: 0x00332B20 File Offset: 0x00330D20
		private void StockTakeCumulative_Load(object sender, EventArgs e)
		{
			try
			{
				this.firstbalrun = this.pf.CheckIfFirstBalRun(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				bool flag = !this.firstbalrun;
				if (flag)
				{
					MessageBox.Show("Please run the normal stock take first to initialise. Form closing.");
					base.Dispose();
				}
				this.LoadStockTakes(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, 0);
				bool flag2 = MyProject.Forms.Form1.DateChange == 0;
				if (flag2)
				{
					this.DTdate.Enabled = false;
				}
				else
				{
					this.DTdate.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00332C18 File Offset: 0x00330E18
		private void CreateStockTake()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
			try
			{
				sqlCommand.Parameters.Clear();
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertStockTakeCumHeader";
				sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
				sqlCommand.Parameters.AddWithValue("timecreated", DateTime.Now.ToString("HH:mm"));
				sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
				sqlCommand.Parameters.AddWithValue("ref", this.txtref.Text);
				sqlCommand.Parameters.AddWithValue("datecreated", DateTime.Today);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				bool @checked = this.RadioButton1.Checked;
				if (@checked)
				{
					sqlCommand.Parameters.AddWithValue("istreatedaszero", 1);
				}
				else
				{
					bool checked2 = this.RadioButton2.Checked;
					if (checked2)
					{
						sqlCommand.Parameters.AddWithValue("istreatedaszero", 0);
					}
				}
				sqlCommand.Parameters.AddWithValue("new_id", this.newID);
				this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				try
				{
					foreach (object obj in MyProject.Forms.Form1.datSelectedCategories.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "InsertSelectedCategory";
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("catid", RuntimeHelpers.GetObjectValue(dataRow["Category"]));
						sqlCommand.Parameters.AddWithValue("refdesc", this.txtref.Text);
						sqlCommand.Parameters.AddWithValue("refentryno", this.newID);
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
			catch (Exception ex)
			{
				MessageBox.Show("Error saving. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00332F58 File Offset: 0x00331158
		private void InsertStockTakeItem(string @ref, int productid, decimal qty)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertStockTakeCumItems";
			sqlCommand.Parameters.AddWithValue("stocktakeref", @ref);
			sqlCommand.Parameters.AddWithValue("donetime", DateTime.Now.ToString("HH:mm"));
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("qty", qty);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x003330BC File Offset: 0x003312BC
		private void DeleteStockTakeItem(int entryno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteStockTakeCumItem";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x00333184 File Offset: 0x00331384
		private void DeleteStockHeader(string @ref)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteStockTakeCumHeader ";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00333248 File Offset: 0x00331448
		private void LoadStockTakes(int coid, string branch, int forall)
		{
			this.dgvStockTakes.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetStockTakeCumHeaders";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			bool flag = forall == 1;
			if (flag)
			{
				sqlCommand.Parameters.AddWithValue("all", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("all", 0);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvStockTakes.DataSource = dataTable;
			this.dgvStockTakes.Columns["Entryno"].Visible = false;
			this.dgvStockTakes.Columns["branch"].Visible = false;
			this.dgvStockTakes.Columns["coid"].Visible = false;
			this.dgvStockTakes.Columns["DateCreatedSystem"].Visible = false;
			this.dgvStockTakes.Columns["MachineName"].Visible = false;
			this.dgvStockTakes.Columns["IsNotEnteredTreatedAsZeros"].HeaderText = "Will Products Not Entered be treated as ZEROs?";
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Enter Stock Take Figures";
			dataGridViewButtonColumn.Text = "Enter";
			dataGridViewButtonColumn.Name = "Enter";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvStockTakes.Columns.Add(dataGridViewButtonColumn);
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn2.HeaderText = "View Selected Categories";
			dataGridViewButtonColumn2.Text = "View";
			dataGridViewButtonColumn2.Name = "View";
			dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
			this.dgvStockTakes.Columns.Add(dataGridViewButtonColumn2);
			DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn3.HeaderText = "Delete";
			dataGridViewButtonColumn3.Text = "Delete";
			dataGridViewButtonColumn3.Name = "Delete";
			dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
			this.dgvStockTakes.Columns.Add(dataGridViewButtonColumn3);
			this.dgvStockTakes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x003334B0 File Offset: 0x003316B0
		private void LoadStockTakeItems(int coid, string branch, string @ref)
		{
			this.dgvStockTakeItems.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetStockTakeCumItems";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("stocktakeref", @ref);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvStockTakeItems.DataSource = dataTable;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Entry";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvStockTakeItems.Columns.Add(dataGridViewButtonColumn);
			this.dgvStockTakeItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x003335AC File Offset: 0x003317AC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtref.Text, "", false) != 0;
				if (flag)
				{
					bool flag2 = this.RadioButton1.Checked | this.RadioButton2.Checked;
					if (flag2)
					{
						DataTable dataTable = new DataTable();
						MyProject.Forms.Form1.datSelectedCategories = dataTable;
						SelectCategories selectCategories = new SelectCategories();
						selectCategories.ShowDialog(this);
						selectCategories.Dispose();
						bool flag3 = MyProject.Forms.Form1.datSelectedCategories.Rows.Count > 0;
						if (flag3)
						{
							this.CreateStockTake();
							this.LoadStockTakes(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, 0);
							MessageBox.Show("Stock Take created successfully.");
							this.txtref.Text = "";
						}
						else
						{
							MessageBox.Show("no categories selected. Cannot proceed.");
						}
					}
					else
					{
						MessageBox.Show("Please select how products that are not entered will be treated first.");
					}
				}
				else
				{
					MessageBox.Show("Please enter the stock take ref details first. ");
					this.txtref.Focus();
				}
			}
			catch (SqlException ex)
			{
				bool flag4 = ex.Number == 2627;
				if (flag4)
				{
					MessageBox.Show("Please use a unique reference for each stock take take.");
					this.txtref.Focus();
				}
				else
				{
					MessageBox.Show("Database error. Detail: " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error creating stock take header detail. Detail: " + ex2.Message);
			}
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x00333780 File Offset: 0x00331980
		private void dgvStockTakes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Enter", false) == 0;
					if (flag2)
					{
						string text = Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["Ref"].Value);
						this.txtDisplayRef.Text = text;
						this.txtDisplayRef2.Text = text;
						int num = Conversions.ToInteger(this.dgvStockTakes.Rows[e.RowIndex].Cells["entryno"].Value);
						this.txtDisplayEntryNo.Text = num.ToString();
						this.txtDisplayEntryno2.Text = num.ToString();
						this.txtDisplayCreatedBy.Text = Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["CreatedBy"].Value);
						this.txtDisplayCreatedBy2.Text = Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["CreatedBy"].Value);
						this.txtDisplayDateCreated.Text = Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["DateCreated"].Value);
						this.txtDisplayDateCreated2.Text = Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["DateCreated"].Value);
						bool flag3 = Operators.ConditionalCompareObjectEqual(this.dgvStockTakes.Rows[e.RowIndex].Cells["IsNotEnteredTreatedAsZeros"].Value, true, false);
						if (flag3)
						{
							this.lblDisplayNotEnteredTreatedAs.Text = "Products not entered/counted will be treated as ZEROs";
							this.lblDisplayTreatedAsZero2.Text = "Products not entered/counted will be treated as ZEROs";
							this.IsZeros = 1;
						}
						else
						{
							bool flag4 = Operators.ConditionalCompareObjectEqual(this.dgvStockTakes.Rows[e.RowIndex].Cells["IsNotEnteredTreatedAsZeros"].Value, false, false);
							if (flag4)
							{
								this.lblDisplayNotEnteredTreatedAs.Text = "Products not entered/counted will be given current system balances";
								this.lblDisplayTreatedAsZero2.Text = "Products not entered/counted will be given current system balances";
								this.IsZeros = 0;
							}
						}
						this.LoadStockTakeItems(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtDisplayRef.Text);
						this.TabControl1.SelectedIndex = 1;
					}
					else
					{
						bool flag5 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
						if (flag5)
						{
							ViewSelectedCategories viewSelectedCategories = new ViewSelectedCategories();
							viewSelectedCategories.refdesc = Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["Ref"].Value);
							viewSelectedCategories.refentryno = Conversions.ToInteger(this.dgvStockTakes.Rows[e.RowIndex].Cells["entryno"].Value);
							viewSelectedCategories.createdby = Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["CreatedBy"].Value);
							viewSelectedCategories.createddate = Conversions.ToDate(this.dgvStockTakes.Rows[e.RowIndex].Cells["DateCreated"].Value);
							bool flag6 = Operators.ConditionalCompareObjectEqual(this.dgvStockTakes.Rows[e.RowIndex].Cells["IsNotEnteredTreatedAsZeros"].Value, true, false);
							if (flag6)
							{
								viewSelectedCategories.display_note = "Products not entered/counted will be treated as ZEROs";
							}
							else
							{
								bool flag7 = Operators.ConditionalCompareObjectEqual(this.dgvStockTakes.Rows[e.RowIndex].Cells["IsNotEnteredTreatedAsZeros"].Value, false, false);
								if (flag7)
								{
									viewSelectedCategories.display_note = "Products not entered/counted will be given current system balances";
								}
							}
							viewSelectedCategories.ShowDialog(this);
							viewSelectedCategories.Dispose();
						}
						else
						{
							bool flag8 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
							if (flag8)
							{
								bool flag9 = Operators.ConditionalCompareObjectEqual(this.dgvStockTakes.Rows[e.RowIndex].Cells["IsComplete"].Value, 0, false);
								if (flag9)
								{
									DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to Delete this Stock Take?", MsgBoxStyle.YesNo, null);
									bool flag10 = dialogResult == DialogResult.Yes;
									if (flag10)
									{
										this.DeleteStockHeader(Conversions.ToString(this.dgvStockTakes.Rows[e.RowIndex].Cells["ref"].Value));
										this.LoadStockTakes(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, 0);
										MessageBox.Show("Stock Take Deleted.");
									}
								}
								else
								{
									MessageBox.Show("Cannot delete a stock take that is complete.");
								}
							}
							else
							{
								bool flag11 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "report", false) == 0;
								if (flag11)
								{
									StockAdjustmentsReportCum stockAdjustmentsReportCum = new StockAdjustmentsReportCum();
									stockAdjustmentsReportCum.ShowDialog(this);
									base.Dispose();
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x00333DD0 File Offset: 0x00331FD0
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

		// Token: 0x06005910 RID: 22800 RVA: 0x00333E58 File Offset: 0x00332058
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

		// Token: 0x06005911 RID: 22801 RVA: 0x00333F50 File Offset: 0x00332150
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

		// Token: 0x06005912 RID: 22802 RVA: 0x0033405C File Offset: 0x0033225C
		private object searchDat(DataTable dt, string column, string value)
		{
			StockTakeCumulative._Closure$__321-0 CS$<>8__locals1 = new StockTakeCumulative._Closure$__321-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((StockTakeCumulative._Closure$__.$I321-0 == null) ? (StockTakeCumulative._Closure$__.$I321-0 = (object row1) => (DataRow)row1) : StockTakeCumulative._Closure$__.$I321-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06005913 RID: 22803 RVA: 0x00334138 File Offset: 0x00332338
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("cats", 1);
			sqlCommand.Parameters.AddWithValue("refentryno", Conversions.ToInteger(this.txtDisplayEntryNo.Text));
			sqlCommand.Parameters.AddWithValue("refdesc", this.txtDisplayRef.Text);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x0033423C File Offset: 0x0033243C
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("cats", 1);
			sqlCommand.Parameters.AddWithValue("refentryno", Conversions.ToInteger(this.txtDisplayEntryNo.Text));
			sqlCommand.Parameters.AddWithValue("refdesc", this.txtDisplayRef.Text);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
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

		// Token: 0x06005915 RID: 22805 RVA: 0x00334490 File Offset: 0x00332690
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

		// Token: 0x06005916 RID: 22806 RVA: 0x003344F0 File Offset: 0x003326F0
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

		// Token: 0x06005917 RID: 22807 RVA: 0x003345B4 File Offset: 0x003327B4
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

		// Token: 0x06005918 RID: 22808 RVA: 0x00334614 File Offset: 0x00332814
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching by bar code. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00334698 File Offset: 0x00332898
		private void SearchBarCode(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("cats", 1);
			sqlCommand.Parameters.AddWithValue("refentryno", Conversions.ToInteger(this.txtDisplayEntryNo.Text));
			sqlCommand.Parameters.AddWithValue("refdesc", this.txtDisplayRef.Text);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentDesc = Conversions.ToString(dataRow["ProductDesc"]);
				this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
				bool currentIsVoucher = this.CurrentIsVoucher;
				if (currentIsVoucher)
				{
					this.txtQty.Enabled = false;
					this.lblIsVoucher.Visible = true;
				}
				else
				{
					this.txtQty.Enabled = true;
					this.lblIsVoucher.Visible = false;
				}
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x003348E8 File Offset: 0x00332AE8
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
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentDesc = Conversions.ToString(dataRow["ProductDesc"]);
				this.CurrentIsVoucher = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])), false, RuntimeHelpers.GetObjectValue(dataRow["IsVoucher"])));
				bool currentIsVoucher = this.CurrentIsVoucher;
				if (currentIsVoucher)
				{
					this.txtQty.Enabled = false;
					this.lblIsVoucher.Visible = true;
				}
				else
				{
					this.txtQty.Enabled = true;
					this.lblIsVoucher.Visible = false;
				}
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00334ABC File Offset: 0x00332CBC
		private decimal GetStockAvailable(int productid)
		{
			decimal num = 0m;
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
					num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0m;
				}
				sqlConnection.Close();
			}
			decimal num3 = 0m;
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
					num3 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2[0])), 0, RuntimeHelpers.GetObjectValue(dataRow2[0])));
				}
				else
				{
					num3 = 0m;
				}
				sqlConnection3.Close();
			}
			return decimal.Subtract(num, num3);
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00334D3C File Offset: 0x00332F3C
		private void Record()
		{
			bool flag = (this.CurrentID != 0) & (Operators.CompareString(this.txtQty.Text, "", false) != 0);
			if (flag)
			{
				this.InsertStockTakeItem(this.txtDisplayRef.Text, this.CurrentID, Convert.ToDecimal(this.txtQty.Text));
				this.LoadStockTakeItems(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtDisplayRef.Text);
				MessageBox.Show("Product count recorded successfully.");
				bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag2)
				{
					this.txtsearch.Text = "";
					this.txtsearch.Focus();
				}
				else
				{
					this.txtBarCode.Text = "";
					this.txtBarCode.Focus();
				}
				this.txtSearchProductCode2.Text = "";
				this.txtQty.Text = "";
				this.CurrentID = 0;
				this.CurrentDesc = "";
				this.CurrentCode = "";
				this.txtDesc.Text = "";
			}
			else
			{
				MessageBox.Show("Please select the product and enter the physical count first.");
			}
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00334E8C File Offset: 0x0033308C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.Record();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error recording. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x00334EDC File Offset: 0x003330DC
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x00334F28 File Offset: 0x00333128
		private void dgvStockTakeItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						int num = Conversions.ToInteger(this.dgvStockTakeItems.Rows[e.RowIndex].Cells["Entryno"].Value);
						this.DeleteStockTakeItem(num);
						this.LoadStockTakeItems(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtDisplayRef.Text);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error with stock take item. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x0033503C File Offset: 0x0033323C
		private void LoadStock2()
		{
			this.DataGridView1.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllProductBals2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("cats", 1);
			sqlCommand.Parameters.AddWithValue("refentryno", Conversions.ToInteger(this.txtDisplayEntryno2.Text));
			sqlCommand.Parameters.AddWithValue("refdesc", this.txtDisplayRef2.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.Columns["ProductID"].Visible = false;
				this.DataGridView1.Columns["ProductCode"].ReadOnly = true;
				this.DataGridView1.Columns["ProductDesc"].ReadOnly = true;
				this.DataGridView1.Columns["StockBalance"].ReadOnly = true;
				this.DataGridView1.Columns.Add("PhysicalCount", "Physical Stock Count");
				this.DataGridView1.Columns["PhysicalCount"].ReadOnly = true;
				this.DataGridView1.Columns.Add("Detail", "Reason for Variance");
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DataGridView1.Columns["ProductCode"].HeaderText = "Product Code";
				this.DataGridView1.Columns["ProductCode"].DefaultCellStyle.BackColor = Color.LightGray;
				this.DataGridView1.Columns["ProductDesc"].HeaderText = "Description";
				this.DataGridView1.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.LightGray;
				this.DataGridView1.Columns["StockBalance"].HeaderText = "Stock Balance";
				this.DataGridView1.Columns["StockBalance"].DefaultCellStyle.BackColor = Color.LightGray;
				this.DataGridView1.Columns["StockBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				this.CopyBals();
			}
			else
			{
				MessageBox.Show("There are no products.");
			}
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x0033532C File Offset: 0x0033352C
		private void CopyBals()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					int productEnteredCount = this.GetProductEnteredCount(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtDisplayRef2.Text, Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value));
					bool flag = this.IsZeros == 0;
					if (flag)
					{
						bool flag2 = productEnteredCount == 0;
						if (flag2)
						{
							dataGridViewRow.Cells["PhysicalCount"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value);
						}
						else
						{
							dataGridViewRow.Cells["PhysicalCount"].Value = this.GetPhysicalCount(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtDisplayRef2.Text, Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value));
						}
					}
					else
					{
						bool flag3 = this.IsZeros == 1;
						if (flag3)
						{
							bool flag4 = productEnteredCount == 0;
							if (flag4)
							{
								dataGridViewRow.Cells["PhysicalCount"].Value = 0;
							}
							else
							{
								dataGridViewRow.Cells["PhysicalCount"].Value = this.GetPhysicalCount(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtDisplayRef2.Text, Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value));
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

		// Token: 0x06005922 RID: 22818 RVA: 0x00335544 File Offset: 0x00333744
		private int GetProductEnteredCount(int coid, string branch, string @ref, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CountStockTakeCumItemsEnteredForProduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlDataAdapter.Fill(dataTable);
				sqlConnection.Close();
			}
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToInteger(dataRow["entered_count"]);
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x00335654 File Offset: 0x00333854
		private decimal GetPhysicalCount(int coid, string branch, string @ref, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetStockTakeCumItemsSumForProduct ";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlDataAdapter.Fill(dataTable);
				sqlConnection.Close();
			}
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["qty"]);
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00335764 File Offset: 0x00333964
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock take figures entered. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x003357AC File Offset: 0x003339AC
		private void Button4_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you have entered the correct Physical Stock count figures and want to adjust stock?", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txtDisplayRef2.Text, "", false) != 0;
				if (flag2)
				{
					this.Cursor = Cursors.WaitCursor;
					this.AdjustStock();
					this.Cursor = Cursors.Default;
				}
				else
				{
					MessageBox.Show("Please select the stock take iteration first.");
				}
			}
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00335820 File Offset: 0x00333A20
		private void AdjustStock()
		{
			this.ProgressBar1.Visible = true;
			this.ProgressBar1.BringToFront();
			this.ProgressBar1.Minimum = 1;
			this.ProgressBar1.Maximum = 3;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.PerformStep();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunStockTake");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				int nextInvNumStockTake = this.pf.GetNextInvNumStockTake(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				this.ProgressBar1.PerformStep();
				int num = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						decimal num2 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)));
						decimal num3 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PhysicalCount"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PhysicalCount"].Value)))));
						bool flag = decimal.Compare(num2, num3) == 0;
						if (!flag)
						{
							bool flag2 = decimal.Compare(num2, num3) > 0;
							if (flag2)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewSaleStockTake";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
								sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num2, num3));
								sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), this._cnn)));
								sqlCommand.Parameters.AddWithValue("salesprice", 0);
								sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 2);
								sqlCommand.Parameters.AddWithValue("TranTime", num);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								bool flag3 = dataGridViewRow.Cells[7].Value == null;
								string text;
								if (flag3)
								{
									text = "";
								}
								else
								{
									text = dataGridViewRow.Cells[7].Value.ToString();
								}
								sqlCommand.Parameters.AddWithValue("details", text);
								sqlCommand.Parameters.AddWithValue("stockbal", num2);
								sqlCommand.Parameters.AddWithValue("trandesc", this.txtDisplayRef2.Text);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.ExecuteNonQuery();
							}
							else
							{
								bool flag4 = decimal.Compare(num2, num3) < 0;
								if (flag4)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertNewStockStockTake";
									sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
									sqlCommand.Parameters.AddWithValue("isstockin", 1);
									sqlCommand.Parameters.AddWithValue("ref", "STOCK INCREASED");
									sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num3, num2));
									sqlCommand.Parameters.AddWithValue("cost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), this._cnn)));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("trancode", 2);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									bool flag5 = dataGridViewRow.Cells[7].Value == null;
									string text2;
									if (flag5)
									{
										text2 = "";
									}
									else
									{
										text2 = dataGridViewRow.Cells[7].Value.ToString();
									}
									sqlCommand.Parameters.AddWithValue("details", text2);
									sqlCommand.Parameters.AddWithValue("stockbal", num2);
									sqlCommand.Parameters.AddWithValue("trandesc", this.txtDisplayRef2.Text);
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
									sqlCommand.ExecuteNonQuery();
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
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "UpdateStockTakeCumHeader";
				sqlCommand.Parameters.AddWithValue("ref", this.txtDisplayRef2.Text);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				sqlCommand.ExecuteNonQuery();
				sqlTransaction.Commit();
				sqlCommand.Connection.Close();
				this.ProgressBar1.PerformStep();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Stock adjusted successfully. To view adjustments made please go to the reports.");
				this.LoadStock2();
			}
			catch (Exception ex)
			{
				sqlTransaction.Rollback();
				sqlCommand.Connection.Close();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Error occured adjusting stock. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00336090 File Offset: 0x00334290
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtQty.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00336158 File Offset: 0x00334358
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts2();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x003361B8 File Offset: 0x003343B8
		private void dgvSearch2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.dgvSearch2.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtSearchProductCode2.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror2.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00336278 File Offset: 0x00334478
		private void dgvSearch2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TextBox4_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x003362CC File Offset: 0x003344CC
		private void FetchAllProducts2()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("cats", 1);
			sqlCommand.Parameters.AddWithValue("refentryno", Conversions.ToInteger(this.txtDisplayEntryno2.Text));
			sqlCommand.Parameters.AddWithValue("refdesc", this.txtDisplayRef2.Text);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvSearch2.DataSource = dataTable;
				this.dgvSearch2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvSearch2.Columns["CatDesc"].Visible = false;
				this.dgvSearch2.Columns["Reorder_Level"].Visible = false;
				this.dgvSearch2.Columns["Unit_Selling_Price"].Visible = false;
				this.dgvSearch2.Columns["Unit_Cost"].Visible = false;
				this.dgvSearch2.Columns["ProductID"].Visible = false;
				this.dgvSearch2.Columns["ProductCode"].Visible = false;
				this.dgvSearch2.Columns["Tax_Percentage"].Visible = false;
				this.dgvSearch2.Columns["Bin_Location"].Visible = false;
				this.dgvSearch2.Columns["Unit_of_Measure"].Visible = false;
				this.dgvSearch2.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror2.Text = "No products match your search.";
			}
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00336520 File Offset: 0x00334720
		private void txtsearch2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced2(this.txtsearch2.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x003365A8 File Offset: 0x003347A8
		private void txtSearchProductCode2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtSearchProductCode2.Text, false);
						if (flag)
						{
							this.DataGridView1.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.DataGridView1.CurrentCell = dataGridViewRow.Cells["ProductCode"];
							break;
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
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00336698 File Offset: 0x00334898
		private void txtBarCode2_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x003366CC File Offset: 0x003348CC
		private void txtBarCode2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.Cursor = Cursors.WaitCursor;
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtBarCode2.Text, false);
							if (flag2)
							{
								this.DataGridView1.ClearSelection();
								dataGridViewRow.Cells["ProductCode"].Selected = true;
								this.DataGridView1.CurrentCell = dataGridViewRow.Cells["ProductCode"];
								this.Cursor = Cursors.Default;
								break;
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
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x00336804 File Offset: 0x00334A04
		private void SearchByDescAdvanced2(string searchtext)
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
					this.dgvSearch2.DataSource = dataTable;
					this.dgvSearch2.Columns["ProductCode"].Visible = false;
					this.dgvSearch2.Columns["ProductID"].Visible = false;
					this.dgvSearch2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					this.lblerror2.Text = "No products match your search.";
				}
			}
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00336910 File Offset: 0x00334B10
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag4;
			try
			{
				bool flag = msg.WParam.ToInt32() == 112;
				if (flag)
				{
					bool flag2 = this.TabControl1.SelectedTab.TabIndex == 1;
					if (flag2)
					{
						this.txtBarCode.Focus();
					}
					else
					{
						bool flag3 = this.TabControl1.SelectedTab.TabIndex == 2;
						if (flag3)
						{
							this.txtBarCode2.Focus();
						}
					}
				}
				flag4 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag4;
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x003369B0 File Offset: 0x00334BB0
		private void txtQty_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.Record();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error after press enter. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00336A10 File Offset: 0x00334C10
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.TabControl1.SelectedIndex == 2;
				if (flag)
				{
					this.Cursor = Cursors.WaitCursor;
					this.LoadStock2();
					this.Cursor = Cursors.Default;
					bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag2)
					{
						this.txtsearch2.Text = "";
						this.txtsearch2.Focus();
					}
					else
					{
						this.txtBarCode2.Text = "";
						this.txtBarCode2.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Selected Tab Control Index changed error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00336AE0 File Offset: 0x00334CE0
		private void Button5_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.LoadStockTakes(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, 1);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying data. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00336B50 File Offset: 0x00334D50
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				StockAdjustmentsReportCum stockAdjustmentsReportCum = new StockAdjustmentsReportCum();
				stockAdjustmentsReportCum.ShowDialog(this);
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x00336BAC File Offset: 0x00334DAC
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				this.TabControl1.SelectedIndex = 2;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying tab. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x00336C00 File Offset: 0x00334E00
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want record all current stock balances for this cummulative stock take?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					DataGridView dataGridView = new DataGridView();
					dataGridView.Visible = false;
					PublicFunctions publicFunctions = new PublicFunctions();
					DataTable allProductsList = publicFunctions.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
					decimal num = 0m;
					try
					{
						foreach (object obj in allProductsList.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							num = publicFunctions.GetStockAvailable(this._cnn, Conversions.ToInteger(dataRow["ProductID"]), dataGridView, Conversions.ToString(dataRow["UOM"]), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false);
							this.InsertStockTakeItem(this.txtDisplayRef.Text, Conversions.ToInteger(dataRow["ProductID"]), num);
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
					this.LoadStockTakeItems(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.txtDisplayRef.Text);
					MessageBox.Show("Current Stock Balances added to this cummulative stock take.");
				}
				else
				{
					MessageBox.Show("No product balance added to current cummulative stock take.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x040026E5 RID: 9957
		private string _cnn;

		// Token: 0x040026E6 RID: 9958
		private int CurrentID;

		// Token: 0x040026E7 RID: 9959
		private string CurrentCode;

		// Token: 0x040026E8 RID: 9960
		private string CurrentDesc;

		// Token: 0x040026E9 RID: 9961
		private bool CurrentIsVoucher;

		// Token: 0x040026EA RID: 9962
		private PublicFunctions pf;

		// Token: 0x040026EB RID: 9963
		private int IsZeros;

		// Token: 0x040026EC RID: 9964
		private int newID;

		// Token: 0x040026ED RID: 9965
		private bool firstbalrun;
	}
}
