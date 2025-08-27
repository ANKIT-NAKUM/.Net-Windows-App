using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Windows_Project
{
    public partial class T6_2 : Form
    {
        public T6_2()
        {
            InitializeComponent();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            using (var Popup = new Popup())
            {
                if (Popup.ShowDialog() == DialogResult.OK)
                {
                    lb1.Items.Add(Popup.InputText);

                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                lb1.Items.Remove(lb1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = lb1.Items.Cast<string>().OrderBy(item => item).ToArray();
            lb1.Items.Clear();
            lb1.Items.AddRange(items);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = ($"Total number of items: {lb1.Items.Count}");
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                select.Text = $"Selected Item: {lb1.SelectedItem.ToString()}";
            }
            else
            {
                select.Text = "Your Selection";
            }



        }

        private void select_Click(object sender, EventArgs e)
        {

        }

        private void T6_2_Load(object sender, EventArgs e)
        {

        }
    }
}
