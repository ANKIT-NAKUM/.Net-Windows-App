namespace Windows_Project
{
    partial class T10_Q2_1
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.lblSlipDate = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.dtpSlipDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 291);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(257, 291);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(337, 291);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(813, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 327);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(850, 225);
            this.dataGridViewOrders.TabIndex = 4;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(12, 252);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 36;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Location = new System.Drawing.Point(12, 212);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(78, 13);
            this.lblPaymentMode.TabIndex = 35;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // lblOrderAmount
            // 
            this.lblOrderAmount.AutoSize = true;
            this.lblOrderAmount.Location = new System.Drawing.Point(12, 172);
            this.lblOrderAmount.Name = "lblOrderAmount";
            this.lblOrderAmount.Size = new System.Drawing.Size(72, 13);
            this.lblOrderAmount.TabIndex = 34;
            this.lblOrderAmount.Text = "Order Amount";
            // 
            // lblSlipDate
            // 
            this.lblSlipDate.AutoSize = true;
            this.lblSlipDate.Location = new System.Drawing.Point(12, 132);
            this.lblSlipDate.Name = "lblSlipDate";
            this.lblSlipDate.Size = new System.Drawing.Size(50, 13);
            this.lblSlipDate.TabIndex = 33;
            this.lblSlipDate.Text = "Slip Date";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(12, 92);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 32;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 52);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 31;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 12);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 30;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(122, 249);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 25);
            this.txtRemarks.TabIndex = 29;
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Location = new System.Drawing.Point(122, 209);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(150, 21);
            this.cmbPaymentMode.TabIndex = 28;
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(122, 169);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.Size = new System.Drawing.Size(150, 20);
            this.txtOrderAmount.TabIndex = 27;
            // 
            // dtpSlipDate
            // 
            this.dtpSlipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSlipDate.Location = new System.Drawing.Point(122, 129);
            this.dtpSlipDate.Name = "dtpSlipDate";
            this.dtpSlipDate.Size = new System.Drawing.Size(150, 20);
            this.dtpSlipDate.TabIndex = 26;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(122, 89);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(150, 20);
            this.dtpOrderDate.TabIndex = 25;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(122, 49);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 24;
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(122, 9);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(150, 21);
            this.cmbCustomerID.TabIndex = 23;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(418, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 575);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblPaymentMode);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.lblSlipDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.cmbPaymentMode);
            this.Controls.Add(this.txtOrderAmount);
            this.Controls.Add(this.dtpSlipDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Name = "Form1";
            this.Text = "Order Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblOrderAmount;
        private System.Windows.Forms.Label lblSlipDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.DateTimePicker dtpSlipDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}