namespace PracticeWebApps_Desktop
{
    partial class CheckUserForm
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
            lbUsers = new ListBox();
            txtSearchName = new TextBox();
            rbName = new RadioButton();
            rbEmail = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(816, 435);
            dataGridView1.TabIndex = 1;
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 20;
            lbUsers.Location = new Point(83, 53);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(621, 324);
            lbUsers.TabIndex = 2;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(83, 409);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(156, 27);
            txtSearchName.TabIndex = 3;
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.BackColor = Color.Red;
            rbName.ForeColor = SystemColors.ButtonFace;
            rbName.Location = new Point(309, 412);
            rbName.Name = "rbName";
            rbName.Size = new Size(70, 24);
            rbName.TabIndex = 4;
            rbName.TabStop = true;
            rbName.Text = "Name";
            rbName.UseVisualStyleBackColor = false;
            rbName.CheckedChanged += rbName_CheckedChanged;
            // 
            // rbEmail
            // 
            rbEmail.AutoSize = true;
            rbEmail.BackColor = Color.Red;
            rbEmail.ForeColor = SystemColors.ButtonFace;
            rbEmail.Location = new Point(423, 412);
            rbEmail.Name = "rbEmail";
            rbEmail.Size = new Size(67, 24);
            rbEmail.TabIndex = 5;
            rbEmail.TabStop = true;
            rbEmail.Text = "Email";
            rbEmail.UseVisualStyleBackColor = false;
            rbEmail.CheckedChanged += rbEmail_CheckedChanged;
            // 
            // CheckUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(934, 501);
            Controls.Add(rbEmail);
            Controls.Add(rbName);
            Controls.Add(txtSearchName);
            Controls.Add(lbUsers);
            Controls.Add(dataGridView1);
            Name = "CheckUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckUserForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ListBox lbUsers;
        private TextBox txtSearchName;
        private RadioButton rbName;
        private RadioButton rbEmail;
    }
}