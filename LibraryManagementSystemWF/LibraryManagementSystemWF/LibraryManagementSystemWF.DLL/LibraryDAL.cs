﻿using LibraryManagementSystemWF.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemWF.DLL
{
    public class LibraryDAL
    {
        public static SqlConnection conn = new SqlConnection("Server=DESKTOP-QVAP8PB\\SQLEXPRESS1;database=LibraryManagementSystem;Integrated security=true");
        public int adminLoginDAL(string Username, string Password)
        {
            SqlCommand cmd = new SqlCommand("Select count(*) from AdminLogin where Username=@uname and Password= @pwd", conn);
            cmd.Parameters.Add(new SqlParameter("@uname", Username));
            cmd.Parameters.Add(new SqlParameter("@pwd", Password));
            conn.Open();
            int noofrowsaffected = (int)cmd.ExecuteScalar(); conn.Close();
            return noofrowsaffected;
        }
        public int userLoginDAL(string Username, string Password)
        {
            string status = "Added";
            SqlCommand cmd = new SqlCommand("Select count(*) from UserLogin where Username=@uname and Password= @pwd and Status=@status", conn);
            cmd.Parameters.Add(new SqlParameter("@uname", Username));
            cmd.Parameters.Add(new SqlParameter("@pwd", Password));
            cmd.Parameters.Add(new SqlParameter("@status", status));
            conn.Open();
            int noofrowsaffected = (int)cmd.ExecuteScalar(); conn.Close();
            return noofrowsaffected;
        }
        public DataSet GetBooksDAL()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from InfoBook", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void AddBookDAL(int Id, string bname, string bauthor, int copies, string status)
        {
            string query = "insert into InfoBook values (@Id, @BookTitle, @Author, @Copies, @Status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            cmd.Parameters.Add(new SqlParameter("@BookTitle", bname));
            cmd.Parameters.Add(new SqlParameter("@Author", bauthor));
            cmd.Parameters.Add(new SqlParameter("@Copies", copies));
            cmd.Parameters.Add(new SqlParameter("@Status", status));
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateBookDAL(int Id, string bname, string bauthor, int copies, string status)
        {
            SqlCommand cmd = new SqlCommand("update InfoBook set BookTitle=@name, Author=@loc, Copies=@sal, Status=@deptid where Id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", Id));
            cmd.Parameters.Add(new SqlParameter("@name", bname));
            cmd.Parameters.Add(new SqlParameter("@loc", bauthor));
            cmd.Parameters.Add(new SqlParameter("@sal", copies));
            cmd.Parameters.Add(new SqlParameter("@DeptId", status));
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteBookDAL(int Id)
        {
            SqlCommand cmd = new SqlCommand("delete from InfoBook where @Id=Id", conn);
            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataSet GetUserDAL()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from UserLogin where Status='Pending'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int AcceptUserDAL(int pno)
        {  
                string status = "Added";
                SqlCommand cmd = new SqlCommand("update UserLogin set Status=@status  where PhoneNo=@pno", conn);
                cmd.Parameters.Add(new SqlParameter("@pno", pno));
                cmd.Parameters.Add(new SqlParameter("@status", status));
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;         
        }
        public int AddUserDAL(int pno, string uname, string upassword)
        {
            string status = "Pending";
            string query = "insert into UserLogin values (@PhoneNo, @Username, @Password,@Status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@PhoneNo", pno));
            cmd.Parameters.Add(new SqlParameter("@Username", uname));
            cmd.Parameters.Add(new SqlParameter("@Password", upassword));
            cmd.Parameters.Add(new SqlParameter("@Status", status));
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public int RequetBookDAL(int bookId, string booktitle)
        {
            string status = "Pending";
            string query = "insert into BookTranscation values(@Id, @BookTitle, null, null, @Status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@Id", bookId));
            cmd.Parameters.Add(new SqlParameter("@BookTitle", booktitle));
            cmd.Parameters.Add(new SqlParameter("@Status", status));
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
     

    }
}