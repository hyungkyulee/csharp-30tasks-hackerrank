using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Day10.BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var binaryDigits = string.Empty;
            while (n > 0)
            {
                binaryDigits = (n % 2) + binaryDigits;
                n /= 2;
            }
            // Console.WriteLine(binaryDigits);

            var oneGroups = binaryDigits.Split('0');

            var maxOnes = 0;
            foreach (var oneGroup in oneGroups)
            {
                if (oneGroup.Length > maxOnes)
                {
                    maxOnes = oneGroup.Length;
                }
            }
            Console.WriteLine(maxOnes);
        }
    }
}