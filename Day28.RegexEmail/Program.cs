using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day28.RegexEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            var gmails = new List<string>();
            int N = Convert.ToInt32(Console.ReadLine());

            for (int NItr = 0; NItr < N; NItr++) {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];
                string emailID = firstNameEmailID[1];
                if (new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(emailID))
                {
                    var domain = emailID.Substring(emailID.IndexOf('@') + 1);
                    if (domain == "gmail.com")
                    {
                        gmails.Add(firstName);
                    }
                }
            }

            var sortedFirstnames = gmails.OrderBy(x => x).ToList();
            foreach (var firstname in sortedFirstnames)
            {
                Console.WriteLine(firstname);
            }
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                    RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    // Console.WriteLine(domainName);
                    // Console.WriteLine(match.Groups[1].Value + domainName);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }
            
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
            
    }
}