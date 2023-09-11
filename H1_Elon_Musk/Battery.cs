using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_Musk
{
    internal class Battery
    {
        private string _manufacturer;
        private string _modelNumber;
        private byte _capacity;
        private byte _level;

        public Battery(string manufacturer, string modelNumber, byte capacity, byte level)
        {
            _manufacturer = manufacturer;
            _modelNumber = modelNumber;
            _capacity = capacity;
            _level = level;
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
        }
    }
}
