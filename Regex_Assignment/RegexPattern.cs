﻿using System;
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


        public void LetterWithUnderscore()
        {
            string pattern = "^[a-z]{1,}[_]{1}[a-z]{1,}$";

            Console.Write("\n\nEnter the String : ");
            string Name = Console.ReadLine();

            if (Regex.IsMatch(Name, pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }

            // Console.ReadKey();

        }



        public void HtmlSyntaxMaching()
        {
            string pattern = @"(<\w+>)|(</\w+>)";

            Console.Write("\n\nEnter the String : ");
            string Name = Console.ReadLine();

            string[] newPattern = Regex.Split(Name, pattern);

            foreach (string sample in newPattern)
            {
                if (Regex.IsMatch(sample, pattern))
                {
                    Console.WriteLine(sample);
                }
            }

            //Console.ReadKey();

        }

    }
}
