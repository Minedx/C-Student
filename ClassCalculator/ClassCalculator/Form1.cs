using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Progress1 todo = new Progress1(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            int temp=0;
            switch (comboBox1.Text)
            {
                case "+":
                    temp = todo.plus();
                    break;
                case "-":
                    temp = todo.minus();
                    break;
                case "*":
                    temp = todo.multiple();
                    break;
                case "/":
                    temp = todo.divide();
                    break;
                case "%":
                    temp = todo.a();
                    break;
                default:
                    MessageBox.Show("错误");
                    break;
            }
            textBox3.Text = temp.ToString();
        }
    }

    class Progress1
    {
        private int i1,i2;
        public Progress1(int Progressint1, int Progressint2)//whattodo
        {
            i1 = Progressint1;
            i2 = Progressint2;
        }
        public int plus()
        {
            return i1 + i2;
        }
        public int minus()
        {
            return i1 - i2;
        }
        public int multiple()
        {
            return i1 * i2;
        }
        public int divide()
        {
            if (i2 != 0) return i1 / i2;
            else return -0;
        }
        public int a()
        {
            if (i2 != 0) return i1 % i2;
            else return 0;
        }
    }
}
