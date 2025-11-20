using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class T10_Q2_1 : Form
    {
        private string connectionString;
        private bool isEditMode = false;

        public T10_Q2_1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadCustomerIDs();
            LoadPaymentModes();
            EnableForm(false);
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
                        string query = "SELECT Name FROM Customer WHERE CustId = @CustId";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@CustId", cmbCustomerID.SelectedItem.ToString());
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

        // NEW BUTTON LOGIC
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            EnableForm(true);
            isEditMode = false;
        }

        // SAVE BUTTON LOGIC
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            T10_Q2_2 orderForm = new T10_Q2_2();
            orderForm.ShowDialog();
            LoadOrdersData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            cmbCustomerID.SelectedIndex = -1;
            txtCustomerName.Clear();
            dtpOrderDate.Value = DateTime.Now;
            dtpSlipDate.Value = DateTime.Now;
            txtOrderAmount.Clear();
            cmbPaymentMode.SelectedIndex = -1;
            txtRemarks.Clear();
        }



        private void EnableForm(bool enable)
        {
            cmbCustomerID.Enabled = enable;
            dtpOrderDate.Enabled = enable;
            dtpSlipDate.Enabled = enable;
            txtOrderAmount.Enabled = enable;
            cmbPaymentMode.Enabled = enable;
            txtRemarks.Enabled = enable;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"INSERT INTO Orders (CustId, OrderDate, OrderDesc, ShipDesc, OrderAmount, PaymentMode, Remarks) 
                                VALUES (@CustId, @OrderDate, @OrderDesc, @ShipDesc, @OrderAmount, @PaymentMode, @Remarks)";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@CustId", cmbCustomerID.SelectedItem);
                        cmd.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value);
                        cmd.Parameters.AddWithValue("@OrderDesc", "Order Description");
                        cmd.Parameters.AddWithValue("@ShipDesc", "Shipping Description");
                        cmd.Parameters.AddWithValue("@OrderAmount", decimal.Parse(txtOrderAmount.Text));
                        cmd.Parameters.AddWithValue("@PaymentMode", cmbPaymentMode.SelectedItem);
                        cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order saved successfully!");
                        ClearForm();
                        LoadOrdersData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving order: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order from the grid to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];

            // Get OrderID from the selected row
            int orderID = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);
            string customerName = selectedRow.Cells["CustomerName"].Value.ToString();

            // Confirm deletion with order details
            if (MessageBox.Show($"Are you sure you want to delete Order #{orderID} for {customerName}?",
                "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Orders WHERE OrderID = @OrderID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@OrderID", orderID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order deleted successfully!");
                            LoadOrdersData(); // Refresh the grid
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }

}