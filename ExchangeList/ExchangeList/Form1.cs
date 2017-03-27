using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeList
{
    public partial class Form1 : Form
    {
        public int[] a = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Input.Items.Clear();
            //Input.Items.Add(0);
            //Input.Items.Add(1);
            //Input.Items.Add(2);
            //Input.Items.Add(3);
            //Input.Items.Add(4);
            //Input.Items.Add(5);
            //Input.Items.Add(6);
            //Input.Items.Add(7);
            //Input.Items.Add(8);
            //Input.Items.Add(9);
            Input.Items.Clear();
            for (int i = 10; i > 0; i--)
            {
                Input.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //short temp1=0;
            //for (short temp = 10; temp > 0; temp--)
            //{
            //    a[temp - 1] = Convert.ToInt32(Input.Items[temp1].ToString());
            //    temp1++;
            //}
            //    Output.Items.Clear();
            //for (short temp_2 = 0; temp_2 < 10; temp_2++)
            //{
            //    Output.Items.Add(a[temp_2]);
            //}
            for (int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Input.Items[i].ToString());
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp=a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Output.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                Output.Items.Add(a[i]);
            }
        }
    }
}
