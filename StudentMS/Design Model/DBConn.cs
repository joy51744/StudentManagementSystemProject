using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentMS.Design_Model
{
    public class DBConn
    {
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";

        public int DBExecuteNonQuery(string sqlcmd, out string strError)
        {
            int x = 0;//默认受影响行数是0行
            strError = "";//默认什么错误都没发生
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlcmd, con);
                    x = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                }
            }
            return x;
        }

        public int DBExecuteNonQuery(string sqlcmd, SqlParameter[] sps, out string strError)
        {
            int x = 0;//默认受影响行数是0行
            strError = "";//默认什么错误都没发生
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlcmd, con);
                    cmd.Parameters.AddRange(sps);
                    x = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                }
            }
            return x;
        }

        public DataTable DBExcuteDataTable(string sqlcmd, out string strError)
        {
            strError = "";
            DataTable dt = null;
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, connString);
                dt = new DataTable();
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                strError = ex.Message;
            }
            return dt;
        }

        public DataTable DBExcuteDataTable(string sqlcmd, SqlParameter[] sps, out string strError)
        {
            strError = "";
            DataTable dt = null;
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, connString);
                sda.SelectCommand.Parameters.AddRange(sps);
                dt = new DataTable();
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                strError = ex.Message;
            }
            return dt;
        }

        public object DBExecuteSalar(string sqlcmd, out string strError)
        {
            strError = "";
            object o = null;
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlcmd, con);
                    o = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                }
            }
            return o;
        }

        public object DBExecuteSalar(string sqlcmd, SqlParameter[] sps, out string strError)
        {
            strError = "";
            object o = null;
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlcmd, con);
                    cmd.Parameters.AddRange(sps);
                    o = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                }
            }
            return o;
        }
    }
}