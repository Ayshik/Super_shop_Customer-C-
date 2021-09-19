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
    public partial class Updateprofile : Form
    {
        public Updateprofile(string uid)
        {
            InitializeComponent();
            textBox3.Text = uid;
        }
        Customerq cq = new Customerq();
        Customer c = new Customer();
        DataTable dt = new DataTable();
        private void Updateprofile_Load(object sender, EventArgs e)
        {
            c.uid = Int16.Parse(textBox3.Text);
            dt = cq.fetchprofile(c);




            if (dt.Rows.Count == 1)
            {


               fullNameTextBox.Text= dt.Rows[0][2].ToString();


                phoneNumberTextBox.Text= dt.Rows[0][3].ToString();
                addressBox.Text= dt.Rows[0][6].ToString();
                bloodComboBox.Text= dt.Rows[0][5].ToString();
                textBox2.Text= dt.Rows[0][1].ToString();
                textBox1.Text= dt.Rows[0][7].ToString();
                emailTextbox.Text= dt.Rows[0][4].ToString();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" || label2.Text == "" || fullNameTextBox.Text == "" || addressBox.Text == "" || phoneNumberTextBox.Text == "" || bloodComboBox.Text == "" || emailTextbox.Text == "")
            {
                MessageBox.Show("Fill All the Info");
            }
            else
            {

                c.name = fullNameTextBox.Text;
                c.uid = Int16.Parse(textBox3.Text);

                c.phone = phoneNumberTextBox.Text;
                c.address = addressBox.Text;
                c.gender = bloodComboBox.Text;
                c.password = textBox2.Text;
                c.squestion = textBox1.Text;
                c.email = emailTextbox.Text;



                int w = cq.updateprofile(c);
                if (w > 0)
                {
                    MessageBox.Show("updated");

                }

            }
        }
    }
}
