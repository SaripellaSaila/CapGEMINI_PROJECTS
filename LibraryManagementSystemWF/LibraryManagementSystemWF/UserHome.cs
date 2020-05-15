using LibraryManagementSystemWF.Entities;
using LibraryManagentSystemEF.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemWF
{
	public partial class UserHome : Form
	{
		public static int Id;
		public static string BookTitle;
		public static string Author;
		public static int Copies;
		public static string Status;


		LibraryBLL libraryBLL = new LibraryBLL();
	
		public UserHome()
		{
			InitializeComponent();
			DataSet ds = libraryBLL.GetBookBLL();

			dgvUser.DataSource = ds.Tables[0];

		}

		private void dgvUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Id = int.Parse(dgvUser.CurrentRow.Cells[0].Value.ToString());
			BookTitle = dgvUser.CurrentRow.Cells[1].Value.ToString();
			Author = dgvUser.CurrentRow.Cells[2].Value.ToString();
			Copies = int.Parse(dgvUser.CurrentRow.Cells[3].Value.ToString());
			Status = dgvUser.CurrentRow.Cells[4].Value.ToString();
		}
		private void btnRequest_Click(object sender, EventArgs e)
		{
			int result = libraryBLL.RequestBookBLL(Id,BookTitle);

			if (result > 0)
			{
				MessageBox.Show("RequestSent Successfully");
			}
			else
			{
				MessageBox.Show("server error try later");
			}

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnTransaction_Click(object sender, EventArgs e)
		{
			UserBooks userBooks = new UserBooks();
			userBooks.Show();
		}

		
	}
}
