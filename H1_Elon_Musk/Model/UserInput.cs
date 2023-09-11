using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Elon_Musk
{
    /// <summary>
    /// Class <see cref="UserInput"/> represents all input from user
    /// </summary>
    internal class UserInput
    {
        /// <summary>
        /// Gets the pressed key by the user
        /// </summary>
        /// <returns>The key which the user pressed</returns>
        public ConsoleKey GetPressedKey()
        {
            return Console.ReadKey(true).Key;
        }
    }
}
