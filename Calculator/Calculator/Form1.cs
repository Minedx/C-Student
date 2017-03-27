using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double temp=0, temp_2=0;
        short function;//0,1,2,3
        public Form1()
        {
            InitializeComponent();
        }

            private void Input_TextChanged(object sender, EventArgs e)
            {
                if (Input.Text.Length >= 12)
                {
                    Input.Font = new Font(Input.Font.FontFamily, 9);
                }
                else
                {
                    Input.Font = new Font(Input.Font.FontFamily, 12, FontStyle.Bold);
                }
            }

            private void Input_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar != (char)8 && !Char.IsDigit(e.KeyChar)) e.Handled = true;
                if (this.Input.Text.Length >= 14) e.Handled = true;
            }

            private void BackSpace_Click(object sender, EventArgs e)
            {
                Input.Focus();
                SendKeys.Send("{BACKSPACE}");
            }

            private void CE_Click(object sender, EventArgs e)
            {
                Input.Clear();
                temp = 0;
                temp_2 = 0;
            }

            private void C_Click(object sender, EventArgs e)
            {
                //C=CE
                Input.Clear();
            }

            private void Zero_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "0";
            }

            private void One_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "1";
            }

            private void Two_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "2";
            }

            private void Three_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "3";
            }

            private void Four_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "4";
            }

            private void Five_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "5";
            }

            private void Six_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "6";
            }

            private void Seven_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "7";
            }

            private void Eight_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "8";
            }

            private void Nine_Click(object sender, EventArgs e)
            {
                Input.Focus();
                Input.Text += "9";
            }

            private void Plus_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                Input.Clear();
                Input.Focus();
                function = 0;//0,+
            }

            private void Minus_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                Input.Clear();
                Input.Focus();
                function = 1;//1,-
            }

            private void Muliply_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                Input.Clear();
                Input.Focus();
                function = 2;//2,*
            }

            private void Divide_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                if (temp != 0)
                {
                    Input.Clear();
                    Input.Focus();
                    function = 3;//3,/
                }
                else Input.Text = ("除数不能等于零");
            }

            private void GetResult_Click(object sender, EventArgs e)
            {
                try
                {
                    temp_2 = Convert.ToInt32(Input.Text);
                    Input.Clear();
                    if (function == 0) Input.Text = Convert.ToString(temp + temp_2);
                    else if (function == 1) Input.Text = Convert.ToString(temp - temp_2);
                    else if (function == 2) Input.Text = Convert.ToString(temp * temp_2);
                    else if (function == 3) Input.Text = Convert.ToString(temp / temp_2);
                    else if (function == 4) Input.Text = Convert.ToString(temp % temp_2);
                    else if (function == 5) Input.Text = Convert.ToString(Math.Pow(temp, 1 / temp_2));
                    else Input.Text = Convert.ToString(temp);
                }
                catch (FormatException)
                {
                    MessageBox.Show("非法字符");
                    Input.Clear();
                }
            }

            private void b_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                Input.Clear();
                Input.Focus();
                function = 4;//4,取余数
            }

            private void a_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                if (temp != 0)
                {
                    Input.Clear();
                    Input.Focus();
                    Input.Text = Convert.ToString(1 / temp);
                }
                else Input.Text = ("除数不能等于零");
            }

            private void Change_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                Input.Clear();
                Input.Focus();
                Input.Text = Convert.ToString(temp * -1);
            }

            private void SquareRoot_Click(object sender, EventArgs e)
            {
                temp = Convert.ToInt32(Input.Text);
                Input.Clear();
                Input.Focus();
                function = 5;//5,平方根
            }
    }
}
