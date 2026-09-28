namespace Algorithms.warmup
{
    internal class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            return candles.Count((val) => val == candles.Max());
        }
    }
}
