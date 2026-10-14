using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x020001DC RID: 476
	[DesignerGenerated]
	public partial class SetEmailSettings : UserControl
	{
		// Token: 0x06005354 RID: 21332 RVA: 0x00306EDC File Offset: 0x003050DC
		public SetEmailSettings()
		{
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06005357 RID: 21335 RVA: 0x00307A69 File Offset: 0x00305C69
		// (set) Token: 0x06005358 RID: 21336 RVA: 0x00307A73 File Offset: 0x00305C73
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x00307A7C File Offset: 0x00305C7C
		// (set) Token: 0x0600535A RID: 21338 RVA: 0x00307A86 File Offset: 0x00305C86
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600535B RID: 21339 RVA: 0x00307A8F File Offset: 0x00305C8F
		// (set) Token: 0x0600535C RID: 21340 RVA: 0x00307A99 File Offset: 0x00305C99
		internal virtual TextBox txtEmailFrom
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600535D RID: 21341 RVA: 0x00307AA2 File Offset: 0x00305CA2
		// (set) Token: 0x0600535E RID: 21342 RVA: 0x00307AAC File Offset: 0x00305CAC
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600535F RID: 21343 RVA: 0x00307AB5 File Offset: 0x00305CB5
		// (set) Token: 0x06005360 RID: 21344 RVA: 0x00307ABF File Offset: 0x00305CBF
		internal virtual TextBox txtPassword
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x00307AC8 File Offset: 0x00305CC8
		// (set) Token: 0x06005362 RID: 21346 RVA: 0x00307AD2 File Offset: 0x00305CD2
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x00307ADB File Offset: 0x00305CDB
		// (set) Token: 0x06005364 RID: 21348 RVA: 0x00307AE5 File Offset: 0x00305CE5
		internal virtual TextBox txtUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06005365 RID: 21349 RVA: 0x00307AEE File Offset: 0x00305CEE
		// (set) Token: 0x06005366 RID: 21350 RVA: 0x00307AF8 File Offset: 0x00305CF8
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x00307B01 File Offset: 0x00305D01
		// (set) Token: 0x06005368 RID: 21352 RVA: 0x00307B0B File Offset: 0x00305D0B
		internal virtual TextBox txtEmailHost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x00307B14 File Offset: 0x00305D14
		// (set) Token: 0x0600536A RID: 21354 RVA: 0x00307B1E File Offset: 0x00305D1E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x00307B27 File Offset: 0x00305D27
		// (set) Token: 0x0600536C RID: 21356 RVA: 0x00307B31 File Offset: 0x00305D31
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600536D RID: 21357 RVA: 0x00307B3A File Offset: 0x00305D3A
		// (set) Token: 0x0600536E RID: 21358 RVA: 0x00307B44 File Offset: 0x00305D44
		internal virtual CheckBox chkSSL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600536F RID: 21359 RVA: 0x00307B4D File Offset: 0x00305D4D
		// (set) Token: 0x06005370 RID: 21360 RVA: 0x00307B57 File Offset: 0x00305D57
		internal virtual Button Button1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x00307B60 File Offset: 0x00305D60
		// (set) Token: 0x06005372 RID: 21362 RVA: 0x00307B6C File Offset: 0x00305D6C
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

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06005373 RID: 21363 RVA: 0x00307BAF File Offset: 0x00305DAF
		// (set) Token: 0x06005374 RID: 21364 RVA: 0x00307BB9 File Offset: 0x00305DB9
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06005375 RID: 21365 RVA: 0x00307BC2 File Offset: 0x00305DC2
		// (set) Token: 0x06005376 RID: 21366 RVA: 0x00307BCC File Offset: 0x00305DCC
		internal virtual TextBox txtBody
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06005377 RID: 21367 RVA: 0x00307BD5 File Offset: 0x00305DD5
		// (set) Token: 0x06005378 RID: 21368 RVA: 0x00307BDF File Offset: 0x00305DDF
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x00307BE8 File Offset: 0x00305DE8
		// (set) Token: 0x0600537A RID: 21370 RVA: 0x00307BF2 File Offset: 0x00305DF2
		internal virtual TextBox txtSubject
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x00307BFB File Offset: 0x00305DFB
		// (set) Token: 0x0600537C RID: 21372 RVA: 0x00307C05 File Offset: 0x00305E05
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600537D RID: 21373 RVA: 0x00307C0E File Offset: 0x00305E0E
		// (set) Token: 0x0600537E RID: 21374 RVA: 0x00307C18 File Offset: 0x00305E18
		internal virtual TextBox txtEmailTo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00307C24 File Offset: 0x00305E24
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.pf.SendEmailNow(this.txtEmailFrom.Text, this.txtEmailTo.Text, this.txtSubject.Text, this.txtBody.Text, this.txtEmailHost.Text, this.txtUsername.Text, this.txtPassword.Text, Conversions.ToBoolean(Interaction.IIf(this.chkSSL.Checked, true, false)));
				MessageBox.Show("Email sent.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error sending email. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400246C RID: 9324
		private PublicFunctions pf;
	}
}
