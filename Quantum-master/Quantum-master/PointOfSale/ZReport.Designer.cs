namespace PointOfSale
{
	// Token: 0x0200021D RID: 541
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ZReport : global::System.Windows.Forms.Form
	{
		// Token: 0x060061AD RID: 25005 RVA: 0x00379ECC File Offset: 0x003780CC
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

		// Token: 0x060061AE RID: 25006 RVA: 0x00379F1C File Offset: 0x0037811C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TabControl1 = new global::System.Windows.Forms.TabControl();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cboPaymentMethod = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			base.SuspendLayout();
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new global::System.Drawing.Size(544, 301);
			this.TabControl1.TabIndex = 0;
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.Controls.Add(this.Button1);
			this.TabPage1.Controls.Add(this.cboPaymentMethod);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new global::System.Drawing.Size(536, 275);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Eltrade";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.TabPage2.Controls.Add(this.Label3);
			this.TabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new global::System.Drawing.Size(536, 275);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Revmax";
			this.TabPage2.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(39, 68);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(123, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select Payment Method:";
			this.cboPaymentMethod.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPaymentMethod.FormattingEnabled = true;
			this.cboPaymentMethod.Location = new global::System.Drawing.Point(168, 65);
			this.cboPaymentMethod.Name = "cboPaymentMethod";
			this.cboPaymentMethod.Size = new global::System.Drawing.Size(176, 21);
			this.cboPaymentMethod.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(168, 92);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(176, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Run Z Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(3, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(525, 40);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "*selection of the payment method will determine the currency. Z Report will run for that currency not that payment method only.";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(91, 96);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(319, 13);
			this.Label3.TabIndex = 1;
			this.Label3.Text = "Please run the Z Report from the Sales Mono or sales normal form.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(544, 301);
			base.Controls.Add(this.TabControl1);
			base.Name = "ZReport";
			this.Text = "ZReport";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002AF9 RID: 11001
		private global::System.ComponentModel.IContainer components;
	}
}
