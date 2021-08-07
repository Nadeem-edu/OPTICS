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
    class presDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        #region Select Data From Database

        public DataTable select()
        {

            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //To hold the data form database
            DataTable pdt = new DataTable();
            try
            {
                //SQL Query to Get Data form Database
                String sql = "select * from tbl_pres";
                //For Excecuting Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting Data form Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill data in dataTable
                adapter.Fill(pdt);
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
            return pdt;

        }

        #endregion

        #region Insert Data In Database
        public bool Insert(presBLL pr)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_pres (cust_id ,R_sph, R_cyl, R_axis, R_vd, R_Nadd, R_vn, L_sph, L_cyl, L_axis, L_vd, L_Nadd, L_vn, Leans_Type, Leans_side, Leans_Price, Frame_Type, Frame_Price, Paid_amt, Total_amt, Pending_amt, added_date, added_by) VALUES(@cust_id, @R_sph, @R_cyl, @R_axis, @R_vd, @R_Nadd, @R_vn, @L_sph, @L_cyl, @L_axis, @L_vd, @L_Nadd, @L_vn, @Leans_Type, @Leans_Side, @Leans_price, @Frame_Type, @Frame_Price, @Paid_amt, @Total_amt, @Pending_amt, @added_date, @ added_by)";

                // --------- Sql command to pass the value to query and sql
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("cust_id", pr.cust_id);
                
                cmd.Parameters.AddWithValue("@pre_id", pr.pre_id);
                // --------- FOR Right side of Eye -----------
                cmd.Parameters.AddWithValue("@R_sph", pr.R_sph);
                cmd.Parameters.AddWithValue("@R_cyl", pr.R_cyl);
                cmd.Parameters.AddWithValue("@R_axis", pr.R_axis);
                cmd.Parameters.AddWithValue("@R_vd", pr.R_vd);
                cmd.Parameters.AddWithValue("@R_Nadd", pr.R_Nadd);
                cmd.Parameters.AddWithValue("@R_vn", pr.R_vn);
                // ---------- FOR LEFT SIDE OF EYE ------------
                cmd.Parameters.AddWithValue("@L_sph", pr.L_sph);
                cmd.Parameters.AddWithValue("@L_cyl", pr.L_cyl);
                cmd.Parameters.AddWithValue("@L_axis", pr.L_axis);
                cmd.Parameters.AddWithValue("@L_vd", pr.L_vd);
                cmd.Parameters.AddWithValue("@L_Nadd", pr.L_Nadd);
                cmd.Parameters.AddWithValue("@L_vn", pr.L_vn);
                //----------------------------------------------------------
                cmd.Parameters.AddWithValue("@Leans_Type", pr.Leans_Type);
                cmd.Parameters.AddWithValue("@Leans_Side", pr.Leans_Side);
                cmd.Parameters.AddWithValue("@Leans_Price", pr.Leans_Price);
                cmd.Parameters.AddWithValue("@Frame_Type", pr.Frame_Type);
                cmd.Parameters.AddWithValue("@Frame_Price", pr.Frame_Price);
                cmd.Parameters.AddWithValue("@Paid_amt", pr.Paid_amt);
                cmd.Parameters.AddWithValue("@Total_amt", pr.Total_amt);
                cmd.Parameters.AddWithValue("@Pending_amt", pr.Pending_amt);
                cmd.Parameters.AddWithValue("@added_date", pr.added_date);
                cmd.Parameters.AddWithValue("@added_by", pr.added_by);



                // For Connection
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

        #region Update Data In Database

        public bool Update(presBLL pr)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_pres SET R_sph=@R_sph, R_cyl=@R_cyl, R_axis=@R_axis, R_vd=@R_vd, R_Nadd=@R_Nadd, R_vn=@R_vn, L_sph=@L_sph, L_cyl=@L_cyl, L_axis=@L_axis, L_vd=@L_vd, L_Nadd=@L_Nadd, L_vn=@L_vn, Leans_Type=@Leans_Type, Leans_Side=@Leans_Side, Leans_Price=@Leans_price, Frame_Type=@Frame_Type, Frame_Price=@Frame_Price, Paid_amt=@Paid_amt, Total_amt=@Total_amt, Pending_amt=@Pending_amt, added_date=@added_date, added_by=@added_by WHERE pre_id=@pre_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                
                // ------------For Right Side---------------------
                cmd.Parameters.AddWithValue("@R_sph", pr.R_sph);
                cmd.Parameters.AddWithValue("@R_cyl", pr.R_cyl);
                cmd.Parameters.AddWithValue("@R_axis", pr.R_axis);
                cmd.Parameters.AddWithValue("@R_vd", pr.R_vd);
                cmd.Parameters.AddWithValue("@R_Nadd", pr.R_Nadd);
                cmd.Parameters.AddWithValue("@R_vn", pr.R_vn);
                // ------------For Left Side---------------------
                cmd.Parameters.AddWithValue("@L_sph", pr.L_sph);
                cmd.Parameters.AddWithValue("@L_cyl", pr.L_cyl);
                cmd.Parameters.AddWithValue("@L_axis", pr.L_axis);
                cmd.Parameters.AddWithValue("@L_vd", pr.L_vd);
                cmd.Parameters.AddWithValue("@L_Nadd", pr.L_Nadd);
                cmd.Parameters.AddWithValue("@L_vn", pr.L_vn);
                //-------------             ----------------------
                cmd.Parameters.AddWithValue("@Leans_Type", pr.Leans_Type);
                cmd.Parameters.AddWithValue("@Leans_Side", pr.Leans_Side);
                cmd.Parameters.AddWithValue("@Leans_Price", pr.Leans_Price);
                cmd.Parameters.AddWithValue("@Frame_Type", pr.Frame_Type);
                cmd.Parameters.AddWithValue("@Frame_Price", pr.Frame_Price);
                cmd.Parameters.AddWithValue("@Paid_amt", pr.Paid_amt);
                cmd.Parameters.AddWithValue("@Total_amt", pr.Total_amt);
                cmd.Parameters.AddWithValue("@Pending_amt", pr.Pending_amt);
                cmd.Parameters.AddWithValue("@added_date", pr.added_date);
                cmd.Parameters.AddWithValue("@added_by", pr.added_by);

                cmd.Parameters.AddWithValue("@pre_id", pr.pre_id);
            

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

        public bool Delete(presBLL pr)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_pres WHERE pre_id=@pre_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@pre_id", pr.pre_id);
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

    }
}
