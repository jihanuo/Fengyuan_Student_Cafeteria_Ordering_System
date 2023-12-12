using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    class data_work
    {
        static string connstr = "Data Source=.\\SQLEXPRESS;;User ID=sa;Password=1234;database=test";
        public static DataTable DataQuery(string str)//数据查询，输入参数为查询语句，返回数据表
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int DataExcute(string str)//数据操作，输入参数为语句，返回影响行数
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

    }

}
