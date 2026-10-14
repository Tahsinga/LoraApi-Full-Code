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
	// Token: 0x02000064 RID: 100
	[DesignerGenerated]
	public partial class GetNewBatchNumber : Form
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x000CA0BC File Offset: 0x000C82BC
		public GetNewBatchNumber()
		{
			this.InitializeComponent();
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x000CA40D File Offset: 0x000C860D
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x000CA417 File Offset: 0x000C8617
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x000CA420 File Offset: 0x000C8620
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x000CA42A File Offset: 0x000C862A
		internal virtual TextBox txtNewBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x000CA433 File Offset: 0x000C8633
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x000CA43D File Offset: 0x000C863D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x000CA446 File Offset: 0x000C8646
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x000CA450 File Offset: 0x000C8650
		internal virtual DateTimePicker DTNewBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000CA459 File Offset: 0x000C8659
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x000CA464 File Offset: 0x000C8664
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

		// Token: 0x06001597 RID: 5527 RVA: 0x000CA4A8 File Offset: 0x000C86A8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtNewBatchNumber.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter a valid batch number.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.DTNewBatchNumber.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please select the expiry date.");
					}
					else
					{
						MyProject.Forms.Form1.selectedbactchnum = this.txtNewBatchNumber.Text;
						MyProject.Forms.Form1.selectedexpirydate = Conversions.ToInteger(this.DTNewBatchNumber.Value.ToString("yyyyMMdd"));
						base.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving. Detail: " + ex.Message);
			}
		}
	}
}
