using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    public interface IStringRandomizer : IBaseRandomizer<string>
    {
        #region Properties

        bool Lowercase { get; set; }

        bool Uppercase { get; set; }

        bool Numeric { get; set; }

        bool Special { get; set; }

        bool Space { get; set; }

        char[] Without { get; set; }

        #endregion

        #region Methods

        string Randomize(int length);

        #endregion
    }
}
