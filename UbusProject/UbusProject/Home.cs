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
    public partial class Home : Form
    {
        public Home(string user)
        {
            InitializeComponent();
            label1.Text = user;
        }

        private void button3_HubusUsers_Click(object sender, EventArgs e)
        {
            HubusUsers hbu = new HubusUsers();
            hbu.Show();
        }

        private void button1HOME_Click(object sender, EventArgs e)
        {
            BookBus bb = new BookBus();
            bb.Show();
        }

        private void button2BOOkINGS_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings();
            bookings.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {


        }

    }
}
