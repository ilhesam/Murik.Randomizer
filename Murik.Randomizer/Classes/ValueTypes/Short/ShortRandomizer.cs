using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random short.
    /// </summary>
    public sealed class ShortRandomizer : IShortRandomizer
    {
        private readonly Random _random;

        public ShortRandomizer()
        {
            _random = new Random();
        }

        /// <summary>
        /// This method is used to get a random short based on default min and max.
        /// </summary>
        /// <returns>A random short that created based on default min and max.</returns>
        public short Randomize()
        {
            const short min = ConstantValues.SHORT_DEFAULT_MIN;
            const short max = ConstantValues.SHORT_DEFAULT_MAX;

            return Randomize(min, max);
        }

        /// <summary>
        /// This method is used to get a random short based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random short that created based on your wishes.</returns>
        public short Randomize(short min, short max)
        {
            if (min >= max)
            {
                throw new MinIsLargerThanOrEqualMaxException(nameof(ShortRandomizer), nameof(Randomize), nameof(min));
            }

            var result = (short) _random.Next(min, max);

            return result;
        }
    }
}
