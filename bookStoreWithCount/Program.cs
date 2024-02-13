using System;
using System.Dynamic;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private int _transactions = 0;
        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
        public int getId()
        {
            return _Id;
        }
        public string getTitle()
        {
            return _Title;
        }
        public string getAuthor()
        {
            return _Author;
        }
        public int setId(int id)
        {
            return _Id = id;
        }
        public string setTitle(string title)
        {
            return _Title = title;
        }
        public string setAuthor(string author)
        {
            return _Author = author;
        }
        public int getTrans(int transactions)
        {
            return _transactions++;
        }
        public int SetTrans()
        {
            return _transactions;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.setId(1);
            book1.setTitle("Lallaloopsy Goosy");
            book1.setAuthor("Trucie Goosie");
            book1.SetTrans();

            book book2 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book2.setId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title: ");
            book2.setTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author: ");
            book2.setAuthor(Console.ReadLine());
            book2.SetTrans();

            book book3 = new book(3, "Freddy's Full-Proof Fowl Field Guide", "Freddy F. Fowl");
            book3.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);
            book4.SetTrans();


            Console.WriteLine("The book store has {book1.getTrans()} new books");
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }
        static void displayBooks(book book1)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {book1.getId()}");
            Console.WriteLine($"Book Name: {book1.getTitle()}");
            Console.WriteLine($"Author Name: {book1.getAuthor()}");
        }

    }
}