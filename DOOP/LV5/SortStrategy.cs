﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
   abstract class SortStrategy
    {
        public abstract void Sort(double[] array);
        protected void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
