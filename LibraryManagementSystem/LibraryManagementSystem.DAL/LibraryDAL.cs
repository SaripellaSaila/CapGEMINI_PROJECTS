using System;
using System.Collections.Generic;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Exceptions;

namespace LibraryManagementSystem.DAL
{
    public class LibraryDAL
    {

        public static List<Book> LstofBook = new List<Book>();     
        public static List<Book> RequestNewBook = new List<Book>();
        public List<Book> transactionBooks = new List<Book>();
        public static List<Book> IssuedBooksList = new List<Book>();
        static List<Login> UserList = new List<Login>();

        //user login
        public bool UserDAL(string Username, string Password)
        {
            bool UserLogin = false;
            foreach (var user in UserList)
            {
                if (user.Username == Username && user.Password == Password)
                {
                    UserLogin = true;
                    return UserLogin;
                }
            }
            return UserLogin;
        }
        //add user
        public bool AdduserDAL(string UserName, string Password)
        {
            UserList.Add(new Login(UserName, Password));
            return true;
        }

        public List<Login> UserRegistrationDAL(string Userid, string UserPassword)
        {
            UserList.Find(b => b.Username == Userid);
            Console.WriteLine("Book Requested Successfully");
            return UserList;
        }

        //login admin
        public bool AdminDAL(string Username, string Password)
        {
            if (Username == Login.AdminUsername && Password == Login.AdminPassword)
                return true;
            else
                return false;
        }

        //To Add Book
        public bool AddBookDAL(int bid, string bbooktitle, string bauthor, int bcopies, string bstatus)
        {
            bool IsBookAdded = false;
            Book book = new Book() { Id = bid, BookTiTle = bbooktitle, Author = bauthor, Copies = bcopies, Status = bstatus };
            try
            {
                LstofBook.Add(book);
                IsBookAdded = true;
            }
            catch (ApplicationException e)
            {
                throw new LibraryExceptions(e.Message);
            }
            return IsBookAdded;
        }

        //To Update Book
        public bool UpdateBookDAL(int bid, string bbooktitle, string bauthor, int bcopies, string bstatus)
        {
            bool IsBookUpdated = false;
            try
            {
                Book UpdateBook = LstofBook.Find(b => b.Id == bid);
                UpdateBook.Id = bid;
                UpdateBook.BookTiTle = bbooktitle;
                UpdateBook.Author = bauthor;
                UpdateBook.Copies = bcopies;
                UpdateBook.Status = bstatus;   
                IsBookUpdated = true;
            }
            catch (ApplicationException e)
            {
                throw new LibraryExceptions(e.Message);
            }
            return IsBookUpdated;
        }

        //To Delete Book
        public bool DeleteBookDAL(int bid)
        {
            bool IsBookDeleted = false;
            try
            {
                Book Deletebook = LstofBook.Find(b => b.Id == bid);
                LstofBook.Remove(Deletebook);
            }
            catch (ApplicationException e)
            {
                throw new Exception(e.Message);
            }
            return IsBookDeleted;
        }

        //To Get List Of Books
        public List<Book> GetLstOfBookDAL()
        {
              return LstofBook;
        }

        public List<Book> RequestBookDAL(int bid)
        {
            Book RequestedBook = LstofBook.Find(b => b.Id == bid);
            transactionBooks.Add(RequestedBook);
            Console.WriteLine("Book Requested Successfully");
            return transactionBooks;
        }
        public int ViewRequestDAL()
        {
            if (transactionBooks.Count > 0)
                foreach (var ele in transactionBooks)
                {
                    Console.WriteLine(ele.Id + "\t" + ele.BookTiTle + "\t" + ele.Author + "\t" + ele.Copies + "\t" + ele.Status);
                }

            else
            {
                Console.WriteLine("No Requests");
            }
            return transactionBooks.Count;
        }
        public bool IssuedOrRejectDAL(int bid, int IssueOrNot)
        {
            Book issuedBook = transactionBooks.Find(b => b.Id == bid);
            Console.WriteLine(issuedBook.Id + "\t" + issuedBook.BookTiTle);
            transactionBooks.Remove(issuedBook);
            if (IssueOrNot == 1)
            {
                IssuedBooksList.Add(issuedBook);
                Console.WriteLine("Issued Successfull");
                return true;
            }
            else
            {
                Console.WriteLine("Book Rejected!!");
                return false;
            }
        }
        public void IssuedBooksDAL()
        {
            if (IssuedBooksList.Count > 0)
            {
                Console.WriteLine("=============================================================================");
                foreach (var ele in IssuedBooksList)
                {
                    Console.WriteLine(ele.Id + "\t" + ele.BookTiTle + "\t" + ele.Author);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No notifications");
            }
        }
    }
}
