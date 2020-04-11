using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    /// <summary>
    /// This error is used when all boolean arguments are false.
    /// </summary>
    [Serializable]
    internal class AllArgumentsAreFalseException : ArgumentException
    {
        /// <summary>
        /// Sends the appropriate error message to base class using the requested arguments.
        /// </summary>
        /// <param name="className">The name of the class in which the error occurred</param>
        /// <param name="methodName">The name of the method in which the error occurred</param>
        public AllArgumentsAreFalseException(string className, string methodName)
        : base($"All '{className} -> {methodName}' method arguments are false.")
        {

        }
    }
}
