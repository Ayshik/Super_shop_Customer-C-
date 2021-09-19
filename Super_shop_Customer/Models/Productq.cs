using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_shop_Customer.Models
{
   public class Productq
    {
        SqlConnection conn;
        public Productq()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-K8O6SE7\MSSQLSERVER02;Initial Catalog=Supershop;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public DataTable productdtailsall(Product u)
        {
            string query = string.Format("Select * from products");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable productsearch(Product u)
        {
            string query = string.Format("select * from products where name = '"+ u.name +"' OR catagory ='"+ u.catagory+"';");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }






    }
}
