using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class BookBuilder : IBuilder<Book>
    {
        private Book _book = new Book();

        public BookBuilder AddAuthor(string author)
        {
            _book.Author = author;
            return this;
        }

        public BookBuilder AddTitle(string title)
        {
            _book.Name = title;
            return this;
        }

        public BookBuilder AddStatus(string status)
        {
            _book.Status = status;
            return this;
        }

        public BookBuilder AddDueDate(string date)
        {
            _book.Date = date;
            return this;
        }

        public BookBuilder AddOwner(string owner)
        {
            _book.Owner = owner;
            return this;
        }

        public Book Build()
        {
            return _book;
        }
    }
}
