namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double pi = 3.14;
            Console.WriteLine(pi);
            
            bool learningCSharp = true;

            string favouriteFilm = "Snatch";

            favouriteFilm = "High School Musical";

            string firstName = "Jason";

            printGreeting(firstName);

            Console.WriteLine(subtractNumbers(10, 5));
        }

        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        private static int subtractNumbers(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

    }
}
