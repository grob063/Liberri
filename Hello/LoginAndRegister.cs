using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class LoginAndRegister
    {
        public static List<string> GetUserArray()
        {
            var logFile = System.IO.File.ReadAllLines(@"../../../users.txt");
            return new List<string>(logFile);

        }

        public static User LogIn(List<string> userList, List<Book> bookList)
        {
            string userName = null;
            while (true)
            {
                Welcome.ResetPage();
                Console.Write("Please enter your name to login to the library database: ");
                userName = Console.ReadLine();
                if (userList.Contains(userName))
                {
                    var user = new User(userName);
                    Console.WriteLine($"Welcome back, {user.Name}");
                    return user;
                }
                else
                {
                    Welcome.ResetPage();
                    Console.WriteLine("Cannot find user name.");
                    while (true)
                    {
                        Console.WriteLine("1 - Retry login");
                        Console.WriteLine("2 - Register new user");
                        Console.Write("Please select the one of the following options: ");
                        string userSelection = Console.ReadLine();
                        if (userSelection == "1")
                        {
                            break;
                        }
                        else if (userSelection == "2")
                        {
                            return RegisterUser(userList);
                        }
                        else
                        {
                            Welcome.ResetPage();
                            Console.WriteLine("Sorry, I didn't get that.");
                        }
                    }
                }
            }
        }

        public static User RegisterUser(List<string> userList)
        {
            string userInput = null;
            while (true)
            {
                while (true)
                {
                    Welcome.ResetPage();
                    Console.Write("Please enter a user name to register: ");
                    userInput = Console.ReadLine();
                    if (!(userList.Contains(userInput)))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That name has already been registered");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                Console.Write($"You've entered {userInput}. Is this the name you want (y/n)? ");
                string continueCheck = Console.ReadLine();
                if (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Welcome.ResetPage();
                    Console.WriteLine($"Thank you for registering, {userInput}");
                    Console.WriteLine("Press any key to access the library catalog");
                    Console.ReadKey();
                    break;
                }
            }
            return new User(userInput);
        }

        public static List<string> AddUserToList(List<string> userList, string userName)
        {
            if (!userList.Contains(userName))
            {
                userList.Add(userName);
            }
            return userList;
        }
    }
}
