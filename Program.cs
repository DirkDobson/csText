using System;
using System.Collections.Generic;

namespace csText
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation";         
            var summary = StringUtility.SummerizeText(text, 30);
            System.Console.WriteLine(summary);
        }

        
    }
}
