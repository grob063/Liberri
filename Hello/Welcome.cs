using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    public class Welcome
    {
        public static int WelcomeUser()
        {
            int checkSearchInput;
            while (true)
            {
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

        public static void ExecuteUserRequest(int checkSearchInput)
        { 
            if (checkSearchInput == 1)
            {
                Console.WriteLine("one");
            }
            else if (checkSearchInput == 2)
            {
                Console.WriteLine("two");
            }
            else if (checkSearchInput == 3)
            {
                Console.WriteLine("three");
            }
            else if (checkSearchInput == 4)
            {
                Console.WriteLine("four");
            }
            else if (checkSearchInput == 5)
            {
                Console.WriteLine("five");
            }
            else if (checkSearchInput == 6)
            {
                Console.WriteLine("six");
            }
            else
            {
                Console.WriteLine("do nothing");
            }
        }
    }
}
