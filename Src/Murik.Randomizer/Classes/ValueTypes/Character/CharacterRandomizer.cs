using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get a random character with specified properties.
    /// </summary>
    public sealed class CharacterRandomizer : ICharacterRandomizer
    {
        private readonly Random _random;

        public CharacterRandomizer()
        {
            _random = new Random();
        }

        #region Properties

        /// <summary>
        /// Can your random character is lowercase letter?
        /// </summary>
        public bool Lowercase { get; set; } = ConstantValues.CHAR_LOWERCASE_DEFAULT;

        /// <summary>
        /// Can your random character is uppercase letter?
        /// </summary>
        public bool Uppercase { get; set; } = ConstantValues.CHAR_UPPERCASE_DEFAULT;

        /// <summary>
        /// Can your random character is numeric letter?
        /// </summary>
        public bool Numeric { get; set; } = ConstantValues.CHAR_NUMERIC_DEFAULT;

        /// <summary>
        /// Can your random character is special letter?
        /// </summary>
        public bool Special { get; set; } = ConstantValues.CHAR_SPECIAL_DEFAULT;

        /// <summary>
        /// Can your random character is space letter?
        /// </summary>
        public bool Space { get; set; } = ConstantValues.CHAR_SPACE_DEFAULT;

        /// <summary>
        /// Letters that isn't in random character.
        /// </summary>
        public char[] Without { get; set; } = ConstantValues.CHAR_WITHOUT_DEFAULT;

        #endregion

        #region Public Methods

        /// <summary>
        /// This method returns a random character.
        /// To customize randomize settings, change the properties.
        /// </summary>
        /// <returns>A random character that created based on your wishes.</returns>
        public char Randomize()
        {
            if (!Lowercase && !Uppercase && !Numeric && !Special && !Space)
            {
                throw new AllArgumentsAreFalseException(nameof(CharacterRandomizer), nameof(Randomize));
            }

            var letters = GetLetters();

            if (Without != null)
            {
                letters = RemoveLetters(letters);
            }

            int min = 0;
            int max = letters.Count - 1;

            var randomNumber = _random.Next(min, max);

            var result = letters[randomNumber];

            return result;
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
