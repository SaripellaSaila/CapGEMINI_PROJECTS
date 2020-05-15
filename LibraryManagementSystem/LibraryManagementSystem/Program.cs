using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Program
    {
        static List<Book> lstBook = null;
        static List<Book> issuedBook = null;
        static LibraryManagementSystemBLL bLL = new LibraryManagementSystemBLL();
        static string Userid;
        static string UserPassword;

        //User Login
        public static bool User()
        {
            Console.WriteLine("Enter UserName : ");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter Password : ");
            string Password = Console.ReadLine();
            if (bLL.UserBLL(Username, Password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Successfull");
                Console.ForegroundColor = ConsoleColor.White;

                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid UserName or Password");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
        public static void UserRegistration()
        {
            Console.WriteLine("enter user name");
            string name = Console.ReadLine();
            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            Console.WriteLine("confirm password");
            string password1 = Console.ReadLine();
            if (password == password1)
            {
                bLL.UserRegistrationBLL(name, password);
                    Console.WriteLine("request sent to Admin!!!");
                    Userid = name;
                    UserPassword = password;
                }
                else
            { 
                    Console.WriteLine("enter valid username or password");
            }
        }

        public static void AddUser(string username, string password)
        {
            if (username != null)
            {
                Console.WriteLine(username + " requested for user login id");
                Console.WriteLine("username :" + Program.Userid);
                Console.WriteLine("password : " + Program.UserPassword);
                Console.WriteLine("press 1 to add user ");
                Console.WriteLine("press 2 to exit");
                int Userid = int.Parse(Console.ReadLine());
                if (Userid == 1)
                {
                    if (bLL.AdduserBLL(username, password))
                    {
                        Console.WriteLine("user added successfully");
                    }
                    else
                        Console.WriteLine("user not added opps!!!");
                }
                else
                    Console.WriteLine("thank you");
            }
            else
            {
                Console.WriteLine("no Request for Adding user");
            }
        }

        //Admin Login
        public static bool Admin()
        {
            Console.WriteLine("Enter UserName : ");
            string Username = Console.ReadLine();
            Username = Username.ToLower();
            Console.WriteLine("Enter Password : ");
            string Password = Console.ReadLine();
            Password = Password.ToLower();
            if(bLL.AdminBLL(Username, Password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Successfull");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid UserName or Password");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }

       
        //To Add Book
        private static void AddBook()
        {
            Console.WriteLine("Plz enter Id");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Plz enter BookTitle");
            string BookTitle = Console.ReadLine();
            Console.WriteLine("Plz enter Author");
            string Author = Console.ReadLine();
            Console.WriteLine("Plz enter Copies");
            int Copies = int.Parse(Console.ReadLine());
            Console.WriteLine("Plz enter Status");
            string Status = Console.ReadLine();

            bLL.AddBookBLL(Id, BookTitle, Author, Copies, Status);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Added Successfull");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //To Update Book
        private static void UpdateBook()
        {
            if (lstBook.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Books List is Empty.. So update is not allowed!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Plz enter Id");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Plz enter BookTitle");
                string BookTitle = Console.ReadLine();
                Console.WriteLine("Plz enter Author");
                string Author = Console.ReadLine();
                Console.WriteLine("Plz enter Copies");
                int Copies = int.Parse(Console.ReadLine());
                Console.WriteLine("Plz enter Status");
                string Status = Console.ReadLine();
                bLL.UpdateBookBLL(Id, BookTitle, Author, Copies, Status);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Updated Successfull");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        //To Delete Book
        private static void DeleteBook()
        {
            Console.WriteLine("Plz enter Id");
            int Id = int.Parse(Console.ReadLine());
            bLL.DeleteBookBLL(Id);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Deleted Successfull");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //To Get List of Books
        private static void LstOfBook()
        {
            lstBook = bLL.GetLstOfBookBLL();
            if (lstBook.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Books List is Empty!!");
               Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach (Book b in lstBook)
                {
                    Console.WriteLine("Book Id is " + "\t"  + b.Id + "\t" + "book name is  "  + "\t" + b.BookTiTle + "\t" + "  book author is" + "\t" + b.Author + "\t" + " book copies is" + "\t" + b.Copies  + "\t" + "book status is" + b.Status);
                }
            }
        }      



        //To Request a Book
        public static void RequestBook()
        {
            Console.WriteLine("Enter the value of book Id");
            int bid = int.Parse(Console.ReadLine());
            bLL.RequestBookBLL(bid);
        }


        public static void ViewRequest()
        {
            bLL.ViewRequestBLL();
        }


        public static void AcceptOrReject()
        {
            Console.WriteLine("Enter Book ID");
            int bid = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press 1 to accept or press anykey to reject");
            Console.ForegroundColor = ConsoleColor.White;
            int AcceptOrNot = int.Parse(Console.ReadLine());
            bLL.IssueOrRejectBLL(bid, AcceptOrNot);
        }

        //To Check For a Transcation Book
        private static void IssuedBooks()
        {
            bLL.IssuedBooksBLL();
        }



        //Main Method
        static void Main(string[] args)
        {
            try
            {
                int continoue = 1;
                while (continoue == 1)
                {
                    try
                    {
                        Console.WriteLine("Welcome to Library Management System");
                        Console.WriteLine("Enter 1 for Admin Login");
                        Console.WriteLine("Enter 2 for User Login");
                        Console.WriteLine("Enter 3 for User Registration");
                        int user = int.Parse(Console.ReadLine());
                        string repeat = "0";
                        switch (user)
                        {
                            case 1:
                                if (Admin())
                                {
                                    while (repeat == "0")
                                    {

                                        Console.WriteLine("Enter 1 to Add Book");
                                        Console.WriteLine("Enter 2 to Delete Book");
                                        Console.WriteLine("Enter 3 to Update Book");
                                        Console.WriteLine("Enter 4 to List of Book");
                                        Console.WriteLine("Enter 5 to View Request");
                                        Console.WriteLine("Enter 6 to Issue Book");
                                        Console.WriteLine("Enter 7 to Add User");
                                        int value = int.Parse(Console.ReadLine());
                                        switch (value)
                                        {
                                            case 1:
                                                AddBook();
                                                break;
                                            case 2:
                                                DeleteBook();
                                                break;
                                            case 3:
                                                UpdateBook();
                                                break;;
                                            case 4:
                                                LstOfBook();
                                                break;
                                            case 5:
                                                ViewRequest();
                                                break;
                                            case 6:
                                                AcceptOrReject();
                                                break;
                                            case 7:
                                                AddUser(Userid, UserPassword);
                                                break;
                                            default:
                                                Console.WriteLine("enter valid digit");
                                                break;
                                        }
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("Enter 0 to continoue as admin");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Enter anything to exit");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        repeat = Console.ReadLine();
                                    }
                                }
                                break;
                            case 2:
                                if (User())
                                {
                                    int UserRepeat = 0;
                                    while (UserRepeat == 0)
                                    {
                                        Console.WriteLine("Enter 1 to display all books");
                                        Console.WriteLine("Enter 2 to Request book");
                                        Console.WriteLine("Enter 3 to Issued Books");
                                        int Uservalue = int.Parse(Console.ReadLine());
                                        switch (Uservalue)
                                        {
                                            case 1:
                                                LstOfBook();
                                                break;
                                            case 2:
                                                RequestBook();
                                                break;
                                            case 3:
                                                IssuedBooks();
                                                break;
                                            default:
                                                Console.WriteLine("enter valid digit");
                                                break;

                                        }
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("Enter 0 to continoue as user");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Enter anything to exit");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        UserRepeat = int.Parse(Console.ReadLine());
                                    }
                                }
                                break;
                            case 3:
                                UserRegistration();
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Enter anything to stop");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Enter 1 to home page");
                    Console.ForegroundColor = ConsoleColor.White;
                    continoue = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid inputs!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
    }

}
