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
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class BackDateValue : Form
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x000199EC File Offset: 0x00017BEC
		public BackDateValue()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00019C5B File Offset: 0x00017E5B
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00019C65 File Offset: 0x00017E65
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00019C6E File Offset: 0x00017E6E
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00019C78 File Offset: 0x00017E78
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00019C81 File Offset: 0x00017E81
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00019C8C File Offset: 0x00017E8C
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

		// Token: 0x060002DA RID: 730 RVA: 0x00019CD0 File Offset: 0x00017ED0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.backdatevalue = Conversions.ToInteger(this.DateTimePicker1.Value.ToString("yyyyMMdd"));
				base.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving back date value to main form. Detail: " + ex.Message);
			}
		}
	}
}
