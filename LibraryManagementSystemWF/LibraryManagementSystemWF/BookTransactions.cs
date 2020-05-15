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
	public partial class BookTransactions : Form
	{
		LibraryBLL libraryBLL = new LibraryBLL();

		public BookTransactions()
		{
			InitializeComponent();
			DataSet ds = libraryBLL.AdminBookTransactionBLL();
			dvgBookTransaction.DataSource = ds.Tables[0];
		}

		private void dvgBookTransaction_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
