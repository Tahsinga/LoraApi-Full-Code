using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200004F RID: 79
	[DesignerGenerated]
	public partial class EditProducts : Form
	{
		// Token: 0x060010C0 RID: 4288 RVA: 0x0009DE24 File Offset: 0x0009C024
		public EditProducts()
		{
			base.Load += this.EditProducts_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.dat_compare = new DataTable();
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0009F958 File Offset: 0x0009DB58
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x0009F962 File Offset: 0x0009DB62
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0009F96B File Offset: 0x0009DB6B
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x0009F978 File Offset: 0x0009DB78
		internal virtual DataGridView dgvProducts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
				DataGridViewCellCancelEventHandler dataGridViewCellCancelEventHandler = new DataGridViewCellCancelEventHandler(this.dgvProducts_CellBeginEdit);
				DataGridView dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
					dataGridView.CellBeginEdit -= dataGridViewCellCancelEventHandler;
				}
				this._dgvProducts = value;
				dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
					dataGridView.CellBeginEdit += dataGridViewCellCancelEventHandler;
				}
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0009F9D6 File Offset: 0x0009DBD6
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x0009F9E0 File Offset: 0x0009DBE0
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0009F9E9 File Offset: 0x0009DBE9
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x0009F9F3 File Offset: 0x0009DBF3
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0009F9FC File Offset: 0x0009DBFC
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0009FA08 File Offset: 0x0009DC08
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

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0009FA66 File Offset: 0x0009DC66
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0009FA70 File Offset: 0x0009DC70
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0009FA79 File Offset: 0x0009DC79
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0009FA84 File Offset: 0x0009DC84
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

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0009FAC7 File Offset: 0x0009DCC7
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x0009FAD1 File Offset: 0x0009DCD1
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0009FADA File Offset: 0x0009DCDA
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x0009FAE4 File Offset: 0x0009DCE4
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

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0009FB27 File Offset: 0x0009DD27
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0009FB31 File Offset: 0x0009DD31
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0009FB3A File Offset: 0x0009DD3A
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0009FB44 File Offset: 0x0009DD44
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
				EventHandler eventHandler = new EventHandler(this.txtProductCode_TextChanged);
				TextBox textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtProductCode = value;
				textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0009FB87 File Offset: 0x0009DD87
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0009FB94 File Offset: 0x0009DD94
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

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0009FBD7 File Offset: 0x0009DDD7
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x0009FBE1 File Offset: 0x0009DDE1
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0009FBEA File Offset: 0x0009DDEA
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x0009FBF4 File Offset: 0x0009DDF4
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0009FBFD File Offset: 0x0009DDFD
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x0009FC08 File Offset: 0x0009DE08
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

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0009FC4B File Offset: 0x0009DE4B
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0009FC58 File Offset: 0x0009DE58
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0009FC9B File Offset: 0x0009DE9B
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
		internal virtual ComboBox cboCat
		{
			[CompilerGenerated]
			get
			{
				return this._cboCat;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCat_SelectedIndexChanged);
				ComboBox comboBox = this._cboCat;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCat = value;
				comboBox = this._cboCat;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0009FCEB File Offset: 0x0009DEEB
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x0009FCF8 File Offset: 0x0009DEF8
		internal virtual TextBox txtPerc
		{
			[CompilerGenerated]
			get
			{
				return this._txtPerc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPerc_KeyPress);
				TextBox textBox = this._txtPerc;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPerc = value;
				textBox = this._txtPerc;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0009FD3B File Offset: 0x0009DF3B
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x0009FD45 File Offset: 0x0009DF45
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0009FD4E File Offset: 0x0009DF4E
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0009FD58 File Offset: 0x0009DF58
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0009FD61 File Offset: 0x0009DF61
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0009FD6B File Offset: 0x0009DF6B
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x0009FD74 File Offset: 0x0009DF74
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0009FD7E File Offset: 0x0009DF7E
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0009FD87 File Offset: 0x0009DF87
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0009FD91 File Offset: 0x0009DF91
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0009FD9A File Offset: 0x0009DF9A
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x0009FDA4 File Offset: 0x0009DFA4
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

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0009FDE7 File Offset: 0x0009DFE7
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0009FDF4 File Offset: 0x0009DFF4
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

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0009FE37 File Offset: 0x0009E037
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0009FE41 File Offset: 0x0009E041
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0009FE4A File Offset: 0x0009E04A
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0009FE54 File Offset: 0x0009E054
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

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0009FE97 File Offset: 0x0009E097
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0009FEA4 File Offset: 0x0009E0A4
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

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0009FEE7 File Offset: 0x0009E0E7
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0009FEF1 File Offset: 0x0009E0F1
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0009FEFA File Offset: 0x0009E0FA
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0009FF04 File Offset: 0x0009E104
		internal virtual Label lblView
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0009FF0D File Offset: 0x0009E10D
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0009FF18 File Offset: 0x0009E118
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0009FF5B File Offset: 0x0009E15B
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0009FF68 File Offset: 0x0009E168
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0009FFAB File Offset: 0x0009E1AB
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x0009FFB8 File Offset: 0x0009E1B8
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x0009FFFB File Offset: 0x0009E1FB
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x000A0008 File Offset: 0x0009E208
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000A004B File Offset: 0x0009E24B
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x000A0058 File Offset: 0x0009E258
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

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000A009B File Offset: 0x0009E29B
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x000A00A8 File Offset: 0x0009E2A8
		internal virtual Button btnRecordSerial
		{
			[CompilerGenerated]
			get
			{
				return this._btnRecordSerial;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnRecordSerial_Click);
				Button button = this._btnRecordSerial;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnRecordSerial = value;
				button = this._btnRecordSerial;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000A00EB File Offset: 0x0009E2EB
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x000A00F8 File Offset: 0x0009E2F8
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
				ComboBox comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox1 = value;
				comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000A013B File Offset: 0x0009E33B
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x000A0148 File Offset: 0x0009E348
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

		// Token: 0x0600110F RID: 4367 RVA: 0x000A018C File Offset: 0x0009E38C
		private void EditProducts_Load(object sender, EventArgs e)
		{
			try
			{
				bool isbranch = MyProject.Forms.Form1.isbranch;
				if (isbranch)
				{
					MessageBox.Show("This is a branch computer and cannot edit product details. Edit at the HQ branch.");
					base.Dispose();
				}
				this.FetchAllProducts2();
				this.LoadCategories();
				this.btnRecordSerial.Text = "Change Record" + MyProject.Forms.Form1.serialNumberName;
				base.WindowState = FormWindowState.Maximized;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000A0238 File Offset: 0x0009E438
		private void FetchAllProducts()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts3";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat_compare);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x000A02A8 File Offset: 0x0009E4A8
		private void FetchAllProducts2()
		{
			Cursor.Current = Cursors.WaitCursor;
			DataTable dataTable = new DataTable();
			this.dat = dataTable;
			this.dgvProducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts3";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(this.dat);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvProducts.DataSource = this.dat;
				this.dgvProducts.Columns["CatID"].Visible = false;
				this.dgvProducts.Columns["CatDesc"].Visible = true;
				this.dgvProducts.Columns["CatDesc"].HeaderText = "Category";
				this.dgvProducts.Columns["CatDesc"].ReadOnly = true;
				this.dgvProducts.Columns["CatDesc"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["ProductID"].Visible = false;
				this.dgvProducts.Columns["Bin_Location"].Visible = true;
				this.dgvProducts.Columns["ProductCode"].ReadOnly = true;
				this.dgvProducts.Columns["ProductCode"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = true;
				this.dgvProducts.Columns["Unit_of_Measure"].ReadOnly = true;
				this.dgvProducts.Columns["Unit_of_Measure"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["ProductExpires"].HeaderText = "Product Expires?";
				this.dgvProducts.Columns["Is_Active"].ReadOnly = true;
				this.dgvProducts.Columns["Is_Active"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Unlimited_Stock_Item"].ReadOnly = true;
				this.dgvProducts.Columns["Unlimited_Stock_Item"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Is_Ingridient"].ReadOnly = true;
				this.dgvProducts.Columns["Is_Ingridient"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Is_Fav"].ReadOnly = true;
				this.dgvProducts.Columns["Is_Fav"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Is_Weighed"].ReadOnly = true;
				this.dgvProducts.Columns["Is_Weighed"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Is_Booking"].ReadOnly = true;
				this.dgvProducts.Columns["Is_Booking"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Change_Price_Variable"].ReadOnly = true;
				this.dgvProducts.Columns["Change_Price_Variable"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["Is_Tax_Exempt"].ReadOnly = true;
				this.dgvProducts.Columns["Is_Tax_Exempt"].DefaultCellStyle.BackColor = Color.LightGray;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Save Changes";
				dataGridViewButtonColumn.Text = "Save";
				dataGridViewButtonColumn.Name = "save";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(17, dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Deactivate Product";
				dataGridViewButtonColumn2.Text = "Deactivate";
				dataGridViewButtonColumn2.Name = "deactivate";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(18, dataGridViewButtonColumn2);
				DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn3.HeaderText = "Activate Product";
				dataGridViewButtonColumn3.Text = "Activate";
				dataGridViewButtonColumn3.Name = "Activate";
				dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(19, dataGridViewButtonColumn3);
				DataGridViewButtonColumn dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn4.HeaderText = "Change Product Expiry";
				dataGridViewButtonColumn4.Text = "Change?";
				dataGridViewButtonColumn4.Name = "Expires";
				this.dgvProducts.Columns.Insert(20, dataGridViewButtonColumn4);
				DataGridViewButtonColumn dataGridViewButtonColumn5 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn5.HeaderText = "Delete Product";
				dataGridViewButtonColumn5.Text = "Delete";
				dataGridViewButtonColumn5.Name = "Delete";
				dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(21, dataGridViewButtonColumn5);
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				dataGridViewCheckBoxColumn.HeaderText = "Change?";
				dataGridViewCheckBoxColumn.Name = "changeprice";
				this.dgvProducts.Columns.Insert(1, dataGridViewCheckBoxColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn6.HeaderText = "Change Unit of Measure";
				dataGridViewButtonColumn6.Text = "Change UOM";
				dataGridViewButtonColumn6.Name = "Change_UOM";
				dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(22, dataGridViewButtonColumn6);
				DataGridViewButtonColumn dataGridViewButtonColumn7 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn7.HeaderText = "Change Unlimited Stock Status";
				dataGridViewButtonColumn7.Text = "Change Unltd Status";
				dataGridViewButtonColumn7.Name = "Change Unltd Status";
				dataGridViewButtonColumn7.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(23, dataGridViewButtonColumn7);
				DataGridViewButtonColumn dataGridViewButtonColumn8 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn8.HeaderText = "Change Igridient Item Status";
				dataGridViewButtonColumn8.Text = "Change Ingridient Status";
				dataGridViewButtonColumn8.Name = "Change Ingridient Status";
				dataGridViewButtonColumn8.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(24, dataGridViewButtonColumn8);
				DataGridViewButtonColumn dataGridViewButtonColumn9 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn9.HeaderText = "Change Favourite Status";
				dataGridViewButtonColumn9.Text = "Change Favourite Status";
				dataGridViewButtonColumn9.Name = "Change Favourite Status";
				dataGridViewButtonColumn9.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(25, dataGridViewButtonColumn9);
				DataGridViewButtonColumn dataGridViewButtonColumn10 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn10.HeaderText = "Change Weighed Status";
				dataGridViewButtonColumn10.Text = "Change Weighed Status";
				dataGridViewButtonColumn10.Name = "Change Weighed Status";
				dataGridViewButtonColumn10.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(26, dataGridViewButtonColumn10);
				DataGridViewButtonColumn dataGridViewButtonColumn11 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn11.HeaderText = "Change Is Booking Status";
				dataGridViewButtonColumn11.Text = "Change Booking Status";
				dataGridViewButtonColumn11.Name = "Change Booking Status";
				dataGridViewButtonColumn11.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(26, dataGridViewButtonColumn11);
				DataGridViewButtonColumn dataGridViewButtonColumn12 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn12.HeaderText = "Change Is Price Variable Status";
				dataGridViewButtonColumn12.Text = "Change_Price_Changeable";
				dataGridViewButtonColumn12.Name = "Change_Price_Changeable";
				dataGridViewButtonColumn12.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(27, dataGridViewButtonColumn12);
				DataGridViewButtonColumn dataGridViewButtonColumn13 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn13.HeaderText = "Change Is Tax Exempt";
				dataGridViewButtonColumn13.Text = "Change_Is_Tax_Exempt";
				dataGridViewButtonColumn13.Name = "Change_Is_Tax_Exempt";
				dataGridViewButtonColumn13.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(28, dataGridViewButtonColumn13);
				DataGridViewButtonColumn dataGridViewButtonColumn14 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn14.HeaderText = "Change Is Deposit";
				dataGridViewButtonColumn14.Text = "Change_Is_Deposit";
				dataGridViewButtonColumn14.Name = "Change_Is_Deposit";
				dataGridViewButtonColumn14.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(29, dataGridViewButtonColumn14);
				DataGridViewButtonColumn dataGridViewButtonColumn15 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn15.HeaderText = "Change Different Price Per Branch";
				dataGridViewButtonColumn15.Text = "Change_Price_Per_Branch";
				dataGridViewButtonColumn15.Name = "Change_Price_Per_Branch";
				dataGridViewButtonColumn15.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(30, dataGridViewButtonColumn15);
				DataGridViewButtonColumn dataGridViewButtonColumn16 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn16.HeaderText = "Change Is Scale Product";
				dataGridViewButtonColumn16.Text = "Change_Is_Scale";
				dataGridViewButtonColumn16.Name = "Change_Is_Scale";
				dataGridViewButtonColumn16.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Insert(31, dataGridViewButtonColumn16);
				this.lblView.Text = "Grid is showing all products";
				this.FetchAllProducts();
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000A0C0C File Offset: 0x0009EE0C
		private void SaveProductDetails(int prodtid, string desc, string desc2, double unitcost, double sellingprice, int reorderlevel, string doneby, int donewhen, decimal taxrate, string uom, string binloc, decimal wholesaleprice, decimal wholesaleqty)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SaveProductDetails4";
			sqlCommand.Parameters.AddWithValue("ProductID", prodtid);
			sqlCommand.Parameters.AddWithValue("ProductDesc", desc);
			sqlCommand.Parameters.AddWithValue("ProductDesc2", desc2);
			sqlCommand.Parameters.AddWithValue("ProductCost", unitcost);
			sqlCommand.Parameters.AddWithValue("ProductSellingPrice", sellingprice);
			sqlCommand.Parameters.AddWithValue("ReorderLevel", reorderlevel);
			sqlCommand.Parameters.AddWithValue("DoneBy", doneby);
			sqlCommand.Parameters.AddWithValue("DoneWhen", donewhen);
			sqlCommand.Parameters.AddWithValue("TaxRate", taxrate);
			sqlCommand.Parameters.AddWithValue("uom", uom);
			sqlCommand.Parameters.AddWithValue("binloc", binloc);
			sqlCommand.Parameters.AddWithValue("wholesaleprice", wholesaleprice);
			sqlCommand.Parameters.AddWithValue("wholesaleqty", wholesaleqty);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x000A0DB8 File Offset: 0x0009EFB8
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSave");
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "save", false) == 0;
					if (flag2)
					{
						bool flag3 = Operators.ConditionalCompareObjectEqual(this.dgvProducts.Rows[e.RowIndex].Cells["DifferentPricesPerBranch"].Value, true, false);
						int num2;
						if (flag3)
						{
							num2 = 1;
						}
						else
						{
							num2 = 0;
						}
						string text = Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Product_Description"].Value);
						string text2 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Product_Desc2"].Value)), "", RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Product_Desc2"].Value)));
						double num3 = Conversions.ToDouble(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_Cost"].Value);
						double num4 = Conversions.ToDouble(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_Selling_Price"].Value);
						int num5 = Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["Reorder_Level"].Value);
						int num6 = Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
						double num7 = Conversions.ToDouble(this.dgvProducts.Rows[e.RowIndex].Cells["Tax_Percentage"].Value);
						string text3 = Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_of_Measure"].Value);
						string text4 = Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Bin_Location"].Value);
						decimal num8 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Wholesale_Selling_Price"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Wholesale_Selling_Price"].Value)));
						decimal num9 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Wholesale_Qty"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Wholesale_Qty"].Value)));
						decimal num10 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Special_Price"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Special_Price"].Value)));
						string text5 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["manufacturer"].Value)), "", RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["manufacturer"].Value)));
						string text6 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["shelflife"].Value)), "", RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["shelflife"].Value)));
						bool flag4 = false;
						bool flag5 = false;
						bool flag6 = false;
						bool flag7 = false;
						bool flag8 = false;
						bool flag9 = false;
						bool flag10 = false;
						DataRow[] array = this.dat_compare.Select("ProductID=" + num6.ToString());
						DataRow dataRow = array[0];
						bool flag11 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Unit_Selling_Price"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Unit_Selling_Price"])), num4, false);
						if (flag11)
						{
							flag4 = true;
						}
						bool flag12 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Selling_Price"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Selling_Price"])), num8, false);
						if (flag12)
						{
							flag5 = true;
						}
						bool flag13 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Qty"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Qty"])), num9, false);
						if (flag13)
						{
							flag6 = true;
						}
						bool flag14 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"])), num3, false);
						if (flag14)
						{
							flag7 = true;
						}
						bool flag15 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Product_Description"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Product_Description"])), text, false);
						if (flag15)
						{
							flag8 = true;
						}
						bool flag16 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Reorder_Level"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Reorder_Level"])), num5, false);
						if (flag16)
						{
							flag9 = true;
						}
						bool flag17 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["manufacturer"])), 0, RuntimeHelpers.GetObjectValue(dataRow["manufacturer"])), text5, false);
						if (flag17)
						{
							flag10 = true;
						}
						bool flag18 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["shelflife"])), 0, RuntimeHelpers.GetObjectValue(dataRow["shelflife"])), text6, false);
						if (flag18)
						{
							flag10 = true;
						}
						bool flag19 = flag4 || flag5 || flag6 || flag7 || flag8 || flag9 || flag10;
						if (flag19)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "Audit_PriceChangeInsert";
							sqlCommand.Parameters.AddWithValue("productid", num6);
							sqlCommand.Parameters.AddWithValue("systemdate", DateTime.Now);
							sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", flag7);
							sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", flag4);
							sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", flag5);
							sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", flag6);
							sqlCommand.Parameters.AddWithValue("Old_CostPrice", RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"]));
							sqlCommand.Parameters.AddWithValue("New_CostPrice", num3);
							sqlCommand.Parameters.AddWithValue("Old_SellingPrice", RuntimeHelpers.GetObjectValue(dataRow["Unit_Selling_Price"]));
							sqlCommand.Parameters.AddWithValue("New_SellingPrice", num4);
							sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Selling_Price"]));
							sqlCommand.Parameters.AddWithValue("New_WholesalePrice", num8);
							sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Qty"]));
							sqlCommand.Parameters.AddWithValue("New_WholesaleQty", num9);
							sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("comment", "EDIT PRODUCT DETAILS");
							sqlCommand.Parameters.AddWithValue("new_entryno", num);
							num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
						}
						bool flag20 = MyProject.Forms.Form1.UseApprovals == 1;
						if (flag20)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "UpdateProductApprovalEditPro";
							sqlCommand.Parameters.AddWithValue("ProductID", num6);
							sqlCommand.Parameters.AddWithValue("ProductDesc", text);
							sqlCommand.Parameters.AddWithValue("ProductDesc2", text2);
							sqlCommand.Parameters.AddWithValue("ProductCost", num3);
							sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
							sqlCommand.Parameters.AddWithValue("ReorderLevel", num5);
							sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("TaxRate", num7);
							sqlCommand.Parameters.AddWithValue("uom", text3);
							sqlCommand.Parameters.AddWithValue("binloc", text4);
							sqlCommand.Parameters.AddWithValue("wholesaleprice", num8);
							sqlCommand.Parameters.AddWithValue("wholesaleqty", num9);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("specialprice", num10);
							sqlCommand.Parameters.AddWithValue("differentprices", num2);
							sqlCommand.Parameters.AddWithValue("approval_audit_entryno", num);
							sqlCommand.ExecuteNonQuery();
						}
						else
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "SaveProductDetails5";
							sqlCommand.Parameters.AddWithValue("ProductID", num6);
							sqlCommand.Parameters.AddWithValue("ProductDesc", text);
							sqlCommand.Parameters.AddWithValue("ProductDesc2", text2);
							sqlCommand.Parameters.AddWithValue("ProductCost", num3);
							sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
							sqlCommand.Parameters.AddWithValue("ReorderLevel", num5);
							sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("TaxRate", num7);
							sqlCommand.Parameters.AddWithValue("uom", text3);
							sqlCommand.Parameters.AddWithValue("binloc", text4);
							sqlCommand.Parameters.AddWithValue("wholesaleprice", num8);
							sqlCommand.Parameters.AddWithValue("wholesaleqty", num9);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("specialprice", num10);
							sqlCommand.Parameters.AddWithValue("differentprices", num2);
							sqlCommand.Parameters.AddWithValue("manu", text5);
							sqlCommand.Parameters.AddWithValue("shelflife", text6);
							sqlCommand.ExecuteNonQuery();
						}
						sqlTransaction.Commit();
						sqlCommand.Connection.Close();
						this.FetchAllProducts2();
						MessageBox.Show("Product Details Saved.");
					}
					else
					{
						bool flag21 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "deactivate", false) == 0;
						if (flag21)
						{
							this.DeleteProduct(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value));
							this.FetchAllProducts2();
						}
						else
						{
							bool flag22 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Activate", false) == 0;
							if (flag22)
							{
								this.ActivateProduct(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value));
								this.FetchAllProducts2();
							}
							else
							{
								bool flag23 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
								if (flag23)
								{
									DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete this product? " + dataGridView.Rows[e.RowIndex].Cells["Product_Description"].Value.ToString(), MsgBoxStyle.YesNo, null);
									bool flag24 = dialogResult == DialogResult.Yes;
									if (flag24)
									{
										string text7 = Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Product_Description"].Value);
										string text8 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Product_Desc2"].Value)), "", RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Product_Desc2"].Value)));
										double num11 = Conversions.ToDouble(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_Cost"].Value);
										double num12 = Conversions.ToDouble(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_Selling_Price"].Value);
										int num13 = Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["Reorder_Level"].Value);
										int num14 = Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
										this.DeleteProductForReal(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), new decimal(num11), new decimal(num12), text7, text8, Environment.MachineName, DateTime.Now.ToString("HH:mm"), DateTime.Today, Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_of_Measure"].Value), Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Ingridient"].Value), Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["CatID"].Value), Conversions.ToDecimal(this.dgvProducts.Rows[e.RowIndex].Cells["Tax_Percentage"].Value));
										this.FetchAllProducts2();
									}
								}
								else
								{
									bool flag25 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Expires", false) == 0;
									if (flag25)
									{
										this.ChangeProductExpiry(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value));
										this.FetchAllProducts2();
									}
									else
									{
										bool flag26 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change_UOM", false) == 0;
										if (flag26)
										{
											this.ChangeUOM(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_of_Measure"].Value));
											this.FetchAllProducts2();
										}
										else
										{
											bool flag27 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change_Price_Changeable", false) == 0;
											if (flag27)
											{
												bool flag28 = Conversions.ToDouble(this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Change_Price_Variable"].Value))) == 0.0;
												string text9;
												if (flag28)
												{
													text9 = Conversions.ToString(Operators.AddObject(Operators.AddObject("Are you sure you want to make the price of ", this.dgvProducts.Rows[e.RowIndex].Cells["Product_Description"].Value), " changeable at selling by anyone?"));
												}
												else
												{
													text9 = Conversions.ToString(Operators.AddObject(Operators.AddObject("Are you sure you want to make the price of ", this.dgvProducts.Rows[e.RowIndex].Cells["Product_Description"].Value), " unchangeable at selling by anyone?"));
												}
												DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox(text9, MsgBoxStyle.YesNo, null);
												bool flag29 = dialogResult2 == DialogResult.Yes;
												if (flag29)
												{
													this.ChangeIsPriceVariable(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Change_Price_Variable"].Value))));
													this.FetchAllProducts2();
												}
											}
											else
											{
												bool flag30 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Unltd Status", false) == 0;
												if (flag30)
												{
													this.ChangeUnltd(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Unlimited_Stock_Item"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Unlimited_Stock_Item"].Value))));
													this.FetchAllProducts2();
												}
												else
												{
													bool flag31 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Ingridient Status", false) == 0;
													if (flag31)
													{
														this.ChangeIngridient(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Ingridient"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Ingridient"].Value))));
														this.FetchAllProducts2();
													}
													else
													{
														bool flag32 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Favourite Status", false) == 0;
														if (flag32)
														{
															this.ChangeFavourite(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Fav"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Fav"].Value))));
															this.FetchAllProducts2();
														}
														else
														{
															bool flag33 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Weighed Status", false) == 0;
															if (flag33)
															{
																this.ChangeWeighed(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Weighed"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Weighed"].Value))));
																this.FetchAllProducts2();
															}
															else
															{
																bool flag34 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Booked Status", false) == 0;
																if (!flag34)
																{
																	bool flag35 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change_Is_Tax_Exempt", false) == 0;
																	if (flag35)
																	{
																		this.ChangeTaxExempt(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Tax_Exempt"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Tax_Exempt"].Value))));
																		MessageBox.Show("Tax Exempt Status changed. Reloading products.");
																		this.FetchAllProducts2();
																	}
																	else
																	{
																		bool flag36 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change_Price_Per_Branch", false) == 0;
																		if (flag36)
																		{
																			this.ChangeIsDiffPricesPerBranches(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["DifferentPricesPerBranch"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["DifferentPricesPerBranch"].Value))));
																			MessageBox.Show("Different Price Per Branch Status Changed. Reloading products.");
																			this.FetchAllProducts2();
																		}
																		else
																		{
																			bool flag37 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change_Is_Scale", false) == 0;
																			if (flag37)
																			{
																				this.ChangeIsScale(Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value), Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Scale_Product"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["Is_Scale_Product"].Value))));
																				MessageBox.Show("Is scale product setting changed. Reloading products.");
																				this.FetchAllProducts2();
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (SqlException ex)
			{
				bool flag38 = ex.Number == 547;
				if (flag38)
				{
					MessageBox.Show("This product has sales transactions And therefore cannot be deleted.", "Logical Error");
				}
				else
				{
					MessageBox.Show("Database error. Cannot delete product. Details" + ex.Message, "Database error");
				}
				try
				{
					sqlTransaction.Rollback();
				}
				catch (Exception ex2)
				{
				}
				sqlCommand.Connection.Close();
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error occurred. Detail:  " + ex3.Message);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000A2A08 File Offset: 0x000A0C08
		private void ChangeUOM(int productid, string currentUOM)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeUOM";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("uom", currentUOM);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000A2AC4 File Offset: 0x000A0CC4
		private void ChangeIsPriceVariable(int productid, int currentIsPriceVariable)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsPriceVariable";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("ispricevariable", currentIsPriceVariable);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x000A2B84 File Offset: 0x000A0D84
		private void ChangeProductExpiry(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeProductExpiry";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000A2C2C File Offset: 0x000A0E2C
		private void DeleteProduct(int ID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteProduct";
			sqlCommand.Parameters.AddWithValue("prodtID", ID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000A2CD4 File Offset: 0x000A0ED4
		private void DeleteProductForReal(int ID, decimal cost, decimal sellingprice, string desc1, string desc2, string machinename, string timedeleted, DateTime datedeleted, string uom, int isingridientonly, int catid, decimal taxrate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteProductForReal";
			sqlCommand.Parameters.AddWithValue("prodtID", ID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("cost", cost);
			sqlCommand.Parameters.AddWithValue("sellingprice", sellingprice);
			sqlCommand.Parameters.AddWithValue("desc1", desc1);
			sqlCommand.Parameters.AddWithValue("desc2", desc2);
			sqlCommand.Parameters.AddWithValue("DateDeleted", datedeleted);
			sqlCommand.Parameters.AddWithValue("TimeDeleted", timedeleted);
			sqlCommand.Parameters.AddWithValue("MachineName", machinename);
			sqlCommand.Parameters.AddWithValue("uom", uom);
			sqlCommand.Parameters.AddWithValue("taxrate", taxrate);
			sqlCommand.Parameters.AddWithValue("catid", catid);
			sqlCommand.Parameters.AddWithValue("isingridientonly", isingridientonly);
			sqlCommand.Parameters.AddWithValue("deletedby", MyProject.Forms.Form1.username);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x000A2E88 File Offset: 0x000A1088
		private void ActivateProduct(int ID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ActivateProduct";
			sqlCommand.Parameters.AddWithValue("prodtID", ID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x000A2F30 File Offset: 0x000A1130
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProductsSearch();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000A2F90 File Offset: 0x000A1190
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000A3050 File Offset: 0x000A1250
		private void FetchAllProductsSearch()
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
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000A3228 File Offset: 0x000A1428
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtsearch.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000A3288 File Offset: 0x000A1488
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

		// Token: 0x0600111F RID: 4383 RVA: 0x000A3380 File Offset: 0x000A1580
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

		// Token: 0x06001120 RID: 4384 RVA: 0x000A33EC File Offset: 0x000A15EC
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool isCurrentCellDirty = this.dgvProducts.IsCurrentCellDirty;
					if (isCurrentCellDirty)
					{
						this.dgvProducts.CommitEdit(DataGridViewDataErrorContexts.Commit);
					}
					int count = this.dgvProducts.Rows.Count;
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							num++;
							bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
							if (flag)
							{
								dataGridViewRow.Cells["Product_Description"].Selected = true;
								this.dgvProducts.CurrentCell = dataGridViewRow.Cells["Product_Description"];
								dataGridViewRow.Selected = true;
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
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x000A351C File Offset: 0x000A171C
		private void Button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
			sqlCommand.Transaction = sqlTransaction;
			checked
			{
				try
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							int num2 = 0;
							string text = dataGridViewRow.Cells["DifferentPricesPerBranch"].Value.ToString();
							bool flag = Operators.CompareString(dataGridViewRow.Cells["DifferentPricesPerBranch"].Value.ToString(), "True", false) == 0;
							int num3;
							if (flag)
							{
								num3 = 1;
							}
							else
							{
								num3 = 0;
							}
							string text2 = Conversions.ToString(dataGridViewRow.Cells["Product_Description"].Value);
							string text3 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Product_Desc2"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Product_Desc2"].Value)));
							double num4 = Conversions.ToDouble(dataGridViewRow.Cells["Unit_Cost"].Value);
							double num5 = Conversions.ToDouble(dataGridViewRow.Cells["Unit_Selling_Price"].Value);
							int num6 = Conversions.ToInteger(dataGridViewRow.Cells["Reorder_Level"].Value);
							int num7 = Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value);
							double num8 = Conversions.ToDouble(dataGridViewRow.Cells["Tax_Percentage"].Value);
							string text4 = Conversions.ToString(dataGridViewRow.Cells["Unit_of_Measure"].Value);
							string text5 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Bin_Location"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Bin_Location"].Value)));
							decimal num9 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Wholesale_Selling_Price"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Wholesale_Selling_Price"].Value)));
							decimal num10 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Wholesale_Qty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Wholesale_Qty"].Value)));
							decimal num11 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Special_Price"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Special_Price"].Value)));
							string text6 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["manufacturer"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["manufacturer"].Value)));
							int num12 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["shelflife"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["shelflife"].Value)));
							decimal num13 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productweight"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productweight"].Value)));
							bool flag2 = false;
							bool flag3 = false;
							bool flag4 = false;
							bool flag5 = false;
							bool flag6 = false;
							bool flag7 = false;
							bool flag8 = false;
							bool flag9 = false;
							DataRow[] array = this.dat_compare.Select("ProductID=" + num7.ToString());
							DataRow dataRow = array[0];
							bool flag10 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Product_Description"])), "", RuntimeHelpers.GetObjectValue(dataRow["Product_Description"])), text2, false);
							if (flag10)
							{
								flag9 = true;
							}
							bool flag11 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Product_Desc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["Product_Desc2"])), text3, false);
							if (flag11)
							{
								flag9 = true;
							}
							bool flag12 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"])), num4, false);
							if (flag12)
							{
								flag9 = true;
							}
							bool flag13 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Special_Price"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Special_Price"])), num11, false);
							if (flag13)
							{
								flag6 = true;
								flag9 = true;
							}
							bool flag14 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Tax_Percentage"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Tax_Percentage"])), num8, false);
							if (flag14)
							{
								flag9 = true;
							}
							bool flag15 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Unit_Selling_Price"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Unit_Selling_Price"])), num5, false);
							if (flag15)
							{
								flag2 = true;
								flag9 = true;
							}
							bool flag16 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Selling_Price"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Selling_Price"])), num9, false);
							if (flag16)
							{
								flag3 = true;
								flag9 = true;
							}
							bool flag17 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Qty"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Qty"])), num10, false);
							if (flag17)
							{
								flag4 = true;
								flag9 = true;
							}
							bool flag18 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"])), num4, false);
							if (flag18)
							{
								flag5 = true;
								flag9 = true;
							}
							bool flag19 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Bin_Location"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Bin_Location"])), text5, false);
							if (flag19)
							{
								flag7 = true;
								flag9 = true;
							}
							bool flag20 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Reorder_Level"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Reorder_Level"])), num6, false);
							if (flag20)
							{
								flag8 = true;
								flag9 = true;
							}
							bool flag21 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["manufacturer"])), "", RuntimeHelpers.GetObjectValue(dataRow["manufacturer"])), text6, false);
							if (flag21)
							{
								flag9 = true;
							}
							bool flag22 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["shelflife"])), 0, RuntimeHelpers.GetObjectValue(dataRow["shelflife"])), num12, false);
							if (flag22)
							{
								flag9 = true;
							}
							bool flag23 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["productweight"])), 0, RuntimeHelpers.GetObjectValue(dataRow["productweight"])), num13, false);
							if (flag23)
							{
								flag9 = true;
							}
							bool flag24 = flag2 || flag3 || flag4 || flag5 || flag6 || flag8 || flag7;
							if (flag24)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "Audit_PriceChangeInsert";
								sqlCommand.Parameters.AddWithValue("productid", num7);
								sqlCommand.Parameters.AddWithValue("systemdate", DateTime.Now);
								sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", flag5);
								sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", flag2);
								sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", flag3);
								sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", flag4);
								sqlCommand.Parameters.AddWithValue("Old_CostPrice", RuntimeHelpers.GetObjectValue(dataRow["Unit_Cost"]));
								sqlCommand.Parameters.AddWithValue("New_CostPrice", num4);
								sqlCommand.Parameters.AddWithValue("Old_SellingPrice", RuntimeHelpers.GetObjectValue(dataRow["Unit_Selling_Price"]));
								sqlCommand.Parameters.AddWithValue("New_SellingPrice", num5);
								sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Selling_Price"]));
								sqlCommand.Parameters.AddWithValue("New_WholesalePrice", num9);
								sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", RuntimeHelpers.GetObjectValue(dataRow["Wholesale_Qty"]));
								sqlCommand.Parameters.AddWithValue("New_WholesaleQty", num10);
								sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("comment", "EDIT PRODUCT DETAILS");
								sqlCommand.Parameters.AddWithValue("new_entryno", num2);
								num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
							}
							bool flag25 = flag9 & (MyProject.Forms.Form1.UseApprovals == 0);
							if (flag25)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "SaveProductDetails5";
								sqlCommand.Parameters.AddWithValue("ProductID", num7);
								sqlCommand.Parameters.AddWithValue("ProductDesc", text2);
								sqlCommand.Parameters.AddWithValue("ProductDesc2", text3);
								sqlCommand.Parameters.AddWithValue("ProductCost", num4);
								sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num5);
								sqlCommand.Parameters.AddWithValue("ReorderLevel", num6);
								sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("TaxRate", num8);
								sqlCommand.Parameters.AddWithValue("uom", text4);
								sqlCommand.Parameters.AddWithValue("binloc", text5);
								sqlCommand.Parameters.AddWithValue("wholesaleprice", num9);
								sqlCommand.Parameters.AddWithValue("wholesaleqty", num10);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("specialprice", num11);
								sqlCommand.Parameters.AddWithValue("differentprices", num3);
								sqlCommand.Parameters.AddWithValue("manu", text6);
								sqlCommand.Parameters.AddWithValue("shelflife", num12);
								sqlCommand.Parameters.AddWithValue("productweight", num13);
								sqlCommand.ExecuteNonQuery();
								num++;
							}
							else
							{
								bool flag26 = flag9 & (MyProject.Forms.Form1.UseApprovals == 1);
								if (flag26)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "UpdateProductApprovalEditPro";
									sqlCommand.Parameters.AddWithValue("ProductID", num7);
									sqlCommand.Parameters.AddWithValue("ProductDesc", text2);
									sqlCommand.Parameters.AddWithValue("ProductDesc2", text3);
									sqlCommand.Parameters.AddWithValue("ProductCost", num4);
									sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num5);
									sqlCommand.Parameters.AddWithValue("ReorderLevel", num6);
									sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("TaxRate", num8);
									sqlCommand.Parameters.AddWithValue("uom", text4);
									sqlCommand.Parameters.AddWithValue("binloc", text5);
									sqlCommand.Parameters.AddWithValue("wholesaleprice", num9);
									sqlCommand.Parameters.AddWithValue("wholesaleqty", num10);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("specialprice", num11);
									sqlCommand.Parameters.AddWithValue("differentprices", num3);
									sqlCommand.Parameters.AddWithValue("approval_audit_entryno", num2);
									sqlCommand.ExecuteNonQuery();
									num++;
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
					sqlTransaction.Commit();
					sqlCommand.Connection.Close();
					bool flag27 = MyProject.Forms.Form1.usingBarcodePrintingScale == 1;
					if (flag27)
					{
						bool flag28 = num > 0;
						if (flag28)
						{
							MessageBox.Show(num.ToString() + " product changes saved successfully. Press OK to save PLU Scale Update list");
						}
						else
						{
							MessageBox.Show("NO changes made. Press OK to save PLU Scale Update list.");
						}
						string text7 = "";
						string text8 = "";
						DataTable barcodeScaleSettings = this.pf.GetBarcodeScaleSettings(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
						bool flag29 = barcodeScaleSettings.Rows.Count > 0;
						if (flag29)
						{
							DataRow dataRow2 = barcodeScaleSettings.Rows[0];
							text7 = Conversions.ToString(dataRow2["scalename"]);
							text8 = Conversions.ToString(dataRow2["filepath"]);
						}
						bool flag30 = Operators.CompareString(text7, "UNI SCALE", false) == 0;
						if (flag30)
						{
							string text9 = text8;
							bool flag31 = !Directory.Exists(text9);
							if (flag31)
							{
								Directory.CreateDirectory(text9);
							}
							string text10 = text9 + "\\products";
							bool flag32 = !File.Exists(text10);
							if (flag32)
							{
								File.Create(text10).Dispose();
							}
							DataTable dataTable = new DataTable();
							DataGridView dataGridView = new DataGridView();
							this.dtTableToCSV(this.pf.GetishidaExportList(this._cnn), text10, true, ",");
							MessageBox.Show("Scale Update list successfully exported for UNI Scale.");
							int num14 = this.pf.CheckIfIshidaExportOk(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
							bool flag33 = num14 > 0;
							if (flag33)
							{
								MessageBox.Show(string.Concat(new string[]
								{
									"There are ",
									Conversions.ToString(num14),
									" products with product codes longer than ",
									this.pf.GetBarcodeScaleCodeLen(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString(),
									" characters. If this is not supported by your scale configuration, please change IsScale settings for the affected products."
								}));
							}
						}
						else
						{
							bool flag34 = Operators.CompareString(text7, "TERAOKA", false) == 0;
							if (flag34)
							{
								string text11 = text8;
								bool flag35 = !Directory.Exists(text11);
								if (flag35)
								{
									Directory.CreateDirectory(text11);
								}
								string text12 = text11 + "\\PLU";
								DataTable dataTable2 = new DataTable();
								DataGridView dataGridView2 = new DataGridView();
								this.dtTableToCSV(this.pf.GetTeraokaExportList(this._cnn), text12, true, ",");
								try
								{
									Process process = new Process();
									process.StartInfo.FileName = "C:\\Program Files\\Teraoka\\SDBX2\\Send.bat";
									process.StartInfo.UseShellExecute = false;
									process.StartInfo.RedirectStandardOutput = true;
									process.StartInfo.RedirectStandardError = true;
									process.StartInfo.CreateNoWindow = true;
									process.Start();
									string text13 = process.StandardOutput.ReadToEnd();
									string text14 = process.StandardError.ReadToEnd();
									process.WaitForExit();
									MessageBox.Show("CMD Line output: " + text13);
									MessageBox.Show("CMD Line error: " + text14);
								}
								catch (Exception ex)
								{
									MessageBox.Show("Error executing Send.bat. Details: " + ex.Message);
								}
								MessageBox.Show("Scale Update list successfully exported for Teraoka Scale.");
							}
							else
							{
								MessageBox.Show("Scale name not recognised. Please call your system administrator or redo the settings un General Settings");
							}
						}
					}
					else
					{
						bool flag36 = num > 0;
						if (flag36)
						{
							MessageBox.Show(num.ToString() + " product changes saved successfully.");
						}
						else
						{
							MessageBox.Show("NO changes made.");
						}
					}
					this.FetchAllProducts2();
				}
				catch (SqlException ex2)
				{
					bool flag37 = ex2.Number == 547;
					if (flag37)
					{
						MessageBox.Show("This product has sales transactions and therefore cannot be deleted.", "Logical Error");
					}
					else
					{
						MessageBox.Show("Database error. Details" + ex2.Message, "Database error");
					}
					sqlTransaction.Rollback();
					sqlCommand.Connection.Close();
				}
				catch (Exception ex3)
				{
					MessageBox.Show("Error occurred. Detail: " + ex3.Message);
				}
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000A48FC File Offset: 0x000A2AFC
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
			this.cboCat.DataSource = dataTable;
			this.cboCat.ValueMember = "CatID";
			this.cboCat.DisplayMember = "CatDesc";
			this.cboCat.SelectedIndex = -1;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x000A49A8 File Offset: 0x000A2BA8
		private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.CompareString(dataGridViewRow.Cells["CatDesc"].Value.ToString(), this.cboCat.Text, false) == 0;
						if (flag)
						{
							dataGridViewRow.Cells[1].Value = 1;
						}
						else
						{
							dataGridViewRow.Cells[1].Value = 0;
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
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting products. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000A4AC0 File Offset: 0x000A2CC0
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells[1].Value = 1;
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
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						dataGridViewRow2.Cells[1].Value = 0;
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
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000A4BBC File Offset: 0x000A2DBC
		private decimal updatePrice(decimal perc, decimal oldprice)
		{
			bool flag = decimal.Compare(perc, 0m) > 0;
			decimal num2;
			if (flag)
			{
				decimal num = decimal.Multiply(oldprice, decimal.Add(1m, decimal.Divide(perc, 100m)));
				num2 = num;
			}
			else
			{
				perc = decimal.Multiply(perc, -1m);
				decimal num = decimal.Divide(oldprice, decimal.Add(1m, decimal.Divide(perc, 100m)));
				num2 = num;
			}
			return num2;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x000A4C34 File Offset: 0x000A2E34
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Conversions.ToBoolean(dataGridViewRow.Cells[1].Value);
							bool flag2 = flag;
							if (flag2)
							{
								decimal num2 = Convert.ToDecimal(this.txtPerc.Text);
								decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Unit_Selling_Price"].Value));
								dataGridViewRow.Cells["Unit_Selling_Price"].Value = this.updatePrice(num2, num3);
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
					bool flag3 = num > 0;
					if (flag3)
					{
						MessageBox.Show("Prices updated in the grid. If satisfied please click SAVE ALL to save the changes.");
					}
					else
					{
						MessageBox.Show("There were NO prices updated.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error changing prices. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000A4D78 File Offset: 0x000A2F78
		private void txtPerc_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000A4DE0 File Offset: 0x000A2FE0
		private void dgvProducts_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = (Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "SellingPrice", false) == 0) & (e.RowIndex >= 0);
			if (flag)
			{
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x000A4E2C File Offset: 0x000A302C
		private void Button4_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Conversions.ToBoolean(dataGridViewRow.Cells[1].Value);
							bool flag2 = flag;
							if (flag2)
							{
								this.ChangeUOM(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), Conversions.ToString(dataGridViewRow.Cells["Unit_of_Measure"].Value));
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
					bool flag3 = num > 0;
					if (flag3)
					{
						this.FetchAllProducts2();
						MessageBox.Show(num.ToString() + " product UOM changed and saved.");
					}
					else
					{
						MessageBox.Show("There were NO UOM settings updated.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error changing prices. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000A4F60 File Offset: 0x000A3160
		private void ChangeUnltd(int productid, int currentUnltd)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeUnltd";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("unltd", currentUnltd);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000A5020 File Offset: 0x000A3220
		private void ChangeIngridient(int productid, int currentIngridient)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsIngridient";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isingridient", currentIngridient);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x000A50E0 File Offset: 0x000A32E0
		private void ChangeFavourite(int productid, int currentFav)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsFavourite";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isfav", currentFav);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000A51A0 File Offset: 0x000A33A0
		private void ChangeWeighed(int productid, int currentW)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsWeighed";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isw", currentW);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x000A5260 File Offset: 0x000A3460
		private void ChangeTaxExempt(int productid, int curr_taxex)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsTaxExempt";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("istaxexempt", curr_taxex);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x000A5320 File Offset: 0x000A3520
		private void ChangeIsScale(int productid, int curr_isscale)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsScale";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isscale", curr_isscale);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x000A53E0 File Offset: 0x000A35E0
		private void ChangeIsDiffPricesPerBranches(int productid, int curr_isdiff)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsDiffPricePerBranch";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isdiffpricesperbranch", curr_isdiff);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x000A54A0 File Offset: 0x000A36A0
		private void ChangeBooking(int productid, int currentB)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeIsBooking";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isb", currentB);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000A5560 File Offset: 0x000A3760
		private void Button5_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete these products? ", MsgBoxStyle.YesNo, null);
					bool flag = dialogResult == DialogResult.Yes;
					if (flag)
					{
						int num = 0;
						try
						{
							foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag2 = Conversions.ToBoolean(dataGridViewRow.Cells[1].Value);
								bool flag3 = flag2;
								if (flag3)
								{
									string text = Conversions.ToString(dataGridViewRow.Cells["Product_Description"].Value);
									string text2 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Product_Desc2"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Product_Desc2"].Value)));
									double num2 = Conversions.ToDouble(dataGridViewRow.Cells["Unit_Cost"].Value);
									double num3 = Conversions.ToDouble(dataGridViewRow.Cells["Unit_Selling_Price"].Value);
									int num4 = Conversions.ToInteger(dataGridViewRow.Cells["Reorder_Level"].Value);
									int num5 = Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value);
									this.DeleteProductForReal(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), new decimal(num2), new decimal(num3), text, text2, Environment.MachineName, DateTime.Now.ToString("HH:mm"), DateTime.Today, Conversions.ToString(dataGridViewRow.Cells["Unit_of_Measure"].Value), Conversions.ToInteger(dataGridViewRow.Cells["Is_Ingridient"].Value), Conversions.ToInteger(dataGridViewRow.Cells["CatID"].Value), Conversions.ToDecimal(dataGridViewRow.Cells["Tax_Percentage"].Value));
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
						bool flag4 = num > 0;
						if (flag4)
						{
							this.FetchAllProducts2();
							MessageBox.Show(num.ToString() + " products deleted.");
						}
						else
						{
							MessageBox.Show("There were NO UOM settings updated.");
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error changing prices. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x000A5830 File Offset: 0x000A3A30
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				CurrencyManager currencyManager = (CurrencyManager)this.BindingContext[RuntimeHelpers.GetObjectValue(this.dgvProducts.DataSource)];
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectLess(dataGridViewRow.Cells["Unit_Cost"].Value, dataGridViewRow.Cells["Unit_Selling_Price"].Value, false);
						if (flag)
						{
							currencyManager.SuspendBinding();
							dataGridViewRow.Visible = false;
							currencyManager.ResumeBinding();
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
				this.lblView.Text = "Grid is showing products with selling price lower than the cost price";
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error filtering. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000A595C File Offset: 0x000A3B5C
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvProducts.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvProducts, this.SaveFileDialog1.FileName);
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

		// Token: 0x06001135 RID: 4405 RVA: 0x000A5A14 File Offset: 0x000A3C14
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				this.FetchAllProducts2();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error filtering. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000A5A64 File Offset: 0x000A3C64
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				this.dgvProducts.Columns["Unit_Selling_Price"].Visible = false;
				this.dgvProducts.Columns["Special_Price"].Visible = false;
				this.dgvProducts.Columns["Unit_Cost"].Visible = false;
				this.dgvProducts.Columns["Wholesale_Selling_Price"].Visible = false;
				this.dgvProducts.Columns["Wholesale_Qty"].Visible = false;
				this.dgvProducts.Columns["Bin_Location"].Visible = false;
				this.dgvProducts.Columns["CatDesc"].Visible = false;
				this.dgvProducts.Columns["ProductID"].Visible = false;
				this.dgvProducts.Columns["ProductCode"].Visible = false;
				this.dgvProducts.Columns["Product_Description"].Visible = false;
				this.dgvProducts.Columns["Product_Desc2"].Visible = false;
				this.dgvProducts.Columns["Reorder_Level"].Visible = false;
				this.dgvProducts.Columns["Tax_Percentage"].Visible = false;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = false;
				this.dgvProducts.Columns["Is_Active"].Visible = false;
				this.dgvProducts.Columns["PRODUCTEXPIRES"].Visible = false;
				this.dgvProducts.Columns["DifferentPricesPerBranch"].Visible = false;
				this.dgvProducts.Columns["Unlimited_Stock_Item"].Visible = false;
				this.dgvProducts.Columns["Is_Ingridient"].Visible = false;
				this.dgvProducts.Columns["Is_Fav"].Visible = false;
				this.dgvProducts.Columns["Is_Weighed"].Visible = false;
				this.dgvProducts.Columns["Is_Booking"].Visible = false;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = false;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = false;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = false;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = false;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error filtering. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x000A5DAC File Offset: 0x000A3FAC
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

		// Token: 0x06001138 RID: 4408 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		private void Button10_Click(object sender, EventArgs e)
		{
			try
			{
				NewProdt2 newProdt = new NewProdt2();
				newProdt.not_for_purchase = true;
				newProdt.ShowDialog(this);
				newProdt.Dispose();
				MyProject.Forms.Form1.newProdtCode = "";
				MyProject.Forms.Form1.newProdtID = 0;
				MyProject.Forms.Form1.qtypurchased = 0m;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error creating new product. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000A605C File Offset: 0x000A425C
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				PriceMatrix priceMatrix = new PriceMatrix();
				priceMatrix.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening Price Matrix form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x000A60B0 File Offset: 0x000A42B0
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				CurrencyManager currencyManager = (CurrencyManager)this.BindingContext[RuntimeHelpers.GetObjectValue(this.dgvProducts.DataSource)];
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Is_Scale_Product"].Value));
						if (flag)
						{
							currencyManager.SuspendBinding();
							dataGridViewRow.Visible = false;
							currencyManager.ResumeBinding();
						}
						else
						{
							bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["Is_Scale_Product"].Value, 1, false);
							if (flag2)
							{
								currencyManager.SuspendBinding();
								dataGridViewRow.Visible = false;
								currencyManager.ResumeBinding();
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
				this.lblView.Text = "Grid is showing scale products only.";
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error filtering. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x000A622C File Offset: 0x000A442C
		private void btnRecordSerial_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Conversions.ToBoolean(dataGridViewRow.Cells[1].Value);
							bool flag2 = flag;
							if (flag2)
							{
								this.ChangeRecordSerialSettings(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), MyProject.Forms.Form1.coid);
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
					bool flag3 = num > 0;
					if (flag3)
					{
						MessageBox.Show("Record " + MyProject.Forms.Form1.serialNumberName + " has been changed and saved already.");
					}
					else
					{
						MessageBox.Show("There were NO settings updated.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error changing setting. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000A6358 File Offset: 0x000A4558
		private void ChangeRecordSerialSettings(int productid, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ChangeProductRecordSerial";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000A6400 File Offset: 0x000A4600
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.ComboBox1.Text, "View Tax Exempt Products Only", false) == 0;
				if (flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					CurrencyManager currencyManager = (CurrencyManager)this.BindingContext[RuntimeHelpers.GetObjectValue(this.dgvProducts.DataSource)];
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Is_Tax_Exempt"].Value));
							if (flag2)
							{
								currencyManager.SuspendBinding();
								dataGridViewRow.Visible = false;
								currencyManager.ResumeBinding();
							}
							else
							{
								bool flag3 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["Is_Tax_Exempt"].Value, 1, false);
								if (flag3)
								{
									currencyManager.SuspendBinding();
									dataGridViewRow.Visible = false;
									currencyManager.ResumeBinding();
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
					this.lblView.Text = "Grid is showing Tax Exempt products only.";
					Cursor.Current = Cursors.Default;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error filtering. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x000A65A0 File Offset: 0x000A47A0
		private void Button13_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to resend product details to branches? This can take a long time to effect.", MsgBoxStyle.YesNo, null);
					bool flag = dialogResult == DialogResult.Yes;
					if (flag)
					{
						int num = 0;
						try
						{
							foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag2 = Conversions.ToBoolean(dataGridViewRow.Cells[1].Value);
								bool flag3 = flag2;
								if (flag3)
								{
									num++;
									SqlConnection sqlConnection = new SqlConnection(this._cnn);
									SqlCommand sqlCommand = sqlConnection.CreateCommand();
									sqlCommand.CommandType = CommandType.Text;
									sqlCommand.CommandText = Conversions.ToString(Operators.ConcatenateObject("update products set uploaded=0 where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid) + " and productid=", dataGridViewRow.Cells["ProductID"].Value));
									using (sqlConnection)
									{
										sqlConnection.Open();
										sqlCommand.ExecuteNonQuery();
										sqlConnection.Close();
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
						bool flag4 = num > 0;
						if (flag4)
						{
							MessageBox.Show(num.ToString() + " products set for upload.");
						}
						else
						{
							MessageBox.Show("No products set for upload.");
						}
					}
					else
					{
						MessageBox.Show("No changes made.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error resending prices. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0400081D RID: 2077
		private string _cnn;

		// Token: 0x0400081E RID: 2078
		private DataTable dat;

		// Token: 0x0400081F RID: 2079
		private DataTable dat_compare;

		// Token: 0x04000820 RID: 2080
		private PublicFunctions pf;
	}
}
