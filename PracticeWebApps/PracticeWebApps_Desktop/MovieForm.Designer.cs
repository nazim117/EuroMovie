namespace PracticeWebApps_Desktop
{
    partial class MovieForm
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
            txtDescriptIon = new TextBox();
            txtDuration = new TextBox();
            cbbMovieRating = new ComboBox();
            cbbMovieGenre = new ComboBox();
            btnEditMovie = new Button();
            btnDeleteMovie = new Button();
            lblName = new Label();
            lblDescription = new Label();
            lblMovieRating = new Label();
            lblMovieGenre = new Label();
            lblMovieDuration = new Label();
            pbMovie = new PictureBox();
            btnSelectFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(845, 393);
            dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(45, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescriptIon
            // 
            txtDescriptIon.Location = new Point(45, 121);
            txtDescriptIon.Multiline = true;
            txtDescriptIon.Name = "txtDescriptIon";
            txtDescriptIon.Size = new Size(247, 192);
            txtDescriptIon.TabIndex = 2;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(349, 277);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(197, 27);
            txtDuration.TabIndex = 3;
            // 
            // cbbMovieRating
            // 
            cbbMovieRating.FormattingEnabled = true;
            cbbMovieRating.Location = new Point(349, 144);
            cbbMovieRating.Name = "cbbMovieRating";
            cbbMovieRating.Size = new Size(197, 28);
            cbbMovieRating.TabIndex = 4;
            // 
            // cbbMovieGenre
            // 
            cbbMovieGenre.FormattingEnabled = true;
            cbbMovieGenre.Location = new Point(349, 209);
            cbbMovieGenre.Name = "cbbMovieGenre";
            cbbMovieGenre.Size = new Size(197, 28);
            cbbMovieGenre.TabIndex = 5;
            // 
            // btnEditMovie
            // 
            btnEditMovie.Cursor = Cursors.Hand;
            btnEditMovie.Location = new Point(45, 350);
            btnEditMovie.Name = "btnEditMovie";
            btnEditMovie.Size = new Size(122, 29);
            btnEditMovie.TabIndex = 7;
            btnEditMovie.Text = "Edit Movie";
            btnEditMovie.UseVisualStyleBackColor = true;
            btnEditMovie.Click += btnEditMovie_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Cursor = Cursors.Hand;
            btnDeleteMovie.Location = new Point(173, 350);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(119, 29);
            btnDeleteMovie.TabIndex = 8;
            btnDeleteMovie.Text = "Delete Movie";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Red;
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(45, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 10;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Red;
            lblDescription.ForeColor = SystemColors.ButtonHighlight;
            lblDescription.Location = new Point(45, 98);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description";
            // 
            // lblMovieRating
            // 
            lblMovieRating.AutoSize = true;
            lblMovieRating.BackColor = Color.Red;
            lblMovieRating.ForeColor = SystemColors.ButtonHighlight;
            lblMovieRating.Location = new Point(349, 121);
            lblMovieRating.Name = "lblMovieRating";
            lblMovieRating.Size = new Size(97, 20);
            lblMovieRating.TabIndex = 12;
            lblMovieRating.Text = "Movie Rating";
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.BackColor = Color.Red;
            lblMovieGenre.ForeColor = SystemColors.ButtonHighlight;
            lblMovieGenre.Location = new Point(349, 186);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(93, 20);
            lblMovieGenre.TabIndex = 13;
            lblMovieGenre.Text = "Movie Genre";
            // 
            // lblMovieDuration
            // 
            lblMovieDuration.AutoSize = true;
            lblMovieDuration.BackColor = Color.Red;
            lblMovieDuration.ForeColor = SystemColors.ButtonHighlight;
            lblMovieDuration.Location = new Point(349, 254);
            lblMovieDuration.Name = "lblMovieDuration";
            lblMovieDuration.Size = new Size(108, 20);
            lblMovieDuration.TabIndex = 14;
            lblMovieDuration.Text = "MovieDuration";
            // 
            // pbMovie
            // 
            pbMovie.BackColor = Color.Red;
            pbMovie.Location = new Point(584, 57);
            pbMovie.Name = "pbMovie";
            pbMovie.Size = new Size(254, 256);
            pbMovie.TabIndex = 15;
            pbMovie.TabStop = false;
            pbMovie.Click += pictureBox1_Click;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(650, 350);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(114, 29);
            btnSelectFile.TabIndex = 16;
            btnSelectFile.Text = "Browse...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(885, 430);
            Controls.Add(btnSelectFile);
            Controls.Add(pbMovie);
            Controls.Add(lblMovieDuration);
            Controls.Add(lblMovieGenre);
            Controls.Add(lblMovieRating);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnEditMovie);
            Controls.Add(cbbMovieGenre);
            Controls.Add(cbbMovieRating);
            Controls.Add(txtDuration);
            Controls.Add(txtDescriptIon);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "MovieForm";
            Text = "MovieForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtDescriptIon;
        private TextBox txtDuration;
        private ComboBox cbbMovieRating;
        private ComboBox cbbMovieGenre;
        private Button btnEditMovie;
        private Button btnDeleteMovie;
        private Label lblName;
        private Label lblDescription;
        private Label lblMovieRating;
        private Label lblMovieGenre;
        private Label lblMovieDuration;
        private PictureBox pbMovie;
        private Button btnSelectFile;
    }
}