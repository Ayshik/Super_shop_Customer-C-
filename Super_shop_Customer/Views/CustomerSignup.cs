using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Super_shop_Customer.Controllers;
using Super_shop_Customer.Models;

namespace Super_shop_Customer.Views
{
    public partial class CustomerSignup : Form
    {
        public CustomerSignup()
        {
            InitializeComponent();
        }
        Customerq cq = new Customerq();
        Customer c = new Customer();

        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" || label2.Text == ""|| fullNameTextBox.Text == "" || addressBox.Text == ""|| phoneNumberTextBox.Text == "" || bloodComboBox.Text == ""|| emailTextbox.Text == "")
            {
                MessageBox.Show("Fill All information");
            }
            else
            {
                c.name =fullNameTextBox.Text;


                c.phone = phoneNumberTextBox.Text;
                c.address = addressBox.Text;
                c.gender = bloodComboBox.Text;
                c.password = textBox2.Text;
                c.squestion = textBox1.Text;
                c.email = emailTextbox.Text;




                int i = cq.Creataccount(c);
                if (i > 0)
                {

                    dt = cq.userid(c);




                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Account Created");

                        string currentno = dt.Rows[0][0].ToString();

                       

                        textBox3.Text = currentno;


                    }


                   
                   

                }


                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerSignup_Load(object sender, EventArgs e)
        {
            textBox3.Text = "What is your Pet Name?";
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void lblphn_Click(object sender, EventArgs e)
        {

        }

        private void lblmail_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButon_Click(object sender, EventArgs e)
        {

        }

        private void bloodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpboxreg_Enter(object sender, EventArgs e)
        {

        }

        private void lblfullname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
