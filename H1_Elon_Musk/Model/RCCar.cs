using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_Musk
{
    /// <summary>
    /// Class <see cref="RCCar"/> represents a remote controlled car, with multiple arguments
    /// </summary>
    internal class RCCar
    {
        private string _name;
        private string _color;
        private Battery _battery;

        /// <summary>
        /// Initializes a new instance of the <see cref="RCCar"/> class, using multiple arguments
        /// </summary>
        /// <param name="name">name of car</param>
        /// <param name="color">color of car</param>
        /// <param name="battery">battery in the car</param>
        /// <param name="display">display which the car uses</param>
        public RCCar(string name, string color, Battery battery)
        {
            _name = name;
            _color = color;
            _battery = battery;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(value == null)
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

        public Battery Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }
    }
}
