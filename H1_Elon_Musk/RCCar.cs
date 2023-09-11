using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_Musk
{
    public class RCCar
    {
        private string _name;
        private string _color;

        public string Name
        {
            get { return _name; }
            set
            {
                if(value != null)
                {
                    _name = value;
                }
            }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
