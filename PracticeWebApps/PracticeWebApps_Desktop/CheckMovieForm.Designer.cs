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
            chbAction = new CheckBox();
            chbDrama = new CheckBox();
            chbComedy = new CheckBox();
            chbHorror = new CheckBox();
            chbDocumentary = new CheckBox();
            chbEducational = new CheckBox();
            chbAdventure = new CheckBox();
            btnFilter = new Button();
            btnResetFilters = new Button();
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
            dataGridView1.Size = new Size(924, 438);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbMovies
            // 
            lbMovies.FormattingEnabled = true;
            lbMovies.ItemHeight = 20;
            lbMovies.Location = new Point(80, 70);
            lbMovies.Name = "lbMovies";
            lbMovies.Size = new Size(702, 284);
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
            lblSearch.Size = new Size(172, 20);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search Product By Name";
            // 
            // chbAction
            // 
            chbAction.AutoSize = true;
            chbAction.BackColor = Color.Red;
            chbAction.ForeColor = SystemColors.ButtonFace;
            chbAction.Location = new Point(838, 109);
            chbAction.Name = "chbAction";
            chbAction.Size = new Size(74, 24);
            chbAction.TabIndex = 11;
            chbAction.Text = "Action";
            chbAction.UseVisualStyleBackColor = false;
            chbAction.CheckedChanged += chbAction_CheckedChanged;
            // 
            // chbDrama
            // 
            chbDrama.AutoSize = true;
            chbDrama.BackColor = Color.Red;
            chbDrama.ForeColor = SystemColors.ButtonFace;
            chbDrama.Location = new Point(838, 148);
            chbDrama.Name = "chbDrama";
            chbDrama.Size = new Size(76, 24);
            chbDrama.TabIndex = 12;
            chbDrama.Text = "Drama";
            chbDrama.UseVisualStyleBackColor = false;
            chbDrama.CheckedChanged += chbDrama_CheckedChanged;
            // 
            // chbComedy
            // 
            chbComedy.AutoSize = true;
            chbComedy.BackColor = Color.Red;
            chbComedy.ForeColor = SystemColors.ButtonFace;
            chbComedy.Location = new Point(837, 189);
            chbComedy.Name = "chbComedy";
            chbComedy.Size = new Size(86, 24);
            chbComedy.TabIndex = 13;
            chbComedy.Text = "Comedy";
            chbComedy.UseVisualStyleBackColor = false;
            chbComedy.CheckedChanged += chbComedy_CheckedChanged;
            // 
            // chbHorror
            // 
            chbHorror.AutoSize = true;
            chbHorror.BackColor = Color.Red;
            chbHorror.ForeColor = SystemColors.ButtonFace;
            chbHorror.Location = new Point(839, 230);
            chbHorror.Name = "chbHorror";
            chbHorror.Size = new Size(75, 24);
            chbHorror.TabIndex = 14;
            chbHorror.Text = "Horror";
            chbHorror.UseVisualStyleBackColor = false;
            chbHorror.CheckedChanged += chbHorror_CheckedChanged;
            // 
            // chbDocumentary
            // 
            chbDocumentary.AutoSize = true;
            chbDocumentary.BackColor = Color.Red;
            chbDocumentary.ForeColor = SystemColors.ButtonFace;
            chbDocumentary.Location = new Point(837, 272);
            chbDocumentary.Name = "chbDocumentary";
            chbDocumentary.Size = new Size(120, 24);
            chbDocumentary.TabIndex = 15;
            chbDocumentary.Text = "Documentary";
            chbDocumentary.UseVisualStyleBackColor = false;
            chbDocumentary.CheckedChanged += chbDocumentary_CheckedChanged;
            // 
            // chbEducational
            // 
            chbEducational.AutoSize = true;
            chbEducational.BackColor = Color.Red;
            chbEducational.ForeColor = SystemColors.ButtonFace;
            chbEducational.Location = new Point(837, 321);
            chbEducational.Name = "chbEducational";
            chbEducational.Size = new Size(109, 24);
            chbEducational.TabIndex = 16;
            chbEducational.Text = "Educational";
            chbEducational.UseVisualStyleBackColor = false;
            chbEducational.CheckedChanged += chbEducational_CheckedChanged;
            // 
            // chbAdventure
            // 
            chbAdventure.AutoSize = true;
            chbAdventure.BackColor = Color.Red;
            chbAdventure.ForeColor = SystemColors.ButtonFace;
            chbAdventure.Location = new Point(838, 70);
            chbAdventure.Name = "chbAdventure";
            chbAdventure.Size = new Size(99, 24);
            chbAdventure.TabIndex = 17;
            chbAdventure.Text = "Adventure";
            chbAdventure.UseVisualStyleBackColor = false;
            chbAdventure.CheckedChanged += chbAdventure_CheckedChanged;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(829, 385);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(128, 29);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Location = new Point(829, 436);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(128, 29);
            btnResetFilters.TabIndex = 19;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.UseVisualStyleBackColor = true;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // CheckMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1041, 536);
            Controls.Add(btnResetFilters);
            Controls.Add(btnFilter);
            Controls.Add(chbAdventure);
            Controls.Add(chbEducational);
            Controls.Add(chbDocumentary);
            Controls.Add(chbHorror);
            Controls.Add(chbComedy);
            Controls.Add(chbDrama);
            Controls.Add(chbAction);
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
        private CheckBox chbAction;
        private CheckBox chbDrama;
        private CheckBox chbComedy;
        private CheckBox chbHorror;
        private CheckBox chbDocumentary;
        private CheckBox chbEducational;
        private CheckBox chbAdventure;
        private Button btnFilter;
        private Button btnResetFilters;
    }
}