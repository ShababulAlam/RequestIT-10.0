using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestIT.Controllers;

namespace RequestIT.Models
{
    class Profile
    {
         SqlConnection con;
        public Profile()
        {
            con = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=requestit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public DataTable Profiledetails(Profilecont u)
        {
            string query = string.Format("Select * from login where UserId='"+u.UserId+"' ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public int UpdateUser(Profilecont u)
        {
            int i = 0;
            string query = String.Format("UPDATE login SET Name='" + u.Name + "',Password='" + u.Password + "',Email='" + u.Email + "',Gender='" + u.Gender + "',AiubId='" + u.Aiubid + "',DOB='" + u.Dob + "' WHERE UserId='" + u.UserId + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}
