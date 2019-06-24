using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    public interface IFactory<T>
    {
        T MakeElement();
    }
}
