using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_Musk
{
    /// <summary>
    /// Class <see cref="Battery"/> represents a battery, which an instance of <see cref="RCCar"/> uses for driving and displaying
    /// </summary>
    internal class Battery
    {
        private string _modelNumber;
        private byte _capacity;
        private byte _level;
        private BatteryState _state;

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class, using multiple arguments
        /// </summary>
        /// <param name="modelNumber">model number of the battery</param>
        /// <param name="capacity">the max capacity</param>
        public Battery(string modelNumber, byte capacity)
        {
            _modelNumber = modelNumber;
            _capacity = capacity;

            // Has to be the same as the capacity because its a new battery
            _level = capacity;

            // The state is charged because its fully charged
            _state = BatteryState.Charged;
        }

        public string ModelNumber
        {
            get { return _modelNumber; }
        }

        public byte Capacity
        {
            get { return _capacity; }
        }

        public byte Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public BatteryState State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// Different battery states
        /// </summary>
        public enum BatteryState
        {
            Charged,
            Empty
        }

    }
}
