using System;
using System.Globalization;
using System.Linq;

namespace Day26.DateTimeNestedLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime format */
            // var date = DateTime.UtcNow;                  // Universal Time Coordinated = GMT
            // var date = DateTime.Now;                      // local time (considering a british summer time)
            // var date = DateTime.Now.ToUniversalTime();   // local time to convert to UTC time

            /* default format of the above all -> en-US  */ 
            // Console.WriteLine(date);                                            // default format - MM/dd/yyyy hh:mm:ss
            // Console.WriteLine(date.ToString("yyyy-MM-dd"));                     // ISO format - yyyy-MM-dd 
            // Console.WriteLine(date.ToString());                     // ISO format - yyyy-MM-dd 
            // Console.WriteLine(date.ToString(new CultureInfo("en-GB")));  // UK format - dd/MM/yyyy
            
            // Solution 1) directly from UTC library -> ISO
            // Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            // Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
            // Console.WriteLine(DateTime.Now.ToString("u"));

            // Solution 2) UK time based input string -> ISO by DateTime Parser + ToString
            // var date = DateTime.Parse(Console.ReadLine() ?? string.Empty, new CultureInfo("en-GB"));
            // Console.WriteLine(date);
            // Console.WriteLine(date.ToString("yyyy-MM-dd"));
            
            // Solution 3) Convert input string to UK format -> ISO by DateTime Parser + ToString
            // var date = Convert.ToDateTime(Console.ReadLine() ?? string.Empty, new CultureInfo("en-GB"));
            // Console.WriteLine(date);
            // Console.WriteLine(date.ToString("yyyy-MM-dd"));

            var returnedDate = Convert.ToDateTime(Console.ReadLine() ?? string.Empty, new CultureInfo("en-GB"));
            var dueDate = Convert.ToDateTime(Console.ReadLine() ?? string.Empty, new CultureInfo("en-GB"));
            
            // Console.WriteLine($"lent at {lentDate.ToString("yyyy-MM-dd")}, returned at {returnedDate.ToString("yyyy-MM-dd")}");
            // Console.WriteLine($"lent at {lentDate.Month}, returned at {returnedDate.Month}");

            var fine = 0;
            // if (returnedDate <= dueDate)
            // {
            //     //Console.WriteLine("ok");
            // }
            if (returnedDate > dueDate)
            {
                if (returnedDate.Month == dueDate.Month)
                {
                    // Console.WriteLine("within month late");
                    fine = 15 * (returnedDate.Day - dueDate.Day);
                }
                else
                {
                    if (returnedDate.Year == dueDate.Year)
                    {
                        // Console.WriteLine("within year late");
                        fine = 500 * (returnedDate.Month - dueDate.Month);
                    }
                    else
                    {
                        // Console.WriteLine("10000 Hackos");
                        fine = 10000;
                    }
                }
            }

            Console.WriteLine(fine);
        }
    }
    
}