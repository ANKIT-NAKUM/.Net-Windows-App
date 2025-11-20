namespace Windows_Project
{
    partial class T10_Q2_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSlipDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblSlipDate = new System.Windows.Forms.Label();
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(173, 74);
            this.cmbCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(199, 24);
            this.cmbCustomerID.TabIndex = 1;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(173, 123);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(265, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(173, 172);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(199, 22);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // dtpSlipDate
            // 
            this.dtpSlipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSlipDate.Location = new System.Drawing.Point(173, 222);
            this.dtpSlipDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpSlipDate.Name = "dtpSlipDate";
            this.dtpSlipDate.Size = new System.Drawing.Size(199, 22);
            this.dtpSlipDate.TabIndex = 4;
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(173, 271);
            this.txtOrderAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.Size = new System.Drawing.Size(199, 22);
            this.txtOrderAmount.TabIndex = 5;
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Location = new System.Drawing.Point(173, 320);
            this.cmbPaymentMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(199, 24);
            this.cmbPaymentMode.TabIndex = 6;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(173, 369);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(265, 30);
            this.txtRemarks.TabIndex = 7;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(173, 25);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(199, 22);
            this.txtOrderID.TabIndex = 0;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 407);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1121, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(353, 407);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 37);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(461, 407);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(569, 407);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(387, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(16, 452);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1205, 272);
            this.dataGridViewOrders.TabIndex = 14;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(27, 28);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(91, 16);
            this.lblOrderID.TabIndex = 15;
            this.lblOrderID.Text = "Enter Order ID";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(27, 78);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(80, 16);
            this.lblCustomerID.TabIndex = 16;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(27, 127);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(27, 176);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(73, 16);
            this.lblOrderDate.TabIndex = 18;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblSlipDate
            // 
            this.lblSlipDate.AutoSize = true;
            this.lblSlipDate.Location = new System.Drawing.Point(27, 225);
            this.lblSlipDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlipDate.Name = "lblSlipDate";
            this.lblSlipDate.Size = new System.Drawing.Size(62, 16);
            this.lblSlipDate.TabIndex = 19;
            this.lblSlipDate.Text = "Slip Date";
            // 
            // lblOrderAmount
            // 
            this.lblOrderAmount.AutoSize = true;
            this.lblOrderAmount.Location = new System.Drawing.Point(27, 274);
            this.lblOrderAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderAmount.Name = "lblOrderAmount";
            this.lblOrderAmount.Size = new System.Drawing.Size(89, 16);
            this.lblOrderAmount.TabIndex = 20;
            this.lblOrderAmount.Text = "Order Amount";
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Location = new System.Drawing.Point(27, 324);
            this.lblPaymentMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(98, 16);
            this.lblPaymentMode.TabIndex = 21;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(27, 373);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(62, 16);
            this.lblRemarks.TabIndex = 22;
            this.lblRemarks.Text = "Remarks";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(32, 407);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 37);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(245, 407);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 37);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 738);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblPaymentMode);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.lblSlipDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cmbPaymentMode);
            this.Controls.Add(this.txtOrderAmount);
            this.Controls.Add(this.dtpSlipDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.cmbCustomerID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Order Entry";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpSlipDate;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblSlipDate;
        private System.Windows.Forms.Label lblOrderAmount;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClear;
    }
}