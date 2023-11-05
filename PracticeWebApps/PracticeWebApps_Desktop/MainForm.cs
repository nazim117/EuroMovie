using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWebApps_Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            this.Hide();
            addMovieForm.ShowDialog();
            this.Show();
        }

        private void btnCheckMovie_Click(object sender, EventArgs e)
        {
            CheckMovieForm checkMovieForm = new CheckMovieForm();
            this.Hide();
            checkMovieForm.ShowDialog();
            this.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            this.Hide();
            addUserForm.ShowDialog();
            this.Show();
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            CheckUserForm checkUserForm = new CheckUserForm();
            this.Hide();
            checkUserForm.ShowDialog();
            this.Show();
        }
    }
}
