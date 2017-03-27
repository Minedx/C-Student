namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Q2 = new System.Windows.Forms.ListBox();
            this.Q1 = new System.Windows.Forms.TextBox();
            this.Q2_New = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Q2
            // 
            this.Q2.FormattingEnabled = true;
            this.Q2.ItemHeight = 12;
            this.Q2.Location = new System.Drawing.Point(12, 122);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(100, 64);
            this.Q2.TabIndex = 0;
            // 
            // Q1
            // 
            this.Q1.AutoCompleteCustomSource.AddRange(new string[] {
            "Q1"});
            this.Q1.Location = new System.Drawing.Point(12, 80);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(100, 21);
            this.Q1.TabIndex = 1;
            // 
            // Q2_New
            // 
            this.Q2_New.FormattingEnabled = true;
            this.Q2_New.ItemHeight = 12;
            this.Q2_New.Location = new System.Drawing.Point(148, 122);
            this.Q2_New.Name = "Q2_New";
            this.Q2_New.Size = new System.Drawing.Size(100, 64);
            this.Q2_New.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Q2_New);
            this.Controls.Add(this.Q1);
            this.Controls.Add(this.Q2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Q2;
        private System.Windows.Forms.TextBox Q1;
        private System.Windows.Forms.ListBox Q2_New;
    }
}

