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
	// Token: 0x02000176 RID: 374
	[DesignerGenerated]
	public partial class PromotionCreate : UserControl
	{
		// Token: 0x060035F4 RID: 13812 RVA: 0x001D1F30 File Offset: 0x001D0130
		public PromotionCreate()
		{
			base.Load += this.PromotionCreate_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x001D570E File Offset: 0x001D390E
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x001D5718 File Offset: 0x001D3918
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x001D5721 File Offset: 0x001D3921
		// (set) Token: 0x060035FA RID: 13818 RVA: 0x001D572B File Offset: 0x001D392B
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x001D5734 File Offset: 0x001D3934
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x001D5740 File Offset: 0x001D3940
		internal virtual DataGridView dgvProms
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProms;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvProms_CellContentClick);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.dgvProms_CellClick);
				DataGridView dataGridView = this._dgvProms;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
					dataGridView.CellClick -= dataGridViewCellEventHandler2;
				}
				this._dgvProms = value;
				dataGridView = this._dgvProms;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
					dataGridView.CellClick += dataGridViewCellEventHandler2;
				}
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x001D579E File Offset: 0x001D399E
		// (set) Token: 0x060035FE RID: 13822 RVA: 0x001D57A8 File Offset: 0x001D39A8
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
				TabControlCancelEventHandler tabControlCancelEventHandler = new TabControlCancelEventHandler(this.TabControl1_Selecting);
				TabControl tabControl = this._TabControl1;
				if (tabControl != null)
				{
					tabControl.Selecting -= tabControlCancelEventHandler;
				}
				this._TabControl1 = value;
				tabControl = this._TabControl1;
				if (tabControl != null)
				{
					tabControl.Selecting += tabControlCancelEventHandler;
				}
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x001D57EB File Offset: 0x001D39EB
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x001D57F5 File Offset: 0x001D39F5
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x001D57FE File Offset: 0x001D39FE
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x001D5808 File Offset: 0x001D3A08
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x001D5811 File Offset: 0x001D3A11
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x001D581B File Offset: 0x001D3A1B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x001D5824 File Offset: 0x001D3A24
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x001D582E File Offset: 0x001D3A2E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x001D5837 File Offset: 0x001D3A37
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x001D5844 File Offset: 0x001D3A44
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

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x001D5887 File Offset: 0x001D3A87
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x001D5891 File Offset: 0x001D3A91
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x001D589A File Offset: 0x001D3A9A
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x001D58A4 File Offset: 0x001D3AA4
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x001D58AD File Offset: 0x001D3AAD
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x001D58B7 File Offset: 0x001D3AB7
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x001D58C0 File Offset: 0x001D3AC0
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x001D58CA File Offset: 0x001D3ACA
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x001D58D3 File Offset: 0x001D3AD3
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x001D58DD File Offset: 0x001D3ADD
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x001D58E6 File Offset: 0x001D3AE6
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x001D58F0 File Offset: 0x001D3AF0
		internal virtual DataGridView dgvPromReq
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPromReq;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPromReq_CellContentClick);
				DataGridView dataGridView = this._dgvPromReq;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPromReq = value;
				dataGridView = this._dgvPromReq;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x001D5933 File Offset: 0x001D3B33
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x001D593D File Offset: 0x001D3B3D
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x001D5946 File Offset: 0x001D3B46
		// (set) Token: 0x06003618 RID: 13848 RVA: 0x001D5950 File Offset: 0x001D3B50
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x001D5959 File Offset: 0x001D3B59
		// (set) Token: 0x0600361A RID: 13850 RVA: 0x001D5964 File Offset: 0x001D3B64
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

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x001D59C2 File Offset: 0x001D3BC2
		// (set) Token: 0x0600361C RID: 13852 RVA: 0x001D59CC File Offset: 0x001D3BCC
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x001D59D5 File Offset: 0x001D3BD5
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x001D59E0 File Offset: 0x001D3BE0
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

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x001D5A23 File Offset: 0x001D3C23
		// (set) Token: 0x06003620 RID: 13856 RVA: 0x001D5A2D File Offset: 0x001D3C2D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x001D5A36 File Offset: 0x001D3C36
		// (set) Token: 0x06003622 RID: 13858 RVA: 0x001D5A40 File Offset: 0x001D3C40
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

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x001D5A83 File Offset: 0x001D3C83
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x001D5A8D File Offset: 0x001D3C8D
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x001D5A96 File Offset: 0x001D3C96
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x001D5AA0 File Offset: 0x001D3CA0
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

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x001D5AE3 File Offset: 0x001D3CE3
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x001D5AED File Offset: 0x001D3CED
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x001D5AF6 File Offset: 0x001D3CF6
		// (set) Token: 0x0600362A RID: 13866 RVA: 0x001D5B00 File Offset: 0x001D3D00
		internal virtual TextBox txtQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x001D5B09 File Offset: 0x001D3D09
		// (set) Token: 0x0600362C RID: 13868 RVA: 0x001D5B14 File Offset: 0x001D3D14
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

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x001D5B57 File Offset: 0x001D3D57
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x001D5B64 File Offset: 0x001D3D64
		internal virtual Label Label9
		{
			[CompilerGenerated]
			get
			{
				return this._Label9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label9_Click);
				Label label = this._Label9;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label9 = value;
				label = this._Label9;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x001D5BA7 File Offset: 0x001D3DA7
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x001D5BB1 File Offset: 0x001D3DB1
		internal virtual TextBox txtPromDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x001D5BBA File Offset: 0x001D3DBA
		// (set) Token: 0x06003632 RID: 13874 RVA: 0x001D5BC4 File Offset: 0x001D3DC4
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x001D5BCD File Offset: 0x001D3DCD
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x001D5BD7 File Offset: 0x001D3DD7
		internal virtual TextBox txtPromNUm
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x001D5BE0 File Offset: 0x001D3DE0
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x001D5BEA File Offset: 0x001D3DEA
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x001D5BF3 File Offset: 0x001D3DF3
		// (set) Token: 0x06003638 RID: 13880 RVA: 0x001D5BFD File Offset: 0x001D3DFD
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x001D5C06 File Offset: 0x001D3E06
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x001D5C10 File Offset: 0x001D3E10
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x001D5C19 File Offset: 0x001D3E19
		// (set) Token: 0x0600363C RID: 13884 RVA: 0x001D5C24 File Offset: 0x001D3E24
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

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x001D5C67 File Offset: 0x001D3E67
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x001D5C74 File Offset: 0x001D3E74
		internal virtual TextBox txtProdid
		{
			[CompilerGenerated]
			get
			{
				return this._txtProdid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtProdid_TextChanged);
				TextBox textBox = this._txtProdid;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtProdid = value;
				textBox = this._txtProdid;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x001D5CB7 File Offset: 0x001D3EB7
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x001D5CC4 File Offset: 0x001D3EC4
		internal virtual DataGridView dgvBenefitsFree
		{
			[CompilerGenerated]
			get
			{
				return this._dgvBenefitsFree;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvBenefitsFree_CellContentClick);
				DataGridView dataGridView = this._dgvBenefitsFree;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvBenefitsFree = value;
				dataGridView = this._dgvBenefitsFree;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x001D5D07 File Offset: 0x001D3F07
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x001D5D11 File Offset: 0x001D3F11
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x001D5D1A File Offset: 0x001D3F1A
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x001D5D24 File Offset: 0x001D3F24
		internal virtual TabControl TabControl2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x001D5D2D File Offset: 0x001D3F2D
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x001D5D37 File Offset: 0x001D3F37
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x001D5D40 File Offset: 0x001D3F40
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x001D5D4C File Offset: 0x001D3F4C
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

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x001D5D8F File Offset: 0x001D3F8F
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x001D5D99 File Offset: 0x001D3F99
		internal virtual GroupBox GroupBox7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x001D5DA2 File Offset: 0x001D3FA2
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x001D5DAC File Offset: 0x001D3FAC
		internal virtual DataGridView dgvPromProds
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x001D5DB5 File Offset: 0x001D3FB5
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x001D5DBF File Offset: 0x001D3FBF
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x001D5DC8 File Offset: 0x001D3FC8
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x001D5DD2 File Offset: 0x001D3FD2
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x001D5DDB File Offset: 0x001D3FDB
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x001D5DE5 File Offset: 0x001D3FE5
		internal virtual TabPage TabPage4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x001D5DEE File Offset: 0x001D3FEE
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x001D5DF8 File Offset: 0x001D3FF8
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

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x001D5E3B File Offset: 0x001D403B
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x001D5E45 File Offset: 0x001D4045
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x001D5E4E File Offset: 0x001D404E
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x001D5E58 File Offset: 0x001D4058
		internal virtual TextBox txtDiscPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x001D5E61 File Offset: 0x001D4061
		// (set) Token: 0x0600365A RID: 13914 RVA: 0x001D5E6B File Offset: 0x001D406B
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x001D5E74 File Offset: 0x001D4074
		// (set) Token: 0x0600365C RID: 13916 RVA: 0x001D5E80 File Offset: 0x001D4080
		internal virtual TextBox txtBarCode2
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarCode2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtBarCode2_TextChanged);
				TextBox textBox = this._txtBarCode2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtBarCode2 = value;
				textBox = this._txtBarCode2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x001D5EC3 File Offset: 0x001D40C3
		// (set) Token: 0x0600365E RID: 13918 RVA: 0x001D5ED0 File Offset: 0x001D40D0
		internal virtual TextBox txtProdid2
		{
			[CompilerGenerated]
			get
			{
				return this._txtProdid2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtProdid2_TextChanged);
				TextBox textBox = this._txtProdid2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtProdid2 = value;
				textBox = this._txtProdid2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x001D5F13 File Offset: 0x001D4113
		// (set) Token: 0x06003660 RID: 13920 RVA: 0x001D5F20 File Offset: 0x001D4120
		internal virtual TextBox txtSearchProductCode2
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCode2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode2_TextChanged);
				TextBox textBox = this._txtSearchProductCode2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode2 = value;
				textBox = this._txtSearchProductCode2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x001D5F63 File Offset: 0x001D4163
		// (set) Token: 0x06003662 RID: 13922 RVA: 0x001D5F6D File Offset: 0x001D416D
		internal virtual TextBox txtQty2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x001D5F76 File Offset: 0x001D4176
		// (set) Token: 0x06003664 RID: 13924 RVA: 0x001D5F80 File Offset: 0x001D4180
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x001D5F89 File Offset: 0x001D4189
		// (set) Token: 0x06003666 RID: 13926 RVA: 0x001D5F93 File Offset: 0x001D4193
		internal virtual Label lblerror2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x001D5F9C File Offset: 0x001D419C
		// (set) Token: 0x06003668 RID: 13928 RVA: 0x001D5FA6 File Offset: 0x001D41A6
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x001D5FAF File Offset: 0x001D41AF
		// (set) Token: 0x0600366A RID: 13930 RVA: 0x001D5FB9 File Offset: 0x001D41B9
		internal virtual TextBox txtDesc2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600366B RID: 13931 RVA: 0x001D5FC2 File Offset: 0x001D41C2
		// (set) Token: 0x0600366C RID: 13932 RVA: 0x001D5FCC File Offset: 0x001D41CC
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x001D5FD5 File Offset: 0x001D41D5
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x001D5FE0 File Offset: 0x001D41E0
		internal virtual DataGridView DGVSearch2
		{
			[CompilerGenerated]
			get
			{
				return this._DGVSearch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch2_CellEnter);
				DataGridView dataGridView = this._DGVSearch2;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch2 = value;
				dataGridView = this._DGVSearch2;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x001D6023 File Offset: 0x001D4223
		// (set) Token: 0x06003670 RID: 13936 RVA: 0x001D602D File Offset: 0x001D422D
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x001D6036 File Offset: 0x001D4236
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x001D6040 File Offset: 0x001D4240
		internal virtual Button Button32
		{
			[CompilerGenerated]
			get
			{
				return this._Button32;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button32_Click);
				Button button = this._Button32;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button32 = value;
				button = this._Button32;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x001D6083 File Offset: 0x001D4283
		// (set) Token: 0x06003674 RID: 13940 RVA: 0x001D608D File Offset: 0x001D428D
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x001D6096 File Offset: 0x001D4296
		// (set) Token: 0x06003676 RID: 13942 RVA: 0x001D60A0 File Offset: 0x001D42A0
		internal virtual TextBox txtsearch2
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch2_TextChanged);
				TextBox textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch2 = value;
				textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x001D60E3 File Offset: 0x001D42E3
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x001D60ED File Offset: 0x001D42ED
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x001D60F6 File Offset: 0x001D42F6
		// (set) Token: 0x0600367A RID: 13946 RVA: 0x001D6100 File Offset: 0x001D4300
		internal virtual TextBox txtPromDesc2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x001D6109 File Offset: 0x001D4309
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x001D6113 File Offset: 0x001D4313
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x001D611C File Offset: 0x001D431C
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x001D6126 File Offset: 0x001D4326
		internal virtual TextBox txtPromNum2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x001D612F File Offset: 0x001D432F
		// (set) Token: 0x06003680 RID: 13952 RVA: 0x001D6139 File Offset: 0x001D4339
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x001D6142 File Offset: 0x001D4342
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x001D614C File Offset: 0x001D434C
		internal virtual TextBox txtCurrentPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x001D6155 File Offset: 0x001D4355
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x001D615F File Offset: 0x001D435F
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06003685 RID: 13957 RVA: 0x001D6168 File Offset: 0x001D4368
		// (set) Token: 0x06003686 RID: 13958 RVA: 0x001D6172 File Offset: 0x001D4372
		internal virtual TextBox txtBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x001D617B File Offset: 0x001D437B
		// (set) Token: 0x06003688 RID: 13960 RVA: 0x001D6185 File Offset: 0x001D4385
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x001D618E File Offset: 0x001D438E
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x001D6198 File Offset: 0x001D4398
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x001D61A1 File Offset: 0x001D43A1
		// (set) Token: 0x0600368C RID: 13964 RVA: 0x001D61AC File Offset: 0x001D43AC
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

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x001D61EF File Offset: 0x001D43EF
		// (set) Token: 0x0600368E RID: 13966 RVA: 0x001D61F9 File Offset: 0x001D43F9
		internal virtual CheckBox chkViewAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x001D6204 File Offset: 0x001D4404
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
			this.cboBranch.SelectedIndex = -1;
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x001D62B0 File Offset: 0x001D44B0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboBranch.Text, "", false) != 0;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "PromotionsCreateHeaderN";
					sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd")));
					sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd")));
					sqlCommand.Parameters.AddWithValue("promdesc", this.TextBox1.Text);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					this.Loadpromotions();
					MessageBox.Show("Promotion successfully created. Please add requirements and benefits below.");
					this.txtPromDesc.Text = "";
					this.dgvProms.Rows[0].Selected = true;
					this.txtPromNUm.Text = this.dgvProms.Rows[0].Cells["Promotion_Num"].Value.ToString();
					this.txtPromDesc.Text = this.dgvProms.Rows[0].Cells["Promotion_Name"].Value.ToString();
					this.txtPromNum2.Text = this.dgvProms.Rows[0].Cells["Promotion_Num"].Value.ToString();
					this.txtPromDesc2.Text = this.dgvProms.Rows[0].Cells["Promotion_Name"].Value.ToString();
					this.txtBranch.Text = this.dgvProms.Rows[0].Cells["branch"].Value.ToString();
					this.txtsearch.Focus();
				}
				else
				{
					MessageBox.Show("Please select the branch for the promotion first.");
					this.cboBranch.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error creating promotion. Details: " + ex.Message);
			}
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x001D65C4 File Offset: 0x001D47C4
		private void Loadpromotions()
		{
			this.dgvProms.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionFetchN";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			bool flag = !this.chkViewAll.Checked;
			if (flag)
			{
				sqlCommand.Parameters.AddWithValue("isactive", 1);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvProms.DataSource = dataTable;
			this.dgvProms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Deactivate";
			dataGridViewButtonColumn.Text = "Deactivate";
			dataGridViewButtonColumn.Name = "Deactivate";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvProms.Columns.Insert(5, dataGridViewButtonColumn);
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn2.HeaderText = "Activate";
			dataGridViewButtonColumn2.Text = "Activate";
			dataGridViewButtonColumn2.Name = "Activate";
			dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
			this.dgvProms.Columns.Insert(6, dataGridViewButtonColumn2);
			DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn3.HeaderText = "View Details";
			dataGridViewButtonColumn3.Text = "View";
			dataGridViewButtonColumn3.Name = "View";
			dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
			this.dgvProms.Columns.Insert(7, dataGridViewButtonColumn3);
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x001D678C File Offset: 0x001D498C
		private void PromotionCreate_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.Loadpromotions();
				this.TextBox1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x001D67F0 File Offset: 0x001D49F0
		private void dgvProms_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.txtPromNUm.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value.ToString();
				this.txtPromDesc.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Name"].Value.ToString();
				this.txtPromNum2.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value.ToString();
				this.txtPromDesc2.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Name"].Value.ToString();
				this.txtBranch.Text = this.dgvProms.Rows[e.RowIndex].Cells["branch"].Value.ToString();
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Deactivate", false) == 0;
					if (flag2)
					{
						int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value));
						this.DeactivatePromotion(num, MyProject.Forms.Form1.coid, this.dgvProms.Rows[e.RowIndex].Cells["branch"].Value.ToString());
						MessageBox.Show("Promotion Deactivated.");
						this.Loadpromotions();
					}
					else
					{
						bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Activate", false) == 0;
						if (flag3)
						{
							int num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value));
							this.ActivatePromotion(num2, MyProject.Forms.Form1.coid, this.dgvProms.Rows[e.RowIndex].Cells["branch"].Value.ToString());
							MessageBox.Show("Promotion Activated.");
							this.Loadpromotions();
						}
						else
						{
							bool flag4 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
							if (flag4)
							{
								this.txtPromNUm.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value.ToString();
								this.txtPromDesc.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Name"].Value.ToString();
								this.txtPromNum2.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value.ToString();
								this.txtPromDesc2.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Name"].Value.ToString();
								this.txtBranch.Text = this.dgvProms.Rows[e.RowIndex].Cells["Branch"].Value.ToString();
								this.LoadPromotionDetails(Convert.ToInt32(this.txtPromNUm.Text));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error executing adjustment. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x001D6C90 File Offset: 0x001D4E90
		private void DeactivatePromotion(int promnum, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionDeactivateN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x001D6D3C File Offset: 0x001D4F3C
		private void ActivatePromotion(int promnum, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionActivateN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x001D6DE8 File Offset: 0x001D4FE8
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

		// Token: 0x06003698 RID: 13976 RVA: 0x001D6E54 File Offset: 0x001D5054
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

		// Token: 0x06003699 RID: 13977 RVA: 0x001D6F4C File Offset: 0x001D514C
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
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x001D7124 File Offset: 0x001D5324
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

		// Token: 0x0600369B RID: 13979 RVA: 0x001D7184 File Offset: 0x001D5384
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtBarCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x001D7248 File Offset: 0x001D5448
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

		// Token: 0x0600369D RID: 13981 RVA: 0x001D72A8 File Offset: 0x001D54A8
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtQty.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, Conversion.Val(this.txtBarCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x001D7358 File Offset: 0x001D5558
		private void SearchBarCode(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtProdid.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x001D7448 File Offset: 0x001D5648
		private void SearchProductCode(string prodtcode)
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
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtProdid.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x001D7534 File Offset: 0x001D5734
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.insertPromotionDetail(Convert.ToInt32(this.txtPromNUm.Text), Convert.ToInt32(this.txtProdid.Text), new decimal(Conversion.Val(this.txtQty.Text)));
				this.LoadPromotionDetails(Convert.ToInt32(this.txtPromNUm.Text));
				MessageBox.Show("Product Inserted.");
				this.txtBarCode.Text = "";
				this.txtQty.Text = "";
				this.txtProdid.Text = "";
				this.txtSearchProductCode.Text = "";
				this.txtsearch.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving promotion requirements. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x001D762C File Offset: 0x001D582C
		private void LoadPromotionDetails(int promnum)
		{
			this.dgvPromReq.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionShowDetails";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.txtBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvPromReq.DataSource = dataTable;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvPromReq.Columns.Add(dataGridViewButtonColumn);
			this.dgvPromReq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x001D7748 File Offset: 0x001D5948
		private void insertPromotionDetail(int promnum, int productid, decimal qty)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionDetailsInsertN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("requiredproductid", productid);
			sqlCommand.Parameters.AddWithValue("requiredqty", qty);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x001D783C File Offset: 0x001D5A3C
		private void txtsearch2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.SearchByDesc2(this.txtsearch2.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x001D78A8 File Offset: 0x001D5AA8
		private void SearchByDesc2(string searchtext)
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
				this.DGVSearch2.DataSource = dataTable;
				this.DGVSearch2.Columns["ProductCode"].Visible = false;
				this.DGVSearch2.Columns["ProductID"].Visible = false;
				this.DGVSearch2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror2.Text = "No products match your search.";
			}
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x001D79A0 File Offset: 0x001D5BA0
		private void FetchAllProducts2()
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
				this.DGVSearch2.DataSource = dataTable;
				this.DGVSearch2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DGVSearch2.Columns["CatDesc"].Visible = false;
				this.DGVSearch2.Columns["Reorder_Level"].Visible = false;
				this.DGVSearch2.Columns["Unit_Selling_Price"].Visible = false;
				this.DGVSearch2.Columns["Unit_Cost"].Visible = false;
				this.DGVSearch2.Columns["ProductID"].Visible = false;
				this.DGVSearch2.Columns["ProductCode"].Visible = false;
				this.DGVSearch2.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch2.Columns["Bin_Location"].Visible = false;
				this.DGVSearch2.Columns["Unit_of_Measure"].Visible = false;
			}
			else
			{
				this.lblerror2.Text = "No products match your search.";
			}
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x001D7B5C File Offset: 0x001D5D5C
		private void Button32_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror2.Text = "...";
				this.FetchAllProducts2();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x001D7BBC File Offset: 0x001D5DBC
		private void DGVSearch2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch2.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtBarCode2.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror2.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x001D7C80 File Offset: 0x001D5E80
		private void DGVSearch2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtQty2.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x001D7CE0 File Offset: 0x001D5EE0
		private void txtBarCode2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtQty2.Text = Conversions.ToString(0);
				this.txtDesc2.Text = "No product matches your search.";
				this.SearchBarCode2(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtBarCode2.Text, "", false) == 0, 0, Conversion.Val(this.txtBarCode2.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x001D7D90 File Offset: 0x001D5F90
		private void SearchBarCode2(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtCurrentPrice.Text = dataRow["SellingPrice"].ToString();
				this.txtDesc2.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtProdid2.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode2.Text = "";
			}
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x001D7EA0 File Offset: 0x001D60A0
		private void SearchProductCode2(string prodtcode)
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
				this.txtDesc2.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtProdid2.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode2.Text = "";
			}
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x001D7F8C File Offset: 0x001D618C
		private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
		{
			try
			{
				this.LoadPromotionDetails2(Convert.ToInt32(this.txtPromNum2.Text));
				this.loadPromBenefits(Convert.ToInt32(this.txtPromNum2.Text), MyProject.Forms.Form1.coid, this.txtBranch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading promotion benefits - discount. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x001D801C File Offset: 0x001D621C
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.txtQty2.Text, "", false) != 0) & (Operators.CompareString(this.txtDiscPrice.Text, "", false) != 0);
				if (flag)
				{
					this.InsertBenefitDisc(Convert.ToInt32(this.txtPromNum2.Text), 2, "Freebie", Convert.ToInt32(this.txtProdid2.Text), new decimal(Conversion.Val(this.txtQty2.Text)), Convert.ToDecimal(this.txtDiscPrice.Text), MyProject.Forms.Form1.coid, this.txtBranch.Text);
					this.loadPromBenefits(Convert.ToInt32(this.txtPromNum2.Text), MyProject.Forms.Form1.coid, this.txtBranch.Text);
				}
				MessageBox.Show("Benefit added.");
				this.txtBarCode2.Text = "";
				this.txtCurrentPrice.Text = "";
				this.txtQty2.Text = "";
				this.txtDiscPrice.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving promotion benefit - free discounted product. Detail" + ex.Message);
			}
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x001D8198 File Offset: 0x001D6398
		private void InsertBenefitDisc(int promnum, int benefittype, string benefitdesc, int productid, decimal discQty, decimal discPrice, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionsInsertBenefitN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("benefittype", benefittype);
			sqlCommand.Parameters.AddWithValue("benefitdesc", benefitdesc);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("discQty", discQty);
			sqlCommand.Parameters.AddWithValue("discPrice", discPrice);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x001D82B8 File Offset: 0x001D64B8
		private void InsertBenefitDisc2(int promnum, int benefittype, string benefitdesc, int productid, decimal discAmt, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionsInsertBenefitDiscN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("benefittype", benefittype);
			sqlCommand.Parameters.AddWithValue("benefitdesc", benefitdesc);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("discAmt", discAmt);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x001D83C0 File Offset: 0x001D65C0
		private void DeleteBenefitDisc2(int promnum, int entryno, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionsDeleteBenefitDiscN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x001D8484 File Offset: 0x001D6684
		private void DeletePromotionReq(int promnum, int entryno, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionDetailsDelete";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x001D8548 File Offset: 0x001D6748
		private void loadPromBenefits(int promnum, int coid, string branch)
		{
			this.dgvBenefitsFree.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionShowBenefitN";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvBenefitsFree.DataSource = dataTable;
			this.dgvBenefitsFree.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Item";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvBenefitsFree.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x001D864C File Offset: 0x001D684C
		private void LoadPromotionDetails2(int promnum)
		{
			this.dgvPromProds.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PromotionShowDetails";
			sqlCommand.Parameters.AddWithValue("promnum", promnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.txtBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvPromProds.DataSource = dataTable;
			this.dgvPromProds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPromProds.Columns["RequiredProductID"].HeaderText = "Product ID";
			this.dgvPromProds.Columns["ProductDesc"].HeaderText = "Description";
			this.dgvPromProds.Columns["PromotionNo"].HeaderText = "Promotion Number";
			this.dgvPromProds.Columns["RequiredQty"].HeaderText = "Qty";
			this.dgvPromProds.Columns["Current_Selling_Price"].HeaderText = "Current Selling Price";
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "Discount for Product";
			dataGridViewTextBoxColumn.Name = "colDisc";
			this.dgvPromProds.Columns.Add(dataGridViewTextBoxColumn);
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x001D87F0 File Offset: 0x001D69F0
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvPromProds.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						string text = "";
						try
						{
							text = dataGridViewRow.Cells[0].Value.ToString();
						}
						catch (Exception ex)
						{
						}
						bool flag = Operators.CompareString(text, "", false) != 0;
						if (flag)
						{
							this.InsertBenefitDisc2(Convert.ToInt32(this.txtPromNum2.Text), 1, "Discount", Conversions.ToInteger(dataGridViewRow.Cells["RequiredProductID"].Value), Convert.ToDecimal(text), MyProject.Forms.Form1.coid, this.txtBranch.Text);
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
				this.loadPromBenefits(Convert.ToInt32(this.txtPromNum2.Text), MyProject.Forms.Form1.coid, this.txtBranch.Text);
				MessageBox.Show("Promotion Benefits added.");
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error loading. Detail: " + ex2.Message);
			}
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x001D8998 File Offset: 0x001D6B98
		private void dgvProms_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.txtPromNUm.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value.ToString();
				this.txtPromDesc.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Name"].Value.ToString();
				this.txtPromNum2.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Num"].Value.ToString();
				this.txtPromDesc2.Text = this.dgvProms.Rows[e.RowIndex].Cells["Promotion_Name"].Value.ToString();
				this.txtBranch.Text = this.dgvProms.Rows[e.RowIndex].Cells["Branch"].Value.ToString();
				this.LoadPromotionDetails(Convert.ToInt32(this.txtPromNUm.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading promotion benefits on tab load. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProductCode2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtProdid_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtProdid2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x001D8B2C File Offset: 0x001D6D2C
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboBranch.Text, "", false) != 0;
				if (flag)
				{
					this.Loadpromotions();
				}
				else
				{
					MessageBox.Show("Please select a branch first");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying promotions" + ex.Message);
			}
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x001D8BA8 File Offset: 0x001D6DA8
		private void dgvPromReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						this.DeletePromotionReq(Conversions.ToInteger(this.dgvPromReq.Rows[e.RowIndex].Cells["PromotionNo"].Value), Conversions.ToInteger(this.dgvPromReq.Rows[e.RowIndex].Cells["Entryno"].Value), MyProject.Forms.Form1.coid, this.txtBranch.Text);
						this.LoadPromotionDetails(Convert.ToInt32(this.txtPromNUm.Text));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x001D8CE8 File Offset: 0x001D6EE8
		private void dgvBenefitsFree_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						this.DeleteBenefitDisc2(Conversions.ToInteger(this.dgvBenefitsFree.Rows[e.RowIndex].Cells["PromotionNo"].Value), Conversions.ToInteger(this.dgvBenefitsFree.Rows[e.RowIndex].Cells["Entryno"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
						this.loadPromBenefits(Convert.ToInt32(this.txtPromNum2.Text), MyProject.Forms.Form1.coid, this.txtBranch.Text);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400176D RID: 5997
		private string _cnn;
	}
}
