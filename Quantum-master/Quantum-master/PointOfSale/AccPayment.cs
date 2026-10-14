using System;
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
	// Token: 0x02000005 RID: 5
	[DesignerGenerated]
	public partial class AccPayment : Form
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002A34 File Offset: 0x00000C34
		public AccPayment()
		{
			base.Load += this.AccPayment_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.TextToPrint = "";
			this.dat_accs = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000586C File Offset: 0x00003A6C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00005878 File Offset: 0x00003A78
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000058BB File Offset: 0x00003ABB
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000058C5 File Offset: 0x00003AC5
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000058CE File Offset: 0x00003ACE
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000058D8 File Offset: 0x00003AD8
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000058E1 File Offset: 0x00003AE1
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000058EB File Offset: 0x00003AEB
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000058F4 File Offset: 0x00003AF4
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00005900 File Offset: 0x00003B00
		internal virtual ComboBox cboBranch
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranch_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranch = value;
				comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00005943 File Offset: 0x00003B43
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000594D File Offset: 0x00003B4D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00005956 File Offset: 0x00003B56
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00005960 File Offset: 0x00003B60
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
				EventHandler eventHandler = new EventHandler(this.cboCustomers_SelectedIndexChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboCustomers_KeyUp);
				EventHandler eventHandler2 = new EventHandler(this.cboCustomers_Leave);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
					comboBox.KeyUp -= keyEventHandler;
					comboBox.Leave -= eventHandler2;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
					comboBox.KeyUp += keyEventHandler;
					comboBox.Leave += eventHandler2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000059D9 File Offset: 0x00003BD9
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000059E3 File Offset: 0x00003BE3
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000059EC File Offset: 0x00003BEC
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000059F6 File Offset: 0x00003BF6
		internal virtual Label lblBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000059FF File Offset: 0x00003BFF
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00005A09 File Offset: 0x00003C09
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005A12 File Offset: 0x00003C12
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005A1C File Offset: 0x00003C1C
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00005A5F File Offset: 0x00003C5F
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005A6C File Offset: 0x00003C6C
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
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00005AAF File Offset: 0x00003CAF
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005AB9 File Offset: 0x00003CB9
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005AC2 File Offset: 0x00003CC2
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005ACC File Offset: 0x00003CCC
		internal virtual Label lblEffectiveAmtPaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00005AD5 File Offset: 0x00003CD5
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005ADF File Offset: 0x00003CDF
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005AE8 File Offset: 0x00003CE8
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00005AF4 File Offset: 0x00003CF4
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
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmtPaid_KeyPress);
				TextBox textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAmtPaid = value;
				textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00005B52 File Offset: 0x00003D52
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00005B5C File Offset: 0x00003D5C
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005B65 File Offset: 0x00003D65
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00005B6F File Offset: 0x00003D6F
		internal virtual Label lblRate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005B78 File Offset: 0x00003D78
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00005B82 File Offset: 0x00003D82
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005B8B File Offset: 0x00003D8B
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00005B98 File Offset: 0x00003D98
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005BDB File Offset: 0x00003DDB
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00005BE5 File Offset: 0x00003DE5
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00005BEE File Offset: 0x00003DEE
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00005BF8 File Offset: 0x00003DF8
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00005C01 File Offset: 0x00003E01
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00005C0B File Offset: 0x00003E0B
		internal virtual Label lblBal2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00005C14 File Offset: 0x00003E14
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00005C1E File Offset: 0x00003E1E
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00005C27 File Offset: 0x00003E27
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00005C34 File Offset: 0x00003E34
		internal virtual ComboBox ComboBox1
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.ComboBox1_KeyUp);
				EventHandler eventHandler2 = new EventHandler(this.ComboBox1_Leave);
				ComboBox comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
					comboBox.KeyUp -= keyEventHandler;
					comboBox.Leave -= eventHandler2;
				}
				this._ComboBox1 = value;
				comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
					comboBox.KeyUp += keyEventHandler;
					comboBox.Leave += eventHandler2;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00005CAD File Offset: 0x00003EAD
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00005CB7 File Offset: 0x00003EB7
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00005CC0 File Offset: 0x00003EC0
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00005CCC File Offset: 0x00003ECC
		internal virtual ComboBox ComboBox2
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox2_SelectedIndexChanged);
				ComboBox comboBox = this._ComboBox2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox2 = value;
				comboBox = this._ComboBox2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00005D0F File Offset: 0x00003F0F
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00005D19 File Offset: 0x00003F19
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00005D22 File Offset: 0x00003F22
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00005D2C File Offset: 0x00003F2C
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005D6F File Offset: 0x00003F6F
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00005D79 File Offset: 0x00003F79
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00005D82 File Offset: 0x00003F82
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00005D8C File Offset: 0x00003F8C
		internal virtual DataGridView DataGridView2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005D95 File Offset: 0x00003F95
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00005D9F File Offset: 0x00003F9F
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005DA8 File Offset: 0x00003FA8
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00005DB4 File Offset: 0x00003FB4
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00005DF7 File Offset: 0x00003FF7
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00005E04 File Offset: 0x00004004
		internal virtual ComboBox cboBranch2
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranch2_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranch2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranch2 = value;
				comboBox = this._cboBranch2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00005E47 File Offset: 0x00004047
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00005E51 File Offset: 0x00004051
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00005E5A File Offset: 0x0000405A
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00005E64 File Offset: 0x00004064
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005E6D File Offset: 0x0000406D
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00005E77 File Offset: 0x00004077
		internal virtual TextBox txtComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005E80 File Offset: 0x00004080
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00005E8C File Offset: 0x0000408C
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005ECF File Offset: 0x000040CF
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00005ED9 File Offset: 0x000040D9
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00005EE2 File Offset: 0x000040E2
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00005EEC File Offset: 0x000040EC
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005EF5 File Offset: 0x000040F5
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00005EFF File Offset: 0x000040FF
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005F08 File Offset: 0x00004108
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00005F14 File Offset: 0x00004114
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005F57 File Offset: 0x00004157
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00005F64 File Offset: 0x00004164
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005FA7 File Offset: 0x000041A7
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00005FB1 File Offset: 0x000041B1
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005FBA File Offset: 0x000041BA
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00005FC4 File Offset: 0x000041C4
		internal virtual ComboBox cboREfund
		{
			[CompilerGenerated]
			get
			{
				return this._cboREfund;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboREfund_SelectedIndexChanged);
				ComboBox comboBox = this._cboREfund;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboREfund = value;
				comboBox = this._cboREfund;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00006007 File Offset: 0x00004207
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00006011 File Offset: 0x00004211
		internal virtual ComboBox cboTipBeneficiary
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000601A File Offset: 0x0000421A
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00006024 File Offset: 0x00004224
		internal virtual CheckBox chkTip
		{
			[CompilerGenerated]
			get
			{
				return this._chkTip;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkTip_CheckedChanged);
				CheckBox checkBox = this._chkTip;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkTip = value;
				checkBox = this._chkTip;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00006067 File Offset: 0x00004267
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00006071 File Offset: 0x00004271
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000607A File Offset: 0x0000427A
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00006084 File Offset: 0x00004284
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000608D File Offset: 0x0000428D
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00006098 File Offset: 0x00004298
		internal virtual TextBox txtAmtPaidTip
		{
			[CompilerGenerated]
			get
			{
				return this._txtAmtPaidTip;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtAmtPaidTip_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmtPaidTip_KeyPress);
				TextBox textBox = this._txtAmtPaidTip;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAmtPaidTip = value;
				textBox = this._txtAmtPaidTip;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000060F6 File Offset: 0x000042F6
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00006100 File Offset: 0x00004300
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006109 File Offset: 0x00004309
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00006113 File Offset: 0x00004313
		internal virtual Label lblTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000611C File Offset: 0x0000431C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00006128 File Offset: 0x00004328
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000616B File Offset: 0x0000436B
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00006178 File Offset: 0x00004378
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000061BB File Offset: 0x000043BB
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000061C5 File Offset: 0x000043C5
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000061CE File Offset: 0x000043CE
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000061D8 File Offset: 0x000043D8
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000621B File Offset: 0x0000441B
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00006225 File Offset: 0x00004425
		internal virtual RadioButton radBoth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000622E File Offset: 0x0000442E
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00006238 File Offset: 0x00004438
		internal virtual RadioButton radCashSales
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006241 File Offset: 0x00004441
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000624B File Offset: 0x0000444B
		internal virtual RadioButton radAccOnly
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00006254 File Offset: 0x00004454
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00006260 File Offset: 0x00004460
		internal virtual ComboBox cboCustomerCategories
		{
			[CompilerGenerated]
			get
			{
				return this._cboCustomerCategories;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCustomerCategories_SelectedIndexChanged);
				ComboBox comboBox = this._cboCustomerCategories;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCustomerCategories = value;
				comboBox = this._cboCustomerCategories;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000062A3 File Offset: 0x000044A3
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000062B0 File Offset: 0x000044B0
		internal virtual CheckBox chkViewAllCusCategories
		{
			[CompilerGenerated]
			get
			{
				return this._chkViewAllCusCategories;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._chkViewAllCusCategories;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkViewAllCusCategories = value;
				checkBox = this._chkViewAllCusCategories;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000062F3 File Offset: 0x000044F3
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000062FD File Offset: 0x000044FD
		internal virtual CheckBox chkShowActiveCustomersOnly
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00006306 File Offset: 0x00004506
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00006310 File Offset: 0x00004510
		internal virtual CheckBox chkShowActiveCustomersOnly2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00006319 File Offset: 0x00004519
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00006323 File Offset: 0x00004523
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000632C File Offset: 0x0000452C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00006336 File Offset: 0x00004536
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000633F File Offset: 0x0000453F
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00006349 File Offset: 0x00004549
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00006352 File Offset: 0x00004552
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000635C File Offset: 0x0000455C
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006365 File Offset: 0x00004565
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000636F File Offset: 0x0000456F
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00006378 File Offset: 0x00004578
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00006382 File Offset: 0x00004582
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000638C File Offset: 0x0000458C
		private void AccPayment_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadPaymentMethods();
				this.LoadBranches2();
				this.LoadBranches();
				this.LoadBranches3();
				bool flag = MyProject.Forms.Form1.DateChange == 1;
				if (flag)
				{
					this.DateTimePicker1.Enabled = true;
				}
				else
				{
					this.DateTimePicker1.Enabled = false;
				}
				bool flag2 = MyProject.Forms.Form1.isRestaurant == 1;
				if (flag2)
				{
				}
				bool flag3 = MyProject.Forms.Form1.isRestaurant == 1;
				if (flag3)
				{
					this.cboTipBeneficiary.DataSource = RuntimeHelpers.GetObjectValue(this.pf.GetSystemUsers(this._cnn, MyProject.Forms.Form1.coid));
					this.cboTipBeneficiary.ValueMember = "Username";
					this.cboTipBeneficiary.DisplayMember = "Username";
					this.chkTip.Visible = true;
				}
				this.LoadCustomerCategories();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000064C4 File Offset: 0x000046C4
		private void LoadCustomers(string branchname)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branchname);
			sqlCommand.Parameters.AddWithValue("showactiveonly", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkShowActiveCustomersOnly.Checked, 1, 0)));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboCustomers.DataSource = dataTable;
			this.cboCustomers.DisplayMember = "CustomerName";
			this.cboCustomers.ValueMember = "EntryNo";
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000065A8 File Offset: 0x000047A8
		private void LoadCustomers2(string branchname)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branchname);
			sqlCommand.Parameters.AddWithValue("showactiveonly", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkShowActiveCustomersOnly2.Checked, 1, 0)));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.ComboBox1.DataSource = dataTable;
			this.ComboBox1.DisplayMember = "CustomerName";
			this.ComboBox1.ValueMember = "Entryno";
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000668C File Offset: 0x0000488C
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch.DataSource = dataTable;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000672C File Offset: 0x0000492C
		private void LoadBranches2()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch2.DataSource = dataTable;
			this.cboBranch2.ValueMember = "branch";
			this.cboBranch2.DisplayMember = "branch";
			this.cboBranch2.SelectedIndex = -1;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000067D8 File Offset: 0x000049D8
		private void LoadBranches3()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.ComboBox2.DataSource = dataTable;
			this.ComboBox2.ValueMember = "branch";
			this.ComboBox2.DisplayMember = "branch";
			this.ComboBox2.SelectedIndex = -1;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006884 File Offset: 0x00004A84
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomers(this.cboBranch.Text);
				this.ComboBox2.SelectedIndex = this.ComboBox2.FindStringExact(this.cboBranch.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000068EC File Offset: 0x00004AEC
		private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblBal.Text = this.pf.GetCustomerBillTotal(Conversions.ToInteger(this.cboCustomers.SelectedValue), MyProject.Forms.Form1.coid, this.cboBranch.Text.ToString(), this._cnn).ToString();
				DataTable dataTable = new DataTable();
				this.DataGridView1.DataSource = dataTable;
				DateTime customerFirstDate = this.pf.GetCustomerFirstDate(Conversions.ToInteger(this.cboCustomers.SelectedValue), MyProject.Forms.Form1.coid, this.cboBranch.Text, this._cnn);
				this.DTStartDate.Value = customerFirstDate;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000069D0 File Offset: 0x00004BD0
		private DataTable GetAccTrans(int customerentryno, int coid, string branch, int salestype, int startdate, int enddate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCustomerTransactions";
			sqlCommand.Parameters.AddWithValue("customerentryno", customerentryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("saletype", salestype);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006AAC File Offset: 0x00004CAC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadTrans();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying transaction data. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006AFC File Offset: 0x00004CFC
		private void LoadTrans()
		{
			this.DataGridView1.Columns.Clear();
			int num = 0;
			bool @checked = this.radBoth.Checked;
			if (@checked)
			{
				num = 3;
			}
			else
			{
				bool checked2 = this.radAccOnly.Checked;
				if (checked2)
				{
					num = 1;
				}
				else
				{
					bool checked3 = this.radCashSales.Checked;
					if (checked3)
					{
						num = 2;
					}
				}
			}
			this.DataGridView1.DataSource = checked(this.GetAccTrans(Conversions.ToInteger(this.cboCustomers.SelectedValue), MyProject.Forms.Form1.coid, this.cboBranch.Text, num, (int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd")))));
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.Name = "View";
			dataGridViewButtonColumn.Text = "View Details";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.DataGridView1.Columns.Add(dataGridViewButtonColumn);
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn2.Name = "Cancel";
			dataGridViewButtonColumn2.Text = "Cancel";
			dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
			this.DataGridView1.Columns.Add(dataGridViewButtonColumn2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006C60 File Offset: 0x00004E60
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.calcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006C98 File Offset: 0x00004E98
		private void Button2_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			int num = 0;
			try
			{
				bool flag = Operators.CompareString(this.cboREfund.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please select PAYMENT OR REFUND.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cboREfund.Text, "PAYMENT RECEIVED", false) == 0;
					DialogResult dialogResult;
					if (flag2)
					{
						dialogResult = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want to accept the effective payment of: " + this.lblEffectiveAmtPaid.Text + " for customer: ", this.ComboBox1.SelectedValue), "?"), MsgBoxStyle.YesNo, null);
					}
					else
					{
						bool flag3 = Operators.CompareString(this.cboREfund.Text, "REFUND GIVEN", false) == 0;
						if (flag3)
						{
							dialogResult = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want to REFUND the account the effective amount of:  " + this.lblEffectiveAmtPaid.Text + " for customer: ", this.ComboBox1.SelectedValue), "?"), MsgBoxStyle.YesNo, null);
						}
						else
						{
							bool flag4 = Operators.CompareString(this.cboREfund.Text, "OTHER", false) == 0;
							if (flag4)
							{
								dialogResult = (DialogResult)Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want to process OTHER CHARGE for the account. Effective amount of:  " + this.lblEffectiveAmtPaid.Text + " for customer: ", this.ComboBox1.SelectedValue), "?"), MsgBoxStyle.YesNo, null);
							}
						}
					}
					bool flag5 = dialogResult == DialogResult.Yes;
					if (flag5)
					{
						sqlConnection.Open();
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunAcceptAccPayment");
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "BillingInsertAccPayment";
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(this.ComboBox2.SelectedValue));
						sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DateTimePicker1.Value.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("shiftdate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
						sqlCommand.Parameters.AddWithValue("amount", decimal.Subtract(Convert.ToDecimal(this.lblEffectiveAmtPaid.Text), decimal.Divide(Convert.ToDecimal(this.txtAmtPaidTip.Text), Convert.ToDecimal(this.lblRate.Text))));
						sqlCommand.Parameters.AddWithValue("teller", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPaymentMethods.SelectedValue));
						sqlCommand.Parameters.AddWithValue("paymentmethoddesc", this.cboPaymentMethods.Text);
						sqlCommand.Parameters.AddWithValue("rate", Convert.ToDecimal(this.lblRate.Text));
						sqlCommand.Parameters.AddWithValue("ref", this.GetPayReceiptNum());
						sqlCommand.Parameters.AddWithValue("customername", RuntimeHelpers.GetObjectValue(this.ComboBox1.SelectedValue));
						sqlCommand.Parameters.AddWithValue("Comment", this.txtComment.Text);
						sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
						int num2 = 0;
						bool flag6 = Operators.CompareString(this.cboREfund.Text, "REFUND GIVEN", false) == 0;
						if (flag6)
						{
							num2 = 1;
							sqlCommand.Parameters.AddWithValue("transactiontype", "REFUND");
						}
						else
						{
							bool flag7 = Operators.CompareString(this.cboREfund.Text, "PAYMENT RECEIVED", false) == 0;
							if (flag7)
							{
								sqlCommand.Parameters.AddWithValue("transactiontype", "PAYMENT");
							}
							else
							{
								bool flag8 = Operators.CompareString(this.cboREfund.Text, "OTHER", false) == 0;
								if (flag8)
								{
									sqlCommand.Parameters.AddWithValue("transactiontype", "OTHER");
								}
							}
						}
						sqlCommand.Parameters.AddWithValue("isrefund", num2);
						sqlCommand.Parameters.AddWithValue("entryno", num);
						num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
						bool flag9 = this.chkTip.Checked & (Conversion.Val(this.txtAmtPaidTip.Text) > 0.0);
						if (flag9)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "TipInsert";
							sqlCommand.Parameters.AddWithValue("trandate", DateTime.Now);
							sqlCommand.Parameters.AddWithValue("customername", this.cboCustomers.Text);
							sqlCommand.Parameters.AddWithValue("tipfor", this.cboTipBeneficiary.Text);
							sqlCommand.Parameters.AddWithValue("tipamount", decimal.Divide(Convert.ToDecimal(this.txtAmtPaidTip.Text), Convert.ToDecimal(this.lblRate.Text)));
							sqlCommand.Parameters.AddWithValue("totalamount", Convert.ToDecimal(this.lblEffectiveAmtPaid.Text));
							sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPaymentMethods.SelectedValue));
							sqlCommand.Parameters.AddWithValue("rate", Convert.ToDecimal(this.lblRate.Text));
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
							sqlCommand.ExecuteNonQuery();
						}
						sqlTransaction.Commit();
						sqlConnection.Close();
						this.lblBal2.Text = this.pf.GetCustomerBillTotal(Conversions.ToInteger(this.ComboBox1.SelectedValue), MyProject.Forms.Form1.coid, this.ComboBox2.SelectedValue.ToString(), this._cnn).ToString();
						MessageBox.Show("Amount Accepted Successfully.");
						bool flag10 = Operators.CompareString(this.cboREfund.Text, "PAYMENT RECEIVED", false) == 0;
						if (flag10)
						{
							DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Do you want to print a receipt?", MsgBoxStyle.YesNo, null);
							bool flag11 = dialogResult2 == DialogResult.Yes;
							if (flag11)
							{
								this.PrintReceipt(MyProject.Forms.Form1.username, num, this.ComboBox1.Text, "");
							}
						}
						this.txtAmtPaid.Text = "0";
						this.txtComment.Text = "";
						this.cboREfund.SelectedIndex = -1;
						this.cboPaymentMethods.SelectedIndex = -1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error accepting payment. Detail: " + ex.Message);
				try
				{
					SqlTransaction sqlTransaction;
					sqlTransaction.Rollback();
					sqlConnection.Close();
				}
				catch (Exception ex2)
				{
					sqlConnection.Close();
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000074C4 File Offset: 0x000056C4
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
			this.cboPaymentMethods.SelectedIndex = -1;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00007570 File Offset: 0x00005770
		private int GetPayReceiptNum()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingGetNextPaymentReceiptNumber";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["num"]))));
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000075FC File Offset: 0x000057FC
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
				this.calcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000076F0 File Offset: 0x000058F0
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomerBals(1);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying account balances. Detail " + ex.Message);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00007740 File Offset: 0x00005940
		private void LoadCustomerBals(int allbals)
		{
			this.dat_accs.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCalcAccBalanceAll";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(this.cboBranch2.SelectedValue));
			sqlCommand.Parameters.AddWithValue("thedate", Conversion.Val(this.DTDate.Value.ToString("yyyyMMdd")));
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat_accs);
			DataView defaultView = this.dat_accs.DefaultView;
			bool flag = allbals == 0;
			if (flag)
			{
				bool flag2 = !this.chkViewAllCusCategories.Checked;
				if (flag2)
				{
					defaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject("bal<>0 and CustomerGroupID=", this.cboCustomerCategories.SelectedValue));
					this.DataGridView2.DataSource = defaultView;
				}
				else
				{
					defaultView.RowFilter = "bal<>0";
					this.DataGridView2.DataSource = defaultView;
				}
			}
			else
			{
				bool flag3 = !this.chkViewAllCusCategories.Checked;
				if (flag3)
				{
					defaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject("CustomerGroupID=", this.cboCustomerCategories.SelectedValue));
					this.DataGridView2.DataSource = defaultView;
				}
				else
				{
					defaultView.RowFilter = "1=1";
					this.DataGridView2.DataSource = defaultView;
				}
			}
			this.DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView2.Columns["InvoiceDetails1"].Visible = false;
			this.DataGridView2.Columns["InvoiceDetails2"].Visible = false;
			this.DataGridView2.Columns["DOB"].Visible = false;
			this.DataGridView2.Columns["Sex"].Visible = false;
			this.DataGridView2.Columns["DateCreated"].Visible = false;
			this.DataGridView2.Columns["CreatedBy"].Visible = false;
			this.DataGridView2.Columns["coid"].Visible = false;
			this.DataGridView2.Columns["branch"].Visible = false;
			this.DataGridView2.Columns["entryno"].Visible = false;
			this.DataGridView2.Columns["uploaded"].Visible = false;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007A10 File Offset: 0x00005C10
		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomers2(Conversions.ToString(this.ComboBox2.SelectedValue));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007A58 File Offset: 0x00005C58
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblBal2.Text = this.pf.GetCustomerBillTotal(Conversions.ToInteger(this.ComboBox1.SelectedValue), MyProject.Forms.Form1.coid, this.ComboBox2.SelectedValue.ToString(), this._cnn).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007AE0 File Offset: 0x00005CE0
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				frmAccStatement frmAccStatement = new frmAccStatement();
				frmAccStatement.customerentryno = Conversions.ToInteger(this.cboCustomers.SelectedValue);
				frmAccStatement.startdate = Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"));
				frmAccStatement.enddate = Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"));
				bool @checked = this.radCashSales.Checked;
				if (@checked)
				{
					frmAccStatement.saletype = 2;
				}
				else
				{
					bool checked2 = this.radBoth.Checked;
					if (checked2)
					{
						frmAccStatement.saletype = 3;
					}
					else
					{
						bool checked3 = this.radAccOnly.Checked;
						if (checked3)
						{
							frmAccStatement.saletype = 1;
						}
					}
				}
				frmAccStatement.ShowDialog(this);
				frmAccStatement.Dispose();
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.WaitCursor;
				MessageBox.Show("Error printing statement. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00007C08 File Offset: 0x00005E08
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.TabControl1.SelectedIndex == 0;
				if (flag)
				{
					bool flag2 = (Operators.CompareString(this.cboBranch.Text, "", false) != 0) & (Operators.CompareString(this.cboCustomers.Text, "", false) != 0);
					if (flag2)
					{
						this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(this.cboBranch.Text);
						this.cboCustomers.SelectedIndex = this.cboCustomers.FindStringExact(this.cboCustomers.Text);
						this.lblBal.Text = this.pf.GetCustomerBillTotal(Conversions.ToInteger(this.cboCustomers.SelectedValue), MyProject.Forms.Form1.coid, this.cboBranch.Text.ToString(), this._cnn).ToString();
						this.LoadTrans();
					}
				}
				else
				{
					bool flag3 = this.TabControl1.SelectedIndex == 1;
					if (flag3)
					{
						bool flag4 = (Operators.CompareString(this.cboBranch.Text, "", false) != 0) & (Operators.CompareString(this.cboCustomers.Text, "", false) != 0);
						if (flag4)
						{
							this.ComboBox2.SelectedIndex = this.ComboBox2.FindStringExact(this.cboBranch.Text);
							this.ComboBox1.SelectedIndex = this.ComboBox1.FindStringExact(this.cboCustomers.Text);
							bool flag5 = this.ComboBox1.SelectedIndex == 0;
							if (flag5)
							{
								this.lblBal2.Text = this.pf.GetCustomerBillTotal(Conversions.ToInteger(this.ComboBox1.SelectedValue), MyProject.Forms.Form1.coid, this.ComboBox2.Text.ToString(), this._cnn).ToString();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Index changed error. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00007E58 File Offset: 0x00006058
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

		// Token: 0x060000CB RID: 203 RVA: 0x00007F60 File Offset: 0x00006160
		public void AutoCompleteCombo_Leave(ComboBox cbo)
		{
			int num = cbo.FindStringExact(cbo.Text);
			cbo.SelectedIndex = num;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007F84 File Offset: 0x00006184
		private void cboCustomers_Leave(object sender, EventArgs e)
		{
			this.AutoCompleteCombo_Leave(this.cboCustomers);
			DataRowView dataRowView = (DataRowView)this.cboCustomers.SelectedItem;
			bool flag = dataRowView == null;
			if (flag)
			{
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00007FBC File Offset: 0x000061BC
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.cboCustomers.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				string searchCustomer = MyProject.Forms.Form1.SearchCustomer;
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindString(MyProject.Forms.Form1.SearchCustomer);
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00008074 File Offset: 0x00006274
		private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0));
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000080DC File Offset: 0x000062DC
		private void ComboBox1_KeyUp(object sender, KeyEventArgs e)
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
							string text = this.ComboBox1.Text;
							int num = this.ComboBox1.FindString(text);
							bool flag = num >= 0;
							if (flag)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(this.ComboBox1.Items[num]);
								string itemText = this.ComboBox1.GetItemText(RuntimeHelpers.GetObjectValue(objectValue));
								string text2 = itemText.Substring(text.Length);
								this.ComboBox1.Text = text + text2;
								this.ComboBox1.SelectionStart = text.Length;
								this.ComboBox1.SelectionLength = text2.Length;
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

		// Token: 0x060000D0 RID: 208 RVA: 0x000081E4 File Offset: 0x000063E4
		private void ComboBox1_Leave(object sender, EventArgs e)
		{
			this.AutoCompleteCombo_Leave(this.ComboBox1);
			DataRowView dataRowView = (DataRowView)this.ComboBox1.SelectedItem;
			bool flag = dataRowView == null;
			if (flag)
			{
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000821C File Offset: 0x0000641C
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.ComboBox1.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				string searchCustomer = MyProject.Forms.Form1.SearchCustomer;
				this.ComboBox1.SelectedIndex = this.ComboBox1.FindString(MyProject.Forms.Form1.SearchCustomer);
				this.cboPaymentMethods.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000082D4 File Offset: 0x000064D4
		private void cboREfund_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboREfund.Text, "PAYMENT RECEIVED", false) == 0;
				if (flag)
				{
					this.Button2.Text = "ACCEPT PAYMENT";
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cboREfund.Text, "OTHER", false) == 0;
					if (flag2)
					{
						this.Button2.Text = "PROCESS OTHER CHARGE";
					}
					else
					{
						bool flag3 = Operators.CompareString(this.cboREfund.Text, "REFUND GIVEN", false) == 0;
						if (flag3)
						{
							this.Button2.Text = "PROCESS REFUND";
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00008398 File Offset: 0x00006598
		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(this.DataGridView1.Rows[e.RowIndex].Cells["Transaction_Type"].Value.ToString(), "SALE", false) == 0;
						if (flag3)
						{
							new ViewInvoiceDetails
							{
								inv_header = "Customer: " + this.DataGridView1.Rows[e.RowIndex].Cells["Customer_Name"].Value.ToString() + ", Date: " + this.DataGridView1.Rows[e.RowIndex].Cells["TranDate"].Value.ToString(),
								inv_details = this.GetInvDetails(Conversions.ToInteger(this.DataGridView1.Rows[e.RowIndex].Cells["Sales_Inv_Number"].Value), MyProject.Forms.Form1.coid, this.cboBranch.Text)
							}.Show();
						}
						else
						{
							MessageBox.Show("Can only view Sale details.");
						}
					}
					else
					{
						bool flag4 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Cancel", false) == 0;
						if (flag4)
						{
							bool flag5 = Operators.CompareString(this.DataGridView1.Rows[e.RowIndex].Cells["Transaction_Type"].Value.ToString(), "SALE", false) == 0;
							if (flag5)
							{
								MessageBox.Show("Please go to View/Cancel Sales menu to cancel this sale and use the following receipt number: " + this.DataGridView1.Rows[e.RowIndex].Cells["Sales_Inv_Number"].Value.ToString());
							}
							else
							{
								MessageBox.Show("Can only cancel a sale. To reverse a payment, issue a refund.");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00008644 File Offset: 0x00006844
		private DataTable GetInvDetails(int inv, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000086D8 File Offset: 0x000068D8
		private void chkTip_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboTipBeneficiary.Visible = true;
				this.txtAmtPaidTip.Visible = true;
				this.Label14.Visible = true;
				this.Label16.Visible = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00008740 File Offset: 0x00006940
		private void txtAmtPaidTip_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.calcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00008778 File Offset: 0x00006978
		private void calcTotal()
		{
			this.lblEffectiveAmtPaid.Text = decimal.Add(decimal.Divide(Convert.ToDecimal(this.txtAmtPaid.Text), Convert.ToDecimal(this.lblRate.Text)), decimal.Divide(Convert.ToDecimal(this.txtAmtPaidTip.Text), Convert.ToDecimal(this.lblRate.Text))).ToString();
			this.lblTotal.Text = decimal.Add(Convert.ToDecimal(this.txtAmtPaid.Text), Convert.ToDecimal(this.txtAmtPaidTip.Text)).ToString();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00008824 File Offset: 0x00006A24
		private void txtAmtPaidTip_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00008870 File Offset: 0x00006A70
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				DataView defaultView = this.dat_accs.DefaultView;
				bool flag = !this.chkViewAllCusCategories.Checked;
				if (flag)
				{
					defaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject("bal<>0 and CustomerGroupID=", this.cboCustomerCategories.SelectedValue));
					this.DataGridView2.DataSource = defaultView;
				}
				else
				{
					defaultView.RowFilter = "bal<>0";
					this.DataGridView2.DataSource = defaultView;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying account balances. Detail " + ex.Message);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00008924 File Offset: 0x00006B24
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.DataGridView2.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.DataGridView2, this.SaveFileDialog1.FileName);
					}
					MessageBox.Show("Data exported to excel.");
				}
				else
				{
					MessageBox.Show("There are no items to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000089DC File Offset: 0x00006BDC
		public void PrintHeader(string tellername)
		{
			bool flag = MyProject.Forms.Form1.ReceiptSize80 == 1;
			checked
			{
				int num;
				if (flag)
				{
					num = MyProject.Forms.Form1.ReceiptSpacingSize;
				}
				else
				{
					num = (int)Math.Round(unchecked(0.6666666666666666 * (double)MyProject.Forms.Form1.ReceiptSpacingSize));
				}
				this.TextToPrint = "";
				string text = this.coname;
				int num2 = text.Length;
				bool flag2 = this.coname.Length > 80;
				if (flag2)
				{
					this.coname = this.coname;
				}
				else
				{
					this.coname = this.pf.StringPadCentre(this.coname, num);
				}
				text = this.coname;
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = this.coadd;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = this.coadd2;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag3 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag3)
				{
					text = this.coemail;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag4 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag4)
				{
					text = this.cotel;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag5 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag5)
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
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				text = "Teller: " + tellername;
				num2 = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = "Customer: " + this.ComboBox1.Text;
				num2 = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00008CCC File Offset: 0x00006ECC
		public void ItemsToBePrinted(int pay_entryno, DataRow paymentDataRow, DataRow balancesDataRow, string customername, string customeraddress)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Entry Number: " + pay_entryno.ToString();
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = Conversions.ToString(Operators.ConcatenateObject(ptr, Operators.ConcatenateObject(Operators.ConcatenateObject("Payment Method: ", paymentDataRow["PaymentMethodDesc"]), Environment.NewLine)));
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			decimal num = 0m;
			string text = "Amount Received: " + paymentDataRow["Amount"].ToString() + Environment.NewLine;
			text = string.Concat(new string[]
			{
				text,
				"Comment: ",
				paymentDataRow["Comment"].ToString(),
				Environment.NewLine,
				Environment.NewLine
			});
			checked
			{
				int num2 = 50 - (14 + MyProject.Forms.Form1.basecurrency.Length + balancesDataRow["amtcharged"].ToString().Length);
				int num3 = 50 - (12 + MyProject.Forms.Form1.basecurrency.Length + balancesDataRow["amtpaid"].ToString().Length);
				string text2 = this.pf.CreateSpacer(num2);
				string text3 = this.pf.CreateSpacer(num3);
				text = string.Concat(new string[]
				{
					text,
					"Account balance: ",
					MyProject.Forms.Form1.basecurrency,
					balancesDataRow["bal"].ToString(),
					Environment.NewLine
				});
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00008EE8 File Offset: 0x000070E8
		private DataRow AccountBalanceDataRow(int customerentryno, int coid, string branch)
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
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows[0];
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00008F88 File Offset: 0x00007188
		private DataRow PaymentDataRow(int entrynum, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select [EntryNo],[CustomerName],[TransactionType],[InvoiceNumber],Convert (numeric(18,2),[Amount]) as Amount,[ShiftDate],[TranDate],[TranTime],[Teller],[Coid],[Branch],[Terms],[DueDate],[PaymentMethodID],[PaymentMethodDesc],[ref],[Comment],[rate],[Uploaded],[InvDiscount],[IsRefund],[RefundSource],[doneby],[machinename] from billinglog where entryno = ",
				entrynum.ToString(),
				" and coid= ",
				coid.ToString(),
				" and branch='",
				branch,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows[0];
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00009028 File Offset: 0x00007228
		private void PrintReceipt(string username, int entry_num, string customername, string customeradd)
		{
			try
			{
				this.GetBranchDetails();
				this.PrintHeader(username);
				this.ItemsToBePrinted(entry_num, this.PaymentDataRow(entry_num, MyProject.Forms.Form1.coid, this.ComboBox2.Text), this.AccountBalanceDataRow(Conversions.ToInteger(this.ComboBox1.SelectedValue), MyProject.Forms.Form1.coid, this.ComboBox2.Text), customername, customeradd);
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
			catch (Exception ex)
			{
				MessageBox.Show("Printing error. Detail: " + ex.Message);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000916C File Offset: 0x0000736C
		private void GetBranchDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
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
					this.coadd2 = dataRow["Address2"].ToString();
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

		// Token: 0x060000E1 RID: 225 RVA: 0x000092FC File Offset: 0x000074FC
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

		// Token: 0x060000E2 RID: 226 RVA: 0x00009450 File Offset: 0x00007650
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = !this.chkViewAllCusCategories.Checked;
				if (flag)
				{
					this.cboCustomerCategories.Visible = true;
					this.cboCustomerCategories.SelectedIndex = -1;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000094B0 File Offset: 0x000076B0
		private void LoadCustomerCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from CustomerCategoryNames where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlDataAdapter.Fill(dataTable);
				this.cboCustomerCategories.DataSource = dataTable;
				this.cboCustomerCategories.ValueMember = "ID";
				this.cboCustomerCategories.DisplayMember = "CategoryName";
				sqlConnection.Close();
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00009574 File Offset: 0x00007774
		private void cboCustomerCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				DataView defaultView = this.dat_accs.DefaultView;
				defaultView.RowFilter = Conversions.ToString(Operators.ConcatenateObject("CustomerGroupID=", this.cboCustomerCategories.SelectedValue));
				this.DataGridView2.DataSource = defaultView;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000095E0 File Offset: 0x000077E0
		private void cboBranch2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomerBals(1);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000056 RID: 86
		private string _cnn;

		// Token: 0x04000057 RID: 87
		private PublicFunctions pf;

		// Token: 0x04000058 RID: 88
		private string TextToPrint;

		// Token: 0x04000059 RID: 89
		private string coname;

		// Token: 0x0400005A RID: 90
		private string coadd;

		// Token: 0x0400005B RID: 91
		private string coadd2;

		// Token: 0x0400005C RID: 92
		private string cotel;

		// Token: 0x0400005D RID: 93
		private string coemail;

		// Token: 0x0400005E RID: 94
		private string cobpnum;

		// Token: 0x0400005F RID: 95
		private string cotel2;

		// Token: 0x04000060 RID: 96
		private string cotel3;

		// Token: 0x04000061 RID: 97
		private StringReader stringToRead;

		// Token: 0x04000062 RID: 98
		private DataTable dat_accs;
	}
}
