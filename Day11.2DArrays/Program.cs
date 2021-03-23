using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11._2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            var hourglasses = new List<int>();
            var hourglassSum = 0;
            for (int j=0; j<6-2; j++)
            {
                for (int k = 0; k < 6-2; k++)
                {
                    // read slot data 3-1-3
                    for (int s = 0; s < 3; s++) 
                    {
                        hourglassSum += arr[j][k + s];
                    }
                    
                    hourglassSum += arr[j+1][k+1];
                    
                    for (int s = 0; s < 3; s++) 
                    {
                        hourglassSum += arr[j+2][k + s];
                    }
                    hourglasses.Add(hourglassSum);
                    hourglassSum = 0;
                }
            }

            var sortedHourglasses = hourglasses.OrderByDescending(x => x).ToList();
            Console.WriteLine(sortedHourglasses.First());
            // foreach (var sortedHourglass in sortedHourglasses)
            // {
            //     Console.WriteLine(sortedHourglass);
            // }
        }
    }
}