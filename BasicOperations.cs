namespace Algebra_Calculator
{
    public static class BasicOperations
    {
        private static string? selection;
        private static int Number1;
        private static int Number2;

        public static int Add(int number1, int number2)
        {
            // Returns Int Added
            return number1 + number2;
        }

        public static int Subrtact(int number1, int number2)
        {
            // Returns Int Subtracted
            return number1 - number2;
        }

        public static int Multiply(int number1, int number2)
        {
            // Returns Int Multiplied
            return number1 * number2;
        }

        public static int Divide(int number1, int number2)
        {
            // Returns Int Divided
            return (number1 / number2);
        }

        public static int Modulo(int number1, int number2)
        {
            // Returns Int Remainder
            return number1 % number2;
        }

        // Funtion to let use pick function
        static public void Select()
        {
            Console.Clear();
            Console.WriteLine("Which function from Basic Operations? \n");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.WriteLine("5 - Modulo");

            selection = Console.ReadLine();

            Console.WriteLine("Number 1: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            Number2 = Convert.ToInt32(Console.ReadLine());

            switch (selection?.ToString())
            {
                case "1":
                    Console.WriteLine("Result: ");
                    Console.WriteLine(Add(Number1, Number2));
                    break;
                case "2":
                    Console.WriteLine("Result: ");
                    Console.WriteLine(Subrtact(Number1, Number2));
                    break;
                case "3":
                    Console.WriteLine("Result: ");
                    Console.WriteLine(Multiply(Number1, Number2));
                    break;
                case "4":
                    Console.WriteLine("Result: ");
                    Console.WriteLine(Divide(Number1, Number2));
                    break;
                case "5":
                    Console.WriteLine("Result: ");
                    Console.WriteLine(Modulo(Number1, Number2));
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("Press any key to return to menu!");
            Console.ReadKey();
            App.Menu();
        }
    }
}
