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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            DataBaseThings dbt = new DataBaseThings();

            SqlConnection con;
            SqlCommand command;
            SqlDataAdapter sda;

            try
            {
                con = new SqlConnection(dbt.SQLCONNECTION);

                command = new SqlCommand("SELECT * from tblBooking", con);

                sda = new SqlDataAdapter(command);

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
                    dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                }
                
 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
