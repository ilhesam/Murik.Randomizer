using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This class is used to get random values ​​of different types.
    /// Instead of using this class, you can use specific classes to each type.
    /// The methods in this class occupy a lot of memory in excessive use.
    /// You can use the methods of this class for low use.
    /// However, it is still recommended that you do not use the methods in this class.
    /// </summary>
    public static class Randomizer
    {
        private static readonly IStringRandomizer _stringRandomizer = new StringRandomizer();
        private static readonly IIntegerRandomizer _integerRandomizer = new IntegerRandomizer();
        private static readonly IDoubleRandomizer _doubleRandomizer = new DoubleRandomizer();
        private static readonly IDecimalRandomizer _decimalRandomizer = new DecimalRandomizer();
        private static readonly IFloatRandomizer _floatRandomizer = new FloatRandomizer();
        private static readonly ILongRandomizer _longRandomizer = new LongRandomizer();
        private static readonly IShortRandomizer _shortRandomizer = new ShortRandomizer();
        private static readonly IBooleanRandomizer _booleanRandomizer = new BooleanRandomizer();
        private static readonly IDateTimeRandomizer _dateTimeRandomizer = new DateTimeRandomizer();
        private static readonly ICharacterRandomizer _characterRandomizer = new CharacterRandomizer();

        /// <summary>
        /// This method returns a random string based on your wishes.
        /// </summary>
        /// <param name="length">String lentgh.</param>
        /// <param name="lowercase">Can your random string include lowercase letters?</param>
        /// <param name="uppercase">Can your random string include uppercase letters?</param>
        /// <param name="numeric">Can your random string include numeric letters?</param>
        /// <param name="special">Can your random string include special letters?</param>
        /// <param name="space">Can your random string include space letters?</param>
        /// <param name="without">Letters that should not exist in random string.</param>
        /// <returns>A random string that created based on your wishes.</returns>
        public static string String(int length, bool lowercase = ConstantValues.STRING_LOWERCASE_DEFAULT, bool uppercase = ConstantValues.STRING_UPPERCASE_DEFAULT, bool numeric = ConstantValues.STRING_NUMERIC_DEFAULT, bool special = ConstantValues.STRING_SPECIAL_DEFAULT, bool space = ConstantValues.STRING_SPACE_DEFAULT, char[] without = ConstantValues.STRING_WITHOUT_DEFAULT)
        {
            _stringRandomizer.Lowercase = lowercase;
            _stringRandomizer.Uppercase = uppercase;
            _stringRandomizer.Numeric = numeric;
            _stringRandomizer.Special = special;
            _stringRandomizer.Space = space;
            _stringRandomizer.Without = without;

            return _stringRandomizer.Randomize(length);
        }

        /// <summary>
        /// This method returns a random integer based on default min and max.
        /// </summary>
        /// <returns>A random integer that created based on default min and max.</returns>
        public static int Integer() =>
            _integerRandomizer.Randomize();

        /// <summary>
        /// This method returns a random integer based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random integer that created based on your wishes.</returns>
        public static int Integer(int min, int max) =>
            _integerRandomizer.Randomize(min, max);

        /// <summary>
        /// This method returns a random double based on default min and max.
        /// </summary>
        /// <returns>A random double that created based on default min and max.</returns>
        public static double Double() =>
            _doubleRandomizer.Randomize();

        /// <summary>
        /// This method returns a random double based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random double that created based on your wishes.</returns>
        public static double Double(double min, double max) =>
            _doubleRandomizer.Randomize(min, max);

        /// <summary>
        /// This method returns a random decimal based on default min and max.
        /// </summary>
        /// <returns>A random decimal that created based on default min and max.</returns>
        public static decimal Decimal() =>
            _decimalRandomizer.Randomize();

        /// <summary>
        /// This method returns a random decimal based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random decimal that created based on your wishes.</returns>
        public static decimal Decimal(decimal min, decimal max) =>
            _decimalRandomizer.Randomize(min, max);

        /// <summary>
        /// This method returns a random float based on default min and max.
        /// </summary>
        /// <returns>A random float that created based on default min and max.</returns>
        public static float Float() =>
            _floatRandomizer.Randomize();

        /// <summary>
        /// This method returns a random float based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random decimal that created based on your wishes.</returns>
        public static float Float(float min, float max) =>
            _floatRandomizer.Randomize(min, max);

        /// <summary>
        /// This method returns a random long based on default min and max.
        /// </summary>
        /// <returns>A random long that created based on default min and max.</returns>
        public static long Long() =>
            _longRandomizer.Randomize();

        /// <summary>
        /// This method returns a random long based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random long that created based on your wishes.</returns>
        public static long Long(long min, long max) =>
            _longRandomizer.Randomize(min, max);

        /// <summary>
        /// This method returns a random short based on default min and max.
        /// </summary>
        /// <returns>A random short that created based on default min and max.</returns>
        public static short Short() =>
            _shortRandomizer.Randomize();

        /// <summary>
        /// This method returns a random short based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum number that can exist in result?</param>
        /// <param name="max">What is the maximum number that can exist in result?</param>
        /// <returns>A random short that created based on your wishes.</returns>
        public static short Short(short min, short max) =>
            _shortRandomizer.Randomize(min, max);

        /// <summary>
        /// This method returns a random boolean.
        /// </summary>
        /// <returns>A random boolean.</returns>
        public static bool Boolean() =>
            _booleanRandomizer.Randomize();

        /// <summary>
        /// This method returns a random date time based on default min and max.
        /// </summary>
        /// <returns>A random short that created based on default min and max.</returns>
        public static DateTime DateTime() =>
            _dateTimeRandomizer.Randomize();

        /// <summary>
        /// This method returns a random date time based on specified min and max.
        /// </summary>
        /// <param name="min">What is the minimum date time that can exist in result?</param>
        /// <param name="max">What is the maximum date time that can exist in result?</param>
        /// <returns>A random date time that created based on your wishes.</returns>
        public static DateTime DateTime(DateTime min, DateTime max) =>
            _dateTimeRandomizer.Randomize(min, max);

        /// <summary>
        /// This method returns a random character based on your wishes.
        /// </summary>
        /// <param name="lowercase">Can your random character is lowercase letter?</param>
        /// <param name="uppercase">Can your random character is uppercase letter?</param>
        /// <param name="numeric">Can your random character is numeric letter?</param>
        /// <param name="special">Can your random character is special letter?</param>
        /// <param name="space">Can your random character is space letter?</param>
        /// <param name="without">Letters that isn't in random character.</param>
        /// <returns>A random character that created based on your wishes.</returns>
        public static char Character(bool lowercase = ConstantValues.STRING_LOWERCASE_DEFAULT, bool uppercase = ConstantValues.CHAR_UPPERCASE_DEFAULT, bool numeric = ConstantValues.CHAR_NUMERIC_DEFAULT, bool special = ConstantValues.CHAR_SPECIAL_DEFAULT, bool space = ConstantValues.CHAR_SPACE_DEFAULT, char[] without = ConstantValues.CHAR_WITHOUT_DEFAULT)
        {
            _characterRandomizer.Lowercase = lowercase;
            _characterRandomizer.Uppercase = uppercase;
            _characterRandomizer.Numeric = numeric;
            _characterRandomizer.Special = special;
            _characterRandomizer.Space = space;
            _characterRandomizer.Without = without;

            return _characterRandomizer.Randomize();
        }
    }
}
