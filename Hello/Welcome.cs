using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    public class Welcome
    {
        public void WelcomeUser()
        {

            int exit;
            do
            {
                while (true)
                {
                    Console.WriteLine("What would you like to do? \n (1) Search by author \n (2) Search by title\n (3) Search by check out status \n (4) View the full list of books \n (5) Return a book \n (6) Check out a book");
                    var searchInput = Console.ReadLine();

                    int checkSearchInput;

                    if ((int.TryParse(searchInput, out checkSearchInput)) && (int.Parse(searchInput) > 0) && (int.Parse(searchInput) <= 6))
                    {
                        checkSearchInput = int.Parse(searchInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose from the list.");
                    }

                    Console.WriteLine(checkSearchInput);

                    if (checkSearchInput == 1)
                    {
                        Console.WriteLine("one");
                    }
                    if (checkSearchInput == 2)
                    {

                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine("Done for today? \n (1) Yes, good bye \n (2) I want one more thing");
                exit = int.Parse(Console.ReadLine());
            } while (!(exit == 1));

        }

    }
}
