namespace PointOfSale
{
	// Token: 0x020001B5 RID: 437
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SearchComments : global::System.Windows.Forms.Form
	{
		// Token: 0x06004F61 RID: 20321 RVA: 0x002F83B8 File Offset: 0x002F65B8
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

		// Token: 0x06004F62 RID: 20322 RVA: 0x002F8408 File Offset: 0x002F6608
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvResult = new global::System.Windows.Forms.DataGridView();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtSearch = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.chkAllDates = new global::System.Windows.Forms.CheckBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvResult).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.chkAllDates);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtSearch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1205, 228);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.dgvResult.AllowUserToAddRows = false;
			this.dgvResult.AllowUserToDeleteRows = false;
			this.dgvResult.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResult.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvResult.Location = new global::System.Drawing.Point(0, 228);
			this.dgvResult.Name = "dgvResult";
			this.dgvResult.ReadOnly = true;
			this.dgvResult.RowTemplate.Height = 28;
			this.dgvResult.Size = new global::System.Drawing.Size(1205, 429);
			this.dgvResult.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(89, 81);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(134, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Enter search text:";
			this.txtSearch.Location = new global::System.Drawing.Point(232, 78);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new global::System.Drawing.Size(323, 26);
			this.txtSearch.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(371, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(503, 32);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "SEARCH COMMENTS IN INVOICES";
			this.DTStartDate.Location = new global::System.Drawing.Point(232, 112);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(323, 26);
			this.DTStartDate.TabIndex = 3;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(139, 116);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(87, 20);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Start Date:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(139, 148);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(81, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "End Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(232, 144);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(323, 26);
			this.DTEndDate.TabIndex = 5;
			this.chkAllDates.AutoSize = true;
			this.chkAllDates.Location = new global::System.Drawing.Point(561, 145);
			this.chkAllDates.Name = "chkAllDates";
			this.chkAllDates.Size = new global::System.Drawing.Size(163, 24);
			this.chkAllDates.TabIndex = 7;
			this.chkAllDates.Text = "Search All Dates?";
			this.chkAllDates.UseVisualStyleBackColor = true;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(229, 176);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(191, 42);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "Search";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1205, 657);
			base.Controls.Add(this.dgvResult);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SearchComments";
			this.Text = "Search Invoice Comments";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvResult).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002366 RID: 9062
		private global::System.ComponentModel.IContainer components;
	}
}
