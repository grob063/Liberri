using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class GetSearchResults
    {
        public static void AuthorSearch(List<Book> bookList)
        {
            string continueCheck;
            do
            {
                Welcome.ResetPage();
                Console.WriteLine("Now searching catalog by author");
                WriteCyanToConsole("Please enter a search facet: ");
                var userInput = Console.ReadLine().ToLower();
                var counter = 1;
                var foundBooks = new List<Book>();
                foreach (var book in bookList)
                {
                    if (userInput.Length == 1)
                    {
                        if (book.Author.ToLower().StartsWith(userInput))
                        {
                            foundBooks.Add(book);
                        }
                    }
                    else if (book.Author.ToLower().Contains(userInput))
                    {
                        foundBooks.Add(book);
                    }
                }
                if (foundBooks.Count > 0)
                {
                    Console.WriteLine("\nFound the following results:\n");
                    foreach (var book in foundBooks)
                    {
                        if (book.Status == "in")
                        {
                            Console.WriteLine($"{counter} - {book.Title}, by {book.Author}. Checked in.");
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine($"{counter} - {book.Title}, by {book.Author}. Checked out and due back on {book.Date}.");
                            counter++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nCould not find any title matching that search");
                }
                Console.WriteLine("\nWould you like to search again (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

        public static void TitleSearch(List<Book> bookList)
        {
            string continueCheck;
            do
            {
                Welcome.ResetPage();
                Console.WriteLine("Now searching catalog by title");
                WriteCyanToConsole("Please enter a search facet: ");
                var userInput = Console.ReadLine().ToLower();
                var counter = 1;
                var foundBooks = new List<Book>();
                foreach (var book in bookList)
                {
                    if (userInput.Length == 1)
                    {
                        if (book.Title.ToLower().StartsWith(userInput))
                        {
                            foundBooks.Add(book);
                        }
                    }
                    else if (book.Title.ToLower().Contains(userInput))
                    {
                        foundBooks.Add(book);
                    }
                }
                if (foundBooks.Count > 0)
                {
                    Console.WriteLine("\nFound the following results:\n");
                    foreach (var book in foundBooks)
                    {
                        if (book.Status == "in")
                        {
                            Console.WriteLine($"{counter} - {book.Title}, by {book.Author}. Checked in.");
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine($"{counter} - {book.Title}, by {book.Author}. Checked out and due back on {book.Date}.");
                            counter++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nCould not find any title matching that search");
                }
                Console.WriteLine("\nWould you like to search again (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

        public static void FullStatusDisplay(List<Book> bookList)
        {
            while (true)
            {
                Welcome.ResetPage();
                var counter = 1;
                Console.WriteLine("Now viewing entire library catalog\n");
                foreach (var book in bookList)
                {
                    if (book.Status == "in")
                    {
                        Console.WriteLine($"{counter} - {book.Title}, by {book.Author}. Checked in.");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"{counter} - {book.Title}, by {book.Author}. Checked out and due back on {book.Date}.");
                        counter++;
                    }
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadLine();
                break;
            }
        }

        public static void WriteCyanToConsole(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(prompt);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ColorUserInput()
        {
            var userInput = Console.ReadLine().ToLower();
        }
    }
}