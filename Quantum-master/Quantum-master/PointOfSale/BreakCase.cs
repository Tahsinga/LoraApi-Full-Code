using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public partial class BreakCase : UserControl
	{
		// Token: 0x0600046D RID: 1133 RVA: 0x0002B268 File Offset: 0x00029468
		public BreakCase()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0002BD4A File Offset: 0x00029F4A
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0002BD54 File Offset: 0x00029F54
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0002BD5D File Offset: 0x00029F5D
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0002BD67 File Offset: 0x00029F67
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0002BD70 File Offset: 0x00029F70
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0002BD7A File Offset: 0x00029F7A
		internal virtual DataGridView DGVSearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0002BD83 File Offset: 0x00029F83
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0002BD8D File Offset: 0x00029F8D
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0002BD96 File Offset: 0x00029F96
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0002BDA9 File Offset: 0x00029FA9
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0002BDB3 File Offset: 0x00029FB3
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0002BDBC File Offset: 0x00029FBC
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0002BDC6 File Offset: 0x00029FC6
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0002BDCF File Offset: 0x00029FCF
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0002BDD9 File Offset: 0x00029FD9
		internal virtual TextBox txtsearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0002BDE2 File Offset: 0x00029FE2
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x0002BDEC File Offset: 0x00029FEC
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0002BDF5 File Offset: 0x00029FF5
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0002BDFF File Offset: 0x00029FFF
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0002BE08 File Offset: 0x0002A008
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x0002BE12 File Offset: 0x0002A012
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0002BE1B File Offset: 0x0002A01B
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x0002BE25 File Offset: 0x0002A025
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0002BE2E File Offset: 0x0002A02E
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x0002BE38 File Offset: 0x0002A038
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}
	}
}
