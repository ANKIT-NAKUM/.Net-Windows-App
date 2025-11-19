using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T10_Q3 : Form
    {
        string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNet\\Windows_Project\\T10.mdf;Integrated Security=True";
        public T10_Q3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(cmbQueryNo.SelectedItem);
            string query = "";

            switch (q)
            {
                case 1:
                    query = @"SELECT o.OrderID, o.CustID, c.Name, c.City, c.State, o.OrderAmount
                              FROM Customer c JOIN Orders o ON c.CustID = o.CustID";
                    break;

                case 2:
                    query = @"SELECT o.OrderID, o.CustID, c.Name, c.City, c.State, o.OrderAmount
                              FROM Customer c JOIN Orders o ON c.CustID = o.CustID
                              WHERE o.OrderAmount > 10000";
                    break;

                case 3:
                    query = @"SELECT c.CustID, c.Name, c.City, c.State,SUM(o.OrderAmount) AS TotalAmount
                              FROM Customer c JOIN Orders o ON c.CustID = o.CustID
                              GROUP BY c.CustID, c.Name, c.City, c.State";
                    break;

                case 4:
                    query = @"SELECT c.CustID, c.Name,SUM(o.OrderAmount) AS TotalAmount,MONTH(o.OrderDate) AS OrderMonth,YEAR(o.OrderDate) AS OrderYear
                              FROM Customer c JOIN Orders o ON c.CustID = o.CustID
                              GROUP BY c.CustID, c.Name, MONTH(o.OrderDate), YEAR(o.OrderDate)";
                    break;

                case 5:
                    query = @"SELECT PaymentMode, SUM(OrderAmount) AS TotalAmount
                              FROM Orders GROUP BY PaymentMode";
                    break;

                case 6:
                    query = @"SELECT PaymentMode, SUM(OrderAmount) AS TotalAmount
                              FROM Orders WHERE YEAR(OrderDate) = YEAR(GETDATE())
                              GROUP BY PaymentMode";
                    break;

                case 7:
                    query = @"SELECT PaymentMode, SUM(OrderAmount) AS TotalAmount
                              FROM Orders WHERE YEAR(OrderDate) = YEAR(GETDATE()) - 1
                              GROUP BY PaymentMode";
                    break;

                case 8:
                    query = @"SELECT PaymentMode, SUM(OrderAmount) AS TotalAmount
                              FROM Orders WHERE OrderDate BETWEEN '2024-01-01' AND '2025-12-31'
                              GROUP BY PaymentMode";
                    break;

                case 9:
                    query = @"SELECT c.CustID, c.Name,COUNT(o.OrderID) AS TotalOrders
                              FROM Customer c JOIN Orders o ON c.CustID = o.CustID
                              GROUP BY c.CustID, c.Name
                              HAVING COUNT(o.OrderID) > 3";
                    break;

                case 10:
                    query = @"SELECT c.CustID, c.Name,MAX(o.OrderAmount) AS HighestOrder
                              FROM Customer c JOIN Orders o ON c.CustID = o.CustID
                              GROUP BY c.CustID, c.Name";
                    break;

                default:
                    MessageBox.Show("Select a valid query number!");
                    return;
            }
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
