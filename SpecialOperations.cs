namespace Algebra_Calculator
{
    public static class SpecialOperations
    {
        private static string? selection;
        private static int X1, X2, Y1, Y2;

        public static int Slope2PointsKnown(int x1, int y1, int x2, int y2)
        {
            return (y2 - y1) / (x2 - x1);
        }

        public static void Select()
        {
            Console.Clear();
            Console.WriteLine("Which function from Special Operations? \n");
            Console.WriteLine("1 - Slope (If 2 points know)");

            selection = Console.ReadLine();

            switch (selection?.ToString())
            {
                case "1":
                    Console.WriteLine("Enter x1: ");
                    X1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter x2: ");
                    X2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y1: ");
                    Y1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y2: ");
                    Y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Slope: ");
                    Console.WriteLine(Slope2PointsKnown(X1, Y1, X2, Y2));
                    break;
            }
            Console.WriteLine("Press any key to return to menu!");
            Console.ReadKey();
            App.Menu();
        }
    }
}
