using System;

namespace Day07.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            
            var size = Convert.ToInt32(Console.ReadLine());
            var data = Console.ReadLine();
            if (data == null) return;
            var numbers = data.Split(" ");

            var outBuffer = new string[size];
            for (int i = 0; i < size; i++)
            {
                outBuffer[i] = numbers[size - i - 1];
            }
            Console.WriteLine(string.Join(" ", outBuffer));
        }
    }
}