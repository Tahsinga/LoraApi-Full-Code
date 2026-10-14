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
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class Bookings : UserControl
	{
		// Token: 0x06000369 RID: 873 RVA: 0x0001E6F8 File Offset: 0x0001C8F8
		public Bookings()
		{
			base.Load += this.Bookings_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.datCustomers = new DataTable();
			this.currentCustomerEntryNo = 0;
			this.CurrentID = 0;
			this.mono_rate = 0m;
			this.og_customername = "";
			this.og_address = "";
			this.og_contactname = "";
			this.og_mobile = "";
			this.og_email = "";
			this.og_tel = "";
			this.og_invdetail1 = "";
			this.og_invdetail2 = "";
			this.og_vatnumber = "";
			this.og_bpnumber = "";
			this.currentCustomerLimit = 0m;
			this.booking_number = 0;
			this.isunedingstock = 0;
			this.pf = new PublicFunctions();
			this.discAmount = 0m;
			this.discPaymentMethod = 0;
			this.PaymentMethodDiscountEffected = 0;
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.specialprice = 0m;
			this.currenttaxrate = 0m;
			this.CurrentCode = "";
			this.IsBooking = false;
			this.InitializeComponent();
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00021EBF File Offset: 0x000200BF
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00021EC9 File Offset: 0x000200C9
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00021ED2 File Offset: 0x000200D2
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00021EDC File Offset: 0x000200DC
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00021EE5 File Offset: 0x000200E5
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00021EF0 File Offset: 0x000200F0
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00021F33 File Offset: 0x00020133
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00021F40 File Offset: 0x00020140
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00021F83 File Offset: 0x00020183
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00021F90 File Offset: 0x00020190
		internal virtual TextBox txtPerson
		{
			[CompilerGenerated]
			get
			{
				return this._txtPerson;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtPerson_TextChanged);
				TextBox textBox = this._txtPerson;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtPerson = value;
				textBox = this._txtPerson;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00021FD3 File Offset: 0x000201D3
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00021FDD File Offset: 0x000201DD
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00021FE6 File Offset: 0x000201E6
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00021FF0 File Offset: 0x000201F0
		internal virtual ComboBox cboProduct
		{
			[CompilerGenerated]
			get
			{
				return this._cboProduct;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboProduct_SelectedIndexChanged);
				ComboBox comboBox = this._cboProduct;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboProduct = value;
				comboBox = this._cboProduct;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00022033 File Offset: 0x00020233
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0002203D File Offset: 0x0002023D
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00022046 File Offset: 0x00020246
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00022050 File Offset: 0x00020250
		internal virtual DateTimePicker DTOut
		{
			[CompilerGenerated]
			get
			{
				return this._DTOut;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DTOut_ValueChanged);
				DateTimePicker dateTimePicker = this._DTOut;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DTOut = value;
				dateTimePicker = this._DTOut;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00022093 File Offset: 0x00020293
		// (set) Token: 0x0600037F RID: 895 RVA: 0x0002209D File Offset: 0x0002029D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000380 RID: 896 RVA: 0x000220A6 File Offset: 0x000202A6
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000220B0 File Offset: 0x000202B0
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000220B9 File Offset: 0x000202B9
		// (set) Token: 0x06000383 RID: 899 RVA: 0x000220C4 File Offset: 0x000202C4
		internal virtual DateTimePicker DTIn
		{
			[CompilerGenerated]
			get
			{
				return this._DTIn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DTIn_ValueChanged);
				DateTimePicker dateTimePicker = this._DTIn;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DTIn = value;
				dateTimePicker = this._DTIn;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00022107 File Offset: 0x00020307
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00022111 File Offset: 0x00020311
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0002211A File Offset: 0x0002031A
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00022124 File Offset: 0x00020324
		internal virtual GroupBox grpCustomers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0002212D File Offset: 0x0002032D
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00022137 File Offset: 0x00020337
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00022140 File Offset: 0x00020340
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0002214A File Offset: 0x0002034A
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00022153 File Offset: 0x00020353
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0002215D File Offset: 0x0002035D
		internal virtual Label lblCustomerBillingBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00022166 File Offset: 0x00020366
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00022170 File Offset: 0x00020370
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000221B3 File Offset: 0x000203B3
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000221BD File Offset: 0x000203BD
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000392 RID: 914 RVA: 0x000221C6 File Offset: 0x000203C6
		// (set) Token: 0x06000393 RID: 915 RVA: 0x000221D0 File Offset: 0x000203D0
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000394 RID: 916 RVA: 0x000221D9 File Offset: 0x000203D9
		// (set) Token: 0x06000395 RID: 917 RVA: 0x000221E3 File Offset: 0x000203E3
		internal virtual TextBox txtbpnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000221EC File Offset: 0x000203EC
		// (set) Token: 0x06000397 RID: 919 RVA: 0x000221F6 File Offset: 0x000203F6
		internal virtual Label Label37
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000221FF File Offset: 0x000203FF
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00022209 File Offset: 0x00020409
		internal virtual TextBox txtvatnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00022212 File Offset: 0x00020412
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0002221C File Offset: 0x0002041C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00022225 File Offset: 0x00020425
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0002222F File Offset: 0x0002042F
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00022238 File Offset: 0x00020438
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00022242 File Offset: 0x00020442
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0002224B File Offset: 0x0002044B
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00022258 File Offset: 0x00020458
		internal virtual Button Button12
		{
			[CompilerGenerated]
			get
			{
				return this._Button12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button12_Click);
				Button button = this._Button12;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button12 = value;
				button = this._Button12;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0002229B File Offset: 0x0002049B
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x000222A8 File Offset: 0x000204A8
		internal virtual Button Button11
		{
			[CompilerGenerated]
			get
			{
				return this._Button11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button11_Click);
				Button button = this._Button11;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button11 = value;
				button = this._Button11;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000222EB File Offset: 0x000204EB
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x000222F5 File Offset: 0x000204F5
		internal virtual TextBox txtInvDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000222FE File Offset: 0x000204FE
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00022308 File Offset: 0x00020508
		internal virtual Label Label28
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00022311 File Offset: 0x00020511
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0002231B File Offset: 0x0002051B
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00022324 File Offset: 0x00020524
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0002232E File Offset: 0x0002052E
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00022337 File Offset: 0x00020537
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00022341 File Offset: 0x00020541
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0002234A File Offset: 0x0002054A
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00022354 File Offset: 0x00020554
		internal virtual TextBox txtContactName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0002235D File Offset: 0x0002055D
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00022367 File Offset: 0x00020567
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00022370 File Offset: 0x00020570
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0002237A File Offset: 0x0002057A
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00022383 File Offset: 0x00020583
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0002238D File Offset: 0x0002058D
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00022396 File Offset: 0x00020596
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x000223A0 File Offset: 0x000205A0
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000223A9 File Offset: 0x000205A9
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x000223B4 File Offset: 0x000205B4
		internal virtual TextBox txtcustomer
		{
			[CompilerGenerated]
			get
			{
				return this._txtcustomer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtcustomer_TextChanged);
				TextBox textBox = this._txtcustomer;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtcustomer = value;
				textBox = this._txtcustomer;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000223F7 File Offset: 0x000205F7
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00022404 File Offset: 0x00020604
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00022447 File Offset: 0x00020647
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00022454 File Offset: 0x00020654
		internal virtual TextBox txtPrice
		{
			[CompilerGenerated]
			get
			{
				return this._txtPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtPrice_TextChanged);
				TextBox textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtPrice = value;
				textBox = this._txtPrice;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00022497 File Offset: 0x00020697
		// (set) Token: 0x060003BF RID: 959 RVA: 0x000224A1 File Offset: 0x000206A1
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x000224AA File Offset: 0x000206AA
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x000224B4 File Offset: 0x000206B4
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000224BD File Offset: 0x000206BD
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000224C7 File Offset: 0x000206C7
		internal virtual TextBox txtSubTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000224D0 File Offset: 0x000206D0
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000224DC File Offset: 0x000206DC
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0002251F File Offset: 0x0002071F
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00022529 File Offset: 0x00020729
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00022532 File Offset: 0x00020732
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0002253C File Offset: 0x0002073C
		internal virtual DataGridView dgvBookingNumbers
		{
			[CompilerGenerated]
			get
			{
				return this._dgvBookingNumbers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvBookingNumbers_CellContentClick);
				DataGridView dataGridView = this._dgvBookingNumbers;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvBookingNumbers = value;
				dataGridView = this._dgvBookingNumbers;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0002257F File Offset: 0x0002077F
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00022589 File Offset: 0x00020789
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00022592 File Offset: 0x00020792
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0002259C File Offset: 0x0002079C
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000225A5 File Offset: 0x000207A5
		// (set) Token: 0x060003CF RID: 975 RVA: 0x000225AF File Offset: 0x000207AF
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000225B8 File Offset: 0x000207B8
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000225C2 File Offset: 0x000207C2
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000225CB File Offset: 0x000207CB
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x000225D5 File Offset: 0x000207D5
		internal virtual TextBox txtTel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000225DE File Offset: 0x000207DE
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000225E8 File Offset: 0x000207E8
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000225F1 File Offset: 0x000207F1
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000225FB File Offset: 0x000207FB
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00022604 File Offset: 0x00020804
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00022610 File Offset: 0x00020810
		internal virtual DataGridView dgvBooking
		{
			[CompilerGenerated]
			get
			{
				return this._dgvBooking;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
				DataGridView dataGridView = this._dgvBooking;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvBooking = value;
				dataGridView = this._dgvBooking;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00022653 File Offset: 0x00020853
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0002265D File Offset: 0x0002085D
		internal virtual TextBox txtComments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00022666 File Offset: 0x00020866
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00022670 File Offset: 0x00020870
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00022679 File Offset: 0x00020879
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00022683 File Offset: 0x00020883
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0002268C File Offset: 0x0002088C
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00022696 File Offset: 0x00020896
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0002269F File Offset: 0x0002089F
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000226A9 File Offset: 0x000208A9
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000226B2 File Offset: 0x000208B2
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x000226BC File Offset: 0x000208BC
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000226FF File Offset: 0x000208FF
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00022709 File Offset: 0x00020909
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00022712 File Offset: 0x00020912
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0002271C File Offset: 0x0002091C
		internal virtual TextBox txtNights
		{
			[CompilerGenerated]
			get
			{
				return this._txtNights;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtNights_TextChanged);
				TextBox textBox = this._txtNights;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtNights = value;
				textBox = this._txtNights;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0002275F File Offset: 0x0002095F
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00022769 File Offset: 0x00020969
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00022772 File Offset: 0x00020972
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0002277C File Offset: 0x0002097C
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00022785 File Offset: 0x00020985
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00022790 File Offset: 0x00020990
		internal virtual Label Label24
		{
			[CompilerGenerated]
			get
			{
				return this._Label24;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label24_Click);
				Label label = this._Label24;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label24 = value;
				label = this._Label24;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000227D3 File Offset: 0x000209D3
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x000227E0 File Offset: 0x000209E0
		internal virtual TextBox txtQtyBooked
		{
			[CompilerGenerated]
			get
			{
				return this._txtQtyBooked;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQtyBooked_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtQtyBooked_TextChanged);
				TextBox textBox = this._txtQtyBooked;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtQtyBooked = value;
				textBox = this._txtQtyBooked;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0002283E File Offset: 0x00020A3E
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00022848 File Offset: 0x00020A48
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00022851 File Offset: 0x00020A51
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0002285C File Offset: 0x00020A5C
		internal virtual CheckBox chkIsAcc
		{
			[CompilerGenerated]
			get
			{
				return this._chkIsAcc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkIsAcc_CheckedChanged);
				CheckBox checkBox = this._chkIsAcc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkIsAcc = value;
				checkBox = this._chkIsAcc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0002289F File Offset: 0x00020A9F
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000228A9 File Offset: 0x00020AA9
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x000228B2 File Offset: 0x00020AB2
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000228BC File Offset: 0x00020ABC
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x000228C5 File Offset: 0x00020AC5
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x000228CF File Offset: 0x00020ACF
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000228D8 File Offset: 0x00020AD8
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x000228E2 File Offset: 0x00020AE2
		internal virtual Label Label29
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000228EB File Offset: 0x00020AEB
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x000228F8 File Offset: 0x00020AF8
		internal virtual TextBox txtAmountPaid
		{
			[CompilerGenerated]
			get
			{
				return this._txtAmountPaid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmountPaid_KeyPress);
				TextBox textBox = this._txtAmountPaid;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAmountPaid = value;
				textBox = this._txtAmountPaid;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0002293C File Offset: 0x00020B3C
		private void LoadCustomers()
		{
			this.datCustomers.Clear();
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
			this.cboCustomers.ValueMember = "CustomerName";
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00022A0C File Offset: 0x00020C0C
		private void UpdateCustomer()
		{
			bool flag = this.IsCustomerNew(this.txtcustomer.Text);
			bool flag2 = flag;
			if (flag2)
			{
				this.currentCustomerEntryNo = 0;
			}
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateCustomerDetails2";
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
			sqlCommand.Parameters.AddWithValue("vatnumber", this.txtvatnumber.Text);
			sqlCommand.Parameters.AddWithValue("bpnumber", this.txtbpnumber.Text);
			sqlCommand.Parameters.AddWithValue("entryno", this.currentCustomerEntryNo);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00022C14 File Offset: 0x00020E14
		private bool IsCustomerNew(string CustomerName)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CountCustomer";
			sqlCommand.Parameters.AddWithValue("CustomerName", CustomerName);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			bool flag3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Operators.ConditionalCompareObjectGreater(dataRow["Customer_Count"], 0, false);
				if (flag2)
				{
					this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					flag3 = false;
				}
				else
				{
					flag3 = true;
				}
			}
			else
			{
				flag3 = true;
			}
			return flag3;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtPerson_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00022D18 File Offset: 0x00020F18
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.SaveCustomerDetails();
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_contactname = this.txtContactName.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_tel = this.txtTel.Text;
				this.og_invdetail1 = this.txtInvDetails1.Text;
				this.og_invdetail2 = this.txtInvDetails2.Text;
				this.og_vatnumber = this.txtvatnumber.Text;
				this.og_bpnumber = this.txtbpnumber.Text;
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Customer details saved successfuly.");
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error saving customer details. Detai: " + ex.Message);
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00022E3C File Offset: 0x0002103C
		private void SaveCustomerDetails()
		{
			try
			{
				this.UpdateCustomer();
				this.LoadCustomers();
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindStringExact(this.txtcustomer.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving customer details. SALE COMPLETED. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00022EB4 File Offset: 0x000210B4
		private void FetchCustomer(string customername)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCustomerDetails";
				sqlCommand.Parameters.AddWithValue("Customername", customername);
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
					this.txtbpnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
					this.txtvatnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])));
					this.og_customername = this.txtcustomer.Text;
					this.og_address = this.txtAddress.Text;
					this.og_contactname = this.txtContactName.Text;
					this.og_mobile = this.txtMobile.Text;
					this.og_email = this.txtEmail.Text;
					this.og_tel = this.txtTel.Text;
					this.og_invdetail1 = this.txtInvDetails1.Text;
					this.og_invdetail2 = this.txtInvDetails2.Text;
					this.og_vatnumber = this.txtvatnumber.Text;
					this.og_bpnumber = this.txtbpnumber.Text;
					this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					this.currentCustomerLimit = Conversions.ToDecimal(Operators.DivideObject(dataRow["AccountLimit"], this.mono_rate));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000231F8 File Offset: 0x000213F8
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
					this.txtbpnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
					this.txtvatnumber.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])));
					this.og_customername = this.txtcustomer.Text;
					this.og_address = this.txtAddress.Text;
					this.og_contactname = this.txtContactName.Text;
					this.og_mobile = this.txtMobile.Text;
					this.og_email = this.txtEmail.Text;
					this.og_tel = this.txtTel.Text;
					this.og_invdetail1 = this.txtInvDetails1.Text;
					this.og_invdetail2 = this.txtInvDetails2.Text;
					this.og_vatnumber = this.txtvatnumber.Text;
					this.og_bpnumber = this.txtbpnumber.Text;
					this.currentCustomerEntryNo = Conversions.ToInteger(dataRow["EntryNo"]);
					this.currentCustomerLimit = Conversions.ToDecimal(Operators.DivideObject(dataRow["AccountLimit"], this.mono_rate));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00023544 File Offset: 0x00021744
		private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchCustomer(Conversions.ToString(this.cboCustomers.SelectedValue));
				this.booking_number = 0;
				this.GetActiveBookings(this.currentCustomerEntryNo);
				this.GetBookingDetails(this.booking_number);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000235B0 File Offset: 0x000217B0
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtcustomer.Text = "Cash";
				this.txtAddress.Text = "";
				this.txtContactName.Text = "";
				this.txtMobile.Text = "";
				this.txtEmail.Text = "";
				this.txtTel.Text = "";
				this.txtInvDetails1.Text = "";
				this.txtInvDetails2.Text = "";
				this.txtvatnumber.Text = "";
				this.txtbpnumber.Text = "";
				this.og_customername = this.txtcustomer.Text;
				this.og_address = this.txtAddress.Text;
				this.og_contactname = this.txtContactName.Text;
				this.og_mobile = this.txtMobile.Text;
				this.og_email = this.txtEmail.Text;
				this.og_tel = this.txtTel.Text;
				this.og_invdetail1 = this.txtInvDetails1.Text;
				this.og_invdetail2 = this.txtInvDetails2.Text;
				this.og_bpnumber = this.txtbpnumber.Text;
				this.og_vatnumber = this.txtvatnumber.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error clearing customer details: " + ex.Message);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00023758 File Offset: 0x00021958
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
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindStringExact(this.txtcustomer.Text);
				this.DTIn.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00023814 File Offset: 0x00021A14
		private void GetActiveBookings(int customer_entry_no)
		{
			this.dgvBookingNumbers.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetActiveBookings";
			sqlCommand.Parameters.AddWithValue("customerentryno", customer_entry_no);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvBookingNumbers.DataSource = dataTable;
			this.dgvBookingNumbers.Columns["CustomerEntryNumber"].Visible = false;
			this.dgvBookingNumbers.Columns["machinename"].Visible = false;
			this.dgvBookingNumbers.Columns["coid"].Visible = false;
			this.dgvBookingNumbers.Columns["branch"].Visible = false;
			this.dgvBookingNumbers.Columns["BookingState"].Visible = false;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "View";
			dataGridViewButtonColumn.Text = "View";
			dataGridViewButtonColumn.Name = "View";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvBookingNumbers.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000239B0 File Offset: 0x00021BB0
		private void GetBookingDetails(int bookingnum)
		{
			this.dgvBooking.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBookingDetails";
			sqlCommand.Parameters.AddWithValue("bookingnumber", bookingnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvBooking.DataSource = dataTable;
			this.dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBooking.Columns["coid"].Visible = false;
			this.dgvBooking.Columns["productcode"].Visible = false;
			this.dgvBooking.Columns["machinename"].Visible = false;
			this.dgvBooking.Columns["bookingtype"].Visible = false;
			this.dgvBooking.Columns["branch"].Visible = false;
			this.dgvBooking.Columns["EntryNo"].Visible = false;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvBooking.Columns.Add(dataGridViewButtonColumn);
			this.GroupBox3.Text = num.ToString() + " records for Booking Number: " + bookingnum.ToString();
			decimal num2 = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvBooking.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					decimal num3 = Conversions.ToDecimal(dataGridViewRow.Cells["SellingPrice"].Value);
					decimal num4 = Conversions.ToDecimal(dataGridViewRow.Cells["Tax"].Value);
					decimal num5 = Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value);
					decimal num6 = Conversions.ToDecimal(dataGridViewRow.Cells["QtyBooked"].Value);
					num2 = decimal.Add(decimal.Add(num2, decimal.Multiply(decimal.Multiply(num3, num5), num6)), num4);
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
			this.txtTotal.Text = num2.ToString();
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00023CA8 File Offset: 0x00021EA8
		private void dgvBookingNumbers_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						this.booking_number = Conversions.ToInteger(this.dgvBookingNumbers.Rows[e.RowIndex].Cells["BookingNumber"].Value);
						this.GetBookingDetails(this.booking_number);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00023D90 File Offset: 0x00021F90
		private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						this.DeleteBookingItem(Conversions.ToInteger(this.dgvBooking.Rows[e.RowIndex].Cells["EntryNo"].Value));
						this.GetBookingDetails(this.booking_number);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing button. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00023E78 File Offset: 0x00022078
		private void DeleteBookingItem(int entry_no)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BookingDelete";
			sqlCommand.Parameters.AddWithValue("entryno", entry_no);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00023F40 File Offset: 0x00022140
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboProduct.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Select product first. ");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.txtcustomer.Text, "Cash", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please select or enter the customer details first.");
					}
					else
					{
						bool flag3 = this.currentCustomerEntryNo == 0;
						if (flag3)
						{
							bool flag4 = (Operators.CompareString(this.txtcustomer.Text, "Cash", false) != 0) & (Operators.CompareString(this.txtcustomer.Text, "", false) != 0);
							if (!flag4)
							{
								MessageBox.Show("Please select a customer or save their details if they are new then try again.");
								return;
							}
							Cursor.Current = Cursors.WaitCursor;
							this.SaveCustomerDetails();
							this.og_customername = this.txtcustomer.Text;
							this.og_address = this.txtAddress.Text;
							this.og_contactname = this.txtContactName.Text;
							this.og_mobile = this.txtMobile.Text;
							this.og_email = this.txtEmail.Text;
							this.og_tel = this.txtTel.Text;
							this.og_invdetail1 = this.txtInvDetails1.Text;
							this.og_invdetail2 = this.txtInvDetails2.Text;
							this.og_vatnumber = this.txtvatnumber.Text;
							this.og_bpnumber = this.txtbpnumber.Text;
							Cursor.Current = Cursors.Default;
						}
						bool flag5 = (Conversion.Val(this.txtNights.Text) <= 0.0) & this.IsBooking;
						if (flag5)
						{
							MessageBox.Show("Error detected. Incorrect dates selected. Negative.");
						}
						else
						{
							Cursor.Current = Cursors.WaitCursor;
							bool flag6 = this.booking_number == 0;
							if (flag6)
							{
								SqlConnection sqlConnection = new SqlConnection(this._cnn);
								SqlCommand sqlCommand = sqlConnection.CreateCommand();
								sqlCommand.Connection = sqlConnection;
								sqlConnection.Open();
								SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
								sqlCommand.Transaction = sqlTransaction;
								try
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "NextBookingNumber";
									this.booking_number = Conversions.ToInteger(sqlCommand.ExecuteScalar());
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "BookingNumberInsert";
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("bookingnumber", this.booking_number);
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("customerentryno", this.currentCustomerEntryNo);
									sqlCommand.Parameters.AddWithValue("datecreated", DateTime.Now);
									sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
									sqlCommand.ExecuteNonQuery();
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "BookingItemInsert";
									sqlCommand.Parameters.AddWithValue("bookingnumber", this.booking_number);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("checkin", this.DTIn.Value);
									sqlCommand.Parameters.AddWithValue("CheckOut", this.DTOut.Value);
									sqlCommand.Parameters.AddWithValue("person", this.txtPerson.Text);
									sqlCommand.Parameters.AddWithValue("Comments", this.txtComments.Text);
									sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("datecreated", DateTime.Now);
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("unitprice", Conversion.Val(this.lblcost.Text));
									sqlCommand.Parameters.AddWithValue("sellingprice", this.priceb4tax);
									bool isBooking = this.IsBooking;
									if (isBooking)
									{
										sqlCommand.Parameters.AddWithValue("Qty", DateAndTime.DateDiff(DateInterval.Day, this.DTIn.Value.Date, this.DTOut.Value.Date, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
										sqlCommand.Parameters.AddWithValue("tax", (Conversion.Val(this.txtPrice.Text) - Convert.ToDouble(this.priceb4tax)) * Conversion.Val(this.txtQtyBooked.Text) * Conversion.Val(this.txtNights.Text));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("Qty", 1);
										sqlCommand.Parameters.AddWithValue("tax", (Conversion.Val(this.txtPrice.Text) - Convert.ToDouble(this.priceb4tax)) * Conversion.Val(this.txtQtyBooked.Text));
									}
									sqlCommand.Parameters.AddWithValue("QtyBooking", Conversion.Val(this.txtQtyBooked.Text));
									sqlCommand.ExecuteNonQuery();
									sqlTransaction.Commit();
									sqlCommand.Connection.Close();
								}
								catch (Exception ex)
								{
									MessageBox.Show("Error saving booking item. Detail: " + ex.Message);
								}
								MessageBox.Show("Booking details created for customer.");
								this.ClearForm();
								this.GetBookingDetails(this.booking_number);
								this.GetActiveBookings(this.currentCustomerEntryNo);
							}
							else
							{
								SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
								SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
								sqlCommand2.CommandType = CommandType.StoredProcedure;
								sqlCommand2.CommandText = "BookingItemInsert";
								sqlCommand2.Parameters.AddWithValue("bookingnumber", this.booking_number);
								sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand2.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand2.Parameters.AddWithValue("checkin", this.DTIn.Value);
								sqlCommand2.Parameters.AddWithValue("checkOut", this.DTOut.Value);
								sqlCommand2.Parameters.AddWithValue("person", this.txtPerson.Text);
								sqlCommand2.Parameters.AddWithValue("comments", this.txtComments.Text);
								sqlCommand2.Parameters.AddWithValue("productid", this.CurrentID);
								sqlCommand2.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
								sqlCommand2.Parameters.AddWithValue("datecreated", DateTime.Now);
								sqlCommand2.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand2.Parameters.AddWithValue("unitprice", Conversion.Val(this.lblcost.Text));
								sqlCommand2.Parameters.AddWithValue("sellingprice", this.priceb4tax);
								bool isBooking2 = this.IsBooking;
								if (isBooking2)
								{
									sqlCommand2.Parameters.AddWithValue("Qty", DateAndTime.DateDiff(DateInterval.Day, this.DTIn.Value.Date, this.DTOut.Value.Date, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
									sqlCommand2.Parameters.AddWithValue("tax", (Conversion.Val(this.txtPrice.Text) - Convert.ToDouble(this.priceb4tax)) * Conversion.Val(this.txtQtyBooked.Text) * Conversion.Val(this.txtNights.Text));
								}
								else
								{
									sqlCommand2.Parameters.AddWithValue("Qty", 1);
									sqlCommand2.Parameters.AddWithValue("tax", (Conversion.Val(this.txtPrice.Text) - Convert.ToDouble(this.priceb4tax)) * Conversion.Val(this.txtQtyBooked.Text));
								}
								sqlCommand2.Parameters.AddWithValue("QtyBooking", Conversion.Val(this.txtQtyBooked.Text));
								using (sqlConnection2)
								{
									sqlConnection2.Open();
									sqlCommand2.ExecuteNonQuery();
									sqlConnection2.Close();
								}
								MessageBox.Show("Booking details added to the customer.");
								this.ClearForm();
								this.GetBookingDetails(this.booking_number);
								this.GetActiveBookings(this.currentCustomerEntryNo);
							}
							Cursor.Current = Cursors.Default;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving booking item. Detail: " + ex2.Message);
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000249DC File Offset: 0x00022BDC
		private void ClearForm()
		{
			this.txtPerson.Text = "";
			this.cboProduct.SelectedIndex = -1;
			this.CurrentID = 0;
			this.txtQtyBooked.Text = Conversions.ToString(MyProject.Forms.Form1.DefaultSellingQty);
			this.txtTotal.Text = "0";
			this.txtAmountPaid.Text = "";
			this.txtPrice.Text = "";
			this.txtComments.Text = "";
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00024A74 File Offset: 0x00022C74
		private void Loadproducts()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboProduct.DataSource = dataTable;
			this.cboProduct.ValueMember = "productid";
			this.cboProduct.DisplayMember = "product_description";
			this.cboProduct.SelectedIndex = -1;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00024B58 File Offset: 0x00022D58
		private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.CurrentID = Conversions.ToInteger(this.cboProduct.SelectedValue);
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByID2";
				sqlCommand.Parameters.AddWithValue("prodtID", this.CurrentID);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					this.IsBooking = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsBooking"])), false, RuntimeHelpers.GetObjectValue(dataRow["isbooking"])));
					int num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])), 0, RuntimeHelpers.GetObjectValue(dataRow["DifferentPricesPerBranch"])));
					this.isunedingstock = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])), 0, RuntimeHelpers.GetObjectValue(dataRow["IsUnlimitedStockItem"])));
					bool flag2 = num2 == 0;
					decimal num4;
					decimal num5;
					if (flag2)
					{
						DataRow productPayMethodDiscount = this.pf.GetProductPayMethodDiscount(this._cnn, this.CurrentID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag3 = Operators.ConditionalCompareObjectNotEqual(productPayMethodDiscount["disc"], 0, false);
						if (flag3)
						{
							this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount["paymethod"]);
							this.discAmount = Conversions.ToDecimal(productPayMethodDiscount["disc"]);
							this.PaymentMethodDiscountEffected = 1;
						}
						else
						{
							this.discAmount = 0m;
						}
						bool flag4 = MyProject.Forms.Form1.CalcBackwards == 1;
						if (flag4)
						{
							object obj = dataRow["SellingPrice"];
							object obj2 = null;
							Type typeFromHandle = typeof(Math);
							string text = "Round";
							object[] array = new object[3];
							array[0] = Operators.MultiplyObject(Operators.DivideObject(dataRow["TaxRate"], 100), dataRow["SellingPrice"]);
							int num3 = 1;
							Form1 form = MyProject.Forms.Form1;
							ref int ptr = ref form.DecimalPlaces;
							array[num3] = form.DecimalPlaces;
							array[2] = MidpointRounding.AwayFromZero;
							object[] array2 = array;
							string[] array3 = null;
							Type[] array4 = null;
							bool[] array5 = new bool[3];
							array5[1] = true;
							bool[] array6 = array5;
							object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text, array, array3, array4, array5);
							if (array6[1])
							{
								ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(int));
							}
							num4 = Conversions.ToDecimal(Operators.MultiplyObject(Operators.AddObject(obj, obj3), this.mono_rate));
						}
						else
						{
							num4 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), this.mono_rate), productPayMethodDiscount["disc"]));
						}
						num5 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPriceWholesale"])))), this.mono_rate);
						this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"])), 0, RuntimeHelpers.GetObjectValue(dataRow["WholesaleQTY"]))));
						this.specialprice = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["specialprice"]))));
					}
					else
					{
						DataRow productPayMethodDiscount2 = this.pf.GetProductPayMethodDiscount(this._cnn, this.CurrentID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.cboPayMeth.SelectedValue), Conversions.ToDecimal(dataRow["SellingPrice"]), this.mono_rate);
						bool flag5 = Operators.ConditionalCompareObjectGreater(productPayMethodDiscount2["disc"], 0, false);
						if (flag5)
						{
							this.discPaymentMethod = Conversions.ToInteger(productPayMethodDiscount2["paymethod"]);
							this.discAmount = Conversions.ToDecimal(productPayMethodDiscount2["disc"]);
							this.PaymentMethodDiscountEffected = 1;
						}
						DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(dataRow["productid"]));
						num4 = Conversions.ToDecimal(Operators.AddObject(decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["sellingprice"])))), this.mono_rate), productPayMethodDiscount2["disc"]));
						num5 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleprice"])))), this.mono_rate);
						this.currentWholesaleQty = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["wholesaleqty"]))));
					}
					decimal num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
					bool flag6 = MyProject.Forms.Form1.PricesAreAfterTax == 0;
					if (flag6)
					{
						bool flag7 = MyProject.Forms.Form1.CalcBackwards == 1;
						decimal num7;
						if (flag7)
						{
							this.priceb4tax = Conversions.ToDecimal(Operators.DivideObject(num4, Operators.AddObject(1, dataRow["TaxRate"])));
							num7 = Math.Round(num4, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero);
						}
						else
						{
							this.priceb4tax = num4;
							num7 = decimal.Add(num4, Math.Round(decimal.Multiply(decimal.Divide(num6, 100m), num4), MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero));
						}
						this.priceb4tax = this.priceb4tax;
						num7 = num7;
						this.priceb4taxWholesale = num5;
						this.priceb4taxWholesale = this.priceb4taxWholesale;
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = decimal.Add(num5, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num5));
						this.totpriceWholesale = this.totpriceWholesale;
						bool flag8 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag8)
						{
							this.txtPrice.Text = Math.Round(this.totpriceWholesale, 8, MidpointRounding.AwayFromZero).ToString();
						}
						else
						{
							this.txtPrice.Text = Math.Round(num7, MyProject.Forms.Form1.DecimalPlaces, MidpointRounding.AwayFromZero).ToString();
						}
					}
					else
					{
						num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.priceb4tax = Math.Round(decimal.Divide(num4, decimal.Add(1m, decimal.Divide(num6, 100m))), 5, MidpointRounding.AwayFromZero);
						this.currenttaxrate = num6;
						decimal num8 = num4;
						num8 = num8;
						this.priceb4taxWholesale = Math.Round(decimal.Divide(num5, decimal.Add(1m, decimal.Divide(num6, 100m))), 5, MidpointRounding.AwayFromZero);
						this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
						this.totpriceWholesale = num5;
						bool flag9 = MyProject.Forms.Form1.IsWholesaleShop == 1;
						if (flag9)
						{
							this.txtPrice.Text = this.totpriceWholesale.ToString();
						}
						else
						{
							this.txtPrice.Text = num8.ToString();
						}
					}
					this.lblcost.Text = Conversions.ToString(Operators.MultiplyObject(dataRow["Cost"], this.mono_rate));
					this.lbltax.Text = Math.Round(num6, 5, MidpointRounding.AwayFromZero).ToString();
					this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				}
			}
			catch (InvalidCastException ex)
			{
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error loading products. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000255BC File Offset: 0x000237BC
		private void cboPayMeth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				decimal num = this.mono_rate;
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
				this.txtPrice.Text = (Conversion.Val(this.txtPrice.Text) / Convert.ToDouble(num) * Convert.ToDouble(this.mono_rate)).ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00025644 File Offset: 0x00023844
		private void GetPayMethDetails(int paymethid)
		{
			DataTable paymentMethodDetails = this.pf.GetPaymentMethodDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn);
			bool flag = paymentMethodDetails.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = paymentMethodDetails.Rows[0];
				this.mono_rate = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000256B4 File Offset: 0x000238B4
		private void txtPrice_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool isBooking = this.IsBooking;
				if (isBooking)
				{
					this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtNights.Text) * Conversion.Val(this.txtQtyBooked.Text));
				}
				else
				{
					this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtQtyBooked.Text));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0002576C File Offset: 0x0002396C
		private void DTIn_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtNights.Text = DateAndTime.DateDiff(DateInterval.Day, this.DTIn.Value.Date, this.DTOut.Value.Date, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
				this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtNights.Text));
				bool flag = Conversion.Val(this.txtNights.Text) <= 0.0;
				if (flag)
				{
					MessageBox.Show("Negative dates selected. Check Check In date.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00025844 File Offset: 0x00023A44
		private void DTOut_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtNights.Text = DateAndTime.DateDiff(DateInterval.Day, this.DTIn.Value.Date, this.DTOut.Value.Date, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
				this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtNights.Text));
				bool flag = Conversion.Val(this.txtNights.Text) <= 0.0;
				if (flag)
				{
					MessageBox.Show("Negative dates selected. Check Check In date.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0002591C File Offset: 0x00023B1C
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
			bool flag = Operators.CompareString(MyProject.Forms.Form1.ChangePaymentMethod, "", false) != 0;
			if (flag)
			{
				this.cboPayMeth.SelectedIndex = this.cboPayMeth.FindStringExact(MyProject.Forms.Form1.ChangePaymentMethod);
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
			}
			else
			{
				this.cboPayMeth.SelectedIndex = 0;
				this.GetPayMethDetails(Conversions.ToInteger(this.cboPayMeth.SelectedValue));
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00025A44 File Offset: 0x00023C44
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

		// Token: 0x0600041B RID: 1051 RVA: 0x00025AE4 File Offset: 0x00023CE4
		private void Bookings_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomers();
				this.LoadPayMeths();
				this.Loadproducts();
				this.LoadPaymentTerms();
				bool flag = MyProject.Forms.Form1.DateChange == 1;
				if (flag)
				{
					this.DTdate.Enabled = true;
				}
				else
				{
					this.DTdate.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label24_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtcustomer_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00025B7C File Offset: 0x00023D7C
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.booking_number != 0) & (this.dgvBooking.Rows.Count > 0) & (this.currentCustomerEntryNo != 0);
				if (flag)
				{
					bool flag2 = !this.chkIsAcc.Checked;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(this.txtAmountPaid.Text, "", false) == 0;
						if (flag3)
						{
							MessageBox.Show("Please enter the amount paid for this CASH sale.");
							return;
						}
						bool flag4 = Conversion.Val(this.txtAmountPaid.Text) != Conversion.Val(this.txtTotal.Text);
						if (flag4)
						{
							MessageBox.Show("Please ensure that the amount paid is equal to the invoice amount. If not make this a credit sale then enter the amount paid in the Account Payments form.");
							return;
						}
					}
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
					sqlCommand.Transaction = sqlTransaction;
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "GetSalesInvoiceNumber";
					sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
					sqlCommand.Parameters.AddWithValue("allowbackdated", MyProject.Forms.Form1.DateChange);
					sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
					sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.ExecuteNonQuery();
					int num = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandText = "InsertNextSalesInvNumber";
					sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
					sqlCommand.Parameters.AddWithValue("newinvnumber", num);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.ExecuteNonQuery();
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvBooking.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "InsertNewSale2WarehouseBooking";
							sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("invoicenum", num);
							sqlCommand.Parameters.AddWithValue("productid", Conversions.ToInteger(dataGridViewRow.Cells["productid"].Value));
							sqlCommand.Parameters.AddWithValue("isstockin", 0);
							sqlCommand.Parameters.AddWithValue("ref", this.txtcustomer.Text);
							sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Qty"].Value)));
							sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["UnitPrice"].Value));
							sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SellingPrice"].Value)), this.mono_rate));
							sqlCommand.Parameters.AddWithValue("paymentmethod", 1);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("trancode", 3);
							sqlCommand.Parameters.AddWithValue("prodcode", dataGridViewRow.Cells["ProductCode"].Value.ToString());
							sqlCommand.Parameters.AddWithValue("TranTime", Conversion.Val(DateTime.Now.ToString("HHmm")));
							sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)) / Convert.ToDouble(this.mono_rate));
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.Parameters.AddWithValue("shift", "");
							sqlCommand.Parameters.AddWithValue("ShiftDate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("BatchNumber", "");
							sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
							sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
							sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
							sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
							sqlCommand.Parameters.AddWithValue("discountamount", 0);
							sqlCommand.Parameters.AddWithValue("consultant", "");
							sqlCommand.Parameters.AddWithValue("invdiscount", 0);
							sqlCommand.Parameters.AddWithValue("collection", "");
							sqlCommand.Parameters.AddWithValue("discountdesc", "");
							sqlCommand.Parameters.AddWithValue("otherdetail", dataGridViewRow.Cells["bookingnumber"].Value.ToString());
							sqlCommand.Parameters.AddWithValue("comments", dataGridViewRow.Cells["comments"].Value.ToString());
							sqlCommand.Parameters.AddWithValue("paymethref", "");
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("isbooking", 1);
							sqlCommand.Parameters.AddWithValue("QtyBooked", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["QtyBooked"].Value));
							sqlCommand.Parameters.AddWithValue("checkin", Conversions.ToDate(dataGridViewRow.Cells["checkin"].Value));
							sqlCommand.Parameters.AddWithValue("checkout", Conversions.ToDate(dataGridViewRow.Cells["checkout"].Value));
							sqlCommand.Parameters.AddWithValue("persons", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PersonInRoom"].Value));
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
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandText = "BookingInvoicedUpdate";
					sqlCommand.Parameters.AddWithValue("bookingnumber", this.booking_number);
					sqlCommand.Parameters.AddWithValue("invnum", num);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.ExecuteNonQuery();
					bool @checked = this.chkIsAcc.Checked;
					if (@checked)
					{
						DateTime dateTime = DateTime.Today.AddDays((double)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue)));
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "BillingInsertAccSale2";
						sqlCommand.Parameters.AddWithValue("customername", this.txtcustomer.Text);
						sqlCommand.Parameters.AddWithValue("invoicenumber", num);
						sqlCommand.Parameters.AddWithValue("amount", decimal.Divide(Convert.ToDecimal(this.txtTotal.Text), this.mono_rate));
						sqlCommand.Parameters.AddWithValue("shiftdate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTdate.Value.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
						sqlCommand.Parameters.AddWithValue("teller", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("terms", RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue));
						sqlCommand.Parameters.AddWithValue("DueDate", Convert.ToInt32(dateTime.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
						sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
						sqlCommand.Parameters.AddWithValue("paymentmethodiddesc", this.cboPayMeth.Text);
						sqlCommand.Parameters.AddWithValue("invdiscount", 0);
						sqlCommand.Parameters.AddWithValue("comment", this.txtComments.Text);
						sqlCommand.Parameters.AddWithValue("termsdesc", this.cboTerms.Text);
						sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
						sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
						sqlCommand.ExecuteNonQuery();
					}
					else
					{
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "InsertActualPaymentMethods";
						sqlCommand.Parameters.AddWithValue("invnum", num);
						sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
						sqlCommand.Parameters.AddWithValue("paydesc", this.cboPayMeth.Text);
						sqlCommand.Parameters.AddWithValue("amt", Conversion.Val(this.txtTotal.Text));
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("rate", this.mono_rate);
						sqlCommand.ExecuteNonQuery();
					}
					sqlTransaction.Commit();
					sqlConnection.Close();
					MessageBox.Show("Invoice saved successfully.");
					this.ClearForm();
					DataTable dataTable = new DataTable();
					this.dgvBooking.DataSource = dataTable;
					this.cboCustomers.SelectedIndex = -1;
					this.PrintInvoice("", num);
				}
				else
				{
					MessageBox.Show("Please check if the customer and booking number are selected. ");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error invoicing. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00026914 File Offset: 0x00024B14
		private void PrintInvoice(string revmax_digsig, int invoicenumber)
		{
			SalesInvPortraitBooking salesInvPortraitBooking = new SalesInvPortraitBooking();
			salesInvPortraitBooking.invnum = invoicenumber;
			salesInvPortraitBooking.revmax_sign = revmax_digsig;
			salesInvPortraitBooking.isEltradeESDfiscal = 1;
			salesInvPortraitBooking.ShowDialog(this);
			salesInvPortraitBooking.Dispose();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0002694C File Offset: 0x00024B4C
		private void chkIsAcc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkIsAcc.Checked;
				if (@checked)
				{
					this.cboTerms.Visible = true;
					this.Button3.Text = "INVOICE CREDIT SALE";
					this.txtAmountPaid.Visible = false;
					this.Label29.Visible = false;
				}
				else
				{
					this.cboTerms.Visible = false;
					this.Button3.Text = "INVOICE CASH SALE";
					this.txtAmountPaid.Visible = true;
					this.Label29.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00026A04 File Offset: 0x00024C04
		private void txtQtyBooked_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00026A50 File Offset: 0x00024C50
		private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00026A9C File Offset: 0x00024C9C
		private void txtQtyBooked_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool isBooking = this.IsBooking;
				if (isBooking)
				{
					this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtNights.Text) * Conversion.Val(this.txtQtyBooked.Text));
				}
				else
				{
					this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtQtyBooked.Text));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00026B54 File Offset: 0x00024D54
		private void txtNights_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool isBooking = this.IsBooking;
				if (isBooking)
				{
					this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtNights.Text) * Conversion.Val(this.txtQtyBooked.Text));
				}
				else
				{
					this.txtSubTotal.Text = Conversions.ToString(Conversion.Val(this.txtPrice.Text) * Conversion.Val(this.txtQtyBooked.Text));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040001CB RID: 459
		private string _cnn;

		// Token: 0x040001CC RID: 460
		private DataTable datCustomers;

		// Token: 0x040001CD RID: 461
		private int currentCustomerEntryNo;

		// Token: 0x040001CE RID: 462
		private int CurrentID;

		// Token: 0x040001CF RID: 463
		private decimal mono_rate;

		// Token: 0x040001D0 RID: 464
		private string og_customername;

		// Token: 0x040001D1 RID: 465
		private string og_address;

		// Token: 0x040001D2 RID: 466
		private string og_contactname;

		// Token: 0x040001D3 RID: 467
		private string og_mobile;

		// Token: 0x040001D4 RID: 468
		private string og_email;

		// Token: 0x040001D5 RID: 469
		private string og_tel;

		// Token: 0x040001D6 RID: 470
		private string og_invdetail1;

		// Token: 0x040001D7 RID: 471
		private string og_invdetail2;

		// Token: 0x040001D8 RID: 472
		private string og_vatnumber;

		// Token: 0x040001D9 RID: 473
		private string og_bpnumber;

		// Token: 0x040001DA RID: 474
		private decimal currentCustomerLimit;

		// Token: 0x040001DB RID: 475
		private int booking_number;

		// Token: 0x040001DC RID: 476
		private int isunedingstock;

		// Token: 0x040001DD RID: 477
		private PublicFunctions pf;

		// Token: 0x040001DE RID: 478
		private decimal discAmount;

		// Token: 0x040001DF RID: 479
		private int discPaymentMethod;

		// Token: 0x040001E0 RID: 480
		private int PaymentMethodDiscountEffected;

		// Token: 0x040001E1 RID: 481
		private decimal priceb4tax;

		// Token: 0x040001E2 RID: 482
		private decimal priceb4taxWholesale;

		// Token: 0x040001E3 RID: 483
		private decimal currentWholesaleQty;

		// Token: 0x040001E4 RID: 484
		private decimal taxdueWholesale;

		// Token: 0x040001E5 RID: 485
		private decimal totpriceWholesale;

		// Token: 0x040001E6 RID: 486
		private int WholesalePriceByQty;

		// Token: 0x040001E7 RID: 487
		private decimal specialprice;

		// Token: 0x040001E8 RID: 488
		private decimal currenttaxrate;

		// Token: 0x040001E9 RID: 489
		private string CurrentCode;

		// Token: 0x040001EA RID: 490
		private bool IsBooking;
	}
}
