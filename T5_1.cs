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
    public partial class T5_1 : Form
    {
        public T5_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To My First Application Using C#");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void T5_1_Load(object sender, EventArgs e)
        {

        }
    }
}
