using System;
using System.Collections.Generic;

namespace Day08.DictionariesMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var count = Convert.ToInt32(Console.ReadLine());

            var phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < count; i++)
            {
                var elements = Console.ReadLine().Split(" ");
                phoneBook.Add(elements[0], elements[1]);
            }

            // foreach (KeyValuePair<string, string> kvp in phoneBook)
            // {
            //     Console.WriteLine($"=> {kvp.Key} {kvp.Value}");
            // }
            //
            // foreach (var value in phoneBook.Values)
            // {
            //     Console.WriteLine(value);
            // }
            
            // Dictionary<string, string>.ValueCollection valueCollection = phoneBook.Values;
            // foreach (var value in valueCollection)
            // {
            //     Console.WriteLine(value);
            // }
            
            while (true)
            {
                var requestName = Console.ReadLine();
                if (!phoneBook.ContainsKey(requestName))
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    // var number = string.Empty;
                    // Console.WriteLine($"{requestName}={phoneBook.TryGetValue(requestName, out number)}");
                    // Console.WriteLine($"{requestName}={phoneBook.GetValueOrDefault(requestName)}");
                    Console.WriteLine($"{requestName}={phoneBook[requestName]}");
                }
            }
            */
            
            var count = Convert.ToInt32(Console.ReadLine());

            var phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < count; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                phoneBook.Add(elements[0], elements[1]);
            }

            var requestNames = new List<string>();
            for (int k = 0; k < count; k++)
            {
                requestNames.Add(Console.ReadLine());
            }
        
            foreach (var name in requestNames)
            {
                if (name != null)
                {
                    if (!phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine("Not found");
                        //continue; -> Q) cause a runtime error?? why?
                    }
            
                    Console.WriteLine($"{name}={phoneBook[name]}");   
                }
            }
            
        }
    }
}