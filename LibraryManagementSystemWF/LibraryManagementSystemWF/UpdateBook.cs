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
    public partial class UpdateBook : Form
    {
        LibraryBLL libraryBLL=new LibraryBLL();
        public UpdateBook()
        {
           
            InitializeComponent();
            tbName.Focus();
            tbId.Text = AdminHomeScreen.Id.ToString();
            tbName.Text = AdminHomeScreen.BookTitle;
            tbAuthor.Text = AdminHomeScreen.Author;
            tbCopies.Text = AdminHomeScreen.Copies.ToString();
            tbStatus.Text = AdminHomeScreen.Status;
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if(libraryBLL.UpdateBookBLL(int.Parse(tbId.Text), tbName.Text, tbAuthor.Text, int.Parse(tbCopies.Text), tbStatus.Text))
            {
                MessageBox.Show("Updated Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Try Later");
                this.Close();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
