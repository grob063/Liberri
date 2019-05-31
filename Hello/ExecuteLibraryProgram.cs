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
            var userList = LoginAndRegister.GetUserArray();
            var user = LoginAndRegister.LogIn(userList, bookList);
            userList = LoginAndRegister.AddUserToList(userList, user.Name);
            var checkedOutBooks = CheckInAndOut.GetCheckedOutBooks(bookList, user);
            var checkedInBooks = CheckInAndOut.GetCheckedinBooks(bookList);
            CheckInAndOut.UserStatus(checkedOutBooks);
            Console.WriteLine("\n");

            while (true)
            {
                // wrap this entire thing in a while
                var userSelection = Welcome.WelcomeUser();
                if (userSelection == 1)
                {
                    GetSearchResults.AuthorSearch(bookList);
                }
                else if (userSelection == 2)
                {
                    GetSearchResults.TitleSearch(bookList);
                }
                else if (userSelection == 3)
                {
                    GetSearchResults.FullStatusDisplay(bookList);
                }
                else if (userSelection == 4)
                {
                    CheckInAndOut.CheckIn(bookList, checkedOutBooks, checkedInBooks);
                }
                else if (userSelection == 5)
                {
                    CheckInAndOut.CheckOut(bookList, checkedInBooks, user);
                }
                else if (userSelection == 6)
                {
                    Console.WriteLine($"See ya later, {user.Name}");
                    break;
                }

                //BuildLibraryItems.BuildBookPropertyFile(bookList);
                //BuildLibraryItems.BuildUserFile(userList);
            }
        }
    }
}
