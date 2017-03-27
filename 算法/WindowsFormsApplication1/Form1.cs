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
            //Q1
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 1 && i % 7 == 5 && i % 5 == 0)
                {
                    Q1.Text = Convert.ToString(i);
                }
            }
            //Q2
            Q2.Items.Clear();
            for (short a = 1; a < 10; a++)
            {
                for (short b = 0; b <= 10; b++)
                {
                    for (short c = 0; c <= 10; c++)
                    {
                        for (short d = 0; d <= 10; d++)
                        {
                            if (a * 1000 + b * 100 + c * 10 + d == Math.Pow(a, 4) + Math.Pow(b, 4) + Math.Pow(c, 4) + Math.Pow(d, 4)) Q2.Items.Add(a * 1000 + b * 100 + c * 10 + d);
                        }
                    }
                }
            }
            //Q2.New
            Q2_New.Items.Clear();
            for (int i = 1000; i < 10000; i++)
            {
                int a = i % 10;
                int b = i / 10 % 10;
                int c = i / 100 % 10;
                int d = i / 1000;
                a = Convert.ToInt32(Math.Pow(a, 4));
                b = Convert.ToInt32(Math.Pow(b, 4));
                c = Convert.ToInt32(Math.Pow(c, 4));
                d = Convert.ToInt32(Math.Pow(d, 4));
                if (a + b + c + d == i) Q2_New.Items.Add(i);
            }
        }
    }
}
