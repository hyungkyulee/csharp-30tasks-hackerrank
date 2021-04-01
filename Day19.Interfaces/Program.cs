using System;

namespace Day19.Interfaces
{
    public interface AdvancedArithmetic{
        int divisorSum(int n);
    }
    
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            var dividor = 0;
            var share = 0;
            var totalSum = 0;
            while (dividor + 1 <= n / (dividor + 1))
            {
                dividor += 1;
                if (n % dividor != 0) continue;

                share = n / dividor;
                totalSum += (dividor == share) ? dividor : dividor + share;
            }
            return totalSum;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
        }
    }
}