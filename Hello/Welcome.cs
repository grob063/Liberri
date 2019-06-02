using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    public class Welcome
    {
        public static void IntroPage()
        {

            string welcomeMessage = @"
             *--------------------*
             |  Hello, welcome to |
             |  the Cow County    |
             |  Library.          |
             *--------------------*
                        \ |   (__)    
                         \|   (oo)------/'
                              (__)    ||
                                 ||--w||
            ------------------------------
                                    ";

            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, 1);
            Console.WriteLine(welcomeMessage);
        }

        public static int WelcomeUser()
        {
            int checkSearchInput;
            while (true)
            {
                ResetPage();
                Console.WriteLine("What would you like to do? \n (1) Search by author \n (2) Search by title\n (3) Display all book information \n (4) Return a book \n (5) Check out a book \n (6) Exit Program");
                var searchInput = Console.ReadLine();
                if ((int.TryParse(searchInput, out checkSearchInput)) && (int.Parse(searchInput) > 0) && (int.Parse(searchInput) <= 7))
                {
                    checkSearchInput = int.Parse(searchInput);
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose from the list.");
                }
            }
            return checkSearchInput;
        }

        public static void ResetPage()
        {
            Console.Clear();
            IntroPage();
        }
    }
}
