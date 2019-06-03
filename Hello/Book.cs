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

        public void CheckOutBook(User user)
        {
            if (Status == "out")
            {
                Console.WriteLine("This book is alredy checked out!");
            }
            else
            {
                Status = "out";
                Date = DateTime.Now.AddDays(14).ToString("MM/dd/yyyy");
                Owner = user.Name;
                Console.WriteLine($"{Title} is now checked out. It is due on {Date}");
            }
        }

        public void CheckInBook()
        {
            if (Status == "in")
            {
                Console.WriteLine("This book is alredy checked in");
            }
            else
            {
                Status = "in";
                switch (DateTime.Compare(DateTime.Now, DateTime.Parse(Date)))
                {
                    case -1:
                    case 0:
                        Console.WriteLine($"{Title} checked in on time");
                        break;
                    case 1:
                        Console.WriteLine($"{Title} checked in late!");
                        break;
                    default:
                        break;
                }
                Date = "";
                Owner = "";
            }
        }
    }
}
