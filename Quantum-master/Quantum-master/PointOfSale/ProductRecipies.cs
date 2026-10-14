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
	// Token: 0x02000173 RID: 371
	[DesignerGenerated]
	public partial class ProductRecipies : UserControl
	{
		// Token: 0x060034AB RID: 13483 RVA: 0x001C746C File Offset: 0x001C566C
		public ProductRecipies()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.CurrentIDing = 0;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x001CB7D0 File Offset: 0x001C99D0
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x001CB7DC File Offset: 0x001C99DC
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

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x001CB81F File Offset: 0x001C9A1F
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x001CB829 File Offset: 0x001C9A29
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x001CB832 File Offset: 0x001C9A32
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x001CB83C File Offset: 0x001C9A3C
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x001CB845 File Offset: 0x001C9A45
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x001CB84F File Offset: 0x001C9A4F
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x001CB858 File Offset: 0x001C9A58
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x001CB864 File Offset: 0x001C9A64
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

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x001CB8C2 File Offset: 0x001C9AC2
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x001CB8CC File Offset: 0x001C9ACC
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x001CB8D5 File Offset: 0x001C9AD5
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x001CB8E0 File Offset: 0x001C9AE0
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

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x001CB923 File Offset: 0x001C9B23
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x001CB92D File Offset: 0x001C9B2D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x001CB936 File Offset: 0x001C9B36
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x001CB940 File Offset: 0x001C9B40
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
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x001CB99E File Offset: 0x001C9B9E
		// (set) Token: 0x060034C1 RID: 13505 RVA: 0x001CB9A8 File Offset: 0x001C9BA8
		internal virtual Button cmdSelect
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSelect;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cmdSelect_Click);
				Button button = this._cmdSelect;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdSelect = value;
				button = this._cmdSelect;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x001CB9EB File Offset: 0x001C9BEB
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x001CB9F5 File Offset: 0x001C9BF5
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x001CB9FE File Offset: 0x001C9BFE
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x001CBA08 File Offset: 0x001C9C08
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x001CBA11 File Offset: 0x001C9C11
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x001CBA1B File Offset: 0x001C9C1B
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x001CBA24 File Offset: 0x001C9C24
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x001CBA2E File Offset: 0x001C9C2E
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x001CBA37 File Offset: 0x001C9C37
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x001CBA41 File Offset: 0x001C9C41
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x001CBA4A File Offset: 0x001C9C4A
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x001CBA54 File Offset: 0x001C9C54
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x001CBA5D File Offset: 0x001C9C5D
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x001CBA68 File Offset: 0x001C9C68
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

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x001CBAAB File Offset: 0x001C9CAB
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x001CBAB5 File Offset: 0x001C9CB5
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x060034D2 RID: 13522 RVA: 0x001CBABE File Offset: 0x001C9CBE
		// (set) Token: 0x060034D3 RID: 13523 RVA: 0x001CBAC8 File Offset: 0x001C9CC8
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x001CBAD1 File Offset: 0x001C9CD1
		// (set) Token: 0x060034D5 RID: 13525 RVA: 0x001CBADC File Offset: 0x001C9CDC
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

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x001CBB1F File Offset: 0x001C9D1F
		// (set) Token: 0x060034D7 RID: 13527 RVA: 0x001CBB29 File Offset: 0x001C9D29
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x001CBB32 File Offset: 0x001C9D32
		// (set) Token: 0x060034D9 RID: 13529 RVA: 0x001CBB3C File Offset: 0x001C9D3C
		internal virtual DataGridView dgvFormulas
		{
			[CompilerGenerated]
			get
			{
				return this._dgvFormulas;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvFormulas_CellContentClick);
				DataGridView dataGridView = this._dgvFormulas;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvFormulas = value;
				dataGridView = this._dgvFormulas;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x001CBB7F File Offset: 0x001C9D7F
		// (set) Token: 0x060034DB RID: 13531 RVA: 0x001CBB89 File Offset: 0x001C9D89
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x001CBB92 File Offset: 0x001C9D92
		// (set) Token: 0x060034DD RID: 13533 RVA: 0x001CBB9C File Offset: 0x001C9D9C
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

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x001CBBDF File Offset: 0x001C9DDF
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x001CBBE9 File Offset: 0x001C9DE9
		internal virtual TextBox txtFormulaName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x060034E0 RID: 13536 RVA: 0x001CBBF2 File Offset: 0x001C9DF2
		// (set) Token: 0x060034E1 RID: 13537 RVA: 0x001CBBFC File Offset: 0x001C9DFC
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x001CBC05 File Offset: 0x001C9E05
		// (set) Token: 0x060034E3 RID: 13539 RVA: 0x001CBC0F File Offset: 0x001C9E0F
		internal virtual TextBox ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x001CBC18 File Offset: 0x001C9E18
		// (set) Token: 0x060034E5 RID: 13541 RVA: 0x001CBC22 File Offset: 0x001C9E22
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x001CBC2B File Offset: 0x001C9E2B
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x001CBC35 File Offset: 0x001C9E35
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x001CBC3E File Offset: 0x001C9E3E
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x001CBC48 File Offset: 0x001C9E48
		internal virtual TextBox ProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x001CBC51 File Offset: 0x001C9E51
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x001CBC5B File Offset: 0x001C9E5B
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x001CBC64 File Offset: 0x001C9E64
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x001CBC6E File Offset: 0x001C9E6E
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x001CBC77 File Offset: 0x001C9E77
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x001CBC84 File Offset: 0x001C9E84
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

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x001CBCE2 File Offset: 0x001C9EE2
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x001CBCEC File Offset: 0x001C9EEC
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x001CBCF5 File Offset: 0x001C9EF5
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x001CBD00 File Offset: 0x001C9F00
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

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x001CBD43 File Offset: 0x001C9F43
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x001CBD4D File Offset: 0x001C9F4D
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x001CBD56 File Offset: 0x001C9F56
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x001CBD60 File Offset: 0x001C9F60
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
				EventHandler eventHandler = new EventHandler(this.TextBox2_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsearch2_KeyDown);
				TextBox textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtsearch2 = value;
				textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x001CBDBE File Offset: 0x001C9FBE
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x001CBDC8 File Offset: 0x001C9FC8
		internal virtual TextBox txtComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x001CBDD1 File Offset: 0x001C9FD1
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x001CBDDB File Offset: 0x001C9FDB
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x001CBDE4 File Offset: 0x001C9FE4
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x001CBDF0 File Offset: 0x001C9FF0
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvIngridients_CellContentClick);
				DataGridView dataGridView = this._dgvIngridients;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvIngridients = value;
				dataGridView = this._dgvIngridients;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x001CBE33 File Offset: 0x001CA033
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x001CBE3D File Offset: 0x001CA03D
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x001CBE46 File Offset: 0x001CA046
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x001CBE50 File Offset: 0x001CA050
		internal virtual TextBox txtStockAvail2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x001CBE59 File Offset: 0x001CA059
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x001CBE63 File Offset: 0x001CA063
		internal virtual TextBox txtDesc2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x001CBE6C File Offset: 0x001CA06C
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x001CBE76 File Offset: 0x001CA076
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x001CBE7F File Offset: 0x001CA07F
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x001CBE8C File Offset: 0x001CA08C
		internal virtual Button cmdAddIngridient
		{
			[CompilerGenerated]
			get
			{
				return this._cmdAddIngridient;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cmdAddIngridient_Click);
				Button button = this._cmdAddIngridient;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdAddIngridient = value;
				button = this._cmdAddIngridient;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x001CBECF File Offset: 0x001CA0CF
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x001CBEDC File Offset: 0x001CA0DC
		internal virtual TextBox txtQTYR
		{
			[CompilerGenerated]
			get
			{
				return this._txtQTYR;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQTYR_KeyPress);
				TextBox textBox = this._txtQTYR;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQTYR = value;
				textBox = this._txtQTYR;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x001CBF1F File Offset: 0x001CA11F
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x001CBF29 File Offset: 0x001CA129
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x001CBF32 File Offset: 0x001CA132
		// (set) Token: 0x0600350D RID: 13581 RVA: 0x001CBF3C File Offset: 0x001CA13C
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x001CBF45 File Offset: 0x001CA145
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x001CBF4F File Offset: 0x001CA14F
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x001CBF58 File Offset: 0x001CA158
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x001CBF64 File Offset: 0x001CA164
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
				TextBox textBox = this._txtBarCode2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtBarCode2 = value;
				textBox = this._txtBarCode2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x001CBFA7 File Offset: 0x001CA1A7
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x001CBFB1 File Offset: 0x001CA1B1
		internal virtual Label lblcode2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x001CBFBA File Offset: 0x001CA1BA
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x001CBFC4 File Offset: 0x001CA1C4
		internal virtual Label lblerror2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x001CBFCD File Offset: 0x001CA1CD
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x001CBFD8 File Offset: 0x001CA1D8
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

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x001CC01B File Offset: 0x001CA21B
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x001CC028 File Offset: 0x001CA228
		internal virtual TextBox txtSelectedFormula
		{
			[CompilerGenerated]
			get
			{
				return this._txtSelectedFormula;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSelectedFormula_TextChanged);
				TextBox textBox = this._txtSelectedFormula;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSelectedFormula = value;
				textBox = this._txtSelectedFormula;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x001CC06B File Offset: 0x001CA26B
		// (set) Token: 0x0600351B RID: 13595 RVA: 0x001CC075 File Offset: 0x001CA275
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x001CC07E File Offset: 0x001CA27E
		// (set) Token: 0x0600351D RID: 13597 RVA: 0x001CC088 File Offset: 0x001CA288
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

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x001CC0CB File Offset: 0x001CA2CB
		// (set) Token: 0x0600351F RID: 13599 RVA: 0x001CC0D8 File Offset: 0x001CA2D8
		internal virtual Label Label15
		{
			[CompilerGenerated]
			get
			{
				return this._Label15;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label15_Click);
				Label label = this._Label15;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label15 = value;
				label = this._Label15;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x001CC11B File Offset: 0x001CA31B
		// (set) Token: 0x06003521 RID: 13601 RVA: 0x001CC125 File Offset: 0x001CA325
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x001CC12E File Offset: 0x001CA32E
		// (set) Token: 0x06003523 RID: 13603 RVA: 0x001CC138 File Offset: 0x001CA338
		internal virtual CheckBox chkInclFinalProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x001CC141 File Offset: 0x001CA341
		// (set) Token: 0x06003525 RID: 13605 RVA: 0x001CC14B File Offset: 0x001CA34B
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x001CC154 File Offset: 0x001CA354
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x001CC15E File Offset: 0x001CA35E
		internal virtual TextBox txtSellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x001CC167 File Offset: 0x001CA367
		// (set) Token: 0x06003529 RID: 13609 RVA: 0x001CC171 File Offset: 0x001CA371
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x001CC17A File Offset: 0x001CA37A
		// (set) Token: 0x0600352B RID: 13611 RVA: 0x001CC184 File Offset: 0x001CA384
		internal virtual TextBox txtCalcCost
		{
			[CompilerGenerated]
			get
			{
				return this._txtCalcCost;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtCalcCost_TextChanged);
				TextBox textBox = this._txtCalcCost;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtCalcCost = value;
				textBox = this._txtCalcCost;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x001CC1C7 File Offset: 0x001CA3C7
		// (set) Token: 0x0600352D RID: 13613 RVA: 0x001CC1D1 File Offset: 0x001CA3D1
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x001CC1DA File Offset: 0x001CA3DA
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x001CC1E4 File Offset: 0x001CA3E4
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
				DataGridView dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvProducts = value;
				dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x001CC227 File Offset: 0x001CA427
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x001CC231 File Offset: 0x001CA431
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x001CC23A File Offset: 0x001CA43A
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x001CC244 File Offset: 0x001CA444
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

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x001CC287 File Offset: 0x001CA487
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x001CC291 File Offset: 0x001CA491
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x001CC29A File Offset: 0x001CA49A
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x001CC2A4 File Offset: 0x001CA4A4
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x001CC2AD File Offset: 0x001CA4AD
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x001CC2B7 File Offset: 0x001CA4B7
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x001CC2C0 File Offset: 0x001CA4C0
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x001CC2CA File Offset: 0x001CA4CA
		internal virtual TextBox txtMargin
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600353C RID: 13628 RVA: 0x001CC2D3 File Offset: 0x001CA4D3
		// (set) Token: 0x0600353D RID: 13629 RVA: 0x001CC2E0 File Offset: 0x001CA4E0
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

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x001CC323 File Offset: 0x001CA523
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x001CC32D File Offset: 0x001CA52D
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x001CC336 File Offset: 0x001CA536
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x001CC340 File Offset: 0x001CA540
		internal virtual TabPage TabPage4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x001CC349 File Offset: 0x001CA549
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x001CC354 File Offset: 0x001CA554
		internal virtual GroupBox GroupBox8
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox8_Enter);
				GroupBox groupBox = this._GroupBox8;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox8 = value;
				groupBox = this._GroupBox8;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x001CC397 File Offset: 0x001CA597
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x001CC3A4 File Offset: 0x001CA5A4
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

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x001CC3E7 File Offset: 0x001CA5E7
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x001CC3F1 File Offset: 0x001CA5F1
		internal virtual TextBox txtDescING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x001CC3FA File Offset: 0x001CA5FA
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x001CC404 File Offset: 0x001CA604
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x001CC40D File Offset: 0x001CA60D
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x001CC418 File Offset: 0x001CA618
		internal virtual DataGridView dgvSearchING
		{
			[CompilerGenerated]
			get
			{
				return this._dgvSearchING;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvSearchING_CellEnter);
				DataGridView dataGridView = this._dgvSearchING;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._dgvSearchING = value;
				dataGridView = this._dgvSearchING;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x001CC45B File Offset: 0x001CA65B
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x001CC465 File Offset: 0x001CA665
		internal virtual GroupBox GroupBox7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x001CC46E File Offset: 0x001CA66E
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x001CC478 File Offset: 0x001CA678
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

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x001CC4BB File Offset: 0x001CA6BB
		// (set) Token: 0x06003551 RID: 13649 RVA: 0x001CC4C5 File Offset: 0x001CA6C5
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x001CC4CE File Offset: 0x001CA6CE
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x001CC4D8 File Offset: 0x001CA6D8
		internal virtual TextBox txtSearchING
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchING;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchING_TextChanged);
				TextBox textBox = this._txtSearchING;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchING = value;
				textBox = this._txtSearchING;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x001CC51B File Offset: 0x001CA71B
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x001CC525 File Offset: 0x001CA725
		internal virtual GroupBox GroupBox9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x001CC52E File Offset: 0x001CA72E
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x001CC538 File Offset: 0x001CA738
		internal virtual DataGridView DgvLinkedRecipes
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x001CC541 File Offset: 0x001CA741
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x001CC54B File Offset: 0x001CA74B
		internal virtual Label lblerrorING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x001CC554 File Offset: 0x001CA754
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x001CC560 File Offset: 0x001CA760
		internal virtual TextBox txtSearchProductCodeING
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCodeING;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCodeING_TextChanged);
				TextBox textBox = this._txtSearchProductCodeING;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCodeING = value;
				textBox = this._txtSearchProductCodeING;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x001CC5A3 File Offset: 0x001CA7A3
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x001CC5B0 File Offset: 0x001CA7B0
		internal virtual Label Label26
		{
			[CompilerGenerated]
			get
			{
				return this._Label26;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label26_Click);
				Label label = this._Label26;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label26 = value;
				label = this._Label26;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x001CC5F3 File Offset: 0x001CA7F3
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x001CC5FD File Offset: 0x001CA7FD
		internal virtual CheckBox chkbackofficeonly
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x001CC608 File Offset: 0x001CA808
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

		// Token: 0x06003561 RID: 13665 RVA: 0x001CC690 File Offset: 0x001CA890
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

		// Token: 0x06003562 RID: 13666 RVA: 0x001CC788 File Offset: 0x001CA988
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
						dataTable = this.searchDB(text, new int?(0));
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

		// Token: 0x06003563 RID: 13667 RVA: 0x001CC898 File Offset: 0x001CAA98
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
						bool @checked = this.chkInclFinalProducts.Checked;
						if (@checked)
						{
							dataTable = this.searchDB(text, null);
						}
						else
						{
							dataTable = this.searchDB(text, new int?(1));
						}
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

		// Token: 0x06003564 RID: 13668 RVA: 0x001CC9D4 File Offset: 0x001CABD4
		private object searchDat(DataTable dt, string column, string value)
		{
			ProductRecipies._Closure$__374-0 CS$<>8__locals1 = new ProductRecipies._Closure$__374-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((ProductRecipies._Closure$__.$I374-0 == null) ? (ProductRecipies._Closure$__.$I374-0 = (object row1) => (DataRow)row1) : ProductRecipies._Closure$__.$I374-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06003565 RID: 13669 RVA: 0x001CCAB0 File Offset: 0x001CACB0
		private DataTable searchDB(string searchtext, int? isingridient)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", isingridient);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x001CCB50 File Offset: 0x001CAD50
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
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

		// Token: 0x06003567 RID: 13671 RVA: 0x001CCD40 File Offset: 0x001CAF40
		private void FetchAllProducts2()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			bool @checked = this.chkInclFinalProducts.Checked;
			if (@checked)
			{
				sqlCommand.Parameters.AddWithValue("isingridient", null);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("isingridient", 1);
			}
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

		// Token: 0x06003568 RID: 13672 RVA: 0x001CCF58 File Offset: 0x001CB158
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

		// Token: 0x06003569 RID: 13673 RVA: 0x001CCFB8 File Offset: 0x001CB1B8
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

		// Token: 0x0600356A RID: 13674 RVA: 0x001CD07C File Offset: 0x001CB27C
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.cmdSelect.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x001CD0DC File Offset: 0x001CB2DC
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

		// Token: 0x0600356C RID: 13676 RVA: 0x001CD184 File Offset: 0x001CB384
		private void SearchBarCode(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
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
				this.txtSellingPrice.Text = Conversions.ToString(dataRow["SellingPrice"]);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x001CD310 File Offset: 0x001CB510
		private void SearchBarCode2(int prodtID)
		{
			bool flag = prodtID != 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByID2";
				sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				bool @checked = this.chkInclFinalProducts.Checked;
				if (@checked)
				{
					sqlCommand.Parameters.AddWithValue("isingridient", null);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("isingridient", 1);
				}
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.txtDesc2.Text = Conversions.ToString(dataRow["ProductDesc"]);
					this.lblcode2.Text = Conversions.ToString(dataRow["ProductCode"]);
					this.CurrentID2 = Conversions.ToInteger(dataRow["ProductID"]);
					this.CurrentCode2 = Conversions.ToString(dataRow["ProductCode"]);
					this.CurrentDesc2 = Conversions.ToString(dataRow["ProductDesc"]);
					this.CurrentUOM = dataRow["UOM"].ToString();
					this.txtStockAvail2.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID2));
				}
				else
				{
					this.txtSearchProductCode2.Text = "";
				}
			}
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x001CD4CC File Offset: 0x001CB6CC
		private void SearchProductCode(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
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
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x001CD634 File Offset: 0x001CB834
		private void SearchProductCode2(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			bool @checked = this.chkInclFinalProducts.Checked;
			if (@checked)
			{
				sqlCommand.Parameters.AddWithValue("isingridient", null);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("isingridient", 1);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc2.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode2.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID2 = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode2 = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentDesc2 = Conversions.ToString(dataRow["ProductDesc"]);
				this.CurrentUOM = dataRow["UOM"].ToString();
				this.txtStockAvail2.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID2));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x001CD7DC File Offset: 0x001CB9DC
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

		// Token: 0x06003571 RID: 13681 RVA: 0x001CDA48 File Offset: 0x001CBC48
		private void cmdSelect_Click(object sender, EventArgs e)
		{
			try
			{
				this.ProductDesc.Text = this.CurrentDesc;
				this.ProductCode.Text = this.CurrentCode;
				this.TabControl1.SelectedIndex = 1;
				this.txtFormulaName.Focus();
				this.txtSelectedFormula.Text = "";
				this.LoadFormulas(MyProject.Forms.Form1.coid, this.CurrentID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading second tab. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x001CDAFC File Offset: 0x001CBCFC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.CreateFormulaName(this.txtFormulaName.Text, this.txtComment.Text, this.CurrentID, Conversions.ToInteger(Interaction.IIf(this.chkbackofficeonly.Checked, 1, 0)));
				this.LoadFormulas(MyProject.Forms.Form1.coid, this.CurrentID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error creating formula name. Details: " + ex.Message);
			}
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x001CDBA4 File Offset: 0x001CBDA4
		private void CreateFormulaName(string name, string comment, int productid, int backofficeonly)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewFormula";
			sqlCommand.Parameters.AddWithValue("formulaname", name);
			sqlCommand.Parameters.AddWithValue("formulacomment", comment);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donedate", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("backofficeonly", backofficeonly);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x001CDCCC File Offset: 0x001CBECC
		private void LoadFormulas(int coid, int productid)
		{
			this.dgvFormulas.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulas";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvFormulas.DataSource = dataTable;
				this.dgvFormulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Formula";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "View";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvFormulas.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Delete Formula";
				dataGridViewButtonColumn2.Text = "Delete";
				dataGridViewButtonColumn2.Name = "Delete";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvFormulas.Columns.Add(dataGridViewButtonColumn2);
				this.txtSelectedFormula.Text = this.dgvFormulas.Rows[0].Cells["FormulaName"].Value.ToString();
				this.LoadIngridients(MyProject.Forms.Form1.coid, this.dgvFormulas.Rows[0].Cells["FormulaName"].Value.ToString());
			}
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x001CDE8C File Offset: 0x001CC08C
		private void TextBox2_TextChanged(object sender, EventArgs e)
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

		// Token: 0x06003576 RID: 13686 RVA: 0x001CDF14 File Offset: 0x001CC114
		private void Button2_Click(object sender, EventArgs e)
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

		// Token: 0x06003577 RID: 13687 RVA: 0x001CDF74 File Offset: 0x001CC174
		private void dgvSearch2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.dgvSearch2.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode2.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror2.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x001CE038 File Offset: 0x001CC238
		private void dgvSearch2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtQTYR.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x001CE098 File Offset: 0x001CC298
		private void TextBox4_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail2.Text = Conversions.ToString(0);
				this.txtDesc2.Text = "No product matches your search.";
				this.SearchProductCode2(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x001CE140 File Offset: 0x001CC340
		private void txtSearchProductCode2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail2.Text = Conversions.ToString(0);
				this.txtQTYR.Text = Conversions.ToString(0);
				this.txtDesc2.Text = "No product matches your search.";
				this.SearchBarCode2(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode2.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode2.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x001CE208 File Offset: 0x001CC408
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

		// Token: 0x0600357C RID: 13692 RVA: 0x001CE2BC File Offset: 0x001CC4BC
		private void cmdAddIngridient_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtSelectedFormula.Text, "", false) != 0;
				if (flag)
				{
					bool flag2 = this.CurrentID2 != 0;
					if (flag2)
					{
						bool flag3 = Conversion.Val(this.txtQTYR.Text) > 0.0;
						if (flag3)
						{
							this.InsertIngridient(MyProject.Forms.Form1.coid, this.txtSelectedFormula.Text, this.CurrentID2, Conversions.ToDecimal(this.txtQTYR.Text));
							this.LoadIngridients(MyProject.Forms.Form1.coid, this.txtSelectedFormula.Text);
							MessageBox.Show("Ingridient succesfuly saved.");
							this.txtQTYR.Text = "";
							this.CurrentID2 = 0;
							bool flag4 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
							if (flag4)
							{
								this.txtsearch2.Focus();
							}
							else
							{
								this.txtBarCode2.Focus();
							}
						}
						else
						{
							MessageBox.Show("Please select the quantity first!");
						}
					}
					else
					{
						MessageBox.Show("Please select the product first!");
					}
				}
				else
				{
					MessageBox.Show("Please select a formula first!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving details. " + ex.Message);
			}
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x001CE444 File Offset: 0x001CC644
		private void InsertIngridient(int coid, string name, int productid, decimal qty)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertFormulaIngridient";
			sqlCommand.Parameters.AddWithValue("formulaname", name);
			sqlCommand.Parameters.AddWithValue("qty", qty);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donedate", DateTime.Today.ToString("yyyyMMdd"));
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x001CE54C File Offset: 0x001CC74C
		private void DeleteIngridient(int entryno, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteFormulaIngridient";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x001CE5E8 File Offset: 0x001CC7E8
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
			this.dgvIngridients.Columns["Entryno"].Visible = false;
			this.dgvIngridients.Columns["productid"].HeaderText = "Product ID";
			this.dgvIngridients.Columns["ProductDesc"].HeaderText = "Product Description";
			this.dgvIngridients.Columns["qty"].HeaderText = "Quantity for Formula";
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Item";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvIngridients.Columns.Add(dataGridViewButtonColumn);
			this.txtCalcCost.Text = this.pf.GetRecipeProductCost(MyProject.Forms.Form1.coid, this.CurrentID, this._cnn, MyProject.Forms.Form1.branch).ToString();
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x001CE78C File Offset: 0x001CC98C
		private void DeleteFormual(int coid, string formulaname)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteFormula";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("formulaname", formulaname);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x001CE820 File Offset: 0x001CCA20
		private void dgvFormulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
			if (flag)
			{
				bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
				if (flag2)
				{
					this.LoadIngridients(MyProject.Forms.Form1.coid, Conversions.ToString(this.dgvFormulas.Rows[e.RowIndex].Cells["FormulaName"].Value));
					this.txtSelectedFormula.Text = Conversions.ToString(this.dgvFormulas.Rows[e.RowIndex].Cells["FormulaName"].Value);
					this.txtCalcCost.Text = this.pf.GetRecipeProductCost(MyProject.Forms.Form1.coid, this.CurrentID, this._cnn, MyProject.Forms.Form1.branch).ToString();
				}
				else
				{
					bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag3)
					{
						this.DeleteFormual(MyProject.Forms.Form1.coid, Conversions.ToString(this.dgvFormulas.Rows[e.RowIndex].Cells["FormulaName"].Value));
						this.LoadFormulas(MyProject.Forms.Form1.coid, this.CurrentID);
						this.txtFormulaName.Focus();
					}
				}
			}
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label14_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label15_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x001CE9F8 File Offset: 0x001CCBF8
		private void dgvIngridients_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
			if (flag)
			{
				bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
				if (flag2)
				{
					this.DeleteIngridient(Conversions.ToInteger(this.dgvIngridients.Rows[e.RowIndex].Cells["Entryno"].Value), MyProject.Forms.Form1.coid);
					this.LoadIngridients(MyProject.Forms.Form1.coid, this.txtSelectedFormula.Text);
				}
			}
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x001CEACC File Offset: 0x001CCCCC
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag4;
			try
			{
				bool flag = msg.WParam.ToInt32() == 112;
				if (flag)
				{
					bool flag2 = this.TabControl1.SelectedTab.TabIndex == 0;
					if (flag2)
					{
						this.txtBarCode.Focus();
					}
					else
					{
						bool flag3 = this.TabControl1.SelectedTab.TabIndex == 1;
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

		// Token: 0x06003586 RID: 13702 RVA: 0x001CEB6C File Offset: 0x001CCD6C
		private void txtQTYR_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.CurrentUOM, "EA", false) == 0;
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

		// Token: 0x06003587 RID: 13703 RVA: 0x001CEC1C File Offset: 0x001CCE1C
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

		// Token: 0x06003588 RID: 13704 RVA: 0x001CECA4 File Offset: 0x001CCEA4
		private void txtsearch2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.dgvSearch2.Focus();
					e.Handled = true;
				}
				else
				{
					bool flag2 = e.KeyCode == Keys.Return;
					if (flag2)
					{
						this.lblerror.Text = "...";
						this.SearchByDescAdvanced2(this.txtsearch2.Text);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x001CED2C File Offset: 0x001CCF2C
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.TabControl1.SelectedIndex == 1;
				if (flag)
				{
					bool flag2 = this.CurrentID == 0;
					if (flag2)
					{
						MessageBox.Show("Please select the product to be made first.");
						this.TabControl1.SelectedTab = this.TabPage1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x001CEDB4 File Offset: 0x001CCFB4
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loadig products.");
			}
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x001CEDF8 File Offset: 0x001CCFF8
		private void LoadProducts()
		{
			this.dgvProducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvProducts.DataSource = dataTable;
				this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvProducts.Columns["CatDesc"].Visible = false;
				this.dgvProducts.Columns["Reorder_Level"].Visible = false;
				this.dgvProducts.Columns["ProductID"].Visible = false;
				this.dgvProducts.Columns["ProductCode"].Visible = false;
				this.dgvProducts.Columns["Tax_Percentage"].Visible = false;
				this.dgvProducts.Columns["Bin_Location"].Visible = false;
				this.dgvProducts.Columns["Unit_of_Measure"].Visible = false;
				this.dgvProducts.Columns["SpecialPrice"].Visible = false;
				this.dgvProducts.Columns.Add("RCostPrice", "Formula Cost Price");
				this.dgvProducts.Columns.Add("Margin", "Margin %");
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Recipe";
				dataGridViewButtonColumn.Text = "View Recipe";
				dataGridViewButtonColumn.Name = "View Recipe";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Add(dataGridViewButtonColumn);
				this.GetRecipeCostPrices();
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x001CF038 File Offset: 0x001CD238
		private void GetRecipeCostPrices()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = !dataGridViewRow.IsNewRow;
					if (flag)
					{
						dataGridViewRow.Cells["RCostPrice"].Value = this.pf.GetRecipeProductCost(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), this._cnn, MyProject.Forms.Form1.branch);
						int num = Conversions.ToInteger(dataGridViewRow.Cells["RCostPrice"].Value);
						bool flag2 = Conversions.ToInteger(dataGridViewRow.Cells["RCostPrice"].Value) != -1;
						if (flag2)
						{
							bool flag3 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["RCostPrice"].Value, 0, false);
							if (flag3)
							{
								dataGridViewRow.Cells["Margin"].Value = NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
								{
									Operators.MultiplyObject(Operators.DivideObject(Operators.SubtractObject(dataGridViewRow.Cells["Unit_Selling_Price"].Value, dataGridViewRow.Cells["RCostPrice"].Value), dataGridViewRow.Cells["RCostPrice"].Value), 100),
									2,
									MidpointRounding.AwayFromZero
								}, null, null, null).ToString() + "%";
							}
							else
							{
								dataGridViewRow.Cells["Margin"].Value = "0 cost";
							}
						}
						else
						{
							bool flag4 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["Unit_Cost"].Value, 0, false);
							if (flag4)
							{
								dataGridViewRow.Cells["Margin"].Value = NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
								{
									Operators.MultiplyObject(Operators.DivideObject(Operators.SubtractObject(dataGridViewRow.Cells["Unit_Selling_Price"].Value, dataGridViewRow.Cells["Unit_Cost"].Value), dataGridViewRow.Cells["Unit_Cost"].Value), 100),
									2,
									MidpointRounding.AwayFromZero
								}, null, null, null).ToString() + "%";
							}
							else
							{
								dataGridViewRow.Cells["Margin"].Value = "0 cost";
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

		// Token: 0x0600358D RID: 13709 RVA: 0x001CF360 File Offset: 0x001CD560
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View Recipe", false) == 0;
					if (flag2)
					{
						this.CurrentID = Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
						this.ProductDesc.Text = Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Product_Description"].Value);
						this.ProductCode.Text = Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["ProductCode"].Value);
						this.txtSellingPrice.Text = Conversions.ToString(this.dgvProducts.Rows[e.RowIndex].Cells["Unit_Selling_Price"].Value);
						this.TabControl1.SelectedIndex = 1;
						this.txtFormulaName.Focus();
						this.txtSelectedFormula.Text = "";
						this.LoadFormulas(MyProject.Forms.Form1.coid, this.CurrentID);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x001CF544 File Offset: 0x001CD744
		private void txtCalcCost_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtMargin.Text = Math.Round((Conversion.Val(this.txtSellingPrice.Text) - Conversion.Val(this.txtCalcCost.Text)) / Conversion.Val(this.txtCalcCost.Text) * 100.0, 2, MidpointRounding.AwayFromZero).ToString() + "%";
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x001CF5D8 File Offset: 0x001CD7D8
		private void Button5_Click(object sender, EventArgs e)
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

		// Token: 0x06003590 RID: 13712 RVA: 0x001CF690 File Offset: 0x001CD890
		private void txtSelectedFormula_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtSelectedFormula.Text, "", false) == 0;
				if (flag)
				{
					DataTable dataTable = new DataTable();
					this.dgvIngridients.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x001CF6F4 File Offset: 0x001CD8F4
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentIDing != 0;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "FindFormulaForIngridient";
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("productid", this.CurrentIDing);
					DataTable dataTable = new DataTable();
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					int num = sqlDataAdapter.Fill(dataTable);
					bool flag2 = num > 0;
					if (flag2)
					{
						this.DgvLinkedRecipes.DataSource = dataTable;
						this.GroupBox9.Text = "Linked Recipes for " + this.txtDescING.Text;
					}
					else
					{
						DataTable dataTable2 = new DataTable();
						this.DgvLinkedRecipes.DataSource = dataTable2;
						this.GroupBox9.Text = "Linked Recipes";
					}
				}
				else
				{
					MessageBox.Show("Please select a product first.");
					DataTable dataTable3 = new DataTable();
					this.DgvLinkedRecipes.DataSource = dataTable3;
					this.GroupBox9.Text = "Linked Recipes";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error fetching data. Detail: ");
			}
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x001CF868 File Offset: 0x001CDA68
		private void txtSearchING_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerrorING.Text = "...";
					this.SearchByDescAdvancedING(this.txtSearchING.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x001CF8F0 File Offset: 0x001CDAF0
		private void SearchByDescAdvancedING(string searchtext)
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
						dataTable = this.searchDBING(text, new int?(0));
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
					this.dgvSearchING.DataSource = dataTable;
					this.dgvSearchING.Columns["ProductCode"].Visible = false;
					this.dgvSearchING.Columns["ProductID"].Visible = false;
					this.dgvSearchING.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					this.lblerrorING.Text = "No products match your search.";
				}
			}
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox8_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x001CFA00 File Offset: 0x001CDC00
		private void dgvSearchING_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.dgvSearchING.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCodeING.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerrorING.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x001CFAC4 File Offset: 0x001CDCC4
		private void txtSearchProductCodeING_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtDescING.Text = "No product matches your search.";
				this.SearchBarCodeING(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCodeING.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCodeING.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x001CFB68 File Offset: 0x001CDD68
		private void SearchBarCodeING(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", null);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDescING.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.CurrentIDing = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x001CFC64 File Offset: 0x001CDE64
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProductsING();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x001CFCC4 File Offset: 0x001CDEC4
		private void FetchAllProductsING()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", null);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvSearchING.DataSource = dataTable;
				this.dgvSearchING.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvSearchING.Columns["CatDesc"].Visible = false;
				this.dgvSearchING.Columns["Reorder_Level"].Visible = false;
				this.dgvSearchING.Columns["Unit_Selling_Price"].Visible = false;
				this.dgvSearchING.Columns["Unit_Cost"].Visible = false;
				this.dgvSearchING.Columns["ProductID"].Visible = false;
				this.dgvSearchING.Columns["ProductCode"].Visible = false;
				this.dgvSearchING.Columns["Tax_Percentage"].Visible = false;
				this.dgvSearchING.Columns["Bin_Location"].Visible = false;
				this.dgvSearchING.Columns["Unit_of_Measure"].Visible = false;
				this.dgvSearchING.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerrorING.Text = "No products match your search.";
			}
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x001CFEB0 File Offset: 0x001CE0B0
		private DataTable searchDBING(string searchtext, int? isingridient)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", null);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label26_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x040016E6 RID: 5862
		private string _cnn;

		// Token: 0x040016E7 RID: 5863
		private int CurrentID;

		// Token: 0x040016E8 RID: 5864
		private string CurrentCode;

		// Token: 0x040016E9 RID: 5865
		private string CurrentDesc;

		// Token: 0x040016EA RID: 5866
		private int CurrentID2;

		// Token: 0x040016EB RID: 5867
		private string CurrentCode2;

		// Token: 0x040016EC RID: 5868
		private string CurrentDesc2;

		// Token: 0x040016ED RID: 5869
		private string CurrentUOM;

		// Token: 0x040016EE RID: 5870
		private int CurrentIDing;

		// Token: 0x040016EF RID: 5871
		private PublicFunctions pf;
	}
}
