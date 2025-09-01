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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.news = new System.Windows.Forms.CheckBox();
            this.friends = new System.Windows.Forms.CheckBox();
            this.oth = new System.Windows.Forms.CheckBox();
            this.website = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(121, 25);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 22);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(121, 71);
            this.male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(58, 20);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(201, 70);
            this.female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(74, 20);
            this.female.TabIndex = 4;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // news
            // 
            this.news.AutoSize = true;
            this.news.ForeColor = System.Drawing.SystemColors.Desktop;
            this.news.Location = new System.Drawing.Point(15, 29);
            this.news.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(103, 20);
            this.news.TabIndex = 6;
            this.news.Text = "News Paper";
            this.news.UseVisualStyleBackColor = true;
            this.news.CheckedChanged += new System.EventHandler(this.news_CheckedChanged);
            // 
            // friends
            // 
            this.friends.AutoSize = true;
            this.friends.ForeColor = System.Drawing.SystemColors.Desktop;
            this.friends.Location = new System.Drawing.Point(152, 29);
            this.friends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(74, 20);
            this.friends.TabIndex = 7;
            this.friends.Text = "Friends";
            this.friends.UseVisualStyleBackColor = true;
            // 
            // oth
            // 
            this.oth.AutoSize = true;
            this.oth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.oth.Location = new System.Drawing.Point(152, 63);
            this.oth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oth.Name = "oth";
            this.oth.Size = new System.Drawing.Size(68, 20);
            this.oth.TabIndex = 9;
            this.oth.Text = "Others";
            this.oth.UseVisualStyleBackColor = true;
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.ForeColor = System.Drawing.SystemColors.Desktop;
            this.website.Location = new System.Drawing.Point(15, 63);
            this.website.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(79, 20);
            this.website.TabIndex = 8;
            this.website.Text = "Website";
            this.website.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.AutoEllipsis = true;
            this.submit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submit.Location = new System.Drawing.Point(90, 269);
            this.submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(143, 39);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.display.Location = new System.Drawing.Point(44, 327);
            this.display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(0, 28);
            this.display.TabIndex = 11;
            this.display.Visible = false;
            // 
            // spec
            // 
            this.spec.Location = new System.Drawing.Point(203, 225);
            this.spec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(125, 22);
            this.spec.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "If other, Specify";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.news);
            this.groupBox1.Controls.Add(this.friends);
            this.groupBox1.Controls.Add(this.website);
            this.groupBox1.Controls.Add(this.oth);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(34, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Of Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // T6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.display);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "T6_1";
            this.Text = "Customer Feedback";
            this.Load += new System.EventHandler(this.T6_1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox name;
        private Label label2;
        private RadioButton male;
        private RadioButton female;
        private CheckBox news;
        private CheckBox friends;
        private CheckBox oth;
        private CheckBox website;
        private Button submit;
        private Label display;
        private TextBox spec;
        private Label label4;
        private GroupBox groupBox1;
    }
}
