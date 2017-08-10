namespace OnlineRegister
{
    partial class Form1
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
            this.name = new System.Windows.Forms.TextBox();
            this.mn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rno = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sem = new System.Windows.Forms.ComboBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.mob = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(152, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(236, 20);
            this.name.TabIndex = 2;
            // 
            // mn
            // 
            this.mn.Location = new System.Drawing.Point(152, 57);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(236, 20);
            this.mn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // sn
            // 
            this.sn.Location = new System.Drawing.Point(152, 89);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(236, 20);
            this.sn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registration Number";
            // 
            // rno
            // 
            this.rno.Location = new System.Drawing.Point(152, 120);
            this.rno.Name = "rno";
            this.rno.Size = new System.Drawing.Size(236, 20);
            this.rno.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(152, 150);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(236, 20);
            this.email.TabIndex = 9;
            this.email.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Branch";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // branch
            // 
            this.branch.AutoCompleteCustomSource.AddRange(new string[] {
            "IT",
            "CCE",
            "MECH",
            "CSE",
            "AUTO",
            "AERO",
            "BIOTECH"});
            this.branch.FormattingEnabled = true;
            this.branch.Items.AddRange(new object[] {
            "CCE",
            "IT",
            "CS",
            "AUTO",
            "MECH",
            "BT"});
            this.branch.Location = new System.Drawing.Point(152, 180);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(236, 21);
            this.branch.TabIndex = 11;
            this.branch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Semester";
            // 
            // sem
            // 
            this.sem.AllowDrop = true;
            this.sem.AutoCompleteCustomSource.AddRange(new string[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.sem.FormattingEnabled = true;
            this.sem.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.sem.Location = new System.Drawing.Point(152, 216);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(236, 21);
            this.sem.TabIndex = 13;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(152, 255);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 14;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(247, 255);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 15;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gender";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // mob
            // 
            this.mob.Location = new System.Drawing.Point(152, 282);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(236, 20);
            this.mob.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mobile No";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "DOB";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(152, 394);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 21;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 355);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "I want to receive updates and new offers";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 449);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox mn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rno;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox branch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sem;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

