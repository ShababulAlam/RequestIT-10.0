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
    class Comment
    {
         SqlConnection con;
        public Comment()
        {
            con = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=requestit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public DataTable commentdetails(commentcont u)
        {
            string query = string.Format("Select * from comment where AccountId='"+u.AccountId+"'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public int Replycomment(commentcont u)
        {
            int i = 0;
            string query = "INSERT INTO comment(StatusId,AccountId,Status,DateTime,Title,Catagory,FromId,Comment) VALUES ('"+u.StatusId+"','"+u.AccountId+"','"+u.Status+"','"+DateTime.Now+"','------','-------','"+u.FormId+"','"+u.comment+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }
    }
}
