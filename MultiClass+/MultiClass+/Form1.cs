using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultiClass_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Title.Text = "新增学生";//设置新窗口大标题
            Title.Visible = true;//新窗口标题显示
            button1.Text = "确认新增学生";//设置按钮文字
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex >= 0)  listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (listView1.SelectedItems.Count > 0) listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                Title.Text = "新增学生";//设置新窗口大标题
                Title.Visible = true;//新窗口标题显示
                button1.Text = "确认新增学生";//设置按钮文字
                Student student = new Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
                ListViewItem item = new ListViewItem(student.Name);//ListViewItem
                item.SubItems.Add(student.sex);
                item.SubItems.Add(student.Age);
                item.SubItems.Add(student.Sn);
                item.SubItems.Add(student.Class);
                item.SubItems.Add(student.LangC.ToString());
                item.SubItems.Add(student.Eng.ToString());
                item.SubItems.Add(student.Math.ToString());
                item.SubItems.Add(student.Chinese.ToString());
                item.SubItems.Add(student.Average.ToString());
                item.SubItems.Add("0");
                listView1.Items.Add(item);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }
            else MessageBox.Show("存在留空");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FileStream newFile = new FileStream("Save.json",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            //StreamReader reader = new StreamReader
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Title.Text = "修改学生";//重新设置新窗口大标题
                Title.Visible = true;//新窗口标题显示
                button1.Text = "确认修改学生";//设置按钮文字
                ListViewItem item = new ListViewItem();
                item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[3].Text;
                textBox5.Text = item.SubItems[4].Text;
                textBox6.Text = item.SubItems[5].Text;
                textBox7.Text = item.SubItems[6].Text;
                textBox8.Text = item.SubItems[7].Text;
                textBox9.Text = item.SubItems[8].Text;
                listView1.Items.Remove(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = String.Empty;
            StudentPlus[] arr = new StudentPlus[listView1.Items.Count];
            ListViewItem[] temp = new ListViewItem[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                arr[i] = new StudentPlus(Convert.ToInt32(listView1.Items[i].SubItems[5].Text)+ Convert.ToInt32(listView1.Items[i].SubItems[6].Text)+ Convert.ToInt32(listView1.Items[i].SubItems[7].Text)+ Convert.ToInt32(listView1.Items[i].SubItems[8].Text)/4, listView1.Items[i].Text);
            }
            Array.Sort(arr);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Items.Count; i++)
                {
                    if (arr[j].ID == i)
                    {
                        listView1.Items[j] = temp[i];
                        temp[i].SubItems[10].Text = i.ToString();
                    }
                }
            }
            listView1.Clear();
            for(int i = 0; i < temp.Length;i++)
            {
                listView1.Items.Add(temp[i]);
            }
        }
        public class StudentPlus : ListViewItem,IComparable
        {
            private int sid;
            public string name; 
            public StudentPlus(int sid, string name)
            {
                this.sid = sid;
                this.name = name;
            }
            public int ID
            {
                get { return sid; }
                set { sid = value; }
            }
            int IComparable.CompareTo(object obj)
            {
                StudentPlus s = (StudentPlus)obj;
                if (this.sid > s.sid) return 1;
                if (this.sid < s.sid) return -1;
                else return 0;
            }
        }
        //{
        //    int[] save = new int[listView1.Items.Count];
        //    int[] save_ = new int[listView1.Items.Count];
        //    try
        //    {
        //        for (int i = 0; i < listView1.Items.Count; i++)
        //        {
        //            save[i] = Convert.ToInt32(listView1.Items[i].SubItems[5].Text) + Convert.ToInt32(listView1.Items[i].SubItems[6].Text) + Convert.ToInt32(listView1.Items[i].SubItems[7].Text) + Convert.ToInt32(listView1.Items[i].SubItems[8].Text);
        //        }
        //        for (int i = 0; i < save.Length; i++) save_[i] = save[i];
        //        //MessageBox.Show((save[0].ToString() + " " + save[1].ToString() + " " + save[2].ToString()));//debug
        //        for (int i = 0; i < save.Length; i++)
        //        {
        //            for (int j = save.Length - 1; j > i; j--)
        //            { 
        //                if (save[j] > save[j - 1])
        //                {
        //                    int temp;
        //                    temp = save[j];
        //                    save[j] = save[j - 1];
        //                    save[j - 1] = temp;
        //                }
        //            } 
        //        }
        //        //MessageBox.Show((save[0].ToString() + " " + save[1].ToString() + " " + save[2].ToString()));//debug
        //        //MessageBox.Show((save_[0].ToString() + " " + save_[1].ToString() + " " + save_[2].ToString()));//debug
        //        //MessageBox.Show(listView1.Items[0].SubItems.Count.ToString());//debug
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        //    for (int i = 0; i < save.Length; i++)
        //    {
        //        for (int j = 0; j < save.Length; j++)
        //        {
        //            if (save[i] == save_[j])
        //            {
        //                listView1.Items[j].SubItems[10].Text = (i+1).ToString();
        //            }
        //        }
        //    }
        //}
    }
}