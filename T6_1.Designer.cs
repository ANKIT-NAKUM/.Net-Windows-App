namespace Windows_Project
{
    partial class T6_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.submitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.chkWebsite = new System.Windows.Forms.CheckBox();
            this.chkFriends = new System.Windows.Forms.CheckBox();
            this.chkNewspaper = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soiOther = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.Black;
            this.gender.Location = new System.Drawing.Point(165, 90);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(82, 24);
            this.gender.TabIndex = 4;
            this.gender.Text = "Gender :";
            // 
            // name
            // 
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(297, 40);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(275, 22);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.Black;
            this.male.Location = new System.Drawing.Point(297, 90);
            this.male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(64, 23);
            this.male.TabIndex = 9;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.Black;
            this.female.Location = new System.Drawing.Point(396, 90);
            this.female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(80, 23);
            this.female.TabIndex = 10;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(305, 330);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(121, 35);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOthers);
            this.groupBox1.Controls.Add(this.chkWebsite);
            this.groupBox1.Controls.Add(this.chkFriends);
            this.groupBox1.Controls.Add(this.chkNewspaper);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(170, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(402, 118);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source of Imformation";
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.ForeColor = System.Drawing.Color.Black;
            this.chkOthers.Location = new System.Drawing.Point(203, 70);
            this.chkOthers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(89, 28);
            this.chkOthers.TabIndex = 3;
            this.chkOthers.Text = "Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            // 
            // chkWebsite
            // 
            this.chkWebsite.AutoSize = true;
            this.chkWebsite.ForeColor = System.Drawing.Color.Black;
            this.chkWebsite.Location = new System.Drawing.Point(56, 70);
            this.chkWebsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkWebsite.Name = "chkWebsite";
            this.chkWebsite.Size = new System.Drawing.Size(101, 28);
            this.chkWebsite.TabIndex = 2;
            this.chkWebsite.Text = "Website";
            this.chkWebsite.UseVisualStyleBackColor = true;
            // 
            // chkFriends
            // 
            this.chkFriends.AutoSize = true;
            this.chkFriends.ForeColor = System.Drawing.Color.Black;
            this.chkFriends.Location = new System.Drawing.Point(203, 40);
            this.chkFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFriends.Name = "chkFriends";
            this.chkFriends.Size = new System.Drawing.Size(93, 28);
            this.chkFriends.TabIndex = 1;
            this.chkFriends.Text = "Friends";
            this.chkFriends.UseVisualStyleBackColor = true;
            // 
            // chkNewspaper
            // 
            this.chkNewspaper.AutoSize = true;
            this.chkNewspaper.ForeColor = System.Drawing.Color.Black;
            this.chkNewspaper.Location = new System.Drawing.Point(56, 40);
            this.chkNewspaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNewspaper.Name = "chkNewspaper";
            this.chkNewspaper.Size = new System.Drawing.Size(132, 28);
            this.chkNewspaper.TabIndex = 0;
            this.chkNewspaper.Text = "News Paper";
            this.chkNewspaper.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(165, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "If other, Specify : ";
            // 
            // soiOther
            // 
            this.soiOther.ForeColor = System.Drawing.Color.Black;
            this.soiOther.Location = new System.Drawing.Point(356, 280);
            this.soiOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soiOther.Name = "soiOther";
            this.soiOther.Size = new System.Drawing.Size(216, 22);
            this.soiOther.TabIndex = 15;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Black;
            this.output.Location = new System.Drawing.Point(165, 387);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 24);
            this.output.TabIndex = 16;
            // 
            // T6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(808, 441);
            this.Controls.Add(this.output);
            this.Controls.Add(this.soiOther);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "T6_1";
            this.Text = "Customer Feedback";
            this.Load += new System.EventHandler(this.Window4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.CheckBox chkWebsite;
        private System.Windows.Forms.CheckBox chkFriends;
        private System.Windows.Forms.CheckBox chkNewspaper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soiOther;
        private System.Windows.Forms.Label output;
    }
}