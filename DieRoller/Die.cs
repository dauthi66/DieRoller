using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    //represents a single six sided die (1-6)
    internal class Die
    {
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// the current face up value of the die to use
        /// </summary>
        public byte FaceUpValue { get; private set; }
        /// <summary>
        /// True if the user chooses to hold the die
        /// </summary>
        public bool IsHeld {  get; set; }

        /// <summary>
        /// "Rolls" a die by returning a random number 1-6 
        /// </summary>
        /// <returns>Returns a new random number 1-6</returns>
        public byte Roll()
        {
            Random random = new();
            byte FaceUpValue = (byte)random.Next(1, 7);
            return FaceUpValue;
        }
    }
}
