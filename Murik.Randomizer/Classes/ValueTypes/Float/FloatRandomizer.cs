using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random float.
    /// </summary>
    public sealed class FloatRandomizer : IFloatRandomizer
    {
        private readonly Random _random;

        public FloatRandomizer()
        {
            _random = new Random();
        }

        /// <summary>
        /// This method is used to get a random float based on default min and max.
        /// </summary>
        /// <returns>A random float that created based on default min and max.</returns>
        public float Randomize()
        {
            const float min = ConstantValues.FLOAT_DEFAULT_MIN;
            const float max = ConstantValues.FLOAT_DEFAULT_MAX;

            return Randomize(min, max);
        }

        /// <summary>
        /// This method is used to get a random float based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random float that created based on your wishes.</returns>
        public float Randomize(float min, float max)
        {
            if (min >= max)
            {
                throw new MinIsLargerThanOrEqualMaxException(nameof(FloatRandomizer), nameof(Randomize), nameof(min));
            }

            var result = (float)_random.NextDouble();

            return result * (min - max) + min;
        }
    }
}
