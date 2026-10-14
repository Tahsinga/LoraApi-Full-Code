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
	// Token: 0x02000036 RID: 54
	[DesignerGenerated]
	public partial class CustomerDetails : UserControl
	{
		// Token: 0x06000BAB RID: 2987 RVA: 0x00075DA0 File Offset: 0x00073FA0
		public CustomerDetails()
		{
			base.Load += this.CustomerDetails_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.customerEntryNo = 0;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x000780D4 File Offset: 0x000762D4
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x000780DE File Offset: 0x000762DE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000780E7 File Offset: 0x000762E7
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x000780F4 File Offset: 0x000762F4
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

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00078137 File Offset: 0x00076337
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00078144 File Offset: 0x00076344
		internal virtual GroupBox GroupBox2
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox2_Enter);
				GroupBox groupBox = this._GroupBox2;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox2 = value;
				groupBox = this._GroupBox2;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00078187 File Offset: 0x00076387
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00078191 File Offset: 0x00076391
		internal virtual TextBox txtBPNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0007819A File Offset: 0x0007639A
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x000781A4 File Offset: 0x000763A4
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x000781AD File Offset: 0x000763AD
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000781B7 File Offset: 0x000763B7
		internal virtual TextBox txtVATNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000781C0 File Offset: 0x000763C0
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x000781CA File Offset: 0x000763CA
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000781D3 File Offset: 0x000763D3
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x000781DD File Offset: 0x000763DD
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000781E6 File Offset: 0x000763E6
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x000781F0 File Offset: 0x000763F0
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000781F9 File Offset: 0x000763F9
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x00078203 File Offset: 0x00076403
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0007820C File Offset: 0x0007640C
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x00078216 File Offset: 0x00076416
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0007821F File Offset: 0x0007641F
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00078229 File Offset: 0x00076429
		internal virtual TextBox txtMobileNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00078232 File Offset: 0x00076432
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0007823C File Offset: 0x0007643C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00078245 File Offset: 0x00076445
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x0007824F File Offset: 0x0007644F
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00078258 File Offset: 0x00076458
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00078262 File Offset: 0x00076462
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0007826B File Offset: 0x0007646B
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00078275 File Offset: 0x00076475
		internal virtual TextBox txtContactName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0007827E File Offset: 0x0007647E
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00078288 File Offset: 0x00076488
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00078291 File Offset: 0x00076491
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0007829B File Offset: 0x0007649B
		internal virtual TextBox txtCustomerName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000782A4 File Offset: 0x000764A4
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000782AE File Offset: 0x000764AE
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000782B7 File Offset: 0x000764B7
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x000782C1 File Offset: 0x000764C1
		internal virtual TextBox txtRegisteredCoName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000782CA File Offset: 0x000764CA
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x000782D4 File Offset: 0x000764D4
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x000782DD File Offset: 0x000764DD
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x000782E7 File Offset: 0x000764E7
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000782F0 File Offset: 0x000764F0
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x000782FA File Offset: 0x000764FA
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00078303 File Offset: 0x00076503
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00078310 File Offset: 0x00076510
		internal virtual TextBox txtAccLimit
		{
			[CompilerGenerated]
			get
			{
				return this._txtAccLimit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAccLimit_KeyPress);
				TextBox textBox = this._txtAccLimit;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAccLimit = value;
				textBox = this._txtAccLimit;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00078353 File Offset: 0x00076553
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0007835D File Offset: 0x0007655D
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00078366 File Offset: 0x00076566
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00078370 File Offset: 0x00076570
		internal virtual CheckBox chkIsActive
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00078379 File Offset: 0x00076579
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00078383 File Offset: 0x00076583
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0007838C File Offset: 0x0007658C
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00078396 File Offset: 0x00076596
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0007839F File Offset: 0x0007659F
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x000783AC File Offset: 0x000765AC
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

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000783EF File Offset: 0x000765EF
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x000783F9 File Offset: 0x000765F9
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00078402 File Offset: 0x00076602
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0007840C File Offset: 0x0007660C
		internal virtual TextBox txtsearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00078415 File Offset: 0x00076615
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00078420 File Offset: 0x00076620
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
				EventHandler eventHandler = new EventHandler(this.Button2_Click_1);
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00078463 File Offset: 0x00076663
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0007846D File Offset: 0x0007666D
		internal virtual TextBox txtinvoiceDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00078476 File Offset: 0x00076676
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00078480 File Offset: 0x00076680
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00078489 File Offset: 0x00076689
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00078493 File Offset: 0x00076693
		internal virtual TextBox txtInvoiceDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0007849C File Offset: 0x0007669C
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000784A6 File Offset: 0x000766A6
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x000784AF File Offset: 0x000766AF
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x000784BC File Offset: 0x000766BC
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

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x000784FF File Offset: 0x000766FF
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0007850C File Offset: 0x0007670C
		internal virtual Label Label17
		{
			[CompilerGenerated]
			get
			{
				return this._Label17;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label17_Click);
				Label label = this._Label17;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label17 = value;
				label = this._Label17;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0007854F File Offset: 0x0007674F
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x00078559 File Offset: 0x00076759
		internal virtual ComboBox cboGender
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00078562 File Offset: 0x00076762
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x0007856C File Offset: 0x0007676C
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00078575 File Offset: 0x00076775
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00078580 File Offset: 0x00076780
		internal virtual DateTimePicker DTDoB
		{
			[CompilerGenerated]
			get
			{
				return this._DTDoB;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DTDoB_ValueChanged);
				DateTimePicker dateTimePicker = this._DTDoB;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DTDoB = value;
				dateTimePicker = this._DTDoB;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x000785C3 File Offset: 0x000767C3
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x000785CD File Offset: 0x000767CD
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000785D6 File Offset: 0x000767D6
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000785E0 File Offset: 0x000767E0
		internal virtual TextBox txtIDNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000785E9 File Offset: 0x000767E9
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000785F3 File Offset: 0x000767F3
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x000785FC File Offset: 0x000767FC
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00078606 File Offset: 0x00076806
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0007860F File Offset: 0x0007680F
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00078619 File Offset: 0x00076819
		internal virtual ComboBox cboCustomerGroup
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00078622 File Offset: 0x00076822
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0007862C File Offset: 0x0007682C
		internal virtual ComboBox cboProvince
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00078635 File Offset: 0x00076835
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0007863F File Offset: 0x0007683F
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00078648 File Offset: 0x00076848
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00078652 File Offset: 0x00076852
		internal virtual ComboBox cboCity
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0007865B File Offset: 0x0007685B
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00078665 File Offset: 0x00076865
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0007866E File Offset: 0x0007686E
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00078678 File Offset: 0x00076878
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00078681 File Offset: 0x00076881
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0007868B File Offset: 0x0007688B
		internal virtual TextBox txtStreetNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00078694 File Offset: 0x00076894
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0007869E File Offset: 0x0007689E
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000786A8 File Offset: 0x000768A8
		private void txtAccLimit_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00078710 File Offset: 0x00076910
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.customerEntryNo = 0;
				this.ClearForm();
				this.GroupBox2.Visible = true;
				this.txtCustomerName.Focus();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00078768 File Offset: 0x00076968
		private void Button2_Click_1(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.txtsearch.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				int searchCustomerEntryno = MyProject.Forms.Form1.SearchCustomerEntryno;
				this.FetchCustomerByEntryno(searchCustomerEntryno);
				this.GroupBox2.Visible = true;
				this.txtCustomerName.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0007880C File Offset: 0x00076A0C
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
					this.txtCustomerName.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["CustomerName"])), "", RuntimeHelpers.GetObjectValue(dataRow["CustomerName"])));
					this.txtAddress.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Address"])), "", RuntimeHelpers.GetObjectValue(dataRow["Address"])));
					this.txtContactName.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ContactName"])), "", RuntimeHelpers.GetObjectValue(dataRow["ContactName"])));
					this.txtMobileNumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Mobile"])), "", RuntimeHelpers.GetObjectValue(dataRow["Mobile"])));
					this.txtEmail.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Email"])), "", RuntimeHelpers.GetObjectValue(dataRow["Email"])));
					this.txtTel.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Tel"])), "", RuntimeHelpers.GetObjectValue(dataRow["Tel"])));
					this.txtinvoiceDetails1.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["InvoiceDetails1"])), "", RuntimeHelpers.GetObjectValue(dataRow["InvoiceDetails1"])));
					this.txtInvoiceDetails2.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["InvoiceDetails2"])), "", RuntimeHelpers.GetObjectValue(dataRow["InvoiceDetails2"])));
					this.txtBPNumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
					this.txtVATNumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])));
					this.customerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					bool flag2 = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["isactive"])), true, RuntimeHelpers.GetObjectValue(dataRow["isactive"])));
					bool flag3 = flag2;
					if (flag3)
					{
						this.chkIsActive.Checked = true;
					}
					else
					{
						this.chkIsActive.Checked = false;
					}
					this.txtRegisteredCoName.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["registeredconame"])), "", RuntimeHelpers.GetObjectValue(dataRow["registeredconame"])));
					this.txtAccLimit.Text = dataRow["accountlimit"].ToString();
					this.txtIDNumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["idnumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["idnumber"])));
					bool flag4 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["dob"]));
					if (flag4)
					{
						this.DTDoB.Format = DateTimePickerFormat.Custom;
						this.DTDoB.CustomFormat = " ";
					}
					else
					{
						this.DTDoB.Value = Conversions.ToDate(dataRow["dob"]);
					}
					this.cboGender.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["sex"])), "", RuntimeHelpers.GetObjectValue(dataRow["sex"])));
					this.cboCustomerGroup.SelectedIndex = this.cboCustomerGroup.FindStringExact(Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["CategoryName"])), "", RuntimeHelpers.GetObjectValue(dataRow["CategoryName"]))));
					this.cboProvince.Text = dataRow["Province"].ToString();
					this.cboCity.SelectedIndex = this.cboCity.FindStringExact(dataRow["city"].ToString());
					this.txtStreetNumber.Text = dataRow["StreetNumber"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying customer details. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00078E14 File Offset: 0x00077014
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.txtCustomerName.Text, "", false) != 0) & (Operators.CompareString(this.txtMobileNumber.Text, "", false) != 0);
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "UpdateCustomerDetails4";
					sqlCommand.Parameters.AddWithValue("CustomerName", this.txtCustomerName.Text);
					sqlCommand.Parameters.AddWithValue("Address", this.txtAddress.Text);
					sqlCommand.Parameters.AddWithValue("Mobile", this.txtMobileNumber.Text);
					sqlCommand.Parameters.AddWithValue("ContactName", this.txtContactName.Text);
					sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("invoicedetails1", this.txtinvoiceDetails1.Text);
					sqlCommand.Parameters.AddWithValue("invoicedetails2", this.txtInvoiceDetails2.Text);
					sqlCommand.Parameters.AddWithValue("tel", this.txtTel.Text);
					sqlCommand.Parameters.AddWithValue("vatnumber", this.txtVATNumber.Text);
					sqlCommand.Parameters.AddWithValue("bpnumber", this.txtBPNumber.Text);
					sqlCommand.Parameters.AddWithValue("entryno", this.customerEntryNo);
					sqlCommand.Parameters.AddWithValue("registeredconame", this.txtRegisteredCoName.Text);
					sqlCommand.Parameters.AddWithValue("gender", this.cboGender.Text);
					sqlCommand.Parameters.AddWithValue("dob", this.DTDoB.Value);
					sqlCommand.Parameters.AddWithValue("idnumber", this.txtIDNumber.Text);
					sqlCommand.Parameters.AddWithValue("province", this.cboProvince.Text);
					sqlCommand.Parameters.AddWithValue("city", this.cboCity.Text);
					sqlCommand.Parameters.AddWithValue("streetnumber", this.txtStreetNumber.Text);
					bool flag2 = Operators.CompareString(this.txtAccLimit.Text, "", false) == 0;
					decimal num;
					if (flag2)
					{
						num = 0m;
					}
					else
					{
						num = Conversions.ToDecimal(this.txtAccLimit.Text);
					}
					sqlCommand.Parameters.AddWithValue("acclimit", num);
					sqlCommand.Parameters.AddWithValue("isactive", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkIsActive.Checked, true, false)));
					sqlCommand.Parameters.AddWithValue("isnew", this.customerEntryNo);
					sqlCommand.Parameters.AddWithValue("customergroup", RuntimeHelpers.GetObjectValue(this.cboCustomerGroup.SelectedValue));
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					MyProject.Forms.Form1.SearchCustomer = this.txtCustomerName.Text;
					MessageBox.Show("Customer Details saved successfully.");
					this.ClearForm();
				}
				else
				{
					MessageBox.Show("Please enter the customer name and mobile number to continue.");
					bool flag3 = Operators.CompareString(this.txtCustomerName.Text, "", false) == 0;
					if (flag3)
					{
						this.txtCustomerName.Focus();
					}
					else
					{
						bool flag4 = Operators.CompareString(this.txtMobileNumber.Text, "", false) == 0;
						if (flag4)
						{
							this.txtMobileNumber.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000792A8 File Offset: 0x000774A8
		private void ClearForm()
		{
			try
			{
				foreach (object obj in this.GroupBox2.Controls)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					bool flag = objectValue is TextBox;
					if (flag)
					{
						NewLateBinding.LateSet(objectValue, null, "text", new object[] { "" }, null, null);
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
			this.chkIsActive.Checked = true;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00079340 File Offset: 0x00077540
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete this customer. This cannot be undone? Customers with history cannot be deleted.", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "DeleteCustomer";
					sqlCommand.Parameters.AddWithValue("customername", this.txtCustomerName.Text);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
					MessageBox.Show("Customer deleted.");
				}
				else
				{
					MessageBox.Show("No action done.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting customer. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0007945C File Offset: 0x0007765C
		private void Label17_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error disposing user control. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000794AC File Offset: 0x000776AC
		private void DTDoB_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.DTDoB.Format = DateTimePickerFormat.Long;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000794EC File Offset: 0x000776EC
		private void LoadCustomerCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from CustomerCategoryNames where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlDataAdapter.Fill(dataTable);
				this.cboCustomerGroup.DataSource = dataTable;
				this.cboCustomerGroup.ValueMember = "ID";
				this.cboCustomerGroup.DisplayMember = "CategoryName";
				sqlConnection.Close();
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000795B0 File Offset: 0x000777B0
		private void CustomerDetails_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboCity.DataSource = this.pf.GetZimCities(MyProject.Forms.Form1.Constring);
				this.cboCity.DisplayMember = "City";
				this.cboCity.ValueMember = "City";
				this.LoadCustomerCategories();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x040005BC RID: 1468
		private string _cnn;

		// Token: 0x040005BD RID: 1469
		private int customerEntryNo;

		// Token: 0x040005BE RID: 1470
		private PublicFunctions pf;
	}
}
