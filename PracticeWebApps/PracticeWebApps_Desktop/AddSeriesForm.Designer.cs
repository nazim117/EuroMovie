namespace PracticeWebApps_Desktop
{
    partial class AddSeriesForm
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
            pbSeries = new PictureBox();
            lblSeriesPicture = new Label();
            lblSeiresDuration = new Label();
            lblSeriesGenre = new Label();
            lblSeriesRating = new Label();
            lblDescription = new Label();
            lblName = new Label();
            cbbSeriesGenre = new ComboBox();
            btnSelectASeriesPicture = new Button();
            btnAddSerie = new Button();
            cbbSeriesRating = new ComboBox();
            txtSeriesDuration = new TextBox();
            txtSerieDescription = new TextBox();
            txtSeriesName = new TextBox();
            dataGridView1 = new DataGridView();
            lblEpisodes = new Label();
            lblSeasons = new Label();
            lblSeriesDescription = new Label();
            lblSeriesName = new Label();
            txtSeasons = new TextBox();
            txtEpisodes = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbSeries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pbSeries
            // 
            pbSeries.BackColor = Color.Red;
            pbSeries.Location = new Point(884, 76);
            pbSeries.Name = "pbSeries";
            pbSeries.Size = new Size(253, 283);
            pbSeries.TabIndex = 32;
            pbSeries.TabStop = false;
            // 
            // lblSeriesPicture
            // 
            lblSeriesPicture.AutoSize = true;
            lblSeriesPicture.BackColor = Color.Red;
            lblSeriesPicture.ForeColor = SystemColors.ButtonFace;
            lblSeriesPicture.Location = new Point(511, 322);
            lblSeriesPicture.Name = "lblSeriesPicture";
            lblSeriesPicture.Size = new Size(54, 20);
            lblSeriesPicture.TabIndex = 31;
            lblSeriesPicture.Text = "Picture";
            // 
            // lblSeiresDuration
            // 
            lblSeiresDuration.AutoSize = true;
            lblSeiresDuration.BackColor = Color.Red;
            lblSeiresDuration.ForeColor = SystemColors.ButtonFace;
            lblSeiresDuration.Location = new Point(511, 162);
            lblSeiresDuration.Name = "lblSeiresDuration";
            lblSeiresDuration.Size = new Size(67, 20);
            lblSeiresDuration.TabIndex = 30;
            lblSeiresDuration.Text = "Duration";
            // 
            // lblSeriesGenre
            // 
            lblSeriesGenre.AutoSize = true;
            lblSeriesGenre.BackColor = Color.Red;
            lblSeriesGenre.ForeColor = SystemColors.ButtonFace;
            lblSeriesGenre.Location = new Point(511, 108);
            lblSeriesGenre.Name = "lblSeriesGenre";
            lblSeriesGenre.Size = new Size(48, 20);
            lblSeriesGenre.TabIndex = 29;
            lblSeriesGenre.Text = "Genre";
            // 
            // lblSeriesRating
            // 
            lblSeriesRating.AutoSize = true;
            lblSeriesRating.BackColor = Color.Red;
            lblSeriesRating.ForeColor = SystemColors.ButtonFace;
            lblSeriesRating.Location = new Point(511, 54);
            lblSeriesRating.Name = "lblSeriesRating";
            lblSeriesRating.Size = new Size(95, 20);
            lblSeriesRating.TabIndex = 28;
            lblSeriesRating.Text = "Series Rating";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Red;
            lblDescription.ForeColor = SystemColors.ButtonFace;
            lblDescription.Location = new Point(-146, 125);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 27;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Red;
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(-146, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 26;
            lblName.Text = "Name";
            // 
            // cbbSeriesGenre
            // 
            cbbSeriesGenre.FormattingEnabled = true;
            cbbSeriesGenre.Location = new Point(511, 131);
            cbbSeriesGenre.Name = "cbbSeriesGenre";
            cbbSeriesGenre.Size = new Size(319, 28);
            cbbSeriesGenre.TabIndex = 25;
            // 
            // btnSelectASeriesPicture
            // 
            btnSelectASeriesPicture.Location = new Point(511, 345);
            btnSelectASeriesPicture.Name = "btnSelectASeriesPicture";
            btnSelectASeriesPicture.Size = new Size(118, 29);
            btnSelectASeriesPicture.TabIndex = 24;
            btnSelectASeriesPicture.Text = "Browse";
            btnSelectASeriesPicture.UseVisualStyleBackColor = true;
            btnSelectASeriesPicture.Click += btnSelectASeriesPicture_Click;
            // 
            // btnAddSerie
            // 
            btnAddSerie.Location = new Point(60, 345);
            btnAddSerie.Name = "btnAddSerie";
            btnAddSerie.Size = new Size(293, 29);
            btnAddSerie.TabIndex = 23;
            btnAddSerie.Text = "Add Series";
            btnAddSerie.UseVisualStyleBackColor = true;
            btnAddSerie.Click += btnAddSerie_Click;
            // 
            // cbbSeriesRating
            // 
            cbbSeriesRating.FormattingEnabled = true;
            cbbSeriesRating.Location = new Point(511, 77);
            cbbSeriesRating.Name = "cbbSeriesRating";
            cbbSeriesRating.Size = new Size(319, 28);
            cbbSeriesRating.TabIndex = 22;
            // 
            // txtSeriesDuration
            // 
            txtSeriesDuration.Location = new Point(511, 185);
            txtSeriesDuration.Name = "txtSeriesDuration";
            txtSeriesDuration.Size = new Size(319, 27);
            txtSeriesDuration.TabIndex = 21;
            txtSeriesDuration.KeyPress += txtSeriesDuration_KeyPress;
            // 
            // txtSerieDescription
            // 
            txtSerieDescription.Location = new Point(60, 131);
            txtSerieDescription.Multiline = true;
            txtSerieDescription.Name = "txtSerieDescription";
            txtSerieDescription.Size = new Size(319, 196);
            txtSerieDescription.TabIndex = 20;
            // 
            // txtSeriesName
            // 
            txtSeriesName.Location = new Point(60, 77);
            txtSeriesName.Name = "txtSeriesName";
            txtSeriesName.Size = new Size(319, 27);
            txtSeriesName.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1146, 348);
            dataGridView1.TabIndex = 18;
            // 
            // lblEpisodes
            // 
            lblEpisodes.AutoSize = true;
            lblEpisodes.BackColor = Color.Red;
            lblEpisodes.ForeColor = SystemColors.ButtonFace;
            lblEpisodes.Location = new Point(511, 269);
            lblEpisodes.Name = "lblEpisodes";
            lblEpisodes.Size = new Size(68, 20);
            lblEpisodes.TabIndex = 35;
            lblEpisodes.Text = "Episodes";
            // 
            // lblSeasons
            // 
            lblSeasons.AutoSize = true;
            lblSeasons.BackColor = Color.Red;
            lblSeasons.ForeColor = SystemColors.ButtonFace;
            lblSeasons.Location = new Point(511, 215);
            lblSeasons.Name = "lblSeasons";
            lblSeasons.Size = new Size(62, 20);
            lblSeasons.TabIndex = 38;
            lblSeasons.Text = "Seasons";
            // 
            // lblSeriesDescription
            // 
            lblSeriesDescription.AutoSize = true;
            lblSeriesDescription.BackColor = Color.Red;
            lblSeriesDescription.ForeColor = SystemColors.ButtonFace;
            lblSeriesDescription.Location = new Point(60, 108);
            lblSeriesDescription.Name = "lblSeriesDescription";
            lblSeriesDescription.Size = new Size(85, 20);
            lblSeriesDescription.TabIndex = 39;
            lblSeriesDescription.Text = "Description";
            // 
            // lblSeriesName
            // 
            lblSeriesName.AutoSize = true;
            lblSeriesName.BackColor = Color.Red;
            lblSeriesName.ForeColor = SystemColors.ButtonFace;
            lblSeriesName.Location = new Point(60, 54);
            lblSeriesName.Name = "lblSeriesName";
            lblSeriesName.Size = new Size(49, 20);
            lblSeriesName.TabIndex = 40;
            lblSeriesName.Text = "Name";
            // 
            // txtSeasons
            // 
            txtSeasons.Location = new Point(511, 239);
            txtSeasons.Name = "txtSeasons";
            txtSeasons.Size = new Size(319, 27);
            txtSeasons.TabIndex = 41;
            // 
            // txtEpisodes
            // 
            txtEpisodes.Location = new Point(511, 292);
            txtEpisodes.Name = "txtEpisodes";
            txtEpisodes.Size = new Size(319, 27);
            txtEpisodes.TabIndex = 42;
            // 
            // AddSeriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1200, 450);
            Controls.Add(txtEpisodes);
            Controls.Add(txtSeasons);
            Controls.Add(lblSeriesName);
            Controls.Add(lblSeriesDescription);
            Controls.Add(lblSeasons);
            Controls.Add(lblEpisodes);
            Controls.Add(pbSeries);
            Controls.Add(lblSeriesPicture);
            Controls.Add(lblSeiresDuration);
            Controls.Add(lblSeriesGenre);
            Controls.Add(lblSeriesRating);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(cbbSeriesGenre);
            Controls.Add(btnSelectASeriesPicture);
            Controls.Add(btnAddSerie);
            Controls.Add(cbbSeriesRating);
            Controls.Add(txtSeriesDuration);
            Controls.Add(txtSerieDescription);
            Controls.Add(txtSeriesName);
            Controls.Add(dataGridView1);
            Name = "AddSeriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckSeriesForm";
            Load += CheckSeriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbSeries).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSeries;
        private Label lblSeriesPicture;
        private Label lblSeiresDuration;
        private Label lblSeriesGenre;
        private Label lblSeriesRating;
        private Label lblDescription;
        private Label lblName;
        private ComboBox cbbSeriesGenre;
        private Button btnSelectASeriesPicture;
        private Button btnAddSerie;
        private ComboBox cbbSeriesRating;
        private TextBox txtSeriesDuration;
        private TextBox txtSerieDescription;
        private TextBox txtSeriesName;
        private DataGridView dataGridView1;
        private Label lblEpisodes;
        private Label lblSeasons;
        private Label lblSeriesDescription;
        private Label lblSeriesName;
        private TextBox txtSeasons;
        private TextBox txtEpisodes;
    }
}