using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000043 RID: 67
	[DesignerGenerated]
	public partial class DialogNumeric : Form
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x0008D350 File Offset: 0x0008B550
		public DialogNumeric()
		{
			base.Load += this.DialogNumeric_Load;
			this.auto_calc = 0;
			this.enable_autcalc = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0008DECC File Offset: 0x0008C0CC
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x0008DED8 File Offset: 0x0008C0D8
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

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0008DF1B File Offset: 0x0008C11B
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x0008DF25 File Offset: 0x0008C125
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0008DF2E File Offset: 0x0008C12E
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0008DF38 File Offset: 0x0008C138
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

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0008DF7B File Offset: 0x0008C17B
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x0008DF88 File Offset: 0x0008C188
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

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0008DFCB File Offset: 0x0008C1CB
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0008DFD8 File Offset: 0x0008C1D8
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0008E01B File Offset: 0x0008C21B
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0008E028 File Offset: 0x0008C228
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

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0008E06B File Offset: 0x0008C26B
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x0008E078 File Offset: 0x0008C278
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0008E0BB File Offset: 0x0008C2BB
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0008E0C8 File Offset: 0x0008C2C8
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0008E10B File Offset: 0x0008C30B
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x0008E118 File Offset: 0x0008C318
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0008E15B File Offset: 0x0008C35B
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x0008E168 File Offset: 0x0008C368
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0008E1AB File Offset: 0x0008C3AB
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x0008E1B8 File Offset: 0x0008C3B8
		internal virtual Button Button10
		{
			[CompilerGenerated]
			get
			{
				return this._Button10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button10_Click);
				Button button = this._Button10;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button10 = value;
				button = this._Button10;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0008E1FB File Offset: 0x0008C3FB
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x0008E208 File Offset: 0x0008C408
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

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0008E24B File Offset: 0x0008C44B
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x0008E258 File Offset: 0x0008C458
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0008E29B File Offset: 0x0008C49B
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x0008E2A5 File Offset: 0x0008C4A5
		internal virtual Label lblamt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0008E2AE File Offset: 0x0008C4AE
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0008E2B8 File Offset: 0x0008C4B8
		internal virtual Button Button13
		{
			[CompilerGenerated]
			get
			{
				return this._Button13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button13_Click);
				Button button = this._Button13;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button13 = value;
				button = this._Button13;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0008E2FB File Offset: 0x0008C4FB
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x0008E308 File Offset: 0x0008C508
		internal virtual Button Button14
		{
			[CompilerGenerated]
			get
			{
				return this._Button14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button14_Click);
				Button button = this._Button14;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button14 = value;
				button = this._Button14;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0008E34C File Offset: 0x0008C54C
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "1";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "1";
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0008E3B0 File Offset: 0x0008C5B0
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "2";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "2";
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0008E414 File Offset: 0x0008C614
		private void Button3_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "3";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "3";
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0008E478 File Offset: 0x0008C678
		private void Button6_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "4";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "4";
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0008E4DC File Offset: 0x0008C6DC
		private void Button5_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "5";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "5";
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0008E540 File Offset: 0x0008C740
		private void Button4_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "6";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "6";
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0008E5A4 File Offset: 0x0008C7A4
		private void Button9_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "7";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "7";
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0008E608 File Offset: 0x0008C808
		private void Button8_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "8";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "8";
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0008E66C File Offset: 0x0008C86C
		private void Button7_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "9";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "9";
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0008E6D0 File Offset: 0x0008C8D0
		private void Button12_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "0";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + "0";
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0008E732 File Offset: 0x0008C932
		private void Button11_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0008E740 File Offset: 0x0008C940
		private void Button10_Click(object sender, EventArgs e)
		{
			int length = this.lblamt.Text.Length;
			this.lblamt.Text = this.lblamt.Text.Substring(0, checked(length - 1));
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0008E780 File Offset: 0x0008C980
		private void Button13_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lblamt.Text, "0", false) == 0;
			if (flag)
			{
				this.lblamt.Text = "0.";
			}
			else
			{
				this.lblamt.Text = this.lblamt.Text + ".";
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0008E7E4 File Offset: 0x0008C9E4
		private void DialogNumeric_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.enable_autcalc == 1;
				if (flag)
				{
					this.Button14.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0008E848 File Offset: 0x0008CA48
		private void Button14_Click(object sender, EventArgs e)
		{
			this.auto_calc = 1;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x04000722 RID: 1826
		public int auto_calc;

		// Token: 0x04000723 RID: 1827
		public int enable_autcalc;
	}
}
