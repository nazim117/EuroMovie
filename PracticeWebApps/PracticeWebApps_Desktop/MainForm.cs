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
            addMovieForm.Show();
        }

        private void btnCheckMovie_Click(object sender, EventArgs e)
        {
            CheckMovieForm checkMovieForm = new CheckMovieForm();
            checkMovieForm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            CheckUserForm checkUserForm = new CheckUserForm();
            checkUserForm.Show();
        }
    }
}
