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
    class loginDAL
    {
        // Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool LoginCheck(loginBLL l)
        {
            //create a boolean variable and set its value to false and return it
            bool isSuccess = false;


            //Connecting To Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL Query To check Login.
                string sql = "SELECT * FROM tbl_user WHERE username=@username AND password=@password";

                //createing SQL Command to pass value
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // Checking The rows in DataTable
                if(dt.Rows.Count>0)
                {
                    //Login Successful
                    isSuccess = true;
                }
                else
                {
                    //Login Failed
                    isSuccess = false;
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
            return isSuccess;
        }

    }

}
