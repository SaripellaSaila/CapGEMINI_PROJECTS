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
	public partial class UserRegisterForm : Form
	{
		LibraryBLL libraryBll = new LibraryBLL();
		public UserRegisterForm()
		{
			InitializeComponent();
			tbPhoneNo.Focus();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			int result =libraryBll.AddUserBLL(int.Parse(tbPhoneNo.Text), tbUserName.Text, tbPassword.Text);
			if (result>0)
			{
				MessageBox.Show("Signed Up Suucessfully Wait for Admin Confirmation");
				this.Close();
			}
			else
			{
				MessageBox.Show("Try Again");
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void UserRegisterForm_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
