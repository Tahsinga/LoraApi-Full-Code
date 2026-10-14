namespace PointOfSale
{
	// Token: 0x02000216 RID: 534
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewSelectedCategories : global::System.Windows.Forms.Form
	{
		// Token: 0x06006003 RID: 24579 RVA: 0x0036E148 File Offset: 0x0036C348
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

		// Token: 0x06006004 RID: 24580 RVA: 0x0036E198 File Offset: 0x0036C398
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtDisplayEntryNo = new global::System.Windows.Forms.TextBox();
			this.Label14 = new global::System.Windows.Forms.Label();
			this.lblDisplayNotEnteredTreatedAs = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtDisplayCreatedBy = new global::System.Windows.Forms.TextBox();
			this.txtDisplayDateCreated = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtDisplayRef = new global::System.Windows.Forms.TextBox();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.txtDisplayEntryNo);
			this.GroupBox1.Controls.Add(this.Label14);
			this.GroupBox1.Controls.Add(this.lblDisplayNotEnteredTreatedAs);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtDisplayCreatedBy);
			this.GroupBox1.Controls.Add(this.txtDisplayDateCreated);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtDisplayRef);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(749, 78);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.txtDisplayEntryNo.Enabled = false;
			this.txtDisplayEntryNo.Location = new global::System.Drawing.Point(297, 38);
			this.txtDisplayEntryNo.Name = "txtDisplayEntryNo";
			this.txtDisplayEntryNo.Size = new global::System.Drawing.Size(75, 20);
			this.txtDisplayEntryNo.TabIndex = 91;
			this.Label14.AutoSize = true;
			this.Label14.Location = new global::System.Drawing.Point(250, 41);
			this.Label14.Name = "Label14";
			this.Label14.Size = new global::System.Drawing.Size(41, 13);
			this.Label14.TabIndex = 90;
			this.Label14.Text = "Ref ID:";
			this.lblDisplayNotEnteredTreatedAs.AutoSize = true;
			this.lblDisplayNotEnteredTreatedAs.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDisplayNotEnteredTreatedAs.Location = new global::System.Drawing.Point(436, 41);
			this.lblDisplayNotEnteredTreatedAs.Name = "lblDisplayNotEnteredTreatedAs";
			this.lblDisplayNotEnteredTreatedAs.Size = new global::System.Drawing.Size(16, 13);
			this.lblDisplayNotEnteredTreatedAs.TabIndex = 89;
			this.lblDisplayNotEnteredTreatedAs.Text = "...";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(434, 15);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(62, 13);
			this.Label4.TabIndex = 88;
			this.Label4.Text = "Created By:";
			this.txtDisplayCreatedBy.Enabled = false;
			this.txtDisplayCreatedBy.Location = new global::System.Drawing.Point(502, 12);
			this.txtDisplayCreatedBy.Name = "txtDisplayCreatedBy";
			this.txtDisplayCreatedBy.Size = new global::System.Drawing.Size(293, 20);
			this.txtDisplayCreatedBy.TabIndex = 87;
			this.txtDisplayDateCreated.Enabled = false;
			this.txtDisplayDateCreated.Location = new global::System.Drawing.Point(79, 38);
			this.txtDisplayDateCreated.Name = "txtDisplayDateCreated";
			this.txtDisplayDateCreated.Size = new global::System.Drawing.Size(144, 20);
			this.txtDisplayDateCreated.TabIndex = 86;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(1, 41);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(73, 13);
			this.Label3.TabIndex = 85;
			this.Label3.Text = "Date Created:";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(13, 15);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(60, 13);
			this.Label2.TabIndex = 84;
			this.Label2.Text = "Reference:";
			this.txtDisplayRef.Enabled = false;
			this.txtDisplayRef.Location = new global::System.Drawing.Point(79, 12);
			this.txtDisplayRef.Name = "txtDisplayRef";
			this.txtDisplayRef.Size = new global::System.Drawing.Size(293, 20);
			this.txtDisplayRef.TabIndex = 83;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 78);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new global::System.Drawing.Size(749, 226);
			this.DataGridView1.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(749, 304);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "ViewSelectedCategories";
			this.Text = "View Selected Categories";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002A2D RID: 10797
		private global::System.ComponentModel.IContainer components;
	}
}
