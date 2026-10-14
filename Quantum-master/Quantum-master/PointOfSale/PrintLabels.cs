using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BarcodeRender;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using Zen.Barcode;

namespace PointOfSale
{
	// Token: 0x0200016B RID: 363
	[DesignerGenerated]
	public partial class PrintLabels : UserControl
	{
		// Token: 0x06003192 RID: 12690 RVA: 0x001ACD48 File Offset: 0x001AAF48
		public PrintLabels()
		{
			base.Load += this.PrintLabels_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.ItemDesc = "";
			this.ItemPrice = MyProject.Forms.Form1.basecurrency + "0";
			this.ItemBarCode = "";
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x001AF2EC File Offset: 0x001AD4EC
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x001AF2F8 File Offset: 0x001AD4F8
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

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x001AF33B File Offset: 0x001AD53B
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x001AF345 File Offset: 0x001AD545
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x001AF34E File Offset: 0x001AD54E
		// (set) Token: 0x0600319A RID: 12698 RVA: 0x001AF358 File Offset: 0x001AD558
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

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x001AF39B File Offset: 0x001AD59B
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x001AF3A8 File Offset: 0x001AD5A8
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

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x001AF3EB File Offset: 0x001AD5EB
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x001AF3F5 File Offset: 0x001AD5F5
		internal virtual DataGridView dgvStocks
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x001AF3FE File Offset: 0x001AD5FE
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x001AF408 File Offset: 0x001AD608
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

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x001AF44B File Offset: 0x001AD64B
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x001AF458 File Offset: 0x001AD658
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

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x001AF49B File Offset: 0x001AD69B
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x001AF4A8 File Offset: 0x001AD6A8
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
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.pdPrint_PrintPage);
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

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x001AF4EB File Offset: 0x001AD6EB
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x001AF4F5 File Offset: 0x001AD6F5
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x001AF4FE File Offset: 0x001AD6FE
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x001AF508 File Offset: 0x001AD708
		internal virtual EventLog EventLog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x001AF511 File Offset: 0x001AD711
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x001AF51B File Offset: 0x001AD71B
		internal virtual BarcodePanel BarcodePanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x001AF524 File Offset: 0x001AD724
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x001AF530 File Offset: 0x001AD730
		internal virtual PrintDocument barcodeDocument
		{
			[CompilerGenerated]
			get
			{
				return this._barcodeDocument;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.barcodeDocument_PrintPage);
				PrintDocument printDocument = this._barcodeDocument;
				if (printDocument != null)
				{
					printDocument.PrintPage -= printPageEventHandler;
				}
				this._barcodeDocument = value;
				printDocument = this._barcodeDocument;
				if (printDocument != null)
				{
					printDocument.PrintPage += printPageEventHandler;
				}
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x001AF573 File Offset: 0x001AD773
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x001AF57D File Offset: 0x001AD77D
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x001AF586 File Offset: 0x001AD786
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x001AF590 File Offset: 0x001AD790
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

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x001AF5EE File Offset: 0x001AD7EE
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x001AF5F8 File Offset: 0x001AD7F8
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x001AF601 File Offset: 0x001AD801
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x001AF60C File Offset: 0x001AD80C
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

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x001AF64F File Offset: 0x001AD84F
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x001AF659 File Offset: 0x001AD859
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x001AF662 File Offset: 0x001AD862
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x001AF66C File Offset: 0x001AD86C
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

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x001AF6AF File Offset: 0x001AD8AF
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x001AF6BC File Offset: 0x001AD8BC
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
				EventHandler eventHandler = new EventHandler(this.txtProductCode_TextChanged_1);
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

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x001AF6FF File Offset: 0x001AD8FF
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x001AF709 File Offset: 0x001AD909
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x001AF712 File Offset: 0x001AD912
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x001AF71C File Offset: 0x001AD91C
		internal virtual ComboBox cboInstalledPrinters
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x001AF725 File Offset: 0x001AD925
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x001AF72F File Offset: 0x001AD92F
		internal virtual CheckBox chkPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x001AF738 File Offset: 0x001AD938
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x001AF742 File Offset: 0x001AD942
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x001AF74B File Offset: 0x001AD94B
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x001AF758 File Offset: 0x001AD958
		internal virtual TextBox txtFScompany
		{
			[CompilerGenerated]
			get
			{
				return this._txtFScompany;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtFScompany_KeyPress);
				TextBox textBox = this._txtFScompany;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtFScompany = value;
				textBox = this._txtFScompany;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x001AF79B File Offset: 0x001AD99B
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x001AF7A5 File Offset: 0x001AD9A5
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x001AF7AE File Offset: 0x001AD9AE
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x001AF7B8 File Offset: 0x001AD9B8
		internal virtual TextBox txtFSdesc
		{
			[CompilerGenerated]
			get
			{
				return this._txtFSdesc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtFSdesc_KeyPress);
				TextBox textBox = this._txtFSdesc;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtFSdesc = value;
				textBox = this._txtFSdesc;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x001AF7FB File Offset: 0x001AD9FB
		// (set) Token: 0x060031CA RID: 12746 RVA: 0x001AF805 File Offset: 0x001ADA05
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x001AF80E File Offset: 0x001ADA0E
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x001AF818 File Offset: 0x001ADA18
		internal virtual TextBox txtFSprice
		{
			[CompilerGenerated]
			get
			{
				return this._txtFSprice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtFSprice_KeyPress);
				TextBox textBox = this._txtFSprice;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtFSprice = value;
				textBox = this._txtFSprice;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x001AF85B File Offset: 0x001ADA5B
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x001AF865 File Offset: 0x001ADA65
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x001AF86E File Offset: 0x001ADA6E
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x001AF878 File Offset: 0x001ADA78
		internal virtual TextBox txtFSbarcode
		{
			[CompilerGenerated]
			get
			{
				return this._txtFSbarcode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtFSbarcode_KeyPress);
				TextBox textBox = this._txtFSbarcode;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtFSbarcode = value;
				textBox = this._txtFSbarcode;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x001AF8BB File Offset: 0x001ADABB
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x001AF8C5 File Offset: 0x001ADAC5
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x001AF8CE File Offset: 0x001ADACE
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x001AF8D8 File Offset: 0x001ADAD8
		internal virtual TextBox txtbarcodesymbology
		{
			[CompilerGenerated]
			get
			{
				return this._txtbarcodesymbology;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
				TextBox textBox = this._txtbarcodesymbology;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtbarcodesymbology = value;
				textBox = this._txtbarcodesymbology;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x001AF91B File Offset: 0x001ADB1B
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x001AF925 File Offset: 0x001ADB25
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x001AF92E File Offset: 0x001ADB2E
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x001AF938 File Offset: 0x001ADB38
		internal virtual TextBox txtFSStartingPoint
		{
			[CompilerGenerated]
			get
			{
				return this._txtFSStartingPoint;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtFSStartingPoint_KeyPress);
				TextBox textBox = this._txtFSStartingPoint;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtFSStartingPoint = value;
				textBox = this._txtFSStartingPoint;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x001AF97B File Offset: 0x001ADB7B
		// (set) Token: 0x060031DA RID: 12762 RVA: 0x001AF985 File Offset: 0x001ADB85
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x001AF98E File Offset: 0x001ADB8E
		// (set) Token: 0x060031DC RID: 12764 RVA: 0x001AF998 File Offset: 0x001ADB98
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x001AF9A1 File Offset: 0x001ADBA1
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x001AF9AB File Offset: 0x001ADBAB
		internal virtual TextBox txtProductDescY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x001AF9B4 File Offset: 0x001ADBB4
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x001AF9BE File Offset: 0x001ADBBE
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x001AF9C7 File Offset: 0x001ADBC7
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x001AF9D1 File Offset: 0x001ADBD1
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x001AF9DA File Offset: 0x001ADBDA
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x001AF9E4 File Offset: 0x001ADBE4
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x001AF9ED File Offset: 0x001ADBED
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x001AF9F7 File Offset: 0x001ADBF7
		internal virtual TextBox txtBarcodeTextY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x001AFA00 File Offset: 0x001ADC00
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x001AFA0A File Offset: 0x001ADC0A
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x001AFA13 File Offset: 0x001ADC13
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x001AFA1D File Offset: 0x001ADC1D
		internal virtual TextBox txtBarcodeY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x001AFA26 File Offset: 0x001ADC26
		// (set) Token: 0x060031EC RID: 12780 RVA: 0x001AFA30 File Offset: 0x001ADC30
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x001AFA39 File Offset: 0x001ADC39
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x001AFA43 File Offset: 0x001ADC43
		internal virtual TextBox txtConameY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060031EF RID: 12783 RVA: 0x001AFA4C File Offset: 0x001ADC4C
		// (set) Token: 0x060031F0 RID: 12784 RVA: 0x001AFA56 File Offset: 0x001ADC56
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x001AFA5F File Offset: 0x001ADC5F
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x001AFA6C File Offset: 0x001ADC6C
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

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x001AFAAF File Offset: 0x001ADCAF
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x001AFABC File Offset: 0x001ADCBC
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

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x001AFAFF File Offset: 0x001ADCFF
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x001AFB0C File Offset: 0x001ADD0C
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

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x001AFB4F File Offset: 0x001ADD4F
		// (set) Token: 0x060031F8 RID: 12792 RVA: 0x001AFB5C File Offset: 0x001ADD5C
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

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x001AFB9F File Offset: 0x001ADD9F
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x001AFBA9 File Offset: 0x001ADDA9
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x001AFBB2 File Offset: 0x001ADDB2
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x001AFBBC File Offset: 0x001ADDBC
		internal virtual CheckBox chkPrintDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x001AFBC5 File Offset: 0x001ADDC5
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x001AFBCF File Offset: 0x001ADDCF
		internal virtual CheckBox chkPrintCo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x001AFBD8 File Offset: 0x001ADDD8
		// (set) Token: 0x06003200 RID: 12800 RVA: 0x001AFBE2 File Offset: 0x001ADDE2
		internal virtual CheckBox chkCoBold
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x001AFBEB File Offset: 0x001ADDEB
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x001AFBF5 File Offset: 0x001ADDF5
		internal virtual CheckBox chkDescBold
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x001AFBFE File Offset: 0x001ADDFE
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x001AFC08 File Offset: 0x001ADE08
		internal virtual CheckBox chkPriceBold
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x001AFC11 File Offset: 0x001ADE11
		// (set) Token: 0x06003206 RID: 12806 RVA: 0x001AFC1B File Offset: 0x001ADE1B
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x001AFC24 File Offset: 0x001ADE24
		// (set) Token: 0x06003208 RID: 12808 RVA: 0x001AFC2E File Offset: 0x001ADE2E
		internal virtual TextBox txtdesclinelen
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x001AFC37 File Offset: 0x001ADE37
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x001AFC41 File Offset: 0x001ADE41
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x001AFC4C File Offset: 0x001ADE4C
		private void PrintLabels_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadPrinters();
				bool flag = decimal.Compare(MyProject.Forms.Form1.FSBarcode, 0m) != 0;
				if (flag)
				{
					this.txtFSbarcode.Text = MyProject.Forms.Form1.FSBarcode.ToString();
					this.txtFSprice.Text = MyProject.Forms.Form1.FSPrice.ToString();
					this.txtFSdesc.Text = MyProject.Forms.Form1.FSDesc.ToString();
					this.txtFScompany.Text = MyProject.Forms.Form1.FSCompany.ToString();
					this.txtbarcodesymbology.Text = MyProject.Forms.Form1.FSBarcodesymbology.ToString();
					this.txtFSStartingPoint.Text = MyProject.Forms.Form1.FSStartingPoint.ToString();
				}
				this.txtConameY.Text = Conversions.ToString(MyProject.Forms.Form1.FSYconame);
				this.txtBarcodeY.Text = Conversions.ToString(MyProject.Forms.Form1.FSYbarcode);
				this.txtBarcodeTextY.Text = Conversions.ToString(MyProject.Forms.Form1.FSYbarcodetext);
				this.txtPrice.Text = Conversions.ToString(MyProject.Forms.Form1.FSYprice);
				this.txtProductDescY.Text = Conversions.ToString(MyProject.Forms.Form1.FSYDesc);
				bool flag2 = MyProject.Forms.Form1.FSYConameBold == 1;
				if (flag2)
				{
					this.chkCoBold.Checked = true;
				}
				else
				{
					this.chkCoBold.Checked = false;
				}
				bool flag3 = MyProject.Forms.Form1.FSYPriceBold == 1;
				if (flag3)
				{
					this.chkPriceBold.Checked = true;
				}
				else
				{
					this.chkPriceBold.Checked = false;
				}
				bool flag4 = MyProject.Forms.Form1.FSYDescBold == 1;
				if (flag4)
				{
					this.chkDescBold.Checked = true;
				}
				else
				{
					this.chkDescBold.Checked = false;
				}
				this.txtdesclinelen.Text = MyProject.Forms.Form1.FSYDescLineLen.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x001AFEF4 File Offset: 0x001AE0F4
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

		// Token: 0x0600320E RID: 12814 RVA: 0x001AFFB8 File Offset: 0x001AE1B8
		private void LoadStocks(string branch)
		{
			this.dgvStocks.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevels";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvStocks.DataSource = dataTable;
			this.dgvStocks.Columns["ReorderLevel"].Visible = false;
			this.dgvStocks.Columns["ProductID"].Visible = false;
			this.dgvStocks.Columns["ProductCode"].Visible = true;
			this.dgvStocks.Columns["UOM"].Visible = false;
			this.dgvStocks.Columns["StockBalance"].HeaderText = "Stock Balance for Branch";
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			dataGridViewCheckBoxColumn.HeaderText = "Print Label";
			dataGridViewCheckBoxColumn.Name = "CHKcol";
			dataGridViewCheckBoxColumn.DataPropertyName = "CHKcol";
			dataGridViewCheckBoxColumn.CellTemplate = new DataGridViewCheckBoxCell();
			this.dgvStocks.Columns.Insert(5, dataGridViewCheckBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "How many labels to be printed?";
			dataGridViewTextBoxColumn.Name = "QTYcol";
			dataGridViewTextBoxColumn.DataPropertyName = "QTYcol";
			dataGridViewTextBoxColumn.CellTemplate = new DataGridViewTextBoxCell();
			this.dgvStocks.Columns.Insert(6, dataGridViewTextBoxColumn);
			this.dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupBox1.Text = "Warehouse Stock Balances";
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x001B01A4 File Offset: 0x001AE3A4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadStocks(this.cboBranch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock items. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x001B0200 File Offset: 0x001AE400
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = Operators.CompareString(this.cboInstalledPrinters.Text, "", false) == 0;
					if (flag)
					{
						MessageBox.Show("Please select a printer first.");
					}
					else
					{
						int num = 0;
						int num2 = 0;
						bool flag2 = this.dgvStocks.Rows.Count > 0;
						if (flag2)
						{
							int num3 = this.dgvStocks.Rows.Count - 1;
							for (int i = 0; i <= num3; i++)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(this.dgvStocks.Rows[i].Cells["QTYcol"].Value);
								object objectValue2 = RuntimeHelpers.GetObjectValue(this.dgvStocks.Rows[i].Cells["CHKcol"].Value);
								bool flag3 = Operators.ConditionalCompareObjectEqual(objectValue2, true, false);
								if (flag3)
								{
									this.ItemBarCode = Conversions.ToString(this.dgvStocks.Rows[i].Cells["ProductCode"].Value);
									bool @checked = this.chkPrice.Checked;
									if (@checked)
									{
										this.ItemPrice = this.GetBaseCurrency() + this.FetchPrice(this.ItemBarCode).ToString("#,0.00");
									}
									else
									{
										this.ItemPrice = "";
									}
									bool checked2 = this.chkPrintDesc.Checked;
									if (checked2)
									{
										this.ItemDesc = Conversions.ToString(this.dgvStocks.Rows[i].Cells["ProductDesc"].Value);
									}
									else
									{
										this.ItemDesc = "";
									}
									bool flag4 = this.PrintBarCode(this.ItemBarCode, this.ItemPrice, this.ItemDesc, Conversions.ToInteger(objectValue));
									if (flag4)
									{
										num++;
										num2 = Conversions.ToInteger(Operators.AddObject(num2, objectValue));
									}
								}
							}
							MessageBox.Show(Conversions.ToString(num) + " stock items processed. " + Conversions.ToString(num2) + " labels printed.");
						}
						else
						{
							MessageBox.Show("Click View Stocks first before proceeding.");
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error printing labels. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x001B0480 File Offset: 0x001AE680
		private string GetBaseCurrency()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select top 1 BaseCurrency from Company where companyID=" + MyProject.Forms.Form1.coid.ToString();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BaseCurrency"])), "", RuntimeHelpers.GetObjectValue(dataRow["BaseCurrency"])));
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x001B0530 File Offset: 0x001AE730
		private decimal FetchPrice(string prodcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x001B0600 File Offset: 0x001AE800
		public Bitmap createBarCodeWithDescription(string barcodeDescription, string BarcodeNumber, Color BarcodeColor, int BarcodeSize, bool AddBackGroundColor, int othertextsize)
		{
			string text = string.Empty;
			string text2 = BarcodeNumber;
			string text3 = "";
			string text4 = text3 + BarcodeNumber + text3;
			BarcodeNumber = text4;
			Bitmap bitmap;
			Font font;
			Font font3;
			Graphics graphics;
			SizeF sizeF;
			SizeF sizeF2;
			checked
			{
				int num = (int)Math.Round((double)BarcodeSize / 2.0);
				bitmap = new Bitmap(BarcodeSize * 8, BarcodeSize * 3);
				font = new Font("Arial", (float)num, FontStyle.Regular);
				Font font2 = new Font("Arial", (float)othertextsize, FontStyle.Regular);
				font3 = new Font("Free 3 of 9 Extended", (float)BarcodeSize, FontStyle.Regular, GraphicsUnit.Point);
				graphics = Graphics.FromImage(bitmap);
				if (AddBackGroundColor)
				{
					graphics.Clear(Color.White);
				}
				sizeF = graphics.MeasureString(barcodeDescription, font2);
				sizeF2 = graphics.MeasureString(BarcodeNumber, font);
				graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
				graphics.DrawString(barcodeDescription, font, new SolidBrush(BarcodeColor), 2f, 0f);
				graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
				graphics.DrawString(BarcodeNumber, font3, new SolidBrush(BarcodeColor), 2f, unchecked(sizeF.Height + 2f));
				graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
				string text5 = text2;
				for (int i = 0; i < text5.Length; i++)
				{
					text = text + text5[i].ToString() + " ";
				}
			}
			graphics.DrawString(text, font, new SolidBrush(BarcodeColor), 6f, sizeF.Height + sizeF2.Height + 6f);
			graphics.Flush();
			font3.Dispose();
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x001B07C0 File Offset: 0x001AE9C0
		public Bitmap createBarCodeWithDescriptionAndLogoImage(Bitmap img, string barcodeDescription, string BarcodeNumber, Color BarcodeColor, int BarcodeSize, bool AddBackGroundColor, int othertextsize)
		{
			string text = string.Empty;
			string text2 = BarcodeNumber;
			string text3 = "*";
			string text4 = text3 + BarcodeNumber + text3;
			BarcodeNumber = text4;
			Bitmap bitmap;
			Font font;
			Font font3;
			Graphics graphics;
			SizeF sizeF;
			SizeF sizeF2;
			checked
			{
				int num = (int)Math.Round((double)BarcodeSize / 2.0);
				img = new Bitmap(img, new Size(img.Size.Width - img.Size.Width + num, img.Size.Height - img.Size.Height + num));
				bitmap = new Bitmap(BarcodeSize * 8, BarcodeSize * 3);
				font = new Font("Arial", (float)num, FontStyle.Regular);
				Font font2 = new Font("Arial", (float)othertextsize, FontStyle.Regular);
				font3 = new Font("Free 3 of 9 Regular", (float)BarcodeSize, FontStyle.Regular, GraphicsUnit.Point);
				graphics = Graphics.FromImage(bitmap);
				if (AddBackGroundColor)
				{
					graphics.Clear(Color.White);
				}
				graphics.DrawImage(img, 2, 0);
				sizeF = graphics.MeasureString(barcodeDescription, font2);
				sizeF2 = graphics.MeasureString(BarcodeNumber, font);
				graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
				graphics.DrawString(barcodeDescription, font, new SolidBrush(BarcodeColor), (float)(img.Width + 5), 0f);
				graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
				graphics.DrawString(BarcodeNumber, font3, new SolidBrush(BarcodeColor), 2f, unchecked(sizeF.Height + 3f));
				graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
				string text5 = text2;
				for (int i = 0; i < text5.Length; i++)
				{
					text = text + text5[i].ToString() + " ";
				}
			}
			graphics.DrawString(text, font, new SolidBrush(BarcodeColor), 6f, sizeF.Height + sizeF2.Height + 8f);
			graphics.Flush();
			font3.Dispose();
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x001B09E0 File Offset: 0x001AEBE0
		private void pdPrint_PrintPage(object sender, PrintPageEventArgs e)
		{
			BarcodeSymbology barcodeSymbology = (BarcodeSymbology)Conversions.ToInteger(this.txtbarcodesymbology.Text);
			bool flag = (barcodeSymbology == BarcodeSymbology.CodeEan13) & (this.ItemBarCode.Length == 13) & Versioned.IsNumeric(this.ItemBarCode);
			if (flag)
			{
				this.ItemBarCode = this.ItemBarCode.Substring(0, 12);
			}
			else
			{
				bool flag2 = (barcodeSymbology == BarcodeSymbology.CodeEan13) & (this.ItemBarCode.Length == 12) & Versioned.IsNumeric(this.ItemBarCode);
				if (!flag2)
				{
					barcodeSymbology = BarcodeSymbology.Code39NC;
				}
			}
			SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, this.ItemBarCode, 20);
			bool flag3 = MyProject.Forms.Form1.FSYConameBold == 1;
			Font font;
			if (flag3)
			{
				font = new Font("Verdana", Convert.ToSingle(Conversions.ToDecimal(this.txtFScompany.Text)), FontStyle.Bold);
			}
			else
			{
				font = new Font("Verdana", Convert.ToSingle(Conversions.ToDecimal(this.txtFScompany.Text)), FontStyle.Regular);
			}
			bool flag4 = MyProject.Forms.Form1.FSYPriceBold == 1;
			Font font2;
			if (flag4)
			{
				font2 = new Font("Verdana", Convert.ToSingle(Conversions.ToDecimal(this.txtFSprice.Text)), FontStyle.Bold);
			}
			else
			{
				font2 = new Font("Verdana", Convert.ToSingle(Conversions.ToDecimal(this.txtFSprice.Text)), FontStyle.Regular);
			}
			bool flag5 = MyProject.Forms.Form1.FSYDescBold == 1;
			Font font3;
			if (flag5)
			{
				font3 = new Font("Verdana", Convert.ToSingle(Conversions.ToDecimal(this.txtFSdesc.Text)), FontStyle.Bold);
			}
			else
			{
				font3 = new Font("Verdana", Convert.ToSingle(Conversions.ToDecimal(this.txtFSdesc.Text)), FontStyle.Regular);
			}
			Font font4 = new Font("Verdana", Convert.ToSingle(Conversions.ToDecimal(this.txtFSbarcode.Text)));
			StringFormat stringFormat = new StringFormat();
			stringFormat.LineAlignment = StringAlignment.Center;
			Rectangle rectangle = new Rectangle(70, 185, 280, 15);
			bool @checked = this.chkPrintCo.Checked;
			if (@checked)
			{
				e.Graphics.DrawString(MyProject.Forms.Form1.companyname, font, SystemBrushes.WindowText, new PointF((float)Conversions.ToInteger(this.txtFSStartingPoint.Text), Convert.ToSingle(MyProject.Forms.Form1.FSYconame)));
			}
			e.Graphics.DrawImage(symbologyTestCase.BarcodeImage, new Point(Conversions.ToInteger(this.txtFSStartingPoint.Text), Convert.ToInt32(MyProject.Forms.Form1.FSYbarcode)));
			e.Graphics.DrawString(this.BarcodePanel1.Text, font4, SystemBrushes.WindowText, new PointF((float)Conversions.ToInteger(this.txtFSStartingPoint.Text), Convert.ToSingle(MyProject.Forms.Form1.FSYbarcodetext)));
			bool checked2 = this.chkPrice.Checked;
			if (checked2)
			{
				e.Graphics.DrawString(this.ItemPrice, font2, SystemBrushes.WindowText, new PointF((float)Conversions.ToInteger(this.txtFSStartingPoint.Text), Convert.ToSingle(MyProject.Forms.Form1.FSYprice)));
			}
			int num = Conversions.ToInteger(this.txtdesclinelen.Text);
			bool checked3 = this.chkPrintDesc.Checked;
			checked
			{
				if (checked3)
				{
					bool flag6 = this.ItemDesc.Length > num;
					if (flag6)
					{
						string text = this.ItemDesc.Substring(0, num + 1);
						string text2 = this.ItemDesc.Substring(num, this.ItemDesc.Length - num);
						this.ItemDesc = text + "\r\n" + text2;
					}
					e.Graphics.DrawString(this.ItemDesc, font3, SystemBrushes.WindowText, new PointF((float)Conversions.ToInteger(this.txtFSStartingPoint.Text), Convert.ToSingle(MyProject.Forms.Form1.FSYDesc)), stringFormat);
				}
			}
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x001B0DDC File Offset: 0x001AEFDC
		private bool PrintBarCode(string barcodeID, string price, string desc, int numoflabels)
		{
			BarcodeSymbology barcodeSymbology = (BarcodeSymbology)Conversions.ToInteger(this.txtbarcodesymbology.Text);
			this.BarcodePanel1.Text = string.Empty;
			this.BarcodePanel1.Symbology = barcodeSymbology;
			this.BarcodePanel1.Text = barcodeID;
			string text = "Barcode";
			this.PrintDocument1.PrinterSettings.PrinterName = this.cboInstalledPrinters.Text;
			this.PrintDocument1.PrintController = new StandardPrintController();
			this.PrintDocument1.PrinterSettings.Copies = checked((short)numoflabels);
			bool isValid = this.PrintDocument1.PrinterSettings.IsValid;
			if (isValid)
			{
				this.PrintDocument1.DocumentName = text;
				this.PrintDocument1.Print();
			}
			return true;
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x001B0EA4 File Offset: 0x001AF0A4
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

		// Token: 0x06003218 RID: 12824 RVA: 0x001B0F04 File Offset: 0x001AF104
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

		// Token: 0x06003219 RID: 12825 RVA: 0x001B0FC4 File Offset: 0x001AF1C4
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
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x001B119C File Offset: 0x001AF39C
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

		// Token: 0x0600321B RID: 12827 RVA: 0x001B11FC File Offset: 0x001AF3FC
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

		// Token: 0x0600321C RID: 12828 RVA: 0x001B12F4 File Offset: 0x001AF4F4
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

		// Token: 0x0600321D RID: 12829 RVA: 0x001B1360 File Offset: 0x001AF560
		private void txtProductCode_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvStocks.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvStocks.ClearSelection();
							dataGridViewRow.Cells["ProductDesc"].Selected = true;
							this.dgvStocks.CurrentCell = dataGridViewRow.Cells["ProductDesc"];
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

		// Token: 0x0600321E RID: 12830 RVA: 0x001B1450 File Offset: 0x001AF650
		private void LoadPrinters()
		{
			try
			{
				foreach (object obj in PrinterSettings.InstalledPrinters)
				{
					string text = Conversions.ToString(obj);
					this.cboInstalledPrinters.Items.Add(text);
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
			this.cboInstalledPrinters.SelectedIndex = -1;
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x001B14C8 File Offset: 0x001AF6C8
		private void txtFSbarcode_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x001B1514 File Offset: 0x001AF714
		private void txtFSprice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x001B1560 File Offset: 0x001AF760
		private void txtFSdesc_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x001B15AC File Offset: 0x001AF7AC
		private void txtFScompany_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x001B15F8 File Offset: 0x001AF7F8
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.AddUpdateAppSettings("FSBarcode", Conversions.ToString(Conversions.ToDecimal(this.txtFSbarcode.Text)));
				MyProject.Forms.Form1.FSBarcode = Conversions.ToDecimal(this.txtFSbarcode.Text);
				this.AddUpdateAppSettings("FSPrice", Conversions.ToString(Conversions.ToDecimal(this.txtFSprice.Text)));
				MyProject.Forms.Form1.FSPrice = Conversions.ToDecimal(this.txtFSprice.Text);
				this.AddUpdateAppSettings("FSDesc", Conversions.ToString(Conversions.ToDecimal(this.txtFSdesc.Text)));
				MyProject.Forms.Form1.FSDesc = Conversions.ToDecimal(this.txtFSdesc.Text);
				this.AddUpdateAppSettings("FSCompany", Conversions.ToString(Conversions.ToDecimal(this.txtFScompany.Text)));
				MyProject.Forms.Form1.FSCompany = Conversions.ToDecimal(this.txtFScompany.Text);
				this.AddUpdateAppSettings("FSBarcodesymbology", Conversions.ToString(Conversions.ToDecimal(this.txtbarcodesymbology.Text)));
				MyProject.Forms.Form1.FSBarcodesymbology = Conversions.ToInteger(this.txtbarcodesymbology.Text);
				this.AddUpdateAppSettings("FSStartingpoint", Conversions.ToString(Conversions.ToDecimal(this.txtFSStartingPoint.Text)));
				MyProject.Forms.Form1.FSStartingPoint = Conversions.ToInteger(this.txtFSStartingPoint.Text);
				bool @checked = this.chkPriceBold.Checked;
				if (@checked)
				{
					this.AddUpdateAppSettings("FSYPriceBold", Conversions.ToString(1));
					MyProject.Forms.Form1.FSYPriceBold = 1;
				}
				else
				{
					this.AddUpdateAppSettings("FSYPriceBold", Conversions.ToString(0));
					MyProject.Forms.Form1.FSYPriceBold = 0;
				}
				bool checked2 = this.chkDescBold.Checked;
				if (checked2)
				{
					this.AddUpdateAppSettings("FSYDescBold", Conversions.ToString(1));
					MyProject.Forms.Form1.FSYDescBold = 1;
				}
				else
				{
					this.AddUpdateAppSettings("FSYDescBold", Conversions.ToString(0));
					MyProject.Forms.Form1.FSYDescBold = 0;
				}
				bool checked3 = this.chkCoBold.Checked;
				if (checked3)
				{
					this.AddUpdateAppSettings("FSYConameBold", Conversions.ToString(1));
					MyProject.Forms.Form1.FSYConameBold = 1;
				}
				else
				{
					this.AddUpdateAppSettings("FSYConameBold", Conversions.ToString(0));
					MyProject.Forms.Form1.FSYConameBold = 0;
				}
				MessageBox.Show("Data Saved.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving settings. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x001B18E0 File Offset: 0x001AFAE0
		private void AddUpdateAppSettings(string key, string value)
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

		// Token: 0x06003225 RID: 12837 RVA: 0x00012800 File Offset: 0x00010A00
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtFSStartingPoint_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x001B194C File Offset: 0x001AFB4C
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadStocks(this.cboBranch.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x001B1990 File Offset: 0x001AFB90
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.AddUpdateAppSettings("FSYconame", Conversions.ToString(Conversions.ToDecimal(this.txtConameY.Text)));
				MyProject.Forms.Form1.FSYconame = Conversions.ToDecimal(this.txtConameY.Text);
				this.AddUpdateAppSettings("FSYbarcode", Conversions.ToString(Conversions.ToDecimal(this.txtBarcodeY.Text)));
				MyProject.Forms.Form1.FSYbarcode = Conversions.ToDecimal(this.txtBarcodeY.Text);
				this.AddUpdateAppSettings("FSYbarcodetext", Conversions.ToString(Conversions.ToDecimal(this.txtBarcodeTextY.Text)));
				MyProject.Forms.Form1.FSYbarcodetext = Conversions.ToDecimal(this.txtBarcodeTextY.Text);
				this.AddUpdateAppSettings("FSYprice", Conversions.ToString(Conversions.ToDecimal(this.txtPrice.Text)));
				MyProject.Forms.Form1.FSYprice = Conversions.ToDecimal(this.txtPrice.Text);
				this.AddUpdateAppSettings("FSYDesc", Conversions.ToString(Conversions.ToDecimal(this.txtProductDescY.Text)));
				MyProject.Forms.Form1.FSYDesc = Conversions.ToDecimal(this.txtProductDescY.Text);
				this.AddUpdateAppSettings("FSBarcode", Conversions.ToString(Conversions.ToDecimal(this.txtFSbarcode.Text)));
				MyProject.Forms.Form1.FSBarcode = Conversions.ToDecimal(this.txtFSbarcode.Text);
				this.AddUpdateAppSettings("FSPrice", Conversions.ToString(Conversions.ToDecimal(this.txtFSprice.Text)));
				MyProject.Forms.Form1.FSPrice = Conversions.ToDecimal(this.txtFSprice.Text);
				this.AddUpdateAppSettings("FSDesc", Conversions.ToString(Conversions.ToDecimal(this.txtFSdesc.Text)));
				MyProject.Forms.Form1.FSDesc = Conversions.ToDecimal(this.txtFSdesc.Text);
				this.AddUpdateAppSettings("FSCompany", Conversions.ToString(Conversions.ToDecimal(this.txtFScompany.Text)));
				MyProject.Forms.Form1.FSCompany = Conversions.ToDecimal(this.txtFScompany.Text);
				this.AddUpdateAppSettings("FSBarcodesymbology", Conversions.ToString(Conversions.ToDecimal(this.txtbarcodesymbology.Text)));
				MyProject.Forms.Form1.FSBarcodesymbology = Conversions.ToInteger(this.txtbarcodesymbology.Text);
				this.AddUpdateAppSettings("FSStartingpoint", Conversions.ToString(Conversions.ToDecimal(this.txtFSStartingPoint.Text)));
				MyProject.Forms.Form1.FSStartingPoint = Conversions.ToInteger(this.txtFSStartingPoint.Text);
				bool @checked = this.chkPriceBold.Checked;
				if (@checked)
				{
					this.AddUpdateAppSettings("FSYPriceBold", Conversions.ToString(1));
					MyProject.Forms.Form1.FSYPriceBold = 1;
				}
				else
				{
					this.AddUpdateAppSettings("FSYPriceBold", Conversions.ToString(0));
					MyProject.Forms.Form1.FSYPriceBold = 0;
				}
				bool checked2 = this.chkDescBold.Checked;
				if (checked2)
				{
					this.AddUpdateAppSettings("FSYDescBold", Conversions.ToString(1));
					MyProject.Forms.Form1.FSYDescBold = 1;
				}
				else
				{
					this.AddUpdateAppSettings("FSYDescBold", Conversions.ToString(0));
					MyProject.Forms.Form1.FSYDescBold = 0;
				}
				bool checked3 = this.chkCoBold.Checked;
				if (checked3)
				{
					this.AddUpdateAppSettings("FSYConameBold", Conversions.ToString(1));
					MyProject.Forms.Form1.FSYConameBold = 1;
				}
				else
				{
					this.AddUpdateAppSettings("FSYConameBold", Conversions.ToString(0));
					MyProject.Forms.Form1.FSYConameBold = 0;
				}
				this.AddUpdateAppSettings("FSYDescLineLen", Conversions.ToString(Conversions.ToDecimal(this.txtdesclinelen.Text)));
				MyProject.Forms.Form1.FSYDescLineLen = Conversions.ToDecimal(this.txtdesclinelen.Text);
				MessageBox.Show("Position Data Saved.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving settings. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x001B1DF8 File Offset: 0x001AFFF8
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvStocks.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["CHKcol"].Value = true;
						dataGridViewRow.Cells["QTYcol"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value);
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
				MessageBox.Show("Error selecting all. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x001B1ED8 File Offset: 0x001B00D8
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvStocks.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["CHKcol"].Value = true;
						dataGridViewRow.Cells["QTYcol"].Value = 1;
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
				MessageBox.Show("Error selecting all. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x001B1FA4 File Offset: 0x001B01A4
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvStocks.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["CHKcol"].Value = false;
						dataGridViewRow.Cells["QTYcol"].Value = 0;
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
				MessageBox.Show("Error deselecting all. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x00002A30 File Offset: 0x00000C30
		private void barcodeDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
		}

		// Token: 0x0400155D RID: 5469
		private string _cnn;

		// Token: 0x0400155E RID: 5470
		private IEnumerator<BarcodeSymbology> _testIterator;

		// Token: 0x0400155F RID: 5471
		private BarcodeSymbology _testplan;

		// Token: 0x04001560 RID: 5472
		private string ItemDesc;

		// Token: 0x04001561 RID: 5473
		private string ItemPrice;

		// Token: 0x04001562 RID: 5474
		private string ItemBarCode;

		// Token: 0x04001563 RID: 5475
		private PublicFunctions pf;
	}
}
