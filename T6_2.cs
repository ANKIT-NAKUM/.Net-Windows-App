using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T6_2 : Form
    {
        public T6_2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label2.Text = "Selected: " + listBox1.SelectedItem.ToString();

            }
        }

        private void count_btn_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            label1.Text = " " + count.ToString();
        }

        private void fill_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Education");
            listBox1.Items.Add("Food for all");
            listBox1.Items.Add("Freedom Of Speech");
            listBox1.Items.Add("Good Books");
            listBox1.Items.Add("Good Movies");

        }

        private void sorted_btn_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
