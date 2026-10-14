namespace PointOfSale
{
	// Token: 0x02000028 RID: 40
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CollectionsByCustomerReport : global::System.Windows.Forms.Form
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x0004C74C File Offset: 0x0004A94C
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

		// Token: 0x06000797 RID: 1943 RVA: 0x0004C79C File Offset: 0x0004A99C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label18 = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.cboCustomers = new global::System.Windows.Forms.ComboBox();
			this.dgvProducts = new global::System.Windows.Forms.DataGridView();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvProductAudit = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProductAudit).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label18);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.cboCustomers);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(853, 110);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(6, 14);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(332, 20);
			this.Label1.TabIndex = 61;
			this.Label1.Text = "Collections/Delivery Status for Customer";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(189, 76);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(179, 23);
			this.Button1.TabIndex = 59;
			this.Button1.Text = "View Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label18.AutoSize = true;
			this.Label18.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label18.Location = new global::System.Drawing.Point(16, 48);
			this.Label18.Name = "Label18";
			this.Label18.Size = new global::System.Drawing.Size(167, 17);
			this.Label18.TabIndex = 57;
			this.Label18.Text = "Select Existing Customer:";
			this.Button4.Location = new global::System.Drawing.Point(535, 45);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 58;
			this.Button4.TabStop = false;
			this.Button4.Text = "Adv. Search";
			this.Button4.UseVisualStyleBackColor = true;
			this.cboCustomers.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboCustomers.FormattingEnabled = true;
			this.cboCustomers.Location = new global::System.Drawing.Point(189, 42);
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Size = new global::System.Drawing.Size(338, 28);
			this.cboCustomers.TabIndex = 56;
			this.cboCustomers.TabStop = false;
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.dgvProducts.Location = new global::System.Drawing.Point(0, 110);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.Size = new global::System.Drawing.Size(853, 218);
			this.dgvProducts.TabIndex = 2;
			this.GroupBox2.Controls.Add(this.dgvProductAudit);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 328);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(853, 234);
			this.GroupBox2.TabIndex = 3;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Audit";
			this.dgvProductAudit.AllowUserToAddRows = false;
			this.dgvProductAudit.AllowUserToDeleteRows = false;
			this.dgvProductAudit.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductAudit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProductAudit.Location = new global::System.Drawing.Point(3, 16);
			this.dgvProductAudit.Name = "dgvProductAudit";
			this.dgvProductAudit.ReadOnly = true;
			this.dgvProductAudit.Size = new global::System.Drawing.Size(847, 215);
			this.dgvProductAudit.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(853, 562);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.dgvProducts);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CollectionsByCustomerReport";
			this.Text = "Collections By Customer Report";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvProductAudit).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000390 RID: 912
		private global::System.ComponentModel.IContainer components;
	}
}
