using System;
using System.Collections;
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
	// Token: 0x02000215 RID: 533
	[DesignerGenerated]
	public partial class ViewQuotations : UserControl
	{
		// Token: 0x06005F4F RID: 24399 RVA: 0x00369234 File Offset: 0x00367434
		public ViewQuotations()
		{
			base.Load += this.ViewQuotations_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currQuotationNumber = 0;
			this.currCustomerEntryno = 0;
			this.pf = new PublicFunctions();
			this.mono_rate = 0m;
			this.currval = 0m;
			this.InitializeComponent();
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x0036BA2F File Offset: 0x00369C2F
		// (set) Token: 0x06005F53 RID: 24403 RVA: 0x0036BA3C File Offset: 0x00369C3C
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

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x0036BA7F File Offset: 0x00369C7F
		// (set) Token: 0x06005F55 RID: 24405 RVA: 0x0036BA89 File Offset: 0x00369C89
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x0036BA92 File Offset: 0x00369C92
		// (set) Token: 0x06005F57 RID: 24407 RVA: 0x0036BA9C File Offset: 0x00369C9C
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x0036BAA5 File Offset: 0x00369CA5
		// (set) Token: 0x06005F59 RID: 24409 RVA: 0x0036BAB0 File Offset: 0x00369CB0
		internal virtual DataGridView dgvQuotations
		{
			[CompilerGenerated]
			get
			{
				return this._dgvQuotations;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvQuotations_CellContentClick);
				DataGridView dataGridView = this._dgvQuotations;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvQuotations = value;
				dataGridView = this._dgvQuotations;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06005F5A RID: 24410 RVA: 0x0036BAF3 File Offset: 0x00369CF3
		// (set) Token: 0x06005F5B RID: 24411 RVA: 0x0036BB00 File Offset: 0x00369D00
		internal virtual GroupBox GroupBox1
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox1_Enter);
				GroupBox groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox1 = value;
				groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x06005F5C RID: 24412 RVA: 0x0036BB43 File Offset: 0x00369D43
		// (set) Token: 0x06005F5D RID: 24413 RVA: 0x0036BB4D File Offset: 0x00369D4D
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x0036BB56 File Offset: 0x00369D56
		// (set) Token: 0x06005F5F RID: 24415 RVA: 0x0036BB60 File Offset: 0x00369D60
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06005F60 RID: 24416 RVA: 0x0036BB69 File Offset: 0x00369D69
		// (set) Token: 0x06005F61 RID: 24417 RVA: 0x0036BB73 File Offset: 0x00369D73
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x06005F62 RID: 24418 RVA: 0x0036BB7C File Offset: 0x00369D7C
		// (set) Token: 0x06005F63 RID: 24419 RVA: 0x0036BB86 File Offset: 0x00369D86
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06005F64 RID: 24420 RVA: 0x0036BB8F File Offset: 0x00369D8F
		// (set) Token: 0x06005F65 RID: 24421 RVA: 0x0036BB99 File Offset: 0x00369D99
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x0036BBA2 File Offset: 0x00369DA2
		// (set) Token: 0x06005F67 RID: 24423 RVA: 0x0036BBAC File Offset: 0x00369DAC
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06005F68 RID: 24424 RVA: 0x0036BBB5 File Offset: 0x00369DB5
		// (set) Token: 0x06005F69 RID: 24425 RVA: 0x0036BBBF File Offset: 0x00369DBF
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x0036BBC8 File Offset: 0x00369DC8
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x0036BBD4 File Offset: 0x00369DD4
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x0036BC17 File Offset: 0x00369E17
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x0036BC24 File Offset: 0x00369E24
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

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x0036BC67 File Offset: 0x00369E67
		// (set) Token: 0x06005F6F RID: 24431 RVA: 0x0036BC71 File Offset: 0x00369E71
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x0036BC7A File Offset: 0x00369E7A
		// (set) Token: 0x06005F71 RID: 24433 RVA: 0x0036BC84 File Offset: 0x00369E84
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06005F72 RID: 24434 RVA: 0x0036BC8D File Offset: 0x00369E8D
		// (set) Token: 0x06005F73 RID: 24435 RVA: 0x0036BC97 File Offset: 0x00369E97
		internal virtual CheckBox chkAllUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06005F74 RID: 24436 RVA: 0x0036BCA0 File Offset: 0x00369EA0
		// (set) Token: 0x06005F75 RID: 24437 RVA: 0x0036BCAA File Offset: 0x00369EAA
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06005F76 RID: 24438 RVA: 0x0036BCB3 File Offset: 0x00369EB3
		// (set) Token: 0x06005F77 RID: 24439 RVA: 0x0036BCBD File Offset: 0x00369EBD
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x0036BCC6 File Offset: 0x00369EC6
		// (set) Token: 0x06005F79 RID: 24441 RVA: 0x0036BCD0 File Offset: 0x00369ED0
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x0036BCD9 File Offset: 0x00369ED9
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x0036BCE3 File Offset: 0x00369EE3
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x0036BCEC File Offset: 0x00369EEC
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x0036BCF6 File Offset: 0x00369EF6
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x0036BCFF File Offset: 0x00369EFF
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x0036BD0C File Offset: 0x00369F0C
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
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView1_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
				DataGridViewCellCancelEventHandler dataGridViewCellCancelEventHandler = new DataGridViewCellCancelEventHandler(this.DataGridView1_CellBeginEdit);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellValidating -= dataGridViewCellValidatingEventHandler;
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
					dataGridView.CellBeginEdit -= dataGridViewCellCancelEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellValidating += dataGridViewCellValidatingEventHandler;
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
					dataGridView.CellBeginEdit += dataGridViewCellCancelEventHandler;
				}
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06005F80 RID: 24448 RVA: 0x0036BD85 File Offset: 0x00369F85
		// (set) Token: 0x06005F81 RID: 24449 RVA: 0x0036BD8F File Offset: 0x00369F8F
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x0036BD98 File Offset: 0x00369F98
		// (set) Token: 0x06005F83 RID: 24451 RVA: 0x0036BDA2 File Offset: 0x00369FA2
		internal virtual Label lblQuotationNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x0036BDAB File Offset: 0x00369FAB
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x0036BDB5 File Offset: 0x00369FB5
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x0036BDBE File Offset: 0x00369FBE
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x0036BDC8 File Offset: 0x00369FC8
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x0036BDD1 File Offset: 0x00369FD1
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x0036BDDB File Offset: 0x00369FDB
		internal virtual TextBox txtCustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x0036BDE4 File Offset: 0x00369FE4
		// (set) Token: 0x06005F8B RID: 24459 RVA: 0x0036BDEE File Offset: 0x00369FEE
		internal virtual Label lblDateCreated
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x0036BDF7 File Offset: 0x00369FF7
		// (set) Token: 0x06005F8D RID: 24461 RVA: 0x0036BE01 File Offset: 0x0036A001
		internal virtual Label lblCreatedBy
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x0036BE0A File Offset: 0x0036A00A
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x0036BE14 File Offset: 0x0036A014
		internal virtual Label lblBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x0036BE1D File Offset: 0x0036A01D
		// (set) Token: 0x06005F91 RID: 24465 RVA: 0x0036BE27 File Offset: 0x0036A027
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06005F92 RID: 24466 RVA: 0x0036BE30 File Offset: 0x0036A030
		// (set) Token: 0x06005F93 RID: 24467 RVA: 0x0036BE3A File Offset: 0x0036A03A
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06005F94 RID: 24468 RVA: 0x0036BE43 File Offset: 0x0036A043
		// (set) Token: 0x06005F95 RID: 24469 RVA: 0x0036BE4D File Offset: 0x0036A04D
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x0036BE56 File Offset: 0x0036A056
		// (set) Token: 0x06005F97 RID: 24471 RVA: 0x0036BE60 File Offset: 0x0036A060
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06005F98 RID: 24472 RVA: 0x0036BE69 File Offset: 0x0036A069
		// (set) Token: 0x06005F99 RID: 24473 RVA: 0x0036BE73 File Offset: 0x0036A073
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06005F9A RID: 24474 RVA: 0x0036BE7C File Offset: 0x0036A07C
		// (set) Token: 0x06005F9B RID: 24475 RVA: 0x0036BE88 File Offset: 0x0036A088
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

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06005F9C RID: 24476 RVA: 0x0036BECB File Offset: 0x0036A0CB
		// (set) Token: 0x06005F9D RID: 24477 RVA: 0x0036BED8 File Offset: 0x0036A0D8
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

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06005F9E RID: 24478 RVA: 0x0036BF1B File Offset: 0x0036A11B
		// (set) Token: 0x06005F9F RID: 24479 RVA: 0x0036BF28 File Offset: 0x0036A128
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

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06005FA0 RID: 24480 RVA: 0x0036BF6B File Offset: 0x0036A16B
		// (set) Token: 0x06005FA1 RID: 24481 RVA: 0x0036BF75 File Offset: 0x0036A175
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06005FA2 RID: 24482 RVA: 0x0036BF7E File Offset: 0x0036A17E
		// (set) Token: 0x06005FA3 RID: 24483 RVA: 0x0036BF88 File Offset: 0x0036A188
		internal virtual ComboBox cboPayMeth
		{
			[CompilerGenerated]
			get
			{
				return this._cboPayMeth;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPayMeth_SelectedIndexChanged);
				ComboBox comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPayMeth = value;
				comboBox = this._cboPayMeth;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06005FA4 RID: 24484 RVA: 0x0036BFCB File Offset: 0x0036A1CB
		// (set) Token: 0x06005FA5 RID: 24485 RVA: 0x0036BFD8 File Offset: 0x0036A1D8
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

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06005FA6 RID: 24486 RVA: 0x0036C01B File Offset: 0x0036A21B
		// (set) Token: 0x06005FA7 RID: 24487 RVA: 0x0036C028 File Offset: 0x0036A228
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

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06005FA8 RID: 24488 RVA: 0x0036C06B File Offset: 0x0036A26B
		// (set) Token: 0x06005FA9 RID: 24489 RVA: 0x0036C075 File Offset: 0x0036A275
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x0036C07E File Offset: 0x0036A27E
		// (set) Token: 0x06005FAB RID: 24491 RVA: 0x0036C088 File Offset: 0x0036A288
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x0036C091 File Offset: 0x0036A291
		// (set) Token: 0x06005FAD RID: 24493 RVA: 0x0036C09B File Offset: 0x0036A29B
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06005FAE RID: 24494 RVA: 0x0036C0A4 File Offset: 0x0036A2A4
		// (set) Token: 0x06005FAF RID: 24495 RVA: 0x0036C0AE File Offset: 0x0036A2AE
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06005FB0 RID: 24496 RVA: 0x0036C0B7 File Offset: 0x0036A2B7
		// (set) Token: 0x06005FB1 RID: 24497 RVA: 0x0036C0C1 File Offset: 0x0036A2C1
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x0036C0CA File Offset: 0x0036A2CA
		// (set) Token: 0x06005FB3 RID: 24499 RVA: 0x0036C0D4 File Offset: 0x0036A2D4
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x0036C0DD File Offset: 0x0036A2DD
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x0036C0E7 File Offset: 0x0036A2E7
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06005FB6 RID: 24502 RVA: 0x0036C0F0 File Offset: 0x0036A2F0
		// (set) Token: 0x06005FB7 RID: 24503 RVA: 0x0036C0FA File Offset: 0x0036A2FA
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06005FB8 RID: 24504 RVA: 0x0036C103 File Offset: 0x0036A303
		// (set) Token: 0x06005FB9 RID: 24505 RVA: 0x0036C10D File Offset: 0x0036A30D
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06005FBA RID: 24506 RVA: 0x0036C116 File Offset: 0x0036A316
		// (set) Token: 0x06005FBB RID: 24507 RVA: 0x0036C120 File Offset: 0x0036A320
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06005FBC RID: 24508 RVA: 0x0036C129 File Offset: 0x0036A329
		// (set) Token: 0x06005FBD RID: 24509 RVA: 0x0036C133 File Offset: 0x0036A333
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06005FBE RID: 24510 RVA: 0x0036C13C File Offset: 0x0036A33C
		// (set) Token: 0x06005FBF RID: 24511 RVA: 0x0036C146 File Offset: 0x0036A346
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06005FC0 RID: 24512 RVA: 0x0036C14F File Offset: 0x0036A34F
		// (set) Token: 0x06005FC1 RID: 24513 RVA: 0x0036C159 File Offset: 0x0036A359
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06005FC2 RID: 24514 RVA: 0x0036C162 File Offset: 0x0036A362
		// (set) Token: 0x06005FC3 RID: 24515 RVA: 0x0036C16C File Offset: 0x0036A36C
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x0036C175 File Offset: 0x0036A375
		// (set) Token: 0x06005FC5 RID: 24517 RVA: 0x0036C17F File Offset: 0x0036A37F
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06005FC6 RID: 24518 RVA: 0x0036C188 File Offset: 0x0036A388
		// (set) Token: 0x06005FC7 RID: 24519 RVA: 0x0036C192 File Offset: 0x0036A392
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x0036C19B File Offset: 0x0036A39B
		// (set) Token: 0x06005FC9 RID: 24521 RVA: 0x0036C1A5 File Offset: 0x0036A3A5
		internal virtual DataGridViewTextBoxColumn DiscPaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x0036C1AE File Offset: 0x0036A3AE
		// (set) Token: 0x06005FCB RID: 24523 RVA: 0x0036C1B8 File Offset: 0x0036A3B8
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x06005FCC RID: 24524 RVA: 0x0036C1C1 File Offset: 0x0036A3C1
		// (set) Token: 0x06005FCD RID: 24525 RVA: 0x0036C1CB File Offset: 0x0036A3CB
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06005FCE RID: 24526 RVA: 0x0036C1D4 File Offset: 0x0036A3D4
		// (set) Token: 0x06005FCF RID: 24527 RVA: 0x0036C1DE File Offset: 0x0036A3DE
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06005FD0 RID: 24528 RVA: 0x0036C1E7 File Offset: 0x0036A3E7
		// (set) Token: 0x06005FD1 RID: 24529 RVA: 0x0036C1F1 File Offset: 0x0036A3F1
		internal virtual DataGridViewTextBoxColumn Taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x0036C1FA File Offset: 0x0036A3FA
		// (set) Token: 0x06005FD3 RID: 24531 RVA: 0x0036C204 File Offset: 0x0036A404
		internal virtual DataGridViewTextBoxColumn PromStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06005FD4 RID: 24532 RVA: 0x0036C20D File Offset: 0x0036A40D
		// (set) Token: 0x06005FD5 RID: 24533 RVA: 0x0036C217 File Offset: 0x0036A417
		internal virtual DataGridViewTextBoxColumn OtherDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x06005FD6 RID: 24534 RVA: 0x0036C220 File Offset: 0x0036A420
		// (set) Token: 0x06005FD7 RID: 24535 RVA: 0x0036C22A File Offset: 0x0036A42A
		internal virtual DataGridViewTextBoxColumn IsVoucher
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x0036C233 File Offset: 0x0036A433
		// (set) Token: 0x06005FD9 RID: 24537 RVA: 0x0036C23D File Offset: 0x0036A43D
		internal virtual DataGridViewTextBoxColumn Comments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x0036C246 File Offset: 0x0036A446
		// (set) Token: 0x06005FDB RID: 24539 RVA: 0x0036C250 File Offset: 0x0036A450
		internal virtual DataGridViewTextBoxColumn RowNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06005FDC RID: 24540 RVA: 0x0036C259 File Offset: 0x0036A459
		// (set) Token: 0x06005FDD RID: 24541 RVA: 0x0036C263 File Offset: 0x0036A463
		internal virtual DataGridViewTextBoxColumn UOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06005FDE RID: 24542 RVA: 0x0036C26C File Offset: 0x0036A46C
		// (set) Token: 0x06005FDF RID: 24543 RVA: 0x0036C276 File Offset: 0x0036A476
		internal virtual DataGridViewTextBoxColumn Break
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06005FE0 RID: 24544 RVA: 0x0036C27F File Offset: 0x0036A47F
		// (set) Token: 0x06005FE1 RID: 24545 RVA: 0x0036C289 File Offset: 0x0036A489
		internal virtual DataGridViewTextBoxColumn BreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x06005FE2 RID: 24546 RVA: 0x0036C292 File Offset: 0x0036A492
		// (set) Token: 0x06005FE3 RID: 24547 RVA: 0x0036C29C File Offset: 0x0036A49C
		internal virtual DataGridViewTextBoxColumn BreakParentProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x06005FE4 RID: 24548 RVA: 0x0036C2A5 File Offset: 0x0036A4A5
		// (set) Token: 0x06005FE5 RID: 24549 RVA: 0x0036C2AF File Offset: 0x0036A4AF
		internal virtual DataGridViewTextBoxColumn ActualBreakQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x06005FE6 RID: 24550 RVA: 0x0036C2B8 File Offset: 0x0036A4B8
		// (set) Token: 0x06005FE7 RID: 24551 RVA: 0x0036C2C2 File Offset: 0x0036A4C2
		internal virtual TextBox txtSearchQuotationNum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x06005FE8 RID: 24552 RVA: 0x0036C2CB File Offset: 0x0036A4CB
		// (set) Token: 0x06005FE9 RID: 24553 RVA: 0x0036C2D8 File Offset: 0x0036A4D8
		internal virtual CheckBox chkSearchQuotationNum
		{
			[CompilerGenerated]
			get
			{
				return this._chkSearchQuotationNum;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkSearchQuotationNum_CheckedChanged);
				CheckBox checkBox = this._chkSearchQuotationNum;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkSearchQuotationNum = value;
				checkBox = this._chkSearchQuotationNum;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x06005FEA RID: 24554 RVA: 0x0036C31B File Offset: 0x0036A51B
		// (set) Token: 0x06005FEB RID: 24555 RVA: 0x0036C325 File Offset: 0x0036A525
		internal virtual CheckBox chkViewALlQ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x0036C330 File Offset: 0x0036A530
		private void ViewQuotations_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadUsers(MyProject.Forms.Form1.coid);
				this.cboPayMeth.DataSource = this.pf.GetPaymentMethods(this._cnn);
				this.cboPayMeth.DisplayMember = "PaymentMethodDesc";
				this.cboPayMeth.ValueMember = "PaymentMethodID";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x0036C3D4 File Offset: 0x0036A5D4
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
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x0036C498 File Offset: 0x0036A698
		private void LoadUsers(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.cboUsers.DataSource = dataTable;
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.ValueMember = "Username";
				this.cboUsers.SelectedIndex = this.cboUsers.FindStringExact(MyProject.Forms.Form1.username);
			}
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x0036C55C File Offset: 0x0036A75C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.dgvQuotations.Columns.Clear();
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				bool @checked = this.chkViewALlQ.Checked;
				if (@checked)
				{
					bool checked2 = this.chkSearchQuotationNum.Checked;
					if (checked2)
					{
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"Select QuotationNum,CustomerRef,customerrefentryno,sum((quantity*sellingprice) + Tax) as inv_total,CreatedBy,CreatedDate,InvoiceNum from quotations where coid=",
							Conversions.ToString(MyProject.Forms.Form1.coid),
							" and branch='",
							this.cboBranch.Text,
							"' and QuotationNum=",
							Conversions.ToString(Conversion.Val(this.txtSearchQuotationNum.Text)),
							" group by QuotationNum,createdby,createddate,CustomerRef,customerrefentryno,invoicenum"
						});
						this.lblinfo.Text = "Viewing quotation " + this.txtSearchQuotationNum.Text;
					}
					else
					{
						bool checked3 = this.chkAllUsers.Checked;
						if (checked3)
						{
							sqlCommand.CommandText = string.Concat(new string[]
							{
								"Select QuotationNum,CustomerRef,customerrefentryno,sum((quantity*sellingprice) + Tax) as inv_total,CreatedBy,CreatedDate,InvoiceNum from quotations where coid=",
								Conversions.ToString(MyProject.Forms.Form1.coid),
								" and branch='",
								this.cboBranch.Text,
								"' and createddate>=",
								Conversions.ToString(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))),
								" and createddate<=",
								Conversions.ToString(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))),
								" group by QuotationNum,createdby,createddate,CustomerRef,customerrefentryno,invoicenum"
							});
							this.lblinfo.Text = "Viewing quotations for all users";
						}
						else
						{
							sqlCommand.CommandText = string.Concat(new string[]
							{
								"Select QuotationNum,CustomerRef,customerrefentryno,sum((quantity*sellingprice) + Tax) as inv_total,CreatedBy,CreatedDate,InvoiceNum from quotations where coid=",
								Conversions.ToString(MyProject.Forms.Form1.coid),
								" and branch='",
								this.cboBranch.Text,
								"' and createddate>=",
								Conversions.ToString(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))),
								" and createddate<=",
								Conversions.ToString(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))),
								" and createdby='",
								this.cboUsers.Text,
								"' group by QuotationNum,createdby,createddate,CustomerRef,customerrefentryno,invoicenum"
							});
							this.lblinfo.Text = "Viewing quotations for " + this.cboUsers.Text;
						}
					}
				}
				else
				{
					bool checked4 = this.chkSearchQuotationNum.Checked;
					if (checked4)
					{
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"Select QuotationNum,CustomerRef,customerrefentryno,sum((quantity*sellingprice) + Tax) as inv_total,CreatedBy,CreatedDate,InvoiceNum from quotations where coid=",
							Conversions.ToString(MyProject.Forms.Form1.coid),
							" and invoicenum is null and branch='",
							this.cboBranch.Text,
							"' and QuotationNum=",
							Conversions.ToString(Conversion.Val(this.txtSearchQuotationNum.Text)),
							" group by QuotationNum,createdby,createddate,CustomerRef,customerrefentryno,invoicenum"
						});
						this.lblinfo.Text = "Viewing quotation " + this.txtSearchQuotationNum.Text;
					}
					else
					{
						bool checked5 = this.chkAllUsers.Checked;
						if (checked5)
						{
							sqlCommand.CommandText = string.Concat(new string[]
							{
								"Select QuotationNum,CustomerRef,customerrefentryno,sum((quantity*sellingprice) + Tax) as inv_total,CreatedBy,CreatedDate,InvoiceNum from quotations where coid=",
								Conversions.ToString(MyProject.Forms.Form1.coid),
								" and invoicenum is null and branch='",
								this.cboBranch.Text,
								"' and createddate>=",
								Conversions.ToString(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))),
								" and createddate<=",
								Conversions.ToString(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))),
								" group by QuotationNum,createdby,createddate,CustomerRef,customerrefentryno,invoicenum"
							});
							this.lblinfo.Text = "Viewing quotations for all users";
						}
						else
						{
							sqlCommand.CommandText = string.Concat(new string[]
							{
								"Select QuotationNum,CustomerRef,customerrefentryno,sum((quantity*sellingprice) + Tax) as inv_total,CreatedBy,CreatedDate,InvoiceNum from quotations where coid=",
								Conversions.ToString(MyProject.Forms.Form1.coid),
								" and invoicenum is null and branch='",
								this.cboBranch.Text,
								"' and createddate>=",
								Conversions.ToString(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))),
								" and createddate<=",
								Conversions.ToString(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))),
								" and createdby='",
								this.cboUsers.Text,
								"' group by QuotationNum,createdby,createddate,CustomerRef,customerrefentryno,invoicenum"
							});
							this.lblinfo.Text = "Viewing quotations for " + this.cboUsers.Text;
						}
					}
				}
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				this.dgvQuotations.DataSource = dataTable;
				this.dgvQuotations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.Name = "View";
				dataGridViewButtonColumn.DataPropertyName = "View";
				dataGridViewButtonColumn.HeaderText = "View Quotation";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.DefaultCellStyle.BackColor = Color.DarkGray;
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvQuotations.Columns.Add(dataGridViewButtonColumn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error fetching quotations. Detail:");
			}
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x0036CB5C File Offset: 0x0036AD5C
		private void dgvQuotations_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						this.currQuotationNumber = Conversions.ToInteger(this.dgvQuotations.Rows[e.RowIndex].Cells["quotationnum"].Value);
						this.TabControl1.SelectedIndex = 1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x0036CC44 File Offset: 0x0036AE44
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.TabControl1.SelectedIndex == 1;
				if (flag)
				{
					this.LoadQuoatation(this.currQuotationNumber);
				}
				else
				{
					bool flag2 = this.TabControl1.SelectedIndex == 0;
					if (flag2)
					{
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x0036CCC0 File Offset: 0x0036AEC0
		private void LoadQuoatation(int quotation_num)
		{
			this.DataGridView1.Rows.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select * from quotations where QuotationNum=" + Conversions.ToString(quotation_num);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblQuotationNumber.Text = Conversions.ToString(dataRow["QuotationNum"]);
				this.lblCreatedBy.Text = Conversions.ToString(dataRow["CreatedBY"]);
				this.lblDateCreated.Text = this.pf.ReturnDate(dataRow["CreatedDate"].ToString(), "yyyyMMdd").ToShortDateString();
				this.lblBranch.Text = Conversions.ToString(dataRow["Branch"]);
				this.cboPayMeth.SelectedIndex = this.cboPayMeth.FindStringExact(Conversions.ToString(dataRow["paymentmethod"]));
				DataTable customerByEntryNo = this.pf.GetCustomerByEntryNo(this.lblBranch.Text, MyProject.Forms.Form1.coid, Conversions.ToInteger(this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(dataRow["customerRefEntryNo"]))), this._cnn);
				try
				{
					DataRow dataRow2 = customerByEntryNo.Rows[0];
					this.txtCustomer.Text = Conversions.ToString(dataRow2["Customername"]);
				}
				catch (Exception ex)
				{
				}
				decimal num2 = 0m;
				decimal num3 = 0m;
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow3 = (DataRow)obj;
						decimal num4 = Conversions.ToDecimal(Operators.AddObject(Operators.MultiplyObject(dataRow3["SellingPrice"], dataRow3["Quantity"]), this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(dataRow3["Tax"]))));
						decimal num5 = Conversions.ToDecimal(this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(dataRow3["Tax"])));
						string[] array = new string[]
						{
							Conversions.ToString(dataRow3["ProductID"]),
							Conversions.ToString(dataRow3["ProductCode"]),
							Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["productdesc"], " "), dataRow3["altdesc"])),
							Conversions.ToString(dataRow3["SellingPrice"]),
							Conversions.ToString(dataRow3["Quantity"]),
							this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(dataRow3["Tax"])),
							Conversions.ToString(num4),
							Conversions.ToString(dataRow3["UnitCost"]),
							"",
							this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(dataRow3["OldPrice"])),
							"",
							Conversions.ToString(0),
							"",
							"",
							"",
							"",
							"",
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["ProductDiscAmt"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["ProductDiscAmt"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["BatchNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow3["BatchNumber"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["ExpiryDate"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["ExpiryDate"]))),
							Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["Taxrate"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["Taxrate"]))),
							"",
							"",
							"",
							"",
							"",
							"",
							""
						};
						num2 = decimal.Add(num2, num4);
						num3 = decimal.Add(num3, num5);
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
				this.txtTotal.Text = MyProject.Forms.Form1.basecurrency + num2.ToString();
				this.txtTax.Text = MyProject.Forms.Form1.basecurrency + num3.ToString();
			}
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label14_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x0036D24C File Offset: 0x0036B44C
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					MyProject.Forms.Form1.dgvQuotations.Columns.Clear();
					try
					{
						foreach (object obj in this.DataGridView1.Columns)
						{
							DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
							MyProject.Forms.Form1.dgvQuotations.Columns.Add((DataGridViewColumn)dataGridViewColumn.Clone());
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
					int num = this.DataGridView1.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						MyProject.Forms.Form1.dgvQuotations.Rows.Add(this.DataGridView1.Rows[i].Cells.Cast<DataGridViewCell>().Select<DataGridViewCell, object>((ViewQuotations._Closure$__.$I327-0 == null) ? (ViewQuotations._Closure$__.$I327-0 = (DataGridViewCell c) => c.Value) : ViewQuotations._Closure$__.$I327-0).ToArray<object>());
					}
					MyProject.Forms.Form1.autoOpenSalesForm = 1;
					MyProject.Forms.Form1.quotationnumber = (int)Math.Round(Conversion.Val(this.lblQuotationNumber.Text));
					this.GotoSalesMono("Enter Sales");
					base.Dispose();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error converting quotation to invoice. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x0036D408 File Offset: 0x0036B608
		private void GotoSalesMono(string sender_string)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.pf.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender_string, MyProject.Forms.MainMenu.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							Sales2mono2 sales2mono = new Sales2mono2();
							MyProject.Forms.MainMenu.Panel1.Controls.Add(sales2mono);
							sales2mono.Dock = DockStyle.Fill;
							sales2mono.BringToFront();
						}
						else
						{
							Sales2mono2 sales2mono2 = new Sales2mono2();
							MyProject.Forms.MainMenu.Panel1.Controls.Add(sales2mono2);
							sales2mono2.Dock = DockStyle.Fill;
							sales2mono2.BringToFront();
						}
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					bool flag4 = MyProject.Forms.Form1.IsWarehouse == 1;
					if (flag4)
					{
						Sales2mono2 sales2mono3 = new Sales2mono2();
						MyProject.Forms.MainMenu.Panel1.Controls.Add(sales2mono3);
						sales2mono3.Dock = DockStyle.Fill;
						sales2mono3.BringToFront();
					}
					else
					{
						Sales2mono2 sales2mono4 = new Sales2mono2();
						MyProject.Forms.MainMenu.Panel1.Controls.Add(sales2mono4);
						sales2mono4.Dock = DockStyle.Fill;
						sales2mono4.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x0036D5F0 File Offset: 0x0036B7F0
		private void Button3_Click(object sender, EventArgs e)
		{
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
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "UpdateQuotationDetails";
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
							sqlCommand.Parameters.AddWithValue("paymentmethod", this.cboPayMeth.Text);
							sqlCommand.Parameters.AddWithValue("quotationnumber", Conversions.ToInteger(this.lblQuotationNumber.Text));
							sqlCommand.Parameters.AddWithValue("discamt", Conversions.ToDecimal(dataGridViewRow.Cells["DiscAmount2"].Value));
							sqlCommand.Parameters.AddWithValue("customerentryno", this.currCustomerEntryno);
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
					MessageBox.Show("Quotation saved.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error saving quotation. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x0036D968 File Offset: 0x0036BB68
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.mono_rate = Conversions.ToDecimal(this.cboPayMeth.SelectedValue);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x0036D9B0 File Offset: 0x0036BBB0
		private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			try
			{
				bool flag = e.ColumnIndex == 17;
				if (flag)
				{
					bool flag2 = !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.FormattedValue));
					if (flag2)
					{
						MessageBox.Show("Please Enter numeric Value");
						this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.currval;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x0036DA50 File Offset: 0x0036BC50
		private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = e.ColumnIndex == 17;
				if (flag)
				{
					this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = decimal.Add(Conversions.ToDecimal(this.DataGridView1.Rows[e.RowIndex].Cells["OldPrice"].Value), Conversions.ToDecimal(this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[e.RowIndex].Cells["Tax"];
					object value = this.DataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value;
					object obj = null;
					Type typeFromHandle = typeof(Math);
					string text = "Round";
					object[] array = new object[3];
					array[0] = Operators.DivideObject(this.DataGridView1.Rows[e.RowIndex].Cells["taxr"].Value, 100);
					int num = 1;
					Form1 form = MyProject.Forms.Form1;
					ref int ptr = ref form.DecimalPlaces;
					array[num] = form.DecimalPlaces;
					array[2] = MidpointRounding.AwayFromZero;
					object[] array2 = array;
					string[] array3 = null;
					Type[] array4 = null;
					bool[] array5 = new bool[3];
					array5[1] = true;
					bool[] array6 = array5;
					object obj2 = NewLateBinding.LateGet(obj, typeFromHandle, text, array, array3, array4, array5);
					if (array6[1])
					{
						ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
					}
					dataGridViewCell.Value = Operators.MultiplyObject(Operators.MultiplyObject(value, obj2), this.DataGridView1.Rows[e.RowIndex].Cells["Qty"].Value);
					this.CalculateTotal();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating total after discount. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x0036DC8C File Offset: 0x0036BE8C
		private void CalculateTotal()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					decimal num3 = Conversions.ToDecimal(Operators.AddObject(Operators.MultiplyObject(dataGridViewRow.Cells["UnitPrice"].Value, dataGridViewRow.Cells["Qty"].Value), this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value))));
					decimal num4 = Conversions.ToDecimal(this.pf.vIIFDNBullDec(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
					num = decimal.Add(num, num3);
					num2 = decimal.Add(num2, num4);
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
			this.txtTotal.Text = MyProject.Forms.Form1.basecurrency + num.ToString();
			this.txtTax.Text = MyProject.Forms.Form1.basecurrency + num2.ToString();
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x0036DDF0 File Offset: 0x0036BFF0
		private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			try
			{
				bool flag = e.ColumnIndex == 17;
				if (flag)
				{
					this.currval = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x0036DE74 File Offset: 0x0036C074
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.txtCustomer.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				int searchCustomerEntryno = MyProject.Forms.Form1.SearchCustomerEntryno;
				this.FetchCustomerByEntryno(searchCustomerEntryno);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x0036DF00 File Offset: 0x0036C100
		private void FetchCustomerByEntryno(int entryno)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCustomerDetailsByEntryno";
				sqlCommand.Parameters.AddWithValue("entryno", entryno);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.txtCustomer.Text = Conversions.ToString(dataRow["CustomerName"]);
					this.currCustomerEntryno = Conversions.ToInteger(dataRow["EntryNo"]);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x0036E01C File Offset: 0x0036C21C
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				new Quotation
				{
					quotationnumber = Conversions.ToInteger(this.lblQuotationNumber.Text),
					branch = MyProject.Forms.Form1.branch,
					coid = MyProject.Forms.Form1.coid
				}.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reprinting quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x0036E0B0 File Offset: 0x0036C2B0
		private void chkSearchQuotationNum_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkSearchQuotationNum.Checked;
				if (@checked)
				{
					this.txtSearchQuotationNum.Visible = true;
				}
				else
				{
					this.txtSearchQuotationNum.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04002A27 RID: 10791
		private string _cnn;

		// Token: 0x04002A28 RID: 10792
		private int currQuotationNumber;

		// Token: 0x04002A29 RID: 10793
		private int currCustomerEntryno;

		// Token: 0x04002A2A RID: 10794
		private PublicFunctions pf;

		// Token: 0x04002A2B RID: 10795
		private decimal mono_rate;

		// Token: 0x04002A2C RID: 10796
		private decimal currval;
	}
}
