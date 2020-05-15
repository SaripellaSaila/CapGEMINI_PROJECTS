using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    //For a Book
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
        public static string AdminUsername = "admin";
        public static string AdminPassword = "admin";
        public string Username;
        public string Password;
        public string Userid;
        public string password;
        public Login(string name, string password)
        {
            Username = name;
            Password = password;
        }
    }
}