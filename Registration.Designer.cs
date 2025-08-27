namespace Windows_Project
{
    partial class Registration
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
            this.name = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.name_text = new System.Windows.Forms.TextBox();
            this.pwd_text = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.list_branch = new System.Windows.Forms.ListBox();
            this.register = new System.Windows.Forms.Button();
            this.comboxcity = new System.Windows.Forms.ComboBox();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(56, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 23);
            this.name.TabIndex = 0;
            this.name.Text = "Name :";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.ForeColor = System.Drawing.Color.Transparent;
            this.branch.Location = new System.Drawing.Point(57, 155);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(82, 23);
            this.branch.TabIndex = 1;
            this.branch.Text = "Branch :";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.Transparent;
            this.city.Location = new System.Drawing.Point(329, 155);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(54, 22);
            this.city.TabIndex = 2;
            this.city.Text = "City :";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Transparent;
            this.password.Location = new System.Drawing.Point(56, 113);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 23);
            this.password.TabIndex = 3;
            this.password.Text = "Password :";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.Transparent;
            this.male.Location = new System.Drawing.Point(171, 266);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(72, 26);
            this.male.TabIndex = 4;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.Transparent;
            this.female.Location = new System.Drawing.Point(275, 266);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(89, 26);
            this.female.TabIndex = 5;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // name_text
            // 
            this.name_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.ForeColor = System.Drawing.Color.Black;
            this.name_text.Location = new System.Drawing.Point(171, 60);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(177, 30);
            this.name_text.TabIndex = 7;
            // 
            // pwd_text
            // 
            this.pwd_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwd_text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_text.ForeColor = System.Drawing.Color.Black;
            this.pwd_text.Location = new System.Drawing.Point(171, 110);
            this.pwd_text.Name = "pwd_text";
            this.pwd_text.PasswordChar = '*';
            this.pwd_text.Size = new System.Drawing.Size(177, 30);
            this.pwd_text.TabIndex = 9;
            // 
            // list_branch
            // 
            this.list_branch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_branch.ForeColor = System.Drawing.Color.Black;
            this.list_branch.FormattingEnabled = true;
            this.list_branch.ItemHeight = 22;
            this.list_branch.Items.AddRange(new object[] {
            "BTECH-CE",
            "BTECH-IE",
            "BTECH-CIVIL",
            "BTECH-CS"});
            this.list_branch.Location = new System.Drawing.Point(171, 155);
            this.list_branch.Name = "list_branch";
            this.list_branch.Size = new System.Drawing.Size(120, 92);
            this.list_branch.TabIndex = 10;
            this.list_branch.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.Window;
            this.register.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(36, 322);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(173, 49);
            this.register.TabIndex = 12;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // comboxcity
            // 
            this.comboxcity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboxcity.FormattingEnabled = true;
            this.comboxcity.Items.AddRange(new object[] {
            "RAJKOT",
            "SURAT",
            "AMRALI",
            "MORBI"});
            this.comboxcity.Location = new System.Drawing.Point(398, 157);
            this.comboxcity.Name = "comboxcity";
            this.comboxcity.Size = new System.Drawing.Size(121, 24);
            this.comboxcity.TabIndex = 13;
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gender_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.gender_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gender_lbl.Location = new System.Drawing.Point(65, 269);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(74, 23);
            this.gender_lbl.TabIndex = 14;
            this.gender_lbl.Text = "Gender";
            this.gender_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.Window;
            this.update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(240, 322);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(173, 49);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.ForeColor = System.Drawing.Color.Black;
            this.id_txt.Location = new System.Drawing.Point(171, 12);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(177, 30);
            this.id_txt.TabIndex = 16;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Transparent;
            this.id.Location = new System.Drawing.Point(57, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(39, 23);
            this.id.TabIndex = 17;
            this.id.Text = "Id :";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Window;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(444, 322);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(173, 49);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.id);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.update);
            this.Controls.Add(this.gender_lbl);
            this.Controls.Add(this.comboxcity);
            this.Controls.Add(this.register);
            this.Controls.Add(this.list_branch);
            this.Controls.Add(this.pwd_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.password);
            this.Controls.Add(this.city);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.name);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox pwd_text;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox list_branch;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.ComboBox comboxcity;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button Delete;
    }
}