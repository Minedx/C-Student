using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_OOC
{
    public class Animal
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       virtual public string borrow()
       {
           return "动物行为：";
       }
    }
    public class Mouse : Animal
    {
        public Mouse()
        {
            base.Name = "老鼠";
        }
        public override string borrow()
        {
 	        return base.borrow()+"老鼠的儿子会打洞";
        }
    }
}
