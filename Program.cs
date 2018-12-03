using System;
using System.Collections.Generic;

namespace csText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation";
            const int maxLength = 20;
            if (sentence.Length < maxLength)
                System.Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach(var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";
                System.Console.WriteLine(summary);
            }
        }
    }
}
