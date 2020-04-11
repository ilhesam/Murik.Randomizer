using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random string with specified properties.
    /// </summary>
    public sealed class StringRandomizer : IStringRandomizer
    {
        private readonly Random _random;

        public StringRandomizer()
        {
            _random = new Random();
        }

        #region Properties

        /// <summary>
        /// Can your random string include lowercase letters?
        /// </summary>
        public bool Lowercase { get; set; } = ConstantValues.STRING_LOWERCASE_DEFAULT;

        /// <summary>
        /// Can your random string include uppercase letters?
        /// </summary>
        public bool Uppercase { get; set; } = ConstantValues.STRING_UPPERCASE_DEFAULT;

        /// <summary>
        /// Can your random string include numeric letters?
        /// </summary>
        public bool Numeric { get; set; } = ConstantValues.STRING_NUMERIC_DEFAULT;

        /// <summary>
        /// Can your random string include special letters?
        /// </summary>
        public bool Special { get; set; } = ConstantValues.STRING_SPECIAL_DEFAULT;

        /// <summary>
        /// Can your random string include space letter?
        /// </summary>
        public bool Space { get; set; } = ConstantValues.STRING_SPACE_DEFAULT;

        /// <summary>
        /// Letters that should not exist in random string.
        /// </summary>
        public char[] Without { get; set; } = ConstantValues.STRING_WITHOUT_DEFAULT;

        #endregion

        #region Public Methods

        /// <summary>
        /// This method returns a random string based on default length.
        /// To customize randomize settings, change the properties.
        /// </summary>
        /// <returns>A random string that created based on default length.</returns>
        public string Randomize()
        {
            const int defaultLength = ConstantValues.STRING_DEFAULT_LENGTH;
            return Randomize(defaultLength);
        }

        /// <summary>
        /// This method returns a random string based on specified length.
        /// To customize randomize settings, change the properties.
        /// </summary>
        /// <param name="length">String lentgh.</param>
        /// <returns>A random string that created based on your wishes.</returns>
        public string Randomize(int length)
        {
            if (!Lowercase && !Uppercase && !Numeric && !Special && !Space)
            {
                throw new AllArgumentsAreFalseException(nameof(StringRandomizer), nameof(Randomize));
            }

            var letters = GetLetters();

            if (Without != null)
            {
                letters = RemoveLetters(letters);
            }

            var result = new StringBuilder();

            int min = 0;
            int max = letters.Count - 1;

            for (int i = 0; i < length; i++)
            {
                var randomNumber = _random.Next(min, max);
                var letter = letters[randomNumber];

                result.Append(letter);
            }

            return result.ToString();
        }

        #endregion

        #region Private Methods

        private List<char> RemoveLetters(List<char> letters)
        {
            return letters.Where(e => !Without.Contains(e))
                .ToList();
        }

        private List<char> GetLetters()
        {
            List<char> result = new List<char>();

            if (Lowercase)
            {
                result.AddRange(ConstantValues.LOWERCASE);
            }

            if (Uppercase)
            {
                result.AddRange(ConstantValues.UPPERCASE);
            }

            if (Numeric)
            {
                result.AddRange(ConstantValues.NUMERIC);
            }

            if (Special)
            {
                result.AddRange(ConstantValues.SPECIAL);
            }

            if (Space)
            {
                result.AddRange(ConstantValues.SPACE);
            }

            return result;
        }

        #endregion
    }
}
