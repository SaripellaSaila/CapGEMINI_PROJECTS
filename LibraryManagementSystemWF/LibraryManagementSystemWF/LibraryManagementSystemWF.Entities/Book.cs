using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemWF.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string BookTiTle { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }
        public string Status { get; set; }
    }
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class BookTransaction
    {
        public int BookID { get; set; }
        public String BookName { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Status { get; set; }

    }
    public class UserLogin
    {
        public string PhoneNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
