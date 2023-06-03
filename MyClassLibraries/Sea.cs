using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Sea : Vehicle
    {
        public enum Type { Ferry, Ship, Yatch, Submarine };

        Type _type;


        public Sea(string color, string type) : base(color)
        {

            if (type == "Ferry")
            {
                _type = Type.Ferry;
            }
            if (type == "Ship")
            {
                _type = Type.Ship;
            }
            if (type == "Yatch")
            {
                _type = Type.Yatch;
            }
            if (type == "Submarine")
            {
                _type = Type.Submarine;
            }

        }
        internal Type Type1 { get => _type; set => _type = value; }

        public override string ToString()
        {
            return base.ToString() + $" - It is a {Type1}";
        }
    }//class
}//namespace

