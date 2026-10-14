namespace PointOfSale
{
	// Token: 0x020001BE RID: 446
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SendSmS : global::System.Windows.Forms.Form
	{
		// Token: 0x0600505C RID: 20572 RVA: 0x002FF188 File Offset: 0x002FD388
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

		// Token: 0x0600505D RID: 20573 RVA: 0x002FF1D8 File Offset: 0x002FD3D8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PointOfSale.SendSmS));
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvCustomers = new global::System.Windows.Forms.DataGridView();
			this.lblwordcount = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtSubject = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtTextMsg = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCustomers).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.lblwordcount);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtSubject);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtTextMsg);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(940, 263);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.dgvCustomers.AllowUserToAddRows = false;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomers.Location = new global::System.Drawing.Point(0, 263);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.Size = new global::System.Drawing.Size(940, 228);
			this.dgvCustomers.TabIndex = 1;
			this.lblwordcount.AutoSize = true;
			this.lblwordcount.Location = new global::System.Drawing.Point(515, 156);
			this.lblwordcount.Name = "lblwordcount";
			this.lblwordcount.Size = new global::System.Drawing.Size(16, 13);
			this.lblwordcount.TabIndex = 27;
			this.lblwordcount.Text = "...";
			this.Button4.Location = new global::System.Drawing.Point(515, 112);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(163, 23);
			this.Button4.TabIndex = 26;
			this.Button4.Text = "Add [CompanyName] Template";
			this.Button4.UseVisualStyleBackColor = true;
			this.Button3.Location = new global::System.Drawing.Point(515, 83);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(163, 23);
			this.Button3.TabIndex = 25;
			this.Button3.Text = "Add [ContactName] Template";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label1.ForeColor = global::System.Drawing.Color.Red;
			this.Label1.Location = new global::System.Drawing.Point(109, 172);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(398, 40);
			this.Label1.TabIndex = 24;
			this.Label1.Text = componentResourceManager.GetString("Label1.Text");
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(46, 53);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(60, 13);
			this.Label2.TabIndex = 23;
			this.Label2.Text = "Reference:";
			this.txtSubject.Location = new global::System.Drawing.Point(112, 50);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new global::System.Drawing.Size(397, 20);
			this.txtSubject.TabIndex = 22;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.Location = new global::System.Drawing.Point(684, 85);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(228, 50);
			this.Button2.TabIndex = 21;
			this.Button2.Text = "SEND SMSs";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(28, 85);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(78, 13);
			this.Label4.TabIndex = 20;
			this.Label4.Text = "Compose Text:";
			this.txtTextMsg.Location = new global::System.Drawing.Point(112, 76);
			this.txtTextMsg.MaxLength = 254;
			this.txtTextMsg.Multiline = true;
			this.txtTextMsg.Name = "txtTextMsg";
			this.txtTextMsg.Size = new global::System.Drawing.Size(397, 93);
			this.txtTextMsg.TabIndex = 19;
			this.txtTextMsg.Text = "Good day [ContactName]\r\n\r\nWe have a promotion running on some items and your company [CompanyName] could benefit from it. Thank you.";
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(112, 19);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(165, 23);
			this.Button1.TabIndex = 28;
			this.Button1.Text = "VIEW CUSTOMER LIST";
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(940, 491);
			base.Controls.Add(this.dgvCustomers);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SendSmS";
			this.Text = "Send SMS";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCustomers).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040023E3 RID: 9187
		private global::System.ComponentModel.IContainer components;
	}
}
