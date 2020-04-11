using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random date time.
    /// </summary>
    public sealed class DateTimeRandomizer : IDateTimeRandomizer
    {
        private readonly Random _random;

        public DateTimeRandomizer()
        {
            _random = new Random();
        }

        /// <summary>
        /// This method is used to get a random date time based on default min and max.
        /// </summary>
        /// <returns>A random date time that created based on default min and max.</returns>
        public DateTime Randomize()
        {
            var min = ConstantValues.DATETIME_DEFAULT_MIN;
            var max = ConstantValues.DATETIME_DEFAULT_MAX;

            return Randomize(min, max);
        }

        /// <summary>
        /// This method is used to get a random date time based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum date time that can exist in result?</param>
        /// <param name="max">What is the maximum date time that can exist in result?</param>
        /// <returns>A random date time that created based on your wishes.</returns>
        public DateTime Randomize(DateTime min, DateTime max)
        {
            if (min >= max)
            {
                throw new MinIsLargerThanOrEqualMaxException(nameof(DateTimeRandomizer), nameof(Randomize), nameof(min));
            }

            var range = max - min;

            var randTimeSpan = new TimeSpan((long)(_random.NextDouble() * range.Ticks));

            return min + randTimeSpan;
        }
    }
}
