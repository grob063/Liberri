using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class User
    {
        public string Name { get; set; }
        public double Fees { get; set; }
        public string CheckedOut { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
