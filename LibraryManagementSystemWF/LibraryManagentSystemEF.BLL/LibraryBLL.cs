using LibraryManagementSystemWF.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagentSystemEF.BLL
{
    public class LibraryBLL
    {
        LibraryDAL libraraDal = new LibraryDAL();
        public int RejectBookBLL(int bid)
        {
            return libraraDal.RejectBookDAL(bid);
        }
        public DataSet AdminBookTransactionBLL()
        {
            return libraraDal.AdminBookTransactionDAL();
        }

        public DataSet NotificationAdmin()
        {
            return libraraDal.AdminNotificationDAL();
        }
        public DataSet UserNotificationBLL()
        {
            return libraraDal.UserNotificationDAL();
        }

        public int adminLoginBLL(string Username, string Password)
        {

            return libraraDal.adminLoginDAL(Username, Password);
        }

        public int userLoginBLL(string Username, string Password)
        {

            return libraraDal.userLoginDAL(Username, Password);
        }

        public DataSet GetBookBLL()
        {
            return libraraDal.GetBooksDAL();
        }
        public bool AddBookBLL(int id, string bname, string bauthor, int copies, string status)
        {
            bool IsBookValidated = false;
            try
            {
                libraraDal.AddBookDAL(id, bname, bauthor, copies, status);
                IsBookValidated = true;
            }
            catch { }
            return IsBookValidated;

        }
        public bool UpdateBookBLL(int id, string bname, string bauthor, int copies, string status)
        {
            bool IsBookValidated = false;
            try
            {
                libraraDal.UpdateBookDAL(id, bname, bauthor, copies, status);
                IsBookValidated = true;
            }
            catch { }
            return IsBookValidated;

        }
        public bool DeleteBookBLL(int id)
        {
            bool IsBookValidated = false;
            try
            {
                libraraDal.DeleteBookDAL(id);
                IsBookValidated = true;
            }
            catch { }
            return IsBookValidated;

        }
        public DataSet GetUserBLL()
        {
            return libraraDal.GetUserDAL();
        }
        public int AcceptUserBLL(int pno)
        {
            return libraraDal.AcceptUserDAL(pno);
        }
        public int AddUserBLL(int pno, string uname, string upassword)
        { 
               return  libraraDal.AddUserDAL(pno, uname,upassword);
        }
        public int RequestBookBLL(int bookId, string bookName)
        {
            return libraraDal.RequetBookDAL(bookId, bookName);
        }
        public int AcceptBookBLL(int bid)
        {
            return libraraDal.AcceptBookDAL(bid);
        }
        public int ReturnBookBLL(int bid)
        {
            return libraraDal.ReturnBookDAL(bid);
        }


    }
}
