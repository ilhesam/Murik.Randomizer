using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This error is used when min is larger than or equal max.
    /// </summary>
    [Serializable]
    public class MinIsLargerThanOrEqualMaxException : ArgumentException
    {
        /// <summary>
        /// Sends the appropriate error message to base class using the requested arguments.
        /// </summary>
        /// <param name="className">The name of the class in which the error occurred.</param>
        /// <param name="methodName">The name of the method in which the error occurred.</param>
        /// <param name="paramName">Minimum parameter name.</param>
        public MinIsLargerThanOrEqualMaxException(string className, string methodName, string paramName)
        : base($"In '{className} -> {methodName}', min is larger than or equal max.", paramName)
        {
        }

        /// <summary>
        /// Sends the appropriate error message to base class using the requested arguments.
        /// </summary>
        /// <param name="className">The name of the class in which the error occurred.</param>
        /// <param name="methodName">The name of the method in which the error occurred.</param>
        public MinIsLargerThanOrEqualMaxException(string className, string methodName)
            : base($"In '{className} -> {methodName}', min is larger than or equal max.")
        {
        }
    }
}
