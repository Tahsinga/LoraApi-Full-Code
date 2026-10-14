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
	// Token: 0x02000186 RID: 390
	[DesignerGenerated]
	public partial class Returns : Form
	{
		// Token: 0x060039EA RID: 14826 RVA: 0x001F74B0 File Offset: 0x001F56B0
		public Returns()
		{
			base.Load += this.Returns_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.priceb4tax = 0m;
			this.InitializeComponent();
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x001F91F3 File Offset: 0x001F73F3
		// (set) Token: 0x060039EE RID: 14830 RVA: 0x001F91FD File Offset: 0x001F73FD
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x001F9206 File Offset: 0x001F7406
		// (set) Token: 0x060039F0 RID: 14832 RVA: 0x001F9210 File Offset: 0x001F7410
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x001F9219 File Offset: 0x001F7419
		// (set) Token: 0x060039F2 RID: 14834 RVA: 0x001F9223 File Offset: 0x001F7423
		internal virtual TextBox txtSearchProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x001F922C File Offset: 0x001F742C
		// (set) Token: 0x060039F4 RID: 14836 RVA: 0x001F9236 File Offset: 0x001F7436
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x001F923F File Offset: 0x001F743F
		// (set) Token: 0x060039F6 RID: 14838 RVA: 0x001F9249 File Offset: 0x001F7449
		internal virtual TextBox txtBarCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x001F9252 File Offset: 0x001F7452
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x001F925C File Offset: 0x001F745C
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x001F9265 File Offset: 0x001F7465
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x001F926F File Offset: 0x001F746F
		internal virtual DataGridView DGVSearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x001F9278 File Offset: 0x001F7478
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x001F9282 File Offset: 0x001F7482
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x001F928B File Offset: 0x001F748B
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x001F9295 File Offset: 0x001F7495
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x001F929E File Offset: 0x001F749E
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x001F92A8 File Offset: 0x001F74A8
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x001F92B1 File Offset: 0x001F74B1
		// (set) Token: 0x06003A02 RID: 14850 RVA: 0x001F92BB File Offset: 0x001F74BB
		internal virtual TextBox txtsearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x001F92C4 File Offset: 0x001F74C4
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x001F92CE File Offset: 0x001F74CE
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x001F92D7 File Offset: 0x001F74D7
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x001F92E4 File Offset: 0x001F74E4
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

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x001F9327 File Offset: 0x001F7527
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x001F9331 File Offset: 0x001F7531
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x001F933A File Offset: 0x001F753A
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x001F9344 File Offset: 0x001F7544
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x001F934D File Offset: 0x001F754D
		// (set) Token: 0x06003A0C RID: 14860 RVA: 0x001F9357 File Offset: 0x001F7557
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x001F9360 File Offset: 0x001F7560
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x001F936A File Offset: 0x001F756A
		internal virtual TextBox txtQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06003A0F RID: 14863 RVA: 0x001F9373 File Offset: 0x001F7573
		// (set) Token: 0x06003A10 RID: 14864 RVA: 0x001F937D File Offset: 0x001F757D
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06003A11 RID: 14865 RVA: 0x001F9386 File Offset: 0x001F7586
		// (set) Token: 0x06003A12 RID: 14866 RVA: 0x001F9390 File Offset: 0x001F7590
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06003A13 RID: 14867 RVA: 0x001F9399 File Offset: 0x001F7599
		// (set) Token: 0x06003A14 RID: 14868 RVA: 0x001F93A3 File Offset: 0x001F75A3
		internal virtual Label lbltax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06003A15 RID: 14869 RVA: 0x001F93AC File Offset: 0x001F75AC
		// (set) Token: 0x06003A16 RID: 14870 RVA: 0x001F93B6 File Offset: 0x001F75B6
		internal virtual Label lblcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06003A17 RID: 14871 RVA: 0x001F93BF File Offset: 0x001F75BF
		// (set) Token: 0x06003A18 RID: 14872 RVA: 0x001F93C9 File Offset: 0x001F75C9
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x001F93D2 File Offset: 0x001F75D2
		// (set) Token: 0x06003A1A RID: 14874 RVA: 0x001F93DC File Offset: 0x001F75DC
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x001F93E5 File Offset: 0x001F75E5
		// (set) Token: 0x06003A1C RID: 14876 RVA: 0x001F93EF File Offset: 0x001F75EF
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06003A1D RID: 14877 RVA: 0x001F93F8 File Offset: 0x001F75F8
		// (set) Token: 0x06003A1E RID: 14878 RVA: 0x001F9402 File Offset: 0x001F7602
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06003A1F RID: 14879 RVA: 0x001F940B File Offset: 0x001F760B
		// (set) Token: 0x06003A20 RID: 14880 RVA: 0x001F9415 File Offset: 0x001F7615
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x001F941E File Offset: 0x001F761E
		// (set) Token: 0x06003A22 RID: 14882 RVA: 0x001F9428 File Offset: 0x001F7628
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x001F9431 File Offset: 0x001F7631
		// (set) Token: 0x06003A24 RID: 14884 RVA: 0x001F943B File Offset: 0x001F763B
		internal virtual TextBox txtPaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x001F9444 File Offset: 0x001F7644
		// (set) Token: 0x06003A26 RID: 14886 RVA: 0x001F944E File Offset: 0x001F764E
		internal virtual TextBox txtRate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x001F9457 File Offset: 0x001F7657
		// (set) Token: 0x06003A28 RID: 14888 RVA: 0x001F9464 File Offset: 0x001F7664
		internal virtual ComboBox cboPayMethods
		{
			[CompilerGenerated]
			get
			{
				return this._cboPayMethods;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPayMethods_SelectedIndexChanged);
				ComboBox comboBox = this._cboPayMethods;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPayMethods = value;
				comboBox = this._cboPayMethods;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x001F94A7 File Offset: 0x001F76A7
		// (set) Token: 0x06003A2A RID: 14890 RVA: 0x001F94B1 File Offset: 0x001F76B1
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x001F94BA File Offset: 0x001F76BA
		// (set) Token: 0x06003A2C RID: 14892 RVA: 0x001F94C4 File Offset: 0x001F76C4
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

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x001F9507 File Offset: 0x001F7707
		// (set) Token: 0x06003A2E RID: 14894 RVA: 0x001F9511 File Offset: 0x001F7711
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x001F951A File Offset: 0x001F771A
		// (set) Token: 0x06003A30 RID: 14896 RVA: 0x001F9524 File Offset: 0x001F7724
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x001F952D File Offset: 0x001F772D
		// (set) Token: 0x06003A32 RID: 14898 RVA: 0x001F9538 File Offset: 0x001F7738
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

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x001F957B File Offset: 0x001F777B
		// (set) Token: 0x06003A34 RID: 14900 RVA: 0x001F9585 File Offset: 0x001F7785
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x001F958E File Offset: 0x001F778E
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x001F9598 File Offset: 0x001F7798
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06003A37 RID: 14903 RVA: 0x001F95A1 File Offset: 0x001F77A1
		// (set) Token: 0x06003A38 RID: 14904 RVA: 0x001F95AB File Offset: 0x001F77AB
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06003A39 RID: 14905 RVA: 0x001F95B4 File Offset: 0x001F77B4
		// (set) Token: 0x06003A3A RID: 14906 RVA: 0x001F95BE File Offset: 0x001F77BE
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x001F95C7 File Offset: 0x001F77C7
		// (set) Token: 0x06003A3C RID: 14908 RVA: 0x001F95D1 File Offset: 0x001F77D1
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x001F95DA File Offset: 0x001F77DA
		// (set) Token: 0x06003A3E RID: 14910 RVA: 0x001F95E4 File Offset: 0x001F77E4
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x001F95ED File Offset: 0x001F77ED
		// (set) Token: 0x06003A40 RID: 14912 RVA: 0x001F95F7 File Offset: 0x001F77F7
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x001F9600 File Offset: 0x001F7800
		// (set) Token: 0x06003A42 RID: 14914 RVA: 0x001F960A File Offset: 0x001F780A
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x001F9613 File Offset: 0x001F7813
		// (set) Token: 0x06003A44 RID: 14916 RVA: 0x001F961D File Offset: 0x001F781D
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x001F9626 File Offset: 0x001F7826
		// (set) Token: 0x06003A46 RID: 14918 RVA: 0x001F9630 File Offset: 0x001F7830
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x001F9639 File Offset: 0x001F7839
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x001F9643 File Offset: 0x001F7843
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x001F964C File Offset: 0x001F784C
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x001F9656 File Offset: 0x001F7856
		internal virtual TextBox txtTax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x001F965F File Offset: 0x001F785F
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x001F9669 File Offset: 0x001F7869
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x001F9674 File Offset: 0x001F7874
		private void Returns_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadPaymentMethods();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x001F96C4 File Offset: 0x001F78C4
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

		// Token: 0x06003A4F RID: 14927 RVA: 0x001F9730 File Offset: 0x001F7930
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

		// Token: 0x06003A50 RID: 14928 RVA: 0x001F9828 File Offset: 0x001F7A28
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

		// Token: 0x06003A51 RID: 14929 RVA: 0x001F99C8 File Offset: 0x001F7BC8
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

		// Token: 0x06003A52 RID: 14930 RVA: 0x001F9A28 File Offset: 0x001F7C28
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

		// Token: 0x06003A53 RID: 14931 RVA: 0x001F9AEC File Offset: 0x001F7CEC
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

		// Token: 0x06003A54 RID: 14932 RVA: 0x001F9B4C File Offset: 0x001F7D4C
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
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

		// Token: 0x06003A55 RID: 14933 RVA: 0x001F9C04 File Offset: 0x001F7E04
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
				decimal num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
				this.priceb4tax = num2;
				this.priceb4tax = Math.Round(this.priceb4tax, 2);
				decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num4 = decimal.Add(num2, decimal.Multiply(decimal.Divide(num3, 100m), num2));
				num4 = Math.Round(num4, 2);
				this.txtPrice.Text = num4.ToString();
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = num3.ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x001F9DD0 File Offset: 0x001F7FD0
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
				double num2 = Conversions.ToDouble(dataRow["SellingPrice"]);
				this.priceb4tax = new decimal(num2);
				this.priceb4tax = Math.Round(this.priceb4tax, 2);
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtPrice.Text = num2.ToString();
				this.lblcost.Text = Conversions.ToString(dataRow["Cost"]);
				this.lbltax.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])));
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x001F9F60 File Offset: 0x001F8160
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.Verify();
			if (flag)
			{
				bool flag2 = Conversion.Val(this.txtQty.Text) > 0.0;
				if (flag2)
				{
					this.AppendGrid();
					this.CalcTotalSale();
					this.txtSearchProductCode.Text = " ";
					this.txtBarCode.Text = "0";
					this.txtQty.Text = Conversions.ToString(0);
					this.txtsearch.Text = "";
					this.txtBarCode.Text = "";
					this.txtBarCode.Focus();
				}
				else
				{
					MessageBox.Show("Please enter the quantity bought.");
				}
			}
			else
			{
				MessageBox.Show("Please make sure that sales, quanity and stock available details are correct.");
			}
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x001FA02C File Offset: 0x001F822C
		public bool Verify()
		{
			bool flag = (Conversion.Val(this.txtQty.Text) <= 0.0) | (Conversion.Val(this.txtPrice.Text) <= 0.0);
			bool flag3;
			if (flag)
			{
				bool flag2 = false;
				flag3 = flag2;
			}
			else
			{
				bool flag2 = true;
				flag3 = flag2;
			}
			return flag3;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x001FA08C File Offset: 0x001F828C
		private void AppendGrid()
		{
			int num = 0;
			int num2 = 0;
			decimal num3 = 0m;
			decimal num4 = decimal.Add(Convert.ToDecimal(this.txtPrice.Text), num3);
			decimal num5 = Convert.ToDecimal(this.lbltax.Text);
			num5 = decimal.Multiply(Math.Round(decimal.Subtract(num4, decimal.Divide(num4, decimal.Add(1m, decimal.Divide(num5, 100m)))), 2), Convert.ToDecimal(this.txtQty.Text));
			num5 = Math.Round(num5, 2);
			decimal num6 = new decimal(Conversion.Val(this.txtQty.Text) * Convert.ToDouble(num4));
			num6 = Math.Round(num6, 2);
			string[] array = new string[]
			{
				Conversions.ToString(this.CurrentID),
				this.txtSearchProductCode.Text,
				this.txtDesc.Text,
				this.priceb4tax.ToString(),
				this.txtQty.Text,
				num5.ToString(),
				num6.ToString(),
				this.lblcost.Text,
				Conversions.ToString(num),
				"",
				Conversions.ToString(num2)
			};
			this.DataGridView1.Rows.Add(array);
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x001FA1E4 File Offset: 0x001F83E4
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

		// Token: 0x06003A5D RID: 14941 RVA: 0x001FA2C4 File Offset: 0x001F84C4
		private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				this.CalcTotalSale();
				this.txtSearchProductCode.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deletting row. Restart SALE.");
			}
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x001FA314 File Offset: 0x001F8514
		private void LoadPaymentMethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPayMethods.DataSource = dataTable;
			this.cboPayMethods.ValueMember = "PaymentMethodID";
			this.cboPayMethods.DisplayMember = "PaymentMethodDesc";
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x001FA3B4 File Offset: 0x001F85B4
		private void cboPayMethods_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040018DE RID: 6366
		private string _cnn;

		// Token: 0x040018DF RID: 6367
		private int CurrentID;

		// Token: 0x040018E0 RID: 6368
		private decimal priceb4tax;
	}
}
