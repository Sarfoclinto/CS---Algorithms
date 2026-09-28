using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.warmup
{
    internal class BigSum
    {
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach(long num in ar)
            {
                sum += num;
            }
            return sum;
        }
    }
}
