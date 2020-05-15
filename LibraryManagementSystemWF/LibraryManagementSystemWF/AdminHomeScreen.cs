using LibraryManagentSystemEF.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemWF
{
    public partial class AdminHomeScreen : Form
    {
        public static int Id;
        public static string BookTitle;
        public static string Author;
        public static int Copies;
        public static string Status;
        LibraryBLL libraryBLL = new LibraryBLL();

        public AdminHomeScreen()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            DataSet ds = libraryBLL.GetBookBLL();

            dataGridView1.DataSource = ds.Tables[0];
         }
       
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // MessageBox.Show(dgvEmpDetails.Rows[e.RowIndex].ToString());
            Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            BookTitle = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Author = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Copies = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            Status = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //MessageBox.Show(EmpName.ToString());
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (AdminHomeScreen.Id > 0)
            {
                DeleteBook deleteBook = new DeleteBook();
                deleteBook.Show();
            }
            else
            {
                MessageBox.Show("Plz selete Book to delete");
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            progressBar1.Visible = true;
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                progressBar1.Value = i;
            }
            progressBar1.Visible = false;
            dataGridView1.Visible = true;
            DataSet ds = libraryBLL.GetBookBLL();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addScreen = new AddBook();
            addScreen.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                // UpdateBook updateScreen1 = new UpdateBook();
                UpdateBook updateBook = new UpdateBook();
                updateBook.Show();
            }
            else
            {
                MessageBox.Show("Plz select Book to update");
            }
        }

        

      


        private void btnNotifications_Click(object sender, EventArgs e)
        {
            AcceptBook bookTransactions = new AcceptBook();
            bookTransactions.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookTransactions bookTransactions = new BookTransactions();
            bookTransactions.Show();
        }
    }
}
