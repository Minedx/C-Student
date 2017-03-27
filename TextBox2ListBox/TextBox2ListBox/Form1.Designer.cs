namespace TextBox2ListBox
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
            this.In = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.domain = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(67, 12);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(129, 21);
            this.In.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(93, 66);
            this.domain.Name = "domain";
            this.domain.ReadOnly = true;
            this.domain.Size = new System.Drawing.Size(103, 21);
            this.domain.TabIndex = 3;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(93, 39);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(103, 21);
            this.username.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 139);
            this.Controls.Add(this.username);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.In);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox In;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.TextBox username;
    }
}

