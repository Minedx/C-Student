namespace ExchangeList
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
            this.Input = new System.Windows.Forms.ListBox();
            this.Output = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.FormattingEnabled = true;
            this.Input.ItemHeight = 12;
            this.Input.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "5",
            "4",
            "6",
            "7",
            "8",
            "9"});
            this.Input.Location = new System.Drawing.Point(12, 28);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(65, 124);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.ItemHeight = 12;
            this.Output.Location = new System.Drawing.Point(140, 28);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(65, 124);
            this.Output.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "输出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Input;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Button button1;
    }
}

