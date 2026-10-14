using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000058 RID: 88
	[DesignerGenerated]
	public partial class Expenses : UserControl
	{
		// Token: 0x0600121B RID: 4635 RVA: 0x000AE19C File Offset: 0x000AC39C
		public Expenses()
		{
			base.Load += this.Expenses_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.forday = false;
			this.pf = new PublicFunctions();
			this.formloaded = false;
			this.InitializeComponent();
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x000B0202 File Offset: 0x000AE402
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x000B020C File Offset: 0x000AE40C
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x000B0215 File Offset: 0x000AE415
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x000B021F File Offset: 0x000AE41F
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000B0228 File Offset: 0x000AE428
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x000B0234 File Offset: 0x000AE434
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000B0277 File Offset: 0x000AE477
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x000B0284 File Offset: 0x000AE484
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

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000B02C7 File Offset: 0x000AE4C7
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x000B02D1 File Offset: 0x000AE4D1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x000B02DA File Offset: 0x000AE4DA
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x000B02E4 File Offset: 0x000AE4E4
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000B02ED File Offset: 0x000AE4ED
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x000B02F7 File Offset: 0x000AE4F7
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x000B0300 File Offset: 0x000AE500
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x000B030A File Offset: 0x000AE50A
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x000B0313 File Offset: 0x000AE513
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x000B031D File Offset: 0x000AE51D
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x000B0326 File Offset: 0x000AE526
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x000B0330 File Offset: 0x000AE530
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000B0339 File Offset: 0x000AE539
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x000B0343 File Offset: 0x000AE543
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x000B034C File Offset: 0x000AE54C
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x000B0356 File Offset: 0x000AE556
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x000B035F File Offset: 0x000AE55F
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x000B0369 File Offset: 0x000AE569
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000B0372 File Offset: 0x000AE572
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x000B037C File Offset: 0x000AE57C
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000B03BF File Offset: 0x000AE5BF
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x000B03C9 File Offset: 0x000AE5C9
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000B03D2 File Offset: 0x000AE5D2
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x000B03DC File Offset: 0x000AE5DC
		internal virtual DataGridView dgvExpenses
		{
			[CompilerGenerated]
			get
			{
				return this._dgvExpenses;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvExpenses_CellContentClick);
				DataGridView dataGridView = this._dgvExpenses;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvExpenses = value;
				dataGridView = this._dgvExpenses;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x000B041F File Offset: 0x000AE61F
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x000B042C File Offset: 0x000AE62C
		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return this._Label6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label6_Click);
				Label label = this._Label6;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label6 = value;
				label = this._Label6;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000B046F File Offset: 0x000AE66F
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x000B047C File Offset: 0x000AE67C
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x000B04BF File Offset: 0x000AE6BF
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x000B04C9 File Offset: 0x000AE6C9
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000B04D2 File Offset: 0x000AE6D2
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x000B04DC File Offset: 0x000AE6DC
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000B04E5 File Offset: 0x000AE6E5
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x000B04EF File Offset: 0x000AE6EF
		internal virtual ComboBox cboExpCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x000B04F8 File Offset: 0x000AE6F8
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x000B0504 File Offset: 0x000AE704
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

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x000B0547 File Offset: 0x000AE747
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x000B0551 File Offset: 0x000AE751
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x000B055A File Offset: 0x000AE75A
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x000B0564 File Offset: 0x000AE764
		internal virtual TextBox txtActualAmt
		{
			[CompilerGenerated]
			get
			{
				return this._txtActualAmt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtActualAmt_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtActualAmt_TextChanged);
				TextBox textBox = this._txtActualAmt;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtActualAmt = value;
				textBox = this._txtActualAmt;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x000B05C2 File Offset: 0x000AE7C2
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x000B05CC File Offset: 0x000AE7CC
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x000B05D5 File Offset: 0x000AE7D5
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x000B05DF File Offset: 0x000AE7DF
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x000B05E8 File Offset: 0x000AE7E8
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x000B05F4 File Offset: 0x000AE7F4
		internal virtual ComboBox cboTill
		{
			[CompilerGenerated]
			get
			{
				return this._cboTill;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboTill_SelectedIndexChanged);
				ComboBox comboBox = this._cboTill;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboTill = value;
				comboBox = this._cboTill;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x000B0637 File Offset: 0x000AE837
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x000B0641 File Offset: 0x000AE841
		internal virtual Label lblTeller
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x000B064A File Offset: 0x000AE84A
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x000B0654 File Offset: 0x000AE854
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x000B065D File Offset: 0x000AE85D
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x000B0667 File Offset: 0x000AE867
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x000B0670 File Offset: 0x000AE870
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x000B067C File Offset: 0x000AE87C
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

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x000B06BF File Offset: 0x000AE8BF
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x000B06C9 File Offset: 0x000AE8C9
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x000B06D2 File Offset: 0x000AE8D2
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x000B06DC File Offset: 0x000AE8DC
		internal virtual CheckBox chkTax
		{
			[CompilerGenerated]
			get
			{
				return this._chkTax;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkTax_CheckedChanged);
				CheckBox checkBox = this._chkTax;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkTax = value;
				checkBox = this._chkTax;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x000B071F File Offset: 0x000AE91F
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x000B072C File Offset: 0x000AE92C
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

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x000B076F File Offset: 0x000AE96F
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x000B077C File Offset: 0x000AE97C
		internal virtual TextBox txtTaxAmt
		{
			[CompilerGenerated]
			get
			{
				return this._txtTaxAmt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtTaxAmt_KeyPress);
				TextBox textBox = this._txtTaxAmt;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtTaxAmt = value;
				textBox = this._txtTaxAmt;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x000B07BF File Offset: 0x000AE9BF
		// (set) Token: 0x06001265 RID: 4709 RVA: 0x000B07C9 File Offset: 0x000AE9C9
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x000B07D2 File Offset: 0x000AE9D2
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x000B07DC File Offset: 0x000AE9DC
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x000B07E5 File Offset: 0x000AE9E5
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x000B07EF File Offset: 0x000AE9EF
		internal virtual Label lblfp
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x000B07F8 File Offset: 0x000AE9F8
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x000B0804 File Offset: 0x000AEA04
		internal virtual Label Label28
		{
			[CompilerGenerated]
			get
			{
				return this._Label28;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label28_Click);
				Label label = this._Label28;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label28 = value;
				label = this._Label28;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000B0847 File Offset: 0x000AEA47
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x000B0854 File Offset: 0x000AEA54
		internal virtual ComboBox cboSupplier
		{
			[CompilerGenerated]
			get
			{
				return this._cboSupplier;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboSupplier_SelectedIndexChanged);
				ComboBox comboBox = this._cboSupplier;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboSupplier = value;
				comboBox = this._cboSupplier;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x000B0897 File Offset: 0x000AEA97
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x000B08A1 File Offset: 0x000AEAA1
		internal virtual Panel Panel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x000B08AA File Offset: 0x000AEAAA
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x000B08B4 File Offset: 0x000AEAB4
		internal virtual TextBox txtSupplierInvnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x000B08BD File Offset: 0x000AEABD
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x000B08C7 File Offset: 0x000AEAC7
		internal virtual Label Label39
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x000B08D0 File Offset: 0x000AEAD0
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x000B08DC File Offset: 0x000AEADC
		internal virtual Label Label37
		{
			[CompilerGenerated]
			get
			{
				return this._Label37;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label37_Click);
				Label label = this._Label37;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label37 = value;
				label = this._Label37;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x000B091F File Offset: 0x000AEB1F
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x000B0929 File Offset: 0x000AEB29
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x000B0932 File Offset: 0x000AEB32
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x000B093C File Offset: 0x000AEB3C
		internal virtual TextBox txtComments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000B0945 File Offset: 0x000AEB45
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x000B0950 File Offset: 0x000AEB50
		internal virtual ComboBox cboTerms
		{
			[CompilerGenerated]
			get
			{
				return this._cboTerms;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboTerms_SelectedIndexChanged);
				ComboBox comboBox = this._cboTerms;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboTerms = value;
				comboBox = this._cboTerms;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x000B0993 File Offset: 0x000AEB93
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x000B09A0 File Offset: 0x000AEBA0
		internal virtual CheckBox chkOnAcc
		{
			[CompilerGenerated]
			get
			{
				return this._chkOnAcc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkOnAcc_CheckedChanged);
				CheckBox checkBox = this._chkOnAcc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkOnAcc = value;
				checkBox = this._chkOnAcc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x000B09E3 File Offset: 0x000AEBE3
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x000B09ED File Offset: 0x000AEBED
		internal virtual CheckBox chkUseSameSuppliers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000B09F8 File Offset: 0x000AEBF8
		private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000B0A44 File Offset: 0x000AEC44
		private void LoadExpensesForDay(int theday)
		{
			this.forday = true;
			this.dgvExpenses.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchExpensesForPeriod";
			sqlCommand.Parameters.AddWithValue("startdate", theday);
			sqlCommand.Parameters.AddWithValue("enddate", theday);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvExpenses.DataSource = dataTable;
			this.dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvExpenses.Columns["EntryNo"].HeaderText = "Entry Number";
			this.dgvExpenses.Columns["ExpenseDate"].HeaderText = "Expense Date";
			this.dgvExpenses.Columns["Description"].HeaderText = "Expense Description";
			this.dgvExpenses.Columns["FromTill"].Visible = false;
			this.dgvExpenses.Columns["TillOperator"].Visible = false;
			this.dgvExpenses.Columns["expensecategorydesc"].HeaderText = "Expense Category";
			this.dgvExpenses.Columns["PaymentMethodDesc"].HeaderText = "Payment Method";
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Expense";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvExpenses.Columns.Add(dataGridViewButtonColumn);
			string text = theday.ToString();
			string text2 = text.Substring(0, 4);
			string text3 = text.Substring(4, 2);
			string text4 = text.Substring(6, 2);
			this.GroupBox2.Text = string.Concat(new string[] { "Expenses For ", text4, "/", text3, "/", text2 });
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000B0CB0 File Offset: 0x000AEEB0
		private void LoadExpensesForPeriod(int startdate, int enddate)
		{
			this.forday = false;
			this.dgvExpenses.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchExpensesForPeriod";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvExpenses.DataSource = dataTable;
			this.dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvExpenses.Columns["EntryNo"].HeaderText = "Entry Number";
			this.dgvExpenses.Columns["ExpenseDate"].HeaderText = "Expense Date";
			this.dgvExpenses.Columns["Description"].HeaderText = "Expense Description";
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Expense";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvExpenses.Columns.Insert(4, dataGridViewButtonColumn);
			string text = startdate.ToString();
			string text2 = enddate.ToString();
			string text3 = text.Substring(0, 4);
			string text4 = text.Substring(4, 2);
			string text5 = text.Substring(6, 2);
			string text6 = text2.Substring(0, 4);
			string text7 = text2.Substring(4, 2);
			string text8 = text2.Substring(6, 2);
			this.GroupBox2.Text = string.Concat(new string[]
			{
				"Expenses For period starting ", text5, "/", text4, "/", text3, " And ending: ", text8, "/", text7,
				"/", text6
			});
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000B0EF8 File Offset: 0x000AF0F8
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.LoadExpensesForPeriod((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))));
					this.txtCost.Text = Conversions.ToString(0);
					this.txtDesc.Text = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error displaying expenses. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000B0FB0 File Offset: 0x000AF1B0
		private void InsertExpense()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunNewStockSave");
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertNewExpense";
				sqlCommand.Parameters.AddWithValue("expensedate", this.DTdate.Value.ToString("yyyyMMdd"));
				sqlCommand.Parameters.AddWithValue("desc", this.txtDesc.Text);
				sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCost.Text));
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
				sqlCommand.Parameters.AddWithValue("rate", this.pay_rate);
				sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
				sqlCommand.Parameters.AddWithValue("expensecategoryid", RuntimeHelpers.GetObjectValue(this.cboExpCategories.SelectedValue));
				int num = 0;
				bool flag = Operators.CompareString(this.cboTill.Text, "MY TILL", false) != 0;
				if (flag)
				{
					num = 1;
				}
				sqlCommand.Parameters.AddWithValue("FromTill", num);
				sqlCommand.Parameters.AddWithValue("Teller", this.lblTeller.Text);
				sqlCommand.Parameters.AddWithValue("Doneby", MyProject.Forms.Form1.username);
				sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
				bool @checked = this.chkTax.Checked;
				if (@checked)
				{
					sqlCommand.Parameters.AddWithValue("amtincludestax", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("amtincludestax", 0);
				}
				bool flag2 = Operators.CompareString(this.lblfp.Text, "...", false) != 0;
				if (flag2)
				{
					byte[] photo = this.pf.GetPhoto(this.lblfp.Text);
					sqlCommand.Parameters.Add("scannedcopy", SqlDbType.VarBinary, photo.Length);
				}
				sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(this.txtTaxAmt.Text));
				sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
				int num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandText = "InsertCreditorLog";
				sqlCommand.Parameters.AddWithValue("@SupplierID", RuntimeHelpers.GetObjectValue(this.cboSupplier.SelectedValue));
				sqlCommand.Parameters.AddWithValue("@TranType", 4);
				sqlCommand.Parameters.AddWithValue("@InvoiceNumber", this.txtSupplierInvnumber.Text);
				sqlCommand.Parameters.AddWithValue("@ref", this.txtComments.Text);
				sqlCommand.Parameters.AddWithValue("@AmtChargedTotal", Conversion.Val(this.txtCost.Text));
				sqlCommand.Parameters.AddWithValue("@TaxAmt", Conversion.Val(this.txtTaxAmt.Text));
				decimal num3 = 0m;
				bool checked2 = this.chkOnAcc.Checked;
				if (checked2)
				{
					num3 = 0m;
				}
				else
				{
					num3 = new decimal(Conversion.Val(this.txtCost.Text));
				}
				sqlCommand.Parameters.AddWithValue("@AmtPaid", num3);
				sqlCommand.Parameters.AddWithValue("@Bal", 0);
				sqlCommand.Parameters.AddWithValue("@TranDate", Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("@TranTime", DateTime.Now.ToString("hh:mm"));
				sqlCommand.Parameters.AddWithValue("@Coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("@Branch", this.cboBranches.Text);
				int num4 = 0;
				bool checked3 = this.chkOnAcc.Checked;
				if (checked3)
				{
					num4 = Conversions.ToInteger(this.cboTerms.SelectedValue);
					sqlCommand.Parameters.AddWithValue("@PaymentMethodID", 0);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("@PaymentMethodID", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
				}
				sqlCommand.Parameters.AddWithValue("@Terms", num4);
				sqlCommand.Parameters.AddWithValue("@DueDate", Conversions.ToInteger(DateAndTime.DateAdd(DateInterval.Day, (double)num4, this.DTdate.Value).ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("@PaymentMethodDesc", this.cboPayMeth.Text);
				sqlCommand.Parameters.AddWithValue("@Comment", this.txtComments.Text);
				sqlCommand.Parameters.AddWithValue("@rate", this.pay_rate);
				sqlCommand.Parameters.AddWithValue("@Uploaded", 0);
				sqlCommand.Parameters.AddWithValue("@doneby", MyProject.Forms.Form1.username);
				sqlCommand.Parameters.AddWithValue("@machinename", Environment.MachineName);
				sqlCommand.Parameters.AddWithValue("@MvtRef", num2);
				int num5;
				sqlCommand.Parameters.AddWithValue("@new_identity", num5);
				sqlCommand.ExecuteNonQuery();
				sqlTransaction.Commit();
				sqlCommand.Connection.Close();
			}
			catch (Exception ex)
			{
				sqlTransaction.Rollback();
				sqlCommand.Connection.Close();
				throw ex;
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000B164C File Offset: 0x000AF84C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboTill.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please select the source of funds.");
				}
				else
				{
					bool flag2 = Conversion.Val(this.txtCost.Text) == 0.0;
					if (flag2)
					{
						MessageBox.Show("Please select a payment method and enter the amount paid first. Cost price is 0");
					}
					else
					{
						bool flag3 = Operators.CompareString(this.txtDesc.Text, "", false) == 0;
						if (flag3)
						{
							MessageBox.Show("Please enter the expense description first.");
							this.txtDesc.Focus();
						}
						else
						{
							bool flag4 = this.cboExpCategories.SelectedIndex == -1;
							if (flag4)
							{
								MessageBox.Show("Please select an expense category first.");
							}
							else
							{
								bool flag5 = Operators.ConditionalCompareObjectLess(this.cboSupplier.SelectedValue, 0, false);
								if (flag5)
								{
									MessageBox.Show("Please select a supplier first.");
									this.cboSupplier.Focus();
								}
								else
								{
									bool flag6 = Operators.CompareString(this.cboSupplier.Text, "", false) == 0;
									if (flag6)
									{
										MessageBox.Show("Please select a supplier first.");
										this.cboSupplier.Focus();
									}
									else
									{
										this.InsertExpense();
										this.LoadExpensesForDay(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd")));
										this.txtActualAmt.Text = "";
										this.txtCost.Text = "0";
										this.txtDesc.Text = "";
										this.cboPayMeth.SelectedIndex = -1;
										this.cboExpCategories.SelectedIndex = -1;
										this.cboTill.SelectedIndex = 0;
										this.lblfp.Text = "...";
										this.txtTaxAmt.Text = "0";
										this.txtComments.Text = "";
										this.txtSupplierInvnumber.Text = "";
										this.cboTerms.SelectedIndex = -1;
										bool @checked = this.chkUseSameSuppliers.Checked;
										if (!@checked)
										{
											bool flag7 = this.cboSupplier.Items.Count == 1;
											if (flag7)
											{
												this.cboSupplier.SelectedIndex = 0;
											}
											else
											{
												this.cboSupplier.SelectedIndex = -1;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error inserting expense. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000B18FC File Offset: 0x000AFAFC
		private void DeleteExpense(int EntryNo)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteExpense";
			sqlCommand.Parameters.AddWithValue("entryno", EntryNo);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
			string text = "Expenses";
			string text2 = "EntryNo";
			string text3 = "int";
			SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
			SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "InsertDeletedItem";
			sqlCommand2.Parameters.AddWithValue("TBName", text);
			sqlCommand2.Parameters.AddWithValue("KeyColumn", text2);
			sqlCommand2.Parameters.AddWithValue("KeyColumnType", text3);
			sqlCommand2.Parameters.AddWithValue("KeyValue", EntryNo.ToString());
			sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand2.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection3)
			{
				sqlConnection3.Open();
				sqlCommand2.ExecuteNonQuery();
				sqlConnection3.Close();
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000B1AD8 File Offset: 0x000AFCD8
		private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			checked
			{
				try
				{
					DataGridView dataGridView = (DataGridView)sender;
					bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
					if (flag)
					{
						this.DeleteExpense(Conversions.ToInteger(this.dgvExpenses.Rows[e.RowIndex].Cells["EntryNo"].Value));
						MessageBox.Show("Expense deleted successfully.");
						bool flag2 = this.forday;
						if (flag2)
						{
							this.LoadExpensesForDay(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd")));
						}
						else
						{
							this.LoadExpensesForPeriod((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))));
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error occurred. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label6_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000B1C18 File Offset: 0x000AFE18
		private void LoadPayMeths()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPayMeth.DataSource = dataTable;
			this.cboPayMeth.ValueMember = "PaymentMethodID";
			this.cboPayMeth.DisplayMember = "PaymentMethodDesc";
			this.cboPayMeth.SelectedIndex = this.cboPayMeth.FindStringExact(MyProject.Forms.Form1.ChangePaymentMethod);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000B1CDC File Offset: 0x000AFEDC
		private decimal GetRate(int paymethid)
		{
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetRateForPayMeth";
			sqlCommand.Parameters.AddWithValue("paymethid", paymethid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag = num2 > 0;
			decimal num3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
				num3 = num;
			}
			else
			{
				num3 = num;
			}
			return num3;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000B1DAC File Offset: 0x000AFFAC
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				ExpensesCategories expensesCategories = new ExpensesCategories();
				expensesCategories.ShowDialog(this);
				expensesCategories.Dispose();
				this.LoadExpenseCategories();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Expenses Categories form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000B1E10 File Offset: 0x000B0010
		private void LoadExpenseCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetExpensesCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboExpCategories.DataSource = dataTable;
			this.cboExpCategories.ValueMember = "ExpenseCategoryID";
			this.cboExpCategories.DisplayMember = "ExpenseCategoryDesc";
			this.cboExpCategories.SelectedIndex = -1;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000B1EBC File Offset: 0x000B00BC
		private void txtActualAmt_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000B1F08 File Offset: 0x000B0108
		private void calcAmtPaid()
		{
			try
			{
				bool flag = this.cboPayMeth.SelectedIndex == -1;
				if (flag)
				{
					bool flag2 = this.formloaded & (Operators.CompareString(this.txtActualAmt.Text, "", false) != 0);
					if (flag2)
					{
						MessageBox.Show("Select payment method first.");
						this.cboPayMeth.Focus();
					}
				}
				else
				{
					bool flag3 = Operators.CompareString(this.txtActualAmt.Text, "", false) == 0;
					if (!flag3)
					{
						decimal num = new decimal(Conversion.Val(this.txtActualAmt.Text) / Convert.ToDouble(this.pay_rate));
						this.txtCost.Text = Math.Round(num, 2, MidpointRounding.AwayFromZero).ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error converting rate. Detail: " + ex.Message);
				this.txtCost.Text = "0";
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x000B2018 File Offset: 0x000B0218
		private void txtActualAmt_TextChanged(object sender, EventArgs e)
		{
			this.calcAmtPaid();
			this.CalcTax();
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000B202C File Offset: 0x000B022C
		private void Expenses_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadExpenseCategories();
				this.LoadPayMeths();
				this.cboBranches.DataSource = MyProject.Forms.Form1.allBranches;
				this.cboBranches.ValueMember = "branch";
				this.cboBranches.DisplayMember = "branch";
				this.cboBranches.SelectedIndex = this.cboBranches.FindStringExact(MyProject.Forms.Form1.branch);
				this.cboTill.SelectedIndex = 0;
				this.formloaded = true;
				this.taxrate = this.GetCoTaxRate();
				this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.ValueMember = "SupplierID";
				bool flag = this.cboSupplier.Items.Count == 1;
				if (flag)
				{
					this.cboSupplier.SelectedIndex = 0;
				}
				this.LoadPaymentTerms();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading expenses form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000B217C File Offset: 0x000B037C
		private void cboTill_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboTill.Text, "MY TILL", false) == 0;
				if (flag)
				{
					this.lblTeller.Text = MyProject.Forms.Form1.username;
				}
				else
				{
					this.lblTeller.Text = "";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000B21FC File Offset: 0x000B03FC
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvExpenses.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvExpenses, this.SaveFileDialog1.FileName);
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

		// Token: 0x06001293 RID: 4755 RVA: 0x000B22B4 File Offset: 0x000B04B4
		private void DATAGRIDVIEW_TO_EXCEL(DataGridView DGV, string FLE)
		{
			checked
			{
				try
				{
					DataTable dataTable = new DataTable();
					int num = DGV.ColumnCount - 1;
					for (int i = 0; i <= num; i++)
					{
						dataTable.Columns.Add(DGV.Columns[i].Name.ToString());
					}
					int num2 = DGV.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						DataRow dataRow = dataTable.NewRow();
						int num3 = DGV.ColumnCount - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								dataRow[dataTable.Columns[i].ColumnName.ToString()] = DGV.Rows[j].Cells[i].Value.ToString();
							}
							catch (Exception ex)
							{
							}
						}
						dataTable.Rows.Add(dataRow);
					}
					dataTable.AcceptChanges();
					DataSet dataSet = new DataSet();
					dataSet.Tables.Add(dataTable);
					dataTable.WriteXml(FLE);
				}
				catch (Exception ex2)
				{
					Interaction.MsgBox(ex2.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000B241C File Offset: 0x000B061C
		private void Export_Excel(DataGridView dgv, string filename)
		{
			checked
			{
				try
				{
					DataTable dataTable = new DataTable();
					try
					{
						foreach (object obj in dgv.Columns)
						{
							DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
							dataTable.Columns.Add(dataGridViewColumn.HeaderText, dataGridViewColumn.ValueType);
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
						foreach (object obj2 in ((IEnumerable)dgv.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
							dataTable.Rows.Add(new object[0]);
							try
							{
								foreach (object obj3 in dataGridViewRow.Cells)
								{
									DataGridViewCell dataGridViewCell = (DataGridViewCell)obj3;
									dataTable.Rows[dataTable.Rows.Count - 1][dataGridViewCell.ColumnIndex] = dataGridViewCell.Value.ToString();
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
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					string text = "c:\\QuantumPOS Price Changes Audits";
					bool flag = !Directory.Exists(text);
					if (flag)
					{
						Directory.CreateDirectory(text);
					}
					using (XLWorkbook xlworkbook = new XLWorkbook())
					{
						xlworkbook.Worksheets.Add(dataTable, "Customers");
						xlworkbook.Worksheet(1).Cells("A1:C1").Style.Fill.BackgroundColor = XLColor.DarkGreen;
						int count = dataTable.Rows.Count;
						for (int i = 1; i <= count; i++)
						{
							string text2 = string.Format("A{0}:C{0}", i + 1);
							bool flag2 = i % 2 != 0;
							if (flag2)
							{
								xlworkbook.Worksheet(1).Cells(text2).Style.Fill.BackgroundColor = XLColor.GreenYellow;
							}
							else
							{
								xlworkbook.Worksheet(1).Cells(text2).Style.Fill.BackgroundColor = XLColor.Yellow;
							}
						}
						xlworkbook.Worksheet(1).Columns().AdjustToContents();
						xlworkbook.SaveAs(text + "DataGridViewExport.xlsx");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error exporting data to excel. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x000B2724 File Offset: 0x000B0924
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtActualAmt.Visible = true;
				this.Label2.Visible = true;
				this.pay_rate = this.GetRate(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
				this.calcAmtPaid();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000B2794 File Offset: 0x000B0994
		private void chkTax_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkTax.Checked;
				if (@checked)
				{
					this.Label13.Visible = true;
					this.txtTaxAmt.Visible = true;
					this.CalcTax();
				}
				else
				{
					this.Label13.Visible = false;
					this.txtTaxAmt.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000B2814 File Offset: 0x000B0A14
		private decimal GetCoTaxRate()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select isnull(BaseTaxPercentage,0) as taxperc from company where companyid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count > 0;
			decimal num;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Conversions.ToDecimal(dataRow["taxperc"]);
			}
			else
			{
				num = 0m;
			}
			return num;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000B28C0 File Offset: 0x000B0AC0
		private void CalcTax()
		{
			this.txtTaxAmt.Text = Conversions.ToString(Conversion.Val(this.txtCost.Text) - Conversion.Val(this.txtCost.Text) / Convert.ToDouble(decimal.Add(1m, decimal.Divide(this.taxrate, 100m))));
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000B2924 File Offset: 0x000B0B24
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Select the scanned copy of the expense.";
				openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				openFileDialog.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg|PNGs|*.png";
				openFileDialog.RestoreDirectory = false;
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.lblfp.Text = openFileDialog.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening file. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000B29C0 File Offset: 0x000B0BC0
		private void txtTaxAmt_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label37_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboTerms_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000B2A0C File Offset: 0x000B0C0C
		private void chkOnAcc_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkOnAcc.Checked;
			if (@checked)
			{
				this.Panel5.Visible = true;
			}
			else
			{
				this.Panel5.Visible = false;
				this.txtTaxAmt.Text = "0";
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000B2A5C File Offset: 0x000B0C5C
		private void LoadPaymentTerms()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentTerms";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboTerms.DataSource = dataTable;
			this.cboTerms.DisplayMember = "Description";
			this.cboTerms.ValueMember = "TermsDays";
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label28_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040008B4 RID: 2228
		private string _cnn;

		// Token: 0x040008B5 RID: 2229
		private bool forday;

		// Token: 0x040008B6 RID: 2230
		private PublicFunctions pf;

		// Token: 0x040008B7 RID: 2231
		private bool formloaded;

		// Token: 0x040008B8 RID: 2232
		private decimal taxrate;

		// Token: 0x040008B9 RID: 2233
		private string fp;

		// Token: 0x040008BA RID: 2234
		private decimal pay_rate;
	}
}
