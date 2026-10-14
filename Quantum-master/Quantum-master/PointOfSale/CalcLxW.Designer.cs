namespace PointOfSale
{
	// Token: 0x0200001C RID: 28
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CalcLxW : global::System.Windows.Forms.Form
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x00033F24 File Offset: 0x00032124
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

		// Token: 0x06000531 RID: 1329 RVA: 0x00033F74 File Offset: 0x00032174
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtL = new global::System.Windows.Forms.TextBox();
			this.txtW = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtTotal = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.lblDesc = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(186, 127);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(92, 29);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Length:";
			this.txtL.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtL.Location = new global::System.Drawing.Point(284, 124);
			this.txtL.Name = "txtL";
			this.txtL.Size = new global::System.Drawing.Size(160, 35);
			this.txtL.TabIndex = 1;
			this.txtW.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtW.Location = new global::System.Drawing.Point(284, 174);
			this.txtW.Name = "txtW";
			this.txtW.Size = new global::System.Drawing.Size(160, 35);
			this.txtW.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(198, 174);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(80, 29);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Width:";
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotal.Location = new global::System.Drawing.Point(284, 227);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new global::System.Drawing.Size(160, 35);
			this.txtTotal.TabIndex = 5;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(84, 232);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(194, 29);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Calculated Total:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(284, 281);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(160, 38);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "SELECT";
			this.Button1.UseVisualStyleBackColor = false;
			this.lblDesc.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.Location = new global::System.Drawing.Point(0, 0);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new global::System.Drawing.Size(640, 59);
			this.lblDesc.TabIndex = 7;
			this.lblDesc.Text = "....";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(0, 78);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(632, 29);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "ENTER THE LENGTH AND WITDH FOR THE PRODUCT";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(640, 334);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.lblDesc);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.txtTotal);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.txtW);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.txtL);
			base.Controls.Add(this.Label1);
			base.Name = "CalcLxW";
			this.Text = "CalcLxW";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400025A RID: 602
		private global::System.ComponentModel.IContainer components;
	}
}
