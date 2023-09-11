using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static H1_Elon_Musk.Battery;

namespace H1_Elon_Musk
{
    /// <summary>
    /// Class <see cref="Controller"/> controls the program and the RC Car
    /// </summary>
    internal class Controller
    {

        Display display = new Display();
        /// <summary>
        /// Starts the controller
        /// </summary>
        public void Start()
        {

            // White Racer RC Car
            Battery whiteRacerBattery = new Battery("AXO819", 100);
            display.BatteryLevel = whiteRacerBattery.Level;
            RCCar whiteRacer = new RCCar("The White Racer", "White", whiteRacerBattery);
            display.UpdateDisplay();

            // Get pressed key by user
            UserInput userInput = new UserInput();
            ConsoleKey key = userInput.GetPressedKey();

            // User input, which checks if the user want drive the car, charge it, or shut the program down.
            while (key != ConsoleKey.Escape)
            {
                switch(key)
                {
                    // Drive car
                    case ConsoleKey.W:
                        Drive(whiteRacer);
                        break;

                    // Charge car
                    case ConsoleKey.C:
                        if (whiteRacer.Battery.State == Battery.BatteryState.Empty)
                        {
                            ChargeRCCar(whiteRacer);
                            display.UpdateDisplay();
                        }
                        break;
                }

                key = userInput.GetPressedKey();
            }
        }

        /// <summary>
        /// Drive the RCCar 20 meters and update the display
        /// </summary>
        /// <param name="rcCar"></param>
        private void Drive(RCCar rcCar)
        {

            // Drives car if the battery isn't empty
            if (rcCar.Battery.State == Battery.BatteryState.Charged)
            {
                rcCar.Battery.Level--;
                display.BatteryLevel = rcCar.Battery.Level;

                display.MetersDriven += 20;

                // Sets the battery state to empty, if the battery level less than 1
                if(rcCar.Battery.Level < 1)
                {
                    rcCar.Battery.State = Battery.BatteryState.Empty;
                }
            }
            display.UpdateDisplay();
        }

        /// <summary>
        /// Fully charges the battery
        /// </summary>
        public void ChargeRCCar(RCCar rcCar)
        {

            rcCar.Battery.State = BatteryState.Charged;
            rcCar.Battery.Level = 100;
            display.BatteryLevel = 100;
            display.MetersDriven = 0;
        }
    }
}
