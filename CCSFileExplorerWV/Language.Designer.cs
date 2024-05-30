namespace CCSFileExplorerWV
{
	// Token: 0x02000011 RID: 17
	public partial class Language : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00003E94 File Offset: 0x00002094
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003EB4 File Offset: 0x000020B4
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(130, 78);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(52, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"English",
				"Portuguese",
				"Spanish"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(29, 51);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(130, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(161, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select program language above:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(194, 113);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.button1);
			base.Name = "Language";
			this.Text = "Language";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002C RID: 44
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label1;
	}
}
