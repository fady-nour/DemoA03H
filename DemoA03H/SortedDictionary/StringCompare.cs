using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoA03H.SortedDictionary
{
    internal class StringCompare : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {

            return y.CompareTo(x);
        }
    }
}
