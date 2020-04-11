using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random double.
    /// </summary>
    public sealed class DoubleRandomizer : IDoubleRandomizer
    {
        private readonly Random _random;

        public DoubleRandomizer()
        {
            _random = new Random();
        }

        /// <summary>
        /// This method is used to get a random double based on default min and max.
        /// </summary>
        /// <returns>A random double that created based on default min and max.</returns>
        public double Randomize()
        {
            const double min = ConstantValues.DOUBLE_DEFAULT_MIN;
            const double max = ConstantValues.DOUBLE_DEFAULT_MAX;

            return Randomize(min, max);
        }

        /// <summary>
        /// This method is used to get a random double based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random double that created based on your wishes.</returns>
        public double Randomize(double min, double max)
        {
            if (min >= max)
            {
                throw new MinIsLargerThanOrEqualMaxException(nameof(DoubleRandomizer), nameof(Randomize), nameof(min));
            }

            var result = _random.NextDouble();

            return result * (max - min) + min;
        }
    }
}
