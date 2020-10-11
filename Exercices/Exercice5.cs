using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice5
    {
        public static void Answer()
        {
            Console.Write("Enter a word: ");

            var input = Console.ReadLine();
            var vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            var count = 0;

            foreach (var item in input)
            {
                if (Array.Exists(vowels, letter => letter == item)) count++;
            }

            Console.WriteLine(count);
        }
    }
}