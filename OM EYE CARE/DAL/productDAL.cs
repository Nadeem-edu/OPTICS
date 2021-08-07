using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OM_EYE_CARE.BLL;

namespace OM_EYE_CARE.DAL
{
    class productDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database

        public DataTable select()
        {

            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //To hold the data form database
            DataTable prod_dt = new DataTable();
            try
            {
                //SQL Query to Get Data form Database
                String sql = "select * from tbl_product";
                //For Excecuting Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting Data form Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill data in dataTable
                adapter.Fill(prod_dt);
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
            return prod_dt;

        }

        #endregion

        #region Insert Data In Database

        public bool Insert(productBLL prod)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_product (p_name, qty, added_date, added_by)  VALUES(@p_name, @qty, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@p_id", prod.p_id);
                cmd.Parameters.AddWithValue("@p_name", prod.p_name);
                cmd.Parameters.AddWithValue("@qty", prod.qty);         
                cmd.Parameters.AddWithValue("@added_date", prod.added_date);
                cmd.Parameters.AddWithValue("@added_by", prod.added_by);
                

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

        #region Update data is Database

        public bool Update(productBLL prod)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_product SET p_name=@p_name, qty=@qty, added_date=@added_date, added_by=@added_by WHERE p_id=@p_id";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@p_name", prod.p_name);
                cmd.Parameters.AddWithValue("@qty", prod.qty);
                cmd.Parameters.AddWithValue("@added_date", prod.added_date);
                cmd.Parameters.AddWithValue("@added_by", prod.added_by);
                cmd.Parameters.AddWithValue("@p_id", prod.p_id);

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

        public bool Delete(productBLL prod)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_product WHERE p_id=@p_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@p_id", prod.p_id);
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
            DataTable prod_dt = new DataTable();
            try
            {
                //SQL Query to Get Data form Database
                String sql = "select * from tbl_product WHERE p_id LIKE '%" + keywords + "%' OR p_name LIKE'%" + keywords + "%' OR added_by LIKE '%" + keywords + "%'";
                //For Excecuting Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting Data form Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill data in dataTable
                adapter.Fill(prod_dt);
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
            return prod_dt;

        }
        #endregion


    }
}
