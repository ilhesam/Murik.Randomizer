using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// Constant values of Project.
    /// </summary>
    internal static class ConstantValues
    {
        #region String

        #region Letters

        internal const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        internal const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        internal const string NUMERIC = "0123456789";
        internal const string SPECIAL = @"!#$%&*@\/.-";
        internal const string SPACE = " ";

        #endregion

        internal const int STRING_DEFAULT_LENGTH = 21;

        internal const bool STRING_LOWERCASE_DEFAULT = true;
        internal const bool STRING_UPPERCASE_DEFAULT = true;
        internal const bool STRING_NUMERIC_DEFAULT = true;
        internal const bool STRING_SPECIAL_DEFAULT = true;
        internal const bool STRING_SPACE_DEFAULT = false;
        internal const char[] STRING_WITHOUT_DEFAULT = null;

        #endregion

        #region Double

        internal const double DOUBLE_DEFAULT_MIN = 0;
        internal const double DOUBLE_DEFAULT_MAX = double.MaxValue;

        #endregion

        #region Integer

        internal const int INTEGER_DEFAULT_MIN = 0;
        internal const int INTEGER_DEFAULT_MAX = int.MaxValue;

        #endregion

        #region Decimal

        internal const decimal DECIMAL_DEFAULT_MIN = 0;
        internal const decimal DECIMAL_DEFAULT_MAX = decimal.MaxValue;

        #endregion

        #region Float

        internal const float FLOAT_DEFAULT_MIN = 0;
        internal const float FLOAT_DEFAULT_MAX = float.MaxValue;

        #endregion

        #region Long

        internal const long LONG_DEFAULT_MIN = 0;
        internal const long LONG_DEFAULT_MAX = long.MaxValue;

        #endregion

        #region Short

        internal const short SHORT_DEFAULT_MIN = 0;
        internal const short SHORT_DEFAULT_MAX = short.MaxValue;

        #endregion

        #region DateTime

        internal static readonly DateTime DATETIME_DEFAULT_MIN = DateTime.MinValue;
        internal static readonly DateTime DATETIME_DEFAULT_MAX = DateTime.MaxValue;

        #endregion

        #region Character

        internal const bool CHAR_LOWERCASE_DEFAULT = true;
        internal const bool CHAR_UPPERCASE_DEFAULT = true;
        internal const bool CHAR_NUMERIC_DEFAULT = false;
        internal const bool CHAR_SPECIAL_DEFAULT = false;
        internal const bool CHAR_SPACE_DEFAULT = false;
        internal const char[] CHAR_WITHOUT_DEFAULT = null;

        #endregion
    }
}
