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
    
    public partial class T5_4 : Form
    {
        double firstno, secondno, result;
        string op = " ";
        public T5_4()
        {
            InitializeComponent();
        }

        private void display_btn_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            if(display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "0";
            }
            else
            {
                display_btn.Text = display_btn.Text + "0";
            }
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "1";
            }
            else
            {
                display_btn.Text = display_btn.Text + "1";
            }
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "2";
            }
            else
            {
                display_btn.Text = display_btn.Text + "2";
            }
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "3";
            }
            else
            {
                display_btn.Text = display_btn.Text + "3";
            }
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "4";
            }
            else
            {
                display_btn.Text = display_btn.Text + "4";
            }
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "5";
            }
            else
            {
                display_btn.Text = display_btn.Text + "5";
            }
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "6";
            }
            else
            {
                display_btn.Text = display_btn.Text + "6";
            }
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "7";
            }
            else
            {
                display_btn.Text = display_btn.Text + "7";
            }
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "8";
            }
            else
            {
                display_btn.Text = display_btn.Text + "8";
            }
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            if (display_btn.Text == "0" && display_btn.Text != null)
            {
                display_btn.Text = "9";
            }
            else
            {
                display_btn.Text = display_btn.Text + "9";
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            display_btn.Text = "";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(display_btn.Text);
            display_btn.Text = "0";
            op = "+";
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(display_btn.Text);
            display_btn.Text = "0";
            op = "-";
        }

        private void mul_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(display_btn.Text);
            display_btn.Text = "0";
            op = "*";
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(display_btn.Text);
            display_btn.Text = "0";
            op = "/";
        }

        private void ans_btn_Click(object sender, EventArgs e)
        {
            secondno = Convert.ToDouble(display_btn.Text);
            switch (op)
            {
                case "+":
                    result = firstno + secondno;
                    display_btn.Text = result.ToString();
                    break;
                case "-":
                    result = firstno - secondno;
                    display_btn.Text = result.ToString();
                    break;
                case "*":
                    result = firstno * secondno;
                    display_btn.Text = result.ToString();
                    break;
                case "/":
                    if (secondno != 0)
                    {
                        result = firstno / secondno;
                        display_btn.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        display_btn.Text = "0";
                    }
                    break;
                default:
                    MessageBox.Show("Please select an operation");
                    break;
            }
        }
    }
}
