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
	// Token: 0x020001FB RID: 507
	[DesignerGenerated]
	public partial class SupplierAccounts : UserControl
	{
		// Token: 0x06005ADF RID: 23263 RVA: 0x00346314 File Offset: 0x00344514
		public SupplierAccounts()
		{
			base.Load += this.SupplierAccounts_Load;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.therate = 0m;
			this.TextToPrint = "";
			this.InitializeComponent();
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x00348A3D File Offset: 0x00346C3D
		// (set) Token: 0x06005AE3 RID: 23267 RVA: 0x00348A47 File Offset: 0x00346C47
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06005AE4 RID: 23268 RVA: 0x00348A50 File Offset: 0x00346C50
		// (set) Token: 0x06005AE5 RID: 23269 RVA: 0x00348A5A File Offset: 0x00346C5A
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06005AE6 RID: 23270 RVA: 0x00348A63 File Offset: 0x00346C63
		// (set) Token: 0x06005AE7 RID: 23271 RVA: 0x00348A6D File Offset: 0x00346C6D
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06005AE8 RID: 23272 RVA: 0x00348A76 File Offset: 0x00346C76
		// (set) Token: 0x06005AE9 RID: 23273 RVA: 0x00348A80 File Offset: 0x00346C80
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06005AEA RID: 23274 RVA: 0x00348A89 File Offset: 0x00346C89
		// (set) Token: 0x06005AEB RID: 23275 RVA: 0x00348A93 File Offset: 0x00346C93
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06005AEC RID: 23276 RVA: 0x00348A9C File Offset: 0x00346C9C
		// (set) Token: 0x06005AED RID: 23277 RVA: 0x00348AA6 File Offset: 0x00346CA6
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06005AEE RID: 23278 RVA: 0x00348AAF File Offset: 0x00346CAF
		// (set) Token: 0x06005AEF RID: 23279 RVA: 0x00348AB9 File Offset: 0x00346CB9
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06005AF0 RID: 23280 RVA: 0x00348AC2 File Offset: 0x00346CC2
		// (set) Token: 0x06005AF1 RID: 23281 RVA: 0x00348ACC File Offset: 0x00346CCC
		internal virtual RadioButton radAccOnly
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x00348AD5 File Offset: 0x00346CD5
		// (set) Token: 0x06005AF3 RID: 23283 RVA: 0x00348ADF File Offset: 0x00346CDF
		internal virtual RadioButton radBoth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x00348AE8 File Offset: 0x00346CE8
		// (set) Token: 0x06005AF5 RID: 23285 RVA: 0x00348AF2 File Offset: 0x00346CF2
		internal virtual RadioButton radCashSales
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x00348AFB File Offset: 0x00346CFB
		// (set) Token: 0x06005AF7 RID: 23287 RVA: 0x00348B05 File Offset: 0x00346D05
		internal virtual CheckBox chkTodaysTrans
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06005AF8 RID: 23288 RVA: 0x00348B0E File Offset: 0x00346D0E
		// (set) Token: 0x06005AF9 RID: 23289 RVA: 0x00348B18 File Offset: 0x00346D18
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

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06005AFA RID: 23290 RVA: 0x00348B5B File Offset: 0x00346D5B
		// (set) Token: 0x06005AFB RID: 23291 RVA: 0x00348B68 File Offset: 0x00346D68
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

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06005AFC RID: 23292 RVA: 0x00348BAB File Offset: 0x00346DAB
		// (set) Token: 0x06005AFD RID: 23293 RVA: 0x00348BB5 File Offset: 0x00346DB5
		internal virtual Label lblBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06005AFE RID: 23294 RVA: 0x00348BBE File Offset: 0x00346DBE
		// (set) Token: 0x06005AFF RID: 23295 RVA: 0x00348BC8 File Offset: 0x00346DC8
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06005B00 RID: 23296 RVA: 0x00348BD1 File Offset: 0x00346DD1
		// (set) Token: 0x06005B01 RID: 23297 RVA: 0x00348BDC File Offset: 0x00346DDC
		internal virtual ComboBox cboSuppliers
		{
			[CompilerGenerated]
			get
			{
				return this._cboSuppliers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboSuppliers_SelectedIndexChanged);
				ComboBox comboBox = this._cboSuppliers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboSuppliers = value;
				comboBox = this._cboSuppliers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06005B02 RID: 23298 RVA: 0x00348C1F File Offset: 0x00346E1F
		// (set) Token: 0x06005B03 RID: 23299 RVA: 0x00348C29 File Offset: 0x00346E29
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06005B04 RID: 23300 RVA: 0x00348C32 File Offset: 0x00346E32
		// (set) Token: 0x06005B05 RID: 23301 RVA: 0x00348C3C File Offset: 0x00346E3C
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x00348C45 File Offset: 0x00346E45
		// (set) Token: 0x06005B07 RID: 23303 RVA: 0x00348C4F File Offset: 0x00346E4F
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06005B08 RID: 23304 RVA: 0x00348C58 File Offset: 0x00346E58
		// (set) Token: 0x06005B09 RID: 23305 RVA: 0x00348C62 File Offset: 0x00346E62
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06005B0A RID: 23306 RVA: 0x00348C6B File Offset: 0x00346E6B
		// (set) Token: 0x06005B0B RID: 23307 RVA: 0x00348C78 File Offset: 0x00346E78
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

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06005B0C RID: 23308 RVA: 0x00348CBB File Offset: 0x00346EBB
		// (set) Token: 0x06005B0D RID: 23309 RVA: 0x00348CC8 File Offset: 0x00346EC8
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

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06005B0E RID: 23310 RVA: 0x00348D0B File Offset: 0x00346F0B
		// (set) Token: 0x06005B0F RID: 23311 RVA: 0x00348D18 File Offset: 0x00346F18
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

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06005B10 RID: 23312 RVA: 0x00348D5B File Offset: 0x00346F5B
		// (set) Token: 0x06005B11 RID: 23313 RVA: 0x00348D65 File Offset: 0x00346F65
		internal virtual ComboBox cboBranch2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06005B12 RID: 23314 RVA: 0x00348D6E File Offset: 0x00346F6E
		// (set) Token: 0x06005B13 RID: 23315 RVA: 0x00348D78 File Offset: 0x00346F78
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06005B14 RID: 23316 RVA: 0x00348D81 File Offset: 0x00346F81
		// (set) Token: 0x06005B15 RID: 23317 RVA: 0x00348D8B File Offset: 0x00346F8B
		internal virtual DataGridView DataGridView2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06005B16 RID: 23318 RVA: 0x00348D94 File Offset: 0x00346F94
		// (set) Token: 0x06005B17 RID: 23319 RVA: 0x00348D9E File Offset: 0x00346F9E
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06005B18 RID: 23320 RVA: 0x00348DA7 File Offset: 0x00346FA7
		// (set) Token: 0x06005B19 RID: 23321 RVA: 0x00348DB1 File Offset: 0x00346FB1
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06005B1A RID: 23322 RVA: 0x00348DBA File Offset: 0x00346FBA
		// (set) Token: 0x06005B1B RID: 23323 RVA: 0x00348DC4 File Offset: 0x00346FC4
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06005B1C RID: 23324 RVA: 0x00348DCD File Offset: 0x00346FCD
		// (set) Token: 0x06005B1D RID: 23325 RVA: 0x00348DD7 File Offset: 0x00346FD7
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06005B1E RID: 23326 RVA: 0x00348DE0 File Offset: 0x00346FE0
		// (set) Token: 0x06005B1F RID: 23327 RVA: 0x00348DEA File Offset: 0x00346FEA
		internal virtual Label lblBal2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06005B20 RID: 23328 RVA: 0x00348DF3 File Offset: 0x00346FF3
		// (set) Token: 0x06005B21 RID: 23329 RVA: 0x00348DFD File Offset: 0x00346FFD
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06005B22 RID: 23330 RVA: 0x00348E06 File Offset: 0x00347006
		// (set) Token: 0x06005B23 RID: 23331 RVA: 0x00348E10 File Offset: 0x00347010
		internal virtual ComboBox cboSuppliers2
		{
			[CompilerGenerated]
			get
			{
				return this._cboSuppliers2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboSuppliers2_SelectedIndexChanged);
				ComboBox comboBox = this._cboSuppliers2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboSuppliers2 = value;
				comboBox = this._cboSuppliers2;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06005B24 RID: 23332 RVA: 0x00348E53 File Offset: 0x00347053
		// (set) Token: 0x06005B25 RID: 23333 RVA: 0x00348E5D File Offset: 0x0034705D
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06005B26 RID: 23334 RVA: 0x00348E66 File Offset: 0x00347066
		// (set) Token: 0x06005B27 RID: 23335 RVA: 0x00348E70 File Offset: 0x00347070
		internal virtual ComboBox cboBranch3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x00348E79 File Offset: 0x00347079
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x00348E83 File Offset: 0x00347083
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x00348E8C File Offset: 0x0034708C
		// (set) Token: 0x06005B2B RID: 23339 RVA: 0x00348E96 File Offset: 0x00347096
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x00348E9F File Offset: 0x0034709F
		// (set) Token: 0x06005B2D RID: 23341 RVA: 0x00348EA9 File Offset: 0x003470A9
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x00348EB2 File Offset: 0x003470B2
		// (set) Token: 0x06005B2F RID: 23343 RVA: 0x00348EBC File Offset: 0x003470BC
		internal virtual Label lblTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06005B30 RID: 23344 RVA: 0x00348EC5 File Offset: 0x003470C5
		// (set) Token: 0x06005B31 RID: 23345 RVA: 0x00348ECF File Offset: 0x003470CF
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06005B32 RID: 23346 RVA: 0x00348ED8 File Offset: 0x003470D8
		// (set) Token: 0x06005B33 RID: 23347 RVA: 0x00348EE2 File Offset: 0x003470E2
		internal virtual ComboBox cboREfund
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06005B34 RID: 23348 RVA: 0x00348EEB File Offset: 0x003470EB
		// (set) Token: 0x06005B35 RID: 23349 RVA: 0x00348EF5 File Offset: 0x003470F5
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06005B36 RID: 23350 RVA: 0x00348EFE File Offset: 0x003470FE
		// (set) Token: 0x06005B37 RID: 23351 RVA: 0x00348F08 File Offset: 0x00347108
		internal virtual TextBox txtComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06005B38 RID: 23352 RVA: 0x00348F11 File Offset: 0x00347111
		// (set) Token: 0x06005B39 RID: 23353 RVA: 0x00348F1C File Offset: 0x0034711C
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

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06005B3A RID: 23354 RVA: 0x00348F5F File Offset: 0x0034715F
		// (set) Token: 0x06005B3B RID: 23355 RVA: 0x00348F69 File Offset: 0x00347169
		internal virtual Label lblEffectiveAmtPaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06005B3C RID: 23356 RVA: 0x00348F72 File Offset: 0x00347172
		// (set) Token: 0x06005B3D RID: 23357 RVA: 0x00348F7C File Offset: 0x0034717C
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06005B3E RID: 23358 RVA: 0x00348F85 File Offset: 0x00347185
		// (set) Token: 0x06005B3F RID: 23359 RVA: 0x00348F90 File Offset: 0x00347190
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
				TextBox textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtAmtPaid = value;
				textBox = this._txtAmtPaid;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06005B40 RID: 23360 RVA: 0x00348FD3 File Offset: 0x003471D3
		// (set) Token: 0x06005B41 RID: 23361 RVA: 0x00348FDD File Offset: 0x003471DD
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06005B42 RID: 23362 RVA: 0x00348FE6 File Offset: 0x003471E6
		// (set) Token: 0x06005B43 RID: 23363 RVA: 0x00348FF0 File Offset: 0x003471F0
		internal virtual Label lblRate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06005B44 RID: 23364 RVA: 0x00348FF9 File Offset: 0x003471F9
		// (set) Token: 0x06005B45 RID: 23365 RVA: 0x00349003 File Offset: 0x00347203
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06005B46 RID: 23366 RVA: 0x0034900C File Offset: 0x0034720C
		// (set) Token: 0x06005B47 RID: 23367 RVA: 0x00349018 File Offset: 0x00347218
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

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06005B48 RID: 23368 RVA: 0x0034905B File Offset: 0x0034725B
		// (set) Token: 0x06005B49 RID: 23369 RVA: 0x00349065 File Offset: 0x00347265
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06005B4A RID: 23370 RVA: 0x0034906E File Offset: 0x0034726E
		// (set) Token: 0x06005B4B RID: 23371 RVA: 0x00349078 File Offset: 0x00347278
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

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06005B4C RID: 23372 RVA: 0x003490BB File Offset: 0x003472BB
		// (set) Token: 0x06005B4D RID: 23373 RVA: 0x003490C8 File Offset: 0x003472C8
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

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06005B4E RID: 23374 RVA: 0x0034910B File Offset: 0x0034730B
		// (set) Token: 0x06005B4F RID: 23375 RVA: 0x00349118 File Offset: 0x00347318
		internal virtual Label Label16
		{
			[CompilerGenerated]
			get
			{
				return this._Label16;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label16_Click);
				Label label = this._Label16;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label16 = value;
				label = this._Label16;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x0034915B File Offset: 0x0034735B
		// (set) Token: 0x06005B51 RID: 23377 RVA: 0x00349168 File Offset: 0x00347368
		internal virtual Label Label18
		{
			[CompilerGenerated]
			get
			{
				return this._Label18;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label18_Click);
				Label label = this._Label18;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label18 = value;
				label = this._Label18;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06005B52 RID: 23378 RVA: 0x003491AB File Offset: 0x003473AB
		// (set) Token: 0x06005B53 RID: 23379 RVA: 0x003491B5 File Offset: 0x003473B5
		internal virtual CheckBox chkCreditOnly
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06005B54 RID: 23380 RVA: 0x003491BE File Offset: 0x003473BE
		// (set) Token: 0x06005B55 RID: 23381 RVA: 0x003491C8 File Offset: 0x003473C8
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

		// Token: 0x06005B56 RID: 23382 RVA: 0x0034920C File Offset: 0x0034740C
		private void SupplierAccounts_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = this.pf.LoadBranches(this._cnn);
				this.cboBranch.DataSource = dataTable;
				this.cboBranch.ValueMember = "Branch";
				this.cboBranch.DisplayMember = "Branch";
				this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
				this.cboBranch2.DataSource = dataTable;
				this.cboBranch2.ValueMember = "Branch";
				this.cboBranch2.DisplayMember = "Branch";
				this.cboBranch2.SelectedIndex = this.cboBranch2.FindStringExact(MyProject.Forms.Form1.branch);
				this.cboBranch3.DataSource = dataTable;
				this.cboBranch3.ValueMember = "Branch";
				this.cboBranch3.DisplayMember = "Branch";
				this.cboBranch3.SelectedIndex = this.cboBranch3.FindStringExact(MyProject.Forms.Form1.branch);
				DataTable suppliersList = this.pf.GetSuppliersList(this._cnn);
				this.cboSuppliers.DataSource = suppliersList;
				this.cboSuppliers.ValueMember = "SupplierID";
				this.cboSuppliers.DisplayMember = "SupplierName";
				this.cboSuppliers.AutoCompleteMode = AutoCompleteMode.Suggest;
				this.cboSuppliers2.DataSource = suppliersList;
				this.cboSuppliers2.ValueMember = "SupplierID";
				this.cboSuppliers2.DisplayMember = "SupplierName";
				this.cboSuppliers2.AutoCompleteMode = AutoCompleteMode.Suggest;
				this.cboPaymentMethods.DataSource = this.pf.GetPaymentMethods(this._cnn);
				this.cboPaymentMethods.ValueMember = "PaymentMethodID";
				this.cboPaymentMethods.DisplayMember = "PaymentMethodDesc";
				this.cboPaymentMethods.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00349448 File Offset: 0x00347648
		private void cboSuppliers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboSuppliers.SelectedIndex > -1;
				if (flag)
				{
					this.lblBal.Text = this.pf.CalcSupplierBal(this._cnn, MyProject.Forms.Form1.coid, this.cboBranch.Text, Conversions.ToInteger(this.cboSuppliers.SelectedValue)).ToString();
				}
			}
			catch (Exception ex)
			{
				bool flag2 = Operators.CompareString(ex.Message, "Conversion from type 'DataRowView' to type 'Integer' is not valid.", false) == 0;
				if (!flag2)
				{
					MessageBox.Show("Error calc supplier acc bal. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x00349510 File Offset: 0x00347710
		private void LoadTrans()
		{
			this.DataGridView1.Columns.Clear();
			bool @checked = this.radBoth.Checked;
			if (!@checked)
			{
				bool checked2 = this.radAccOnly.Checked;
				if (!checked2)
				{
					bool checked3 = this.radCashSales.Checked;
					if (checked3)
					{
					}
				}
			}
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.Name = "View";
			dataGridViewButtonColumn.Text = "View Details";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.DataGridView1.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x003495B4 File Offset: 0x003477B4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.DataGridView1.Columns.Clear();
				this.DataGridView1.DataSource = this.GetSuppAccTrans(Conversions.ToInteger(this.cboSuppliers.SelectedValue), MyProject.Forms.Form1.coid, this.cboBranch.Text);
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				bool @checked = this.chkTodaysTrans.Checked;
				if (@checked)
				{
					MessageBox.Show("Today's transactions loaded for supplier " + this.cboSuppliers.Text);
				}
				else
				{
					MessageBox.Show("All transactions loaded for supplier " + this.cboSuppliers.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting supplier transactions. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x003496A0 File Offset: 0x003478A0
		private DataTable GetSuppAccTrans(int supplierid, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CreditorsTransactions";
			sqlCommand.Parameters.AddWithValue("supplierid", supplierid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("todaystrans", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkTodaysTrans.Checked, 1, 0)));
			sqlCommand.Parameters.AddWithValue("thedate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("creditonly", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkCreditOnly.Checked, 1, 0)));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x003497C4 File Offset: 0x003479C4
		private DataTable GetSuppAccTransAll(int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CreditorsTransactionsAll";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x00349840 File Offset: 0x00347A40
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.dat_trans = this.GetSuppAccTransAll(MyProject.Forms.Form1.coid, this.cboBranch2.Text);
				this.DataGridView2.DataSource = this.dat_trans;
				this.DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				MessageBox.Show("Balances for all suppliers loaded for branch " + this.cboBranch2.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading all supplier account balances. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x003498E8 File Offset: 0x00347AE8
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow[] array = this.dat_trans.Select("bal<>0");
				bool flag = array.Length > 0;
				if (flag)
				{
					this.DataGridView2.DataSource = array.CopyToDataTable<DataRow>();
					this.DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					MessageBox.Show("Grid filtered.");
				}
				else
				{
					DataTable dataTable = new DataTable();
					this.DataGridView2.DataSource = dataTable;
					MessageBox.Show("There are no rows that match the filter.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error filtering. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00349998 File Offset: 0x00347B98
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

		// Token: 0x06005B5F RID: 23391 RVA: 0x00349A50 File Offset: 0x00347C50
		private void cboPaymentMethods_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.therate = this.pf.GetRate(Conversions.ToInteger(this.cboPaymentMethods.SelectedValue), this._cnn);
				this.lblRate.Text = this.therate.ToString();
				this.calcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x00349AC8 File Offset: 0x00347CC8
		private void calcTotal()
		{
			this.lblEffectiveAmtPaid.Text = decimal.Divide(Convert.ToDecimal(this.txtAmtPaid.Text), Convert.ToDecimal(this.lblRate.Text)).ToString();
			this.lblTotal.Text = Convert.ToDecimal(this.txtAmtPaid.Text).ToString();
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x00349B34 File Offset: 0x00347D34
		private void txtAmtPaid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.calcTotal();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00349B6C File Offset: 0x00347D6C
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectLess(this.cboSuppliers2.SelectedValue, 0, false);
			if (flag)
			{
				MessageBox.Show("Please select the supplier first.");
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.Connection = sqlConnection;
				try
				{
					bool flag2 = Operators.CompareString(this.cboREfund.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please select PAYMENT OR REFUND.");
					}
					else
					{
						bool flag3 = Operators.CompareString(this.cboREfund.Text, "PAYMENT MADE", false) == 0;
						DialogResult dialogResult;
						if (flag3)
						{
							dialogResult = (DialogResult)Interaction.MsgBox(string.Concat(new string[]
							{
								"Do you want to accept the effective payment of: ",
								this.lblEffectiveAmtPaid.Text,
								" for supplier: ",
								this.cboSuppliers2.Text,
								"?"
							}), MsgBoxStyle.YesNo, null);
						}
						else
						{
							bool flag4 = Operators.CompareString(this.cboREfund.Text, "REFUND GIVEN", false) == 0;
							if (flag4)
							{
								dialogResult = (DialogResult)Interaction.MsgBox(string.Concat(new string[]
								{
									"Do you want to REFUND the account the effective amount of:  ",
									this.lblEffectiveAmtPaid.Text,
									" for supplier: ",
									this.cboSuppliers2.Text,
									"?"
								}), MsgBoxStyle.YesNo, null);
							}
						}
						bool flag5 = dialogResult == DialogResult.Yes;
						if (flag5)
						{
							sqlConnection.Open();
							SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunAcceptAccPayment");
							sqlCommand.Transaction = sqlTransaction;
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertCreditorLog";
							sqlCommand.Parameters.AddWithValue("SupplierID", RuntimeHelpers.GetObjectValue(this.cboSuppliers2.SelectedValue));
							sqlCommand.Parameters.AddWithValue("InvoiceNumber", 0);
							sqlCommand.Parameters.AddWithValue("ref", this.cboREfund.Text);
							sqlCommand.Parameters.AddWithValue("AmtChargedTotal", 0);
							sqlCommand.Parameters.AddWithValue("TaxAmt", 0);
							sqlCommand.Parameters.AddWithValue("bal", 0);
							sqlCommand.Parameters.AddWithValue("TranDate", Convert.ToInt32(this.DateTimePicker1.Value.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("TranTime", DateTime.Now.ToString("HH:mm"));
							sqlCommand.Parameters.AddWithValue("Coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("Branch", this.cboBranch3.Text);
							sqlCommand.Parameters.AddWithValue("Terms", 0);
							sqlCommand.Parameters.AddWithValue("DueDate", 0);
							sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPaymentMethods.SelectedValue));
							sqlCommand.Parameters.AddWithValue("paymentmethoddesc", this.cboPaymentMethods.Text);
							sqlCommand.Parameters.AddWithValue("Comment", this.txtComment.Text);
							sqlCommand.Parameters.AddWithValue("rate", Convert.ToDecimal(this.lblRate.Text));
							sqlCommand.Parameters.AddWithValue("uploaded", 0);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("mvtref", 0);
							bool flag6 = Operators.CompareString(this.cboREfund.Text, "REFUND GIVEN", false) == 0;
							if (flag6)
							{
								sqlCommand.Parameters.AddWithValue("TranType", 3);
								sqlCommand.Parameters.AddWithValue("AmtPaid", decimal.Multiply(Convert.ToDecimal(this.lblEffectiveAmtPaid.Text), -1m));
							}
							else
							{
								bool flag7 = Operators.CompareString(this.cboREfund.Text, "PAYMENT MADE", false) == 0;
								if (flag7)
								{
									sqlCommand.Parameters.AddWithValue("TranType", 2);
									sqlCommand.Parameters.AddWithValue("AmtPaid", Convert.ToDecimal(this.lblEffectiveAmtPaid.Text));
								}
							}
							sqlCommand.Parameters.AddWithValue("new_identity", 0);
							int num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
							sqlTransaction.Commit();
							sqlConnection.Close();
							this.lblBal2.Text = Conversions.ToString(this.pf.CalcSupplierBal(this._cnn, MyProject.Forms.Form1.coid, this.cboBranch3.Text, Conversions.ToInteger(this.cboSuppliers2.SelectedValue)));
							MessageBox.Show("Amount Accepted Successfully.");
							bool flag8 = Operators.CompareString(this.cboREfund.Text, "PAYMENT MADE", false) == 0;
							if (flag8)
							{
								DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Do you want to print a receipt?", MsgBoxStyle.YesNo, null);
								bool flag9 = dialogResult2 == DialogResult.Yes;
								if (flag9)
								{
									this.PrintReceipt(MyProject.Forms.Form1.username, num, this.cboSuppliers2.Text, "");
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
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x0034A1CC File Offset: 0x003483CC
		private void PrintReceipt(string username, int entry_num, string suppliername, string supplieradd)
		{
			try
			{
				this.GetBranchDetails();
				this.PrintHeader(username);
				this.ItemsToBePrinted(entry_num, this.PaymentDataRow(entry_num, MyProject.Forms.Form1.coid, this.cboSuppliers2.Text), this.AccountBalanceDataRow(Conversions.ToInteger(this.cboSuppliers2.SelectedValue), MyProject.Forms.Form1.coid, this.cboSuppliers2.Text), suppliername, supplieradd);
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

		// Token: 0x06005B64 RID: 23396 RVA: 0x0034A310 File Offset: 0x00348510
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

		// Token: 0x06005B65 RID: 23397 RVA: 0x0034A488 File Offset: 0x00348688
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

		// Token: 0x06005B66 RID: 23398 RVA: 0x0034A5DC File Offset: 0x003487DC
		public void PrintHeader(string tellername)
		{
			this.TextToPrint = "";
			string text = this.coname;
			int num = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag)
				{
					text = "BP Number: " + this.cobpnum;
					num = text.Length;
					string text3 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				}
				text = this.coadd;
				num = text.Length;
				bool flag2 = num > 49;
				if (flag2)
				{
					string text4 = text.Substring(0, 50);
					string text5 = text.Substring(50, num - 50);
					string text6 = new string(' ', (int)Math.Round(Math.Round((double)(50 - text4.Length) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text6 + text + Environment.NewLine;
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(50 - text5.Length) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text7 + text + Environment.NewLine;
				}
				else
				{
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text + Environment.NewLine;
				}
				bool flag3 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag3)
				{
					text = "Email: " + this.coemail;
					num = text.Length;
					string text9 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text + Environment.NewLine;
				}
				bool flag4 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag4)
				{
					text = this.cotel;
					num = text.Length;
					string text10 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text10 + text + Environment.NewLine;
				}
				bool flag5 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag5)
				{
					text = this.cotel2 + "  " + this.cotel3;
					num = text.Length;
					string text11 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text11 + text + Environment.NewLine;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				text = "Teller: " + tellername;
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = "Supplier: " + this.cboSuppliers2.Text;
				num = text.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x0034A9BC File Offset: 0x00348BBC
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
				string text4 = this.pf.CreateSpacer(50 - (18 + MyProject.Forms.Form1.basecurrency.Length + balancesDataRow["bal"].ToString().Length));
				text = string.Concat(new string[]
				{
					text,
					"Total Billed: ",
					text2,
					MyProject.Forms.Form1.basecurrency,
					balancesDataRow["amtcharged"].ToString(),
					Environment.NewLine
				});
				text = string.Concat(new string[]
				{
					text,
					"Total Paid:",
					text3,
					MyProject.Forms.Form1.basecurrency,
					balancesDataRow["amtpaid"].ToString(),
					Environment.NewLine,
					Environment.NewLine
				});
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

		// Token: 0x06005B68 RID: 23400 RVA: 0x0034ACB0 File Offset: 0x00348EB0
		private DataRow AccountBalanceDataRow(int supplierid, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCalcAccBalanceSupplier";
			sqlCommand.Parameters.AddWithValue("supplierid", supplierid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows[0];
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x0034AD50 File Offset: 0x00348F50
		private DataRow PaymentDataRow(int entrynum, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select [EntryNo],[SupplierName],[TranType],[InvoiceNumber],Convert (numeric(18,2),[AmtPaid]) as Amount,[TranDate],[TranTime],[DoneBy],[Coid],[Branch],[Terms],[DueDate],[PaymentMethodID],[PaymentMethodDesc],[ref],[Comment],[rate],[Uploaded],[machinename] from CreditorsLog where entryno = ",
				Conversions.ToString(entrynum),
				" and coid= ",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows[0];
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x0034ADEC File Offset: 0x00348FEC
		private void Label14_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label16_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label18_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x0034AE24 File Offset: 0x00349024
		private void cboSuppliers2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboSuppliers2.SelectedIndex > -1;
				if (flag)
				{
					this.lblBal2.Text = this.pf.CalcSupplierBal(this._cnn, MyProject.Forms.Form1.coid, this.cboBranch3.Text, Conversions.ToInteger(this.cboSuppliers2.SelectedValue)).ToString();
				}
			}
			catch (Exception ex)
			{
				bool flag2 = Operators.CompareString(ex.Message, "Conversion from type 'DataRowView' to type 'Integer' is not valid.", false) == 0;
				if (!flag2)
				{
					MessageBox.Show("Error calc supplier acc bal. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x0034AEEC File Offset: 0x003490EC
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				new SupplierAging
				{
					supplierid = Conversions.ToInteger(this.cboSuppliers.SelectedValue),
					suppliername = this.cboSuppliers.Text
				}.ShowDialog(this);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening aging. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040027EC RID: 10220
		private PublicFunctions pf;

		// Token: 0x040027ED RID: 10221
		private string _cnn;

		// Token: 0x040027EE RID: 10222
		private DataTable dat_trans;

		// Token: 0x040027EF RID: 10223
		private decimal therate;

		// Token: 0x040027F0 RID: 10224
		private string TextToPrint;

		// Token: 0x040027F1 RID: 10225
		private string coname;

		// Token: 0x040027F2 RID: 10226
		private string coadd;

		// Token: 0x040027F3 RID: 10227
		private string cotel;

		// Token: 0x040027F4 RID: 10228
		private string coemail;

		// Token: 0x040027F5 RID: 10229
		private string cobpnum;

		// Token: 0x040027F6 RID: 10230
		private string cotel2;

		// Token: 0x040027F7 RID: 10231
		private string cotel3;

		// Token: 0x040027F8 RID: 10232
		private StringReader stringToRead;
	}
}
