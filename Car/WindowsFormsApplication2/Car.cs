using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Car
    {
        private string Name,Type,Color,Weigh,Speed;
        public Car(string CarName,string CarType,string CarColor,string CarWeight,string CarSpeed)
        {
            Name = CarName;
            Type = CarType;
            Color = CarColor;
            Weigh = CarWeight;
            Speed = CarSpeed;
        }
        public string getName()
        {
            return Name;
        }
        public string getType()
        {
            return Type;
        }
        public string getColor()
        {
            return Color;
        }
        public string getWeigh()
        {
            return (Weigh+" 吨");
        }
        public string getSpeed()
        {
            return (Speed + " km/h");
        }
    }
}
