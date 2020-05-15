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
   
	 public partial class AddBook : Form
    {
        LibraryBLL libraryBLL = new LibraryBLL();
        public AddBook()
        {
            InitializeComponent();
            
        }
        private void btnAddBook_Click_1(object sender, EventArgs e)
        {           
            if(libraryBLL.AddBookBLL(int.Parse(tbId.Text), tbName.Text, tbAuthor.Text, int.Parse(tbCopies.Text), tbStatus.Text))
                {
                    MessageBox.Show("Added Successfully");
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

        private void lblBookId_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
