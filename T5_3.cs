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
    public partial class T5_3 : Form
    {
        public T5_3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_red_CheckedChanged(object sender, EventArgs e)
        {
                this.ForeColor = Color.Red;
        }

        private void btn_green_CheckedChanged(object sender, EventArgs e)
        {
                this.ForeColor = Color.Green;
        }

        private void btn_blue_CheckedChanged(object sender, EventArgs e)
        {
                this.ForeColor = Color.Blue;
        }

        private void btn_cyan_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void btn_pink_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void btn_black_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void T5_3_Load(object sender, EventArgs e)
        {

        }
    }
}
