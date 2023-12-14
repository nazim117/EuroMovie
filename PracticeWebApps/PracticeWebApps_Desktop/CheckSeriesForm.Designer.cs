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
            chbAdventure = new CheckBox();
            chbAction = new CheckBox();
            chbDrama = new CheckBox();
            chbComedy = new CheckBox();
            chbHorror = new CheckBox();
            chbDocumentary = new CheckBox();
            chbEducational = new CheckBox();
            btnFilter = new Button();
            btnResetFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(907, 478);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbSeries
            // 
            lbSeries.FormattingEnabled = true;
            lbSeries.ItemHeight = 20;
            lbSeries.Location = new Point(57, 48);
            lbSeries.Name = "lbSeries";
            lbSeries.Size = new Size(691, 344);
            lbSeries.TabIndex = 1;
            lbSeries.SelectedIndexChanged += lbSeries_SelectedIndexChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(57, 459);
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
            lblSearch.Location = new Point(57, 427);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(172, 20);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search Product By Name";
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.BackColor = Color.Red;
            lblSortBy.ForeColor = Color.White;
            lblSortBy.Location = new Point(315, 427);
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
            rbName.Location = new Point(315, 462);
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
            rbMovieRating.Location = new Point(408, 460);
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
            rbGenre.Location = new Point(559, 459);
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
            rbDuration.Location = new Point(660, 459);
            rbDuration.Name = "rbDuration";
            rbDuration.Size = new Size(88, 24);
            rbDuration.TabIndex = 8;
            rbDuration.Text = "Duration";
            rbDuration.UseVisualStyleBackColor = false;
            rbDuration.CheckedChanged += rbDuration_CheckedChanged;
            // 
            // chbAdventure
            // 
            chbAdventure.AutoSize = true;
            chbAdventure.BackColor = Color.Red;
            chbAdventure.ForeColor = SystemColors.ButtonFace;
            chbAdventure.Location = new Point(803, 48);
            chbAdventure.Name = "chbAdventure";
            chbAdventure.Size = new Size(99, 24);
            chbAdventure.TabIndex = 9;
            chbAdventure.Text = "Adventure";
            chbAdventure.UseVisualStyleBackColor = false;
            chbAdventure.CheckedChanged += chbAdventure_CheckedChanged;
            // 
            // chbAction
            // 
            chbAction.AutoSize = true;
            chbAction.BackColor = Color.Red;
            chbAction.ForeColor = SystemColors.ButtonFace;
            chbAction.Location = new Point(803, 101);
            chbAction.Name = "chbAction";
            chbAction.Size = new Size(74, 24);
            chbAction.TabIndex = 10;
            chbAction.Text = "Action";
            chbAction.UseVisualStyleBackColor = false;
            chbAction.CheckedChanged += chbAction_CheckedChanged;
            // 
            // chbDrama
            // 
            chbDrama.AutoSize = true;
            chbDrama.BackColor = Color.Red;
            chbDrama.ForeColor = SystemColors.ButtonFace;
            chbDrama.Location = new Point(803, 153);
            chbDrama.Name = "chbDrama";
            chbDrama.Size = new Size(76, 24);
            chbDrama.TabIndex = 11;
            chbDrama.Text = "Drama";
            chbDrama.UseVisualStyleBackColor = false;
            chbDrama.CheckedChanged += chbDrama_CheckedChanged;
            // 
            // chbComedy
            // 
            chbComedy.AutoSize = true;
            chbComedy.BackColor = Color.Red;
            chbComedy.ForeColor = SystemColors.ButtonFace;
            chbComedy.Location = new Point(803, 206);
            chbComedy.Name = "chbComedy";
            chbComedy.Size = new Size(86, 24);
            chbComedy.TabIndex = 12;
            chbComedy.Text = "Comedy";
            chbComedy.UseVisualStyleBackColor = false;
            chbComedy.CheckedChanged += chbComedy_CheckedChanged;
            // 
            // chbHorror
            // 
            chbHorror.AutoSize = true;
            chbHorror.BackColor = Color.Red;
            chbHorror.ForeColor = SystemColors.ButtonFace;
            chbHorror.Location = new Point(803, 257);
            chbHorror.Name = "chbHorror";
            chbHorror.Size = new Size(75, 24);
            chbHorror.TabIndex = 13;
            chbHorror.Text = "Horror";
            chbHorror.UseVisualStyleBackColor = false;
            chbHorror.CheckedChanged += chbHorror_CheckedChanged;
            // 
            // chbDocumentary
            // 
            chbDocumentary.AutoSize = true;
            chbDocumentary.BackColor = Color.Red;
            chbDocumentary.ForeColor = SystemColors.ButtonFace;
            chbDocumentary.Location = new Point(803, 305);
            chbDocumentary.Name = "chbDocumentary";
            chbDocumentary.Size = new Size(120, 24);
            chbDocumentary.TabIndex = 14;
            chbDocumentary.Text = "Documentary";
            chbDocumentary.UseVisualStyleBackColor = false;
            chbDocumentary.CheckedChanged += chbDocumentary_CheckedChanged;
            // 
            // chbEducational
            // 
            chbEducational.AutoSize = true;
            chbEducational.BackColor = Color.Red;
            chbEducational.ForeColor = SystemColors.ButtonFace;
            chbEducational.Location = new Point(803, 354);
            chbEducational.Name = "chbEducational";
            chbEducational.Size = new Size(109, 24);
            chbEducational.TabIndex = 15;
            chbEducational.Text = "Educational";
            chbEducational.UseVisualStyleBackColor = false;
            chbEducational.CheckedChanged += chbEducational_CheckedChanged;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(795, 407);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(128, 29);
            btnFilter.TabIndex = 19;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Location = new Point(795, 462);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(128, 29);
            btnResetFilters.TabIndex = 20;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.UseVisualStyleBackColor = true;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // CheckSeriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(989, 561);
            Controls.Add(btnResetFilters);
            Controls.Add(btnFilter);
            Controls.Add(chbEducational);
            Controls.Add(chbDocumentary);
            Controls.Add(chbHorror);
            Controls.Add(chbComedy);
            Controls.Add(chbDrama);
            Controls.Add(chbAction);
            Controls.Add(chbAdventure);
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
        private CheckBox chbAdventure;
        private CheckBox chbAction;
        private CheckBox chbDrama;
        private CheckBox chbComedy;
        private CheckBox chbHorror;
        private CheckBox chbDocumentary;
        private CheckBox chbEducational;
        private Button btnFilter;
        private Button btnResetFilters;
    }
}