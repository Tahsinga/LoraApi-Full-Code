using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x0200017A RID: 378
	[DesignerGenerated]
	public partial class PurchaseReturns : Form
	{
		// Token: 0x06003773 RID: 14195 RVA: 0x001E4078 File Offset: 0x001E2278
		public PurchaseReturns()
		{
			base.Load += this.PurchaseReturns_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x001E5A6C File Offset: 0x001E3C6C
		// (set) Token: 0x06003777 RID: 14199 RVA: 0x001E5A76 File Offset: 0x001E3C76
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x001E5A7F File Offset: 0x001E3C7F
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x001E5A89 File Offset: 0x001E3C89
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x001E5A92 File Offset: 0x001E3C92
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x001E5A9C File Offset: 0x001E3C9C
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x001E5AFA File Offset: 0x001E3CFA
		// (set) Token: 0x0600377D RID: 14205 RVA: 0x001E5B04 File Offset: 0x001E3D04
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x001E5B0D File Offset: 0x001E3D0D
		// (set) Token: 0x0600377F RID: 14207 RVA: 0x001E5B18 File Offset: 0x001E3D18
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

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x001E5B5B File Offset: 0x001E3D5B
		// (set) Token: 0x06003781 RID: 14209 RVA: 0x001E5B65 File Offset: 0x001E3D65
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06003782 RID: 14210 RVA: 0x001E5B6E File Offset: 0x001E3D6E
		// (set) Token: 0x06003783 RID: 14211 RVA: 0x001E5B78 File Offset: 0x001E3D78
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

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x001E5BBB File Offset: 0x001E3DBB
		// (set) Token: 0x06003785 RID: 14213 RVA: 0x001E5BC5 File Offset: 0x001E3DC5
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x001E5BCE File Offset: 0x001E3DCE
		// (set) Token: 0x06003787 RID: 14215 RVA: 0x001E5BD8 File Offset: 0x001E3DD8
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x001E5BE1 File Offset: 0x001E3DE1
		// (set) Token: 0x06003789 RID: 14217 RVA: 0x001E5BEC File Offset: 0x001E3DEC
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x001E5C2F File Offset: 0x001E3E2F
		// (set) Token: 0x0600378B RID: 14219 RVA: 0x001E5C39 File Offset: 0x001E3E39
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x001E5C42 File Offset: 0x001E3E42
		// (set) Token: 0x0600378D RID: 14221 RVA: 0x001E5C4C File Offset: 0x001E3E4C
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

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x001E5C8F File Offset: 0x001E3E8F
		// (set) Token: 0x0600378F RID: 14223 RVA: 0x001E5C99 File Offset: 0x001E3E99
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x001E5CA2 File Offset: 0x001E3EA2
		// (set) Token: 0x06003791 RID: 14225 RVA: 0x001E5CAC File Offset: 0x001E3EAC
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x001E5CB5 File Offset: 0x001E3EB5
		// (set) Token: 0x06003793 RID: 14227 RVA: 0x001E5CBF File Offset: 0x001E3EBF
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x001E5CC8 File Offset: 0x001E3EC8
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x001E5CD2 File Offset: 0x001E3ED2
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x001E5CDB File Offset: 0x001E3EDB
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x001E5CE5 File Offset: 0x001E3EE5
		internal virtual TextBox txtref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x001E5CEE File Offset: 0x001E3EEE
		// (set) Token: 0x06003799 RID: 14233 RVA: 0x001E5CF8 File Offset: 0x001E3EF8
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

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x001E5D3B File Offset: 0x001E3F3B
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x001E5D45 File Offset: 0x001E3F45
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x001E5D4E File Offset: 0x001E3F4E
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x001E5D58 File Offset: 0x001E3F58
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x001E5D61 File Offset: 0x001E3F61
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x001E5D6C File Offset: 0x001E3F6C
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

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x001E5DAF File Offset: 0x001E3FAF
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x001E5DB9 File Offset: 0x001E3FB9
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x001E5DC2 File Offset: 0x001E3FC2
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x001E5DCC File Offset: 0x001E3FCC
		internal virtual Label lblStockBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x001E5DD5 File Offset: 0x001E3FD5
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x001E5DDF File Offset: 0x001E3FDF
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x001E5DE8 File Offset: 0x001E3FE8
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x001E5DF2 File Offset: 0x001E3FF2
		internal virtual ComboBox cboSuppliers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x001E5DFB File Offset: 0x001E3FFB
		// (set) Token: 0x060037A9 RID: 14249 RVA: 0x001E5E08 File Offset: 0x001E4008
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

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x001E5E4B File Offset: 0x001E404B
		// (set) Token: 0x060037AB RID: 14251 RVA: 0x001E5E55 File Offset: 0x001E4055
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060037AC RID: 14252 RVA: 0x001E5E5E File Offset: 0x001E405E
		// (set) Token: 0x060037AD RID: 14253 RVA: 0x001E5E68 File Offset: 0x001E4068
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x001E5E71 File Offset: 0x001E4071
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x001E5E7B File Offset: 0x001E407B
		internal virtual DataGridView dgvItems
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x001E5E84 File Offset: 0x001E4084
		// (set) Token: 0x060037B1 RID: 14257 RVA: 0x001E5E8E File Offset: 0x001E408E
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x001E5E97 File Offset: 0x001E4097
		// (set) Token: 0x060037B3 RID: 14259 RVA: 0x001E5EA1 File Offset: 0x001E40A1
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x001E5EAA File Offset: 0x001E40AA
		// (set) Token: 0x060037B5 RID: 14261 RVA: 0x001E5EB4 File Offset: 0x001E40B4
		internal virtual BindingSource PurchaseReturnsForSupplierBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x001E5EBD File Offset: 0x001E40BD
		// (set) Token: 0x060037B7 RID: 14263 RVA: 0x001E5EC7 File Offset: 0x001E40C7
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x001E5ED0 File Offset: 0x001E40D0
		// (set) Token: 0x060037B9 RID: 14265 RVA: 0x001E5EDA File Offset: 0x001E40DA
		internal virtual PurchaseReturnsForSupplierTableAdapter PurchaseReturnsForSupplierTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x001E5EE3 File Offset: 0x001E40E3
		// (set) Token: 0x060037BB RID: 14267 RVA: 0x001E5EED File Offset: 0x001E40ED
		internal virtual DataGridViewTextBoxColumn ProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x001E5EF6 File Offset: 0x001E40F6
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x001E5F00 File Offset: 0x001E4100
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x001E5F09 File Offset: 0x001E4109
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x001E5F13 File Offset: 0x001E4113
		internal virtual DataGridViewTextBoxColumn ProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x001E5F1C File Offset: 0x001E411C
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x001E5F26 File Offset: 0x001E4126
		internal virtual DataGridViewTextBoxColumn Quantity
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x001E5F2F File Offset: 0x001E412F
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x001E5F39 File Offset: 0x001E4139
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x001E5F42 File Offset: 0x001E4142
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x001E5F4C File Offset: 0x001E414C
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x001E5F55 File Offset: 0x001E4155
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x001E5F60 File Offset: 0x001E4160
		internal virtual Button cmdSelectQty
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSelectQty;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cmdSelectQty_Click);
				Button button = this._cmdSelectQty;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdSelectQty = value;
				button = this._cmdSelectQty;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x001E5FA4 File Offset: 0x001E41A4
		private void PurchaseReturns_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.cboSuppliers.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSuppliers.ValueMember = "SupplierID";
				this.cboSuppliers.DisplayMember = "SupplierName";
				this.cboSuppliers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				this.cboSuppliers.AutoCompleteSource = AutoCompleteSource.ListItems;
				this.cboSuppliers.SelectedIndex = -1;
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					this.cmdSelectQty.Visible = true;
					this.Label13.Visible = false;
					this.txtQty.Visible = false;
					this.Button2.Visible = false;
				}
				else
				{
					this.cmdSelectQty.Visible = false;
					this.Label13.Visible = true;
					this.txtQty.Visible = true;
					this.Button2.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x001E60E0 File Offset: 0x001E42E0
		private int GetInvoiceNum()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNewInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x001E61B8 File Offset: 0x001E43B8
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(this.txtBarCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x001E6214 File Offset: 0x001E4414
		private void SearchBarCode(int barcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProductBarCode";
			sqlCommand.Parameters.AddWithValue("barcode", barcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtSearchProductCode.Text = Conversions.ToString(dataRow["ProductCode"]);
			}
			else
			{
				this.txtSearchProductCode.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x001E62E8 File Offset: 0x001E44E8
		private void Button4_Click(object sender, EventArgs e)
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

		// Token: 0x060037CD RID: 14285 RVA: 0x001E6348 File Offset: 0x001E4548
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
				this.DGVSearch.Columns["Unit_of_measure"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x001E6520 File Offset: 0x001E4720
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

		// Token: 0x060037CF RID: 14287 RVA: 0x001E6580 File Offset: 0x001E4780
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtSearchProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x001E6640 File Offset: 0x001E4840
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

		// Token: 0x060037D1 RID: 14289 RVA: 0x001E66AC File Offset: 0x001E48AC
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

		// Token: 0x060037D2 RID: 14290 RVA: 0x001E67A4 File Offset: 0x001E49A4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvItems.Rows.Count > 0;
				if (flag)
				{
					bool flag2 = this.cboSuppliers.SelectedIndex == -1;
					if (flag2)
					{
						MessageBox.Show("Please select a supplier first.");
						this.cboSuppliers.Focus();
					}
					else
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to return these products?", MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							int invoiceNum = this.GetInvoiceNum();
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							sqlCommand.Connection = sqlConnection;
							sqlConnection.Open();
							SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductReturn");
							sqlCommand.Transaction = sqlTransaction;
							try
							{
								foreach (object obj in ((IEnumerable)this.dgvItems.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									bool flag4 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, 0, false);
									if (flag4)
									{
										MessageBox.Show("Error with product ID.Close and try again.");
										sqlTransaction.Rollback();
										return;
									}
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "PurchaseReturn";
									sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", invoiceNum);
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
									sqlCommand.Parameters.AddWithValue("ref", this.txtref.Text);
									sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value));
									sqlCommand.Parameters.AddWithValue("trandesc", "STOCK RETURNED");
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("productcode", dataGridViewRow.Cells[1].Value.ToString());
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("suppliername", this.cboSuppliers.Text);
									sqlCommand.Parameters.AddWithValue("batchnumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[4].Value));
									sqlCommand.Parameters.AddWithValue("expirydate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value));
									sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
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
							SqlConnection sqlConnection2 = new SqlConnection(MyProject.Forms.Form1.Constring);
							this.GetCompanyDetailsTableAdapter.Connection = sqlConnection2;
							this.PurchaseReturnsForSupplierTableAdapter.Connection = sqlConnection2;
							ReportParameter reportParameter = new ReportParameter("trandate", Conversions.ToString(Convert.ToInt32(DateTime.Today.Date.ToString("yyyyMMdd"))));
							ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
							ReportParameter reportParameter3 = new ReportParameter("branch", MyProject.Forms.Form1.branch);
							ReportParameter reportParameter4 = new ReportParameter("ref", this.txtref.Text);
							ReportParameter reportParameter5 = new ReportParameter("suppliername", this.cboSuppliers.Text);
							ReportParameter reportParameter6 = new ReportParameter("Reason", this.txtref.Text);
							ReportParameter[] array = new ReportParameter[] { reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter, reportParameter6 };
							this.ReportViewer1.LocalReport.SetParameters(array);
							this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
							this.PurchaseReturnsForSupplierTableAdapter.Fill(this.POSDataSet.PurchaseReturnsForSupplier, this.txtref.Text, this.cboSuppliers.Text, new int?(Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
							this.ReportViewer1.RefreshReport();
							MessageBox.Show("Product successfully returned to supplier.");
							this.clearform();
						}
					}
				}
				else
				{
					MessageBox.Show("Please select a product, enter the quantity and ADD TO LIST first.");
					this.Button2.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error returning stock item. Error detail: " + ex.Message);
			}
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x001E6D88 File Offset: 0x001E4F88
		private void clearform()
		{
			this.txtQty.Text = "";
			this.txtref.Text = "";
			this.cboSuppliers.Text = "";
			this.dgvItems.Rows.Clear();
			this.cboSuppliers.SelectedIndex = -1;
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x001E6DE8 File Offset: 0x001E4FE8
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x001E6E34 File Offset: 0x001E5034
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(this.txtSearchProductCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x001E6E90 File Offset: 0x001E5090
		private void FetchProdtDetails(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = dataRow["ProductDesc"].ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				double num2 = Convert.ToDouble(this.GetStockAvailable(this.CurrentID));
				this.lblStockBal.Text = num2.ToString();
				string text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["suppliername"])), "", RuntimeHelpers.GetObjectValue(dataRow["suppliername"])));
				bool flag2 = Operators.CompareString(text, "", false) != 0;
				if (flag2)
				{
					this.cboSuppliers.SelectedIndex = this.cboSuppliers.FindStringExact(text);
				}
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.CurrentID = 0;
				this.lblStockBal.Text = "...";
			}
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x001E7020 File Offset: 0x001E5220
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

		// Token: 0x060037D8 RID: 14296 RVA: 0x001E728C File Offset: 0x001E548C
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

		// Token: 0x060037D9 RID: 14297 RVA: 0x001E72EC File Offset: 0x001E54EC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.addtolist();
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding items to list. Detail: " + ex.Message);
			}
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x001E7348 File Offset: 0x001E5548
		private void addtolist()
		{
			bool flag = this.CurrentID == 0;
			if (flag)
			{
				MessageBox.Show("Please re-select the product.");
			}
			else
			{
				bool flag2 = Operators.CompareString(this.txtref.Text, "", false) == 0;
				if (flag2)
				{
					MessageBox.Show("Please enter the reference first.");
				}
				else
				{
					bool flag3 = Operators.CompareString(this.cboSuppliers.Text, "", false) == 0;
					if (flag3)
					{
						MessageBox.Show("Please select a supplier first.");
					}
					else
					{
						bool flag4 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag4)
						{
							bool flag5 = false;
							decimal num = 0m;
							try
							{
								foreach (object obj in MyProject.Forms.Form1.SelectedBatch.Rows)
								{
									DataRow dataRow = (DataRow)obj;
									num = new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["OrderQty"])), 0, RuntimeHelpers.GetObjectValue(dataRow["OrderQty"])))));
									bool flag6 = decimal.Compare(num, 0m) != 0;
									if (flag6)
									{
										flag5 = true;
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
							bool flag7 = !flag5;
							if (flag7)
							{
								MessageBox.Show("No quantity selected.");
								return;
							}
						}
						else
						{
							bool flag8 = (Operators.CompareString(this.txtQty.Text, "", false) == 0) | (Conversion.Val(this.txtQty.Text) == 0.0);
							if (flag8)
							{
								MessageBox.Show("Please enter the quantity first.");
								return;
							}
						}
						string text = this.txtSearchProductCode.Text;
						string text2 = this.lblDesc.Text;
						bool flag9 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag9)
						{
							try
							{
								foreach (object obj2 in MyProject.Forms.Form1.SelectedBatch.Rows)
								{
									DataRow dataRow2 = (DataRow)obj2;
									decimal num2 = new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["OrderQty"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["OrderQty"])))));
									bool flag10 = decimal.Compare(num2, 0m) != 0;
									if (flag10)
									{
										string text3 = dataRow2["BatchNumber"].ToString();
										int num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow2["ExpiryDate"]));
										string[] array = new string[]
										{
											Conversions.ToString(this.CurrentID),
											text,
											text2,
											Conversions.ToString(num2),
											text3,
											Conversions.ToString(num3)
										};
										this.dgvItems.Rows.Add(array);
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
							string text4 = this.txtQty.Text;
							string[] array2 = new string[]
							{
								Conversions.ToString(this.CurrentID),
								text,
								text2,
								text4,
								"",
								""
							};
							this.dgvItems.Rows.Add(array2);
						}
					}
				}
			}
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x001E7704 File Offset: 0x001E5904
		private void cmdSelectQty_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				MyProject.Forms.Form1.SelectedBatch = dataTable;
				BatchSelect batchSelect = new BatchSelect();
				batchSelect.productid = this.CurrentID;
				batchSelect.coid = MyProject.Forms.Form1.coid;
				batchSelect.branch = MyProject.Forms.Form1.branch;
				batchSelect.ShowDialog(this);
				batchSelect.Dispose();
				this.addtolist();
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying batch select. Details: " + ex.Message);
			}
		}

		// Token: 0x040017A4 RID: 6052
		private string _cnn;

		// Token: 0x040017A5 RID: 6053
		private int CurrentID;

		// Token: 0x040017A6 RID: 6054
		private PublicFunctions pf;
	}
}
