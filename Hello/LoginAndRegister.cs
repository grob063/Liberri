using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class LoginAndRegister
    {
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
