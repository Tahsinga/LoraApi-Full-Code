namespace PointOfSale
{
	// Token: 0x0200020A RID: 522
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Videos : global::System.Windows.Forms.Form
	{
		// Token: 0x06005DF5 RID: 24053 RVA: 0x0035D3B8 File Offset: 0x0035B5B8
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x0035D408 File Offset: 0x0035B608
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PointOfSale.Videos));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.LinkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.lbltuckshop = new global::System.Windows.Forms.Label();
			this.cboShopVideos = new global::System.Windows.Forms.ComboBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.AxWindowsMediaPlayer1 = new global::AxWMPLib.AxWindowsMediaPlayer();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.AxWindowsMediaPlayer1).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.LinkLabel1);
			this.Panel1.Controls.Add(this.lblinfo);
			this.Panel1.Controls.Add(this.lbltuckshop);
			this.Panel1.Controls.Add(this.cboShopVideos);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(833, 81);
			this.Panel1.TabIndex = 0;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new global::System.Drawing.Point(36, 9);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new global::System.Drawing.Size(507, 13);
			this.LinkLabel1.TabIndex = 6;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Click here to visit the Quantum Business Solutions YouTube channel for the latest How to Training Videos.";
			this.lblinfo.AutoSize = true;
			this.lblinfo.Location = new global::System.Drawing.Point(159, 53);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(16, 13);
			this.lblinfo.TabIndex = 4;
			this.lblinfo.Text = "...";
			this.lbltuckshop.AutoSize = true;
			this.lbltuckshop.Location = new global::System.Drawing.Point(34, 32);
			this.lbltuckshop.Name = "lbltuckshop";
			this.lbltuckshop.Size = new global::System.Drawing.Size(122, 13);
			this.lbltuckshop.TabIndex = 1;
			this.lbltuckshop.Text = "Select a video to watch:";
			this.cboShopVideos.FormattingEnabled = true;
			this.cboShopVideos.Items.AddRange(new object[] { "How to configure General Settings ", "Entering New Stock Purchases", "How to conduct a Stock Take", "How to View Product IDs or Product Codes", "How to enter a Sale", "How to Cancel a Sale", "How to Run Reports", "View Product Movement", "Edit Product Details- cost price, selling price, reorder level, desc" });
			this.cboShopVideos.Location = new global::System.Drawing.Point(162, 29);
			this.cboShopVideos.Name = "cboShopVideos";
			this.cboShopVideos.Size = new global::System.Drawing.Size(352, 21);
			this.cboShopVideos.TabIndex = 0;
			this.Panel2.Controls.Add(this.AxWindowsMediaPlayer1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 81);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(833, 271);
			this.Panel2.TabIndex = 1;
			this.AxWindowsMediaPlayer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AxWindowsMediaPlayer1.Enabled = true;
			this.AxWindowsMediaPlayer1.Location = new global::System.Drawing.Point(0, 0);
			this.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1";
			this.AxWindowsMediaPlayer1.OcxState = (global::System.Windows.Forms.AxHost.State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState");
			this.AxWindowsMediaPlayer1.Size = new global::System.Drawing.Size(833, 271);
			this.AxWindowsMediaPlayer1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(833, 352);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.Name = "Videos";
			this.Text = "Videos";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.AxWindowsMediaPlayer1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002919 RID: 10521
		private global::System.ComponentModel.IContainer components;
	}
}
