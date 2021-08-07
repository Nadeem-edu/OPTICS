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
using System.Text.RegularExpressions;

namespace OM_EYE_CARE.UI
{
    public partial class frmusers : Form
    {
        public frmusers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        usersDAL dal = new usersDAL();

        // For Closeing User from click on delete picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmusers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.select();
            dgvuserview.DataSource = dt;
        }

        private void txtuserLname_TextChanged(object sender, EventArgs e)
        {

        }

        // For Submit Button 
        private void btnusersubmit_Click(object sender, EventArgs e)
        {
   
            //Getting Data From UI
            u.first_name = txtuserfname.Text;
            u.last_name = txtuserLname.Text;
            u.username = txtusername.Text;
            u.password = txtuserpass.Text;
            u.email_id = txtuseremail_id.Text;
            u.address = txtuseraddress.Text;
            u.contact_no = txtusercontact_no.Text;
            u.gender = cbusergender.Text;

            string loggedUser = frmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by =usr.user_id;

            //Inserting data into database

            bool success = dal.Insert(u);
            //if the data is successfully iinserted then the value of success will be true else it will be false
            if (success == true)
            {
                //Data sucessfully inserted
                MessageBox.Show("Successfully Added Data.");

                clear(); //In After Click on Submit This Fuction is Called.

            }
            else
            {
                //Failed to Insert Data
                MessageBox.Show("Failed to Add Data.");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.select();
            dgvuserview.DataSource = dt;
        }



        // For Clear Function  
        private void clear()
        {
            txtuserID.Text = "";
            txtuserfname.Text = "";
            txtuserLname.Text = "";
            txtusername.Text = "";
            txtuserpass.Text = "";
            txtuseremail_id.Text = "";
            txtuseraddress.Text = "";
            txtusercontact_no.Text = "";
            cbusergender.Text = "";


        }
        

        //For Displying Data in Data Grid view
        private void dgvuserview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtuserID.Text = dgvuserview.Rows[rowIndex].Cells[0].Value.ToString();
            txtuserfname.Text = dgvuserview.Rows[rowIndex].Cells[1].Value.ToString();
            txtuserLname.Text = dgvuserview.Rows[rowIndex].Cells[2].Value.ToString();
            txtusername.Text = dgvuserview.Rows[rowIndex].Cells[3].Value.ToString();
            txtuserpass.Text = dgvuserview.Rows[rowIndex].Cells[4].Value.ToString();
            txtuseremail_id.Text = dgvuserview.Rows[rowIndex].Cells[5].Value.ToString();
            txtuseraddress.Text = dgvuserview.Rows[rowIndex].Cells[6].Value.ToString();
            txtusercontact_no.Text = dgvuserview.Rows[rowIndex].Cells[7].Value.ToString();
            cbusergender.Text = dgvuserview.Rows[rowIndex].Cells[8].Value.ToString();

        }

        // BUTTON UPDATE
        private void btnuserupdate_Click(object sender, EventArgs e)
        {
            u.user_id = Convert.ToInt32(txtuserID.Text);
            u.first_name= txtuserfname.Text;
            u.last_name = txtuserLname.Text;
            u.username = txtusername.Text;
            u.password = txtuserpass.Text;
            u.email_id = txtuseremail_id.Text;
            u.address = txtuseraddress.Text;
            u.contact_no = txtusercontact_no.Text;
            u.gender = cbusergender.Text;

            //Updating Data Into Database
            bool success = dal.Update(u);
            //If data is updated successfully then the value of sucess will be 
            if (success == true)
            {
                //Data Updated Successfully 
                MessageBox.Show("User Details Successfully Updated");
                clear();
            }
            else
            {
                // Failed To Update User
                MessageBox.Show("Failed to Update User");
            }
            //Refreshing Data Grid View
            DataTable dt = dal.select();
            dgvuserview.DataSource = dt;
        }
        
        // BUTTON CLEAR
        private void btnuserclear_Click(object sender, EventArgs e)
        {
            txtuserID.Text = "";
            txtuserfname.Text = "";
            txtuserLname.Text = "";
            txtusername.Text = "";
            txtuserpass.Text = "";
            txtuseremail_id.Text = "";
            txtuseraddress.Text = "";
            txtusercontact_no.Text = "";
            cbusergender.Text = "";
        }

        //BUTTON DELETE
        private void btnuserdelete_Click(object sender, EventArgs e)
        {
            //Getting Customer ID From Form
            u.user_id = Convert.ToInt32(txtuserID.Text);

            bool success = dal.Delete(u);
            //if data is Deleted then the value of sucess will be true else it will be false
            if (success == true)
            {
                //Customer Deleted Successfully
                MessageBox.Show("Customer Details Deleted Successfully");
                clear();
            }
            else
            {
                //Failed to Delete Customer
                MessageBox.Show("Failed to Delete Customer Details");
            }
            //refreshing Datagrid View
            DataTable dt = dal.select();
            dgvuserview.DataSource = dt;
        }

        // TEXTBOX SEARCH USER
        private void txtusersearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from Text Box
            string keywords = txtusersearch.Text;

            //Check if the keywords has value or not
            if (keywords != null)
            {
                // Show Customers based on Keywords
                DataTable dt = dal.Search(keywords);
                dgvuserview.DataSource = dt;

            }
            else
            {
                //show all customer from the database
                DataTable dt = dal.select();
                dgvuserview.DataSource = dt;

            }
        }

        private void txtusercontact_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtuseremail_id_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" + @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" + @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            if (Regex.IsMatch(txtuseremail_id.Text, pattern))
            {
                emailerroruser.Clear();
            }
            else
            {
                emailerroruser.SetError(this.txtuseremail_id, "Please Enter Valid Email Id");
            }
        }

        private void txtusercontact_no_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

