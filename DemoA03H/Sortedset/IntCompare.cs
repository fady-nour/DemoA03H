using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoA03H.Sortedset
{
    internal class IntCompare : IComparer<int>
    {
        public int Compare(int x, int y)
        {
           return y.CompareTo(x);
        }
    }
}
