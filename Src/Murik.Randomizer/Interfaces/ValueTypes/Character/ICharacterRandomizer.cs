using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    public interface ICharacterRandomizer : IBaseRandomizer<char>
    {
        bool Lowercase { get; set; }

        bool Uppercase { get; set; }

        bool Numeric { get; set; }

        bool Special { get; set; }

        bool Space { get; set; }

        char[] Without { get; set; }
    }
}
