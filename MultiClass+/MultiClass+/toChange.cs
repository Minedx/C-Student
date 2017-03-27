using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiClass_
{
    public partial class toChange : Form
    {
        public toChange()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text,textBox9.Text);
            Form1 frm1 = new Form1();
            ListViewItem item = new ListViewItem(student.Name);//ListViewItem
            item.SubItems.Add(student.sex);
            item.SubItems.Add(student.Age);
            item.SubItems.Add(student.Class);
            item.SubItems.Add(student.LangC.ToString());
            item.SubItems.Add(student.Eng.ToString());
            item.SubItems.Add(student.Math.ToString());
            item.SubItems.Add(student.Chinese.ToString());
            item.SubItems.Add(student.Average.ToString());
            frm1.listView1.Items.Add(item);
            this.Hide();
            frm1.Show();
        }
    }
}
