using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet1.Restaurant' table. You can move, or remove it, as needed.
            this.restaurantTableAdapter.Fill(this.restaurantDataSet1.Restaurant);

        }

     
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
            {
            if (textBox1.Text == "kiro")
            {
                if (textBox2.Text == "123")
                {
                    FormMenu f = new FormMenu();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Enter correct username or password", "Login Invalid");
                }
            }
            else
            {
                MessageBox.Show("Please Enter correct username or password", "Login Invalid");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
