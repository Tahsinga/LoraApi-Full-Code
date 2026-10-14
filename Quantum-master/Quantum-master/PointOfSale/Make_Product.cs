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
	// Token: 0x0200006D RID: 109
	[DesignerGenerated]
	public partial class Make_Product : Form
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x000E55B8 File Offset: 0x000E37B8
		public Make_Product()
		{
			base.Load += this.Make_Product_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x000E770A File Offset: 0x000E590A
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x000E7714 File Offset: 0x000E5914
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x000E771D File Offset: 0x000E591D
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x000E7727 File Offset: 0x000E5927
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000E7730 File Offset: 0x000E5930
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x000E773C File Offset: 0x000E593C
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000E779A File Offset: 0x000E599A
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x000E77A4 File Offset: 0x000E59A4
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000E77AD File Offset: 0x000E59AD
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x000E77B8 File Offset: 0x000E59B8
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

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000E77FB File Offset: 0x000E59FB
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x000E7805 File Offset: 0x000E5A05
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x000E780E File Offset: 0x000E5A0E
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x000E7818 File Offset: 0x000E5A18
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

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x000E785B File Offset: 0x000E5A5B
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x000E7868 File Offset: 0x000E5A68
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

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x000E78AB File Offset: 0x000E5AAB
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x000E78B8 File Offset: 0x000E5AB8
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
				TextBox textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQty = value;
				textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x000E78FB File Offset: 0x000E5AFB
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x000E7905 File Offset: 0x000E5B05
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x000E790E File Offset: 0x000E5B0E
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x000E7918 File Offset: 0x000E5B18
		internal virtual ComboBox cboFormualas
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x000E7921 File Offset: 0x000E5B21
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x000E792B File Offset: 0x000E5B2B
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x000E7934 File Offset: 0x000E5B34
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x000E793E File Offset: 0x000E5B3E
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000E7947 File Offset: 0x000E5B47
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x000E7951 File Offset: 0x000E5B51
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000E795A File Offset: 0x000E5B5A
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x000E7964 File Offset: 0x000E5B64
		internal virtual DataGridView dgvIngridients
		{
			[CompilerGenerated]
			get
			{
				return this._dgvIngridients;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.dgvIngridients_Validated);
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.dgvBatches_EditingControlShowing);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvIngridients_CellValidated);
				DataGridView dataGridView = this._dgvIngridients;
				if (dataGridView != null)
				{
					dataGridView.Validated -= eventHandler;
					dataGridView.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
					dataGridView.CellValidated -= dataGridViewCellEventHandler;
				}
				this._dgvIngridients = value;
				dataGridView = this._dgvIngridients;
				if (dataGridView != null)
				{
					dataGridView.Validated += eventHandler;
					dataGridView.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
					dataGridView.CellValidated += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x000E79DD File Offset: 0x000E5BDD
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x000E79E7 File Offset: 0x000E5BE7
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x000E79F0 File Offset: 0x000E5BF0
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x000E79FA File Offset: 0x000E5BFA
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x000E7A03 File Offset: 0x000E5C03
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x000E7A0D File Offset: 0x000E5C0D
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x000E7A16 File Offset: 0x000E5C16
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x000E7A20 File Offset: 0x000E5C20
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x000E7A29 File Offset: 0x000E5C29
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x000E7A33 File Offset: 0x000E5C33
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x000E7A3C File Offset: 0x000E5C3C
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x000E7A46 File Offset: 0x000E5C46
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x000E7A4F File Offset: 0x000E5C4F
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x000E7A59 File Offset: 0x000E5C59
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x000E7A62 File Offset: 0x000E5C62
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x000E7A6C File Offset: 0x000E5C6C
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

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x000E7AAF File Offset: 0x000E5CAF
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x000E7AB9 File Offset: 0x000E5CB9
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x000E7AC2 File Offset: 0x000E5CC2
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x000E7ACC File Offset: 0x000E5CCC
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

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000E7B0F File Offset: 0x000E5D0F
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x000E7B1C File Offset: 0x000E5D1C
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

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x000E7B5F File Offset: 0x000E5D5F
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x000E7B6C File Offset: 0x000E5D6C
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

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x000E7BAF File Offset: 0x000E5DAF
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x000E7BB9 File Offset: 0x000E5DB9
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x000E7BC2 File Offset: 0x000E5DC2
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x000E7BCC File Offset: 0x000E5DCC
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x000E7BD5 File Offset: 0x000E5DD5
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x000E7BDF File Offset: 0x000E5DDF
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x000E7BE8 File Offset: 0x000E5DE8
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x000E7BF2 File Offset: 0x000E5DF2
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x000E7BFB File Offset: 0x000E5DFB
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x000E7C05 File Offset: 0x000E5E05
		internal virtual Label lblBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000E7C0E File Offset: 0x000E5E0E
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x000E7C18 File Offset: 0x000E5E18
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x000E7C21 File Offset: 0x000E5E21
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x000E7C2B File Offset: 0x000E5E2B
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x000E7C34 File Offset: 0x000E5E34
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x000E7C3E File Offset: 0x000E5E3E
		internal virtual TextBox txtNewSellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x000E7C47 File Offset: 0x000E5E47
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x000E7C51 File Offset: 0x000E5E51
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000E7C5A File Offset: 0x000E5E5A
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x000E7C64 File Offset: 0x000E5E64
		internal virtual Label lblselling
		{
			[CompilerGenerated]
			get
			{
				return this._lblselling;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lblselling_TextChanged);
				Label label = this._lblselling;
				if (label != null)
				{
					label.TextChanged -= eventHandler;
				}
				this._lblselling = value;
				label = this._lblselling;
				if (label != null)
				{
					label.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000E7CA7 File Offset: 0x000E5EA7
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x000E7CB1 File Offset: 0x000E5EB1
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000E7CBA File Offset: 0x000E5EBA
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x000E7CC4 File Offset: 0x000E5EC4
		internal virtual TextBox txtNewCostPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000E7CCD File Offset: 0x000E5ECD
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x000E7CD7 File Offset: 0x000E5ED7
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x000E7CE0 File Offset: 0x000E5EE0
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x000E7CEA File Offset: 0x000E5EEA
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x000E7CF3 File Offset: 0x000E5EF3
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x000E7CFD File Offset: 0x000E5EFD
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x000E7D06 File Offset: 0x000E5F06
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x000E7D10 File Offset: 0x000E5F10
		internal virtual TextBox txtBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x000E7D19 File Offset: 0x000E5F19
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x000E7D23 File Offset: 0x000E5F23
		internal virtual Label lbltxtbatchnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x000E7D2C File Offset: 0x000E5F2C
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x000E7D36 File Offset: 0x000E5F36
		internal virtual Label lblDTExpirydate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x000E7D3F File Offset: 0x000E5F3F
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x000E7D4C File Offset: 0x000E5F4C
		internal virtual DateTimePicker DTExpiryDate
		{
			[CompilerGenerated]
			get
			{
				return this._DTExpiryDate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DTExpiryDate_ValueChanged);
				DateTimePicker dateTimePicker = this._DTExpiryDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DTExpiryDate = value;
				dateTimePicker = this._DTExpiryDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000E7D90 File Offset: 0x000E5F90
		private void Make_Product_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.DateChange == 1;
				if (flag)
				{
					this.DTDate.Enabled = true;
				}
				else
				{
					this.DTDate.Enabled = false;
				}
				this.lblBranch.Text = MyProject.Forms.Form1.branch;
				this.DTExpiryDate.Format = DateTimePickerFormat.Custom;
				this.DTExpiryDate.CustomFormat = " ";
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 0;
				if (flag2)
				{
					this.lblDTExpirydate.Visible = false;
					this.lbltxtbatchnumber.Visible = false;
					this.DTExpiryDate.Visible = false;
					this.txtBatchNumber.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000E7E94 File Offset: 0x000E6094
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

		// Token: 0x06001946 RID: 6470 RVA: 0x000E7F1C File Offset: 0x000E611C
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

		// Token: 0x06001947 RID: 6471 RVA: 0x000E8014 File Offset: 0x000E6214
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

		// Token: 0x06001948 RID: 6472 RVA: 0x000E8120 File Offset: 0x000E6320
		private object searchDat(DataTable dt, string column, string value)
		{
			Make_Product._Closure$__204-0 CS$<>8__locals1 = new Make_Product._Closure$__204-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((Make_Product._Closure$__.$I204-0 == null) ? (Make_Product._Closure$__.$I204-0 = (object row1) => (DataRow)row1) : Make_Product._Closure$__.$I204-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06001949 RID: 6473 RVA: 0x000E81FC File Offset: 0x000E63FC
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

		// Token: 0x0600194A RID: 6474 RVA: 0x000E8284 File Offset: 0x000E6484
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

		// Token: 0x0600194B RID: 6475 RVA: 0x000E845C File Offset: 0x000E665C
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

		// Token: 0x0600194C RID: 6476 RVA: 0x000E84BC File Offset: 0x000E66BC
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

		// Token: 0x0600194D RID: 6477 RVA: 0x000E8580 File Offset: 0x000E6780
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

		// Token: 0x0600194E RID: 6478 RVA: 0x000E85E0 File Offset: 0x000E67E0
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000E8688 File Offset: 0x000E6888
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
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentDesc = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
				this.currentUOM = Conversions.ToString(dataRow["UOM"]);
				this.differentPricesPerBranch = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = this.differentPricesPerBranch == 0;
				if (flag2)
				{
					this.currentSellingPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
					this.currentwholesalePrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"]))));
					this.currentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
					this.currentCost = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Cost"]))));
				}
				else
				{
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					this.currentSellingPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"]))));
					this.currentwholesalePrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"]))));
					this.currentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
					this.currentCost = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Cost"]))));
				}
				this.lblcost.Text = Math.Round(this.currentCost, 2, MidpointRounding.AwayFromZero).ToString();
				this.lblselling.Text = Math.Round(this.currentSellingPrice, 2, MidpointRounding.AwayFromZero).ToString();
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x000E8B24 File Offset: 0x000E6D24
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
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
				this.currentUOM = Conversions.ToString(dataRow["UOM"]);
				this.differentPricesPerBranch = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = this.differentPricesPerBranch == 0;
				if (flag2)
				{
					this.currentSellingPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
					this.currentwholesalePrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"]))));
					this.currentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
					this.currentCost = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Cost"]))));
				}
				else
				{
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					this.currentSellingPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"]))));
					this.currentwholesalePrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"]))));
					this.currentSpecialPrice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"]))));
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
					this.currentCost = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Cost"]))));
				}
				this.lblcost.Text = Math.Round(this.currentCost, 2, MidpointRounding.AwayFromZero).ToString();
				this.lblselling.Text = Math.Round(this.currentSellingPrice, 2, MidpointRounding.AwayFromZero).ToString();
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000E8FB8 File Offset: 0x000E71B8
		private decimal GetStockAvailable(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "StockBalForProduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			decimal num;
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlDataAdapter.Fill(dataTable);
				DataRow dataRow = dataTable.Rows[0];
				num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000E9108 File Offset: 0x000E7308
		private void LoadFormulas(int coid, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulas";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboFormualas.DataSource = dataTable;
			this.cboFormualas.ValueMember = "FormulaName";
			this.cboFormualas.DisplayMember = "FormulaName";
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000E91B0 File Offset: 0x000E73B0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.txtQty.Text, "", false) != 0) & (this.CurrentID != 0);
				if (flag)
				{
					this.LoadIngridients(MyProject.Forms.Form1.coid, this.cboFormualas.Text);
					this.PopulateGrid();
				}
				else
				{
					MessageBox.Show("Please check quantity and if the product is selected.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating product conversion details. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000E9258 File Offset: 0x000E7458
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID != 0;
				if (flag)
				{
					this.LoadFormulas(MyProject.Forms.Form1.coid, this.CurrentID);
				}
				else
				{
					MessageBox.Show("Select the product first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading formulas. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000E92D8 File Offset: 0x000E74D8
		private void LoadIngridients(int coid, string formulaname)
		{
			this.dgvIngridients.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulaIngridients";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("formulaname", formulaname);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvIngridients.DataSource = dataTable;
			this.dgvIngridients.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvIngridients.Columns["ProductDesc"].HeaderText = "Product Description";
			this.dgvIngridients.Columns["qty"].HeaderText = "Qty for Formula";
			this.dgvIngridients.Columns.Add("Stock_Available", "Stock Available");
			this.dgvIngridients.Columns.Add("CalculatedQty", "Calculated Qty");
			this.dgvIngridients.Columns.Add("ActualQty", "Actual Qty Required");
			this.dgvIngridients.Columns["Stock_Available"].ReadOnly = true;
			this.dgvIngridients.Columns["CalculatedQty"].ReadOnly = true;
			this.dgvIngridients.Columns["productid"].ReadOnly = true;
			this.dgvIngridients.Columns["qty"].ReadOnly = true;
			this.dgvIngridients.Columns["Stock_Available"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["CalculatedQty"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["productid"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["qty"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["entryno"].Visible = false;
			this.dgvIngridients.Columns["Cost"].Visible = false;
			this.dgvIngridients.Columns["qty"].HeaderText = "Formula Qty";
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000E959C File Offset: 0x000E779C
		private void PopulateGrid()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvIngridients.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells["Stock_Available"].Value = this.GetStockAvailable(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productid"].Value)));
					dataGridViewRow.Cells["CalculatedQty"].Value = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), Convert.ToDecimal(this.txtQty.Text));
					dataGridViewRow.Cells["ActualQty"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CalculatedQty"].Value);
					decimal num = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
					{
						Operators.AddObject(num, Operators.MultiplyObject(Operators.DivideObject(dataGridViewRow.Cells["ActualQty"].Value, Conversion.Val(this.txtQty.Text)), dataGridViewRow.Cells["Cost"].Value)),
						2,
						MidpointRounding.AwayFromZero
					}, null, null, null));
					this.txtNewCostPrice.Text = num.ToString();
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

		// Token: 0x06001957 RID: 6487 RVA: 0x000E976C File Offset: 0x000E796C
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					bool flag2 = (Operators.CompareString(this.txtBatchNumber.Text, "", false) == 0) | (Operators.CompareString(this.DTExpiryDate.Text, "", false) == 0);
					if (flag2)
					{
						MessageBox.Show("Please enter the Batch Number and Expiry Date first.");
						return;
					}
				}
				bool flag3 = this.dgvIngridients.Rows.Count <= 0;
				if (flag3)
				{
					MessageBox.Show("Please calculate firt before making the product.");
					this.Button1.Focus();
				}
				else
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to create this product using the selected formula?", MsgBoxStyle.YesNo, null);
					bool flag4 = dialogResult == DialogResult.Yes;
					if (flag4)
					{
						bool flag5 = this.CurrentID != 0;
						if (flag5)
						{
							int num = 0;
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							sqlCommand.Connection = sqlConnection;
							sqlConnection.Open();
							SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunMakeProduct");
							sqlCommand.Transaction = sqlTransaction;
							try
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "GetProductConvertedNumber";
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
								int coid = MyProject.Forms.Form1.coid;
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("newconvertednum", 0);
								int num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
								try
								{
									foreach (object obj in ((IEnumerable)this.dgvIngridients.Rows))
									{
										DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
										bool flag6 = MyProject.Forms.Form1.NegativeStock == 0;
										if (flag6)
										{
											bool flag7 = Operators.ConditionalCompareObjectGreater(dataGridViewRow.Cells["ActualQty"].Value, dataGridViewRow.Cells["Stock_Available"].Value, false);
											if (flag7)
											{
												MessageBox.Show(Conversions.ToString(Operators.AddObject(Operators.AddObject("CANNOT MAKE PRODUCT. Ingridient ", dataGridViewRow.Cells["productdesc"].Value), " has insufficient stock.")));
												sqlTransaction.Rollback();
												return;
											}
										}
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "InsertProductsConverted";
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("formulaname", this.cboFormualas.Text);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
										sqlCommand.Parameters.AddWithValue("QTYCalculated", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CalculatedQty"].Value));
										sqlCommand.Parameters.AddWithValue("QTYActual", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ActualQty"].Value));
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productid"].Value));
										sqlCommand.Parameters.AddWithValue("type", "MAKE");
										sqlCommand.Parameters.AddWithValue("convertedproductid", this.CurrentID);
										sqlCommand.Parameters.AddWithValue("invnumber", num2);
										sqlCommand.ExecuteNonQuery();
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "InsertNewStock2Warehouse";
										sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("invoicenum", num2);
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productid"].Value));
										sqlCommand.Parameters.AddWithValue("isstockin", 0);
										sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
										sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ActualQty"].Value));
										sqlCommand.Parameters.AddWithValue("cost", 0);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("trancode", 9);
										sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["productid"].Value), this._cnn));
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("BatchNumber", "");
										sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
										sqlCommand.Parameters.AddWithValue("suppliername", "");
										sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
										sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
										sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
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
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertNewStock2Warehouse";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", num2);
								sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
								sqlCommand.Parameters.AddWithValue("isstockin", 1);
								sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
								sqlCommand.Parameters.AddWithValue("quantity", Convert.ToDecimal(this.txtQty.Text));
								sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtNewCostPrice.Text));
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("trancode", 9);
								sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, this.CurrentID, this._cnn));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								bool flag8 = MyProject.Forms.Form1.IsWarehouse == 1;
								if (flag8)
								{
									sqlCommand.Parameters.AddWithValue("BatchNumber", this.txtBatchNumber.Text);
									sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(this.DTExpiryDate.Value.ToString("yyyyMMdd")));
								}
								else
								{
									sqlCommand.Parameters.AddWithValue("BatchNumber", "");
									sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
								}
								sqlCommand.Parameters.AddWithValue("suppliername", "");
								sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
								sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
								sqlCommand.ExecuteNonQuery();
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertProductsConverted";
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("formulaname", this.cboFormualas.Text);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
								sqlCommand.Parameters.AddWithValue("QTYCalculated", Convert.ToDecimal(this.txtQty.Text));
								sqlCommand.Parameters.AddWithValue("QTYActual", Convert.ToDecimal(this.txtQty.Text));
								sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
								sqlCommand.Parameters.AddWithValue("type", "MAKE");
								sqlCommand.Parameters.AddWithValue("convertedproductid", this.CurrentID);
								sqlCommand.Parameters.AddWithValue("invnumber", num2);
								sqlCommand.ExecuteNonQuery();
								bool flag9 = (Convert.ToDouble(this.currentSellingPrice) != Conversion.Val(this.txtNewSellingPrice.Text)) | (Convert.ToDouble(this.currentCost) != Conversion.Val(this.txtNewCostPrice.Text));
								if (flag9)
								{
									bool flag10 = Convert.ToDouble(this.currentCost) != Conversion.Val(this.txtNewCostPrice.Text);
									if (flag10)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.Text;
										sqlCommand.CommandText = string.Concat(new string[]
										{
											"update products set cost=",
											this.txtNewCostPrice.Text,
											" where coid=",
											Conversions.ToString(MyProject.Forms.Form1.coid),
											" and productid=",
											Conversions.ToString(this.CurrentID)
										});
										sqlCommand.ExecuteNonQuery();
									}
									bool flag11 = Convert.ToDouble(this.currentSellingPrice) != Conversion.Val(this.txtNewSellingPrice.Text);
									if (flag11)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "SaveBranchPricesUpdate";
										sqlCommand.Parameters.AddWithValue("ProductID", this.CurrentID);
										sqlCommand.Parameters.AddWithValue("ProductSellingPrice", Conversion.Val(this.txtNewSellingPrice.Text));
										sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(this.DTDate.Value.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("wholesaleprice", this.currentwholesalePrice);
										sqlCommand.Parameters.AddWithValue("wholesaleqty", this.currentWholesaleQty);
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("specialprice", this.currentSpecialPrice);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										sqlCommand.Parameters.AddWithValue("isglobal", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.differentPricesPerBranch == 1, 0, 1)));
										sqlCommand.ExecuteNonQuery();
									}
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "Audit_PriceChangeInsert";
									sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("systemdate", this.DTDate.Value);
									sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", RuntimeHelpers.GetObjectValue(Interaction.IIf(Convert.ToDouble(this.currentCost) != Conversion.Val(this.txtNewCostPrice.Text), true, false)));
									sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", RuntimeHelpers.GetObjectValue(Interaction.IIf(Convert.ToDouble(this.currentSellingPrice) != Conversion.Val(this.txtNewSellingPrice.Text), true, false)));
									sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", false);
									sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", false);
									sqlCommand.Parameters.AddWithValue("Old_CostPrice", this.currentCost);
									sqlCommand.Parameters.AddWithValue("New_CostPrice", Conversion.Val(this.txtNewCostPrice.Text));
									sqlCommand.Parameters.AddWithValue("Old_SellingPrice", this.currentSellingPrice);
									sqlCommand.Parameters.AddWithValue("New_SellingPrice", Conversion.Val(this.txtNewSellingPrice.Text));
									sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", this.currentwholesalePrice);
									sqlCommand.Parameters.AddWithValue("New_WholesalePrice", this.currentwholesalePrice);
									sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", this.currentWholesaleQty);
									sqlCommand.Parameters.AddWithValue("New_WholesaleQty", this.currentWholesaleQty);
									sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("comment", "MAKE PRODUCT");
									sqlCommand.Parameters.AddWithValue("new_entryno", num);
									num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
								}
								sqlTransaction.Commit();
								sqlCommand.Connection.Close();
								MessageBox.Show("Product has been successfully made.");
								this.ClearForm();
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error saving permission settings. Detail:  " + ex.Message);
							}
						}
						else
						{
							MessageBox.Show("Select product first.");
						}
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error making product. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x000EA9C4 File Offset: 0x000E8BC4
		private void ClearForm()
		{
			this.CurrentID = 0;
			this.CurrentDesc = "";
			this.CurrentCode = "";
			this.currentUOM = "";
			this.txtQty.Text = "";
			DataTable dataTable = new DataTable();
			this.dgvIngridients.DataSource = dataTable;
			this.lblcost.Text = "...";
			this.lblselling.Text = "...";
			this.txtNewCostPrice.Text = "";
			this.txtNewSellingPrice.Text = "";
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x000EAA64 File Offset: 0x000E8C64
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000EAB18 File Offset: 0x000E8D18
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag2;
			try
			{
				bool flag = msg.WParam.ToInt32() == 112;
				if (flag)
				{
					this.txtBarCode.Focus();
				}
				flag2 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag2;
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000EAB78 File Offset: 0x000E8D78
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

		// Token: 0x0600195C RID: 6492 RVA: 0x00002A30 File Offset: 0x00000C30
		private void dgvIngridients_Validated(object sender, EventArgs e)
		{
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x000EAC28 File Offset: 0x000E8E28
		private void dgvBatches_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			bool flag = e.Control is TextBox;
			if (flag)
			{
				TextBox textBox = e.Control as TextBox;
				textBox.KeyPress -= this.tb_KeyPress;
				bool flag2 = this.dgvIngridients.CurrentCell.ColumnIndex == 7;
				if (flag2)
				{
					textBox.KeyPress += this.tb_KeyPress;
				}
			}
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000EAC98 File Offset: 0x000E8E98
		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x000EACEC File Offset: 0x000E8EEC
		private void dgvIngridients_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvIngridients.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						decimal num = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.AddObject(num, Operators.MultiplyObject(Operators.DivideObject(dataGridViewRow.Cells["ActualQty"].Value, Conversion.Val(this.txtQty.Text)), dataGridViewRow.Cells["Cost"].Value)),
							2,
							MidpointRounding.AwayFromZero
						}, null, null, null));
						this.txtNewCostPrice.Text = num.ToString();
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

		// Token: 0x06001960 RID: 6496 RVA: 0x000EAE14 File Offset: 0x000E9014
		private void DTExpiryDate_ValueChanged(object sender, EventArgs e)
		{
			this.DTExpiryDate.Format = DateTimePickerFormat.Long;
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x000EAE24 File Offset: 0x000E9024
		private void lblselling_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtNewSellingPrice.Text = this.lblselling.Text;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000C39 RID: 3129
		private string _cnn;

		// Token: 0x04000C3A RID: 3130
		private int CurrentID;

		// Token: 0x04000C3B RID: 3131
		private string CurrentCode;

		// Token: 0x04000C3C RID: 3132
		private string CurrentDesc;

		// Token: 0x04000C3D RID: 3133
		private PublicFunctions pf;

		// Token: 0x04000C3E RID: 3134
		private string currentUOM;

		// Token: 0x04000C3F RID: 3135
		private decimal currentCost;

		// Token: 0x04000C40 RID: 3136
		private decimal currentSellingPrice;

		// Token: 0x04000C41 RID: 3137
		private decimal currentwholesalePrice;

		// Token: 0x04000C42 RID: 3138
		private decimal currentWholesaleQty;

		// Token: 0x04000C43 RID: 3139
		private int differentPricesPerBranch;

		// Token: 0x04000C44 RID: 3140
		private decimal currentSpecialPrice;
	}
}
