namespace PointOfSale
{
	// Token: 0x02000035 RID: 53
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CS_EODEnter : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x00074B74 File Offset: 0x00072D74
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

		// Token: 0x06000B8F RID: 2959 RVA: 0x00074BC4 File Offset: 0x00072DC4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dtTranDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lblTeller = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.lblBranch = new global::System.Windows.Forms.Label();
			this.dgvCashUp = new global::System.Windows.Forms.DataGridView();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCashUp).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.lblBranch);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.lblTeller);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.dtTranDate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(800, 105);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Teller Details";
			this.dtTranDate.Location = new global::System.Drawing.Point(88, 28);
			this.dtTranDate.Name = "dtTranDate";
			this.dtTranDate.Size = new global::System.Drawing.Size(200, 20);
			this.dtTranDate.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(49, 32);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(33, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Date:";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(15, 60);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(67, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Teller Name:";
			this.lblTeller.AutoSize = true;
			this.lblTeller.Location = new global::System.Drawing.Point(88, 60);
			this.lblTeller.Name = "lblTeller";
			this.lblTeller.Size = new global::System.Drawing.Size(0, 13);
			this.lblTeller.TabIndex = 3;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(38, 82);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(44, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Branch:";
			this.lblBranch.AutoSize = true;
			this.lblBranch.Location = new global::System.Drawing.Point(88, 82);
			this.lblBranch.Name = "lblBranch";
			this.lblBranch.Size = new global::System.Drawing.Size(0, 13);
			this.lblBranch.TabIndex = 5;
			this.dgvCashUp.AllowUserToAddRows = false;
			this.dgvCashUp.AllowUserToDeleteRows = false;
			this.dgvCashUp.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCashUp.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvCashUp.Location = new global::System.Drawing.Point(0, 105);
			this.dgvCashUp.Name = "dgvCashUp";
			this.dgvCashUp.Size = new global::System.Drawing.Size(800, 283);
			this.dgvCashUp.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(457, 77);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(104, 23);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.Location = new global::System.Drawing.Point(576, 77);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(212, 23);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "DELETE Cash Up Entered for Day";
			this.Button2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 388);
			base.Controls.Add(this.dgvCashUp);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CS_EODEnter";
			this.Text = "CashUp Enter";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCashUp).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400057A RID: 1402
		private global::System.ComponentModel.IContainer components;
	}
}
