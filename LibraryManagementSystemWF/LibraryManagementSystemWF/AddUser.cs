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
	public partial class AddUser : Form
	{
		public static string Username;
		public static string Password;
		public static string Status;
		LibraryBLL libraryBLL = new LibraryBLL();
		public static int PhoneNo;
		public AddUser()
		{
			InitializeComponent();
			progressBar1.Visible = false;
			DataSet ds = libraryBLL.GetUserBLL();
			dgvUser.DataSource = ds.Tables[0];
		}
 
		private void dgvUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			PhoneNo = int.Parse(dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString());
			Username = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
			Password = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
			Status = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();	
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			int result = libraryBLL.AcceptUserBLL(AddUser.PhoneNo);
				if (result >= 1)
				{
					MessageBox.Show("Updated Successfully");
					
				}
				else
				{
					MessageBox.Show("Plz Select any User to Add");	
				}		
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			dgvUser.Visible = false;
			progressBar1.Visible = true;
			for (int i = 1; i <= 100; i++)
			{
				Thread.Sleep(10);
				progressBar1.Value = i;
			}
			progressBar1.Visible = false;
			dgvUser.Visible = true;
			DataSet ds = libraryBLL.GetUserBLL();
			dgvUser.DataSource = ds.Tables[0];
		}

		private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}