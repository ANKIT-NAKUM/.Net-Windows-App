using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Windows_Project
{
    public partial class T9_1 : Form
    {
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNet\\Windows_Project\\T9_1.mdf;Integrated Security=True";
        public T9_1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into students values (@name,@course,@dob,@address,@contect)", con);
            cmd.Parameters.Add("@name", textBox1.Text);
            cmd.Parameters.Add("@course", textBox2.Text);
            cmd.Parameters.Add("@dob", textBox3.Text);
            cmd.Parameters.Add("@address", textBox4.Text);
            cmd.Parameters.Add("@contect", textBox5.Text);


            int result = cmd.ExecuteNonQuery();

            if (result == 0)
            {
                MessageBox.Show("Error in insert");
            }
            else
            {
                MessageBox.Show("Data Inserted");
            }

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);

            con.Open();

            SqlCommand cmd = new SqlCommand("Update students set name=@name , course=@course ,dob=@dob ,address=@address WHERE Id=@Id", con);
            cmd.Parameters.Add("@Id", textBox6.Text);
            cmd.Parameters.Add("@name", textBox1.Text);
            cmd.Parameters.Add("@course", textBox2.Text);
            cmd.Parameters.Add("@dob", textBox3.Text);
            cmd.Parameters.Add("@address", textBox4.Text);
            cmd.Parameters.Add("@contect", textBox5.Text);

            int result = cmd.ExecuteNonQuery();
            if (result == 0)
            {
                MessageBox.Show("Error in update");
            }
            else
            {
                MessageBox.Show("Data Updated");
            }


            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from students where Id=@Id", con);
            cmd.Parameters.Add("@Id", textBox6.Text);

            int result = cmd.ExecuteNonQuery();

            if (result == 0)
            {
                MessageBox.Show("Error in delete");
            }
            else
            {
                MessageBox.Show("Data Deleted");
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM students", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            MessageBox.Show("Reset successful!");
            con.Close();
        }
    }
}
