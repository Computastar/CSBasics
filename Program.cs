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

            Console.WriteLine(isStringLonger("Tuesday", 9));

            Book myFavoriteBook = new Book("Twilight", 498);

            Console.WriteLine(myFavoriteBook.Title + " is " + myFavoriteBook.Pages + " long.");

            myFavoriteBook.TurnPage();

            Book mySecondFavoriteBook = new Book("Twlight 2", 999);
            Console.WriteLine(mySecondFavoriteBook.Title + " is " + mySecondFavoriteBook.Pages + " long.");
            mySecondFavoriteBook.TurnPage(1000);



        }

        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        private static int subtractNumbers(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        private static bool isStringLonger(string word, int number)
        {
            return word.Length > number;
        }

    }
}
