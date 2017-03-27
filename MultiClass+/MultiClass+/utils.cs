using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClass_
{
    public class Person
    {
        public string Name = null, sex = null, Age = null;
    }

    public class Student : Person
    {
        public string Sn, Class;
        public int LangC, Eng, Math, Chinese, Average;
        public Student() { }
        public Student(string name, string sex, string age, string sn, string aclass, string langc, string eng, string math, string chinese)
        {
            base.Name = name;
            base.sex = sex;
            base.Age = age;
            Sn = sn;
            Class = aclass;
            LangC = Convert.ToInt32(langc);
            Eng = Convert.ToInt32(eng);
            Math = Convert.ToInt32(math);
            Chinese = Convert.ToInt32(chinese);
            Average = (Eng + Math + Chinese + LangC) / 4;
        }
    }
}