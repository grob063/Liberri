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

            
            var parsedBookData = GetFileMetadata();
            var bookList = BuildBookInstanceList(parsedBookData);
            var userArray = GetUserArray();
            var userName = LogIn(userArray);
            //Console.WriteLine(userName);

            /*
            var checker = true;
            while (checker)
            {
                var checkOut = GetBookToCheckOut(bookList);
                CheckOutBook(checkOut);
                Console.WriteLine("Do you wanna try again?");
                var userInput = Console.ReadLine();
                if (userInput == "n")
                {
                    checker = false;
                }
            }
            */
            //BuildBookPropertyFile(bookList);

        }
        public static void WelcomeWagon()
        {

            var search = JustLooking();

            SearchList JustLooking()
            {
                Console.WriteLine("Welcome, would you like to search by title (1), author (2), checked out status (3) or would you prefer to see the list(4)?");
                var searchInput = int.Parse(Console.ReadLine());
                //validate this please

                return 0;

            }
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
                StringBuilder sb = new StringBuilder($"{ book.Author },{book.Name},{book.Status},{book.Date},{book.Owner}");
                bookPropList.Add(sb.ToString());
            }
            System.IO.File.WriteAllLines(@"../../../books.txt", bookPropList);
        }
       
        public static Book GetBookToCheckOut(List<Book> bookList)
        {
            int counter = 1;
            Console.WriteLine("What book do you wanna check out huh?");
            foreach (var book in bookList)
            {
                Console.WriteLine($"{counter} - {book.Name}");
                counter++;
            }
            // validate this later
            var userInput = int.Parse(Console.ReadLine());
            return bookList[userInput - 1];
        }

        public static void CheckOutBook(Book book)
        {
            //validate this later too haha
            if (book.Status == "out")
            {
                Console.WriteLine("This book is alredy checked out!");
            }
            else
            {
                book.Status = "out";
                book.Date = DateTime.Now.AddDays(14).ToString("MM/DD/YYYY");
                Console.WriteLine($"{book.Name} is now checked out. It is due on {book.Date}");
            }
        }
         
        public static string[] GetUserArray()
        {
            return System.IO.File.ReadAllLines(@"../../../users.txt");
        }

        public static User LogIn(string[] userArray)
        {
            string userName = null;
            while (true)
            {
                Console.Write("Please enter your name to login to the library database: ");
                userName = Console.ReadLine();
                if (userArray.Contains(userName))
                {
                    Console.WriteLine($"Welcome back, {userName}");
                    return new User(userName);
                }
                else
                {
                    Console.WriteLine("Cannot find user name.");
                    while (true)
                    {
                        Console.WriteLine("Please select the one of the following options: ");
                        Console.WriteLine("1 - Retry login");
                        Console.WriteLine("2 - Register new user");
                        string userSelection = Console.ReadLine();
                        if (userSelection == "1")
                        {
                            break;
                        }
                        else if (userSelection == "2")
                        {
                            return RegisterUser();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I didn't get that.");
                        }
                    }
                }
            }

        }

        public static User RegisterUser()
        {
            string userInput = null;
            while (true)
            {
                Console.WriteLine("Please enter a user name to register: ");
                userInput = Console.ReadLine();
                Console.WriteLine($"You've entered {userInput}. Is this the name you want (y/n)?");
                string continueCheck = Console.ReadLine();
                if (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Thank you for registering, {userInput}");
                    break;
                }
            }
            return new User(userInput);
            
        }
         
        
    }
}
