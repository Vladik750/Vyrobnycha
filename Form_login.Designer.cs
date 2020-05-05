namespace Laba1
{
    partial class Form_login
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
            this.Login_input = new System.Windows.Forms.TextBox();
            this.Password_input = new System.Windows.Forms.TextBox();
            this.LF_reg_but = new System.Windows.Forms.Button();
            this.login_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Login_input
            // 
            this.Login_input.Location = new System.Drawing.Point(142, 17);
            this.Login_input.Name = "Login_input";
            this.Login_input.Size = new System.Drawing.Size(100, 20);
            this.Login_input.TabIndex = 2;
            // 
            // Password_input
            // 
            this.Password_input.Location = new System.Drawing.Point(142, 66);
            this.Password_input.Name = "Password_input";
            this.Password_input.Size = new System.Drawing.Size(100, 20);
            this.Password_input.TabIndex = 3;
            // 
            // LF_reg_but
            // 
            this.LF_reg_but.Location = new System.Drawing.Point(18, 118);
            this.LF_reg_but.Name = "LF_reg_but";
            this.LF_reg_but.Size = new System.Drawing.Size(75, 23);
            this.LF_reg_but.TabIndex = 4;
            this.LF_reg_but.Text = "Register";
            this.LF_reg_but.UseVisualStyleBackColor = true;
            this.LF_reg_but.Click += new System.EventHandler(this.LF_reg_but_Click);
            // 
            // login_but
            // 
            this.login_but.Location = new System.Drawing.Point(142, 117);
            this.login_but.Name = "login_but";
            this.login_but.Size = new System.Drawing.Size(75, 23);
            this.login_but.TabIndex = 5;
            this.login_but.Text = "LogIn";
            this.login_but.UseVisualStyleBackColor = true;
            this.login_but.Click += new System.EventHandler(this.login_but_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 223);
            this.Controls.Add(this.login_but);
            this.Controls.Add(this.LF_reg_but);
            this.Controls.Add(this.Password_input);
            this.Controls.Add(this.Login_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_login";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_input;
        private System.Windows.Forms.TextBox Password_input;
        private System.Windows.Forms.Button LF_reg_but;
        private System.Windows.Forms.Button login_but;
    }
}