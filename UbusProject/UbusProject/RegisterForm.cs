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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=HUZAIFA\\SQLEXPRESS;Initial Catalog=UbusBooking;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            textBox1_FirstName.Text = "First Name";
            textBox2_LastName.Text = "Last Name";
            textBox3_Phone.Text = "Phone Number";
            textBox4_Email.Text = "Email";
            textBox5_Password.Text = "Password";
            textBox_ID.Text = "ID Number";
            this.richTextBox1.Enabled = false;
            this.ActiveControl = richTextBox1;

            
        }

        public virtual void ClearTextBoxes()
        {
            foreach (Control cont in Controls)
            {
                if (cont is TextBox)
                {
                    cont.Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Password_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5_Password.Text = "";
            textBox5_Password.UseSystemPasswordChar = true;
        }

        private void textBox4_Email_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4_Email.Text = null;
        }

        private void textBox3_Phone_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3_Phone.Text = null;
        }

        private void textBox2_LastName_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2_LastName.Text = null;
        }

        private void textBox1_FirstName_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1_FirstName.Text = null;
        }

        private void button1_Register_Click(object sender, EventArgs e)
        {
            DataBaseThings dbt = new DataBaseThings();


            if (textBox_ID.Text == "ID Number" || textBox1_FirstName.Text == "First Name" || textBox2_LastName.Text == "Last Name" || textBox3_Phone.Text == "Phone Number" || textBox4_Email.Text == "Email" || textBox5_Password.Text == "Password")
            {
                MessageBox.Show("All fields are mandatory.", "register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (textBox_ID.Text == "" || textBox1_FirstName.Text == "" || textBox2_LastName.Text == "" || textBox3_Phone.Text == "" || textBox4_Email.Text == "" || textBox5_Password.Text == "")
            {
                MessageBox.Show("All fields are mandatory.", "register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                try
                {

                    String id = textBox_ID.Text.ToString();
                    int idNo = Int32.Parse(id);

                    String firstName = textBox1_FirstName.Text.ToString();
                    String lastName = textBox2_LastName.Text.ToString();

                    String phoneNumber = textBox3_Phone.Text.ToString();
                    long iPhoneNumber = Convert.ToInt64(phoneNumber);

                    String emailAddress = textBox4_Email.Text.ToString();

                    String password = textBox5_Password.Text.ToString();

                    dbt.Register(idNo, firstName, lastName, iPhoneNumber, emailAddress, password);

                    ClearTextBoxes();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Please use correct format for the fields", "error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            
        
        }

        private void textBox_ID_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_ID.Text = null;
        }

        private void button1AlreadyPatrner_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
