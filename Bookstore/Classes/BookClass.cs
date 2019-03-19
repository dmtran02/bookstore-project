// BookStore Class 
// Contains constants, properties and other data related to the Bookstore
//     Frank Friedman
//     CIS 3309

using System;

namespace Bookstore.Classes
{
    public class BookClass
    {
        private string bookISBN;
        private string bookTitle;
        private string bookAuthor;
        private string bookPrice;
        private string bookOnHand;
        private string bookTransDate;

        public BookClass(string bookISBN, string bookTitle, string bookAuthor, string bookPrice, string bookOnHand, string bookTransDate)
        {
            this.bookISBN = bookISBN;
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.bookPrice = bookPrice;
            this.bookOnHand = bookOnHand;
            this.bookTransDate = bookTransDate;
        }

        public BookClass()
        {
            // null
        }

        public void displayBookRecord(string nextRecord)
        {
            Console.WriteLine(nextRecord);
        }

        public bool bookMatch(string ISBN, string nextRecord)
        {
            string[] lines = System.IO.File.ReadAllLines("currentBookFile.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(ISBN))
                {
                    return true;
                }
            }
            return false;
        }

        public bool verifyISBN(string ISBN)
        {
            string[] lines = System.IO.File.ReadAllLines("currentBookFile.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(ISBN))
                {
                    Console.WriteLine(lines[i]);
                    return true;
                }
            }
            return false;
        }

        public Boolean getRecord(string ISBN, out string getBookISBN, out string getBookTitle, out string getBookAuthor,
            out string getBookPrice, out string getBookOnHand, out string getBookTransDate)
        {
            getBookISBN = "";
            getBookTitle = "";
            getBookAuthor = "";
            getBookPrice = "";
            getBookOnHand = "";
            getBookTransDate = "";

            string[] lines = System.IO.File.ReadAllLines("currentBookFile.txt");
            string holder = "";
            int count = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(ISBN))
                {
                    Console.WriteLine(lines[i]);
                    holder = lines[i];
                }
            }
            string[] bookParts = holder.Split('*');

            foreach(string element in bookParts)
            {
                if(count == 0)
                {
                    getBookISBN = element;
                    getBookISBN = getBookISBN.Trim();
                    count++;
                }
                else if(count == 1)
                {
                    getBookTitle = element;
                    getBookTitle = getBookTitle.Trim();
                    count++;
                }
                else if(count == 2)
                {
                    getBookAuthor = element;
                    getBookAuthor = getBookAuthor.Trim();
                    count++;
                }
                else if(count == 3)
                {
                    getBookPrice = element;
                    getBookPrice = getBookPrice.Trim();
                    count++;
                }
                else if(count == 4)
                {
                    getBookOnHand = element;
                    getBookOnHand = getBookOnHand.Trim();
                    count++;
                }
                else if(count == 5)
                {
                    getBookTransDate = element;
                    getBookTransDate = getBookTransDate.Trim();
                    count++;
                }
            }
            return false;
        }
    }
}