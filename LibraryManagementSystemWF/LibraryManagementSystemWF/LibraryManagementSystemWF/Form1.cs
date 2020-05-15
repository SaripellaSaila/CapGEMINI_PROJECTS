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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Click On Admin If Your is Admin.
        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
        }
        //Click On User If Your is User.
        private void btnUser_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
