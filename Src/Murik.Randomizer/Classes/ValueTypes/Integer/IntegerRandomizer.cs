using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random integer.
    /// </summary>
    public sealed class IntegerRandomizer : IIntegerRandomizer
    {
        private readonly Random _random;

        public IntegerRandomizer()
        {
            _random = new Random();
        }

        /// <summary>
        /// This method is used to get a random integer based on default min and max.
        /// </summary>
        /// <returns>A random integer that created based on default min and max.</returns>
        public int Randomize()
        {
            const int min = ConstantValues.INTEGER_DEFAULT_MIN;
            const int max = ConstantValues.INTEGER_DEFAULT_MAX;

            return Randomize(min, max);
        }

        /// <summary>
        /// This method is used to get a random integer based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random integer that created based on your wishes.</returns>
        public int Randomize(int min, int max)
        {
            if (min >= max)
            {
                throw new MinIsLargerThanOrEqualMaxException(nameof(IntegerRandomizer), nameof(Randomize), nameof(min));
            }

            var result = _random.Next(min, max);

            return result;
        }
    }
}
