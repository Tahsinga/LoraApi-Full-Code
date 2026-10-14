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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using BarcodeRender;
using EltradeFPAx;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using Zen.Barcode;

namespace PointOfSale
{
	// Token: 0x02000169 RID: 361
	[DesignerGenerated]
	public partial class Printers : Form
	{
		// Token: 0x06002FF1 RID: 12273 RVA: 0x0019D1A0 File Offset: 0x0019B3A0
		public Printers()
		{
			base.Load += this.Printers_Load;
			base.MinimumSizeChanged += this.Printers_MinimumSizeChanged;
			this.publicfunction = new PublicFunctions();
			this.TextToPrint = "";
			this._cnn = MyProject.Forms.Form1.Constring;
			this.invnum = 0;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x001A35C9 File Offset: 0x001A17C9
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x001A35D3 File Offset: 0x001A17D3
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x001A35DC File Offset: 0x001A17DC
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x001A35E8 File Offset: 0x001A17E8
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

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x001A362B File Offset: 0x001A182B
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x001A3635 File Offset: 0x001A1835
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x001A363E File Offset: 0x001A183E
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x001A3648 File Offset: 0x001A1848
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x001A3651 File Offset: 0x001A1851
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x001A365C File Offset: 0x001A185C
		internal virtual ComboBox cmbPrinterType
		{
			[CompilerGenerated]
			get
			{
				return this._cmbPrinterType;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cmbPrinterType_SelectedIndexChanged);
				ComboBox comboBox = this._cmbPrinterType;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cmbPrinterType = value;
				comboBox = this._cmbPrinterType;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06002FFE RID: 12286 RVA: 0x001A369F File Offset: 0x001A189F
		// (set) Token: 0x06002FFF RID: 12287 RVA: 0x001A36AC File Offset: 0x001A18AC
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

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x001A36EF File Offset: 0x001A18EF
		// (set) Token: 0x06003001 RID: 12289 RVA: 0x001A36F9 File Offset: 0x001A18F9
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x001A3702 File Offset: 0x001A1902
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x001A370C File Offset: 0x001A190C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x001A3715 File Offset: 0x001A1915
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x001A3720 File Offset: 0x001A1920
		internal virtual ComboBox cboSize
		{
			[CompilerGenerated]
			get
			{
				return this._cboSize;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboSize_SelectedIndexChanged);
				ComboBox comboBox = this._cboSize;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboSize = value;
				comboBox = this._cboSize;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x001A3763 File Offset: 0x001A1963
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x001A3770 File Offset: 0x001A1970
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x001A37B3 File Offset: 0x001A19B3
		// (set) Token: 0x06003009 RID: 12297 RVA: 0x001A37C0 File Offset: 0x001A19C0
		internal virtual CheckBox CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox2_CheckedChanged);
				CheckBox checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._CheckBox2 = value;
				checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x001A3803 File Offset: 0x001A1A03
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x001A380D File Offset: 0x001A1A0D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x001A3816 File Offset: 0x001A1A16
		// (set) Token: 0x0600300D RID: 12301 RVA: 0x001A3820 File Offset: 0x001A1A20
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

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x001A3863 File Offset: 0x001A1A63
		// (set) Token: 0x0600300F RID: 12303 RVA: 0x001A3870 File Offset: 0x001A1A70
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06003010 RID: 12304 RVA: 0x001A38B3 File Offset: 0x001A1AB3
		// (set) Token: 0x06003011 RID: 12305 RVA: 0x001A38BD File Offset: 0x001A1ABD
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x001A38C6 File Offset: 0x001A1AC6
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x001A38D0 File Offset: 0x001A1AD0
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x001A38D9 File Offset: 0x001A1AD9
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x001A38E4 File Offset: 0x001A1AE4
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

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x001A3927 File Offset: 0x001A1B27
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x001A3931 File Offset: 0x001A1B31
		internal virtual Button Button5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x001A393A File Offset: 0x001A1B3A
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x001A3944 File Offset: 0x001A1B44
		internal virtual Label Label7
		{
			[CompilerGenerated]
			get
			{
				return this._Label7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label7_Click);
				Label label = this._Label7;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label7 = value;
				label = this._Label7;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x001A3987 File Offset: 0x001A1B87
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x001A3994 File Offset: 0x001A1B94
		internal virtual ComboBox cboCable
		{
			[CompilerGenerated]
			get
			{
				return this._cboCable;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCable_SelectedIndexChanged);
				ComboBox comboBox = this._cboCable;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCable = value;
				comboBox = this._cboCable;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x001A39D7 File Offset: 0x001A1BD7
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x001A39E4 File Offset: 0x001A1BE4
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

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x001A3A27 File Offset: 0x001A1C27
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x001A3A31 File Offset: 0x001A1C31
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x001A3A3A File Offset: 0x001A1C3A
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x001A3A44 File Offset: 0x001A1C44
		internal virtual TextBox txtFootnote
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x001A3A4D File Offset: 0x001A1C4D
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x001A3A57 File Offset: 0x001A1C57
		internal virtual CheckBox chkShowPaymentMethods
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x001A3A60 File Offset: 0x001A1C60
		// (set) Token: 0x06003025 RID: 12325 RVA: 0x001A3A6A File Offset: 0x001A1C6A
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x001A3A73 File Offset: 0x001A1C73
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x001A3A80 File Offset: 0x001A1C80
		internal virtual TextBox txtNumberOfCopies
		{
			[CompilerGenerated]
			get
			{
				return this._txtNumberOfCopies;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNumberOfCopies_KeyPress);
				TextBox textBox = this._txtNumberOfCopies;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNumberOfCopies = value;
				textBox = this._txtNumberOfCopies;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x001A3AC3 File Offset: 0x001A1CC3
		// (set) Token: 0x06003029 RID: 12329 RVA: 0x001A3AD0 File Offset: 0x001A1CD0
		internal virtual DataGridView dgvEltrade
		{
			[CompilerGenerated]
			get
			{
				return this._dgvEltrade;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvEltrade_CellContentClick);
				DataGridView dataGridView = this._dgvEltrade;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvEltrade = value;
				dataGridView = this._dgvEltrade;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x001A3B13 File Offset: 0x001A1D13
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x001A3B1D File Offset: 0x001A1D1D
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x001A3B26 File Offset: 0x001A1D26
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x001A3B30 File Offset: 0x001A1D30
		internal virtual Label lblRevMax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x001A3B39 File Offset: 0x001A1D39
		// (set) Token: 0x0600302F RID: 12335 RVA: 0x001A3B43 File Offset: 0x001A1D43
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x001A3B4C File Offset: 0x001A1D4C
		// (set) Token: 0x06003031 RID: 12337 RVA: 0x001A3B56 File Offset: 0x001A1D56
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x001A3B5F File Offset: 0x001A1D5F
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x001A3B6C File Offset: 0x001A1D6C
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

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x001A3BAF File Offset: 0x001A1DAF
		// (set) Token: 0x06003035 RID: 12341 RVA: 0x001A3BBC File Offset: 0x001A1DBC
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

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x001A3BFF File Offset: 0x001A1DFF
		// (set) Token: 0x06003037 RID: 12343 RVA: 0x001A3C0C File Offset: 0x001A1E0C
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x001A3C4F File Offset: 0x001A1E4F
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x001A3C59 File Offset: 0x001A1E59
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x001A3C62 File Offset: 0x001A1E62
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x001A3C6C File Offset: 0x001A1E6C
		internal virtual RadioButton RadioButton2
		{
			[CompilerGenerated]
			get
			{
				return this._RadioButton2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RadioButton2_CheckedChanged);
				RadioButton radioButton = this._RadioButton2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._RadioButton2 = value;
				radioButton = this._RadioButton2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x001A3CAF File Offset: 0x001A1EAF
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x001A3CBC File Offset: 0x001A1EBC
		internal virtual RadioButton RadioButton1
		{
			[CompilerGenerated]
			get
			{
				return this._RadioButton1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RadioButton1_CheckedChanged);
				RadioButton radioButton = this._RadioButton1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._RadioButton1 = value;
				radioButton = this._RadioButton1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x001A3CFF File Offset: 0x001A1EFF
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x001A3D09 File Offset: 0x001A1F09
		internal virtual ComboBox cboFont
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x001A3D12 File Offset: 0x001A1F12
		// (set) Token: 0x06003041 RID: 12353 RVA: 0x001A3D1C File Offset: 0x001A1F1C
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x001A3D25 File Offset: 0x001A1F25
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x001A3D2F File Offset: 0x001A1F2F
		internal virtual TabPage TabPage4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x001A3D38 File Offset: 0x001A1F38
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x001A3D42 File Offset: 0x001A1F42
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x001A3D4B File Offset: 0x001A1F4B
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x001A3D58 File Offset: 0x001A1F58
		internal virtual RadioButton radEltradeESD
		{
			[CompilerGenerated]
			get
			{
				return this._radEltradeESD;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.radEltradeESD_CheckedChanged);
				RadioButton radioButton = this._radEltradeESD;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._radEltradeESD = value;
				radioButton = this._radEltradeESD;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x001A3D9B File Offset: 0x001A1F9B
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x001A3DA8 File Offset: 0x001A1FA8
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
				EventHandler eventHandler = new EventHandler(this.Button7_Click_1);
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

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x001A3DEB File Offset: 0x001A1FEB
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x001A3DF5 File Offset: 0x001A1FF5
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x001A3DFE File Offset: 0x001A1FFE
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x001A3E08 File Offset: 0x001A2008
		internal virtual TextBox txtLength
		{
			[CompilerGenerated]
			get
			{
				return this._txtLength;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtLength_KeyPress);
				TextBox textBox = this._txtLength;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtLength = value;
				textBox = this._txtLength;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x001A3E4B File Offset: 0x001A204B
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x001A3E55 File Offset: 0x001A2055
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x001A3E5E File Offset: 0x001A205E
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x001A3E68 File Offset: 0x001A2068
		internal virtual TextBox txtLeadingChars
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x001A3E71 File Offset: 0x001A2071
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x001A3E7B File Offset: 0x001A207B
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x001A3E84 File Offset: 0x001A2084
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x001A3E90 File Offset: 0x001A2090
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

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x001A3ED3 File Offset: 0x001A20D3
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x001A3EE0 File Offset: 0x001A20E0
		internal virtual RadioButton radEltradeESDReceipt
		{
			[CompilerGenerated]
			get
			{
				return this._radEltradeESDReceipt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.radEltradeESDReceipt_CheckedChanged);
				RadioButton radioButton = this._radEltradeESDReceipt;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._radEltradeESDReceipt = value;
				radioButton = this._radEltradeESDReceipt;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x001A3F23 File Offset: 0x001A2123
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x001A3F2D File Offset: 0x001A212D
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x001A3F36 File Offset: 0x001A2136
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x001A3F40 File Offset: 0x001A2140
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
				EventHandler eventHandler = new EventHandler(this.Button10_Click_1);
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

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x001A3F83 File Offset: 0x001A2183
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x001A3F8D File Offset: 0x001A218D
		internal virtual TextBox txtpath
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x001A3F96 File Offset: 0x001A2196
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x001A3FA0 File Offset: 0x001A21A0
		internal virtual CheckBox chkPrintToFile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x001A3FA9 File Offset: 0x001A21A9
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x001A3FB3 File Offset: 0x001A21B3
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x001A3FBC File Offset: 0x001A21BC
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x001A3FC6 File Offset: 0x001A21C6
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x001A3FCF File Offset: 0x001A21CF
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x001A3FD9 File Offset: 0x001A21D9
		internal virtual TextBox txtFiscalDeviceDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x001A3FE2 File Offset: 0x001A21E2
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x001A3FEC File Offset: 0x001A21EC
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x001A3FF5 File Offset: 0x001A21F5
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x001A3FFF File Offset: 0x001A21FF
		internal virtual CheckBox chkShowFooterDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x001A4008 File Offset: 0x001A2208
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x001A4014 File Offset: 0x001A2214
		internal virtual CheckBox chk
		{
			[CompilerGenerated]
			get
			{
				return this._chk;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chk_CheckedChanged);
				CheckBox checkBox = this._chk;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chk = value;
				checkBox = this._chk;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x001A4057 File Offset: 0x001A2257
		// (set) Token: 0x0600306D RID: 12397 RVA: 0x001A4061 File Offset: 0x001A2261
		internal virtual CheckBox chkReceiptsOptional
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x001A406A File Offset: 0x001A226A
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x001A4074 File Offset: 0x001A2274
		internal virtual ComboBox cboPrinters
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x001A407D File Offset: 0x001A227D
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x001A4088 File Offset: 0x001A2288
		internal virtual CheckBox chkSecondaryPrinter
		{
			[CompilerGenerated]
			get
			{
				return this._chkSecondaryPrinter;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox3_CheckedChanged);
				CheckBox checkBox = this._chkSecondaryPrinter;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkSecondaryPrinter = value;
				checkBox = this._chkSecondaryPrinter;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x001A40CB File Offset: 0x001A22CB
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x001A40D8 File Offset: 0x001A22D8
		internal virtual ComboBox cboPrinterSecondary
		{
			[CompilerGenerated]
			get
			{
				return this._cboPrinterSecondary;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				ComboBox comboBox = this._cboPrinterSecondary;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPrinterSecondary = value;
				comboBox = this._cboPrinterSecondary;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x001A411B File Offset: 0x001A231B
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x001A4128 File Offset: 0x001A2328
		internal virtual Label Label14
		{
			[CompilerGenerated]
			get
			{
				return this._Label14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label14_Click);
				Label label = this._Label14;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label14 = value;
				label = this._Label14;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x001A416B File Offset: 0x001A236B
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x001A4175 File Offset: 0x001A2375
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x001A417E File Offset: 0x001A237E
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x001A4188 File Offset: 0x001A2388
		internal virtual TextBox txtSecondaryPrinterCaption
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x001A4191 File Offset: 0x001A2391
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x001A419B File Offset: 0x001A239B
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x001A41A4 File Offset: 0x001A23A4
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x001A41AE File Offset: 0x001A23AE
		internal virtual ComboBox cboprintersRev
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x001A41B7 File Offset: 0x001A23B7
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x001A41C1 File Offset: 0x001A23C1
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x001A41CA File Offset: 0x001A23CA
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x001A41D4 File Offset: 0x001A23D4
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

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x001A4217 File Offset: 0x001A2417
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x001A4224 File Offset: 0x001A2424
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

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x001A4267 File Offset: 0x001A2467
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x001A4274 File Offset: 0x001A2474
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

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x001A42B7 File Offset: 0x001A24B7
		// (set) Token: 0x06003087 RID: 12423 RVA: 0x001A42C1 File Offset: 0x001A24C1
		internal virtual PictureBox PictureBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x001A42CA File Offset: 0x001A24CA
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x001A42D4 File Offset: 0x001A24D4
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x001A42DD File Offset: 0x001A24DD
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x001A42E7 File Offset: 0x001A24E7
		internal virtual GroupBox GroupBox7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x001A42F0 File Offset: 0x001A24F0
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x001A42FA File Offset: 0x001A24FA
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x001A4303 File Offset: 0x001A2503
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x001A430D File Offset: 0x001A250D
		internal virtual CheckBox chkCropImage
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x001A4316 File Offset: 0x001A2516
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x001A4320 File Offset: 0x001A2520
		internal virtual TextBox txtHeaderText
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x001A4329 File Offset: 0x001A2529
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x001A4333 File Offset: 0x001A2533
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x001A433C File Offset: 0x001A253C
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x001A4348 File Offset: 0x001A2548
		internal virtual TextBox txtNextInvoiceNumber
		{
			[CompilerGenerated]
			get
			{
				return this._txtNextInvoiceNumber;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNextInvoiceNumber_KeyPress);
				TextBox textBox = this._txtNextInvoiceNumber;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNextInvoiceNumber = value;
				textBox = this._txtNextInvoiceNumber;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x001A438B File Offset: 0x001A258B
		// (set) Token: 0x06003097 RID: 12439 RVA: 0x001A4395 File Offset: 0x001A2595
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x001A439E File Offset: 0x001A259E
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x001A43A8 File Offset: 0x001A25A8
		internal virtual CheckBox chkPrintBarcodedInvNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x001A43B1 File Offset: 0x001A25B1
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x001A43BC File Offset: 0x001A25BC
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= eventHandler;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x001A43FF File Offset: 0x001A25FF
		// (set) Token: 0x0600309D RID: 12445 RVA: 0x001A440C File Offset: 0x001A260C
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
				EventHandler eventHandler = new EventHandler(this.Button16_Click);
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

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x001A444F File Offset: 0x001A264F
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x001A4459 File Offset: 0x001A2659
		internal virtual TabPage TabPage5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x001A4462 File Offset: 0x001A2662
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x001A446C File Offset: 0x001A266C
		internal virtual GroupBox GroupBox8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x001A4475 File Offset: 0x001A2675
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x001A4480 File Offset: 0x001A2680
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

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x001A44C3 File Offset: 0x001A26C3
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x001A44CD File Offset: 0x001A26CD
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x001A44D6 File Offset: 0x001A26D6
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x001A44E0 File Offset: 0x001A26E0
		internal virtual ComboBox cboPapersize2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x001A44E9 File Offset: 0x001A26E9
		// (set) Token: 0x060030A9 RID: 12457 RVA: 0x001A44F3 File Offset: 0x001A26F3
		internal virtual ComboBox cboPrinters2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x001A44FC File Offset: 0x001A26FC
		// (set) Token: 0x060030AB RID: 12459 RVA: 0x001A4506 File Offset: 0x001A2706
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x001A450F File Offset: 0x001A270F
		// (set) Token: 0x060030AD RID: 12461 RVA: 0x001A4519 File Offset: 0x001A2719
		internal virtual ComboBox cboCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x001A4522 File Offset: 0x001A2722
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x001A452C File Offset: 0x001A272C
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060030B0 RID: 12464 RVA: 0x001A4535 File Offset: 0x001A2735
		// (set) Token: 0x060030B1 RID: 12465 RVA: 0x001A453F File Offset: 0x001A273F
		internal virtual GroupBox GroupBox9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060030B2 RID: 12466 RVA: 0x001A4548 File Offset: 0x001A2748
		// (set) Token: 0x060030B3 RID: 12467 RVA: 0x001A4552 File Offset: 0x001A2752
		internal virtual DataGridView dgvCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060030B4 RID: 12468 RVA: 0x001A455B File Offset: 0x001A275B
		// (set) Token: 0x060030B5 RID: 12469 RVA: 0x001A4565 File Offset: 0x001A2765
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x001A456E File Offset: 0x001A276E
		// (set) Token: 0x060030B7 RID: 12471 RVA: 0x001A4578 File Offset: 0x001A2778
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x001A4581 File Offset: 0x001A2781
		// (set) Token: 0x060030B9 RID: 12473 RVA: 0x001A458B File Offset: 0x001A278B
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060030BA RID: 12474 RVA: 0x001A4594 File Offset: 0x001A2794
		// (set) Token: 0x060030BB RID: 12475 RVA: 0x001A459E File Offset: 0x001A279E
		internal virtual CheckBox chkUseOldPrintingService
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x001A45A7 File Offset: 0x001A27A7
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x001A45B1 File Offset: 0x001A27B1
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x001A45BA File Offset: 0x001A27BA
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x001A45C4 File Offset: 0x001A27C4
		internal virtual TextBox txtrec_copy_name
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x001A45CD File Offset: 0x001A27CD
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x001A45D8 File Offset: 0x001A27D8
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
				EventHandler eventHandler = new EventHandler(this.Button18_Click_2);
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

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x001A461B File Offset: 0x001A281B
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x001A4628 File Offset: 0x001A2828
		internal virtual Button Button22
		{
			[CompilerGenerated]
			get
			{
				return this._Button22;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button22_Click);
				Button button = this._Button22;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button22 = value;
				button = this._Button22;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x001A466B File Offset: 0x001A286B
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x001A4675 File Offset: 0x001A2875
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x001A467E File Offset: 0x001A287E
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x001A4688 File Offset: 0x001A2888
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x001A4691 File Offset: 0x001A2891
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x001A469B File Offset: 0x001A289B
		internal virtual ComboBox cboReceiptTemplate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x001A46A4 File Offset: 0x001A28A4
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x001A46AE File Offset: 0x001A28AE
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x001A46B7 File Offset: 0x001A28B7
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x001A46C1 File Offset: 0x001A28C1
		internal virtual RadioButton radSaveasPDF
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x001A46CA File Offset: 0x001A28CA
		// (set) Token: 0x060030CF RID: 12495 RVA: 0x001A46D4 File Offset: 0x001A28D4
		internal virtual RadioButton radSaveasTXT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x001A46DD File Offset: 0x001A28DD
		// (set) Token: 0x060030D1 RID: 12497 RVA: 0x001A46E7 File Offset: 0x001A28E7
		internal virtual ComboBox cboInvoiceTemplates
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x001A46F0 File Offset: 0x001A28F0
		// (set) Token: 0x060030D3 RID: 12499 RVA: 0x001A46FC File Offset: 0x001A28FC
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

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x001A473F File Offset: 0x001A293F
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x001A4749 File Offset: 0x001A2949
		internal virtual CheckBox chkRevmaxTest
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x001A4752 File Offset: 0x001A2952
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x001A475C File Offset: 0x001A295C
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
				EventHandler eventHandler = new EventHandler(this.Button20_Click_1);
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

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x060030D8 RID: 12504 RVA: 0x001A479F File Offset: 0x001A299F
		// (set) Token: 0x060030D9 RID: 12505 RVA: 0x001A47AC File Offset: 0x001A29AC
		internal virtual Button btnAdditionalSettings
		{
			[CompilerGenerated]
			get
			{
				return this._btnAdditionalSettings;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnAdditionalSettings_Click);
				Button button = this._btnAdditionalSettings;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnAdditionalSettings = value;
				button = this._btnAdditionalSettings;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x001A47EF File Offset: 0x001A29EF
		// (set) Token: 0x060030DB RID: 12507 RVA: 0x001A47FC File Offset: 0x001A29FC
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
				EventHandler eventHandler = new EventHandler(this.Button21_Click_1);
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

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x001A483F File Offset: 0x001A2A3F
		// (set) Token: 0x060030DD RID: 12509 RVA: 0x001A4849 File Offset: 0x001A2A49
		internal virtual TextBox txtLicense
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x001A4852 File Offset: 0x001A2A52
		// (set) Token: 0x060030DF RID: 12511 RVA: 0x001A485C File Offset: 0x001A2A5C
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x001A4865 File Offset: 0x001A2A65
		// (set) Token: 0x060030E1 RID: 12513 RVA: 0x001A486F File Offset: 0x001A2A6F
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x001A4878 File Offset: 0x001A2A78
		// (set) Token: 0x060030E3 RID: 12515 RVA: 0x001A4882 File Offset: 0x001A2A82
		internal virtual ComboBox cboInvTemplates
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x060030E4 RID: 12516 RVA: 0x001A488B File Offset: 0x001A2A8B
		// (set) Token: 0x060030E5 RID: 12517 RVA: 0x001A4895 File Offset: 0x001A2A95
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x001A489E File Offset: 0x001A2A9E
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x001A48A8 File Offset: 0x001A2AA8
		internal virtual ComboBox cboKDU
		{
			[CompilerGenerated]
			get
			{
				return this._cboKDU;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged_1);
				ComboBox comboBox = this._cboKDU;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboKDU = value;
				comboBox = this._cboKDU;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x001A48EB File Offset: 0x001A2AEB
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x001A48F8 File Offset: 0x001A2AF8
		internal virtual Button Button23
		{
			[CompilerGenerated]
			get
			{
				return this._Button23;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button23_Click);
				Button button = this._Button23;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button23 = value;
				button = this._Button23;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x001A493B File Offset: 0x001A2B3B
		// (set) Token: 0x060030EB RID: 12523 RVA: 0x001A4945 File Offset: 0x001A2B45
		internal virtual CheckBox chkHideVAT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x001A494E File Offset: 0x001A2B4E
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x001A4958 File Offset: 0x001A2B58
		internal virtual TextBox txtNextDebitNoteNum
		{
			[CompilerGenerated]
			get
			{
				return this._txtNextDebitNoteNum;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNextDebitNoteNum_KeyPress);
				TextBox textBox = this._txtNextDebitNoteNum;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNextDebitNoteNum = value;
				textBox = this._txtNextDebitNoteNum;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x001A499B File Offset: 0x001A2B9B
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x001A49A5 File Offset: 0x001A2BA5
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x001A49AE File Offset: 0x001A2BAE
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x001A49B8 File Offset: 0x001A2BB8
		internal virtual TextBox txtNextCreditNoteNumber
		{
			[CompilerGenerated]
			get
			{
				return this._txtNextCreditNoteNumber;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNextCreditNoteNumber_KeyPress);
				TextBox textBox = this._txtNextCreditNoteNumber;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNextCreditNoteNumber = value;
				textBox = this._txtNextCreditNoteNumber;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x001A49FB File Offset: 0x001A2BFB
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x001A4A05 File Offset: 0x001A2C05
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x001A4A0E File Offset: 0x001A2C0E
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x001A4A18 File Offset: 0x001A2C18
		internal virtual TabPage TabPage6
		{
			[CompilerGenerated]
			get
			{
				return this._TabPage6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabPage6_Click);
				TabPage tabPage = this._TabPage6;
				if (tabPage != null)
				{
					tabPage.Click -= eventHandler;
				}
				this._TabPage6 = value;
				tabPage = this._TabPage6;
				if (tabPage != null)
				{
					tabPage.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x001A4A5B File Offset: 0x001A2C5B
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x001A4A65 File Offset: 0x001A2C65
		internal virtual GroupBox GroupBox10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x001A4A6E File Offset: 0x001A2C6E
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x001A4A78 File Offset: 0x001A2C78
		internal virtual ComboBox cboLBPrinters
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x001A4A81 File Offset: 0x001A2C81
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x001A4A8B File Offset: 0x001A2C8B
		internal virtual Label Label33
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x001A4A94 File Offset: 0x001A2C94
		// (set) Token: 0x060030FD RID: 12541 RVA: 0x001A4AA0 File Offset: 0x001A2CA0
		internal virtual Button Button25
		{
			[CompilerGenerated]
			get
			{
				return this._Button25;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button25_Click);
				Button button = this._Button25;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button25 = value;
				button = this._Button25;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x001A4AE3 File Offset: 0x001A2CE3
		// (set) Token: 0x060030FF RID: 12543 RVA: 0x001A4AED File Offset: 0x001A2CED
		internal virtual TextBox txtLBpath
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x001A4AF6 File Offset: 0x001A2CF6
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x001A4B00 File Offset: 0x001A2D00
		internal virtual Button Button24
		{
			[CompilerGenerated]
			get
			{
				return this._Button24;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button24_Click);
				Button button = this._Button24;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button24 = value;
				button = this._Button24;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x001A4B43 File Offset: 0x001A2D43
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x001A4B50 File Offset: 0x001A2D50
		internal virtual TextBox txtLBWait
		{
			[CompilerGenerated]
			get
			{
				return this._txtLBWait;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress_1);
				TextBox textBox = this._txtLBWait;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtLBWait = value;
				textBox = this._txtLBWait;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x001A4BAE File Offset: 0x001A2DAE
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x001A4BB8 File Offset: 0x001A2DB8
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x001A4BC1 File Offset: 0x001A2DC1
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x001A4BCB File Offset: 0x001A2DCB
		internal virtual ComboBox cboLBInvTemplate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x001A4BD4 File Offset: 0x001A2DD4
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x001A4BDE File Offset: 0x001A2DDE
		internal virtual Label Label35
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x001A4BE7 File Offset: 0x001A2DE7
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x001A4BF1 File Offset: 0x001A2DF1
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x001A4BFA File Offset: 0x001A2DFA
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x001A4C04 File Offset: 0x001A2E04
		internal virtual RadioButton RadLB80
		{
			[CompilerGenerated]
			get
			{
				return this._RadLB80;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RadLB80_CheckedChanged);
				RadioButton radioButton = this._RadLB80;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._RadLB80 = value;
				radioButton = this._RadLB80;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x001A4C47 File Offset: 0x001A2E47
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x001A4C54 File Offset: 0x001A2E54
		internal virtual RadioButton RadLBA4
		{
			[CompilerGenerated]
			get
			{
				return this._RadLBA4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RadLBA4_CheckedChanged);
				RadioButton radioButton = this._RadLBA4;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._RadLBA4 = value;
				radioButton = this._RadLBA4;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x001A4C97 File Offset: 0x001A2E97
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x001A4CA4 File Offset: 0x001A2EA4
		internal virtual CheckBox chkLBFiscal
		{
			[CompilerGenerated]
			get
			{
				return this._chkLBFiscal;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkLBFiscal_CheckedChanged);
				CheckBox checkBox = this._chkLBFiscal;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkLBFiscal = value;
				checkBox = this._chkLBFiscal;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x001A4CE7 File Offset: 0x001A2EE7
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x001A4CF1 File Offset: 0x001A2EF1
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x001A4CFA File Offset: 0x001A2EFA
		// (set) Token: 0x06003115 RID: 12565 RVA: 0x001A4D04 File Offset: 0x001A2F04
		internal virtual TextBox txtEXSymbol
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x001A4D0D File Offset: 0x001A2F0D
		// (set) Token: 0x06003117 RID: 12567 RVA: 0x001A4D17 File Offset: 0x001A2F17
		internal virtual TextBox txtLogoSpacePadding
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x001A4D20 File Offset: 0x001A2F20
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x001A4D2A File Offset: 0x001A2F2A
		internal virtual Label Label37
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x001A4D33 File Offset: 0x001A2F33
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x001A4D40 File Offset: 0x001A2F40
		internal virtual Button Button26
		{
			[CompilerGenerated]
			get
			{
				return this._Button26;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button26_Click);
				Button button = this._Button26;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button26 = value;
				button = this._Button26;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x001A4D83 File Offset: 0x001A2F83
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x001A4D8D File Offset: 0x001A2F8D
		internal virtual Label Label38
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x001A4D96 File Offset: 0x001A2F96
		// (set) Token: 0x0600311F RID: 12575 RVA: 0x001A4DA0 File Offset: 0x001A2FA0
		internal virtual TextBox txtreceiptspacingsize
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x001A4DA9 File Offset: 0x001A2FA9
		// (set) Token: 0x06003121 RID: 12577 RVA: 0x001A4DB3 File Offset: 0x001A2FB3
		internal virtual Label Label39
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x001A4DBC File Offset: 0x001A2FBC
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x001A4DC8 File Offset: 0x001A2FC8
		internal virtual TextBox txtExtraSpaces
		{
			[CompilerGenerated]
			get
			{
				return this._txtExtraSpaces;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtExtraSpaces_KeyPress);
				TextBox textBox = this._txtExtraSpaces;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtExtraSpaces = value;
				textBox = this._txtExtraSpaces;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x001A4E0C File Offset: 0x001A300C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.CheckBox1.Checked;
				if (@checked)
				{
					bool flag = Operators.CompareString(this.cboSize.Text, "", false) != 0;
					if (!flag)
					{
						MessageBox.Show("Please enter the receipt paper size.");
						return;
					}
					bool flag2 = Operators.CompareString(this.cboFont.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please select font size first.");
						this.cboFont.Focus();
						return;
					}
					bool flag3 = Operators.CompareString(this.cboReceiptTemplate.Text, "", false) == 0;
					if (flag3)
					{
						MessageBox.Show("Please select the Receipt Template to use.");
						return;
					}
					this.publicfunction.AddUpdateAppSettings("defaultReceiptPrinter", this.cboPrinters.Text);
					MyProject.Forms.Form1.defaultReceiptPrinter = this.cboPrinters.Text;
					this.publicfunction.AddUpdateAppSettings("NumOfReceiptsPrint", Conversions.ToString(Convert.ToInt32(this.txtNumberOfCopies.Text)));
					MyProject.Forms.Form1.NumOfReceiptsPrint = Convert.ToInt32(this.txtNumberOfCopies.Text);
					MyProject.Forms.Form1.ReceiptFootnote = this.txtFootnote.Text;
					this.publicfunction.AddUpdateAppSettings("PrintReceipt", "1");
					bool flag4 = Operators.CompareString(this.cboSize.Text, "80mm", false) == 0;
					if (flag4)
					{
						this.publicfunction.AddUpdateAppSettings("ReceiptSize80", "1");
						MyProject.Forms.Form1.ReceiptSize80 = 1;
					}
					else
					{
						bool flag5 = Operators.CompareString(this.cboSize.Text, "58mm", false) == 0;
						if (flag5)
						{
							this.publicfunction.AddUpdateAppSettings("ReceiptSize80", "0");
							MyProject.Forms.Form1.ReceiptSize80 = 0;
						}
					}
					MyProject.Forms.Form1.PrintReceipt = 1;
					bool checked2 = this.chkReceiptsOptional.Checked;
					if (checked2)
					{
						this.publicfunction.AddUpdateAppSettings("ReceiptsOptional", Conversions.ToString(1));
						MyProject.Forms.Form1.ReceiptsOptional = 1;
					}
					else
					{
						this.publicfunction.AddUpdateAppSettings("ReceiptsOptional", Conversions.ToString(0));
						MyProject.Forms.Form1.ReceiptsOptional = 0;
					}
					bool flag6 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "TaxExemptSymbol", this.txtEXSymbol.Text, MyProject.Forms.Form1.Constring);
					MyProject.Forms.Form1.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
				}
				else
				{
					this.publicfunction.AddUpdateAppSettings("PrintReceipt", "0");
					MyProject.Forms.Form1.PrintReceipt = 0;
				}
				bool checked3 = this.CheckBox2.Checked;
				if (checked3)
				{
					bool flag7 = Operators.CompareString(this.cboInvoiceTemplates.Text, "", false) == 0;
					if (flag7)
					{
						MessageBox.Show("Please select a template first.");
						return;
					}
					this.publicfunction.AddUpdateAppSettings("PrintInvoice", "1");
					MyProject.Forms.Form1.PrintInvoice = 1;
					bool flag8 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Normal Invoice", false) == 0;
					if (flag8)
					{
						MyProject.Forms.Form1.inv_template_normal = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag9 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Pharma Template", false) == 0;
					if (flag9)
					{
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag10 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Incotex Template", false) == 0;
					if (flag10)
					{
						MyProject.Forms.Form1.inv_template_incotex = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag11 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Revmax Template", false) == 0;
					if (flag11)
					{
						MyProject.Forms.Form1.inv_template_revmax = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag12 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Lea Invoice Template", false) == 0;
					if (flag12)
					{
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_lea = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag13 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Tongaat Template", false) == 0;
					if (flag13)
					{
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_lea = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag14 = Operators.CompareString(this.cboInvoiceTemplates.Text, "FDMS Template", false) == 0;
					if (flag14)
					{
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_lea = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag15 = Operators.CompareString(this.cboInvoiceTemplates.Text, "GetPro Template", false) == 0;
					if (flag15)
					{
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_lea = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag16 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Binum Template", false) == 0;
					if (flag16)
					{
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_lea = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(1));
						MyProject.Forms.Form1.inv_template_Farhan = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(0));
					}
					bool flag17 = Operators.CompareString(this.cboInvoiceTemplates.Text, "Farhan Template", false) == 0;
					if (flag17)
					{
						MyProject.Forms.Form1.inv_template_revmax = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_normal = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_incotex = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_lea = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_pharma = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_tongaat = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_FDMS = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_GetPro = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Binum = 0;
						this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
						MyProject.Forms.Form1.inv_template_Farhan = 1;
						this.publicfunction.AddUpdateAppSettings("inv_template_Farhan", Conversions.ToString(1));
					}
					bool checked4 = this.chkHideVAT.Checked;
					if (checked4)
					{
						MyProject.Forms.Form1.hidevat = 1;
						this.publicfunction.AddUpdateAppSettings("hidevat", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.hidevat = 0;
						this.publicfunction.AddUpdateAppSettings("hidevat", Conversions.ToString(0));
					}
				}
				else
				{
					this.publicfunction.AddUpdateAppSettings("PrintInvoice", "0");
					MyProject.Forms.Form1.PrintInvoice = 0;
				}
				bool checked5 = this.chkShowPaymentMethods.Checked;
				if (checked5)
				{
					this.publicfunction.AddUpdateAppSettings("ShowPaymentMethodsOnReceipt", "1");
					MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt = 1;
				}
				else
				{
					this.publicfunction.AddUpdateAppSettings("ShowPaymentMethodsOnReceipt", "0");
					MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt = 0;
				}
				MyProject.Forms.Form1.PrintFiscal = 0;
				this.publicfunction.AddUpdateAppSettings("PrintFiscal", Conversions.ToString(0));
				MyProject.Forms.Form1.FiscalEltrade = 0;
				this.publicfunction.AddUpdateAppSettings("FiscalEltrade", Conversions.ToString(0));
				MyProject.Forms.Form1.FiscalRevmax = 0;
				this.publicfunction.AddUpdateAppSettings("FiscalRevmax", Conversions.ToString(0));
				int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.cboFont.Text, "", false) == 0, 7, Conversion.Val(this.cboFont.Text)));
				MyProject.Forms.Form1.ReceiptFontSize = num;
				this.publicfunction.AddUpdateAppSettings("ReceiptFontSize", Conversions.ToString(num));
				this.UpdateBranchFootnote(MyProject.Forms.Form1.branch, this.txtFootnote.Text);
				bool checked6 = this.chk.Checked;
				if (checked6)
				{
					MyProject.Forms.Form1.SelectA4InvatPOS = 1;
					this.publicfunction.AddUpdateAppSettings("SelectA4InvatPOS", Conversions.ToString(1));
				}
				else
				{
					MyProject.Forms.Form1.SelectA4InvatPOS = 0;
					this.publicfunction.AddUpdateAppSettings("SelectA4InvatPOS", Conversions.ToString(0));
				}
				bool checked7 = this.chkSecondaryPrinter.Checked;
				if (checked7)
				{
					this.publicfunction.AddUpdateAppSettings("defaultSecondaryPrinter", this.cboPrinterSecondary.Text);
					this.publicfunction.AddUpdateAppSettings("defaultSecondaryPrinterCaption", this.txtSecondaryPrinterCaption.Text);
					MyProject.Forms.Form1.defaultSecondaryPrinter = this.cboPrinterSecondary.Text;
					MyProject.Forms.Form1.defaultSecondaryPrinterCaption = this.txtSecondaryPrinterCaption.Text;
				}
				else
				{
					this.publicfunction.AddUpdateAppSettings("defaultSecondaryPrinter", "");
					this.publicfunction.AddUpdateAppSettings("defaultSecondaryPrinterCaption", "");
					MyProject.Forms.Form1.defaultSecondaryPrinter = "";
					MyProject.Forms.Form1.defaultSecondaryPrinterCaption = "";
				}
				this.publicfunction.AddUpdateAppSettings("InvoiceHeaderText", this.txtHeaderText.Text);
				MyProject.Forms.Form1.InvoiceHeaderText = this.txtHeaderText.Text;
				bool checked8 = this.chkPrintBarcodedInvNumber.Checked;
				if (checked8)
				{
					MyProject.Forms.Form1.PrintBarcodeInvNumber = 1;
					this.publicfunction.AddUpdateAppSettings("PrintBarcodeInvNumber", Conversions.ToString(1));
				}
				else
				{
					MyProject.Forms.Form1.PrintBarcodeInvNumber = 0;
					this.publicfunction.AddUpdateAppSettings("PrintBarcodeInvNumber", Conversions.ToString(0));
				}
				MyProject.Forms.Form1.useprintercategories = 0;
				this.publicfunction.AddUpdateAppSettings("useprintercategories", Conversions.ToString(0));
				bool checked9 = this.chkUseOldPrintingService.Checked;
				if (checked9)
				{
					this.publicfunction.AddUpdateAppSettings("useOldPrintingService", Conversions.ToString(1));
					MyProject.Forms.Form1.useOldPrintingService = 1;
				}
				else
				{
					this.publicfunction.AddUpdateAppSettings("useOldPrintingService", Conversions.ToString(0));
					MyProject.Forms.Form1.useOldPrintingService = 0;
				}
				MyProject.Forms.Form1.receipt_copy_name = this.txtrec_copy_name.Text;
				this.publicfunction.AddUpdateAppSettings("receipt_copy_name", this.txtrec_copy_name.Text);
				MyProject.Forms.Form1.receipt_template = this.cboReceiptTemplate.Text;
				this.publicfunction.AddUpdateAppSettings("receipt_template", this.cboReceiptTemplate.Text);
				this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", "0", MyProject.Forms.Form1.Constring);
				this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "ReceiptSpacingSize", Conversions.ToString(Conversion.Val(this.txtreceiptspacingsize.Text)), MyProject.Forms.Form1.Constring);
				MyProject.Forms.Form1.ReceiptSpacingSize = checked((int)Math.Round(Conversion.Val(this.txtreceiptspacingsize.Text)));
				this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "ReceiptExtraSpace", Conversions.ToString(Conversion.Val(this.txtExtraSpaces.Text)), MyProject.Forms.Form1.Constring);
				MessageBox.Show("Settings saved.", "Information");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving data. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x001A67CC File Offset: 0x001A49CC
		private void UpdateBranchFootnote(string branch, string footnote)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Update branches set footnote='",
				footnote,
				"' where branch= '",
				branch,
				"' and coid= ",
				Conversions.ToString(MyProject.Forms.Form1.coid)
			});
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x001A6874 File Offset: 0x001A4A74
		private string GetFooterText(int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select footnote from branches where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = Conversions.ToString(dataRow["footnote"]);
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x001A693C File Offset: 0x001A4B3C
		private void FetchPrinterSettings()
		{
			try
			{
				bool flag = MyProject.Forms.Form1.PrintReceipt == 1;
				if (flag)
				{
					this.CheckBox1.Checked = true;
				}
				bool flag2 = MyProject.Forms.Form1.PrintInvoice == 1;
				if (flag2)
				{
					this.CheckBox2.Checked = true;
				}
				this.txtFootnote.Text = this.GetFooterText(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				bool flag3 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag3)
				{
					this.chkShowPaymentMethods.Checked = true;
				}
				bool flag4 = MyProject.Forms.Form1.ReceiptFontSize == 0;
				if (flag4)
				{
					this.cboFont.SelectedIndex = this.cboFont.FindStringExact("7");
				}
				else
				{
					this.cboFont.Text = MyProject.Forms.Form1.ReceiptFontSize.ToString();
				}
				bool flag5 = (MyProject.Forms.Form1.ReceiptSize80 == 1) & (MyProject.Forms.Form1.PrintReceipt == 1);
				if (flag5)
				{
					this.cboSize.SelectedIndex = this.cboSize.FindString("80mm");
				}
				else
				{
					bool flag6 = (MyProject.Forms.Form1.ReceiptSize80 == 0) & (MyProject.Forms.Form1.PrintReceipt == 1);
					if (flag6)
					{
						this.cboSize.SelectedIndex = this.cboSize.FindString("58mm");
					}
				}
				bool flag7 = MyProject.Forms.Form1.ReceiptsOptional == 1;
				if (flag7)
				{
					this.chkReceiptsOptional.Checked = true;
				}
				else
				{
					this.chkReceiptsOptional.Checked = false;
				}
				bool flag8 = Operators.CompareString(MyProject.Forms.Form1.defaultReceiptPrinter, "", false) != 0;
				if (flag8)
				{
					this.cboPrinters.SelectedIndex = this.cboPrinters.FindStringExact(MyProject.Forms.Form1.defaultReceiptPrinter);
				}
				bool flag9 = Operators.CompareString(MyProject.Forms.Form1.defaultSecondaryPrinter, "", false) != 0;
				if (flag9)
				{
					this.cboPrinterSecondary.SelectedIndex = this.cboPrinterSecondary.FindStringExact(MyProject.Forms.Form1.defaultSecondaryPrinter);
					this.txtSecondaryPrinterCaption.Text = MyProject.Forms.Form1.defaultSecondaryPrinterCaption;
					this.chkSecondaryPrinter.Checked = true;
				}
				bool flag10 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
				if (flag10)
				{
					this.chkPrintBarcodedInvNumber.Checked = true;
				}
				else
				{
					this.chkPrintBarcodedInvNumber.Checked = false;
				}
				bool flag11 = MyProject.Forms.Form1.NumOfReceiptsPrint == 0;
				if (flag11)
				{
					this.txtNumberOfCopies.Text = "1";
				}
				else
				{
					this.txtNumberOfCopies.Text = MyProject.Forms.Form1.NumOfReceiptsPrint.ToString();
				}
				bool flag12 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "", false) != 0;
				if (flag12)
				{
					this.cboReceiptTemplate.Text = MyProject.Forms.Form1.receipt_template;
				}
				bool flag13 = MyProject.Forms.Form1.hidevat == 1;
				if (flag13)
				{
					this.chkHideVAT.Checked = true;
				}
				else
				{
					this.chkHideVAT.Checked = false;
				}
				bool flag14 = MyProject.Forms.Form1.SelectA4InvatPOS == 1;
				if (flag14)
				{
					this.chk.Checked = true;
				}
				else
				{
					this.chk.Checked = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x001A6D24 File Offset: 0x001A4F24
		private void removeTabs()
		{
			this.TabControl1.TabPages.Remove(this.TabPage1);
			this.TabControl1.TabPages.Remove(this.TabPage2);
			this.TabControl1.TabPages.Remove(this.TabPage3);
			this.TabControl1.TabPages.Remove(this.TabPage4);
			this.TabControl1.TabPages.Remove(this.TabPage5);
			this.TabControl1.TabPages.Remove(this.TabPage6);
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x001A6DBC File Offset: 0x001A4FBC
		private void GetNextInvoiceNumberSales(int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetSalesInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("allowbackdated", MyProject.Forms.Form1.DateChange);
			sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
			sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlConnection.Open();
			this.invnum = Conversions.ToInteger(sqlCommand.ExecuteScalar());
			sqlConnection.Close();
			this.txtNextInvoiceNumber.Text = this.invnum.ToString();
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x001A6EF4 File Offset: 0x001A50F4
		private int GetNextCreditNoteNumber(int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select top 1 isnull(creditnotenumber,0) as creditnotenumber from CreditNoteNumbers where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' ORDER BY ENTRYNO DESC"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(Operators.AddObject(dataRow["creditnotenumber"], 1));
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x001A6FB4 File Offset: 0x001A51B4
		private int GetNextDebitNoteNumber()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select isnull(max(debitno),0) as debitnotenumber from InvoiceNumbersDebitNotes";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(Operators.AddObject(dataRow["debitnotenumber"], 1));
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x001A7048 File Offset: 0x001A5248
		private void Printers_Load(object sender, EventArgs e)
		{
			try
			{
				this.loadInstalledPrinters();
				this.FetchPrinterSettings();
				this.removeTabs();
				this.GetInvoiceSettings();
				this.txtpath.Text = MyProject.Forms.Form1.PrintFilePath;
				bool flag = MyProject.Forms.Form1.PrintToFile == 1;
				if (flag)
				{
					this.chkPrintToFile.Checked = true;
				}
				else
				{
					this.chkPrintToFile.Checked = false;
				}
				this.txtFiscalDeviceDetails.Text = MyProject.Forms.Form1.FiscalEltradeESDSerial;
				bool flag2 = MyProject.Forms.Form1.showfooter == 1;
				if (flag2)
				{
					this.chkShowFooterDetails.Checked = true;
				}
				else
				{
					this.chkShowFooterDetails.Checked = false;
				}
				this.txtHeaderText.Text = MyProject.Forms.Form1.InvoiceHeaderText;
				base.WindowState = FormWindowState.Maximized;
				this.cboCategories.DataSource = this.publicfunction.LoadCategories(this._cnn);
				this.cboCategories.ValueMember = "CatID";
				this.cboCategories.DisplayMember = "CatDesc";
				this.cboCategories.SelectedIndex = -1;
				bool flag3 = MyProject.Forms.Form1.useOldPrintingService == 1;
				if (flag3)
				{
					this.chkUseOldPrintingService.Checked = true;
				}
				else
				{
					this.chkUseOldPrintingService.Checked = false;
				}
				this.txtrec_copy_name.Text = MyProject.Forms.Form1.receipt_copy_name;
				bool flag4 = MyProject.Forms.Form1.inv_template_normal == 1;
				if (flag4)
				{
					this.cboInvoiceTemplates.Text = "Normal Invoice";
				}
				bool flag5 = MyProject.Forms.Form1.inv_template_incotex == 1;
				if (flag5)
				{
					this.cboInvoiceTemplates.Text = "Incotex Template";
				}
				bool flag6 = MyProject.Forms.Form1.inv_template_revmax == 1;
				if (flag6)
				{
					this.cboInvoiceTemplates.Text = "Revmax Template";
				}
				bool flag7 = MyProject.Forms.Form1.inv_template_lea == 1;
				if (flag7)
				{
					this.cboInvoiceTemplates.Text = "Lea Invoice Template";
				}
				bool flag8 = MyProject.Forms.Form1.inv_template_pharma == 1;
				if (flag8)
				{
					this.cboInvoiceTemplates.Text = "Pharma Template";
				}
				bool flag9 = MyProject.Forms.Form1.inv_template_tongaat == 1;
				if (flag9)
				{
					this.cboInvoiceTemplates.Text = "Tongaat Template";
				}
				bool flag10 = MyProject.Forms.Form1.inv_template_FDMS == 1;
				if (flag10)
				{
					this.cboInvoiceTemplates.Text = "FDMS Template";
				}
				bool flag11 = MyProject.Forms.Form1.inv_template_GetPro == 1;
				if (flag11)
				{
					this.cboInvoiceTemplates.Text = "GetPro Template";
				}
				bool flag12 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", MyProject.Forms.Form1.Constring), "1", false) == 0;
				if (flag12)
				{
					this.RadLBA4.Checked = true;
					this.txtLBpath.Text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBFolderPath", MyProject.Forms.Form1.Constring);
					this.cboLBPrinters.Text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBPrinterName", MyProject.Forms.Form1.Constring);
					this.txtLBWait.Text = Conversions.ToString(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBWaitTime", MyProject.Forms.Form1.Constring)) / 1000.0);
					bool flag13 = MyProject.Forms.Form1.inv_template_normal == 1;
					if (flag13)
					{
						this.cboLBInvTemplate.Text = "Normal Invoice";
					}
					else
					{
						this.cboLBInvTemplate.Text = "Binum Template";
					}
				}
				else
				{
					this.RadLBA4.Checked = false;
					this.txtLBpath.Text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBFolderPath", MyProject.Forms.Form1.Constring);
					this.cboLBPrinters.Text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBPrinterName", MyProject.Forms.Form1.Constring);
					this.txtLBWait.Text = Conversions.ToString(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBWaitTime", MyProject.Forms.Form1.Constring)) / 1000.0);
					bool flag14 = MyProject.Forms.Form1.inv_template_normal == 1;
					if (flag14)
					{
						this.cboLBInvTemplate.Text = "Normal Invoice";
					}
					else
					{
						this.cboLBInvTemplate.Text = "Binum Template";
					}
				}
				bool flag15 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", MyProject.Forms.Form1.Constring), "1", false) == 0;
				if (flag15)
				{
					this.RadLB80.Checked = true;
					this.cboLBPrinters.Text = MyProject.Forms.Form1.defaultReceiptPrinter;
				}
				this.txtEXSymbol.Text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "TaxExemptSymbol", MyProject.Forms.Form1.Constring);
				bool flag16 = File.Exists("C:\\Quantum\\logo.bmp");
				if (flag16)
				{
					this.PictureBox2.ImageLocation = "C:\\Quantum\\logo.bmp";
				}
				int num = checked((int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LogoSpacePadding", MyProject.Forms.Form1.Constring))));
				bool flag17 = num != 0;
				if (flag17)
				{
					this.txtLogoSpacePadding.Text = num.ToString();
				}
				else
				{
					this.txtLogoSpacePadding.Text = Conversions.ToString(1200);
				}
				this.txtExtraSpaces.Text = Conversions.ToString(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "ReceiptExtraSpace", MyProject.Forms.Form1.Constring)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x001A7804 File Offset: 0x001A5A04
		private void GetCompanyDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
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

		// Token: 0x0600312E RID: 12590 RVA: 0x001A78B8 File Offset: 0x001A5AB8
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
				text = "TEST RECEIPT";
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

		// Token: 0x0600312F RID: 12591 RVA: 0x001A79B0 File Offset: 0x001A5BB0
		public void ItemsToBePrinted()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description" + Environment.NewLine;
			string text = "Product 1 X 2 @ " + Strings.FormatCurrency("10.00", 2, TriState.True, TriState.True, TriState.True);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			text = "Product 2 X 4 @ " + Strings.FormatCurrency("5.00", 2, TriState.True, TriState.True, TriState.True);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			text = "Product 3 X 1 @ " + Strings.FormatCurrency("50.00", 2, TriState.True, TriState.True, TriState.True);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x001A7A68 File Offset: 0x001A5C68
		private void PrintFooter()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine + Environment.NewLine;
			string text = "Sub Total   " + Strings.FormatCurrency("90.00", -1, TriState.True, TriState.True, TriState.True);
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
				text = "Cash        " + Strings.FormatCurrency("100.00", -1, TriState.True, TriState.True, TriState.True);
				text2 = Conversions.ToString(length);
				string text4 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag = Operators.CompareString(text, "Cash        $0.00", false) != 0;
				if (flag)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text4 + text + Environment.NewLine;
				}
				text = "Change      " + Strings.FormatCurrency("10.00", -1, TriState.True, TriState.True, TriState.True);
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
				bool flag2 = Operators.CompareString(this.txtFootnote.Text, "", false) != 0;
				if (flag2)
				{
					text = this.txtFootnote.Text;
					text2 = Conversions.ToString(length);
					string text6 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
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
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x001A7C90 File Offset: 0x001A5E90
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

		// Token: 0x06003132 RID: 12594 RVA: 0x001A7E64 File Offset: 0x001A6064
		private void PrintReceipt(string printer_name)
		{
			this.PrintHeader();
			this.ItemsToBePrinted();
			this.PrintFooter();
			StandardPrintController standardPrintController = new StandardPrintController();
			this.PrintDocument1.PrinterSettings.PrinterName = printer_name;
			this.PrintDocument1.PrintController = standardPrintController;
			this.PrintDocument1.Print();
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x001A7EB8 File Offset: 0x001A60B8
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.GetCompanyDetails();
				this.PrintReceipt(this.cboPrinters.Text);
				MessageBox.Show("Test receipt sent to Receipt Printer. Check the receipt.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to print receipt. Error details: " + ex.Message);
			}
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x001A7F24 File Offset: 0x001A6124
		private void cmbPrinterType_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cmbPrinterType.Text, "Normal Printer", false) == 0;
				if (flag)
				{
					this.removeTabs();
					this.TabControl1.TabPages.Insert(0, this.TabPage1);
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cmbPrinterType.Text, "Eltrade Fiscal Printer", false) == 0;
					if (flag2)
					{
						this.removeTabs();
						this.TabControl1.TabPages.Insert(0, this.TabPage2);
						this.loadEltradeSettings();
					}
					else
					{
						bool flag3 = Operators.CompareString(this.cmbPrinterType.Text, "Revmax Fiscal Printer", false) == 0;
						if (flag3)
						{
							this.removeTabs();
							this.TabControl1.TabPages.Insert(0, this.TabPage3);
						}
						else
						{
							bool flag4 = Operators.CompareString(this.cmbPrinterType.Text, "Eltrade ESD", false) == 0;
							if (flag4)
							{
								this.removeTabs();
								this.TabControl1.TabPages.Insert(0, this.TabPage4);
							}
							else
							{
								bool flag5 = Operators.CompareString(this.cmbPrinterType.Text, "Set Printer By Category", false) == 0;
								if (flag5)
								{
									this.removeTabs();
									this.TabControl1.TabPages.Insert(0, this.TabPage5);
									this.ViewCategoryPrinters();
									this.cboPapersize2.SelectedIndex = 0;
								}
								else
								{
									bool flag6 = Operators.CompareString(this.cmbPrinterType.Text, "Leafbright Fiscal", false) == 0;
									if (flag6)
									{
										this.removeTabs();
										this.TabControl1.TabPages.Insert(0, this.TabPage6);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting printer type." + ex.Message);
			}
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x001A811C File Offset: 0x001A631C
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvEltrade.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						this.SaveSettings(Conversions.ToInteger(dataGridViewRow.Cells["paymentmethodid"].Value), Conversions.ToString(dataGridViewRow.Cells["paymentmethoddesc"].Value), Conversions.ToInteger(dataGridViewRow.Cells["ComPort"].Value), Conversions.ToInteger(dataGridViewRow.Cells["ComSpeed"].Value));
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
				this.SaveFiscalPrinterSettings();
				MyProject.Forms.Form1.useprintercategories = 0;
				this.publicfunction.AddUpdateAppSettings("useprintercategories", Conversions.ToString(0));
				MessageBox.Show("Printer settings saved.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x001A825C File Offset: 0x001A645C
		private void SaveFiscalPrinterSettings()
		{
			this.publicfunction.AddUpdateAppSettings("PrintReceipt", "1");
			this.publicfunction.AddUpdateAppSettings("PrintFiscal", "1");
			this.publicfunction.AddUpdateAppSettings("FiscalEltrade", "1");
			this.publicfunction.AddUpdateAppSettings("FiscalRevmax", "0");
			MyProject.Forms.Form1.PrintReceipt = 1;
			MyProject.Forms.Form1.PrintFiscal = 1;
			MyProject.Forms.Form1.FiscalEltrade = 1;
			MyProject.Forms.Form1.FiscalRevmax = 0;
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x001A8304 File Offset: 0x001A6504
		private void cboCable_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.PrinterCable = this.cboCable.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error applying cable settings. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNumberOfCopies_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x001A8368 File Offset: 0x001A6568
		private void UpdateBranchFootnote()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateBranchFootNote";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("footnote", this.txtFootnote.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x001A8434 File Offset: 0x001A6634
		private void loadEltradeSettings()
		{
			this.dgvEltrade.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvEltrade.DataSource = dataTable;
			this.dgvEltrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEltrade.Columns["rate"].Visible = false;
			this.dgvEltrade.Columns["uploaded"].Visible = false;
			this.dgvEltrade.Columns["paymentmethodid"].Visible = false;
			this.dgvEltrade.Columns["FiscalGroup"].Visible = false;
			this.dgvEltrade.Columns.Add("ComPort", "Com Port");
			this.dgvEltrade.Columns.Add("ComSpeed", "Com Speed");
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Test Connection";
			dataGridViewButtonColumn.Text = "Test Conn";
			dataGridViewButtonColumn.Name = "Test Conn";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvEltrade.Columns.Add(dataGridViewButtonColumn);
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn2.HeaderText = "Print Test Receipt";
			dataGridViewButtonColumn2.Text = "Test Receipt";
			dataGridViewButtonColumn2.Name = "Test Receipt";
			dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
			this.dgvEltrade.Columns.Add(dataGridViewButtonColumn2);
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvEltrade.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					DataTable eltradeSetting = this.getEltradeSetting(Conversions.ToInteger(dataGridViewRow.Cells["paymentmethodid"].Value));
					bool flag = eltradeSetting.Rows.Count > 0;
					if (flag)
					{
						DataRow dataRow = eltradeSetting.Rows[0];
						dataGridViewRow.Cells["ComPort"].Value = RuntimeHelpers.GetObjectValue(dataRow["ComPort"]);
						dataGridViewRow.Cells["ComSpeed"].Value = RuntimeHelpers.GetObjectValue(dataRow["ComSpeed"]);
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

		// Token: 0x0600313B RID: 12603 RVA: 0x001A870C File Offset: 0x001A690C
		private DataTable getEltradeSetting(int paymentmethodid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "getEltradePortSettings";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x001A8774 File Offset: 0x001A6974
		private void SaveSettings(int paymentmethodid, string paymentmethoddesc, int Comport, int Comspeed)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "saveEltradeSetting";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			sqlCommand.Parameters.AddWithValue("paymentmethoddesc", paymentmethoddesc);
			sqlCommand.Parameters.AddWithValue("comport", Comport);
			sqlCommand.Parameters.AddWithValue("comspeed", Comspeed);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x001A8838 File Offset: 0x001A6A38
		private void dgvEltrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Save", false) == 0;
					if (flag2)
					{
						this.SaveSettings(Conversions.ToInteger(this.dgvEltrade.Rows[e.RowIndex].Cells["paymentmethodid"].Value), Conversions.ToString(this.dgvEltrade.Rows[e.RowIndex].Cells["paymentmethoddesc"].Value), Conversions.ToInteger(this.dgvEltrade.Rows[e.RowIndex].Cells["ComPort"].Value), Conversions.ToInteger(this.dgvEltrade.Rows[e.RowIndex].Cells["ComSpeed"].Value));
					}
					else
					{
						bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Test Conn", false) == 0;
						if (flag3)
						{
							EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
							int num = eltradeFprn.Init(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvEltrade.Rows[e.RowIndex].Cells["ComPort"].Value)), Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvEltrade.Rows[e.RowIndex].Cells["ComSpeed"].Value)), 0, 0, 0, "");
							bool flag4 = num == 0;
							if (flag4)
							{
								eltradeFprn.Close();
								MessageBox.Show("Init Successfull");
							}
							else
							{
								eltradeFprn.Close();
								MessageBox.Show("Eltrade Fiscal Device init failed. Error Code: " + num.ToString());
							}
						}
						else
						{
							bool flag5 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Test Receipt", false) == 0;
							if (flag5)
							{
								EltradeFprn eltradeFprn2 = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
								bool flag6 = eltradeFprn2.Init(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvEltrade.Rows[e.RowIndex].Cells["ComPort"].Value)), Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvEltrade.Rows[e.RowIndex].Cells["ComSpeed"].Value)), 0, 0, 0, "") == 0;
								if (flag6)
								{
									int num2 = eltradeFprn2.RunPrinterTest();
									bool flag7 = num2 == 0;
									if (flag7)
									{
										MessageBox.Show("Printer Test Success");
									}
									else
									{
										MessageBox.Show(Conversions.ToString(Conversions.ToDouble("Printer test ERROR. Code: ") + (double)num2));
									}
								}
								else
								{
									MessageBox.Show("Eltrade Device Init Failed.");
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

		// Token: 0x0600313E RID: 12606 RVA: 0x001A8BD4 File Offset: 0x001A6DD4
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error connecting to Revmax device. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x001A8C1C File Offset: 0x001A6E1C
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing test receipt. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x001A8C64 File Offset: 0x001A6E64
		private string BuildCurrencyXML()
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("CurrenciesReceived");
			this.MakeCurrency(xmlWriter, "USD", 20m, 1m);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			StreamReader streamReader = new StreamReader(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			string text = streamReader.ReadToEnd();
			xmlWriter.Close();
			return text;
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x001A8D04 File Offset: 0x001A6F04
		private string BuildItemsXML()
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("ITEMS");
			this.MakeItems(xmlWriter, 1, "aab001", "Product 1 desc", "Product 1 desc2", 2m, 10m, 20m, 2.9m, 0.145m);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			StreamReader streamReader = new StreamReader(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			this.lblRevMax.Text = streamReader.ReadToEnd();
			xmlWriter.Close();
			return this.lblRevMax.Text;
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x001A8DE4 File Offset: 0x001A6FE4
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

		// Token: 0x06003143 RID: 12611 RVA: 0x001A8F20 File Offset: 0x001A7120
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

		// Token: 0x06003144 RID: 12612 RVA: 0x001A8FA0 File Offset: 0x001A71A0
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				this.publicfunction.AddUpdateAppSettings("PrintFiscal", "1");
				this.publicfunction.AddUpdateAppSettings("FiscalEltrade", "0");
				this.publicfunction.AddUpdateAppSettings("FiscalRevmax", "1");
				bool @checked = this.RadioButton1.Checked;
				if (@checked)
				{
					bool flag = Operators.CompareString(this.cboprintersRev.Text, "", false) == 0;
					if (flag)
					{
						MessageBox.Show("Please select the receipt printer to use. Thank you.");
						return;
					}
					MyProject.Forms.Form1.PrintReceipt = 1;
					this.publicfunction.AddUpdateAppSettings("PrintReceipt", "1");
					this.publicfunction.AddUpdateAppSettings("PrintInvoice", "0");
					MyProject.Forms.Form1.PrintReceipt = 1;
					MyProject.Forms.Form1.PrintInvoice = 0;
					this.publicfunction.AddUpdateAppSettings("defaultReceiptPrinter", this.cboprintersRev.Text);
					MyProject.Forms.Form1.defaultReceiptPrinter = this.cboprintersRev.Text;
				}
				else
				{
					bool checked2 = this.RadioButton2.Checked;
					if (checked2)
					{
						MyProject.Forms.Form1.PrintInvoice = 1;
						this.publicfunction.AddUpdateAppSettings("PrintInvoice", "1");
						this.publicfunction.AddUpdateAppSettings("PrintReceipt", "0");
						MyProject.Forms.Form1.PrintReceipt = 0;
						bool flag2 = Operators.CompareString(this.cboInvTemplates.Text, "Revmax Template", false) == 0;
						if (flag2)
						{
							this.ClearSavedInvTemplates();
							MyProject.Forms.Form1.inv_template_revmax = 1;
							this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(1));
						}
						else
						{
							bool flag3 = Operators.CompareString(this.cboInvTemplates.Text, "GetPro Template", false) == 0;
							if (flag3)
							{
								this.ClearSavedInvTemplates();
								MyProject.Forms.Form1.inv_template_GetPro = 1;
								this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(1));
							}
							else
							{
								bool flag4 = Operators.CompareString(this.cboInvTemplates.Text, "Binum Template", false) == 0;
								if (flag4)
								{
									this.ClearSavedInvTemplates();
									MyProject.Forms.Form1.inv_template_Binum = 1;
									this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(1));
								}
							}
						}
					}
				}
				MyProject.Forms.Form1.PrintFiscal = 1;
				this.publicfunction.AddUpdateAppSettings("PrintFiscal", Conversions.ToString(1));
				MyProject.Forms.Form1.FiscalEltrade = 0;
				MyProject.Forms.Form1.FiscalRevmax = 1;
				this.publicfunction.AddUpdateAppSettings("FiscalRevmax", Conversions.ToString(1));
				bool checked3 = this.chkRevmaxTest.Checked;
				if (checked3)
				{
					MyProject.Forms.Form1.RevmaxTest = 1;
				}
				else
				{
					MyProject.Forms.Form1.RevmaxTest = 0;
				}
				MessageBox.Show("Revmax fiscal settings set. Please restart the application");
				base.Dispose();
			}
			catch (Exception ex)
			{
				bool flag5 = Operators.CompareString(ex.Message, "Index was outside the bounds of the array.", false) == 0;
				if (flag5)
				{
					MessageBox.Show("Settings saved but device settings were not found.");
				}
				else
				{
					MessageBox.Show("Error saving settings. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x001A9330 File Offset: 0x001A7530
		private void ClearSavedInvTemplates()
		{
			MyProject.Forms.Form1.inv_template_normal = 0;
			this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
			MyProject.Forms.Form1.inv_template_incotex = 0;
			this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
			MyProject.Forms.Form1.inv_template_revmax = 0;
			this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
			MyProject.Forms.Form1.inv_template_pharma = 0;
			this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
			MyProject.Forms.Form1.inv_template_tongaat = 0;
			this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
			MyProject.Forms.Form1.inv_template_FDMS = 0;
			this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
			MyProject.Forms.Form1.inv_template_GetPro = 0;
			this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x001A9450 File Offset: 0x001A7650
		private void Button10_Click(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error generating Z Report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x001A9498 File Offset: 0x001A7698
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(this.BuildCurrencyXML());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error building currency xml. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x001A94EC File Offset: 0x001A76EC
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(this.BuildItemsXML());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error building items xml. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x001A9540 File Offset: 0x001A7740
		private void Button7_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.radEltradeESD.Checked;
				if (@checked)
				{
					this.publicfunction.AddUpdateAppSettings("PrintInvoice", "1");
					this.publicfunction.AddUpdateAppSettings("PrintFiscal", "1");
					this.publicfunction.AddUpdateAppSettings("PrintReceipt", "0");
					this.publicfunction.AddUpdateAppSettings("FiscalEltradeESD", "1");
					this.publicfunction.AddUpdateAppSettings("FiscalEltrateESDSerial", this.txtFiscalDeviceDetails.Text);
					MyProject.Forms.Form1.PrintReceipt = 0;
					MyProject.Forms.Form1.PrintInvoice = 1;
					MyProject.Forms.Form1.PrintFiscal = 1;
					MyProject.Forms.Form1.FiscalEltradeESD = 1;
					MyProject.Forms.Form1.FiscalEltradeESDSerial = this.txtFiscalDeviceDetails.Text;
					MessageBox.Show("Interfaced Fiscal Device Settings saved.");
				}
				else
				{
					bool checked2 = this.radEltradeESDReceipt.Checked;
					if (checked2)
					{
						this.publicfunction.AddUpdateAppSettings("PrintInvoice", "0");
						this.publicfunction.AddUpdateAppSettings("PrintFiscal", "1");
						this.publicfunction.AddUpdateAppSettings("PrintReceipt", "1");
						this.publicfunction.AddUpdateAppSettings("FiscalEltradeESD", "1");
						MyProject.Forms.Form1.PrintReceipt = 1;
						MyProject.Forms.Form1.PrintInvoice = 0;
						MyProject.Forms.Form1.PrintFiscal = 1;
						MyProject.Forms.Form1.FiscalEltradeESD = 1;
						this.publicfunction.AddUpdateAppSettings("PrintToFile", "1");
						MessageBox.Show("Interfaced Fiscal Device Settings saved.");
					}
					else
					{
						MessageBox.Show("No settings changed.");
					}
				}
				bool checked3 = this.chkPrintToFile.Checked;
				if (checked3)
				{
					this.publicfunction.AddUpdateAppSettings("PrintToFile", "1");
					MyProject.Forms.Form1.PrintToFile = 1;
					this.publicfunction.AddUpdateAppSettings("PrintFilePath", this.txtpath.Text);
					MyProject.Forms.Form1.PrintFilePath = this.txtpath.Text;
					bool checked4 = this.radSaveasPDF.Checked;
					if (checked4)
					{
						MyProject.Forms.Form1.InterfacedFiscalSaveas = "PDF";
						this.publicfunction.AddUpdateAppSettings("InterfacedFiscalSaveas", "PDF");
					}
					else
					{
						bool checked5 = this.radSaveasTXT.Checked;
						if (checked5)
						{
							MyProject.Forms.Form1.InterfacedFiscalSaveas = "TXT";
							this.publicfunction.AddUpdateAppSettings("InterfacedFiscalSaveas", "TXT");
						}
					}
				}
				else
				{
					this.publicfunction.AddUpdateAppSettings("PrintToFile", "0");
					MyProject.Forms.Form1.PrintToFile = 0;
					this.publicfunction.AddUpdateAppSettings("PrintFilePath", this.txtpath.Text);
					MyProject.Forms.Form1.PrintFilePath = this.txtpath.Text;
				}
				MyProject.Forms.Form1.useprintercategories = 0;
				this.publicfunction.AddUpdateAppSettings("useprintercategories", Conversions.ToString(0));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving Eltrade ESD settings. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x001A98D0 File Offset: 0x001A7AD0
		private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x001A991C File Offset: 0x001A7B1C
		private void Button8_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtNextInvoiceNumber.Text, "", false) != 0;
				if (flag)
				{
					this.SaveInvoiceNumberSettings();
					bool @checked = this.chkShowFooterDetails.Checked;
					if (@checked)
					{
						this.publicfunction.AddUpdateAppSettings("showfooter", "1");
						MyProject.Forms.Form1.showfooter = 1;
					}
					else
					{
						this.publicfunction.AddUpdateAppSettings("showfooter", "0");
						MyProject.Forms.Form1.showfooter = 0;
					}
					bool flag2 = this.invnum != Conversions.ToInteger(this.txtNextInvoiceNumber.Text);
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Change in the next invoice number detected. Do you want to save this change? Next invoice number will be: " + this.txtNextInvoiceNumber.Text, MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "SetNextInvoiceNumberSales";
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("nextnum", checked(Conversions.ToInteger(this.txtNextInvoiceNumber.Text) - 1));
							using (sqlConnection)
							{
								sqlConnection.Open();
								sqlCommand.ExecuteNonQuery();
								sqlConnection.Close();
							}
						}
					}
					bool flag4 = (double)this.currentNextCreditNoteNum != Conversion.Val(this.txtNextCreditNoteNumber.Text);
					if (flag4)
					{
						DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Change in the next Credit Note number detected. Do you want to save this change? Next invoice number will be: " + this.txtNextCreditNoteNumber.Text, MsgBoxStyle.YesNo, null);
						bool flag5 = dialogResult2 == DialogResult.Yes;
						if (flag5)
						{
							SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
							SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
							sqlCommand2.CommandType = CommandType.Text;
							sqlCommand2.CommandText = string.Concat(new string[]
							{
								"insert into CreditNoteNumbers (coid,branch,invoicenumber,creditnotenumber) values (",
								Conversions.ToString(MyProject.Forms.Form1.coid),
								",'",
								MyProject.Forms.Form1.branch,
								"',0,",
								Conversions.ToString(Conversion.Val(this.txtNextCreditNoteNumber.Text) - 1.0),
								")"
							});
							using (sqlConnection3)
							{
								sqlConnection3.Open();
								sqlCommand2.ExecuteNonQuery();
								sqlConnection3.Close();
							}
						}
					}
					bool flag6 = (double)this.currentNextDebitNoteNum != Conversion.Val(this.txtNextDebitNoteNum.Text);
					if (flag6)
					{
						DialogResult dialogResult3 = (DialogResult)Interaction.MsgBox("Change in the next Debit Note number detected. Do you want to save this change? Next invoice number will be: " + this.txtNextDebitNoteNum.Text, MsgBoxStyle.YesNo, null);
						bool flag7 = dialogResult3 == DialogResult.Yes;
						if (flag7)
						{
							SqlConnection sqlConnection5 = new SqlConnection(this._cnn);
							SqlCommand sqlCommand3 = sqlConnection5.CreateCommand();
							sqlCommand3.CommandType = CommandType.StoredProcedure;
							sqlCommand3.CommandText = "SetNextDebitNoteNumber";
							sqlCommand3.Parameters.AddWithValue("debitnotenumber", Conversion.Val(this.txtNextDebitNoteNum.Text));
							using (sqlConnection5)
							{
								sqlConnection5.Open();
								sqlCommand3.ExecuteNonQuery();
								sqlConnection5.Close();
							}
						}
					}
					this.GetInvoiceSettings();
					MessageBox.Show("Invoice number settings saved.");
				}
				else
				{
					MessageBox.Show("Please enter the leading characters And invoice length first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving invoice details. Details: " + ex.Message);
			}
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x001A9DB8 File Offset: 0x001A7FB8
		private void SaveInvoiceNumberSettings()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SetLeadingZeros";
			sqlCommand.Parameters.AddWithValue("leadingzeros", this.txtLeadingChars.Text);
			sqlCommand.Parameters.AddWithValue("setby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("numberofcharacters", Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtLength.Text, "", false) == 0, 0, this.txtLength.Text)));
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x001A9ED0 File Offset: 0x001A80D0
		private void GetInvoiceSettings()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetLeadingZeros";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtLeadingChars.Text = Conversions.ToString(dataRow["LeadingZeros"]);
				this.txtLength.Text = Conversions.ToString(dataRow["NumberofCharacters"]);
			}
			this.GetNextInvoiceNumberSales(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			this.txtNextCreditNoteNumber.Text = this.GetNextCreditNoteNumber(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString();
			checked
			{
				this.currentNextCreditNoteNum = (int)Math.Round(Conversion.Val(this.txtNextCreditNoteNumber.Text));
				this.txtNextDebitNoteNum.Text = Conversions.ToString(this.GetNextDebitNoteNumber());
				this.currentNextDebitNoteNum = (int)Math.Round(Conversion.Val(this.txtNextDebitNoteNum.Text));
			}
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x001AA04C File Offset: 0x001A824C
		private void radEltradeESDReceipt_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.radEltradeESDReceipt.Checked;
				if (@checked)
				{
					this.GroupBox6.Visible = true;
				}
				else
				{
					this.GroupBox6.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x001AA0AC File Offset: 0x001A82AC
		private void Button10_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtpath.Text = this.FolderBrowserDialog1.SelectedPath;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving file path. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x001AA120 File Offset: 0x001A8320
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.CheckBox1.Checked;
				if (@checked)
				{
					this.GroupBox7.Visible = true;
					this.CheckBox2.Checked = false;
					this.chkReceiptsOptional.Visible = true;
					this.cboPrinters.Visible = true;
					this.Button15.Visible = true;
					this.Button14.Visible = true;
					this.PictureBox2.Visible = true;
					this.chkPrintBarcodedInvNumber.Visible = true;
					this.btnAdditionalSettings.Visible = true;
				}
				else
				{
					this.GroupBox7.Visible = false;
					bool checked2 = this.chk.Checked;
					if (!checked2)
					{
						this.chkReceiptsOptional.Visible = false;
						this.cboPrinters.Visible = false;
						this.Button15.Visible = true;
						this.Button14.Visible = true;
						this.PictureBox2.Visible = true;
						this.chkPrintBarcodedInvNumber.Visible = false;
						this.btnAdditionalSettings.Visible = false;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x001AA264 File Offset: 0x001A8464
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.CheckBox2.Checked;
				if (@checked)
				{
					bool checked2 = this.chk.Checked;
					if (checked2)
					{
						this.Panel1.Visible = true;
					}
					else
					{
						this.CheckBox1.Checked = false;
						this.Panel1.Visible = true;
					}
				}
				else
				{
					this.Panel1.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x001AA2F4 File Offset: 0x001A84F4
		private void chk_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chk.Checked;
				if (@checked)
				{
					this.CheckBox1.Checked = true;
					this.CheckBox2.Checked = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x001AA350 File Offset: 0x001A8550
		private void loadInstalledPrinters()
		{
			this.cboPrinters.Items.Clear();
			this.cboPrinterSecondary.Items.Clear();
			try
			{
				foreach (object obj in PrinterSettings.InstalledPrinters)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					this.cboPrinters.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
					this.cboPrinterSecondary.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
					this.cboprintersRev.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
					this.cboPrinters2.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
					this.cboLBPrinters.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
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

		// Token: 0x06003154 RID: 12628 RVA: 0x00002A30 File Offset: 0x00000C30
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label14_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x001AA444 File Offset: 0x001A8644
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkSecondaryPrinter.Checked;
				if (@checked)
				{
					this.cboPrinterSecondary.Visible = true;
					this.txtSecondaryPrinterCaption.Visible = true;
					this.Label14.Visible = true;
					this.Label15.Visible = true;
				}
				else
				{
					this.cboPrinterSecondary.Visible = false;
					this.txtSecondaryPrinterCaption.Visible = false;
					this.Label14.Visible = false;
					this.Label15.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x001AA4F4 File Offset: 0x001A86F4
		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.RadioButton2.Checked;
			if (@checked)
			{
				this.Label16.Visible = false;
				this.cboprintersRev.Visible = false;
				this.Label29.Visible = true;
				this.cboInvTemplates.Visible = true;
			}
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x001AA548 File Offset: 0x001A8748
		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.RadioButton1.Checked;
			if (@checked)
			{
				this.Label16.Visible = true;
				this.cboprintersRev.Visible = true;
				this.Label29.Visible = false;
				this.cboInvTemplates.Visible = false;
			}
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x001AA59C File Offset: 0x001A879C
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x001AA5E8 File Offset: 0x001A87E8
		private void Button13_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = Operators.CompareString(this.cboPrinters.Text, "", false) == 0;
					if (flag)
					{
						MessageBox.Show("Please select a printer first.");
					}
					else
					{
						bool flag2 = Operators.CompareString(this.cboSize.Text, "", false) == 0;
						if (flag2)
						{
							MessageBox.Show("Please select a paper size first. 80mm is recommended.");
						}
						else
						{
							bool @checked = this.chkUseOldPrintingService.Checked;
							if (@checked)
							{
								this.GetCompanyDetails();
								this.PrintReceipt(this.cboPrinters.Text);
								MessageBox.Show("Test receipt sent to Receipt Printer. Check the receipt.");
							}
							else
							{
								PrinterClass printerClass = new PrinterClass(this.cboPrinters.Text, Application.StartupPath);
								PrinterClass printerClass2 = printerClass;
								int num = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LogoSpacePadding", MyProject.Forms.Form1.Constring)));
								bool flag3 = File.Exists("C:\\Quantum\\logo.bmp");
								if (flag3)
								{
									printerClass2.RTL = false;
									printerClass2.PrintLogo(num);
									printerClass2.FeedPaper(3);
								}
								this.GetCompanyDetails();
								printerClass2.AlignCenter();
								this.TextToPrint = "";
								string text = this.coname;
								int num2 = text.Length;
								string text2 = new string(' ', (int)Math.Round(Math.Round((double)(33 - num2) / 2.0)));
								ref string ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text2 + text + Environment.NewLine;
								text = "TEST RECEIPT";
								num2 = text.Length;
								string text3 = new string(' ', (int)Math.Round(Math.Round((double)(33 - num2) / 2.0)));
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text3 + text + Environment.NewLine;
								text = this.cotel;
								num2 = text.Length;
								string text4 = new string(' ', (int)Math.Round(Math.Round((double)(33 - num2) / 2.0)));
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text4 + text + Environment.NewLine;
								printerClass2.AlignCenter();
								printerClass2.NormalFont();
								printerClass2.WriteChars(this.TextToPrint);
								printerClass2.AlignLeft();
								text = "Description" + Environment.NewLine;
								printerClass2.WriteChars(text);
								text = "Product 1  X 2 @ " + Strings.FormatCurrency("10.00", 2, TriState.True, TriState.True, TriState.True);
								text += Environment.NewLine;
								text = text + "Product 2 X 4 @ " + Strings.FormatCurrency("5.00", 2, TriState.True, TriState.True, TriState.True);
								text += Environment.NewLine;
								text += Strings.Format("test align", Conversions.ToString(1));
								text += Environment.NewLine;
								text = text + "Product 3 X 1 @ " + Strings.FormatCurrency("50.00", 2, TriState.True, TriState.True, TriState.True);
								text += Environment.NewLine;
								printerClass2.WriteChars(text);
								bool checked2 = this.chkPrintBarcodedInvNumber.Checked;
								if (checked2)
								{
									try
									{
										Image image = this.PictureBox1.Image;
										BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39C;
										SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, this.invnum.ToString(), 20);
										this.PictureBox1.Image = symbologyTestCase.BarcodeImage;
										printerClass2.PrintBarcodeImage(this.PictureBox1, num);
									}
									catch (Exception ex)
									{
										MessageBox.Show("Failed to print barcode. Error: " + ex.Message);
									}
								}
								printerClass2.CutPaper();
								printerClass2.EndDoc();
								printerClass2 = null;
							}
						}
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show("Error: " + ex2.Message);
				}
			}
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x001AAA10 File Offset: 0x001A8C10
		private void Button15_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.PictureBox2.ImageLocation = this.OpenFileDialog1.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to load picture. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x001AAA84 File Offset: 0x001A8C84
		private void Button14_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.PictureBox2.ImageLocation, "", false) != 0;
			if (flag)
			{
				int width = this.PictureBox2.Width;
				int height = this.PictureBox2.Height;
				Bitmap bitmap = new Bitmap(width, height);
				this.PictureBox2.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));
				this.PictureBox2.Image = bitmap;
				bool @checked = this.chkCropImage.Checked;
				if (@checked)
				{
					this.publicfunction.SaveLogoBMP("C:\\Quantum\\logo.bmp", bitmap);
				}
				else
				{
					this.publicfunction.SaveLogoBMP("C:\\Quantum\\logo.bmp", this.PictureBox2.Image);
				}
				this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LogoSpacePadding", this.txtLogoSpacePadding.Text, MyProject.Forms.Form1.Constring);
			}
			else
			{
				MessageBox.Show("Please select a bitmap image first.");
			}
			MessageBox.Show("Image saved to file.");
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00002A30 File Offset: 0x00000C30
		private void radEltradeESD_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNextInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x001AABA0 File Offset: 0x001A8DA0
		private void Button17_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboCategories.SelectedIndex == -1;
				if (flag)
				{
					MessageBox.Show("Please select a category first.");
					this.cboCategories.Focus();
				}
				else
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.Text;
					bool flag2 = this.cboKDU.SelectedValue == null;
					int num;
					if (flag2)
					{
						num = 0;
					}
					else
					{
						num = Conversions.ToInteger(this.cboKDU.SelectedValue);
					}
					bool flag3 = Operators.CompareString(this.cboPrinters2.Text, "", false) == 0;
					string text;
					if (flag3)
					{
						text = "";
					}
					else
					{
						text = this.cboPapersize2.Text;
					}
					sqlCommand.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
					{
						"update categories set printername='",
						this.cboPrinters2.Text,
						"', papersize='",
						text,
						"',KDU=",
						Conversions.ToString(num),
						" where catid="
					}), this.cboCategories.SelectedValue), " and coid="), MyProject.Forms.Form1.coid));
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					MyProject.Forms.Form1.useprintercategories = 1;
					this.publicfunction.AddUpdateAppSettings("useprintercategories", Conversions.ToString(1));
					MyProject.Forms.Form1.PrintReceipt = 1;
					this.publicfunction.AddUpdateAppSettings("PrintReceipt", "1");
					MessageBox.Show("Printer settings saved.");
					this.ViewCategoryPrinters();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving printer settings. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x001AADC8 File Offset: 0x001A8FC8
		private void ViewCategoryPrinters()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select catid, catdesc, papersize, printername,k.KDUName from Categories c full join KitchenDisplayUnits k on c.KDU=k.Entryno where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvCategories.DataSource = dataTable;
			this.dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x001AAE74 File Offset: 0x001A9074
		private void Button16_Click(object sender, EventArgs e)
		{
			try
			{
				this.removeTabs();
				this.TabControl1.TabPages.Insert(0, this.TabPage5);
				this.ViewCategoryPrinters();
				this.loadKDUs();
				this.cboPapersize2.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x001AAEE0 File Offset: 0x001A90E0
		private void loadKDUs()
		{
			this.cboKDU.DataSource = this.publicfunction.LoadKDUs(this._cnn);
			this.cboKDU.DisplayMember = "KDUName";
			this.cboKDU.ValueMember = "EntryNo";
			this.cboKDU.SelectedIndex = -1;
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00002A30 File Offset: 0x00000C30
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button18_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button18_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00002A30 File Offset: 0x00000C30
		private void CutPaper(PrinterClass printdoc)
		{
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x001AAF3C File Offset: 0x001A913C
		private void Button18_Click_2(object sender, EventArgs e)
		{
			try
			{
				string text = "QUANTUMPOS SHOPS";
				string text2 = "Harare, Pretoria, Lusaka";
				string text3 = "TCN10-20191204-001";
				string text4 = Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss");
				PrintingFormat printingFormat = new PrintingFormat();
				double num = 50000.0;
				this.Data_Load();
				PrinterX.NewPrint(this.cboPrinters.Text);
				try
				{
					Image image = Image.FromFile(Application.StartupPath + "\\Resources\\QuantumPOS Logo2.jpg");
					PrinterX.Print(image, 200, 100);
				}
				catch (Exception ex)
				{
				}
				PrinterX.SetFont("Courier New", 11f, FontStyle.Bold);
				PrinterX.Print(text);
				PrinterX.SetFont("Courier New", 8f, FontStyle.Regular);
				PrinterX.Print(text2 + ";", new int[] { 280 }, 0);
				PrinterX.Print(" ");
				PrinterX.Print(text3);
				PrinterX.Print(text4);
				PrinterX.Print(" ");
				PrinterX.SetFont("Courier New", 8f, FontStyle.Bold);
				int[] array = new int[] { 90, 40, 50, 70 };
				StringFormat[] array2 = new StringFormat[] { printingFormat.MidLeft, printingFormat.MidRight, printingFormat.MidRight, printingFormat.MidRight };
				PrinterX.Print("item;qty;price;subtotal", array, array2);
				PrinterX.SetFont("Courier New", 8f, FontStyle.Regular);
				PrinterX.Print("------------------------------------");
				double num2 = 0.0;
				double num3 = 0.0;
				checked
				{
					int num4 = this.dtItem.Rows.Count - 1;
					for (int i = 0; i <= num4; i++)
					{
						PrinterX.Print(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.dtItem.Rows[i]["itemname"], ";"), this.dtItem.Rows[i]["qty"]), ";"), this.dtItem.Rows[i]["price"]), ";"), Operators.MultiplyObject(this.dtItem.Rows[i]["qty"], this.dtItem.Rows[i]["price"]))), array, array2);
						unchecked
						{
							num3 += (double)Conversions.ToSingle(this.dtItem.Rows[i]["qty"]);
							num2 = Conversions.ToDouble(Operators.AddObject(num2, Operators.MultiplyObject(this.dtItem.Rows[i]["qty"], this.dtItem.Rows[i]["price"])));
						}
					}
					PrinterX.Print("------------------------------------");
					array = new int[] { 130, 120 };
					array2 = new StringFormat[] { printingFormat.MidLeft, printingFormat.MidRight };
					PrinterX.Print("Total;" + Conversions.ToString(num2), array, array2);
					PrinterX.Print("Payment;" + Conversions.ToString(num), array, array2);
					PrinterX.Print("------------------------------------");
				}
				PrinterX.Print("Change;" + Conversions.ToString(num - num2), array, array2);
				PrinterX.Print(" ");
				PrinterX.Print("Item Qty;" + Conversions.ToString(num3), array, array2);
				PrinterX.DoPrint();
				MessageBox.Show("Test print job done.");
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error printing test print page. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x001AB38C File Offset: 0x001A958C
		public void Data_Load()
		{
			this.dtItem = new DataTable();
			DataColumnCollection columns = this.dtItem.Columns;
			columns.Add("itemname", Type.GetType("System.String"));
			columns.Add("qty", Type.GetType("System.String"));
			columns.Add("price", Type.GetType("System.String"));
			DataRow dataRow = this.dtItem.NewRow();
			dataRow["itemname"] = "Taro Snack";
			dataRow["qty"] = "1";
			dataRow["price"] = "5000";
			this.dtItem.Rows.Add(dataRow);
			dataRow = this.dtItem.NewRow();
			dataRow["itemname"] = "Kopi Ice";
			dataRow["qty"] = "2";
			dataRow["price"] = "7000";
			this.dtItem.Rows.Add(dataRow);
			dataRow = this.dtItem.NewRow();
			dataRow["itemname"] = "Lolipop";
			dataRow["qty"] = "5";
			dataRow["price"] = "1000";
			this.dtItem.Rows.Add(dataRow);
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x001AB4EC File Offset: 0x001A96EC
		private void Button19_Click(object sender, EventArgs e)
		{
			try
			{
				this.TextToPrint = "\u001bd1";
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = this.cboPrinters.Text;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x001AB57C File Offset: 0x001A977C
		private void Button20_Click(object sender, EventArgs e)
		{
			try
			{
				this.TextToPrint = "\u001bd1";
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = this.cboPrinters.Text;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x001AB60C File Offset: 0x001A980C
		private void Button21_Click(object sender, EventArgs e)
		{
			try
			{
				this.TextToPrint = Conversions.ToString(Convert.ToChar(29)) + "V" + Conversions.ToString(Convert.ToChar(65)) + Conversions.ToString(Convert.ToChar(0));
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = this.cboPrinters.Text;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x001AB6C4 File Offset: 0x001A98C4
		private void Button22_Click(object sender, EventArgs e)
		{
			try
			{
				SerialPort serialPort = new SerialPort();
				serialPort.PortName = "COM5";
				serialPort.BaudRate = 115200;
				serialPort.Parity = Parity.None;
				serialPort.DataBits = 8;
				serialPort.StopBits = StopBits.One;
				serialPort.Handshake = Handshake.None;
				serialPort.Open();
				serialPort.WriteLine("Line1");
				serialPort.WriteLine("Line2");
				serialPort.WriteLine("Line3");
				byte b = Conversions.ToByte("0x1B");
				byte[] array = new byte[]
				{
					b,
					Conversions.ToByte("0x69")
				};
				serialPort.Write(array, 0, array.Length);
				serialPort.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x001AB7AC File Offset: 0x001A99AC
		private void Button19_Click_1(object sender, EventArgs e)
		{
			try
			{
				string cardDetails = MyProject.Forms.Form1.myrevmax.GetCardDetails();
				MessageBox.Show("Card Details: " + cardDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting card details: " + ex.Message);
			}
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x001AB81C File Offset: 0x001A9A1C
		private void Button20_Click_1(object sender, EventArgs e)
		{
			try
			{
				string license = MyProject.Forms.Form1.myrevmax.GetLicense();
				MessageBox.Show("License Details: " + license);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting License details: " + ex.Message);
			}
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x001AB88C File Offset: 0x001A9A8C
		private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboSize.Text, "58mm", false) == 0;
				if (flag)
				{
					this.cboReceiptTemplate.Text = "NO VAT COLUMN";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Printers_MinimumSizeChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x001AB8F0 File Offset: 0x001A9AF0
		private void btnAdditionalSettings_Click(object sender, EventArgs e)
		{
			try
			{
				AdditionalSettings additionalSettings = new AdditionalSettings();
				additionalSettings.ShowDialog();
				additionalSettings.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing Additional Settings Form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x001AB94C File Offset: 0x001A9B4C
		private void Button21_Click_1(object sender, EventArgs e)
		{
			try
			{
				string text = MyProject.Forms.Form1.myrevmax.SetLicense(this.txtLicense.Text);
				MessageBox.Show("License Response: " + text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting card details: " + ex.Message);
			}
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00002A30 File Offset: 0x00000C30
		private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x001AB9C4 File Offset: 0x001A9BC4
		private void Button23_Click(object sender, EventArgs e)
		{
			try
			{
				KDUs kdus = new KDUs();
				kdus.ShowDialog();
				kdus.Dispose();
				this.loadKDUs();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying KDUs. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNextDebitNoteNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNextCreditNoteNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x001ABA28 File Offset: 0x001A9C28
		private void Button25_Click(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkLBFiscal.Checked;
				if (@checked)
				{
					bool flag = Operators.CompareString(this.cboLBPrinters.Text, "", false) == 0;
					if (flag)
					{
						MessageBox.Show("Please select the printer first.");
					}
					else
					{
						bool checked2 = this.RadLBA4.Checked;
						if (checked2)
						{
							bool flag2 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", "1", MyProject.Forms.Form1.Constring);
							bool flag3 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBPrinterName", this.cboLBPrinters.Text, MyProject.Forms.Form1.Constring);
							bool flag4 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBFolderPath", this.txtLBpath.Text, MyProject.Forms.Form1.Constring);
							bool flag5 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBWaitTime", Conversions.ToString(Conversion.Val(this.txtLBWait.Text) * 1000.0), MyProject.Forms.Form1.Constring);
							bool flag6 = Operators.CompareString(this.cboLBInvTemplate.Text, "Normal Invoice", false) == 0;
							if (flag6)
							{
								MyProject.Forms.Form1.inv_template_revmax = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_normal = 1;
								this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(1));
								MyProject.Forms.Form1.inv_template_incotex = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_lea = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_pharma = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_tongaat = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_FDMS = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_GetPro = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_Binum = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
								this.publicfunction.AddUpdateAppSettings("PrintInvoice", "1");
								MyProject.Forms.Form1.PrintInvoice = 1;
								MyProject.Forms.Form1.PrintReceipt = 0;
								MyProject.Forms.Form1.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
							}
							else
							{
								MyProject.Forms.Form1.inv_template_revmax = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_revmax", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_normal = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_normal", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_incotex = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_incotex", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_lea = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_lea", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_pharma = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_pharma", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_tongaat = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_tongaat", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_FDMS = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_FDMS", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_GetPro = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_GetPro", Conversions.ToString(0));
								MyProject.Forms.Form1.inv_template_Binum = 1;
								this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(1));
								this.publicfunction.AddUpdateAppSettings("PrintInvoice", "1");
								MyProject.Forms.Form1.PrintInvoice = 1;
								MyProject.Forms.Form1.PrintReceipt = 0;
								MyProject.Forms.Form1.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
							}
							bool flag7 = flag2 && flag3 && flag4;
							if (flag7)
							{
								MessageBox.Show("Leafbright A4 settings saved.");
							}
							else
							{
								MessageBox.Show("Some settings not saved. Contact your System Admin");
							}
						}
						else
						{
							bool checked3 = this.RadLB80.Checked;
							if (checked3)
							{
								MyProject.Forms.Form1.PrintInvoice = 0;
								MyProject.Forms.Form1.PrintReceipt = 1;
								bool flag8 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", "0", MyProject.Forms.Form1.Constring);
								bool flag9 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", "1", MyProject.Forms.Form1.Constring);
								bool flag10 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LBPrinterName", this.cboLBPrinters.Text, MyProject.Forms.Form1.Constring);
								this.publicfunction.AddUpdateAppSettings("ReceiptSize80", "1");
								MyProject.Forms.Form1.ReceiptSize80 = 1;
								this.publicfunction.AddUpdateAppSettings("defaultReceiptPrinter", this.cboLBPrinters.Text);
								MyProject.Forms.Form1.defaultReceiptPrinter = this.cboLBPrinters.Text;
								this.publicfunction.AddUpdateAppSettings("NumOfReceiptsPrint", Conversions.ToString(1));
								MyProject.Forms.Form1.NumOfReceiptsPrint = 1;
								MyProject.Forms.Form1.PrintFiscal = 0;
								this.publicfunction.AddUpdateAppSettings("PrintFiscal", Conversions.ToString(0));
								MyProject.Forms.Form1.FiscalEltrade = 0;
								this.publicfunction.AddUpdateAppSettings("FiscalEltrade", Conversions.ToString(0));
								MyProject.Forms.Form1.FiscalRevmax = 0;
								this.publicfunction.AddUpdateAppSettings("FiscalRevmax", Conversions.ToString(0));
								int num = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.cboFont.Text, "", false) == 0, 7, Conversion.Val(this.cboFont.Text)));
								MyProject.Forms.Form1.ReceiptFontSize = num;
								this.publicfunction.AddUpdateAppSettings("ReceiptFontSize", Conversions.ToString(num));
								this.publicfunction.AddUpdateAppSettings("defaultSecondaryPrinter", "");
								this.publicfunction.AddUpdateAppSettings("defaultSecondaryPrinterCaption", "");
								MyProject.Forms.Form1.defaultSecondaryPrinter = "";
								MyProject.Forms.Form1.defaultSecondaryPrinterCaption = "";
								this.publicfunction.AddUpdateAppSettings("InvoiceHeaderText", this.txtHeaderText.Text);
								MyProject.Forms.Form1.InvoiceHeaderText = this.txtHeaderText.Text;
								bool checked4 = this.chkPrintBarcodedInvNumber.Checked;
								if (checked4)
								{
									MyProject.Forms.Form1.PrintBarcodeInvNumber = 1;
									this.publicfunction.AddUpdateAppSettings("PrintBarcodeInvNumber", Conversions.ToString(1));
								}
								else
								{
									MyProject.Forms.Form1.PrintBarcodeInvNumber = 0;
									this.publicfunction.AddUpdateAppSettings("PrintBarcodeInvNumber", Conversions.ToString(0));
								}
								MyProject.Forms.Form1.useprintercategories = 0;
								this.publicfunction.AddUpdateAppSettings("useprintercategories", Conversions.ToString(0));
								bool checked5 = this.chkUseOldPrintingService.Checked;
								if (checked5)
								{
									this.publicfunction.AddUpdateAppSettings("useOldPrintingService", Conversions.ToString(1));
									MyProject.Forms.Form1.useOldPrintingService = 1;
								}
								else
								{
									this.publicfunction.AddUpdateAppSettings("useOldPrintingService", Conversions.ToString(0));
									MyProject.Forms.Form1.useOldPrintingService = 0;
								}
								MyProject.Forms.Form1.receipt_copy_name = this.txtrec_copy_name.Text;
								this.publicfunction.AddUpdateAppSettings("receipt_copy_name", this.txtrec_copy_name.Text);
								MyProject.Forms.Form1.receipt_template = this.cboReceiptTemplate.Text;
								this.publicfunction.AddUpdateAppSettings("receipt_template", this.cboReceiptTemplate.Text);
								MyProject.Forms.Form1.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
								MessageBox.Show("Leafbright 80mm settings saved.");
							}
							else
							{
								MyProject.Forms.Form1.inv_template_Binum = 0;
								this.publicfunction.AddUpdateAppSettings("inv_template_Binum", Conversions.ToString(0));
								this.publicfunction.AddUpdateAppSettings("PrintInvoice", "0");
								MyProject.Forms.Form1.PrintInvoice = 0;
								MyProject.Forms.Form1.PrintReceipt = 0;
								bool flag11 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", "0", MyProject.Forms.Form1.Constring);
								bool flag12 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", "0", MyProject.Forms.Form1.Constring);
								MyProject.Forms.Form1.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
								bool flag13 = flag11 && flag12;
								if (flag13)
								{
									MessageBox.Show("Leafbright Fiscal settings disabled.");
								}
							}
						}
					}
				}
				else
				{
					bool flag14 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", "0", MyProject.Forms.Form1.Constring);
					bool flag15 = this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", "0", MyProject.Forms.Form1.Constring);
					MyProject.Forms.Form1.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
					bool flag16 = flag14;
					if (flag16)
					{
						MessageBox.Show("Leafbright fiscal set to OFF");
					}
					else
					{
						MessageBox.Show("Leafbright fiscal attempt to turn off UNSUCCESSFUL. Please call the System Administrator");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving details. " + ex.Message);
			}
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TabPage6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x001AC6F8 File Offset: 0x001AA8F8
		private void Button24_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtLBpath.Text = this.FolderBrowserDialog1.SelectedPath;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error setting folder path. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x00012800 File Offset: 0x00010A00
		private void TextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x001AC76C File Offset: 0x001AA96C
		private void RadLB80_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.RadLB80.Checked;
				if (@checked)
				{
					this.Label35.Visible = false;
					this.cboLBInvTemplate.Visible = false;
					this.Button24.Visible = false;
					this.txtLBpath.Visible = false;
					this.Label34.Visible = false;
					this.txtLBWait.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x001AC7FC File Offset: 0x001AA9FC
		private void RadLBA4_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.RadLBA4.Checked;
				if (@checked)
				{
					this.Label35.Visible = true;
					this.cboLBInvTemplate.Visible = true;
					this.Button24.Visible = true;
					this.txtLBpath.Visible = true;
					this.Label34.Visible = true;
					this.txtLBWait.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x001AC88C File Offset: 0x001AAA8C
		private void chkLBFiscal_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkLBFiscal.Checked;
				if (@checked)
				{
					this.Panel3.Visible = true;
				}
				else
				{
					this.Panel3.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x001AC8EC File Offset: 0x001AAAEC
		private void Button26_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete the Receipt Logo?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.pf.DeleteLogoBMP("C:\\Quantum\\logo.bmp");
					MessageBox.Show("Logo deleted successfully.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting receipt logo. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtExtraSpaces_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0400150D RID: 5389
		private PublicFunctions publicfunction;

		// Token: 0x0400150E RID: 5390
		private string TextToPrint;

		// Token: 0x0400150F RID: 5391
		private string coname;

		// Token: 0x04001510 RID: 5392
		private string coadd;

		// Token: 0x04001511 RID: 5393
		private string cotel;

		// Token: 0x04001512 RID: 5394
		private string _cnn;

		// Token: 0x04001513 RID: 5395
		private int invnum;

		// Token: 0x04001514 RID: 5396
		private DataTable dtItem;

		// Token: 0x04001515 RID: 5397
		private int currentNextCreditNoteNum;

		// Token: 0x04001516 RID: 5398
		private int currentNextDebitNoteNum;

		// Token: 0x04001517 RID: 5399
		private PublicFunctions pf;
	}
}
