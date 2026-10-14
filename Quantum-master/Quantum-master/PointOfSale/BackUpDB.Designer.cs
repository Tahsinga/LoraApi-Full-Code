namespace PointOfSale
{
	// Token: 0x02000011 RID: 17
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BackUpDB : global::System.Windows.Forms.Form
	{
		// Token: 0x060002DC RID: 732 RVA: 0x00019D6C File Offset: 0x00017F6C
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

		// Token: 0x060002DD RID: 733 RVA: 0x00019DBC File Offset: 0x00017FBC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.txtFilename = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtFolderPath = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.FolderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.txtDBName = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.txtFilename.Location = new global::System.Drawing.Point(147, 102);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new global::System.Drawing.Size(281, 20);
			this.txtFilename.TabIndex = 15;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(20, 105);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(121, 13);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "Enter the backup name:";
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 239);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(526, 23);
			this.ProgressBar1.TabIndex = 13;
			this.ProgressBar1.Visible = false;
			this.Button2.Location = new global::System.Drawing.Point(311, 128);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(117, 23);
			this.Button2.TabIndex = 12;
			this.Button2.Text = "Back Up Now";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(30, 76);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(111, 13);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Select back up folder:";
			this.txtFolderPath.Enabled = false;
			this.txtFolderPath.Location = new global::System.Drawing.Point(147, 76);
			this.txtFolderPath.Name = "txtFolderPath";
			this.txtFolderPath.Size = new global::System.Drawing.Size(242, 20);
			this.txtFolderPath.TabIndex = 10;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(30, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(180, 17);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Back up Fees Database";
			this.Button1.Location = new global::System.Drawing.Point(395, 76);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(33, 23);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "...";
			this.Button1.UseVisualStyleBackColor = true;
			this.txtDBName.Location = new global::System.Drawing.Point(147, 50);
			this.txtDBName.Name = "txtDBName";
			this.txtDBName.Size = new global::System.Drawing.Size(169, 20);
			this.txtDBName.TabIndex = 16;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(54, 53);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(87, 13);
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Database Name:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(526, 262);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.txtDBName);
			base.Controls.Add(this.txtFilename);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.txtFolderPath);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Button1);
			base.MaximizeBox = false;
			base.Name = "BackUpDB";
			this.Text = "Back Up Database";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400013C RID: 316
		private global::System.ComponentModel.IContainer components;
	}
}
