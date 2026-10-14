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
	// Token: 0x02000080 RID: 128
	[DesignerGenerated]
	public partial class OtherProductDetail : Form
	{
		// Token: 0x06001DC3 RID: 7619 RVA: 0x0010ACC4 File Offset: 0x00108EC4
		public OtherProductDetail()
		{
			base.Load += this.OtherProductDetail_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0010AFE2 File Offset: 0x001091E2
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0010AFEC File Offset: 0x001091EC
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0010AFF5 File Offset: 0x001091F5
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0010B000 File Offset: 0x00109200
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

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x0010B043 File Offset: 0x00109243
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0010B04D File Offset: 0x0010924D
		internal virtual TextBox txtdetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0010B056 File Offset: 0x00109256
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0010B060 File Offset: 0x00109260
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0010B06C File Offset: 0x0010926C
		private void OtherProductDetail_Load(object sender, EventArgs e)
		{
			try
			{
				base.AcceptButton = this.Button1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0010B0C0 File Offset: 0x001092C0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.OtherDetail = this.txtdetail.Text;
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving additional product detail: " + ex.Message);
			}
		}
	}
}
