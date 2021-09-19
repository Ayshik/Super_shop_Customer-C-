using Super_shop_Customer.Controllers;
using Super_shop_Customer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_shop_Customer.Views
{
    public partial class Order : Form
    {
        public Order(string uid, string bid)
        {
            InitializeComponent();
            label5.Text = uid;
            label7.Text = bid;
            textBox1.Visible = false;
            button8.Visible = false;


        }
        Orderq oq = new Orderq();
        Orderitem o = new Orderitem();

        DataTable dt = new DataTable();
        private void button10_Click(object sender, EventArgs e)
        {
            o.userid = Int16.Parse(label5.Text);


          

            o.total = label9.Text;
            o.billno = label7.Text;





            int i = oq.Finalorder(o);
            if (i > 0)
            {


              


                MessageBox.Show("Oder Complete");
                

            }
        }
            private void label3_Click(object sender, EventArgs e)
            {
                textBox1.Visible = true;
                button8.Visible = true;
            }

            private void Order_Load(object sender, EventArgs e)
            {
                o.billno = label7.Text;
                o.userid = Int16.Parse(label5.Text);
                dt = oq.cartproduct(o);
                dataGridView1.DataSource = dt;





                dt = oq.Ordertotal(o);
                if (dt.Rows.Count == 1)
                {

                    string total = dt.Rows[0][0].ToString();



                    label9.Text = total;


                }
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }
    }
