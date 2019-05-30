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

            var welcome = new Welcome();
            welcome.WelcomeUser();

            //CheckInAndOut.CheckIn(bookList, checkedOutBooks);
            //CheckInAndOut.CheckOut(bookList, checkedInBooks, user);


            BuildLibraryItems.BuildBookPropertyFile(bookList);
            BuildLibraryItems.BuildUserFile(userList);
        }
    }
}
