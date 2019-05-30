using System;
using System.Collections.Generic;

namespace Hello
{
    class Validation
    {
        // get rid of this and initialize within class
        // then return the list once its populated
        public List<Book> searchResults = new List<Book>();

        bool inputValidation;

        public bool InputValidation(List<Book> bookList, int searchInput)
        {
            // Validation takes in bookList and userInput entered for search
            // and returns inputValidation bool
            // If inputValidation returns false, run Welcome() again

            // Create a list of validated search input and export the contents to display

            switch (searchInput)
            {
                // have these just cascade into eachother since they all return the same
                case 1:
                    //Author;
                    inputValidation = true;
                    break;
                case 2:
                    //Title;
                    inputValidation = true;
                    break;
                case 3:
                    //Status;
                    inputValidation = true;
                    break;
                default:
                    inputValidation = false;
                    break;
            }

            return inputValidation;
        }
        public List<Book> SearchValidation(List<Book> bookList, string userInput)
        {
            foreach (var book in bookList)
            {

                if (book.Author.Contains(userInput))
                {
                    searchResults.Add(book);
                }
                else if (book.Title.Contains(userInput))
                {
                    searchResults.Add(book);
                }
                else if (book.Status.Contains(userInput))
                {
                    searchResults.Add(book);
                }
                else
                {

                    Console.WriteLine("heheheh");

                }
            }

            return searchResults;
        }
            
    }
}