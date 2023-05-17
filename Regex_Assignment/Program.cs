using System;
using System.Collections.Generic;


namespace Regex_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexPattern reg = new RegexPattern();

            reg.UCFirst();
            reg.LetterWithUnderscore();

            reg.HtmlSyntaxMaching();

            reg.WordOccurance();

            //reg.FileExtension();


            Console.ReadKey();
        }
    }
}
