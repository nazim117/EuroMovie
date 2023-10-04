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
            txtURL = new TextBox();
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
            dataGridView1.Size = new Size(687, 369);
            dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(232, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(319, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(232, 115);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(319, 81);
            txtDescription.TabIndex = 2;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(232, 264);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(319, 27);
            txtDuration.TabIndex = 3;
            // 
            // cbbMovieRating
            // 
            cbbMovieRating.FormattingEnabled = true;
            cbbMovieRating.Location = new Point(232, 220);
            cbbMovieRating.Name = "cbbMovieRating";
            cbbMovieRating.Size = new Size(319, 28);
            cbbMovieRating.TabIndex = 4;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(303, 360);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(178, 29);
            btnAddMovie.TabIndex = 6;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(232, 317);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(319, 27);
            txtURL.TabIndex = 7;
            // 
            // AddMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(txtURL);
            Controls.Add(btnAddMovie);
            Controls.Add(cbbMovieRating);
            Controls.Add(txtDuration);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "AddMovieForm";
            Text = "AddMovieForm";
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
        private TextBox txtURL;
    }
}