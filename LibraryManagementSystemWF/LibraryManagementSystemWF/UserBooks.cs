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
	public partial class UserBooks : Form
	{
		LibraryBLL libraryBLL = new LibraryBLL();
		public int BookId;
		public UserBooks()
		{
			InitializeComponent();
			DataSet ds = libraryBLL.UserNotificationBLL();
			dvgUserBooks.DataSource = ds.Tables[0];
		}

		private void dvgUserBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BookId = int.Parse(dvgUserBooks.CurrentRow.Cells[0].Value.ToString());
		}

		private void btnReturnBook_Click(object sender, EventArgs e)
		{
			int result = libraryBLL.ReturnBookBLL(BookId);
			if(result>0)
			{
				MessageBox.Show("Book Returned Successfully");
			}
			else
			{
				MessageBox.Show("Try Later");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
