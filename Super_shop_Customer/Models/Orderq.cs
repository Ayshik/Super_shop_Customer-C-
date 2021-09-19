using Super_shop_Customer.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_shop_Customer.Models
{
   public class Orderq
    {
        SqlConnection conn;
        public Orderq()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-K8O6SE7\MSSQLSERVER02;Initial Catalog=Supershop;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }



        public DataTable cartproduct(Orderitem u)
        {
            string query = string.Format("select * from Cart where Userid = '" + u.userid + "' AND Billingno ='" + u.billno + "';");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }




        public DataTable Ordertotal(Orderitem u)
        {
            string query = string.Format("select SUM(ItemPrice) from Cart where Billingno ='" + u.billno + "' And Status ='Active'");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }



        public int Finalorder(Orderitem u)
        {
            int i = 0;
            string query = "INSERT INTO Allorders(Userid,TotalPrice,Billingno,Datetime,Status) VALUES ('" + u.userid + "','" + u.total + "','" + u.billno + "','" + DateTime.Now + "','Active')";
            SqlCommand cmd = new SqlCommand(query, conn);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }

        public DataTable orderhistory(Orderitem u)
        {
            string query = string.Format("select * from Allorders where Userid = '" + u.userid + "';");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }
    }
}
