using System;
using System.Collections.Generic;
using System.Text;

namespace Murik.Randomizer
{
    public interface INumberRandomizer<T> : IBaseRandomizer<T> where T : struct
    {
        T Randomize(T min, T max);
    }
}
