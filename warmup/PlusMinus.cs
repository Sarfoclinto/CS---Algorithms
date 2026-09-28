
namespace Algorithms.warmup
{
    internal class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            int pos = 0, neg = 0, zero = 0;
            foreach(int num in arr)
            {
                if (num > 0) pos++;
                else if (num < 0) neg++;
                else zero++;
            }
            double n = arr.Count;
            Console.WriteLine($"{(pos / n):f6}");
            Console.WriteLine($"{(neg / n):f6}");
            Console.WriteLine($"{(zero / n):f6}");
        }
    }
}
