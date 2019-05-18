using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLists
{
    class To_Kill_a_Mockingbird : BookFactory, IBook
    {
        public string Author()
        {
            return "Harper Lee";
        }

        public bool CheckedOut()
        {
            return true;
        }

        public int DueDate()
        {
            return 2;
        }

        public string Title()
        {
            return "To Kill a Mocking Bird";
        }
    }
}
