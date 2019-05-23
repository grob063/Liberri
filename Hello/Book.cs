using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Status { get; set; }

        public string Date { get; set; }

        public string Owner { get; set; }

        public void CheckOutBook()
        {
            //validate this later too haha
            if (Status == "out")
            {
                Console.WriteLine("This book is alredy checked out!");
            }
            else
            {
                Status = "out";
                Date = DateTime.Now.AddDays(14).ToString("MM/dd/yyyy");
                Console.WriteLine($"{Title} is now checked out. It is due on {Date}");
            }
        }

        public void CheckInBook()
        {
            if (Status == "in")
            {
                Console.WriteLine("This book is alredy checked out!");
            }
            else
            {
                Status = "out";
                Date = DateTime.Now.AddDays(14).ToString("MM/dd/yyyy");
                Console.WriteLine($"{Title} is now checked out. It is due on {Date}");
            }
        }
    }
}
