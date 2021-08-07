using OM_EYE_CARE.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace OM_EYE_CARE.DAL
{
    


    class customerDAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable select()
        {

            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //To hold the data form database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to Get Data form Database
                String sql = "select * from tbl_newcust";
                //For Excecuting Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting Data form Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill data in dataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if there any error
                MessageBox.Show(ex.Message);
            }

            finally
            {
                //Closing Connection
                conn.Close();
            }
            //Return the value in DataTable
            return dt;

        }

        #endregion

        #region Insert Data In Database

        public bool Insert(customerBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_newcust (name, address, contact_no, email_id, doctor, birth_date, gender, added_date, added_by, age) VALUES(@name, @address, @contact_no, @email_id, @doctor, @birth_date, @gender, @added_date, @added_by, @age)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cust_id", c.cust_id);
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@contact_no", c.contact_no);
                cmd.Parameters.AddWithValue("@email_id", c.email_id);
                cmd.Parameters.AddWithValue("@doctor", c.doctor);
                cmd.Parameters.AddWithValue("@birth_date", c.birth_date);
                cmd.Parameters.AddWithValue("@gender", c.gender);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@age", c.age);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query is executed sucessfully then the value of rows will be greate than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Sucessfull
                    isSuccess = true;
                }
                else
                {
                    //Query Failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

      



        #endregion

        #region Update data in Database

        public bool Update(customerBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_newcust SET name=@name, address=@address, contact_no=@contact_no, email_id=@email_id, doctor=@doctor, birth_date=@birth_date, gender=@gender, added_date=@added_date, added_by=@added_by, age=@age WHERE cust_id=@cust_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                 

                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@contact_no", c.contact_no);
                cmd.Parameters.AddWithValue("@email_id", c.email_id);
                cmd.Parameters.AddWithValue("@doctor", c.doctor);
                //cmd.Parameters.AddWithValue("@birth_date",  SqlDbType.DateTime).Value = DateTime.ParseExact(c.birth_date, "yyyy-MM-dd", null); //<- as example

                cmd.Parameters.AddWithValue("@birth_date", c.birth_date);

                //cmd.Parameters.AddWithValue("@birth_date", DateTime.Now.ToString("dd/MM/yyyy"));

                cmd.Parameters.AddWithValue("@gender", c.gender);
                cmd.Parameters.AddWithValue("@added_date",c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@age", c.age);
                cmd.Parameters.AddWithValue("@cust_id", c.cust_id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Successfull
                    isSuccess = true;

                }
                else
                {
                    //Query Failed
                    isSuccess = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }

            return isSuccess;

        }



        #endregion

        #region Delete Data From Database

        public bool Delete(customerBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_newcust WHERE cust_id=@cust_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cust_id", c.cust_id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Successfull
                    isSuccess = true;

                }
                else
                {
                    //Query Failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return isSuccess;
        }
        #endregion

        #region Serach Customer Form Database

        public DataTable Search(string keywords)
        {

            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //To hold the data form database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to Get Data form Database
                String sql = "select * from tbl_newcust WHERE cust_id LIKE '%" + keywords + "%' OR name LIKE'%" + keywords + "%' OR contact_no LIKE '%" + keywords + "%'";
                //For Excecuting Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting Data form Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill data in dataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if there any error
                MessageBox.Show(ex.Message);
            }

            finally
            {
                //Closing Connection
                conn.Close();
            }
            //Return the value in DataTable
            return dt;

        }
        #endregion

        #region select customer form table and display on the prescrition table


      



        #endregion

    }
}
