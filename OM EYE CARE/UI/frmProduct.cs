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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        productBLL prod = new productBLL();
        productDAL pdal = new productDAL();
        userBLL u = new userBLL();
        usersDAL DAL = new usersDAL();

        private void frmProduct_Load(object sender, EventArgs e)
        {
            DataTable prod_dt = pdal.select();
            dgvproductview.DataSource = prod_dt;

        }

        //%%%%%%%%%%%%%%%%%    ADD BUTTON
        private void btngbproAdd_Click(object sender, EventArgs e)
        {
            prod.p_name = txtgbprodName.Text;
            prod.qty = Convert.ToInt32 (txtgbproqty.Text);
            prod.added_date = DateTime.Now;

            //Getting the ID to Logged in user and passign its value in customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = DAL.GetIDFromUsername(loggedUsr);
            prod.added_by = usr.user_id;

            //Inserting data into database

            bool success = pdal.Insert(prod);
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
            DataTable prod_dt = pdal.select();
            dgvproductview.DataSource = prod_dt;

        }

        //%%%%%%%%%%%%%%%%%    For Clear All Data From Textbox WHEN ADD BUTTON CLICK'S
        private void clear()
        {

            lblgbproiddisplay.Text = "";
            txtgbprodName.Text = "";
            txtgbproqty.Text = "";

        }

        //%%%%%%%%%%%%%%%%%%   DATAGRID VIEW MOUSE CLICK OPTION
        private void dgvproductview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of Particular row
            int rowIndex = e.RowIndex;
            lblgbproiddisplay.Text = dgvproductview.Rows[rowIndex].Cells[0].Value.ToString();
            txtgbprodName.Text= dgvproductview.Rows[rowIndex].Cells[1].Value.ToString();
            txtgbproqty.Text= dgvproductview.Rows[rowIndex].Cells[2].Value.ToString();

        }

        //%%%%%%%%%%%%%%%%%%   UPDATE BUTTON 
        private void btngbproupdate_Click(object sender, EventArgs e)
        {
            prod.p_id = Convert.ToInt32(lblgbproiddisplay.Text);
            prod.p_name = txtgbprodName.Text;
            prod.qty = Convert.ToInt32(txtgbproqty.Text);
            prod.added_date = DateTime.Now;

            //Getting the ID to Logged in user and passign its value in customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = DAL.GetIDFromUsername(loggedUsr);
            prod.added_by = usr.user_id;


            //Updating Data Into Database
            bool success = pdal.Update(prod);
            //If data is updated successfully then the value of sucess will be 
            if (success == true)
            {
                //Data Updated Successfully 
                MessageBox.Show("Customer Details Successfully Updated");
                clear();
            }
            else
            {
                // Failed To Update User
                MessageBox.Show("Failed to Update Customer Details");
            }

            //Refreshing Data Grid View
            DataTable prod_dt = pdal.select();
            dgvproductview.DataSource = prod_dt;
        }

        //%%%%%%%%%%%%%%%%%%   DELETE BUTTON 
        private void btngbprodelete_Click(object sender, EventArgs e)
        {
            prod.p_id = Convert.ToInt32(lblgbproiddisplay.Text);

            bool success = pdal.Delete(prod);
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

            //Refreshing Data Grid View
            DataTable prod_dt = pdal.select();
            dgvproductview.DataSource = prod_dt;

        }

        //%%%%%%%%%%%%%%%%%%   TO SERACH THE DATA FORM DATAGRID VIEW 
        private void txtproSearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from Text Box
            string keywords = txtproSearch.Text;

            //Check if the keywords has value or not
            if (keywords != null)
            {
                // Show Customers based on Keywords
                DataTable prod_dt = pdal.Search(keywords);
                dgvproductview.DataSource = prod_dt;

            }
            else
            {
                //show all customer from the database
                DataTable prod_dt = pdal.select();
                dgvproductview.DataSource = prod_dt;

            }
        }

        //%%%%%%%%%%%%%%%%%    TO TYPE ONLY NUMBER IN QUANTITY TEXTBOX
        private void txtgbproqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //%%%%%%%%%%%%%%%%%    TO CLOSE THE PRODUCT FORM
        private void proclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



    
}
