namespace PointOfSale
{
	// Token: 0x02000009 RID: 9
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AddNewProdt : global::System.Windows.Forms.Form
	{
		// Token: 0x06000165 RID: 357 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
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

		// Token: 0x06000166 RID: 358 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtReorder = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboCategory = new global::System.Windows.Forms.ComboBox();
			this.txtdesc = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvproducts = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvproducts).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.lblinfo);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtReorder);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboCategory);
			this.GroupBox1.Controls.Add(this.txtdesc);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(875, 138);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = global::System.Drawing.Color.Red;
			this.Label5.Location = new global::System.Drawing.Point(558, 52);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(11, 13);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "*";
			this.lblinfo.AutoSize = true;
			this.lblinfo.Location = new global::System.Drawing.Point(383, 106);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(16, 13);
			this.lblinfo.TabIndex = 15;
			this.lblinfo.Text = "...";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(216, 78);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(80, 13);
			this.Label4.TabIndex = 14;
			this.Label4.Text = "Re-order Level:";
			this.txtReorder.Location = new global::System.Drawing.Point(302, 75);
			this.txtReorder.Name = "txtReorder";
			this.txtReorder.Size = new global::System.Drawing.Size(75, 20);
			this.txtReorder.TabIndex = 3;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(193, 52);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(103, 13);
			this.Label3.TabIndex = 12;
			this.Label3.Text = "Product Description:";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(211, 25);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(85, 13);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Select Category:";
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new global::System.Drawing.Point(302, 22);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new global::System.Drawing.Size(250, 21);
			this.cboCategory.TabIndex = 1;
			this.txtdesc.Location = new global::System.Drawing.Point(302, 49);
			this.txtdesc.Name = "txtdesc";
			this.txtdesc.Size = new global::System.Drawing.Size(250, 20);
			this.txtdesc.TabIndex = 2;
			this.Button1.Location = new global::System.Drawing.Point(302, 101);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = true;
			this.dgvproducts.AllowUserToAddRows = false;
			this.dgvproducts.AllowUserToDeleteRows = false;
			this.dgvproducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvproducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvproducts.Location = new global::System.Drawing.Point(0, 138);
			this.dgvproducts.Name = "dgvproducts";
			this.dgvproducts.ReadOnly = true;
			this.dgvproducts.Size = new global::System.Drawing.Size(875, 333);
			this.dgvproducts.TabIndex = 1;
			this.dgvproducts.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(875, 471);
			base.Controls.Add(this.dgvproducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "AddNewProdt";
			this.Text = "Add New Product";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvproducts).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000096 RID: 150
		private global::System.ComponentModel.IContainer components;
	}
}
