using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projectsales
{
    internal class Connection
    {
        public SqlConnection Conn = new SqlConnection("Data Source=BEETHOR\\SQLEXPRESS;Initial Catalog=Sales;Integrated Security=True");
        //public SqlDataAdapter Adapter;
        //public DataSet ds;
        public void Query(string sql)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.Open();
            try
            {
                SqlDataAdapter Adapter = new SqlDataAdapter(sql, Conn);
                DataSet ds = new DataSet();
                Adapter.Fill(ds, "Admin");
                Conn.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
