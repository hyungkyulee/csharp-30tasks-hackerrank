using System;

namespace Day02.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var intAdded = 4;
            var doubleAdded = 4d;
            var stringAdded = "HackerRank";

            int inputInt;
            double inputDouble;
            string inputString;

            inputInt = int.Parse(Console.ReadLine());
            inputDouble = double.Parse(Console.ReadLine());
            inputString = Console.ReadLine();

            Console.WriteLine(intAdded + inputInt);
            Console.WriteLine(string.Format("{0:N1}", doubleAdded + inputDouble));
            Console.WriteLine($"{stringAdded} {inputString}");

        }
    }
}