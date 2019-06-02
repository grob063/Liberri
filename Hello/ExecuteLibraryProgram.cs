using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class ExecuteLibraryProgram
    {
        public void MakeItHappen()
        {
            Welcome.IntroPage();
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
                var userSelection = Welcome.WelcomeUser();
                switch (userSelection)
                {
                    case 1:
                        GetSearchResults.AuthorSearch(bookList);
                        break;
                    case 2:
                        GetSearchResults.TitleSearch(bookList);
                        break;
                    case 3:
                        GetSearchResults.FullStatusDisplay(bookList);
                        break;
                    case 4:
                        CheckInAndOut.CheckIn(bookList, checkedOutBooks, checkedInBooks);
                        break;
                    case 5:
                        CheckInAndOut.CheckOut(bookList, checkedInBooks, checkedOutBooks, user);
                        break;
                    case 6:
                        Console.WriteLine($"See ya later, {user.Name}");
                        BuildLibraryItems.BuildBookPropertyFile(bookList);
                        BuildLibraryItems.BuildUserFile(userList);
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
