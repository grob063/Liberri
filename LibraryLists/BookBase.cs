using System;

namespace LibraryLists
{
    class BookFactory : IFactory<IBook, BookType>
    {
        public IBook Create(BookType type)
        {
            switch (type)
            {
                case BookType.To_Kill_a_Mockingbird: return new To_Kill_a_Mockingbird();


                case BookType.The_Illustrated_Man:
                    return new The_Illustrated_Man();

                default: throw new ArgumentOutOfRangeException("Invalid book entry");

            }
        }
    }
}
