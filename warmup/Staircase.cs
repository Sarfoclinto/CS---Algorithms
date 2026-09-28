namespace Algorithms.warmup
{
    internal class Staircase
    {
        public static void staircase(int n)
        {
            for(int numOfSym = 1; numOfSym <= n; numOfSym++)
            {
                for(int i = 0; i < n - numOfSym; i++)
                {
                    Console.Write(" ");
                }
                for(int count = 0; count < numOfSym; count++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
