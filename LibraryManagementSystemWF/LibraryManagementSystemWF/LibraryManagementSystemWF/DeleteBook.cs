using LibraryManagentSystemEF.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemWF
{
    public partial class DeleteBook : Form
    {
        LibraryBLL libraryBLL = new LibraryBLL();
        public DeleteBook()
        {
            InitializeComponent();
            tbId.Text = AdminHomeScreen.Id.ToString();
            tbName.Text = AdminHomeScreen.BookTitle;
            tbAuthor.Text = AdminHomeScreen.Author;
            tbCopies.Text = AdminHomeScreen.Copies.ToString();
            tbStatus.Text = AdminHomeScreen.Status;
        }

      

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            
            if (libraryBLL.DeleteBookBLL(int.Parse(tbId.Text)))
            {
                MessageBox.Show("Deleted Successfull");
                this.Close();
            }
            else
            {
                MessageBox.Show("Try later");
                this.Close();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
