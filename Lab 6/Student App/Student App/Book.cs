using System;
using System.Collections.Generic;
using System.Text;

namespace Student_App
{
    class Book
    {
        private string  bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }





    }
}
