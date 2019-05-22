using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    public interface IBuilder<T>
    {
        T Build();
    }
}
