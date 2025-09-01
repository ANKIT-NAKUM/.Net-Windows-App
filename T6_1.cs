using System;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T6_1 : Form
    {
        public T6_1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            CheckBox mycheckbox = new CheckBox();
            if (male.Checked == true)
            {
                display.Visible = true;
                if (news.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + news.Text + ", " + spec.Text;
                }
                else if (friends.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + friends.Text + ", " + spec.Text;
                }
                else if (website.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + website.Text + ", " + spec.Text;
                }
                else if (oth.Checked == true)
                {
                    display.Text = "Mr. " + name.Text + " You know about us from\n" + oth.Text + ", " + spec.Text;
                }
            }
            else if (female.Checked == true)
            {
                display.Visible = true;
                if (news.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + news.Text + ", " + spec.Text;
                }
                else if (friends.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + friends.Text + ", " + spec.Text;
                }
                else if (website.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + website.Text + ", " + spec.Text;
                }
                else if (oth.Checked == true)
                {
                    display.Text = "Miss. " + name.Text + " You know about us from\n" + oth.Text + ", " + spec.Text;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void news_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void T6_1_Load(object sender, EventArgs e)
        {

        }
    }
}
