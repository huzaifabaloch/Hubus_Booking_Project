using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UbusProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Email";
            textBox2.Text = "Password";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Center;
            richTextBox1.Enabled = false;
            this.ActiveControl = richTextBox1;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
            textBox2.UseSystemPasswordChar = true;
            
        }



        private void button1_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HUZAIFA\SQLEXPRESS;Initial Catalog=UbusBooking;Integrated Security=True");


            if (textBox1.Text == "email" || textBox1.Text == "" || textBox2.Text == "password" || textBox2.Text == "")
            {
                MessageBox.Show("Enter both Email and Password", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();

                DataBaseThings dbt = new DataBaseThings();
                dbt.Select("SELECT * from tblUserAccounts Where email = '" + textBox1.Text.ToString() + "'And Password = '" + textBox2.Text.ToString() + "'");

                SqlCommand command = new SqlCommand(dbt.SELECT, conn);
                SqlDataAdapter sda = new SqlDataAdapter(command);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {

                    Home hom = new Home("Welcome "+textBox1.Text.ToString());
                    hom.Show();
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password!", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            this.Hide();
            rf.Show();
        }
    }
}
