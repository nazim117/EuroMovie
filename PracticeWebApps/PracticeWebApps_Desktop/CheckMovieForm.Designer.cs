namespace PracticeWebApps_Desktop
{
    partial class CheckMovieForm
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
            lbMovies = new ListBox();
            txtNameSearch = new TextBox();
            lblSortBy = new Label();
            rbName = new RadioButton();
            rbRating = new RadioButton();
            rbGenre = new RadioButton();
            rbDuration = new RadioButton();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(736, 438);
            dataGridView1.TabIndex = 2;
            // 
            // lbMovies
            // 
            lbMovies.FormattingEnabled = true;
            lbMovies.ItemHeight = 20;
            lbMovies.Location = new Point(96, 90);
            lbMovies.Name = "lbMovies";
            lbMovies.Size = new Size(647, 264);
            lbMovies.TabIndex = 3;
            lbMovies.SelectedIndexChanged += lbMovies_SelectedIndexChanged;
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(105, 416);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(178, 27);
            txtNameSearch.TabIndex = 4;
            txtNameSearch.TextChanged += textBox1_TextChanged;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.BackColor = Color.Red;
            lblSortBy.ForeColor = Color.White;
            lblSortBy.Location = new Point(323, 385);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(59, 20);
            lblSortBy.TabIndex = 5;
            lblSortBy.Text = "Sort By:";
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.BackColor = Color.Red;
            rbName.Checked = true;
            rbName.ForeColor = Color.White;
            rbName.Location = new Point(323, 419);
            rbName.Name = "rbName";
            rbName.Size = new Size(70, 24);
            rbName.TabIndex = 6;
            rbName.TabStop = true;
            rbName.Text = "Name";
            rbName.UseVisualStyleBackColor = false;
            rbName.CheckedChanged += rbName_CheckedChanged;
            // 
            // rbRating
            // 
            rbRating.AutoSize = true;
            rbRating.BackColor = Color.Red;
            rbRating.ForeColor = Color.White;
            rbRating.Location = new Point(423, 419);
            rbRating.Name = "rbRating";
            rbRating.Size = new Size(118, 24);
            rbRating.TabIndex = 7;
            rbRating.Text = "Movie Rating";
            rbRating.UseVisualStyleBackColor = false;
            rbRating.CheckedChanged += rbRating_CheckedChanged;
            // 
            // rbGenre
            // 
            rbGenre.AutoSize = true;
            rbGenre.BackColor = Color.Red;
            rbGenre.ForeColor = Color.White;
            rbGenre.Location = new Point(570, 419);
            rbGenre.Name = "rbGenre";
            rbGenre.Size = new Size(69, 24);
            rbGenre.TabIndex = 8;
            rbGenre.Text = "Genre";
            rbGenre.UseVisualStyleBackColor = false;
            rbGenre.CheckedChanged += rbGenre_CheckedChanged;
            // 
            // rbDuration
            // 
            rbDuration.AutoSize = true;
            rbDuration.BackColor = Color.Red;
            rbDuration.ForeColor = Color.White;
            rbDuration.Location = new Point(655, 419);
            rbDuration.Name = "rbDuration";
            rbDuration.Size = new Size(88, 24);
            rbDuration.TabIndex = 9;
            rbDuration.Text = "Duration";
            rbDuration.UseVisualStyleBackColor = false;
            rbDuration.CheckedChanged += rbDuration_CheckedChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Red;
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(105, 385);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(117, 20);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search By Name";
            // 
            // CheckMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(862, 536);
            Controls.Add(lblSearch);
            Controls.Add(rbDuration);
            Controls.Add(rbGenre);
            Controls.Add(rbRating);
            Controls.Add(rbName);
            Controls.Add(lblSortBy);
            Controls.Add(txtNameSearch);
            Controls.Add(lbMovies);
            Controls.Add(dataGridView1);
            Name = "CheckMovieForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckMovieForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox lbMovies;
        private TextBox txtNameSearch;
        private Label lblSortBy;
        private RadioButton rbName;
        private RadioButton rbRating;
        private RadioButton rbGenre;
        private RadioButton rbDuration;
        private Label lblSearch;
    }
}