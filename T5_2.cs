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
    public partial class T5_2 : Form
    {
        public T5_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Name " + txt_name.Text + " " + "form " + " " + txt_orga.Text + " " + "Is a " + txt_comm.Text);

            MessageBox.Show("Name: " + txt_name.Text + "\n" +
                "Organization: " + txt_orga.Text + "\n" +
                "Comment: " + txt_comm.Text);
        }
    }
}
