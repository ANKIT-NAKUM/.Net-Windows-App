namespace Windows_Project
{
    partial class Sum
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
            this.num1lbl = new System.Windows.Forms.Label();
            this.num2lbl = new System.Windows.Forms.Label();
            this.num1text = new System.Windows.Forms.TextBox();
            this.num2text = new System.Windows.Forms.TextBox();
            this.sumbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1lbl
            // 
            this.num1lbl.AutoSize = true;
            this.num1lbl.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1lbl.Location = new System.Drawing.Point(44, 50);
            this.num1lbl.Name = "num1lbl";
            this.num1lbl.Size = new System.Drawing.Size(92, 15);
            this.num1lbl.TabIndex = 0;
            this.num1lbl.Text = "Enter Number 1:";
            this.num1lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2lbl
            // 
            this.num2lbl.AutoSize = true;
            this.num2lbl.Location = new System.Drawing.Point(44, 104);
            this.num2lbl.Name = "num2lbl";
            this.num2lbl.Size = new System.Drawing.Size(102, 16);
            this.num2lbl.TabIndex = 1;
            this.num2lbl.Text = "Enter Number 2:";
            // 
            // num1text
            // 
            this.num1text.Location = new System.Drawing.Point(202, 50);
            this.num1text.Name = "num1text";
            this.num1text.Size = new System.Drawing.Size(100, 22);
            this.num1text.TabIndex = 2;
            // 
            // num2text
            // 
            this.num2text.Location = new System.Drawing.Point(202, 101);
            this.num2text.Name = "num2text";
            this.num2text.Size = new System.Drawing.Size(100, 22);
            this.num2text.TabIndex = 3;
            this.num2text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sumbtn
            // 
            this.sumbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumbtn.Location = new System.Drawing.Point(71, 162);
            this.sumbtn.Name = "sumbtn";
            this.sumbtn.Size = new System.Drawing.Size(75, 34);
            this.sumbtn.TabIndex = 4;
            this.sumbtn.Text = "+";
            this.sumbtn.UseVisualStyleBackColor = true;
            this.sumbtn.Click += new System.EventHandler(this.sumbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(268, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(363, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sumbtn);
            this.Controls.Add(this.num2text);
            this.Controls.Add(this.num1text);
            this.Controls.Add(this.num2lbl);
            this.Controls.Add(this.num1lbl);
            this.Name = "Sum";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1lbl;
        private System.Windows.Forms.Label num2lbl;
        private System.Windows.Forms.TextBox num1text;
        private System.Windows.Forms.TextBox num2text;
        private System.Windows.Forms.Button sumbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}