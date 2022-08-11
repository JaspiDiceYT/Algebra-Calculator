namespace Algebra_Calculator
{
    public class App
    {
        public const bool Runstartsleep = true;
        public static int CountVisited = 0;

        public static void Menu()
        {
            CountVisited++;
            Console.Clear();
            Console.Title = "Algebra Calculator - By Jaspin";

            if (CountVisited == 0)
            {
                if (Runstartsleep)
                {
                    Console.WriteLine("Welcome to Jaspin's Algebra Calculator!");
                    Console.WriteLine("This is a project because i recently have gotten into Algebra 1 honors, so I'm using coding to help (:");
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine("What would you like to do? \n");
            Console.WriteLine("1 - Basic Operations");
            Console.WriteLine("2 - Special Calculations");
            Console.WriteLine("3 - Probability");

            string? option = Console.ReadLine();

            switch (option?.ToString())
            {
                // Go to Basic Operations Function Menu
                case "1":
                    BasicOperations.Select();
                    break;
                case "2":
                    SpecialOperations.Select();
                    break;
                case "3":
                    Probability.Select();
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    Console.ReadKey();
                    Program.Main();
                    break;
            }
        }

        public App()
        {
            
        }
    }
}
