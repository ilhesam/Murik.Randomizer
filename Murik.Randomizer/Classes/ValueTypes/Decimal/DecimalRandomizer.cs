using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random decimal.
    /// </summary>
    public sealed class DecimalRandomizer : IDecimalRandomizer
    {
        private readonly Random _random;

        public DecimalRandomizer()
        {
            _random = new Random();
        }

        /// <summary>
        /// This method is used to get a random decimal based on default min and max.
        /// </summary>
        /// <returns>A random decimal that created based on default min and max.</returns>
        public decimal Randomize()
        {
            const decimal min = ConstantValues.DECIMAL_DEFAULT_MIN;
            const decimal max = ConstantValues.DECIMAL_DEFAULT_MAX;

            return Randomize(min, max);
        }

        /// <summary>
        /// This method is used to get a random decimal based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random decimal that created based on your wishes.</returns>
        public decimal Randomize(decimal min, decimal max)
        {
            if (min >= max)
            {
                throw new MinIsLargerThanOrEqualMaxException(nameof(DecimalRandomizer), nameof(Randomize), nameof(min));
            }

            var result = (decimal)_random.NextDouble();

            return result * (max - min) + min;
        }
    }
}
