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
    public partial class BookBus : Form
    {
        public BookBus()
        {
            InitializeComponent();
        }

        DataBaseThings dtb = new DataBaseThings();

        private void BookBus_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {

            String bookId = texBusID.Text.ToString();
            int bookID = int.Parse(bookId);

            String custName = textBox_CustNAme.Text;

            String phone = textBox2_Phone.Text.ToString();
            long phoneNo = long.Parse(phone);

            String startingCity = comboBox1Starting.Text;
            String destination = comboBox2Destination.Text;

            String schedule = dateTimePicker1.Text;

            dtb.InsertintoBooking(bookID, custName, phoneNo, startingCity, destination, schedule);
        }

    }
}
