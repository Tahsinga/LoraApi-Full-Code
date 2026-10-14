using System;
using System.Collections.Generic;
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
	// Token: 0x0200002F RID: 47
	[DesignerGenerated]
	public partial class ConvertProduct : UserControl
	{
		// Token: 0x0600090B RID: 2315 RVA: 0x00056C34 File Offset: 0x00054E34
		public ConvertProduct()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00059642 File Offset: 0x00057842
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0005964C File Offset: 0x0005784C
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00059655 File Offset: 0x00057855
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0005965F File Offset: 0x0005785F
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00059668 File Offset: 0x00057868
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00059672 File Offset: 0x00057872
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0005967B File Offset: 0x0005787B
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00059685 File Offset: 0x00057885
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0005968E File Offset: 0x0005788E
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00059698 File Offset: 0x00057898
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x000596A1 File Offset: 0x000578A1
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000596AB File Offset: 0x000578AB
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x000596B4 File Offset: 0x000578B4
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x000596C0 File Offset: 0x000578C0
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00059703 File Offset: 0x00057903
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0005970D File Offset: 0x0005790D
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00059716 File Offset: 0x00057916
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00059720 File Offset: 0x00057920
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00059729 File Offset: 0x00057929
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00059734 File Offset: 0x00057934
		internal virtual Button cmdSelect
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSelect;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cmdSelect_Click);
				Button button = this._cmdSelect;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdSelect = value;
				button = this._cmdSelect;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00059777 File Offset: 0x00057977
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00059781 File Offset: 0x00057981
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0005978A File Offset: 0x0005798A
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00059794 File Offset: 0x00057994
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0005979D File Offset: 0x0005799D
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x000597A7 File Offset: 0x000579A7
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x000597B0 File Offset: 0x000579B0
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x000597BA File Offset: 0x000579BA
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x000597C3 File Offset: 0x000579C3
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x000597CD File Offset: 0x000579CD
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x000597D6 File Offset: 0x000579D6
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x000597E0 File Offset: 0x000579E0
		internal virtual DataGridView DGVSearch
		{
			[CompilerGenerated]
			get
			{
				return this._DGVSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00059823 File Offset: 0x00057A23
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0005982D File Offset: 0x00057A2D
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00059836 File Offset: 0x00057A36
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00059840 File Offset: 0x00057A40
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00059883 File Offset: 0x00057A83
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0005988D File Offset: 0x00057A8D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00059896 File Offset: 0x00057A96
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000598A0 File Offset: 0x00057AA0
		internal virtual TextBox txtsearch
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch_TextChanged);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x000598E3 File Offset: 0x00057AE3
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x000598ED File Offset: 0x00057AED
		internal virtual TextBox txtSearchProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x000598F6 File Offset: 0x00057AF6
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00059900 File Offset: 0x00057B00
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00059909 File Offset: 0x00057B09
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00059913 File Offset: 0x00057B13
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0005991C File Offset: 0x00057B1C
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00059926 File Offset: 0x00057B26
		internal virtual TextBox txtProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0005992F File Offset: 0x00057B2F
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00059939 File Offset: 0x00057B39
		internal virtual TextBox txtProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00059942 File Offset: 0x00057B42
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0005994C File Offset: 0x00057B4C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00059955 File Offset: 0x00057B55
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x0005995F File Offset: 0x00057B5F
		internal virtual TextBox txtQtyAvailable
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00059968 File Offset: 0x00057B68
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00059972 File Offset: 0x00057B72
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0005997B File Offset: 0x00057B7B
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00059985 File Offset: 0x00057B85
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0005998E File Offset: 0x00057B8E
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00059998 File Offset: 0x00057B98
		internal virtual CheckBox chkInclFinalProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x000599A1 File Offset: 0x00057BA1
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x000599AB File Offset: 0x00057BAB
		internal virtual TextBox txtSearchProductCode2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x000599B4 File Offset: 0x00057BB4
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x000599BE File Offset: 0x00057BBE
		internal virtual Label lblcode2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000599C7 File Offset: 0x00057BC7
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x000599D1 File Offset: 0x00057BD1
		internal virtual Label lblerror2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x000599DA File Offset: 0x00057BDA
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x000599E4 File Offset: 0x00057BE4
		internal virtual Button cmdAddIngridient
		{
			[CompilerGenerated]
			get
			{
				return this._cmdAddIngridient;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cmdAddIngridient_Click);
				Button button = this._cmdAddIngridient;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdAddIngridient = value;
				button = this._cmdAddIngridient;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00059A27 File Offset: 0x00057C27
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00059A31 File Offset: 0x00057C31
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00059A3A File Offset: 0x00057C3A
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00059A44 File Offset: 0x00057C44
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00059A4D File Offset: 0x00057C4D
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00059A57 File Offset: 0x00057C57
		internal virtual TextBox txtBarCode2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00059A60 File Offset: 0x00057C60
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00059A6A File Offset: 0x00057C6A
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00059A73 File Offset: 0x00057C73
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00059A7D File Offset: 0x00057C7D
		internal virtual TextBox txtStockAvail2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00059A86 File Offset: 0x00057C86
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00059A90 File Offset: 0x00057C90
		internal virtual TextBox txtDesc2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00059A99 File Offset: 0x00057C99
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00059AA3 File Offset: 0x00057CA3
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00059AAC File Offset: 0x00057CAC
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00059AB6 File Offset: 0x00057CB6
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00059ABF File Offset: 0x00057CBF
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00059ACC File Offset: 0x00057CCC
		internal virtual DataGridView dgvSearch2
		{
			[CompilerGenerated]
			get
			{
				return this._dgvSearch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.dgvSearch2_KeyDown);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvSearch2_CellEnter);
				DataGridView dataGridView = this._dgvSearch2;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._dgvSearch2 = value;
				dataGridView = this._dgvSearch2;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00059B2A File Offset: 0x00057D2A
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00059B34 File Offset: 0x00057D34
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00059B3D File Offset: 0x00057D3D
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00059B48 File Offset: 0x00057D48
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00059B8B File Offset: 0x00057D8B
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00059B95 File Offset: 0x00057D95
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00059B9E File Offset: 0x00057D9E
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00059BA8 File Offset: 0x00057DA8
		internal virtual TextBox txtsearch2
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch2_TextChanged);
				TextBox textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch2 = value;
				textBox = this._txtsearch2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00059BEB File Offset: 0x00057DEB
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00059BF5 File Offset: 0x00057DF5
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00059BFE File Offset: 0x00057DFE
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00059C08 File Offset: 0x00057E08
		internal virtual TextBox txtQtyToBeConverted
		{
			[CompilerGenerated]
			get
			{
				return this._txtQtyToBeConverted;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQtyToBeConverted_KeyPress);
				TextBox textBox = this._txtQtyToBeConverted;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQtyToBeConverted = value;
				textBox = this._txtQtyToBeConverted;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00059C4B File Offset: 0x00057E4B
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00059C55 File Offset: 0x00057E55
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00059C5E File Offset: 0x00057E5E
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00059C68 File Offset: 0x00057E68
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00059C71 File Offset: 0x00057E71
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00059C7B File Offset: 0x00057E7B
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00059C84 File Offset: 0x00057E84
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00059C8E File Offset: 0x00057E8E
		internal virtual TextBox TextBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00059C98 File Offset: 0x00057E98
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00059D20 File Offset: 0x00057F20
		private void SearchByDescAdvanced(string searchtext)
		{
			string[] array = searchtext.Split(new char[] { ' ' });
			int num = 1;
			DataTable dataTable = new DataTable();
			checked
			{
				foreach (string text in array)
				{
					bool flag = num == 1;
					if (flag)
					{
						dataTable = this.searchDB(text, new int?(0));
					}
					else
					{
						DataTable dataTable2 = new DataTable();
						dataTable2 = (DataTable)this.searchDat(dataTable, "ProductDesc", text);
						dataTable = dataTable2;
					}
					num++;
				}
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
				{
					this.DGVSearch.DataSource = dataTable;
					this.DGVSearch.Columns["ProductCode"].Visible = false;
					this.DGVSearch.Columns["ProductID"].Visible = false;
					this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					this.lblerror.Text = "No products match your search.";
				}
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00059E30 File Offset: 0x00058030
		private object searchDat(DataTable dt, string column, string value)
		{
			ConvertProduct._Closure$__227-0 CS$<>8__locals1 = new ConvertProduct._Closure$__227-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((ConvertProduct._Closure$__.$I227-0 == null) ? (ConvertProduct._Closure$__.$I227-0 = (object row1) => (DataRow)row1) : ConvertProduct._Closure$__.$I227-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
				{
					dataTable.ImportRow(dataRow);
				}
			}
			finally
			{
				IEnumerator<DataRow> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00059F0C File Offset: 0x0005810C
		private DataTable searchDB(string searchtext, int? isingridient)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", isingridient);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00059FAC File Offset: 0x000581AC
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0005A00C File Offset: 0x0005820C
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DGVSearch.Columns["CatDesc"].Visible = false;
				this.DGVSearch.Columns["Reorder_Level"].Visible = false;
				this.DGVSearch.Columns["Unit_Selling_Price"].Visible = false;
				this.DGVSearch.Columns["Unit_Cost"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0005A1FC File Offset: 0x000583FC
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0005A2C0 File Offset: 0x000584C0
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0005A368 File Offset: 0x00058568
		private void SearchProductCode(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentDesc = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0005A4D0 File Offset: 0x000586D0
		private decimal GetStockAvailable(int productid)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TotalStockIn";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0;
				}
				sqlConnection.Close();
			}
			int num3 = 0;
			SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
			SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "TotalStockOut";
			sqlCommand2.Parameters.AddWithValue("productid", productid);
			sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand2.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable2 = new DataTable();
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			using (sqlConnection3)
			{
				sqlConnection3.Open();
				int num4 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num4 > 0;
				if (flag2)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2[0])), 0, RuntimeHelpers.GetObjectValue(dataRow2[0])));
				}
				else
				{
					num3 = 0;
				}
				sqlConnection3.Close();
			}
			decimal num5 = new decimal(checked(num - num3));
			return num5;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0005A73C File Offset: 0x0005893C
		private void cmdSelect_Click(object sender, EventArgs e)
		{
			try
			{
				this.txtProductDesc.Text = this.CurrentDesc;
				this.txtProductCode.Text = this.CurrentCode;
				this.txtQtyAvailable.Text = this.txtStockAvail.Text;
				this.TabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading second tab. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0005A7CC File Offset: 0x000589CC
		private void txtQtyToBeConverted_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.CurrentUOM, "EA", false) == 0;
				if (flag)
				{
					e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
				}
				else
				{
					e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0005A87C File Offset: 0x00058A7C
		private void txtsearch2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced2(this.txtsearch2.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0005A904 File Offset: 0x00058B04
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts2();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0005A964 File Offset: 0x00058B64
		private void dgvSearch2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtQtyToBeConverted.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0005A9C4 File Offset: 0x00058BC4
		private void dgvSearch2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.dgvSearch2.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode2.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror2.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0005AA88 File Offset: 0x00058C88
		private void SearchByDescAdvanced2(string searchtext)
		{
			string[] array = searchtext.Split(new char[] { ' ' });
			int num = 1;
			DataTable dataTable = new DataTable();
			checked
			{
				foreach (string text in array)
				{
					bool flag = num == 1;
					if (flag)
					{
						bool @checked = this.chkInclFinalProducts.Checked;
						if (@checked)
						{
							dataTable = this.searchDB(text, null);
						}
						else
						{
							dataTable = this.searchDB(text, new int?(1));
						}
					}
					else
					{
						DataTable dataTable2 = new DataTable();
						dataTable2 = (DataTable)this.searchDat(dataTable, "ProductDesc", text);
						dataTable = dataTable2;
					}
					num++;
				}
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
				{
					this.dgvSearch2.DataSource = dataTable;
					this.dgvSearch2.Columns["ProductCode"].Visible = false;
					this.dgvSearch2.Columns["ProductID"].Visible = false;
					this.dgvSearch2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					this.lblerror2.Text = "No products match your search.";
				}
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0005ABC4 File Offset: 0x00058DC4
		private void FetchAllProducts2()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			bool @checked = this.chkInclFinalProducts.Checked;
			if (@checked)
			{
				sqlCommand.Parameters.AddWithValue("isingridient", null);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("isingridient", 1);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvSearch2.DataSource = dataTable;
				this.dgvSearch2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvSearch2.Columns["CatDesc"].Visible = false;
				this.dgvSearch2.Columns["Reorder_Level"].Visible = false;
				this.dgvSearch2.Columns["Unit_Selling_Price"].Visible = false;
				this.dgvSearch2.Columns["Unit_Cost"].Visible = false;
				this.dgvSearch2.Columns["ProductID"].Visible = false;
				this.dgvSearch2.Columns["ProductCode"].Visible = false;
				this.dgvSearch2.Columns["Tax_Percentage"].Visible = false;
				this.dgvSearch2.Columns["Bin_Location"].Visible = false;
				this.dgvSearch2.Columns["Unit_of_Measure"].Visible = false;
				this.dgvSearch2.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror2.Text = "No products match your search.";
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cmdAddIngridient_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000472 RID: 1138
		private string _cnn;

		// Token: 0x04000473 RID: 1139
		private int CurrentID;

		// Token: 0x04000474 RID: 1140
		private string CurrentCode;

		// Token: 0x04000475 RID: 1141
		private string CurrentDesc;

		// Token: 0x04000476 RID: 1142
		private int CurrentID2;

		// Token: 0x04000477 RID: 1143
		private string CurrentCode2;

		// Token: 0x04000478 RID: 1144
		private string CurrentDesc2;

		// Token: 0x04000479 RID: 1145
		private string CurrentUOM;

		// Token: 0x0400047A RID: 1146
		private string CurrentUOM2;
	}
}
