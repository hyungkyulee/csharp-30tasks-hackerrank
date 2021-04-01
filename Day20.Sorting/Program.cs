using System;

namespace Day20.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);

            var totalSwaps = 0;
            while (true)
            {
                var numSwaps = 0;
                for (var i = 0; i < n - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        // Swap(ref a[i], ref a[i + 1]);
                        (a[i], a[i + 1]) = (a[i + 1], a[i]);
                        numSwaps++;
                        totalSwaps++;
                    }
                }

                if (numSwaps == 0)
                {
                    break;
                }
            }
            
            Console.WriteLine($"Array is sorted in {totalSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[n-1]}");
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T temp = y;
            y = x;
            x = temp;
        }
    }
}