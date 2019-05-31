using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hello
{
    class CheckInAndOut
    {
        public static List<Book> GetCheckedOutBooks(List<Book> bookList, User user)
        {
            var checkedOutBookList = new List<Book>();
            foreach (var book in bookList)
            {
                if (book.Owner == user.Name)
                {
                    checkedOutBookList.Add(book);
                }
            }
            return checkedOutBookList;
        }

        public static void PrintCheckedOutList(List<Book> checkedOutBooks)
        {
            var counter = 1;
            foreach (var book in checkedOutBooks)
            {
                Console.WriteLine($"{counter} - {book.Title}, due back on {book.Date}");
                counter++;
            }
        }

        public static List<Book> GetCheckedinBooks(List<Book> bookList)
        {
            var checkedInBookList = new List<Book>();
            foreach (var book in bookList)
            {
                if (book.Status == "in")
                {
                    checkedInBookList.Add(book);
                }
            }
            return checkedInBookList;
        }

        public static void PrintCheckedInList(List<Book> checkedInBooks)
        {
            var counter = 1;
            foreach (var book in checkedInBooks)
            {
                Console.WriteLine($"{counter} - {book.Title}, by {book.Author}");
                counter++;
            }
        }

        public static void UserStatus(List<Book> checkedOutBooks)
        {
            if (!checkedOutBooks.Any())
            {
                Console.WriteLine("You don't currently have anything checked out.");
            }
            else
            {
                Console.WriteLine("You currently have the following books checked out:\n");
                PrintCheckedOutList(checkedOutBooks);
            }
        }

        public static void CheckIn(List<Book> bookList, List<Book> checkedOutBooks, List<Book> checkedInBooks)
        {
            string continueCheck;
            do
            {
                while (true)
                {
                    PrintCheckedOutList(checkedOutBooks);

                    Console.WriteLine("What do you want to check in?");

                    int checkedInput;
                    var userInput = Console.ReadLine();

                    if ((int.TryParse(userInput, out checkedInput)) && (int.Parse(userInput) > 0) && int.Parse(userInput) <= checkedOutBooks.Count)
                    {
                        checkedInput = int.Parse(userInput);
                        checkedOutBooks[checkedInput - 1].CheckInBook();
                        checkedInBooks.Add(checkedOutBooks[checkedInput - 1]);
                        checkedOutBooks.Remove(checkedOutBooks[checkedInput - 1]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a book by number from the list.");
                    }
                }

                Console.Write("\nWould you like to check another book in? (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

        public static void CheckOut(List<Book> bookList, List<Book> checkedInBooks, User user)
        {
            string continueCheck;
            do
            {
                while (true)
                {
                    PrintCheckedInList(checkedInBooks);

                    Console.WriteLine("What do you want to check out?");

                    int checkedInput;
                    var userInput = Console.ReadLine();

                    if ((int.TryParse(userInput, out checkedInput)) && (int.Parse(userInput) > 0) && int.Parse(userInput) <= checkedInBooks.Count)
                    {
                        checkedInput = int.Parse(userInput);
                        checkedInBooks[checkedInput - 1].CheckOutBook(user);
                        checkedInBooks.Remove(checkedInBooks[checkedInput - 1]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a book by number from the list.");
                    }
                }

                Console.Write("\nWould you like to check out another book? (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
        }
    }
}
