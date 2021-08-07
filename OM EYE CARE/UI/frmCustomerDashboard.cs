using OM_EYE_CARE.BLL;
using OM_EYE_CARE.DAL;
using OM_EYE_CARE.UI;
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

namespace OM_EYE_CARE
{
    public partial class frmcust : Form
    {
        public frmcust()
        {
            InitializeComponent();
        }


        customerBLL c = new customerBLL();
        customerDAL dal = new customerDAL();
        presBLL pr = new presBLL();
        presDAL pdal = new presDAL();
        userBLL u = new userBLL();
        usersDAL DAL = new usersDAL();

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.select();
            gdvcustomerview.DataSource = dt;

            DataTable pdt = pdal.select();
            dgvpredata.DataSource = pdt;

            lblLoggedInUser.Text = frmLogin.loggedIn;
        }


        #region TAB 1 FOR CUSTOMERS DETAILS

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCompanyNameBelow_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void rbnewcustmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        


        //Hear The Code starts...

        private void btnnewcustsubmit_Click(object sender, EventArgs e)
        {
            //Getting Data From UI
            c.name = txtnewcustname.Text;
            c.address = txtnewcustaddress.Text;
            c.contact_no = txtnewcustcontactno.Text;
            c.email_id = txtnewcustemailid.Text;
            c.doctor = listboxnewcustdoctor.Text;
            c.birth_date = newcustbirthdate.Text;
            c.gender = cbnewcustgender.Text;
            c.added_date = DateTime.Now;

             //Getting the ID to Logged in user and passign its value in customer module
             string loggedUsr = frmLogin.loggedIn;
             userBLL usr = DAL.GetIDFromUsername(loggedUsr);
             c.added_by = usr.user_id;

             c.age = txtnewcustage.Text;



            //Inserting data into database

            bool success = dal.Insert(c);
            //if the data is successfully iinserted then the value of success will be true else it will be false
            if(success==true)
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
            gdvcustomerview.DataSource = dt;


        }

             //For Getting Age of Customer
        private void newcustbirthdate_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - newcustbirthdate.Value.Year; // CurrentYear - BirthDate

            txtnewcustage.Text = age.ToString();
        }

             //For Clear All Data From Textbox 
        private void clear()
        {
            
            txtnewcust_id.Text = "";
            txtnewcustname.Text = "";
            txtnewcustaddress.Text = "";
            txtnewcustcontactno.Text = "";
            txtnewcustemailid.Text = "";
            listboxnewcustdoctor.Text = "";
            newcustbirthdate.Text = "";
            txtnewcustage.Text = "";
            cbnewcustgender.Text = "";


        }

        //For Clear All Data From Textbox prescription Side
        private void clearpre()
        {

            txtnewcust_id.Text = "";
            txtnewcustname.Text = "";
            txtnewcustaddress.Text = "";
            txtnewcustcontactno.Text = "";
            txtnewcustemailid.Text = "";
            listboxnewcustdoctor.Text = "";
            newcustbirthdate.Text = "";
            txtnewcustage.Text = "";
            cbnewcustgender.Text = "";


        }

        // For datagrid view 
        private void gdvcustomerview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of Particular row
            int rowIndex = e.RowIndex;
            txtnewcust_id.Text = gdvcustomerview.Rows[rowIndex].Cells[0].Value.ToString();
            txtnewcustname.Text = gdvcustomerview.Rows[rowIndex].Cells[1].Value.ToString();
            txtnewcustaddress.Text = gdvcustomerview.Rows[rowIndex].Cells[2].Value.ToString();
            txtnewcustcontactno.Text = gdvcustomerview.Rows[rowIndex].Cells[3].Value.ToString();
            txtnewcustemailid.Text = gdvcustomerview.Rows[rowIndex].Cells[4].Value.ToString();
            listboxnewcustdoctor.Text = gdvcustomerview.Rows[rowIndex].Cells[5].Value.ToString();
            newcustbirthdate.Text = gdvcustomerview.Rows[rowIndex].Cells[6].Value.ToString();
            cbnewcustgender.Text = gdvcustomerview.Rows[rowIndex].Cells[7].Value.ToString();
            txtnewcustage.Text = gdvcustomerview.Rows[rowIndex].Cells[10].Value.ToString();

            // For Lable Prescription
            lblpreCustIDNO.Text = gdvcustomerview.Rows[rowIndex].Cells[0].Value.ToString();
            // For Lable Customer Details Show  CUstomer ID
            lblcustIDDetailsdisplay.Text = gdvcustomerview.Rows[rowIndex].Cells[0].Value.ToString();
            // For lable Customer Details show Contact Number
            lblcustomercontactnodisplay.Text = gdvcustomerview.Rows[rowIndex].Cells[3].Value.ToString();
            // For lable Customer Details Show CUstomer Name
            lblCustomerDetailsDisplay.Text = gdvcustomerview.Rows[rowIndex].Cells[1].Value.ToString();

        }
            
            // For Button Clear
        private void btnnewcustclear_Click(object sender, EventArgs e)
        {
            txtnewcust_id.Text = "";
            txtnewcustname.Text = "";
            txtnewcustaddress.Text = "";
            txtnewcustcontactno.Text = "";
            txtnewcustemailid.Text = "";
            newcustbirthdate.Text = "";
            listboxnewcustdoctor.Text = "";
            newcustbirthdate.Text = "";
            txtnewcustage.Text = "";
            cbnewcustgender.Text = "";
        }

            // For Button Update
        private void btnnewcustupdate_Click(object sender, EventArgs e)
        {
            //get the values form user UI.

            c.cust_id =Convert.ToInt32(txtnewcust_id.Text);
            c.name = txtnewcustname.Text;
            c.address = txtnewcustaddress.Text;
            c.contact_no = txtnewcustcontactno.Text;
            c.email_id = txtnewcustemailid.Text;
            c.doctor = listboxnewcustdoctor.Text;
            c.birth_date = newcustbirthdate.Text;
            c.age = txtnewcustage.Text;
            c.gender = cbnewcustgender.Text;
            c.added_date = Convert.ToDateTime(DateTime.Now);

            //Getting the ID to Logged in user and passign its value in customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = DAL.GetIDFromUsername(loggedUsr);
            c.added_by = usr.user_id;
            

            //Updating Data Into Database
            bool success = dal.Update(c);
            //If data is updated successfully then the value of sucess will be 
            if(success==true)
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
            DataTable dt = dal.select();
            gdvcustomerview.DataSource = dt;
        }

            // For Button Delete
        private void btnnewcustdel_Click(object sender, EventArgs e)
        {
            //Getting Customer ID From Form
            c.cust_id = Convert.ToInt32(txtnewcust_id.Text);

            bool success = dal.Delete(c);
            //if data is Deleted then the value of sucess will be true else it will be false
            if(success==true)
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
            gdvcustomerview.DataSource = dt;

        }

            // For Textbox when keywords will type in Textbox of ****SEARCH****
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from Text Box
            string keywords = txtcustserach.Text;
            
            //Check if the keywords has value or not
            if(keywords!=null)
            {
                // Show Customers based on Keywords
                DataTable dt = dal.Search(keywords);
                gdvcustomerview.DataSource = dt;

            }
            else
            {
                //show all customer from the database
                DataTable dt = dal.select();
                gdvcustomerview.DataSource=dt;

            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

            // For MenuStrip Userclick
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusers user = new frmusers();
            user.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Menustrip for LOGOUT...
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnewcustname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnewcustemailid_Leave(object sender, EventArgs e)
        {
            string pattern= @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" + @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +@"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            if(Regex.IsMatch(txtnewcustemailid.Text,pattern))
            {
                emailerror.Clear();
            }
            else
            {
                emailerror.SetError(this.txtnewcustemailid, "Please Enter Valid Email Id");
            }
        }


        // For only accpet numbers in contact textbox..
        private void txtnewcustcontactno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // same as testing for decimal above, we can check the text for digits
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)
                    e.Handled = true;
            }

        }

        private void txtnewcustemailid_TextChanged(object sender, EventArgs e)
        {

        }

        private void GBprescriptioin_Enter(object sender, EventArgs e)
        {

        }

        private void txtnewcust_id_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region TAB 2 FOR CUSTOMER'S PRESCRIPTION :- START'S HEAR  

        //  SUBMIT BUTTON
        private void btnpresubmit_Click_1(object sender, EventArgs e)
        {
            //Getting Data From UI
            
            pr.cust_id = int.Parse(lblpreCustIDNO.Text);
            
            pr.R_sph = CBOLrightsph.Text;
            pr.R_cyl = CBOLrightcyl.Text;
            pr.R_axis = CBOLrightaxis.Text;
            pr.R_vd = CBOLrightvd.Text;
            pr.R_Nadd = CBOLrightnearadd.Text;
            pr.R_vn = CBOLrightvn.Text;
            pr.L_sph = CBOLrightsph.Text;
            pr.L_cyl = CBOSleftcyl.Text;
            pr.L_axis = CBOSleftaxis.Text;
            pr.L_vd = CBOSleftvd.Text;
            pr.L_Nadd = CBOSleftnearadd.Text;
            pr.L_vn = CBOSleftvn.Text;
            pr.Leans_Type = CBprelenstype.Text;
            pr.Leans_Side = CBprelensSide.Text;
            pr.Leans_Price = txtpreLensPrice.Text;
            pr.Frame_Type = CBpreFrameType.Text;
            pr.Frame_Price = txtpreFrameprice.Text;
            pr.Paid_amt = txtprePaidAmount.Text;
            pr.Total_amt = txtpreTotalAmount.Text;
            pr.Pending_amt = lblpendingamount.Text;

            pr.added_date = DateTime.Now;

            //Getting the ID to Logged in user and passign its value in customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = DAL.GetIDFromUsername(loggedUsr);
            pr.added_by = usr.user_id;


            //Getting the ID to Logged in user and passign its value in customer module -------------error
            //string loggedUsr = frmLogin.loggedIn;
            // userBLL usr = dal.GetIDFromUsername(loggedUsr);

            //Inserting data into database
            bool success = pdal.Insert(pr);
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
            DataTable pdt = pdal.select();
            dgvpredata.DataSource = pdt;
        }

            //  CLEAR BUTTON
        private void btnpreclear_Click(object sender, EventArgs e)
        {
            // Right Side
            txtpreID.Text = "";
            CBOLrightsph.Text = "";
            CBOLrightcyl.Text = "";
            CBOLrightaxis.Text = "";
            CBOLrightvd.Text = "";
            CBOLrightnearadd.Text = "";
            CBOLrightvn.Text = "";
            // Left side
            CBOSleftsph.Text = "";
            CBOSleftcyl.Text= "";
            CBOSleftaxis.Text = "";
            CBOSleftvd.Text = "";
            CBOSleftnearadd.Text = "";
            CBOSleftvn.Text = "";
            //------------------------
            CBprelenstype.Text = "";
            CBprelensSide.Text = "";
            txtpreLensPrice.Text = "";
            CBpreFrameType.Text = "";
            txtpreFrameprice.Text = "";
            txtprePaidAmount.Text = "";
            txtpreTotalAmount.Text = "";
            lblpendingamount.Text = "";
        }

            //  DATA GRID VIEW IN TEXT BOX
        private void dgvpredata_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtpreID.Text = dgvpredata.Rows[rowIndex].Cells[0].Value.ToString();
            CBOLrightsph.Text = dgvpredata.Rows[rowIndex].Cells[2].Value.ToString();          
            CBOLrightcyl.Text = dgvpredata.Rows[rowIndex].Cells[3].Value.ToString();
            CBOLrightaxis.Text = dgvpredata.Rows[rowIndex].Cells[4].Value.ToString();
            CBOLrightvd.Text = dgvpredata.Rows[rowIndex].Cells[5].Value.ToString();
            CBOLrightnearadd.Text = dgvpredata.Rows[rowIndex].Cells[6].Value.ToString();
            CBOLrightvn.Text = dgvpredata.Rows[rowIndex].Cells[7].Value.ToString();
            CBOSleftsph.Text = dgvpredata.Rows[rowIndex].Cells[8].Value.ToString();
            CBOSleftcyl.Text = dgvpredata.Rows[rowIndex].Cells[9].Value.ToString();
            CBOSleftaxis.Text = dgvpredata.Rows[rowIndex].Cells[10].Value.ToString();
            CBOSleftvd.Text = dgvpredata.Rows[rowIndex].Cells[11].Value.ToString();
            CBOSleftnearadd.Text = dgvpredata.Rows[rowIndex].Cells[12].Value.ToString();
            CBOSleftvn.Text = dgvpredata.Rows[rowIndex].Cells[13].Value.ToString();
            CBprelenstype.Text = dgvpredata.Rows[rowIndex].Cells[14].Value.ToString();
            CBprelensSide.Text = dgvpredata.Rows[rowIndex].Cells[15].Value.ToString();
            txtpreLensPrice.Text = dgvpredata.Rows[rowIndex].Cells[16].Value.ToString();
            CBpreFrameType.Text = dgvpredata.Rows[rowIndex].Cells[17].Value.ToString();
            txtpreFrameprice.Text = dgvpredata.Rows[rowIndex].Cells[18].Value.ToString();
            txtprePaidAmount.Text = dgvpredata.Rows[rowIndex].Cells[19].Value.ToString();
            txtpreTotalAmount.Text = dgvpredata.Rows[rowIndex].Cells[20].Value.ToString();
            lblpendingamount.Text = dgvpredata.Rows[rowIndex].Cells[21].Value.ToString();
           // txtpreTotalAmount.Text = dgvpredata.Rows[rowIndex].Cells[20].Value.ToString();
           // txtpreTotalAmount.Text = dgvpredata.Rows[rowIndex].Cells[20].Value.ToString();


            // For Lable Prescription

            /////////  LABEL CUSTOMER DETAILS ONCLICK ON DATA OF PRESCRIPTION ///////////////

            lblRSPHDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[2].Value.ToString();

            lblRCLYDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[3].Value.ToString();

            lblRAXISDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[4].Value.ToString();

            lblLSPHDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[8].Value.ToString();

            lblLCLYDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[9].Value.ToString();

            lblLAXISDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[10].Value.ToString();

            lblLEANSTYPEDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[14].Value.ToString();

            lblLENSSIDEDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[15].Value.ToString();

            lblLENSPRICEDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[16].Value.ToString();

            lblFRAMETYPEDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[17].Value.ToString();

            lblFRAMEPRICEDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[18].Value.ToString();

            lblPAIDAMTDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[19].Value.ToString();

            lblTOTALAMTDetailsdisplay.Text = dgvpredata.Rows[rowIndex].Cells[20].Value.ToString();


        }

        private void btnpreupdate_Click(object sender, EventArgs e)
        {

            //get the values form user UI.
            pr.pre_id = Convert.ToInt32(txtpreID.Text);
            pr.R_sph = CBOLrightsph.Text;
            pr.R_cyl = CBOLrightsph.Text;
            pr.R_axis = CBOLrightaxis.Text;
            pr.R_vd = CBOLrightvd.Text;
            pr.R_Nadd = CBOLrightnearadd.Text;
            pr.R_vn = CBOLrightvn.Text;
            pr.L_sph = CBOSleftsph.Text;
            pr.L_cyl = CBOSleftcyl.Text;
            pr.L_axis = CBOSleftaxis.Text;
            pr.L_vd = CBOSleftvd.Text;
            pr.L_Nadd = CBOSleftnearadd.Text;
            pr.L_vn = CBOSleftvn.Text;
            pr.Leans_Type = CBprelenstype.Text;
            pr.Leans_Side = CBprelensSide.Text;
            pr.Leans_Price = txtpreLensPrice.Text;
            pr.Frame_Type = CBpreFrameType.Text;
            pr.Frame_Price = txtpreFrameprice.Text;
            pr.Paid_amt = txtprePaidAmount.Text;
            pr.Total_amt = txtpreTotalAmount.Text;
            pr.Pending_amt = lblpendingamount.Text;
            pr.added_date = Convert.ToDateTime(DateTime.Now);

            //Getting the ID to Logged in user and passign its value in customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = DAL.GetIDFromUsername(loggedUsr);
            pr.added_by = usr.user_id;

            //Updating Data Into Database
            bool success = pdal.Update(pr);
            //If data is updated successfully then the value of sucess will be 
            if (success == true)
            {
                //Data Updated Successfully 
                MessageBox.Show("Prescription Details Successfully Updated");
                clear();
            }
            else
            {
                // Failed To Update User
                MessageBox.Show("Failed to Update Prescription Details");
            }
            //Refreshing Data Grid View
            DataTable pdt = pdal.select();
            dgvpredata.DataSource = pdt;


        }

        private void btnpredelete_Click(object sender, EventArgs e)
        {

            //Getting Customer ID From Form
            pr.pre_id = Convert.ToInt32(txtpreID.Text);

            bool success = pdal.Delete(pr);
            //if data is Deleted then the value of sucess will be true else it will be false
            if (success == true)
            {
                //Customer Deleted Successfully
                MessageBox.Show("Prescription Details Deleted Successfully");
                clear();
            }
            else
            {
                //Failed to Delete Customer
                MessageBox.Show("Failed to Delete Prescription Details");
            }

            //refreshing Datagrid View
            DataTable pdt =pdal.select();
            dgvpredata.DataSource = pdt;

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.Show();
        }

        private void txtpreLensPrice_TextChanged(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(txtpreLensPrice.Text) && !string.IsNullOrEmpty(txtpreFrameprice.Text))
               txtpreTotalAmount.Text = (Convert.ToInt32(txtpreLensPrice.Text) + Convert.ToInt32(txtpreFrameprice.Text)).ToString();
        }

        private void txtpreFrameprice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpreLensPrice.Text) && !string.IsNullOrEmpty(txtpreFrameprice.Text))
                txtpreTotalAmount.Text = (Convert.ToInt32(txtpreLensPrice.Text) + Convert.ToInt32(txtpreFrameprice.Text)).ToString();
        }

        private void txtprePaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtprePaidAmount.Text) && !string.IsNullOrEmpty(txtpreTotalAmount.Text))
                lblpendingamount.Text = (Convert.ToInt32(txtprePaidAmount.Text) - Convert.ToInt32(txtpreTotalAmount.Text)).ToString();
        }

        //#################### FOR ONLY ACCEPT THE NUMBER IN TEXTBOX in presc section
        private void txtpreLensPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpreFrameprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpreTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtprePaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblcustIDDetailsdisplay_Click(object sender, EventArgs e)
        {

        }

        
    }
}
