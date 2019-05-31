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
                WriteCyanToConsole("Please enter a search facet: ");
                var userInput = Console.ReadLine().ToLower();
                var counter = 1;
                foreach (var book in bookList)
                {
                    if (userInput.Length == 1)
                    {
                        if (book.Author.ToLower().StartsWith(userInput))
                        {
                            Console.WriteLine($"{counter} - {book.Title} - {book.Author}");
                            counter++;
                        }
                    }
                    else if (book.Author.ToLower().Contains(userInput))
                    {
                        Console.WriteLine($"{counter} - {book.Title} - {book.Author}");
                        counter++;
                    }
                }
                Console.WriteLine("Would you like to search again (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

        public static void TitleSearch(List<Book> bookList)
        {
            string continueCheck;
            do
            {
                WriteCyanToConsole("Please enter a search facet: ");
                var userInput = Console.ReadLine().ToLower();
                var counter = 1;
                foreach (var book in bookList)
                {
                    if (userInput.Length == 1)
                    {
                        if (book.Title.ToLower().StartsWith(userInput))
                        {
                            Console.WriteLine($"{counter} - {book.Title} - {book.Author}");
                            counter++;
                        }
                    }
                    else if (book.Title.ToLower().Contains(userInput))
                    {
                        Console.WriteLine($"{counter} - {book.Title} - {book.Author}");
                        counter++;
                    }
                }
                Console.WriteLine("Would you like to search again (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

        public static void FullStatusDisplay(List<Book> bookList)
        {
            while (true)
            {
                Console.Clear();
                var counter = 1;
                foreach (var book in bookList)
                {
                    Console.WriteLine($"{counter} - {book.Title} - {book.Author} - {book.Status}");
                    counter++;
                }
                Console.WriteLine("Press any key to continue");
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