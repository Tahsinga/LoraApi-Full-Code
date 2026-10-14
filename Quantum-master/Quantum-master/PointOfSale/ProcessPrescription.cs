using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x0200016F RID: 367
	[DesignerGenerated]
	public partial class ProcessPrescription : UserControl
	{
		// Token: 0x06003365 RID: 13157 RVA: 0x001BCD44 File Offset: 0x001BAF44
		public ProcessPrescription()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06003368 RID: 13160 RVA: 0x001BE6CD File Offset: 0x001BC8CD
		// (set) Token: 0x06003369 RID: 13161 RVA: 0x001BE6D7 File Offset: 0x001BC8D7
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x0600336A RID: 13162 RVA: 0x001BE6E0 File Offset: 0x001BC8E0
		// (set) Token: 0x0600336B RID: 13163 RVA: 0x001BE6EA File Offset: 0x001BC8EA
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x0600336C RID: 13164 RVA: 0x001BE6F3 File Offset: 0x001BC8F3
		// (set) Token: 0x0600336D RID: 13165 RVA: 0x001BE6FD File Offset: 0x001BC8FD
		internal virtual Button Button1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x001BE706 File Offset: 0x001BC906
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x001BE710 File Offset: 0x001BC910
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x001BE719 File Offset: 0x001BC919
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x001BE723 File Offset: 0x001BC923
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x001BE72C File Offset: 0x001BC92C
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x001BE736 File Offset: 0x001BC936
		internal virtual DataGridView dgvPatients
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003374 RID: 13172 RVA: 0x001BE73F File Offset: 0x001BC93F
		// (set) Token: 0x06003375 RID: 13173 RVA: 0x001BE749 File Offset: 0x001BC949
		internal virtual Button Button2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x001BE752 File Offset: 0x001BC952
		// (set) Token: 0x06003377 RID: 13175 RVA: 0x001BE75C File Offset: 0x001BC95C
		internal virtual TextBox TextBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x001BE765 File Offset: 0x001BC965
		// (set) Token: 0x06003379 RID: 13177 RVA: 0x001BE76F File Offset: 0x001BC96F
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x001BE778 File Offset: 0x001BC978
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x001BE782 File Offset: 0x001BC982
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x0600337C RID: 13180 RVA: 0x001BE78B File Offset: 0x001BC98B
		// (set) Token: 0x0600337D RID: 13181 RVA: 0x001BE795 File Offset: 0x001BC995
		internal virtual TextBox TextBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x0600337E RID: 13182 RVA: 0x001BE79E File Offset: 0x001BC99E
		// (set) Token: 0x0600337F RID: 13183 RVA: 0x001BE7A8 File Offset: 0x001BC9A8
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x001BE7B1 File Offset: 0x001BC9B1
		// (set) Token: 0x06003381 RID: 13185 RVA: 0x001BE7BB File Offset: 0x001BC9BB
		internal virtual TextBox TextBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06003382 RID: 13186 RVA: 0x001BE7C4 File Offset: 0x001BC9C4
		// (set) Token: 0x06003383 RID: 13187 RVA: 0x001BE7CE File Offset: 0x001BC9CE
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x001BE7D7 File Offset: 0x001BC9D7
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x001BE7E1 File Offset: 0x001BC9E1
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x001BE7EA File Offset: 0x001BC9EA
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x001BE7F4 File Offset: 0x001BC9F4
		internal virtual TextBox TextBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x001BE7FD File Offset: 0x001BC9FD
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x001BE807 File Offset: 0x001BCA07
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x001BE810 File Offset: 0x001BCA10
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x001BE81A File Offset: 0x001BCA1A
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x001BE823 File Offset: 0x001BCA23
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x001BE82D File Offset: 0x001BCA2D
		internal virtual ComboBox ComboBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x001BE836 File Offset: 0x001BCA36
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x001BE840 File Offset: 0x001BCA40
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x001BE849 File Offset: 0x001BCA49
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x001BE853 File Offset: 0x001BCA53
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x001BE85C File Offset: 0x001BCA5C
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x001BE866 File Offset: 0x001BCA66
		internal virtual TextBox TextBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x001BE86F File Offset: 0x001BCA6F
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x001BE879 File Offset: 0x001BCA79
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x001BE882 File Offset: 0x001BCA82
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x001BE88C File Offset: 0x001BCA8C
		internal virtual TextBox TextBox7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003398 RID: 13208 RVA: 0x001BE895 File Offset: 0x001BCA95
		// (set) Token: 0x06003399 RID: 13209 RVA: 0x001BE89F File Offset: 0x001BCA9F
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x001BE8A8 File Offset: 0x001BCAA8
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x001BE8B2 File Offset: 0x001BCAB2
		internal virtual TextBox TextBox8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x001BE8BB File Offset: 0x001BCABB
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x001BE8C5 File Offset: 0x001BCAC5
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x001BE8CE File Offset: 0x001BCACE
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x001BE8D8 File Offset: 0x001BCAD8
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x001BE8E1 File Offset: 0x001BCAE1
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x001BE8EB File Offset: 0x001BCAEB
		internal virtual Button Button4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x001BE8F4 File Offset: 0x001BCAF4
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x001BE8FE File Offset: 0x001BCAFE
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x001BE907 File Offset: 0x001BCB07
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x001BE911 File Offset: 0x001BCB11
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x001BE91A File Offset: 0x001BCB1A
		// (set) Token: 0x060033A7 RID: 13223 RVA: 0x001BE924 File Offset: 0x001BCB24
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x060033A8 RID: 13224 RVA: 0x001BE92D File Offset: 0x001BCB2D
		// (set) Token: 0x060033A9 RID: 13225 RVA: 0x001BE937 File Offset: 0x001BCB37
		internal virtual DataGridView DataGridView2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x001BE940 File Offset: 0x001BCB40
		// (set) Token: 0x060033AB RID: 13227 RVA: 0x001BE94A File Offset: 0x001BCB4A
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x001BE953 File Offset: 0x001BCB53
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x001BE95D File Offset: 0x001BCB5D
		internal virtual TextBox TextBox10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x060033AE RID: 13230 RVA: 0x001BE966 File Offset: 0x001BCB66
		// (set) Token: 0x060033AF RID: 13231 RVA: 0x001BE970 File Offset: 0x001BCB70
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x001BE979 File Offset: 0x001BCB79
		// (set) Token: 0x060033B1 RID: 13233 RVA: 0x001BE983 File Offset: 0x001BCB83
		internal virtual TextBox TextBox9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x001BE98C File Offset: 0x001BCB8C
		// (set) Token: 0x060033B3 RID: 13235 RVA: 0x001BE996 File Offset: 0x001BCB96
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x001BE99F File Offset: 0x001BCB9F
		// (set) Token: 0x060033B5 RID: 13237 RVA: 0x001BE9A9 File Offset: 0x001BCBA9
		internal virtual TextBox TextBox11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x001BE9B2 File Offset: 0x001BCBB2
		// (set) Token: 0x060033B7 RID: 13239 RVA: 0x001BE9BC File Offset: 0x001BCBBC
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x060033B8 RID: 13240 RVA: 0x001BE9C5 File Offset: 0x001BCBC5
		// (set) Token: 0x060033B9 RID: 13241 RVA: 0x001BE9CF File Offset: 0x001BCBCF
		internal virtual TextBox TextBox12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x001BE9D8 File Offset: 0x001BCBD8
		// (set) Token: 0x060033BB RID: 13243 RVA: 0x001BE9E2 File Offset: 0x001BCBE2
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060033BC RID: 13244 RVA: 0x001BE9EB File Offset: 0x001BCBEB
		// (set) Token: 0x060033BD RID: 13245 RVA: 0x001BE9F5 File Offset: 0x001BCBF5
		internal virtual DateTimePicker DateTimePicker2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x001BE9FE File Offset: 0x001BCBFE
		// (set) Token: 0x060033BF RID: 13247 RVA: 0x001BEA08 File Offset: 0x001BCC08
		internal virtual Button Button5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}
	}
}
