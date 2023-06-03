using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Air : Vehicle
    {
        public Air(string color) : base(color)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }//class
}//namespace
