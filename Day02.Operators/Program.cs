using System;

namespace Day03Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            Solve(meal_cost, tip_percent, tax_percent);
        }
        
        static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double total = 0;
            total += meal_cost;
            total += meal_cost * tip_percent / 100;
            total += meal_cost * tax_percent / 100;
            Console.WriteLine(Math.Round(total));
        }
    }
}