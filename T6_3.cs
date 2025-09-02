
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T6_3 : Form
    {
        public T6_3()
        {
            InitializeComponent();
            txtNumeric.KeyPress += TxtNumeric_KeyPress;
            txtUppercase.KeyPress += TxtUppercase_KeyPress;
            txtChars.KeyPress += TxtChars_KeyPress;

            txtUppercase.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtUppercase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtChars_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUppercase_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtNumeric_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
