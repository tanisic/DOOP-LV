using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    interface IAbstractIteratorProduct
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
