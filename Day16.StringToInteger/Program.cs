using System;

namespace Day16.StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            try
            {
                var result = int.Parse(s);
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
            
        }
    }
}