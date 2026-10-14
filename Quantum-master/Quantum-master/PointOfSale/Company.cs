using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200002B RID: 43
	[DesignerGenerated]
	public partial class Company : Form
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x0004E594 File Offset: 0x0004C794
		public Company()
		{
			base.Load += this.Company_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0005143C File Offset: 0x0004F63C
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00051446 File Offset: 0x0004F646
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0005144F File Offset: 0x0004F64F
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00051459 File Offset: 0x0004F659
		internal virtual TextBox txtCoName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00051462 File Offset: 0x0004F662
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x0005146C File Offset: 0x0004F66C
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00051475 File Offset: 0x0004F675
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x0005147F File Offset: 0x0004F67F
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00051488 File Offset: 0x0004F688
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00051492 File Offset: 0x0004F692
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0005149B File Offset: 0x0004F69B
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x000514A5 File Offset: 0x0004F6A5
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x000514AE File Offset: 0x0004F6AE
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x000514B8 File Offset: 0x0004F6B8
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x000514C1 File Offset: 0x0004F6C1
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x000514CC File Offset: 0x0004F6CC
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0005150F File Offset: 0x0004F70F
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00051519 File Offset: 0x0004F719
		internal virtual TextBox txtCompanyID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00051522 File Offset: 0x0004F722
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x0005152C File Offset: 0x0004F72C
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00051535 File Offset: 0x0004F735
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x0005153F File Offset: 0x0004F73F
		internal virtual TextBox txtBranchName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00051548 File Offset: 0x0004F748
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00051552 File Offset: 0x0004F752
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0005155B File Offset: 0x0004F75B
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00051565 File Offset: 0x0004F765
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0005156E File Offset: 0x0004F76E
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00051578 File Offset: 0x0004F778
		internal virtual TextBox txttel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00051581 File Offset: 0x0004F781
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0005158B File Offset: 0x0004F78B
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00051594 File Offset: 0x0004F794
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0005159E File Offset: 0x0004F79E
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000515A7 File Offset: 0x0004F7A7
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x000515B1 File Offset: 0x0004F7B1
		internal virtual TextBox txttel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x000515BA File Offset: 0x0004F7BA
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x000515C4 File Offset: 0x0004F7C4
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x000515CD File Offset: 0x0004F7CD
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x000515D7 File Offset: 0x0004F7D7
		internal virtual TextBox txtemail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000515E0 File Offset: 0x0004F7E0
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x000515EA File Offset: 0x0004F7EA
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000515F3 File Offset: 0x0004F7F3
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x000515FD File Offset: 0x0004F7FD
		internal virtual TextBox txtBpnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00051606 File Offset: 0x0004F806
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00051610 File Offset: 0x0004F810
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00051619 File Offset: 0x0004F819
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00051623 File Offset: 0x0004F823
		internal virtual TextBox txtspecial
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0005162C File Offset: 0x0004F82C
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00051636 File Offset: 0x0004F836
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0005163F File Offset: 0x0004F83F
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00051649 File Offset: 0x0004F849
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00051652 File Offset: 0x0004F852
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x0005165C File Offset: 0x0004F85C
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0005169F File Offset: 0x0004F89F
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x000516A9 File Offset: 0x0004F8A9
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000516B2 File Offset: 0x0004F8B2
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x000516BC File Offset: 0x0004F8BC
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000516C5 File Offset: 0x0004F8C5
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x000516CF File Offset: 0x0004F8CF
		internal virtual TextBox txtBank
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000516D8 File Offset: 0x0004F8D8
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x000516E2 File Offset: 0x0004F8E2
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000516EB File Offset: 0x0004F8EB
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x000516F5 File Offset: 0x0004F8F5
		internal virtual TextBox txtBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000516FE File Offset: 0x0004F8FE
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00051708 File Offset: 0x0004F908
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00051711 File Offset: 0x0004F911
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x0005171B File Offset: 0x0004F91B
		internal virtual TextBox txtAccName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00051724 File Offset: 0x0004F924
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x0005172E File Offset: 0x0004F92E
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00051737 File Offset: 0x0004F937
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00051741 File Offset: 0x0004F941
		internal virtual TextBox txtSwiftCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0005174A File Offset: 0x0004F94A
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00051754 File Offset: 0x0004F954
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0005175D File Offset: 0x0004F95D
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00051767 File Offset: 0x0004F967
		internal virtual TextBox txtAccNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00051770 File Offset: 0x0004F970
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x0005177A File Offset: 0x0004F97A
		internal virtual TextBox txtCurrency
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00051783 File Offset: 0x0004F983
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x0005178D File Offset: 0x0004F98D
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00051796 File Offset: 0x0004F996
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x000517A0 File Offset: 0x0004F9A0
		internal virtual Label Label21
		{
			[CompilerGenerated]
			get
			{
				return this._Label21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label21_Click);
				Label label = this._Label21;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label21 = value;
				label = this._Label21;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x000517E3 File Offset: 0x0004F9E3
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x000517ED File Offset: 0x0004F9ED
		internal virtual TextBox txtCurrencyUSD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000517F6 File Offset: 0x0004F9F6
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00051800 File Offset: 0x0004FA00
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00051809 File Offset: 0x0004FA09
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00051813 File Offset: 0x0004FA13
		internal virtual TextBox txtAccNumberUSD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0005181C File Offset: 0x0004FA1C
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00051826 File Offset: 0x0004FA26
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0005182F File Offset: 0x0004FA2F
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00051839 File Offset: 0x0004FA39
		internal virtual TextBox txtSwiftCodeUSD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00051842 File Offset: 0x0004FA42
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x0005184C File Offset: 0x0004FA4C
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00051855 File Offset: 0x0004FA55
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x0005185F File Offset: 0x0004FA5F
		internal virtual TextBox txtAccNameUSD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00051868 File Offset: 0x0004FA68
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00051872 File Offset: 0x0004FA72
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0005187B File Offset: 0x0004FA7B
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00051885 File Offset: 0x0004FA85
		internal virtual TextBox txtBranchUSD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0005188E File Offset: 0x0004FA8E
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00051898 File Offset: 0x0004FA98
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000518A1 File Offset: 0x0004FAA1
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x000518AB File Offset: 0x0004FAAB
		internal virtual TextBox txtBankUSD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000518B4 File Offset: 0x0004FAB4
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000518BE File Offset: 0x0004FABE
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000518C7 File Offset: 0x0004FAC7
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x000518D1 File Offset: 0x0004FAD1
		internal virtual TextBox txtVATNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000518DA File Offset: 0x0004FADA
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x000518E4 File Offset: 0x0004FAE4
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000518ED File Offset: 0x0004FAED
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x000518F7 File Offset: 0x0004FAF7
		internal virtual TextBox txtVendorNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00051900 File Offset: 0x0004FB00
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0005190A File Offset: 0x0004FB0A
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00051913 File Offset: 0x0004FB13
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00051920 File Offset: 0x0004FB20
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

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00051963 File Offset: 0x0004FB63
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0005196D File Offset: 0x0004FB6D
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00051976 File Offset: 0x0004FB76
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00051980 File Offset: 0x0004FB80
		internal virtual TextBox txtBaseCurrency
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00051989 File Offset: 0x0004FB89
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00051993 File Offset: 0x0004FB93
		internal virtual TextBox txtBPNumberName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0005199C File Offset: 0x0004FB9C
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x000519A6 File Offset: 0x0004FBA6
		internal virtual TextBox txtVATNumberName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x000519AF File Offset: 0x0004FBAF
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x000519B9 File Offset: 0x0004FBB9
		internal virtual TextBox txtVendorNumberName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x000519C2 File Offset: 0x0004FBC2
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x000519CC File Offset: 0x0004FBCC
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x000519D5 File Offset: 0x0004FBD5
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x000519DF File Offset: 0x0004FBDF
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x000519E8 File Offset: 0x0004FBE8
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x000519F2 File Offset: 0x0004FBF2
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x000519FB File Offset: 0x0004FBFB
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00051A05 File Offset: 0x0004FC05
		internal virtual CheckBox CheckBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00051A0E File Offset: 0x0004FC0E
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00051A18 File Offset: 0x0004FC18
		internal virtual TextBox txtMaxDisc
		{
			[CompilerGenerated]
			get
			{
				return this._txtMaxDisc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtMaxDisc_KeyPress);
				TextBox textBox = this._txtMaxDisc;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtMaxDisc = value;
				textBox = this._txtMaxDisc;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00051A5B File Offset: 0x0004FC5B
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00051A65 File Offset: 0x0004FC65
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00051A6E File Offset: 0x0004FC6E
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00051A78 File Offset: 0x0004FC78
		internal virtual TextBox txtwebsite
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00051A81 File Offset: 0x0004FC81
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00051A8B File Offset: 0x0004FC8B
		internal virtual Label Label33
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00051A94 File Offset: 0x0004FC94
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00051A9E File Offset: 0x0004FC9E
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00051AA7 File Offset: 0x0004FCA7
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00051AB1 File Offset: 0x0004FCB1
		internal virtual TextBox txtWebsiteComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00051ABA File Offset: 0x0004FCBA
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00051AC4 File Offset: 0x0004FCC4
		internal virtual Label Label35
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00051ACD File Offset: 0x0004FCCD
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00051AD7 File Offset: 0x0004FCD7
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00051AE0 File Offset: 0x0004FCE0
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00051AEA File Offset: 0x0004FCEA
		internal virtual TextBox txtQRCodeSize
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00051AF3 File Offset: 0x0004FCF3
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00051AFD File Offset: 0x0004FCFD
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00051B08 File Offset: 0x0004FD08
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.InsertCompanyDetails();
				this.SaveBranchDisc();
				this.pf.AdditionalSettings2Save(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "QRCodeSize", Conversions.ToString(Conversion.Val(this.txtQRCodeSize.Text)), MyProject.Forms.Form1.Constring);
				MyProject.Forms.Form1.QRCodeSize = checked((int)Math.Round(Conversion.Val(this.txtQRCodeSize.Text)));
				MessageBox.Show("Details saved successfully");
				base.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving details. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00051BE8 File Offset: 0x0004FDE8
		private void SaveBranchDisc()
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				bool flag = Operators.CompareString(this.txtMaxDisc.Text, "", false) == 0;
				if (flag)
				{
					this.txtMaxDisc.Text = "0";
				}
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"update branches set maxdisc=",
					Conversions.ToString(Conversion.Val(this.txtMaxDisc.Text)),
					" where branch='",
					this.txtBranchName.Text,
					"' and coid=",
					Conversions.ToString(Conversions.ToInteger(this.txtCompanyID.Text))
				});
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					MyProject.Forms.Form1.MaxDiscPerc = new decimal(Conversion.Val(this.txtMaxDisc.Text));
					sqlConnection.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00051D3C File Offset: 0x0004FF3C
		private void InsertCompanyDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertCompanyDetails";
			sqlCommand.Parameters.AddWithValue("coname", this.txtCoName.Text);
			sqlCommand.Parameters.AddWithValue("coaddress", this.txtAddress.Text);
			sqlCommand.Parameters.AddWithValue("cotel", this.txtTel.Text);
			sqlCommand.Parameters.AddWithValue("coid", this.txtCompanyID.Text);
			sqlCommand.Parameters.AddWithValue("branchname", this.txtBranchName.Text);
			sqlCommand.Parameters.AddWithValue("cotel2", this.txttel2.Text);
			sqlCommand.Parameters.AddWithValue("cotel3", this.txttel3.Text);
			sqlCommand.Parameters.AddWithValue("email", this.txtemail.Text);
			sqlCommand.Parameters.AddWithValue("bpnumber", this.txtBpnumber.Text);
			sqlCommand.Parameters.AddWithValue("special", this.txtspecial.Text);
			sqlCommand.Parameters.AddWithValue("bank", this.txtBank.Text);
			sqlCommand.Parameters.AddWithValue("bankbranch", this.txtBranch.Text);
			sqlCommand.Parameters.AddWithValue("bankaccnum", this.txtAccNumber.Text);
			sqlCommand.Parameters.AddWithValue("bankaccname", this.txtAccName.Text);
			sqlCommand.Parameters.AddWithValue("bankswiftcode", this.txtSwiftCode.Text);
			sqlCommand.Parameters.AddWithValue("currency", this.txtCurrency.Text);
			sqlCommand.Parameters.AddWithValue("bank2", this.txtBankUSD.Text);
			sqlCommand.Parameters.AddWithValue("bankbranch2", this.txtBranchUSD.Text);
			sqlCommand.Parameters.AddWithValue("bankaccnum2", this.txtAccNumberUSD.Text);
			sqlCommand.Parameters.AddWithValue("bankaccname2", this.txtAccNumberUSD.Text);
			sqlCommand.Parameters.AddWithValue("bankswiftcode2", this.txtSwiftCodeUSD.Text);
			sqlCommand.Parameters.AddWithValue("currency2", this.txtCurrencyUSD.Text);
			sqlCommand.Parameters.AddWithValue("vatnumber", this.txtVATNumber.Text);
			sqlCommand.Parameters.AddWithValue("vendornumber", this.txtVendorNumber.Text);
			sqlCommand.Parameters.AddWithValue("basecurrency", this.txtBaseCurrency.Text);
			sqlCommand.Parameters.AddWithValue("tax_name", this.txtBPNumberName.Text);
			sqlCommand.Parameters.AddWithValue("vendornum_name", this.txtVendorNumberName.Text);
			sqlCommand.Parameters.AddWithValue("vat_name", this.txtVATNumberName.Text);
			sqlCommand.Parameters.AddWithValue("websiteadd", this.txtwebsite.Text);
			sqlCommand.Parameters.AddWithValue("websitecomment", this.txtWebsiteComment.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000520F0 File Offset: 0x000502F0
		private void LoadCoDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectCoDetails";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtAddress.Text = dataRow["Address"].ToString();
				this.txtBpnumber.Text = dataRow["BPNumber"].ToString();
				this.txtBranchName.Text = dataRow["BranchName"].ToString();
				this.txtCompanyID.Text = dataRow["CompanyID"].ToString();
				this.txtCoName.Text = dataRow["Company"].ToString();
				this.txtemail.Text = dataRow["Email"].ToString();
				this.txtTel.Text = dataRow["Tel"].ToString();
				this.txttel2.Text = dataRow["Tel2"].ToString();
				this.txttel3.Text = dataRow["Tel3"].ToString();
				this.txtspecial.Text = dataRow["SP"].ToString();
				this.txtBaseCurrency.Text = dataRow["basecurrency"].ToString();
				this.txtVATNumberName.Text = dataRow["VATNumber_name"].ToString();
				this.txtBPNumberName.Text = dataRow["BPNumber_name"].ToString();
				this.txtVendorNumberName.Text = dataRow["Vendor_name"].ToString();
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000522F0 File Offset: 0x000504F0
		private void LoadBranchDetails(int coid, string branchname)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branchname);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtVATNumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VatNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VatNumber"])));
				this.txtVendorNumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VendorNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VendorNumber"])));
				this.txtBpnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
				this.txtemail.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Email"])), "", RuntimeHelpers.GetObjectValue(dataRow["Email"])));
				this.txtwebsite.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["websiteadd"])), "", RuntimeHelpers.GetObjectValue(dataRow["websiteadd"])));
				this.txtWebsiteComment.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["websitecomment"])), "", RuntimeHelpers.GetObjectValue(dataRow["websitecomment"])));
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00052510 File Offset: 0x00050710
		private void LoadBankDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBankingDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtBank.Text = dataRow["BankName"].ToString();
				this.txtBranch.Text = dataRow["Branch"].ToString();
				this.txtAccName.Text = dataRow["Account_Name"].ToString();
				this.txtAccNumber.Text = dataRow["Account_Number"].ToString();
				this.txtSwiftCode.Text = dataRow["Swift_Code"].ToString();
				this.txtCurrency.Text = dataRow["Currency"].ToString();
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0005264C File Offset: 0x0005084C
		private void LoadBankDetails2()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBankingDetails2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtBankUSD.Text = dataRow["BankName"].ToString();
				this.txtBranchUSD.Text = dataRow["Branch"].ToString();
				this.txtAccNameUSD.Text = dataRow["Account_Name"].ToString();
				this.txtAccNumberUSD.Text = dataRow["Account_Number"].ToString();
				this.txtSwiftCodeUSD.Text = dataRow["Swift_Code"].ToString();
				this.txtCurrencyUSD.Text = dataRow["Currency"].ToString();
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00052788 File Offset: 0x00050988
		private void LoadCoLogo()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			try
			{
				SqlCommand sqlCommand = new SqlCommand("select top 1 logo from Company");
				sqlCommand.Connection = sqlConnection;
				sqlCommand.CommandType = CommandType.Text;
				sqlConnection.Open();
				MemoryStream memoryStream = new MemoryStream((byte[])sqlCommand.ExecuteScalar());
				bool flag = memoryStream.Length > 0L;
				if (flag)
				{
					this.PictureBox1.Image = Image.FromStream(memoryStream);
				}
				memoryStream.Dispose();
				sqlCommand.Connection.Close();
				this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0005283C File Offset: 0x00050A3C
		private void Company_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadCoDetails();
				this.LoadBranchDetails(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				this.LoadBankDetails();
				this.LoadBankDetails2();
				this.LoadCoLogo();
				this.txtMaxDisc.Text = MyProject.Forms.Form1.MaxDiscPerc.ToString();
				this.txtQRCodeSize.Text = Conversions.ToString(MyProject.Forms.Form1.QRCodeSize);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying co details. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0005290C File Offset: 0x00050B0C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.PictureBox1.BackgroundImage = Image.FromFile(this.OpenFileDialog1.FileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to load picture. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00052984 File Offset: 0x00050B84
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SaveLogo";
				sqlCommand.Parameters.AddWithValue("coid", Conversions.ToInteger(this.txtCompanyID.Text));
				MemoryStream memoryStream = new MemoryStream();
				this.PictureBox1.BackgroundImage.Save(memoryStream, this.PictureBox1.BackgroundImage.RawFormat);
				byte[] buffer = memoryStream.GetBuffer();
				SqlParameter sqlParameter = new SqlParameter("image", SqlDbType.Image);
				sqlParameter.Value = buffer;
				sqlCommand.Parameters.Add(sqlParameter);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				MessageBox.Show("Logo saved.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving logo. Detail:" + ex.Message);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00052AB0 File Offset: 0x00050CB0
		private void txtMaxDisc_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label21_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040003FC RID: 1020
		private string _cnn;

		// Token: 0x040003FD RID: 1021
		private PublicFunctions pf;
	}
}
