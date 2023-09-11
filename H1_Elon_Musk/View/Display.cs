using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_Musk
{
    /// <summary>
    /// Class <see cref="Display"/> represents a display
    /// </summary>
    internal class Display
    {
        private ushort _metersDriven;
        private ushort _batteryLevel;

        public ushort MetersDriven
        {
            get { return _metersDriven; }
            set { _metersDriven = value; }
        }

        public ushort BatteryLevel
        {
            get { return _batteryLevel; }
            set { _batteryLevel = value; }
        }

        /// <summary>
        /// Updates the GUI or also called Display
        /// </summary>
        public void UpdateDisplay()
        {
            Console.Clear();

            // When the battery is charged
            if (_batteryLevel > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bilen har kørt: " + _metersDriven + " meter");
                Console.WriteLine("Battries kan holde til: " + _batteryLevel*20 + " meter");
            }

            // When the battery is empty
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vil du oplade batteriet, da det er tomt?");
                Console.WriteLine("Så tryk C");
            }
            Console.ResetColor();
        }
    }
}
