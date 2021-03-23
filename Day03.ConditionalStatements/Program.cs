using System;
using System.Linq;

namespace Day03.ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (Enumerable.Range(2, 3).Contains(N))
                {
                    Console.WriteLine("Not Weird");
                }
                else if (Enumerable.Range(6, 15).Contains(N))
                {
                    Console.WriteLine("Weird");
                }
                else if (N > 20)
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}