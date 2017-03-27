using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// 学号 uid 姓名 name 民族 person

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClassList.Items.Clear();
            this.ClassList.Items.Add("一班");
            this.ClassList.Items.Add("二班");
            this.ClassList.Items.Add("三班");
            this.ClassList.Items.Add("四班");
            this.ClassList.Items.Add("五班");
            this.ClassList.Items.Add("六班");
            this.ClassList.Visible = true;

            this.person.Items.Clear();
            this.person.Items.Add("汉族");
            this.person.Items.Add("少数民族");

            this.Likes.Items.Clear();
            this.Likes.Items.Add("a");
            this.Likes.Items.Add("b");
            this.Likes.Items.Add("c");
            this.Likes.Items.Add("d");
            this.Likes.Items.Add("e");
            this.Likes.Items.Add("f");
            b1.Checked = false;
            b2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uid.Text.Length == 0) MessageBox.Show("未输入学号，请重新输入！");
            else if (name.Text.Length == 0) MessageBox.Show("未输入姓名，请重新输入！");
            else if (!(b1.Checked | b2.Checked)) MessageBox.Show("未选择性别，请重新选择！");
            else if (person.Text.Length == 0) MessageBox.Show("未选择民族，请重新选择！");
            else if (ClassList.Text.Length == 0) MessageBox.Show("未选择班级，请重新选择！");
            else
            {
                Form2 frm2 = new Form2();
                frm2.ShowUID.Text = uid.Text;
                frm2.ShowUID.Visible = true;//学号
                frm2.ShowName.Text = name.Text.Trim();
                frm2.ShowName.Visible = true;//姓名
                frm2.RegistionMessage.Text = name.Text + "同学的注册信息";
                frm2.RegistionMessage.Visible = true;//大标题_姓名
                frm2.ShowGender.Text = b1.Checked ? "男" : "女";
                frm2.ShowGender.Visible = true;//性别
                frm2.ShowPerson.Text = person.Text;
                frm2.ShowPerson.Visible = true;//民族
                frm2.ShowClass.Text = ClassList.Text;
                frm2.ShowClass.Visible = true;//班级
                frm2.ShowLikes.Text = "";//初始化Text列表
                foreach (string a in Likes.CheckedItems)
                {
                    //frm2.ShowLikes.Text = Likes.Text;
                    frm2.ShowLikes.Text += a + " ";
                }
                frm2.ShowLikes.Visible = true;
                this.Hide();
                frm2.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
