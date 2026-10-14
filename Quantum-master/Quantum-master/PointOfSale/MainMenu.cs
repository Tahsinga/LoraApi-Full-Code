using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EltradeFPAx;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.My.Resources;

namespace PointOfSale
{
	// Token: 0x0200006C RID: 108
	[DesignerGenerated]
	public partial class MainMenu : Form
	{
		// Token: 0x06001675 RID: 5749 RVA: 0x000D12C0 File Offset: 0x000CF4C0
		public MainMenu()
		{
			base.FormClosed += this.MainMenu_FormClosed;
			base.Load += this.MainMenu_Load;
			base.FormClosing += this.MainMenu_FormClosing;
			this.Publicfunction = new PublicFunctions();
			this.menuLevel = 0;
			this.menuDAT = new DataTable();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x000D5954 File Offset: 0x000D3B54
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x000D5960 File Offset: 0x000D3B60
		internal virtual MenuStrip MenuStrip1
		{
			[CompilerGenerated]
			get
			{
				return this._MenuStrip1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.MenuStrip1_Click);
				ToolStripItemClickedEventHandler toolStripItemClickedEventHandler = new ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
				MenuStrip menuStrip = this._MenuStrip1;
				if (menuStrip != null)
				{
					menuStrip.Click -= eventHandler;
					menuStrip.ItemClicked -= toolStripItemClickedEventHandler;
				}
				this._MenuStrip1 = value;
				menuStrip = this._MenuStrip1;
				if (menuStrip != null)
				{
					menuStrip.Click += eventHandler;
					menuStrip.ItemClicked += toolStripItemClickedEventHandler;
				}
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x000D59BE File Offset: 0x000D3BBE
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x000D59C8 File Offset: 0x000D3BC8
		internal virtual ToolStripMenuItem StockToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000D59D1 File Offset: 0x000D3BD1
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x000D59DC File Offset: 0x000D3BDC
		internal virtual ToolStripMenuItem SalesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesToolStripMenuItem = value;
				toolStripMenuItem = this._SalesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000D5A1F File Offset: 0x000D3C1F
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x000D5A29 File Offset: 0x000D3C29
		internal virtual ToolStripMenuItem ReportsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000D5A32 File Offset: 0x000D3C32
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x000D5A3C File Offset: 0x000D3C3C
		internal virtual ToolStripMenuItem AdminToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x000D5A45 File Offset: 0x000D3C45
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x000D5A4F File Offset: 0x000D3C4F
		internal virtual ToolStripMenuItem UserManagementToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x000D5A58 File Offset: 0x000D3C58
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x000D5A64 File Offset: 0x000D3C64
		internal virtual ToolStripMenuItem CreateUsersToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreateUsersToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreateUsersToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreateUsersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreateUsersToolStripMenuItem = value;
				toolStripMenuItem = this._CreateUsersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x000D5AA7 File Offset: 0x000D3CA7
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x000D5AB4 File Offset: 0x000D3CB4
		internal virtual ToolStripMenuItem ChangeMyPasswordToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ChangeMyPasswordToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChangeMyPasswordToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ChangeMyPasswordToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ChangeMyPasswordToolStripMenuItem = value;
				toolStripMenuItem = this._ChangeMyPasswordToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x000D5AF7 File Offset: 0x000D3CF7
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x000D5B04 File Offset: 0x000D3D04
		internal virtual ToolStripMenuItem DatabaseConnectionToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DatabaseConnectionToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DatabaseConnectionToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._DatabaseConnectionToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._DatabaseConnectionToolStripMenuItem = value;
				toolStripMenuItem = this._DatabaseConnectionToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x000D5B47 File Offset: 0x000D3D47
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x000D5B54 File Offset: 0x000D3D54
		internal virtual ToolStripMenuItem CategoriesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CategoriesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CategoriesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CategoriesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CategoriesToolStripMenuItem = value;
				toolStripMenuItem = this._CategoriesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x000D5B97 File Offset: 0x000D3D97
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x000D5BA4 File Offset: 0x000D3DA4
		internal virtual ToolStripMenuItem GeneralSettingsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._GeneralSettingsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GeneralSettingsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._GeneralSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._GeneralSettingsToolStripMenuItem = value;
				toolStripMenuItem = this._GeneralSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x000D5BE7 File Offset: 0x000D3DE7
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x000D5BF1 File Offset: 0x000D3DF1
		internal virtual ToolStripMenuItem AddNewStockToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x000D5BFA File Offset: 0x000D3DFA
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x000D5C04 File Offset: 0x000D3E04
		internal virtual ToolStripMenuItem PaymentMethodsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PaymentMethodsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PaymentMethodsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PaymentMethodsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PaymentMethodsToolStripMenuItem = value;
				toolStripMenuItem = this._PaymentMethodsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x000D5C47 File Offset: 0x000D3E47
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x000D5C51 File Offset: 0x000D3E51
		internal virtual ToolStripMenuItem ViewProductIDsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000D5C5A File Offset: 0x000D3E5A
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x000D5C64 File Offset: 0x000D3E64
		internal virtual ToolStripMenuItem StockTakeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockTakeToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockTakeToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockTakeToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockTakeToolStripMenuItem = value;
				toolStripMenuItem = this._StockTakeToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x000D5CA7 File Offset: 0x000D3EA7
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x000D5CB1 File Offset: 0x000D3EB1
		internal virtual ToolStripMenuItem ExpensesToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x000D5CBA File Offset: 0x000D3EBA
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x000D5CC4 File Offset: 0x000D3EC4
		internal virtual ToolStripMenuItem EnterAndViewExpensesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnterAndViewExpensesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterAndViewExpensesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterAndViewExpensesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterAndViewExpensesToolStripMenuItem = value;
				toolStripMenuItem = this._EnterAndViewExpensesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x000D5D07 File Offset: 0x000D3F07
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x000D5D14 File Offset: 0x000D3F14
		internal virtual ToolStripMenuItem SalesReportsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesReportsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesReportsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesReportsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesReportsToolStripMenuItem = value;
				toolStripMenuItem = this._SalesReportsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x000D5D57 File Offset: 0x000D3F57
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x000D5D64 File Offset: 0x000D3F64
		internal virtual ToolStripMenuItem SalesForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x000D5DA7 File Offset: 0x000D3FA7
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x000D5DB1 File Offset: 0x000D3FB1
		internal virtual ToolStripMenuItem StockReportsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x000D5DBA File Offset: 0x000D3FBA
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x000D5DC4 File Offset: 0x000D3FC4
		internal virtual ToolStripMenuItem HighestMoversByQuantityToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HighestMoversByQuantityToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.HighestMoversByQuantityToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._HighestMoversByQuantityToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._HighestMoversByQuantityToolStripMenuItem = value;
				toolStripMenuItem = this._HighestMoversByQuantityToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x000D5E07 File Offset: 0x000D4007
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x000D5E14 File Offset: 0x000D4014
		internal virtual ToolStripMenuItem HighestMoversByGrossProfitContributionToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HighestMoversByGrossProfitContributionToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.HighestMoversByGrossProfitContributionToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._HighestMoversByGrossProfitContributionToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._HighestMoversByGrossProfitContributionToolStripMenuItem = value;
				toolStripMenuItem = this._HighestMoversByGrossProfitContributionToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x000D5E57 File Offset: 0x000D4057
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x000D5E64 File Offset: 0x000D4064
		internal virtual ToolStripMenuItem StockBalancesNowToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalancesNowToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalancesNowToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalancesNowToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalancesNowToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalancesNowToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x000D5EA7 File Offset: 0x000D40A7
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x000D5EB4 File Offset: 0x000D40B4
		internal virtual ToolStripMenuItem StockAdjustmentsForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockAdjustmentsForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockAdjustmentsForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockAdjustmentsForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockAdjustmentsForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._StockAdjustmentsForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x000D5EF7 File Offset: 0x000D40F7
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x000D5F04 File Offset: 0x000D4104
		internal virtual ToolStripMenuItem SalesGraphForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesGraphForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesGraphForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesGraphForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesGraphForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._SalesGraphForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x000D5F47 File Offset: 0x000D4147
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x000D5F54 File Offset: 0x000D4154
		internal virtual ToolStripMenuItem BackUpDatabaseToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BackUpDatabaseToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BackUpDatabaseToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._BackUpDatabaseToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._BackUpDatabaseToolStripMenuItem = value;
				toolStripMenuItem = this._BackUpDatabaseToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x000D5F97 File Offset: 0x000D4197
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x000D5FA4 File Offset: 0x000D41A4
		internal virtual ToolStripMenuItem ViewStockLevelsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewStockLevelsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewStockLevelsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewStockLevelsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewStockLevelsToolStripMenuItem = value;
				toolStripMenuItem = this._ViewStockLevelsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x000D5FE7 File Offset: 0x000D41E7
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x000D5FF4 File Offset: 0x000D41F4
		internal virtual ToolStripMenuItem AboutUsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AboutUsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.AboutUsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._AboutUsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._AboutUsToolStripMenuItem = value;
				toolStripMenuItem = this._AboutUsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x000D6037 File Offset: 0x000D4237
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x000D6044 File Offset: 0x000D4244
		internal virtual ToolStripMenuItem CompanyDetailsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CompanyDetailsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CompanyDetailsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CompanyDetailsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CompanyDetailsToolStripMenuItem = value;
				toolStripMenuItem = this._CompanyDetailsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x000D6087 File Offset: 0x000D4287
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x000D6094 File Offset: 0x000D4294
		internal virtual ToolStripMenuItem LicenseKeyToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LicenseKeyToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LicenseKeyToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._LicenseKeyToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._LicenseKeyToolStripMenuItem = value;
				toolStripMenuItem = this._LicenseKeyToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x000D60D7 File Offset: 0x000D42D7
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x000D60E4 File Offset: 0x000D42E4
		internal virtual ToolStripMenuItem EditStockPurhcasesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EditStockPurhcasesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EditStockPurhcasesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EditStockPurhcasesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EditStockPurhcasesToolStripMenuItem = value;
				toolStripMenuItem = this._EditStockPurhcasesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000D6127 File Offset: 0x000D4327
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x000D6134 File Offset: 0x000D4334
		internal virtual ToolStripMenuItem EnterNewProductToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._EnterNewProductToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterNewProductToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterNewProductToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterNewProductToolStripMenuItem1 = value;
				toolStripMenuItem = this._EnterNewProductToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x000D6177 File Offset: 0x000D4377
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x000D6184 File Offset: 0x000D4384
		internal virtual ToolStripMenuItem EditProductDetailsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._EditProductDetailsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EditProductDetailsToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._EditProductDetailsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EditProductDetailsToolStripMenuItem1 = value;
				toolStripMenuItem = this._EditProductDetailsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x000D61C7 File Offset: 0x000D43C7
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x000D61D4 File Offset: 0x000D43D4
		internal virtual ToolStripMenuItem CancelSaleToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CancelSaleToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CancelSaleToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CancelSaleToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CancelSaleToolStripMenuItem = value;
				toolStripMenuItem = this._CancelSaleToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x000D6217 File Offset: 0x000D4417
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x000D6224 File Offset: 0x000D4424
		internal virtual ToolStripMenuItem ViewCancelledSalesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewCancelledSalesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewCancelledSalesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewCancelledSalesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewCancelledSalesToolStripMenuItem = value;
				toolStripMenuItem = this._ViewCancelledSalesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x000D6267 File Offset: 0x000D4467
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x000D6274 File Offset: 0x000D4474
		internal virtual ToolStripMenuItem PrinterSettingsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PrinterSettingsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrinterSettingsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrinterSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrinterSettingsToolStripMenuItem = value;
				toolStripMenuItem = this._PrinterSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x000D62B7 File Offset: 0x000D44B7
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x000D62C1 File Offset: 0x000D44C1
		internal virtual ToolStripMenuItem HowToVideosToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x000D62CA File Offset: 0x000D44CA
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x000D62D4 File Offset: 0x000D44D4
		internal virtual ToolStripMenuItem HowToVideosToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._HowToVideosToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.HowToVideosToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._HowToVideosToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._HowToVideosToolStripMenuItem1 = value;
				toolStripMenuItem = this._HowToVideosToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x000D6317 File Offset: 0x000D4517
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x000D6324 File Offset: 0x000D4524
		internal virtual ToolStripMenuItem EditBarCodesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EditBarCodesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EditBarCodesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EditBarCodesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EditBarCodesToolStripMenuItem = value;
				toolStripMenuItem = this._EditBarCodesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x000D6367 File Offset: 0x000D4567
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x000D6371 File Offset: 0x000D4571
		internal virtual ToolStripMenuItem CustomerReportsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x000D637A File Offset: 0x000D457A
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x000D6384 File Offset: 0x000D4584
		internal virtual ToolStripMenuItem CurrentCustomersListToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CurrentCustomersListToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CurrentCustomersListToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CurrentCustomersListToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CurrentCustomersListToolStripMenuItem = value;
				toolStripMenuItem = this._CurrentCustomersListToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000D63C7 File Offset: 0x000D45C7
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x000D63D4 File Offset: 0x000D45D4
		internal virtual ToolStripMenuItem CustomersListBySalesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CustomersListBySalesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CustomersListBySalesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CustomersListBySalesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CustomersListBySalesToolStripMenuItem = value;
				toolStripMenuItem = this._CustomersListBySalesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x000D6417 File Offset: 0x000D4617
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x000D6421 File Offset: 0x000D4621
		internal virtual ToolStripMenuItem SMSToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x000D642A File Offset: 0x000D462A
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x000D6434 File Offset: 0x000D4634
		internal virtual ToolStripMenuItem SendSMSToCustomersToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SendSMSToCustomersToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SendSMSToCustomersToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SendSMSToCustomersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SendSMSToCustomersToolStripMenuItem = value;
				toolStripMenuItem = this._SendSMSToCustomersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x000D6477 File Offset: 0x000D4677
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x000D6484 File Offset: 0x000D4684
		internal virtual ToolStripMenuItem ViewSMSsSentToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewSMSsSentToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewSMSsSentToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewSMSsSentToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewSMSsSentToolStripMenuItem = value;
				toolStripMenuItem = this._ViewSMSsSentToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000D64C7 File Offset: 0x000D46C7
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x000D64D4 File Offset: 0x000D46D4
		internal virtual ToolStripMenuItem TaxReturnsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._TaxReturnsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TaxReturnsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._TaxReturnsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._TaxReturnsToolStripMenuItem = value;
				toolStripMenuItem = this._TaxReturnsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000D6517 File Offset: 0x000D4717
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x000D6524 File Offset: 0x000D4724
		internal virtual ToolStripMenuItem IndividualProductMovementToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._IndividualProductMovementToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.IndividualProductMovementToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._IndividualProductMovementToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._IndividualProductMovementToolStripMenuItem = value;
				toolStripMenuItem = this._IndividualProductMovementToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x000D6567 File Offset: 0x000D4767
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x000D6574 File Offset: 0x000D4774
		internal virtual ToolStripMenuItem StockBalancesForCompanyToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalancesForCompanyToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalancesForCompanyToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalancesForCompanyToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalancesForCompanyToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalancesForCompanyToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x000D65B7 File Offset: 0x000D47B7
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x000D65C4 File Offset: 0x000D47C4
		internal virtual ToolStripMenuItem WarehouseNewStockPurchaseToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._WarehouseNewStockPurchaseToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.WarehouseNewStockPurchaseToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._WarehouseNewStockPurchaseToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._WarehouseNewStockPurchaseToolStripMenuItem = value;
				toolStripMenuItem = this._WarehouseNewStockPurchaseToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x000D6607 File Offset: 0x000D4807
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x000D6614 File Offset: 0x000D4814
		internal virtual ToolStripMenuItem PrintLabelsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PrintLabelsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintLabelsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintLabelsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintLabelsToolStripMenuItem = value;
				toolStripMenuItem = this._PrintLabelsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x000D6657 File Offset: 0x000D4857
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x000D6664 File Offset: 0x000D4864
		internal virtual ToolStripMenuItem CreateDiscountCouponsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreateDiscountCouponsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreateDiscountCouponsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreateDiscountCouponsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreateDiscountCouponsToolStripMenuItem = value;
				toolStripMenuItem = this._CreateDiscountCouponsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x000D66A7 File Offset: 0x000D48A7
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x000D66B4 File Offset: 0x000D48B4
		internal virtual ToolStripMenuItem SalesByCategoryToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesByCategoryToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesByCategoryToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesByCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesByCategoryToolStripMenuItem = value;
				toolStripMenuItem = this._SalesByCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x000D66F7 File Offset: 0x000D48F7
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x000D6704 File Offset: 0x000D4904
		internal virtual ToolStripMenuItem ViewStockTransfersToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewStockTransfersToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewStockTransfersToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewStockTransfersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewStockTransfersToolStripMenuItem = value;
				toolStripMenuItem = this._ViewStockTransfersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x000D6747 File Offset: 0x000D4947
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x000D6754 File Offset: 0x000D4954
		internal virtual ToolStripMenuItem ChangeUserPasswordToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ChangeUserPasswordToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChangeUserPasswordToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ChangeUserPasswordToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ChangeUserPasswordToolStripMenuItem = value;
				toolStripMenuItem = this._ChangeUserPasswordToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000D6797 File Offset: 0x000D4997
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x000D67A4 File Offset: 0x000D49A4
		internal virtual ToolStripMenuItem ViewStockTransfersToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ViewStockTransfersToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewStockTransfersToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewStockTransfersToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewStockTransfersToolStripMenuItem1 = value;
				toolStripMenuItem = this._ViewStockTransfersToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000D67E7 File Offset: 0x000D49E7
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x000D67F4 File Offset: 0x000D49F4
		internal virtual ToolStripMenuItem SalesForPeriodByShiftsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForPeriodByShiftsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForPeriodByShiftsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForPeriodByShiftsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForPeriodByShiftsToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForPeriodByShiftsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000D6837 File Offset: 0x000D4A37
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x000D6841 File Offset: 0x000D4A41
		internal virtual ToolStripMenuItem ShiftsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x000D684A File Offset: 0x000D4A4A
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x000D6854 File Offset: 0x000D4A54
		internal virtual ToolStripMenuItem ConfigureShiftsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ConfigureShiftsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ConfigureShiftsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ConfigureShiftsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ConfigureShiftsToolStripMenuItem = value;
				toolStripMenuItem = this._ConfigureShiftsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x000D6897 File Offset: 0x000D4A97
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x000D68A4 File Offset: 0x000D4AA4
		internal virtual ToolStripMenuItem ViewOpenActualShiftToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewOpenActualShiftToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewOpenActualShiftToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewOpenActualShiftToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewOpenActualShiftToolStripMenuItem = value;
				toolStripMenuItem = this._ViewOpenActualShiftToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x000D68E7 File Offset: 0x000D4AE7
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x000D68F4 File Offset: 0x000D4AF4
		internal virtual ToolStripMenuItem StockTransferToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockTransferToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockTransferToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockTransferToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockTransferToolStripMenuItem = value;
				toolStripMenuItem = this._StockTransferToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x000D6937 File Offset: 0x000D4B37
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x000D6941 File Offset: 0x000D4B41
		internal virtual ToolStripMenuItem FiscalReportToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x000D694A File Offset: 0x000D4B4A
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x000D6954 File Offset: 0x000D4B54
		internal virtual ToolStripMenuItem PrintZReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PrintZReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintZReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintZReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintZReportToolStripMenuItem = value;
				toolStripMenuItem = this._PrintZReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x000D6997 File Offset: 0x000D4B97
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x000D69A4 File Offset: 0x000D4BA4
		internal virtual ToolStripMenuItem PrintXReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PrintXReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintXReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintXReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintXReportToolStripMenuItem = value;
				toolStripMenuItem = this._PrintXReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000D69E7 File Offset: 0x000D4BE7
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x000D69F4 File Offset: 0x000D4BF4
		internal virtual ToolStripMenuItem ReprintLastReceiptToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ReprintLastReceiptToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ReprintLastReceiptToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ReprintLastReceiptToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ReprintLastReceiptToolStripMenuItem = value;
				toolStripMenuItem = this._ReprintLastReceiptToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x000D6A37 File Offset: 0x000D4C37
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x000D6A44 File Offset: 0x000D4C44
		internal virtual ToolStripMenuItem EnterSalesTOUCHToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnterSalesTOUCHToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterSalesTOUCHToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterSalesTOUCHToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterSalesTOUCHToolStripMenuItem = value;
				toolStripMenuItem = this._EnterSalesTOUCHToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x000D6A87 File Offset: 0x000D4C87
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x000D6A94 File Offset: 0x000D4C94
		internal virtual ToolStripMenuItem StockExpiryReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockExpiryReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockExpiryReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockExpiryReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockExpiryReportToolStripMenuItem = value;
				toolStripMenuItem = this._StockExpiryReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000D6AD7 File Offset: 0x000D4CD7
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x000D6AE1 File Offset: 0x000D4CE1
		internal virtual ToolStripMenuItem ReturnStockToSupplierToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x000D6AEA File Offset: 0x000D4CEA
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x000D6AF4 File Offset: 0x000D4CF4
		internal virtual ToolStripMenuItem ReturnStockToSupplierToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ReturnStockToSupplierToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ReturnStockToSupplierToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._ReturnStockToSupplierToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ReturnStockToSupplierToolStripMenuItem1 = value;
				toolStripMenuItem = this._ReturnStockToSupplierToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x000D6B37 File Offset: 0x000D4D37
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x000D6B44 File Offset: 0x000D4D44
		internal virtual ToolStripMenuItem ViewPurchaseReturnsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewPurchaseReturnsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewPurchaseReturnsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewPurchaseReturnsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewPurchaseReturnsToolStripMenuItem = value;
				toolStripMenuItem = this._ViewPurchaseReturnsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x000D6B87 File Offset: 0x000D4D87
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x000D6B94 File Offset: 0x000D4D94
		internal virtual ToolStripMenuItem ViewProductIDsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ViewProductIDsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewProductIDsToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewProductIDsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewProductIDsToolStripMenuItem1 = value;
				toolStripMenuItem = this._ViewProductIDsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x000D6BD7 File Offset: 0x000D4DD7
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x000D6BE4 File Offset: 0x000D4DE4
		internal virtual ToolStripMenuItem ChangeProductCategoryToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ChangeProductCategoryToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChangeProductCategoryToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ChangeProductCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ChangeProductCategoryToolStripMenuItem = value;
				toolStripMenuItem = this._ChangeProductCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x000D6C27 File Offset: 0x000D4E27
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x000D6C34 File Offset: 0x000D4E34
		internal virtual ToolStripMenuItem StockBalancesForCategoryToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalancesForCategoryToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalancesForCategoryToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalancesForCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalancesForCategoryToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalancesForCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000D6C77 File Offset: 0x000D4E77
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x000D6C84 File Offset: 0x000D4E84
		internal virtual ToolStripMenuItem EcocashReceiptsReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EcocashReceiptsReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EcocashReceiptsReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EcocashReceiptsReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EcocashReceiptsReportToolStripMenuItem = value;
				toolStripMenuItem = this._EcocashReceiptsReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x000D6CC7 File Offset: 0x000D4EC7
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x000D6CD4 File Offset: 0x000D4ED4
		internal virtual ToolStripMenuItem TillPointPriceChangesReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._TillPointPriceChangesReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TillPointPriceChangesReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._TillPointPriceChangesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._TillPointPriceChangesReportToolStripMenuItem = value;
				toolStripMenuItem = this._TillPointPriceChangesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x000D6D17 File Offset: 0x000D4F17
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x000D6D24 File Offset: 0x000D4F24
		internal virtual ToolStripMenuItem EndOfDayPrintOutSlipToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EndOfDayPrintOutSlipToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EndOfDayPrintOutSlipToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EndOfDayPrintOutSlipToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EndOfDayPrintOutSlipToolStripMenuItem = value;
				toolStripMenuItem = this._EndOfDayPrintOutSlipToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x000D6D67 File Offset: 0x000D4F67
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x000D6D74 File Offset: 0x000D4F74
		internal virtual ToolStripMenuItem StockBalToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x000D6DB7 File Offset: 0x000D4FB7
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x000D6DC4 File Offset: 0x000D4FC4
		internal virtual ToolStripMenuItem StockBalanceByBinLocationToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalanceByBinLocationToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalanceByBinLocationToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalanceByBinLocationToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalanceByBinLocationToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalanceByBinLocationToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000D6E07 File Offset: 0x000D5007
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x000D6E14 File Offset: 0x000D5014
		internal virtual ToolStripMenuItem DailySalesByShiftsForDayToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DailySalesByShiftsForDayToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DailySalesByShiftsForDayToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._DailySalesByShiftsForDayToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._DailySalesByShiftsForDayToolStripMenuItem = value;
				toolStripMenuItem = this._DailySalesByShiftsForDayToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000D6E57 File Offset: 0x000D5057
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x000D6E64 File Offset: 0x000D5064
		internal virtual ToolStripMenuItem SalesForPeriodTotalToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForPeriodTotalToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForPeriodTotalToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForPeriodTotalToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForPeriodTotalToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForPeriodTotalToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000D6EA7 File Offset: 0x000D50A7
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x000D6EB1 File Offset: 0x000D50B1
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x000D6EBA File Offset: 0x000D50BA
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x000D6EC4 File Offset: 0x000D50C4
		internal virtual ToolStripMenuItem CustomerPurchasesForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CustomerPurchasesForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CustomerPurchasesForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CustomerPurchasesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CustomerPurchasesForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._CustomerPurchasesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x000D6F07 File Offset: 0x000D5107
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x000D6F14 File Offset: 0x000D5114
		internal virtual ToolStripMenuItem SalesEnquiryToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesEnquiryToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesEnquiryToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesEnquiryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesEnquiryToolStripMenuItem = value;
				toolStripMenuItem = this._SalesEnquiryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x000D6F57 File Offset: 0x000D5157
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x000D6F64 File Offset: 0x000D5164
		internal virtual ToolStripMenuItem SalesEnquiriesReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesEnquiriesReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesEnquiriesReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesEnquiriesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesEnquiriesReportToolStripMenuItem = value;
				toolStripMenuItem = this._SalesEnquiriesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x000D6FA7 File Offset: 0x000D51A7
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x000D6FB4 File Offset: 0x000D51B4
		internal virtual ToolStripMenuItem TotalSalesForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._TotalSalesForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TotalSalesForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._TotalSalesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._TotalSalesForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._TotalSalesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000D6FF7 File Offset: 0x000D51F7
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x000D7004 File Offset: 0x000D5204
		internal virtual ToolStripMenuItem SalesMonoPaymentToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesMonoPaymentToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesMonoPaymentToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesMonoPaymentToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesMonoPaymentToolStripMenuItem = value;
				toolStripMenuItem = this._SalesMonoPaymentToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000D7047 File Offset: 0x000D5247
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x000D7054 File Offset: 0x000D5254
		internal virtual ToolStripMenuItem ViewStockPurchasesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewStockPurchasesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewStockPurchasesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewStockPurchasesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewStockPurchasesToolStripMenuItem = value;
				toolStripMenuItem = this._ViewStockPurchasesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000D7097 File Offset: 0x000D5297
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x000D70A4 File Offset: 0x000D52A4
		internal virtual ToolStripMenuItem SalesVsPurchasesForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesVsPurchasesForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesVsPurchasesForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesVsPurchasesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesVsPurchasesForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._SalesVsPurchasesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x000D70E7 File Offset: 0x000D52E7
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x000D70F4 File Offset: 0x000D52F4
		internal virtual ToolStripMenuItem AccountPaymentsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AccountPaymentsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.AccountPaymentsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._AccountPaymentsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._AccountPaymentsToolStripMenuItem = value;
				toolStripMenuItem = this._AccountPaymentsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x000D7137 File Offset: 0x000D5337
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x000D7144 File Offset: 0x000D5344
		internal virtual ToolStripMenuItem StockBalancesWithBatchNumbersExpiryDatesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalancesWithBatchNumbersExpiryDatesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalancesWithBatchNumbersExpiryDatesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalancesWithBatchNumbersExpiryDatesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalancesWithBatchNumbersExpiryDatesToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalancesWithBatchNumbersExpiryDatesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000D7187 File Offset: 0x000D5387
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x000D7191 File Offset: 0x000D5391
		internal virtual ToolStripMenuItem AuditReportsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x000D719A File Offset: 0x000D539A
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x000D71A4 File Offset: 0x000D53A4
		internal virtual ToolStripMenuItem PriceChangeAuditToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PriceChangeAuditToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PriceChangeAuditToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PriceChangeAuditToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PriceChangeAuditToolStripMenuItem = value;
				toolStripMenuItem = this._PriceChangeAuditToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x000D71E7 File Offset: 0x000D53E7
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x000D71F4 File Offset: 0x000D53F4
		internal virtual ToolStripMenuItem RoleManagementToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RoleManagementToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RoleManagementToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._RoleManagementToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._RoleManagementToolStripMenuItem = value;
				toolStripMenuItem = this._RoleManagementToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x000D7237 File Offset: 0x000D5437
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x000D7244 File Offset: 0x000D5444
		internal virtual ToolStripMenuItem UserPermissionsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UserPermissionsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UserPermissionsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._UserPermissionsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._UserPermissionsToolStripMenuItem = value;
				toolStripMenuItem = this._UserPermissionsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000D7287 File Offset: 0x000D5487
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x000D7294 File Offset: 0x000D5494
		internal virtual ToolStripMenuItem ProductImagesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ProductImagesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ProductImagesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ProductImagesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ProductImagesToolStripMenuItem = value;
				toolStripMenuItem = this._ProductImagesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x000D72D7 File Offset: 0x000D54D7
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x000D72E4 File Offset: 0x000D54E4
		internal virtual ToolStripMenuItem ViewStockTransfersForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewStockTransfersForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewStockTransfersForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewStockTransfersForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewStockTransfersForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._ViewStockTransfersForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000D7327 File Offset: 0x000D5527
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x000D7334 File Offset: 0x000D5534
		internal virtual ToolStripMenuItem CreateNewSupplierToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreateNewSupplierToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreateNewSupplierToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreateNewSupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreateNewSupplierToolStripMenuItem = value;
				toolStripMenuItem = this._CreateNewSupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x000D7377 File Offset: 0x000D5577
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x000D7384 File Offset: 0x000D5584
		internal virtual ToolStripMenuItem GoodsReceivedVoucherToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._GoodsReceivedVoucherToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GoodsReceivedVoucherToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._GoodsReceivedVoucherToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._GoodsReceivedVoucherToolStripMenuItem = value;
				toolStripMenuItem = this._GoodsReceivedVoucherToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x000D73C7 File Offset: 0x000D55C7
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x000D73D4 File Offset: 0x000D55D4
		internal virtual ToolStripMenuItem PrintPurchaseReturnsForSupplierToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PrintPurchaseReturnsForSupplierToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintPurchaseReturnsForSupplierToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintPurchaseReturnsForSupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintPurchaseReturnsForSupplierToolStripMenuItem = value;
				toolStripMenuItem = this._PrintPurchaseReturnsForSupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x000D7417 File Offset: 0x000D5617
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x000D7424 File Offset: 0x000D5624
		internal virtual ToolStripMenuItem ConsignmentStockReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ConsignmentStockReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ConsignmentStockReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ConsignmentStockReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ConsignmentStockReportToolStripMenuItem = value;
				toolStripMenuItem = this._ConsignmentStockReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x000D7467 File Offset: 0x000D5667
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x000D7474 File Offset: 0x000D5674
		internal virtual ToolStripMenuItem PrintQuotationsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PrintQuotationsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintQuotationsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintQuotationsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintQuotationsToolStripMenuItem = value;
				toolStripMenuItem = this._PrintQuotationsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000D74B7 File Offset: 0x000D56B7
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x000D74C4 File Offset: 0x000D56C4
		internal virtual ToolStripMenuItem BatchNumberAndExpiryDateChangesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BatchNumberAndExpiryDateChangesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BatchNumberAndExpiryDateChangesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._BatchNumberAndExpiryDateChangesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._BatchNumberAndExpiryDateChangesToolStripMenuItem = value;
				toolStripMenuItem = this._BatchNumberAndExpiryDateChangesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000D7507 File Offset: 0x000D5707
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x000D7514 File Offset: 0x000D5714
		internal virtual ToolStripMenuItem PriceListToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PriceListToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PriceListToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PriceListToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PriceListToolStripMenuItem = value;
				toolStripMenuItem = this._PriceListToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x000D7557 File Offset: 0x000D5757
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x000D7561 File Offset: 0x000D5761
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000D756A File Offset: 0x000D576A
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x000D7574 File Offset: 0x000D5774
		internal virtual ToolStripMenuItem CreateConversionFormulaToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreateConversionFormulaToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreateConversionFormulaToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreateConversionFormulaToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreateConversionFormulaToolStripMenuItem = value;
				toolStripMenuItem = this._CreateConversionFormulaToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x000D75B7 File Offset: 0x000D57B7
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x000D75C4 File Offset: 0x000D57C4
		internal virtual ToolStripMenuItem MakeProductToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._MakeProductToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.MakeProductToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._MakeProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._MakeProductToolStripMenuItem = value;
				toolStripMenuItem = this._MakeProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x000D7607 File Offset: 0x000D5807
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x000D7611 File Offset: 0x000D5811
		internal virtual ToolStripMenuItem PromotionsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x000D761A File Offset: 0x000D581A
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x000D7624 File Offset: 0x000D5824
		internal virtual ToolStripMenuItem CreatePromotionToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreatePromotionToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreatePromotionToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreatePromotionToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreatePromotionToolStripMenuItem = value;
				toolStripMenuItem = this._CreatePromotionToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000D7667 File Offset: 0x000D5867
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x000D7674 File Offset: 0x000D5874
		internal virtual ToolStripMenuItem ViewPromotionsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewPromotionsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewPromotionsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewPromotionsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewPromotionsToolStripMenuItem = value;
				toolStripMenuItem = this._ViewPromotionsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000D76B7 File Offset: 0x000D58B7
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x000D76C1 File Offset: 0x000D58C1
		internal virtual ToolStripMenuItem SingleStockTakeToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x000D76CA File Offset: 0x000D58CA
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x000D76D4 File Offset: 0x000D58D4
		internal virtual ToolStripMenuItem PrintStockSheetsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._PrintStockSheetsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintStockSheetsToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintStockSheetsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintStockSheetsToolStripMenuItem1 = value;
				toolStripMenuItem = this._PrintStockSheetsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x000D7717 File Offset: 0x000D5917
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x000D7724 File Offset: 0x000D5924
		internal virtual ToolStripMenuItem EnterStockTakeFiguresToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._EnterStockTakeFiguresToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterStockTakeFiguresToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterStockTakeFiguresToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterStockTakeFiguresToolStripMenuItem1 = value;
				toolStripMenuItem = this._EnterStockTakeFiguresToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x000D7767 File Offset: 0x000D5967
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x000D7771 File Offset: 0x000D5971
		internal virtual ToolStripMenuItem CummulativeStockTakeToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x000D777A File Offset: 0x000D597A
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x000D7784 File Offset: 0x000D5984
		internal virtual ToolStripMenuItem PrintStockSheetsToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._PrintStockSheetsToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintStockSheetsToolStripMenuItem2_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintStockSheetsToolStripMenuItem2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintStockSheetsToolStripMenuItem2 = value;
				toolStripMenuItem = this._PrintStockSheetsToolStripMenuItem2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x000D77C7 File Offset: 0x000D59C7
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x000D77D4 File Offset: 0x000D59D4
		internal virtual ToolStripMenuItem EnterCummulativeStockTakeFiguresToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnterCummulativeStockTakeFiguresToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterCummulativeStockTakeFiguresToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterCummulativeStockTakeFiguresToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterCummulativeStockTakeFiguresToolStripMenuItem = value;
				toolStripMenuItem = this._EnterCummulativeStockTakeFiguresToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x000D7817 File Offset: 0x000D5A17
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x000D7824 File Offset: 0x000D5A24
		internal virtual ToolStripMenuItem EditBatchNumbersAndExpiryDate2ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EditBatchNumbersAndExpiryDate2ToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EditBatchNumbersAndExpiryDate2ToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EditBatchNumbersAndExpiryDate2ToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EditBatchNumbersAndExpiryDate2ToolStripMenuItem = value;
				toolStripMenuItem = this._EditBatchNumbersAndExpiryDate2ToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000D7867 File Offset: 0x000D5A67
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x000D7874 File Offset: 0x000D5A74
		internal virtual ToolStripMenuItem BREAKProductToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BREAKProductToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BREAKProductToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._BREAKProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._BREAKProductToolStripMenuItem = value;
				toolStripMenuItem = this._BREAKProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x000D78B7 File Offset: 0x000D5AB7
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x000D78C4 File Offset: 0x000D5AC4
		internal virtual ToolStripMenuItem CreditNotePerProductToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreditNotePerProductToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreditNotePerProductToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreditNotePerProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreditNotePerProductToolStripMenuItem = value;
				toolStripMenuItem = this._CreditNotePerProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x000D7907 File Offset: 0x000D5B07
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x000D7914 File Offset: 0x000D5B14
		internal virtual ToolStripMenuItem GenerateCreditNoteForProductToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._GenerateCreditNoteForProductToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GenerateCreditNoteForProductToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._GenerateCreditNoteForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._GenerateCreditNoteForProductToolStripMenuItem = value;
				toolStripMenuItem = this._GenerateCreditNoteForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x000D7957 File Offset: 0x000D5B57
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x000D7964 File Offset: 0x000D5B64
		internal virtual ToolStripMenuItem ViewCancelCreditNotesForProductToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewCancelCreditNotesForProductToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewCancelCreditNotesForProductToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewCancelCreditNotesForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewCancelCreditNotesForProductToolStripMenuItem = value;
				toolStripMenuItem = this._ViewCancelCreditNotesForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x000D79A7 File Offset: 0x000D5BA7
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x000D79B4 File Offset: 0x000D5BB4
		internal virtual ToolStripMenuItem SalesByConsultantReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesByConsultantReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesByConsultantReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesByConsultantReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesByConsultantReportToolStripMenuItem = value;
				toolStripMenuItem = this._SalesByConsultantReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x000D79F7 File Offset: 0x000D5BF7
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x000D7A04 File Offset: 0x000D5C04
		internal virtual ToolStripMenuItem LogOutToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LogOutToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LogOutToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._LogOutToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._LogOutToolStripMenuItem = value;
				toolStripMenuItem = this._LogOutToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x000D7A47 File Offset: 0x000D5C47
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x000D7A54 File Offset: 0x000D5C54
		internal virtual ToolStripMenuItem ChangePricesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ChangePricesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChangePricesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ChangePricesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ChangePricesToolStripMenuItem = value;
				toolStripMenuItem = this._ChangePricesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x000D7A97 File Offset: 0x000D5C97
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x000D7AA4 File Offset: 0x000D5CA4
		internal virtual ToolStripMenuItem StockBalancesForBranchByCategoryToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalancesForBranchByCategoryToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalancesForBranchByCategoryToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalancesForBranchByCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalancesForBranchByCategoryToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalancesForBranchByCategoryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x000D7AE7 File Offset: 0x000D5CE7
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x000D7AF4 File Offset: 0x000D5CF4
		internal virtual ToolStripMenuItem PurchasesBySupplierToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PurchasesBySupplierToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PurchasesBySupplierToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PurchasesBySupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PurchasesBySupplierToolStripMenuItem = value;
				toolStripMenuItem = this._PurchasesBySupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x000D7B37 File Offset: 0x000D5D37
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x000D7B44 File Offset: 0x000D5D44
		internal virtual ToolStripMenuItem LoginsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LoginsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LoginsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._LoginsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._LoginsToolStripMenuItem = value;
				toolStripMenuItem = this._LoginsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x000D7B87 File Offset: 0x000D5D87
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x000D7B94 File Offset: 0x000D5D94
		internal virtual ToolStripMenuItem PaymentMethodBasedDiscountsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PaymentMethodBasedDiscountsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PaymentMethodBasedDiscountsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PaymentMethodBasedDiscountsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PaymentMethodBasedDiscountsToolStripMenuItem = value;
				toolStripMenuItem = this._PaymentMethodBasedDiscountsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x000D7BD7 File Offset: 0x000D5DD7
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x000D7BE1 File Offset: 0x000D5DE1
		internal virtual ToolStripMenuItem DiscountsReportsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x000D7BEA File Offset: 0x000D5DEA
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x000D7BF4 File Offset: 0x000D5DF4
		internal virtual ToolStripMenuItem DiscountsGivenForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DiscountsGivenForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DiscountsGivenForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._DiscountsGivenForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._DiscountsGivenForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._DiscountsGivenForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x000D7C37 File Offset: 0x000D5E37
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x000D7C44 File Offset: 0x000D5E44
		internal virtual ToolStripMenuItem FIFOStockAgingReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FIFOStockAgingReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.FIFOStockAgingReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._FIFOStockAgingReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._FIFOStockAgingReportToolStripMenuItem = value;
				toolStripMenuItem = this._FIFOStockAgingReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x000D7C87 File Offset: 0x000D5E87
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x000D7C91 File Offset: 0x000D5E91
		internal virtual ToolStripMenuItem CollectionDeliveryToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x000D7C9A File Offset: 0x000D5E9A
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x000D7CA4 File Offset: 0x000D5EA4
		internal virtual ToolStripMenuItem ViewUpdateCollectionsDeliveriesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewUpdateCollectionsDeliveriesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewUpdateCollectionsDeliveriesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewUpdateCollectionsDeliveriesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewUpdateCollectionsDeliveriesToolStripMenuItem = value;
				toolStripMenuItem = this._ViewUpdateCollectionsDeliveriesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x000D7CE7 File Offset: 0x000D5EE7
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x000D7CF4 File Offset: 0x000D5EF4
		internal virtual ToolStripMenuItem EnterOrCollectFloatToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnterOrCollectFloatToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterOrCollectFloatToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterOrCollectFloatToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterOrCollectFloatToolStripMenuItem = value;
				toolStripMenuItem = this._EnterOrCollectFloatToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x000D7D37 File Offset: 0x000D5F37
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x000D7D44 File Offset: 0x000D5F44
		internal virtual ToolStripMenuItem EnterEndOfDayCashInBoxToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnterEndOfDayCashInBoxToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterEndOfDayCashInBoxToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterEndOfDayCashInBoxToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterEndOfDayCashInBoxToolStripMenuItem = value;
				toolStripMenuItem = this._EnterEndOfDayCashInBoxToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x000D7D87 File Offset: 0x000D5F87
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x000D7D94 File Offset: 0x000D5F94
		internal virtual ToolStripMenuItem WaiterTipsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._WaiterTipsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.WaiterTipsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._WaiterTipsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._WaiterTipsToolStripMenuItem = value;
				toolStripMenuItem = this._WaiterTipsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x000D7DD7 File Offset: 0x000D5FD7
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x000D7DE4 File Offset: 0x000D5FE4
		internal virtual ToolStripMenuItem SetInvoiceDiscountToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SetInvoiceDiscountToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SetInvoiceDiscountToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SetInvoiceDiscountToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SetInvoiceDiscountToolStripMenuItem = value;
				toolStripMenuItem = this._SetInvoiceDiscountToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x000D7E27 File Offset: 0x000D6027
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x000D7E34 File Offset: 0x000D6034
		internal virtual ToolStripMenuItem ProductDiscountsForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ProductDiscountsForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ProductDiscountsForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ProductDiscountsForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ProductDiscountsForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._ProductDiscountsForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x000D7E77 File Offset: 0x000D6077
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x000D7E84 File Offset: 0x000D6084
		internal virtual ToolStripMenuItem ProductsConvertedToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ProductsConvertedToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ProductsConvertedToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ProductsConvertedToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ProductsConvertedToolStripMenuItem = value;
				toolStripMenuItem = this._ProductsConvertedToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x000D7EC7 File Offset: 0x000D60C7
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x000D7ED4 File Offset: 0x000D60D4
		internal virtual ToolStripMenuItem PrintProductFormulaReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PrintProductFormulaReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintProductFormulaReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintProductFormulaReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintProductFormulaReportToolStripMenuItem = value;
				toolStripMenuItem = this._PrintProductFormulaReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x000D7F17 File Offset: 0x000D6117
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x000D7F24 File Offset: 0x000D6124
		internal virtual ToolStripMenuItem AccountToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AccountToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.AccountToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._AccountToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._AccountToolStripMenuItem = value;
				toolStripMenuItem = this._AccountToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x000D7F67 File Offset: 0x000D6167
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x000D7F74 File Offset: 0x000D6174
		internal virtual ToolStripMenuItem ViewStockPurchasesForProductToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewStockPurchasesForProductToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewStockPurchasesForProductToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewStockPurchasesForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewStockPurchasesForProductToolStripMenuItem = value;
				toolStripMenuItem = this._ViewStockPurchasesForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x000D7FB7 File Offset: 0x000D61B7
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x000D7FC1 File Offset: 0x000D61C1
		internal virtual ToolStripMenuItem AirtimeVouchersToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x000D7FCA File Offset: 0x000D61CA
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x000D7FD4 File Offset: 0x000D61D4
		internal virtual ToolStripMenuItem LoadEconetVouchersToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LoadEconetVouchersToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LoadEconetVouchersToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._LoadEconetVouchersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._LoadEconetVouchersToolStripMenuItem = value;
				toolStripMenuItem = this._LoadEconetVouchersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x000D8017 File Offset: 0x000D6217
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x000D8024 File Offset: 0x000D6224
		internal virtual ToolStripMenuItem CustomersToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CustomersToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CustomersToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CustomersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CustomersToolStripMenuItem = value;
				toolStripMenuItem = this._CustomersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x000D8067 File Offset: 0x000D6267
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x000D8074 File Offset: 0x000D6274
		internal virtual ToolStripMenuItem LinkProductToSideMenuToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LinkProductToSideMenuToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LinkProductToSideMenuToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._LinkProductToSideMenuToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._LinkProductToSideMenuToolStripMenuItem = value;
				toolStripMenuItem = this._LinkProductToSideMenuToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x000D80B7 File Offset: 0x000D62B7
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x000D80C4 File Offset: 0x000D62C4
		internal virtual ToolStripMenuItem EnterStockTakeFiguresExcelToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnterStockTakeFiguresExcelToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterStockTakeFiguresExcelToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterStockTakeFiguresExcelToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterStockTakeFiguresExcelToolStripMenuItem = value;
				toolStripMenuItem = this._EnterStockTakeFiguresExcelToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x000D8107 File Offset: 0x000D6307
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x000D8114 File Offset: 0x000D6314
		internal virtual ToolStripMenuItem ViewUpdateCollectionsDeliveriesForCustomerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewUpdateCollectionsDeliveriesForCustomerToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewUpdateCollectionsDeliveriesForCustomerToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewUpdateCollectionsDeliveriesForCustomerToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewUpdateCollectionsDeliveriesForCustomerToolStripMenuItem = value;
				toolStripMenuItem = this._ViewUpdateCollectionsDeliveriesForCustomerToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x000D8157 File Offset: 0x000D6357
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x000D8164 File Offset: 0x000D6364
		internal virtual ToolStripMenuItem CollectionDeliveryByCustomerReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CollectionDeliveryByCustomerReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CollectionDeliveryByCustomerReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CollectionDeliveryByCustomerReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CollectionDeliveryByCustomerReportToolStripMenuItem = value;
				toolStripMenuItem = this._CollectionDeliveryByCustomerReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x000D81A7 File Offset: 0x000D63A7
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x000D81B4 File Offset: 0x000D63B4
		internal virtual ToolStripMenuItem CollectionDeliveryProductBalancesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CollectionDeliveryProductBalancesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CollectionDeliveryProductBalancesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CollectionDeliveryProductBalancesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CollectionDeliveryProductBalancesToolStripMenuItem = value;
				toolStripMenuItem = this._CollectionDeliveryProductBalancesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x000D81F7 File Offset: 0x000D63F7
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x000D8204 File Offset: 0x000D6404
		internal virtual ToolStripMenuItem RestrictProductCategoriesForUserToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RestrictProductCategoriesForUserToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RestrictProductCategoriesForUserToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._RestrictProductCategoriesForUserToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._RestrictProductCategoriesForUserToolStripMenuItem = value;
				toolStripMenuItem = this._RestrictProductCategoriesForUserToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x000D8247 File Offset: 0x000D6447
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x000D8251 File Offset: 0x000D6451
		internal virtual ToolStripMenuItem ApprovalsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x000D825A File Offset: 0x000D645A
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x000D8264 File Offset: 0x000D6464
		internal virtual ToolStripMenuItem ApproveDenyProductChangeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ApproveDenyProductChangeToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ApproveDenyProductChangeToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ApproveDenyProductChangeToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ApproveDenyProductChangeToolStripMenuItem = value;
				toolStripMenuItem = this._ApproveDenyProductChangeToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x000D82A7 File Offset: 0x000D64A7
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x000D82B4 File Offset: 0x000D64B4
		internal virtual ToolStripMenuItem BookingsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BookingsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BookingsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._BookingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._BookingsToolStripMenuItem = value;
				toolStripMenuItem = this._BookingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x000D82F7 File Offset: 0x000D64F7
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x000D8304 File Offset: 0x000D6504
		internal virtual ToolStripMenuItem CheckInvoiceToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CheckInvoiceToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckInvoiceToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CheckInvoiceToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CheckInvoiceToolStripMenuItem = value;
				toolStripMenuItem = this._CheckInvoiceToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x000D8347 File Offset: 0x000D6547
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x000D8354 File Offset: 0x000D6554
		internal virtual ToolStripMenuItem HighestMoversBySalesContributionReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HighestMoversBySalesContributionReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.HighestMoversBySalesContributionReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._HighestMoversBySalesContributionReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._HighestMoversBySalesContributionReportToolStripMenuItem = value;
				toolStripMenuItem = this._HighestMoversBySalesContributionReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x000D8397 File Offset: 0x000D6597
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x000D83A4 File Offset: 0x000D65A4
		internal virtual ToolStripMenuItem ChangeProductSupplierToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ChangeProductSupplierToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ChangeProductSupplierToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ChangeProductSupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ChangeProductSupplierToolStripMenuItem = value;
				toolStripMenuItem = this._ChangeProductSupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x000D83E7 File Offset: 0x000D65E7
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x000D83F4 File Offset: 0x000D65F4
		internal virtual ToolStripMenuItem StockBalancesBySupplierToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockBalancesBySupplierToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockBalancesBySupplierToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockBalancesBySupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockBalancesBySupplierToolStripMenuItem = value;
				toolStripMenuItem = this._StockBalancesBySupplierToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x000D8437 File Offset: 0x000D6637
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x000D8444 File Offset: 0x000D6644
		internal virtual ToolStripMenuItem HighestMoversBySalesForSupplierForBranchToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HighestMoversBySalesForSupplierForBranchToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.HighestMoversBySalesForSupplierForBranchToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._HighestMoversBySalesForSupplierForBranchToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._HighestMoversBySalesForSupplierForBranchToolStripMenuItem = value;
				toolStripMenuItem = this._HighestMoversBySalesForSupplierForBranchToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x000D8487 File Offset: 0x000D6687
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x000D8494 File Offset: 0x000D6694
		internal virtual ToolStripMenuItem EditProductCaseParentChildSettingsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EditProductCaseParentChildSettingsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EditProductCaseParentChildSettingsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EditProductCaseParentChildSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EditProductCaseParentChildSettingsToolStripMenuItem = value;
				toolStripMenuItem = this._EditProductCaseParentChildSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x000D84D7 File Offset: 0x000D66D7
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x000D84E4 File Offset: 0x000D66E4
		internal virtual ToolStripMenuItem VEHICLETRIPSBILLINGToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._VEHICLETRIPSBILLINGToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.VEHICLETRIPSBILLINGToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._VEHICLETRIPSBILLINGToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._VEHICLETRIPSBILLINGToolStripMenuItem = value;
				toolStripMenuItem = this._VEHICLETRIPSBILLINGToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x000D8527 File Offset: 0x000D6727
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x000D8534 File Offset: 0x000D6734
		internal virtual ToolStripMenuItem PerformanceReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PerformanceReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PerformanceReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._PerformanceReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PerformanceReportToolStripMenuItem = value;
				toolStripMenuItem = this._PerformanceReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x000D8577 File Offset: 0x000D6777
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x000D8584 File Offset: 0x000D6784
		internal virtual ToolStripMenuItem PrintQuotationsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._PrintQuotationsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintQuotationsToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._PrintQuotationsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._PrintQuotationsToolStripMenuItem1 = value;
				toolStripMenuItem = this._PrintQuotationsToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x000D85C7 File Offset: 0x000D67C7
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x000D85D4 File Offset: 0x000D67D4
		internal virtual ToolStripMenuItem ViewQuotationsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewQuotationsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewQuotationsToolStripMenuItem_Click_1);
				ToolStripMenuItem toolStripMenuItem = this._ViewQuotationsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewQuotationsToolStripMenuItem = value;
				toolStripMenuItem = this._ViewQuotationsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x000D8617 File Offset: 0x000D6817
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x000D8621 File Offset: 0x000D6821
		internal virtual ToolStripMenuItem BreakMakeCaseToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x000D862A File Offset: 0x000D682A
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x000D8634 File Offset: 0x000D6834
		internal virtual ToolStripMenuItem QuotationsConvertedToInvoicesReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._QuotationsConvertedToInvoicesReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.QuotationsConvertedToInvoicesReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._QuotationsConvertedToInvoicesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._QuotationsConvertedToInvoicesReportToolStripMenuItem = value;
				toolStripMenuItem = this._QuotationsConvertedToInvoicesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x000D8677 File Offset: 0x000D6877
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x000D8684 File Offset: 0x000D6884
		internal virtual ToolStripMenuItem SalesByCategoryByUserToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesByCategoryByUserToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesByCategoryByUserToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesByCategoryByUserToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesByCategoryByUserToolStripMenuItem = value;
				toolStripMenuItem = this._SalesByCategoryByUserToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x000D86C7 File Offset: 0x000D68C7
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x000D86D4 File Offset: 0x000D68D4
		internal virtual ToolStripMenuItem SalesForProductToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForProductToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForProductToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForProductToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForProductToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x000D8717 File Offset: 0x000D6917
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x000D8724 File Offset: 0x000D6924
		internal virtual ToolStripMenuItem EmailSettingsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EmailSettingsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EmailSettingsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EmailSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EmailSettingsToolStripMenuItem = value;
				toolStripMenuItem = this._EmailSettingsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x000D8767 File Offset: 0x000D6967
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x000D8774 File Offset: 0x000D6974
		internal virtual ToolStripMenuItem ADFSalesReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ADFSalesReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ADFSalesReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ADFSalesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ADFSalesReportToolStripMenuItem = value;
				toolStripMenuItem = this._ADFSalesReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x000D87B7 File Offset: 0x000D69B7
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x000D87C4 File Offset: 0x000D69C4
		internal virtual ToolStripMenuItem ADFSToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ADFSToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ADFSToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ADFSToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ADFSToolStripMenuItem = value;
				toolStripMenuItem = this._ADFSToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x000D8807 File Offset: 0x000D6A07
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x000D8811 File Offset: 0x000D6A11
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x000D881A File Offset: 0x000D6A1A
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x000D8824 File Offset: 0x000D6A24
		internal virtual ToolStripMenuItem DebtorsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DebtorsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DebtorsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._DebtorsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._DebtorsToolStripMenuItem = value;
				toolStripMenuItem = this._DebtorsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x000D8867 File Offset: 0x000D6A67
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x000D8874 File Offset: 0x000D6A74
		internal virtual ToolStripMenuItem CreditorsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreditorsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreditorsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreditorsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreditorsToolStripMenuItem = value;
				toolStripMenuItem = this._CreditorsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x000D88B7 File Offset: 0x000D6AB7
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x000D88C4 File Offset: 0x000D6AC4
		internal virtual ToolStripMenuItem SalesForPeriodInvoiceNumbersToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForPeriodInvoiceNumbersToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForPeriodInvoiceNumbersToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForPeriodInvoiceNumbersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForPeriodInvoiceNumbersToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForPeriodInvoiceNumbersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x000D8907 File Offset: 0x000D6B07
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x000D8914 File Offset: 0x000D6B14
		internal virtual ToolStripMenuItem SALESFORCOMPANYToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SALESFORCOMPANYToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SALESFORCOMPANYToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SALESFORCOMPANYToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SALESFORCOMPANYToolStripMenuItem = value;
				toolStripMenuItem = this._SALESFORCOMPANYToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x000D8957 File Offset: 0x000D6B57
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x000D8964 File Offset: 0x000D6B64
		internal virtual ToolStripMenuItem ImportSalesCSVToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ImportSalesCSVToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ImportSalesCSVToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ImportSalesCSVToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ImportSalesCSVToolStripMenuItem = value;
				toolStripMenuItem = this._ImportSalesCSVToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x000D89A7 File Offset: 0x000D6BA7
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x000D89B4 File Offset: 0x000D6BB4
		internal virtual ToolStripMenuItem OneProductStockTakeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._OneProductStockTakeToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.OneProductStockTakeToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._OneProductStockTakeToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._OneProductStockTakeToolStripMenuItem = value;
				toolStripMenuItem = this._OneProductStockTakeToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x000D89F7 File Offset: 0x000D6BF7
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x000D8A04 File Offset: 0x000D6C04
		internal virtual ToolStripMenuItem BulkStockEntryToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BulkStockEntryToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BulkStockEntryToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._BulkStockEntryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._BulkStockEntryToolStripMenuItem = value;
				toolStripMenuItem = this._BulkStockEntryToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x000D8A47 File Offset: 0x000D6C47
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x000D8A54 File Offset: 0x000D6C54
		internal virtual ToolStripMenuItem SalesForPeriodByPaymentMethodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForPeriodByPaymentMethodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForPeriodByPaymentMethodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForPeriodByPaymentMethodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForPeriodByPaymentMethodToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForPeriodByPaymentMethodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x000D8A97 File Offset: 0x000D6C97
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x000D8AA4 File Offset: 0x000D6CA4
		internal virtual ToolStripMenuItem StockTransfersInForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StockTransfersInForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.StockTransfersInForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._StockTransfersInForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._StockTransfersInForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._StockTransfersInForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x000D8AE7 File Offset: 0x000D6CE7
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x000D8AF4 File Offset: 0x000D6CF4
		internal virtual ToolStripMenuItem SetHSCodesForProductsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SetHSCodesForProductsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SetHSCodesForProductsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SetHSCodesForProductsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SetHSCodesForProductsToolStripMenuItem = value;
				toolStripMenuItem = this._SetHSCodesForProductsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x000D8B37 File Offset: 0x000D6D37
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x000D8B41 File Offset: 0x000D6D41
		internal virtual ToolStripMenuItem RepairsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x000D8B4A File Offset: 0x000D6D4A
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x000D8B54 File Offset: 0x000D6D54
		internal virtual ToolStripMenuItem CheckInToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CheckInToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckInToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CheckInToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CheckInToolStripMenuItem = value;
				toolStripMenuItem = this._CheckInToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x000D8B97 File Offset: 0x000D6D97
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x000D8BA4 File Offset: 0x000D6DA4
		internal virtual ToolStripMenuItem ViewAndCheckOutToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewAndCheckOutToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewAndCheckOutToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewAndCheckOutToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewAndCheckOutToolStripMenuItem = value;
				toolStripMenuItem = this._ViewAndCheckOutToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x000D8BE7 File Offset: 0x000D6DE7
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x000D8BF4 File Offset: 0x000D6DF4
		internal virtual ToolStripMenuItem ViewDeletedProductsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewDeletedProductsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewDeletedProductsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewDeletedProductsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewDeletedProductsToolStripMenuItem = value;
				toolStripMenuItem = this._ViewDeletedProductsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x000D8C37 File Offset: 0x000D6E37
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x000D8C44 File Offset: 0x000D6E44
		internal virtual ToolStripMenuItem SearchInvoiceCommentsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SearchInvoiceCommentsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SearchInvoiceCommentsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SearchInvoiceCommentsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SearchInvoiceCommentsToolStripMenuItem = value;
				toolStripMenuItem = this._SearchInvoiceCommentsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x000D8C87 File Offset: 0x000D6E87
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x000D8C94 File Offset: 0x000D6E94
		internal virtual ToolStripMenuItem KkToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._KkToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.KkToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._KkToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._KkToolStripMenuItem = value;
				toolStripMenuItem = this._KkToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x000D8CD7 File Offset: 0x000D6ED7
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x000D8CE4 File Offset: 0x000D6EE4
		internal virtual ToolStripMenuItem KitchenDisplayToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._KitchenDisplayToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.KitchenDisplayToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._KitchenDisplayToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._KitchenDisplayToolStripMenuItem = value;
				toolStripMenuItem = this._KitchenDisplayToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x000D8D27 File Offset: 0x000D6F27
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x000D8D31 File Offset: 0x000D6F31
		internal virtual ToolStripMenuItem DespatchToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x000D8D3A File Offset: 0x000D6F3A
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x000D8D44 File Offset: 0x000D6F44
		internal virtual ToolStripMenuItem EnterDespatchToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnterDespatchToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.EnterDespatchToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._EnterDespatchToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._EnterDespatchToolStripMenuItem = value;
				toolStripMenuItem = this._EnterDespatchToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x000D8D87 File Offset: 0x000D6F87
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x000D8D94 File Offset: 0x000D6F94
		internal virtual ToolStripMenuItem ViewCancelDespatchToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ViewCancelDespatchToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ViewCancelDespatchToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ViewCancelDespatchToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ViewCancelDespatchToolStripMenuItem = value;
				toolStripMenuItem = this._ViewCancelDespatchToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x000D8DD7 File Offset: 0x000D6FD7
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x000D8DE4 File Offset: 0x000D6FE4
		internal virtual ToolStripMenuItem DespatchReportToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DespatchReportToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DespatchReportToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._DespatchReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._DespatchReportToolStripMenuItem = value;
				toolStripMenuItem = this._DespatchReportToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x000D8E27 File Offset: 0x000D7027
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x000D8E31 File Offset: 0x000D7031
		internal virtual ToolStripMenuItem DespatchReportsToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x000D8E3A File Offset: 0x000D703A
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x000D8E44 File Offset: 0x000D7044
		internal virtual ToolStripMenuItem DesptachesForPeriodToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DesptachesForPeriodToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DesptachesForPeriodToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._DesptachesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._DesptachesForPeriodToolStripMenuItem = value;
				toolStripMenuItem = this._DesptachesForPeriodToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x000D8E87 File Offset: 0x000D7087
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x000D8E94 File Offset: 0x000D7094
		internal virtual ToolStripMenuItem DespatchesForCustomerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DespatchesForCustomerToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DespatchesForCustomerToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._DespatchesForCustomerToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._DespatchesForCustomerToolStripMenuItem = value;
				toolStripMenuItem = this._DespatchesForCustomerToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x000D8ED7 File Offset: 0x000D70D7
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x000D8EE1 File Offset: 0x000D70E1
		internal virtual ToolStripMenuItem TIPSToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x000D8EEA File Offset: 0x000D70EA
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x000D8EF4 File Offset: 0x000D70F4
		internal virtual ToolStripMenuItem TipsForAUserToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._TipsForAUserToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TipsForAUserToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._TipsForAUserToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._TipsForAUserToolStripMenuItem = value;
				toolStripMenuItem = this._TipsForAUserToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x000D8F37 File Offset: 0x000D7137
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x000D8F41 File Offset: 0x000D7141
		internal virtual Label lblHotKeys
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x000D8F4A File Offset: 0x000D714A
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x000D8F54 File Offset: 0x000D7154
		internal virtual ToolStripMenuItem SalesForPeriodGroupedByDayToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForPeriodGroupedByDayToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForPeriodGroupedByDayToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForPeriodGroupedByDayToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForPeriodGroupedByDayToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForPeriodGroupedByDayToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x000D8F97 File Offset: 0x000D7197
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x000D8FA4 File Offset: 0x000D71A4
		internal virtual ToolStripMenuItem SalesForPeriodAllUsersToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SalesForPeriodAllUsersToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalesForPeriodAllUsersToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._SalesForPeriodAllUsersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._SalesForPeriodAllUsersToolStripMenuItem = value;
				toolStripMenuItem = this._SalesForPeriodAllUsersToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x000D8FE7 File Offset: 0x000D71E7
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x000D8FF1 File Offset: 0x000D71F1
		internal virtual ToolStripMenuItem SerialNumbersToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x000D8FFA File Offset: 0x000D71FA
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x000D9004 File Offset: 0x000D7204
		internal virtual ToolStripMenuItem CheckSerialNumberToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CheckSerialNumberToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckSerialNumberToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CheckSerialNumberToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CheckSerialNumberToolStripMenuItem = value;
				toolStripMenuItem = this._CheckSerialNumberToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x000D9047 File Offset: 0x000D7247
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x000D9054 File Offset: 0x000D7254
		internal virtual ToolStripMenuItem ConnectedBranchStatusToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ConnectedBranchStatusToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ConnectedBranchStatusToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._ConnectedBranchStatusToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._ConnectedBranchStatusToolStripMenuItem = value;
				toolStripMenuItem = this._ConnectedBranchStatusToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000D9097 File Offset: 0x000D7297
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x000D90A1 File Offset: 0x000D72A1
		internal virtual ToolStripMenuItem PacketSizesToolStripMenuItem
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x000D90AA File Offset: 0x000D72AA
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x000D90B4 File Offset: 0x000D72B4
		internal virtual ToolStripMenuItem CreatePacketSizesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreatePacketSizesToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreatePacketSizesToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreatePacketSizesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreatePacketSizesToolStripMenuItem = value;
				toolStripMenuItem = this._CreatePacketSizesToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x000D90F7 File Offset: 0x000D72F7
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x000D9104 File Offset: 0x000D7304
		internal virtual ToolStripMenuItem CreatePacketGroupsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CreatePacketGroupsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CreatePacketGroupsToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._CreatePacketGroupsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._CreatePacketGroupsToolStripMenuItem = value;
				toolStripMenuItem = this._CreatePacketGroupsToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x000D9147 File Offset: 0x000D7347
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x000D9154 File Offset: 0x000D7354
		internal virtual ToolStripMenuItem LinkProductWithPacketSzeGroupToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LinkProductWithPacketSzeGroupToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LinkProductWithPacketSzeGroupToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._LinkProductWithPacketSzeGroupToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._LinkProductWithPacketSzeGroupToolStripMenuItem = value;
				toolStripMenuItem = this._LinkProductWithPacketSzeGroupToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x000D9197 File Offset: 0x000D7397
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x000D91A4 File Offset: 0x000D73A4
		internal virtual ToolStripMenuItem RunningToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RunningToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RunningToolStripMenuItem_Click);
				ToolStripMenuItem toolStripMenuItem = this._RunningToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= eventHandler;
				}
				this._RunningToolStripMenuItem = value;
				toolStripMenuItem = this._RunningToolStripMenuItem;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000D91E8 File Offset: 0x000D73E8
		private void CreateUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Users users = new Users();
						users.ShowDialog(this);
						users.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Users users2 = new Users();
					users2.ShowDialog(this);
					users2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000D92DC File Offset: 0x000D74DC
		private void ChangeMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ChangePwd changePwd = new ChangePwd();
						changePwd.ShowDialog(this);
						changePwd.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ChangePwd changePwd2 = new ChangePwd();
					changePwd2.ShowDialog(this);
					changePwd2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x000D93D0 File Offset: 0x000D75D0
		private void DatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DBConnections dbconnections = new DBConnections();
						dbconnections.ShowDialog(this);
						dbconnections.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DBConnections dbconnections2 = new DBConnections();
					dbconnections2.ShowDialog(this);
					dbconnections2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x000D94C4 File Offset: 0x000D76C4
		private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Categories categories = new Categories();
						categories.ShowDialog(this);
						categories.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Categories categories2 = new Categories();
					categories2.ShowDialog(this);
					categories2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000D95B8 File Offset: 0x000D77B8
		private void GeneralSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						GeneralSettings generalSettings = new GeneralSettings();
						generalSettings.ShowDialog(this);
						generalSettings.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					GeneralSettings generalSettings2 = new GeneralSettings();
					generalSettings2.ShowDialog(this);
					generalSettings2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x000D96AC File Offset: 0x000D78AC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000D96B8 File Offset: 0x000D78B8
		private void PaymentMethodsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PaymentMethods paymentMethods = new PaymentMethods();
						paymentMethods.ShowDialog(this);
						paymentMethods.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PaymentMethods paymentMethods2 = new PaymentMethods();
					paymentMethods2.ShowDialog(this);
					paymentMethods2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002A30 File Offset: 0x00000C30
		private void StockTakeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000D97AC File Offset: 0x000D79AC
		private void EnterAndViewExpensesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Expenses expenses = new Expenses();
						this.Panel1.Controls.Add(expenses);
						expenses.Dock = DockStyle.Fill;
						expenses.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Expenses expenses2 = new Expenses();
					this.Panel1.Controls.Add(expenses2);
					expenses2.Dock = DockStyle.Fill;
					expenses2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000D98C8 File Offset: 0x000D7AC8
		private void DailySalesReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				SalesForDay salesForDay = new SalesForDay();
				this.Panel1.Controls.Add(salesForDay);
				salesForDay.Dock = DockStyle.Fill;
				salesForDay.BringToFront();
			}
			else
			{
				MessageBox.Show("Function for administrators only.");
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000D9920 File Offset: 0x000D7B20
		private void SalesForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						VerifyOpenImpReports verifyOpenImpReports = new VerifyOpenImpReports();
						verifyOpenImpReports.ShowDialog(this);
						verifyOpenImpReports.Dispose();
						SalesForPeriod salesForPeriod = new SalesForPeriod();
						this.Panel1.Controls.Add(salesForPeriod);
						salesForPeriod.Dock = DockStyle.Fill;
						salesForPeriod.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					VerifyOpenImpReports verifyOpenImpReports2 = new VerifyOpenImpReports();
					verifyOpenImpReports2.ShowDialog(this);
					verifyOpenImpReports2.Dispose();
					SalesForPeriod salesForPeriod2 = new SalesForPeriod();
					this.Panel1.Controls.Add(salesForPeriod2);
					salesForPeriod2.Dock = DockStyle.Fill;
					salesForPeriod2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000D9A78 File Offset: 0x000D7C78
		private void HighestMoversByQuantityToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockMovementQty stockMovementQty = new StockMovementQty();
						this.Panel1.Controls.Add(stockMovementQty);
						stockMovementQty.Dock = DockStyle.Fill;
						stockMovementQty.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockMovementQty stockMovementQty2 = new StockMovementQty();
					this.Panel1.Controls.Add(stockMovementQty2);
					stockMovementQty2.Dock = DockStyle.Fill;
					stockMovementQty2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000D9B94 File Offset: 0x000D7D94
		private void HighestMoversByGrossProfitContributionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockMovementValue stockMovementValue = new StockMovementValue();
						this.Panel1.Controls.Add(stockMovementValue);
						stockMovementValue.Dock = DockStyle.Fill;
						stockMovementValue.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockMovementValue stockMovementValue2 = new StockMovementValue();
					this.Panel1.Controls.Add(stockMovementValue2);
					stockMovementValue2.Dock = DockStyle.Fill;
					stockMovementValue2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000D9CB0 File Offset: 0x000D7EB0
		private void StockBalancesNowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockBalances stockBalances = new StockBalances();
						this.Panel1.Controls.Add(stockBalances);
						stockBalances.Dock = DockStyle.Fill;
						stockBalances.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockBalances stockBalances2 = new StockBalances();
					this.Panel1.Controls.Add(stockBalances2);
					stockBalances2.Dock = DockStyle.Fill;
					stockBalances2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000D9DCC File Offset: 0x000D7FCC
		private void StockAdjustmentsForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockAdjustments stockAdjustments = new StockAdjustments();
						this.Panel1.Controls.Add(stockAdjustments);
						stockAdjustments.Dock = DockStyle.Fill;
						stockAdjustments.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockAdjustments stockAdjustments2 = new StockAdjustments();
					this.Panel1.Controls.Add(stockAdjustments2);
					stockAdjustments2.Dock = DockStyle.Fill;
					stockAdjustments2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x000D9EE8 File Offset: 0x000D80E8
		private void SalesGraphForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesforPeriodGraph salesforPeriodGraph = new SalesforPeriodGraph();
						this.Panel1.Controls.Add(salesforPeriodGraph);
						salesforPeriodGraph.Dock = DockStyle.Fill;
						salesforPeriodGraph.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesforPeriodGraph salesforPeriodGraph2 = new SalesforPeriodGraph();
					this.Panel1.Controls.Add(salesforPeriodGraph2);
					salesforPeriodGraph2.Dock = DockStyle.Fill;
					salesforPeriodGraph2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000DA004 File Offset: 0x000D8204
		private void BackUpDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						BackUpDB backUpDB = new BackUpDB();
						backUpDB.ShowDialog(this);
						backUpDB.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					BackUpDB backUpDB2 = new BackUpDB();
					backUpDB2.ShowDialog(this);
					backUpDB2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00002A30 File Offset: 0x00000C30
		private void ViewStockLevelsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000DA0F8 File Offset: 0x000D82F8
		private void DisposeResources()
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1);
				if (flag)
				{
					try
					{
						foreach (object obj in this.Panel1.Controls)
						{
							Control control = (Control)obj;
							control.Dispose();
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
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000DA1AC File Offset: 0x000D83AC
		private void MainMenu_Load(object sender, EventArgs e)
		{
			this.loadMenuDAT();
			string text = "";
			bool flag = MyProject.Forms.Form1.isRestaurant == 1;
			if (flag)
			{
				text = " : RESTAURANT MODE";
			}
			this.Text = string.Concat(new string[]
			{
				"Menu - QuantumPOS v2.9.5:         Company: ",
				MyProject.Forms.Form1.companyname,
				" (",
				MyProject.Forms.Form1.coid.ToString(),
				")         Branch: ",
				MyProject.Forms.Form1.branch,
				"         Username: ",
				MyProject.Forms.Form1.username,
				text
			});
			bool flag2 = MyProject.Forms.Form1.ShowLowStockAtStartUp == 1;
			if (flag2)
			{
				bool flag3 = this.Publicfunction.CheckReorderLevel(MyProject.Forms.Form1.Constring);
				if (flag3)
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Some stock items have reached their reorder levels.  Do you want to view them now?", MsgBoxStyle.YesNo, null);
					bool flag4 = dialogResult == DialogResult.Yes;
					if (flag4)
					{
						StockLevels stockLevels = new StockLevels();
						this.Panel1.Controls.Add(stockLevels);
						stockLevels.Dock = DockStyle.Fill;
						stockLevels.BringToFront();
					}
				}
			}
			base.WindowState = FormWindowState.Maximized;
			bool flag5 = MyProject.Forms.Form1.showproductconversion == 1;
			if (flag5)
			{
				this.ToolStripMenuItem1.Visible = true;
			}
			bool flag6 = MyProject.Forms.Form1.isRestaurant == 1;
			if (flag6)
			{
				this.WaiterTipsToolStripMenuItem.Visible = true;
			}
			else
			{
				this.WaiterTipsToolStripMenuItem.Visible = false;
			}
			bool flag7 = (MyProject.Forms.Form1.istouchscreen == 1) & (MyProject.Forms.Form1.isRestaurant == 1);
			if (flag7)
			{
				bool flag8 = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag8)
				{
					bool flag9 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag9)
					{
						SalesTouchScreen salesTouchScreen = new SalesTouchScreen();
						this.Panel1.Controls.Add(salesTouchScreen);
						salesTouchScreen.Dock = DockStyle.Fill;
						salesTouchScreen.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesTouchScreen salesTouchScreen2 = new SalesTouchScreen();
					this.Panel1.Controls.Add(salesTouchScreen2);
					salesTouchScreen2.Dock = DockStyle.Fill;
					salesTouchScreen2.BringToFront();
				}
			}
			bool flag10 = MyProject.Forms.Form1.BillTrips == 1;
			if (flag10)
			{
				this.VEHICLETRIPSBILLINGToolStripMenuItem.Visible = true;
			}
			else
			{
				this.VEHICLETRIPSBILLINGToolStripMenuItem.Visible = false;
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000DA490 File Offset: 0x000D8690
		private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						About about = new About();
						about.ShowDialog(this);
						about.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					About about2 = new About();
					about2.ShowDialog(this);
					about2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000DA584 File Offset: 0x000D8784
		private void CompanyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Company company = new Company();
						company.ShowDialog(this);
						company.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Company company2 = new Company();
					company2.ShowDialog(this);
					company2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000DA678 File Offset: 0x000D8878
		private void LicenseKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						License license = new License();
						license.ShowDialog(this);
						license.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					License license2 = new License();
					license2.ShowDialog(this);
					license2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x000DA76C File Offset: 0x000D896C
		private void NewStockInPacksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.BusType, "Tuckshop", false) == 0;
				if (flag)
				{
					NewStock newStock = new NewStock();
					newStock.ShowDialog(this);
					newStock.Dispose();
				}
				else
				{
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Parts", false) == 0;
					if (flag2)
					{
						NewStock2 newStock2 = new NewStock2();
						newStock2.ShowDialog(this);
						newStock2.Dispose();
					}
				}
			}
			else
			{
				MessageBox.Show("Only admin users can enter new stock.");
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000DA810 File Offset: 0x000D8A10
		private void NewStockInUnitsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.BusType, "Tuckshop", false) == 0;
				if (flag)
				{
					MyProject.Forms.NewStockUnits.Show();
				}
				else
				{
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Parts", false) == 0;
					if (flag2)
					{
						MyProject.Forms.NewStockUnits2.Show();
					}
				}
			}
			else
			{
				MessageBox.Show("Only admin users can enter new stock.");
			}
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x000DA8A8 File Offset: 0x000D8AA8
		private void EditStockPurhcasesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						EditStockPurchases editStockPurchases = new EditStockPurchases();
						this.Panel1.Controls.Add(editStockPurchases);
						editStockPurchases.Dock = DockStyle.Fill;
						editStockPurchases.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EditStockPurchases editStockPurchases2 = new EditStockPurchases();
					this.Panel1.Controls.Add(editStockPurchases2);
					editStockPurchases2.Dock = DockStyle.Fill;
					editStockPurchases2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x000DA9C4 File Offset: 0x000D8BC4
		private void ViewProductIDsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
			if (flag)
			{
				bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
				if (flag2)
				{
					ViewProducts2 viewProducts = new ViewProducts2();
					viewProducts.ShowDialog(this);
					viewProducts.Dispose();
				}
				else
				{
					MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
				}
			}
			else
			{
				ViewProducts2 viewProducts2 = new ViewProducts2();
				viewProducts2.ShowDialog(this);
				viewProducts2.Dispose();
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x000DAA7C File Offset: 0x000D8C7C
		private void EnterNewProductToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
			if (flag)
			{
				bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
				if (flag2)
				{
					NewStockUnits2 newStockUnits = new NewStockUnits2();
					newStockUnits.ShowDialog(this);
					newStockUnits.Dispose();
				}
				else
				{
					MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
				}
			}
			else
			{
				NewStockUnits2 newStockUnits2 = new NewStockUnits2();
				newStockUnits2.ShowDialog(this);
				newStockUnits2.Dispose();
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000DAB24 File Offset: 0x000D8D24
		private void EditProductDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
			if (flag)
			{
				bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
				if (flag2)
				{
					EditProducts editProducts = new EditProducts();
					editProducts.ShowDialog(this);
					editProducts.Dispose();
				}
				else
				{
					MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
				}
			}
			else
			{
				EditProducts editProducts2 = new EditProducts();
				editProducts2.ShowDialog(this);
				editProducts2.Dispose();
			}
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000DABDC File Offset: 0x000D8DDC
		private void CancelSaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CreditNote creditNote = new CreditNote();
						this.Panel1.Controls.Add(creditNote);
						creditNote.Dock = DockStyle.Fill;
						creditNote.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CreditNote creditNote2 = new CreditNote();
					this.Panel1.Controls.Add(creditNote2);
					creditNote2.Dock = DockStyle.Fill;
					creditNote2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000DACF8 File Offset: 0x000D8EF8
		private void ViewCancelledSalesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewCancelledSales viewCancelledSales = new ViewCancelledSales();
						this.Panel1.Controls.Add(viewCancelledSales);
						viewCancelledSales.Dock = DockStyle.Fill;
						viewCancelledSales.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewCancelledSales viewCancelledSales2 = new ViewCancelledSales();
					this.Panel1.Controls.Add(viewCancelledSales2);
					viewCancelledSales2.Dock = DockStyle.Fill;
					viewCancelledSales2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x000DAE14 File Offset: 0x000D9014
		private void ViewProductMovementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProductMovement productMovement = new ProductMovement();
			this.Panel1.Controls.Add(productMovement);
			productMovement.Dock = DockStyle.Fill;
			productMovement.BringToFront();
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x000DAE4C File Offset: 0x000D904C
		private void PrinterSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Printers printers = new Printers();
						printers.ShowDialog(this);
						printers.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Printers printers2 = new Printers();
					printers2.ShowDialog(this);
					printers2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000DAF40 File Offset: 0x000D9140
		private void HowToVideosToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				Videos videos = new Videos();
				videos.ShowDialog(this);
				videos.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("PLEASE OPEN THE VIDEOS DIRECTLY FROM C:\\POSVideos ");
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000DAF94 File Offset: 0x000D9194
		private void SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MyProject.Forms.Form1.BusType, "Tuckshop", false) == 0;
			if (flag)
			{
				bool flag2 = MyProject.Forms.Form1.BarCode == 1;
				if (flag2)
				{
					SalesBarCode salesBarCode = new SalesBarCode();
					this.Panel1.Controls.Add(salesBarCode);
					salesBarCode.Dock = DockStyle.Fill;
					salesBarCode.BringToFront();
				}
				else
				{
					bool flag3 = MyProject.Forms.Form1.BarCode == 0;
					if (flag3)
					{
						Sales sales = new Sales();
						this.Panel1.Controls.Add(sales);
						sales.Dock = DockStyle.Fill;
						sales.BringToFront();
					}
				}
			}
			else
			{
				bool flag4 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Parts", false) == 0;
				if (flag4)
				{
					Sales2OLD sales2OLD = new Sales2OLD();
					this.Panel1.Controls.Add(sales2OLD);
					sales2OLD.Dock = DockStyle.Fill;
					sales2OLD.BringToFront();
				}
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x000DB09C File Offset: 0x000D929C
		private void EditBarCodesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
			if (flag)
			{
				bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
				if (flag2)
				{
					eltratefiscaldevice eltratefiscaldevice = new eltratefiscaldevice();
					eltratefiscaldevice.ShowDialog(this);
					eltratefiscaldevice.Dispose();
				}
				else
				{
					MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
				}
			}
			else
			{
				eltratefiscaldevice eltratefiscaldevice2 = new eltratefiscaldevice();
				eltratefiscaldevice2.ShowDialog(this);
				eltratefiscaldevice2.Dispose();
			}
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x000DB154 File Offset: 0x000D9354
		private void DailySalesReportByUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				SalesForDayByUser salesForDayByUser = new SalesForDayByUser();
				this.Panel1.Controls.Add(salesForDayByUser);
				salesForDayByUser.Dock = DockStyle.Fill;
				salesForDayByUser.BringToFront();
			}
			else
			{
				MessageBox.Show("Function is set for admin users only.");
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x000DB1AC File Offset: 0x000D93AC
		private void CurrentCustomersListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CustomerList customerList = new CustomerList();
						this.Panel1.Controls.Add(customerList);
						customerList.Dock = DockStyle.Fill;
						customerList.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CustomerList customerList2 = new CustomerList();
					this.Panel1.Controls.Add(customerList2);
					customerList2.Dock = DockStyle.Fill;
					customerList2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x000DB2C8 File Offset: 0x000D94C8
		private void CustomersListBySalesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CustomerListBySales customerListBySales = new CustomerListBySales();
						this.Panel1.Controls.Add(customerListBySales);
						customerListBySales.Dock = DockStyle.Fill;
						customerListBySales.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CustomerListBySales customerListBySales2 = new CustomerListBySales();
					this.Panel1.Controls.Add(customerListBySales2);
					customerListBySales2.Dock = DockStyle.Fill;
					customerListBySales2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x000DB3E4 File Offset: 0x000D95E4
		private void SendSMSToCustomersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SendSmS sendSmS = new SendSmS();
						sendSmS.ShowDialog(this);
						sendSmS.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SendSmS sendSmS2 = new SendSmS();
					sendSmS2.ShowDialog(this);
					sendSmS2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000DB4D8 File Offset: 0x000D96D8
		private void ViewSMSsSentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewSMSSent viewSMSSent = new ViewSMSSent();
						viewSMSSent.ShowDialog(this);
						viewSMSSent.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewSMSSent viewSMSSent2 = new ViewSMSSent();
					viewSMSSent2.ShowDialog(this);
					viewSMSSent2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x000DB5CC File Offset: 0x000D97CC
		private void TaxReturnsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						TaxReturns taxReturns = new TaxReturns();
						this.Panel1.Controls.Add(taxReturns);
						taxReturns.Dock = DockStyle.Fill;
						taxReturns.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					TaxReturns taxReturns2 = new TaxReturns();
					this.Panel1.Controls.Add(taxReturns2);
					taxReturns2.Dock = DockStyle.Fill;
					taxReturns2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x000DB6E8 File Offset: 0x000D98E8
		private void EnterSalesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.PrintFiscal == 1;
				if (flag)
				{
					MessageBox.Show("Please use Sales Normal or Mono since fiscalisation is set on.");
				}
				else
				{
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
					if (flag2)
					{
						bool flag3 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
						if (flag3)
						{
							bool flag4 = MyProject.Forms.Form1.IsWarehouse == 1;
							if (flag4)
							{
								Sales2 sales = new Sales2();
								this.Panel1.Controls.Add(sales);
								sales.Dock = DockStyle.Fill;
								sales.BringToFront();
							}
							else
							{
								Sales2 sales2 = new Sales2();
								this.Panel1.Controls.Add(sales2);
								sales2.Dock = DockStyle.Fill;
								sales2.BringToFront();
							}
						}
						else
						{
							MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
						}
					}
					else
					{
						bool flag5 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag5)
						{
							Sales2 sales3 = new Sales2();
							this.Panel1.Controls.Add(sales3);
							sales3.Dock = DockStyle.Fill;
							sales3.BringToFront();
						}
						else
						{
							Sales2 sales4 = new Sales2();
							this.Panel1.Controls.Add(sales4);
							sales4.Dock = DockStyle.Fill;
							sales4.BringToFront();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x000DB8CC File Offset: 0x000D9ACC
		private void IndividualProductMovementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ProductMovement productMovement = new ProductMovement();
						this.Panel1.Controls.Add(productMovement);
						productMovement.Dock = DockStyle.Fill;
						productMovement.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ProductMovement productMovement2 = new ProductMovement();
					this.Panel1.Controls.Add(productMovement2);
					productMovement2.Dock = DockStyle.Fill;
					productMovement2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000DB9E8 File Offset: 0x000D9BE8
		private void DailySalesReportForTheCompanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Report disabled in this version of the software.");
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x000DB9E8 File Offset: 0x000D9BE8
		private void RevenueReportForCompanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Report disabled in this version of the software.");
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000DB9F8 File Offset: 0x000D9BF8
		private void StockBalancesForCompanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						OveralStockBalances overalStockBalances = new OveralStockBalances();
						this.Panel1.Controls.Add(overalStockBalances);
						overalStockBalances.Dock = DockStyle.Fill;
						overalStockBalances.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					OveralStockBalances overalStockBalances2 = new OveralStockBalances();
					this.Panel1.Controls.Add(overalStockBalances2);
					overalStockBalances2.Dock = DockStyle.Fill;
					overalStockBalances2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000DBB14 File Offset: 0x000D9D14
		private void WarehouseNewStockPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						NewStockUnits2 newStockUnits = new NewStockUnits2();
						newStockUnits.ShowDialog(this);
						newStockUnits.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					NewStockUnits2 newStockUnits2 = new NewStockUnits2();
					newStockUnits2.ShowDialog(this);
					newStockUnits2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x000DBC08 File Offset: 0x000D9E08
		private void WarehouseStockTransferToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				WarehouseStockTransfer warehouseStockTransfer = new WarehouseStockTransfer();
				this.Panel1.Controls.Add(warehouseStockTransfer);
				warehouseStockTransfer.Dock = DockStyle.Fill;
				warehouseStockTransfer.BringToFront();
			}
			else
			{
				MessageBox.Show("Function set for admin users");
			}
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000DBC60 File Offset: 0x000D9E60
		private void PrintLabelsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PrintLabels printLabels = new PrintLabels();
						this.Panel1.Controls.Add(printLabels);
						printLabels.Dock = DockStyle.Fill;
						printLabels.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PrintLabels printLabels2 = new PrintLabels();
					this.Panel1.Controls.Add(printLabels2);
					printLabels2.Dock = DockStyle.Fill;
					printLabels2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000DBD7C File Offset: 0x000D9F7C
		private void CreateDiscountCouponsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CreateCoupons createCoupons = new CreateCoupons();
						this.Panel1.Controls.Add(createCoupons);
						createCoupons.Dock = DockStyle.Fill;
						createCoupons.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CreateCoupons createCoupons2 = new CreateCoupons();
					this.Panel1.Controls.Add(createCoupons2);
					createCoupons2.Dock = DockStyle.Fill;
					createCoupons2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000DBE98 File Offset: 0x000DA098
		private void TrasnferStockFromBranchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				StockTransfer stockTransfer = new StockTransfer();
				this.Panel1.Controls.Add(stockTransfer);
				stockTransfer.Dock = DockStyle.Fill;
				stockTransfer.BringToFront();
			}
			else
			{
				MessageBox.Show("Function set for admin users");
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000DBEF0 File Offset: 0x000DA0F0
		private void SalesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				ComputedSalesReport computedSalesReport = new ComputedSalesReport();
				this.Panel1.Controls.Add(computedSalesReport);
				computedSalesReport.Dock = DockStyle.Fill;
				computedSalesReport.BringToFront();
			}
			else
			{
				MessageBox.Show("Function set for admin users");
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000DBF48 File Offset: 0x000DA148
		private void SalesReportForBranchShiftsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				SalesforDayShift salesforDayShift = new SalesforDayShift();
				this.Panel1.Controls.Add(salesforDayShift);
				salesforDayShift.Dock = DockStyle.Fill;
				salesforDayShift.BringToFront();
			}
			else
			{
				MessageBox.Show("Function set for admin users");
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000DBFA0 File Offset: 0x000DA1A0
		private void SalesReportForPeriodShiftsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				SalesforPeriodbyShift salesforPeriodbyShift = new SalesforPeriodbyShift();
				this.Panel1.Controls.Add(salesforPeriodbyShift);
				salesforPeriodbyShift.Dock = DockStyle.Fill;
				salesforPeriodbyShift.BringToFront();
			}
			else
			{
				MessageBox.Show("Function set for admin users");
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x000DBFF8 File Offset: 0x000DA1F8
		private void SalesByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesByCategory salesByCategory = new SalesByCategory();
						this.Panel1.Controls.Add(salesByCategory);
						salesByCategory.Dock = DockStyle.Fill;
						salesByCategory.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesByCategory salesByCategory2 = new SalesByCategory();
					this.Panel1.Controls.Add(salesByCategory2);
					salesByCategory2.Dock = DockStyle.Fill;
					salesByCategory2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x000DC114 File Offset: 0x000DA314
		private void ViewStockTransfersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewStockTransfers viewStockTransfers = new ViewStockTransfers();
						this.Panel1.Controls.Add(viewStockTransfers);
						viewStockTransfers.Dock = DockStyle.Fill;
						viewStockTransfers.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewStockTransfers viewStockTransfers2 = new ViewStockTransfers();
					this.Panel1.Controls.Add(viewStockTransfers2);
					viewStockTransfers2.Dock = DockStyle.Fill;
					viewStockTransfers2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x000DC230 File Offset: 0x000DA430
		private void ChangeUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ChangeUserPassword changeUserPassword = new ChangeUserPassword();
						changeUserPassword.ShowDialog(this);
						changeUserPassword.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ChangeUserPassword changeUserPassword2 = new ChangeUserPassword();
					changeUserPassword2.ShowDialog(this);
					changeUserPassword2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x000DC324 File Offset: 0x000DA524
		private void ViewStockTransfersToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewStockTransfers viewStockTransfers = new ViewStockTransfers();
						this.Panel1.Controls.Add(viewStockTransfers);
						viewStockTransfers.Dock = DockStyle.Fill;
						viewStockTransfers.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewStockTransfers viewStockTransfers2 = new ViewStockTransfers();
					this.Panel1.Controls.Add(viewStockTransfers2);
					viewStockTransfers2.Dock = DockStyle.Fill;
					viewStockTransfers2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x000DC440 File Offset: 0x000DA640
		private void NegaiveStockSettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				NegativeStockSetting negativeStockSetting = new NegativeStockSetting();
				negativeStockSetting.ShowDialog(this);
				negativeStockSetting.Dispose();
			}
			else
			{
				MessageBox.Show("Function set for admin users");
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000DC488 File Offset: 0x000DA688
		private void DailySalesByShiftsForDayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesForDayByUser salesForDayByUser = new SalesForDayByUser();
						this.Panel1.Controls.Add(salesForDayByUser);
						salesForDayByUser.Dock = DockStyle.Fill;
						salesForDayByUser.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesForDayByUser salesForDayByUser2 = new SalesForDayByUser();
					this.Panel1.Controls.Add(salesForDayByUser2);
					salesForDayByUser2.Dock = DockStyle.Fill;
					salesForDayByUser2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x000DC5A4 File Offset: 0x000DA7A4
		private void SalesForPeriodByShiftsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						UserSalesForPeriod userSalesForPeriod = new UserSalesForPeriod();
						this.Panel1.Controls.Add(userSalesForPeriod);
						userSalesForPeriod.Dock = DockStyle.Fill;
						userSalesForPeriod.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					UserSalesForPeriod userSalesForPeriod2 = new UserSalesForPeriod();
					this.Panel1.Controls.Add(userSalesForPeriod2);
					userSalesForPeriod2.Dock = DockStyle.Fill;
					userSalesForPeriod2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x000DC6C0 File Offset: 0x000DA8C0
		private void ViewOpenActualShiftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						EditShiftDetail editShiftDetail = new EditShiftDetail();
						editShiftDetail.ShowDialog(this);
						editShiftDetail.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EditShiftDetail editShiftDetail2 = new EditShiftDetail();
					editShiftDetail2.ShowDialog(this);
					editShiftDetail2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000DC7B4 File Offset: 0x000DA9B4
		private void ConfigureShiftsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						ConfigureShifts configureShifts = new ConfigureShifts();
						configureShifts.ShowDialog(this);
						configureShifts.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ConfigureShifts configureShifts2 = new ConfigureShifts();
					configureShifts2.ShowDialog(this);
					configureShifts2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x000DC898 File Offset: 0x000DAA98
		private void StockTransferToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						StockTransfer stockTransfer = new StockTransfer();
						this.Panel1.Controls.Add(stockTransfer);
						stockTransfer.Dock = DockStyle.Fill;
						stockTransfer.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockTransfer stockTransfer2 = new StockTransfer();
					this.Panel1.Controls.Add(stockTransfer2);
					stockTransfer2.Dock = DockStyle.Fill;
					stockTransfer2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x000DC9A0 File Offset: 0x000DABA0
		private void PrintZReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to print the Fiscal Z Report from the fiscal device?", MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							bool flag4 = (MyProject.Forms.Form1.PrintReceipt == 1) & (MyProject.Forms.Form1.PrintFiscal == 1);
							if (flag4)
							{
								ZReport zreport = new ZReport();
								zreport.ShowDialog(this);
								zreport.Dispose();
							}
							else
							{
								MessageBox.Show("Fiscal device recepit printing Is Not configured.");
							}
						}
					}
					else
					{
						MessageBox.Show("You are Not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Are you sure you want to print the Fiscal Z Report from the fiscal device?", MsgBoxStyle.YesNo, null);
					bool flag5 = dialogResult2 == DialogResult.Yes;
					if (flag5)
					{
						bool flag6 = MyProject.Forms.Form1.PrintFiscal == 1;
						if (flag6)
						{
							ZReport zreport2 = new ZReport();
							zreport2.ShowDialog(this);
							zreport2.Dispose();
						}
						else
						{
							MessageBox.Show("Fiscal device recepit printing is not configured.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Z Report Error Details: " + ex.Message);
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000DCB3C File Offset: 0x000DAD3C
		private void PrintXReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to print the Fiscal X Report from the fiscal device?", MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							bool flag4 = MyProject.Forms.Form1.PrintFiscal == 1;
							if (flag4)
							{
								bool flag5 = MyProject.Forms.Form1.FiscalEltrade == 1;
								if (flag5)
								{
									EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
									long num = (long)eltradeFprn.RunXReport();
									bool flag6 = num != 0L;
									if (flag6)
									{
										eltradeFprn.Close();
										MessageBox.Show(Conversions.ToString(Conversions.ToDouble("Error. ") + (double)num));
									}
									else
									{
										eltradeFprn.Close();
										MessageBox.Show("X Report Success.");
									}
								}
								else
								{
									bool flag7 = MyProject.Forms.Form1.FiscalRevmax == 1;
									if (flag7)
									{
										MessageBox.Show("There is no X report for Revmax currently. Contact the software developer.");
									}
								}
							}
							else
							{
								MessageBox.Show("Fiscal device recepit printing is not configured.");
							}
						}
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Are you sure you want to print the Fiscal X Report from the fiscal device?", MsgBoxStyle.YesNo, null);
					bool flag8 = dialogResult2 == DialogResult.Yes;
					if (flag8)
					{
						bool flag9 = MyProject.Forms.Form1.PrintFiscal == 1;
						if (flag9)
						{
							bool flag10 = MyProject.Forms.Form1.FiscalEltrade == 1;
							if (flag10)
							{
								EltradeFprn eltradeFprn2 = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
								long num2 = (long)eltradeFprn2.RunXReport();
								bool flag11 = num2 != 0L;
								if (flag11)
								{
									eltradeFprn2.Close();
									MessageBox.Show(Conversions.ToString(Conversions.ToDouble("Error. ") + (double)num2));
								}
								else
								{
									eltradeFprn2.Close();
									MessageBox.Show("X Report Success.");
								}
							}
							else
							{
								bool flag12 = MyProject.Forms.Form1.FiscalRevmax == 1;
								if (flag12)
								{
									MessageBox.Show("There is no X report for Revmax currently. Contact the software developer.");
								}
							}
						}
						else
						{
							MessageBox.Show("Fiscal device recepit printing is not configured.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000DCDFC File Offset: 0x000DAFFC
		private void ReprintLastReceiptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to reprint a copy of the last receipt?", MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							bool flag4 = MyProject.Forms.Form1.PrintFiscal == 1;
							if (flag4)
							{
								bool flag5 = MyProject.Forms.Form1.FiscalEltrade == 1;
								if (flag5)
								{
									EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
									int num = eltradeFprn.Init(MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, 0, 0, 0, "");
									bool flag6 = num == 0;
									if (flag6)
									{
										string lastInvoiceNumber = eltradeFprn.GetLastInvoiceNumber();
										eltradeFprn.Close();
										MessageBox.Show("Cannot reprint. Last Invoice Number is: " + lastInvoiceNumber);
									}
									else
									{
										MessageBox.Show("Eltrade device init failed.");
										eltradeFprn.Close();
									}
								}
								else
								{
									bool flag7 = MyProject.Forms.Form1.FiscalRevmax == 1;
									if (flag7)
									{
										MessageBox.Show("Function not available in Revmax. Contact System Developer.");
									}
								}
							}
							else
							{
								MessageBox.Show("Fiscal device recepit printing is not configured.");
							}
						}
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Are you sure you want to reprint a copy of the last receipt?", MsgBoxStyle.YesNo, null);
					bool flag8 = dialogResult2 == DialogResult.Yes;
					if (flag8)
					{
						bool flag9 = (MyProject.Forms.Form1.PrintReceipt == 1) & (MyProject.Forms.Form1.PrintFiscal == 1);
						if (flag9)
						{
							EltradeFprn eltradeFprn2 = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
							int num2 = eltradeFprn2.Init(MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, 0, 0, 0, "");
							bool flag10 = num2 == 0;
							if (flag10)
							{
								string lastInvoiceNumber2 = eltradeFprn2.GetLastInvoiceNumber();
								MessageBox.Show("Cannot reprint. Last Invoice Number is: " + lastInvoiceNumber2);
								eltradeFprn2.Close();
							}
							else
							{
								MessageBox.Show("Eltrade device init failed.");
								eltradeFprn2.Close();
							}
						}
						else
						{
							MessageBox.Show("Fiscal device recepit printing is not configured.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x000DD0DC File Offset: 0x000DB2DC
		private void PaymentTermsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			if (isAdmin)
			{
				BillingTerms billingTerms = new BillingTerms();
				billingTerms.ShowDialog(this);
				billingTerms.Dispose();
			}
			else
			{
				MessageBox.Show("Function set for admin users");
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000DD124 File Offset: 0x000DB324
		private void DisburseFundsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						TellerDisbursements tellerDisbursements = new TellerDisbursements();
						tellerDisbursements.ShowDialog(this);
						tellerDisbursements.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					TellerDisbursements tellerDisbursements2 = new TellerDisbursements();
					tellerDisbursements2.ShowDialog(this);
					tellerDisbursements2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000DD208 File Offset: 0x000DB408
		private void EnterSalesTOUCHToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesTouchScreen salesTouchScreen = new SalesTouchScreen();
						this.Panel1.Controls.Add(salesTouchScreen);
						salesTouchScreen.Dock = DockStyle.Fill;
						salesTouchScreen.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesTouchScreen salesTouchScreen2 = new SalesTouchScreen();
					this.Panel1.Controls.Add(salesTouchScreen2);
					salesTouchScreen2.Dock = DockStyle.Fill;
					salesTouchScreen2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x000DD324 File Offset: 0x000DB524
		private void StockExpiryReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmStockExpiry frmStockExpiry = new frmStockExpiry();
				frmStockExpiry.ShowDialog(this);
				frmStockExpiry.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000DD380 File Offset: 0x000DB580
		private void ReturnStockToSupplierToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PurchaseReturns purchaseReturns = new PurchaseReturns();
						purchaseReturns.ShowDialog(this);
						purchaseReturns.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PurchaseReturns purchaseReturns2 = new PurchaseReturns();
					purchaseReturns2.ShowDialog(this);
					purchaseReturns2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000DD474 File Offset: 0x000DB674
		private void ViewPurchaseReturnsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewPurchaseReturns viewPurchaseReturns = new ViewPurchaseReturns();
						viewPurchaseReturns.ShowDialog(this);
						viewPurchaseReturns.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewPurchaseReturns viewPurchaseReturns2 = new ViewPurchaseReturns();
					viewPurchaseReturns2.ShowDialog(this);
					viewPurchaseReturns2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000DD568 File Offset: 0x000DB768
		private void ChangeProductCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						EditProductCategory editProductCategory = new EditProductCategory();
						editProductCategory.ShowDialog(this);
						editProductCategory.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EditProductCategory editProductCategory2 = new EditProductCategory();
					editProductCategory2.ShowDialog(this);
					editProductCategory2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000DD64C File Offset: 0x000DB84C
		private void StockBalancesCompleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				StockLevels stockLevels = new StockLevels();
				this.Panel1.Controls.Add(stockLevels);
				stockLevels.Dock = DockStyle.Fill;
				stockLevels.BringToFront();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying Stock levels form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000DD6BC File Offset: 0x000DB8BC
		private void StockBalancesForCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockBalancesByCategory stockBalancesByCategory = new StockBalancesByCategory();
						this.Panel1.Controls.Add(stockBalancesByCategory);
						stockBalancesByCategory.Dock = DockStyle.Fill;
						stockBalancesByCategory.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockBalancesByCategory stockBalancesByCategory2 = new StockBalancesByCategory();
					this.Panel1.Controls.Add(stockBalancesByCategory2);
					stockBalancesByCategory2.Dock = DockStyle.Fill;
					stockBalancesByCategory2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x000DD7D8 File Offset: 0x000DB9D8
		private void EcocashReceiptsReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						EcocashReceipts ecocashReceipts = new EcocashReceipts();
						ecocashReceipts.ShowDialog(this);
						ecocashReceipts.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EcocashReceipts ecocashReceipts2 = new EcocashReceipts();
					ecocashReceipts2.ShowDialog(this);
					ecocashReceipts2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000DD8CC File Offset: 0x000DBACC
		private void TillPointPriceChangesReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PriceChangesReport priceChangesReport = new PriceChangesReport();
						priceChangesReport.ShowDialog(this);
						priceChangesReport.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PriceChangesReport priceChangesReport2 = new PriceChangesReport();
					priceChangesReport2.ShowDialog(this);
					priceChangesReport2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000DD9C0 File Offset: 0x000DBBC0
		private void EndOfDayPrintOutSlipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						EODPrintOut eodprintOut = new EODPrintOut();
						eodprintOut.ShowDialog(this);
						eodprintOut.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EODPrintOut eodprintOut2 = new EODPrintOut();
					eodprintOut2.ShowDialog(this);
					eodprintOut2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000DDAB4 File Offset: 0x000DBCB4
		private void StockBalanceByBinLocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						StockByBinLoc stockByBinLoc = new StockByBinLoc();
						this.Panel1.Controls.Add(stockByBinLoc);
						stockByBinLoc.Dock = DockStyle.Fill;
						stockByBinLoc.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockByBinLoc stockByBinLoc2 = new StockByBinLoc();
					this.Panel1.Controls.Add(stockByBinLoc2);
					stockByBinLoc2.Dock = DockStyle.Fill;
					stockByBinLoc2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000DDBBC File Offset: 0x000DBDBC
		private void StockBalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockLevels stockLevels = new StockLevels();
						this.Panel1.Controls.Add(stockLevels);
						stockLevels.Dock = DockStyle.Fill;
						stockLevels.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockLevels stockLevels2 = new StockLevels();
					this.Panel1.Controls.Add(stockLevels2);
					stockLevels2.Dock = DockStyle.Fill;
					stockLevels2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000DDCD8 File Offset: 0x000DBED8
		private void EnterStockTakeFiguresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							StockTakeWarehouse stockTakeWarehouse = new StockTakeWarehouse();
							stockTakeWarehouse.ShowDialog(this);
							stockTakeWarehouse.Dispose();
						}
						else
						{
							StockTake stockTake = new StockTake();
							stockTake.ShowDialog(this);
							stockTake.Dispose();
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
						StockTakeWarehouse stockTakeWarehouse2 = new StockTakeWarehouse();
						stockTakeWarehouse2.ShowDialog(this);
						stockTakeWarehouse2.Dispose();
					}
					else
					{
						StockTake stockTake2 = new StockTake();
						stockTake2.ShowDialog(this);
						stockTake2.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x000DDE44 File Offset: 0x000DC044
		private void PrintStockSheetsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							StockSheetsWarehouse stockSheetsWarehouse = new StockSheetsWarehouse();
							stockSheetsWarehouse.ShowDialog(this);
							stockSheetsWarehouse.Dispose();
						}
						else
						{
							StockSheets stockSheets = new StockSheets();
							this.Panel1.Controls.Add(stockSheets);
							stockSheets.Dock = DockStyle.Fill;
							stockSheets.BringToFront();
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
						StockSheetsWarehouse stockSheetsWarehouse2 = new StockSheetsWarehouse();
						stockSheetsWarehouse2.ShowDialog(this);
						stockSheetsWarehouse2.Dispose();
					}
					else
					{
						StockSheets stockSheets2 = new StockSheets();
						this.Panel1.Controls.Add(stockSheets2);
						stockSheets2.Dock = DockStyle.Fill;
						stockSheets2.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000DDFD8 File Offset: 0x000DC1D8
		private void SalesForPeriodTotalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						SalesForPeriodGrid salesForPeriodGrid = new SalesForPeriodGrid();
						this.Panel1.Controls.Add(salesForPeriodGrid);
						salesForPeriodGrid.Dock = DockStyle.Fill;
						salesForPeriodGrid.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesForPeriodGrid salesForPeriodGrid2 = new SalesForPeriodGrid();
					this.Panel1.Controls.Add(salesForPeriodGrid2);
					salesForPeriodGrid2.Dock = DockStyle.Fill;
					salesForPeriodGrid2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000DE0E0 File Offset: 0x000DC2E0
		private void CustomerPurchasesForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						SalesForCustomer salesForCustomer = new SalesForCustomer();
						this.Panel1.Controls.Add(salesForCustomer);
						salesForCustomer.Dock = DockStyle.Fill;
						salesForCustomer.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesForCustomer salesForCustomer2 = new SalesForCustomer();
					this.Panel1.Controls.Add(salesForCustomer2);
					salesForCustomer2.Dock = DockStyle.Fill;
					salesForCustomer2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000DE1E8 File Offset: 0x000DC3E8
		private void SalesEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						new ViewPricesAvailability
						{
							toclose = 1
						}.Show();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					new ViewPricesAvailability
					{
						toclose = 1
					}.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x000DE2D8 File Offset: 0x000DC4D8
		private void SalesEnquiriesReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				EnquiriesReport enquiriesReport = new EnquiriesReport();
				this.Panel1.Controls.Add(enquiriesReport);
				enquiriesReport.Dock = DockStyle.Fill;
				enquiriesReport.BringToFront();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Enquiries Report form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TotalSalesForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x000DE348 File Offset: 0x000DC548
		private void GotoSalesMono(string sender_string)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender_string, this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							this.OpenSalesForm();
						}
						else
						{
							this.OpenSalesForm();
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
						this.OpenSalesForm();
					}
					else
					{
						this.OpenSalesForm();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000DE460 File Offset: 0x000DC660
		private void OpenSalesForm()
		{
			bool flag = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "EnablePacketSizes", MyProject.Forms.Form1.Constring), "1", false) == 0;
			if (flag)
			{
				Sales2monoPS sales2monoPS = new Sales2monoPS();
				this.Panel1.Controls.Add(sales2monoPS);
				sales2monoPS.Dock = DockStyle.Fill;
				sales2monoPS.BringToFront();
			}
			else
			{
				Sales2mono2 sales2mono = new Sales2mono2();
				this.Panel1.Controls.Add(sales2mono);
				sales2mono.Dock = DockStyle.Fill;
				sales2mono.BringToFront();
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000DE510 File Offset: 0x000DC710
		private void SalesMonoPaymentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.GotoSalesMono(sender.ToString());
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x000DE520 File Offset: 0x000DC720
		private void ViewStockPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewStockPurchases viewStockPurchases = new ViewStockPurchases();
						this.Panel1.Controls.Add(viewStockPurchases);
						viewStockPurchases.Dock = DockStyle.Fill;
						viewStockPurchases.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewStockPurchases viewStockPurchases2 = new ViewStockPurchases();
					this.Panel1.Controls.Add(viewStockPurchases2);
					viewStockPurchases2.Dock = DockStyle.Fill;
					viewStockPurchases2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000DE63C File Offset: 0x000DC83C
		private void SalesVsPurchasesForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesvsPurchases salesvsPurchases = new SalesvsPurchases();
						this.Panel1.Controls.Add(salesvsPurchases);
						salesvsPurchases.Dock = DockStyle.Fill;
						salesvsPurchases.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesvsPurchases salesvsPurchases2 = new SalesvsPurchases();
					this.Panel1.Controls.Add(salesvsPurchases2);
					salesvsPurchases2.Dock = DockStyle.Fill;
					salesvsPurchases2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000DE758 File Offset: 0x000DC958
		private void AccountPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						AccPayment accPayment = new AccPayment();
						accPayment.ShowDialog(this);
						accPayment.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					AccPayment accPayment2 = new AccPayment();
					accPayment2.ShowDialog(this);
					accPayment2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000DE84C File Offset: 0x000DCA4C
		private void StockBalancesWithBatchNumbersExpiryDatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockLevelsWarehouse stockLevelsWarehouse = new StockLevelsWarehouse();
						this.Panel1.Controls.Add(stockLevelsWarehouse);
						stockLevelsWarehouse.Dock = DockStyle.Fill;
						stockLevelsWarehouse.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockLevelsWarehouse stockLevelsWarehouse2 = new StockLevelsWarehouse();
					this.Panel1.Controls.Add(stockLevelsWarehouse2);
					stockLevelsWarehouse2.Dock = DockStyle.Fill;
					stockLevelsWarehouse2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000DE968 File Offset: 0x000DCB68
		private void ViewQuotationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				PendingInvoices pendingInvoices = new PendingInvoices();
				pendingInvoices.ShowDialog(this);
				pendingInvoices.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing quotations screen. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000DE9C4 File Offset: 0x000DCBC4
		private void PriceChangeAuditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						AuditPriceChanges auditPriceChanges = new AuditPriceChanges();
						auditPriceChanges.ShowDialog(this);
						auditPriceChanges.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					AuditPriceChanges auditPriceChanges2 = new AuditPriceChanges();
					auditPriceChanges2.ShowDialog(this);
					auditPriceChanges2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000DEAB8 File Offset: 0x000DCCB8
		private void loadMenuDAT()
		{
			try
			{
				this.menuDAT.Columns.Add("MenuItem");
				this.menuDAT.Columns.Add("MenuLevel");
				List<MainMenu.myMenuRow> list = new List<MainMenu.myMenuRow>();
				try
				{
					foreach (object obj in this.MenuStrip1.Items)
					{
						ToolStripItem toolStripItem = (ToolStripItem)obj;
						this.GetMenues(toolStripItem, ref list);
						this.menuLevel = 0;
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
					foreach (MainMenu.myMenuRow myMenuRow in list)
					{
						DataRow dataRow = this.menuDAT.NewRow();
						dataRow[0] = myMenuRow.menu_item;
						dataRow[1] = myMenuRow.menu_level;
						this.menuDAT.Rows.Add(dataRow);
					}
				}
				finally
				{
					List<MainMenu.myMenuRow>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.permissionsDAT = this.Publicfunction.GetAllowedPagesForUsername(MyProject.Forms.Form1.username, this._cnn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000DEC60 File Offset: 0x000DCE60
		public void GetMenues(ToolStripItem Current, ref List<MainMenu.myMenuRow> menues)
		{
			checked
			{
				this.menuLevel++;
				MainMenu.myMenuRow myMenuRow;
				myMenuRow.menu_item = (ToolStripMenuItem)Current;
				myMenuRow.menu_level = this.menuLevel;
				menues.Add(myMenuRow);
				bool flag = Current is ToolStripMenuItem;
				if (flag)
				{
					try
					{
						foreach (object obj in ((ToolStripMenuItem)Current).DropDownItems)
						{
							ToolStripItem toolStripItem = (ToolStripItem)obj;
							this.GetMenues(toolStripItem, ref menues);
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
					this.menuLevel--;
				}
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000DED18 File Offset: 0x000DCF18
		private void RoleManagementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						AC_SetRoles ac_SetRoles = new AC_SetRoles();
						ac_SetRoles.ShowDialog(this);
						ac_SetRoles.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					AC_SetRoles ac_SetRoles2 = new AC_SetRoles();
					ac_SetRoles2.ShowDialog(this);
					ac_SetRoles2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000DEE0C File Offset: 0x000DD00C
		private void UserPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						AC_UserPermissions ac_UserPermissions = new AC_UserPermissions();
						ac_UserPermissions.ShowDialog(this);
						ac_UserPermissions.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					AC_UserPermissions ac_UserPermissions2 = new AC_UserPermissions();
					ac_UserPermissions2.ShowDialog(this);
					ac_UserPermissions2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000DEF00 File Offset: 0x000DD100
		private void ProductImagesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						MyProject.Forms.ProductPics.Show();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					MyProject.Forms.ProductPics.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000DEFE8 File Offset: 0x000DD1E8
		private void ViewStockTransfersForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						StockTransfersForPeriod stockTransfersForPeriod = new StockTransfersForPeriod();
						stockTransfersForPeriod.ShowDialog(this);
						stockTransfersForPeriod.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockTransfersForPeriod stockTransfersForPeriod2 = new StockTransfersForPeriod();
					stockTransfersForPeriod2.ShowDialog(this);
					stockTransfersForPeriod2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000DF0CC File Offset: 0x000DD2CC
		private void CreateNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Suppliers suppliers = new Suppliers();
						suppliers.ShowDialog(this);
						suppliers.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Suppliers suppliers2 = new Suppliers();
					suppliers2.ShowDialog(this);
					suppliers2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000DF1C0 File Offset: 0x000DD3C0
		private void GoodsReceivedVoucherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						GoodsReveivedV goodsReveivedV = new GoodsReveivedV();
						this.Panel1.Controls.Add(goodsReveivedV);
						goodsReveivedV.Dock = DockStyle.Fill;
						goodsReveivedV.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					GoodsReveivedV goodsReveivedV2 = new GoodsReveivedV();
					this.Panel1.Controls.Add(goodsReveivedV2);
					goodsReveivedV2.Dock = DockStyle.Fill;
					goodsReveivedV2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000DF2DC File Offset: 0x000DD4DC
		private void PrintPurchaseReturnsForSupplierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PurchaseReturnsForSupplier purchaseReturnsForSupplier = new PurchaseReturnsForSupplier();
						this.Panel1.Controls.Add(purchaseReturnsForSupplier);
						purchaseReturnsForSupplier.Dock = DockStyle.Fill;
						purchaseReturnsForSupplier.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PurchaseReturnsForSupplier purchaseReturnsForSupplier2 = new PurchaseReturnsForSupplier();
					this.Panel1.Controls.Add(purchaseReturnsForSupplier2);
					purchaseReturnsForSupplier2.Dock = DockStyle.Fill;
					purchaseReturnsForSupplier2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000DF3F8 File Offset: 0x000DD5F8
		private void ConsignmentStockReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						ConsignmentReport consignmentReport = new ConsignmentReport();
						consignmentReport.ShowDialog(this);
						consignmentReport.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ConsignmentReport consignmentReport2 = new ConsignmentReport();
					consignmentReport2.ShowDialog(this);
					consignmentReport2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00002A30 File Offset: 0x00000C30
		private void PrintQuotationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000DF4DC File Offset: 0x000DD6DC
		private void EditProductBatchNumberAndExpiryDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
					if (flag2)
					{
						bool flag3 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
						if (flag3)
						{
							EditBatchNumbers editBatchNumbers = new EditBatchNumbers();
							editBatchNumbers.ShowDialog(this);
							editBatchNumbers.Dispose();
						}
						else
						{
							MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
						}
					}
					else
					{
						EditBatchNumbers editBatchNumbers2 = new EditBatchNumbers();
						editBatchNumbers2.ShowDialog(this);
						editBatchNumbers2.Dispose();
					}
				}
				else
				{
					MessageBox.Show("This shop is not a warehouse. Contact your system administrator.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x000DF5EC File Offset: 0x000DD7EC
		private void BatchNumberAndExpiryDateChangesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewBatchNumberChanges viewBatchNumberChanges = new ViewBatchNumberChanges();
						viewBatchNumberChanges.ShowDialog(this);
						viewBatchNumberChanges.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewBatchNumberChanges viewBatchNumberChanges2 = new ViewBatchNumberChanges();
					viewBatchNumberChanges2.ShowDialog(this);
					viewBatchNumberChanges2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000DF6E0 File Offset: 0x000DD8E0
		private void PriceListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PriceList priceList = new PriceList();
						priceList.ShowDialog(this);
						priceList.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PriceList priceList2 = new PriceList();
					priceList2.ShowDialog(this);
					priceList2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000DF7D4 File Offset: 0x000DD9D4
		private void CreateConversionFormulaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ProductRecipies productRecipies = new ProductRecipies();
						this.Panel1.Controls.Add(productRecipies);
						productRecipies.Dock = DockStyle.Fill;
						productRecipies.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ProductRecipies productRecipies2 = new ProductRecipies();
					this.Panel1.Controls.Add(productRecipies2);
					productRecipies2.Dock = DockStyle.Fill;
					productRecipies2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000DF8F0 File Offset: 0x000DDAF0
		private void MakeProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Make_Product make_Product = new Make_Product();
						make_Product.ShowDialog(this);
						make_Product.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Make_Product make_Product2 = new Make_Product();
					make_Product2.ShowDialog(this);
					make_Product2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000DF9E4 File Offset: 0x000DDBE4
		private void CreatePromotionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PromotionCreate promotionCreate = new PromotionCreate();
						this.Panel1.Controls.Add(promotionCreate);
						promotionCreate.Dock = DockStyle.Fill;
						promotionCreate.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PromotionCreate promotionCreate2 = new PromotionCreate();
					this.Panel1.Controls.Add(promotionCreate2);
					promotionCreate2.Dock = DockStyle.Fill;
					promotionCreate2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000DFB00 File Offset: 0x000DDD00
		private void ViewPromotionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PromotionsView promotionsView = new PromotionsView();
						promotionsView.ShowDialog(this);
						promotionsView.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PromotionsView promotionsView2 = new PromotionsView();
					promotionsView2.ShowDialog(this);
					promotionsView2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000DFBF4 File Offset: 0x000DDDF4
		private void PrintStockSheetsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							StockSheetsWarehouse stockSheetsWarehouse = new StockSheetsWarehouse();
							stockSheetsWarehouse.ShowDialog(this);
							stockSheetsWarehouse.Dispose();
						}
						else
						{
							StockSheets stockSheets = new StockSheets();
							this.Panel1.Controls.Add(stockSheets);
							stockSheets.Dock = DockStyle.Fill;
							stockSheets.BringToFront();
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
						StockSheetsWarehouse stockSheetsWarehouse2 = new StockSheetsWarehouse();
						stockSheetsWarehouse2.ShowDialog(this);
						stockSheetsWarehouse2.Dispose();
					}
					else
					{
						StockSheets stockSheets2 = new StockSheets();
						this.Panel1.Controls.Add(stockSheets2);
						stockSheets2.Dock = DockStyle.Fill;
						stockSheets2.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x000DFD88 File Offset: 0x000DDF88
		private void EnterStockTakeFiguresToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							StockTakeWarehouse stockTakeWarehouse = new StockTakeWarehouse();
							stockTakeWarehouse.ShowDialog(this);
							stockTakeWarehouse.Dispose();
						}
						else
						{
							StockTake stockTake = new StockTake();
							stockTake.ShowDialog(this);
							stockTake.Dispose();
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
						StockTakeWarehouse stockTakeWarehouse2 = new StockTakeWarehouse();
						stockTakeWarehouse2.ShowDialog(this);
						stockTakeWarehouse2.Dispose();
					}
					else
					{
						StockTake stockTake2 = new StockTake();
						stockTake2.ShowDialog(this);
						stockTake2.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x000DFEF4 File Offset: 0x000DE0F4
		private void PrintStockSheetsToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							StockSheetsWarehouse stockSheetsWarehouse = new StockSheetsWarehouse();
							stockSheetsWarehouse.ShowDialog(this);
							stockSheetsWarehouse.Dispose();
						}
						else
						{
							StockSheets stockSheets = new StockSheets();
							this.Panel1.Controls.Add(stockSheets);
							stockSheets.Dock = DockStyle.Fill;
							stockSheets.BringToFront();
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
						StockSheetsWarehouse stockSheetsWarehouse2 = new StockSheetsWarehouse();
						stockSheetsWarehouse2.ShowDialog(this);
						stockSheetsWarehouse2.Dispose();
					}
					else
					{
						StockSheets stockSheets2 = new StockSheets();
						this.Panel1.Controls.Add(stockSheets2);
						stockSheets2.Dock = DockStyle.Fill;
						stockSheets2.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x000E0088 File Offset: 0x000DE288
		private void EnterCummulativeStockTakeFiguresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					MessageBox.Show("Please use the simple Stock Take form not cumulative.");
				}
				else
				{
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
					if (flag2)
					{
						bool flag3 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
						if (flag3)
						{
							bool flag4 = MyProject.Forms.Form1.IsWarehouse == 1;
							if (flag4)
							{
								StockTakeCumulative stockTakeCumulative = new StockTakeCumulative();
								stockTakeCumulative.ShowDialog(this);
								stockTakeCumulative.Dispose();
							}
							else
							{
								StockTakeCumulative stockTakeCumulative2 = new StockTakeCumulative();
								stockTakeCumulative2.ShowDialog(this);
								stockTakeCumulative2.Dispose();
							}
						}
						else
						{
							MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
						}
					}
					else
					{
						bool flag5 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag5)
						{
							StockTakeCumulative stockTakeCumulative3 = new StockTakeCumulative();
							stockTakeCumulative3.ShowDialog(this);
							stockTakeCumulative3.Dispose();
						}
						else
						{
							StockTakeCumulative stockTakeCumulative4 = new StockTakeCumulative();
							stockTakeCumulative4.ShowDialog(this);
							stockTakeCumulative4.Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x000E0220 File Offset: 0x000DE420
		private void EditBatchNumbersAndExpiryDate2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
						if (flag3)
						{
							ChangeExpiryDate changeExpiryDate = new ChangeExpiryDate();
							changeExpiryDate.ShowDialog(this);
							changeExpiryDate.Dispose();
						}
						else
						{
							MessageBox.Show("Your system is not configured for Batch Numbers and Expiry Dates");
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
						ChangeExpiryDate changeExpiryDate2 = new ChangeExpiryDate();
						changeExpiryDate2.ShowDialog(this);
						changeExpiryDate2.Dispose();
					}
					else
					{
						MessageBox.Show("Your system is not configured for Batch Numbers and Expiry Dates");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x000E0374 File Offset: 0x000DE574
		private void BREAKProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						BreakProduct breakProduct = new BreakProduct();
						breakProduct.ShowDialog(this);
						breakProduct.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					BreakProduct breakProduct2 = new BreakProduct();
					breakProduct2.ShowDialog(this);
					breakProduct2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00002A30 File Offset: 0x00000C30
		private void CreditNotePerProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x000E0468 File Offset: 0x000DE668
		private void GenerateCreditNoteForProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CreditNote2 creditNote = new CreditNote2();
						creditNote.ShowDialog(this);
						creditNote.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CreditNote2 creditNote2 = new CreditNote2();
					creditNote2.ShowDialog(this);
					creditNote2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x000E055C File Offset: 0x000DE75C
		private void ViewCancelCreditNotesForProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewProductCreditNotes viewProductCreditNotes = new ViewProductCreditNotes();
						viewProductCreditNotes.ShowDialog(this);
						viewProductCreditNotes.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewProductCreditNotes viewProductCreditNotes2 = new ViewProductCreditNotes();
					viewProductCreditNotes2.ShowDialog(this);
					viewProductCreditNotes2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x000E0650 File Offset: 0x000DE850
		private void SalesByConsultantReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesForConsultant salesForConsultant = new SalesForConsultant();
						this.Panel1.Controls.Add(salesForConsultant);
						salesForConsultant.Dock = DockStyle.Fill;
						salesForConsultant.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesForConsultant salesForConsultant2 = new SalesForConsultant();
					this.Panel1.Controls.Add(salesForConsultant2);
					salesForConsultant2.Dock = DockStyle.Fill;
					salesForConsultant2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000E076C File Offset: 0x000DE96C
		private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
				MyProject.Forms.Form1.Show();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x000E07B4 File Offset: 0x000DE9B4
		private void ChangePricesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						BranchPrices branchPrices = new BranchPrices();
						branchPrices.ShowDialog(this);
						branchPrices.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					BranchPrices branchPrices2 = new BranchPrices();
					branchPrices2.ShowDialog(this);
					branchPrices2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000E08A8 File Offset: 0x000DEAA8
		private void StockBalancesForBranchByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockBalanceReportByCategory stockBalanceReportByCategory = new StockBalanceReportByCategory();
						this.Panel1.Controls.Add(stockBalanceReportByCategory);
						stockBalanceReportByCategory.Dock = DockStyle.Fill;
						stockBalanceReportByCategory.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockBalanceReportByCategory stockBalanceReportByCategory2 = new StockBalanceReportByCategory();
					this.Panel1.Controls.Add(stockBalanceReportByCategory2);
					stockBalanceReportByCategory2.Dock = DockStyle.Fill;
					stockBalanceReportByCategory2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x000E09C4 File Offset: 0x000DEBC4
		private void PurchasesBySupplierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SupplierDeliveries supplierDeliveries = new SupplierDeliveries();
						this.Panel1.Controls.Add(supplierDeliveries);
						supplierDeliveries.Dock = DockStyle.Fill;
						supplierDeliveries.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SupplierDeliveries supplierDeliveries2 = new SupplierDeliveries();
					this.Panel1.Controls.Add(supplierDeliveries2);
					supplierDeliveries2.Dock = DockStyle.Fill;
					supplierDeliveries2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000E0AE0 File Offset: 0x000DECE0
		private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x000E0B28 File Offset: 0x000DED28
		private void LoginsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Logins logins = new Logins();
						logins.ShowDialog(this);
						logins.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Logins logins2 = new Logins();
					logins2.ShowDialog(this);
					logins2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000E0C1C File Offset: 0x000DEE1C
		private void PaymentMethodBasedDiscountsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PaymentMethodDiscount paymentMethodDiscount = new PaymentMethodDiscount();
						this.Panel1.Controls.Add(paymentMethodDiscount);
						paymentMethodDiscount.Dock = DockStyle.Fill;
						paymentMethodDiscount.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PaymentMethodDiscount paymentMethodDiscount2 = new PaymentMethodDiscount();
					this.Panel1.Controls.Add(paymentMethodDiscount2);
					paymentMethodDiscount2.Dock = DockStyle.Fill;
					paymentMethodDiscount2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000E0D38 File Offset: 0x000DEF38
		private void DiscountsGivenForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DiscountsGiven discountsGiven = new DiscountsGiven();
						this.Panel1.Controls.Add(discountsGiven);
						discountsGiven.Dock = DockStyle.Fill;
						discountsGiven.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DiscountsGiven discountsGiven2 = new DiscountsGiven();
					this.Panel1.Controls.Add(discountsGiven2);
					discountsGiven2.Dock = DockStyle.Fill;
					discountsGiven2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000E0E54 File Offset: 0x000DF054
		private void FIFOStockAgingReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockAging stockAging = new StockAging();
						stockAging.ShowDialog(this);
						stockAging.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockAging stockAging2 = new StockAging();
					stockAging2.ShowDialog(this);
					stockAging2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000E0F48 File Offset: 0x000DF148
		private void ViewUpdateCollectionsDeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Collections collections = new Collections();
						collections.ShowDialog(this);
						collections.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Collections collections2 = new Collections();
					collections2.ShowDialog(this);
					collections2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000E103C File Offset: 0x000DF23C
		private void EnterOrCollectFloatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						FloatManagement floatManagement = new FloatManagement();
						floatManagement.ShowDialog(this);
						floatManagement.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					FloatManagement floatManagement2 = new FloatManagement();
					floatManagement2.ShowDialog(this);
					floatManagement2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x000E1130 File Offset: 0x000DF330
		private void EnterEndOfDayCashInBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CS_EODEnter cs_EODEnter = new CS_EODEnter();
						cs_EODEnter.ShowDialog(this);
						cs_EODEnter.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CS_EODEnter cs_EODEnter2 = new CS_EODEnter();
					cs_EODEnter2.ShowDialog(this);
					cs_EODEnter2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000E1224 File Offset: 0x000DF424
		private void WaiterTipsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewEditTips viewEditTips = new ViewEditTips();
						this.Panel1.Controls.Add(viewEditTips);
						viewEditTips.Dock = DockStyle.Fill;
						viewEditTips.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewEditTips viewEditTips2 = new ViewEditTips();
					this.Panel1.Controls.Add(viewEditTips2);
					viewEditTips2.Dock = DockStyle.Fill;
					viewEditTips2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000E1340 File Offset: 0x000DF540
		private void SetInvoiceDiscountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SetDiscountPercentage setDiscountPercentage = new SetDiscountPercentage();
						setDiscountPercentage.ShowDialog(this);
						setDiscountPercentage.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SetDiscountPercentage setDiscountPercentage2 = new SetDiscountPercentage();
					setDiscountPercentage2.ShowDialog(this);
					setDiscountPercentage2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x000E1434 File Offset: 0x000DF634
		private void ProductDiscountsForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PriceChangesReport2 priceChangesReport = new PriceChangesReport2();
						priceChangesReport.ShowDialog(this);
						priceChangesReport.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PriceChangesReport2 priceChangesReport2 = new PriceChangesReport2();
					priceChangesReport2.ShowDialog(this);
					priceChangesReport2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000E1528 File Offset: 0x000DF728
		private void ProductsConvertedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ProductsConverted productsConverted = new ProductsConverted();
						this.Panel1.Controls.Add(productsConverted);
						productsConverted.Dock = DockStyle.Fill;
						productsConverted.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ProductsConverted productsConverted2 = new ProductsConverted();
					this.Panel1.Controls.Add(productsConverted2);
					productsConverted2.Dock = DockStyle.Fill;
					productsConverted2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000E1644 File Offset: 0x000DF844
		private void PrintProductFormulaReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						FormulaReport formulaReport = new FormulaReport();
						formulaReport.ShowDialog(this);
						formulaReport.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					FormulaReport formulaReport2 = new FormulaReport();
					formulaReport2.ShowDialog(this);
					formulaReport2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000E1738 File Offset: 0x000DF938
		private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						BillingTerms billingTerms = new BillingTerms();
						billingTerms.ShowDialog(this);
						billingTerms.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					BillingTerms billingTerms2 = new BillingTerms();
					billingTerms2.ShowDialog(this);
					billingTerms2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000E182C File Offset: 0x000DFA2C
		private void ViewStockPurchasesForProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockPurchasesforProduct stockPurchasesforProduct = new StockPurchasesforProduct();
						stockPurchasesforProduct.ShowDialog(this);
						stockPurchasesforProduct.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockPurchasesforProduct stockPurchasesforProduct2 = new StockPurchasesforProduct();
					stockPurchasesforProduct2.ShowDialog(this);
					stockPurchasesforProduct2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000E1920 File Offset: 0x000DFB20
		private void MenuStrip1_Click(object sender, EventArgs e)
		{
			this.DisposeResources();
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000E192C File Offset: 0x000DFB2C
		private void LoadEconetVouchersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						EconetVoucherUpload econetVoucherUpload = new EconetVoucherUpload();
						econetVoucherUpload.ShowDialog(this);
						econetVoucherUpload.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EconetVoucherUpload econetVoucherUpload2 = new EconetVoucherUpload();
					econetVoucherUpload2.ShowDialog(this);
					econetVoucherUpload2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000E1A20 File Offset: 0x000DFC20
		private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CustomerDetails customerDetails = new CustomerDetails();
						this.Panel1.Controls.Add(customerDetails);
						customerDetails.Dock = DockStyle.Fill;
						customerDetails.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CustomerDetails customerDetails2 = new CustomerDetails();
					this.Panel1.Controls.Add(customerDetails2);
					customerDetails2.Dock = DockStyle.Fill;
					customerDetails2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000E1B3C File Offset: 0x000DFD3C
		private void LinkProductToSideMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SetCategorySideMenus setCategorySideMenus = new SetCategorySideMenus();
						setCategorySideMenus.ShowDialog(this);
						setCategorySideMenus.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SetCategorySideMenus setCategorySideMenus2 = new SetCategorySideMenus();
					setCategorySideMenus2.ShowDialog(this);
					setCategorySideMenus2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000E1C30 File Offset: 0x000DFE30
		private void EnterStockTakeFiguresExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockTakeExcel stockTakeExcel = new StockTakeExcel();
						stockTakeExcel.ShowDialog(this);
						stockTakeExcel.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockTakeExcel stockTakeExcel2 = new StockTakeExcel();
					stockTakeExcel2.ShowDialog(this);
					stockTakeExcel2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x000E1D24 File Offset: 0x000DFF24
		private void ViewUpdateCollectionsDeliveriesForCustomerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CollectionsByCustomer collectionsByCustomer = new CollectionsByCustomer();
						collectionsByCustomer.ShowDialog(this);
						collectionsByCustomer.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CollectionsByCustomer collectionsByCustomer2 = new CollectionsByCustomer();
					collectionsByCustomer2.ShowDialog(this);
					collectionsByCustomer2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00002A30 File Offset: 0x00000C30
		private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000E1E18 File Offset: 0x000E0018
		private void CollectionDeliveryByCustomerReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CollectionsByCustomerReport collectionsByCustomerReport = new CollectionsByCustomerReport();
						collectionsByCustomerReport.ShowDialog(this);
						collectionsByCustomerReport.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CollectionsByCustomerReport collectionsByCustomerReport2 = new CollectionsByCustomerReport();
					collectionsByCustomerReport2.ShowDialog(this);
					collectionsByCustomerReport2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000E1F0C File Offset: 0x000E010C
		private void CollectionDeliveryProductBalancesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CollectionsProductBals collectionsProductBals = new CollectionsProductBals();
						this.Panel1.Controls.Add(collectionsProductBals);
						collectionsProductBals.Dock = DockStyle.Fill;
						collectionsProductBals.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CollectionsProductBals collectionsProductBals2 = new CollectionsProductBals();
					this.Panel1.Controls.Add(collectionsProductBals2);
					collectionsProductBals2.Dock = DockStyle.Fill;
					collectionsProductBals2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000E2028 File Offset: 0x000E0228
		private void RestrictProductCategoriesForUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						RestrictUserCategories restrictUserCategories = new RestrictUserCategories();
						restrictUserCategories.ShowDialog(this);
						restrictUserCategories.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					RestrictUserCategories restrictUserCategories2 = new RestrictUserCategories();
					restrictUserCategories2.ShowDialog(this);
					restrictUserCategories2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000E211C File Offset: 0x000E031C
		private void ApproveDenyProductChangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Approvals approvals = new Approvals();
						this.Panel1.Controls.Add(approvals);
						approvals.Dock = DockStyle.Fill;
						approvals.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Approvals approvals2 = new Approvals();
					this.Panel1.Controls.Add(approvals2);
					approvals2.Dock = DockStyle.Fill;
					approvals2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000E2238 File Offset: 0x000E0438
		private void BookingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Bookings bookings = new Bookings();
						this.Panel1.Controls.Add(bookings);
						bookings.Dock = DockStyle.Fill;
						bookings.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Bookings bookings2 = new Bookings();
					this.Panel1.Controls.Add(bookings2);
					bookings2.Dock = DockStyle.Fill;
					bookings2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000E2354 File Offset: 0x000E0554
		private void CheckInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						InvoiceCheck invoiceCheck = new InvoiceCheck();
						this.Panel1.Controls.Add(invoiceCheck);
						invoiceCheck.Dock = DockStyle.Fill;
						invoiceCheck.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					InvoiceCheck invoiceCheck2 = new InvoiceCheck();
					this.Panel1.Controls.Add(invoiceCheck2);
					invoiceCheck2.Dock = DockStyle.Fill;
					invoiceCheck2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000E2470 File Offset: 0x000E0670
		private void HighestMoversBySalesContributionReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockMovementSales stockMovementSales = new StockMovementSales();
						this.Panel1.Controls.Add(stockMovementSales);
						stockMovementSales.Dock = DockStyle.Fill;
						stockMovementSales.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockMovementSales stockMovementSales2 = new StockMovementSales();
					this.Panel1.Controls.Add(stockMovementSales2);
					stockMovementSales2.Dock = DockStyle.Fill;
					stockMovementSales2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000E258C File Offset: 0x000E078C
		private void ChangeProductSupplierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						EditProductSupplier editProductSupplier = new EditProductSupplier();
						editProductSupplier.ShowDialog(this);
						editProductSupplier.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EditProductSupplier editProductSupplier2 = new EditProductSupplier();
					editProductSupplier2.ShowDialog(this);
					editProductSupplier2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000E2680 File Offset: 0x000E0880
		private void StockBalancesBySupplierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockBalancesBySupplier stockBalancesBySupplier = new StockBalancesBySupplier();
						this.Panel1.Controls.Add(stockBalancesBySupplier);
						stockBalancesBySupplier.Dock = DockStyle.Fill;
						stockBalancesBySupplier.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockBalancesBySupplier stockBalancesBySupplier2 = new StockBalancesBySupplier();
					this.Panel1.Controls.Add(stockBalancesBySupplier2);
					stockBalancesBySupplier2.Dock = DockStyle.Fill;
					stockBalancesBySupplier2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000E279C File Offset: 0x000E099C
		private void HighestMoversBySalesForSupplierForBranchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockMvtBySupplier stockMvtBySupplier = new StockMvtBySupplier();
						this.Panel1.Controls.Add(stockMvtBySupplier);
						stockMvtBySupplier.Dock = DockStyle.Fill;
						stockMvtBySupplier.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockMvtBySupplier stockMvtBySupplier2 = new StockMvtBySupplier();
					this.Panel1.Controls.Add(stockMvtBySupplier2);
					stockMvtBySupplier2.Dock = DockStyle.Fill;
					stockMvtBySupplier2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000E28B8 File Offset: 0x000E0AB8
		private void EditProductCaseParentChildSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						EditProductCaseSettings editProductCaseSettings = new EditProductCaseSettings();
						this.Panel1.Controls.Add(editProductCaseSettings);
						editProductCaseSettings.Dock = DockStyle.Fill;
						editProductCaseSettings.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					EditProductCaseSettings editProductCaseSettings2 = new EditProductCaseSettings();
					this.Panel1.Controls.Add(editProductCaseSettings2);
					editProductCaseSettings2.Dock = DockStyle.Fill;
					editProductCaseSettings2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000E29D4 File Offset: 0x000E0BD4
		private void VEHICLETRIPSBILLINGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						TripMgt tripMgt = new TripMgt();
						this.Panel1.Controls.Add(tripMgt);
						tripMgt.Dock = DockStyle.Fill;
						tripMgt.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					TripMgt tripMgt2 = new TripMgt();
					this.Panel1.Controls.Add(tripMgt2);
					tripMgt2.Dock = DockStyle.Fill;
					tripMgt2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000E2AF0 File Offset: 0x000E0CF0
		private void PerformanceReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PerformanceReport performanceReport = new PerformanceReport();
						this.Panel1.Controls.Add(performanceReport);
						performanceReport.Dock = DockStyle.Fill;
						performanceReport.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PerformanceReport performanceReport2 = new PerformanceReport();
					this.Panel1.Controls.Add(performanceReport2);
					performanceReport2.Dock = DockStyle.Fill;
					performanceReport2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000E2C0C File Offset: 0x000E0E0C
		private void PrintQuotationsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						PrintQuotation printQuotation = new PrintQuotation();
						printQuotation.ShowDialog(this);
						printQuotation.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PrintQuotation printQuotation2 = new PrintQuotation();
					printQuotation2.ShowDialog(this);
					printQuotation2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000E2CF0 File Offset: 0x000E0EF0
		private void ViewQuotationsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						ViewQuotations viewQuotations = new ViewQuotations();
						this.Panel1.Controls.Add(viewQuotations);
						viewQuotations.Dock = DockStyle.Fill;
						viewQuotations.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					ViewQuotations viewQuotations2 = new ViewQuotations();
					this.Panel1.Controls.Add(viewQuotations2);
					viewQuotations2.Dock = DockStyle.Fill;
					viewQuotations2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000E2E0C File Offset: 0x000E100C
		private void QuotationsConvertedToInvoicesReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Quotations_Invoices_Report quotations_Invoices_Report = new Quotations_Invoices_Report();
						this.Panel1.Controls.Add(quotations_Invoices_Report);
						quotations_Invoices_Report.Dock = DockStyle.Fill;
						quotations_Invoices_Report.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Quotations_Invoices_Report quotations_Invoices_Report2 = new Quotations_Invoices_Report();
					this.Panel1.Controls.Add(quotations_Invoices_Report2);
					quotations_Invoices_Report2.Dock = DockStyle.Fill;
					quotations_Invoices_Report2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000E2F28 File Offset: 0x000E1128
		private void SalesByCategoryByUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesByCategoryAndUser salesByCategoryAndUser = new SalesByCategoryAndUser();
						this.Panel1.Controls.Add(salesByCategoryAndUser);
						salesByCategoryAndUser.Dock = DockStyle.Fill;
						salesByCategoryAndUser.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesByCategoryAndUser salesByCategoryAndUser2 = new SalesByCategoryAndUser();
					this.Panel1.Controls.Add(salesByCategoryAndUser2);
					salesByCategoryAndUser2.Dock = DockStyle.Fill;
					salesByCategoryAndUser2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000E3044 File Offset: 0x000E1244
		private void SalesForProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesForProduct salesForProduct = new SalesForProduct();
						this.Panel1.Controls.Add(salesForProduct);
						salesForProduct.Dock = DockStyle.Fill;
						salesForProduct.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesForProduct salesForProduct2 = new SalesForProduct();
					this.Panel1.Controls.Add(salesForProduct2);
					salesForProduct2.Dock = DockStyle.Fill;
					salesForProduct2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x000E3160 File Offset: 0x000E1360
		private void EmailSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SetEmailSettings setEmailSettings = new SetEmailSettings();
						this.Panel1.Controls.Add(setEmailSettings);
						setEmailSettings.Dock = DockStyle.Fill;
						setEmailSettings.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SetEmailSettings setEmailSettings2 = new SetEmailSettings();
					this.Panel1.Controls.Add(setEmailSettings2);
					setEmailSettings2.Dock = DockStyle.Fill;
					setEmailSettings2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000E327C File Offset: 0x000E147C
		private void ADFSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						R_SalesReport r_SalesReport = new R_SalesReport();
						r_SalesReport.ShowDialog(this);
						r_SalesReport.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					R_SalesReport r_SalesReport2 = new R_SalesReport();
					r_SalesReport2.ShowDialog(this);
					r_SalesReport2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x000E3360 File Offset: 0x000E1560
		private void ADFSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						FrmADF_SalesPurchases3 frmADF_SalesPurchases = new FrmADF_SalesPurchases3();
						frmADF_SalesPurchases.ShowDialog(this);
						frmADF_SalesPurchases.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					FrmADF_SalesPurchases3 frmADF_SalesPurchases2 = new FrmADF_SalesPurchases3();
					frmADF_SalesPurchases2.ShowDialog(this);
					frmADF_SalesPurchases2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000E3444 File Offset: 0x000E1644
		private void CreditorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SupplierAccounts supplierAccounts = new SupplierAccounts();
						this.Panel1.Controls.Add(supplierAccounts);
						supplierAccounts.Dock = DockStyle.Fill;
						supplierAccounts.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SupplierAccounts supplierAccounts2 = new SupplierAccounts();
					this.Panel1.Controls.Add(supplierAccounts2);
					supplierAccounts2.Dock = DockStyle.Fill;
					supplierAccounts2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000E3560 File Offset: 0x000E1760
		private void DebtorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						AccPayment accPayment = new AccPayment();
						accPayment.ShowDialog(this);
						accPayment.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					AccPayment accPayment2 = new AccPayment();
					accPayment2.ShowDialog(this);
					accPayment2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000E3654 File Offset: 0x000E1854
		private void SalesForPeriodInvoiceNumbersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesByInvoice salesByInvoice = new SalesByInvoice();
						salesByInvoice.ShowDialog(this);
						salesByInvoice.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesByInvoice salesByInvoice2 = new SalesByInvoice();
					salesByInvoice2.ShowDialog(this);
					salesByInvoice2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000E3748 File Offset: 0x000E1948
		private void SALESFORCOMPANYToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesForCompany salesForCompany = new SalesForCompany();
						this.Panel1.Controls.Add(salesForCompany);
						salesForCompany.Dock = DockStyle.Fill;
						salesForCompany.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesForCompany salesForCompany2 = new SalesForCompany();
					this.Panel1.Controls.Add(salesForCompany2);
					salesForCompany2.Dock = DockStyle.Fill;
					salesForCompany2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000E3864 File Offset: 0x000E1A64
		private void ImportSalesCSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CSVSales csvsales = new CSVSales();
						this.Panel1.Controls.Add(csvsales);
						csvsales.Dock = DockStyle.Fill;
						csvsales.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CSVSales csvsales2 = new CSVSales();
					this.Panel1.Controls.Add(csvsales2);
					csvsales2.Dock = DockStyle.Fill;
					csvsales2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000E3980 File Offset: 0x000E1B80
		private void OneProductStockTakeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockTake1Item stockTake1Item = new StockTake1Item();
						stockTake1Item.ShowDialog(this);
						stockTake1Item.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockTake1Item stockTake1Item2 = new StockTake1Item();
					stockTake1Item2.ShowDialog(this);
					stockTake1Item2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000E3A74 File Offset: 0x000E1C74
		private void BulkStockEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						BulkStockEntry bulkStockEntry = new BulkStockEntry();
						bulkStockEntry.ShowDialog(this);
						bulkStockEntry.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					BulkStockEntry bulkStockEntry2 = new BulkStockEntry();
					bulkStockEntry2.ShowDialog(this);
					bulkStockEntry2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000E3B68 File Offset: 0x000E1D68
		private void SalesForPeriodByPaymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesByPaymentMethod salesByPaymentMethod = new SalesByPaymentMethod();
						this.Panel1.Controls.Add(salesByPaymentMethod);
						salesByPaymentMethod.Dock = DockStyle.Fill;
						salesByPaymentMethod.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesByPaymentMethod salesByPaymentMethod2 = new SalesByPaymentMethod();
					this.Panel1.Controls.Add(salesByPaymentMethod2);
					salesByPaymentMethod2.Dock = DockStyle.Fill;
					salesByPaymentMethod2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000E3C84 File Offset: 0x000E1E84
		private void StockTransfersInForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						StockTransfersForPeriodFrom stockTransfersForPeriodFrom = new StockTransfersForPeriodFrom();
						stockTransfersForPeriodFrom.ShowDialog(this);
						stockTransfersForPeriodFrom.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					StockTransfersForPeriodFrom stockTransfersForPeriodFrom2 = new StockTransfersForPeriodFrom();
					stockTransfersForPeriodFrom2.ShowDialog(this);
					stockTransfersForPeriodFrom2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x000E3D78 File Offset: 0x000E1F78
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				TestConnectedScale testConnectedScale = new TestConnectedScale();
				testConnectedScale.ShowDialog(this);
				testConnectedScale.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000E3DD4 File Offset: 0x000E1FD4
		private void SetHSCodesForProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SetHSCodes setHSCodes = new SetHSCodes();
						setHSCodes.ShowDialog(this);
						setHSCodes.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SetHSCodes setHSCodes2 = new SetHSCodes();
					setHSCodes2.ShowDialog(this);
					setHSCodes2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x000E3EC8 File Offset: 0x000E20C8
		private void CheckInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						RepairsIn repairsIn = new RepairsIn();
						this.Panel1.Controls.Add(repairsIn);
						repairsIn.Dock = DockStyle.Fill;
						repairsIn.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					RepairsIn repairsIn2 = new RepairsIn();
					this.Panel1.Controls.Add(repairsIn2);
					repairsIn2.Dock = DockStyle.Fill;
					repairsIn2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000E3FE4 File Offset: 0x000E21E4
		private void ViewAndCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						RepairsView repairsView = new RepairsView();
						this.Panel1.Controls.Add(repairsView);
						repairsView.Dock = DockStyle.Fill;
						repairsView.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					RepairsView repairsView2 = new RepairsView();
					this.Panel1.Controls.Add(repairsView2);
					repairsView2.Dock = DockStyle.Fill;
					repairsView2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000E4100 File Offset: 0x000E2300
		private void ViewDeletedProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DeletedProducts deletedProducts = new DeletedProducts();
						this.Panel1.Controls.Add(deletedProducts);
						deletedProducts.Dock = DockStyle.Fill;
						deletedProducts.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DeletedProducts deletedProducts2 = new DeletedProducts();
					this.Panel1.Controls.Add(deletedProducts2);
					deletedProducts2.Dock = DockStyle.Fill;
					deletedProducts2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000E421C File Offset: 0x000E241C
		private void SearchInvoiceCommentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SearchComments searchComments = new SearchComments();
						searchComments.ShowDialog(this);
						searchComments.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SearchComments searchComments2 = new SearchComments();
					searchComments2.ShowDialog(this);
					searchComments2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x000E4310 File Offset: 0x000E2510
		private void KkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						SalesByInvoice2 salesByInvoice = new SalesByInvoice2();
						this.Panel1.Controls.Add(salesByInvoice);
						salesByInvoice.Dock = DockStyle.Fill;
						salesByInvoice.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesByInvoice2 salesByInvoice2 = new SalesByInvoice2();
					this.Panel1.Controls.Add(salesByInvoice2);
					salesByInvoice2.Dock = DockStyle.Fill;
					salesByInvoice2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000E442C File Offset: 0x000E262C
		private void KitchenDisplayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						KitchenDisplay kitchenDisplay = new KitchenDisplay();
						kitchenDisplay.ShowDialog(this);
						kitchenDisplay.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					KitchenDisplay kitchenDisplay2 = new KitchenDisplay();
					kitchenDisplay2.ShowDialog(this);
					kitchenDisplay2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000E4520 File Offset: 0x000E2720
		private void EnterDespatchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						Despatch despatch = new Despatch();
						this.Panel1.Controls.Add(despatch);
						despatch.Dock = DockStyle.Fill;
						despatch.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					Despatch despatch2 = new Despatch();
					this.Panel1.Controls.Add(despatch2);
					despatch2.Dock = DockStyle.Fill;
					despatch2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000E463C File Offset: 0x000E283C
		private void ViewCancelDespatchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DespatchViewCancel despatchViewCancel = new DespatchViewCancel();
						this.Panel1.Controls.Add(despatchViewCancel);
						despatchViewCancel.Dock = DockStyle.Fill;
						despatchViewCancel.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DespatchViewCancel despatchViewCancel2 = new DespatchViewCancel();
					this.Panel1.Controls.Add(despatchViewCancel2);
					despatchViewCancel2.Dock = DockStyle.Fill;
					despatchViewCancel2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x000E4758 File Offset: 0x000E2958
		private void DespatchReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DespatchReportForPeriod despatchReportForPeriod = new DespatchReportForPeriod();
						this.Panel1.Controls.Add(despatchReportForPeriod);
						despatchReportForPeriod.Dock = DockStyle.Fill;
						despatchReportForPeriod.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DespatchReportForPeriod despatchReportForPeriod2 = new DespatchReportForPeriod();
					this.Panel1.Controls.Add(despatchReportForPeriod2);
					despatchReportForPeriod2.Dock = DockStyle.Fill;
					despatchReportForPeriod2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000E4874 File Offset: 0x000E2A74
		private void DesptachesForPeriodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DespatchReportForPeriod despatchReportForPeriod = new DespatchReportForPeriod();
						this.Panel1.Controls.Add(despatchReportForPeriod);
						despatchReportForPeriod.Dock = DockStyle.Fill;
						despatchReportForPeriod.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DespatchReportForPeriod despatchReportForPeriod2 = new DespatchReportForPeriod();
					this.Panel1.Controls.Add(despatchReportForPeriod2);
					despatchReportForPeriod2.Dock = DockStyle.Fill;
					despatchReportForPeriod2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000E4990 File Offset: 0x000E2B90
		private void DespatchesForCustomerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						DespatchForCustomer despatchForCustomer = new DespatchForCustomer();
						this.Panel1.Controls.Add(despatchForCustomer);
						despatchForCustomer.Dock = DockStyle.Fill;
						despatchForCustomer.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					DespatchForCustomer despatchForCustomer2 = new DespatchForCustomer();
					this.Panel1.Controls.Add(despatchForCustomer2);
					despatchForCustomer2.Dock = DockStyle.Fill;
					despatchForCustomer2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000E4AAC File Offset: 0x000E2CAC
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			try
			{
				bool flag = msg.WParam.ToInt32() == 116;
				if (flag)
				{
					this.lblHotKeys.Visible = false;
					this.GotoSalesMono("Enter Sales");
				}
				else
				{
					bool flag2 = msg.WParam.ToInt32() == 117;
					if (flag2)
					{
						try
						{
							this.lblHotKeys.Visible = false;
							bool flag3 = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
							if (flag3)
							{
								bool flag4 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, "Enter Sales - TOUCH", this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
								if (flag4)
								{
									SalesTouchScreen salesTouchScreen = new SalesTouchScreen();
									this.Panel1.Controls.Add(salesTouchScreen);
									salesTouchScreen.Dock = DockStyle.Fill;
									salesTouchScreen.BringToFront();
								}
								else
								{
									MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
								}
							}
							else
							{
								SalesTouchScreen salesTouchScreen2 = new SalesTouchScreen();
								this.Panel1.Controls.Add(salesTouchScreen2);
								salesTouchScreen2.Dock = DockStyle.Fill;
								salesTouchScreen2.BringToFront();
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Main Menu Error. Details: " + ex.Message);
						}
					}
				}
			}
			catch (Exception ex2)
			{
			}
			bool flag5;
			return flag5;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000E4C68 File Offset: 0x000E2E68
		private void TipsForAUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						TIPSForPeriodPerson tipsforPeriodPerson = new TIPSForPeriodPerson();
						this.Panel1.Controls.Add(tipsforPeriodPerson);
						tipsforPeriodPerson.Dock = DockStyle.Fill;
						tipsforPeriodPerson.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					TIPSForPeriodPerson tipsforPeriodPerson2 = new TIPSForPeriodPerson();
					this.Panel1.Controls.Add(tipsforPeriodPerson2);
					tipsforPeriodPerson2.Dock = DockStyle.Fill;
					tipsforPeriodPerson2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000E4D84 File Offset: 0x000E2F84
		private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			try
			{
				this.lblHotKeys.Visible = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000E4DC4 File Offset: 0x000E2FC4
		private void SalesForPeriodAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						SalesforPeriodbyShift salesforPeriodbyShift = new SalesforPeriodbyShift();
						this.Panel1.Controls.Add(salesforPeriodbyShift);
						salesforPeriodbyShift.Dock = DockStyle.Fill;
						salesforPeriodbyShift.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesforPeriodbyShift salesforPeriodbyShift2 = new SalesforPeriodbyShift();
					this.Panel1.Controls.Add(salesforPeriodbyShift2);
					salesforPeriodbyShift2.Dock = DockStyle.Fill;
					salesforPeriodbyShift2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000E4ECC File Offset: 0x000E30CC
		private void SalesForPeriodGroupedByDayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						SalesForPeriodGroupedByDay salesForPeriodGroupedByDay = new SalesForPeriodGroupedByDay();
						this.Panel1.Controls.Add(salesForPeriodGroupedByDay);
						salesForPeriodGroupedByDay.Dock = DockStyle.Fill;
						salesForPeriodGroupedByDay.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					SalesForPeriodGroupedByDay salesForPeriodGroupedByDay2 = new SalesForPeriodGroupedByDay();
					this.Panel1.Controls.Add(salesForPeriodGroupedByDay2);
					salesForPeriodGroupedByDay2.Dock = DockStyle.Fill;
					salesForPeriodGroupedByDay2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000E4FD4 File Offset: 0x000E31D4
		private void CheckSerialNumberToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CheckSerialNumber checkSerialNumber = new CheckSerialNumber();
						checkSerialNumber.ShowDialog(this);
						checkSerialNumber.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CheckSerialNumber checkSerialNumber2 = new CheckSerialNumber();
					checkSerialNumber2.ShowDialog(this);
					checkSerialNumber2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00002A30 File Offset: 0x00000C30
		private void SalesReportsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000E50C8 File Offset: 0x000E32C8
		private void ConnectedBranchStatusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						CheckConnectedbranchStatus checkConnectedbranchStatus = new CheckConnectedbranchStatus();
						checkConnectedbranchStatus.Show(this);
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					CheckConnectedbranchStatus checkConnectedbranchStatus2 = new CheckConnectedbranchStatus();
					checkConnectedbranchStatus2.Show(this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000E51AC File Offset: 0x000E33AC
		private void CreatePacketSizesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT) | MyProject.Forms.Form1.IsAdmin;
					if (flag2)
					{
						PackSizeCreate packSizeCreate = new PackSizeCreate();
						packSizeCreate.ShowDialog(this);
						packSizeCreate.Dispose();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PackSizeCreate packSizeCreate2 = new PackSizeCreate();
					packSizeCreate2.ShowDialog(this);
					packSizeCreate2.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000E52A0 File Offset: 0x000E34A0
		private void CreatePacketGroupsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						PackSizeGroups packSizeGroups = new PackSizeGroups();
						this.Panel1.Controls.Add(packSizeGroups);
						packSizeGroups.Dock = DockStyle.Fill;
						packSizeGroups.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PackSizeGroups packSizeGroups2 = new PackSizeGroups();
					this.Panel1.Controls.Add(packSizeGroups2);
					packSizeGroups2.Dock = DockStyle.Fill;
					packSizeGroups2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x000E53A8 File Offset: 0x000E35A8
		private void LinkProductWithPacketSzeGroupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						PacketSizesLinkToProduct packetSizesLinkToProduct = new PacketSizesLinkToProduct();
						this.Panel1.Controls.Add(packetSizesLinkToProduct);
						packetSizesLinkToProduct.Dock = DockStyle.Fill;
						packetSizesLinkToProduct.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					PacketSizesLinkToProduct packetSizesLinkToProduct2 = new PacketSizesLinkToProduct();
					this.Panel1.Controls.Add(packetSizesLinkToProduct2);
					packetSizesLinkToProduct2.Dock = DockStyle.Fill;
					packetSizesLinkToProduct2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000E54B0 File Offset: 0x000E36B0
		private void RunningToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.username, "POSAdmin", false) != 0;
				if (flag)
				{
					bool flag2 = this.Publicfunction.IsAuthorised(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, sender.ToString(), this.permissionsDAT);
					if (flag2)
					{
						RunningBalReport runningBalReport = new RunningBalReport();
						this.Panel1.Controls.Add(runningBalReport);
						runningBalReport.Dock = DockStyle.Fill;
						runningBalReport.BringToFront();
					}
					else
					{
						MessageBox.Show("You are not authorised to view. Contact your System Administrator.");
					}
				}
				else
				{
					RunningBalReport runningBalReport2 = new RunningBalReport();
					this.Panel1.Controls.Add(runningBalReport2);
					runningBalReport2.Dock = DockStyle.Fill;
					runningBalReport2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Main Menu Error. Details: " + ex.Message);
			}
		}

		// Token: 0x04000C04 RID: 3076
		private PublicFunctions Publicfunction;

		// Token: 0x04000C05 RID: 3077
		private int menuLevel;

		// Token: 0x04000C06 RID: 3078
		public DataTable menuDAT;

		// Token: 0x04000C07 RID: 3079
		public DataTable permissionsDAT;

		// Token: 0x04000C08 RID: 3080
		private string _cnn;

		// Token: 0x04000C09 RID: 3081
		private PublicFunctions pf;

		// Token: 0x02000249 RID: 585
		public struct myMenuRow
		{
			// Token: 0x04002B86 RID: 11142
			public ToolStripMenuItem menu_item;

			// Token: 0x04002B87 RID: 11143
			public int menu_level;
		}
	}
}
