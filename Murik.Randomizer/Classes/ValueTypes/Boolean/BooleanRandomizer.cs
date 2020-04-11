using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random boolean.
    /// </summary>
    public class BooleanRandomizer : IBooleanRandomizer
    {
        private readonly Random _random;

        public BooleanRandomizer()
        {
            _random = new Random();
        }

        /// <summary>
        /// This method is used to get a random boolean.
        /// </summary>
        /// <returns>A random boolean.</returns>
        public bool Randomize()
        {
            var result = _random.Next(0, 1);

            return Convert.ToBoolean(result);
        }
    }
}
