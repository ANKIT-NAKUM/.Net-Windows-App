using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T10_Q2_2 : Form
    {
        private string connectionString;

        public T10_Q2_2()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {

            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNet\\Windows_Project\\T10.mdf;Integrated Security=True";
        }

        private void LoadCustomerIDs()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CustId FROM Customer";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbCustomerID.Items.Clear();
                    while (reader.Read())
                    {
                        cmbCustomerID.Items.Add(reader["CustId"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer IDs: " + ex.Message);
                }
            }
        }

        private void LoadPaymentModes()
        {
            cmbPaymentMode.Items.AddRange(new string[] {
                "UPI", "RuPay Cards", "Debit Cards", "NetBanking", "Wallet"
            });
        }

        private void LoadOrdersData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT o.OrderID, o.CustId, c.Name as CustomerName, o.OrderAmount, o.PaymentMode 
                                     FROM Orders o 
                                     INNER JOIN Customer c ON o.CustId = c.CustId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewOrders.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string custId = cmbCustomerID.SelectedItem.ToString();
                        string query = "SELECT Name FROM Customer WHERE CustId = '" + custId + "'";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtCustomerName.Text = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading customer name: " + ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter Order ID to update.");
                return;
            }

            if (ValidateInput())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string orderId = txtOrderID.Text.Replace("'", "''");
                        string custId = cmbCustomerID.SelectedItem.ToString();
                        string orderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        string orderAmount = txtOrderAmount.Text.Replace("'", "''");
                        string paymentMode = cmbPaymentMode.SelectedItem.ToString();
                        string remarks = txtRemarks.Text.Replace("'", "''");

                        string query = @"UPDATE Orders SET 
                                         CustId = '" + custId + "', " +
                                         "OrderDate = '" + orderDate + "', " +
                                         "OrderAmount = " + orderAmount + ", " +
                                         "PaymentMode = '" + paymentMode + "', " +
                                         "Remarks = '" + remarks + "' " +
                                         "WHERE OrderID = " + orderId;

                        SqlCommand cmd = new SqlCommand(query, connection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order updated successfully!");
                            ClearForm();
                            LoadOrdersData();
                        }
                        else
                        {
                            MessageBox.Show("Order not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating order: " + ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter Order ID to search.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string orderId = txtOrderID.Text.Replace("'", "''");
                    string query = @"SELECT o.*, c.Name as CustomerName 
                                     FROM Orders o 
                                     INNER JOIN Customer c ON o.CustId = c.CustId 
                                     WHERE o.OrderID = " + orderId;

                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cmbCustomerID.SelectedItem = reader["CustId"].ToString();
                        dtpOrderDate.Value = Convert.ToDateTime(reader["OrderDate"]);
                        dtpSlipDate.Value = Convert.ToDateTime(reader["OrderDate"]);
                        txtOrderAmount.Text = reader["OrderAmount"].ToString();
                        cmbPaymentMode.SelectedItem = reader["PaymentMode"].ToString();
                        txtRemarks.Text = reader["Remarks"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Order ID not found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching order: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter Order ID to update.");
                return;
            }

            if (ValidateInput())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string orderId = txtOrderID.Text.Replace("'", "''");
                        string custId = cmbCustomerID.SelectedItem.ToString();
                        string orderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        string orderAmount = txtOrderAmount.Text.Replace("'", "''");
                        string paymentMode = cmbPaymentMode.SelectedItem.ToString();
                        string remarks = txtRemarks.Text.Replace("'", "''");

                        string query = @"UPDATE Orders SET 
                                         CustId = '" + custId + "', " +
                                         "OrderDate = '" + orderDate + "', " +
                                         "OrderAmount = " + orderAmount + ", " +
                                         "PaymentMode = '" + paymentMode + "', " +
                                         "Remarks = '" + remarks + "' " +
                                         "WHERE OrderID = " + orderId;

                        SqlCommand cmd = new SqlCommand(query, connection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order updated successfully!");
                            ClearForm();
                            LoadOrdersData();
                        }
                        else
                        {
                            MessageBox.Show("Order not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating order: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter Order ID to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string orderId = txtOrderID.Text.Replace("'", "''");
                        string query = "DELETE FROM Orders WHERE OrderID = " + orderId;
                        SqlCommand cmd = new SqlCommand(query, connection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order deleted successfully!");
                            ClearForm();
                            LoadOrdersData();
                        }
                        else
                        {
                            MessageBox.Show("Order not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting order: " + ex.Message);
                    }
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderID = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"SELECT o.*, c.Name as CustomerName 
                               FROM Orders o 
                               INNER JOIN Customer c ON o.CustId = c.CustId 
                               WHERE o.OrderID = " + orderID;

                        SqlCommand cmd = new SqlCommand(query, connection);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtOrderID.Text = reader["OrderID"].ToString();
                            cmbCustomerID.SelectedItem = reader["CustId"].ToString();
                            txtCustomerName.Text = reader["CustomerName"].ToString();
                            dtpOrderDate.Value = Convert.ToDateTime(reader["OrderDate"]);
                            dtpSlipDate.Value = Convert.ToDateTime(reader["OrderDate"]);
                            txtOrderAmount.Text = reader["OrderAmount"].ToString();
                            cmbPaymentMode.SelectedItem = reader["PaymentMode"].ToString();
                            txtRemarks.Text = reader["Remarks"].ToString();

                            cmbCustomerID.Enabled = true;
                            dtpOrderDate.Enabled = true;
                            dtpSlipDate.Enabled = true;
                            txtOrderAmount.Enabled = true;
                            cmbPaymentMode.Enabled = true;
                            txtRemarks.Enabled = true;

                            MessageBox.Show("Order #" + orderID + " loaded for editing. Make changes and click Update.");
                        }
                        else
                        {
                            MessageBox.Show("Order not found in database!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading order: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an order from the grid to edit.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            T10_Q2_1 form1 = new T10_Q2_1();
            form1.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (cmbCustomerID.SelectedItem == null)
            {
                MessageBox.Show("Please select Customer ID");
                return false;
            }
            if (string.IsNullOrEmpty(txtOrderAmount.Text) || !decimal.TryParse(txtOrderAmount.Text, out _))
            {
                MessageBox.Show("Please enter valid Order Amount");
                return false;
            }
            if (cmbPaymentMode.SelectedItem == null)
            {
                MessageBox.Show("Please select Payment Mode");
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            txtOrderID.Clear();
            cmbCustomerID.SelectedIndex = -1;
            txtCustomerName.Clear();
            dtpOrderDate.Value = DateTime.Now;
            dtpSlipDate.Value = DateTime.Now;
            txtOrderAmount.Clear();
            cmbPaymentMode.SelectedIndex = -1;
            txtRemarks.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCustomerIDs();
            LoadPaymentModes();
            LoadOrdersData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();

        }



        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearForm();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}