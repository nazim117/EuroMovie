using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
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
    public partial class AddMovieForm : Form
    {
        string fileLocation;
        public AddMovieForm()
        {
            InitializeComponent();
            fileLocation = string.Empty;
            foreach (var item in Enum.GetValues(typeof(Rating)))
            {
                cbbMovieRating.Items.Add(item);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (fileLocation == string.Empty)
            {
                MessageBox.Show("Select a Picture for the movie/serie");
                return;
            }
            if (!int.TryParse(txtDuration.Text, out int duration))
            {
                MessageBox.Show("Invalid duration");
                return;
            }
            ProductManager productManager = new ProductManager(new ProductDAL());
            try
            {
                productManager.CreateObject(
                    new Movie(txtName.Text,
                    txtDescription.Text,
                    (Rating)cbbMovieRating.SelectedItem,
                    duration,
                    fileLocation));

                MessageBox.Show("Movie added successfully");

            }
            catch (MovieException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectAFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileLocation = openFileDialog.FileName;
                MessageBox.Show("File selected successfully");
            }
        }
    }
}
