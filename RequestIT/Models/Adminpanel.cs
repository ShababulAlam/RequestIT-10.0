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
   public class Adminpanel
    {
         SqlConnection con;
        
        public Adminpanel()
        {
            con = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=requestit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public DataTable Alldetails(Admincont u)
        {
            string query = string.Format("Select * from newpost ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public int Deletestatus(Admincont u)
        {
            int i = 0;
            string query = String.Format("delete from newpost where StatusId='"+u.StatusId+"'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

       

        public int Approve(Newsfeedcont u)
        {
            int i = 0;
            string query = "INSERT INTO newsfeed(StatusId,AccountId,Status,DateTime,Title,Catagory,FormId,Comment) VALUES ('"+ u.StatusId +"','"+ u.AccountId +"','"+ u.Status +"', '"+DateTime.Now+"', '"+u.Title+"','"+ u.Catagory +"','"+u.FormId +"','"+ u.Comment +"')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;


        }

        public DataTable Search(Newsfeedcont u)
        {
            string query = string.Format("Select * from newsfeed where [DateTime]='{0}'", u.DateTime);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }
    }
}
