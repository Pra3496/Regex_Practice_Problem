using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regex_Assignment
{
    internal class RegexPattern
    {
        public void UCFirst()
        {
            string pattern = "^[a]{1}[b]{2,}";
           

            string Name = Console.ReadLine();

            if (Regex.IsMatch(Name, pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }

            Console.ReadKey();

        }

      
    }
}
