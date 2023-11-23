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
            dataGridView1.Size = new Size(689, 360);
            dataGridView1.TabIndex = 2;
            // 
            // lbMovies
            // 
            lbMovies.FormattingEnabled = true;
            lbMovies.ItemHeight = 20;
            lbMovies.Location = new Point(105, 93);
            lbMovies.Name = "lbMovies";
            lbMovies.Size = new Size(591, 264);
            lbMovies.TabIndex = 3;
            lbMovies.SelectedIndexChanged += lbMovies_SelectedIndexChanged;
            // 
            // CheckMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMovies);
            Controls.Add(dataGridView1);
            Name = "CheckMovieForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckMovieForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox lbMovies;
    }
}