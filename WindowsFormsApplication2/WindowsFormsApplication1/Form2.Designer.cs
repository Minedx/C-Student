namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegistionMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowUID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowName = new System.Windows.Forms.Label();
            this.ShowGender = new System.Windows.Forms.Label();
            this.ShowPerson = new System.Windows.Forms.Label();
            this.ShowClass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowLikes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistionMessage
            // 
            this.RegistionMessage.AutoSize = true;
            this.RegistionMessage.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegistionMessage.Location = new System.Drawing.Point(23, 9);
            this.RegistionMessage.Name = "RegistionMessage";
            this.RegistionMessage.Size = new System.Drawing.Size(164, 25);
            this.RegistionMessage.TabIndex = 0;
            this.RegistionMessage.Text = "XX同学的注册信息";
            this.RegistionMessage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "民族：";
            // 
            // ShowUID
            // 
            this.ShowUID.AutoSize = true;
            this.ShowUID.Location = new System.Drawing.Point(77, 44);
            this.ShowUID.Name = "ShowUID";
            this.ShowUID.Size = new System.Drawing.Size(29, 12);
            this.ShowUID.TabIndex = 5;
            this.ShowUID.Text = "null";
            this.ShowUID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "班级：";
            // 
            // ShowName
            // 
            this.ShowName.AutoSize = true;
            this.ShowName.Location = new System.Drawing.Point(77, 69);
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(29, 12);
            this.ShowName.TabIndex = 7;
            this.ShowName.Text = "null";
            this.ShowName.Visible = false;
            // 
            // ShowGender
            // 
            this.ShowGender.AutoSize = true;
            this.ShowGender.Location = new System.Drawing.Point(77, 94);
            this.ShowGender.Name = "ShowGender";
            this.ShowGender.Size = new System.Drawing.Size(29, 12);
            this.ShowGender.TabIndex = 8;
            this.ShowGender.Text = "null";
            this.ShowGender.Visible = false;
            // 
            // ShowPerson
            // 
            this.ShowPerson.AutoSize = true;
            this.ShowPerson.Location = new System.Drawing.Point(77, 119);
            this.ShowPerson.Name = "ShowPerson";
            this.ShowPerson.Size = new System.Drawing.Size(29, 12);
            this.ShowPerson.TabIndex = 9;
            this.ShowPerson.Text = "null";
            this.ShowPerson.Visible = false;
            // 
            // ShowClass
            // 
            this.ShowClass.AutoSize = true;
            this.ShowClass.Location = new System.Drawing.Point(77, 143);
            this.ShowClass.Name = "ShowClass";
            this.ShowClass.Size = new System.Drawing.Size(29, 12);
            this.ShowClass.TabIndex = 10;
            this.ShowClass.Text = "null";
            this.ShowClass.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "爱好：";
            // 
            // ShowLikes
            // 
            this.ShowLikes.AutoSize = true;
            this.ShowLikes.Location = new System.Drawing.Point(77, 167);
            this.ShowLikes.Name = "ShowLikes";
            this.ShowLikes.Size = new System.Drawing.Size(29, 12);
            this.ShowLikes.TabIndex = 13;
            this.ShowLikes.Text = "null";
            this.ShowLikes.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 262);
            this.Controls.Add(this.ShowLikes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowClass);
            this.Controls.Add(this.ShowPerson);
            this.Controls.Add(this.ShowGender);
            this.Controls.Add(this.ShowName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShowUID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistionMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label RegistionMessage;
        public System.Windows.Forms.Label ShowUID;
        public System.Windows.Forms.Label ShowName;
        public System.Windows.Forms.Label ShowGender;
        public System.Windows.Forms.Label ShowPerson;
        public System.Windows.Forms.Label ShowClass;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ShowLikes;
    }
}