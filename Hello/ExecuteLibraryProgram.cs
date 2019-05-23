using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class ExecuteLibraryProgram
    {
        public void MakeItHappen()
        {
            var parsedBookData = BuildLibraryItems.GetFileMetadata();
            var bookList = BuildLibraryItems.BuildBookInstanceList(parsedBookData);
            var userArray = LoginAndRegister.GetUserArray();
            var user = LoginAndRegister.LogIn(userArray, bookList);
            userArray = LoginAndRegister.AddUserToList(userArray, user.Name);
            var checkedOutBooks = CheckInAndOut.GetCheckedOutBooks(bookList, user);
            CheckInAndOut.UserStatus(checkedOutBooks);

            /*
            string continueCheck;
            do
            {
                //testing shit
                Console.WriteLine("What do you want to check in?");
                var counter = 1;
                foreach (var book in bookList)
                {
                    Console.WriteLine($"{counter} - {book.Title} - {book.Author} - {book.Status}");
                    counter++;
                }

                var userChoice = int.Parse(Console.ReadLine());
                bookList[userChoice - 1].CheckInBook();
                Console.Write("\nWould you like to check out again huh? (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Goodbye!");
            */
        }
    }
}
