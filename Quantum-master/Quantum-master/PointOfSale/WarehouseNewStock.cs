using System;
using System.Collections;
using System.ComponentModel;
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
	// Token: 0x0200021A RID: 538
	[DesignerGenerated]
	public partial class WarehouseNewStock : UserControl
	{
		// Token: 0x060060B9 RID: 24761 RVA: 0x003736C0 File Offset: 0x003718C0
		public WarehouseNewStock()
		{
			base.Load += this.WarehouseNewStock_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.calc = false;
			this.InitializeComponent();
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x060060BC RID: 24764 RVA: 0x00375BEB File Offset: 0x00373DEB
		// (set) Token: 0x060060BD RID: 24765 RVA: 0x00375BF5 File Offset: 0x00373DF5
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x060060BE RID: 24766 RVA: 0x00375BFE File Offset: 0x00373DFE
		// (set) Token: 0x060060BF RID: 24767 RVA: 0x00375C08 File Offset: 0x00373E08
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x060060C0 RID: 24768 RVA: 0x00375C11 File Offset: 0x00373E11
		// (set) Token: 0x060060C1 RID: 24769 RVA: 0x00375C1B File Offset: 0x00373E1B
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x060060C2 RID: 24770 RVA: 0x00375C24 File Offset: 0x00373E24
		// (set) Token: 0x060060C3 RID: 24771 RVA: 0x00375C2E File Offset: 0x00373E2E
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x060060C4 RID: 24772 RVA: 0x00375C37 File Offset: 0x00373E37
		// (set) Token: 0x060060C5 RID: 24773 RVA: 0x00375C41 File Offset: 0x00373E41
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x060060C6 RID: 24774 RVA: 0x00375C4A File Offset: 0x00373E4A
		// (set) Token: 0x060060C7 RID: 24775 RVA: 0x00375C54 File Offset: 0x00373E54
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

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x060060C8 RID: 24776 RVA: 0x00375CB2 File Offset: 0x00373EB2
		// (set) Token: 0x060060C9 RID: 24777 RVA: 0x00375CBC File Offset: 0x00373EBC
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x060060CA RID: 24778 RVA: 0x00375CC5 File Offset: 0x00373EC5
		// (set) Token: 0x060060CB RID: 24779 RVA: 0x00375CD0 File Offset: 0x00373ED0
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

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x060060CC RID: 24780 RVA: 0x00375D13 File Offset: 0x00373F13
		// (set) Token: 0x060060CD RID: 24781 RVA: 0x00375D1D File Offset: 0x00373F1D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x060060CE RID: 24782 RVA: 0x00375D26 File Offset: 0x00373F26
		// (set) Token: 0x060060CF RID: 24783 RVA: 0x00375D30 File Offset: 0x00373F30
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

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x060060D0 RID: 24784 RVA: 0x00375D73 File Offset: 0x00373F73
		// (set) Token: 0x060060D1 RID: 24785 RVA: 0x00375D80 File Offset: 0x00373F80
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

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x060060D2 RID: 24786 RVA: 0x00375DC3 File Offset: 0x00373FC3
		// (set) Token: 0x060060D3 RID: 24787 RVA: 0x00375DCD File Offset: 0x00373FCD
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x060060D4 RID: 24788 RVA: 0x00375DD6 File Offset: 0x00373FD6
		// (set) Token: 0x060060D5 RID: 24789 RVA: 0x00375DE0 File Offset: 0x00373FE0
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

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x060060D6 RID: 24790 RVA: 0x00375E23 File Offset: 0x00374023
		// (set) Token: 0x060060D7 RID: 24791 RVA: 0x00375E2D File Offset: 0x0037402D
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x060060D8 RID: 24792 RVA: 0x00375E36 File Offset: 0x00374036
		// (set) Token: 0x060060D9 RID: 24793 RVA: 0x00375E40 File Offset: 0x00374040
		internal virtual TextBox txtSearchProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x060060DA RID: 24794 RVA: 0x00375E49 File Offset: 0x00374049
		// (set) Token: 0x060060DB RID: 24795 RVA: 0x00375E53 File Offset: 0x00374053
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x060060DC RID: 24796 RVA: 0x00375E5C File Offset: 0x0037405C
		// (set) Token: 0x060060DD RID: 24797 RVA: 0x00375E66 File Offset: 0x00374066
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x060060DE RID: 24798 RVA: 0x00375E6F File Offset: 0x0037406F
		// (set) Token: 0x060060DF RID: 24799 RVA: 0x00375E79 File Offset: 0x00374079
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x060060E0 RID: 24800 RVA: 0x00375E82 File Offset: 0x00374082
		// (set) Token: 0x060060E1 RID: 24801 RVA: 0x00375E8C File Offset: 0x0037408C
		internal virtual TextBox txtCost
		{
			[CompilerGenerated]
			get
			{
				return this._txtCost;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCost_KeyPress);
				TextBox textBox = this._txtCost;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCost = value;
				textBox = this._txtCost;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x060060E2 RID: 24802 RVA: 0x00375ECF File Offset: 0x003740CF
		// (set) Token: 0x060060E3 RID: 24803 RVA: 0x00375ED9 File Offset: 0x003740D9
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x060060E4 RID: 24804 RVA: 0x00375EE2 File Offset: 0x003740E2
		// (set) Token: 0x060060E5 RID: 24805 RVA: 0x00375EEC File Offset: 0x003740EC
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

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x060060E6 RID: 24806 RVA: 0x00375F2F File Offset: 0x0037412F
		// (set) Token: 0x060060E7 RID: 24807 RVA: 0x00375F39 File Offset: 0x00374139
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x060060E8 RID: 24808 RVA: 0x00375F42 File Offset: 0x00374142
		// (set) Token: 0x060060E9 RID: 24809 RVA: 0x00375F4C File Offset: 0x0037414C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x060060EA RID: 24810 RVA: 0x00375F55 File Offset: 0x00374155
		// (set) Token: 0x060060EB RID: 24811 RVA: 0x00375F60 File Offset: 0x00374160
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

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x060060EC RID: 24812 RVA: 0x00375FA3 File Offset: 0x003741A3
		// (set) Token: 0x060060ED RID: 24813 RVA: 0x00375FAD File Offset: 0x003741AD
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x060060EE RID: 24814 RVA: 0x00375FB6 File Offset: 0x003741B6
		// (set) Token: 0x060060EF RID: 24815 RVA: 0x00375FC0 File Offset: 0x003741C0
		internal virtual DataGridView dgvPurchases
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x060060F0 RID: 24816 RVA: 0x00375FC9 File Offset: 0x003741C9
		// (set) Token: 0x060060F1 RID: 24817 RVA: 0x00375FD3 File Offset: 0x003741D3
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x060060F2 RID: 24818 RVA: 0x00375FDC File Offset: 0x003741DC
		// (set) Token: 0x060060F3 RID: 24819 RVA: 0x00375FE8 File Offset: 0x003741E8
		internal virtual DataGridView dgvCosts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvCosts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewRowEventHandler dataGridViewRowEventHandler = new DataGridViewRowEventHandler(this.DgvCosts_UserDeletedRow);
				DataGridView dataGridView = this._dgvCosts;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow -= dataGridViewRowEventHandler;
				}
				this._dgvCosts = value;
				dataGridView = this._dgvCosts;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow += dataGridViewRowEventHandler;
				}
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x060060F4 RID: 24820 RVA: 0x0037602B File Offset: 0x0037422B
		// (set) Token: 0x060060F5 RID: 24821 RVA: 0x00376035 File Offset: 0x00374235
		internal virtual DataGridViewTextBoxColumn Description
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x060060F6 RID: 24822 RVA: 0x0037603E File Offset: 0x0037423E
		// (set) Token: 0x060060F7 RID: 24823 RVA: 0x00376048 File Offset: 0x00374248
		internal virtual DataGridViewTextBoxColumn DirectCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x060060F8 RID: 24824 RVA: 0x00376051 File Offset: 0x00374251
		// (set) Token: 0x060060F9 RID: 24825 RVA: 0x0037605C File Offset: 0x0037425C
		internal virtual TextBox txtBatchCost
		{
			[CompilerGenerated]
			get
			{
				return this._txtBatchCost;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtBatchCost_KeyPress);
				TextBox textBox = this._txtBatchCost;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtBatchCost = value;
				textBox = this._txtBatchCost;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x060060FA RID: 24826 RVA: 0x0037609F File Offset: 0x0037429F
		// (set) Token: 0x060060FB RID: 24827 RVA: 0x003760A9 File Offset: 0x003742A9
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x060060FC RID: 24828 RVA: 0x003760B2 File Offset: 0x003742B2
		// (set) Token: 0x060060FD RID: 24829 RVA: 0x003760BC File Offset: 0x003742BC
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

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060060FE RID: 24830 RVA: 0x003760FF File Offset: 0x003742FF
		// (set) Token: 0x060060FF RID: 24831 RVA: 0x00376109 File Offset: 0x00374309
		internal virtual TextBox txtBatchDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x06006100 RID: 24832 RVA: 0x00376112 File Offset: 0x00374312
		// (set) Token: 0x06006101 RID: 24833 RVA: 0x0037611C File Offset: 0x0037431C
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x06006102 RID: 24834 RVA: 0x00376125 File Offset: 0x00374325
		// (set) Token: 0x06006103 RID: 24835 RVA: 0x00376130 File Offset: 0x00374330
		internal virtual TextBox txtMargin
		{
			[CompilerGenerated]
			get
			{
				return this._txtMargin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtMargin_KeyPress);
				TextBox textBox = this._txtMargin;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtMargin = value;
				textBox = this._txtMargin;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x06006104 RID: 24836 RVA: 0x00376173 File Offset: 0x00374373
		// (set) Token: 0x06006105 RID: 24837 RVA: 0x0037617D File Offset: 0x0037437D
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06006106 RID: 24838 RVA: 0x00376186 File Offset: 0x00374386
		// (set) Token: 0x06006107 RID: 24839 RVA: 0x00376190 File Offset: 0x00374390
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

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x06006108 RID: 24840 RVA: 0x003761D3 File Offset: 0x003743D3
		// (set) Token: 0x06006109 RID: 24841 RVA: 0x003761DD File Offset: 0x003743DD
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x0600610A RID: 24842 RVA: 0x003761E6 File Offset: 0x003743E6
		// (set) Token: 0x0600610B RID: 24843 RVA: 0x003761F0 File Offset: 0x003743F0
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

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x0600610C RID: 24844 RVA: 0x00376233 File Offset: 0x00374433
		// (set) Token: 0x0600610D RID: 24845 RVA: 0x0037623D File Offset: 0x0037443D
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x0600610E RID: 24846 RVA: 0x00376246 File Offset: 0x00374446
		// (set) Token: 0x0600610F RID: 24847 RVA: 0x00376250 File Offset: 0x00374450
		internal virtual Label lblTotalCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x06006110 RID: 24848 RVA: 0x00376259 File Offset: 0x00374459
		// (set) Token: 0x06006111 RID: 24849 RVA: 0x00376264 File Offset: 0x00374464
		internal virtual Label Label13
		{
			[CompilerGenerated]
			get
			{
				return this._Label13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label13_Click);
				Label label = this._Label13;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label13 = value;
				label = this._Label13;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x06006112 RID: 24850 RVA: 0x003762A7 File Offset: 0x003744A7
		// (set) Token: 0x06006113 RID: 24851 RVA: 0x003762B1 File Offset: 0x003744B1
		internal virtual TextBox txtref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x06006114 RID: 24852 RVA: 0x003762BA File Offset: 0x003744BA
		// (set) Token: 0x06006115 RID: 24853 RVA: 0x003762C4 File Offset: 0x003744C4
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x06006116 RID: 24854 RVA: 0x003762CD File Offset: 0x003744CD
		// (set) Token: 0x06006117 RID: 24855 RVA: 0x003762D7 File Offset: 0x003744D7
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06006118 RID: 24856 RVA: 0x003762E0 File Offset: 0x003744E0
		// (set) Token: 0x06006119 RID: 24857 RVA: 0x003762EA File Offset: 0x003744EA
		internal virtual DataGridViewTextBoxColumn TranDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x0600611A RID: 24858 RVA: 0x003762F3 File Offset: 0x003744F3
		// (set) Token: 0x0600611B RID: 24859 RVA: 0x003762FD File Offset: 0x003744FD
		internal virtual DataGridViewTextBoxColumn ProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x0600611C RID: 24860 RVA: 0x00376306 File Offset: 0x00374506
		// (set) Token: 0x0600611D RID: 24861 RVA: 0x00376310 File Offset: 0x00374510
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x0600611E RID: 24862 RVA: 0x00376319 File Offset: 0x00374519
		// (set) Token: 0x0600611F RID: 24863 RVA: 0x00376323 File Offset: 0x00374523
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06006120 RID: 24864 RVA: 0x0037632C File Offset: 0x0037452C
		// (set) Token: 0x06006121 RID: 24865 RVA: 0x00376336 File Offset: 0x00374536
		internal virtual DataGridViewTextBoxColumn Quantity
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06006122 RID: 24866 RVA: 0x0037633F File Offset: 0x0037453F
		// (set) Token: 0x06006123 RID: 24867 RVA: 0x00376349 File Offset: 0x00374549
		internal virtual DataGridViewTextBoxColumn Cost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x06006124 RID: 24868 RVA: 0x00376352 File Offset: 0x00374552
		// (set) Token: 0x06006125 RID: 24869 RVA: 0x0037635C File Offset: 0x0037455C
		internal virtual DataGridViewTextBoxColumn NewCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x06006126 RID: 24870 RVA: 0x00376365 File Offset: 0x00374565
		// (set) Token: 0x06006127 RID: 24871 RVA: 0x0037636F File Offset: 0x0037456F
		internal virtual DataGridViewTextBoxColumn SellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x06006128 RID: 24872 RVA: 0x00376378 File Offset: 0x00374578
		// (set) Token: 0x06006129 RID: 24873 RVA: 0x00376382 File Offset: 0x00374582
		internal virtual DataGridViewTextBoxColumn SubTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x0600612A RID: 24874 RVA: 0x0037638B File Offset: 0x0037458B
		// (set) Token: 0x0600612B RID: 24875 RVA: 0x00376395 File Offset: 0x00374595
		internal virtual DataGridViewTextBoxColumn Prop
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x0600612C RID: 24876 RVA: 0x0037639E File Offset: 0x0037459E
		// (set) Token: 0x0600612D RID: 24877 RVA: 0x003763A8 File Offset: 0x003745A8
		internal virtual TextBox txtReorderLevel
		{
			[CompilerGenerated]
			get
			{
				return this._txtReorderLevel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtReorderLevel_KeyPress);
				TextBox textBox = this._txtReorderLevel;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtReorderLevel = value;
				textBox = this._txtReorderLevel;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x0600612E RID: 24878 RVA: 0x003763EB File Offset: 0x003745EB
		// (set) Token: 0x0600612F RID: 24879 RVA: 0x003763F5 File Offset: 0x003745F5
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x06006130 RID: 24880 RVA: 0x003763FE File Offset: 0x003745FE
		// (set) Token: 0x06006131 RID: 24881 RVA: 0x00376408 File Offset: 0x00374608
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x06006132 RID: 24882 RVA: 0x00376411 File Offset: 0x00374611
		// (set) Token: 0x06006133 RID: 24883 RVA: 0x0037641B File Offset: 0x0037461B
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x06006134 RID: 24884 RVA: 0x00376424 File Offset: 0x00374624
		// (set) Token: 0x06006135 RID: 24885 RVA: 0x0037642E File Offset: 0x0037462E
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x06006136 RID: 24886 RVA: 0x00376437 File Offset: 0x00374637
		// (set) Token: 0x06006137 RID: 24887 RVA: 0x00376441 File Offset: 0x00374641
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x06006138 RID: 24888 RVA: 0x0037644A File Offset: 0x0037464A
		// (set) Token: 0x06006139 RID: 24889 RVA: 0x00376454 File Offset: 0x00374654
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x0037645D File Offset: 0x0037465D
		// (set) Token: 0x0600613B RID: 24891 RVA: 0x00376467 File Offset: 0x00374667
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x0600613C RID: 24892 RVA: 0x00376470 File Offset: 0x00374670
		// (set) Token: 0x0600613D RID: 24893 RVA: 0x0037647A File Offset: 0x0037467A
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x0600613E RID: 24894 RVA: 0x00376483 File Offset: 0x00374683
		// (set) Token: 0x0600613F RID: 24895 RVA: 0x0037648D File Offset: 0x0037468D
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06006140 RID: 24896 RVA: 0x00376496 File Offset: 0x00374696
		// (set) Token: 0x06006141 RID: 24897 RVA: 0x003764A0 File Offset: 0x003746A0
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x003764AC File Offset: 0x003746AC
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
			this.cboBranches.DataSource = dataTable;
			this.cboBranches.ValueMember = "branch";
			this.cboBranches.DisplayMember = "branch";
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0037654C File Offset: 0x0037474C
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

		// Token: 0x06006144 RID: 24900 RVA: 0x003765AC File Offset: 0x003747AC
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

		// Token: 0x06006145 RID: 24901 RVA: 0x0037674C File Offset: 0x0037494C
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
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x00376828 File Offset: 0x00374A28
		private void FetchProdtDetailsBYCode(string prodtcode)
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
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtSearchProductID.Text = Conversions.ToString(dataRow["ProductID"]);
				this.txtReorderLevel.Text = dataRow["ReorderLevel"].ToString();
				this.txtCost.Text = dataRow["Cost"].ToString();
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
			}
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x00376950 File Offset: 0x00374B50
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetailsBYCode(this.txtSearchProductCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred searching by code. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x003769B0 File Offset: 0x00374BB0
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

		// Token: 0x06006149 RID: 24905 RVA: 0x00376A70 File Offset: 0x00374C70
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

		// Token: 0x0600614A RID: 24906 RVA: 0x00376ADC File Offset: 0x00374CDC
		private void AppendGrid()
		{
			string text = this.DTDate.Value.ToShortDateString();
			double num = Conversion.Val(this.txtCost.Text) / Conversion.Val(this.txtQty.Text);
			string text2 = this.lblDesc.Text;
			string[] array = new string[]
			{
				text,
				this.txtSearchProductID.Text,
				this.txtSearchProductCode.Text,
				text2,
				this.txtQty.Text,
				num.ToString("#,0.00"),
				"Not Set",
				"Not Set"
			};
			this.dgvPurchases.Rows.Add(array);
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x00376B98 File Offset: 0x00374D98
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtref.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter reference information before proceeding.");
				}
				else
				{
					this.AppendGrid();
					this.txtCost.Text = "0";
					this.txtQty.Text = "0";
					this.txtSearchProductCode.Text = "";
					this.txtReorderLevel.Text = "";
					this.txtSearchProductCode.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending to grid. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x00376C64 File Offset: 0x00374E64
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				NewProdt2 newProdt = new NewProdt2();
				newProdt.ShowDialog(this);
				newProdt.Dispose();
				string newProdtCode = MyProject.Forms.Form1.newProdtCode;
				this.txtSearchProductCode.Text = newProdtCode;
				this.txtQty.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("New product error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x00376CEC File Offset: 0x00374EEC
		private void txtMargin_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x00376D38 File Offset: 0x00374F38
		private void txtBatchCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x00376D84 File Offset: 0x00374F84
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x00376DD0 File Offset: 0x00374FD0
		private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x00376E1C File Offset: 0x0037501C
		private void txtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x00376E68 File Offset: 0x00375068
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.AppendCosts();
				this.lblTotalCost.Text = this.CalcTotalCost().ToString();
				this.txtBatchCost.Text = "";
				this.txtBatchDesc.Text = "";
				this.txtBatchDesc.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding costs. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x00376F00 File Offset: 0x00375100
		private void AppendCosts()
		{
			double num = Conversion.Val(this.txtBatchCost.Text);
			string[] array = new string[]
			{
				this.txtBatchDesc.Text,
				num.ToString("#,0.00")
			};
			this.dgvCosts.Rows.Add(array);
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x00376F58 File Offset: 0x00375158
		private double CalcTotalCost()
		{
			double num = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvCosts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DirectCost"].Value));
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
			return num;
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x00376FEC File Offset: 0x003751EC
		private void DgvCosts_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				this.lblTotalCost.Text = this.CalcTotalCost().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error recalculating total cost. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x00377050 File Offset: 0x00375250
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtMargin.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter the mark up margin first.");
				}
				else
				{
					this.CalcNewCost();
					this.calc = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating new price. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x003770D4 File Offset: 0x003752D4
		private void CalcNewCost()
		{
			int count = this.dgvPurchases.Rows.Count;
			double num = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvPurchases.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells["SubTotal"].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Quantity"].Value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Cost"].Value));
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SubTotal"].Value));
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
				foreach (object obj2 in ((IEnumerable)this.dgvPurchases.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					dataGridViewRow2.Cells["Prop"].Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["SubTotal"].Value)) / num, 2, MidpointRounding.AwayFromZero);
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
			try
			{
				foreach (object obj3 in ((IEnumerable)this.dgvPurchases.Rows))
				{
					DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
					double num2 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Prop"].Value)) * Conversion.Val(this.lblTotalCost.Text), 2, MidpointRounding.AwayFromZero);
					dataGridViewRow3.Cells["NewCost"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
					{
						Operators.AddObject(dataGridViewRow3.Cells["Cost"].Value, num2 / Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["Quantity"].Value))),
						2,
						MidpointRounding.AwayFromZero
					}, null, null, null));
					dataGridViewRow3.Cells["SellingPrice"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
					{
						Operators.AddObject(dataGridViewRow3.Cells["NewCost"].Value, Conversion.Val(this.txtMargin.Text) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells["NewCost"].Value))),
						2,
						MidpointRounding.AwayFromZero
					}, null, null, null));
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
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label13_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x00377464 File Offset: 0x00375664
		private void InsertBatchCosts(int invnum, int TranDate, string Ref, string ExpDesc, double ExpAmount, double Margin, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertBatchCost";
			sqlCommand.Parameters.AddWithValue("InvNum", invnum);
			sqlCommand.Parameters.AddWithValue("TranDate", TranDate);
			sqlCommand.Parameters.AddWithValue("Ref", Ref);
			sqlCommand.Parameters.AddWithValue("ExpDesc", ExpDesc);
			sqlCommand.Parameters.AddWithValue("ExpAmount", ExpAmount);
			sqlCommand.Parameters.AddWithValue("Margin", Margin);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x0037758C File Offset: 0x0037578C
		private void Button6_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = this.calc;
					if (flag)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to enter these Purchases at the displayed costs and selling prices? ", MsgBoxStyle.YesNo, null);
						bool flag2 = dialogResult == DialogResult.Yes;
						if (flag2)
						{
							int invoiceNum = this.GetInvoiceNum();
							try
							{
								foreach (object obj in ((IEnumerable)this.dgvPurchases.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									this.UpdateProduct(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), 0, Conversions.ToDouble(dataGridViewRow.Cells["NewCost"].Value), Conversions.ToDouble(dataGridViewRow.Cells["SellingPrice"].Value), (int)Math.Round(Conversion.Val(this.txtReorderLevel.Text)));
									this.InsertStock(invoiceNum, Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), this.txtref.Text, Conversions.ToInteger(dataGridViewRow.Cells["Quantity"].Value), Conversions.ToDouble(dataGridViewRow.Cells["NewCost"].Value), Conversions.ToString(dataGridViewRow.Cells["ProductCode"].Value));
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
								foreach (object obj2 in ((IEnumerable)this.dgvCosts.Rows))
								{
									DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
									this.InsertBatchCosts(invoiceNum, (int)Math.Round(Conversion.Val(this.DTDate.Value.ToString("yyyyMMdd"))), this.txtref.Text, Conversions.ToString(dataGridViewRow2.Cells["Description"].Value), Conversions.ToDouble(dataGridViewRow2.Cells["DirectCost"].Value), Conversion.Val(this.txtMargin.Text), MyProject.Forms.Form1.coid, this.cboBranches.Text);
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
							this.calc = false;
						}
						MessageBox.Show("Purchases have successfully been saved into the Warehouse.");
						this.dgvPurchases.Rows.Clear();
						this.dgvCosts.Rows.Clear();
						this.TabControl1.SelectedTab = this.TabPage1;
					}
					else
					{
						MessageBox.Show("Please calculate the new cost and selling prices first.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error confirming purchase. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x003778BC File Offset: 0x00375ABC
		private void UpdateProduct(int productid, int unitsperpack, double cost, double sellingprice, int reorderlevel)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Updateproduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("unitsperpack", unitsperpack);
			sqlCommand.Parameters.AddWithValue("cost", cost);
			sqlCommand.Parameters.AddWithValue("sellingprice", sellingprice);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("reorderlevel", reorderlevel);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x00377A18 File Offset: 0x00375C18
		private void InsertStock(int invoicenum, int productid, string @ref, int quantity, double cost, string productcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock2";
			sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isstockin", 1);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			sqlCommand.Parameters.AddWithValue("quantity", quantity);
			sqlCommand.Parameters.AddWithValue("cost", cost);
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("productcode", this.txtSearchProductCode.Text);
			sqlCommand.Parameters.AddWithValue("trancode", 1);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x00377BFC File Offset: 0x00375DFC
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

		// Token: 0x0600615E RID: 24926 RVA: 0x00377CD4 File Offset: 0x00375ED4
		private void WarehouseNewStock_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.txtref.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x00377D30 File Offset: 0x00375F30
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					e.Handled = true;
					this.txtQty.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x04002AD5 RID: 10965
		private string _cnn;

		// Token: 0x04002AD6 RID: 10966
		private bool calc;
	}
}
