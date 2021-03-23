using System;
using System.Linq;

namespace Day14.Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            var a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();
            
            Console.Write(d.maximumDifference);
        }
    }

    internal class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            elements = a;
        }

        public void computeDifference()
        {
            for (var i = 0; i < elements.Length - 1; i++)
            {
                for (var j = i + 1; j < elements.Length; j++)
                {
                    var absValue = Math.Abs(elements[i] - elements[j]);
                    if(maximumDifference < absValue) maximumDifference = absValue;    
                }
            }
        }
    }
}