using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox2ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int save = 0, counter = 0, protect = 0;
            for (int i = 0; i < In.TextLength; i++)
            {
                if (In.Text.Substring(i, 1) == "@")
                {
                    save = i;
                    counter++;
                }
                if (In.Text.Substring(i, 1) == ".")
                {
                    protect++;
                }
            }
            username.Clear();
            domain.Clear();
            if (counter == 0) MessageBox.Show("错误：未检测到 @ 符号");
            else if (protect == 0) MessageBox.Show("错误：未检测到 . 符号");
            else if (counter > 1) MessageBox.Show("错误：检测到多个 @ 符号");
            else if (protect > 1) MessageBox.Show("错误：检测到多个 . 符号");
            else
            {
                //username.Text = In.Text.Substring(0, save);
                //domain.Text = In.Text.Substring(save + 1, In.TextLength - username.TextLength - 1);
                string[] temp = new string[2];
                temp = In.Text.Split('@');
                username.Text = temp[0];
                domain.Text = temp[1];
            }
            protect = 0;
            counter = 0;
        }
    }
}
