using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            var startProgram = new ExecuteLibraryProgram();
            startProgram.MakeItHappen();

            Console.WriteLine("");
            var validation = new Validation();

            string text = File.ReadAllText(@"../../../books.txt");
            Console.WriteLine("Would you like to search by title(1), author(2), checked out status(3) or would you prefer to see the full list of books(4)?");
            Console.Write("Please enter your numbered selection: ");
            var searchInput = int.Parse(Console.ReadLine());

           
        }

            public static Book GetBookToCheckOut(List<Book> bookList)
            {
                int counter = 1;
                Console.WriteLine("What book do you wanna check out huh?");
                foreach (var book in bookList)
                {
                    Console.WriteLine($"{counter} - {book.Title}");
                    counter++;
                }
                // validate this later
                var userInput = int.Parse(Console.ReadLine());
                return bookList[userInput - 1];

            }

    }
}
