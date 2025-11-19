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
    public partial class T10_Q5 : Form
    {
        public T10_Q5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("AGE", typeof(int));
            table.Columns.Add("ADDRESS", typeof(string));
            table.Columns.Add("SALARY", typeof(decimal));

            table.Rows.Add(1, "Ramesh", 32, "Ahmedabad", 2000.00m);
            table.Rows.Add(2, "Khilan", 25, "Delhi", 1500.00m);
            table.Rows.Add(3, "Kaushik", 23, "Kota", 2000.00m);
            table.Rows.Add(4, "Chaitali", 25, "Mumbai", 6500.00m);
            table.Rows.Add(5, "Hardik", 27, "Bhopal", 8500.00m);
            table.Rows.Add(6, "Komal", 22, "MP", 4500.00m);
            table.Rows.Add(7, "Aarav", 28, "Surat", 5200.00m);
            table.Rows.Add(8, "Anika", 24, "Jaipur", 4800.00m);
            table.Rows.Add(9, "Bodhi", 30, "Pune", 6100.00m);
            table.Rows.Add(10, "Diya", 22, "Nagpur", 4300.00m);

            dataGridView.DataSource = table;

        }
    }
}
