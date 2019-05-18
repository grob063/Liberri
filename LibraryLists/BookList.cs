using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLists
{
    class BookList
    {
        public BookList()
        {
            List<Books> entry = new List<Books>();
            {
                new Books { Author = "Harper Lee", Title = "To Kill a MockingBird", CheckedOut = true };
                new Books { Author = "Ray Bradbury", Title = "The Illustrated Man", CheckedOut = false };
            }

        }
    }
}
