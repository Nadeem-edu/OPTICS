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
    class usersDAL
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
                String sql = "select * from tbl_user";
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

        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_user (first_name, last_name, username, password, email_id, address, contact_no, gender, added_by) VALUES(@first_name, @last_name, @username, @password, @email_id, @address, @contact_no, @gender, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user_id", u.user_id);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@email_id", u.email_id);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@contact_no", u.contact_no);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);



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
        #region Update Data Form Database

        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_user SET first_name=@first_name, last_name=@last_name, username=@username, password=@password, email_id=@email_id, address=@address, contact_no=@contact_no, gender=@gender WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@email_id", u.email_id);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@contact_no", u.contact_no);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                cmd.Parameters.AddWithValue("@user_id", u.user_id);

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
        #region Delete Data Form Database

        public bool Delete(userBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_user WHERE user_id=@user_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user_id", c.user_id);
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
        #region Search Data Form Database

        public DataTable Search(string keywords)
        {

            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //To hold the data form database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to Get Data form Database
                String sql = "select * from tbl_user WHERE user_id LIKE '%"+keywords+"%' OR first_name LIKE '%"+keywords+"%' OR contact_no LIKE '%"+keywords+"%'";
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

        
       #region Getting User ID from Username

        public userBLL GetIDFromUsername(string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT user_id FROM tbl_user WHERE username='" + username + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    u.user_id = int.Parse(dt.Rows[0]["user_id"].ToString());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;
        }

        #endregion 
    }
}
