using System;
using System.IO;

namespace Day09.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextWriter streamHandler = new StreamWriter(@System.Environment.GetEnvironmentVariable("./", true));

            var n = Convert.ToInt32(Console.ReadLine());
            
            var factorialResult = Factorial(n);
            
            // streamHandler.WriteLine(factorialResult);
            // streamHandler.Flush();
            // streamHandler.Close();
            
            Console.WriteLine(factorialResult);
        }

        private static int Factorial(int n)
        {
            var result = 1;
            var number = n;
            if (number > 0)
            {
                result = number * Factorial(number -= 1);    
            }

            return result;
        }
    }
}