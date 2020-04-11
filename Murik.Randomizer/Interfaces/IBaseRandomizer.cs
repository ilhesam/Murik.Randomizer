using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    public interface IBaseRandomizer<out T>
    {
        T Randomize();
    }
}
