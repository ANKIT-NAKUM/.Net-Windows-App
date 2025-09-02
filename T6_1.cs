using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Windows_Project
{
    public partial class T6_1 : Form
    {

        public T6_1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string salutation = "";
            if (male.Checked)
            {
                salutation = "Mr. ";
            }
            else if (female.Checked)
            {
                salutation = "Miss ";
            }

            List<string> selectedSources = new List<string>();

            if (chkNewspaper.Checked)
            {
                selectedSources.Add("News Paper");
            }
            if (chkFriends.Checked)
            {
                selectedSources.Add("Friends");
            }
            if (chkWebsite.Checked)
            {
                selectedSources.Add("Website");
            }
            if (chkOthers.Checked)
            {
                selectedSources.Add(soiOther.Text.Trim());
            }

            string sources = string.Join(", ", selectedSources);

            string message = $"Hello {salutation} {name.Text}. You know about us from \n{sources}";
            output.Text = message;
        }

        private void Window4_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
