using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Restaurant_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Total_Click(object sender, EventArgs e)
        {

            double total = Pizza() + Beef() + Chicken() + Pasta() + Fries() + Grill() + Tawgen();
            double tax = (total *14)/100;
            textBox1.Text = tax.ToString();
            double totalwithtax = total + tax;
            textBox2.Text = totalwithtax.ToString();
        }
        private double Pizza()
        {
            double[] pricee = new double[10];
            SqlConnection connection = new SqlConnection(@"server=LAPTOP-HLKAL83K\MSSQLSERVER01;Database=Restaurant;
    Trusted_Connection=True");
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            if (numericUpDown1.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'SUPER SUPREME-Large (Pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                pricee[0] = totalprice * (int)numericUpDown1.Value;
            }
            if (numericUpDown2.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'SUPER SUPREME-Medium (Pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                pricee[1] = totalprice * (int)numericUpDown2.Value;  
            }
            if (numericUpDown3.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'SUPER SUPREME-Small (Pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();

                pricee[2] = totalprice * (int)numericUpDown3.Value;
            }
            if (numericUpDown4.Value >= 1)
            {
                double totalprice = 0;
                
                sql = "select price from Restaurant where food_name like 'CLASSIC PEPPERONI-Large (pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                pricee[3] = totalprice * (int)numericUpDown4.Value;
            }
            if (numericUpDown5.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'CLASSIC PEPPERONI-Medium (pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[4] = totalprice * (int)numericUpDown5.Value;
            }
            if (numericUpDown6.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'CLASSIC PEPPERONI-Small (pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[5] = totalprice * (int)numericUpDown6.Value;
            }
            if (numericUpDown7.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'CHICKEN SUPREME-Large (Pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[6] = totalprice * (int)numericUpDown7.Value;
            }
            if (numericUpDown43.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'CHICKEN SUPREME-Medium (Pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[7] = totalprice * (int)numericUpDown43.Value;
            }
            if (numericUpDown9.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'CHICKEN SUPREME-Small (Pizza)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[8] = totalprice * (int)numericUpDown9.Value;
            }
            connection.Close();
            double finalpriece=0;
            for (int i = 0; i <= 9; i++)
            {
                finalpriece += pricee[i];
            }
            return finalpriece;
        }

        private double Beef()
        {
            double[] pricee = new double[8];
            SqlConnection connection = new SqlConnection(@"server=LAPTOP-HLKAL83K\MSSQLSERVER01;Database=Restaurant;Trusted_Connection=True");
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            if (numericUpDown8.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'BBQ Charbroiled-150gm (Beef Sandwich)'";
                command = new SqlCommand(sql, connection);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[0] = totalprice * (int)numericUpDown8.Value;

            }
            if (numericUpDown9.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'BBQ Charbroiled-200gm (Beef Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[1] = totalprice * (int)numericUpDown9.Value;
            }
            if (numericUpDown10.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'BBQ Charbroiled-400gm (Beef Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                pricee[2] = totalprice * (int)numericUpDown10.Value;
            }
            if (numericUpDown11.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Double Double-300gm (Beef Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
               
                
                pricee[3] = totalprice * (int)numericUpDown11.Value;
            }
            if (numericUpDown12.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Triple buger-450gm (Beef Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[4] = totalprice * (int)numericUpDown12.Value;
            }
            if (numericUpDown13.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Double Jab-400gm (Beef Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
               
             
                pricee[5] = totalprice * (int)numericUpDown13.Value;
            }
            connection.Close();
            double finalpricee = 0;
            for (int i = 0; i <= 7; i++)
                finalpricee +=pricee[i];
            return finalpricee;
        }

        private double Chicken()
        {
            double[] pricee = new double[7];
            SqlConnection connection = new SqlConnection(@"server=LAPTOP-HLKAL83K\MSSQLSERVER01;Database=Restaurant;Trusted_Connection=True");
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            if (numericUpDown14.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Chicken Caramels-Single (Chicken Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                pricee[0] = totalprice * (int)numericUpDown14.Value;
            }
            if (numericUpDown15.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Chicken Caramels-Double (Chicken Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[1] = totalprice * (int)numericUpDown15.Value;
            }
            if (numericUpDown16.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Chicken Caramels-Triple (Chicken Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[2] = totalprice * (int)numericUpDown16.Value;
            }
            if (numericUpDown17.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Hot Chicken Fries (Chicken Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
               
                
                pricee[3] = totalprice * (int)numericUpDown17.Value;
            }
            if (numericUpDown18.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Crack Chack Chicken-Single (Chicken Sandwich)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[4] = totalprice * (int)numericUpDown18.Value;
            }
            connection.Close();
            double finalpricee = 0;
            for (int i = 0; i <= 6; i++)
                finalpricee += pricee[i];
            return finalpricee;
        }
        private double Pasta()
        {
            double[] pricee = new double[8];
            SqlConnection connection = new SqlConnection(@"server=LAPTOP-HLKAL83K\MSSQLSERVER01;Database=Restaurant;Trusted_Connection=True");
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            if (numericUpDown23.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Fettuccini Chicken Alfredo (Pasta)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
               
                pricee[0] = totalprice * (int)numericUpDown23.Value;
            }
            if (numericUpDown24.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Fettuccini Beef Alfredo (Pasta)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[1] = totalprice * (int)numericUpDown24.Value;
            }
            if (numericUpDown27.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Fettuccini Seafood Alfredo (Pasta)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[2] = totalprice * (int)numericUpDown27.Value;
            }
            if (numericUpDown25.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Fettuccini Chicken Pesto (Pasta)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[3] = totalprice * (int)numericUpDown25.Value;
            }
            if (numericUpDown26.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Penne Quattro Formaggi (Pasta)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
               
                
                pricee[4] = totalprice * (int)numericUpDown26.Value;
            }
            if (numericUpDown28.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Chicken Pappardelle (Pasta)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[5] = totalprice * (int)numericUpDown28.Value;
            }
            connection.Close();
            double finalpricee = 0;
            for (int i = 0; i <= 7; i++)
                finalpricee +=pricee[i];
            return finalpricee;

        }
        private double Fries()
        {
            double[] pricee = new double[6];
            SqlConnection connection = new SqlConnection(@"server=LAPTOP-HLKAL83K\MSSQLSERVER01;Database=Restaurant;Trusted_Connection=True");
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            if (numericUpDown29.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Classic Fries (Fries)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[0] = totalprice * (int)numericUpDown29.Value;
            }
            if (numericUpDown30.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Classic Fries-Jumbo (Fries)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[1] = totalprice * (int)numericUpDown30.Value;
            }
            if (numericUpDown31.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Classic Fries-Large (Fries)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
               
                
                pricee[2] = totalprice * (int)numericUpDown31.Value;
            }
            if (numericUpDown32.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Classic Fries-Medium (Fries)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[3] = totalprice * (int)numericUpDown32.Value;
            }
            connection.Close();
            double finalpricee = 0;
            for (int i = 0; i <= 5; i++)
                finalpricee += pricee[i];
            return finalpricee;
        }

        private double Grill()
        {
            double[] pricee = new double[8];
            SqlConnection connection = new SqlConnection(@"server=LAPTOP-HLKAL83K\MSSQLSERVER01;Database=Restaurant;Trusted_Connection=True");
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            if (numericUpDown33.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like '1/4 Kofta (Dishes)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[0] = totalprice * (int)numericUpDown33.Value;
            }
            if (numericUpDown34.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like '1/2 Chicken Tikka (Grill)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[1] = totalprice * (int)numericUpDown34.Value;
            }
            if (numericUpDown35.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like '1/2 Charcoal Chicken Shish (Grill)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[2] = totalprice * (int)numericUpDown35.Value;
            }
            if (numericUpDown36.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like '1/4 Kofta & Tarb(Grill)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[3] = totalprice * (int)numericUpDown36.Value;
            }
            if (numericUpDown37.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like '1/4 Tarb(Grill)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[4] = totalprice * (int)numericUpDown37.Value;
            }
            if (numericUpDown38.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like '1/4 Kabab(Grill)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[5] = totalprice * (int)numericUpDown38.Value;
            }
            connection.Close();
            double finalpricee = 0;
            for (int i = 0; i <= 5; i++)
                finalpricee +=pricee[i];
            return finalpricee;
        }
        private double Tawgen()
        {
            double[] pricee = new double[9];
            SqlConnection connection = new SqlConnection(@"server=LAPTOP-HLKAL83K\MSSQLSERVER01;Database=Restaurant;Trusted_Connection=True");
            connection.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            if (numericUpDown39.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Plain Molokheya (Tawagen)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[0] = totalprice * (int)numericUpDown39.Value;
            }
            if (numericUpDown40.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Torlley (Tawagen)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
               
                pricee[1] = totalprice * (int)numericUpDown40.Value;
            }
            if (numericUpDown41.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like ' Freek (Tawagen)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
               
                
                pricee[2] = totalprice * (int)numericUpDown41.Value;
            }
            if (numericUpDown42.Value >= 1)
            {
                double totalprice = 0;
                sql = "select price from Restaurant where food_name like 'Potatoes(Tawagen)'";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble(0);
                    totalprice = totalprice + price;
                }
                dataReader.Close();
                command.Dispose();
                
                
                pricee[3] = totalprice * (int)numericUpDown42.Value;
            }
            connection.Close();
            double finalpricee = 0;
            for (int i = 0; i <= 8; i++)
                finalpricee +=pricee[i];
            return finalpricee;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
