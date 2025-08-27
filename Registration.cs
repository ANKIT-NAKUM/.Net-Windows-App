using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Windows_Project
{
    public partial class Registration : Form
    {
        string gender1;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNet\\Windows_Project\\Registration.mdf;Integrated Security=True";
        public Registration()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO Register VALUES ('" + name_text.Text + "','" + pwd_text.Text + "','" + list_branch.SelectedItem.ToString() + "','" + comboxcity.SelectedItem.ToString() + "','" + gender1 + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Registration Successful!");
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gender1 = "male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender1 = "female";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Register SET Name = @Name, Password = @Password, Branch = @Branch, City = @City, Gender1 = @Gender1 where id = @id",con);

            cmd.Parameters.AddWithValue("@id", id_txt.Text);
            cmd.Parameters.AddWithValue("@Name", name_text.Text);
            cmd.Parameters.AddWithValue("@Password", pwd_text.Text);
            cmd.Parameters.AddWithValue("@Branch", list_branch.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@City", comboxcity.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Gender1", gender1);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successful!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Register where id = @id", con);
            cmd.Parameters.AddWithValue("@id", id_txt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Successful!");
        }
    }
}
