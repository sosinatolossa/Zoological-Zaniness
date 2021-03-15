using System;
using System.Collections.Generic;

namespace Zoological_Zaniness
{
    public interface ISwimming
    {
        int MaximumDepth { get; }
        void Swim();
    }
}