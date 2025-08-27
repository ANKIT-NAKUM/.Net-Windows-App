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
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sumbtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1text.Text);
            int b = Convert.ToInt32(num2text.Text);

            MessageBox.Show("Addition Of Number Is : " + (a + b));
  
      
           

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1text.Text);
            int b = Convert.ToInt32(num2text.Text);
            MessageBox.Show("Subtraction Of Number Is :" + (a - b));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1text.Text);
            int b = Convert.ToInt32(num2text.Text);
            MessageBox.Show("Multiplication Of Number Is :" + (a * b));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1text.Text);
            int b = Convert.ToInt32(num2text.Text);

            MessageBox.Show("Division Of Number Is :" + (a / b));

        }
    }
}
