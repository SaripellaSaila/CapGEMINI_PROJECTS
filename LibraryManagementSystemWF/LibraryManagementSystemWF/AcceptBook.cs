using LibraryManagentSystemEF.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemWF
{
	public partial class AcceptBook : Form
	{
		public int BookId;
		public string BookTitle;
		public string Status;




		LibraryBLL libraryBLL = new LibraryBLL();

		public AcceptBook()
		{

			InitializeComponent();
			DataSet ds = libraryBLL.NotificationAdmin();
			dvgAcceptBooks.DataSource = ds.Tables[0];
			progressBar1.Visible = false;

		}



		private void btnAcceptBook_Click(object sender, EventArgs e)
		{
			MessageBox.Show("BookId is" + BookId.ToString()+"Book Title is" +BookTitle+ "Issued Successfully");
			int result = libraryBLL.AcceptBookBLL(BookId);
			if(result>0)
			{
				MessageBox.Show("Book Issued Successfully");
			}
			else
			{
				MessageBox.Show("Please select book to Issue");
			}
		}

		

		private void dvgAcceptBook_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
		{
			BookId = int.Parse(dvgAcceptBooks.CurrentRow.Cells[0].Value.ToString());
			BookTitle = dvgAcceptBooks.CurrentRow.Cells[1].Value.ToString();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnRejectBook_Click(object sender, EventArgs e)
		{
			int result = libraryBLL.RejectBookBLL(BookId);
			if(result>0)
			{
				MessageBox.Show("Book Rejected");
			}
			else
			{
				MessageBox.Show("Please select book to reject");
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			dvgAcceptBooks.Visible = false;

			progressBar1.Visible = true;
			for (int i = 1; i <= 100; i++)
			{
				Thread.Sleep(10);
				progressBar1.Value = i;
			}
			progressBar1.Visible = false;
			dvgAcceptBooks.Visible = true;
			DataSet ds = libraryBLL.GetBookBLL();

			dvgAcceptBooks.DataSource = ds.Tables[0];
		}
	}
}
