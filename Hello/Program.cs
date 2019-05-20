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

            
            foreach (var book in bookList)
            {
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Name);
                Console.WriteLine(book.Status);
                Console.WriteLine(book.Date);
            }
            

            Console.Write("Enter a new author: ");
            bookList[0].Author = Console.ReadLine();

            BuildBookPropertyFile(bookList);

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
    }
}
