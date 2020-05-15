using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.BLL
{
    public class LibraryManagementSystemBLL
    {
       
      static  LibraryDAL dAL = new LibraryDAL();

        //Validations for Admin Login
       /*public bool ValidateAdmin(Login login)
        {
            StringBuilder sb = new StringBuilder();
            bool IsAdminValidated = false;
            if(login.Username==string.Empty)
            {
                sb.Append("Invalid User Name");
            }
            if(login.Password==string.Empty)
            {
                sb.Append("Invalid Password");
            }
            return IsAdminValidated;
        }*/

        //Validations for Admin Login
        public bool ValidateAdmin(Login login)
        {
            bool IsAdminValidated = false;
            if (login.Username == string.Empty )
            {
                IsAdminValidated = false;
                Console.WriteLine("Invalid");
            }
            if (login.Password == string.Empty)
            {
                IsAdminValidated = false;
                Console.WriteLine("Invalid password");
            }
            return IsAdminValidated;
        }
          
    //Validations for User Login
    public bool ValidateUser(Login login)
        {
            StringBuilder sb = new StringBuilder();
            bool IsAdminValidated = false;
            if (login.Username == string.Empty)
            {
                sb.Append("Invalid User Name");
            }
            if (login.Password == string.Empty)
            {
                sb.Append("Invalid Password");
            }
            return IsAdminValidated;
        }
        

        //  //Validations for a Book
        public bool ValidateBook(Book book)
        {
            StringBuilder sb = new StringBuilder();
            bool IsBookValidated = false;
            if (book.Id <= 0)
            {
                IsBookValidated = false;
                sb.Append("Invaild Id");       
            }
            if (book.BookTiTle == string.Empty || book.BookTiTle.Length < 20)
            {
                sb.Append("Invaild BookTitle");
            }
            if (book.Author == string.Empty)
            {
                sb.Append("Invaild Author");
            }
            if (book.Copies <= 0)
            {
                sb.Append("Invaild Copies");
            }
            if (book.Status == string.Empty)
            {
                sb.Append("Invaild Status");
            }
            return IsBookValidated;
        }

        //Admin Login
        public bool AdminBLL(string Username, string Password)
        {
            bool IsAdminAdded = false;
            try
            {
               
              return  dAL.AdminDAL(Username, Password);
               
            }
            catch
            {
                
            }
            return IsAdminAdded;
        }

        
            public bool UserRegistrationBLL(string Username, string Password)
            {
            bool IsUserReg = false;
            try
            {
                return dAL.UserDAL(Username, Password);

            }
            catch
            {

            }
            return IsUserReg;
        }
        //User Login
        public bool UserBLL(string Username, string Password)
        {
            bool IsUserAdded = false;
            try
            {
              return dAL.UserDAL(Username, Password);
                
            }
            catch
            {

            }
            return IsUserAdded;
        }

        public bool AdduserBLL(string Username, string Password)
        {
            bool IsUserAdded = false;
            try
            {
                return dAL.AdduserDAL(Username, Password);

            }
            catch
            {

            }
            return IsUserAdded;
        }


        //To Add a Book
        public bool AddBookBLL(int id, string booktitle, string author, int copies,  string status)
        {
            bool IsBookAdded = false;
            try
            {
                dAL.AddBookDAL(id, booktitle, author, copies,  status);
                return IsBookAdded = true;
            }
            catch
            {

            }
            return IsBookAdded;
        }

        //To Update a Book
        public bool UpdateBookBLL(int bid, string bbooktitle, string bauthor, int bcopies, string bstatus)
        {
            bool IsBookUpdated = false;
            try
            {
                dAL.UpdateBookDAL(bid, bbooktitle, bauthor, bcopies, bstatus);
                return IsBookUpdated = true;
            }
            catch
            {

            }
            return IsBookUpdated;
        }


        //Delete a Book
        public bool DeleteBookBLL(int bid)
        {
            bool IsBookDelete = false;
            try
            {
                dAL.DeleteBookDAL(bid);
                return IsBookDelete = true;
            }
            catch
            {

            }
            return IsBookDelete;
        }

        //To Get List of all Books
        public List<Book> GetLstOfBookBLL()
        {
            return dAL.GetLstOfBookDAL();
        }

        public bool RequestBookBLL(int bid)
        {
            bool IsBookRequested = false;
            try
            {
                dAL.RequestBookDAL(bid);
                IsBookRequested = true;
            }
            catch
            {

            }
            return IsBookRequested;
        }
        public bool ViewRequestBLL()
        {
            bool isRequestsViewed = false;
            try
            {
                dAL.ViewRequestDAL();
                isRequestsViewed = true;
            }
            catch { }
            return isRequestsViewed;
        }
        public bool IssueOrRejectBLL(int bid, int AcceptOrNot)
        {
            return dAL.IssuedOrRejectDAL(bid, AcceptOrNot);
        }
        public bool IssuedBooksBLL()
        {
            bool isBookAccepted = false;
            try
            {
                dAL.IssuedBooksDAL();
                isBookAccepted = true;
            }
            catch {
            }
            return isBookAccepted;
        }
    }
}