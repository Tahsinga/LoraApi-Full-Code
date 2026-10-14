using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200003A RID: 58
	[DesignerGenerated]
	public partial class DBConnections : Form
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x0007B538 File Offset: 0x00079738
		public DBConnections()
		{
			base.Load += this.DBConnections_Load;
			this.lblclicks = 0;
			this.pf = new PublicFunctions();
			this.DBCreated = false;
			this.InitializeComponent();
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0007D909 File Offset: 0x0007BB09
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x0007D913 File Offset: 0x0007BB13
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0007D91C File Offset: 0x0007BB1C
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x0007D926 File Offset: 0x0007BB26
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0007D92F File Offset: 0x0007BB2F
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0007D939 File Offset: 0x0007BB39
		internal virtual TextBox txtConnString2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0007D942 File Offset: 0x0007BB42
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x0007D94C File Offset: 0x0007BB4C
		internal virtual CheckBox CheckBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0007D955 File Offset: 0x0007BB55
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x0007D95F File Offset: 0x0007BB5F
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0007D968 File Offset: 0x0007BB68
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x0007D972 File Offset: 0x0007BB72
		internal virtual TextBox txtConnString
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0007D97B File Offset: 0x0007BB7B
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x0007D985 File Offset: 0x0007BB85
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0007D98E File Offset: 0x0007BB8E
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x0007D998 File Offset: 0x0007BB98
		internal virtual CheckBox CheckBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0007D9A1 File Offset: 0x0007BBA1
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x0007D9AC File Offset: 0x0007BBAC
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
				EventHandler eventHandler2 = new EventHandler(this.Button4_MouseHover);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
					button.MouseHover -= eventHandler2;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
					button.MouseHover += eventHandler2;
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0007DA0A File Offset: 0x0007BC0A
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x0007DA14 File Offset: 0x0007BC14
		internal virtual Label lblmsg
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0007DA1D File Offset: 0x0007BC1D
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x0007DA27 File Offset: 0x0007BC27
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0007DA30 File Offset: 0x0007BC30
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x0007DA3C File Offset: 0x0007BC3C
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

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0007DA7F File Offset: 0x0007BC7F
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x0007DA8C File Offset: 0x0007BC8C
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0007DACF File Offset: 0x0007BCCF
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x0007DADC File Offset: 0x0007BCDC
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0007DB1F File Offset: 0x0007BD1F
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x0007DB29 File Offset: 0x0007BD29
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0007DB32 File Offset: 0x0007BD32
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x0007DB3C File Offset: 0x0007BD3C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0007DB45 File Offset: 0x0007BD45
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x0007DB4F File Offset: 0x0007BD4F
		internal virtual TextBox txtPwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0007DB58 File Offset: 0x0007BD58
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x0007DB62 File Offset: 0x0007BD62
		internal virtual TextBox txtUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0007DB6B File Offset: 0x0007BD6B
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x0007DB78 File Offset: 0x0007BD78
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0007DBBB File Offset: 0x0007BDBB
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x0007DBC8 File Offset: 0x0007BDC8
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0007DC0B File Offset: 0x0007BE0B
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0007DC15 File Offset: 0x0007BE15
		internal virtual TextBox txtDBName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0007DC1E File Offset: 0x0007BE1E
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0007DC28 File Offset: 0x0007BE28
		internal virtual TextBox txtServerName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0007DC31 File Offset: 0x0007BE31
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x0007DC3B File Offset: 0x0007BE3B
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0007DC44 File Offset: 0x0007BE44
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x0007DC4E File Offset: 0x0007BE4E
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0007DC57 File Offset: 0x0007BE57
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x0007DC61 File Offset: 0x0007BE61
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0007DC6A File Offset: 0x0007BE6A
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x0007DC74 File Offset: 0x0007BE74
		internal virtual TextBox txtOnlineConn
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0007DC7D File Offset: 0x0007BE7D
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x0007DC88 File Offset: 0x0007BE88
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0007DCCB File Offset: 0x0007BECB
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x0007DCD8 File Offset: 0x0007BED8
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0007DD1B File Offset: 0x0007BF1B
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x0007DD25 File Offset: 0x0007BF25
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0007DD2E File Offset: 0x0007BF2E
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x0007DD38 File Offset: 0x0007BF38
		internal virtual ComboBox cboOnlineConnString
		{
			[CompilerGenerated]
			get
			{
				return this._cboOnlineConnString;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboOnlineConnString_SelectedIndexChanged);
				ComboBox comboBox = this._cboOnlineConnString;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboOnlineConnString = value;
				comboBox = this._cboOnlineConnString;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0007DD7B File Offset: 0x0007BF7B
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x0007DD88 File Offset: 0x0007BF88
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0007DDCB File Offset: 0x0007BFCB
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x0007DDD8 File Offset: 0x0007BFD8
		internal virtual Button Button8
		{
			[CompilerGenerated]
			get
			{
				return this._Button8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button8_Click);
				Button button = this._Button8;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button8 = value;
				button = this._Button8;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0007DE1B File Offset: 0x0007C01B
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x0007DE25 File Offset: 0x0007C025
		internal virtual TextBox txtOnlinePwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0007DE2E File Offset: 0x0007C02E
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x0007DE38 File Offset: 0x0007C038
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0007DE41 File Offset: 0x0007C041
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x0007DE4C File Offset: 0x0007C04C
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
				EventHandler eventHandler = new EventHandler(this.Button9_Click_1);
				EventHandler eventHandler2 = new EventHandler(this.Button9_MouseHover);
				Button button = this._Button9;
				if (button != null)
				{
					button.Click -= eventHandler;
					button.MouseHover -= eventHandler2;
				}
				this._Button9 = value;
				button = this._Button9;
				if (button != null)
				{
					button.Click += eventHandler;
					button.MouseHover += eventHandler2;
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0007DEAA File Offset: 0x0007C0AA
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x0007DEB4 File Offset: 0x0007C0B4
		internal virtual TextBox txtscript
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0007DEBD File Offset: 0x0007C0BD
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x0007DEC8 File Offset: 0x0007C0C8
		internal virtual CheckBox chkOnlineDB
		{
			[CompilerGenerated]
			get
			{
				return this._chkOnlineDB;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkOnlineDB_CheckedChanged);
				CheckBox checkBox = this._chkOnlineDB;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkOnlineDB = value;
				checkBox = this._chkOnlineDB;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0007DF0B File Offset: 0x0007C10B
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x0007DF15 File Offset: 0x0007C115
		internal virtual ToolTip ToolTip1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0007DF1E File Offset: 0x0007C11E
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x0007DF28 File Offset: 0x0007C128
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0007DF31 File Offset: 0x0007C131
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x0007DF3C File Offset: 0x0007C13C
		internal virtual Button Button10
		{
			[CompilerGenerated]
			get
			{
				return this._Button10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button10_Click);
				Button button = this._Button10;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button10 = value;
				button = this._Button10;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x0007DF7F File Offset: 0x0007C17F
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x0007DF89 File Offset: 0x0007C189
		internal virtual TextBox txtQuery
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0007DF92 File Offset: 0x0007C192
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x0007DF9C File Offset: 0x0007C19C
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0007DFA5 File Offset: 0x0007C1A5
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x0007DFAF File Offset: 0x0007C1AF
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0007DFB8 File Offset: 0x0007C1B8
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x0007DFC4 File Offset: 0x0007C1C4
		internal virtual Button Button11
		{
			[CompilerGenerated]
			get
			{
				return this._Button11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button11_Click);
				Button button = this._Button11;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button11 = value;
				button = this._Button11;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0007E007 File Offset: 0x0007C207
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x0007E014 File Offset: 0x0007C214
		internal virtual Button Button12
		{
			[CompilerGenerated]
			get
			{
				return this._Button12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button12_Click);
				Button button = this._Button12;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button12 = value;
				button = this._Button12;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0007E057 File Offset: 0x0007C257
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x0007E061 File Offset: 0x0007C261
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0007E06A File Offset: 0x0007C26A
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x0007E074 File Offset: 0x0007C274
		internal virtual TextBox txtBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0007E07D File Offset: 0x0007C27D
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x0007E087 File Offset: 0x0007C287
		internal virtual Label lblbranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0007E090 File Offset: 0x0007C290
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x0007E09A File Offset: 0x0007C29A
		internal virtual TextBox txtCoid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0007E0A3 File Offset: 0x0007C2A3
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x0007E0AD File Offset: 0x0007C2AD
		internal virtual Label lblcoid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0007E0B6 File Offset: 0x0007C2B6
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x0007E0C0 File Offset: 0x0007C2C0
		internal virtual TextBox txtcurr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0007E0C9 File Offset: 0x0007C2C9
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0007E0D3 File Offset: 0x0007C2D3
		internal virtual Label lblcurr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0007E0DC File Offset: 0x0007C2DC
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0007E0E6 File Offset: 0x0007C2E6
		internal virtual TextBox txtconame
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0007E0EF File Offset: 0x0007C2EF
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0007E0F9 File Offset: 0x0007C2F9
		internal virtual Label lblconame
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0007E102 File Offset: 0x0007C302
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x0007E10C File Offset: 0x0007C30C
		internal virtual Button Button13
		{
			[CompilerGenerated]
			get
			{
				return this._Button13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button13_Click);
				Button button = this._Button13;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button13 = value;
				button = this._Button13;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0007E14F File Offset: 0x0007C34F
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x0007E159 File Offset: 0x0007C359
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0007E164 File Offset: 0x0007C364
		private void DBConnections_Load(object sender, EventArgs e)
		{
			try
			{
				this.CheckBox1.Checked = true;
				this.CheckBox2.Checked = true;
				this.txtDBName.Text = "POS";
				this.txtServerName.Text = Environment.MachineName;
				this.txtConnString2.Text = MyProject.Forms.Form1.Constring;
				base.AcceptButton = this.Button2;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0007E210 File Offset: 0x0007C410
		public bool CheckDatabaseExists(string Server, string Database)
		{
			string text = this.GetconnStringInitial();
			string text2 = "SELECT * FROM master.dbo.sysdatabases WHERE NAME='" + Database + "'";
			bool flag = false;
			using (SqlConnection sqlConnection = new SqlConnection(text))
			{
				sqlConnection.Open();
				using (SqlCommand sqlCommand = new SqlCommand(text2, sqlConnection))
				{
					using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
					{
						flag = sqlDataReader.HasRows;
					}
				}
			}
			return flag;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0007E2C4 File Offset: 0x0007C4C4
		private void CreateDB()
		{
			this.ProgressBar1.Minimum = 1;
			this.ProgressBar1.Maximum = 125;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.Value = 1;
			this.ProgressBar1.Visible = true;
			string text = this.GetconnStringInitial();
			string connString = this.GetConnString();
			FileInfo fileInfo = new FileInfo("c:\\Quantum\\createPOSdb.sql");
			string text2 = fileInfo.OpenText().ReadToEnd();
			string text3 = text2.Replace("GO", "");
			FileInfo fileInfo2 = new FileInfo("c:\\Quantum\\fulldb.sql");
			string text4 = fileInfo2.OpenText().ReadToEnd();
			string text5 = text4;
			text5 = text5.Replace("USE [POS]", "");
			text5 = text5.Replace("SET ANSI_NULLS ON", "");
			text5 = text5.Replace("SET QUOTED_IDENTIFIER ON", "");
			SqlConnection sqlConnection = new SqlConnection(connString);
			SqlConnection sqlConnection2 = new SqlConnection(text);
			SqlCommand sqlCommand = new SqlCommand(text3, sqlConnection2);
			SqlConnection sqlConnection3 = new SqlConnection(connString);
			SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
			sqlCommand2.CommandType = CommandType.Text;
			sqlCommand2.CommandText = text5;
			SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
			try
			{
				bool flag = !this.CheckDatabaseExists(this.txtServerName.Text, this.txtDBName.Text);
				if (flag)
				{
					sqlCommand.Connection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Dispose();
					sqlCommand.Connection.Close();
					this.ProgressBar1.PerformStep();
				}
				sqlConnection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("CreateDBTablesAndSP");
				sqlCommand2.Transaction = sqlTransaction;
				sqlCommand2.CommandType = CommandType.Text;
				this.ProgressBar1.PerformStep();
				IEnumerable<string> enumerable = Directory.GetFiles("c:\\quantum\\scripts\\", "dbo.*", SearchOption.TopDirectoryOnly).Select<string, string>((DBConnections._Closure$__.$I233-0 == null) ? (DBConnections._Closure$__.$I233-0 = (string nm) => Path.GetFileName(nm)) : DBConnections._Closure$__.$I233-0);
				try
				{
					foreach (string text6 in enumerable)
					{
						FileInfo fileInfo3 = new FileInfo("c:\\quantum\\scripts\\" + text6);
						string text7 = fileInfo3.OpenText().ReadToEnd();
						string text8 = text7.Replace("GO", ";");
						text8 = text8.Replace("USE [POS]", "");
						text8 = text8.Replace("SET ANSI_NULLS ON", "");
						text8 = text8.Replace("SET QUOTED_IDENTIFIER ON", "");
						sqlCommand2.CommandType = CommandType.Text;
						sqlCommand2.CommandText = text8;
						sqlCommand2.ExecuteNonQuery();
						sqlCommand2.Dispose();
						this.ProgressBar1.PerformStep();
					}
				}
				finally
				{
					IEnumerator<string> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.ProgressBar1.PerformStep();
				sqlTransaction.Commit();
				this.ProgressBar1.PerformStep();
				this.ProgressBar1.Visible = false;
				sqlConnection.Close();
				this.lblmsg.Text = "Configuration done.";
				MessageBox.Show("Database created successfully");
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Do you want to save the connection settings?", MsgBoxStyle.YesNo, null);
				bool flag2 = dialogResult == DialogResult.Yes;
				if (flag2)
				{
					try
					{
						bool flag3 = this.TestServerConns(this.GetConnString());
						if (flag3)
						{
							this.AddUpdateAppSettings("SQLServerConnString", this.GetConnString());
							MyProject.Forms.Form1.Constring = this.GetConnString();
							MessageBox.Show("Successfuly saved Server Connection Data", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Close();
						}
						else
						{
							MessageBox.Show("Connection to Database was not established. Data was not saved.");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error saving connection string. Retry. Detailed error is as follows: " + ex.Message);
					}
				}
			}
			catch (Exception ex2)
			{
				this.ProgressBar1.Visible = false;
				MessageBox.Show("An error has occured while attempting to create the database. Roll back being attempted. Detail: " + ex2.Message);
				SqlTransaction sqlTransaction;
				sqlTransaction.Rollback();
				this.lblmsg.Text = "Rollback successfull.";
			}
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0007E724 File Offset: 0x0007C924
		private void CreateDefaultTransactionCodes(string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			string text = "insert into TranCodes (TranCode, TranDescription) values(1,'Stock Purchase')";
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
			text = "insert into TranCodes (TranCode,TranDescription) values(2,'Stock Take')";
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
			text = "insert into TranCodes (TranCode,TranDescription) values(3,'Sale')";
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
			text = "insert into TranCodes (TranCode,TranDescription) values(4,'Credit Note')";
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0007E850 File Offset: 0x0007CA50
		private void CreateDefaultUser(string conn)
		{
			PublicFunctions publicFunctions = new PublicFunctions();
			string text = publicFunctions.Encrypt("POSAdmin1", "10");
			SqlConnection sqlConnection = new SqlConnection(conn);
			string text2 = "Insert into Users ([Username],[Password],[IsAdmin]) values ('POSAdmin1', '" + text + "',1)";
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text2;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0007E8DC File Offset: 0x0007CADC
		private void CreateDefaultSockVal(string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			string text = "insert into StockValuationMethods ([Method]) values ('LIFO')";
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0007E93C File Offset: 0x0007CB3C
		private void CreateDefaultPayMethods(string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			string text = "Insert into PaymentMethods ([PaymentMethodDesc]) values ('Cash')";
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
			text = "Insert into PaymentMethods ([PaymentMethodDesc]) values ('Ecocash')";
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0007E9E0 File Offset: 0x0007CBE0
		private void DropDatabase()
		{
			string text = this.GetconnStringInitial();
			SqlConnection sqlConnection = new SqlConnection(text);
			SqlCommand sqlCommand = new SqlCommand("ALTER DATABASE [databasename] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; use master; Drop Database OnlineFeesManagement;", sqlConnection);
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Dispose();
			sqlCommand.Connection.Close();
			this.lblmsg.Text = this.lblmsg.Text + " Database dropped.";
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0007EA50 File Offset: 0x0007CC50
		private void SaveConstring(string theconstring)
		{
			SqlConnection sqlConnection = new SqlConnection(theconstring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "update company set constring='" + theconstring + "'";
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0007EAC4 File Offset: 0x0007CCC4
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.TestServerConns(this.GetConnString());
				if (flag)
				{
					this.AddUpdateAppSettings("SQLServerConnString", this.GetConnString());
					MyProject.Forms.Form1.Constring = this.GetConnString();
					this.SaveConstring(MyProject.Forms.Form1.Constring);
					bool flag2 = this.IsDBInitialised(MyProject.Forms.Form1.Constring);
					if (flag2)
					{
						MessageBox.Show("Successfuly saved Server Connection Data", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						base.Close();
					}
					else
					{
						this.txtCoid.Visible = true;
						this.txtBranch.Visible = true;
						this.lblcoid.Visible = true;
						this.lblbranch.Visible = true;
						this.txtconame.Visible = true;
						this.txtcurr.Visible = true;
						this.lblconame.Visible = true;
						this.lblcurr.Visible = true;
						bool flag3 = (Operators.CompareString(this.txtCoid.Text, "", false) == 0) & (Operators.CompareString(this.txtBranch.Text, "", false) == 0);
						if (flag3)
						{
							MessageBox.Show("Please enter the company COID and branch");
						}
						else
						{
							this.ReplaceCoid_Batch("initDBscript.sql", Environment.CurrentDirectory, this.txtCoid.Text, this.txtBranch.Text, this.txtconame.Text, this.txtcurr.Text);
							bool flag4 = this.RunSqlScript("initDBscript.sql", this.GetConnString());
							if (flag4)
							{
								MessageBox.Show("Init DB successfully run.");
								base.Close();
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Connection to Database was not established. Data was not saved.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving connection string. Retry. Detailed error is as follows: " + ex.Message);
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0007ECCC File Offset: 0x0007CECC
		private void AddUpdateAppSettings(string key, string value)
		{
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
			bool flag = Information.IsNothing(settings[key]);
			if (flag)
			{
				settings.Add(key, value);
			}
			else
			{
				settings[key].Value = value;
			}
			configuration.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0007ED38 File Offset: 0x0007CF38
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.TestServerConns(this.GetConnString());
			if (flag)
			{
				MessageBox.Show("Test Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Test was not successful. Edit connection settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0007ED84 File Offset: 0x0007CF84
		private bool TestServerConns(string serverconn)
		{
			bool flag = false;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(serverconn);
				SqlConnection sqlConnection2 = sqlConnection;
				sqlConnection2.Open();
				flag = true;
				sqlConnection2.Close();
			}
			catch (Exception ex)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0007EDDC File Offset: 0x0007CFDC
		private string GetConnString()
		{
			bool @checked = this.CheckBox3.Checked;
			string text;
			if (@checked)
			{
				text = this.txtConnString2.Text;
			}
			else
			{
				bool flag = !this.CheckBox2.Checked;
				if (flag)
				{
					bool checked2 = this.CheckBox1.Checked;
					if (checked2)
					{
						text = string.Concat(new string[]
						{
							"Server=",
							this.txtServerName.Text,
							";Database=",
							this.txtDBName.Text,
							";Trusted_Connection=True;"
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							"Server=",
							this.txtServerName.Text,
							";Database=",
							this.txtDBName.Text,
							";User Id=",
							this.txtUsername.Text,
							";Password=",
							this.txtPwd.Text
						});
					}
				}
				else
				{
					bool checked3 = this.CheckBox1.Checked;
					if (checked3)
					{
						text = string.Concat(new string[]
						{
							"Data Source=",
							this.txtServerName.Text,
							"\\SQLEXPRESS;Database =",
							this.txtDBName.Text,
							";Trusted_Connection=Yes;User Instance=False"
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							"Data Source=",
							this.txtServerName.Text,
							"\\SQLEXPRESS;Database =",
							this.txtDBName.Text,
							";User Id=",
							this.txtUsername.Text,
							";Password=",
							this.txtPwd.Text,
							";User Instance=False"
						});
					}
				}
			}
			return text;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0007EFB4 File Offset: 0x0007D1B4
		private string GetconnStringInitial()
		{
			string text = "";
			bool @checked = this.CheckBox3.Checked;
			if (@checked)
			{
				text = this.txtConnString.Text;
			}
			else
			{
				bool flag = !this.CheckBox2.Checked;
				if (flag)
				{
					bool checked2 = this.CheckBox1.Checked;
					if (checked2)
					{
						text = "Server=" + this.txtServerName.Text + ";Database=master;Trusted_Connection=True;";
					}
					else
					{
						text = string.Concat(new string[]
						{
							"Server=",
							this.txtServerName.Text,
							";Database=master;User Id=",
							this.txtUsername.Text,
							";Password=",
							this.txtPwd.Text
						});
					}
				}
				else
				{
					bool checked3 = this.CheckBox2.Checked;
					if (checked3)
					{
						bool checked4 = this.CheckBox1.Checked;
						if (checked4)
						{
							text = "Data Source=" + this.txtServerName.Text + "\\SQLEXPRESS;Integrated Security=True;User Instance=False";
						}
						else
						{
							text = string.Concat(new string[]
							{
								"Data Source=",
								this.txtServerName.Text,
								"\\SQLEXPRESS;User Instance=False;User Id=",
								this.txtUsername.Text,
								";Password=",
								this.txtPwd.Text
							});
						}
					}
					else
					{
						bool checked5 = this.CheckBox3.Checked;
						if (checked5)
						{
							text = this.txtConnString.Text;
						}
					}
				}
			}
			return text;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0007F140 File Offset: 0x0007D340
		private void Button3_Click(object sender, EventArgs e)
		{
			this.txtDBName.Text = "";
			this.txtServerName.Text = "";
			this.txtPwd.Text = "";
			this.txtUsername.Text = "";
			this.CheckBox1.Checked = false;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0007F1A0 File Offset: 0x0007D3A0
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				this.txtPwd.Enabled = false;
				this.txtUsername.Enabled = false;
			}
			else
			{
				this.txtPwd.Enabled = true;
				this.txtUsername.Enabled = true;
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0007F1F8 File Offset: 0x0007D3F8
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.DBCreated = false;
				bool flag = this.RunSqlScript("createPOSdb.sql", this.GetconnStringInitial());
				if (flag)
				{
					MessageBox.Show("Database created successfully. Creating database objects now. Press OK.");
					bool flag2 = this.RunSqlScript("FullDB.sql", this.GetConnString());
					if (flag2)
					{
						MessageBox.Show("Databases objects - Tables and Stored Procedures created. Please enter the company name, branch, currency and coid then Click Save.");
						this.txtCoid.Visible = true;
						this.txtBranch.Visible = true;
						this.lblcoid.Visible = true;
						this.lblbranch.Visible = true;
						this.txtconame.Visible = true;
						this.txtcurr.Visible = true;
						this.lblconame.Visible = true;
						this.lblcurr.Visible = true;
					}
				}
				else
				{
					bool dbcreated = this.DBCreated;
					if (dbcreated)
					{
						MessageBox.Show("Database was already created. Creating database objects now. Press OK.");
						bool flag3 = this.RunSqlScript("FullDB.sql", this.GetConnString());
						if (flag3)
						{
							MessageBox.Show("Databases objects - Tables and Stored Procedures created. Please enter the company name, branch, currency and coid then Click Save.");
							this.txtCoid.Visible = true;
							this.txtBranch.Visible = true;
							this.lblcoid.Visible = true;
							this.lblbranch.Visible = true;
							this.txtconame.Visible = true;
							this.txtcurr.Visible = true;
							this.lblconame.Visible = true;
							this.lblcurr.Visible = true;
						}
					}
					MessageBox.Show("Script error.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error has occured while attempting to create the database. Detail: " + ex.Message);
				this.lblmsg.Text = "";
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0007F3CC File Offset: 0x0007D5CC
		private string GetOnlineConnString()
		{
			string text = this.cboOnlineConnString.Text;
			string text2 = "";
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 1213331508U)
			{
				if (num <= 902095622U)
				{
					if (num != 161312274U)
					{
						if (num == 902095622U)
						{
							if (Operators.CompareString(text, "ONLINE TEST", false) == 0)
							{
								text2 = "Data Source=SQL6010.site4now.net;Database =DB_A374C0_POSDEMO;User Id=DB_A374C0_POSDEMO_admin;Password=POS!@123;User Instance=False";
							}
						}
					}
					else if (Operators.CompareString(text, "MNANDI MEATS", false) == 0)
					{
						text2 = "Data Source=SQL6030.site4now.net;Initial Catalog=db_a374c0_mnandi;User Id=db_a374c0_mnandi_admin;Password=POS!@123";
					}
				}
				else if (num != 1098209549U)
				{
					if (num == 1213331508U)
					{
						if (Operators.CompareString(text, "ICLIT TECHNOLOGIES", false) == 0)
						{
							text2 = "Data Source=SQL6010.site4now.net;Database =DB_A54F4E_POSICLIT;User Id=DB_A54F4E_POSICLIT_admin;Password=POS!@123;User Instance=False";
						}
					}
				}
				else if (Operators.CompareString(text, "FARM DISTRIBUTORS", false) == 0)
				{
					text2 = "Data Source=SQL6029.site4now.net;Database =DB_A374C0_POSFD;User Id=DB_A374C0_POSFD_admin;Password=POS!@123;User Instance=False";
				}
			}
			else if (num <= 2123619619U)
			{
				if (num != 1237670605U)
				{
					if (num == 2123619619U)
					{
						if (Operators.CompareString(text, "BBB Furniture", false) == 0)
						{
							text2 = "Data Source=SQL6030.site4now.net;Initial Catalog=DB_A54F4E_BBB;User Id=DB_A54F4E_BBB_admin;Password=POS!@123";
						}
					}
				}
				else if (Operators.CompareString(text, "MANAT WHOLESALERS", false) == 0)
				{
					text2 = "Data Source=SQL6011.site4now.net;Initial Catalog=db_a54f4e_posmanat2;User Id=db_a54f4e_posmanat2_admin;Password=POS!@123";
				}
			}
			else if (num != 3130099441U)
			{
				if (num == 3239088040U)
				{
					if (Operators.CompareString(text, "ZAMHARVEST", false) == 0)
					{
						text2 = "Data Source=SQL6030.site4now.net;Initial Catalog=db_a374c0_zamharvest;User Id=db_a374c0_zamharvest_admin;Password=POS!@123!";
					}
				}
			}
			else if (Operators.CompareString(text, "JEWEL PAINTS", false) == 0)
			{
				text2 = "Data Source=SQL6009.site4now.net;Database =DB_A374C0_POSJEWEL;User Id=DB_A374C0_POSJEWEL_admin;Password=POS!@123;User Instance=False";
			}
			return text2;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0007F548 File Offset: 0x0007D748
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.TestServerConns(this.GetOnlineConnString());
				if (flag)
				{
					MessageBox.Show("Test Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Test was not successful. Edit connection settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while attempting to test connection. Details: " + ex.Message);
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0007F5CC File Offset: 0x0007D7CC
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				string onlineConnString = this.GetOnlineConnString();
				bool flag = this.TestServerConns(onlineConnString);
				if (flag)
				{
					this.AddUpdateAppSettings("SQLServerConnString", onlineConnString);
					MyProject.Forms.Form1.Constring = onlineConnString;
					MessageBox.Show("Successfuly Saved Online Server Connection Data", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					MyProject.Forms.Form1.OnlineSearchOptimised = 1;
					this.AddUpdateAppSettings("OnlineSearchOptimised", Conversions.ToString(1));
					base.Close();
				}
				else
				{
					MessageBox.Show("Connection to Database was not established. Data was not saved.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving connection string. Retry. Detailed error is as follows: " + ex.Message);
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0007F690 File Offset: 0x0007D890
		private void Button7_Click(object sender, EventArgs e)
		{
			string text = "Data Source=SQL6010.site4now.net;Database =DB_A374C0_POSDEMO;User Id=DB_A374C0_POSDEMO_admin;Password=POS!@123;User Instance=False";
			try
			{
				bool flag = this.TestServerConns(text);
				if (flag)
				{
					this.AddUpdateAppSettings("SQLServerConnString", text);
					MyProject.Forms.Form1.Constring = text;
					MessageBox.Show("Successfuly Saved Online Server Connection Data", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					base.Close();
				}
				else
				{
					MessageBox.Show("Connection to Database was not established. Data was not saved.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving connection string. Retry. Detailed error is as follows: " + ex.Message);
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0007F730 File Offset: 0x0007D930
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtOnlinePwd.Text, "", false) != 0;
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.txtOnlinePwd.Text, "POSAdmin123", false) == 0;
					if (flag2)
					{
						this.cboOnlineConnString.Visible = true;
					}
					else
					{
						bool flag3 = Operators.CompareString(this.txtOnlinePwd.Text, "POSAdmin435", false) == 0;
						if (flag3)
						{
							this.cboOnlineConnString.Text = "ZAMHARVEST";
							this.cboOnlineConnString.Visible = true;
							this.cboOnlineConnString.Enabled = false;
							MessageBox.Show("ZamHarvest loaded.");
						}
						else
						{
							bool flag4 = Operators.CompareString(this.txtOnlinePwd.Text, "POSAdminBBB", false) == 0;
							if (flag4)
							{
								this.cboOnlineConnString.Text = "BBB Furniture";
								this.cboOnlineConnString.Visible = true;
								this.cboOnlineConnString.Enabled = false;
								MessageBox.Show("BBB Furniture loaded.");
							}
							else
							{
								MessageBox.Show("Please enter a correct password.");
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Please enter the password first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error viewing. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
		private void Button9_Click(object sender, EventArgs e)
		{
			try
			{
				FileInfo fileInfo = new FileInfo("c:\\Quantum\\fulldb.sql");
				string text = fileInfo.OpenText().ReadToEnd();
				string text2 = text.Replace("GO", "");
				text2 = text2.Replace("USE [POS]", "");
				text2 = text2.Replace("SET ANSI_NULLS ON", "");
				text2 = text2.Replace("SET QUOTED_IDENTIFIER ON", "");
				string text3 = this.GetconnStringInitial();
				SqlConnection sqlConnection = new SqlConnection(text3);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0007F93C File Offset: 0x0007DB3C
		private void Label2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.lblclicks++;
					bool flag = this.lblclicks == 7;
					if (flag)
					{
						this.txtDBName.Enabled = true;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0007F998 File Offset: 0x0007DB98
		private void RunScript()
		{
			string text = File.ReadAllText("c:\\Quantum\\fulldb_20230417.sql");
			text = text.Replace("GO", ";");
			SqlConnection sqlConnection = new SqlConnection(this.GetConnString());
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0007FA1C File Offset: 0x0007DC1C
		private void Button9_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.CheckBox2.Checked;
				string text;
				if (@checked)
				{
					text = this.txtServerName.Text + "\\SQLEXPRESS";
				}
				else
				{
					text = this.txtServerName.Text;
				}
				this.txtscript.Text = this.pf.RunScript_SQLCMD_Script(text, this.txtDBName.Text, this.txtUsername.Text, this.txtPwd.Text, this.CheckBox1.Checked, "C:\\Quantum", "drop_recreatedb.sql");
				MessageBox.Show("Script executed. Check script output.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running script. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002A30 File Offset: 0x00000C30
		private void RunScript2()
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0007FAF4 File Offset: 0x0007DCF4
		private void RunScript_SQLCMD()
		{
			string text = File.OpenText("C:\\Quantum\\fulldb_20230417.sql").ReadToEnd();
			string text2 = this.txtServerName.Text;
			string text3 = this.txtDBName.Text;
			string text4 = text;
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "SQLCMD.EXE";
			process.StartInfo.Arguments = string.Format("-S {0} -d {1} -E -Q {2} -h-1 -s\",\" -w 700", text2, text3, text4);
			process.Start();
			process.WaitForExit();
			MessageBox.Show("done");
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0007FBBC File Offset: 0x0007DDBC
		private void chkOnlineDB_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkOnlineDB.Checked;
				if (@checked)
				{
					this.GroupBox2.Visible = true;
					this.txtOnlinePwd.Focus();
				}
				else
				{
					this.GroupBox2.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0007FC28 File Offset: 0x0007DE28
		private void Button4_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Create Database is used for new installations.", this.Button4);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0007FC70 File Offset: 0x0007DE70
		private void Button9_MouseHover(object sender, EventArgs e)
		{
			try
			{
				this.ToolTip1.Show("Upgrade Database is used for existing installations. Stored procedures are dropped and recreated.", this.Button9);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0007FCB8 File Offset: 0x0007DEB8
		private void Button10_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.GetConnString());
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = this.txtQuery.Text;
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error executing. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0007FD60 File Offset: 0x0007DF60
		private void Button11_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.GetConnString());
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = this.txtQuery.Text;
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				MessageBox.Show("Execution done.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error executing. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0007FE14 File Offset: 0x0007E014
		private void Unzip()
		{
			try
			{
				string text = ".\\SQL2019.zip";
				string text2 = ".\\SQL2019";
				ZipFile.ExtractToDirectory(text, text2);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0007FE5C File Offset: 0x0007E05C
		private void Button12_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.Unzip();
				string text = Environment.CurrentDirectory + "\\SQL2019\\SQL2019";
				string text2 = Environment.SystemDirectory + "\\cmd.exe";
				ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
				Process process = new Process();
				processStartInfo.UseShellExecute = false;
				processStartInfo.WorkingDirectory = text;
				string text3 = string.Format(string.Format("/k setup.exe /qs /IACCEPTSQLSERVERLICENSETERMS /ENU /ACTION=\"Install\" /FEATURES=\"SQLEngine\" /SECURITYMODE=\"SQL\" /INSTANCENAME=\"{0}\" /SAPWD=\"POSAdmin\" /UpdateEnabled=\"False\" ", 0), this.txtDBName.Text);
				processStartInfo.Arguments = text3;
				process.StartInfo = processStartInfo;
				process.Start();
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Done. Check log or attempt log in using SA.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error details: " + ex.Message);
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0007FF44 File Offset: 0x0007E144
		public void RunCMDCom(string command, string arguments, bool permanent)
		{
			new Process
			{
				StartInfo = 
				{
					UseShellExecute = true
				},
				StartInfo = new ProcessStartInfo
				{
					UseShellExecute = true,
					Arguments = string.Concat(new string[]
					{
						" ",
						permanent ? "/K" : "/C",
						" ",
						command,
						" ",
						arguments
					}),
					FileName = "cmd.exe"
				}
			}.Start();
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboOnlineConnString_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0007FFD4 File Offset: 0x0007E1D4
		private bool RunSqlScript(string script_filename, string sqlconstring)
		{
			bool flag;
			try
			{
				string currentDirectory = Environment.CurrentDirectory;
				DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
				FileInfo[] files = directoryInfo.GetFiles(script_filename);
				foreach (FileInfo fileInfo in files)
				{
					FileInfo fileInfo2 = new FileInfo(fileInfo.FullName);
					string text = fileInfo2.OpenText().ReadToEnd();
					string[] array2 = text.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
					using (SqlConnection sqlConnection = new SqlConnection(sqlconstring))
					{
						sqlConnection.Open();
						foreach (string text2 in array2)
						{
							using (SqlCommand sqlCommand = new SqlCommand(text2, sqlConnection))
							{
								sqlCommand.ExecuteNonQuery();
							}
						}
					}
				}
				flag = true;
			}
			catch (Exception ex)
			{
				bool flag2 = Operators.CompareString(ex.Message, "Database 'POS' already exists. Choose a different database name.", false) == 0;
				if (flag2)
				{
					this.DBCreated = true;
				}
				MessageBox.Show("Error running DB Init. Detail: " + ex.Message);
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00080140 File Offset: 0x0007E340
		private bool RunSqlScript1(string script_filename, string sqlconstring)
		{
			bool flag;
			try
			{
				FileInfo fileInfo = new FileInfo(script_filename);
				string directoryName = fileInfo.DirectoryName;
				DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
				FileInfo fileInfo2 = new FileInfo(script_filename);
				string text = fileInfo2.OpenText().ReadToEnd();
				string[] array = text.Split(new string[] { "go" }, StringSplitOptions.RemoveEmptyEntries);
				using (SqlConnection sqlConnection = new SqlConnection(sqlconstring))
				{
					sqlConnection.Open();
					foreach (string text2 in array)
					{
						using (SqlCommand sqlCommand = new SqlCommand(text2, sqlConnection))
						{
							sqlCommand.ExecuteNonQuery();
						}
					}
				}
				flag = true;
			}
			catch (Exception ex)
			{
				bool flag2 = Operators.CompareString(ex.Message, "Database 'POS' already exists. Choose a different database name.", false) == 0;
				if (flag2)
				{
					this.DBCreated = true;
				}
				MessageBox.Show("Error running custom script. Detail: " + ex.Message);
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0008027C File Offset: 0x0007E47C
		private bool IsDBInitialised(object curr_constring)
		{
			SqlConnection sqlConnection = new SqlConnection(Conversions.ToString(curr_constring));
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select count(*) from branches";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return num > 0;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000802E0 File Offset: 0x0007E4E0
		private bool ReplaceCoid_Batch(string script_filename, string scriptDirectory, string thecoid, string thebranch, string theconame, string thecurr)
		{
			bool flag;
			try
			{
				string text = scriptDirectory + "\\" + script_filename;
				string text2 = File.ReadAllText(text);
				text2 = text2.Replace("#999#", thecoid);
				text2 = text2.Replace("#SHOP1#", thebranch);
				text2 = text2.Replace("#curr_R#", thecurr);
				text2 = text2.Replace("#CONAME#", theconame);
				File.WriteAllText(text, text2);
				flag = true;
			}
			catch (Exception ex)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00080368 File Offset: 0x0007E568
		private void Button13_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					string fileName = this.OpenFileDialog1.FileName;
					bool flag2 = this.RunSqlScript1(fileName, this.GetConnString());
					if (flag2)
					{
						MessageBox.Show("Script successfully run.");
					}
					else
					{
						MessageBox.Show("Error.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running script. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400061F RID: 1567
		private int lblclicks;

		// Token: 0x04000620 RID: 1568
		private PublicFunctions pf;

		// Token: 0x04000621 RID: 1569
		private bool DBCreated;
	}
}
