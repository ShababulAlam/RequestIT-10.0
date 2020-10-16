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
    class Newsfeed
    {
         SqlConnection con;

        public bool Visible { get; internal set; }

        public Newsfeed()
        {
            con = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=requestit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public DataTable Newsfeeddetails(Newsfeedcont u)
        {
            string query = string.Format("Select * from newsfeed");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable Newsfeedsearch(Newsfeedcont u)
        {
            string query = string.Format("Select * from newsfeed where [Title]='{0}' or [Catagory]='{1}'", u.Title,u.Catagory);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        //public int CreateTable(Newsfeedcont u)
        //{
        //    int i = 0;
        //    string query = "CREATE TABLE [dbo].["+u.StatusId+"]([AccountId] [varchar](50) NOT NULL,[Status] [varchar](max) NOT NULL,[DateTime] [varchar](50) NOT NULL,[Title] [varchar](50) NOT NULL,[Catagory] [nchar](10) NOT NULL,[FromId] [varchar](50) NOT NULL,[Comment] [varchar](50) NOT NULL)";
        //    SqlCommand cmd = new SqlCommand(query, con);



        //    i = cmd.ExecuteNonQuery();
        //    // con.Close();
        //    return i;

        //}

        public int Comment(Newsfeedcont u)
        {
            int i = 0;
            string query = "INSERT INTO comment(StatusId,AccountId,Status,DateTime,Title,Catagory,FromId,Comment) VALUES ('"+ u.StatusId +"','"+u.AccountId+"',' " + u.Status + " ', ' " + DateTime.Now + " ', ' " + u.Title + " ',' " + u.Catagory + " ',' " + u.FormId + " ',' " + u.Comment + " ')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }

    }
}
