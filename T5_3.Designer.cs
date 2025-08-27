namespace Windows_Project
{
    partial class T5_3
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
            this.foreground = new System.Windows.Forms.GroupBox();
            this.btn_blue = new System.Windows.Forms.RadioButton();
            this.btn_green = new System.Windows.Forms.RadioButton();
            this.btn_red = new System.Windows.Forms.RadioButton();
            this.background = new System.Windows.Forms.GroupBox();
            this.btn_black = new System.Windows.Forms.RadioButton();
            this.btn_pink = new System.Windows.Forms.RadioButton();
            this.btn_cyan = new System.Windows.Forms.RadioButton();
            this.foreground.SuspendLayout();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreground
            // 
            this.foreground.Controls.Add(this.btn_blue);
            this.foreground.Controls.Add(this.btn_green);
            this.foreground.Controls.Add(this.btn_red);
            this.foreground.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreground.Location = new System.Drawing.Point(97, 81);
            this.foreground.Name = "foreground";
            this.foreground.Size = new System.Drawing.Size(520, 107);
            this.foreground.TabIndex = 0;
            this.foreground.TabStop = false;
            this.foreground.Text = "Foreground Color";
            this.foreground.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_blue
            // 
            this.btn_blue.AutoSize = true;
            this.btn_blue.Location = new System.Drawing.Point(368, 48);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(68, 26);
            this.btn_blue.TabIndex = 2;
            this.btn_blue.TabStop = true;
            this.btn_blue.Text = "Blue";
            this.btn_blue.UseVisualStyleBackColor = true;
            this.btn_blue.CheckedChanged += new System.EventHandler(this.btn_blue_CheckedChanged);
            // 
            // btn_green
            // 
            this.btn_green.AutoSize = true;
            this.btn_green.Location = new System.Drawing.Point(192, 49);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(79, 26);
            this.btn_green.TabIndex = 1;
            this.btn_green.TabStop = true;
            this.btn_green.Text = "Green";
            this.btn_green.UseVisualStyleBackColor = true;
            this.btn_green.CheckedChanged += new System.EventHandler(this.btn_green_CheckedChanged);
            // 
            // btn_red
            // 
            this.btn_red.AutoSize = true;
            this.btn_red.Location = new System.Drawing.Point(27, 50);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(63, 26);
            this.btn_red.TabIndex = 0;
            this.btn_red.TabStop = true;
            this.btn_red.Text = "Red";
            this.btn_red.UseVisualStyleBackColor = true;
            this.btn_red.CheckedChanged += new System.EventHandler(this.btn_red_CheckedChanged);
            // 
            // background
            // 
            this.background.Controls.Add(this.btn_black);
            this.background.Controls.Add(this.btn_pink);
            this.background.Controls.Add(this.btn_cyan);
            this.background.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.background.Location = new System.Drawing.Point(97, 206);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(520, 100);
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            this.background.Text = "Background Color";
            // 
            // btn_black
            // 
            this.btn_black.AutoSize = true;
            this.btn_black.Location = new System.Drawing.Point(368, 50);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(77, 26);
            this.btn_black.TabIndex = 2;
            this.btn_black.TabStop = true;
            this.btn_black.Text = "Black";
            this.btn_black.UseVisualStyleBackColor = true;
            this.btn_black.CheckedChanged += new System.EventHandler(this.btn_black_CheckedChanged);
            // 
            // btn_pink
            // 
            this.btn_pink.AutoSize = true;
            this.btn_pink.Location = new System.Drawing.Point(192, 50);
            this.btn_pink.Name = "btn_pink";
            this.btn_pink.Size = new System.Drawing.Size(66, 26);
            this.btn_pink.TabIndex = 1;
            this.btn_pink.TabStop = true;
            this.btn_pink.Text = "Pink";
            this.btn_pink.UseVisualStyleBackColor = true;
            this.btn_pink.CheckedChanged += new System.EventHandler(this.btn_pink_CheckedChanged);
            // 
            // btn_cyan
            // 
            this.btn_cyan.AutoSize = true;
            this.btn_cyan.Location = new System.Drawing.Point(37, 51);
            this.btn_cyan.Name = "btn_cyan";
            this.btn_cyan.Size = new System.Drawing.Size(71, 26);
            this.btn_cyan.TabIndex = 0;
            this.btn_cyan.TabStop = true;
            this.btn_cyan.Text = "Cyan";
            this.btn_cyan.UseVisualStyleBackColor = true;
            this.btn_cyan.CheckedChanged += new System.EventHandler(this.btn_cyan_CheckedChanged);
            // 
            // T5_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Controls.Add(this.foreground);
            this.Name = "T5_3";
            this.Text = "T5_4";
            this.Load += new System.EventHandler(this.T5_3_Load);
            this.foreground.ResumeLayout(false);
            this.foreground.PerformLayout();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox background;
        private System.Windows.Forms.GroupBox foreground;
        private System.Windows.Forms.RadioButton btn_blue;
        private System.Windows.Forms.RadioButton btn_green;
        private System.Windows.Forms.RadioButton btn_red;
        private System.Windows.Forms.RadioButton btn_cyan;
        private System.Windows.Forms.RadioButton btn_black;
        private System.Windows.Forms.RadioButton btn_pink;
    }
}