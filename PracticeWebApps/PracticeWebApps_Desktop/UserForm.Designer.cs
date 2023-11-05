namespace PracticeWebApps_Desktop
{
    partial class UserForm
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
            lblPhone = new Label();
            lblEmail = new Label();
            lblName = new Label();
            btnEditUser = new Button();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(428, 296);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Red;
            lblPhone.ForeColor = SystemColors.ButtonFace;
            lblPhone.Location = new Point(80, 167);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 20;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Red;
            lblEmail.ForeColor = SystemColors.ButtonFace;
            lblEmail.Location = new Point(83, 105);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Red;
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(80, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 18;
            lblName.Text = "Name";
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(83, 253);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(149, 38);
            btnEditUser.TabIndex = 17;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(83, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(315, 27);
            txtPhone.TabIndex = 14;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 27);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 27);
            txtName.TabIndex = 12;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(247, 253);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(151, 38);
            btnDeleteUser.TabIndex = 23;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(515, 349);
            Controls.Add(btnDeleteUser);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(btnEditUser);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblName;
        private Button btnEditUser;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnDeleteUser;
    }
}