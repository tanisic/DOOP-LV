using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    interface IAbstractCollectionProduct
    {
        IAbstractIteratorProduct GetIterator();
    }
}
