using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLists
{
    public interface IBook
    {
        string Author();
        string Title();
        bool CheckedOut();

        int DueDate();
            
    }
}
