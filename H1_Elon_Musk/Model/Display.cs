using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_Musk
{
    /// <summary>
    /// Class <see cref="Display"/> represents a display, which an instance of <see cref="RCCar"/> uses for displaying
    /// </summary>
    internal class Display
    {
        private ushort _metersDriven;
        private Battery _battery;

        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class, using multiple arguments
        /// </summary>
        /// <param name="metersDriven">meters the <see cref="RCCar"/> has driven</param>
        /// <param name="batteryLevel">battery level of the <see cref="RCCar"/>'s battery level</param>
        public Display(ushort metersDriven, Battery battery)
        {
            _metersDriven = metersDriven;
            _battery = battery;
        }

        public ushort MetersDriven
        {
            get { return _metersDriven; }
            set { _metersDriven = value; }
        }

        public Battery Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }

        /// <summary>
        /// Updates the <see cref="RCCar"/>'s display
        /// </summary>
        public void UpdateDisplay(Battery.BatteryState state)
        {
            Console.Clear();

            // When the battery is charged
            if (state == Battery.BatteryState.Charged)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bilen har kørt: " + _metersDriven + " meter");
                Console.WriteLine("Battries kan holde til: " + _battery.Level*20 + " meter");
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
