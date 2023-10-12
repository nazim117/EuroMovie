namespace PracticeWebApps_Desktop
{
    partial class AddMovieForm
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
            txtDescription = new TextBox();
            txtDuration = new TextBox();
            cbbMovieRating = new ComboBox();
            btnAddMovie = new Button();
            btnSelectAFile = new Button();
            cbbGenre = new ComboBox();
            lblName = new Label();
            lblDescription = new Label();
            lblMovieRating = new Label();
            lblGenre = new Label();
            lblDuration = new Label();
            lblPicture = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HotTrack;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(858, 348);
            dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(65, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(319, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(65, 129);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(319, 145);
            txtDescription.TabIndex = 2;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(516, 181);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(319, 27);
            txtDuration.TabIndex = 3;
            // 
            // cbbMovieRating
            // 
            cbbMovieRating.FormattingEnabled = true;
            cbbMovieRating.Location = new Point(516, 63);
            cbbMovieRating.Name = "cbbMovieRating";
            cbbMovieRating.Size = new Size(319, 28);
            cbbMovieRating.TabIndex = 4;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(320, 316);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(293, 29);
            btnAddMovie.TabIndex = 6;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnSelectAFile
            // 
            btnSelectAFile.Location = new Point(516, 245);
            btnSelectAFile.Name = "btnSelectAFile";
            btnSelectAFile.Size = new Size(118, 29);
            btnSelectAFile.TabIndex = 9;
            btnSelectAFile.Text = "Browse";
            btnSelectAFile.UseVisualStyleBackColor = true;
            btnSelectAFile.Click += btnSelectAFile_Click;
            // 
            // cbbGenre
            // 
            cbbGenre.FormattingEnabled = true;
            cbbGenre.Location = new Point(516, 127);
            cbbGenre.Name = "cbbGenre";
            cbbGenre.Size = new Size(319, 28);
            cbbGenre.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.HotTrack;
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(65, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 11;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = SystemColors.HotTrack;
            lblDescription.ForeColor = SystemColors.ButtonFace;
            lblDescription.Location = new Point(65, 106);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            // 
            // lblMovieRating
            // 
            lblMovieRating.AutoSize = true;
            lblMovieRating.BackColor = SystemColors.HotTrack;
            lblMovieRating.ForeColor = SystemColors.ButtonFace;
            lblMovieRating.Location = new Point(516, 40);
            lblMovieRating.Name = "lblMovieRating";
            lblMovieRating.Size = new Size(97, 20);
            lblMovieRating.TabIndex = 13;
            lblMovieRating.Text = "Movie Rating";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.BackColor = SystemColors.HotTrack;
            lblGenre.ForeColor = SystemColors.ButtonFace;
            lblGenre.Location = new Point(516, 104);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 14;
            lblGenre.Text = "Genre";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.BackColor = SystemColors.HotTrack;
            lblDuration.ForeColor = SystemColors.ButtonFace;
            lblDuration.Location = new Point(516, 158);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(67, 20);
            lblDuration.TabIndex = 15;
            lblDuration.Text = "Duration";
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.BackColor = SystemColors.HotTrack;
            lblPicture.ForeColor = SystemColors.ButtonFace;
            lblPicture.Location = new Point(510, 222);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(54, 20);
            lblPicture.TabIndex = 16;
            lblPicture.Text = "Picture";
            // 
            // AddMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(941, 416);
            Controls.Add(lblPicture);
            Controls.Add(lblDuration);
            Controls.Add(lblGenre);
            Controls.Add(lblMovieRating);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(cbbGenre);
            Controls.Add(btnSelectAFile);
            Controls.Add(btnAddMovie);
            Controls.Add(cbbMovieRating);
            Controls.Add(txtDuration);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "AddMovieForm";
            Text = "Add Movie";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtDuration;
        private ComboBox cbbMovieRating;
        private Button btnAddMovie;
        private Button btnSelectAFile;
        private ComboBox cbbGenre;
        private Label lblName;
        private Label lblDescription;
        private Label lblMovieRating;
        private Label lblGenre;
        private Label lblDuration;
        private Label lblPicture;
    }
}