using System;
using System.Collections.Generic;

namespace Algebra_Calculator
{
    public static class Probability
    {
        public static string? selection;
        public static int rn1;
        public static int rn2;

        public static int GenerateNumberRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min , max);
        }

        public static void Select()
        {
            Console.Clear();
            Console.WriteLine("Which function from Probability? \n");
            Console.WriteLine("1 - Generate Random Range Number");

            selection = Console.ReadLine();

            switch (selection?.ToString())
            {
                case "1":
                    Console.WriteLine("Enter minimum number to generate: ");
                    rn1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter maximum number to generate: ");
                    rn2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Random Number:");
                    Console.WriteLine(GenerateNumberRange(rn1, rn2));
                    break;
            }
            Console.WriteLine("Press any key to return to menu!");
            Console.ReadKey();
            App.Menu();
        }
    }
}
