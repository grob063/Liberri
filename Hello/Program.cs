using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var parsedBookData = GetFileMetadata();
            var bookList = BuildBookInstanceList(parsedBookData);

            WelcomeMenu(bookList);
          
            

            //Console.Write("Enter a new author: ");
            //bookList[0].Author = Console.ReadLine();

            //BuildBookPropertyFile(bookList);

        }

        public static List<string[]> GetFileMetadata()
        {
            var parsedBookData = new List<string[]>();
            string[] lines = System.IO.File.ReadAllLines(@"../../../books.txt");
            foreach (var line in lines)
            {
                parsedBookData.Add(line.Split(","));
            }
            return parsedBookData;
        }

        public static List<Book> BuildBookInstanceList(List<string[]> fileMetadata)
        {
            var bookList = new List<Book>();
            foreach (var item in fileMetadata)
            {
                var bookBuilder = new BookBuilder();
                bookList.Add(bookBuilder.AddAuthor(item[0])
                    .AddTitle(item[1])
                    .AddStatus(item[2])
                    .AddDueDate(item[3])
                    .Build());
            }
            return bookList;
        }

        public static void BuildBookPropertyFile(List<Book> bookList)
        {
            var bookPropList = new List<string>();
            foreach (var book in bookList)
            {
                StringBuilder sb = new StringBuilder($"{ book.Author },{book.Name},{book.Status},{book.Date}");
                bookPropList.Add(sb.ToString());
            }
            System.IO.File.WriteAllLines(@"../../../books.txt", bookPropList);
        }

        public static void CheckOutBook(List<Book> bookList)
        {
            Console.WriteLine("hehe");
        }

        public static void WelcomeMenu(List<Book> bookList)
        {
            // prompt user to select all books or search by value
            // if the user wants to search, give them a list of searchable properties
            //     validate user input (enum?) so that we retrieve appropriate information
            //     this can be broken into two steps, the search and the display
            //     feed the results of the search into the output of the display
            Console.WriteLine("Welcome to the library");
            Console.WriteLine("Would you like to search by author, title, book status, or would you like to see the entire library list?");

            var userInput = Console.ReadLine();

            Console.WriteLine("Here are our books haha");
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title    Author    Status");
                Console.WriteLine($"{book.Name}    {book.Author}    {book.Status}");
            }

            bool inputValidation = true;

            while (inputValidation == false)
            {
                if (bookList.Author == )
            }
        }
        public static bool Validation(List<>)
        {
            bool inputValidation = true;

            while (inputValidation == false)
            {
                if(bookList)
            }

            return inputValidation;
        }
    }
}
