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
	public partial class AdminLogin : Form
    {
        LibraryBLL libraryBLL = new LibraryBLL();

        public AdminLogin()
		{
			InitializeComponent();
            tbUser.Focus();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int noofrowsEffected = libraryBLL.adminLoginBLL(tbUser.Text, tbPwd.Text);
            if (noofrowsEffected > 0)
            {
                labResults.ForeColor = Color.Green;
                labResults.Text = "Logged Successfully";
                AdminHomeScreen homeScreen = new AdminHomeScreen();
                homeScreen.Show();
            }
            else
            {
                labResults.ForeColor = Color.Red;
                labResults.Text = "Invalid UserName or Password";
                //MessageBox.Show("Invalid username or password");
            }
            tbPwd.Clear();
            tbUser.Clear();
        }
        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
