using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.warmup
{
    internal class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int len = arr.Count;
            int leftSum = 0, rightSum = 0;
            for(int i = 0, n = len - 1; i < len; i++, n--)
            {
                leftSum += arr[i][i];
                rightSum += arr[i][n];
            }
            return Math.Abs(leftSum - rightSum);
        }
    }
}
