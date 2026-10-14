using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x0200006E RID: 110
	[DesignerGenerated]
	public partial class Make_Break_Case : UserControl
	{
		// Token: 0x06001962 RID: 6498 RVA: 0x000EAE6C File Offset: 0x000E906C
		public Make_Break_Case()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x000EC3E7 File Offset: 0x000EA5E7
		// (set) Token: 0x06001966 RID: 6502 RVA: 0x000EC3F1 File Offset: 0x000EA5F1
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x000EC3FA File Offset: 0x000EA5FA
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x000EC404 File Offset: 0x000EA604
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x000EC40D File Offset: 0x000EA60D
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x000EC417 File Offset: 0x000EA617
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x000EC420 File Offset: 0x000EA620
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x000EC42A File Offset: 0x000EA62A
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x000EC433 File Offset: 0x000EA633
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x000EC43D File Offset: 0x000EA63D
		internal virtual DataGridView dgvProductsChild
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x000EC446 File Offset: 0x000EA646
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x000EC450 File Offset: 0x000EA650
		internal virtual GroupBox gbxChild
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000EC459 File Offset: 0x000EA659
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x000EC463 File Offset: 0x000EA663
		internal virtual GroupBox gbxParent
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000EC46C File Offset: 0x000EA66C
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x000EC476 File Offset: 0x000EA676
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x000EC47F File Offset: 0x000EA67F
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x000EC489 File Offset: 0x000EA689
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000EC492 File Offset: 0x000EA692
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x000EC49C File Offset: 0x000EA69C
		internal virtual ListBox ListBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000EC4A5 File Offset: 0x000EA6A5
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x000EC4AF File Offset: 0x000EA6AF
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x000EC4B8 File Offset: 0x000EA6B8
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x000EC4C2 File Offset: 0x000EA6C2
		internal virtual ComboBox cboProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x000EC4CB File Offset: 0x000EA6CB
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x000EC4D5 File Offset: 0x000EA6D5
		internal virtual TextBox txtCaseQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x000EC4DE File Offset: 0x000EA6DE
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x000EC4E8 File Offset: 0x000EA6E8
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x000EC4F1 File Offset: 0x000EA6F1
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x000EC4FB File Offset: 0x000EA6FB
		internal virtual CheckBox chkIsCase
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x000EC504 File Offset: 0x000EA704
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x000EC50E File Offset: 0x000EA70E
		internal virtual ComboBox cboProductsParents
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x000EC517 File Offset: 0x000EA717
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x000EC521 File Offset: 0x000EA721
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x000EC52A File Offset: 0x000EA72A
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x000EC534 File Offset: 0x000EA734
		internal virtual TextBox txtParentCaseQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x000EC53D File Offset: 0x000EA73D
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x000EC547 File Offset: 0x000EA747
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x000EC550 File Offset: 0x000EA750
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x000EC55A File Offset: 0x000EA75A
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x000EC563 File Offset: 0x000EA763
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x000EC570 File Offset: 0x000EA770
		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				TextBox textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._TextBox1 = value;
				textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x000EC5B3 File Offset: 0x000EA7B3
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x000EC5C0 File Offset: 0x000EA7C0
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x000EC603 File Offset: 0x000EA803
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x000EC60D File Offset: 0x000EA80D
		internal virtual ComboBox cboProductsParentID2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x000EC616 File Offset: 0x000EA816
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x000EC620 File Offset: 0x000EA820
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x000EC629 File Offset: 0x000EA829
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x000EC634 File Offset: 0x000EA834
		internal virtual Label Label7
		{
			[CompilerGenerated]
			get
			{
				return this._Label7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label7_Click);
				Label label = this._Label7;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label7 = value;
				label = this._Label7;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x000EC677 File Offset: 0x000EA877
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x000EC681 File Offset: 0x000EA881
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x000EC68A File Offset: 0x000EA88A
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x000EC694 File Offset: 0x000EA894
		internal virtual DataGridView dgvCaseProdcuts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x000EC69D File Offset: 0x000EA89D
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x000EC6A7 File Offset: 0x000EA8A7
		internal virtual Button Button1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x000EC6B0 File Offset: 0x000EA8B0
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x000EC6BA File Offset: 0x000EA8BA
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x000EC6C3 File Offset: 0x000EA8C3
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x000EC6CD File Offset: 0x000EA8CD
		internal virtual DataGridView dgvChildProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000EC6D6 File Offset: 0x000EA8D6
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x000EC6E0 File Offset: 0x000EA8E0
		internal virtual Button Button2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label7_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}
	}
}
