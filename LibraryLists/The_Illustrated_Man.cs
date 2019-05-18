using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLists
{
    class The_Illustrated_Man : BookFactory, IBook
    {
        public string Author()
        {
            return "Ray Bradbury";
        }

        public bool CheckedOut()
        {
            return false;
        }

        public int DueDate()
        {
            return 0;
        }

        public string Title()
        {
            return "The Illustrated Man";
        }
    }
}
