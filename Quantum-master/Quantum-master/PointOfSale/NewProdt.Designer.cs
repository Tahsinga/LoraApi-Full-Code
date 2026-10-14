namespace PointOfSale
{
	// Token: 0x0200007A RID: 122
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class NewProdt : global::System.Windows.Forms.Form
	{
		// Token: 0x06001A48 RID: 6728 RVA: 0x000F0A18 File Offset: 0x000EEC18
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

		// Token: 0x06001A49 RID: 6729 RVA: 0x000F0A68 File Offset: 0x000EEC68
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtdesc = new global::System.Windows.Forms.TextBox();
			this.cboCategory = new global::System.Windows.Forms.ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtReorder = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.Button1.Location = new global::System.Drawing.Point(120, 140);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(86, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(229, 24);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Enter New Product Details";
			this.txtdesc.Location = new global::System.Drawing.Point(120, 88);
			this.txtdesc.Name = "txtdesc";
			this.txtdesc.Size = new global::System.Drawing.Size(250, 20);
			this.txtdesc.TabIndex = 1;
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new global::System.Drawing.Point(120, 61);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new global::System.Drawing.Size(250, 21);
			this.cboCategory.TabIndex = 0;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(29, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(85, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Select Category:";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(11, 91);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(103, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Product Description:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(34, 117);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(80, 13);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Re-order Level:";
			this.txtReorder.Location = new global::System.Drawing.Point(120, 114);
			this.txtReorder.Name = "txtReorder";
			this.txtReorder.Size = new global::System.Drawing.Size(75, 20);
			this.txtReorder.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(394, 208);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.txtReorder);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.cboCategory);
			base.Controls.Add(this.txtdesc);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Button1);
			base.MaximizeBox = false;
			base.Name = "NewProdt";
			this.Text = "New Products";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CAF RID: 3247
		private global::System.ComponentModel.IContainer components;
	}
}
