using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T10_Q6 : Form
    {
        public T10_Q6()
        {
            InitializeComponent();
        }

        private void T10_Q6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFrom.Text))
            {
                MessageBox.Show("Please enter From email");
                return;
            }

            if (string.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show("Please enter To email");
                return;
            }

            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Please enter Message");
                return;
            }

           MessageBox.Show("Message  Send ");

            txtFrom.Clear();
            txtTo.Clear();
            txtMessage.Clear();
        }


    }
}
