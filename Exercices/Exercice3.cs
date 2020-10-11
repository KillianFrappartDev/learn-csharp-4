using System;

namespace Exercices
{
    public class Exercice3
    {
        public static void Answer()
        {
            Console.Write("Enter a time valus (18:00): ");
            var input = Console.ReadLine();
            try
            {
                Console.WriteLine($"{TimeSpan.Parse(input)} OK");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}