using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Successful Login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Welcome " + txt1.Text + " to Windows Project", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt3.Visible = true;
            txt3.Text = "I am " + txt1.Text + " From " + txt2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
