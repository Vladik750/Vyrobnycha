namespace Laba1
{
    partial class Form_registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName_input = new System.Windows.Forms.TextBox();
            this.LastName_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Login_input = new System.Windows.Forms.TextBox();
            this.RF_reg_but = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Password_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // FirstName_input
            // 
            this.FirstName_input.Location = new System.Drawing.Point(114, 16);
            this.FirstName_input.Name = "FirstName_input";
            this.FirstName_input.Size = new System.Drawing.Size(100, 20);
            this.FirstName_input.TabIndex = 2;
            // 
            // LastName_input
            // 
            this.LastName_input.Location = new System.Drawing.Point(114, 55);
            this.LastName_input.Name = "LastName_input";
            this.LastName_input.Size = new System.Drawing.Size(100, 20);
            this.LastName_input.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Email_input
            // 
            this.Email_input.Location = new System.Drawing.Point(114, 99);
            this.Email_input.Name = "Email_input";
            this.Email_input.Size = new System.Drawing.Size(100, 20);
            this.Email_input.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login";
            // 
            // Login_input
            // 
            this.Login_input.Location = new System.Drawing.Point(114, 138);
            this.Login_input.Name = "Login_input";
            this.Login_input.Size = new System.Drawing.Size(100, 20);
            this.Login_input.TabIndex = 7;
            // 
            // RF_reg_but
            // 
            this.RF_reg_but.Location = new System.Drawing.Point(114, 223);
            this.RF_reg_but.Name = "RF_reg_but";
            this.RF_reg_but.Size = new System.Drawing.Size(75, 23);
            this.RF_reg_but.TabIndex = 8;
            this.RF_reg_but.Text = "Register";
            this.RF_reg_but.UseVisualStyleBackColor = true;
            this.RF_reg_but.Click += new System.EventHandler(this.RF_reg_but_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // Password_input
            // 
            this.Password_input.Location = new System.Drawing.Point(114, 183);
            this.Password_input.Name = "Password_input";
            this.Password_input.Size = new System.Drawing.Size(100, 20);
            this.Password_input.TabIndex = 10;
            this.Password_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 258);
            this.Controls.Add(this.Password_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RF_reg_but);
            this.Controls.Add(this.Login_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName_input);
            this.Controls.Add(this.FirstName_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form_registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName_input;
        private System.Windows.Forms.TextBox LastName_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Login_input;
        private System.Windows.Forms.Button RF_reg_but;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Password_input;
    }
}