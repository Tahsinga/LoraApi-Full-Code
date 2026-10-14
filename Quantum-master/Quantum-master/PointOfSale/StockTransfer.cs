using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001F7 RID: 503
	[DesignerGenerated]
	public partial class StockTransfer : UserControl
	{
		// Token: 0x060059BE RID: 22974 RVA: 0x0033CE68 File Offset: 0x0033B068
		public StockTransfer()
		{
			base.Load += this.StockTransfer_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.invnum = 0;
			this.TextToPrint = "";
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x060059C1 RID: 22977 RVA: 0x0033EC30 File Offset: 0x0033CE30
		// (set) Token: 0x060059C2 RID: 22978 RVA: 0x0033EC3A File Offset: 0x0033CE3A
		internal virtual GroupBox gbmain
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x060059C3 RID: 22979 RVA: 0x0033EC43 File Offset: 0x0033CE43
		// (set) Token: 0x060059C4 RID: 22980 RVA: 0x0033EC4D File Offset: 0x0033CE4D
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x060059C5 RID: 22981 RVA: 0x0033EC56 File Offset: 0x0033CE56
		// (set) Token: 0x060059C6 RID: 22982 RVA: 0x0033EC60 File Offset: 0x0033CE60
		internal virtual DataGridView dgvWarehouse
		{
			[CompilerGenerated]
			get
			{
				return this._dgvWarehouse;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvWarehouse_CellContentClick);
				DataGridView dataGridView = this._dgvWarehouse;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvWarehouse = value;
				dataGridView = this._dgvWarehouse;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x060059C7 RID: 22983 RVA: 0x0033ECA3 File Offset: 0x0033CEA3
		// (set) Token: 0x060059C8 RID: 22984 RVA: 0x0033ECAD File Offset: 0x0033CEAD
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x0033ECB6 File Offset: 0x0033CEB6
		// (set) Token: 0x060059CA RID: 22986 RVA: 0x0033ECC0 File Offset: 0x0033CEC0
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x060059CB RID: 22987 RVA: 0x0033ECC9 File Offset: 0x0033CEC9
		// (set) Token: 0x060059CC RID: 22988 RVA: 0x0033ECD3 File Offset: 0x0033CED3
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x060059CD RID: 22989 RVA: 0x0033ECDC File Offset: 0x0033CEDC
		// (set) Token: 0x060059CE RID: 22990 RVA: 0x0033ECE8 File Offset: 0x0033CEE8
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

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x060059CF RID: 22991 RVA: 0x0033ED2B File Offset: 0x0033CF2B
		// (set) Token: 0x060059D0 RID: 22992 RVA: 0x0033ED38 File Offset: 0x0033CF38
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

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x060059D1 RID: 22993 RVA: 0x0033ED7B File Offset: 0x0033CF7B
		// (set) Token: 0x060059D2 RID: 22994 RVA: 0x0033ED85 File Offset: 0x0033CF85
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x060059D3 RID: 22995 RVA: 0x0033ED8E File Offset: 0x0033CF8E
		// (set) Token: 0x060059D4 RID: 22996 RVA: 0x0033ED98 File Offset: 0x0033CF98
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x060059D5 RID: 22997 RVA: 0x0033EDA1 File Offset: 0x0033CFA1
		// (set) Token: 0x060059D6 RID: 22998 RVA: 0x0033EDAB File Offset: 0x0033CFAB
		internal virtual DataGridView dgvBranchStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x060059D7 RID: 22999 RVA: 0x0033EDB4 File Offset: 0x0033CFB4
		// (set) Token: 0x060059D8 RID: 23000 RVA: 0x0033EDBE File Offset: 0x0033CFBE
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x060059D9 RID: 23001 RVA: 0x0033EDC7 File Offset: 0x0033CFC7
		// (set) Token: 0x060059DA RID: 23002 RVA: 0x0033EDD1 File Offset: 0x0033CFD1
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x060059DB RID: 23003 RVA: 0x0033EDDA File Offset: 0x0033CFDA
		// (set) Token: 0x060059DC RID: 23004 RVA: 0x0033EDE4 File Offset: 0x0033CFE4
		internal virtual ComboBox cboBranchFrom
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranchFrom;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranchFrom_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranchFrom;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranchFrom = value;
				comboBox = this._cboBranchFrom;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x060059DD RID: 23005 RVA: 0x0033EE27 File Offset: 0x0033D027
		// (set) Token: 0x060059DE RID: 23006 RVA: 0x0033EE31 File Offset: 0x0033D031
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x060059DF RID: 23007 RVA: 0x0033EE3A File Offset: 0x0033D03A
		// (set) Token: 0x060059E0 RID: 23008 RVA: 0x0033EE44 File Offset: 0x0033D044
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click_1);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x060059E1 RID: 23009 RVA: 0x0033EE87 File Offset: 0x0033D087
		// (set) Token: 0x060059E2 RID: 23010 RVA: 0x0033EE91 File Offset: 0x0033D091
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x060059E3 RID: 23011 RVA: 0x0033EE9A File Offset: 0x0033D09A
		// (set) Token: 0x060059E4 RID: 23012 RVA: 0x0033EEA4 File Offset: 0x0033D0A4
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x060059E5 RID: 23013 RVA: 0x0033EEAD File Offset: 0x0033D0AD
		// (set) Token: 0x060059E6 RID: 23014 RVA: 0x0033EEB7 File Offset: 0x0033D0B7
		internal virtual BindingSource FetchTransferDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x060059E7 RID: 23015 RVA: 0x0033EEC0 File Offset: 0x0033D0C0
		// (set) Token: 0x060059E8 RID: 23016 RVA: 0x0033EECA File Offset: 0x0033D0CA
		internal virtual BindingSource FetchBranchToforTransferBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x060059E9 RID: 23017 RVA: 0x0033EED3 File Offset: 0x0033D0D3
		// (set) Token: 0x060059EA RID: 23018 RVA: 0x0033EEDD File Offset: 0x0033D0DD
		internal virtual BindingSource FetchBranchFromforTransferBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x060059EB RID: 23019 RVA: 0x0033EEE6 File Offset: 0x0033D0E6
		// (set) Token: 0x060059EC RID: 23020 RVA: 0x0033EEF0 File Offset: 0x0033D0F0
		internal virtual BindingSource FetchTransferDetailsToBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x060059ED RID: 23021 RVA: 0x0033EEF9 File Offset: 0x0033D0F9
		// (set) Token: 0x060059EE RID: 23022 RVA: 0x0033EF03 File Offset: 0x0033D103
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x0033EF0C File Offset: 0x0033D10C
		// (set) Token: 0x060059F0 RID: 23024 RVA: 0x0033EF16 File Offset: 0x0033D116
		internal virtual FetchTransferDetailsTableAdapter FetchTransferDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x0033EF1F File Offset: 0x0033D11F
		// (set) Token: 0x060059F2 RID: 23026 RVA: 0x0033EF29 File Offset: 0x0033D129
		internal virtual FetchBranchToforTransferTableAdapter FetchBranchToforTransferTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x0033EF32 File Offset: 0x0033D132
		// (set) Token: 0x060059F4 RID: 23028 RVA: 0x0033EF3C File Offset: 0x0033D13C
		internal virtual FetchBranchFromforTransferTableAdapter FetchBranchFromforTransferTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x060059F5 RID: 23029 RVA: 0x0033EF45 File Offset: 0x0033D145
		// (set) Token: 0x060059F6 RID: 23030 RVA: 0x0033EF4F File Offset: 0x0033D14F
		internal virtual FetchTransferDetailsToTableAdapter FetchTransferDetailsToTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x060059F7 RID: 23031 RVA: 0x0033EF58 File Offset: 0x0033D158
		// (set) Token: 0x060059F8 RID: 23032 RVA: 0x0033EF62 File Offset: 0x0033D162
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x0033EF6B File Offset: 0x0033D16B
		// (set) Token: 0x060059FA RID: 23034 RVA: 0x0033EF78 File Offset: 0x0033D178
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

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x060059FB RID: 23035 RVA: 0x0033EFBB File Offset: 0x0033D1BB
		// (set) Token: 0x060059FC RID: 23036 RVA: 0x0033EFC5 File Offset: 0x0033D1C5
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x060059FD RID: 23037 RVA: 0x0033EFCE File Offset: 0x0033D1CE
		// (set) Token: 0x060059FE RID: 23038 RVA: 0x0033EFD8 File Offset: 0x0033D1D8
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DGVSearch_CellContentClick);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler2;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler2;
				}
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x060059FF RID: 23039 RVA: 0x0033F051 File Offset: 0x0033D251
		// (set) Token: 0x06005A00 RID: 23040 RVA: 0x0033F05B File Offset: 0x0033D25B
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06005A01 RID: 23041 RVA: 0x0033F064 File Offset: 0x0033D264
		// (set) Token: 0x06005A02 RID: 23042 RVA: 0x0033F070 File Offset: 0x0033D270
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

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06005A03 RID: 23043 RVA: 0x0033F0B3 File Offset: 0x0033D2B3
		// (set) Token: 0x06005A04 RID: 23044 RVA: 0x0033F0BD File Offset: 0x0033D2BD
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06005A05 RID: 23045 RVA: 0x0033F0C6 File Offset: 0x0033D2C6
		// (set) Token: 0x06005A06 RID: 23046 RVA: 0x0033F0D0 File Offset: 0x0033D2D0
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

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06005A07 RID: 23047 RVA: 0x0033F12E File Offset: 0x0033D32E
		// (set) Token: 0x06005A08 RID: 23048 RVA: 0x0033F138 File Offset: 0x0033D338
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06005A09 RID: 23049 RVA: 0x0033F141 File Offset: 0x0033D341
		// (set) Token: 0x06005A0A RID: 23050 RVA: 0x0033F14C File Offset: 0x0033D34C
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

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06005A0B RID: 23051 RVA: 0x0033F18F File Offset: 0x0033D38F
		// (set) Token: 0x06005A0C RID: 23052 RVA: 0x0033F19C File Offset: 0x0033D39C
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

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06005A0D RID: 23053 RVA: 0x0033F1DF File Offset: 0x0033D3DF
		// (set) Token: 0x06005A0E RID: 23054 RVA: 0x0033F1E9 File Offset: 0x0033D3E9
		internal virtual DateTimePicker DTTranDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06005A0F RID: 23055 RVA: 0x0033F1F2 File Offset: 0x0033D3F2
		// (set) Token: 0x06005A10 RID: 23056 RVA: 0x0033F1FC File Offset: 0x0033D3FC
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06005A11 RID: 23057 RVA: 0x0033F205 File Offset: 0x0033D405
		// (set) Token: 0x06005A12 RID: 23058 RVA: 0x0033F20F File Offset: 0x0033D40F
		internal virtual CheckBox chkShowCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06005A13 RID: 23059 RVA: 0x0033F218 File Offset: 0x0033D418
		// (set) Token: 0x06005A14 RID: 23060 RVA: 0x0033F224 File Offset: 0x0033D424
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

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06005A15 RID: 23061 RVA: 0x0033F267 File Offset: 0x0033D467
		// (set) Token: 0x06005A16 RID: 23062 RVA: 0x0033F271 File Offset: 0x0033D471
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06005A17 RID: 23063 RVA: 0x0033F27A File Offset: 0x0033D47A
		// (set) Token: 0x06005A18 RID: 23064 RVA: 0x0033F284 File Offset: 0x0033D484
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06005A19 RID: 23065 RVA: 0x0033F28D File Offset: 0x0033D48D
		// (set) Token: 0x06005A1A RID: 23066 RVA: 0x0033F298 File Offset: 0x0033D498
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

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06005A1B RID: 23067 RVA: 0x0033F2DB File Offset: 0x0033D4DB
		// (set) Token: 0x06005A1C RID: 23068 RVA: 0x0033F2E8 File Offset: 0x0033D4E8
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

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06005A1D RID: 23069 RVA: 0x0033F32B File Offset: 0x0033D52B
		// (set) Token: 0x06005A1E RID: 23070 RVA: 0x0033F338 File Offset: 0x0033D538
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

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06005A1F RID: 23071 RVA: 0x0033F37B File Offset: 0x0033D57B
		// (set) Token: 0x06005A20 RID: 23072 RVA: 0x0033F385 File Offset: 0x0033D585
		internal virtual TextBox txtdesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06005A21 RID: 23073 RVA: 0x0033F38E File Offset: 0x0033D58E
		// (set) Token: 0x06005A22 RID: 23074 RVA: 0x0033F398 File Offset: 0x0033D598
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

		// Token: 0x06005A23 RID: 23075 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x0033F3DC File Offset: 0x0033D5DC
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
			this.cboBranchFrom.DataSource = dataTable;
			this.cboBranchFrom.ValueMember = "branch";
			this.cboBranchFrom.DisplayMember = "branch";
			this.cboBranchFrom.SelectedIndex = this.cboBranchFrom.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x0033F4A0 File Offset: 0x0033D6A0
		private void LoadBranchesTo()
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
			this.cboBranch.SelectedIndex = -1;
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0033F54C File Offset: 0x0033D74C
		private void StockTransfer_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadBranchFromStock(this.cboBranchFrom.Text);
				this.LoadBranchesTo();
				bool flag = MyProject.Forms.Form1.DateChange == 0;
				if (flag)
				{
					this.DTTranDate.Enabled = false;
				}
				else
				{
					this.DTTranDate.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x0033F5E8 File Offset: 0x0033D7E8
		private int CheckIfFirstRunFOrBranch(string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select FirstStockBalRun from branches where branch='" + branch + "' and coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow[0]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x0033F6AC File Offset: 0x0033D8AC
		private void LoadBranchFromStock(string branch)
		{
			this.dgvWarehouse.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
			if (flag)
			{
				sqlCommand.CommandText = "CurrentStockLevelsWarehouseCurrent";
			}
			else
			{
				sqlCommand.CommandText = "CurrentStockLevels";
				sqlCommand.Parameters.AddWithValue("use_curr_bal", this.CheckIfFirstRunFOrBranch(branch));
				sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			}
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvWarehouse.DataSource = dataTable;
			this.dgvWarehouse.Columns["ProductID"].Visible = false;
			bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
			if (!flag2)
			{
				this.dgvWarehouse.Columns["UOM"].Visible = false;
				this.dgvWarehouse.Columns["ReorderLevel"].Visible = false;
			}
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "Enter Quanity to be transfered";
			dataGridViewTextBoxColumn.Name = "QTYcol";
			dataGridViewTextBoxColumn.DataPropertyName = "QTYcol";
			dataGridViewTextBoxColumn.CellTemplate = new DataGridViewTextBoxCell();
			this.dgvWarehouse.Columns.Insert(5, dataGridViewTextBoxColumn);
			this.dgvWarehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupBox1.Text = "Warehouse Stock Balances";
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x0033F890 File Offset: 0x0033DA90
		private void LoadBranchStock(string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
			if (flag)
			{
				sqlCommand.CommandText = "CurrentStockLevelsWarehouseCurrent";
			}
			else
			{
				sqlCommand.CommandText = "CurrentStockLevels";
				sqlCommand.Parameters.AddWithValue("use_curr_bal", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.pf.CheckIfFirstBalRun(MyProject.Forms.Form1.coid, branch, this._cnn), 1, 0)));
			}
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvBranchStock.DataSource = dataTable;
			this.dgvBranchStock.Columns["ProductID"].Visible = false;
			bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
			if (!flag2)
			{
				this.dgvBranchStock.Columns["UOM"].Visible = false;
				this.dgvBranchStock.Columns["ReorderLevel"].Visible = false;
			}
			this.dgvBranchStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupBox2.Text = "Stock Balances for Branch: " + branch;
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x0033FA28 File Offset: 0x0033DC28
		private void cboBranchFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x0033FA5C File Offset: 0x0033DC5C
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading branch stock. Details: " + ex.Message);
			}
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x0033FAA4 File Offset: 0x0033DCA4
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = DateTime.Compare(this.DTTranDate.Value, DateTime.Now) > 0;
					if (flag)
					{
						MessageBox.Show("Date selected is greater than today. Cannot proceed.");
					}
					else
					{
						bool flag2 = Operators.CompareString(this.cboBranch.Text, "", false) == 0;
						if (flag2)
						{
							MessageBox.Show("Select branch to first.");
						}
						else
						{
							bool flag3 = Operators.CompareString(this.txtRef.Text, "", false) != 0;
							if (flag3)
							{
								bool flag4 = Operators.CompareString(this.cboBranchFrom.Text, this.cboBranch.Text, false) != 0;
								if (flag4)
								{
									this.invnum = this.GetInvoiceNum();
									int num = 0;
									decimal num2 = 0m;
									SqlConnection sqlConnection = new SqlConnection(this._cnn);
									SqlCommand sqlCommand = sqlConnection.CreateCommand();
									sqlCommand.Connection = sqlConnection;
									sqlConnection.Open();
									SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunStockTransfer");
									sqlCommand.Transaction = sqlTransaction;
									sqlCommand.CommandType = CommandType.StoredProcedure;
									try
									{
										int num3 = this.dgvWarehouse.Rows.Count - 1;
										for (int i = 0; i <= num3; i++)
										{
											object objectValue = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsNothing(RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["QTYcol"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["QTYcol"].Value)));
											bool flag5 = Operators.ConditionalCompareObjectNotEqual(objectValue, 0, false);
											if (flag5)
											{
												bool flag6 = MyProject.Forms.Form1.IsWarehouse != 0;
												decimal num4;
												string text;
												int num5;
												if (flag6)
												{
													num4 = Conversions.ToDecimal(this.dgvWarehouse.Rows[i].Cells["bal"].Value);
													text = Conversions.ToString(this.dgvWarehouse.Rows[i].Cells["BatchNumber"].Value);
													num5 = Conversions.ToInteger(this.dgvWarehouse.Rows[i].Cells["ExpiryDate"].Value);
												}
												else
												{
													num4 = Conversions.ToDecimal(this.dgvWarehouse.Rows[i].Cells["StockBalance"].Value);
													text = "";
													num5 = 0;
												}
												object objectValue2 = RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["ProductCode"].Value);
												object objectValue3 = RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["ProductID"].Value);
												bool flag7 = Operators.CompareString(this.dgvWarehouse.Rows[i].Cells["ProductDesc"].ToString(), "", false) == 0;
												if (flag7)
												{
													MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Please ensure all products have a description. TRANSFER CANCELLED. Product Code: ", objectValue2)));
													sqlTransaction.Rollback();
													return;
												}
												string text2 = Conversions.ToString(this.dgvWarehouse.Rows[i].Cells["ProductDesc"].Value);
												bool flag8 = Operators.ConditionalCompareObjectNotEqual(objectValue, 0, false);
												if (flag8)
												{
													bool flag9 = false;
													bool flag10 = Operators.ConditionalCompareObjectGreaterEqual(Operators.SubtractObject(num4, objectValue), 0, false);
													if (flag10)
													{
														flag9 = true;
													}
													bool flag11 = MyProject.Forms.Form1.NegativeStock == 1;
													if (flag11)
													{
														flag9 = true;
													}
													bool flag12 = flag9;
													if (flag12)
													{
														sqlCommand.Parameters.Clear();
														sqlCommand.CommandText = "TransferStock";
														sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTTranDate.Value.ToString("yyyyMMdd")));
														sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
														sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(objectValue3));
														sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
														sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(objectValue));
														sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
														sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateTime.Today.Date.ToString("yyyyMMdd")));
														sqlCommand.Parameters.AddWithValue("productcode", RuntimeHelpers.GetObjectValue(objectValue2));
														sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
														sqlCommand.Parameters.AddWithValue("branchfrom", this.cboBranchFrom.Text);
														sqlCommand.Parameters.AddWithValue("branchto", this.cboBranch.Text);
														sqlCommand.Parameters.AddWithValue("batchnumber", text);
														sqlCommand.Parameters.AddWithValue("expirydate", num5);
														sqlCommand.ExecuteNonQuery();
														num++;
														num2 = Conversions.ToDecimal(Operators.AddObject(num2, objectValue));
													}
													else
													{
														MessageBox.Show("Cannot transfer a quantity greater than the stock balance. Product: " + text2);
													}
												}
											}
										}
										sqlTransaction.Commit();
										sqlConnection.Close();
									}
									catch (Exception ex)
									{
										try
										{
											sqlTransaction.Rollback();
											sqlConnection.Close();
											MessageBox.Show("Transaction unsuccessful and rolled back. No stock transfered. Detail: " + ex.Message);
										}
										catch (Exception ex2)
										{
											MessageBox.Show("Transaction unsuccessful. No stock transfered.");
										}
									}
									bool flag13 = num > 0;
									if (flag13)
									{
										this.RunReport(this.invnum, Conversions.ToBoolean(Interaction.IIf(this.chkShowCost.Checked, 1, 0)));
										MessageBox.Show(string.Concat(new string[]
										{
											"Stock successfully transfered. ",
											Conversions.ToString(num),
											" stock products transfered. ",
											Conversions.ToString(num2),
											" total items transfered."
										}));
										this.lblinfo.Text = string.Concat(new string[]
										{
											"Stock successfully transfered. ",
											Conversions.ToString(num),
											" stock products transfered.",
											Conversions.ToString(num2),
											" total items transfered."
										});
										this.lblinfo.ForeColor = Color.Blue;
									}
									else
									{
										MessageBox.Show("NO stock items transfered.");
										this.lblinfo.Text = "NO stock items transfered.";
										this.lblinfo.ForeColor = Color.Red;
									}
									this.LoadBranchFromStock(this.cboBranchFrom.SelectedValue.ToString());
									this.LoadBranchStock(this.cboBranch.SelectedValue.ToString());
								}
								else
								{
									MessageBox.Show("Cannot transfer stock from the same branch.");
								}
							}
							else
							{
								MessageBox.Show("Please enter a reference number.");
							}
							this.Button2.Visible = true;
							this.REF = this.txtRef.Text;
						}
					}
				}
				catch (Exception ex3)
				{
					MessageBox.Show("Error transfering stock. Detail: " + ex3.Message);
				}
			}
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x003402D4 File Offset: 0x0033E4D4
		private int GetInvoiceNum()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNewInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", this.DTTranDate.Value.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x003403B4 File Offset: 0x0033E5B4
		private void TransferStock(string branchfrom, string branchto, int trandate, int invoicenum, int productid, string @ref, decimal quantity, string doneby, int donewhen, string productcode, int coid, string batchnumber, int expirydate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TransferStock";
			sqlCommand.Parameters.AddWithValue("trandate", trandate);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			sqlCommand.Parameters.AddWithValue("quantity", quantity);
			sqlCommand.Parameters.AddWithValue("doneby", doneby);
			sqlCommand.Parameters.AddWithValue("donewhen", donewhen);
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branchfrom", branchfrom);
			sqlCommand.Parameters.AddWithValue("branchto", branchto);
			sqlCommand.Parameters.AddWithValue("batchnumber", batchnumber);
			sqlCommand.Parameters.AddWithValue("expirydate", expirydate);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x00340538 File Offset: 0x0033E738
		private void RunReport(int invoicenumber, bool showcost)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.FetchBranchFromforTransferTableAdapter.Connection = sqlConnection;
				this.FetchBranchToforTransferTableAdapter.Connection = sqlConnection;
				this.FetchTransferDetailsTableAdapter.Connection = sqlConnection;
				this.FetchTransferDetailsToTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("invoicenum", Conversions.ToString(invoicenumber));
				ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter3 = new ReportParameter("IsWarehouse", Conversions.ToString(MyProject.Forms.Form1.IsWarehouse));
				ReportParameter reportParameter4 = new ReportParameter("showcost", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkShowCost.Checked, 1, 0))));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.FetchBranchFromforTransferTableAdapter.Fill(this.POSDataSet.FetchBranchFromforTransfer, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.FetchBranchToforTransferTableAdapter.Fill(this.POSDataSet.FetchBranchToforTransfer, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.FetchTransferDetailsTableAdapter.Fill(this.POSDataSet.FetchTransferDetails, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.FetchTransferDetailsToTableAdapter.Fill(this.POSDataSet.FetchTransferDetailsTo, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x00340778 File Offset: 0x0033E978
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

		// Token: 0x06005A32 RID: 23090 RVA: 0x00340800 File Offset: 0x0033EA00
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

		// Token: 0x06005A33 RID: 23091 RVA: 0x003408F8 File Offset: 0x0033EAF8
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
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x00340A98 File Offset: 0x0033EC98
		private void savepdf(string invnumString, string @ref)
		{
			byte[] array = this.ReportViewer1.LocalReport.Render("PDF");
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "*PDF files (*.pdf)|*.pdf";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			bool flag = !Directory.Exists("C:\\StockTransfers");
			if (flag)
			{
				Directory.CreateDirectory("C:\\StockTransfers");
			}
			FileStream fileStream = new FileStream("C:\\StockTransfers\\StockTransfer_" + invnumString + ".pdf", FileMode.Create);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			MessageBox.Show("Stock Transfer report saved in c:\\StockTransfers.");
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00340B34 File Offset: 0x0033ED34
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

		// Token: 0x06005A36 RID: 23094 RVA: 0x00340B94 File Offset: 0x0033ED94
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvWarehouse.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.CompareString(dataGridViewRow.Cells["ProductCode"].Value.ToString().ToUpper(), this.txtProductCode.Text.ToUpper(), false) == 0;
						if (flag)
						{
							this.dgvWarehouse.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvWarehouse.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvBranchStock.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						bool flag2 = Operators.CompareString(dataGridViewRow2.Cells["ProductCode"].Value.ToString().ToUpper(), this.txtProductCode.Text.ToUpper(), false) == 0;
						if (flag2)
						{
							this.dgvBranchStock.ClearSelection();
							dataGridViewRow2.Cells["ProductCode"].Selected = true;
							this.dgvBranchStock.CurrentCell = dataGridViewRow2.Cells["ProductCode"];
							dataGridViewRow2.Selected = true;
							break;
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
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00340DB0 File Offset: 0x0033EFB0
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

		// Token: 0x06005A38 RID: 23096 RVA: 0x00340E70 File Offset: 0x0033F070
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

		// Token: 0x06005A39 RID: 23097 RVA: 0x00340ED0 File Offset: 0x0033F0D0
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

		// Token: 0x06005A3A RID: 23098 RVA: 0x00340F58 File Offset: 0x0033F158
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

		// Token: 0x06005A3B RID: 23099 RVA: 0x00341064 File Offset: 0x0033F264
		private object searchDat(DataTable dt, string column, string value)
		{
			StockTransfer._Closure$__237-0 CS$<>8__locals1 = new StockTransfer._Closure$__237-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((StockTransfer._Closure$__.$I237-0 == null) ? (StockTransfer._Closure$__.$I237-0 = (object row1) => (DataRow)row1) : StockTransfer._Closure$__.$I237-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06005A3C RID: 23100 RVA: 0x00341140 File Offset: 0x0033F340
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

		// Token: 0x06005A3D RID: 23101 RVA: 0x003411C8 File Offset: 0x0033F3C8
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.invnum != 0;
				if (flag)
				{
					this.GetBranchDetails();
					this.PrintHeaderQuotation();
					this.ItemsToBePrintedQuotation();
					this.stringToRead = new StringReader(this.TextToPrint);
					StandardPrintController standardPrintController = new StandardPrintController();
					this.PrintDocument1.PrintController = standardPrintController;
					this.PrintDocument1.Print();
					MessageBox.Show("Print job sent to printer.");
				}
				else
				{
					MessageBox.Show("Please check if a stock transfer has been done.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x0034127C File Offset: 0x0033F47C
		private void GetBranchDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
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

		// Token: 0x06005A3F RID: 23103 RVA: 0x003413F8 File Offset: 0x0033F5F8
		private void PrintHeaderQuotation()
		{
			this.TextToPrint = "";
			string text = "STOCKS TRANSFERED";
			int length = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - length) / 2.0)));
				ref string ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text + Environment.NewLine;
				string text3 = this.coname;
				int num = text3.Length;
				string text4 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + text3 + Environment.NewLine;
				bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag)
				{
					text3 = "BP Number: " + this.cobpnum;
					num = text3.Length;
					string text5 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text5 + text3 + Environment.NewLine;
				}
				text3 = this.coadd;
				num = text3.Length;
				string text6 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text6 + text3 + Environment.NewLine;
				bool flag2 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag2)
				{
					text3 = "Email: " + this.coemail;
					num = text3.Length;
					string text7 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text7 + text3 + Environment.NewLine;
				}
				bool flag3 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag3)
				{
					text3 = this.cotel;
					num = text3.Length;
					string text8 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text8 + text3 + Environment.NewLine;
				}
				bool flag4 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag4)
				{
					text3 = this.cotel2 + "  " + this.cotel3;
					num = text3.Length;
					string text9 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text9 + text3 + Environment.NewLine;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text3 = this.DTTranDate.Value.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "Transfers from " + this.DTTranDate.Value.ToString("dd-MM-yyyy");
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "Branch From: " + this.GetBranchFrom(MyProject.Forms.Form1.coid, this.invnum);
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
				text3 = "Branch To: " + this.GetBranchTo(MyProject.Forms.Form1.coid, this.invnum);
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "REF: " + this.REF.ToString();
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00341850 File Offset: 0x0033FA50
		private string GetBranchFrom(int coid, int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranchFromforTransfer";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToString(dataRow["BranchFrom"]);
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x003418F0 File Offset: 0x0033FAF0
		private string GetBranchTo(int coid, int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranchToforTransfer";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToString(dataRow["BranchTo"]);
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x00341990 File Offset: 0x0033FB90
		private void ItemsToBePrintedQuotation()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			decimal num = 0m;
			double num2 = 0.0;
			DataTable transfers = this.GetTransfers(MyProject.Forms.Form1.coid, this.invnum);
			string text3;
			try
			{
				foreach (object obj in transfers.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text = Conversions.ToString(dataRow["ProductDesc"]);
					string text2 = Conversions.ToString(dataRow["ProductCode"]);
					num = Conversions.ToDecimal(dataRow["Quantity"]);
					num2 += Convert.ToDouble(num);
					checked
					{
						int num3 = (int)Math.Round(Conversion.Val(text.Length));
						bool flag = num3 >= 34;
						if (flag)
						{
							text = text.Substring(0, 33);
						}
						else
						{
							int num4 = num3;
							int num5 = 34 - num4;
							text = text.PadRight(num5);
						}
						int length = text.Length;
						text3 = text2 + ": " + text;
						string text4 = Conversions.ToString(text3.Length);
						string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine;
						text3 = "X     " + num.ToString();
						string text6 = Conversions.ToString(text3.Length);
						string text7 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
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
			text3 = "TOTAL ITEMS TRANSFERED: " + Conversions.ToString(num2);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text3 + Environment.NewLine;
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x00341C00 File Offset: 0x0033FE00
		private DataTable GetTransfers(int coid, int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchTransferDetailsTo";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x00341C80 File Offset: 0x0033FE80
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

		// Token: 0x06005A45 RID: 23109 RVA: 0x00002A30 File Offset: 0x00000C30
		private void dgvWarehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00341DD4 File Offset: 0x0033FFD4
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.invnum != 0;
				if (flag)
				{
					this.RunReport(this.invnum, Conversions.ToBoolean(Interaction.IIf(this.chkShowCost.Checked, 1, 0)));
					MessageBox.Show("Transfer report re-run- see the report below.");
				}
				else
				{
					MessageBox.Show("Check if there has been a transfer first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reprinting transfer report");
			}
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00341E68 File Offset: 0x00340068
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranchFromStock(this.cboBranchFrom.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading branch stock. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00341EC4 File Offset: 0x003400C4
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboBranch.Text, "", false) != 0;
				if (flag)
				{
					this.LoadBranchStock(this.cboBranch.Text);
				}
				else
				{
					MessageBox.Show("Please select the branch being transfered to first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading branch stock. Details: " + ex.Message);
			}
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00002A30 File Offset: 0x00000C30
		private void DGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00341F4C File Offset: 0x0034014C
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvWarehouse.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.CompareString(dataGridViewRow.Cells["ProductDesc"].Value.ToString().ToUpper(), this.txtdesc.Text.ToUpper(), false) == 0;
						if (flag)
						{
							this.dgvWarehouse.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvWarehouse.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvBranchStock.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						bool flag2 = Operators.CompareString(dataGridViewRow2.Cells["ProductDesc"].Value.ToString().ToUpper(), this.txtdesc.Text.ToUpper(), false) == 0;
						if (flag2)
						{
							this.dgvBranchStock.ClearSelection();
							dataGridViewRow2.Cells["ProductCode"].Selected = true;
							this.dgvBranchStock.CurrentCell = dataGridViewRow2.Cells["ProductCode"];
							dataGridViewRow2.Selected = true;
							break;
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
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x0034217C File Offset: 0x0034037C
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvWarehouse.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.CompareString(dataGridViewRow.Cells["ProductCode"].Value.ToString().ToUpper(), this.txtProductCode.Text, false) == 0;
						if (flag)
						{
							this.dgvWarehouse.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvWarehouse.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvBranchStock.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						bool flag2 = Operators.CompareString(dataGridViewRow2.Cells["ProductCode"].Value.ToString().ToUpper(), this.txtProductCode.Text, false) == 0;
						if (flag2)
						{
							this.dgvBranchStock.ClearSelection();
							dataGridViewRow2.Cells["ProductCode"].Selected = true;
							this.dgvBranchStock.CurrentCell = dataGridViewRow2.Cells["ProductCode"];
							dataGridViewRow2.Selected = true;
							break;
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
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400275D RID: 10077
		private string _cnn;

		// Token: 0x0400275E RID: 10078
		private int invnum;

		// Token: 0x0400275F RID: 10079
		private string TextToPrint;

		// Token: 0x04002760 RID: 10080
		private string coname;

		// Token: 0x04002761 RID: 10081
		private string coadd;

		// Token: 0x04002762 RID: 10082
		private string cotel;

		// Token: 0x04002763 RID: 10083
		private string coemail;

		// Token: 0x04002764 RID: 10084
		private string cobpnum;

		// Token: 0x04002765 RID: 10085
		private string cotel2;

		// Token: 0x04002766 RID: 10086
		private string cotel3;

		// Token: 0x04002767 RID: 10087
		private string REF;

		// Token: 0x04002768 RID: 10088
		private StringReader stringToRead;

		// Token: 0x04002769 RID: 10089
		private PublicFunctions pf;
	}
}
