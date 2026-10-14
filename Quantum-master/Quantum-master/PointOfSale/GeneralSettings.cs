using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000063 RID: 99
	[DesignerGenerated]
	public partial class GeneralSettings : Form
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x000BF8D8 File Offset: 0x000BDAD8
		public GeneralSettings()
		{
			base.Load += this.GeneralSettings_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x000C4CC4 File Offset: 0x000C2EC4
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x000C4CCE File Offset: 0x000C2ECE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x000C4CD7 File Offset: 0x000C2ED7
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x000C4CE1 File Offset: 0x000C2EE1
		internal virtual ComboBox cboValuations
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x000C4CEA File Offset: 0x000C2EEA
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x000C4CF4 File Offset: 0x000C2EF4
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x000C4CFD File Offset: 0x000C2EFD
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x000C4D08 File Offset: 0x000C2F08
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

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x000C4D4B File Offset: 0x000C2F4B
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x000C4D55 File Offset: 0x000C2F55
		internal virtual ComboBox cboBusinessType
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x000C4D5E File Offset: 0x000C2F5E
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x000C4D68 File Offset: 0x000C2F68
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x000C4D71 File Offset: 0x000C2F71
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x000C4D7B File Offset: 0x000C2F7B
		internal virtual TextBox txtBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x000C4D84 File Offset: 0x000C2F84
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x000C4D8E File Offset: 0x000C2F8E
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x000C4D97 File Offset: 0x000C2F97
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x000C4DA1 File Offset: 0x000C2FA1
		internal virtual TextBox txtCOID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x000C4DAA File Offset: 0x000C2FAA
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x000C4DB4 File Offset: 0x000C2FB4
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x000C4DBD File Offset: 0x000C2FBD
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x000C4DC8 File Offset: 0x000C2FC8
		internal virtual TextBox txtMarkUp
		{
			[CompilerGenerated]
			get
			{
				return this._txtMarkUp;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtMarkUp_KeyPress);
				TextBox textBox = this._txtMarkUp;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtMarkUp = value;
				textBox = this._txtMarkUp;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x000C4E0B File Offset: 0x000C300B
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x000C4E15 File Offset: 0x000C3015
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x000C4E1E File Offset: 0x000C301E
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x000C4E28 File Offset: 0x000C3028
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x000C4E31 File Offset: 0x000C3031
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x000C4E3B File Offset: 0x000C303B
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x000C4E44 File Offset: 0x000C3044
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x000C4E50 File Offset: 0x000C3050
		internal virtual CheckBox chkNeg
		{
			[CompilerGenerated]
			get
			{
				return this._chkNeg;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkNeg_MouseHover);
				EventHandler eventHandler2 = new EventHandler(this.chkNeg_CheckedChanged);
				CheckBox checkBox = this._chkNeg;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
					checkBox.CheckedChanged -= eventHandler2;
				}
				this._chkNeg = value;
				checkBox = this._chkNeg;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
					checkBox.CheckedChanged += eventHandler2;
				}
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x000C4EAE File Offset: 0x000C30AE
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x000C4EB8 File Offset: 0x000C30B8
		internal virtual CheckBox chkTilPointChange
		{
			[CompilerGenerated]
			get
			{
				return this._chkTilPointChange;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkTilPointChange_CheckedChanged);
				EventHandler eventHandler2 = new EventHandler(this.chkTilPointChange_MouseHover);
				CheckBox checkBox = this._chkTilPointChange;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
					checkBox.MouseHover -= eventHandler2;
				}
				this._chkTilPointChange = value;
				checkBox = this._chkTilPointChange;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
					checkBox.MouseHover += eventHandler2;
				}
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x000C4F16 File Offset: 0x000C3116
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x000C4F20 File Offset: 0x000C3120
		internal virtual CheckBox chkWarehouse
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x000C4F29 File Offset: 0x000C3129
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x000C4F34 File Offset: 0x000C3134
		internal virtual CheckBox chkSearchCursor
		{
			[CompilerGenerated]
			get
			{
				return this._chkSearchCursor;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkSearchCursor_MouseHover);
				CheckBox checkBox = this._chkSearchCursor;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkSearchCursor = value;
				checkBox = this._chkSearchCursor;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x000C4F77 File Offset: 0x000C3177
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x000C4F81 File Offset: 0x000C3181
		internal virtual CheckBox chkCheckStocks
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x000C4F8A File Offset: 0x000C318A
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x000C4F94 File Offset: 0x000C3194
		internal virtual CheckBox chkTellerViewStockBalances
		{
			[CompilerGenerated]
			get
			{
				return this._chkTellerViewStockBalances;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkTellerViewStockBalances_MouseHover);
				CheckBox checkBox = this._chkTellerViewStockBalances;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkTellerViewStockBalances = value;
				checkBox = this._chkTellerViewStockBalances;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x000C4FD7 File Offset: 0x000C31D7
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x000C4FE4 File Offset: 0x000C31E4
		internal virtual CheckBox chkOptimiseOnlineSearch
		{
			[CompilerGenerated]
			get
			{
				return this._chkOptimiseOnlineSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkOptimiseOnlineSearch_MouseHover);
				CheckBox checkBox = this._chkOptimiseOnlineSearch;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkOptimiseOnlineSearch = value;
				checkBox = this._chkOptimiseOnlineSearch;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x000C5027 File Offset: 0x000C3227
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x000C5031 File Offset: 0x000C3231
		internal virtual CheckBox chkChangePricetoWholesale
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x000C503A File Offset: 0x000C323A
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x000C5044 File Offset: 0x000C3244
		internal virtual CheckBox chkIsWholesaleShop
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x000C504D File Offset: 0x000C324D
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x000C5058 File Offset: 0x000C3258
		internal virtual CheckBox chkAllowSales
		{
			[CompilerGenerated]
			get
			{
				return this._chkAllowSales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkAllowSales_CheckedChanged);
				EventHandler eventHandler2 = new EventHandler(this.chkAllowSales_MouseHover);
				CheckBox checkBox = this._chkAllowSales;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
					checkBox.MouseHover -= eventHandler2;
				}
				this._chkAllowSales = value;
				checkBox = this._chkAllowSales;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
					checkBox.MouseHover += eventHandler2;
				}
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x000C50B6 File Offset: 0x000C32B6
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x000C50C0 File Offset: 0x000C32C0
		internal virtual CheckBox chkSpecialPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x000C50C9 File Offset: 0x000C32C9
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x000C50D3 File Offset: 0x000C32D3
		internal virtual CheckBox chkProductConversion
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x000C50DC File Offset: 0x000C32DC
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x000C50E6 File Offset: 0x000C32E6
		internal virtual CheckBox chkDateChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x000C50EF File Offset: 0x000C32EF
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x000C50FC File Offset: 0x000C32FC
		internal virtual CheckBox chkLinkProductCreditWithInvoice
		{
			[CompilerGenerated]
			get
			{
				return this._chkLinkProductCreditWithInvoice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkLinkProductCreditWithInvoice_MouseHover);
				CheckBox checkBox = this._chkLinkProductCreditWithInvoice;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkLinkProductCreditWithInvoice = value;
				checkBox = this._chkLinkProductCreditWithInvoice;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x000C513F File Offset: 0x000C333F
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x000C5149 File Offset: 0x000C3349
		internal virtual CheckBox chkuseManagedLogins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x000C5152 File Offset: 0x000C3352
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x000C515C File Offset: 0x000C335C
		internal virtual CheckBox chkAllowInvDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x000C5165 File Offset: 0x000C3365
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x000C5170 File Offset: 0x000C3370
		internal virtual CheckBox chkUseCollections
		{
			[CompilerGenerated]
			get
			{
				return this._chkUseCollections;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkUseCollections_CheckedChanged);
				CheckBox checkBox = this._chkUseCollections;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkUseCollections = value;
				checkBox = this._chkUseCollections;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x000C51B3 File Offset: 0x000C33B3
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x000C51BD File Offset: 0x000C33BD
		internal virtual CheckBox chkRestaurant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x000C51C6 File Offset: 0x000C33C6
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x000C51D0 File Offset: 0x000C33D0
		internal virtual CheckBox chkPricesIncludeTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x000C51D9 File Offset: 0x000C33D9
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x000C51E4 File Offset: 0x000C33E4
		internal virtual CheckBox chkDiscountEditing
		{
			[CompilerGenerated]
			get
			{
				return this._chkDiscountEditing;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkDiscountEditing_MouseHover);
				CheckBox checkBox = this._chkDiscountEditing;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkDiscountEditing = value;
				checkBox = this._chkDiscountEditing;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x000C5227 File Offset: 0x000C3427
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x000C5231 File Offset: 0x000C3431
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x000C523A File Offset: 0x000C343A
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x000C5244 File Offset: 0x000C3444
		internal virtual CheckBox chkAccountSales
		{
			[CompilerGenerated]
			get
			{
				return this._chkAccountSales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkAccountSales_CheckedChanged);
				EventHandler eventHandler2 = new EventHandler(this.chkAccountSales_MouseHover);
				CheckBox checkBox = this._chkAccountSales;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
					checkBox.MouseHover -= eventHandler2;
				}
				this._chkAccountSales = value;
				checkBox = this._chkAccountSales;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
					checkBox.MouseHover += eventHandler2;
				}
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x000C52A2 File Offset: 0x000C34A2
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x000C52AC File Offset: 0x000C34AC
		internal virtual CheckBox chkRecordConsultant
		{
			[CompilerGenerated]
			get
			{
				return this._chkRecordConsultant;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkRecordConsultant_CheckedChanged);
				EventHandler eventHandler2 = new EventHandler(this.chkRecordConsultant_MouseHover);
				CheckBox checkBox = this._chkRecordConsultant;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
					checkBox.MouseHover -= eventHandler2;
				}
				this._chkRecordConsultant = value;
				checkBox = this._chkRecordConsultant;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
					checkBox.MouseHover += eventHandler2;
				}
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x000C530A File Offset: 0x000C350A
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x000C5314 File Offset: 0x000C3514
		internal virtual CheckBox chkConsultantSales
		{
			[CompilerGenerated]
			get
			{
				return this._chkConsultantSales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkConsultantSales_MouseHover);
				CheckBox checkBox = this._chkConsultantSales;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkConsultantSales = value;
				checkBox = this._chkConsultantSales;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x000C5357 File Offset: 0x000C3557
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x000C5361 File Offset: 0x000C3561
		internal virtual CheckBox chkOtherDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x000C536A File Offset: 0x000C356A
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x000C5374 File Offset: 0x000C3574
		internal virtual CheckBox chkIsTouchScreen
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsTouchScreen;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsTouchScreen_CheckedChanged);
				CheckBox checkBox = this._chkIsTouchScreen;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsTouchScreen = value;
				checkBox = this._chkIsTouchScreen;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x000C53B7 File Offset: 0x000C35B7
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x000C53C1 File Offset: 0x000C35C1
		internal virtual CheckBox chkTables
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x000C53CA File Offset: 0x000C35CA
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x000C53D4 File Offset: 0x000C35D4
		internal virtual CheckBox chkusingBarcodePrintingScale
		{
			[CompilerGenerated]
			get
			{
				return this._chkusingBarcodePrintingScale;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkusingBarcodePrintingScale_CheckedChanged);
				CheckBox checkBox = this._chkusingBarcodePrintingScale;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkusingBarcodePrintingScale = value;
				checkBox = this._chkusingBarcodePrintingScale;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x000C5417 File Offset: 0x000C3617
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x000C5421 File Offset: 0x000C3621
		internal virtual GroupBox grpBarcodePrintingScale
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x000C542A File Offset: 0x000C362A
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x000C5434 File Offset: 0x000C3634
		internal virtual RadioButton radPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x000C543D File Offset: 0x000C363D
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x000C5448 File Offset: 0x000C3648
		internal virtual RadioButton radWeight
		{
			[CompilerGenerated]
			get
			{
				return this._radWeight;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.radWeight_CheckedChanged);
				RadioButton radioButton = this._radWeight;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= eventHandler;
				}
				this._radWeight = value;
				radioButton = this._radWeight;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x000C548B File Offset: 0x000C368B
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x000C5498 File Offset: 0x000C3698
		internal virtual TextBox txtPriceLength
		{
			[CompilerGenerated]
			get
			{
				return this._txtPriceLength;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPriceLength_KeyPress);
				TextBox textBox = this._txtPriceLength;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPriceLength = value;
				textBox = this._txtPriceLength;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x000C54DB File Offset: 0x000C36DB
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x000C54E5 File Offset: 0x000C36E5
		internal virtual Label lblPriceLength
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x000C54EE File Offset: 0x000C36EE
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x000C54F8 File Offset: 0x000C36F8
		internal virtual TextBox txtPriceStart
		{
			[CompilerGenerated]
			get
			{
				return this._txtPriceStart;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPriceStart_KeyPress);
				TextBox textBox = this._txtPriceStart;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPriceStart = value;
				textBox = this._txtPriceStart;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x000C553B File Offset: 0x000C373B
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x000C5545 File Offset: 0x000C3745
		internal virtual Label lblPricestart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x000C554E File Offset: 0x000C374E
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x000C5558 File Offset: 0x000C3758
		internal virtual TextBox txtWeightLength
		{
			[CompilerGenerated]
			get
			{
				return this._txtWeightLength;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtWeightLength_KeyPress);
				TextBox textBox = this._txtWeightLength;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtWeightLength = value;
				textBox = this._txtWeightLength;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x000C559B File Offset: 0x000C379B
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x000C55A5 File Offset: 0x000C37A5
		internal virtual Label lblWeightLength
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x000C55AE File Offset: 0x000C37AE
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x000C55B8 File Offset: 0x000C37B8
		internal virtual TextBox txtWeightStart
		{
			[CompilerGenerated]
			get
			{
				return this._txtWeightStart;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtWeightStart_KeyPress);
				TextBox textBox = this._txtWeightStart;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtWeightStart = value;
				textBox = this._txtWeightStart;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x000C55FB File Offset: 0x000C37FB
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x000C5605 File Offset: 0x000C3805
		internal virtual Label lblWeightStart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000C560E File Offset: 0x000C380E
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x000C5618 File Offset: 0x000C3818
		internal virtual TextBox txtCodeLength
		{
			[CompilerGenerated]
			get
			{
				return this._txtCodeLength;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox2_KeyPress);
				TextBox textBox = this._txtCodeLength;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCodeLength = value;
				textBox = this._txtCodeLength;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x000C565B File Offset: 0x000C385B
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x000C5668 File Offset: 0x000C3868
		internal virtual TextBox txtCodeStartPosition
		{
			[CompilerGenerated]
			get
			{
				return this._txtCodeStartPosition;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
				TextBox textBox = this._txtCodeStartPosition;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCodeStartPosition = value;
				textBox = this._txtCodeStartPosition;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x000C56AB File Offset: 0x000C38AB
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x000C56B5 File Offset: 0x000C38B5
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000C56BE File Offset: 0x000C38BE
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x000C56C8 File Offset: 0x000C38C8
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x000C56D1 File Offset: 0x000C38D1
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x000C56DC File Offset: 0x000C38DC
		internal virtual TextBox txtStartingNumber
		{
			[CompilerGenerated]
			get
			{
				return this._txtStartingNumber;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtStartingNumber_KeyPress);
				TextBox textBox = this._txtStartingNumber;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtStartingNumber = value;
				textBox = this._txtStartingNumber;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000C571F File Offset: 0x000C391F
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x000C5729 File Offset: 0x000C3929
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x000C5732 File Offset: 0x000C3932
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x000C573C File Offset: 0x000C393C
		internal virtual CheckBox chkShowCustomersInSalesForm
		{
			[CompilerGenerated]
			get
			{
				return this._chkShowCustomersInSalesForm;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkShowCustomersInSalesForm_MouseHover);
				CheckBox checkBox = this._chkShowCustomersInSalesForm;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkShowCustomersInSalesForm = value;
				checkBox = this._chkShowCustomersInSalesForm;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000C577F File Offset: 0x000C397F
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x000C578C File Offset: 0x000C398C
		internal virtual Label Label11
		{
			[CompilerGenerated]
			get
			{
				return this._Label11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label11_MouseHover);
				Label label = this._Label11;
				if (label != null)
				{
					label.MouseHover -= eventHandler;
				}
				this._Label11 = value;
				label = this._Label11;
				if (label != null)
				{
					label.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000C57CF File Offset: 0x000C39CF
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x000C57DC File Offset: 0x000C39DC
		internal virtual TextBox txtDecimals
		{
			[CompilerGenerated]
			get
			{
				return this._txtDecimals;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDecimals_KeyPress);
				TextBox textBox = this._txtDecimals;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtDecimals = value;
				textBox = this._txtDecimals;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x000C581F File Offset: 0x000C3A1F
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x000C582C File Offset: 0x000C3A2C
		internal virtual CheckBox chkCalcBackward
		{
			[CompilerGenerated]
			get
			{
				return this._chkCalcBackward;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkCalcBackward_MouseHover);
				CheckBox checkBox = this._chkCalcBackward;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkCalcBackward = value;
				checkBox = this._chkCalcBackward;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x000C586F File Offset: 0x000C3A6F
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x000C5879 File Offset: 0x000C3A79
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x000C5882 File Offset: 0x000C3A82
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x000C588C File Offset: 0x000C3A8C
		internal virtual TextBox btnHeight
		{
			[CompilerGenerated]
			get
			{
				return this._btnHeight;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.btnHeight_KeyPress);
				TextBox textBox = this._btnHeight;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._btnHeight = value;
				textBox = this._btnHeight;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000C58CF File Offset: 0x000C3ACF
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x000C58D9 File Offset: 0x000C3AD9
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x000C58E2 File Offset: 0x000C3AE2
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x000C58EC File Offset: 0x000C3AEC
		internal virtual TextBox btnWidth
		{
			[CompilerGenerated]
			get
			{
				return this._btnWidth;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.btnWidth_KeyPress);
				TextBox textBox = this._btnWidth;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._btnWidth = value;
				textBox = this._btnWidth;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x000C592F File Offset: 0x000C3B2F
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x000C5939 File Offset: 0x000C3B39
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x000C5942 File Offset: 0x000C3B42
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x000C594C File Offset: 0x000C3B4C
		internal virtual TextBox btnCountPerLine
		{
			[CompilerGenerated]
			get
			{
				return this._btnCountPerLine;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.btnCountPerLine_KeyPress);
				TextBox textBox = this._btnCountPerLine;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._btnCountPerLine = value;
				textBox = this._btnCountPerLine;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x000C598F File Offset: 0x000C3B8F
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x000C5999 File Offset: 0x000C3B99
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x000C59A2 File Offset: 0x000C3BA2
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x000C59AC File Offset: 0x000C3BAC
		internal virtual TextBox btnFontSize
		{
			[CompilerGenerated]
			get
			{
				return this._btnFontSize;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.btnFontSize_KeyPress);
				TextBox textBox = this._btnFontSize;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._btnFontSize = value;
				textBox = this._btnFontSize;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x000C59EF File Offset: 0x000C3BEF
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x000C59F9 File Offset: 0x000C3BF9
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x000C5A02 File Offset: 0x000C3C02
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x000C5A0C File Offset: 0x000C3C0C
		internal virtual TextBox btnSpace
		{
			[CompilerGenerated]
			get
			{
				return this._btnSpace;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.btnSpace_KeyPress);
				TextBox textBox = this._btnSpace;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._btnSpace = value;
				textBox = this._btnSpace;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x000C5A4F File Offset: 0x000C3C4F
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x000C5A59 File Offset: 0x000C3C59
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x000C5A62 File Offset: 0x000C3C62
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x000C5A6C File Offset: 0x000C3C6C
		internal virtual CheckBox chkHasSecondScreen
		{
			[CompilerGenerated]
			get
			{
				return this._chkHasSecondScreen;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkHasSecondScreen_CheckedChanged);
				CheckBox checkBox = this._chkHasSecondScreen;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkHasSecondScreen = value;
				checkBox = this._chkHasSecondScreen;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x000C5AAF File Offset: 0x000C3CAF
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x000C5ABC File Offset: 0x000C3CBC
		internal virtual Button btnPath
		{
			[CompilerGenerated]
			get
			{
				return this._btnPath;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnPath_Click);
				Button button = this._btnPath;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnPath = value;
				button = this._btnPath;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x000C5AFF File Offset: 0x000C3CFF
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x000C5B09 File Offset: 0x000C3D09
		internal virtual Label lblpath
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x000C5B12 File Offset: 0x000C3D12
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x000C5B1C File Offset: 0x000C3D1C
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000C5B25 File Offset: 0x000C3D25
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x000C5B30 File Offset: 0x000C3D30
		internal virtual CheckBox chkUseConnectedScale
		{
			[CompilerGenerated]
			get
			{
				return this._chkUseConnectedScale;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkUseConnectedScale_CheckedChanged);
				CheckBox checkBox = this._chkUseConnectedScale;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkUseConnectedScale = value;
				checkBox = this._chkUseConnectedScale;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000C5B73 File Offset: 0x000C3D73
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x000C5B7D File Offset: 0x000C3D7D
		internal virtual ComboBox ComboBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000C5B86 File Offset: 0x000C3D86
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x000C5B90 File Offset: 0x000C3D90
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000C5B99 File Offset: 0x000C3D99
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x000C5BA4 File Offset: 0x000C3DA4
		internal virtual TextBox txtConnectedScalePortNum
		{
			[CompilerGenerated]
			get
			{
				return this._txtConnectedScalePortNum;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtConnectedScalePortNum_KeyPress);
				TextBox textBox = this._txtConnectedScalePortNum;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtConnectedScalePortNum = value;
				textBox = this._txtConnectedScalePortNum;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x000C5BE7 File Offset: 0x000C3DE7
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x000C5BF1 File Offset: 0x000C3DF1
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x000C5BFA File Offset: 0x000C3DFA
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x000C5C04 File Offset: 0x000C3E04
		internal virtual CheckBox chkBarFastExchange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000C5C0D File Offset: 0x000C3E0D
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x000C5C18 File Offset: 0x000C3E18
		internal virtual CheckBox chkDontAutoAppend
		{
			[CompilerGenerated]
			get
			{
				return this._chkDontAutoAppend;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkDontAutoAppend_MouseHover);
				CheckBox checkBox = this._chkDontAutoAppend;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkDontAutoAppend = value;
				checkBox = this._chkDontAutoAppend;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x000C5C5B File Offset: 0x000C3E5B
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x000C5C65 File Offset: 0x000C3E65
		internal virtual CheckBox chkUseApprovals
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000C5C6E File Offset: 0x000C3E6E
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x000C5C78 File Offset: 0x000C3E78
		internal virtual CheckBox chkDisableQuotations
		{
			[CompilerGenerated]
			get
			{
				return this._chkDisableQuotations;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkDisableQuotations_MouseHover);
				CheckBox checkBox = this._chkDisableQuotations;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkDisableQuotations = value;
				checkBox = this._chkDisableQuotations;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x000C5CBB File Offset: 0x000C3EBB
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x000C5CC8 File Offset: 0x000C3EC8
		internal virtual Label Label19
		{
			[CompilerGenerated]
			get
			{
				return this._Label19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label19_MouseHover);
				Label label = this._Label19;
				if (label != null)
				{
					label.MouseHover -= eventHandler;
				}
				this._Label19 = value;
				label = this._Label19;
				if (label != null)
				{
					label.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000C5D0B File Offset: 0x000C3F0B
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x000C5D18 File Offset: 0x000C3F18
		internal virtual TextBox txtDefaultSellingQty
		{
			[CompilerGenerated]
			get
			{
				return this._txtDefaultSellingQty;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDefaultSellingQty_KeyPress);
				TextBox textBox = this._txtDefaultSellingQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtDefaultSellingQty = value;
				textBox = this._txtDefaultSellingQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000C5D5B File Offset: 0x000C3F5B
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x000C5D65 File Offset: 0x000C3F65
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000C5D6E File Offset: 0x000C3F6E
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x000C5D78 File Offset: 0x000C3F78
		internal virtual CheckBox chkDontShowQuotationOptions
		{
			[CompilerGenerated]
			get
			{
				return this._chkDontShowQuotationOptions;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkDontShowQuotationOptions_MouseHover);
				CheckBox checkBox = this._chkDontShowQuotationOptions;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkDontShowQuotationOptions = value;
				checkBox = this._chkDontShowQuotationOptions;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000C5DBB File Offset: 0x000C3FBB
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x000C5DC5 File Offset: 0x000C3FC5
		internal virtual CheckBox chkAutoBreakCase
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000C5DCE File Offset: 0x000C3FCE
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x000C5DD8 File Offset: 0x000C3FD8
		internal virtual CheckBox chkBillingTrips
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000C5DE1 File Offset: 0x000C3FE1
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x000C5DEC File Offset: 0x000C3FEC
		internal virtual CheckBox chkAllowDirectPriceEditing
		{
			[CompilerGenerated]
			get
			{
				return this._chkAllowDirectPriceEditing;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkAllowDirectPriceEditing_MouseHover);
				CheckBox checkBox = this._chkAllowDirectPriceEditing;
				if (checkBox != null)
				{
					checkBox.MouseHover -= eventHandler;
				}
				this._chkAllowDirectPriceEditing = value;
				checkBox = this._chkAllowDirectPriceEditing;
				if (checkBox != null)
				{
					checkBox.MouseHover += eventHandler;
				}
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x000C5E2F File Offset: 0x000C402F
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x000C5E39 File Offset: 0x000C4039
		internal virtual ToolTip ToolTip1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000C5E42 File Offset: 0x000C4042
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x000C5E4C File Offset: 0x000C404C
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x000C5E55 File Offset: 0x000C4055
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x000C5E5F File Offset: 0x000C405F
		internal virtual TextBox txtCustomerDisplayText
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x000C5E68 File Offset: 0x000C4068
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x000C5E74 File Offset: 0x000C4074
		internal virtual CheckBox chkCustomerDisplay
		{
			[CompilerGenerated]
			get
			{
				return this._chkCustomerDisplay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkCustomerDisplay_CheckedChanged);
				CheckBox checkBox = this._chkCustomerDisplay;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkCustomerDisplay = value;
				checkBox = this._chkCustomerDisplay;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x000C5EB7 File Offset: 0x000C40B7
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x000C5EC1 File Offset: 0x000C40C1
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x000C5ECA File Offset: 0x000C40CA
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x000C5ED4 File Offset: 0x000C40D4
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x000C5EDD File Offset: 0x000C40DD
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x000C5EE7 File Offset: 0x000C40E7
		internal virtual TextBox txtCustomerDisplayCOMPORT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x000C5EF0 File Offset: 0x000C40F0
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x000C5EFA File Offset: 0x000C40FA
		internal virtual CheckBox chkIsBlindCashup
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x000C5F03 File Offset: 0x000C4103
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x000C5F0D File Offset: 0x000C410D
		internal virtual CheckBox chkRequestSupervisor
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x000C5F16 File Offset: 0x000C4116
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x000C5F20 File Offset: 0x000C4120
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x000C5F29 File Offset: 0x000C4129
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x000C5F33 File Offset: 0x000C4133
		internal virtual CheckBox chkBarDeposits1day
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x000C5F3C File Offset: 0x000C413C
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x000C5F46 File Offset: 0x000C4146
		internal virtual CheckBox chkBarDeposits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x000C5F4F File Offset: 0x000C414F
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x000C5F59 File Offset: 0x000C4159
		internal virtual CheckBox chkShowCostPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x000C5F62 File Offset: 0x000C4162
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x000C5F6C File Offset: 0x000C416C
		internal virtual CheckBox chkDefaultConsultanttoUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x000C5F75 File Offset: 0x000C4175
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x000C5F7F File Offset: 0x000C417F
		internal virtual CheckBox chkDisableEditingPendingInv
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x000C5F88 File Offset: 0x000C4188
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x000C5F92 File Offset: 0x000C4192
		internal virtual CheckBox chkShiftClosedUseNExtDay
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x000C5F9B File Offset: 0x000C419B
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x000C5FA5 File Offset: 0x000C41A5
		internal virtual CheckBox chkPriceMatrix
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x000C5FAE File Offset: 0x000C41AE
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x000C5FB8 File Offset: 0x000C41B8
		internal virtual CheckBox chkDailyBBBackup
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x000C5FC1 File Offset: 0x000C41C1
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x000C5FCB File Offset: 0x000C41CB
		internal virtual CheckBox chkShowOrderNo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x000C5FD4 File Offset: 0x000C41D4
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x000C5FE0 File Offset: 0x000C41E0
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

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x000C6023 File Offset: 0x000C4223
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x000C602D File Offset: 0x000C422D
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x000C6036 File Offset: 0x000C4236
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x000C6040 File Offset: 0x000C4240
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x000C6049 File Offset: 0x000C4249
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x000C6053 File Offset: 0x000C4253
		internal virtual ComboBox cboScaleType
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000C605C File Offset: 0x000C425C
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x000C6066 File Offset: 0x000C4266
		internal virtual CheckBox chkSerialRestrictqtyediting
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000C606F File Offset: 0x000C426F
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x000C6079 File Offset: 0x000C4279
		internal virtual ComboBox cboBarcodePrintingScaleName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000C6082 File Offset: 0x000C4282
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x000C608C File Offset: 0x000C428C
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

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000C60CF File Offset: 0x000C42CF
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x000C60D9 File Offset: 0x000C42D9
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000C60E2 File Offset: 0x000C42E2
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x000C60EC File Offset: 0x000C42EC
		internal virtual TextBox txtpath
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x000C60F5 File Offset: 0x000C42F5
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x000C60FF File Offset: 0x000C42FF
		internal virtual CheckBox chkRecheckStockBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000C6108 File Offset: 0x000C4308
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x000C6112 File Offset: 0x000C4312
		internal virtual CheckBox chkEnableGridQtyEditing
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x000C611B File Offset: 0x000C431B
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x000C6125 File Offset: 0x000C4325
		internal virtual CheckBox chkPacketSizes
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x000C612E File Offset: 0x000C432E
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x000C6138 File Offset: 0x000C4338
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x000C6141 File Offset: 0x000C4341
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x000C614C File Offset: 0x000C434C
		internal virtual TextBox txtMaxSellingQty
		{
			[CompilerGenerated]
			get
			{
				return this._txtMaxSellingQty;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtMaxSellingQty_KeyPress);
				TextBox textBox = this._txtMaxSellingQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtMaxSellingQty = value;
				textBox = this._txtMaxSellingQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x000C6190 File Offset: 0x000C4390
		private void GeneralSettings_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.autoBreakCase == 1;
				if (flag)
				{
					this.chkAutoBreakCase.Checked = true;
				}
				else
				{
					this.chkAutoBreakCase.Checked = false;
				}
				this.GetSerialPortNames();
				this.LoadMethods();
				this.cboBusinessType.SelectedIndex = 1;
				this.txtCOID.Text = MyProject.Forms.Form1.coid.ToString();
				this.txtBranch.Text = MyProject.Forms.Form1.branch;
				this.FetchNegStockSettings();
				this.txtMarkUp.Text = MyProject.Forms.Form1.MarkUp.ToString();
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag2)
				{
					this.chkWarehouse.Checked = true;
				}
				else
				{
					this.chkWarehouse.Checked = false;
				}
				bool flag3 = MyProject.Forms.Form1.TillPointPriceChange == 1;
				if (flag3)
				{
					this.chkTilPointChange.Checked = true;
				}
				else
				{
					this.chkTilPointChange.Checked = false;
				}
				bool flag4 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag4)
				{
					this.chkSearchCursor.Checked = true;
				}
				else
				{
					this.chkSearchCursor.Checked = false;
				}
				bool flag5 = MyProject.Forms.Form1.ShowLowStockAtStartUp == 1;
				if (flag5)
				{
					this.chkCheckStocks.Checked = true;
				}
				else
				{
					this.chkCheckStocks.Checked = false;
				}
				bool flag6 = MyProject.Forms.Form1.AllowTellerToViewStockBalances == 1;
				if (flag6)
				{
					this.chkTellerViewStockBalances.Checked = true;
				}
				else
				{
					this.chkTellerViewStockBalances.Checked = false;
				}
				bool flag7 = MyProject.Forms.Form1.OnlineSearchOptimised == 1;
				if (flag7)
				{
					this.chkOptimiseOnlineSearch.Checked = true;
				}
				else
				{
					this.chkOptimiseOnlineSearch.Checked = false;
				}
				bool flag8 = MyProject.Forms.Form1.ChangeToWholesalePriceForQty == 1;
				if (flag8)
				{
					this.chkChangePricetoWholesale.Checked = true;
				}
				else
				{
					this.chkChangePricetoWholesale.Checked = false;
				}
				bool flag9 = MyProject.Forms.Form1.IsWholesaleShop == 1;
				if (flag9)
				{
					this.chkIsWholesaleShop.Checked = true;
				}
				else
				{
					this.chkIsWholesaleShop.Checked = false;
				}
				bool flag10 = MyProject.Forms.Form1.AllowSalesonComputer == 1;
				if (flag10)
				{
					this.chkAllowSales.Checked = true;
				}
				else
				{
					this.chkAllowSales.Checked = false;
				}
				bool flag11 = MyProject.Forms.Form1.ShowSpecialPrice == 0;
				if (flag11)
				{
					this.chkSpecialPrice.Checked = false;
				}
				else
				{
					this.chkSpecialPrice.Checked = true;
				}
				bool flag12 = MyProject.Forms.Form1.showproductconversion == 0;
				if (flag12)
				{
					this.chkProductConversion.Checked = false;
				}
				else
				{
					this.chkProductConversion.Checked = true;
				}
				bool flag13 = MyProject.Forms.Form1.DateChange == 0;
				if (flag13)
				{
					this.chkDateChange.Checked = false;
				}
				else
				{
					this.chkDateChange.Checked = true;
				}
				bool flag14 = MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice == 0;
				if (flag14)
				{
					this.chkLinkProductCreditWithInvoice.Checked = false;
				}
				else
				{
					this.chkLinkProductCreditWithInvoice.Checked = true;
				}
				bool flag15 = MyProject.Forms.Form1.ConsultantSalesOnly == 0;
				if (flag15)
				{
					this.chkConsultantSales.Checked = false;
				}
				else
				{
					this.chkConsultantSales.Checked = true;
				}
				bool flag16 = MyProject.Forms.Form1.useManagedLogins == 0;
				if (flag16)
				{
					this.chkuseManagedLogins.Checked = false;
				}
				else
				{
					this.chkuseManagedLogins.Checked = true;
				}
				bool flag17 = MyProject.Forms.Form1.UseCollections == 0;
				if (flag17)
				{
					this.chkUseCollections.Checked = false;
				}
				else
				{
					this.chkUseCollections.Checked = true;
				}
				bool flag18 = MyProject.Forms.Form1.AllowInvDiscount == 0;
				if (flag18)
				{
					this.chkAllowInvDiscount.Checked = false;
				}
				else
				{
					this.chkAllowInvDiscount.Checked = true;
				}
				bool flag19 = MyProject.Forms.Form1.isRestaurant == 0;
				if (flag19)
				{
					this.chkRestaurant.Checked = false;
				}
				else
				{
					this.chkRestaurant.Checked = true;
				}
				bool flag20 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
				if (flag20)
				{
					this.chkPricesIncludeTax.Checked = true;
				}
				else
				{
					this.chkPricesIncludeTax.Checked = false;
				}
				bool flag21 = MyProject.Forms.Form1.DiscountEditingAllowed == 1;
				if (flag21)
				{
					this.chkDiscountEditing.Checked = true;
				}
				else
				{
					this.chkDiscountEditing.Checked = false;
				}
				bool flag22 = MyProject.Forms.Form1.RecordConsultant == 1;
				if (flag22)
				{
					this.chkRecordConsultant.Checked = true;
				}
				else
				{
					this.chkRecordConsultant.Checked = false;
				}
				bool flag23 = MyProject.Forms.Form1.AllowAccountSales == 1;
				if (flag23)
				{
					this.chkAccountSales.Checked = true;
				}
				else
				{
					this.chkAccountSales.Checked = false;
				}
				bool flag24 = MyProject.Forms.Form1.OtherProductDetail == 1;
				if (flag24)
				{
					this.chkOtherDetail.Checked = true;
				}
				else
				{
					this.chkOtherDetail.Checked = false;
				}
				bool flag25 = MyProject.Forms.Form1.istouchscreen == 1;
				if (flag25)
				{
					this.chkIsTouchScreen.Checked = true;
				}
				else
				{
					this.chkIsTouchScreen.Checked = false;
				}
				bool flag26 = MyProject.Forms.Form1.usingTables == 1;
				if (flag26)
				{
					this.chkTables.Checked = true;
				}
				else
				{
					this.chkTables.Checked = false;
				}
				bool flag27 = Operators.CompareString(this.txtCOID.Text, "0", false) != 0;
				if (flag27)
				{
					bool flag28 = MyProject.Forms.Form1.usingBarcodePrintingScale == 1;
					if (flag28)
					{
						this.chkusingBarcodePrintingScale.Checked = true;
					}
					else
					{
						this.chkusingBarcodePrintingScale.Checked = false;
					}
					bool flag29 = MyProject.Forms.Form1.BarcodePrintingScalePrice == 1;
					if (flag29)
					{
						this.radPrice.Checked = true;
					}
					bool flag30 = MyProject.Forms.Form1.BarcodePrintingScaleWeight == 1;
					if (flag30)
					{
						this.radWeight.Checked = true;
					}
					this.GetBarcodeScaleSettings();
				}
				else
				{
					this.chkusingBarcodePrintingScale.Visible = false;
				}
				bool flag31 = MyProject.Forms.Form1.SHowCustomersInSalesForm == 1;
				if (flag31)
				{
					this.chkShowCustomersInSalesForm.Checked = true;
				}
				else
				{
					this.chkShowCustomersInSalesForm.Checked = false;
				}
				this.txtDecimals.Text = MyProject.Forms.Form1.DecimalPlaces.ToString();
				bool flag32 = MyProject.Forms.Form1.btnHeight != 0;
				if (flag32)
				{
					this.btnHeight.Text = MyProject.Forms.Form1.btnHeight.ToString();
				}
				bool flag33 = MyProject.Forms.Form1.btnWidth != 0;
				if (flag33)
				{
					this.btnWidth.Text = MyProject.Forms.Form1.btnWidth.ToString();
				}
				bool flag34 = MyProject.Forms.Form1.btnSpace != 0;
				if (flag34)
				{
					this.btnSpace.Text = MyProject.Forms.Form1.btnSpace.ToString();
				}
				bool flag35 = MyProject.Forms.Form1.btnCountperLine != 0;
				if (flag35)
				{
					this.btnCountPerLine.Text = MyProject.Forms.Form1.btnCountperLine.ToString();
				}
				bool flag36 = MyProject.Forms.Form1.btnFontSize != 0;
				if (flag36)
				{
					this.btnFontSize.Text = MyProject.Forms.Form1.btnFontSize.ToString();
				}
				bool flag37 = MyProject.Forms.Form1.HasSecondScreen == 1;
				if (flag37)
				{
					this.chkHasSecondScreen.Checked = true;
				}
				else
				{
					this.chkHasSecondScreen.Checked = false;
				}
				this.lblpath.Text = MyProject.Forms.Form1.AdvertPath;
				bool flag38 = MyProject.Forms.Form1.UseConnectedScale == 1;
				if (flag38)
				{
					this.chkUseConnectedScale.Checked = true;
					this.txtConnectedScalePortNum.Text = MyProject.Forms.Form1.ConnectedScalePortNum.ToString();
					bool flag39 = MyProject.Forms.Form1.serialRestrictQtyTextBox == 1;
					if (flag39)
					{
						this.chkSerialRestrictqtyediting.Checked = true;
					}
					else
					{
						this.chkSerialRestrictqtyediting.Checked = false;
					}
					bool flag40 = MyProject.Forms.Form1.scaleType == 1;
					if (flag40)
					{
						this.cboScaleType.SelectedIndex = this.cboScaleType.FindStringExact("WW");
					}
					else
					{
						bool flag41 = MyProject.Forms.Form1.scaleType == 2;
						if (flag41)
						{
							this.cboScaleType.SelectedIndex = this.cboScaleType.FindStringExact("ST,GS");
						}
						else
						{
							bool flag42 = MyProject.Forms.Form1.scaleType == 3;
							if (flag42)
							{
								this.cboScaleType.SelectedIndex = this.cboScaleType.FindStringExact("CAS PCII KG");
							}
						}
					}
				}
				else
				{
					this.chkUseConnectedScale.Checked = false;
					this.txtConnectedScalePortNum.Text = MyProject.Forms.Form1.ConnectedScalePortNum.ToString();
				}
				bool flag43 = MyProject.Forms.Form1.BarFastExchange == 1;
				if (flag43)
				{
					this.chkBarFastExchange.Checked = true;
				}
				else
				{
					this.chkBarFastExchange.Checked = false;
				}
				bool flag44 = MyProject.Forms.Form1.DontAutoAppendAfterBarcodeSearch == 0;
				if (flag44)
				{
					this.chkDontAutoAppend.Checked = false;
				}
				else
				{
					this.chkDontAutoAppend.Checked = true;
				}
				bool flag45 = MyProject.Forms.Form1.UseApprovals == 1;
				if (flag45)
				{
					this.chkUseApprovals.Checked = true;
				}
				else
				{
					this.chkUseApprovals.Checked = false;
				}
				this.txtDefaultSellingQty.Text = MyProject.Forms.Form1.DefaultSellingQty.ToString();
				bool flag46 = MyProject.Forms.Form1.DontShowQuotationsOnSalesForm == 1;
				if (flag46)
				{
					this.chkDontShowQuotationOptions.Checked = true;
				}
				else
				{
					this.chkDontShowQuotationOptions.Checked = false;
				}
				bool flag47 = MyProject.Forms.Form1.BillTrips == 1;
				if (flag47)
				{
					this.chkBillingTrips.Checked = true;
				}
				else
				{
					this.chkBillingTrips.Checked = false;
				}
				bool flag48 = MyProject.Forms.Form1.AllowDirectPriceEditing == 1;
				if (flag48)
				{
					this.chkAllowDirectPriceEditing.Checked = true;
				}
				else
				{
					this.chkAllowDirectPriceEditing.Checked = false;
				}
				bool flag49 = MyProject.Forms.Form1.CalcBackwards == 1;
				if (flag49)
				{
					this.chkCalcBackward.Checked = true;
				}
				else
				{
					this.chkCalcBackward.Checked = false;
				}
				bool flag50 = MyProject.Forms.Form1.hascustomerdisplayvfd == 1;
				if (flag50)
				{
					this.chkCustomerDisplay.Checked = true;
				}
				else
				{
					this.chkCustomerDisplay.Checked = false;
				}
				bool flag51 = MyProject.Forms.Form1.IsBlindCashUp == 1;
				if (flag51)
				{
					this.chkIsBlindCashup.Checked = true;
				}
				else
				{
					this.chkIsBlindCashup.Checked = false;
				}
				bool flag52 = MyProject.Forms.Form1.approve_till_void == 1;
				if (flag52)
				{
					this.chkRequestSupervisor.Checked = true;
				}
				else
				{
					this.chkRequestSupervisor.Checked = false;
				}
				bool flag53 = MyProject.Forms.Form1.deposits_inuse == 1;
				if (flag53)
				{
					this.chkBarDeposits.Checked = true;
				}
				else
				{
					this.chkBarDeposits.Checked = false;
				}
				bool flag54 = MyProject.Forms.Form1.deposits_1dayvalid == 1;
				if (flag54)
				{
					this.chkBarDeposits1day.Checked = true;
				}
				else
				{
					this.chkBarDeposits1day.Checked = false;
				}
				bool flag55 = MyProject.Forms.Form1.ShowCostPrice == 1;
				if (flag55)
				{
					this.chkShowCostPrice.Checked = true;
				}
				else
				{
					this.chkShowCostPrice.Checked = false;
				}
				bool flag56 = MyProject.Forms.Form1.ConsultantDefaultToUsername == 1;
				if (flag56)
				{
					this.chkDefaultConsultanttoUsername.Checked = true;
				}
				else
				{
					this.chkDefaultConsultanttoUsername.Checked = false;
				}
				bool flag57 = MyProject.Forms.Form1.DisableEditingPendingInv == 1;
				if (flag57)
				{
					this.chkDisableEditingPendingInv.Checked = true;
				}
				else
				{
					this.chkDisableEditingPendingInv.Checked = false;
				}
				bool flag58 = MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1;
				if (flag58)
				{
					this.chkShiftClosedUseNExtDay.Checked = true;
				}
				else
				{
					this.chkShiftClosedUseNExtDay.Checked = false;
				}
				bool flag59 = Operators.CompareString(this.txtDefaultSellingQty.Text, "", false) == 0;
				if (flag59)
				{
					this.txtDefaultSellingQty.Text = "1";
				}
				bool flag60 = Operators.CompareString(this.txtDecimals.Text, "", false) == 0;
				if (flag60)
				{
					this.txtDecimals.Text = "4";
				}
				bool flag61 = MyProject.Forms.Form1.UsePriceMatrix == 1;
				if (flag61)
				{
					this.chkPriceMatrix.Checked = true;
				}
				else
				{
					this.chkPriceMatrix.Checked = false;
				}
				bool flag62 = this.pf.CheckIfDBBackupSet(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
				if (flag62)
				{
					this.chkDailyBBBackup.Checked = true;
				}
				else
				{
					this.chkDailyBBBackup.Checked = false;
				}
				bool flag63 = MyProject.Forms.Form1.ShowOrderNo == 1;
				if (flag63)
				{
					this.chkShowOrderNo.Checked = true;
				}
				else
				{
					this.chkShowOrderNo.Checked = false;
				}
				bool flag64 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnableSalesGridQtyEditing", MyProject.Forms.Form1.Constring), "1", false) == 0;
				if (flag64)
				{
					this.chkEnableGridQtyEditing.Checked = true;
				}
				else
				{
					this.chkEnableGridQtyEditing.Checked = false;
				}
				bool flag65 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnablePacketSizes", MyProject.Forms.Form1.Constring), "1", false) == 0;
				if (flag65)
				{
					this.chkPacketSizes.Checked = true;
				}
				else
				{
					this.chkPacketSizes.Checked = false;
				}
				string text = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "MaxSellingQty", MyProject.Forms.Form1.Constring);
				bool flag66 = Operators.CompareString(text, "0", false) == 0;
				if (flag66)
				{
					this.txtMaxSellingQty.Text = "0";
				}
				else
				{
					this.txtMaxSellingQty.Text = text;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000C71C0 File Offset: 0x000C53C0
		private void LoadMethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchStockValuationMethods";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboValuations.DataSource = dataTable;
			this.cboValuations.ValueMember = "MethodID";
			this.cboValuations.DisplayMember = "Method";
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000C723C File Offset: 0x000C543C
		private void AddUpdateAppSettings(string key, string value)
		{
			try
			{
				Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
				bool flag = Information.IsNothing(settings[key]);
				if (flag)
				{
					settings.Add(key, value);
				}
				else
				{
					settings[key].Value = value;
				}
				configuration.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error addupdateAppSettings. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000C72E0 File Offset: 0x000C54E0
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool @checked = this.chkAutoBreakCase.Checked;
					if (@checked)
					{
						this.AddUpdateAppSettings("autoBreakCase", Conversions.ToString(1));
						MyProject.Forms.Form1.autoBreakCase = 1;
					}
					else
					{
						this.AddUpdateAppSettings("autoBreakCase", Conversions.ToString(0));
						MyProject.Forms.Form1.autoBreakCase = 0;
					}
					this.AddUpdateAppSettings("BusType", Conversions.ToString(this.cboBusinessType.SelectedItem));
					this.AddUpdateAppSettings("StockValuation", Conversions.ToString(this.cboValuations.SelectedValue));
					this.AddUpdateAppSettings("coid", this.txtCOID.Text);
					this.AddUpdateAppSettings("branch", this.txtBranch.Text);
					MyProject.Forms.Form1.BusType = this.cboBusinessType.SelectedText;
					bool checked2 = this.chkNeg.Checked;
					if (checked2)
					{
						this.AddUpdateAppSettings("NegativeStock", "1");
						MyProject.Forms.Form1.NegativeStock = 1;
					}
					else
					{
						this.AddUpdateAppSettings("NegativeStock", "0");
						MyProject.Forms.Form1.NegativeStock = 0;
						this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "RecheckStockBal", Conversions.ToString(Interaction.IIf(this.chkRecheckStockBal.Checked, 1, 0)), MyProject.Forms.Form1.Constring);
					}
					bool flag = Operators.CompareString(this.txtMarkUp.Text, "", false) != 0;
					if (flag)
					{
						this.AddUpdateAppSettings("MarkUp", Conversions.ToString(Convert.ToDecimal(this.txtMarkUp.Text)));
						MyProject.Forms.Form1.MarkUp = Convert.ToDecimal(this.txtMarkUp.Text);
					}
					bool checked3 = this.chkTilPointChange.Checked;
					if (checked3)
					{
						this.AddUpdateAppSettings("TillPointPriceChange", Conversions.ToString(1));
						MyProject.Forms.Form1.TillPointPriceChange = 1;
					}
					else
					{
						this.AddUpdateAppSettings("TillPointPriceChange", Conversions.ToString(0));
						MyProject.Forms.Form1.TillPointPriceChange = 0;
					}
					bool checked4 = this.chkWarehouse.Checked;
					if (checked4)
					{
						this.AddUpdateAppSettings("IsWarehouse", Conversions.ToString(1));
						MyProject.Forms.Form1.IsWarehouse = 1;
					}
					else
					{
						this.AddUpdateAppSettings("IsWarehouse", Conversions.ToString(0));
						MyProject.Forms.Form1.IsWarehouse = 0;
					}
					bool checked5 = this.chkSearchCursor.Checked;
					if (checked5)
					{
						this.AddUpdateAppSettings("DefaultSearchDesc", Conversions.ToString(1));
						MyProject.Forms.Form1.DefaultSearchDesc = 1;
					}
					else
					{
						this.AddUpdateAppSettings("DefaultSearchDesc", Conversions.ToString(0));
						MyProject.Forms.Form1.DefaultSearchDesc = 0;
					}
					bool checked6 = this.chkCheckStocks.Checked;
					if (checked6)
					{
						this.AddUpdateAppSettings("ShowLowStockAtStartUp", Conversions.ToString(1));
						MyProject.Forms.Form1.ShowLowStockAtStartUp = 1;
					}
					else
					{
						this.AddUpdateAppSettings("ShowLowStockAtStartUp", Conversions.ToString(0));
						MyProject.Forms.Form1.ShowLowStockAtStartUp = 0;
					}
					bool checked7 = this.chkTellerViewStockBalances.Checked;
					if (checked7)
					{
						this.AddUpdateAppSettings("AllowTellerToViewStockBalances", Conversions.ToString(1));
						MyProject.Forms.Form1.AllowTellerToViewStockBalances = 1;
					}
					else
					{
						this.AddUpdateAppSettings("AllowTellerToViewStockBalances", Conversions.ToString(0));
						MyProject.Forms.Form1.AllowTellerToViewStockBalances = 0;
					}
					bool checked8 = this.chkOptimiseOnlineSearch.Checked;
					if (checked8)
					{
						this.AddUpdateAppSettings("OnlineSearchOptimised", Conversions.ToString(1));
						MyProject.Forms.Form1.OnlineSearchOptimised = 1;
					}
					else
					{
						this.AddUpdateAppSettings("OnlineSearchOptimised", Conversions.ToString(0));
						MyProject.Forms.Form1.OnlineSearchOptimised = 0;
					}
					bool checked9 = this.chkChangePricetoWholesale.Checked;
					if (checked9)
					{
						this.AddUpdateAppSettings("ChangeToWholesalePriceForQty", Conversions.ToString(1));
						MyProject.Forms.Form1.ChangeToWholesalePriceForQty = 1;
					}
					else
					{
						this.AddUpdateAppSettings("ChangeToWholesalePriceForQty", Conversions.ToString(0));
						MyProject.Forms.Form1.ChangeToWholesalePriceForQty = 0;
					}
					bool checked10 = this.chkIsWholesaleShop.Checked;
					if (checked10)
					{
						this.AddUpdateAppSettings("IsWholesaleShop", Conversions.ToString(1));
						MyProject.Forms.Form1.IsWholesaleShop = 1;
					}
					else
					{
						this.AddUpdateAppSettings("IsWholesaleShop", Conversions.ToString(0));
						MyProject.Forms.Form1.IsWholesaleShop = 0;
					}
					bool checked11 = this.chkAllowSales.Checked;
					if (checked11)
					{
						this.AddUpdateAppSettings("AllowSalesonComputer", Conversions.ToString(1));
						MyProject.Forms.Form1.AllowSalesonComputer = 1;
					}
					else
					{
						this.AddUpdateAppSettings("AllowSalesonComputer", Conversions.ToString(0));
						MyProject.Forms.Form1.AllowSalesonComputer = 0;
					}
					bool checked12 = this.chkSpecialPrice.Checked;
					if (checked12)
					{
						this.AddUpdateAppSettings("ShowSpecialPrice", Conversions.ToString(1));
						MyProject.Forms.Form1.ShowSpecialPrice = 1;
					}
					else
					{
						this.AddUpdateAppSettings("ShowSpecialPrice", Conversions.ToString(0));
						MyProject.Forms.Form1.ShowSpecialPrice = 0;
					}
					bool checked13 = this.chkProductConversion.Checked;
					if (checked13)
					{
						this.AddUpdateAppSettings("ShowProductConversion", Conversions.ToString(1));
						MyProject.Forms.Form1.showproductconversion = 1;
					}
					else
					{
						this.AddUpdateAppSettings("ShowProductConversion", Conversions.ToString(0));
						MyProject.Forms.Form1.showproductconversion = 0;
					}
					bool checked14 = this.chkDateChange.Checked;
					if (checked14)
					{
						this.AddUpdateAppSettings("DateChange", Conversions.ToString(1));
						MyProject.Forms.Form1.DateChange = 1;
					}
					else
					{
						this.AddUpdateAppSettings("DateChange", Conversions.ToString(0));
						MyProject.Forms.Form1.DateChange = 0;
					}
					bool checked15 = this.chkLinkProductCreditWithInvoice.Checked;
					if (checked15)
					{
						this.AddUpdateAppSettings("LinkProductCreditWithInvoice", Conversions.ToString(1));
						MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice = 1;
					}
					else
					{
						this.AddUpdateAppSettings("LinkProductCreditWithInvoice", Conversions.ToString(0));
						MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice = 0;
					}
					bool checked16 = this.chkConsultantSales.Checked;
					if (checked16)
					{
						this.AddUpdateAppSettings("ConsultantSalesOnly", Conversions.ToString(1));
						MyProject.Forms.Form1.ConsultantSalesOnly = 1;
					}
					else
					{
						this.AddUpdateAppSettings("ConsultantSalesOnly", Conversions.ToString(0));
						MyProject.Forms.Form1.ConsultantSalesOnly = 0;
					}
					bool checked17 = this.chkuseManagedLogins.Checked;
					if (checked17)
					{
						this.AddUpdateAppSettings("useManagedLogins", Conversions.ToString(1));
						MyProject.Forms.Form1.useManagedLogins = 1;
					}
					else
					{
						this.AddUpdateAppSettings("useManagedLogins", Conversions.ToString(0));
						MyProject.Forms.Form1.useManagedLogins = 0;
					}
					bool checked18 = this.chkAllowInvDiscount.Checked;
					if (checked18)
					{
						this.AddUpdateAppSettings("AllowInvDiscount", Conversions.ToString(1));
						MyProject.Forms.Form1.AllowInvDiscount = 1;
					}
					else
					{
						this.AddUpdateAppSettings("AllowInvDiscount", Conversions.ToString(0));
						MyProject.Forms.Form1.AllowInvDiscount = 0;
					}
					bool checked19 = this.chkUseCollections.Checked;
					if (checked19)
					{
						this.AddUpdateAppSettings("UseCollections", Conversions.ToString(1));
						MyProject.Forms.Form1.UseCollections = 1;
					}
					else
					{
						this.AddUpdateAppSettings("UseCollections", Conversions.ToString(0));
						MyProject.Forms.Form1.UseCollections = 0;
					}
					bool checked20 = this.chkRestaurant.Checked;
					if (checked20)
					{
						this.AddUpdateAppSettings("IsRestaurant", Conversions.ToString(1));
						MyProject.Forms.Form1.isRestaurant = 1;
					}
					else
					{
						this.AddUpdateAppSettings("IsRestaurant", Conversions.ToString(0));
						MyProject.Forms.Form1.isRestaurant = 0;
					}
					bool checked21 = this.chkPricesIncludeTax.Checked;
					if (checked21)
					{
						this.AddUpdateAppSettings("PricesAreAfterTax", Conversions.ToString(1));
						MyProject.Forms.Form1.PricesAreAfterTax = 1;
					}
					else
					{
						this.AddUpdateAppSettings("PricesAreAfterTax", Conversions.ToString(0));
						MyProject.Forms.Form1.PricesAreAfterTax = 0;
					}
					bool checked22 = this.chkDiscountEditing.Checked;
					if (checked22)
					{
						this.AddUpdateAppSettings("DiscountEditingAllowed", Conversions.ToString(1));
						MyProject.Forms.Form1.DiscountEditingAllowed = 1;
					}
					else
					{
						this.AddUpdateAppSettings("DiscountEditingAllowed", Conversions.ToString(0));
						MyProject.Forms.Form1.DiscountEditingAllowed = 0;
					}
					bool checked23 = this.chkRecordConsultant.Checked;
					if (checked23)
					{
						this.AddUpdateAppSettings("RecordConsultant", Conversions.ToString(1));
						MyProject.Forms.Form1.RecordConsultant = 1;
					}
					else
					{
						this.AddUpdateAppSettings("RecordConsultant", Conversions.ToString(0));
						MyProject.Forms.Form1.RecordConsultant = 0;
					}
					bool checked24 = this.chkAccountSales.Checked;
					if (checked24)
					{
						this.AddUpdateAppSettings("AllowAccountSales", Conversions.ToString(1));
						MyProject.Forms.Form1.AllowAccountSales = 1;
					}
					else
					{
						this.AddUpdateAppSettings("AllowAccountSales", Conversions.ToString(0));
						MyProject.Forms.Form1.AllowAccountSales = 0;
					}
					bool checked25 = this.chkOtherDetail.Checked;
					if (checked25)
					{
						this.AddUpdateAppSettings("OtherProductDetail", Conversions.ToString(1));
						MyProject.Forms.Form1.OtherProductDetail = 1;
					}
					else
					{
						this.AddUpdateAppSettings("OtherProductDetail", Conversions.ToString(0));
						MyProject.Forms.Form1.OtherProductDetail = 0;
					}
					bool checked26 = this.chkIsTouchScreen.Checked;
					if (checked26)
					{
						this.AddUpdateAppSettings("istouchscreen", Conversions.ToString(1));
						MyProject.Forms.Form1.istouchscreen = 1;
					}
					else
					{
						this.AddUpdateAppSettings("istouchscreen", Conversions.ToString(0));
						MyProject.Forms.Form1.istouchscreen = 0;
					}
					bool checked27 = this.chkTables.Checked;
					if (checked27)
					{
						this.AddUpdateAppSettings("usingTables", Conversions.ToString(1));
						MyProject.Forms.Form1.usingTables = 1;
					}
					else
					{
						this.AddUpdateAppSettings("usingTables", Conversions.ToString(0));
						MyProject.Forms.Form1.usingTables = 0;
					}
					bool checked28 = this.chkusingBarcodePrintingScale.Checked;
					if (checked28)
					{
						this.AddUpdateAppSettings("usingBarcodePrintingScale", Conversions.ToString(1));
						MyProject.Forms.Form1.usingBarcodePrintingScale = 1;
					}
					else
					{
						this.AddUpdateAppSettings("usingBarcodePrintingScale", Conversions.ToString(0));
						MyProject.Forms.Form1.usingBarcodePrintingScale = 0;
					}
					bool checked29 = this.chkusingBarcodePrintingScale.Checked;
					if (checked29)
					{
						bool checked30 = this.radWeight.Checked;
						if (checked30)
						{
							MyProject.Forms.Form1.BarcodePrintingScaleWeight = 1;
							MyProject.Forms.Form1.BarcodePrintingScalePrice = 0;
							this.AddUpdateAppSettings("BarcodePrintingScaleWeight", Conversions.ToString(1));
							this.AddUpdateAppSettings("BarcodePrintingScalePrice", Conversions.ToString(0));
						}
						else
						{
							bool checked31 = this.radPrice.Checked;
							if (checked31)
							{
								MyProject.Forms.Form1.BarcodePrintingScaleWeight = 0;
								MyProject.Forms.Form1.BarcodePrintingScalePrice = 1;
								this.AddUpdateAppSettings("BarcodePrintingScaleWeight", Conversions.ToString(0));
								this.AddUpdateAppSettings("BarcodePrintingScalePrice", Conversions.ToString(1));
							}
						}
						this.SaveBarcodeScaleSettings();
					}
					bool checked32 = this.chkShowCustomersInSalesForm.Checked;
					if (checked32)
					{
						this.AddUpdateAppSettings("ShowCustomersInSalesForm", Conversions.ToString(1));
						MyProject.Forms.Form1.SHowCustomersInSalesForm = 1;
					}
					else
					{
						this.AddUpdateAppSettings("ShowCustomersInSalesForm", Conversions.ToString(0));
						MyProject.Forms.Form1.SHowCustomersInSalesForm = 0;
					}
					bool checked33 = this.chkIsBlindCashup.Checked;
					if (checked33)
					{
						MyProject.Forms.Form1.IsBlindCashUp = 1;
						this.AddUpdateAppSettings("IsBlindCashUp", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.IsBlindCashUp = 0;
						this.AddUpdateAppSettings("IsBlindCashUp", Conversions.ToString(0));
					}
					bool checked34 = this.chkCalcBackward.Checked;
					if (checked34)
					{
						this.AddUpdateAppSettings("CalcBackwards", Conversions.ToString(1));
						MyProject.Forms.Form1.CalcBackwards = 1;
					}
					else
					{
						this.AddUpdateAppSettings("CalcBackwards", Conversions.ToString(0));
						MyProject.Forms.Form1.CalcBackwards = 0;
					}
					bool flag2 = Operators.CompareString(this.txtDecimals.Text, "", false) == 0;
					if (flag2)
					{
						this.AddUpdateAppSettings("DecimalPlaces", Conversions.ToString(4));
						MyProject.Forms.Form1.DecimalPlaces = 4;
					}
					else
					{
						this.AddUpdateAppSettings("DecimalPlaces", Conversions.ToString(Conversions.ToInteger(this.txtDecimals.Text)));
						MyProject.Forms.Form1.DecimalPlaces = Conversions.ToInteger(this.txtDecimals.Text);
					}
					this.AddUpdateAppSettings("btnHeight", Conversions.ToString(Conversions.ToInteger(this.btnHeight.Text)));
					MyProject.Forms.Form1.btnHeight = (int)Math.Round(Conversion.Val(this.btnHeight.Text));
					this.AddUpdateAppSettings("btnWidth", Conversions.ToString(Conversions.ToInteger(this.btnWidth.Text)));
					MyProject.Forms.Form1.btnWidth = (int)Math.Round(Conversion.Val(this.btnWidth.Text));
					this.AddUpdateAppSettings("btnSpace", Conversions.ToString(Conversions.ToInteger(this.btnSpace.Text)));
					MyProject.Forms.Form1.btnSpace = (int)Math.Round(Conversion.Val(this.btnSpace.Text));
					this.AddUpdateAppSettings("btnFontSize", Conversions.ToString(Conversions.ToInteger(this.btnFontSize.Text)));
					MyProject.Forms.Form1.btnFontSize = (int)Math.Round(Conversion.Val(this.btnFontSize.Text));
					this.AddUpdateAppSettings("btnCountPerLine", Conversions.ToString(Conversions.ToInteger(this.btnCountPerLine.Text)));
					MyProject.Forms.Form1.btnCountperLine = Conversions.ToInteger(this.btnCountPerLine.Text);
					bool checked35 = this.chkHasSecondScreen.Checked;
					if (checked35)
					{
						MyProject.Forms.Form1.HasSecondScreen = 1;
						this.AddUpdateAppSettings("HasSecondScreen", Conversions.ToString(1));
						MyProject.Forms.Form1.AdvertPath = this.lblpath.Text;
						this.AddUpdateAppSettings("AdvertPath", this.lblpath.Text);
					}
					else
					{
						MyProject.Forms.Form1.HasSecondScreen = 0;
						this.AddUpdateAppSettings("HasSecondScreen", Conversions.ToString(0));
					}
					bool checked36 = this.chkUseConnectedScale.Checked;
					if (checked36)
					{
						MyProject.Forms.Form1.UseConnectedScale = 1;
						this.AddUpdateAppSettings("UseConnectedScale", Conversions.ToString(1));
						MyProject.Forms.Form1.ConnectedScalePortNum = (int)Math.Round(Conversion.Val(this.txtConnectedScalePortNum.Text));
						this.AddUpdateAppSettings("ConnectedScalePortNum", Conversions.ToString(Conversion.Val(this.txtConnectedScalePortNum.Text)));
						bool checked37 = this.chkSerialRestrictqtyediting.Checked;
						if (checked37)
						{
							MyProject.Forms.Form1.serialRestrictQtyTextBox = 1;
							this.AddUpdateAppSettings("serialRestrictQtyTextBox", Conversions.ToString(1));
						}
						else
						{
							MyProject.Forms.Form1.serialRestrictQtyTextBox = 0;
							this.AddUpdateAppSettings("serialRestrictQtyTextBox", Conversions.ToString(0));
						}
						bool flag3 = Operators.CompareString(this.cboScaleType.Text, "WW", false) == 0;
						if (flag3)
						{
							MyProject.Forms.Form1.scaleType = 1;
							this.AddUpdateAppSettings("scaletype", Conversions.ToString(1));
						}
						else
						{
							bool flag4 = Operators.CompareString(this.cboScaleType.Text, "ST,GS", false) == 0;
							if (flag4)
							{
								MyProject.Forms.Form1.scaleType = 2;
								this.AddUpdateAppSettings("scaletype", Conversions.ToString(2));
							}
							else
							{
								bool flag5 = Operators.CompareString(this.cboScaleType.Text, "CAS PCII KG", false) == 0;
								if (flag5)
								{
									MyProject.Forms.Form1.scaleType = 3;
									this.AddUpdateAppSettings("scaletype", Conversions.ToString(3));
								}
								else
								{
									MyProject.Forms.Form1.scaleType = 1;
								}
							}
						}
					}
					else
					{
						MyProject.Forms.Form1.UseConnectedScale = 0;
						this.AddUpdateAppSettings("UseConnectedScale", Conversions.ToString(0));
					}
					bool checked38 = this.chkBarFastExchange.Checked;
					if (checked38)
					{
						MyProject.Forms.Form1.BarFastExchange = 1;
						this.AddUpdateAppSettings("BarFastExchange", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.BarFastExchange = 0;
						this.AddUpdateAppSettings("BarFastExchange", Conversions.ToString(0));
					}
					bool checked39 = this.chkDontAutoAppend.Checked;
					if (checked39)
					{
						MyProject.Forms.Form1.DontAutoAppendAfterBarcodeSearch = 1;
						this.AddUpdateAppSettings("DontAutoAppend", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.DontAutoAppendAfterBarcodeSearch = 0;
						this.AddUpdateAppSettings("DontAutoAppend", Conversions.ToString(0));
					}
					bool checked40 = this.chkUseApprovals.Checked;
					if (checked40)
					{
						MyProject.Forms.Form1.UseApprovals = 1;
						this.AddUpdateAppSettings("UseApprovals", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.UseApprovals = 0;
						this.AddUpdateAppSettings("UseApprovals", Conversions.ToString(0));
					}
					bool checked41 = this.chkDisableQuotations.Checked;
					if (checked41)
					{
						MyProject.Forms.Form1.DisableQuotations = 1;
						this.AddUpdateAppSettings("DisableQuotations", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.DisableQuotations = 0;
						this.AddUpdateAppSettings("DisableQuotations", Conversions.ToString(0));
					}
					MyProject.Forms.Form1.DefaultSellingQty = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtDefaultSellingQty.Text, "", false) == 0, 0, Conversion.Val(this.txtDefaultSellingQty.Text)));
					this.AddUpdateAppSettings("DefaultSellingQty", Conversions.ToString(Conversion.Val(this.txtDefaultSellingQty.Text)));
					int defaultSellingQty = MyProject.Forms.Form1.DefaultSellingQty;
					bool checked42 = this.chkDontShowQuotationOptions.Checked;
					if (checked42)
					{
						MyProject.Forms.Form1.DontShowQuotationsOnSalesForm = 1;
						this.AddUpdateAppSettings("DontShowQuotationsOnSalesForm", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.DontShowQuotationsOnSalesForm = 0;
						this.AddUpdateAppSettings("DontShowQuotationsOnSalesForm", Conversions.ToString(0));
					}
					bool checked43 = this.chkBillingTrips.Checked;
					if (checked43)
					{
						MyProject.Forms.Form1.BillTrips = 1;
						this.AddUpdateAppSettings("BillTrips", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.BillTrips = 0;
						this.AddUpdateAppSettings("BillTrips", Conversions.ToString(0));
					}
					bool checked44 = this.chkAllowDirectPriceEditing.Checked;
					if (checked44)
					{
						MyProject.Forms.Form1.AllowDirectPriceEditing = 1;
						this.AddUpdateAppSettings("AllowDirectPriceEditing", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.AllowDirectPriceEditing = 0;
						this.AddUpdateAppSettings("AllowDirectPriceEditing", Conversions.ToString(0));
					}
					bool checked45 = this.chkCustomerDisplay.Checked;
					if (checked45)
					{
						MyProject.Forms.Form1.customerdisplayvfdMessage = this.txtCustomerDisplayText.Text;
						MyProject.Forms.Form1.hascustomerdisplayvfd = 1;
						MyProject.Forms.Form1.customerdisplayCOMPORT = this.txtCustomerDisplayCOMPORT.Text;
						this.AddUpdateAppSettings("hascustomerdisplayvfd", Conversions.ToString(1));
						this.AddUpdateAppSettings("customerdisplayvfdMessage", this.txtCustomerDisplayText.Text);
						this.AddUpdateAppSettings("customerdisplayCOMPORT", this.txtCustomerDisplayCOMPORT.Text);
					}
					else
					{
						MyProject.Forms.Form1.hascustomerdisplayvfd = 0;
						this.AddUpdateAppSettings("hascustomerdisplayvfd", Conversions.ToString(0));
					}
					bool checked46 = this.chkRequestSupervisor.Checked;
					if (checked46)
					{
						this.AddUpdateAppSettings("approve_till_void", Conversions.ToString(1));
						MyProject.Forms.Form1.approve_till_void = 1;
					}
					else
					{
						this.AddUpdateAppSettings("approve_till_void", Conversions.ToString(0));
						MyProject.Forms.Form1.approve_till_void = 0;
					}
					bool checked47 = this.chkBarDeposits.Checked;
					if (checked47)
					{
						MyProject.Forms.Form1.deposits_inuse = 1;
						this.AddUpdateAppSettings("deposits_inuse", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.deposits_inuse = 0;
						this.AddUpdateAppSettings("deposits_inuse", Conversions.ToString(0));
					}
					bool checked48 = this.chkBarDeposits1day.Checked;
					if (checked48)
					{
						MyProject.Forms.Form1.deposits_1dayvalid = 1;
						this.AddUpdateAppSettings("deposits_1dayvalid", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.deposits_1dayvalid = 0;
						this.AddUpdateAppSettings("deposits_1dayvalid", Conversions.ToString(0));
					}
					bool checked49 = this.chkShowCostPrice.Checked;
					if (checked49)
					{
						MyProject.Forms.Form1.ShowCostPrice = 1;
						this.AddUpdateAppSettings("ShowCostPrice", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.ShowCostPrice = 0;
						this.AddUpdateAppSettings("ShowCostPrice", Conversions.ToString(0));
					}
					bool checked50 = this.chkDefaultConsultanttoUsername.Checked;
					if (checked50)
					{
						MyProject.Forms.Form1.ConsultantDefaultToUsername = 1;
						this.AddUpdateAppSettings("ConsultantDefaultToUsername", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.ConsultantDefaultToUsername = 0;
						this.AddUpdateAppSettings("ConsultantDefaultToUsername", Conversions.ToString(0));
					}
					bool checked51 = this.chkDisableEditingPendingInv.Checked;
					if (checked51)
					{
						MyProject.Forms.Form1.DisableEditingPendingInv = 1;
						this.AddUpdateAppSettings("DisableEditingPendingInv", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.DisableEditingPendingInv = 0;
						this.AddUpdateAppSettings("DisableEditingPendingInv", Conversions.ToString(0));
					}
					bool checked52 = this.chkShiftClosedUseNExtDay.Checked;
					if (checked52)
					{
						MyProject.Forms.Form1.ShiftClosedUseNExtDay = 1;
						this.AddUpdateAppSettings("ShiftClosedUseNExtDay", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.ShiftClosedUseNExtDay = 0;
						this.AddUpdateAppSettings("ShiftClosedUseNExtDay", Conversions.ToString(0));
					}
					bool checked53 = this.chkPriceMatrix.Checked;
					if (checked53)
					{
						MyProject.Forms.Form1.UsePriceMatrix = 1;
						this.AddUpdateAppSettings("UsePriceMatrix", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.UsePriceMatrix = 0;
						this.AddUpdateAppSettings("UsePriceMatrix", Conversions.ToString(0));
					}
					bool checked54 = this.chkDailyBBBackup.Checked;
					if (checked54)
					{
						this.pf.SetDBBackup(MyProject.Forms.Form1.coid, true, MyProject.Forms.Form1.Constring);
					}
					else
					{
						this.pf.SetDBBackup(MyProject.Forms.Form1.coid, false, MyProject.Forms.Form1.Constring);
					}
					bool checked55 = this.chkShowOrderNo.Checked;
					if (checked55)
					{
						MyProject.Forms.Form1.ShowOrderNo = 1;
						this.AddUpdateAppSettings("ShowOrderNo", Conversions.ToString(1));
					}
					else
					{
						MyProject.Forms.Form1.ShowOrderNo = 0;
						this.AddUpdateAppSettings("ShowOrderNo", Conversions.ToString(0));
					}
					bool checked56 = this.chkEnableGridQtyEditing.Checked;
					if (checked56)
					{
						this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnableSalesGridQtyEditing", "1", MyProject.Forms.Form1.Constring);
					}
					else
					{
						this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnableSalesGridQtyEditing", "0", MyProject.Forms.Form1.Constring);
					}
					bool checked57 = this.chkPacketSizes.Checked;
					if (checked57)
					{
						this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnablePacketSizes", "1", MyProject.Forms.Form1.Constring);
						MyProject.Forms.Form1.usePacketSizes = 1;
					}
					else
					{
						this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnablePacketSizes", "0", MyProject.Forms.Form1.Constring);
						MyProject.Forms.Form1.usePacketSizes = 0;
					}
					bool flag6 = Operators.CompareString(this.txtMaxSellingQty.Text, "", false) == 0;
					if (flag6)
					{
						this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "MaxSellingQty", "0", MyProject.Forms.Form1.Constring);
					}
					else
					{
						this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "MaxSellingQty", this.txtMaxSellingQty.Text, MyProject.Forms.Form1.Constring);
					}
					MyProject.Forms.Form1.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
					MessageBox.Show("General settings successfully saved.");
					base.Dispose();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error saving data. Detal: " + ex.Message);
				}
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000C8E14 File Offset: 0x000C7014
		private void GetBarcodeScaleSettings()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BarcodeScaleSettingsSelect";
			sqlCommand.Parameters.AddWithValue("coid", Conversions.ToInteger(this.txtCOID.Text));
			sqlCommand.Parameters.AddWithValue("branch", this.txtBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			bool flag = Conversions.ToBoolean(dataRow["hasweight"]);
			if (flag)
			{
				this.radWeight.Checked = true;
				this.txtWeightLength.Text = dataRow["WeightLength"].ToString();
				this.txtWeightStart.Text = dataRow["WeightStartPosition"].ToString();
			}
			else
			{
				this.radPrice.Checked = true;
				this.txtPriceLength.Text = dataRow["PriceLength"].ToString();
				this.txtPriceStart.Text = dataRow["PriceStartPosition"].ToString();
			}
			this.txtCodeStartPosition.Text = dataRow["CodeStartPosition"].ToString();
			this.txtCodeLength.Text = dataRow["CodeLength"].ToString();
			this.txtStartingNumber.Text = dataRow["StartChar"].ToString();
			this.txtpath.Text = dataRow["filepath"].ToString();
			this.cboBarcodePrintingScaleName.Text = dataRow["scalename"].ToString();
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000C8FEC File Offset: 0x000C71EC
		private void SaveBarcodeScaleSettings()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BarcodeScaleSettingsInsert";
			sqlCommand.Parameters.AddWithValue("hasweight", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.radWeight.Checked, true, false)));
			sqlCommand.Parameters.AddWithValue("codestartposition", Conversions.ToInteger(this.txtCodeStartPosition.Text));
			sqlCommand.Parameters.AddWithValue("codelength", Conversions.ToInteger(this.txtCodeLength.Text));
			bool flag = Operators.CompareString(this.txtPriceStart.Text, "", false) != 0;
			if (flag)
			{
				sqlCommand.Parameters.AddWithValue("pricestartposition", Conversions.ToInteger(this.txtPriceStart.Text));
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("pricestartposition", 0);
			}
			bool flag2 = Operators.CompareString(this.txtPriceLength.Text, "", false) != 0;
			if (flag2)
			{
				sqlCommand.Parameters.AddWithValue("pricelength", Conversions.ToInteger(this.txtPriceLength.Text));
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("pricelength", 0);
			}
			bool flag3 = Operators.CompareString(this.txtWeightStart.Text, "", false) != 0;
			if (flag3)
			{
				sqlCommand.Parameters.AddWithValue("weightstartposition", Conversions.ToInteger(this.txtWeightStart.Text));
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("weightstartposition", 0);
			}
			bool flag4 = Operators.CompareString(this.txtWeightLength.Text, "", false) != 0;
			if (flag4)
			{
				sqlCommand.Parameters.AddWithValue("weightlength", Conversions.ToInteger(this.txtWeightLength.Text));
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("weightlength", 0);
			}
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("startchar", Conversions.ToInteger(this.txtStartingNumber.Text));
			sqlCommand.Parameters.AddWithValue("scalename", this.cboBarcodePrintingScaleName.Text);
			sqlCommand.Parameters.AddWithValue("filepath", this.txtpath.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000C934C File Offset: 0x000C754C
		private void FetchNegStockSettings()
		{
			bool flag = MyProject.Forms.Form1.NegativeStock == 1;
			if (flag)
			{
				this.chkNeg.Checked = true;
			}
			else
			{
				this.chkNeg.Checked = false;
				this.chkRecheckStockBal.Visible = true;
				bool flag2 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "RecheckStockBal", MyProject.Forms.Form1.Constring), "1", false) == 0;
				if (flag2)
				{
					this.chkRecheckStockBal.Checked = true;
				}
				else
				{
					this.chkRecheckStockBal.Checked = false;
				}
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x000C9410 File Offset: 0x000C7610
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.AddUpdateAppSettings("MarkUp", Conversions.ToString(Convert.ToDecimal(this.txtMarkUp.Text)));
				MyProject.Forms.Form1.MarkUp = Convert.ToDecimal(this.txtMarkUp.Text);
				MessageBox.Show("Mark up saved succesfully.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving details. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000C94A4 File Offset: 0x000C76A4
		private void txtMarkUp_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000C94F0 File Offset: 0x000C76F0
		private void chkAllowSales_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error detail: " + ex.Message);
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000C9538 File Offset: 0x000C7738
		private void chkTilPointChange_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkTilPointChange.Checked;
				if (@checked)
				{
					this.chkDiscountEditing.Visible = true;
					this.chkAllowDirectPriceEditing.Visible = true;
				}
				else
				{
					this.chkDiscountEditing.Visible = false;
					this.chkAllowDirectPriceEditing.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000C95B4 File Offset: 0x000C77B4
		private void chkIsTouchScreen_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkIsTouchScreen.Checked;
			if (@checked)
			{
				this.chkTables.Visible = true;
			}
			else
			{
				this.chkTables.Visible = false;
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x000C95F0 File Offset: 0x000C77F0
		private void chkRecordConsultant_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkRecordConsultant.Checked;
			if (@checked)
			{
				this.chkConsultantSales.Visible = true;
			}
			else
			{
				this.chkConsultantSales.Visible = false;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000C962C File Offset: 0x000C782C
		private void chkusingBarcodePrintingScale_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkusingBarcodePrintingScale.Checked;
			if (@checked)
			{
				this.grpBarcodePrintingScale.Visible = true;
				this.cboBarcodePrintingScaleName.Visible = true;
			}
			else
			{
				this.grpBarcodePrintingScale.Visible = false;
				this.cboBarcodePrintingScaleName.Visible = false;
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000C9684 File Offset: 0x000C7884
		private void radWeight_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.radWeight.Checked;
			if (@checked)
			{
				this.lblWeightLength.Visible = true;
				this.txtWeightLength.Visible = true;
				this.lblWeightStart.Visible = true;
				this.txtWeightStart.Visible = true;
				this.lblPriceLength.Visible = false;
				this.txtPriceLength.Visible = false;
				this.lblPricestart.Visible = false;
				this.txtPriceStart.Visible = false;
			}
			else
			{
				bool checked2 = this.radPrice.Checked;
				if (checked2)
				{
					this.lblWeightLength.Visible = false;
					this.txtWeightLength.Visible = false;
					this.lblWeightStart.Visible = false;
					this.txtWeightStart.Visible = false;
					this.lblPriceLength.Visible = true;
					this.txtPriceLength.Visible = true;
					this.lblPricestart.Visible = true;
					this.txtPriceStart.Visible = true;
				}
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00012800 File Offset: 0x00010A00
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00012800 File Offset: 0x00010A00
		private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtWeightStart_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtWeightLength_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtPriceStart_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtPriceLength_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtStartingNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000C9784 File Offset: 0x000C7984
		private void chkAccountSales_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkAccountSales.Checked;
			if (@checked)
			{
				this.chkShowCustomersInSalesForm.Checked = true;
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000C97B0 File Offset: 0x000C79B0
		private void chkUseCollections_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkUseCollections.Checked;
			if (@checked)
			{
				this.chkShowCustomersInSalesForm.Checked = true;
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x000C97DC File Offset: 0x000C79DC
		private void chkHasSecondScreen_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkHasSecondScreen.Checked;
			if (@checked)
			{
				this.lblpath.Visible = true;
				this.btnPath.Visible = true;
			}
			else
			{
				this.lblpath.Visible = false;
				this.btnPath.Visible = false;
			}
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000C9834 File Offset: 0x000C7A34
		private void btnPath_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.lblpath.Text = this.OpenFileDialog1.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error locating file. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000C98A8 File Offset: 0x000C7AA8
		private void chkUseConnectedScale_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkUseConnectedScale.Checked;
				if (@checked)
				{
					this.txtConnectedScalePortNum.Visible = true;
					this.Label17.Visible = true;
				}
				else
				{
					this.txtConnectedScalePortNum.Visible = false;
					this.Label17.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtConnectedScalePortNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtDecimals_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00012800 File Offset: 0x00010A00
		private void btnCountPerLine_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00012800 File Offset: 0x00010A00
		private void btnFontSize_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00012800 File Offset: 0x00010A00
		private void btnSpace_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00012800 File Offset: 0x00010A00
		private void btnWidth_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00012800 File Offset: 0x00010A00
		private void btnHeight_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000C9924 File Offset: 0x000C7B24
		public void GetSerialPortNames()
		{
			try
			{
				try
				{
					foreach (string text in MyProject.Computer.Ports.SerialPortNames)
					{
						this.ComboBox1.Items.Add(text);
					}
				}
				finally
				{
					IEnumerator<string> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtDefaultSellingQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000C99AC File Offset: 0x000C7BAC
		private void chkNeg_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Sales and stock transfers will proceed even if it means the affected stock balance will get into negative.", this.chkNeg);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000C99F4 File Offset: 0x000C7BF4
		private void chkTilPointChange_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Teller will press a button and window appears to select the discount amount. Supervisor credentials required to successfuly apply the product discount.", this.chkTilPointChange);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000C9A3C File Offset: 0x000C7C3C
		private void chkDiscountEditing_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Teller can enter a positive amount to increase the price or a negative amount to reduce it in a space provided. No supervisor credentials required.", this.chkDiscountEditing);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000C9A84 File Offset: 0x000C7C84
		private void chkAllowDirectPriceEditing_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("The Teller can edit the price of the product directly. No audit trail.", this.chkAllowDirectPriceEditing);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000C9ACC File Offset: 0x000C7CCC
		private void chkSearchCursor_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("If unticked, the forms will start with the cursor waiting for a barcode to be entered. If ticked, the cursor is at the product description search position", this.chkNeg);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x000C9B14 File Offset: 0x000C7D14
		private void chkTellerViewStockBalances_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Enables the teller to view stock balances on the sales form only.", this.chkTellerViewStockBalances);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000C9B5C File Offset: 0x000C7D5C
		private void chkAllowSales_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("This will allow sales to be processed on this computer.", this.chkAllowSales);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000C9BA4 File Offset: 0x000C7DA4
		private void chkRecordConsultant_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("The name of an existing user can be selected and saved with the invoice. Sales by Consultant report available.", this.chkRecordConsultant);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x000C9BEC File Offset: 0x000C7DEC
		private void chkConsultantSales_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("A sale will not proceed with a consultant selected. A consultant is an existing user in the system.", this.chkConsultantSales);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000C9C34 File Offset: 0x000C7E34
		private void chkAccountSales_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Enables sales on account/credit on this computer in addition to cash sales.", this.chkAccountSales);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000C9C7C File Offset: 0x000C7E7C
		private void chkCalcBackward_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("This results in the decimal figures having a slight difference.", this.chkCalcBackward);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000C9CC4 File Offset: 0x000C7EC4
		private void chkShowCustomersInSalesForm_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Enables selecting and entering Customers on the normal sales form. This does not apply to the touch screen sales form.", this.chkShowCustomersInSalesForm);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x000C9D0C File Offset: 0x000C7F0C
		private void chkDontShowQuotationOptions_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Hides the ability to Save quotations or to Print quotations on the default sales form.", this.chkDontShowQuotationOptions);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000C9D54 File Offset: 0x000C7F54
		private void chkDisableQuotations_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Assuming that Dont Show Quotation Options is not selected, this will show Print Quotation option and not the Save Quotations option on the default sales form.", this.chkDisableQuotations);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000C9D9C File Offset: 0x000C7F9C
		private void Label19_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Sets the default sale quantity on the sales form.", this.Label19);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000C9DE4 File Offset: 0x000C7FE4
		private void Label11_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Sets the number of decimal places to be used when calculating prices.", this.Label11);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000C9E2C File Offset: 0x000C802C
		private void chkOptimiseOnlineSearch_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Searching for a product will only begin after pressing Enter to minimise calls to a remote database.", this.chkOptimiseOnlineSearch);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x000C9E74 File Offset: 0x000C8074
		private void chkDontAutoAppend_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("After scanning a barcode, the system will highlight the previous barcode as opposed to removing it.", this.chkDontAutoAppend);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000C9EBC File Offset: 0x000C80BC
		private void chkLinkProductCreditWithInvoice_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("When processing a credit note for an individual product, an existing invoice with the product has to be selected first.", this.chkLinkProductCreditWithInvoice);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000C9F04 File Offset: 0x000C8104
		private void chkCustomerDisplay_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkCustomerDisplay.Checked;
			if (@checked)
			{
				this.txtCustomerDisplayText.Visible = true;
				this.Label21.Visible = true;
				this.txtCustomerDisplayCOMPORT.Visible = true;
				this.Label22.Visible = true;
			}
			else
			{
				this.txtCustomerDisplayText.Visible = false;
				this.Label21.Visible = false;
				this.txtCustomerDisplayCOMPORT.Visible = false;
				this.Label22.Visible = false;
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000C9F90 File Offset: 0x000C8190
		private void Button2_Click_1(object sender, EventArgs e)
		{
			try
			{
				TestComport testComport = new TestComport();
				testComport.ShowDialog();
				testComport.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000C9FEC File Offset: 0x000C81EC
		private void Button3_Click(object sender, EventArgs e)
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
				MessageBox.Show("Error selecting barcode printing scale file path. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000CA060 File Offset: 0x000C8260
		private void chkNeg_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkNeg.Checked;
				if (@checked)
				{
					this.chkRecheckStockBal.Visible = false;
					this.chkRecheckStockBal.Checked = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtMaxSellingQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x04000AC9 RID: 2761
		private string _cnn;

		// Token: 0x04000ACA RID: 2762
		private PublicFunctions pf;
	}
}
