namespace PointOfSale
{
	// Token: 0x02000064 RID: 100
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class GetNewBatchNumber : global::System.Windows.Forms.Form
	{
		// Token: 0x0600158B RID: 5515 RVA: 0x000CA0CC File Offset: 0x000C82CC
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

		// Token: 0x0600158C RID: 5516 RVA: 0x000CA11C File Offset: 0x000C831C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtNewBatchNumber = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTNewBatchNumber = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(12, 55);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(193, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Enter New Batch Number:";
			this.txtNewBatchNumber.Location = new global::System.Drawing.Point(207, 51);
			this.txtNewBatchNumber.Name = "txtNewBatchNumber";
			this.txtNewBatchNumber.Size = new global::System.Drawing.Size(188, 26);
			this.txtNewBatchNumber.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(12, 102);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(178, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Select New Expiry Date:";
			this.DTNewBatchNumber.Location = new global::System.Drawing.Point(207, 97);
			this.DTNewBatchNumber.Name = "DTNewBatchNumber";
			this.DTNewBatchNumber.Size = new global::System.Drawing.Size(283, 26);
			this.DTNewBatchNumber.TabIndex = 3;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(207, 129);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(116, 37);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "DONE";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(616, 244);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.DTNewBatchNumber);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.txtNewBatchNumber);
			base.Controls.Add(this.Label1);
			base.Name = "GetNewBatchNumber";
			this.Text = "Get New BatchNumber";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000ACB RID: 2763
		private global::System.ComponentModel.IContainer components;
	}
}
