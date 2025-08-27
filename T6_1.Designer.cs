using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Project
{
    partial class T6_1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            name = new TextBox();
            label2 = new Label();
            male = new RadioButton();
            female = new RadioButton();
            label3 = new Label();
            news = new CheckBox();
            friends = new CheckBox();
            oth = new CheckBox();
            website = new CheckBox();
            submit = new Button();
            display = new Label();
            spec = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // name
            // 
            name.Location = new Point(151, 39);
            name.Name = "name";
            name.Size = new Size(155, 31);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 105);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(151, 111);
            male.Name = "male";
            male.Size = new Size(75, 29);
            male.TabIndex = 3;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(251, 110);
            female.Name = "female";
            female.Size = new Size(93, 29);
            female.TabIndex = 4;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(55, 165);
            label3.Name = "label3";
            label3.Size = new Size(257, 32);
            label3.TabIndex = 5;
            label3.Text = "Source Of Information";
            // 
            // news
            // 
            news.AutoSize = true;
            news.Location = new Point(55, 226);
            news.Name = "news";
            news.Size = new Size(130, 29);
            news.TabIndex = 6;
            news.Text = "News Paper";
            news.UseVisualStyleBackColor = true;
            // 
            // friends
            // 
            friends.AutoSize = true;
            friends.Location = new Point(199, 226);
            friends.Name = "friends";
            friends.Size = new Size(95, 29);
            friends.TabIndex = 7;
            friends.Text = "Friends";
            friends.UseVisualStyleBackColor = true;
            // 
            // website
            // 
            website.AutoSize = true;
            website.Location = new Point(55, 279);
            website.Name = "website";
            website.Size = new Size(101, 29);
            website.TabIndex = 8;
            website.Text = "Website";
            website.UseVisualStyleBackColor = true;
            // 
            // oth
            // 
            oth.AutoSize = true;
            oth.Location = new Point(199, 279);
            oth.Name = "oth";
            oth.Size = new Size(91, 29);
            oth.TabIndex = 9;
            oth.Text = "Others";
            oth.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            submit.AutoEllipsis = true;
            submit.BackColor = SystemColors.ButtonHighlight;
            submit.Cursor = Cursors.Hand;
            submit.ForeColor = SystemColors.ActiveCaptionText;
            submit.Location = new Point(112, 400);
            submit.Name = "submit";
            submit.Size = new Size(179, 61);
            submit.TabIndex = 10;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += new EventHandler(submit_Click);
            // 
            // display
            // 
            display.AutoSize = true;
            display.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            display.Location = new Point(55, 490);
            display.Name = "display";
            display.Size = new Size(0, 32);
            display.TabIndex = 11;
            display.Visible = false;
            // 
            // spec
            // 
            spec.Location = new Point(254, 331);
            spec.Name = "spec";
            spec.Size = new Size(155, 31);
            spec.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(54, 330);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 12;
            label4.Text = "If other, Specify";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 669);
            Controls.Add(spec);
            Controls.Add(label4);
            Controls.Add(display);
            Controls.Add(submit);
            Controls.Add(oth);
            Controls.Add(website);
            Controls.Add(friends);
            Controls.Add(news);
            Controls.Add(label3);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            //Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Label label2;
        private RadioButton male;
        private RadioButton female;
        private Label label3;
        private CheckBox news;
        private CheckBox friends;
        private CheckBox oth;
        private CheckBox website;
        private Button submit;
        private Label display;
        private TextBox spec;
        private Label label4;
    }
}
