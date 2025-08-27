using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Windows_Project
{
    partial class Popup
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
            addtext = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // addtext
            // 
            addtext.Location = new Point(26, 28);
            addtext.Name = "addtext";
            addtext.Size = new Size(125, 27);
            addtext.TabIndex = 0;
            // 
            // submit
            // 
            submit.Location = new Point(42, 72);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 1;
            submit.Text = "Add";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Popup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(addtext);
            Name = "Popup";
            Text = "Popup";
            Load += Popup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addtext;
        private Button submit;
    }
}