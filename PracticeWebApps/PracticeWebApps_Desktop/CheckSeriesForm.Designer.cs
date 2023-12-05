namespace PracticeWebApps_Desktop
{
    partial class CheckSeriesForm
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
            lbSeries = new ListBox();
            txtSearchName = new TextBox();
            lblSearch = new Label();
            lblSortBy = new Label();
            rbName = new RadioButton();
            rbMovieRating = new RadioButton();
            rbGenre = new RadioButton();
            rbDuration = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(744, 506);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbSeries
            // 
            lbSeries.FormattingEnabled = true;
            lbSeries.ItemHeight = 20;
            lbSeries.Location = new Point(75, 72);
            lbSeries.Name = "lbSeries";
            lbSeries.Size = new Size(691, 344);
            lbSeries.TabIndex = 1;
            lbSeries.SelectedIndexChanged += lbSeries_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(75, 483);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(195, 27);
            txtSearchName.TabIndex = 2;
            txtSearchName.TextChanged += textBox1_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Red;
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(75, 451);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(117, 20);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "SearchProduct By Name";
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.BackColor = Color.Red;
            lblSortBy.ForeColor = Color.White;
            lblSortBy.Location = new Point(333, 451);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(52, 20);
            lblSortBy.TabIndex = 4;
            lblSortBy.Text = "SortBy";
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.BackColor = Color.Red;
            rbName.Checked = true;
            rbName.ForeColor = Color.White;
            rbName.Location = new Point(333, 486);
            rbName.Name = "rbName";
            rbName.Size = new Size(70, 24);
            rbName.TabIndex = 5;
            rbName.TabStop = true;
            rbName.Text = "Name";
            rbName.UseVisualStyleBackColor = false;
            rbName.CheckedChanged += rbName_CheckedChanged;
            // 
            // rbMovieRating
            // 
            rbMovieRating.AutoSize = true;
            rbMovieRating.BackColor = Color.Red;
            rbMovieRating.ForeColor = Color.White;
            rbMovieRating.Location = new Point(426, 484);
            rbMovieRating.Name = "rbMovieRating";
            rbMovieRating.Size = new Size(118, 24);
            rbMovieRating.TabIndex = 6;
            rbMovieRating.Text = "Movie Rating";
            rbMovieRating.UseVisualStyleBackColor = false;
            rbMovieRating.CheckedChanged += rbMovieRating_CheckedChanged;
            // 
            // rbGenre
            // 
            rbGenre.AutoSize = true;
            rbGenre.BackColor = Color.Red;
            rbGenre.ForeColor = Color.White;
            rbGenre.Location = new Point(577, 483);
            rbGenre.Name = "rbGenre";
            rbGenre.Size = new Size(69, 24);
            rbGenre.TabIndex = 7;
            rbGenre.Text = "Genre";
            rbGenre.UseVisualStyleBackColor = false;
            rbGenre.CheckedChanged += rbGenre_CheckedChanged;
            // 
            // rbDuration
            // 
            rbDuration.AutoSize = true;
            rbDuration.BackColor = Color.Red;
            rbDuration.ForeColor = Color.White;
            rbDuration.Location = new Point(678, 483);
            rbDuration.Name = "rbDuration";
            rbDuration.Size = new Size(88, 24);
            rbDuration.TabIndex = 8;
            rbDuration.Text = "Duration";
            rbDuration.UseVisualStyleBackColor = false;
            rbDuration.CheckedChanged += rbDuration_CheckedChanged;
            // 
            // CheckSeriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(877, 624);
            Controls.Add(rbDuration);
            Controls.Add(rbGenre);
            Controls.Add(rbMovieRating);
            Controls.Add(rbName);
            Controls.Add(lblSortBy);
            Controls.Add(lblSearch);
            Controls.Add(txtSearchName);
            Controls.Add(lbSeries);
            Controls.Add(dataGridView1);
            Name = "CheckSeriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckSeriesForm";
            Load += CheckSeriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox lbSeries;
        private TextBox txtSearchName;
        private Label lblSearch;
        private Label lblSortBy;
        private RadioButton rbName;
        private RadioButton rbMovieRating;
        private RadioButton rbGenre;
        private RadioButton rbDuration;
    }
}