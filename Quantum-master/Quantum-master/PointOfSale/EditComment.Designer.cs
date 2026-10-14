namespace PointOfSale
{
	// Token: 0x0200004C RID: 76
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditComment : global::System.Windows.Forms.Form
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x00097BB8 File Offset: 0x00095DB8
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

		// Token: 0x0600100D RID: 4109 RVA: 0x00097C08 File Offset: 0x00095E08
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtInvNum = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtInvDate = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtCustomer = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.dgvComments = new global::System.Windows.Forms.DataGridView();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvComments).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.txtCustomer);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtInvDate);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtInvNum);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(587, 223);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.txtInvNum.Enabled = false;
			this.txtInvNum.Location = new global::System.Drawing.Point(164, 66);
			this.txtInvNum.Name = "txtInvNum";
			this.txtInvNum.Size = new global::System.Drawing.Size(150, 26);
			this.txtInvNum.TabIndex = 5;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(93, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(274, 25);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "EDIT INVOICE COMMENT";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(35, 69);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(123, 20);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Invoice Number:";
			this.txtInvDate.Enabled = false;
			this.txtInvDate.Location = new global::System.Drawing.Point(164, 98);
			this.txtInvDate.Name = "txtInvDate";
			this.txtInvDate.Size = new global::System.Drawing.Size(269, 26);
			this.txtInvDate.TabIndex = 7;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(56, 98);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(102, 20);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Invoice Date:";
			this.txtCustomer.Enabled = false;
			this.txtCustomer.Location = new global::System.Drawing.Point(164, 130);
			this.txtCustomer.Name = "txtCustomer";
			this.txtCustomer.Size = new global::System.Drawing.Size(269, 26);
			this.txtCustomer.TabIndex = 9;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(76, 133);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(82, 20);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Customer:";
			this.dgvComments.AllowUserToAddRows = false;
			this.dgvComments.AllowUserToDeleteRows = false;
			this.dgvComments.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvComments.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvComments.Location = new global::System.Drawing.Point(0, 223);
			this.dgvComments.Name = "dgvComments";
			this.dgvComments.RowTemplate.Height = 28;
			this.dgvComments.Size = new global::System.Drawing.Size(587, 261);
			this.dgvComments.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(159, 162);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(155, 44);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(587, 484);
			base.Controls.Add(this.dgvComments);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EditComment";
			this.Text = "Edit Invoice Comment";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvComments).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007AA RID: 1962
		private global::System.ComponentModel.IContainer components;
	}
}
