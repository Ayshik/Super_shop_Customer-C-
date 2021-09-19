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
   public class Cartq
    {
        SqlConnection conn;
        public Cartq()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-K8O6SE7\MSSQLSERVER02;Initial Catalog=Supershop;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }





        public int insertintocart(Cart u)
        {
            int i = 0;
            string query = "INSERT INTO Cart(Userid,Sl,ItemName,ItemPrice,Catagory,Billingno,Datetime,Status) VALUES ('" + u.userid + "','" + u.sl + "','" + u.name + "','" + u.price + "','" + u.catagory + "','" + u.billno + "','" + DateTime.Now + "','Active')";
            SqlCommand cmd = new SqlCommand(query, conn);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }


        public DataTable Billingno(Cart u)
        {
            string query = string.Format("select * from Billingsl where Status ='Active'");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public int billupdate(Cart u)
        {
            int i = 0;
            string query = String.Format("UPDATE Billingsl SET Billingno='"+u.billno+"' WHERE Status='Active'");
            SqlCommand cmd = new SqlCommand(query, conn);
            i = cmd.ExecuteNonQuery();
            return i;
        }



    }

    
}
