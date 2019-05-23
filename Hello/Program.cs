using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var startProgram = new ExecuteLibraryProgram();
            startProgram.MakeItHappen();
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
