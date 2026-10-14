namespace PointOfSale
{
	// Token: 0x02000013 RID: 19
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BatchSelect : global::System.Windows.Forms.Form
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0001AB14 File Offset: 0x00018D14
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

		// Token: 0x06000302 RID: 770 RVA: 0x0001AB64 File Offset: 0x00018D64
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvBatches = new global::System.Windows.Forms.DataGridView();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBatches).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1125, 118);
			this.Panel1.TabIndex = 0;
			this.Button3.Location = new global::System.Drawing.Point(12, 55);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(154, 47);
			this.Button3.TabIndex = 3;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(168, 14);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(803, 32);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "SELECT THE BATCH TO BE SUPPLIED TO THE CUSTOMER";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(491, 55);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(171, 47);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "SUBMIT";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvBatches.AllowUserToAddRows = false;
			this.dgvBatches.AllowUserToDeleteRows = false;
			this.dgvBatches.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBatches.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvBatches.Location = new global::System.Drawing.Point(0, 118);
			this.dgvBatches.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvBatches.Name = "dgvBatches";
			this.dgvBatches.Size = new global::System.Drawing.Size(1125, 285);
			this.dgvBatches.TabIndex = 1;
			base.AcceptButton = this.Button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1125, 403);
			base.Controls.Add(this.dgvBatches);
			base.Controls.Add(this.Panel1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "BatchSelect";
			this.Text = "SELECT QUANTITY FOR EACH BATCH";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBatches).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400014C RID: 332
		private global::System.ComponentModel.IContainer components;
	}
}
