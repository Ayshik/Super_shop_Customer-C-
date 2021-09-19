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
    public partial class DashBoard : Form
    {
        public DashBoard(string uid)
        {
            InitializeComponent();
            button10.Visible = false;
            label5.Text = uid;
        }
        Productq da = new Productq();
        Cart c = new Cart();
        Cartq cq = new Cartq();
        Orderitem o = new Orderitem();
        Orderq oq = new Orderq();
        DataTable dt = new DataTable();
        Product u = new Product();
        private void homePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void productPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            dt = da.productdtailsall(u);
            dataGridView1.DataSource = dt;
//fetch korar jonno billno
            

            dt = cq.Billingno(c);




            if (dt.Rows.Count == 1)
            {

                string currentno = dt.Rows[0][0].ToString();

                var newno = (Convert.ToInt16(currentno) + Convert.ToInt16(1)).ToString();

                label7.Text = newno;


            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            dt = da.productdtailsall(u);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;
            label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            label4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Input Name Or Catagory"); }
            else
            {
                u.catagory = textBox1.Text;
                u.name = textBox1.Text;
                dt = da.productsearch(u);
                dataGridView1.DataSource = dt;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" || label2.Text == "")
            {
                MessageBox.Show("Please Select a Product");
            }
            else
            {
                c.sl =Int16.Parse(label1.Text);


                c.name = label2.Text;
                c.catagory = label3.Text;
                c.price = label4.Text;
                c.userid= Int16.Parse(label5.Text);
                c.billno = label7.Text;
                



                int i = cq.insertintocart(c);
                if (i > 0)
                {
                   

                        c.billno = label7.Text;
                       
                    
                        int w = cq.billupdate(c);


                    MessageBox.Show(label2.Text + "Added to Cart");
                    button10.Visible = true;

                }
                   
                
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Order o = new Order(label5.Text,label7.Text);
            o.Visible = true;
            this.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            o.userid = Int16.Parse(label5.Text);
            dt = oq.orderhistory(o);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updateprofile uf = new Updateprofile(label5.Text);
            this.Visible = false ;
            uf.Visible = true;
        }
    }
}
