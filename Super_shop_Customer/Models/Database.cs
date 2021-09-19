using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Super_shop_Customer.Models
{
    class Database
    {
        public Customerq Users { get; set; }
        public Database()
        {
            SqlConnection conn;
            conn = new SqlConnection(@"Data Source=DESKTOP-K8O6SE7\MSSQLSERVER02;Initial Catalog=Supershop;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            // SqlConnection conn = new SqlConnection(connString);
            // Users = new Customerq(conn);
            // Products = new Products();
            // Categories = new Categories();

        }
    }
}
