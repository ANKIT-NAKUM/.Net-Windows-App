using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T10_Q2_1 : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNet\\Windows_Project\\T10.mdf;Integrated Security=True";
        SqlConnection con;
        int selectedCustomerID;
        string selectedCustomerName;
        public T10_Q2_1()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT CustID FROM Customer", con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox1.Items.Add(sqlDataReader["CustID"].ToString());
            }

            sqlDataReader.Close();

            SqlCommand paymentModeCommand = new SqlCommand("SELECT DISTINCT PaymentMode FROM Orders", con);

            SqlDataReader paymentModeReader = paymentModeCommand.ExecuteReader();
            while (paymentModeReader.Read())
            {
                comboBox3.Items.Add(paymentModeReader["PaymentMode"].ToString());
            }
            con.Close();

        }

        private void T10_Q2_1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            selectedCustomerID = int.Parse(comboBox1.SelectedItem.ToString());
            con.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT Name FROM Customer WHERE CustID=@CustID", con);

            sqlCommand.Parameters.AddWithValue("@CustID", selectedCustomerID);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox2.Items.Add(sqlDataReader["Name"].ToString());
            }
            comboBox2.SelectedIndex = 0;
            con.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomerName = comboBox2.SelectedItem.ToString();
        }
    }
}
