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
    public partial class HubusUsers : Form
    {
        public HubusUsers()
        {
            InitializeComponent();
        }

        public void ClearGroupTextBoxes()
        {
            foreach (Control cont in groupBox1.Controls)
            {
                if (cont is TextBox)
                {
                    cont.Text = "";
                }
            }
        }

        SqlConnection con;
        DataBaseThings dbt = new DataBaseThings();



        void UserDataTable()
        {
            try
            {
                con = new SqlConnection(dbt.SQLCONNECTION);

                SqlCommand command = new SqlCommand("SELECT * from tblUserAccounts", con);

                SqlDataAdapter sda = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void HubusUsers_Load(object sender, EventArgs e)
        {
            UserDataTable();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            String _error = "Please Select the Left Arrow to highlight a Record";
            try
            {
                textBox1_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2firstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3_Lastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4PhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5_Email.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(_error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(_error);
            }
        }

        private void button1Update_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(dbt.SQLCONNECTION);
            
                String _update = "UPDATE tblUserAccounts SET ID= '" + textBox1_ID.Text.ToString() + "',[First Name]= '" + textBox2firstName.Text + "',[Last Name]= '" + textBox3_Lastname.Text + "',Phone= '" + textBox4PhoneNumber.Text.ToString() + "',Email = '" + textBox5_Email.Text.ToString() + "' WHERE ID= '"+textBox1_ID.Text.ToString()+"'";

                con.Open();
                SqlCommand command = new SqlCommand(_update, con);
                command.ExecuteNonQuery();

                MessageBox.Show("Updated, " + textBox2firstName.Text + ' ' + textBox3_Lastname.Text);
                ClearGroupTextBoxes();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(dbt.SQLCONNECTION);

                string id = textBox1_ID.Text.ToString();

                int idNo = int.Parse(id);

                String _delete = "DELETE from tblUserAccounts WHERE ID= '"+idNo+"'";

                con.Open();
                SqlCommand command = new SqlCommand(_delete, con);
                command.ExecuteNonQuery();

                MessageBox.Show("Deleted, " + textBox2firstName.Text + ' ' + textBox3_Lastname.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

 

    }
}
