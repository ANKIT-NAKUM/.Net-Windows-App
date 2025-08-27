namespace Windows_Project
{
    partial class T5_1
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_calcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(43, 26);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_calcel
            // 
            this.btn_calcel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcel.Location = new System.Drawing.Point(34, 72);
            this.btn_calcel.Name = "btn_calcel";
            this.btn_calcel.Size = new System.Drawing.Size(133, 31);
            this.btn_calcel.TabIndex = 1;
            this.btn_calcel.Text = "CANCEL";
            this.btn_calcel.UseVisualStyleBackColor = true;
            this.btn_calcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // T5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcel);
            this.Controls.Add(this.btn_ok);
            this.Name = "T5_1";
            this.Text = "T5_1";
            this.Load += new System.EventHandler(this.T5_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_calcel;
    }
}