using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hello
{
    public class Validation2
    {
        public static string GetMasterSelection(MasterSelection selection)
        {
            string returnSelection = "default";
            switch (selection)
            {
                case MasterSelection.all:
                    Console.WriteLine("All");
                    break;
                case MasterSelection.search:
                    Console.WriteLine("Search");
                    break;
                case MasterSelection.checkin:
                    Console.WriteLine("Check In");
                    break;
                case MasterSelection.checkout:
                    Console.WriteLine("Check Out");
                    break;
                case MasterSelection.exit:
                    Console.WriteLine("Exit");
                    break;
                default:
                    break;
            }
            return returnSelection;
        }

        public static string CheckReturnSelection()
        {
            string returnSelection = "defualt";
            MasterSelection clearedSelectionCheck;
            bool checker = true;
            do
            {
                PrintSelectionList();
                Console.Write("Choose a thing you'd like to do with haha: ");
                var response = Console.ReadLine().ToLower();
                response = Regex.Replace(response, @"\s+", "");
                if (Enum.TryParse<MasterSelection>(response, out clearedSelectionCheck) && Enum.IsDefined(typeof(MasterSelection), clearedSelectionCheck))
                {
                    returnSelection = GetMasterSelection(clearedSelectionCheck);
                    checker = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Can only accept a valid option option number.\n");
                }
            } while (checker);
            return returnSelection;
        }

        public static void PrintSelectionList()
        {
            Console.WriteLine("1 - All: Show entire library catalog\n" +
                "2 - Search: Search library catalog\n" +
                "3 - Check In: Return a checked out book\n" +
                "4 - Check Out: Check out a book\n" +
                "5 - Exit: Log out and exit library catalog\n");
        }
    }
}
