namespace PracticeWebApps_Desktop
{
    partial class LogInForm
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
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtPassword.PasswordChar = '*';
            btnLogIn = new Button();
            lblName = new Label();
            lblPAssword = new Label();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(447, 321);
            dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 184);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 27);
            txtName.TabIndex = 1;
            txtName.Text = "Michael";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(135, 254);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Michael12345";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(181, 301);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(147, 29);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click_1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Red;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(135, 161);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblPAssword
            // 
            lblPAssword.AutoSize = true;
            lblPAssword.BackColor = Color.Red;
            lblPAssword.ForeColor = Color.White;
            lblPAssword.Location = new Point(135, 231);
            lblPAssword.Name = "lblPAssword";
            lblPAssword.Size = new Size(70, 20);
            lblPAssword.TabIndex = 5;
            lblPAssword.Text = "Password";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Red;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(70, 51);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(385, 46);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome to EuroMovies";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(518, 389);
            Controls.Add(lblWelcome);
            Controls.Add(lblPAssword);
            Controls.Add(lblName);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Label lblName;
        private Label lblPAssword;
        private Label lblWelcome;
    }
}