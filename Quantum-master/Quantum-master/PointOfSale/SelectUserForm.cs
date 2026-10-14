using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x020001BD RID: 445
	[DesignerGenerated]
	public partial class SelectUserForm : Form
	{
		// Token: 0x0600504C RID: 20556 RVA: 0x002FEB48 File Offset: 0x002FCD48
		public SelectUserForm()
		{
			base.Load += this.SelectUserForm_Load;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x0600504F RID: 20559 RVA: 0x002FEEC9 File Offset: 0x002FD0C9
		// (set) Token: 0x06005050 RID: 20560 RVA: 0x002FEED3 File Offset: 0x002FD0D3
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x002FEEDC File Offset: 0x002FD0DC
		// (set) Token: 0x06005052 RID: 20562 RVA: 0x002FEEE6 File Offset: 0x002FD0E6
		internal virtual ComboBox cboUsernames
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x002FEEEF File Offset: 0x002FD0EF
		// (set) Token: 0x06005054 RID: 20564 RVA: 0x002FEEFC File Offset: 0x002FD0FC
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

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x002FEF3F File Offset: 0x002FD13F
		// (set) Token: 0x06005056 RID: 20566 RVA: 0x002FEF4C File Offset: 0x002FD14C
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

		// Token: 0x06005057 RID: 20567 RVA: 0x002FEF90 File Offset: 0x002FD190
		private void SelectUserForm_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadUsers();
				this.cboUsernames.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x002FEFEC File Offset: 0x002FD1EC
		private void LoadUsers()
		{
			this.cboUsernames.DataSource = this.pf.GetUsers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
			this.cboUsernames.ValueMember = "Username";
			this.cboUsernames.DisplayMember = "Username";
			this.cboUsernames.SelectedIndex = -1;
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x002FF060 File Offset: 0x002FD260
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboUsernames.Text, "", false) != 0;
				if (flag)
				{
					MyProject.Forms.Form1.new_consultant = this.cboUsernames.Text;
					MessageBox.Show("New user selected is: " + this.cboUsernames.Text);
					base.Dispose();
				}
				else
				{
					MessageBox.Show("Please select the user first.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x002FF0FC File Offset: 0x002FD2FC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.new_consultant = "";
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error cancelling. Detail: " + ex.Message);
			}
		}

		// Token: 0x040023E2 RID: 9186
		private PublicFunctions pf;
	}
}
