namespace PracticeWebApps_Desktop
{
    partial class SeriesForm
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
            txtADuration = new TextBox();
            txtSeasons = new TextBox();
            txtEpisodes = new TextBox();
            cbbRating = new ComboBox();
            cbbGenre = new ComboBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBrowsePicture = new Button();
            pbSeries = new PictureBox();
            lblName = new Label();
            lblDescription = new Label();
            lblRating = new Label();
            lblGenre = new Label();
            lblDuration = new Label();
            lblSeasons = new Label();
            lblEpisodes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSeries).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(740, 398);
            dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(169, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(62, 125);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(234, 196);
            txtDescription.TabIndex = 2;
            // 
            // txtADuration
            // 
            txtADuration.Location = new Point(330, 183);
            txtADuration.Name = "txtADuration";
            txtADuration.Size = new Size(179, 27);
            txtADuration.TabIndex = 3;
            // 
            // txtSeasons
            // 
            txtSeasons.Location = new Point(330, 239);
            txtSeasons.Name = "txtSeasons";
            txtSeasons.Size = new Size(179, 27);
            txtSeasons.TabIndex = 4;
            // 
            // txtEpisodes
            // 
            txtEpisodes.Location = new Point(330, 294);
            txtEpisodes.Name = "txtEpisodes";
            txtEpisodes.Size = new Size(179, 27);
            txtEpisodes.TabIndex = 5;
            // 
            // cbbRating
            // 
            cbbRating.FormattingEnabled = true;
            cbbRating.Location = new Point(330, 71);
            cbbRating.Name = "cbbRating";
            cbbRating.Size = new Size(179, 28);
            cbbRating.TabIndex = 6;
            // 
            // cbbGenre
            // 
            cbbGenre.FormattingEnabled = true;
            cbbGenre.Location = new Point(330, 125);
            cbbGenre.Name = "cbbGenre";
            cbbGenre.Size = new Size(179, 28);
            cbbGenre.TabIndex = 7;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(62, 357);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(183, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBrowsePicture
            // 
            btnBrowsePicture.Location = new Point(575, 357);
            btnBrowsePicture.Name = "btnBrowsePicture";
            btnBrowsePicture.Size = new Size(94, 29);
            btnBrowsePicture.TabIndex = 10;
            btnBrowsePicture.Text = "Browse";
            btnBrowsePicture.UseVisualStyleBackColor = true;
            btnBrowsePicture.Click += btnBrowsePicture_Click;
            // 
            // pbSeries
            // 
            pbSeries.BackColor = Color.Red;
            pbSeries.Location = new Point(536, 71);
            pbSeries.Name = "pbSeries";
            pbSeries.Size = new Size(198, 250);
            pbSeries.TabIndex = 11;
            pbSeries.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Red;
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(62, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 12;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Red;
            lblDescription.ForeColor = SystemColors.ButtonFace;
            lblDescription.Location = new Point(62, 102);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = Color.Red;
            lblRating.ForeColor = SystemColors.ButtonFace;
            lblRating.Location = new Point(330, 48);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(97, 20);
            lblRating.TabIndex = 14;
            lblRating.Text = "Movie Rating";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.BackColor = Color.Red;
            lblGenre.ForeColor = SystemColors.ButtonFace;
            lblGenre.Location = new Point(330, 102);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 15;
            lblGenre.Text = "Genre";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.BackColor = Color.Red;
            lblDuration.ForeColor = SystemColors.ButtonFace;
            lblDuration.Location = new Point(330, 160);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(67, 20);
            lblDuration.TabIndex = 16;
            lblDuration.Text = "Duration";
            // 
            // lblSeasons
            // 
            lblSeasons.AutoSize = true;
            lblSeasons.BackColor = Color.Red;
            lblSeasons.ForeColor = SystemColors.ButtonFace;
            lblSeasons.Location = new Point(330, 213);
            lblSeasons.Name = "lblSeasons";
            lblSeasons.Size = new Size(62, 20);
            lblSeasons.TabIndex = 17;
            lblSeasons.Text = "Seasons";
            // 
            // lblEpisodes
            // 
            lblEpisodes.AutoSize = true;
            lblEpisodes.BackColor = Color.Red;
            lblEpisodes.ForeColor = SystemColors.ButtonFace;
            lblEpisodes.Location = new Point(329, 271);
            lblEpisodes.Name = "lblEpisodes";
            lblEpisodes.Size = new Size(68, 20);
            lblEpisodes.TabIndex = 18;
            lblEpisodes.Text = "Episodes";
            // 
            // SeriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEpisodes);
            Controls.Add(lblSeasons);
            Controls.Add(lblDuration);
            Controls.Add(lblGenre);
            Controls.Add(lblRating);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(pbSeries);
            Controls.Add(btnBrowsePicture);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(cbbGenre);
            Controls.Add(cbbRating);
            Controls.Add(txtEpisodes);
            Controls.Add(txtSeasons);
            Controls.Add(txtADuration);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "SeriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeriesForm";
            Load += SeriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSeries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtADuration;
        private TextBox txtSeasons;
        private TextBox txtEpisodes;
        private ComboBox cbbRating;
        private ComboBox cbbGenre;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnBrowsePicture;
        private PictureBox pbSeries;
        private Label lblName;
        private Label lblDescription;
        private Label lblRating;
        private Label lblGenre;
        private Label lblDuration;
        private Label lblSeasons;
        private Label lblEpisodes;
    }
}