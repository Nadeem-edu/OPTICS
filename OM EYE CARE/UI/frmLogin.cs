using OM_EYE_CARE.BLL;
using OM_EYE_CARE.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OM_EYE_CARE.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Closing This Window
            this.Close();
        }

        private void btnloginsubmit_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text.Trim();
            l.password = txtpassword.Text.Trim();

            // Checking hte login Credentials
            bool sucess = dal.LoginCheck(l);
            if(sucess==true)
            {
                // Login Successfull
                 MessageBox.Show("Login Successful.");

                //to loggedIN 
                loggedIn = l.username;
            
               

                // Disply Customer DashBoard
                frmcust user = new frmcust();
                user.Show();
                this.Hide();
            }

            else
            {
                // Login Failed
                MessageBox.Show("Login Failed. Try Again");
            }
        }

        private void CBshowpassword_CheckedChanged(object sender, EventArgs e)
        {

            this.txtpassword.PasswordChar = this.CBshowpassword.Checked ? char.MinValue : '*';
        }
    }
}
