namespace PointOfSale
{
	// Token: 0x0200004A RID: 74
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditBatchNumber : global::System.Windows.Forms.Form
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x00095104 File Offset: 0x00093304
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

		// Token: 0x06000FBF RID: 4031 RVA: 0x00095154 File Offset: 0x00093354
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.lbloldbatchnumber = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lbloldexpirydate = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtNewBatchNum = new global::System.Windows.Forms.TextBox();
			this.DTNewExpDate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.lbloldexpirydate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.lbloldbatchnumber);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(529, 119);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Current Details:";
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Controls.Add(this.DTNewExpDate);
			this.GroupBox2.Controls.Add(this.txtNewBatchNum);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 119);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(529, 170);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "NEW Details:";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(72, 41);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(115, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Batch Number:";
			this.lbloldbatchnumber.AutoSize = true;
			this.lbloldbatchnumber.Location = new global::System.Drawing.Point(204, 41);
			this.lbloldbatchnumber.Name = "lbloldbatchnumber";
			this.lbloldbatchnumber.Size = new global::System.Drawing.Size(21, 20);
			this.lbloldbatchnumber.TabIndex = 1;
			this.lbloldbatchnumber.Text = "...";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(93, 73);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(94, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Expiry Date:";
			this.lbloldexpirydate.AutoSize = true;
			this.lbloldexpirydate.Location = new global::System.Drawing.Point(204, 73);
			this.lbloldexpirydate.Name = "lbloldexpirydate";
			this.lbloldexpirydate.Size = new global::System.Drawing.Size(21, 20);
			this.lbloldexpirydate.TabIndex = 3;
			this.lbloldexpirydate.Text = "...";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(93, 81);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(94, 20);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Expiry Date:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(72, 49);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(115, 20);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Batch Number:";
			this.txtNewBatchNum.Location = new global::System.Drawing.Point(208, 46);
			this.txtNewBatchNum.Name = "txtNewBatchNum";
			this.txtNewBatchNum.Size = new global::System.Drawing.Size(281, 26);
			this.txtNewBatchNum.TabIndex = 5;
			this.DTNewExpDate.Location = new global::System.Drawing.Point(208, 81);
			this.DTNewExpDate.Name = "DTNewExpDate";
			this.DTNewExpDate.Size = new global::System.Drawing.Size(281, 26);
			this.DTNewExpDate.TabIndex = 6;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.FromArgb(64, 0, 64);
			this.Button1.Location = new global::System.Drawing.Point(208, 113);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(281, 31);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "SAVE CHANGES";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(529, 289);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EditBatchNumber";
			this.Text = "Edit Batch Number";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000787 RID: 1927
		private global::System.ComponentModel.IContainer components;
	}
}
