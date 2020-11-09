using System;
using System.Collections.Generic;
using System.Text;

namespace Student_App
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        private Book[] listOfBook;

        public Book[] ListOfBook
        {
            get { return listOfBook; }
            set { listOfBook = value; }
        }

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }



    }
}
