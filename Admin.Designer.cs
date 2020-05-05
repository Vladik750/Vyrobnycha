namespace Laba1
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Admin_log = new System.Windows.Forms.Label();
            this.Admin_pass = new System.Windows.Forms.Label();
            this.Admin_email = new System.Windows.Forms.Label();
            this.Admin_first = new System.Windows.Forms.Label();
            this.Admin_last = new System.Windows.Forms.Label();
            this.Ad_first_input = new System.Windows.Forms.TextBox();
            this.Ad_last_input = new System.Windows.Forms.TextBox();
            this.Ad_email_input = new System.Windows.Forms.TextBox();
            this.Ad_log_input = new System.Windows.Forms.TextBox();
            this.Ad_pass_input = new System.Windows.Forms.TextBox();
            this.Create_but = new System.Windows.Forms.Button();
            this.Ban_but = new System.Windows.Forms.Button();
            this.UnBan_but = new System.Windows.Forms.Button();
            this.Logout_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // Admin_log
            // 
            this.Admin_log.AutoSize = true;
            this.Admin_log.Location = new System.Drawing.Point(365, 233);
            this.Admin_log.Name = "Admin_log";
            this.Admin_log.Size = new System.Drawing.Size(33, 13);
            this.Admin_log.TabIndex = 1;
            this.Admin_log.Text = "Login";
            // 
            // Admin_pass
            // 
            this.Admin_pass.AutoSize = true;
            this.Admin_pass.Location = new System.Drawing.Point(462, 233);
            this.Admin_pass.Name = "Admin_pass";
            this.Admin_pass.Size = new System.Drawing.Size(53, 13);
            this.Admin_pass.TabIndex = 2;
            this.Admin_pass.Text = "Password";
            // 
            // Admin_email
            // 
            this.Admin_email.AutoSize = true;
            this.Admin_email.Location = new System.Drawing.Point(259, 233);
            this.Admin_email.Name = "Admin_email";
            this.Admin_email.Size = new System.Drawing.Size(32, 13);
            this.Admin_email.TabIndex = 3;
            this.Admin_email.Text = "Email";
            this.Admin_email.Click += new System.EventHandler(this.Admin_email_Click);
            // 
            // Admin_first
            // 
            this.Admin_first.AutoSize = true;
            this.Admin_first.Location = new System.Drawing.Point(28, 233);
            this.Admin_first.Name = "Admin_first";
            this.Admin_first.Size = new System.Drawing.Size(57, 13);
            this.Admin_first.TabIndex = 4;
            this.Admin_first.Text = "First Name";
            // 
            // Admin_last
            // 
            this.Admin_last.AutoSize = true;
            this.Admin_last.Location = new System.Drawing.Point(138, 233);
            this.Admin_last.Name = "Admin_last";
            this.Admin_last.Size = new System.Drawing.Size(58, 13);
            this.Admin_last.TabIndex = 5;
            this.Admin_last.Text = "Last Name";
            // 
            // Ad_first_input
            // 
            this.Ad_first_input.Location = new System.Drawing.Point(11, 249);
            this.Ad_first_input.Name = "Ad_first_input";
            this.Ad_first_input.Size = new System.Drawing.Size(100, 20);
            this.Ad_first_input.TabIndex = 6;
            // 
            // Ad_last_input
            // 
            this.Ad_last_input.Location = new System.Drawing.Point(117, 249);
            this.Ad_last_input.Name = "Ad_last_input";
            this.Ad_last_input.Size = new System.Drawing.Size(100, 20);
            this.Ad_last_input.TabIndex = 7;
            // 
            // Ad_email_input
            // 
            this.Ad_email_input.Location = new System.Drawing.Point(223, 249);
            this.Ad_email_input.Name = "Ad_email_input";
            this.Ad_email_input.Size = new System.Drawing.Size(100, 20);
            this.Ad_email_input.TabIndex = 8;
            // 
            // Ad_log_input
            // 
            this.Ad_log_input.Location = new System.Drawing.Point(329, 249);
            this.Ad_log_input.Name = "Ad_log_input";
            this.Ad_log_input.Size = new System.Drawing.Size(100, 20);
            this.Ad_log_input.TabIndex = 9;
            // 
            // Ad_pass_input
            // 
            this.Ad_pass_input.Location = new System.Drawing.Point(436, 249);
            this.Ad_pass_input.Name = "Ad_pass_input";
            this.Ad_pass_input.Size = new System.Drawing.Size(100, 20);
            this.Ad_pass_input.TabIndex = 10;
            // 
            // Create_but
            // 
            this.Create_but.Location = new System.Drawing.Point(11, 299);
            this.Create_but.Name = "Create_but";
            this.Create_but.Size = new System.Drawing.Size(75, 23);
            this.Create_but.TabIndex = 11;
            this.Create_but.Text = "Create";
            this.Create_but.UseVisualStyleBackColor = true;
            this.Create_but.Click += new System.EventHandler(this.Create_but_Click);
            // 
            // Ban_but
            // 
            this.Ban_but.Location = new System.Drawing.Point(13, 329);
            this.Ban_but.Name = "Ban_but";
            this.Ban_but.Size = new System.Drawing.Size(75, 23);
            this.Ban_but.TabIndex = 12;
            this.Ban_but.Text = "Ban";
            this.Ban_but.UseVisualStyleBackColor = true;
            // 
            // UnBan_but
            // 
            this.UnBan_but.Location = new System.Drawing.Point(13, 359);
            this.UnBan_but.Name = "UnBan_but";
            this.UnBan_but.Size = new System.Drawing.Size(75, 23);
            this.UnBan_but.TabIndex = 13;
            this.UnBan_but.Text = "UnBan";
            this.UnBan_but.UseVisualStyleBackColor = true;
            // 
            // Logout_but
            // 
            this.Logout_but.Location = new System.Drawing.Point(575, 358);
            this.Logout_but.Name = "Logout_but";
            this.Logout_but.Size = new System.Drawing.Size(75, 23);
            this.Logout_but.TabIndex = 14;
            this.Logout_but.Text = "Log Out";
            this.Logout_but.UseVisualStyleBackColor = true;
            this.Logout_but.Click += new System.EventHandler(this.Logout_but_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 385);
            this.Controls.Add(this.Logout_but);
            this.Controls.Add(this.UnBan_but);
            this.Controls.Add(this.Ban_but);
            this.Controls.Add(this.Create_but);
            this.Controls.Add(this.Ad_pass_input);
            this.Controls.Add(this.Ad_log_input);
            this.Controls.Add(this.Ad_email_input);
            this.Controls.Add(this.Ad_last_input);
            this.Controls.Add(this.Ad_first_input);
            this.Controls.Add(this.Admin_last);
            this.Controls.Add(this.Admin_first);
            this.Controls.Add(this.Admin_email);
            this.Controls.Add(this.Admin_pass);
            this.Controls.Add(this.Admin_log);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Admin_log;
        private System.Windows.Forms.Label Admin_pass;
        private System.Windows.Forms.Label Admin_email;
        private System.Windows.Forms.Label Admin_first;
        private System.Windows.Forms.Label Admin_last;
        private System.Windows.Forms.TextBox Ad_first_input;
        private System.Windows.Forms.TextBox Ad_last_input;
        private System.Windows.Forms.TextBox Ad_email_input;
        private System.Windows.Forms.TextBox Ad_log_input;
        private System.Windows.Forms.TextBox Ad_pass_input;
        private System.Windows.Forms.Button Create_but;
        private System.Windows.Forms.Button Ban_but;
        private System.Windows.Forms.Button UnBan_but;
        private System.Windows.Forms.Button Logout_but;
    }
}