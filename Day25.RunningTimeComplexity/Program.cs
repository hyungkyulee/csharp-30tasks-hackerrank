using System;
using System.Threading.Channels;

namespace Day25.RunningTimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            while (count-- > 0)
            {
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPrimeNumber(number) ? "Prime" : "Not prime");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (var i = 3; i <= Math.Floor(Math.Sqrt(number)); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}