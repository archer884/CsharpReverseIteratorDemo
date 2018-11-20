using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Reverse;

namespace demo
{
    class Program
    {
        static int Seconds = 1000; // Multiplier for milliseconds

        static IEnumerable<int> LetMeReallyFuckThisUp()
        {
            Thread.Sleep(1 * Seconds);
            for (var i = 1; i <= 100; ++i)
                yield return i;
        }

        static void Main(string[] args)
        {
            var sequence = LetMeReallyFuckThisUp();
            var reversed = sequence.ReverseSeq();

            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}
