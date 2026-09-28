using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.warmup
{
    internal class CompareTriplet
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0, bob = 0;
            for(int i = 0; i < 3; i++)
            {
                if (a[i] > b[i]) alice++;
                else if (b[i] > a[i]) bob++;
            }
            return [alice, bob];
        }
    }
}
