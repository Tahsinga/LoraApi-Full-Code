using System;
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
	// Token: 0x0200004D RID: 77
	[DesignerGenerated]
	public partial class EditProductCaseSettings : UserControl
	{
		// Token: 0x06001027 RID: 4135 RVA: 0x00098774 File Offset: 0x00096974
		public EditProductCaseSettings()
		{
			base.Load += this.EditProductCaseSettings_Load;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00099F53 File Offset: 0x00098153
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00099F5D File Offset: 0x0009815D
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00099F66 File Offset: 0x00098166
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00099F70 File Offset: 0x00098170
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00099F79 File Offset: 0x00098179
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x00099F83 File Offset: 0x00098183
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00099F8C File Offset: 0x0009818C
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x00099F98 File Offset: 0x00098198
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00099FDB File Offset: 0x000981DB
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00099FE8 File Offset: 0x000981E8
		internal virtual ComboBox cboProductsParents
		{
			[CompilerGenerated]
			get
			{
				return this._cboProductsParents;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboProductsParents_TextChanged);
				EventHandler eventHandler2 = new EventHandler(this.cboProductsParents_SelectedIndexChanged);
				ComboBox comboBox = this._cboProductsParents;
				if (comboBox != null)
				{
					comboBox.TextChanged -= eventHandler;
					comboBox.SelectedIndexChanged -= eventHandler2;
				}
				this._cboProductsParents = value;
				comboBox = this._cboProductsParents;
				if (comboBox != null)
				{
					comboBox.TextChanged += eventHandler;
					comboBox.SelectedIndexChanged += eventHandler2;
				}
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0009A046 File Offset: 0x00098246
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x0009A050 File Offset: 0x00098250
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0009A059 File Offset: 0x00098259
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x0009A064 File Offset: 0x00098264
		internal virtual TextBox txtCaseQty
		{
			[CompilerGenerated]
			get
			{
				return this._txtCaseQty;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCaseQty_KeyPress);
				TextBox textBox = this._txtCaseQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCaseQty = value;
				textBox = this._txtCaseQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0009A0A7 File Offset: 0x000982A7
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x0009A0B1 File Offset: 0x000982B1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0009A0BA File Offset: 0x000982BA
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x0009A0C4 File Offset: 0x000982C4
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0009A107 File Offset: 0x00098307
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x0009A111 File Offset: 0x00098311
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0009A11A File Offset: 0x0009831A
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x0009A124 File Offset: 0x00098324
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0009A12D File Offset: 0x0009832D
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x0009A138 File Offset: 0x00098338
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
				EventHandler eventHandler2 = new EventHandler(this.cboProducts_SelectedIndexChanged);
				ComboBox comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.TextChanged -= eventHandler;
					comboBox.SelectedIndexChanged -= eventHandler2;
				}
				this._cboProducts = value;
				comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.TextChanged += eventHandler;
					comboBox.SelectedIndexChanged += eventHandler2;
				}
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0009A196 File Offset: 0x00098396
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x0009A1A0 File Offset: 0x000983A0
		internal virtual DataGridView dgvProductsChild
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0009A1A9 File Offset: 0x000983A9
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x0009A1B4 File Offset: 0x000983B4
		internal virtual Button btnRemoveParent
		{
			[CompilerGenerated]
			get
			{
				return this._btnRemoveParent;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._btnRemoveParent;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnRemoveParent = value;
				button = this._btnRemoveParent;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0009A1F7 File Offset: 0x000983F7
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0009A204 File Offset: 0x00098404
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0009A247 File Offset: 0x00098447
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0009A254 File Offset: 0x00098454
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0009A297 File Offset: 0x00098497
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x0009A2A4 File Offset: 0x000984A4
		internal virtual ListBox ListBox2
		{
			[CompilerGenerated]
			get
			{
				return this._ListBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListBox2_SelectedIndexChanged);
				ListBox listBox = this._ListBox2;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= eventHandler;
				}
				this._ListBox2 = value;
				listBox = this._ListBox2;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0009A2E7 File Offset: 0x000984E7
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0009A2F1 File Offset: 0x000984F1
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0009A2FA File Offset: 0x000984FA
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0009A304 File Offset: 0x00098504
		internal virtual TextBox txtParentCaseQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0009A30D File Offset: 0x0009850D
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x0009A317 File Offset: 0x00098517
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0009A320 File Offset: 0x00098520
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x0009A32A File Offset: 0x0009852A
		internal virtual Label lblParentInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0009A333 File Offset: 0x00098533
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x0009A33D File Offset: 0x0009853D
		internal virtual CheckBox chkUpdateParent
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x0009A346 File Offset: 0x00098546
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x0009A350 File Offset: 0x00098550
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0009A393 File Offset: 0x00098593
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x0009A3A0 File Offset: 0x000985A0
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x0009A3E3 File Offset: 0x000985E3
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x0009A3ED File Offset: 0x000985ED
		internal virtual Label lblStockBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0009A3F6 File Offset: 0x000985F6
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x0009A400 File Offset: 0x00098600
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
				EventHandler eventHandler = new EventHandler(this.Button2_Click_1);
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

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0009A443 File Offset: 0x00098643
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x0009A44D File Offset: 0x0009864D
		internal virtual Label lblStockBal2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0009A456 File Offset: 0x00098656
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x0009A460 File Offset: 0x00098660
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x0009A4A3 File Offset: 0x000986A3
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x0009A4AD File Offset: 0x000986AD
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0009A4B6 File Offset: 0x000986B6
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x0009A4C0 File Offset: 0x000986C0
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0009A4C9 File Offset: 0x000986C9
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x0009A4D3 File Offset: 0x000986D3
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x0009A4DC File Offset: 0x000986DC
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x0009A4E6 File Offset: 0x000986E6
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0009A4EF File Offset: 0x000986EF
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x0009A4F9 File Offset: 0x000986F9
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0009A502 File Offset: 0x00098702
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x0009A50C File Offset: 0x0009870C
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0009A515 File Offset: 0x00098715
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x0009A520 File Offset: 0x00098720
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

		// Token: 0x06001070 RID: 4208 RVA: 0x0009A564 File Offset: 0x00098764
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.cboProductsParents.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error changing setting: " + ex.Message);
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0009A5B8 File Offset: 0x000987B8
		private void EditProductCaseSettings_Load(object sender, EventArgs e)
		{
			try
			{
				this.productsDatatable = this.pf.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
				this.cboProductsParents.DataSource = this.productsDatatable;
				this.cboProductsParents.ValueMember = "productid";
				this.cboProductsParents.DisplayMember = "productdesc";
				this.cboProductsParents.SelectedIndex = -1;
				this.cboProducts.DataSource = this.pf.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
				this.cboProducts.ValueMember = "ProductID";
				this.cboProducts.DisplayMember = "ProductDesc";
				this.cboProducts.SelectedIndex = -1;
				bool flag = MyProject.Forms.Form1.autoBreakCase == 1;
				if (flag)
				{
					this.lblinfo.Text = "Auto break case is turned on.";
					this.lblinfo.ForeColor = Color.Lime;
				}
				else
				{
					this.lblinfo.Text = "Auto break case is turned off. AUTO BREAK CASE WILL NOT WORK DURING SALE";
					this.lblinfo.ForeColor = Color.Red;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0009A72C File Offset: 0x0009892C
		private void cboProducts_TextChanged(object sender, EventArgs e)
		{
			try
			{
				EditProductCaseSettings._Closure$__149-0 CS$<>8__locals1 = new EditProductCaseSettings._Closure$__149-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$Local_textToSearch = this.cboProducts.Text.ToLower();
				this.ListBox1.Visible = false;
				bool flag = string.IsNullOrEmpty(CS$<>8__locals1.$VB$Local_textToSearch);
				if (!flag)
				{
					var list = this.productsDatatable.AsEnumerable().Select((EditProductCaseSettings._Closure$__.$I149-0 == null) ? (EditProductCaseSettings._Closure$__.$I149-0 = (DataRow p) => new
					{
						ID = p.Field<int>("productid"),
						Name = p.Field<string>("productdesc")
					}) : EditProductCaseSettings._Closure$__.$I149-0).ToList();
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

		// Token: 0x06001073 RID: 4211 RVA: 0x0009A890 File Offset: 0x00098A90
		private void Label4_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0009A8C8 File Offset: 0x00098AC8
		private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.GetProductDetails();
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0009A8D4 File Offset: 0x00098AD4
		private void GetProductDetails()
		{
			try
			{
				DataRow productDetails = this.pf.getProductDetails(MyProject.Forms.Form1.coid, Conversions.ToInteger(this.cboProducts.SelectedValue), this._cnn);
				string text = Conversions.ToString(productDetails["productdesc"]);
				bool flag = Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["iscase"]));
				if (flag)
				{
					this.chkIsCase.Checked = false;
					this.chkIsBoth.Checked = false;
				}
				this.chkIsCase.Checked = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["iscase"])), false, RuntimeHelpers.GetObjectValue(productDetails["iscase"])));
				bool flag2 = Operators.ConditionalCompareObjectEqual(productDetails["iscase"], 0, false);
				if (flag2)
				{
					this.chkIsCase.Checked = false;
					this.chkIsBoth.Checked = false;
				}
				else
				{
					bool flag3 = Operators.ConditionalCompareObjectEqual(productDetails["iscase"], 1, false);
					if (flag3)
					{
						this.chkIsCase.Checked = true;
						this.chkIsBoth.Checked = false;
					}
					else
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(productDetails["iscase"], 2, false);
						if (flag4)
						{
							this.chkIsCase.Checked = false;
							this.chkIsBoth.Checked = true;
						}
					}
				}
				int num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["caseparentproductid"])), 0, RuntimeHelpers.GetObjectValue(productDetails["caseparentproductid"])));
				DataRow productDetails2 = this.pf.getProductDetails(MyProject.Forms.Form1.coid, num, this._cnn);
				try
				{
					int num2 = this.cboProductsParents.FindStringExact(Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails2["productdesc"])), "", RuntimeHelpers.GetObjectValue(productDetails2["productdesc"]))));
					bool flag5 = num2 >= 0;
					if (flag5)
					{
						this.cboProductsParents.SelectedIndex = num2;
					}
					else
					{
						this.cboProductsParents.SelectedIndex = -1;
					}
				}
				catch (Exception ex)
				{
					this.cboProductsParents.SelectedIndex = -1;
				}
				this.txtCaseQty.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])), 0, RuntimeHelpers.GetObjectValue(productDetails["CaseQty"])));
				this.lblStockBal.Text = "";
				this.lblStockBal2.Text = "";
			}
			catch (Exception ex2)
			{
				this.lblStockBal.Text = "";
				this.lblStockBal2.Text = "";
				this.cboProductsParents.SelectedIndex = -1;
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0009AC0C File Offset: 0x00098E0C
		private void GetAllProductChild()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetAllChildProducts";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvProductsChild.DataSource = dataTable;
			this.dgvProductsChild.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0009AC98 File Offset: 0x00098E98
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				bool flag = this.cboProductsParents.SelectedIndex == -1;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = Conversions.ToInteger(this.cboProductsParents.SelectedValue);
				}
				int num2 = Conversions.ToInteger(Interaction.IIf(this.cboProducts.SelectedIndex == -1, 0, RuntimeHelpers.GetObjectValue(this.cboProducts.SelectedValue)));
				int num3 = 0;
				bool @checked = this.chkIsCase.Checked;
				if (@checked)
				{
					num3 = 1;
					bool flag2 = Conversion.Val(this.txtCaseQty.Text) == 0.0;
					if (flag2)
					{
						MessageBox.Show("Please enter a valid case quantity first.");
						this.txtCaseQty.Focus();
						return;
					}
				}
				else
				{
					bool checked2 = this.chkIsBoth.Checked;
					if (checked2)
					{
						num3 = 2;
					}
					else
					{
						bool flag3 = !this.chkIsCase.Checked & !this.chkIsBoth.Checked;
						if (flag3)
						{
							num3 = 0;
						}
					}
				}
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"update products set iscase=",
					Conversions.ToString(num3),
					" ,caseqty=",
					Conversions.ToString(Conversion.Val(this.txtCaseQty.Text)),
					" ,caseparentproductid=",
					Conversions.ToString(num),
					" where coid=",
					Conversions.ToString(MyProject.Forms.Form1.coid),
					" and productid=",
					Conversions.ToString(num2)
				});
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				bool checked3 = this.chkUpdateParent.Checked;
				if (checked3)
				{
					SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
					SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
					sqlCommand2.CommandType = CommandType.Text;
					bool flag4 = this.cboProductsParents.SelectedIndex == -1;
					int num4;
					if (flag4)
					{
						num4 = 0;
					}
					else
					{
						num4 = Conversions.ToInteger(this.cboProductsParents.SelectedValue);
					}
					sqlCommand2.CommandText = string.Concat(new string[]
					{
						"update products set iscase=1,caseqty=",
						Conversions.ToString(Conversion.Val(this.txtParentCaseQty.Text)),
						" where coid=",
						Conversions.ToString(MyProject.Forms.Form1.coid),
						" and productid=",
						Conversions.ToString(num4)
					});
					using (sqlConnection3)
					{
						sqlConnection3.Open();
						sqlCommand2.ExecuteNonQuery();
						sqlConnection3.Close();
					}
				}
				this.txtParentCaseQty.Enabled = false;
				MessageBox.Show("Changes saved successfully.");
				this.lblStockBal.Text = "";
				this.lblStockBal2.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving changes. Details: " + ex.Message);
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtCaseQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0009B00C File Offset: 0x0009920C
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

		// Token: 0x0600107A RID: 4218 RVA: 0x0009B088 File Offset: 0x00099288
		private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboProductsParents.SelectedIndex = this.cboProductsParents.FindStringExact(this.ListBox2.SelectedItem.ToString());
				this.ListBox2.Visible = false;
				this.ShowParentDetails(Conversions.ToInteger(this.cboProductsParents.SelectedValue), MyProject.Forms.Form1.coid);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting from list. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0009B12C File Offset: 0x0009932C
		private void cboProductsParents_TextChanged(object sender, EventArgs e)
		{
			try
			{
				EditProductCaseSettings._Closure$__158-0 CS$<>8__locals1 = new EditProductCaseSettings._Closure$__158-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$Local_textToSearch = this.cboProductsParents.Text.ToLower();
				this.ListBox2.Visible = false;
				bool flag = string.IsNullOrEmpty(CS$<>8__locals1.$VB$Local_textToSearch);
				if (!flag)
				{
					var list = this.productsDatatable.AsEnumerable().Select((EditProductCaseSettings._Closure$__.$I158-0 == null) ? (EditProductCaseSettings._Closure$__.$I158-0 = (DataRow p) => new
					{
						ID = p.Field<int>("productid"),
						Name = p.Field<string>("productdesc")
					}) : EditProductCaseSettings._Closure$__.$I158-0).ToList();
					var list2 = list.Where(x => x.Name.ToLower().Contains(CS$<>8__locals1.$VB$Local_textToSearch)).ToList();
					bool flag2 = list2.Count == 0;
					if (!flag2)
					{
						this.ListBox2.Items.Clear();
						try
						{
							foreach (var anon in list2)
							{
								this.ListBox2.Items.Add(anon.Name);
							}
						}
						finally
						{
							var enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.ListBox2.Visible = true;
						this.ShowParentDetails(Conversions.ToInteger(this.cboProductsParents.SelectedValue), MyProject.Forms.Form1.coid);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0009B2B8 File Offset: 0x000994B8
		private void ShowParentDetails(int parentproductid, int coid)
		{
			this.lblStockBal.Text = "";
			this.lblStockBal2.Text = "";
			this.lblParentInfo.Visible = true;
			this.txtParentCaseQty.Visible = true;
			this.Label5.Visible = true;
			this.chkUpdateParent.Visible = true;
			this.lblParentInfo.Text = "...";
			this.txtParentCaseQty.Text = "0";
			DataRow productDetails = this.pf.getProductDetails(coid, parentproductid, this._cnn);
			bool flag = Conversions.ToBoolean(productDetails["iscase"]);
			int num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(productDetails["iscase"])), 0, RuntimeHelpers.GetObjectValue(productDetails["caseqty"])));
			bool flag2 = flag;
			if (flag2)
			{
				this.lblParentInfo.Text = "Parent product is already marked as a case.";
				this.txtParentCaseQty.Text = num.ToString();
				bool flag3 = num == 0;
				if (flag3)
				{
					MessageBox.Show("Parent product is marked as a case but has no quantity for the case. Please enter the number of units in the case.");
					this.txtParentCaseQty.Focus();
					this.txtParentCaseQty.Enabled = true;
					this.chkUpdateParent.Checked = true;
				}
				else
				{
					this.txtParentCaseQty.Enabled = false;
					this.chkUpdateParent.Checked = false;
				}
			}
			else
			{
				this.lblParentInfo.Text = "Parent product is NOT set as case/parent.";
				this.txtParentCaseQty.Text = num.ToString();
				this.chkUpdateParent.Checked = true;
				this.txtParentCaseQty.Enabled = true;
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0009B464 File Offset: 0x00099664
		private void chkIsCase_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsCase.Checked;
				if (@checked)
				{
					this.lblParentInfo.Visible = false;
					this.txtParentCaseQty.Visible = false;
					this.Label5.Visible = false;
					this.lblParentInfo.Text = "...";
					this.txtParentCaseQty.Text = "0";
					this.chkUpdateParent.Checked = false;
					this.chkIsBoth.Checked = false;
					this.cboProductsParents.Visible = false;
					this.Label3.Visible = false;
					this.btnRemoveParent.Visible = false;
				}
				else
				{
					this.lblParentInfo.Visible = true;
					this.txtParentCaseQty.Visible = true;
					this.Label5.Visible = true;
					this.lblParentInfo.Text = "...";
					this.txtParentCaseQty.Text = "0";
					this.chkUpdateParent.Checked = true;
					this.cboProductsParents.Visible = true;
					this.Label3.Visible = true;
					this.btnRemoveParent.Visible = true;
					this.txtCaseQty.Text = "0";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0009B5D4 File Offset: 0x000997D4
		private void cboProductsParents_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.ShowParentDetails(Conversions.ToInteger(this.cboProductsParents.SelectedValue), MyProject.Forms.Form1.coid);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0009B62C File Offset: 0x0009982C
		private void chkIsBoth_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsBoth.Checked;
				if (@checked)
				{
					this.chkIsCase.Checked = false;
					this.cboProductsParents.Visible = true;
					this.Label3.Visible = true;
					this.btnRemoveParent.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0009B6A8 File Offset: 0x000998A8
		private void Button2_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.lblStockBal.Text = this.pf.GetStockBalSimple(this._cnn, Conversions.ToInteger(this.cboProducts.SelectedValue), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0009B72C File Offset: 0x0009992C
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblStockBal2.Text = this.pf.GetStockBalSimple(this._cnn, Conversions.ToInteger(this.cboProductsParents.SelectedValue), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0009B7B0 File Offset: 0x000999B0
		private void Button3_Click(object sender, EventArgs e)
		{
			bool flag = this.cboProductsParents.SelectedIndex < 0;
			if (flag)
			{
				MessageBox.Show("There is no parent product selected. Operation Cancelled.");
			}
			else
			{
				string text = "Enter quantity of Parent (Case) Product to be broken";
				string text2 = "Quantity to be broken";
				string text3 = "0";
				string text4 = Interaction.InputBox(text, text2, text3, -1, -1);
				try
				{
					bool flag2 = Conversions.ToInteger(text4) == 0;
					if (flag2)
					{
						MessageBox.Show("No quantity entered. Operation cancelled.");
						return;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Please enter a valid quantity.");
					return;
				}
				int num = Conversions.ToInteger(text4);
				bool flag3 = (Operators.CompareString(this.txtParentCaseQty.Text, "", false) == 0) | (Conversions.ToInteger(this.txtParentCaseQty.Text) == 0);
				if (flag3)
				{
					MessageBox.Show("Parent product case quantity is not set. Operation cancelled");
				}
				else
				{
					int num2 = Conversions.ToInteger(this.txtParentCaseQty.Text);
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox(string.Concat(new string[]
					{
						"Do you want to break ",
						this.cboProductsParents.Text,
						" x ",
						num.ToString(),
						" to make ",
						this.cboProducts.Text,
						"?"
					}), MsgBoxStyle.YesNo, null);
					bool flag4 = dialogResult == DialogResult.Yes;
					if (flag4)
					{
						bool flag5 = decimal.Compare(new decimal(num), this.pf.GetStockBalSimple(this._cnn, Conversions.ToInteger(this.cboProductsParents.SelectedValue), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch)) > 0;
						if (flag5)
						{
							bool flag6 = MyProject.Forms.Form1.NegativeStock == 0;
							if (flag6)
							{
								MessageBox.Show("Cannot break parent that has lower stock that the quantity to be broken.");
								return;
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
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "GetProductConvertedNumber";
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
							int coid = MyProject.Forms.Form1.coid;
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("newconvertednum", 0);
							int num3 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertProductsConverted";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("formulaname", "Auto Break Case");
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case");
							sqlCommand.Parameters.AddWithValue("QTYCalculated", num);
							sqlCommand.Parameters.AddWithValue("QTYActual", num);
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(this.cboProducts.SelectedValue));
							sqlCommand.Parameters.AddWithValue("type", "BREAK");
							sqlCommand.Parameters.AddWithValue("convertedproductid", RuntimeHelpers.GetObjectValue(this.cboProductsParents.SelectedValue));
							sqlCommand.Parameters.AddWithValue("invnumber", num3);
							sqlCommand.ExecuteNonQuery();
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "InsertNewStock2Warehouse";
							sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("invoicenum", num3);
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(this.cboProductsParents.SelectedValue));
							sqlCommand.Parameters.AddWithValue("isstockin", 0);
							sqlCommand.Parameters.AddWithValue("ref", "Auto Break Case parent");
							sqlCommand.Parameters.AddWithValue("quantity", num);
							sqlCommand.Parameters.AddWithValue("cost", 0);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("donewhen", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("trancode", 9);
							sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(this.cboProductsParents.SelectedValue), this._cnn));
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("BatchNumber", "");
							sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
							sqlCommand.Parameters.AddWithValue("suppliername", "");
							sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
							sqlCommand.ExecuteNonQuery();
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "InsertNewStock2Warehouse";
							sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("invoicenum", num3);
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(this.cboProducts.SelectedValue));
							sqlCommand.Parameters.AddWithValue("isstockin", 1);
							sqlCommand.Parameters.AddWithValue("ref", "Auto Break case child");
							sqlCommand.Parameters.AddWithValue("quantity", checked(num * num2));
							sqlCommand.Parameters.AddWithValue("cost", 0);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("donewhen", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("trancode", 9);
							sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(this.cboProducts.SelectedValue), this._cnn));
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("BatchNumber", "");
							sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
							sqlCommand.Parameters.AddWithValue("suppliername", "");
							sqlCommand.Parameters.AddWithValue("sellingprice", 0);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
							sqlCommand.ExecuteNonQuery();
							sqlTransaction.Commit();
							sqlConnection.Close();
							MessageBox.Show("Case Product successfully broken. Check stock balances to verify.");
							this.lblStockBal.Text = "";
							this.lblStockBal2.Text = "";
						}
						catch (Exception ex2)
						{
							MessageBox.Show("Error breaking case. Detail: " + ex2.Message);
							SqlTransaction sqlTransaction;
							sqlTransaction.Rollback();
							sqlConnection.Close();
						}
					}
					else
					{
						MessageBox.Show("Operation cancelled by user.");
					}
				}
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0009C1D4 File Offset: 0x0009A3D4
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.GetAllProductChild();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying all child products. Detail: " + ex.Message);
			}
		}

		// Token: 0x040007DC RID: 2012
		private PublicFunctions pf;

		// Token: 0x040007DD RID: 2013
		private string _cnn;

		// Token: 0x040007DE RID: 2014
		private DataTable productsDatatable;
	}
}
