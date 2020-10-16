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
    class Register
    {
        SqlConnection con;
        public Register()
        {
            con = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=requestit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public int CreateAccount(Profilecont u)
        {
            int i = 0;
            string query = "INSERT INTO login(Name,Password,Aiubid,DOB,Gender,Email) VALUES ('"+ u.Name +"','"+ u.Password +"', '"+ u.Aiubid +"', '"+ u.Dob +"','"+ u.Gender +"','"+ u.Email +"')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public DataTable Profileuid(Profilecont u)
        {
            string query = string.Format("Select UserId from login where AiubId='" + u.Aiubid + "'and Email='" + u.Email + "' and Password='" + u.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }







    }
}
