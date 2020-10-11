using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice4
    {
        public static void Answer()
        {
            Console.Write("Enter words separated by a space (one two three): ");

            var input = Console.ReadLine();
            var inputArr = input.ToLower().Split(" ");
            var inputList = new List<string>();

            foreach (var item in inputArr) inputList.Add(char.ToUpper(item[0]) + item.Substring(1));

            Console.WriteLine(String.Join("", inputList));

        }
    }
}