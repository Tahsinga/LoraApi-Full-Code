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
	// Token: 0x020001B9 RID: 441
	[DesignerGenerated]
	public partial class SelectKDU : Form
	{
		// Token: 0x06004FDE RID: 20446 RVA: 0x002FB62C File Offset: 0x002F982C
		public SelectKDU()
		{
			base.Load += this.SelectKDU_Load;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x002FB8F3 File Offset: 0x002F9AF3
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x002FB8FD File Offset: 0x002F9AFD
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x002FB906 File Offset: 0x002F9B06
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x002FB910 File Offset: 0x002F9B10
		internal virtual ComboBox cboKDUs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x002FB919 File Offset: 0x002F9B19
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x002FB924 File Offset: 0x002F9B24
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

		// Token: 0x06004FE7 RID: 20455 RVA: 0x002FB968 File Offset: 0x002F9B68
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboKDUs.SelectedValue == null;
				if (flag)
				{
					MessageBox.Show("Please select a Kitchen Display Unit first.");
				}
				else
				{
					MyProject.Forms.Form1.kduID = Conversions.ToInteger(this.cboKDUs.SelectedValue);
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x002FB9F8 File Offset: 0x002F9BF8
		private void SelectKDU_Load(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.kduID = 0;
				this.cboKDUs.DataSource = this.pf.LoadKDUs(MyProject.Forms.Form1.Constring);
				this.cboKDUs.DisplayMember = "KDUName";
				this.cboKDUs.ValueMember = "EntryNo";
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x040023A4 RID: 9124
		private PublicFunctions pf;
	}
}
