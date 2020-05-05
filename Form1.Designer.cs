namespace Laba1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_input = new System.Windows.Forms.TextBox();
            this.President_input = new System.Windows.Forms.TextBox();
            this.Square_input = new System.Windows.Forms.TextBox();
            this.Amount_input = new System.Windows.Forms.TextBox();
            this.Time_zone_input = new System.Windows.Forms.TextBox();
            this.Add_but = new System.Windows.Forms.Button();
            this.Edit_but = new System.Windows.Forms.Button();
            this.Delete_but = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(613, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "President";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Square";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time zone";
            // 
            // Name_input
            // 
            this.Name_input.Location = new System.Drawing.Point(15, 361);
            this.Name_input.Name = "Name_input";
            this.Name_input.Size = new System.Drawing.Size(100, 20);
            this.Name_input.TabIndex = 6;
            // 
            // President_input
            // 
            this.President_input.Location = new System.Drawing.Point(121, 361);
            this.President_input.Name = "President_input";
            this.President_input.Size = new System.Drawing.Size(100, 20);
            this.President_input.TabIndex = 7;
            // 
            // Square_input
            // 
            this.Square_input.Location = new System.Drawing.Point(227, 361);
            this.Square_input.Name = "Square_input";
            this.Square_input.Size = new System.Drawing.Size(100, 20);
            this.Square_input.TabIndex = 8;
            // 
            // Amount_input
            // 
            this.Amount_input.Location = new System.Drawing.Point(335, 361);
            this.Amount_input.Name = "Amount_input";
            this.Amount_input.Size = new System.Drawing.Size(100, 20);
            this.Amount_input.TabIndex = 9;
            // 
            // Time_zone_input
            // 
            this.Time_zone_input.Location = new System.Drawing.Point(441, 361);
            this.Time_zone_input.Name = "Time_zone_input";
            this.Time_zone_input.Size = new System.Drawing.Size(100, 20);
            this.Time_zone_input.TabIndex = 10;
            // 
            // Add_but
            // 
            this.Add_but.Location = new System.Drawing.Point(14, 407);
            this.Add_but.Name = "Add_but";
            this.Add_but.Size = new System.Drawing.Size(75, 23);
            this.Add_but.TabIndex = 11;
            this.Add_but.Text = "Add";
            this.Add_but.UseVisualStyleBackColor = true;
            this.Add_but.Click += new System.EventHandler(this.Add_but_Click);
            // 
            // Edit_but
            // 
            this.Edit_but.Location = new System.Drawing.Point(95, 407);
            this.Edit_but.Name = "Edit_but";
            this.Edit_but.Size = new System.Drawing.Size(75, 23);
            this.Edit_but.TabIndex = 12;
            this.Edit_but.Text = "Edit";
            this.Edit_but.UseVisualStyleBackColor = true;
            this.Edit_but.Click += new System.EventHandler(this.Edit_but_Click);
            // 
            // Delete_but
            // 
            this.Delete_but.Location = new System.Drawing.Point(471, 407);
            this.Delete_but.Name = "Delete_but";
            this.Delete_but.Size = new System.Drawing.Size(75, 23);
            this.Delete_but.TabIndex = 13;
            this.Delete_but.Text = "Delete";
            this.Delete_but.UseVisualStyleBackColor = true;
            this.Delete_but.Click += new System.EventHandler(this.Delete_but_Click);
            // 
            // Logout_but
            // 
            this.Logout_but.Location = new System.Drawing.Point(552, 407);
            this.Logout_but.Name = "Logout_but";
            this.Logout_but.Size = new System.Drawing.Size(75, 23);
            this.Logout_but.TabIndex = 14;
            this.Logout_but.Text = "Log Out";
            this.Logout_but.UseVisualStyleBackColor = true;
            this.Logout_but.Click += new System.EventHandler(this.Logout_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 438);
            this.Controls.Add(this.Logout_but);
            this.Controls.Add(this.Delete_but);
            this.Controls.Add(this.Edit_but);
            this.Controls.Add(this.Add_but);
            this.Controls.Add(this.Time_zone_input);
            this.Controls.Add(this.Amount_input);
            this.Controls.Add(this.Square_input);
            this.Controls.Add(this.President_input);
            this.Controls.Add(this.Name_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_input;
        private System.Windows.Forms.TextBox President_input;
        private System.Windows.Forms.TextBox Square_input;
        private System.Windows.Forms.TextBox Amount_input;
        private System.Windows.Forms.TextBox Time_zone_input;
        private System.Windows.Forms.Button Add_but;
        private System.Windows.Forms.Button Edit_but;
        private System.Windows.Forms.Button Delete_but;
        private System.Windows.Forms.Button Logout_but;
    }
}

