namespace PointOfSale
{
	// Token: 0x020001BA RID: 442
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelectMNO : global::System.Windows.Forms.Form
	{
		// Token: 0x06004FEA RID: 20458 RVA: 0x002FBB00 File Offset: 0x002F9D00
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

		// Token: 0x06004FEB RID: 20459 RVA: 0x002FBB50 File Offset: 0x002F9D50
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TabControl1 = new global::System.Windows.Forms.TabControl();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.cmdNetone = new global::System.Windows.Forms.Button();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtNetoneAirtime = new global::System.Windows.Forms.TextBox();
			this.TabPage3 = new global::System.Windows.Forms.TabPage();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.TabPage4 = new global::System.Windows.Forms.TabPage();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.TabPage4.SuspendLayout();
			base.SuspendLayout();
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new global::System.Drawing.Size(705, 262);
			this.TabControl1.TabIndex = 0;
			this.TabPage1.Controls.Add(this.Button3);
			this.TabPage1.Controls.Add(this.Button2);
			this.TabPage1.Controls.Add(this.cmdNetone);
			this.TabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new global::System.Drawing.Size(697, 236);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "SELECT";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.Button3.Enabled = false;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(478, 62);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(172, 98);
			this.Button3.TabIndex = 3;
			this.Button3.Text = "TELECEL";
			this.Button3.UseVisualStyleBackColor = true;
			this.Button2.Enabled = false;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.Location = new global::System.Drawing.Point(252, 62);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(172, 98);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "ECONET";
			this.Button2.UseVisualStyleBackColor = true;
			this.cmdNetone.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cmdNetone.Location = new global::System.Drawing.Point(18, 62);
			this.cmdNetone.Name = "cmdNetone";
			this.cmdNetone.Size = new global::System.Drawing.Size(172, 98);
			this.cmdNetone.TabIndex = 1;
			this.cmdNetone.Text = "NETONE";
			this.cmdNetone.UseVisualStyleBackColor = true;
			this.TabPage2.Controls.Add(this.Button1);
			this.TabPage2.Controls.Add(this.Label1);
			this.TabPage2.Controls.Add(this.txtNetoneAirtime);
			this.TabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new global::System.Drawing.Size(697, 236);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "NETONE";
			this.TabPage2.UseVisualStyleBackColor = true;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(463, 101);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(120, 32);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "ENTER";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(70, 104);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(239, 26);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Enter Airtime Required:";
			this.txtNetoneAirtime.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNetoneAirtime.Location = new global::System.Drawing.Point(345, 101);
			this.txtNetoneAirtime.Name = "txtNetoneAirtime";
			this.txtNetoneAirtime.Size = new global::System.Drawing.Size(100, 32);
			this.txtNetoneAirtime.TabIndex = 0;
			this.TabPage3.Controls.Add(this.Label2);
			this.TabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new global::System.Drawing.Size(697, 236);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "ECONET";
			this.TabPage3.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(227, 108);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(216, 26);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "NOT YET ENABLED";
			this.TabPage4.Controls.Add(this.Label3);
			this.TabPage4.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Size = new global::System.Drawing.Size(697, 236);
			this.TabPage4.TabIndex = 3;
			this.TabPage4.Text = "TELECEL";
			this.TabPage4.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(240, 105);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(216, 26);
			this.Label3.TabIndex = 1;
			this.Label3.Text = "NOT YET ENABLED";
			base.AcceptButton = this.cmdNetone;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(705, 262);
			base.Controls.Add(this.TabControl1);
			base.Name = "SelectMNO";
			this.Text = "Select MNO";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.TabPage4.ResumeLayout(false);
			this.TabPage4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040023A5 RID: 9125
		private global::System.ComponentModel.IContainer components;
	}
}
