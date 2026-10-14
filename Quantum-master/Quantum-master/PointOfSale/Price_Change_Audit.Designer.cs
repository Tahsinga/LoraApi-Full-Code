namespace PointOfSale
{
	// Token: 0x02000162 RID: 354
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Price_Change_Audit : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06002F4F RID: 12111 RVA: 0x0019A8D8 File Offset: 0x00198AD8
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

		// Token: 0x06002F50 RID: 12112 RVA: 0x0019A928 File Offset: 0x00198B28
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTend = new global::System.Windows.Forms.DateTimePicker();
			this.DTstart = new global::System.Windows.Forms.DateTimePicker();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvAudit = new global::System.Windows.Forms.DataGridView();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvAudit).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTend);
			this.GroupBox1.Controls.Add(this.DTstart);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1111, 150);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Select";
			this.Button2.BackColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(576, 113);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(200, 23);
			this.Button2.TabIndex = 11;
			this.Button2.Text = "Export to Excel";
			this.Button2.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(20, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(305, 24);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "View All Prices Changes Audit Trail";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(21, 91);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "End Date:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(85, 113);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "View All Price Changes";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(21, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Start Date:";
			this.DTend.Location = new global::System.Drawing.Point(85, 87);
			this.DTend.Name = "DTend";
			this.DTend.Size = new global::System.Drawing.Size(200, 20);
			this.DTend.TabIndex = 6;
			this.DTstart.Location = new global::System.Drawing.Point(85, 61);
			this.DTstart.Name = "DTstart";
			this.DTstart.Size = new global::System.Drawing.Size(200, 20);
			this.DTstart.TabIndex = 5;
			this.GroupBox2.Controls.Add(this.dgvAudit);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 150);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(1111, 255);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Audit Detail";
			this.dgvAudit.AllowUserToAddRows = false;
			this.dgvAudit.AllowUserToDeleteRows = false;
			this.dgvAudit.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAudit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvAudit.Location = new global::System.Drawing.Point(3, 16);
			this.dgvAudit.Name = "dgvAudit";
			this.dgvAudit.ReadOnly = true;
			this.dgvAudit.Size = new global::System.Drawing.Size(1105, 236);
			this.dgvAudit.TabIndex = 0;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Location = new global::System.Drawing.Point(1075, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(33, 13);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "Price_Change_Audit";
			base.Size = new global::System.Drawing.Size(1111, 405);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvAudit).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001447 RID: 5191
		private global::System.ComponentModel.IContainer components;
	}
}
