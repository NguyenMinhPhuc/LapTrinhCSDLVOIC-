﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111
{
    public class Database
    {
        private string connectionString = string.Empty;

        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public Database()
        {
            connectionString = "server=DESKTOP-AQH0V70;database=DatabaseBanHang_17SE111;uid=sa;pwd=123";
            cnn = new SqlConnection(connectionString);
        }

        public DataTable GetDataTable(ref string err, string sql, CommandType ct,params SqlParameter[] parameters)
        {
            DataTable table = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if(parameters !=null)
                {
                    foreach (SqlParameter item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                table = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(table);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return table;
        }

        public bool MyExcuteNonQuery(ref string err,ref int count, string sql, CommandType ct, params SqlParameter[] parameters)
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (parameters != null)
                {
                    foreach (SqlParameter item in parameters)
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
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
    }
}
