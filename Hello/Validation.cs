using System;
using System.Collections.Generic;

namespace Hello
{
    class Validation
    {
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
                foreach (var word in book)
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

                    }
                }
            }

            return searchResults;
        }
            
    }
}