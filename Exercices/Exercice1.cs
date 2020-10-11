using System;

namespace Exercices
{
    public class Exercice1
    {
        public static void Answer()
        {
            Console.Write("Enter a list of number (1-2-3-4-5): ");

            var input = Console.ReadLine();
            var inputArr = input.Split("-", input.Length);
            var isConsecutive = true;
            var isPositive = true;

            if (Convert.ToInt32(inputArr[1]) == Convert.ToInt32(inputArr[0]) - 1) isPositive = false;

            for (var i = 1; i < inputArr.Length; i++)
            {
                if (isPositive)
                {
                    if (Convert.ToInt32(inputArr[i - 1]) != Convert.ToInt32(inputArr[i]) - 1) isConsecutive = false;
                }
                else
                {
                    if (Convert.ToInt32(inputArr[i - 1]) != Convert.ToInt32(inputArr[i]) + 1) isConsecutive = false;

                }
            }

            if (isConsecutive) Console.WriteLine("Numbers are consecutives");
            else Console.WriteLine("Numbers are not consecutives");
        }
    }

}