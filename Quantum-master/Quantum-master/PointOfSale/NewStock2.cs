using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200007D RID: 125
	[DesignerGenerated]
	public partial class NewStock2 : Form
	{
		// Token: 0x06001BB1 RID: 7089 RVA: 0x000FAC70 File Offset: 0x000F8E70
		public NewStock2()
		{
			base.Load += this.NewStock_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.first = false;
			this.InitializeComponent();
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x000FCB7E File Offset: 0x000FAD7E
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x000FCB88 File Offset: 0x000FAD88
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x000FCB91 File Offset: 0x000FAD91
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x000FCB9B File Offset: 0x000FAD9B
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x000FCBA4 File Offset: 0x000FADA4
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x000FCBAE File Offset: 0x000FADAE
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x000FCBB7 File Offset: 0x000FADB7
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x000FCBC1 File Offset: 0x000FADC1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x000FCBCA File Offset: 0x000FADCA
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x000FCBD4 File Offset: 0x000FADD4
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x000FCBDD File Offset: 0x000FADDD
		// (set) Token: 0x06001BBF RID: 7103 RVA: 0x000FCBE7 File Offset: 0x000FADE7
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x000FCBF0 File Offset: 0x000FADF0
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x000FCBFC File Offset: 0x000FADFC
		internal virtual TextBox txtSearchProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode_TextChanged);
				TextBox textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode = value;
				textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x000FCC3F File Offset: 0x000FAE3F
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x000FCC49 File Offset: 0x000FAE49
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x000FCC52 File Offset: 0x000FAE52
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x000FCC5C File Offset: 0x000FAE5C
		internal virtual ComboBox cboCategory
		{
			[CompilerGenerated]
			get
			{
				return this._cboCategory;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCategory_SelectedIndexChanged);
				ComboBox comboBox = this._cboCategory;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCategory = value;
				comboBox = this._cboCategory;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000FCC9F File Offset: 0x000FAE9F
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x000FCCA9 File Offset: 0x000FAEA9
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x000FCCB2 File Offset: 0x000FAEB2
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x000FCCBC File Offset: 0x000FAEBC
		internal virtual ComboBox cboProdt
		{
			[CompilerGenerated]
			get
			{
				return this._cboProdt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboProdt_KeyUp);
				EventHandler eventHandler = new EventHandler(this.cboProdt_SelectedIndexChanged);
				ComboBox comboBox = this._cboProdt;
				if (comboBox != null)
				{
					comboBox.KeyUp -= keyEventHandler;
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboProdt = value;
				comboBox = this._cboProdt;
				if (comboBox != null)
				{
					comboBox.KeyUp += keyEventHandler;
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x000FCD1A File Offset: 0x000FAF1A
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x000FCD24 File Offset: 0x000FAF24
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x000FCD2D File Offset: 0x000FAF2D
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x000FCD37 File Offset: 0x000FAF37
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x000FCD40 File Offset: 0x000FAF40
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x000FCD4C File Offset: 0x000FAF4C
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

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000FCD8F File Offset: 0x000FAF8F
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x000FCD9C File Offset: 0x000FAF9C
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

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000FCDDF File Offset: 0x000FAFDF
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x000FCDE9 File Offset: 0x000FAFE9
		internal virtual TextBox lblCalcGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x000FCDF2 File Offset: 0x000FAFF2
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x000FCDFC File Offset: 0x000FAFFC
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000FCE05 File Offset: 0x000FB005
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x000FCE0F File Offset: 0x000FB00F
		internal virtual TextBox lblNumUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x000FCE18 File Offset: 0x000FB018
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x000FCE22 File Offset: 0x000FB022
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x000FCE2B File Offset: 0x000FB02B
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x000FCE35 File Offset: 0x000FB035
		internal virtual TextBox lblCostOfStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x000FCE3E File Offset: 0x000FB03E
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x000FCE48 File Offset: 0x000FB048
		internal virtual TextBox txtReorder
		{
			[CompilerGenerated]
			get
			{
				return this._txtReorder;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtReorder_KeyPress);
				TextBox textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtReorder = value;
				textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000FCE8B File Offset: 0x000FB08B
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x000FCE95 File Offset: 0x000FB095
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000FCE9E File Offset: 0x000FB09E
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x000FCEA8 File Offset: 0x000FB0A8
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x000FCEB1 File Offset: 0x000FB0B1
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x000FCEBC File Offset: 0x000FB0BC
		internal virtual TextBox txtSellingPrice
		{
			[CompilerGenerated]
			get
			{
				return this._txtSellingPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtSellingPrice_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtSellingPrice_TextChanged);
				TextBox textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtSellingPrice = value;
				textBox = this._txtSellingPrice;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000FCF1A File Offset: 0x000FB11A
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x000FCF24 File Offset: 0x000FB124
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000FCF2D File Offset: 0x000FB12D
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x000FCF37 File Offset: 0x000FB137
		internal virtual TextBox txtCostperUnit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000FCF40 File Offset: 0x000FB140
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x000FCF4A File Offset: 0x000FB14A
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000FCF53 File Offset: 0x000FB153
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x000FCF60 File Offset: 0x000FB160
		internal virtual TextBox txtCostOnePack
		{
			[CompilerGenerated]
			get
			{
				return this._txtCostOnePack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtCostOnePack_KeyPress);
				TextBox textBox = this._txtCostOnePack;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtCostOnePack = value;
				textBox = this._txtCostOnePack;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000FCFA3 File Offset: 0x000FB1A3
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x000FCFAD File Offset: 0x000FB1AD
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x000FCFB6 File Offset: 0x000FB1B6
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x000FCFC0 File Offset: 0x000FB1C0
		internal virtual TextBox txtNumUnitsinPack
		{
			[CompilerGenerated]
			get
			{
				return this._txtNumUnitsinPack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNumUnitsinPack_KeyPress);
				TextBox textBox = this._txtNumUnitsinPack;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNumUnitsinPack = value;
				textBox = this._txtNumUnitsinPack;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000FD003 File Offset: 0x000FB203
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x000FD00D File Offset: 0x000FB20D
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000FD016 File Offset: 0x000FB216
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x000FD020 File Offset: 0x000FB220
		internal virtual TextBox txtPacks
		{
			[CompilerGenerated]
			get
			{
				return this._txtPacks;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtPacks_KeyPress);
				TextBox textBox = this._txtPacks;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtPacks = value;
				textBox = this._txtPacks;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000FD063 File Offset: 0x000FB263
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x000FD06D File Offset: 0x000FB26D
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000FD076 File Offset: 0x000FB276
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x000FD080 File Offset: 0x000FB280
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

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x000FD0C3 File Offset: 0x000FB2C3
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x000FD0CD File Offset: 0x000FB2CD
		internal virtual TextBox txtref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x000FD0D6 File Offset: 0x000FB2D6
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x000FD0E0 File Offset: 0x000FB2E0
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000FD0E9 File Offset: 0x000FB2E9
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x000FD0F3 File Offset: 0x000FB2F3
		internal virtual Label Label25
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000FD0FC File Offset: 0x000FB2FC
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x000FD106 File Offset: 0x000FB306
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000FD10F File Offset: 0x000FB30F
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x000FD119 File Offset: 0x000FB319
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000FD122 File Offset: 0x000FB322
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x000FD12C File Offset: 0x000FB32C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000FD135 File Offset: 0x000FB335
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x000FD13F File Offset: 0x000FB33F
		internal virtual Label lblTotalGross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000FD148 File Offset: 0x000FB348
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x000FD152 File Offset: 0x000FB352
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000FD15B File Offset: 0x000FB35B
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x000FD165 File Offset: 0x000FB365
		internal virtual Label lbltotalcost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000FD16E File Offset: 0x000FB36E
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x000FD178 File Offset: 0x000FB378
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000FD181 File Offset: 0x000FB381
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x000FD18B File Offset: 0x000FB38B
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x000FD194 File Offset: 0x000FB394
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x000FD19E File Offset: 0x000FB39E
		internal virtual DataGridViewTextBoxColumn NumUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000FD1A7 File Offset: 0x000FB3A7
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x000FD1B1 File Offset: 0x000FB3B1
		internal virtual DataGridViewTextBoxColumn Packs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000FD1BA File Offset: 0x000FB3BA
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x000FD1C4 File Offset: 0x000FB3C4
		internal virtual DataGridViewTextBoxColumn Reorder
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000FD1CD File Offset: 0x000FB3CD
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x000FD1D7 File Offset: 0x000FB3D7
		internal virtual DataGridViewTextBoxColumn TotalUnits
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000FD1E0 File Offset: 0x000FB3E0
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x000FD1EA File Offset: 0x000FB3EA
		internal virtual DataGridViewTextBoxColumn CostPerUnit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000FD1F3 File Offset: 0x000FB3F3
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x000FD1FD File Offset: 0x000FB3FD
		internal virtual DataGridViewTextBoxColumn SellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x000FD206 File Offset: 0x000FB406
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x000FD210 File Offset: 0x000FB410
		internal virtual DataGridViewTextBoxColumn Gross
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000FD219 File Offset: 0x000FB419
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x000FD223 File Offset: 0x000FB423
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000FD22C File Offset: 0x000FB42C
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x000FD238 File Offset: 0x000FB438
		internal virtual TextBox txtBarCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtBarCode_TextChanged);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000FD27B File Offset: 0x000FB47B
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x000FD285 File Offset: 0x000FB485
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000FD290 File Offset: 0x000FB490
		private void NewStock_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategories();
				this.LoadProducts(Conversions.ToInteger(this.cboCategory.SelectedValue));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000FD2F8 File Offset: 0x000FB4F8
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboCategory.DataSource = dataTable;
			this.cboCategory.ValueMember = "CatID";
			this.cboCategory.DisplayMember = "CatDesc";
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000FD398 File Offset: 0x000FB598
		private void LoadProducts(int catid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductsByCategory";
			sqlCommand.Parameters.AddWithValue("category", catid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboProdt.DataSource = dataTable;
			this.cboProdt.ValueMember = "ProductCode";
			this.cboProdt.DisplayMember = "ProductDesc";
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000FD450 File Offset: 0x000FB650
		private void FetchProdtDetails(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtReorder.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ReorderLevel"])), 0, RuntimeHelpers.GetObjectValue(dataRow["ReorderLevel"])));
				this.txtNumUnitsinPack.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["UnitsPerPack"])), 0, RuntimeHelpers.GetObjectValue(dataRow["UnitsPerPack"])));
				this.txtSellingPrice.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtCostOnePack.Text = Conversions.ToString(Operators.MultiplyObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["cost"])), Conversion.Val(this.txtNumUnitsinPack.Text)));
				this.CurrentId = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.ClearForm();
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000FD668 File Offset: 0x000FB868
		private void CalcStats()
		{
			try
			{
				double num = Conversion.Val(this.txtCostOnePack.Text) * Conversion.Val(this.txtPacks.Text);
				double num2 = Conversion.Val(this.txtCostOnePack.Text) / Conversion.Val(this.txtNumUnitsinPack.Text);
				double num3 = Conversion.Val(this.txtNumUnitsinPack.Text) * Conversion.Val(this.txtPacks.Text) * Conversion.Val(this.txtSellingPrice.Text) - num;
				this.lblCostOfStock.Text = Conversions.ToString(num);
				this.lblCalcGross.Text = Conversions.ToString(num3);
				this.txtCostperUnit.Text = Conversions.ToString(num2);
				this.lblNumUnits.Text = Conversions.ToString(Conversion.Val(this.txtNumUnitsinPack.Text) * Conversion.Val(this.txtPacks.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating.");
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000FD788 File Offset: 0x000FB988
		private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadProducts(Conversions.ToInteger(this.cboCategory.SelectedValue));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000FD7D0 File Offset: 0x000FB9D0
		private void cboProdt_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = (e.KeyCode == Keys.Back) | (e.KeyCode == Keys.Left) | (e.KeyCode == Keys.Right) | (e.KeyCode == Keys.Up) | (e.KeyCode == Keys.Delete) | (e.KeyCode == Keys.Down) | (e.KeyCode == Keys.Prior) | (e.KeyCode == Keys.Next) | (e.KeyCode == Keys.Home) | (e.KeyCode == Keys.End);
			if (!flag)
			{
				string text = this.cboProdt.Text;
				int num = this.cboProdt.FindString(text);
				bool flag2 = num > -1;
				if (flag2)
				{
					string text2 = this.cboProdt.Items[num].ToString();
					this.cboProdt.SelectedIndex = num;
					this.cboProdt.SelectionStart = text.Length;
					this.cboProdt.SelectionLength = text2.Length;
				}
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000FD8C0 File Offset: 0x000FBAC0
		private void cboProdt_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtSearchProductCode.Text = Conversions.ToString(this.cboProdt.SelectedValue);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000FD910 File Offset: 0x000FBB10
		private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000FD95C File Offset: 0x000FBB5C
		private void txtSellingPrice_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcStats();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating statistics. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000FD9AC File Offset: 0x000FBBAC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				NewProdt2 newProdt = new NewProdt2();
				newProdt.ShowDialog(this);
				newProdt.Dispose();
				string newProdtCode = MyProject.Forms.Form1.newProdtCode;
				this.txtSearchProductCode.Text = newProdtCode;
				this.txtPacks.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("New product error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000FDA34 File Offset: 0x000FBC34
		private void txtCostOnePack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtNumUnitsinPack_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtPacks_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000FDA80 File Offset: 0x000FBC80
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.verify();
				if (flag)
				{
					bool flag2 = this.first;
					if (flag2)
					{
						this.invnum = this.GetInvoiceNum();
						this.first = false;
					}
					this.UpdateProduct();
					this.InsertStock(this.invnum);
					this.AppendGrid();
					this.UpdateTotals();
					this.ClearForm();
					this.txtSearchProductCode.Focus();
				}
				else
				{
					MessageBox.Show("Please ensure that the number of units and cost of the units details are entered before proceeding.", "Error");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving new stock item. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000FDB3C File Offset: 0x000FBD3C
		private bool verify()
		{
			bool flag = (Conversion.Val(this.txtCostperUnit.Text) <= 0.0) | (Conversion.Val(this.lblNumUnits.Text) <= 0.0);
			return !flag;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000FDB9C File Offset: 0x000FBD9C
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboProdt.Text = "-";
				this.FetchProdtDetails(this.txtSearchProductCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000FDC08 File Offset: 0x000FBE08
		private void UpdateProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Updateproduct";
			sqlCommand.Parameters.AddWithValue("productid", this.CurrentId);
			sqlCommand.Parameters.AddWithValue("unitsperpack", Conversion.Val(this.txtNumUnitsinPack.Text));
			sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
			sqlCommand.Parameters.AddWithValue("sellingprice", Conversion.Val(this.txtSellingPrice.Text));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("reorderlevel", Conversion.Val(this.txtReorder.Text));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000FDDA4 File Offset: 0x000FBFA4
		private int GetInvoiceNum()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNewInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000FDE7C File Offset: 0x000FC07C
		private void InsertStock(int invoicenum)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock2";
			sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", this.CurrentId);
			sqlCommand.Parameters.AddWithValue("isstockin", 1);
			sqlCommand.Parameters.AddWithValue("ref", this.txtref.Text);
			sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(this.lblNumUnits.Text));
			sqlCommand.Parameters.AddWithValue("cost", Conversion.Val(this.txtCostperUnit.Text));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("productcode", this.txtSearchProductCode.Text);
			sqlCommand.Parameters.AddWithValue("trancode", 1);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000FE08C File Offset: 0x000FC28C
		private void AppendGrid()
		{
			string[] array = new string[]
			{
				this.lblDesc.Text,
				this.txtNumUnitsinPack.Text,
				this.txtPacks.Text,
				this.txtReorder.Text,
				this.lblNumUnits.Text,
				this.txtCostperUnit.Text,
				this.txtSellingPrice.Text,
				this.lblCalcGross.Text
			};
			this.DataGridView1.Rows.Add(array);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000FE124 File Offset: 0x000FC324
		private void UpdateTotals()
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CostperUnit"].Value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["TotalUnits"].Value));
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Gross"].Value));
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
			this.lbltotalcost.Text = Conversions.ToString(num);
			this.lblTotalGross.Text = Conversions.ToString(num2);
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000FE224 File Offset: 0x000FC424
		private void ClearForm()
		{
			this.txtref.Text = "";
			this.txtSellingPrice.Text = Conversions.ToString(0);
			this.txtPacks.Text = Conversions.ToString(0);
			this.txtCostperUnit.Text = Conversions.ToString(0);
			this.lblCalcGross.Text = Conversions.ToString(0);
			this.txtCostOnePack.Text = Conversions.ToString(0);
			this.txtNumUnitsinPack.Text = Conversions.ToString(0);
			this.txtReorder.Text = Conversions.ToString(0);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x000FE2C4 File Offset: 0x000FC4C4
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.CalcStats();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating statistics. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x000FE314 File Offset: 0x000FC514
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SearchBarCode(Conversions.ToInteger(this.txtBarCode.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching Bar Code. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x000FE374 File Offset: 0x000FC574
		private void SearchBarCode(int barcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProductBarCode";
			sqlCommand.Parameters.AddWithValue("barcode", barcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtSearchProductCode.Text = Conversions.ToString(dataRow["ProductCode"]);
			}
			else
			{
				this.txtSearchProductCode.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x04000D84 RID: 3460
		private string _cnn;

		// Token: 0x04000D85 RID: 3461
		private PublicFunctions publicfunction;

		// Token: 0x04000D86 RID: 3462
		public int newID;

		// Token: 0x04000D87 RID: 3463
		private bool first;

		// Token: 0x04000D88 RID: 3464
		private int invnum;

		// Token: 0x04000D89 RID: 3465
		private int CurrentId;
	}
}
