using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;
using WMPLib;

namespace PointOfSale
{
	// Token: 0x0200020A RID: 522
	[DesignerGenerated]
	public partial class Videos : Form
	{
		// Token: 0x06005DF4 RID: 24052 RVA: 0x0035D398 File Offset: 0x0035B598
		public Videos()
		{
			base.Load += this.Videos_Load;
			this.InitializeComponent();
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x0035D8F4 File Offset: 0x0035BAF4
		// (set) Token: 0x06005DF8 RID: 24056 RVA: 0x0035D8FE File Offset: 0x0035BAFE
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06005DF9 RID: 24057 RVA: 0x0035D907 File Offset: 0x0035BB07
		// (set) Token: 0x06005DFA RID: 24058 RVA: 0x0035D911 File Offset: 0x0035BB11
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06005DFB RID: 24059 RVA: 0x0035D91A File Offset: 0x0035BB1A
		// (set) Token: 0x06005DFC RID: 24060 RVA: 0x0035D924 File Offset: 0x0035BB24
		internal virtual Label lbltuckshop
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x0035D92D File Offset: 0x0035BB2D
		// (set) Token: 0x06005DFE RID: 24062 RVA: 0x0035D938 File Offset: 0x0035BB38
		internal virtual ComboBox cboShopVideos
		{
			[CompilerGenerated]
			get
			{
				return this._cboShopVideos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboShopVideos_SelectedIndexChanged);
				ComboBox comboBox = this._cboShopVideos;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboShopVideos = value;
				comboBox = this._cboShopVideos;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06005DFF RID: 24063 RVA: 0x0035D97B File Offset: 0x0035BB7B
		// (set) Token: 0x06005E00 RID: 24064 RVA: 0x0035D985 File Offset: 0x0035BB85
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x06005E01 RID: 24065 RVA: 0x0035D98E File Offset: 0x0035BB8E
		// (set) Token: 0x06005E02 RID: 24066 RVA: 0x0035D998 File Offset: 0x0035BB98
		internal virtual AxWindowsMediaPlayer AxWindowsMediaPlayer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x06005E03 RID: 24067 RVA: 0x0035D9A1 File Offset: 0x0035BBA1
		// (set) Token: 0x06005E04 RID: 24068 RVA: 0x0035D9AC File Offset: 0x0035BBAC
		internal virtual LinkLabel LinkLabel1
		{
			[CompilerGenerated]
			get
			{
				return this._LinkLabel1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				LinkLabel linkLabel = this._LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel1 = value;
				linkLabel = this._LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x0035D9F0 File Offset: 0x0035BBF0
		private void cboShopVideos_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				switch (this.cboShopVideos.SelectedIndex)
				{
				case 0:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\General Setup.wmv";
					break;
				case 1:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\New Stock Purchases.mp4";
					break;
				case 2:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\Stock Take.mp4";
					break;
				case 3:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\ProductID.mp4";
					break;
				case 4:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\Sales.mp4";
					break;
				case 5:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\CancelSale.mp4";
					break;
				case 6:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\Reports.mp4";
					break;
				case 7:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\ProductMovement.mp4";
					break;
				case 8:
					this.AxWindowsMediaPlayer1.URL = "C:\\POSVideos\\ChangeProductDetails.mp4";
					break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error playing video file.");
			}
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x0035DB24 File Offset: 0x0035BD24
		private void AxWindowsMediaPlayer1_MediaError(object sender, _WMPOCXEvents_MediaErrorEvent e)
		{
			try
			{
				IWMPMedia2 iwmpmedia = (IWMPMedia2)e.pMediaObject;
				IWMPErrorItem error = iwmpmedia.Error;
				MessageBox.Show("Media error " + error.errorCode.ToString("X") + " in " + iwmpmedia.sourceURL);
			}
			catch (InvalidCastException ex)
			{
				MessageBox.Show("Player error");
			}
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x0035DBA4 File Offset: 0x0035BDA4
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("https://www.youtube.com/channel/UCUmux9t8OLwi4EVKQFTreYQ");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying training videos link. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Videos_Load(object sender, EventArgs e)
		{
		}
	}
}
