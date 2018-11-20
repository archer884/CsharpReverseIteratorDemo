using System;
using System.Linq;
using Reverse;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Enumerable.Range(1, 100);
            var reversed = sequence.ReverseSeq();

            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}
