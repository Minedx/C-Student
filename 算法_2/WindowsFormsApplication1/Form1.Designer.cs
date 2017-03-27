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
            this.uid = new System.Windows.Forms.TextBox();
            this.In = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uid
            // 
            this.uid.AutoCompleteCustomSource.AddRange(new string[] {
            "Q1"});
            this.uid.Location = new System.Drawing.Point(12, 12);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(121, 21);
            this.uid.TabIndex = 1;
            // 
            // In
            // 
            this.In.FormattingEnabled = true;
            this.In.Items.AddRange(new object[] {
            "男",
            "女"});
            this.In.Location = new System.Drawing.Point(12, 39);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(121, 20);
            this.In.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 116);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.In);
            this.Controls.Add(this.uid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.ComboBox In;
        private System.Windows.Forms.Button button1;
    }
}

