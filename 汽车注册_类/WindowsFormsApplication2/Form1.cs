using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked != radioButton2.Checked)
            {
                Car car = new Car(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, radioButton1.Checked ? "自动档" : "手动档");
                Form2 Frm2 = new Form2();
                Frm2.name.Text = car._name;
                Frm2.type.Text = car._type;
                Frm2.color.Text = car._color;
                Frm2.weigh.Text = car._weight;
                Frm2.speed.Text = car._speed;
                Frm2.textBox.Text = car.Gear;
                Frm2.Output.Text = car.Run();
                Frm2.Output.Text = car.stop();
                this.Hide();
                Frm2.Show();
            }
            else MessageBox.Show("错误：未选择档位");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
;