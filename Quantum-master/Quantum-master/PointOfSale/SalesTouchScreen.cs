using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using EltradeFPAx;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.My.Resources;

namespace PointOfSale
{
	// Token: 0x020001B3 RID: 435
	[DesignerGenerated]
	public partial class SalesTouchScreen : UserControl
	{
		// Token: 0x06004DD9 RID: 19929 RVA: 0x002E01E4 File Offset: 0x002DE3E4
		public SalesTouchScreen()
		{
			base.Load += this.SalesTouchScreen_Load;
			base.Disposed += this.SalesTouchScreen_Disposed;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.wholesaleQty = 0m;
			this.isunendingstock = 0;
			this.pf = new PublicFunctions();
			this.currentIsWeighed = false;
			this.currentTable = 0;
			this.currentTablePendingInvEntryNo = 0;
			this.discTeller = 0m;
			this.discCoupons = 0m;
			this.discPromotion = 0m;
			this.discPromotionName = "";
			this.discDESC = "";
			this.datProm = new DataTable();
			this.TextToPrint = "";
			this.RowID = 0;
			this.sScale = new clsScale();
			this.items_saved = true;
			this.@ref = "";
			this.currBreak = 0;
			this.isunedingstock = false;
			this.currParentCaseID = 0;
			this.currCaseQty = 0;
			this.BreakQtyActual = 0;
			this.currentIsDeposit = 0;
			this.current_taxexempt = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06004DDC RID: 19932 RVA: 0x002E4A65 File Offset: 0x002E2C65
		// (set) Token: 0x06004DDD RID: 19933 RVA: 0x002E4A6F File Offset: 0x002E2C6F
		internal virtual Panel PanelCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06004DDE RID: 19934 RVA: 0x002E4A78 File Offset: 0x002E2C78
		// (set) Token: 0x06004DDF RID: 19935 RVA: 0x002E4A82 File Offset: 0x002E2C82
		internal virtual Panel PanelProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x002E4A8B File Offset: 0x002E2C8B
		// (set) Token: 0x06004DE1 RID: 19937 RVA: 0x002E4A95 File Offset: 0x002E2C95
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06004DE2 RID: 19938 RVA: 0x002E4A9E File Offset: 0x002E2C9E
		// (set) Token: 0x06004DE3 RID: 19939 RVA: 0x002E4AA8 File Offset: 0x002E2CA8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06004DE4 RID: 19940 RVA: 0x002E4AB1 File Offset: 0x002E2CB1
		// (set) Token: 0x06004DE5 RID: 19941 RVA: 0x002E4ABC File Offset: 0x002E2CBC
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

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06004DE6 RID: 19942 RVA: 0x002E4AFF File Offset: 0x002E2CFF
		// (set) Token: 0x06004DE7 RID: 19943 RVA: 0x002E4B0C File Offset: 0x002E2D0C
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

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06004DE8 RID: 19944 RVA: 0x002E4B4F File Offset: 0x002E2D4F
		// (set) Token: 0x06004DE9 RID: 19945 RVA: 0x002E4B59 File Offset: 0x002E2D59
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06004DEA RID: 19946 RVA: 0x002E4B62 File Offset: 0x002E2D62
		// (set) Token: 0x06004DEB RID: 19947 RVA: 0x002E4B6C File Offset: 0x002E2D6C
		internal virtual Label lbldesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06004DEC RID: 19948 RVA: 0x002E4B75 File Offset: 0x002E2D75
		// (set) Token: 0x06004DED RID: 19949 RVA: 0x002E4B80 File Offset: 0x002E2D80
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

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06004DEE RID: 19950 RVA: 0x002E4BC3 File Offset: 0x002E2DC3
		// (set) Token: 0x06004DEF RID: 19951 RVA: 0x002E4BD0 File Offset: 0x002E2DD0
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
				EventHandler eventHandler = new EventHandler(this.txtQty_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtQty_KeyDown);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQty_KeyPress);
				TextBox textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQty = value;
				textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x002E4C49 File Offset: 0x002E2E49
		// (set) Token: 0x06004DF1 RID: 19953 RVA: 0x002E4C54 File Offset: 0x002E2E54
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

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x002E4C97 File Offset: 0x002E2E97
		// (set) Token: 0x06004DF3 RID: 19955 RVA: 0x002E4CA4 File Offset: 0x002E2EA4
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

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x002E4CE7 File Offset: 0x002E2EE7
		// (set) Token: 0x06004DF5 RID: 19957 RVA: 0x002E4CF1 File Offset: 0x002E2EF1
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x002E4CFA File Offset: 0x002E2EFA
		// (set) Token: 0x06004DF7 RID: 19959 RVA: 0x002E4D04 File Offset: 0x002E2F04
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
				EventHandler eventHandler = new EventHandler(this.txtPrice_TextChanged);
				TextBox textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtPrice = value;
				textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x002E4D47 File Offset: 0x002E2F47
		// (set) Token: 0x06004DF9 RID: 19961 RVA: 0x002E4D51 File Offset: 0x002E2F51
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06004DFA RID: 19962 RVA: 0x002E4D5A File Offset: 0x002E2F5A
		// (set) Token: 0x06004DFB RID: 19963 RVA: 0x002E4D64 File Offset: 0x002E2F64
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06004DFC RID: 19964 RVA: 0x002E4D6D File Offset: 0x002E2F6D
		// (set) Token: 0x06004DFD RID: 19965 RVA: 0x002E4D77 File Offset: 0x002E2F77
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06004DFE RID: 19966 RVA: 0x002E4D80 File Offset: 0x002E2F80
		// (set) Token: 0x06004DFF RID: 19967 RVA: 0x002E4D8A File Offset: 0x002E2F8A
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06004E00 RID: 19968 RVA: 0x002E4D93 File Offset: 0x002E2F93
		// (set) Token: 0x06004E01 RID: 19969 RVA: 0x002E4DA0 File Offset: 0x002E2FA0
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
				DataGridViewRowEventHandler dataGridViewRowEventHandler = new DataGridViewRowEventHandler(this.DataGridView1_UserDeletedRow);
				DataGridViewRowCancelEventHandler dataGridViewRowCancelEventHandler = new DataGridViewRowCancelEventHandler(this.DataGridView1_UserDeletingRow);
				EventHandler eventHandler = new EventHandler(this.DataGridView1_SelectionChanged);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
					dataGridView.UserDeletedRow -= dataGridViewRowEventHandler;
					dataGridView.UserDeletingRow -= dataGridViewRowCancelEventHandler;
					dataGridView.SelectionChanged -= eventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
					dataGridView.UserDeletedRow += dataGridViewRowEventHandler;
					dataGridView.UserDeletingRow += dataGridViewRowCancelEventHandler;
					dataGridView.SelectionChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06004E02 RID: 19970 RVA: 0x002E4E40 File Offset: 0x002E3040
		// (set) Token: 0x06004E03 RID: 19971 RVA: 0x002E4E4A File Offset: 0x002E304A
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x002E4E53 File Offset: 0x002E3053
		// (set) Token: 0x06004E05 RID: 19973 RVA: 0x002E4E5D File Offset: 0x002E305D
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x002E4E66 File Offset: 0x002E3066
		// (set) Token: 0x06004E07 RID: 19975 RVA: 0x002E4E70 File Offset: 0x002E3070
		internal virtual Label lblcategory
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x002E4E79 File Offset: 0x002E3079
		// (set) Token: 0x06004E09 RID: 19977 RVA: 0x002E4E83 File Offset: 0x002E3083
		internal virtual TextBox txtOldprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06004E0A RID: 19978 RVA: 0x002E4E8C File Offset: 0x002E308C
		// (set) Token: 0x06004E0B RID: 19979 RVA: 0x002E4E96 File Offset: 0x002E3096
		internal virtual TextBox txtCoupons
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06004E0C RID: 19980 RVA: 0x002E4E9F File Offset: 0x002E309F
		// (set) Token: 0x06004E0D RID: 19981 RVA: 0x002E4EA9 File Offset: 0x002E30A9
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x002E4EB2 File Offset: 0x002E30B2
		// (set) Token: 0x06004E0F RID: 19983 RVA: 0x002E4EBC File Offset: 0x002E30BC
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06004E10 RID: 19984 RVA: 0x002E4EC5 File Offset: 0x002E30C5
		// (set) Token: 0x06004E11 RID: 19985 RVA: 0x002E4ED0 File Offset: 0x002E30D0
		internal virtual Button btnPayMethod
		{
			[CompilerGenerated]
			get
			{
				return this._btnPayMethod;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnPayMethod_Click);
				Button button = this._btnPayMethod;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnPayMethod = value;
				button = this._btnPayMethod;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x002E4F13 File Offset: 0x002E3113
		// (set) Token: 0x06004E13 RID: 19987 RVA: 0x002E4F1D File Offset: 0x002E311D
		internal virtual TextBox txtDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x002E4F26 File Offset: 0x002E3126
		// (set) Token: 0x06004E15 RID: 19989 RVA: 0x002E4F30 File Offset: 0x002E3130
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

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x002E4F73 File Offset: 0x002E3173
		// (set) Token: 0x06004E17 RID: 19991 RVA: 0x002E4F7D File Offset: 0x002E317D
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x002E4F86 File Offset: 0x002E3186
		// (set) Token: 0x06004E19 RID: 19993 RVA: 0x002E4F90 File Offset: 0x002E3190
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06004E1A RID: 19994 RVA: 0x002E4F99 File Offset: 0x002E3199
		// (set) Token: 0x06004E1B RID: 19995 RVA: 0x002E4FA3 File Offset: 0x002E31A3
		internal virtual TextBox txtChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x002E4FAC File Offset: 0x002E31AC
		// (set) Token: 0x06004E1D RID: 19997 RVA: 0x002E4FB6 File Offset: 0x002E31B6
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06004E1E RID: 19998 RVA: 0x002E4FBF File Offset: 0x002E31BF
		// (set) Token: 0x06004E1F RID: 19999 RVA: 0x002E4FC9 File Offset: 0x002E31C9
		internal virtual Label lblchange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06004E20 RID: 20000 RVA: 0x002E4FD2 File Offset: 0x002E31D2
		// (set) Token: 0x06004E21 RID: 20001 RVA: 0x002E4FDC File Offset: 0x002E31DC
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
				EventHandler eventHandler = new EventHandler(this.txtAmtPaid_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmtPaid_KeyDown);
				EventHandler eventHandler2 = new EventHandler(this.txtAmtPaid_Click);
				TextBox textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.Click -= eventHandler2;
				}
				this._txtAmtPaid = value;
				textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.Click += eventHandler2;
				}
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x002E5055 File Offset: 0x002E3255
		// (set) Token: 0x06004E23 RID: 20003 RVA: 0x002E505F File Offset: 0x002E325F
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x002E5068 File Offset: 0x002E3268
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x002E5072 File Offset: 0x002E3272
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x002E507B File Offset: 0x002E327B
		// (set) Token: 0x06004E27 RID: 20007 RVA: 0x002E5088 File Offset: 0x002E3288
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

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x002E50CB File Offset: 0x002E32CB
		// (set) Token: 0x06004E29 RID: 20009 RVA: 0x002E50D5 File Offset: 0x002E32D5
		internal virtual Label lblCouponInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x002E50DE File Offset: 0x002E32DE
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x002E50E8 File Offset: 0x002E32E8
		internal virtual TextBox txtPriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x002E50F1 File Offset: 0x002E32F1
		// (set) Token: 0x06004E2D RID: 20013 RVA: 0x002E50FB File Offset: 0x002E32FB
		internal virtual TextBox txtCustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x002E5104 File Offset: 0x002E3304
		// (set) Token: 0x06004E2F RID: 20015 RVA: 0x002E510E File Offset: 0x002E330E
		internal virtual GroupBox grpCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x002E5117 File Offset: 0x002E3317
		// (set) Token: 0x06004E31 RID: 20017 RVA: 0x002E5121 File Offset: 0x002E3321
		internal virtual RadioButton rdbCollectionsNone
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x002E512A File Offset: 0x002E332A
		// (set) Token: 0x06004E33 RID: 20019 RVA: 0x002E5134 File Offset: 0x002E3334
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x002E513D File Offset: 0x002E333D
		// (set) Token: 0x06004E35 RID: 20021 RVA: 0x002E5147 File Offset: 0x002E3347
		internal virtual RadioButton rdpDelivery
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x002E5150 File Offset: 0x002E3350
		// (set) Token: 0x06004E37 RID: 20023 RVA: 0x002E515A File Offset: 0x002E335A
		internal virtual RadioButton rdbCollection
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x002E5163 File Offset: 0x002E3363
		// (set) Token: 0x06004E39 RID: 20025 RVA: 0x002E516D File Offset: 0x002E336D
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x002E5176 File Offset: 0x002E3376
		// (set) Token: 0x06004E3B RID: 20027 RVA: 0x002E5180 File Offset: 0x002E3380
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

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x002E51C3 File Offset: 0x002E33C3
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x002E51CD File Offset: 0x002E33CD
		internal virtual CheckBox chkMultiple
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x002E51D6 File Offset: 0x002E33D6
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x002E51E0 File Offset: 0x002E33E0
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06004E40 RID: 20032 RVA: 0x002E51E9 File Offset: 0x002E33E9
		// (set) Token: 0x06004E41 RID: 20033 RVA: 0x002E51F3 File Offset: 0x002E33F3
		internal virtual CheckBox chkAccount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x002E51FC File Offset: 0x002E33FC
		// (set) Token: 0x06004E43 RID: 20035 RVA: 0x002E5206 File Offset: 0x002E3406
		internal virtual ComboBox cboConsultant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06004E44 RID: 20036 RVA: 0x002E520F File Offset: 0x002E340F
		// (set) Token: 0x06004E45 RID: 20037 RVA: 0x002E521C File Offset: 0x002E341C
		internal virtual Button btnSave
		{
			[CompilerGenerated]
			get
			{
				return this._btnSave;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnSave_Click);
				Button button = this._btnSave;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnSave = value;
				button = this._btnSave;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06004E46 RID: 20038 RVA: 0x002E525F File Offset: 0x002E345F
		// (set) Token: 0x06004E47 RID: 20039 RVA: 0x002E526C File Offset: 0x002E346C
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

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06004E48 RID: 20040 RVA: 0x002E52AF File Offset: 0x002E34AF
		// (set) Token: 0x06004E49 RID: 20041 RVA: 0x002E52BC File Offset: 0x002E34BC
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
				EventHandler eventHandler = new EventHandler(this.btnstartshift_Click);
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

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06004E4A RID: 20042 RVA: 0x002E52FF File Offset: 0x002E34FF
		// (set) Token: 0x06004E4B RID: 20043 RVA: 0x002E5309 File Offset: 0x002E3509
		internal virtual Label lblShiftDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x002E5312 File Offset: 0x002E3512
		// (set) Token: 0x06004E4D RID: 20045 RVA: 0x002E531C File Offset: 0x002E351C
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

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06004E4E RID: 20046 RVA: 0x002E535F File Offset: 0x002E355F
		// (set) Token: 0x06004E4F RID: 20047 RVA: 0x002E5369 File Offset: 0x002E3569
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x002E5372 File Offset: 0x002E3572
		// (set) Token: 0x06004E51 RID: 20049 RVA: 0x002E537C File Offset: 0x002E357C
		internal virtual DateTimePicker DateTimePicker2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x002E5385 File Offset: 0x002E3585
		// (set) Token: 0x06004E53 RID: 20051 RVA: 0x002E5390 File Offset: 0x002E3590
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
				EventHandler eventHandler = new EventHandler(this.Button8_Click_1);
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

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x002E53D3 File Offset: 0x002E35D3
		// (set) Token: 0x06004E55 RID: 20053 RVA: 0x002E53E0 File Offset: 0x002E35E0
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

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x002E5423 File Offset: 0x002E3623
		// (set) Token: 0x06004E57 RID: 20055 RVA: 0x002E5430 File Offset: 0x002E3630
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

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06004E58 RID: 20056 RVA: 0x002E5473 File Offset: 0x002E3673
		// (set) Token: 0x06004E59 RID: 20057 RVA: 0x002E5480 File Offset: 0x002E3680
		internal virtual Button btnClose
		{
			[CompilerGenerated]
			get
			{
				return this._btnClose;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button11_Click);
				Button button = this._btnClose;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnClose = value;
				button = this._btnClose;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06004E5A RID: 20058 RVA: 0x002E54C3 File Offset: 0x002E36C3
		// (set) Token: 0x06004E5B RID: 20059 RVA: 0x002E54D0 File Offset: 0x002E36D0
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

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06004E5C RID: 20060 RVA: 0x002E5513 File Offset: 0x002E3713
		// (set) Token: 0x06004E5D RID: 20061 RVA: 0x002E551D File Offset: 0x002E371D
		internal virtual Label lblCurrCalc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06004E5E RID: 20062 RVA: 0x002E5526 File Offset: 0x002E3726
		// (set) Token: 0x06004E5F RID: 20063 RVA: 0x002E5530 File Offset: 0x002E3730
		internal virtual Button btnRefreshScale
		{
			[CompilerGenerated]
			get
			{
				return this._btnRefreshScale;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button11_Click_1);
				Button button = this._btnRefreshScale;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnRefreshScale = value;
				button = this._btnRefreshScale;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06004E60 RID: 20064 RVA: 0x002E5573 File Offset: 0x002E3773
		// (set) Token: 0x06004E61 RID: 20065 RVA: 0x002E557D File Offset: 0x002E377D
		internal virtual Label lblTable
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06004E62 RID: 20066 RVA: 0x002E5586 File Offset: 0x002E3786
		// (set) Token: 0x06004E63 RID: 20067 RVA: 0x002E5590 File Offset: 0x002E3790
		internal virtual Label lblShift
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06004E64 RID: 20068 RVA: 0x002E5599 File Offset: 0x002E3799
		// (set) Token: 0x06004E65 RID: 20069 RVA: 0x002E55A3 File Offset: 0x002E37A3
		internal virtual Label lblRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06004E66 RID: 20070 RVA: 0x002E55AC File Offset: 0x002E37AC
		// (set) Token: 0x06004E67 RID: 20071 RVA: 0x002E55B8 File Offset: 0x002E37B8
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
				EventHandler eventHandler = new EventHandler(this.Button11_Click_2);
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

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06004E68 RID: 20072 RVA: 0x002E55FB File Offset: 0x002E37FB
		// (set) Token: 0x06004E69 RID: 20073 RVA: 0x002E5608 File Offset: 0x002E3808
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

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06004E6A RID: 20074 RVA: 0x002E564B File Offset: 0x002E384B
		// (set) Token: 0x06004E6B RID: 20075 RVA: 0x002E5655 File Offset: 0x002E3855
		internal virtual Label lblTip
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06004E6C RID: 20076 RVA: 0x002E565E File Offset: 0x002E385E
		// (set) Token: 0x06004E6D RID: 20077 RVA: 0x002E5668 File Offset: 0x002E3868
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06004E6E RID: 20078 RVA: 0x002E5671 File Offset: 0x002E3871
		// (set) Token: 0x06004E6F RID: 20079 RVA: 0x002E567B File Offset: 0x002E387B
		internal virtual Label lblUser
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06004E70 RID: 20080 RVA: 0x002E5684 File Offset: 0x002E3884
		// (set) Token: 0x06004E71 RID: 20081 RVA: 0x002E5690 File Offset: 0x002E3890
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

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06004E72 RID: 20082 RVA: 0x002E56D3 File Offset: 0x002E38D3
		// (set) Token: 0x06004E73 RID: 20083 RVA: 0x002E56DD File Offset: 0x002E38DD
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06004E74 RID: 20084 RVA: 0x002E56E6 File Offset: 0x002E38E6
		// (set) Token: 0x06004E75 RID: 20085 RVA: 0x002E56F0 File Offset: 0x002E38F0
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06004E76 RID: 20086 RVA: 0x002E56F9 File Offset: 0x002E38F9
		// (set) Token: 0x06004E77 RID: 20087 RVA: 0x002E5703 File Offset: 0x002E3903
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06004E78 RID: 20088 RVA: 0x002E570C File Offset: 0x002E390C
		// (set) Token: 0x06004E79 RID: 20089 RVA: 0x002E5716 File Offset: 0x002E3916
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06004E7A RID: 20090 RVA: 0x002E571F File Offset: 0x002E391F
		// (set) Token: 0x06004E7B RID: 20091 RVA: 0x002E5729 File Offset: 0x002E3929
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06004E7C RID: 20092 RVA: 0x002E5732 File Offset: 0x002E3932
		// (set) Token: 0x06004E7D RID: 20093 RVA: 0x002E573C File Offset: 0x002E393C
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06004E7E RID: 20094 RVA: 0x002E5745 File Offset: 0x002E3945
		// (set) Token: 0x06004E7F RID: 20095 RVA: 0x002E574F File Offset: 0x002E394F
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x002E5758 File Offset: 0x002E3958
		// (set) Token: 0x06004E81 RID: 20097 RVA: 0x002E5762 File Offset: 0x002E3962
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06004E82 RID: 20098 RVA: 0x002E576B File Offset: 0x002E396B
		// (set) Token: 0x06004E83 RID: 20099 RVA: 0x002E5775 File Offset: 0x002E3975
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06004E84 RID: 20100 RVA: 0x002E577E File Offset: 0x002E397E
		// (set) Token: 0x06004E85 RID: 20101 RVA: 0x002E5788 File Offset: 0x002E3988
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06004E86 RID: 20102 RVA: 0x002E5791 File Offset: 0x002E3991
		// (set) Token: 0x06004E87 RID: 20103 RVA: 0x002E579B File Offset: 0x002E399B
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06004E88 RID: 20104 RVA: 0x002E57A4 File Offset: 0x002E39A4
		// (set) Token: 0x06004E89 RID: 20105 RVA: 0x002E57AE File Offset: 0x002E39AE
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x002E57B7 File Offset: 0x002E39B7
		// (set) Token: 0x06004E8B RID: 20107 RVA: 0x002E57C1 File Offset: 0x002E39C1
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06004E8C RID: 20108 RVA: 0x002E57CA File Offset: 0x002E39CA
		// (set) Token: 0x06004E8D RID: 20109 RVA: 0x002E57D4 File Offset: 0x002E39D4
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x002E57DD File Offset: 0x002E39DD
		// (set) Token: 0x06004E8F RID: 20111 RVA: 0x002E57E7 File Offset: 0x002E39E7
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06004E90 RID: 20112 RVA: 0x002E57F0 File Offset: 0x002E39F0
		// (set) Token: 0x06004E91 RID: 20113 RVA: 0x002E57FA File Offset: 0x002E39FA
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06004E92 RID: 20114 RVA: 0x002E5803 File Offset: 0x002E3A03
		// (set) Token: 0x06004E93 RID: 20115 RVA: 0x002E580D File Offset: 0x002E3A0D
		internal virtual DataGridViewTextBoxColumn DiscPaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06004E94 RID: 20116 RVA: 0x002E5816 File Offset: 0x002E3A16
		// (set) Token: 0x06004E95 RID: 20117 RVA: 0x002E5820 File Offset: 0x002E3A20
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06004E96 RID: 20118 RVA: 0x002E5829 File Offset: 0x002E3A29
		// (set) Token: 0x06004E97 RID: 20119 RVA: 0x002E5833 File Offset: 0x002E3A33
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x002E583C File Offset: 0x002E3A3C
		// (set) Token: 0x06004E99 RID: 20121 RVA: 0x002E5846 File Offset: 0x002E3A46
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06004E9A RID: 20122 RVA: 0x002E584F File Offset: 0x002E3A4F
		// (set) Token: 0x06004E9B RID: 20123 RVA: 0x002E5859 File Offset: 0x002E3A59
		internal virtual DataGridViewTextBoxColumn Taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06004E9C RID: 20124 RVA: 0x002E5862 File Offset: 0x002E3A62
		// (set) Token: 0x06004E9D RID: 20125 RVA: 0x002E586C File Offset: 0x002E3A6C
		internal virtual DataGridViewTextBoxColumn PromStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06004E9E RID: 20126 RVA: 0x002E5875 File Offset: 0x002E3A75
		// (set) Token: 0x06004E9F RID: 20127 RVA: 0x002E587F File Offset: 0x002E3A7F
		internal virtual DataGridViewTextBoxColumn OtherDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x002E5888 File Offset: 0x002E3A88
		// (set) Token: 0x06004EA1 RID: 20129 RVA: 0x002E5892 File Offset: 0x002E3A92
		internal virtual DataGridViewTextBoxColumn IsVoucher
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06004EA2 RID: 20130 RVA: 0x002E589B File Offset: 0x002E3A9B
		// (set) Token: 0x06004EA3 RID: 20131 RVA: 0x002E58A5 File Offset: 0x002E3AA5
		internal virtual DataGridViewTextBoxColumn Comments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x002E58AE File Offset: 0x002E3AAE
		// (set) Token: 0x06004EA5 RID: 20133 RVA: 0x002E58B8 File Offset: 0x002E3AB8
		internal virtual DataGridViewTextBoxColumn RowNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x002E58C1 File Offset: 0x002E3AC1
		// (set) Token: 0x06004EA7 RID: 20135 RVA: 0x002E58CB File Offset: 0x002E3ACB
		internal virtual DataGridViewTextBoxColumn UOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x002E58D4 File Offset: 0x002E3AD4
		// (set) Token: 0x06004EA9 RID: 20137 RVA: 0x002E58DE File Offset: 0x002E3ADE
		internal virtual DataGridViewTextBoxColumn Break
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06004EAA RID: 20138 RVA: 0x002E58E7 File Offset: 0x002E3AE7
		// (set) Token: 0x06004EAB RID: 20139 RVA: 0x002E58F1 File Offset: 0x002E3AF1
		internal virtual DataGridViewTextBoxColumn BreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x002E58FA File Offset: 0x002E3AFA
		// (set) Token: 0x06004EAD RID: 20141 RVA: 0x002E5904 File Offset: 0x002E3B04
		internal virtual DataGridViewTextBoxColumn BreakParentProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x002E590D File Offset: 0x002E3B0D
		// (set) Token: 0x06004EAF RID: 20143 RVA: 0x002E5917 File Offset: 0x002E3B17
		internal virtual DataGridViewTextBoxColumn ActualBreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x002E5920 File Offset: 0x002E3B20
		// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x002E592A File Offset: 0x002E3B2A
		internal virtual DataGridViewTextBoxColumn taxexempt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x002E5933 File Offset: 0x002E3B33
		// (set) Token: 0x06004EB3 RID: 20147 RVA: 0x002E593D File Offset: 0x002E3B3D
		internal virtual DataGridViewTextBoxColumn isdeposits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06004EB4 RID: 20148 RVA: 0x002E5946 File Offset: 0x002E3B46
		// (set) Token: 0x06004EB5 RID: 20149 RVA: 0x002E5950 File Offset: 0x002E3B50
		internal virtual DataGridViewTextBoxColumn AltDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06004EB6 RID: 20150 RVA: 0x002E5959 File Offset: 0x002E3B59
		// (set) Token: 0x06004EB7 RID: 20151 RVA: 0x002E5963 File Offset: 0x002E3B63
		internal virtual DataGridViewTextBoxColumn HSCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x002E596C File Offset: 0x002E3B6C
		// (set) Token: 0x06004EB9 RID: 20153 RVA: 0x002E5976 File Offset: 0x002E3B76
		internal virtual DataGridViewTextBoxColumn NewOrder
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x002E597F File Offset: 0x002E3B7F
		// (set) Token: 0x06004EBB RID: 20155 RVA: 0x002E5989 File Offset: 0x002E3B89
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x002E5992 File Offset: 0x002E3B92
		// (set) Token: 0x06004EBD RID: 20157 RVA: 0x002E599C File Offset: 0x002E3B9C
		internal virtual Button btnEnterDisc
		{
			[CompilerGenerated]
			get
			{
				return this._btnEnterDisc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnEnterDisc_Click);
				Button button = this._btnEnterDisc;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnEnterDisc = value;
				button = this._btnEnterDisc;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x002E59E0 File Offset: 0x002E3BE0
		private void SalesTouchScreen_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable paymentMethods = this.pf.GetPaymentMethods(this._cnn);
				bool flag = paymentMethods.Rows.Count > 0;
				if (flag)
				{
					DataRow dataRow = paymentMethods.AsEnumerable().ElementAtOrDefault<DataRow>(0);
					this.currentPayMethod = Conversions.ToInteger(dataRow["paymentmethodid"]);
					this.GetPayMethDetails();
					this.GetBranchDetails();
					this.btnSave.Visible = true;
					bool flag2 = MyProject.Forms.Form1.isRestaurant == 1;
					if (flag2)
					{
						DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
						dataGridViewButtonColumn.HeaderText = "Comments";
						dataGridViewButtonColumn.Text = "Comments";
						dataGridViewButtonColumn.Name = "btnComments";
						dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
						this.DataGridView1.Columns.Insert(24, dataGridViewButtonColumn);
						this.DataGridView1.Columns["ProductCode"].Visible = false;
						this.CheckShiftStatus();
					}
					bool flag3 = MyProject.Forms.Form1.UseConnectedScale == 1;
					if (flag3)
					{
						try
						{
							this.btnRefreshScale.Visible = true;
							this.GetScaleSettings();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Connected Scale not detected. Enter weight manually");
							this.txtQtyWeighed.Enabled = true;
						}
					}
					else
					{
						this.btnRefreshScale.Visible = false;
					}
					this.datProm.Columns.Add("PromNo", typeof(int));
					bool flag4 = MyProject.Forms.Form1.TillPointPriceChange == 1;
					if (flag4)
					{
						this.txtPriceChange.Visible = true;
						this.Label3.Visible = true;
						this.btnEnterDisc.Visible = true;
						bool flag5 = MyProject.Forms.Form1.DiscountEditingAllowed == 1;
						if (flag5)
						{
							this.txtPriceChange.Enabled = true;
						}
						else
						{
							this.txtPriceChange.Enabled = false;
						}
					}
					else
					{
						this.txtPriceChange.Visible = false;
						this.Label3.Visible = false;
						this.btnEnterDisc.Visible = false;
					}
					this.btnstartshift.Focus();
				}
				else
				{
					MessageBox.Show("There are no payment methods found. Please check before proceeding.");
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error loading form. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x002E5C84 File Offset: 0x002E3E84
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

		// Token: 0x06004EC0 RID: 20160 RVA: 0x002E5D10 File Offset: 0x002E3F10
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
			int num = 1;
			int num2 = 60;
			int num3 = 90;
			int num4 = 5;
			int num5 = 50;
			checked
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						Button button = new Button();
						button.BackColor = Color.LightYellow;
						bool flag = num == 1;
						if (flag)
						{
							button.Text = "All Categories";
							button.Name = "allcategories";
							button.Location = new Point(num4, num5);
							num4 = num4 + num3 + 20;
							button.Height = num2;
							button.Width = num3;
							this.PanelCategories.Controls.Add(button);
							button.Click += this.Button_Click;
							Button button2 = new Button();
							button2.BackColor = Color.White;
							button2.Text = Conversions.ToString(dataRow["CatDesc"]);
							button2.Name = Conversions.ToString(dataRow["CatDesc"]);
							button2.Location = new Point(num4, num5);
							num4 = num4 + num3 + 20;
							button2.Height = num2;
							button2.Width = num3;
							this.PanelCategories.Controls.Add(button2);
							button2.Click += this.Button_Click;
							num++;
						}
						else
						{
							button.Text = Conversions.ToString(dataRow["CatDesc"]);
							button.Name = Conversions.ToString(dataRow["CatDesc"]);
							button.Location = new Point(num4, num5);
							num4 = num4 + num3 + 20;
							button.Height = num2;
							button.Width = num3;
							this.PanelCategories.Controls.Add(button);
							button.Click += this.Button_Click;
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
			}
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label10_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x002E5FC4 File Offset: 0x002E41C4
		private void CategoryChosen(string catname, Button senderbtn)
		{
			try
			{
				foreach (object obj in this.PanelCategories.Controls)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					bool flag = objectValue is Button;
					if (flag)
					{
						Button button = (Button)objectValue;
						button.BackColor = Color.LightYellow;
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
			senderbtn.BackColor = Color.Lime;
			this.lblcategory.Text = catname;
			this.LoadProductsForCategory(catname, MyProject.Forms.Form1.coid);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x002E6078 File Offset: 0x002E4278
		private void LoadProductsForCategory(string categoryname, int coid)
		{
			bool flag = Operators.CompareString(categoryname, "allcategories", false) == 0;
			if (flag)
			{
				MenuCategories menuCategories = new MenuCategories();
				menuCategories.categoryname = categoryname;
				bool flag2 = menuCategories.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
					this.LoadProduct(menuCategories.selectedproductid_cat);
				}
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductsByCategoryName";
				sqlCommand.Parameters.AddWithValue("category", categoryname);
				sqlCommand.Parameters.AddWithValue("coid", coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag3 = num > 0;
				if (flag3)
				{
					MenuProducts menuProducts = new MenuProducts();
					menuProducts.categoryname = categoryname;
					bool flag4 = menuProducts.ShowDialog() == DialogResult.OK;
					if (flag4)
					{
						this.LoadProduct(menuProducts.selectedproductid);
					}
				}
			}
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x002E6190 File Offset: 0x002E4390
		private void LoadFavProducts()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductsFavourites";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			int num2 = 30;
			int num3 = 230;
			int num4 = 5;
			int num5 = 10;
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					Button button = new Button();
					button.BackColor = Color.LightYellow;
					button.Text = Conversions.ToString(dataRow["ProductDesc"]);
					button.Name = Conversions.ToString(dataRow["productid"]);
					button.Location = new Point(num4, num5);
					num5 = checked(num5 + num2 + 20);
					button.Height = num2;
					button.Width = num3;
					this.PanelProducts.Controls.Add(button);
					button.Click += this.ProductButton_Click;
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

		// Token: 0x06004EC5 RID: 20165 RVA: 0x002E630C File Offset: 0x002E450C
		private void Button_Click(object sender, EventArgs e)
		{
			try
			{
				Button button = (Button)sender;
				this.CategoryChosen(button.Name, button);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading category products. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x002E6368 File Offset: 0x002E4568
		private void ProductButton_Click(object sender, EventArgs e)
		{
			try
			{
				Button button = (Button)sender;
				try
				{
					foreach (object obj in this.PanelProducts.Controls)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						bool flag = objectValue is Button;
						if (flag)
						{
							Button button2 = (Button)objectValue;
							button2.BackColor = Color.LightYellow;
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
				button.BackColor = Color.Lime;
				this.LoadProduct(Conversions.ToInteger(button.Name));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading product. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x002E644C File Offset: 0x002E464C
		private void LoadProduct(int productid)
		{
			this.WholesalePriceByQty = 0m;
			bool flag = productid == 0;
			if (flag)
			{
				this.currentID = 0;
				this.currentIsWeighed = false;
				this.currentCode = "";
				this.lbldesc.Text = ".....";
				this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
				this.txtBarCode.Focus();
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByID2";
				sqlCommand.Parameters.AddWithValue("prodtID", productid);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.lbldesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
					bool flag3 = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
					this.isunendingstock = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
					DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataRow["ProductID"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.currentPayMethod, Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
					bool flag4 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
					if (flag4)
					{
						this.txtCoupons.Text = "1";
						this.txtOldprice.Text = Conversions.ToString(productPayMethodDiscount["oldprice"]);
						this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount["paymethod"]);
						this.discAmount = Conversions.ToDecimal(productPayMethodDiscount["disc"]);
						this.btnPayMethod.Enabled = false;
						this.PaymentMethodDiscountEffected = 1;
					}
					else
					{
						this.txtCoupons.Text = "";
					}
					bool flag5 = !flag3;
					decimal num2;
					decimal num3;
					if (flag5)
					{
						num2 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), productPayMethodDiscount["disc"]));
						num3 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
						this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
						this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["specialprice"]))));
					}
					else
					{
						DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
						num2 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate), productPayMethodDiscount["disc"]));
						num3 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
						this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"]))));
						this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
					}
					decimal num4 = 0m;
					bool flag6 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
					if (flag6)
					{
						this.priceb4tax = num2;
						this.priceb4tax = this.priceb4tax;
						num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						decimal num5 = decimal.Add(num2, decimal.Multiply(decimal.Divide(num4, 100m), num2));
						num5 = num5;
						this.priceb4taxWholesale = num3;
						this.priceb4taxWholesale = this.priceb4taxWholesale;
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = decimal.Add(num3, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num3));
						this.totpriceWholesale = this.totpriceWholesale;
						bool flag7 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag7)
						{
							this.txtPrice.Text = Math.Round(this.totpriceWholesale, 5, MidpointRounding.AwayFromZero).ToString();
						}
						else
						{
							this.txtPrice.Text = Math.Round(num5, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
						}
					}
					else
					{
						num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.priceb4tax = Math.Round(decimal.Divide(num2, decimal.Add(1m, decimal.Divide(num4, 100m))), 5, MidpointRounding.AwayFromZero);
						this.currentTaxRate = num4;
						decimal num6 = num2;
						num6 = num6;
						this.priceb4taxWholesale = Math.Round(decimal.Divide(num3, decimal.Add(1m, decimal.Divide(num4, 100m))), 5, MidpointRounding.AwayFromZero);
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = num3;
						bool flag8 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag8)
						{
							this.txtPrice.Text = this.totpriceWholesale.ToString();
						}
						else
						{
							this.txtPrice.Text = num6.ToString();
						}
					}
					this.lblcost.Text = Conversions.ToString(Operators.MultiplyObject(dataRow["Cost"], this.mono_rate));
					this.lbltax.Text = Math.Round(num4, 5, MidpointRounding.AwayFromZero).ToString();
					this.currentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.currentCode = Conversions.ToString(dataRow["ProductCode"]);
					this.currentExpires = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
					bool flag9 = (MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == -1);
					if (flag9)
					{
						this.txtQty.Visible = false;
						this.Label4.Visible = false;
						this.Button1.Text = "SELECT";
					}
					else
					{
						this.txtQty.Visible = true;
						this.Label4.Visible = true;
					}
					this.currentUOM = dataRow["UOM"].ToString();
					this.currentIsWeighed = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isweighed"])), false, RuntimeHelpers.GetObjectValue(dataRow["isweighed"])));
					this.currParentCaseID = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["caseparentproductid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["caseparentproductid"])));
					this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]), RuntimeHelpers.GetObjectValue(dataRow["HSCode"])));
					this.currentIsDeposit = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])), 0, RuntimeHelpers.GetObjectValue(dataRow["isdeposit"])));
					this.current_taxexempt = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow["taxexempt"])));
					this.txtStockAvail.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.currentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
					bool flag10 = (MyProject.Forms.Form1.autoBreakCase == 1) & (this.currParentCaseID != 0);
					if (flag10)
					{
						DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, this.currParentCaseID, this._cnn);
						this.currCaseQty = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])), 0, RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])));
					}
					bool flag11 = MyProject.Forms.Form1.AllowTellerToViewStockBalances == 1;
					if (flag11)
					{
						this.txtStockAvail.Visible = true;
						this.Label6.Visible = true;
					}
					else
					{
						this.txtStockAvail.Visible = false;
						this.Label6.Visible = false;
					}
					bool flag12 = (MyProject.Forms.Form1.UseConnectedScale == 1) & this.currentIsWeighed;
					if (flag12)
					{
						try
						{
							this.txtQty.Visible = false;
							this.txtQtyWeighed.Visible = true;
							this.lblCurrCalc.Visible = true;
							bool flag13 = MyProject.Forms.Form1.serialRestrictQtyTextBox == 1;
							if (flag13)
							{
								this.txtQtyWeighed.ReadOnly = true;
							}
							else
							{
								this.txtQtyWeighed.ReadOnly = false;
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Connected Scale not detected. Enter weight manually");
							this.txtQtyWeighed.Enabled = true;
						}
					}
					else
					{
						this.txtQty.Visible = true;
						this.txtQtyWeighed.Visible = false;
						this.lblCurrCalc.Visible = false;
						this.txtQty.Text = Conversions.ToString(1);
					}
					this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
					this.txtBarCode.Focus();
				}
				else
				{
					this.currentID = 0;
					this.currentIsWeighed = false;
					this.currentCode = "";
					this.lbldesc.Text = ".....";
					this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
					this.txtBarCode.Focus();
				}
			}
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x002E7174 File Offset: 0x002E5374
		private void btnPayMethod_Click(object sender, EventArgs e)
		{
			try
			{
				DialogPayMethods dialogPayMethods = new DialogPayMethods();
				bool flag = dialogPayMethods.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.currentPayMethod = Conversions.ToInteger(dialogPayMethods.txtpaymethid.Text);
					this.currentPayMethodDesc = dialogPayMethods.txtpaymethdesc.Text;
					DataTable paymentMethodDetails = this.pf.GetPaymentMethodDetails(this.currentPayMethod, this._cnn);
					DataRow dataRow = paymentMethodDetails.Rows[0];
					this.paymeth_requiresref = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["requiresref"])), false, RuntimeHelpers.GetObjectValue(dataRow["requiresref"])));
					this.paymethchanged();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing payment methods select form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x002E7264 File Offset: 0x002E5464
		private void paymethchanged()
		{
			this.btnPayMethod.Text = this.currentPayMethodDesc;
			this.txtAmtPaid.Text = "0";
			bool flag = MyProject.Forms.Form1.PrintFiscal == 1;
			if (flag)
			{
				bool flag2 = MyProject.Forms.Form1.FiscalEltrade == 1;
				if (flag2)
				{
					this.GetEtradePortSettings(this.currentPayMethod);
				}
			}
			decimal num = this.mono_rate;
			this.GetPayMethDetails();
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
						int num2 = 0;
						bool flag4 = count > 0;
						if (flag4)
						{
							DataRow dataRow = prodtDetails.Rows[0];
							object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value);
							object objectValue2 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscPaymethod"].Value);
							object objectValue3 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value);
							decimal num3 = Conversions.ToDecimal(dataRow["TaxRate"]);
							bool flag5 = Operators.ConditionalCompareObjectNotEqual(objectValue3, 0, false);
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
									num2 = 1;
								}
							}
							bool flag7 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Promstatus"].Value, 3, false);
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
								dataRow2 = this.pf.GetProductPayMethodDiscount(this._cnn, Conversions.ToInteger(dataGridViewRow.Cells["ProdtID"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.currentPayMethod, Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
							}
							bool flag8 = Operators.ConditionalCompareObjectNotEqual(dataRow2["disc"], 0, false);
							if (flag8)
							{
								this.PaymentMethodDiscountEffected = 1;
								dataGridViewRow.Cells["CouponNumber"].Value = 1;
								dataGridViewRow.Cells["OldPrice"].Value = RuntimeHelpers.GetObjectValue(dataRow2["oldprice"]);
								dataGridViewRow.Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
								dataGridViewRow.Cells["UnitPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow2["disc"])), 2, MidpointRounding.AwayFromZero);
								dataGridViewRow.Cells["DiscDetails"].Value = "Payment Method Discount";
								dataGridViewRow.Cells["DiscPaymethod"].Value = RuntimeHelpers.GetObjectValue(dataRow2["paymethod"]);
								dataGridViewRow.Cells["Tax"].Value = Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, decimal.Add(1m, decimal.Divide(num3, 100m)));
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
								bool flag9 = num2 == 0;
								if (flag9)
								{
									dataGridViewRow.Cells["CouponNumber"].Value = 0;
									dataGridViewRow.Cells["DiscDetails"].Value = "";
								}
								dataGridViewRow.Cells["DiscAmount2"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 2, MidpointRounding.AwayFromZero);
								dataGridViewRow.Cells["OldPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
								dataGridViewRow.Cells["UnitPrice"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
								dataGridViewRow.Cells["Tax"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
								{
									Operators.MultiplyObject(Operators.MultiplyObject(decimal.Divide(num3, 100m), dataGridViewRow.Cells["UnitPrice"].Value), dataGridViewRow.Cells["Qty"].Value),
									5,
									MidpointRounding.AwayFromZero
								}, null, null, null));
								dataGridViewRow.Cells["UnitCost"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate), 5, MidpointRounding.AwayFromZero);
								bool flag10 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
								decimal num4;
								if (flag10)
								{
									num4 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
									{
										Operators.AddObject(dataGridViewRow.Cells["UnitPrice"].Value, Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, decimal.Divide(num3, 100m))),
										2,
										MidpointRounding.AwayFromZero
									}, null, null, null));
								}
								else
								{
									num4 = Conversions.ToDecimal(Operators.AddObject(dataGridViewRow.Cells["UnitPrice"].Value, Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, decimal.Divide(num3, 100m))));
								}
								dataGridViewRow.Cells["Total"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
								{
									Operators.MultiplyObject(num4, dataGridViewRow.Cells["Qty"].Value),
									5,
									MidpointRounding.AwayFromZero
								}, null, null, null));
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
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x002E7C88 File Offset: 0x002E5E88
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
			num = new decimal(Math.Round(Convert.ToDouble(num) + Conversion.Val(this.lblTip.Text), 2, MidpointRounding.AwayFromZero));
			bool flag = decimal.Compare(MyProject.Forms.Form1.DiscountApprovedPerc, 0m) != 0;
			if (flag)
			{
				num3 = Math.Round(decimal.Multiply(decimal.Divide(MyProject.Forms.Form1.DiscountApprovedPerc, 100m), num), 5, MidpointRounding.AwayFromZero);
			}
			else
			{
				num3 = 0m;
			}
			this.txtDiscount.Text = num3.ToString();
			num = decimal.Subtract(num, num3);
			this.txtTotal.Text = Conversions.ToString(Math.Round(num, 2, MidpointRounding.AwayFromZero));
			this.txtTax.Text = Conversions.ToString(Math.Round(num2, 2, MidpointRounding.AwayFromZero));
			MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
			double num4 = Conversion.Val(this.txtAmtPaid.Text) - Conversion.Val(this.txtTotal.Text);
			this.txtChange.Text = num4.ToString("#,0.00");
			this.UpdateCustomerDisplayVFD(this.txtTotal.Text);
			bool flag2 = (this.currentTable != 0) & (MyProject.Forms.Form1.usingTables == 1) & !this.items_saved;
			if (flag2)
			{
				this.SaveTableInvoice();
			}
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

		// Token: 0x06004ECB RID: 20171 RVA: 0x002E7F0C File Offset: 0x002E610C
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

		// Token: 0x06004ECC RID: 20172 RVA: 0x002E800C File Offset: 0x002E620C
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

		// Token: 0x06004ECD RID: 20173 RVA: 0x002E808C File Offset: 0x002E628C
		private void GetPayMethDetails()
		{
			DataTable paymentMethodDetails = this.pf.GetPaymentMethodDetails(this.currentPayMethod, this._cnn);
			bool flag = paymentMethodDetails.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = paymentMethodDetails.Rows[0];
				this.paymeth_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				this.mono_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				this.paymeth_fiscalgroup = Conversions.ToInteger(dataRow["FiscalGroup"]);
				this.paymeth_desc = Conversions.ToString(dataRow["PaymentMethodDesc"]);
				this.paymeth_currency = Conversions.ToString(dataRow["Currency"]);
				this.currentPayMethodDesc = this.paymeth_desc;
				this.btnPayMethod.Text = this.currentPayMethodDesc;
			}
			else
			{
				MessageBox.Show("Payment method details error. Please fix the payment methods.");
			}
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x002E817C File Offset: 0x002E637C
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

		// Token: 0x06004ECF RID: 20175 RVA: 0x002E822C File Offset: 0x002E642C
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.UseConnectedScale == 1) & this.currentIsWeighed;
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.txtQtyWeighed.Text, "", false) != 0;
					if (flag2)
					{
						try
						{
							decimal num = this.totpriceWholesale;
							bool flag3 = Operators.CompareString(this.txtQtyWeighed.Text, "", false) != 0;
							if (flag3)
							{
								bool flag4 = Operators.CompareString(this.txtQtyWeighed.Text, "0", false) != 0;
								if (flag4)
								{
									bool flag5 = MyProject.Forms.Form1.IsWholesaleShop != 1;
									if (flag5)
									{
										bool flag6 = MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1;
										if (flag6)
										{
											bool flag7 = decimal.Compare(this.currentWholesaleQty, 0m) != 0;
											if (flag7)
											{
												bool flag8 = decimal.Compare(Convert.ToDecimal(this.txtQtyWeighed.Text), this.currentWholesaleQty) >= 0;
												if (flag8)
												{
													DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Quantity has reached wholesale level. Do you want to change the price to wholesale? " + this.totpriceWholesale.ToString(), MsgBoxStyle.YesNo, null);
													bool flag9 = dialogResult == DialogResult.Yes;
													if (flag9)
													{
														this.txtPrice.Text = this.totpriceWholesale.ToString();
														this.priceb4tax = decimal.Divide(this.totpriceWholesale, decimal.Add(1m, decimal.Divide(this.taxdueWholesale, 100m)));
														this.WholesalePriceByQty = 1m;
														this.EnterItem();
													}
													else
													{
														this.EnterItem();
													}
												}
												else
												{
													this.EnterItem();
												}
											}
											else
											{
												this.EnterItem();
											}
										}
										else
										{
											this.EnterItem();
										}
									}
									else
									{
										this.EnterItem();
									}
								}
							}
						}
						catch (Exception ex)
						{
						}
					}
					else
					{
						MessageBox.Show("Please enter the qty first.");
						this.txtQty.Focus();
					}
				}
				else
				{
					bool flag10 = Operators.CompareString(this.txtQty.Text, "", false) != 0;
					if (flag10)
					{
						try
						{
							decimal num2 = this.totpriceWholesale;
							bool flag11 = Operators.CompareString(this.txtQty.Text, "", false) != 0;
							if (flag11)
							{
								bool flag12 = Operators.CompareString(this.txtQty.Text, "0", false) != 0;
								if (flag12)
								{
									bool flag13 = MyProject.Forms.Form1.IsWholesaleShop != 1;
									if (flag13)
									{
										bool flag14 = MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1;
										if (flag14)
										{
											bool flag15 = decimal.Compare(this.currentWholesaleQty, 0m) != 0;
											if (flag15)
											{
												bool flag16 = decimal.Compare(Convert.ToDecimal(this.txtQty.Text), this.currentWholesaleQty) >= 0;
												if (flag16)
												{
													DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Quantity has reached wholesale level. Do you want to change the price to wholesale? " + this.totpriceWholesale.ToString(), MsgBoxStyle.YesNo, null);
													bool flag17 = dialogResult2 == DialogResult.Yes;
													if (flag17)
													{
														this.txtPrice.Text = this.totpriceWholesale.ToString();
														this.priceb4tax = decimal.Divide(this.totpriceWholesale, decimal.Add(1m, decimal.Divide(this.taxdueWholesale, 100m)));
														this.WholesalePriceByQty = 1m;
														this.EnterItem();
													}
													else
													{
														this.EnterItem();
													}
												}
												else
												{
													this.EnterItem();
												}
											}
											else
											{
												this.EnterItem();
											}
										}
										else
										{
											this.EnterItem();
										}
									}
									else
									{
										this.EnterItem();
									}
								}
							}
						}
						catch (Exception ex2)
						{
						}
					}
					else
					{
						MessageBox.Show("Please enter the qty first.");
						this.txtQty.Focus();
					}
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error adding item to grid. Details: " + ex3.Message);
			}
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x002E8690 File Offset: 0x002E6890
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
					this.txtQty.Text = Conversions.ToString(0);
					this.lblCouponInfo.Text = "...";
					this.txtCoupons.Text = "";
					this.txtBarCode.Text = "";
					this.txtPriceChange.Text = "";
					this.txtBarCode.Focus();
					this.currentID = 0;
					this.lbldesc.Text = "";
					this.txtPrice.Text = "0";
					this.txtStockAvail.Text = "0";
				}
				else
				{
					MessageBox.Show("Coupon error. Check message under coupon, fix And retry.");
				}
			}
			else
			{
				MessageBox.Show("Please make sure that sales, quantity And stock available details are correct.");
				this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
				this.txtBarCode.Focus();
			}
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x002E8830 File Offset: 0x002E6A30
		public bool Verify()
		{
			bool flag = true;
			bool flag2 = (MyProject.Forms.Form1.NegativeStock == 1) | this.isunedingstock;
			if (flag2)
			{
				bool flag3 = MyProject.Forms.Form1.autoBreakCase == 1;
				if (!flag3)
				{
					return true;
				}
				bool flag4 = this.currParentCaseID == 0;
				if (flag4)
				{
					return true;
				}
				int num = Convert.ToInt32(this.pf.GetStockAvailable(this._cnn, this.currParentCaseID, this.DataGridView1, "EA", 0, 0, false, "", 0, false));
				bool flag5 = (double)(checked(num * this.currCaseQty)) + Conversion.Val(this.txtStockAvail.Text) >= Conversion.Val(this.txtQty.Text);
				if (!flag5)
				{
					return true;
				}
				checked
				{
					this.BreakQtyActual = (int)Math.Round(Math.Ceiling(unchecked(Conversion.Val(this.txtQty.Text) - Conversion.Val(this.txtStockAvail.Text)) / (double)this.currCaseQty));
					this.currBreak = 1;
					flag = true;
				}
			}
			else
			{
				bool flag6 = this.isunedingstock;
				if (flag6)
				{
					flag = true;
				}
				else
				{
					decimal num2 = 0m;
					bool flag7 = this.currentIsWeighed & (MyProject.Forms.Form1.UseConnectedScale == 1);
					if (flag7)
					{
						num2 = decimal.Subtract(Convert.ToDecimal(this.txtStockAvail.Text), Convert.ToDecimal(this.txtQtyWeighed.Text));
					}
					else
					{
						num2 = decimal.Subtract(Convert.ToDecimal(this.txtStockAvail.Text), Convert.ToDecimal(this.txtQty.Text));
					}
					bool flag8 = decimal.Compare(num2, 0m) < 0;
					if (flag8)
					{
						bool flag9 = MyProject.Forms.Form1.autoBreakCase == 1;
						if (!flag9)
						{
							return false;
						}
						bool flag10 = this.currParentCaseID == 0;
						if (flag10)
						{
							return false;
						}
						int num3 = Convert.ToInt32(this.pf.GetStockAvailable(this._cnn, this.currParentCaseID, this.DataGridView1, "EA", 0, 0, false, "", 0, false));
						bool flag11 = this.currentIsWeighed;
						if (flag11)
						{
							bool flag12 = (double)(checked(num3 * this.currCaseQty)) + Conversion.Val(this.txtStockAvail.Text) >= Conversion.Val(this.txtQtyWeighed.Text);
							if (!flag12)
							{
								return false;
							}
							checked
							{
								this.BreakQtyActual = (int)Math.Round(Math.Ceiling(unchecked(Conversion.Val(this.txtQtyWeighed.Text) - Conversion.Val(this.txtStockAvail.Text)) / (double)this.currCaseQty));
								this.currBreak = 1;
								flag = true;
							}
						}
						else
						{
							bool flag13 = (double)(checked(num3 * this.currCaseQty)) + Conversion.Val(this.txtStockAvail.Text) >= Conversion.Val(this.txtQty.Text);
							if (!flag13)
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
			}
			bool flag14 = Conversion.Val(this.txtPrice.Text) == 0.0;
			bool flag15;
			if (flag14)
			{
				flag = false;
				flag15 = flag;
			}
			else
			{
				flag15 = flag;
			}
			return flag15;
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x002E8BCC File Offset: 0x002E6DCC
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
						bool flag6 = this.currentID != num3;
						if (flag6)
						{
							this.lblCouponInfo.Text = "Coupon Is Not valid for this product.";
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
									this.txtOldprice.Text = num5.ToString();
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

		// Token: 0x06004ED3 RID: 20179 RVA: 0x002E8E1C File Offset: 0x002E701C
		private void AppendGrid()
		{
			bool flag = this.currentID == 0;
			checked
			{
				if (!flag)
				{
					bool flag2 = (Operators.CompareString(this.currentCode, "1", false) != 0) & (MyProject.Forms.Form1.isRestaurant != 1) & (MyProject.Forms.Form1.OtherProductDetail != 1);
					if (flag2)
					{
						int num = this.DataGridView1.RowCount - 1;
						for (int i = 0; i <= num; i++)
						{
							decimal num2 = Math.Round(decimal.Add(Convert.ToDecimal(unchecked(Convert.ToDouble(Convert.ToDecimal(this.txtPrice.Text)) - Conversion.Val(this.txtPriceChange.Text)) / Convert.ToDouble(decimal.Add(1m, decimal.Divide(Convert.ToDecimal(this.lbltax.Text), 100m)))), this.discTeller), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
							bool flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridView1.Rows[i].Cells["ProdtID"].Value, this.currentID, false), decimal.Compare(Conversions.ToDecimal(this.DataGridView1.Rows[i].Cells["UnitPrice"].Value), num2) == 0));
							if (flag3)
							{
								decimal num3 = Conversions.ToDecimal(Operators.DivideObject(this.DataGridView1.Rows[i].Cells["Tax"].Value, this.DataGridView1.Rows[i].Cells["Qty"].Value));
								bool flag4 = (MyProject.Forms.Form1.UseConnectedScale == 1) & this.currentIsWeighed;
								if (flag4)
								{
									this.DataGridView1.Rows[i].Cells["Qty"].Value = Operators.AddObject(this.DataGridView1.Rows[i].Cells["Qty"].Value, Conversions.ToInteger(this.txtQtyWeighed.Text));
								}
								else
								{
									this.DataGridView1.Rows[i].Cells["Qty"].Value = Operators.AddObject(this.DataGridView1.Rows[i].Cells["Qty"].Value, Conversions.ToInteger(this.txtQty.Text));
								}
								this.DataGridView1.Rows[i].Cells["Tax"].Value = Operators.MultiplyObject(num3, this.DataGridView1.Rows[i].Cells["Qty"].Value);
								this.DataGridView1.Rows[i].Cells["Total"].Value = Operators.AddObject(Operators.MultiplyObject(this.DataGridView1.Rows[i].Cells["UnitPrice"].Value, this.DataGridView1.Rows[i].Cells["Qty"].Value), this.DataGridView1.Rows[i].Cells["Tax"].Value);
								this.DataGridView1.Rows[i].Cells["RowNumber"].Value = this.RowID.ToString();
								this.RowID++;
								this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
								bool flag5 = (MyProject.Forms.Form1.TillPointPriceChange == 1) & (MyProject.Forms.Form1.DiscountEditingAllowed == 1);
								if (flag5)
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
								return;
							}
						}
					}
					int num4 = 0;
					int num5 = 0;
					decimal num6 = 0m;
					this.discTeller = 0m;
					this.discDESC = "";
					bool flag6 = (MyProject.Forms.Form1.IsWarehouse == 0) | ((MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == 0));
					if (flag6)
					{
						bool flag7 = (MyProject.Forms.Form1.UseConnectedScale == 1) & this.currentIsWeighed;
						if (flag7)
						{
							bool flag8 = Conversion.Val(this.txtQtyWeighed.Text) == 0.0;
							if (flag8)
							{
								MessageBox.Show("Please enter a valid weighed quantity.");
								return;
							}
						}
						else
						{
							bool flag9 = Conversion.Val(this.txtQty.Text) == 0.0;
							if (flag9)
							{
								MessageBox.Show("Please enter a valid quantity.");
								return;
							}
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
							this.txtOldprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
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
						decimal num9 = 0m;
						bool flag12 = (MyProject.Forms.Form1.UseConnectedScale == 1) & this.currentIsWeighed;
						if (flag12)
						{
							num9 = new decimal(Conversion.Val(this.txtQtyWeighed.Text));
						}
						else
						{
							num9 = new decimal(Conversion.Val(this.txtQty.Text));
						}
						bool flag13 = decimal.Compare(num7, 0m) != 0;
						decimal num10;
						decimal num11;
						decimal num12;
						if (flag13)
						{
							num10 = Math.Round(this.priceb4tax, 5, MidpointRounding.AwayFromZero);
							bool flag14 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
							if (flag14)
							{
								num11 = Math.Round(decimal.Multiply(Math.Round(decimal.Multiply(decimal.Divide(num7, 100m), num10), 2, MidpointRounding.AwayFromZero), num9), 5, MidpointRounding.AwayFromZero);
							}
							else
							{
								num11 = Math.Round(decimal.Multiply(decimal.Multiply(decimal.Divide(num7, 100m), num10), num9), 5, MidpointRounding.AwayFromZero);
							}
							num12 = decimal.Divide(num7, 100m);
						}
						else
						{
							num10 = Math.Round(num8, 5, MidpointRounding.AwayFromZero);
							num11 = 0m;
							num12 = 0m;
						}
						bool flag15 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalEltrade == 1);
						decimal num13;
						if (flag15)
						{
							num13 = decimal.Multiply(Math.Round(decimal.Add(num10, decimal.Multiply(num10, decimal.Divide(num7, 100m))), 2, MidpointRounding.AwayFromZero), num9);
						}
						else
						{
							num13 = decimal.Multiply(Math.Round(decimal.Add(num10, decimal.Multiply(num10, decimal.Divide(num7, 100m))), 5, MidpointRounding.AwayFromZero), num9);
						}
						string text = "";
						string text2 = Conversions.ToString(this.discAmount);
						bool flag16 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
						if (flag16)
						{
							text = this.discPaymentMethod.ToString();
						}
						bool flag17 = decimal.Compare(this.discTeller, 0m) != 0;
						if (flag17)
						{
							num6 = decimal.Add(num6, this.discTeller);
							ref string ptr = ref this.discDESC;
							this.discDESC = ptr + "Product Discount, " + MyProject.Forms.Form1.Approvedby;
						}
						bool flag18 = decimal.Compare(this.discAmount, 0m) != 0;
						if (flag18)
						{
							num6 = decimal.Add(num6, this.discAmount);
							ref string ptr = ref this.discDESC;
							this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
						}
						bool flag19 = decimal.Compare(this.discCoupons, 0m) != 0;
						if (flag19)
						{
							num6 = decimal.Add(num6, this.discCoupons);
							ref string ptr = ref this.discDESC;
							this.discDESC = ptr + "Coupon Discount, ";
						}
						bool flag20 = decimal.Compare(this.discPromotion, 0m) != 0;
						if (flag20)
						{
							num6 = decimal.Add(num6, this.discPromotion);
							ref string ptr = ref this.discDESC;
							this.discDESC = ptr + this.discPromotionName + ", ";
						}
						bool flag21 = MyProject.Forms.Form1.isRestaurant == 0;
						if (flag21)
						{
							string[] array = new string[]
							{
								Conversions.ToString(this.currentID),
								this.currentCode,
								this.lbldesc.Text,
								num10.ToString(),
								num9.ToString(),
								num11.ToString(),
								Conversions.ToString(num13),
								this.lblcost.Text,
								Conversions.ToString(num4),
								Conversions.ToString(Conversion.Val(this.txtOldprice.Text)),
								Conversions.ToString(num5),
								"0",
								"",
								Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
								Conversions.ToString(this.WholesalePriceByQty),
								this.discDESC,
								text,
								num6.ToString(),
								"",
								Conversions.ToString(0),
								Conversions.ToString(num12),
								"",
								MyProject.Forms.Form1.OtherDetail,
								"",
								"",
								this.GetNextRowNumber().ToString(),
								this.currentUOM,
								Conversions.ToString(this.currBreak),
								Conversions.ToString(this.currCaseQty),
								Conversions.ToString(this.currParentCaseID),
								Conversions.ToString(this.BreakQtyActual),
								Conversions.ToString(this.current_taxexempt),
								Conversions.ToString(this.currentIsDeposit),
								"",
								this.CurrentHSCode,
								"1"
							};
							this.DataGridView1.Rows.Add(array);
						}
						else
						{
							string[] array2 = new string[]
							{
								Conversions.ToString(this.currentID),
								this.currentCode,
								this.lbldesc.Text,
								num10.ToString(),
								num9.ToString(),
								num11.ToString(),
								Conversions.ToString(num13),
								this.lblcost.Text,
								Conversions.ToString(num4),
								Conversions.ToString(Conversion.Val(this.txtOldprice.Text)),
								Conversions.ToString(num5),
								"0",
								"",
								Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
								Conversions.ToString(this.WholesalePriceByQty),
								this.discDESC,
								text,
								num6.ToString(),
								"",
								Conversions.ToString(0),
								Conversions.ToString(num12),
								"",
								MyProject.Forms.Form1.OtherDetail,
								"",
								"",
								"",
								this.GetNextRowNumber().ToString(),
								this.currentUOM,
								Conversions.ToString(this.currBreak),
								Conversions.ToString(this.currCaseQty),
								Conversions.ToString(this.currParentCaseID),
								Conversions.ToString(this.BreakQtyActual),
								Conversions.ToString(this.current_taxexempt),
								Conversions.ToString(this.currentIsDeposit),
								"",
								this.CurrentHSCode,
								"1"
							};
							this.DataGridView1.Rows.Add(array2);
						}
					}
					else
					{
						bool flag22 = (MyProject.Forms.Form1.IsWarehouse == 1) & (this.currentExpires == -1);
						if (flag22)
						{
							DataTable selectedBatch = MyProject.Forms.Form1.SelectedBatch;
							bool flag23 = selectedBatch.Rows.Count > 0;
							if (flag23)
							{
								try
								{
									foreach (object obj in selectedBatch.Rows)
									{
										DataRow dataRow = (DataRow)obj;
										decimal num14 = new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"])));
										bool flag24 = decimal.Compare(num14, 0m) != 0;
										if (flag24)
										{
											bool flag25 = Operators.CompareString(this.txtCoupons.Text, "", false) != 0;
											if (flag25)
											{
												num4 = (int)Math.Round(Conversion.Val(this.txtCoupons.Text));
											}
											decimal num15 = 0m;
											bool flag26 = Operators.CompareString(this.txtPriceChange.Text, "", false) != 0;
											if (flag26)
											{
												num15 = Convert.ToDecimal(this.txtPriceChange.Text);
												this.txtOldprice.Text = Conversions.ToString(Convert.ToDecimal(this.txtPrice.Text));
												num5 = 1;
												this.priceb4tax = decimal.Add(this.priceb4tax, num15);
											}
											decimal num16 = Convert.ToDecimal(this.lbltax.Text);
											decimal num17 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num15);
											bool flag27 = decimal.Compare(num16, 0m) != 0;
											decimal num10;
											decimal num11;
											decimal num12;
											if (flag27)
											{
												num10 = decimal.Divide(num17, decimal.Add(1m, decimal.Divide(num16, 100m)));
												num11 = Conversions.ToDecimal(Strings.Format(decimal.Multiply(Math.Round(decimal.Multiply(decimal.Divide(num16, 100m), num10), 2), num14), "N2"));
												num12 = decimal.Divide(num16, 100m);
											}
											else
											{
												num10 = num17;
												num11 = 0m;
												num12 = 0m;
											}
											decimal num18 = decimal.Multiply(num14, num17);
											num18 = num18;
											string text3 = "";
											bool flag28 = Operators.CompareString(this.txtCoupons.Text, "1", false) == 0;
											if (flag28)
											{
												text3 = this.discPaymentMethod.ToString();
											}
											bool flag29 = decimal.Compare(this.discTeller, 0m) != 0;
											if (flag29)
											{
												num6 = decimal.Add(num6, this.discTeller);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + "Cashier Discount, " + MyProject.Forms.Form1.Approvedby;
											}
											bool flag30 = decimal.Compare(this.discAmount, 0m) != 0;
											if (flag30)
											{
												num6 = decimal.Add(num6, this.discAmount);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + this.discPaymentMethod.ToString() + " Payment Method Discount, ";
											}
											bool flag31 = decimal.Compare(this.discCoupons, 0m) != 0;
											if (flag31)
											{
												num6 = decimal.Add(num6, this.discCoupons);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + "Coupon Discount, ";
											}
											bool flag32 = decimal.Compare(this.discPromotion, 0m) != 0;
											if (flag32)
											{
												num6 = decimal.Add(num6, this.discPromotion);
												ref string ptr = ref this.discDESC;
												this.discDESC = ptr + this.discPromotionName + ", ";
											}
											string[] array3 = new string[]
											{
												Conversions.ToString(this.currentID),
												this.currentCode,
												this.lbldesc.Text,
												num10.ToString(),
												num14.ToString(),
												num11.ToString(),
												num18.ToString(),
												this.lblcost.Text,
												Conversions.ToString(num4),
												Conversions.ToString(Conversion.Val(this.txtOldprice.Text)),
												Conversions.ToString(num5),
												"0",
												"",
												Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
												Conversions.ToString(this.WholesalePriceByQty),
												this.discDESC,
												text3,
												num6.ToString(),
												dataRow["BatchNumber"].ToString(),
												dataRow["ExpiryDate"].ToString(),
												Conversions.ToString(num12),
												"",
												MyProject.Forms.Form1.OtherDetail,
												"",
												"",
												this.GetNextRowNumber().ToString(),
												this.currentUOM,
												Conversions.ToString(this.currBreak),
												Conversions.ToString(this.currCaseQty),
												Conversions.ToString(this.currParentCaseID),
												Conversions.ToString(this.BreakQtyActual),
												Conversions.ToString(this.current_taxexempt),
												Conversions.ToString(this.currentIsDeposit),
												"",
												this.CurrentHSCode,
												"1"
											};
											this.DataGridView1.Rows.Add(array3);
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
					this.txtPriceChange.Text = "";
					this.discTeller = 0m;
					this.discDESC = "";
					this.CheckPromotions();
					this.txtQty.ReadOnly = false;
					this.DataGridView1.Sort(this.DataGridView1.Columns["RowNumber"], ListSortDirection.Descending);
					bool flag33 = MyProject.Forms.Form1.pendinginvoice_entryno != 0;
					if (flag33)
					{
						this.SaveTableInvoice();
					}
				}
			}
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x002EA1FC File Offset: 0x002E83FC
		private int GetNextRowNumber()
		{
			int num = 0;
			bool flag = false;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag2 = !dataGridViewRow.IsNewRow;
					if (flag2)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["rownumber"].Value);
						bool flag3 = objectValue != null && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue));
						if (flag3)
						{
							int num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue));
							bool flag4 = num2 > num;
							if (flag4)
							{
								num = num2;
								flag = true;
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
			return flag ? checked(num + 1) : 0;
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x002EA2DC File Offset: 0x002E84DC
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

		// Token: 0x06004ED6 RID: 20182 RVA: 0x002EA380 File Offset: 0x002E8580
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
													MessageBox.Show("Benefit type for promotion Not known. Advise the System Administrator. Click OK to continue.");
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
														"3",
														MyProject.Forms.Form1.OtherDetail,
														"",
														"",
														this.RowID.ToString()
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
					MessageBox.Show("Promotion calculation error. Detail " + ex.Message);
				}
			}
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x002EAFE8 File Offset: 0x002E91E8
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

		// Token: 0x06004ED8 RID: 20184 RVA: 0x002EB098 File Offset: 0x002E9298
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

		// Token: 0x06004ED9 RID: 20185 RVA: 0x002EB148 File Offset: 0x002E9348
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

		// Token: 0x06004EDA RID: 20186 RVA: 0x002EB208 File Offset: 0x002E9408
		private void InsertPromGiven(int invnumber, int promno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionGivenInsertN";
			sqlCommand.Parameters.AddWithValue("theday", Convert.ToInt32(DateTime.Today.Date.ToString("yyyyMMdd")));
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

		// Token: 0x06004EDB RID: 20187 RVA: 0x002EB31C File Offset: 0x002E951C
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

		// Token: 0x06004EDC RID: 20188 RVA: 0x002EB348 File Offset: 0x002E9548
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

		// Token: 0x06004EDD RID: 20189 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtQty_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x002EB3D8 File Offset: 0x002E95D8
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

		// Token: 0x06004EDF RID: 20191 RVA: 0x002EB450 File Offset: 0x002E9650
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

		// Token: 0x06004EE0 RID: 20192 RVA: 0x002EB500 File Offset: 0x002E9700
		private void Button4_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = Operators.CompareString(this.currentUOM, "EA", false) == 0;
					if (flag)
					{
						int num = Conversions.ToInteger(this.txtQty.Text);
						num++;
						this.txtQty.Text = num.ToString();
					}
					else
					{
						decimal num2 = Conversions.ToDecimal(this.txtQty.Text);
						num2 = decimal.Add(num2, 1m);
						this.txtQty.Text = num2.ToString();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error adding quantity. Detail " + ex.Message);
				}
			}
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x002EB5BC File Offset: 0x002E97BC
		private void Button3_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = Operators.CompareString(this.currentUOM, "EA", false) == 0;
					if (flag)
					{
						int num = Conversions.ToInteger(this.txtQty.Text);
						num--;
						this.txtQty.Text = num.ToString();
					}
					else
					{
						decimal num2 = Conversions.ToDecimal(this.txtQty.Text);
						num2 = decimal.Subtract(num2, 1m);
						this.txtQty.Text = num2.ToString();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error adding quantity. Detail " + ex.Message);
				}
			}
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x002EB678 File Offset: 0x002E9878
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
					this.txtBarCode.Focus();
				}
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error performing sale. Detail " + ex.Message);
			}
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x002EB740 File Offset: 0x002E9940
		private void Button2_Click(object sender, EventArgs e)
		{
			this.ProcessSale();
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x002EB74C File Offset: 0x002E994C
		private void ConfirmSale()
		{
			string text = "";
			bool flag = DateTime.Compare(this.DTdate.Value.Date, DateTime.Today.Date) > 0;
			if (flag)
			{
				MessageBox.Show("Date selected Is greater than today's date. Cannot proceed.");
			}
			else
			{
				bool flag2 = this.paymeth_requiresref;
				if (flag2)
				{
					PayMethRef payMethRef = new PayMethRef();
					bool flag3 = payMethRef.ShowDialog() == DialogResult.OK;
					if (flag3)
					{
						text = this.paymeth_desc + " ref: " + payMethRef.txtRef.Text;
					}
				}
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.Connection = sqlConnection;
				try
				{
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
					sqlCommand.Transaction = sqlTransaction;
					sqlCommand.CommandType = CommandType.StoredProcedure;
					bool flag4 = !this.chkAccount.Checked;
					if (flag4)
					{
						bool flag5 = this.CheckIFPayMethACcurate();
						if (!flag5)
						{
							MessageBox.Show("Check payment methods. Sale cannot proceed.");
							return;
						}
						int num = 0;
						num = 1;
						bool flag6 = (MyProject.Forms.Form1.RecordConsultant == 1) & (MyProject.Forms.Form1.ConsultantSalesOnly == 1);
						if (flag6)
						{
							bool flag7 = Operators.CompareString(this.cboConsultant.Text, "", false) == 0;
							if (flag7)
							{
								MessageBox.Show("Please select the consultant first.");
								sqlTransaction.Rollback();
								sqlConnection.Close();
								return;
							}
						}
						bool flag8 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
						if (flag8)
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
						this.invnum = this.GetInvNumberSales();
						bool flag9 = this.invnum == 0;
						if (flag9)
						{
							MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
							sqlTransaction.Rollback();
							sqlConnection.Close();
							return;
						}
						int num2 = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
						DateTime today = DateTime.Today;
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								string text3 = dataGridViewRow.Cells[24].Value.ToString();
								decimal num3 = 0m;
								bool flag10 = MyProject.Forms.Form1.isRestaurant == 1;
								if (flag10)
								{
									DataTable productIngridients = this.GetProductIngridients(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(dataGridViewRow.Cells["Prodtid"].Value));
									bool flag11 = productIngridients.Rows.Count == 0;
									if (flag11)
									{
										num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value));
									}
									try
									{
										foreach (object obj2 in productIngridients.Rows)
										{
											DataRow dataRow = (DataRow)obj2;
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertNewSale2Warehouse3";
											sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataRow["productid"]));
											sqlCommand.Parameters.AddWithValue("isstockin", 0);
											sqlCommand.Parameters.AddWithValue("ref", this.txtCustomer.Text);
											sqlCommand.Parameters.AddWithValue("quantity", Operators.MultiplyObject(dataRow["qty"], Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value))));
											num3 = decimal.Add(num3, Convert.ToDecimal(Operators.MultiplyObject(dataRow["Cost"], dataRow["qty"])));
											sqlCommand.Parameters.AddWithValue("unitcost", 0);
											sqlCommand.Parameters.AddWithValue("salesprice", 0);
											sqlCommand.Parameters.AddWithValue("paymentmethod", num);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("trancode", 3);
											sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["prodtid"].Value), this._cnn));
											sqlCommand.Parameters.AddWithValue("TranTime", num2);
											sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
											sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(today.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
											sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)));
											sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
											sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", this.currentPayMethod);
											sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
											sqlCommand.Parameters.AddWithValue("discountamount", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)));
											sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
											sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text));
											sqlCommand.Parameters.AddWithValue("collection", 0);
											sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
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
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewSale2Warehouse3";
								sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", this.txtCustomer.Text);
								sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
								bool flag12 = MyProject.Forms.Form1.isRestaurant == 1;
								if (flag12)
								{
									sqlCommand.Parameters.AddWithValue("unitcost", num3);
								}
								else
								{
									sqlCommand.Parameters.AddWithValue("unitcost", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value)));
								}
								sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), this.mono_rate));
								sqlCommand.Parameters.AddWithValue("paymentmethod", num);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 3);
								sqlCommand.Parameters.AddWithValue("prodcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
								sqlCommand.Parameters.AddWithValue("TranTime", num2);
								sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)) / Convert.ToDouble(this.mono_rate));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("shift", this.lblShift.Text);
								sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(today.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)));
								sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", this.currentPayMethod);
								sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
								sqlCommand.Parameters.AddWithValue("discountamount", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)), this.mono_rate));
								sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
								sqlCommand.Parameters.AddWithValue("invdiscount", Conversion.Val(this.txtDiscount.Text) / Convert.ToDouble(this.mono_rate));
								string text4 = "";
								bool @checked = this.rdbCollection.Checked;
								if (@checked)
								{
									text4 = "COLLECTION";
								}
								else
								{
									bool checked2 = this.rdpDelivery.Checked;
									if (checked2)
									{
										text4 = "DELIVERY";
									}
								}
								sqlCommand.Parameters.AddWithValue("collection", text4);
								sqlCommand.Parameters.AddWithValue("discountdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
								sqlCommand.Parameters.AddWithValue("otherdetail", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OtherDetail"].Value));
								sqlCommand.Parameters.AddWithValue("comments", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Comments"].Value));
								sqlCommand.Parameters.AddWithValue("paymethref", text);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
								sqlCommand.Parameters.AddWithValue("TIP", Conversion.Val(this.lblTip.Text));
								sqlCommand.ExecuteNonQuery();
								bool flag13 = Operators.ConditionalCompareObjectGreater(dataGridViewRow.Cells["CouponNumber"].Value, 0, false);
								if (flag13)
								{
									int num4 = Conversions.ToInteger(dataGridViewRow.Cells["CouponNumber"].Value);
									bool flag14 = num4 != 1;
									if (flag14)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "UpdateCoupon";
										sqlCommand.Parameters.AddWithValue("CouponNumber", num4);
										sqlCommand.ExecuteNonQuery();
									}
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertDiscount2";
									sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
									sqlCommand.Parameters.AddWithValue("TranDate", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("DiscountAmt", Operators.DivideObject(dataGridViewRow.Cells["DiscAmount2"].Value, this.mono_rate));
									sqlCommand.Parameters.AddWithValue("pricebefore", Operators.DivideObject(dataGridViewRow.Cells["OldPrice"].Value, this.mono_rate));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("couponnumber", num4);
									sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
									sqlCommand.Parameters.AddWithValue("discounttype", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscDetails"].Value));
									sqlCommand.Parameters.AddWithValue("discountperinvoice", 0);
									sqlCommand.Parameters.AddWithValue("@discountpaymethod", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscPaymethod"].Value));
									sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
									sqlCommand.ExecuteNonQuery();
								}
								bool flag15 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(dataGridViewRow.Cells["PriceChange"]), 0, RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["PriceChange"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PriceChange"].Value)))), 1, false);
								if (flag15)
								{
									decimal num5 = new decimal(Convert.ToDouble(decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)), this.mono_rate)) - (Convert.ToDouble(decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)), this.mono_rate)) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)) / Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value))));
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "PCInsertPriceChange";
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prodtid"].Value));
									sqlCommand.Parameters.AddWithValue("qty", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
									sqlCommand.Parameters.AddWithValue("pricechange", num5);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
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
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						bool flag16 = MyProject.Forms.Form1.pendinginvoice_entryno != 0;
						if (flag16)
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
						bool checked3 = this.chkMultiple.Checked;
						if (checked3)
						{
							try
							{
								foreach (object obj3 in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
								{
									DataRow dataRow2 = (DataRow)obj3;
									bool flag17 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["amtpaid"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["amtpaid"])), 0, false);
									if (flag17)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
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
							decimal num6 = Convert.ToDecimal(this.txtTotal.Text);
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertActualPaymentMethods";
							sqlCommand.Parameters.AddWithValue("invnum", this.invnum);
							sqlCommand.Parameters.AddWithValue("payid", this.currentPayMethod);
							sqlCommand.Parameters.AddWithValue("paydesc", this.currentPayMethodDesc);
							sqlCommand.Parameters.AddWithValue("amt", num6);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
							sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.ExecuteNonQuery();
						}
						bool flag18 = MyProject.Forms.Form1.CollectEcocashDetails == 1;
						if (flag18)
						{
							bool flag19 = (Operators.CompareString(this.currentPayMethodDesc, "Ecocash", false) == 0) | (Operators.CompareString(this.currentPayMethodDesc, "ECOCASH", false) == 0) | (Operators.CompareString(this.currentPayMethodDesc, "ecocash", false) == 0);
							if (flag19)
							{
								MessageBox.Show("Function is disable. Contact your system administrator.");
							}
						}
					}
					else
					{
						bool flag20 = Operators.CompareString(this.txtCustomer.Text, "Cash", false) != 0;
						if (!flag20)
						{
							MessageBox.Show("Please select/enter a customer name first before confirming the sale.");
							sqlTransaction.Rollback();
							sqlConnection.Close();
							Cursor.Current = Cursors.Default;
							return;
						}
					}
					bool flag21 = MyProject.Forms.Form1.usingTables == 1;
					if (flag21)
					{
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"update [Tables] set isfree=1, takenby='",
							MyProject.Forms.Form1.username,
							"' where coid=",
							Conversions.ToString(MyProject.Forms.Form1.coid),
							" and branch='",
							MyProject.Forms.Form1.branch,
							"' and tablenumber=",
							Conversions.ToString(this.currentTable)
						});
						sqlCommand.ExecuteNonQuery();
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"update [PendingInvoices] set isdone=1 where ref=",
							Conversions.ToString(this.currentTable),
							" and entryno=",
							Conversions.ToString(this.currentTablePendingInvEntryNo),
							" and coid=",
							Conversions.ToString(MyProject.Forms.Form1.coid),
							" and branch='",
							MyProject.Forms.Form1.branch,
							"'"
						});
						sqlCommand.ExecuteNonQuery();
					}
					sqlTransaction.Commit();
					sqlConnection.Close();
					bool flag22 = MyProject.Forms.Form1.PrintReceipt == 1;
					if (flag22)
					{
						bool flag23 = MyProject.Forms.Form1.PrintFiscal == 0;
						if (flag23)
						{
							bool flag24 = MyProject.Forms.Form1.useprintercategories == 1;
							checked
							{
								if (flag24)
								{
									DataTable categoriesForInvoice = this.GetCategoriesForInvoice(this.invnum, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
									try
									{
										foreach (object obj4 in categoriesForInvoice.Rows)
										{
											DataRow dataRow3 = (DataRow)obj4;
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
									for (int i = MyProject.Forms.Form1.NumOfReceiptsPrint; i > 0; i--)
									{
										bool flag25 = MyProject.Forms.Form1.ReceiptSize80 == 1;
										if (flag25)
										{
											this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultReceiptPrinter, 0);
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
									bool flag27 = Operators.CompareString(MyProject.Forms.Form1.defaultSecondaryPrinter, "", false) != 0;
									if (flag27)
									{
										this.PrintReceipt(this.invnum, "", MyProject.Forms.Form1.defaultSecondaryPrinter, 0);
									}
								}
							}
						}
						else
						{
							bool flag28 = MyProject.Forms.Form1.PrintFiscal == 1;
							if (flag28)
							{
								bool flag29 = MyProject.Forms.Form1.FiscalEltrade == 1;
								if (flag29)
								{
									EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
									DataTable dataTable = this.createDTFromGrid(this.DataGridView1);
									string text5 = this.PrintEltradeInvoice(dataTable, this.pf.GetFiscalGroup(this.currentPayMethod, this._cnn), this.currentPayMethodDesc, Conversion.Val(this.txtAmtPaid.Text), MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, this.pf.GetEltradeFiscalCountryID(this.currentPayMethod, this._cnn), 3, MyProject.Forms.Form1.username, this.invnum, "", "", MyProject.Forms.Form1.companyname, "", this.coadd, "MOL", this.txtCustomer.Text, eltradeFprn);
									bool flag30 = Operators.CompareString(Strings.Trim(text5), "SUCCESS", false) != 0;
									if (flag30)
									{
										MessageBox.Show("Sale done. Fiscal Error. " + text5);
										eltradeFprn.Close();
									}
									else
									{
										eltradeFprn.Close();
									}
								}
								else
								{
									bool flag31 = MyProject.Forms.Form1.FiscalRevmax == 1;
									if (flag31)
									{
										string text6 = "";
										try
										{
											DataTable dataTable2 = new DataTable();
											dataTable2.Columns.Add("ProductCode", typeof(string));
											dataTable2.Columns.Add("ProductDesc", typeof(string));
											dataTable2.Columns.Add("Qty", typeof(decimal));
											dataTable2.Columns.Add("SellingPrice", typeof(decimal));
											dataTable2.Columns.Add("Total", typeof(decimal));
											dataTable2.Columns.Add("Tax", typeof(decimal));
											dataTable2.Columns.Add("Taxr", typeof(decimal));
											try
											{
												foreach (object obj5 in ((IEnumerable)this.DataGridView1.Rows))
												{
													DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj5;
													dataTable2.Rows.Add(new object[]
													{
														dataGridViewRow2.Cells["ProductCode"].Value,
														dataGridViewRow2.Cells["Desc"].Value,
														dataGridViewRow2.Cells["Qty"].Value,
														dataGridViewRow2.Cells["UnitPrice"].Value,
														dataGridViewRow2.Cells["Total"].Value,
														dataGridViewRow2.Cells["Tax"].Value,
														dataGridViewRow2.Cells["taxr"].Value
													});
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
											decimal num7 = new decimal(Conversion.Val(this.txtTotal.Text) - Conversion.Val(this.txtTax.Text));
											string text7 = this.BuildItemsXML(dataTable2);
											string text8 = this.BuildCurrencyXML(this.paymeth_currency, Convert.ToDecimal(this.txtTotal.Text), this.mono_rate);
											text6 = MyProject.Forms.Form1.myrevmax.TransactM(this.paymeth_currency, MyProject.Forms.Form1.branch, this.invnum.ToString(), this.txtCustomer.Text, "000", "na", "na", "na", num7.ToString(), this.txtTax.Text, "01", "na", "na", text7, text8);
											string[] array = text6.Split(new char[] { '#' });
											this.SaveDigSig(array[2], this.invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
											this.PrintReceipt(this.invnum, array[2], MyProject.Forms.Form1.defaultReceiptPrinter, 0);
										}
										catch (Exception ex2)
										{
											MessageBox.Show("Error fiscalising. Check settings first. Return: " + text6 + " ex:" + ex2.Message);
										}
									}
								}
							}
						}
					}
					bool flag32 = MyProject.Forms.Form1.PrintInvoice == 1;
					if (flag32)
					{
						bool flag33 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
						if (flag33)
						{
							MessageBox.Show("Cannot do fiscal invoices on this touch interface.");
						}
						else
						{
							bool flag34 = (MyProject.Forms.Form1.PrintInvoice == 1) & (MyProject.Forms.Form1.FiscalEltradeESD == 1);
							if (flag34)
							{
								MessageBox.Show("Printing invoice not enabled on this touch interface.");
							}
						}
					}
					this.ClearForm();
					this.txtBarCode.Focus();
					MessageBox.Show("Sale Done. Invoice number: " + this.invnum.ToString());
				}
				catch (Exception ex3)
				{
					try
					{
						MessageBox.Show("Error confirming sale. Attempting rollback. Detail: " + ex3.Message);
						this.Button2.TabStop = false;
						SqlTransaction sqlTransaction;
						sqlTransaction.Rollback();
						sqlConnection.Close();
						Cursor.Current = Cursors.Default;
					}
					catch (Exception ex4)
					{
					}
				}
			}
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x002ED9C8 File Offset: 0x002EBBC8
		private DataTable GetCategoriesForInvoice(int invnum, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetCategoriesForInvoice";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x002EDA5C File Offset: 0x002EBC5C
		private void ClearForm()
		{
			this.DataGridView1.Rows.Clear();
			this.txtStockAvail.Text = Conversions.ToString(0);
			this.txtPrice.Text = Conversions.ToString(0);
			this.txtQty.Text = Conversions.ToString(0);
			this.txtTotal.Text = Conversions.ToString(0);
			this.txtChange.Text = "";
			this.txtAmtPaid.Text = "";
			this.txtTax.Text = Conversions.ToString(0);
			this.txtPriceChange.Text = "";
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
			this.btnPayMethod.Enabled = true;
			this.PaymentMethodDiscountEffected = 0;
			this.isunendingstock = 0;
			this.specialprice = 0m;
			this.currentTaxRate = 0m;
			this.RowID = 0;
			this.GetPayMethDetails();
			this.txtBarCode.Focus();
			try
			{
				foreach (object obj2 in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					dataRow2["amtpaid"] = 0;
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
			this.UpdateCustomerDisplayVFD("0.00");
			this.lbldesc.Text = "";
			this.currentTable = 0;
			this.currentTablePendingInvEntryNo = 0;
			this.items_saved = true;
			MyProject.Forms.Form1.pendinginvoice_entryno = 0;
			MyProject.Forms.Form1.pendinginvoice_ref = 0;
			this.lblRef.Text = "...";
			this.currBreak = 0;
			this.currCaseQty = 0;
			this.CurrentHSCode = "";
			this.current_taxexempt = 0;
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x002EDDCC File Offset: 0x002EBFCC
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

		// Token: 0x06004EE8 RID: 20200 RVA: 0x002EDF44 File Offset: 0x002EC144
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

		// Token: 0x06004EE9 RID: 20201 RVA: 0x002EE080 File Offset: 0x002EC280
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

		// Token: 0x06004EEA RID: 20202 RVA: 0x002EE100 File Offset: 0x002EC300
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

		// Token: 0x06004EEB RID: 20203 RVA: 0x002EE20C File Offset: 0x002EC40C
		private bool CheckIFPayMethACcurate()
		{
			bool flag2;
			try
			{
				bool flag = (Convert.ToDouble(Conversion.Val(this.txtChange.Text)) < 0.0) | (Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) < Convert.ToDouble(Conversion.Val(this.txtTotal.Text)));
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
						double num3 = Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) - Convert.ToDouble(Conversion.Val(this.txtChange.Text));
						double num4 = Convert.ToDouble(Conversion.Val(this.txtTotal.Text));
						bool flag4 = Math.Round(Convert.ToDouble(Conversion.Val(this.txtAmtPaid.Text)) - Convert.ToDouble(Conversion.Val(this.txtChange.Text)), 2, MidpointRounding.AwayFromZero) != Math.Round(Convert.ToDouble(Conversion.Val(this.txtTotal.Text)), 2, MidpointRounding.AwayFromZero);
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

		// Token: 0x06004EEC RID: 20204 RVA: 0x002EE3F0 File Offset: 0x002EC5F0
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

		// Token: 0x06004EED RID: 20205 RVA: 0x002EE4A8 File Offset: 0x002EC6A8
		private void PrintReceipt(int invnumber, string revmaxdigital_signature, string printer_name, int catid)
		{
			this.PrintHeader();
			this.ItemsToBePrinted(invnumber, catid);
			this.PrintFooter(revmaxdigital_signature);
			this.stringToRead = new StringReader(this.TextToPrint);
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = printer_name;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			finally
			{
				this.stringToRead.Close();
			}
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x002EE534 File Offset: 0x002EC734
		private void PrintReceipt58(int invnumber)
		{
			this.PrintHeader58();
			this.ItemsToBePrinted58(invnumber);
			this.PrintFooter58();
			StandardPrintController standardPrintController = new StandardPrintController();
			this.PrintDocument1.PrintController = standardPrintController;
			this.PrintDocument1.Print();
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x002EE578 File Offset: 0x002EC778
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
				text = "address";
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

		// Token: 0x06004EF0 RID: 20208 RVA: 0x002EE950 File Offset: 0x002ECB50
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

		// Token: 0x06004EF1 RID: 20209 RVA: 0x002EEB58 File Offset: 0x002ECD58
		public void ItemsToBePrinted(int invnumber, int catid)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag = !this.chkAccount.Checked;
			if (flag)
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
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Invoice Number:" + Conversions.ToString(invnumber);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag2 = Operators.CompareString(this.txtCustomer.Text, "Cash", false) != 0;
			if (flag2)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + this.txtCustomer.Text;
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
			this.TextToPrint = ptr + "Description - " + this.paymeth_currency + Environment.NewLine;
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("catid", catid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag3 = num2 > 0;
			checked
			{
				if (flag3)
				{
					int num3 = 0;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							num3++;
							bool flag4 = decimal.Compare(Conversions.ToDecimal(dataRow["Unit_Selling_Price"]), 0m) != 0;
							if (flag4)
							{
								string text = Conversions.ToString(dataRow["Description"]);
								string text2 = Conversions.ToString(dataRow["UOM"]);
								bool flag5 = Operators.CompareString(text2, "EA", false) == 0;
								if (flag5)
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
								bool flag6 = num6 >= 34;
								if (flag6)
								{
									text = text.Substring(0, 33);
								}
								else
								{
									int num7 = num6;
									int num8 = 34 - num7;
									text = text.PadRight(num8);
								}
								bool flag7 = num3 == 1;
								string text5;
								if (flag7)
								{
									text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["paymethref"], Environment.NewLine), Environment.NewLine));
									bool flag8 = MyProject.Forms.Form1.ShowOrderNo == 1;
									if (flag8)
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
								}
								int length = text.Length;
								bool flag9 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
								if (flag9)
								{
									DataTable productDetailsByBarCode = this.pf.GetProductDetailsByBarCode(dataRow["Product_Code"].ToString(), this._cnn);
									DataRow dataRow3 = productDetailsByBarCode.Rows[0];
									decimal num9 = Conversions.ToDecimal(dataRow3["TaxRate"]);
									bool flag10 = decimal.Compare(num9, 0m) > 0;
									if (flag10)
									{
										text = "T: " + text;
									}
									else
									{
										text = "E: " + text;
									}
								}
								bool flag11 = num3 != 1;
								if (flag11)
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
								bool flag12 = MyProject.Forms.Form1.isRestaurant == 1;
								if (flag12)
								{
									bool flag13 = dataRow["Comments"].ToString().Length > 35;
									if (flag13)
									{
										text5 = dataRow["Comments"].ToString().Substring(0, 34) + Environment.NewLine;
										text5 = text5 + dataRow["Comments"].ToString().Substring(34, dataRow["Comments"].ToString().Length - 34) + Environment.NewLine;
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text5;
									}
									else
									{
										bool flag14 = dataRow["Comments"].ToString().Length > 0;
										if (flag14)
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

		// Token: 0x06004EF2 RID: 20210 RVA: 0x002EF310 File Offset: 0x002ED510
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
			bool flag = Operators.CompareString(this.txtCustomer.Text, "Cash", false) != 0;
			if (flag)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + this.txtCustomer.Text;
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

		// Token: 0x06004EF3 RID: 20211 RVA: 0x002EF74C File Offset: 0x002ED94C
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
				text = "Customer:" + this.txtCustomer.Text;
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
										text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["paymentmethoddesc"], ": "), Strings.Format(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["amtpaid"])), "N2")));
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
						else
						{
							text = this.btnPayMethod.Text + ": " + Strings.Format(Conversion.Val(this.txtAmtPaid.Text), "N2");
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text + Environment.NewLine;
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + Environment.NewLine;
						}
					}
				}
				text = this.TipSection(new decimal(Conversion.Val(this.lblTip.Text)));
				text += this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				bool flag9 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
				if (flag9)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + RevmaxDigital_Signature + Environment.NewLine + Environment.NewLine;
				}
			}
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x002EFDD0 File Offset: 0x002EDFD0
		private string TipSection(decimal tipamt)
		{
			bool flag = decimal.Compare(tipamt, 0m) == 0;
			string text;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					"TIP:            ",
					MyProject.Forms.Form1.basecurrency,
					"____________________",
					Environment.NewLine,
					Environment.NewLine
				});
				text = string.Concat(new string[]
				{
					text,
					"TOTAL:     ",
					MyProject.Forms.Form1.basecurrency,
					"____________________",
					Environment.NewLine
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					"TIP:            ",
					MyProject.Forms.Form1.basecurrency,
					Conversions.ToString(tipamt),
					Environment.NewLine,
					Environment.NewLine
				});
				text = string.Concat(new string[]
				{
					text,
					"TOTAL:     ",
					MyProject.Forms.Form1.basecurrency,
					this.txtTotal.Text,
					Environment.NewLine
				});
			}
			return text;
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x002EFEFC File Offset: 0x002EE0FC
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
				text = "Customer:" + this.txtCustomer.Text;
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
				text = this.btnPayMethod.Text + ": " + this.txtTotal.Text;
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

		// Token: 0x06004EF6 RID: 20214 RVA: 0x002F02B4 File Offset: 0x002EE4B4
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

		// Token: 0x06004EF7 RID: 20215 RVA: 0x002F0408 File Offset: 0x002EE608
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

		// Token: 0x06004EF8 RID: 20216 RVA: 0x002F048C File Offset: 0x002EE68C
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

		// Token: 0x06004EF9 RID: 20217 RVA: 0x002F0638 File Offset: 0x002EE838
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

		// Token: 0x06004EFA RID: 20218 RVA: 0x002F06EC File Offset: 0x002EE8EC
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

		// Token: 0x06004EFB RID: 20219 RVA: 0x002F0840 File Offset: 0x002EEA40
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

		// Token: 0x06004EFC RID: 20220 RVA: 0x002F0A38 File Offset: 0x002EEC38
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

		// Token: 0x06004EFD RID: 20221 RVA: 0x002F0AD8 File Offset: 0x002EECD8
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

		// Token: 0x06004EFE RID: 20222 RVA: 0x002F0BC0 File Offset: 0x002EEDC0
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

		// Token: 0x06004EFF RID: 20223 RVA: 0x002F0C44 File Offset: 0x002EEE44
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtQty.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x002F0CB8 File Offset: 0x002EEEB8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtBarCode.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x002F0D2C File Offset: 0x002EEF2C
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				this.SelectTable();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x002F0D7C File Offset: 0x002EEF7C
		private void SelectTable()
		{
			SelectTable selectTable = new SelectTable();
			bool flag = selectTable.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				int num = selectTable.lblCurrentTable.Text.IndexOf(":");
				string text = selectTable.lblCurrentTable.Text.Substring(0, num);
				this.currentTable = Conversions.ToInteger(text);
				this.currentTablePendingInvEntryNo = this.GetEntryNoPendingInvoices(this.currentTable);
				this.lblTable.Text = selectTable.lblCurrentTable.Text;
				this.LoadTable(this.currentTable);
			}
			else
			{
				this.currentTable = 0;
				this.currentTablePendingInvEntryNo = 0;
				this.lblTable.Text = "NO TABLE SELECTED";
			}
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x002F0E2C File Offset: 0x002EF02C
		private void LoadTable(int tableNum)
		{
			this.currentTablePendingInvEntryNo = this.GetEntryNoPendingInvoices(tableNum);
			DataTable allPendingDetails = this.GetAllPendingDetails(this.currentTablePendingInvEntryNo, tableNum);
			DataTable dataTable = this.GetallPendingInvoices(tableNum);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				MyProject.Forms.Form1.custid = Conversions.ToString(dataRow["CustomerID"]);
				MyProject.Forms.Form1.PendingItemsDAT = allPendingDetails;
				MyProject.Forms.Form1.pendinginv_paymethodid = Conversions.ToString(dataRow["paymethodid"]);
				this.UpdatePending(Conversions.ToInteger(dataRow["entryno"]), Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")), MyProject.Forms.Form1.username, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
			}
			else
			{
				DataTable dataTable2 = new DataTable();
				MyProject.Forms.Form1.custid = "CASH";
				MyProject.Forms.Form1.PendingItemsDAT = dataTable2;
				MyProject.Forms.Form1.pendinginv_paymethodid = Conversions.ToString(0);
			}
			bool flag2 = MyProject.Forms.Form1.PendingItemsDAT.Rows.Count > 0;
			if (flag2)
			{
				bool flag3 = Operators.CompareString(MyProject.Forms.Form1.custid, "Cash", false) == 0;
				if (flag3)
				{
				}
				this.DataGridView1.Rows.Clear();
				DataRow dataRow2 = MyProject.Forms.Form1.PendingItemsDAT.Rows[0];
				this.cboConsultant.Text = dataRow2["consultant"].ToString();
				try
				{
					foreach (object obj in MyProject.Forms.Form1.PendingItemsDAT.Rows)
					{
						DataRow dataRow3 = (DataRow)obj;
						string[] array = new string[]
						{
							Conversions.ToString(dataRow3["ProductID"]),
							Conversions.ToString(dataRow3["ProductCode"]),
							Conversions.ToString(dataRow3["productdesc"]),
							Conversions.ToString(dataRow3["UnitPrice"]),
							Conversions.ToString(dataRow3["Quantity"]),
							Conversions.ToString(dataRow3["Tax"]),
							Conversions.ToString(dataRow3["Total"]),
							Conversions.ToString(dataRow3["Col1"]),
							Conversions.ToString(dataRow3["CouponNumber"]),
							Conversions.ToString(dataRow3["OldPrice"]),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["pricechange"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["pricechange"]))),
							Conversions.ToString(dataRow3["isairtime"]),
							Conversions.ToString(dataRow3["MNO"]),
							Conversions.ToString(dataRow3["iswholesaleprice"]),
							Conversions.ToString(dataRow3["wholesaleqtydiscount"]),
							"",
							"",
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["DiscountAmt"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["DiscountAmt"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["BatchNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow3["BatchNumber"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["ExpiryDate"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["ExpiryDate"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["Tax"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["Tax"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["promstatus"])), "", RuntimeHelpers.GetObjectValue(dataRow3["promstatus"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["OtherDetail"])), "", RuntimeHelpers.GetObjectValue(dataRow3["OtherDetail"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["isvoucher"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["isvoucher"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["rownumber"])), "", RuntimeHelpers.GetObjectValue(dataRow3["rownumber"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["uom"])), "", RuntimeHelpers.GetObjectValue(dataRow3["uom"])))
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
				MessageBox.Show("Tab Loaded.");
				this.txtAmtPaid.Focus();
			}
			else
			{
				this.DataGridView1.Rows.Clear();
				this.CalcTotalSale();
			}
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x002F1460 File Offset: 0x002EF660
		private DataTable GetPendingItems(int entryno, string branch, int coid, string @ref)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PendingInvoicesGetDetails";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x002F1508 File Offset: 0x002EF708
		private void UpdatePending(int entryno, int reopeneddate, string reopenedby, string branch, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PendingInvoicesUpdate";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("reopeneddate", reopeneddate);
			sqlCommand.Parameters.AddWithValue("reopenedby", reopenedby);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x002F15E0 File Offset: 0x002EF7E0
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
							dataRow[0] = text2;
							string text3 = barcode.Substring(this.BCweightstartposition, this.BCweightlength);
							text3 = text3.TrimStart(new char[] { '0' });
							decimal num = decimal.Divide(Conversions.ToDecimal(text3), 1000m);
							dataRow[1] = Math.Round(num, 3);
							dataRow[2] = 1;
							dataRow[3] = 0;
							dataRow2 = dataRow;
						}
						else
						{
							bool flag4 = MyProject.Forms.Form1.BarcodePrintingScalePrice == 1;
							if (flag4)
							{
								string text4 = barcode.Substring(this.BCcodestartposition, this.BCcodelength);
								DataTable dataTable = this.FetchProductDetailsbyCode(text4);
								DataRow dataRow3 = dataTable.Rows[0];
								decimal num2 = Conversions.ToDecimal(dataRow3["SellingPrice"]);
								string text5 = barcode.Substring(this.BCpricestartposition, this.BCpricelength);
								decimal num3 = decimal.Divide(Conversions.ToDecimal(text5), 10000m);
								decimal num4 = decimal.Divide(num3, num2);
								dataRow[1] = Math.Round(num4, 3);
								dataRow[2] = 1;
								dataRow[3] = num3;
								dataRow2 = dataRow;
							}
						}
					}
					else
					{
						dataRow[0] = "0";
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

		// Token: 0x06004F07 RID: 20231 RVA: 0x002F18EC File Offset: 0x002EFAEC
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

		// Token: 0x06004F08 RID: 20232 RVA: 0x002F1A48 File Offset: 0x002EFC48
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtAmtPaid.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x002F1ABC File Offset: 0x002EFCBC
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

		// Token: 0x06004F0A RID: 20234 RVA: 0x002F1FDC File Offset: 0x002F01DC
		private void EnableForm()
		{
			this.Panel1.Visible = true;
			this.GroupBox2.Visible = true;
			this.GroupBox3.Visible = true;
			this.btnShift.Visible = true;
			this.btnstartshift.Visible = false;
			this.DataGridView1.Visible = true;
			this.btnClose.Visible = true;
			this.LoadCategories();
			this.LoadFavProducts();
			this.PanelProducts.Visible = true;
			this.ShowSecondScreen();
			this.txtBarCode.Focus();
			this.lblUser.Text = "By: " + MyProject.Forms.Form1.username;
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x002F2098 File Offset: 0x002F0298
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

		// Token: 0x06004F0C RID: 20236 RVA: 0x002F2104 File Offset: 0x002F0304
		private void btnShift_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure your shift has ended and you want to exit?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.CloseShift(Conversions.ToInteger(this.lblShift.Text), MyProject.Forms.Form1.coid, DateAndTime.TimeOfDay.ToString("HHmm"), Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
					bool flag2 = MyProject.Forms.Form1.IsBlindCashUp == 0;
					if (flag2)
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

		// Token: 0x06004F0D RID: 20237 RVA: 0x002F2208 File Offset: 0x002F0408
		private void btnstartshift_Click(object sender, EventArgs e)
		{
			try
			{
				this.CheckShiftStatus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error starting shift. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x002F2258 File Offset: 0x002F0458
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

		// Token: 0x06004F0F RID: 20239 RVA: 0x002F235C File Offset: 0x002F055C
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

		// Token: 0x06004F10 RID: 20240 RVA: 0x002F23E8 File Offset: 0x002F05E8
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

		// Token: 0x06004F11 RID: 20241 RVA: 0x002F24A0 File Offset: 0x002F06A0
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

		// Token: 0x06004F12 RID: 20242 RVA: 0x002F25E0 File Offset: 0x002F07E0
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

		// Token: 0x06004F13 RID: 20243 RVA: 0x002F2684 File Offset: 0x002F0884
		private void Button8_Click_1(object sender, EventArgs e)
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

		// Token: 0x06004F14 RID: 20244 RVA: 0x002F26FC File Offset: 0x002F08FC
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

		// Token: 0x06004F15 RID: 20245 RVA: 0x002F2884 File Offset: 0x002F0A84
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				try
				{
					this.txtStockAvail.Text = Conversions.ToString(0);
					this.txtPrice.Text = Conversions.ToString(0);
					this.txtQty.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
					this.lbldesc.Text = "No product matches your search.";
					bool flag2 = MyProject.Forms.Form1.usingBarcodePrintingScale == 1;
					if (flag2)
					{
						DataRow butcheryProductDetails = this.GetButcheryProductDetails(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
						bool flag3 = Operators.ConditionalCompareObjectEqual(butcheryProductDetails["isvalidbutchery"], 1, false);
						if (flag3)
						{
							this.LoadProduct(this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(butcheryProductDetails["productcode"]), this._cnn));
							this.txtQty.Text = butcheryProductDetails["productqty"].ToString();
							this.txtQty.ReadOnly = true;
							this.EnterItem();
						}
						else
						{
							this.LoadProduct(this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(butcheryProductDetails["productcode"]), this._cnn));
							this.EnterItem();
						}
					}
					else
					{
						this.LoadProduct(this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, this.txtBarCode.Text, this._cnn));
						this.EnterItem();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Barcode error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x002F2A98 File Offset: 0x002F0C98
		private void Button10_Click(object sender, EventArgs e)
		{
			try
			{
				this.ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error clearing form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x002F2AE8 File Offset: 0x002F0CE8
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveTableInvoice();
				MessageBox.Show("Invoice for ref: " + this.lblRef.Text + " has been updated successfully.");
				this.ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error clearing line. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x002F2B60 File Offset: 0x002F0D60
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
							this.txtBarCode.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error DGV Cell Click. Details: " + ex.Message);
			}
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x002F2C98 File Offset: 0x002F0E98
		private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				this.items_saved = false;
				this.CalcTotalSale();
				this.txtBarCode.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deletting row. Restart SALE.");
			}
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x002F2CF0 File Offset: 0x002F0EF0
		private void txtAmtPaid_KeyDown(object sender, KeyEventArgs e)
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
			}
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x002F2D40 File Offset: 0x002F0F40
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.UseConnectedScale == 1;
				if (flag)
				{
					MyProject.Forms.Form1.receiveSerialPortData = false;
					ProjectData.EndApp();
				}
				base.Dispose();
			}
			catch (Exception ex)
			{
				base.Dispose();
			}
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x002F2DB0 File Offset: 0x002F0FB0
		private void GetScaleSettings()
		{
			this.sScale.BaudRate = "9600";
			this.sScale.Parity = "0";
			this.sScale.StopBits = "1";
			this.sScale.DataBits = "8";
			this.sScale.PortName = "COM" + Conversions.ToString(MyProject.Forms.Form1.ConnectedScalePortNum);
			this.sScale.TextWindow = this.txtQtyWeighed;
			bool flag = !this.sScale.comPort.IsOpen;
			if (flag)
			{
				this.sScale.OpenPort(MyProject.Forms.Form1.scaleType);
			}
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x002F2E74 File Offset: 0x002F1074
		private void txtQtyWeighed_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblCurrCalc.Text = Math.Round(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtQtyWeighed.Text), 2, MidpointRounding.AwayFromZero).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x002F2EE4 File Offset: 0x002F10E4
		private void txtPrice_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblCurrCalc.Text = Math.Round(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtQtyWeighed.Text), 2, MidpointRounding.AwayFromZero).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x002F2F54 File Offset: 0x002F1154
		private void SalesTouchScreen_Disposed(object sender, EventArgs e)
		{
			try
			{
				this.UpdateCustomerDisplayVFD("0.00");
				bool isOpen = this.sScale.comPort.IsOpen;
				if (isOpen)
				{
					this.sScale.comPort.Close();
				}
				this.sScale.comPort.Dispose();
				base.Dispose();
			}
			catch (Exception ex)
			{
				base.Dispose();
			}
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x002F2FD8 File Offset: 0x002F11D8
		private void Button11_Click_1(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				bool isOpen = this.sScale.comPort.IsOpen;
				if (isOpen)
				{
					this.sScale.comPort.Close();
				}
				this.GetScaleSettings();
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error refreshing scale. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x002F3070 File Offset: 0x002F1270
		private void btnSave_Click(object sender, EventArgs e)
		{
			checked
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
						this.@ref = MyProject.Forms.Form1.ref2;
						this.lblRef.Text = this.@ref;
						this.txtCustomer.Text = this.@ref;
						bool flag2 = Operators.CompareString(MyProject.Forms.Form1.custid, "Cash", false) == 0;
						if (flag2)
						{
						}
						this.DataGridView1.Rows.Clear();
						DataRow dataRow = MyProject.Forms.Form1.PendingItemsDAT.Rows[0];
						this.cboConsultant.SelectedIndex = this.cboConsultant.FindStringExact(dataRow["consultant"].ToString());
						int num = 0;
						try
						{
							foreach (object obj in MyProject.Forms.Form1.PendingItemsDAT.Rows)
							{
								DataRow dataRow2 = (DataRow)obj;
								bool flag3 = MyProject.Forms.Form1.isRestaurant == 0;
								if (flag3)
								{
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
										Conversions.ToString(num),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["uom"])), "", RuntimeHelpers.GetObjectValue(dataRow2["uom"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["break"])), "0", RuntimeHelpers.GetObjectValue(dataRow2["break"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["breakqty"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["breakqty"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BreakParentProductID"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["BreakParentProductID"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["ActualBreakQty"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["ActualBreakQty"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["taxexempt"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["altdesc"])), "", RuntimeHelpers.GetObjectValue(dataRow2["altdesc"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["hscode"])), "", RuntimeHelpers.GetObjectValue(dataRow2["hscode"]))),
										"0"
									};
									this.DataGridView1.Rows.Add(array);
								}
								else
								{
									string[] array2 = new string[]
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
										"",
										Conversions.ToString(num),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["uom"])), "", RuntimeHelpers.GetObjectValue(dataRow2["uom"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["break"])), "0", RuntimeHelpers.GetObjectValue(dataRow2["break"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["breakqty"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["breakqty"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["BreakParentProductID"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["BreakParentProductID"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["ActualBreakQty"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["ActualBreakQty"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["taxexempt"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["isdeposits"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["altdesc"])), "", RuntimeHelpers.GetObjectValue(dataRow2["altdesc"]))),
										Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["hscode"])), "", RuntimeHelpers.GetObjectValue(dataRow2["hscode"]))),
										"0"
									};
									this.DataGridView1.Rows.Add(array2);
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
						this.CalcTotalSale();
						MyProject.Forms.Form1.PendingItemsDAT.Clear();
						bool flag4 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
						if (flag4)
						{
							this.txtBarCode.Focus();
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
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x002F3DBC File Offset: 0x002F1FBC
		private void UpdateTableTaken(int isfree)
		{
			bool flag = this.currentTable != 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"update [Tables] set isfree=",
					Conversions.ToString(isfree),
					", takenby='",
					MyProject.Forms.Form1.username,
					"' where coid=",
					Conversions.ToString(MyProject.Forms.Form1.coid),
					" and branch='",
					MyProject.Forms.Form1.branch,
					"' and tablenumber=",
					Conversions.ToString(this.currentTable)
				});
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
			}
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x002F3EBC File Offset: 0x002F20BC
		private int GetEntryNoPendingInvoices(int current_table)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select isnull(entryno,0) from PendingInvoices where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"' and savedby='",
				MyProject.Forms.Form1.username,
				"' and isdone=0 and datesaved=",
				DateTime.Today.ToString("yyyyMMdd"),
				" and ref=",
				Conversions.ToString(current_table)
			});
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x002F3FC0 File Offset: 0x002F21C0
		private DataTable GetallPendingInvoices(int current_table)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select * from PendingInvoices where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"' and savedby='",
				MyProject.Forms.Form1.username,
				"' and isdone=0 and ref=",
				Conversions.ToString(current_table)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x002F407C File Offset: 0x002F227C
		private DataTable GetAllPendingDetails(int entryno, int tableref)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select * from PendingInvoiceDetail where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"' and ref=",
				Conversions.ToString(tableref),
				" and entryno=",
				Conversions.ToString(entryno)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x002F4130 File Offset: 0x002F2330
		private bool SaveTableInvoice()
		{
			bool flag3;
			try
			{
				bool flag = this.DataGridView1.RowCount < 1;
				if (flag)
				{
					MessageBox.Show("Please select items for the quotation before saving.");
					bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag2)
					{
						this.txtBarCode.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
					flag3 = false;
				}
				else
				{
					bool flag4 = MyProject.Forms.Form1.ConsultantSalesOnly == 1;
					if (flag4)
					{
						bool flag5 = Operators.CompareString(this.cboConsultant.Text, "", false) == 0;
						if (flag5)
						{
							MessageBox.Show("Please select a consultant first.");
							this.cboConsultant.Focus();
							return false;
						}
					}
					bool flag6 = MyProject.Forms.Form1.pendinginvoice_entryno == 0;
					if (flag6)
					{
						string text = "Enter a reference or name of the customer";
						string text2 = "Enter Pending Invoice Details";
						string text3 = "";
						object obj = Interaction.InputBox(text, text2, text3, -1, -1);
						bool flag7 = Operators.CompareString(obj.ToString(), "", false) == 0;
						if (flag7)
						{
							MessageBox.Show("No name given. Cannot proceed. TRY AGAIN");
							return false;
						}
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
							sqlCommand.Parameters.AddWithValue("CustomerID", this.txtCustomer.Text);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("consultant", this.cboConsultant.Text);
							sqlCommand.Parameters.AddWithValue("new_entryno", num2);
							sqlCommand.Parameters.AddWithValue("paymethodid", this.currentPayMethod);
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
									sqlCommand.Parameters.AddWithValue("couponnumber", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CouponNumber"].Value)));
									sqlCommand.Parameters.AddWithValue("oldprice", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value)));
									sqlCommand.Parameters.AddWithValue("pricechange", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PriceChange"].Value)));
									sqlCommand.Parameters.AddWithValue("isairtime", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isairtime"].Value)));
									string text4 = dataGridViewRow.Cells["MNO"].Value.ToString();
									bool flag8 = Operators.CompareString(text4, "", false) == 0;
									int num3;
									if (flag8)
									{
										num3 = 0;
									}
									else
									{
										num3 = Conversions.ToInteger(dataGridViewRow.Cells["MNO"].Value);
									}
									sqlCommand.Parameters.AddWithValue("mno", num3);
									sqlCommand.Parameters.AddWithValue("iswholesaleprice", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["iswholesaleprice"].Value)));
									sqlCommand.Parameters.AddWithValue("wholesaleqtydiscount", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["wholesaleqtydiscount"].Value)));
									sqlCommand.Parameters.AddWithValue("entryno", num2);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("consultant", this.cboConsultant.Text);
									sqlCommand.Parameters.AddWithValue("promstatus", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PromStatus"].Value));
									sqlCommand.Parameters.AddWithValue("BatchNumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
									sqlCommand.Parameters.AddWithValue("ExpiryDate", Conversions.ToInteger(dataGridViewRow.Cells["ExpiryDate"].Value));
									sqlCommand.Parameters.AddWithValue("DiscountAmt", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value))));
									sqlCommand.Parameters.AddWithValue("otherdetail", dataGridViewRow.Cells["OtherDetail"].Value.ToString());
									sqlCommand.Parameters.AddWithValue("isvoucher", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["isvoucher"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["isvoucher"].Value))));
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
									bool flag9 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["isdeposits"].Value, null, false);
									string text5;
									if (flag9)
									{
										text5 = "";
									}
									else
									{
										text5 = Conversions.ToString(dataGridViewRow.Cells["isdeposits"].Value);
									}
									bool flag10 = Operators.CompareString(text5, "", false) != 0;
									if (flag10)
									{
										num4 = Conversions.ToInteger(dataGridViewRow.Cells["isdeposits"].Value);
									}
									sqlCommand.Parameters.AddWithValue("isdeposits", num4);
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
							MessageBox.Show("Invoice saved as pending. Ref number: " + num.ToString());
							return true;
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error saving quotation for invoicing. Detail: " + ex.Message);
							try
							{
								sqlTransaction.Rollback();
								sqlConnection.Close();
								flag3 = false;
								ProjectData.ClearProjectError();
								return flag3;
							}
							catch (Exception ex2)
							{
								return false;
							}
						}
					}
					this.UpdatePendingInv();
					flag3 = true;
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error saving quotation. Detail: " + ex3.Message);
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x002F4EA0 File Offset: 0x002F30A0
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

		// Token: 0x06004F28 RID: 20264 RVA: 0x002F57D8 File Offset: 0x002F39D8
		private void txtAmtPaid_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtAmtPaid.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x002F584C File Offset: 0x002F3A4C
		private void Button11_Click_2(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.SaveTableInvoice();
				if (flag)
				{
					this.PrintHeaderQuotation(this.SaveQuotation(), false);
					this.ItemsToBePrintedQuotation(false);
					this.PrintFooterQuotation(false);
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
					this.ClearForm();
					MessageBox.Show("Quotation print job sent to printer.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x002F5964 File Offset: 0x002F3B64
		private void PrintHeaderQuotation(int quotation_num, bool isLastOrder)
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
				text3 = this.coadd;
				num = text3.Length;
				string text5 = new string(' ', (int)Math.Round(Math.Round((double)(100 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text5 + text3 + Environment.NewLine;
				bool flag = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag)
				{
					text3 = "Email: " + this.coemail;
					num = text3.Length;
					string text6 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text6 + text3 + Environment.NewLine;
				}
				bool flag2 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag2)
				{
					text3 = this.cotel;
					num = text3.Length;
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text7 + text3 + Environment.NewLine;
				}
				bool flag3 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag3)
				{
					text3 = this.cotel2 + "  " + this.cotel3;
					num = text3.Length;
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text3 + Environment.NewLine;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text3 = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				if (isLastOrder)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "ITEMS LAST ORDERED" + Environment.NewLine + Environment.NewLine;
				}
				text3 = "Teller: " + MyProject.Forms.Form1.username;
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
			}
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x002F5CB4 File Offset: 0x002F3EB4
		private void ItemsToBePrintedQuotation(bool isLastOrder)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag = Operators.CompareString(this.txtCustomer.Text, "Cash", false) != 0;
			if (flag)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + this.txtCustomer.Text;
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
			this.TextToPrint = ptr + "Payment Method: " + this.btnPayMethod.Text;
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
						bool flag2 = (isLastOrder & (Operators.CompareString(dataGridViewRow.Cells["NewOrder"].Value.ToString(), "1", false) == 0)) | !isLastOrder;
						if (flag2)
						{
							string text = dataGridViewRow.Cells["Desc"].Value.ToString();
							string text2 = dataGridViewRow.Cells["Desc"].Value.ToString();
							num = Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value);
							double num2 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)));
							double num3 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
							string text3 = dataGridViewRow.Cells["ProductCode"].Value.ToString();
							string text4 = "";
							int num4 = (int)Math.Round(Conversion.Val(text.Length));
							bool flag3 = num4 >= 41;
							if (flag3)
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
							bool flag4 = text.Length > 0;
							if (flag4)
							{
								text5 = text5 + Environment.NewLine + text4;
							}
							string text6 = Conversions.ToString(text5.Length);
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text5 + Environment.NewLine;
							decimal num7 = 0m;
							string text7 = "               ";
							bool flag5 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
							if (flag5)
							{
								decimal num8 = new decimal(unchecked(num2 * Convert.ToDouble(this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn))));
								num7 = decimal.Multiply(num8, num);
								string text8 = Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True);
								int length = num8.ToString().Length;
								int i = length - 5;
								bool flag6 = i > 0;
								if (flag6)
								{
									while (i > 0)
									{
										text7 = text7.Substring(0, text7.Length - 1);
										i--;
									}
								}
								else
								{
									bool flag7 = i < 0;
									if (flag7)
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
								bool flag8 = j > 0;
								if (flag8)
								{
									while (j > 0)
									{
										text7 = text7.Substring(0, text7.Length - 1);
										j--;
									}
								}
								else
								{
									bool flag9 = j < 0;
									if (flag9)
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

		// Token: 0x06004F2C RID: 20268 RVA: 0x002F6270 File Offset: 0x002F4470
		private void PrintFooterQuotation(bool isLastOrder)
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
					if (isLastOrder)
					{
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["NewOrder"].Value, "1", false);
						if (flag)
						{
							num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
							num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
						}
					}
					else
					{
						num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
						num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
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
			string text = "Tax         " + Strings.FormatCurrency(num2.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
			string text2 = Conversions.ToString(text.Length);
			int length = text.Length;
			checked
			{
				string text3 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag2 = !isLastOrder;
				if (flag2)
				{
					bool flag3 = Operators.CompareString(text, "Tax         $0.00", false) != 0;
					if (flag3)
					{
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + text + Environment.NewLine;
					}
				}
			}
			if (isLastOrder)
			{
				bool flag4 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				if (flag4)
				{
					decimal num3 = new decimal(num * Convert.ToDouble(this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn)));
					text = "Current Invoice Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				else
				{
					text = "Current Invoice Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
			}
			else
			{
				bool flag5 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				if (flag5)
				{
					decimal num4 = new decimal(num * Convert.ToDouble(this.pf.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod, this._cnn)));
					text = "Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				else
				{
					text = "Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
			}
			text2 = Conversions.ToString(length);
			checked
			{
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
				text = "Customer:" + this.txtCustomer.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag6 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag6)
				{
					bool @checked = this.chkAccount.Checked;
					if (@checked)
					{
					}
				}
				if (!isLastOrder)
				{
					text = this.TipSection(new decimal(Conversion.Val(this.lblTip.Text)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				text = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x002F66C0 File Offset: 0x002F48C0
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
							sqlCommand.Parameters.AddWithValue("customerref", this.txtCustomer.Text);
							sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("createddate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("paymentmethod", this.btnPayMethod.Text);
							sqlCommand.Parameters.AddWithValue("quotationnumber", num);
							sqlCommand.Parameters.AddWithValue("discamt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value));
							sqlCommand.Parameters.AddWithValue("customerentryno", 1);
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

		// Token: 0x06004F2E RID: 20270 RVA: 0x002F6B9C File Offset: 0x002F4D9C
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				new TIP
				{
					invamt = new decimal(Conversion.Val(this.txtTotal.Text))
				}.ShowDialog();
				this.lblTip.Text = Conversions.ToString(MyProject.Forms.Form1.tipamt);
				this.CalcTotalSale();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error noting TIP amount. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x002F6C34 File Offset: 0x002F4E34
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
				sqlCommand.Parameters.AddWithValue("OrderNo", "");
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

		// Token: 0x06004F30 RID: 20272 RVA: 0x002F6F04 File Offset: 0x002F5104
		private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.IsAdmin | MyProject.Forms.Form1.IsSupervisor;
				if (!flag)
				{
					bool flag2 = Operators.CompareString(this.lblRef.Text, "...", false) != 0;
					if (flag2)
					{
						MessageBox.Show("Cannot delete. Check with your supervisor.");
						e.Cancel = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x002F6F90 File Offset: 0x002F5190
		private void Button13_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.SaveTableInvoice();
				if (flag)
				{
					this.PrintHeaderQuotation(this.SaveQuotation(), true);
					this.ItemsToBePrintedQuotation(true);
					this.PrintFooterQuotation(true);
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
					this.ClearForm();
					MessageBox.Show("Quotation print job sent to printer.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x002F70A8 File Offset: 0x002F52A8
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
						bool flag4 = Operators.CompareString(this.lblRef.Text, "...", false) != 0;
						if (flag4)
						{
							DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Do you want to SAVE?", MsgBoxStyle.YesNo, null);
							bool flag5 = dialogResult2 == DialogResult.Yes;
							if (flag5)
							{
								this.SaveTableInvoice();
							}
						}
					}
				}
				else
				{
					ApprovalForm approvalForm = new ApprovalForm();
					approvalForm.lblHeader.Text = "Enter Admin/Supervisor credentials to delete selected row.";
					approvalForm.ShowDialog();
					approvalForm.Dispose();
					bool flag6 = !MyProject.Forms.Form1.approved;
					if (flag6)
					{
						bool flag7 = Operators.CompareString(this.lblRef.Text, "...", false) != 0;
						if (flag7)
						{
							MessageBox.Show("Cannot delete. Check with your supervisor.");
						}
					}
					else
					{
						this.DataGridView1.Rows.Remove(this.DataGridView1.SelectedRows[0]);
						this.CalcTotalSale();
						bool flag8 = Operators.CompareString(this.lblRef.Text, "...", false) != 0;
						if (flag8)
						{
							DialogResult dialogResult3 = (DialogResult)Interaction.MsgBox("Do you want to SAVE?", MsgBoxStyle.YesNo, null);
							bool flag9 = dialogResult3 == DialogResult.Yes;
							if (flag9)
							{
								this.SaveTableInvoice();
							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x002F7280 File Offset: 0x002F5480
		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.DataGridView1.SelectedRows.Count == 1;
			if (flag)
			{
				this.DeleteSelectedRow();
			}
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x002F72B0 File Offset: 0x002F54B0
		private void btnEnterDisc_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtPrice.Text, "", false) != 0;
				if (flag)
				{
					SupervisorApproval supervisorApproval = new SupervisorApproval();
					supervisorApproval.prod_desc = "Product: " + this.lbldesc.Text;
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

		// Token: 0x0400230F RID: 8975
		private string _cnn;

		// Token: 0x04002310 RID: 8976
		private decimal wholesaleQty;

		// Token: 0x04002311 RID: 8977
		private int isunendingstock;

		// Token: 0x04002312 RID: 8978
		private PublicFunctions pf;

		// Token: 0x04002313 RID: 8979
		private int discPaymentMethod;

		// Token: 0x04002314 RID: 8980
		private decimal discAmount;

		// Token: 0x04002315 RID: 8981
		private int PaymentMethodDiscountEffected;

		// Token: 0x04002316 RID: 8982
		private decimal currentWholesaleQty;

		// Token: 0x04002317 RID: 8983
		private decimal WholesalePriceByQty;

		// Token: 0x04002318 RID: 8984
		private decimal mono_rate;

		// Token: 0x04002319 RID: 8985
		private decimal specialprice;

		// Token: 0x0400231A RID: 8986
		private decimal priceb4tax;

		// Token: 0x0400231B RID: 8987
		private decimal priceb4taxWholesale;

		// Token: 0x0400231C RID: 8988
		private decimal taxdueWholesale;

		// Token: 0x0400231D RID: 8989
		private decimal totpriceWholesale;

		// Token: 0x0400231E RID: 8990
		private decimal currentTaxRate;

		// Token: 0x0400231F RID: 8991
		private int currentID;

		// Token: 0x04002320 RID: 8992
		private int currentExpires;

		// Token: 0x04002321 RID: 8993
		private string currentCode;

		// Token: 0x04002322 RID: 8994
		private string currentUOM;

		// Token: 0x04002323 RID: 8995
		private bool currentIsWeighed;

		// Token: 0x04002324 RID: 8996
		private int currentPayMethod;

		// Token: 0x04002325 RID: 8997
		private string currentPayMethodDesc;

		// Token: 0x04002326 RID: 8998
		private int currentTable;

		// Token: 0x04002327 RID: 8999
		private int currentTablePendingInvEntryNo;

		// Token: 0x04002328 RID: 9000
		private decimal paymeth_rate;

		// Token: 0x04002329 RID: 9001
		private int paymeth_fiscalgroup;

		// Token: 0x0400232A RID: 9002
		private string paymeth_desc;

		// Token: 0x0400232B RID: 9003
		private string paymeth_currency;

		// Token: 0x0400232C RID: 9004
		private bool paymeth_requiresref;

		// Token: 0x0400232D RID: 9005
		private decimal discTeller;

		// Token: 0x0400232E RID: 9006
		private decimal discCoupons;

		// Token: 0x0400232F RID: 9007
		private decimal discPromotion;

		// Token: 0x04002330 RID: 9008
		private string discPromotionName;

		// Token: 0x04002331 RID: 9009
		private string discDESC;

		// Token: 0x04002332 RID: 9010
		private DataTable datProm;

		// Token: 0x04002333 RID: 9011
		private string TextToPrint;

		// Token: 0x04002334 RID: 9012
		private int invnum;

		// Token: 0x04002335 RID: 9013
		private StringReader stringToRead;

		// Token: 0x04002336 RID: 9014
		private string coname;

		// Token: 0x04002337 RID: 9015
		private string coadd;

		// Token: 0x04002338 RID: 9016
		private string cotel;

		// Token: 0x04002339 RID: 9017
		private string coemail;

		// Token: 0x0400233A RID: 9018
		private string cobpnum;

		// Token: 0x0400233B RID: 9019
		private string footnote;

		// Token: 0x0400233C RID: 9020
		private string cotel2;

		// Token: 0x0400233D RID: 9021
		private string cotel3;

		// Token: 0x0400233E RID: 9022
		private string coVATNum;

		// Token: 0x0400233F RID: 9023
		private int BCweightlength;

		// Token: 0x04002340 RID: 9024
		private int BCweightstartposition;

		// Token: 0x04002341 RID: 9025
		private int BCpricelength;

		// Token: 0x04002342 RID: 9026
		private int BCpricestartposition;

		// Token: 0x04002343 RID: 9027
		private int BCcodestartposition;

		// Token: 0x04002344 RID: 9028
		private int BCcodelength;

		// Token: 0x04002345 RID: 9029
		private int BCstartchar;

		// Token: 0x04002346 RID: 9030
		private int RowID;

		// Token: 0x04002347 RID: 9031
		private clsScale sScale;

		// Token: 0x04002348 RID: 9032
		private bool items_saved;

		// Token: 0x04002349 RID: 9033
		private string @ref;

		// Token: 0x0400234A RID: 9034
		private int currBreak;

		// Token: 0x0400234B RID: 9035
		private bool isunedingstock;

		// Token: 0x0400234C RID: 9036
		private int currParentCaseID;

		// Token: 0x0400234D RID: 9037
		private int currCaseQty;

		// Token: 0x0400234E RID: 9038
		private string CurrentHSCode;

		// Token: 0x0400234F RID: 9039
		private int BreakQtyActual;

		// Token: 0x04002350 RID: 9040
		private int currentIsDeposit;

		// Token: 0x04002351 RID: 9041
		private int current_taxexempt;
	}
}
