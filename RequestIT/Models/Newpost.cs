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
    class Newpost
    {
       SqlConnection con;
        public Newpost()
        {
            con = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=requestit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public int Newpostentry(Newpostcont u)
        {
            int i = 0;
            string query = "INSERT INTO newpost(AccountId,Status,DateTime,Title,Catagory,[Check]) VALUES ('"+u.AccountId+"','"+u.Status+"','"+DateTime.Now.ToShortDateString()+"','"+u.Title+"','"+u.Catagory+"','"+u.Check+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }





    }
}
