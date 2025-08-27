using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Windows_Project
{
    partial class T6_2
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
            lb1 = new ListBox();
            fill = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            display = new Label();
            select = new Label();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.Location = new Point(26, 39);
            lb1.Name = "lb1";
            lb1.ScrollAlwaysVisible = true;
            lb1.Size = new Size(150, 124);
            lb1.TabIndex = 0;
            lb1.SelectedIndexChanged += lb1_SelectedIndexChanged;
            // 
            // fill
            // 
            fill.BackColor = SystemColors.GradientInactiveCaption;
            fill.Location = new Point(235, 39);
            fill.Name = "fill";
            fill.Size = new Size(94, 29);
            fill.TabIndex = 1;
            fill.Text = "Fill";
            fill.UseVisualStyleBackColor = false;
            fill.Click += fill_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(235, 84);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Location = new Point(235, 130);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Location = new Point(26, 201);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Count";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Location = new Point(190, 200);
            button4.Name = "button4";
            button4.Size = new Size(139, 30);
            button4.TabIndex = 5;
            button4.Text = "Remove Item";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // display
            // 
            display.AutoSize = true;
            display.Location = new Point(26, 279);
            display.Name = "display";
            display.Size = new Size(133, 20);
            display.TabIndex = 6;
            display.Text = "Display total items";
            // 
            // select
            // 
            select.AutoSize = true;
            select.Location = new Point(226, 279);
            select.Name = "select";
            select.Size = new Size(103, 20);
            select.TabIndex = 7;
            select.Text = "Your Selection";
            select.Click += select_Click;
            // 
            // T6_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(select);
            Controls.Add(display);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(fill);
            Controls.Add(lb1);
            Name = "T6_2";
            Text = "Lbox";
            Load += T6_2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb1;
        private Button fill;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label display;
        private Label select;
    }
}