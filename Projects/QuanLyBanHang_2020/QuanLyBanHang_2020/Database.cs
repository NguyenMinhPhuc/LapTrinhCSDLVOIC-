using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_2020
{
    public class Database
    {
        string connectionString = "Server=DESKTOP-AQH0V70;database=BanHang2020;uid=sa;pwd=123";
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Database()
        {
            cnn = new SqlConnection(connectionString);
        }
        public bool KiemTraKetNoi(ref string err)
        {
            try
            {
                cnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }

        public DataTable GetDataTable(ref string err, string Sql,CommandType ct,params SqlParameter[] param)
        {
            DataTable dt=null;
            try
            {
                if(cnn.State==ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                cmd = new SqlCommand(Sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if(param!=null)
                {

                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
               // return dt;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }
        public bool MyExcuteNonQuery(ref string err,ref int count, string Sql, CommandType ct, params SqlParameter[] param)
        {
           
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                cmd = new SqlCommand(Sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (param != null)
                {

                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                count = cmd.ExecuteNonQuery();
                 return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }

        public object MyExecuteScalar(ref string err,  string Sql, CommandType ct, params SqlParameter[] param)
        {

            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                cmd = new SqlCommand(Sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (param != null)
                {

                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
              return  cmd.ExecuteScalar();
                 
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
