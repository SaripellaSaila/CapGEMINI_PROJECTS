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
	public partial class UserLogin : Form
	{
        

        LibraryBLL libraryBLL = new LibraryBLL();

		public UserLogin()
		{
			InitializeComponent();
            tbUser.Focus();
    }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            int noofrowsEffected = libraryBLL.userLoginBLL(tbUser.Text, tbPwd.Text);
            if (noofrowsEffected > 0)
            {
                labResults.ForeColor = Color.Green;
                labResults.Text = "Logged Successfully";
               // MessageBox.Show("Login SUccessful");

                UserHome userHome = new UserHome();
                userHome.Show();
            }
            else
            {
                labResults.ForeColor = Color.Red;
                labResults.Text = "Invalid UserName or Password";
                // MessageBox.Show("Invalid username or password");

            }
            tbPwd.Clear();
            tbUser.Clear();


        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegisterForm userRegisterForm = new UserRegisterForm();
            userRegisterForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
	}
