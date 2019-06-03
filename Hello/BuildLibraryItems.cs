using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class BuildLibraryItems
    {
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
                    .AddOwner(item[4])
                    .Build());
            }
            return bookList;
        }

        public static void BuildBookPropertyFile(List<Book> bookList)
        {
            var bookPropList = new List<string>();
            foreach (var book in bookList)
            {
                StringBuilder sb = new StringBuilder($"{ book.Author },{book.Title},{book.Status},{book.Date},{book.Owner}");
                bookPropList.Add(sb.ToString());
            }
            System.IO.File.WriteAllLines(@"../../../books.txt", bookPropList);
        }

        public static void BuildUserFile(List<string> userList)
        {
            string[] userArray = userList.ToArray();
            System.IO.File.WriteAllLines(@"../../../users.txt", userArray);
        }

        public static void AddBook(List<Book> bookList, List<Book> checkedInBooks)
        {
            Welcome.ResetPage();
            var donatedBook = new Book();
            GetSearchResults.WriteCyanToConsole("Please enter the name of the book you're donating: ");
            donatedBook.Title = Console.ReadLine();
            GetSearchResults.WriteCyanToConsole("Please enter the author of the book you're donating: ");
            donatedBook.Author = Console.ReadLine();
            donatedBook.Status = "in";
            bookList.Add(donatedBook);
            checkedInBooks.Add(donatedBook);
            Console.WriteLine("\nThank you for your donation!");
            GetSearchResults.WriteCyanToConsole("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
