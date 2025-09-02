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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_Project
{
    public partial class T6_3 : Form
    {
        public T6_3()
        {
            InitializeComponent();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            display.Visible = true;
            display.Text = numeric.Text + "\n" + upper.Text + "\n" + characters.Text;

        }

        private void upperkey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numkey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void charonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void characters_TextChanged(object sender, EventArgs e)
        {

        }

        private void T6_3_Load(object sender, EventArgs e)
        {

        }
    }
}