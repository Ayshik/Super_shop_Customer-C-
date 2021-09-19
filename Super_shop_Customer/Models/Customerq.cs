using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_shop_Customer.Models
{
    public class Customerq
    {
        SqlConnection conn;
        public Customerq()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-K8O6SE7\MSSQLSERVER02;Initial Catalog=Supershop;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public DataTable Loginowner(Customer l)
        {

            string query = string.Format("Select * from customer where userid= '" + l.uid + "' and password='" + l.password + "'");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            conn.Close();
            return dt;

        }

        public int Creataccount(Customer u)
        {
            int i = 0;
            string query = "INSERT INTO customer(password,name,phone,email,gender,address,squestion) VALUES ('" + u.password + "','" + u.name + "','" + u.phone + "','" + u.email+ "','" + u.gender + "','" + u.address + "','" + u.squestion + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }



        public DataTable userid(Customer l)
        {

            string query = string.Format("Select * from customer where phone= '" + l.phone + "' and password='" + l.password + "'");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            conn.Close();
            return dt;

        }


        public int updateprofile(Customer u)
        {
            int i = 0;
            string query = String.Format("UPDATE customer SET name='" + u.name + "',password='" + u.password + "',phone='" + u.phone + "',address='" + u.address + "',email='" + u.email + "',squestion='" + u.squestion + "' WHERE userid='" + u.uid + "'");
            SqlCommand cmd = new SqlCommand(query, conn);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public DataTable fetchprofile(Customer l)
        {

            string query = string.Format("Select * from customer where userid= '" + l.uid + "'");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //conn.Close();
            return dt;

        }

    }
}
