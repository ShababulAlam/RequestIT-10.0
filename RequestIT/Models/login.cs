using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestIT.Models;
using RequestIT.Controllers;


namespace RequestIT.Models
{
    public class Login
    {
         SqlConnection con;
        public Login()
        {
            con = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=requestit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }



        public DataTable Loginuser(logincont p)
        {
            
            string query = string.Format("Select * from Login where UserId= '" + p.UserId + "' and Password='" + p.Password + "'");
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
           con.Close();
            return dt;
           
        }


        public DataTable Loginadmin(logincont p)
        {
            string query = string.Format("Select * from Admin where UserId= '" + p.UserId + "' and Password='" + p.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }

    }
}
