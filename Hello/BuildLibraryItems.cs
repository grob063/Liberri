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
    }
}
