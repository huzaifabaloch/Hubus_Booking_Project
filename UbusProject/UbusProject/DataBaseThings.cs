using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace UbusProject
{
    class DataBaseThings
    {
        public string sqlCon;     //= "Data Source=HUZAIFA\\SQLEXPRESS;Initial Catalog=UbusBooking;Integrated Security=True";
        public string querySelect;
        private string _query;

        SqlConnection conn;
        SqlCommand command;
        public DataBaseThings()
        {
            sqlCon = "Data Source=HUZAIFA\\SQLEXPRESS;Initial Catalog=UbusBooking;Integrated Security=True";
        }



        public void Select(String query)
        {
            _query = query;
        }

        public String SELECT
        {
            get
            {
                return _query;
            }
        }

        public String SelectAll(String query)
        {
            query = "SELECT * from tblUserAccounts";
            return query;
        }


        public void Insert(String query)
        {
            _query = query;
        }

        public String INSERT
        {
            get
            {
                return _query;
            }
        }


        public String SQLCONNECTION
        {
            get { return sqlCon; }
        }

        public void Register(int ID, string first, string last, long phone, string email, string password)
        {

            conn = new SqlConnection(sqlCon);

            try
            {

                //  string insertQuery = "INSERT into tblUserAccounts values ('" + ID + "','" + first + "','" + last + "','" + phone + "','" + email + "','" + password + "')";


                Insert("INSERT into tblUserAccounts values ('" + ID + "','" + first + "','" + last + "','" + phone + "','" + email + "','" + password + "')");

                command = new SqlCommand(INSERT, conn);
                conn.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("User : " + first + "," + last + " has been registered");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex + ", ", "error");
            }

            finally
            {
                conn.Close();
            }

        }


        public void InsertintoBooking(int busID, string custName, long phone, string startingPoint, string destination, string schedule)
        {
            try
            {
                conn = new SqlConnection(sqlCon);

                Insert("INSERT into tblBooking values ('" + busID + "','" + custName + "','" + phone + "','" + startingPoint + "','" + destination + "','" + schedule + "')");

                command = new SqlCommand(INSERT, conn);
                conn.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Booking Successful!", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
