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
    public partial class T10_Q2_2 : Form
    {
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNet\\Windows_Project\\T10.mdf;Integrated Security=True";
        public T10_Q2_2()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand cmd1 = new SqlCommand("insert into Orders valus(@CustId,@OrderDate,@ShipDate,@OrderAmount,@PaymentMode,@Remark)", con);
            cmd1.Parameters.Add("@CustId", comboBox1.SelectedValue);
            cmd1.Parameters.Add("@OrderDate", DateTime.ParseExact(orderdate.Text, "dd/mm/yyyy", null));
            cmd1.Parameters.Add("@ShipDate", DateTime.ParseExact(shipdate.Text, "dd/mm/yyyy", null));
            cmd1.Parameters.Add("@OrderAmount", int.Parse(orderamount.Text));
            cmd1.Parameters.Add("@PaymentMode", paymentmode.SelectedValue);
            cmd1.Parameters.Add("@Remark", remarks.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Successfully");

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
