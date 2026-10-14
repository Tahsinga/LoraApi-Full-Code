namespace PointOfSale
{
	// Token: 0x02000089 RID: 137
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PaymentMethods : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F5A RID: 8026 RVA: 0x00117DCC File Offset: 0x00115FCC
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

		// Token: 0x06001F5B RID: 8027 RVA: 0x00117E1C File Offset: 0x0011601C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PointOfSale.PaymentMethods));
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.chkDisplayRate = new global::System.Windows.Forms.CheckBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.cboDisplayRate = new global::System.Windows.Forms.ComboBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboChange = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.chkDisplayRate);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.cboDisplayRate);
			this.GroupBox1.Controls.Add(this.PictureBox1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboChange);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1250, 410);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label8.Location = new global::System.Drawing.Point(962, 25);
			this.Label8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(270, 148);
			this.Label8.TabIndex = 15;
			this.Label8.Text = "Eltrade Currency IDs\r\n\r\n1 - ZWD\r\n2 - USD\r\n3 - ZAR";
			this.chkDisplayRate.AutoSize = true;
			this.chkDisplayRate.Location = new global::System.Drawing.Point(468, 376);
			this.chkDisplayRate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkDisplayRate.Name = "chkDisplayRate";
			this.chkDisplayRate.Size = new global::System.Drawing.Size(345, 24);
			this.chkDisplayRate.TabIndex = 14;
			this.chkDisplayRate.Text = "Use this rate for receipt displayed amounts?";
			this.chkDisplayRate.UseVisualStyleBackColor = true;
			this.chkDisplayRate.Visible = false;
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(33, 378);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(243, 20);
			this.Label7.TabIndex = 13;
			this.Label7.Text = "Receipt display payment method:";
			this.cboDisplayRate.FormattingEnabled = true;
			this.cboDisplayRate.Location = new global::System.Drawing.Point(280, 373);
			this.cboDisplayRate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboDisplayRate.Name = "cboDisplayRate";
			this.cboDisplayRate.Size = new global::System.Drawing.Size(180, 28);
			this.cboDisplayRate.TabIndex = 12;
			this.cboDisplayRate.Visible = false;
			this.PictureBox1.Image = global::PointOfSale.My.Resources.Resources.refresh;
			this.PictureBox1.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.InitialImage");
			this.PictureBox1.Location = new global::System.Drawing.Point(468, 325);
			this.PictureBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(51, 43);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 11;
			this.PictureBox1.TabStop = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(33, 336);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(188, 20);
			this.Label6.TabIndex = 9;
			this.Label6.Text = "Default payment method:";
			this.cboChange.FormattingEnabled = true;
			this.cboChange.Location = new global::System.Drawing.Point(280, 332);
			this.cboChange.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboChange.Name = "cboChange";
			this.cboChange.Size = new global::System.Drawing.Size(180, 28);
			this.cboChange.TabIndex = 8;
			this.Label5.Location = new global::System.Drawing.Point(637, 25);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(315, 291);
			this.Label5.TabIndex = 7;
			this.Label5.Text = componentResourceManager.GetString("Label5.Text");
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(18, 185);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(523, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "QuantumPOS will divide the amount entered by the rate amount set here.";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(18, 145);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(384, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "*If USD$1 equal  to Euro1 then set rate to 1 for Euro.";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(18, 108);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(402, 20);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "*If USD$1 equal to ZAR10 then set rate to 10 for Rand.";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(58, 25);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(318, 32);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Enter Payment Methods";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(660, 321);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(141, 35);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Save Changes";
			this.Button1.UseVisualStyleBackColor = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 410);
			this.DataGridView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new global::System.Drawing.Size(1250, 446);
			this.DataGridView1.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1250, 856);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "PaymentMethods";
			this.Text = "Payment Methods";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000EE6 RID: 3814
		private global::System.ComponentModel.IContainer components;
	}
}
