using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Exercice2
    {
        public static void Answer()
        {
            Console.Write("Enter number with a hyphen (1-2-3): ");

            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) { }
            else
            {
                var numList = new List<string>();
                var inputArr = input.Split('-');

                foreach (var num in inputArr)
                {
                    if (numList.Contains(num))
                    {
                        Console.WriteLine("Duplicates");
                        break;
                    }
                    else numList.Add(num);
                }
            }
        }
    }
}