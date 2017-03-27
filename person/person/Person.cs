using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Person
    {
        public string name, year, gender;
        public Person() { }
        public Person(string _name, string _year, string _gender) { }
    }
    class Student : Person
    {
        public string number;
        public double a1, a2, a3, a4, a5;
        public Student(string _name, string _year, string _gender, string _number, string c1, string c2, string c3, string c4, string c5)
        {
            base.name = _name;
            base.year = _year;
            base.gender = _gender;
            number = _number;
            a1 = Convert.ToDouble(c1);
            a2 = Convert.ToDouble(c2);
            a3 = Convert.ToDouble(c3);
            a4 = Convert.ToDouble(c4);
            a5 = Convert.ToDouble(c5);
        }
        public string average()
        {
            return Convert.ToString((a1 + a2 + a3 + a4 + a5) / 5); 
        }
    }
}
