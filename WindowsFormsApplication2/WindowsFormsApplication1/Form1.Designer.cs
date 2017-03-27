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
            this.label1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.RadioButton();
            this.b2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.uid = new System.Windows.Forms.TextBox();
            this.ClassList = new System.Windows.Forms.ListBox();
            this.person = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Likes = new System.Windows.Forms.CheckedListBox();
            this.labelx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入用户信息";
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Location = new System.Drawing.Point(76, 82);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(35, 16);
            this.b1.TabIndex = 1;
            this.b1.TabStop = true;
            this.b1.Text = "男";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Location = new System.Drawing.Point(131, 82);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(35, 16);
            this.b2.TabIndex = 2;
            this.b2.TabStop = true;
            this.b2.Text = "女";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "班级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "民族：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "姓名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "性别：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(76, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 21);
            this.name.TabIndex = 8;
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(76, 28);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(182, 21);
            this.uid.TabIndex = 9;
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.ItemHeight = 12;
            this.ClassList.Location = new System.Drawing.Point(76, 140);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(182, 88);
            this.ClassList.TabIndex = 10;
            this.ClassList.Visible = false;
            // 
            // person
            // 
            this.person.FormattingEnabled = true;
            this.person.Location = new System.Drawing.Point(76, 111);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(182, 20);
            this.person.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Likes
            // 
            this.Likes.FormattingEnabled = true;
            this.Likes.Location = new System.Drawing.Point(76, 246);
            this.Likes.Name = "Likes";
            this.Likes.Size = new System.Drawing.Size(182, 116);
            this.Likes.TabIndex = 14;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(22, 246);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(41, 12);
            this.labelx.TabIndex = 15;
            this.labelx.Text = "爱好：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 467);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.Likes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.person);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "用户信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton b1;
        private System.Windows.Forms.RadioButton b2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.ListBox ClassList;
        private System.Windows.Forms.ComboBox person;
        private System.Windows.Forms.CheckedListBox Likes;
        private System.Windows.Forms.Label labelx;
    }
}

