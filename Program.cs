namespace Algebra_Calculator
{
    class Program
    {
        public static void Main()
        {
            bool playintro = true;
            App app = new App(playintro);
            app.Menu();
        }
    }
}