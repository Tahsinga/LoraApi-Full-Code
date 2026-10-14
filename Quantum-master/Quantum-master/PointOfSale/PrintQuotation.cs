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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200016C RID: 364
	[DesignerGenerated]
	public partial class PrintQuotation : Form
	{
		// Token: 0x0600322E RID: 12846 RVA: 0x001B2070 File Offset: 0x001B0270
		public PrintQuotation()
		{
			base.Load += this.PrintQuotation_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.datCustomers = new DataTable();
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.TextToPrint = "";
			this.mono_rate = 0m;
			this.pf = new PublicFunctions();
			this.currCustomerEntryno = 0;
			this.altdescription = "";
			this.InitializeComponent();
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x001B6C18 File Offset: 0x001B4E18
		// (set) Token: 0x06003232 RID: 12850 RVA: 0x001B6C22 File Offset: 0x001B4E22
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x001B6C2B File Offset: 0x001B4E2B
		// (set) Token: 0x06003234 RID: 12852 RVA: 0x001B6C35 File Offset: 0x001B4E35
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x001B6C3E File Offset: 0x001B4E3E
		// (set) Token: 0x06003236 RID: 12854 RVA: 0x001B6C48 File Offset: 0x001B4E48
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x001B6C51 File Offset: 0x001B4E51
		// (set) Token: 0x06003238 RID: 12856 RVA: 0x001B6C5C File Offset: 0x001B4E5C
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
				DataGridViewRowEventHandler dataGridViewRowEventHandler = new DataGridViewRowEventHandler(this.DataGridView1_UserDeletedRow);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow -= dataGridViewRowEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.UserDeletedRow += dataGridViewRowEventHandler;
				}
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x001B6C9F File Offset: 0x001B4E9F
		// (set) Token: 0x0600323A RID: 12858 RVA: 0x001B6CA9 File Offset: 0x001B4EA9
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x001B6CB2 File Offset: 0x001B4EB2
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x001B6CBC File Offset: 0x001B4EBC
		internal virtual Panel Panel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x001B6CC5 File Offset: 0x001B4EC5
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x001B6CD0 File Offset: 0x001B4ED0
		internal virtual Button Button9
		{
			[CompilerGenerated]
			get
			{
				return this._Button9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button9_Click);
				Button button = this._Button9;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button9 = value;
				button = this._Button9;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x001B6D13 File Offset: 0x001B4F13
		// (set) Token: 0x06003240 RID: 12864 RVA: 0x001B6D20 File Offset: 0x001B4F20
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

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06003241 RID: 12865 RVA: 0x001B6D63 File Offset: 0x001B4F63
		// (set) Token: 0x06003242 RID: 12866 RVA: 0x001B6D6D File Offset: 0x001B4F6D
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06003243 RID: 12867 RVA: 0x001B6D76 File Offset: 0x001B4F76
		// (set) Token: 0x06003244 RID: 12868 RVA: 0x001B6D80 File Offset: 0x001B4F80
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x001B6D89 File Offset: 0x001B4F89
		// (set) Token: 0x06003246 RID: 12870 RVA: 0x001B6D93 File Offset: 0x001B4F93
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06003247 RID: 12871 RVA: 0x001B6D9C File Offset: 0x001B4F9C
		// (set) Token: 0x06003248 RID: 12872 RVA: 0x001B6DA6 File Offset: 0x001B4FA6
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x001B6DAF File Offset: 0x001B4FAF
		// (set) Token: 0x0600324A RID: 12874 RVA: 0x001B6DB9 File Offset: 0x001B4FB9
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x001B6DC2 File Offset: 0x001B4FC2
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x001B6DCC File Offset: 0x001B4FCC
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x001B6DD5 File Offset: 0x001B4FD5
		// (set) Token: 0x0600324E RID: 12878 RVA: 0x001B6DDF File Offset: 0x001B4FDF
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x001B6DE8 File Offset: 0x001B4FE8
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x001B6DF4 File Offset: 0x001B4FF4
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

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x001B6E37 File Offset: 0x001B5037
		// (set) Token: 0x06003252 RID: 12882 RVA: 0x001B6E41 File Offset: 0x001B5041
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x001B6E4A File Offset: 0x001B504A
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x001B6E54 File Offset: 0x001B5054
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x001B6E5D File Offset: 0x001B505D
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x001B6E67 File Offset: 0x001B5067
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x001B6E70 File Offset: 0x001B5070
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x001B6E7A File Offset: 0x001B507A
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x001B6E83 File Offset: 0x001B5083
		// (set) Token: 0x0600325A RID: 12890 RVA: 0x001B6E8D File Offset: 0x001B508D
		internal virtual TextBox txtInvDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x001B6E96 File Offset: 0x001B5096
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x001B6EA0 File Offset: 0x001B50A0
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x001B6EA9 File Offset: 0x001B50A9
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x001B6EB3 File Offset: 0x001B50B3
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x001B6EBC File Offset: 0x001B50BC
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x001B6EC6 File Offset: 0x001B50C6
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x001B6ECF File Offset: 0x001B50CF
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x001B6ED9 File Offset: 0x001B50D9
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x001B6EE2 File Offset: 0x001B50E2
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x001B6EEC File Offset: 0x001B50EC
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x001B6EF5 File Offset: 0x001B50F5
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x001B6EFF File Offset: 0x001B50FF
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x001B6F08 File Offset: 0x001B5108
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x001B6F12 File Offset: 0x001B5112
		internal virtual TextBox txtContactName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x001B6F1B File Offset: 0x001B511B
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x001B6F25 File Offset: 0x001B5125
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x001B6F2E File Offset: 0x001B512E
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x001B6F38 File Offset: 0x001B5138
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x001B6F41 File Offset: 0x001B5141
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x001B6F4B File Offset: 0x001B514B
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x001B6F54 File Offset: 0x001B5154
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x001B6F5E File Offset: 0x001B515E
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x001B6F67 File Offset: 0x001B5167
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x001B6F71 File Offset: 0x001B5171
		internal virtual TextBox txtcustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x001B6F7A File Offset: 0x001B517A
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x001B6F84 File Offset: 0x001B5184
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x001B6F8D File Offset: 0x001B518D
		// (set) Token: 0x06003276 RID: 12918 RVA: 0x001B6F97 File Offset: 0x001B5197
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x001B6FA0 File Offset: 0x001B51A0
		// (set) Token: 0x06003278 RID: 12920 RVA: 0x001B6FAA File Offset: 0x001B51AA
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x001B6FB3 File Offset: 0x001B51B3
		// (set) Token: 0x0600327A RID: 12922 RVA: 0x001B6FBD File Offset: 0x001B51BD
		internal virtual Label lblpaymeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x001B6FC6 File Offset: 0x001B51C6
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x001B6FD0 File Offset: 0x001B51D0
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x001B6FD9 File Offset: 0x001B51D9
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x001B6FE4 File Offset: 0x001B51E4
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

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x001B7027 File Offset: 0x001B5227
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x001B7031 File Offset: 0x001B5231
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x001B703A File Offset: 0x001B523A
		// (set) Token: 0x06003282 RID: 12930 RVA: 0x001B7044 File Offset: 0x001B5244
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x001B704D File Offset: 0x001B524D
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x001B7058 File Offset: 0x001B5258
		internal virtual ComboBox cboCustomers
		{
			[CompilerGenerated]
			get
			{
				return this._cboCustomers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCustomers_SelectedIndexChanged);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x001B709B File Offset: 0x001B529B
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x001B70A5 File Offset: 0x001B52A5
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x001B70AE File Offset: 0x001B52AE
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x001B70B8 File Offset: 0x001B52B8
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x001B70C1 File Offset: 0x001B52C1
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x001B70CB File Offset: 0x001B52CB
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x001B70D4 File Offset: 0x001B52D4
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x001B70DE File Offset: 0x001B52DE
		internal virtual TextBox txtOLDprice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x001B70E7 File Offset: 0x001B52E7
		// (set) Token: 0x0600328E RID: 12942 RVA: 0x001B70F1 File Offset: 0x001B52F1
		internal virtual Label lblCouponInfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x001B70FA File Offset: 0x001B52FA
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x001B7104 File Offset: 0x001B5304
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x001B710D File Offset: 0x001B530D
		// (set) Token: 0x06003292 RID: 12946 RVA: 0x001B7117 File Offset: 0x001B5317
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x001B7120 File Offset: 0x001B5320
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x001B712C File Offset: 0x001B532C
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

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x001B716F File Offset: 0x001B536F
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x001B7179 File Offset: 0x001B5379
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x001B7182 File Offset: 0x001B5382
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x001B718C File Offset: 0x001B538C
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

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x001B71CF File Offset: 0x001B53CF
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x001B71D9 File Offset: 0x001B53D9
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x001B71E2 File Offset: 0x001B53E2
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x001B71EC File Offset: 0x001B53EC
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x001B71F5 File Offset: 0x001B53F5
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x001B7200 File Offset: 0x001B5400
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

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x001B7243 File Offset: 0x001B5443
		// (set) Token: 0x060032A0 RID: 12960 RVA: 0x001B724D File Offset: 0x001B544D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x001B7256 File Offset: 0x001B5456
		// (set) Token: 0x060032A2 RID: 12962 RVA: 0x001B7260 File Offset: 0x001B5460
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060032A3 RID: 12963 RVA: 0x001B7269 File Offset: 0x001B5469
		// (set) Token: 0x060032A4 RID: 12964 RVA: 0x001B7273 File Offset: 0x001B5473
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060032A5 RID: 12965 RVA: 0x001B727C File Offset: 0x001B547C
		// (set) Token: 0x060032A6 RID: 12966 RVA: 0x001B7286 File Offset: 0x001B5486
		internal virtual TextBox txtQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060032A7 RID: 12967 RVA: 0x001B728F File Offset: 0x001B548F
		// (set) Token: 0x060032A8 RID: 12968 RVA: 0x001B7299 File Offset: 0x001B5499
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x001B72A2 File Offset: 0x001B54A2
		// (set) Token: 0x060032AA RID: 12970 RVA: 0x001B72AC File Offset: 0x001B54AC
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x001B72B5 File Offset: 0x001B54B5
		// (set) Token: 0x060032AC RID: 12972 RVA: 0x001B72BF File Offset: 0x001B54BF
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x001B72C8 File Offset: 0x001B54C8
		// (set) Token: 0x060032AE RID: 12974 RVA: 0x001B72D2 File Offset: 0x001B54D2
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x001B72DB File Offset: 0x001B54DB
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x001B72E5 File Offset: 0x001B54E5
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x001B72EE File Offset: 0x001B54EE
		// (set) Token: 0x060032B2 RID: 12978 RVA: 0x001B72F8 File Offset: 0x001B54F8
		internal virtual Button Button5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x001B7301 File Offset: 0x001B5501
		// (set) Token: 0x060032B4 RID: 12980 RVA: 0x001B730C File Offset: 0x001B550C
		internal virtual Button btnSpecialPrice
		{
			[CompilerGenerated]
			get
			{
				return this._btnSpecialPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnSpecialPrice_Click);
				Button button = this._btnSpecialPrice;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnSpecialPrice = value;
				button = this._btnSpecialPrice;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x001B734F File Offset: 0x001B554F
		// (set) Token: 0x060032B6 RID: 12982 RVA: 0x001B7359 File Offset: 0x001B5559
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060032B7 RID: 12983 RVA: 0x001B7362 File Offset: 0x001B5562
		// (set) Token: 0x060032B8 RID: 12984 RVA: 0x001B736C File Offset: 0x001B556C
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

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x001B73CA File Offset: 0x001B55CA
		// (set) Token: 0x060032BA RID: 12986 RVA: 0x001B73D4 File Offset: 0x001B55D4
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x001B73DD File Offset: 0x001B55DD
		// (set) Token: 0x060032BC RID: 12988 RVA: 0x001B73E8 File Offset: 0x001B55E8
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

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x001B742B File Offset: 0x001B562B
		// (set) Token: 0x060032BE RID: 12990 RVA: 0x001B7435 File Offset: 0x001B5635
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x001B743E File Offset: 0x001B563E
		// (set) Token: 0x060032C0 RID: 12992 RVA: 0x001B7448 File Offset: 0x001B5648
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

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x001B74A6 File Offset: 0x001B56A6
		// (set) Token: 0x060032C2 RID: 12994 RVA: 0x001B74B0 File Offset: 0x001B56B0
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060032C3 RID: 12995 RVA: 0x001B74B9 File Offset: 0x001B56B9
		// (set) Token: 0x060032C4 RID: 12996 RVA: 0x001B74C3 File Offset: 0x001B56C3
		internal virtual PrintDocument PrintDocument1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060032C5 RID: 12997 RVA: 0x001B74CC File Offset: 0x001B56CC
		// (set) Token: 0x060032C6 RID: 12998 RVA: 0x001B74D8 File Offset: 0x001B56D8
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060032C7 RID: 12999 RVA: 0x001B751B File Offset: 0x001B571B
		// (set) Token: 0x060032C8 RID: 13000 RVA: 0x001B7525 File Offset: 0x001B5725
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x001B752E File Offset: 0x001B572E
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x001B7538 File Offset: 0x001B5738
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x001B7541 File Offset: 0x001B5741
		// (set) Token: 0x060032CC RID: 13004 RVA: 0x001B754B File Offset: 0x001B574B
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060032CD RID: 13005 RVA: 0x001B7554 File Offset: 0x001B5754
		// (set) Token: 0x060032CE RID: 13006 RVA: 0x001B755E File Offset: 0x001B575E
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x001B7567 File Offset: 0x001B5767
		// (set) Token: 0x060032D0 RID: 13008 RVA: 0x001B7574 File Offset: 0x001B5774
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

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060032D1 RID: 13009 RVA: 0x001B75B7 File Offset: 0x001B57B7
		// (set) Token: 0x060032D2 RID: 13010 RVA: 0x001B75C1 File Offset: 0x001B57C1
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060032D3 RID: 13011 RVA: 0x001B75CA File Offset: 0x001B57CA
		// (set) Token: 0x060032D4 RID: 13012 RVA: 0x001B75D4 File Offset: 0x001B57D4
		internal virtual DateTimePicker DTStart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x060032D5 RID: 13013 RVA: 0x001B75DD File Offset: 0x001B57DD
		// (set) Token: 0x060032D6 RID: 13014 RVA: 0x001B75E7 File Offset: 0x001B57E7
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x060032D7 RID: 13015 RVA: 0x001B75F0 File Offset: 0x001B57F0
		// (set) Token: 0x060032D8 RID: 13016 RVA: 0x001B75FA File Offset: 0x001B57FA
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x001B7603 File Offset: 0x001B5803
		// (set) Token: 0x060032DA RID: 13018 RVA: 0x001B7610 File Offset: 0x001B5810
		internal virtual ComboBox cboQuotationHeader
		{
			[CompilerGenerated]
			get
			{
				return this._cboQuotationHeader;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboQuotationHeader_SelectedIndexChanged);
				ComboBox comboBox = this._cboQuotationHeader;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboQuotationHeader = value;
				comboBox = this._cboQuotationHeader;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x001B7653 File Offset: 0x001B5853
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x001B765D File Offset: 0x001B585D
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x001B7666 File Offset: 0x001B5866
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x001B7670 File Offset: 0x001B5870
		internal virtual TextBox txtDisc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x001B7679 File Offset: 0x001B5879
		// (set) Token: 0x060032E0 RID: 13024 RVA: 0x001B7683 File Offset: 0x001B5883
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x060032E1 RID: 13025 RVA: 0x001B768C File Offset: 0x001B588C
		// (set) Token: 0x060032E2 RID: 13026 RVA: 0x001B7698 File Offset: 0x001B5898
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

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x060032E3 RID: 13027 RVA: 0x001B76DB File Offset: 0x001B58DB
		// (set) Token: 0x060032E4 RID: 13028 RVA: 0x001B76E8 File Offset: 0x001B58E8
		internal virtual Button Button21
		{
			[CompilerGenerated]
			get
			{
				return this._Button21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button21_Click);
				Button button = this._Button21;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button21 = value;
				button = this._Button21;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x001B772B File Offset: 0x001B592B
		// (set) Token: 0x060032E6 RID: 13030 RVA: 0x001B7735 File Offset: 0x001B5935
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x060032E7 RID: 13031 RVA: 0x001B773E File Offset: 0x001B593E
		// (set) Token: 0x060032E8 RID: 13032 RVA: 0x001B7748 File Offset: 0x001B5948
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x060032E9 RID: 13033 RVA: 0x001B7751 File Offset: 0x001B5951
		// (set) Token: 0x060032EA RID: 13034 RVA: 0x001B775B File Offset: 0x001B595B
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x060032EB RID: 13035 RVA: 0x001B7764 File Offset: 0x001B5964
		// (set) Token: 0x060032EC RID: 13036 RVA: 0x001B776E File Offset: 0x001B596E
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x001B7777 File Offset: 0x001B5977
		// (set) Token: 0x060032EE RID: 13038 RVA: 0x001B7781 File Offset: 0x001B5981
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x001B778A File Offset: 0x001B598A
		// (set) Token: 0x060032F0 RID: 13040 RVA: 0x001B7794 File Offset: 0x001B5994
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x060032F1 RID: 13041 RVA: 0x001B779D File Offset: 0x001B599D
		// (set) Token: 0x060032F2 RID: 13042 RVA: 0x001B77A7 File Offset: 0x001B59A7
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x001B77B0 File Offset: 0x001B59B0
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x001B77BA File Offset: 0x001B59BA
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x001B77C3 File Offset: 0x001B59C3
		// (set) Token: 0x060032F6 RID: 13046 RVA: 0x001B77CD File Offset: 0x001B59CD
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x060032F7 RID: 13047 RVA: 0x001B77D6 File Offset: 0x001B59D6
		// (set) Token: 0x060032F8 RID: 13048 RVA: 0x001B77E0 File Offset: 0x001B59E0
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x060032F9 RID: 13049 RVA: 0x001B77E9 File Offset: 0x001B59E9
		// (set) Token: 0x060032FA RID: 13050 RVA: 0x001B77F3 File Offset: 0x001B59F3
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x060032FB RID: 13051 RVA: 0x001B77FC File Offset: 0x001B59FC
		// (set) Token: 0x060032FC RID: 13052 RVA: 0x001B7806 File Offset: 0x001B5A06
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x001B780F File Offset: 0x001B5A0F
		// (set) Token: 0x060032FE RID: 13054 RVA: 0x001B7819 File Offset: 0x001B5A19
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x001B7822 File Offset: 0x001B5A22
		// (set) Token: 0x06003300 RID: 13056 RVA: 0x001B782C File Offset: 0x001B5A2C
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06003301 RID: 13057 RVA: 0x001B7835 File Offset: 0x001B5A35
		// (set) Token: 0x06003302 RID: 13058 RVA: 0x001B783F File Offset: 0x001B5A3F
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x001B7848 File Offset: 0x001B5A48
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x001B7852 File Offset: 0x001B5A52
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x001B785B File Offset: 0x001B5A5B
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x001B7865 File Offset: 0x001B5A65
		internal virtual DataGridViewTextBoxColumn DiscPaymentMethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x001B786E File Offset: 0x001B5A6E
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x001B7878 File Offset: 0x001B5A78
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x001B7881 File Offset: 0x001B5A81
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x001B788B File Offset: 0x001B5A8B
		internal virtual DataGridViewTextBoxColumn taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x0600330B RID: 13067 RVA: 0x001B7894 File Offset: 0x001B5A94
		// (set) Token: 0x0600330C RID: 13068 RVA: 0x001B789E File Offset: 0x001B5A9E
		internal virtual DataGridViewTextBoxColumn AltDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x001B78A7 File Offset: 0x001B5AA7
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x001B78B1 File Offset: 0x001B5AB1
		internal virtual DataGridViewTextBoxColumn HSCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x001B78BC File Offset: 0x001B5ABC
		private void PrintQuotation_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.AllowTellerToViewStockBalances == 0;
				if (flag)
				{
					this.Label3.Visible = false;
					this.txtStockAvail.Visible = false;
				}
				bool flag2 = MyProject.Forms.Form1.ShowSpecialPrice == 1;
				if (flag2)
				{
					this.btnSpecialPrice.Visible = true;
				}
				this.GetBranchDetails();
				this.LoadPayMeths();
				this.LoadCustomers();
				bool flag3 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag3)
				{
					this.txtsearch.Focus();
				}
				else
				{
					this.txtBarCode.Focus();
				}
				this.LoadBranch();
				this.cboQuotationHeader.SelectedIndex = 0;
				base.WindowState = FormWindowState.Maximized;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x001B79C0 File Offset: 0x001B5BC0
		private void LoadBranch()
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
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x001B7A60 File Offset: 0x001B5C60
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
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x001B7B00 File Offset: 0x001B5D00
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
					this.footnote = dataRow["Footnote"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x001B7C94 File Offset: 0x001B5E94
		private void LoadCustomers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(this.datCustomers);
			this.cboCustomers.DataSource = this.datCustomers;
			this.cboCustomers.DisplayMember = "CustomerName";
			this.cboCustomers.ValueMember = "Entryno";
			this.cboCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cboCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x001B7D74 File Offset: 0x001B5F74
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

		// Token: 0x06003315 RID: 13077 RVA: 0x001B7DFC File Offset: 0x001B5FFC
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

		// Token: 0x06003316 RID: 13078 RVA: 0x001B7EF4 File Offset: 0x001B60F4
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

		// Token: 0x06003317 RID: 13079 RVA: 0x001B8000 File Offset: 0x001B6200
		private object searchDat(DataTable dt, string column, string value)
		{
			PrintQuotation._Closure$__482-0 CS$<>8__locals1 = new PrintQuotation._Closure$__482-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((PrintQuotation._Closure$__.$I482-0 == null) ? (PrintQuotation._Closure$__.$I482-0 = (object row1) => (DataRow)row1) : PrintQuotation._Closure$__.$I482-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06003318 RID: 13080 RVA: 0x001B80DC File Offset: 0x001B62DC
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

		// Token: 0x06003319 RID: 13081 RVA: 0x001B8164 File Offset: 0x001B6364
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

		// Token: 0x0600331A RID: 13082 RVA: 0x001B833C File Offset: 0x001B653C
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

		// Token: 0x0600331B RID: 13083 RVA: 0x001B839C File Offset: 0x001B659C
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x001B8460 File Offset: 0x001B6660
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
				MessageBox.Show("Key down error on search. Ignore");
			}
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x001B84C0 File Offset: 0x001B66C0
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtPrice.Text = Conversions.ToString(0);
				this.txtQty.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x001B858C File Offset: 0x001B678C
		private void SearchBarCode(int prodtID)
		{
			this.WholesalePriceByQty = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = num2 == 0;
				decimal num3;
				decimal num4;
				if (flag2)
				{
					num3 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate);
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
					this.CurrentSpecialPrice = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				}
				else
				{
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					num3 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate);
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
					this.CurrentSpecialPrice = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
				}
				this.priceb4tax = num3;
				this.priceb4tax = Math.Round(this.priceb4tax, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
				decimal num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				bool flag3 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
				if (flag3)
				{
					decimal num6 = decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3));
					num6 = Math.Round(num6, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					this.priceb4taxWholesale = num4;
					this.priceb4taxWholesale = Math.Round(this.priceb4taxWholesale, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(Math.Round(decimal.Divide(this.taxdueWholesale, 100m), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero), num4));
					this.totpriceWholesale = Math.Round(this.totpriceWholesale, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					bool flag4 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag4)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num6.ToString();
					}
				}
				else
				{
					num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.priceb4tax = Math.Round(decimal.Divide(num3, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					decimal num7 = num3;
					num7 = num7;
					this.priceb4taxWholesale = Math.Round(decimal.Divide(num4, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = num4;
					bool flag5 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag5)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num7.ToString();
					}
				}
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num5.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]), RuntimeHelpers.GetObjectValue(dataRow["HSCode"])));
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x001B8D14 File Offset: 0x001B6F14
		private void SearchProductCode(string prodtcode)
		{
			this.WholesalePriceByQty = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
				bool flag2 = num2 == 0;
				decimal num3;
				decimal num4;
				if (flag2)
				{
					num3 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate);
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
					this.CurrentSpecialPrice = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SpecialPrice"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
				}
				else
				{
					DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
					num3 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate);
					num4 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
					this.CurrentSpecialPrice = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["specialprice"])))), this.mono_rate);
					this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
				}
				this.priceb4tax = num3;
				this.priceb4tax = Math.Round(this.priceb4tax, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
				decimal num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				bool flag3 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
				if (flag3)
				{
					decimal num6 = decimal.Add(num3, decimal.Multiply(decimal.Divide(num5, 100m), num3));
					num6 = Math.Round(num6, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					this.priceb4taxWholesale = num4;
					this.priceb4taxWholesale = Math.Round(this.priceb4taxWholesale, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = decimal.Add(num4, decimal.Multiply(Math.Round(decimal.Divide(this.taxdueWholesale, 100m), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero), num4));
					this.totpriceWholesale = Math.Round(this.totpriceWholesale, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					bool flag4 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag4)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num6.ToString();
					}
				}
				else
				{
					num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.priceb4tax = Math.Round(decimal.Divide(num3, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					decimal num7 = num3;
					num7 = num7;
					this.priceb4taxWholesale = Math.Round(decimal.Divide(num4, decimal.Add(1m, decimal.Divide(num5, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					this.totpriceWholesale = num4;
					bool flag5 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag5)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num7.ToString();
					}
				}
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num5.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), RuntimeHelpers.GetObjectValue(dataRow["ProductCode"]), RuntimeHelpers.GetObjectValue(dataRow["HSCode"])));
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x001B9494 File Offset: 0x001B7694
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

		// Token: 0x06003321 RID: 13089 RVA: 0x001B9700 File Offset: 0x001B7900
		private void AppendGrid()
		{
			int num = 0;
			int num2 = 0;
			decimal num3 = new decimal(Conversion.Val(this.txtDisc.Text));
			decimal num4 = Convert.ToDecimal(this.lbltax.Text);
			decimal num5 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num3);
			bool flag = decimal.Compare(num4, 0m) != 0;
			decimal num6;
			decimal num7;
			if (flag)
			{
				num6 = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num4, 100m))), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
				num7 = new decimal(Math.Round(Convert.ToDouble(decimal.Divide(num4, 100m)) * (Convert.ToDouble(num6) * Conversion.Val(this.txtQty.Text)), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
			}
			else
			{
				num6 = num5;
				num7 = 0m;
			}
			decimal num8 = new decimal(Conversion.Val(this.txtQty.Text) * Convert.ToDouble(num6) + Convert.ToDouble(decimal.Divide(num4, 100m)) * (Convert.ToDouble(num6) * Conversion.Val(this.txtQty.Text)));
			num8 = Math.Round(num8, MyProject.Forms.Form1.DecimalPlaces);
			string[] array = new string[]
			{
				Conversions.ToString(this.CurrentID),
				this.CurrentCode,
				this.txtDesc.Text + " " + this.altdescription,
				num6.ToString(),
				this.txtQty.Text,
				num7.ToString(),
				num8.ToString(),
				this.lblcost.Text,
				Conversions.ToString(num),
				Conversions.ToString(this.priceb4tax),
				Conversions.ToString(num2),
				"0",
				"",
				Conversions.ToString(MyProject.Forms.Form1.IsWholesaleShop),
				Conversions.ToString(this.WholesalePriceByQty),
				"",
				"",
				Conversions.ToString(Conversion.Val(this.txtDisc.Text)),
				(Conversion.Val(this.lbltax.Text) / 100.0).ToString(),
				this.altdescription,
				this.CurrentHSCode
			};
			this.DataGridView1.Rows.Add(array);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x001B99AC File Offset: 0x001B7BAC
		private void CalcTotalSale()
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
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
			this.txtTotal.Text = Conversions.ToString(num);
			this.txtTax.Text = Conversions.ToString(num2);
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x001B9A8C File Offset: 0x001B7C8C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Conversion.Val(this.txtPrice.Text) > 0.0) & (Conversion.Val(this.txtQty.Text) > 0.0);
				if (flag)
				{
					this.AppendGrid();
					this.CalcTotalSale();
					this.txtSearchProductCode.Text = " ";
					this.txtBarCode.Text = "0";
					this.txtQty.Text = Conversions.ToString(0);
					this.lblCouponInfo.Text = "...";
					this.txtsearch.Text = "";
					this.txtBarCode.Text = "";
					bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag2)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
					this.lblcode.Text = "";
					this.WholesalePriceByQty = 0;
					this.txtDisc.Text = "0";
					this.cboPayMeth.Enabled = false;
					this.lbltax.Text = "0";
				}
				else
				{
					MessageBox.Show("Please enter the quantity bought.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x001B9C1C File Offset: 0x001B7E1C
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtPrice.Text = Conversions.ToString(0);
				this.txtQty.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x001B9CF4 File Offset: 0x001B7EF4
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveQuote();
				this.PrintHeaderQuotation();
				this.ItemsToBePrintedQuotation();
				this.PrintFooterQuotation();
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
				MessageBox.Show("Quotation saved and print job sent to printer.");
				this.DataGridView1.Rows.Clear();
				this.cboPayMeth.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x001B9DA0 File Offset: 0x001B7FA0
		private void SaveQuote()
		{
			bool flag = this.DataGridView1.Rows.Count > 0;
			if (flag)
			{
				try
				{
					this.SaveCustomerDetails();
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunQuotationSaveAll");
					sqlCommand.Transaction = sqlTransaction;
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "InsertQuotationDetailsHeader";
					sqlCommand.Parameters.AddWithValue("quotation_num", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
					this.quotation_number = Conversions.ToInteger(sqlCommand.ExecuteScalar());
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertQuotationDetails";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProdtID"].Value));
							sqlCommand.Parameters.AddWithValue("productcode", dataGridViewRow.Cells["ProductCode"].Value.ToString());
							sqlCommand.Parameters.AddWithValue("productdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Desc"].Value));
							sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value));
							sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitCost"].Value));
							sqlCommand.Parameters.AddWithValue("sellingprice", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value));
							sqlCommand.Parameters.AddWithValue("tax", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
							sqlCommand.Parameters.AddWithValue("customerref", this.txtcustomer.Text);
							sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("createddate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("paymentmethod", this.cboPayMeth.Text);
							sqlCommand.Parameters.AddWithValue("quotationnumber", this.quotation_number);
							sqlCommand.Parameters.AddWithValue("discamt", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscAmount2"].Value));
							sqlCommand.Parameters.AddWithValue("customerentryno", this.currCustomerEntryno);
							sqlCommand.Parameters.AddWithValue("oldprice", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["OldPrice"].Value));
							sqlCommand.Parameters.AddWithValue("taxrate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["taxr"].Value));
							sqlCommand.Parameters.AddWithValue("altdesc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["AltDesc"].Value));
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
					MessageBox.Show("Saved successfully.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error generating quotation. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x001BA29C File Offset: 0x001B849C
		private void PrintHeaderQuotation()
		{
			this.TextToPrint = "";
			string text = "QUOTATION";
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
				text3 = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				text3 = "Teller: " + MyProject.Forms.Form1.username;
				num = text3.Length;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine;
			}
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x001BA614 File Offset: 0x001B8814
		private void ItemsToBePrintedQuotation()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag = Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0;
			if (flag)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Customer:" + this.txtcustomer.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Details:" + this.txtAddress.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Description" + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			decimal num = 0m;
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						string text = dataGridViewRow.Cells["Desc"].Value.ToString();
						num = Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value);
						double num2 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value)));
						double num3 = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
						string text2 = dataGridViewRow.Cells["ProductCode"].Value.ToString();
						int num4 = (int)Math.Round(Conversion.Val(text.Length));
						bool flag2 = num4 >= 34;
						if (flag2)
						{
							text = text.Substring(0, 33);
						}
						else
						{
							int num5 = num4;
							int num6 = 34 - num5;
							text = text.PadRight(num6);
						}
						int length = text.Length;
						string text3 = text;
						string text4 = Conversions.ToString(text3.Length);
						string text5 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine;
						decimal num7 = 0m;
						string text6 = "               ";
						bool flag3 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
						if (flag3)
						{
							decimal num8 = new decimal(unchecked(num2 * Convert.ToDouble(this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod))));
							num7 = decimal.Multiply(num8, num);
							string text7 = Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True);
							int length2 = num8.ToString().Length;
							int i = length2 - 5;
							bool flag4 = i > 0;
							if (flag4)
							{
								while (i > 0)
								{
									text6 = text6.Substring(0, text6.Length - 1);
									i--;
								}
							}
							else
							{
								bool flag5 = i < 0;
								if (flag5)
								{
								}
							}
							text3 = string.Concat(new string[]
							{
								"     ",
								num.ToString(),
								"   X        ",
								Strings.FormatCurrency(num8.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
								text6,
								Strings.FormatCurrency(num7.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
							});
						}
						else
						{
							string text8 = Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True);
							int length3 = text8.ToString().Length;
							int j = length3 - 5;
							bool flag6 = j > 0;
							if (flag6)
							{
								while (j > 0)
								{
									text6 = text6.Substring(0, text6.Length - 1);
									j--;
								}
							}
							else
							{
								bool flag7 = j < 0;
								if (flag7)
								{
								}
							}
							num7 = new decimal(unchecked(num2 * Convert.ToDouble(num)));
							text3 = string.Concat(new string[]
							{
								"     ",
								num.ToString(),
								"   X        ",
								Strings.FormatCurrency(num2.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True),
								text6,
								Strings.FormatCurrency(num7.ToString(), 2, TriState.UseDefault, TriState.True, TriState.True)
							});
						}
						string text9 = Conversions.ToString(text3.Length);
						string text10 = new string(' ', (int)Math.Round(Math.Round(unchecked(55.0 - Conversions.ToDouble(text4)))));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text3 + Environment.NewLine;
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

		// Token: 0x06003329 RID: 13097 RVA: 0x001BAB34 File Offset: 0x001B8D34
		private void PrintFooterQuotation()
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value));
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value));
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
			string text = "Tax         " + Strings.FormatCurrency(num2.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
			string text2 = Conversions.ToString(text.Length);
			int length = text.Length;
			checked
			{
				string text3 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				bool flag = Operators.CompareString(text, "Tax         $0.00", false) != 0;
				if (flag)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				}
				bool flag2 = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				if (flag2)
				{
					decimal num3 = new decimal(unchecked(num * Convert.ToDouble(this.GetRate(MyProject.Forms.Form1.ReceiptDisplayPaymentMethod))));
					text = "Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				else
				{
					text = "Total       " + Strings.FormatCurrency(num.ToString(), -1, TriState.UseDefault, TriState.True, TriState.True);
				}
				text2 = Conversions.ToString(length);
				string text4 = new string(' ', (int)Math.Round(Math.Round(unchecked(26.0 - Conversions.ToDouble(text2)))));
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					Environment.NewLine,
					text4,
					text,
					Environment.NewLine
				});
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = "Customer:" + this.txtcustomer.Text;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag3 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag3)
				{
				}
				text = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x001BADF8 File Offset: 0x001B8FF8
		private decimal GetRate(int paymethid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetPaymentMethRate";
			sqlCommand.Parameters.AddWithValue("paymethid", paymethid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x001BAEA8 File Offset: 0x001B90A8
		private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcCustomerBill(Conversions.ToInteger(this.cboCustomers.SelectedValue));
				this.FetchCustomer(this.cboCustomers.Text);
			}
			catch (InvalidCastException ex)
			{
			}
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x001BAF04 File Offset: 0x001B9104
		private void CalcCustomerBill(int cus_entryno)
		{
			try
			{
				this.lblCustomerBillingBal.Text = "Acc Bal $" + this.GetCustomerBillTotal(cus_entryno, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating customer bill. Proceed. Details: " + ex.Message);
			}
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x001BAF90 File Offset: 0x001B9190
		private void FetchCustomer(string customername)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCustomerDetails";
				sqlCommand.Parameters.AddWithValue("CustomerName", customername);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.txtcustomer.Text = Conversions.ToString(dataRow["CustomerName"]);
					this.txtAddress.Text = Conversions.ToString(dataRow["Address"]);
					this.txtContactName.Text = Conversions.ToString(dataRow["ContactName"]);
					this.txtMobile.Text = Conversions.ToString(dataRow["Mobile"]);
					this.txtEmail.Text = Conversions.ToString(dataRow["Email"]);
					this.currCustomerEntryno = Conversions.ToInteger(dataRow["EntryNo"]);
				}
				else
				{
					this.currCustomerEntryno = 0;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x001BB134 File Offset: 0x001B9334
		private double GetCustomerBillTotal(int customerentryno, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCalcAccBalance";
			sqlCommand.Parameters.AddWithValue("customerentryno", customerentryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			double num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["bal"]));
				if (flag2)
				{
					num2 = 0.0;
				}
				else
				{
					num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["bal"]));
				}
			}
			else
			{
				num2 = 0.0;
			}
			return num2;
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x001BB22C File Offset: 0x001B942C
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			int num3 = 0;
			int num4 = 0;
			Font font = new Font("Times New Roman", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			checked
			{
				int num9 = (int)Math.Round(Math.Round((double)num5 / 1.0));
				Rectangle rectangle = new Rectangle(num7, num8, num6, num5);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				e.Graphics.MeasureString(this.TextToPrint, font, e.MarginBounds.Size, stringFormat, out num3, out num4);
				num4 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				using (StringReader stringReader = new StringReader(this.TextToPrint))
				{
					while (i < num4)
					{
						text = stringReader.ReadLine();
						bool flag = stringReader.Peek() == -1;
						if (flag)
						{
							break;
						}
						float num10 = unchecked(num2 + (float)i * font.GetHeight(e.Graphics));
						e.Graphics.DrawString(text, font, Brushes.Black, num, num10, new StringFormat());
						i++;
					}
				}
				bool flag2 = (Operators.CompareString(text, "", false) == 0) | Information.IsNothing(text);
				if (flag2)
				{
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
					this.TextToPrint = this.TextToPrint.Substring(num3);
				}
			}
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x001BB400 File Offset: 0x001B9600
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.mono_rate = this.GetRate(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
				this.lblpaymeth.Text = this.cboPayMeth.Text;
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x001BB4AC File Offset: 0x001B96AC
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					MessageBox.Show("Please note that the Batch Number and Expiry Date are not recorded. If you convert this quotation into an invoice - there will be errors.");
				}
				this.SaveQuote();
				Quotation quotation = new Quotation();
				quotation.quotationnumber = this.quotation_number;
				quotation.coid = MyProject.Forms.Form1.coid;
				quotation.branch = MyProject.Forms.Form1.branch;
				quotation.quotationHeader = this.cboQuotationHeader.Text;
				quotation.ShowDialog(this);
				quotation.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x001BB57C File Offset: 0x001B977C
		private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				bool flag = this.DataGridView1.Rows.Count == 0;
				if (flag)
				{
					this.cboPayMeth.Enabled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x001BB5D4 File Offset: 0x001B97D4
		private void Button7_Click(object sender, EventArgs e)
		{
			this.SaveCustomerDetails();
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x001BB5E0 File Offset: 0x001B97E0
		private void SaveCustomerDetails()
		{
			try
			{
				bool flag = this.pf.IsCustomerNew(this.txtcustomer.Text, this._cnn);
				if (flag)
				{
					this.InsertNewCustomer();
				}
				else
				{
					this.UpdateCustomer();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer details. SALE COMPLETED. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x001BB65C File Offset: 0x001B985C
		private void InsertNewCustomer()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertCustomerDetails";
			sqlCommand.Parameters.AddWithValue("CustomerName", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobile.Text);
			sqlCommand.Parameters.AddWithValue("ContactName", this.txtContactName.Text);
			sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("invoicedetails1", this.txtInvDetails1.Text);
			sqlCommand.Parameters.AddWithValue("invoicedetails2", this.txtInvDetails2.Text);
			sqlCommand.Parameters.AddWithValue("tel", this.txtTel.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x001BB7EC File Offset: 0x001B99EC
		private void UpdateCustomer()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateCustomerDetails";
			sqlCommand.Parameters.AddWithValue("CustomerName", this.txtcustomer.Text);
			sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobile.Text);
			sqlCommand.Parameters.AddWithValue("ContactName", this.txtContactName.Text);
			sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("invoicedetails1", this.txtInvDetails1.Text);
			sqlCommand.Parameters.AddWithValue("invoicedetails2", this.txtInvDetails2.Text);
			sqlCommand.Parameters.AddWithValue("tel", this.txtTel.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x001BB97C File Offset: 0x001B9B7C
		private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 1;
			if (flag)
			{
				bool flag2 = e.KeyChar == '\r';
				if (flag2)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x001BB9D8 File Offset: 0x001B9BD8
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadQuotations();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading quotation headers. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x001BBA28 File Offset: 0x001B9C28
		private void LoadQuotations()
		{
			this.dgvQuotations.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetQuotationsHeader";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			string text = this.DTStart.Value.ToString("yyyy-MM-dd");
			sqlCommand.Parameters.AddWithValue("startdate", this.DTStart.Value);
			sqlCommand.Parameters.AddWithValue("enddate", this.DTend.Value);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvQuotations.DataSource = dataTable;
			this.dgvQuotations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "View Quotation";
			dataGridViewButtonColumn.Text = "View";
			dataGridViewButtonColumn.Name = "View";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvQuotations.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x001BBB88 File Offset: 0x001B9D88
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
						Quotation quotation = new Quotation();
						quotation.quotationnumber = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.dgvQuotations.Rows[e.RowIndex].Cells["quotation_number"].Value));
						quotation.coid = MyProject.Forms.Form1.coid;
						quotation.branch = MyProject.Forms.Form1.branch;
						quotation.ShowDialog(this);
						quotation.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error viewing quotation. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x001BBCAC File Offset: 0x001B9EAC
		private void btnSpecialPrice_Click(object sender, EventArgs e)
		{
			try
			{
				VerifyOpenImpReports verifyOpenImpReports = new VerifyOpenImpReports();
				verifyOpenImpReports.ShowDialog(this);
				verifyOpenImpReports.Dispose();
				bool flag = MyProject.Forms.Form1.OpenImpReports == 1;
				if (flag)
				{
					this.txtPrice.Text = Conversions.ToString(this.CurrentSpecialPrice);
					MessageBox.Show("Special price effected.");
				}
				else
				{
					MessageBox.Show("Incorrect special price password. ");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Special price error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x001BBD50 File Offset: 0x001B9F50
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

		// Token: 0x0600333E RID: 13118 RVA: 0x001BBDD8 File Offset: 0x001B9FD8
		private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				this.CalcTotalSale();
				bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag)
				{
					this.txtSearchProductCode.Focus();
				}
				else
				{
					this.txtBarCode.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deletting row. Restart SALE.");
			}
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x001BBE50 File Offset: 0x001BA050
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.cboCustomers.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				int searchCustomerEntryno = MyProject.Forms.Form1.SearchCustomerEntryno;
				this.FetchCustomerByEntryno(searchCustomerEntryno);
				this.txtsearch.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x001BBEE8 File Offset: 0x001BA0E8
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
					this.txtcustomer.Text = Conversions.ToString(dataRow["CustomerName"]);
					this.txtAddress.Text = Conversions.ToString(dataRow["Address"]);
					this.txtContactName.Text = Conversions.ToString(dataRow["ContactName"]);
					this.txtMobile.Text = Conversions.ToString(dataRow["Mobile"]);
					this.txtEmail.Text = Conversions.ToString(dataRow["Email"]);
					this.txtTel.Text = Conversions.ToString(dataRow["Tel"]);
					this.txtInvDetails1.Text = Conversions.ToString(dataRow["InvoiceDetails1"]);
					this.txtInvDetails2.Text = Conversions.ToString(dataRow["InvoiceDetails2"]);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboQuotationHeader_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x001BC0C8 File Offset: 0x001BA2C8
		private void Button21_Click(object sender, EventArgs e)
		{
			try
			{
				PayMethRef payMethRef = new PayMethRef();
				bool flag = payMethRef.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.altdescription = payMethRef.txtRef.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding alternative description");
			}
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x001BC12C File Offset: 0x001BA32C
		private void ClearForm()
		{
			this.altdescription = "";
		}

		// Token: 0x040015D4 RID: 5588
		private string _cnn;

		// Token: 0x040015D5 RID: 5589
		private int CurrentID;

		// Token: 0x040015D6 RID: 5590
		private string CurrentCode;

		// Token: 0x040015D7 RID: 5591
		private string CurrentHSCode;

		// Token: 0x040015D8 RID: 5592
		private decimal CurrentSpecialPrice;

		// Token: 0x040015D9 RID: 5593
		private DataTable datCustomers;

		// Token: 0x040015DA RID: 5594
		private decimal priceb4tax;

		// Token: 0x040015DB RID: 5595
		private decimal priceb4taxWholesale;

		// Token: 0x040015DC RID: 5596
		private decimal currentWholesaleQty;

		// Token: 0x040015DD RID: 5597
		private decimal taxdueWholesale;

		// Token: 0x040015DE RID: 5598
		private decimal totpriceWholesale;

		// Token: 0x040015DF RID: 5599
		private int WholesalePriceByQty;

		// Token: 0x040015E0 RID: 5600
		private string TextToPrint;

		// Token: 0x040015E1 RID: 5601
		private string coname;

		// Token: 0x040015E2 RID: 5602
		private string coadd;

		// Token: 0x040015E3 RID: 5603
		private string cotel;

		// Token: 0x040015E4 RID: 5604
		private string coemail;

		// Token: 0x040015E5 RID: 5605
		private string cobpnum;

		// Token: 0x040015E6 RID: 5606
		private string cotel2;

		// Token: 0x040015E7 RID: 5607
		private string cotel3;

		// Token: 0x040015E8 RID: 5608
		private string footnote;

		// Token: 0x040015E9 RID: 5609
		private decimal mono_rate;

		// Token: 0x040015EA RID: 5610
		private int quotation_number;

		// Token: 0x040015EB RID: 5611
		private PublicFunctions pf;

		// Token: 0x040015EC RID: 5612
		private int currCustomerEntryno;

		// Token: 0x040015ED RID: 5613
		private string altdescription;
	}
}
