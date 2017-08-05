namespace BankingApplication
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
            this.name = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(30, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Username";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(118, 47);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(132, 20);
            this.name1.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(33, 85);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(79, 148);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(107, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(79, 196);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 5;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(118, 85);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(132, 20);
            this.password1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.MaskedTextBox password1;
    }
}

