using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Vehicle
    {
        public string _name,_type,_color,_weight,_speed;
        public virtual string Run()
        {
            return null;
        }
        public virtual string stop()
        {
            return null;
        }
    }

    public class Car : Vehicle
    {
        public string Gear;
        public Car(string name,string ctype,string ccolor,string cweigh,string cspeed,string gear)
        {
            base._name = name;
            base._type = ctype;
            base._color = ccolor;
            base._weight = cweigh;
            base._speed = cspeed;
            Gear = gear;
        }
        public override string Run()
        {
            return (base._name + " 正在以 " + base._speed + " km/h 的最高速度行驶.");
        }
        public override string stop()
        {
            return (Convert.ToInt32(base._speed) > 100) ? "请停车" : "正常速度";
        }
    }
}
