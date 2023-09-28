namespace PracticeWebApps_Desktop
{
    partial class MainForm
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
            btnAddMovie = new Button();
            btnCheckMovie = new Button();
            btnAddUser = new Button();
            btnCheckUser = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(104, 56);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(158, 89);
            btnAddMovie.TabIndex = 0;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnCheckMovie
            // 
            btnCheckMovie.Location = new Point(334, 56);
            btnCheckMovie.Name = "btnCheckMovie";
            btnCheckMovie.Size = new Size(158, 89);
            btnCheckMovie.TabIndex = 1;
            btnCheckMovie.Text = "Check Movie";
            btnCheckMovie.UseVisualStyleBackColor = true;
            btnCheckMovie.Click += btnCheckMovie_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(104, 186);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(158, 89);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnCheckUser
            // 
            btnCheckUser.Location = new Point(334, 186);
            btnCheckUser.Name = "btnCheckUser";
            btnCheckUser.Size = new Size(158, 89);
            btnCheckUser.TabIndex = 3;
            btnCheckUser.Text = "Check User";
            btnCheckUser.UseVisualStyleBackColor = true;
            btnCheckUser.Click += btnCheckUser_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HotTrack;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(459, 277);
            dataGridView1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(606, 356);
            Controls.Add(btnCheckUser);
            Controls.Add(btnAddUser);
            Controls.Add(btnCheckMovie);
            Controls.Add(btnAddMovie);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddMovie;
        private Button btnCheckMovie;
        private Button btnAddUser;
        private Button btnCheckUser;
        private DataGridView dataGridView1;
    }
}