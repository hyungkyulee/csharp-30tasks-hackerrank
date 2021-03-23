using System;

namespace Day17.MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator=new  Calculator();
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]); 
                try{
                    int ans=myCalculator.power(n,p);
                    Console.WriteLine(ans);
                }
                catch(Exception e){
                    Console.WriteLine(e.Message);

                }
            }
        }
    }

    internal class Calculator
    {
        public int power(int number, int exponent)
        {
            if (number < 0 || exponent < 0)
            {
                throw new Exception("n and p should be non-negative");
            }

            var result = 1;
            for (var i = 0; i < exponent; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}