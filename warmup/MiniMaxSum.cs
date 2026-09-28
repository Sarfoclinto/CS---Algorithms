
namespace Algorithms.warmup
{
    internal class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            List<long> sums = [];
            int n = arr.Count;
            for(int skipIndex = 0; skipIndex < n; skipIndex++)
            {
                long sum = 0;
                for(int i = 0; i < n; i++)
                {
                    if (i != skipIndex) sum += arr[i];
                }
                sums.Add(sum);
            }
            Console.Write($"{sums.Min()} {sums.Max()}");
        }
    }
}
