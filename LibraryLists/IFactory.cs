using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLists
{
    public interface IFactory<T, UEnum>
        where UEnum : Enum
    {
        T Create(UEnum type);
    }
}
