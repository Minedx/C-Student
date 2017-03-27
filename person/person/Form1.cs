using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wfm2 wfm2 = new Wfm2();
            Student student = new Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
            wfm2.textBox1.Text = student.name;
            wfm2.textBox2.Text = student.year;
            wfm2.textBox3.Text = student.gender;
            wfm2.textBox4.Text = student.number;
            wfm2.textBox5.Text = Convert.ToString(student.a1);
            wfm2.textBox6.Text = Convert.ToString(student.a2);
            wfm2.textBox7.Text = Convert.ToString(student.a3);
            wfm2.textBox8.Text = Convert.ToString(student.a4);
            wfm2.textBox9.Text = Convert.ToString(student.a5);
            wfm2.textBox10.Text = student.average();
            this.Hide();
            wfm2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
