using System;
using System.Collections.Generic;
using System.IO;

namespace Day29.BitwiseAND
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("./"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int count = Convert.ToInt32(firstMultipleInput[0]);

                int lim = Convert.ToInt32(firstMultipleInput[1]);

                int res = BitwiseAnd(count, lim);

                // textWriter.WriteLine(res);
                Console.WriteLine(res);
            }

            // textWriter.Flush();
            // textWriter.Close();
        }

        private static int BitwiseAnd(int count, int limit)
        {
            var number = new int[count];
            for (var i = 0; i < count; i++)
            {
                number[i] = i + 1;
            }

            var maxValue = 0;
            for (var j = 0; j < count - 1; j++)
            {
                for (var k = j + 1; k < count; k++)
                {
                    var bitwiseResult = number[j] & number[k];
                    if (maxValue < bitwiseResult && bitwiseResult < limit) maxValue = bitwiseResult;
                }
            }
            
            return maxValue;
        }
    }
}