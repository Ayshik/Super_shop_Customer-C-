using Super_shop_Customer.Controllers;
using Super_shop_Customer.Models;
using Super_shop_Customer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_shop_Customer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Customer c = new Customer();
        Customerq cq = new Customerq();
        DataTable dt = new DataTable();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtID.Text==""||txtpass.Text=="")
            {

                MessageBox.Show("Fill up all info");


            }
            else {
                c.uid= Int16.Parse(txtID.Text);
                c.password = txtpass.Text;
                dt = cq.Loginowner(c);

                if (dt.Rows.Count == 1)
                {
                   
                    DashBoard c = new DashBoard(txtID.Text);
                      this.Visible = false;
                      c.Visible = true;

                }
                else
                {
                    MessageBox.Show("User not valid");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerSignup cs = new CustomerSignup();
           // this.Visible = false;
            cs.Visible = true;
        }
    }
}

