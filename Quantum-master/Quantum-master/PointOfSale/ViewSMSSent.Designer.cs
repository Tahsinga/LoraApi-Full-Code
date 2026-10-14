namespace PointOfSale
{
	// Token: 0x02000217 RID: 535
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewSMSSent : global::System.Windows.Forms.Form
	{
		// Token: 0x0600601D RID: 24605 RVA: 0x0036EAB4 File Offset: 0x0036CCB4
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

		// Token: 0x0600601E RID: 24606 RVA: 0x0036EB04 File Offset: 0x0036CD04
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTdate = new global::System.Windows.Forms.DateTimePicker();
			this.cboSMSSubject = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvSMSs = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvSMSs).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTdate);
			this.GroupBox1.Controls.Add(this.cboSMSSubject);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1006, 123);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "SMS Batch Details";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(5, 28);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(109, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Sent Before this date:";
			this.Button1.Location = new global::System.Drawing.Point(120, 79);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(100, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "View SMSs";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTdate.Location = new global::System.Drawing.Point(120, 26);
			this.DTdate.Name = "DTdate";
			this.DTdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTdate.TabIndex = 2;
			this.cboSMSSubject.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSMSSubject.FormattingEnabled = true;
			this.cboSMSSubject.Location = new global::System.Drawing.Point(120, 52);
			this.cboSMSSubject.Name = "cboSMSSubject";
			this.cboSMSSubject.Size = new global::System.Drawing.Size(415, 21);
			this.cboSMSSubject.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(12, 55);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(105, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select SMS Subject:";
			this.GroupBox2.Controls.Add(this.dgvSMSs);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 123);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(1006, 289);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.dgvSMSs.AllowUserToAddRows = false;
			this.dgvSMSs.AllowUserToDeleteRows = false;
			this.dgvSMSs.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSMSs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvSMSs.Location = new global::System.Drawing.Point(3, 16);
			this.dgvSMSs.Name = "dgvSMSs";
			this.dgvSMSs.ReadOnly = true;
			this.dgvSMSs.Size = new global::System.Drawing.Size(1000, 270);
			this.dgvSMSs.TabIndex = 4;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1006, 412);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ViewSMSSent";
			this.Text = "View SMSs Sent";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvSMSs).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002A3F RID: 10815
		private global::System.ComponentModel.IContainer components;
	}
}
