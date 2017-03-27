using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uid.TextLength == 15 || uid.TextLength == 18)
            {
                if (uid.TextLength == 15)
                {
                    if (In.Text == "男" && uid.Text.Substring(13, 1) == "1") MessageBox.Show("身份证是 " + uid.Text.Length + "位，\n成功");
                    if (In.Text == "女" && uid.Text.Substring(13, 1) == "2") MessageBox.Show("身份证是 " + uid.Text.Length + "位，\n成功");
                }
                if (uid.TextLength == 18)
                {
                    if (In.Text == "男" && uid.Text.Substring(16, 1) == "1") MessageBox.Show("身份证是 " + uid.Text.Length + "位，\n成功");
                    if (In.Text == "女" && uid.Text.Substring(16, 1) == "2") MessageBox.Show("身份证是 " + uid.Text.Length + "位，\n成功");
                }
            }
            else
            {
                MessageBox.Show("身份证是 "+uid.TextLength+" 位\n错误");
            }
        }
    }
}
