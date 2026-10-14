using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000206 RID: 518
	[DesignerGenerated]
	public partial class TripMgt : UserControl
	{
		// Token: 0x06005C9C RID: 23708 RVA: 0x00352588 File Offset: 0x00350788
		public TripMgt()
		{
			base.Load += this.TripMgt_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06005C9F RID: 23711 RVA: 0x00355563 File Offset: 0x00353763
		// (set) Token: 0x06005CA0 RID: 23712 RVA: 0x00355570 File Offset: 0x00353770
		internal virtual TabControl TabControl1
		{
			[CompilerGenerated]
			get
			{
				return this._TabControl1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabControl1_TabIndexChanged);
				TabControl tabControl = this._TabControl1;
				if (tabControl != null)
				{
					tabControl.TabIndexChanged -= eventHandler;
				}
				this._TabControl1 = value;
				tabControl = this._TabControl1;
				if (tabControl != null)
				{
					tabControl.TabIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06005CA1 RID: 23713 RVA: 0x003555B3 File Offset: 0x003537B3
		// (set) Token: 0x06005CA2 RID: 23714 RVA: 0x003555BD File Offset: 0x003537BD
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06005CA3 RID: 23715 RVA: 0x003555C6 File Offset: 0x003537C6
		// (set) Token: 0x06005CA4 RID: 23716 RVA: 0x003555D0 File Offset: 0x003537D0
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06005CA5 RID: 23717 RVA: 0x003555D9 File Offset: 0x003537D9
		// (set) Token: 0x06005CA6 RID: 23718 RVA: 0x003555E3 File Offset: 0x003537E3
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06005CA7 RID: 23719 RVA: 0x003555EC File Offset: 0x003537EC
		// (set) Token: 0x06005CA8 RID: 23720 RVA: 0x003555F6 File Offset: 0x003537F6
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06005CA9 RID: 23721 RVA: 0x003555FF File Offset: 0x003537FF
		// (set) Token: 0x06005CAA RID: 23722 RVA: 0x0035560C File Offset: 0x0035380C
		internal virtual TextBox txtDistanceTar
		{
			[CompilerGenerated]
			get
			{
				return this._txtDistanceTar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtDistanceTar_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDistanceTar_KeyPress);
				TextBox textBox = this._txtDistanceTar;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtDistanceTar = value;
				textBox = this._txtDistanceTar;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06005CAB RID: 23723 RVA: 0x0035566A File Offset: 0x0035386A
		// (set) Token: 0x06005CAC RID: 23724 RVA: 0x00355674 File Offset: 0x00353874
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06005CAD RID: 23725 RVA: 0x0035567D File Offset: 0x0035387D
		// (set) Token: 0x06005CAE RID: 23726 RVA: 0x00355687 File Offset: 0x00353887
		internal virtual TextBox txtDestination
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x00355690 File Offset: 0x00353890
		// (set) Token: 0x06005CB0 RID: 23728 RVA: 0x0035569A File Offset: 0x0035389A
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x003556A3 File Offset: 0x003538A3
		// (set) Token: 0x06005CB2 RID: 23730 RVA: 0x003556AD File Offset: 0x003538AD
		internal virtual TextBox txtOrigin
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06005CB3 RID: 23731 RVA: 0x003556B6 File Offset: 0x003538B6
		// (set) Token: 0x06005CB4 RID: 23732 RVA: 0x003556C0 File Offset: 0x003538C0
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06005CB5 RID: 23733 RVA: 0x003556C9 File Offset: 0x003538C9
		// (set) Token: 0x06005CB6 RID: 23734 RVA: 0x003556D3 File Offset: 0x003538D3
		internal virtual TextBox txtLTINumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x003556DC File Offset: 0x003538DC
		// (set) Token: 0x06005CB8 RID: 23736 RVA: 0x003556E6 File Offset: 0x003538E6
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x003556EF File Offset: 0x003538EF
		// (set) Token: 0x06005CBA RID: 23738 RVA: 0x003556F9 File Offset: 0x003538F9
		internal virtual TextBox txtWayBill
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06005CBB RID: 23739 RVA: 0x00355702 File Offset: 0x00353902
		// (set) Token: 0x06005CBC RID: 23740 RVA: 0x0035570C File Offset: 0x0035390C
		internal virtual DateTimePicker DTDispatchDate
		{
			[CompilerGenerated]
			get
			{
				return this._DTDispatchDate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DTDispatchDate_ValueChanged);
				DateTimePicker dateTimePicker = this._DTDispatchDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DTDispatchDate = value;
				dateTimePicker = this._DTDispatchDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06005CBD RID: 23741 RVA: 0x0035574F File Offset: 0x0035394F
		// (set) Token: 0x06005CBE RID: 23742 RVA: 0x00355759 File Offset: 0x00353959
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06005CBF RID: 23743 RVA: 0x00355762 File Offset: 0x00353962
		// (set) Token: 0x06005CC0 RID: 23744 RVA: 0x0035576C File Offset: 0x0035396C
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06005CC1 RID: 23745 RVA: 0x00355775 File Offset: 0x00353975
		// (set) Token: 0x06005CC2 RID: 23746 RVA: 0x0035577F File Offset: 0x0035397F
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x00355788 File Offset: 0x00353988
		// (set) Token: 0x06005CC4 RID: 23748 RVA: 0x00355794 File Offset: 0x00353994
		internal virtual TextBox txtRateDust
		{
			[CompilerGenerated]
			get
			{
				return this._txtRateDust;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtRateDust_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtRateDust_KeyPress);
				TextBox textBox = this._txtRateDust;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtRateDust = value;
				textBox = this._txtRateDust;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x003557F2 File Offset: 0x003539F2
		// (set) Token: 0x06005CC6 RID: 23750 RVA: 0x003557FC File Offset: 0x003539FC
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06005CC7 RID: 23751 RVA: 0x00355805 File Offset: 0x00353A05
		// (set) Token: 0x06005CC8 RID: 23752 RVA: 0x00355810 File Offset: 0x00353A10
		internal virtual TextBox txtRateTar
		{
			[CompilerGenerated]
			get
			{
				return this._txtRateTar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtRateTar_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtRateTar_KeyPress);
				TextBox textBox = this._txtRateTar;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtRateTar = value;
				textBox = this._txtRateTar;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06005CC9 RID: 23753 RVA: 0x0035586E File Offset: 0x00353A6E
		// (set) Token: 0x06005CCA RID: 23754 RVA: 0x00355878 File Offset: 0x00353A78
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06005CCB RID: 23755 RVA: 0x00355881 File Offset: 0x00353A81
		// (set) Token: 0x06005CCC RID: 23756 RVA: 0x0035588C File Offset: 0x00353A8C
		internal virtual TextBox txtTonnage
		{
			[CompilerGenerated]
			get
			{
				return this._txtTonnage;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtTonnage_KeyPress);
				TextBox textBox = this._txtTonnage;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtTonnage = value;
				textBox = this._txtTonnage;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06005CCD RID: 23757 RVA: 0x003558CF File Offset: 0x00353ACF
		// (set) Token: 0x06005CCE RID: 23758 RVA: 0x003558D9 File Offset: 0x00353AD9
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06005CCF RID: 23759 RVA: 0x003558E2 File Offset: 0x00353AE2
		// (set) Token: 0x06005CD0 RID: 23760 RVA: 0x003558EC File Offset: 0x00353AEC
		internal virtual TextBox txtTruckCapacity
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06005CD1 RID: 23761 RVA: 0x003558F5 File Offset: 0x00353AF5
		// (set) Token: 0x06005CD2 RID: 23762 RVA: 0x003558FF File Offset: 0x00353AFF
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x00355908 File Offset: 0x00353B08
		// (set) Token: 0x06005CD4 RID: 23764 RVA: 0x00355912 File Offset: 0x00353B12
		internal virtual TextBox txtTruckREg
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x0035591B File Offset: 0x00353B1B
		// (set) Token: 0x06005CD6 RID: 23766 RVA: 0x00355928 File Offset: 0x00353B28
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

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x0035596B File Offset: 0x00353B6B
		// (set) Token: 0x06005CD8 RID: 23768 RVA: 0x00355975 File Offset: 0x00353B75
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06005CD9 RID: 23769 RVA: 0x0035597E File Offset: 0x00353B7E
		// (set) Token: 0x06005CDA RID: 23770 RVA: 0x00355988 File Offset: 0x00353B88
		internal virtual TextBox txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06005CDB RID: 23771 RVA: 0x00355991 File Offset: 0x00353B91
		// (set) Token: 0x06005CDC RID: 23772 RVA: 0x0035599B File Offset: 0x00353B9B
		internal virtual DataGridView dgvTrips
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06005CDD RID: 23773 RVA: 0x003559A4 File Offset: 0x00353BA4
		// (set) Token: 0x06005CDE RID: 23774 RVA: 0x003559AE File Offset: 0x00353BAE
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06005CDF RID: 23775 RVA: 0x003559B7 File Offset: 0x00353BB7
		// (set) Token: 0x06005CE0 RID: 23776 RVA: 0x003559C4 File Offset: 0x00353BC4
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

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x00355A07 File Offset: 0x00353C07
		// (set) Token: 0x06005CE2 RID: 23778 RVA: 0x00355A14 File Offset: 0x00353C14
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

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06005CE3 RID: 23779 RVA: 0x00355A57 File Offset: 0x00353C57
		// (set) Token: 0x06005CE4 RID: 23780 RVA: 0x00355A64 File Offset: 0x00353C64
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

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x00355AA7 File Offset: 0x00353CA7
		// (set) Token: 0x06005CE6 RID: 23782 RVA: 0x00355AB1 File Offset: 0x00353CB1
		internal virtual DateTimePicker DTInvEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06005CE7 RID: 23783 RVA: 0x00355ABA File Offset: 0x00353CBA
		// (set) Token: 0x06005CE8 RID: 23784 RVA: 0x00355AC4 File Offset: 0x00353CC4
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x00355ACD File Offset: 0x00353CCD
		// (set) Token: 0x06005CEA RID: 23786 RVA: 0x00355AD7 File Offset: 0x00353CD7
		internal virtual DateTimePicker DTInvStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x00355AE0 File Offset: 0x00353CE0
		// (set) Token: 0x06005CEC RID: 23788 RVA: 0x00355AEA File Offset: 0x00353CEA
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06005CED RID: 23789 RVA: 0x00355AF3 File Offset: 0x00353CF3
		// (set) Token: 0x06005CEE RID: 23790 RVA: 0x00355AFD File Offset: 0x00353CFD
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x00355B06 File Offset: 0x00353D06
		// (set) Token: 0x06005CF0 RID: 23792 RVA: 0x00355B10 File Offset: 0x00353D10
		internal virtual DataGridView dgvPendingTrips
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPendingTrips;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPendingTrips_CellContentClick);
				DataGridView dataGridView = this._dgvPendingTrips;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPendingTrips = value;
				dataGridView = this._dgvPendingTrips;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x00355B53 File Offset: 0x00353D53
		// (set) Token: 0x06005CF2 RID: 23794 RVA: 0x00355B60 File Offset: 0x00353D60
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

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06005CF3 RID: 23795 RVA: 0x00355BA3 File Offset: 0x00353DA3
		// (set) Token: 0x06005CF4 RID: 23796 RVA: 0x00355BAD File Offset: 0x00353DAD
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06005CF5 RID: 23797 RVA: 0x00355BB6 File Offset: 0x00353DB6
		// (set) Token: 0x06005CF6 RID: 23798 RVA: 0x00355BC0 File Offset: 0x00353DC0
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06005CF7 RID: 23799 RVA: 0x00355BC9 File Offset: 0x00353DC9
		// (set) Token: 0x06005CF8 RID: 23800 RVA: 0x00355BD4 File Offset: 0x00353DD4
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

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x00355C17 File Offset: 0x00353E17
		// (set) Token: 0x06005CFA RID: 23802 RVA: 0x00355C21 File Offset: 0x00353E21
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06005CFB RID: 23803 RVA: 0x00355C2A File Offset: 0x00353E2A
		// (set) Token: 0x06005CFC RID: 23804 RVA: 0x00355C34 File Offset: 0x00353E34
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

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06005CFD RID: 23805 RVA: 0x00355C77 File Offset: 0x00353E77
		// (set) Token: 0x06005CFE RID: 23806 RVA: 0x00355C84 File Offset: 0x00353E84
		internal virtual ComboBox cboCustomers
		{
			[CompilerGenerated]
			get
			{
				return this._cboCustomers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCustomers_TextChanged);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.TextChanged -= eventHandler;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06005CFF RID: 23807 RVA: 0x00355CC7 File Offset: 0x00353EC7
		// (set) Token: 0x06005D00 RID: 23808 RVA: 0x00355CD4 File Offset: 0x00353ED4
		internal virtual ListBox ListBox1
		{
			[CompilerGenerated]
			get
			{
				return this._ListBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListBox1_SelectedIndexChanged);
				ListBox listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= eventHandler;
				}
				this._ListBox1 = value;
				listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06005D01 RID: 23809 RVA: 0x00355D17 File Offset: 0x00353F17
		// (set) Token: 0x06005D02 RID: 23810 RVA: 0x00355D21 File Offset: 0x00353F21
		internal virtual Button Button8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06005D03 RID: 23811 RVA: 0x00355D2A File Offset: 0x00353F2A
		// (set) Token: 0x06005D04 RID: 23812 RVA: 0x00355D34 File Offset: 0x00353F34
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06005D05 RID: 23813 RVA: 0x00355D3D File Offset: 0x00353F3D
		// (set) Token: 0x06005D06 RID: 23814 RVA: 0x00355D48 File Offset: 0x00353F48
		internal virtual TextBox txtDistanceDust
		{
			[CompilerGenerated]
			get
			{
				return this._txtDistanceDust;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtDistanceDust_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDistanceDust_KeyPress);
				TextBox textBox = this._txtDistanceDust;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtDistanceDust = value;
				textBox = this._txtDistanceDust;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06005D07 RID: 23815 RVA: 0x00355DA6 File Offset: 0x00353FA6
		// (set) Token: 0x06005D08 RID: 23816 RVA: 0x00355DB0 File Offset: 0x00353FB0
		internal virtual Label Label19
		{
			[CompilerGenerated]
			get
			{
				return this._Label19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label19_Click);
				Label label = this._Label19;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label19 = value;
				label = this._Label19;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06005D09 RID: 23817 RVA: 0x00355DF3 File Offset: 0x00353FF3
		// (set) Token: 0x06005D0A RID: 23818 RVA: 0x00355E00 File Offset: 0x00354000
		internal virtual Label Label20
		{
			[CompilerGenerated]
			get
			{
				return this._Label20;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label20_Click);
				Label label = this._Label20;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label20 = value;
				label = this._Label20;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06005D0B RID: 23819 RVA: 0x00355E43 File Offset: 0x00354043
		// (set) Token: 0x06005D0C RID: 23820 RVA: 0x00355E4D File Offset: 0x0035404D
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06005D0D RID: 23821 RVA: 0x00355E56 File Offset: 0x00354056
		// (set) Token: 0x06005D0E RID: 23822 RVA: 0x00355E60 File Offset: 0x00354060
		internal virtual ListBox ListBox2
		{
			[CompilerGenerated]
			get
			{
				return this._ListBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListBox2_SelectedIndexChanged);
				ListBox listBox = this._ListBox2;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= eventHandler;
				}
				this._ListBox2 = value;
				listBox = this._ListBox2;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06005D0F RID: 23823 RVA: 0x00355EA3 File Offset: 0x003540A3
		// (set) Token: 0x06005D10 RID: 23824 RVA: 0x00355EB0 File Offset: 0x003540B0
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

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06005D11 RID: 23825 RVA: 0x00355EF3 File Offset: 0x003540F3
		// (set) Token: 0x06005D12 RID: 23826 RVA: 0x00355F00 File Offset: 0x00354100
		internal virtual ComboBox cboCustomers2
		{
			[CompilerGenerated]
			get
			{
				return this._cboCustomers2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCustomers2_TextChanged);
				ComboBox comboBox = this._cboCustomers2;
				if (comboBox != null)
				{
					comboBox.TextChanged -= eventHandler;
				}
				this._cboCustomers2 = value;
				comboBox = this._cboCustomers2;
				if (comboBox != null)
				{
					comboBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06005D13 RID: 23827 RVA: 0x00355F43 File Offset: 0x00354143
		// (set) Token: 0x06005D14 RID: 23828 RVA: 0x00355F4D File Offset: 0x0035414D
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06005D15 RID: 23829 RVA: 0x00355F56 File Offset: 0x00354156
		// (set) Token: 0x06005D16 RID: 23830 RVA: 0x00355F60 File Offset: 0x00354160
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06005D17 RID: 23831 RVA: 0x00355F69 File Offset: 0x00354169
		// (set) Token: 0x06005D18 RID: 23832 RVA: 0x00355F73 File Offset: 0x00354173
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06005D19 RID: 23833 RVA: 0x00355F7C File Offset: 0x0035417C
		// (set) Token: 0x06005D1A RID: 23834 RVA: 0x00355F88 File Offset: 0x00354188
		internal virtual ListBox ListBox3
		{
			[CompilerGenerated]
			get
			{
				return this._ListBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListBox3_SelectedIndexChanged);
				ListBox listBox = this._ListBox3;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= eventHandler;
				}
				this._ListBox3 = value;
				listBox = this._ListBox3;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06005D1B RID: 23835 RVA: 0x00355FCB File Offset: 0x003541CB
		// (set) Token: 0x06005D1C RID: 23836 RVA: 0x00355FD5 File Offset: 0x003541D5
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06005D1D RID: 23837 RVA: 0x00355FDE File Offset: 0x003541DE
		// (set) Token: 0x06005D1E RID: 23838 RVA: 0x00355FE8 File Offset: 0x003541E8
		internal virtual ComboBox cboProducts
		{
			[CompilerGenerated]
			get
			{
				return this._cboProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboProducts_TextChanged);
				ComboBox comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.TextChanged -= eventHandler;
				}
				this._cboProducts = value;
				comboBox = this._cboProducts;
				if (comboBox != null)
				{
					comboBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06005D1F RID: 23839 RVA: 0x0035602B File Offset: 0x0035422B
		// (set) Token: 0x06005D20 RID: 23840 RVA: 0x00356035 File Offset: 0x00354235
		internal virtual TextBox txtTaxAmt
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06005D21 RID: 23841 RVA: 0x0035603E File Offset: 0x0035423E
		// (set) Token: 0x06005D22 RID: 23842 RVA: 0x00356048 File Offset: 0x00354248
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06005D23 RID: 23843 RVA: 0x00356051 File Offset: 0x00354251
		// (set) Token: 0x06005D24 RID: 23844 RVA: 0x0035605B File Offset: 0x0035425B
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06005D25 RID: 23845 RVA: 0x00356064 File Offset: 0x00354264
		// (set) Token: 0x06005D26 RID: 23846 RVA: 0x0035606E File Offset: 0x0035426E
		internal virtual ComboBox cboPayMeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06005D27 RID: 23847 RVA: 0x00356077 File Offset: 0x00354277
		// (set) Token: 0x06005D28 RID: 23848 RVA: 0x00356081 File Offset: 0x00354281
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06005D29 RID: 23849 RVA: 0x0035608A File Offset: 0x0035428A
		// (set) Token: 0x06005D2A RID: 23850 RVA: 0x00356094 File Offset: 0x00354294
		internal virtual Label Label26
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06005D2B RID: 23851 RVA: 0x0035609D File Offset: 0x0035429D
		// (set) Token: 0x06005D2C RID: 23852 RVA: 0x003560A7 File Offset: 0x003542A7
		internal virtual TextBox txtcomments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06005D2D RID: 23853 RVA: 0x003560B0 File Offset: 0x003542B0
		// (set) Token: 0x06005D2E RID: 23854 RVA: 0x003560BA File Offset: 0x003542BA
		internal virtual ComboBox cboTerms
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x003560C4 File Offset: 0x003542C4
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				int num = 0;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvPendingTrips.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Conversions.ToBoolean(dataGridViewRow.Cells[1].Value);
						bool flag2 = flag;
						if (flag2)
						{
							num = ((-(((num == 1) > false) ? 1 : 0)) ? 1 : 0);
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				bool flag3 = num == 0;
				if (flag3)
				{
					MessageBox.Show("Please select trips to invoice first. Tick in the grid.");
				}
				else
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to invoice these trips? ", MsgBoxStyle.YesNo, null);
					bool flag4 = dialogResult == DialogResult.Yes;
					if (flag4)
					{
						int num2 = 0;
						decimal rate = this.pf.GetRate(Conversions.ToInteger(this.cboPayMeth.SelectedValue), this._cnn);
						decimal num3 = 0m;
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.Connection = sqlConnection;
						try
						{
							sqlConnection.Open();
							SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
							sqlCommand.Transaction = sqlTransaction;
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "GetSalesInvoiceNumber";
							sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
							sqlCommand.Parameters.AddWithValue("allowbackdated", MyProject.Forms.Form1.DateChange);
							sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
							sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							sqlCommand.ExecuteNonQuery();
							num2 = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
							bool flag5 = num2 == 0;
							if (flag5)
							{
								MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
								sqlTransaction.Rollback();
								sqlConnection.Close();
							}
							else
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "InsertNextSalesInvNumber";
								sqlCommand.Parameters.AddWithValue("desc", this.DTDate.Value.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
								sqlCommand.Parameters.AddWithValue("newinvnumber", num2);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.ExecuteNonQuery();
								try
								{
									foreach (object obj2 in ((IEnumerable)this.dgvPendingTrips.Rows))
									{
										DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
										bool flag6 = Conversions.ToBoolean(dataGridViewRow2.Cells[1].Value);
										bool flag7 = flag6;
										if (flag7)
										{
											string text = Conversions.ToString(dataGridViewRow2.Cells["Product_Description"].Value);
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertNewSale2Warehouse3";
											bool flag8 = MyProject.Forms.Form1.DateChange == 1;
											if (flag8)
											{
												sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value.ToString("yyyyMMdd"));
											}
											else
											{
												sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
											}
											sqlCommand.Parameters.AddWithValue("invoicenum", num2);
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["productid"].Value));
											sqlCommand.Parameters.AddWithValue("isstockin", 0);
											sqlCommand.Parameters.AddWithValue("ref", this.cboCustomers2.Text);
											sqlCommand.Parameters.AddWithValue("quantity", 1);
											sqlCommand.Parameters.AddWithValue("unitcost", 0);
											sqlCommand.Parameters.AddWithValue("salesprice", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["Total"].Value));
											sqlCommand.Parameters.AddWithValue("paymentmethod", 1);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("trancode", 3);
											sqlCommand.Parameters.AddWithValue("prodcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow2.Cells["productid"].Value), this._cnn));
											sqlCommand.Parameters.AddWithValue("TranTime", DateTime.Now.ToString("HHmm"));
											sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["TaxAmt"].Value)));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("shift", "SHIFT");
											sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("BatchNumber", "");
											sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
											sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
											sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
											sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", rate);
											sqlCommand.Parameters.AddWithValue("discountamount", 0);
											sqlCommand.Parameters.AddWithValue("consultant", "");
											sqlCommand.Parameters.AddWithValue("invdiscount", 0);
											sqlCommand.Parameters.AddWithValue("collection", "");
											sqlCommand.Parameters.AddWithValue("discountdesc", 0);
											sqlCommand.Parameters.AddWithValue("otherdetail", "");
											sqlCommand.Parameters.AddWithValue("comments", "");
											sqlCommand.Parameters.AddWithValue("paymethref", "");
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.ExecuteNonQuery();
											num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataGridViewRow2.Cells["Total"].Value));
										}
									}
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
								DateTime dateTime = this.DTDate.Value.AddDays((double)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue)));
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "BillingInsertAccSale2";
								sqlCommand.Parameters.AddWithValue("customername", this.cboCustomers.Text);
								sqlCommand.Parameters.AddWithValue("invoicenumber", num2);
								sqlCommand.Parameters.AddWithValue("amount", num3);
								sqlCommand.Parameters.AddWithValue("shiftdate", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trandate", Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
								sqlCommand.Parameters.AddWithValue("teller", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("terms", RuntimeHelpers.GetObjectValue(this.cboTerms.SelectedValue));
								sqlCommand.Parameters.AddWithValue("DueDate", Convert.ToInt32(dateTime.ToString("yyyyMMdd")));
								sqlCommand.Parameters.AddWithValue("rate", rate);
								sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
								sqlCommand.Parameters.AddWithValue("paymentmethodiddesc", this.cboPayMeth.Text);
								sqlCommand.Parameters.AddWithValue("invdiscount", 0);
								sqlCommand.Parameters.AddWithValue("comment", this.txtcomments.Text);
								sqlCommand.Parameters.AddWithValue("termsdesc", this.cboTerms.Text);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.ExecuteNonQuery();
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "TripInv";
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("entryno", RuntimeHelpers.GetObjectValue(this.cboCustomers2.SelectedValue));
								sqlCommand.Parameters.AddWithValue("invnum", num2);
								sqlCommand.ExecuteNonQuery();
								sqlTransaction.Commit();
								sqlConnection.Close();
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error saving invoice. Detail: " + ex.Message);
							try
							{
								SqlTransaction sqlTransaction;
								sqlTransaction.Rollback();
								sqlConnection.Close();
							}
							catch (Exception ex2)
							{
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error generating invoice. Detail: " + ex3.Message);
			}
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x00356D78 File Offset: 0x00354F78
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x00356DAC File Offset: 0x00354FAC
		private void cboCustomers_TextChanged(object sender, EventArgs e)
		{
			try
			{
				TripMgt._Closure$__298-0 CS$<>8__locals1 = new TripMgt._Closure$__298-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$Local_textToSearch = this.cboCustomers.Text.ToLower();
				this.ListBox1.Visible = false;
				bool flag = string.IsNullOrEmpty(CS$<>8__locals1.$VB$Local_textToSearch);
				if (!flag)
				{
					var list = this.customersDatatable.AsEnumerable().Select((TripMgt._Closure$__.$I298-0 == null) ? (TripMgt._Closure$__.$I298-0 = (DataRow p) => new
					{
						ID = p.Field<int>("entryno"),
						Name = p.Field<string>("CustomerName")
					}) : TripMgt._Closure$__.$I298-0).ToList();
					var list2 = list.Where(x => x.Name.ToLower().Contains(CS$<>8__locals1.$VB$Local_textToSearch)).ToList();
					bool flag2 = list2.Count == 0;
					if (!flag2)
					{
						this.ListBox1.Items.Clear();
						try
						{
							foreach (var anon in list2)
							{
								this.ListBox1.Items.Add(anon.Name);
							}
						}
						finally
						{
							var enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.ListBox1.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x00356F10 File Offset: 0x00355110
		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindStringExact(this.ListBox1.SelectedItem.ToString());
				this.ListBox1.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting from list. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x00356F8C File Offset: 0x0035518C
		private void TripMgt_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable allCustomers = this.pf.GetAllCustomers(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				this.cboCustomers.DataSource = allCustomers;
				this.cboCustomers2.DataSource = allCustomers;
				this.customersDatatable = allCustomers;
				this.cboCustomers.DisplayMember = "CustomerName";
				this.cboCustomers.ValueMember = "EntryNo";
				this.cboCustomers.SelectedIndex = -1;
				this.cboCustomers2.DisplayMember = "CustomerName";
				this.cboCustomers2.ValueMember = "EntryNo";
				this.cboCustomers2.SelectedIndex = -1;
				this.dgvTrips.DataSource = this.ViewTrips(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.DTDispatchDate.Value, this.DTDispatchDate.Value, 1, 0);
				bool flag = MyProject.Forms.Form1.DateChange == 1;
				if (flag)
				{
					this.DTDate.Enabled = true;
				}
				else
				{
					this.DTDate.Enabled = false;
				}
				DataTable allProductsList = this.pf.getAllProductsList(MyProject.Forms.Form1.coid, this._cnn);
				this.productsDatatable = allProductsList;
				this.cboProducts.DataSource = allProductsList;
				this.cboProducts.ValueMember = "ProductID";
				this.cboProducts.DisplayMember = "ProductDesc";
				this.cboProducts.SelectedIndex = -1;
				this.LoadPayMeths();
				this.LoadPaymentTerms();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Trip form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x00357180 File Offset: 0x00355380
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboCustomers.SelectedIndex == -1;
				if (flag)
				{
					MessageBox.Show("Please select a customer first.");
					this.cboCustomers.Focus();
				}
				else
				{
					bool flag2 = this.cboProducts.SelectedIndex == -1;
					if (flag2)
					{
						MessageBox.Show("Please select the product first.");
						this.cboProducts.Focus();
					}
					else
					{
						bool flag3 = Conversion.Val(this.txtTotal.Text) <= 0.0;
						if (flag3)
						{
							MessageBox.Show("Please check the total.");
						}
						else
						{
							bool flag4 = Conversion.Val(this.txtTonnage.Text) > Conversion.Val(this.txtTruckCapacity.Text);
							if (flag4)
							{
								MessageBox.Show("Tonnage cannot be higher than truck capacity.");
							}
							else
							{
								SqlConnection sqlConnection = new SqlConnection(this._cnn);
								SqlCommand sqlCommand = sqlConnection.CreateCommand();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "TRIPInsert";
								sqlCommand.Parameters.AddWithValue("dispatchdate", this.DTDispatchDate.Value);
								sqlCommand.Parameters.AddWithValue("LTINumber", this.txtLTINumber.Text);
								sqlCommand.Parameters.AddWithValue("WayBillNumber", this.txtWayBill.Text);
								sqlCommand.Parameters.AddWithValue("Origin", this.txtOrigin.Text);
								sqlCommand.Parameters.AddWithValue("Destination", this.txtDestination.Text);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("TruckRegNumber", this.txtTruckREg.Text);
								sqlCommand.Parameters.AddWithValue("TruckCapacity", Conversion.Val(this.txtTruckCapacity.Text));
								sqlCommand.Parameters.AddWithValue("Tonnage", Conversion.Val(this.txtTonnage.Text));
								sqlCommand.Parameters.AddWithValue("RateTar", Conversion.Val(this.txtRateTar.Text));
								sqlCommand.Parameters.AddWithValue("DistanceTAR", Conversion.Val(this.txtDistanceTar.Text));
								sqlCommand.Parameters.AddWithValue("RateDust", Conversion.Val(this.txtRateDust.Text));
								sqlCommand.Parameters.AddWithValue("DistanceDUST", Conversion.Val(this.txtDistanceDust.Text));
								sqlCommand.Parameters.AddWithValue("TripState", 1);
								sqlCommand.Parameters.AddWithValue("TripStateDesc", "PENDING INVOICE");
								sqlCommand.Parameters.AddWithValue("DateEntered", DateTime.Now);
								sqlCommand.Parameters.AddWithValue("Enteredby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("Machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("CustomerEntryNo", RuntimeHelpers.GetObjectValue(this.cboCustomers.SelectedValue));
								sqlCommand.Parameters.AddWithValue("TripTotal", Conversion.Val(this.txtTotal.Text));
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(this.cboProducts.SelectedValue));
								sqlCommand.Parameters.AddWithValue("taxamt", Conversion.Val(this.txtTaxAmt.Text));
								sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(this.cboPayMeth.SelectedValue));
								using (sqlConnection)
								{
									sqlConnection.Open();
									sqlCommand.ExecuteNonQuery();
									sqlConnection.Close();
								}
								this.ShowTripsPending();
								MessageBox.Show("Trip saved.");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving trip. Details: " + ex.Message);
			}
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x00357620 File Offset: 0x00355820
		private void ShowTripsPending()
		{
			this.dgvTrips.Columns.Clear();
			this.dgvTrips.DataSource = this.ViewTrips(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.DTDispatchDate.Value, this.DTDispatchDate.Value, 1, 0);
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Trip";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvTrips.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x003576CC File Offset: 0x003558CC
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.cboCustomers.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindStringExact(MyProject.Forms.Form1.SearchCustomer);
				this.txtWayBill.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x00357774 File Offset: 0x00355974
		private void Button7_Click(object sender, EventArgs e)
		{
			try
			{
				CustomerDetails customerDetails = new CustomerDetails();
				customerDetails.txtsearch.Text = this.cboCustomers.Text;
				this.Panel1.Controls.Add(customerDetails);
				customerDetails.Dock = DockStyle.Fill;
				customerDetails.BringToFront();
				customerDetails.Dispose();
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindStringExact(MyProject.Forms.Form1.SearchCustomer);
				this.txtWayBill.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying new customer form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x00357834 File Offset: 0x00355A34
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboCustomers2.SelectedIndex == -1;
				if (flag)
				{
					MessageBox.Show("Please select the customer first.");
					this.cboCustomers2.Focus();
				}
				else
				{
					this.ViewTripsPendingInvoice();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x003578B0 File Offset: 0x00355AB0
		private void ViewTripsPendingInvoice()
		{
			this.dgvPendingTrips.Columns.Clear();
			this.dgvPendingTrips.DataSource = this.ViewTrips(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.DTInvStartDate.Value, this.DTInvEndDate.Value, 1, Conversions.ToInteger(this.cboCustomers2.SelectedValue));
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Trip";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvPendingTrips.Columns.Add(dataGridViewButtonColumn);
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			dataGridViewCheckBoxColumn.HeaderText = "Select for Invoicing";
			dataGridViewCheckBoxColumn.Name = "Select";
			this.dgvPendingTrips.Columns.Add(dataGridViewCheckBoxColumn);
			this.GroupBox3.Text = string.Concat(new string[]
			{
				"Showing trips for ",
				this.cboCustomers2.Text,
				" period starting: ",
				this.DTInvStartDate.Value.ToShortDateString(),
				" ending: ",
				this.DTInvEndDate.Value.ToShortDateString()
			});
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x00357A04 File Offset: 0x00355C04
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboCustomers2.SelectedIndex == -1;
				if (flag)
				{
					MessageBox.Show("Please select the customer first.");
					this.cboCustomers2.Focus();
				}
				else
				{
					this.dgvPendingTrips.Columns.Clear();
					this.dgvPendingTrips.DataSource = this.ViewTrips(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.DTInvStartDate.Value, this.DTInvEndDate.Value, 1, Conversions.ToInteger(this.cboCustomers2.SelectedValue));
					DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
					dataGridViewButtonColumn.HeaderText = "Delete Trip";
					dataGridViewButtonColumn.Text = "Delete";
					dataGridViewButtonColumn.Name = "Delete";
					dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
					this.dgvPendingTrips.Columns.Add(dataGridViewButtonColumn);
					this.GroupBox3.Text = string.Concat(new string[]
					{
						"Showing trips for ",
						this.cboCustomers2.Text,
						" period starting: ",
						this.DTInvStartDate.Value.ToShortDateString(),
						" ending: ",
						this.DTInvEndDate.Value.ToShortDateString()
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading trips. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x00357B9C File Offset: 0x00355D9C
		private DataTable ViewTrips(int coid, string branch, DateTime startdate, DateTime enddate, int tripstate, int customerentryno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TRIPSView";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("tripstate", tripstate);
			sqlCommand.Parameters.AddWithValue("customerentryno", customerentryno);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x00357C78 File Offset: 0x00355E78
		private void DTDispatchDate_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.dgvTrips.DataSource = this.ViewTrips(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.DTDispatchDate.Value, this.DTDispatchDate.Value, 1, 0);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying trips after date changed. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x00357D08 File Offset: 0x00355F08
		private void CalcTotalTrip()
		{
			this.txtTotal.Text = (Conversion.Val(this.txtDistanceDust.Text) * Conversion.Val(this.txtRateDust.Text) + Conversion.Val(this.txtDistanceTar.Text) * Conversion.Val(this.txtRateTar.Text)).ToString();
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x00357D70 File Offset: 0x00355F70
		private void txtRateTar_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotalTrip();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calc total. Details: " + ex.Message);
			}
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x00357DC0 File Offset: 0x00355FC0
		private void txtRateDust_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotalTrip();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calc total. Details: " + ex.Message);
			}
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x00357E10 File Offset: 0x00356010
		private void txtDistanceTar_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotalTrip();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calc total. Details: " + ex.Message);
			}
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x00357E60 File Offset: 0x00356060
		private void txtDistanceDust_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcTotalTrip();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calc total. Details: " + ex.Message);
			}
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x00357EB0 File Offset: 0x003560B0
		private void txtRateTar_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x00357EFC File Offset: 0x003560FC
		private void txtRateDust_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x00357F48 File Offset: 0x00356148
		private void txtDistanceTar_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x00357F94 File Offset: 0x00356194
		private void txtDistanceDust_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x00357FE0 File Offset: 0x003561E0
		private void txtTonnage_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label19_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label20_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x0035802C File Offset: 0x0035622C
		private void cboCustomers2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				TripMgt._Closure$__322-0 CS$<>8__locals1 = new TripMgt._Closure$__322-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$Local_textToSearch = this.cboCustomers2.Text.ToLower();
				this.ListBox2.Visible = false;
				bool flag = string.IsNullOrEmpty(CS$<>8__locals1.$VB$Local_textToSearch);
				if (!flag)
				{
					var list = this.customersDatatable.AsEnumerable().Select((TripMgt._Closure$__.$I322-0 == null) ? (TripMgt._Closure$__.$I322-0 = (DataRow p) => new
					{
						ID = p.Field<int>("entryno"),
						Name = p.Field<string>("CustomerName")
					}) : TripMgt._Closure$__.$I322-0).ToList();
					var list2 = list.Where(x => x.Name.ToLower().Contains(CS$<>8__locals1.$VB$Local_textToSearch)).ToList();
					bool flag2 = list2.Count == 0;
					if (!flag2)
					{
						this.ListBox2.Items.Clear();
						try
						{
							foreach (var anon in list2)
							{
								this.ListBox2.Items.Add(anon.Name);
							}
						}
						finally
						{
							var enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.ListBox2.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x00358190 File Offset: 0x00356390
		private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboCustomers2.SelectedIndex = this.cboCustomers2.FindStringExact(this.ListBox2.SelectedItem.ToString());
				this.ListBox2.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting from list. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x0035820C File Offset: 0x0035640C
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.cboCustomers.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				this.cboCustomers2.SelectedIndex = this.cboCustomers2.FindStringExact(MyProject.Forms.Form1.SearchCustomer);
				this.txtWayBill.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x003582B4 File Offset: 0x003564B4
		private void TabControl1_TabIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.TabControl1.SelectedIndex == 1;
				if (flag)
				{
					this.cboCustomers2.Focus();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x00358308 File Offset: 0x00356508
		private void dgvPendingTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						this.DeleteTrip(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(this.dgvPendingTrips.Rows[e.RowIndex].Cells["EntryNo"].Value), MyProject.Forms.Form1.username, Environment.MachineName);
						MessageBox.Show("Trip deleted.");
						this.ViewTripsPendingInvoice();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D4E RID: 23886 RVA: 0x0035842C File Offset: 0x0035662C
		private void DeleteTrip(int coid, string branch, int entryno, string user, string machinename)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteTrip";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("deletedby", user);
			sqlCommand.Parameters.AddWithValue("machinename", machinename);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x00358500 File Offset: 0x00356700
		private void cboProducts_TextChanged(object sender, EventArgs e)
		{
			try
			{
				TripMgt._Closure$__328-0 CS$<>8__locals1 = new TripMgt._Closure$__328-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$Local_textToSearch = this.cboProducts.Text.ToLower();
				this.ListBox3.Visible = false;
				bool flag = string.IsNullOrEmpty(CS$<>8__locals1.$VB$Local_textToSearch);
				if (!flag)
				{
					var list = this.productsDatatable.AsEnumerable().Select((TripMgt._Closure$__.$I328-0 == null) ? (TripMgt._Closure$__.$I328-0 = (DataRow p) => new
					{
						ID = p.Field<int>("productid"),
						Name = p.Field<string>("productdesc")
					}) : TripMgt._Closure$__.$I328-0).ToList();
					var list2 = list.Where(x => x.Name.ToLower().Contains(CS$<>8__locals1.$VB$Local_textToSearch)).ToList();
					bool flag2 = list2.Count == 0;
					if (!flag2)
					{
						this.ListBox3.Items.Clear();
						try
						{
							foreach (var anon in list2)
							{
								this.ListBox3.Items.Add(anon.Name);
							}
						}
						finally
						{
							var enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.ListBox3.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x00358664 File Offset: 0x00356864
		private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboProducts.SelectedIndex = this.cboProducts.FindStringExact(this.ListBox3.SelectedItem.ToString());
				this.ListBox3.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting from list. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x003586E0 File Offset: 0x003568E0
		private void LoadPayMeths()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPayMeth.DataSource = dataTable;
			this.cboPayMeth.ValueMember = "PaymentMethodID";
			this.cboPayMeth.DisplayMember = "PaymentMethodDesc";
			this.cboPayMeth.SelectedIndex = -1;
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x0035878C File Offset: 0x0035698C
		private void LoadPaymentTerms()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentTerms";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboTerms.DataSource = dataTable;
			this.cboTerms.DisplayMember = "Description";
			this.cboTerms.ValueMember = "TermsDays";
			this.cboTerms.SelectedIndex = -1;
		}

		// Token: 0x040028CB RID: 10443
		private string _cnn;

		// Token: 0x040028CC RID: 10444
		private DataTable customersDatatable;

		// Token: 0x040028CD RID: 10445
		private PublicFunctions pf;

		// Token: 0x040028CE RID: 10446
		private DataTable productsDatatable;
	}
}
