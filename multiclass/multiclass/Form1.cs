using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TrafficTool tt = new TrafficTool("a","b");
            Plane plane = tt;
            Train train = tt;
            string s = tt.ToString() + plane.fly() + train.run();
            label1.Text = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Vehicle { public string Name, Type;}

    public interface Plane { string fly(); }
    public interface Train { string run(); }

    public class TrafficTool : Vehicle, Plane, Train
    {
        string Plane.fly()
        {
            return "能飞,";
        }
        string Train.run()
        {
            return "能跑,";
        }
        public TrafficTool(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public override string ToString()
        {
            return "名字: " + Name + ",类型: " + Type + ",";
        }
    }
}
