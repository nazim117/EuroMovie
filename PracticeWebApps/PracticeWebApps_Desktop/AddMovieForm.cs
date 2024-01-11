using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps_Desktop
{
    public partial class AddMovieForm : Form
    {
        string destinationFilePath;
        public AddMovieForm()
        {
            InitializeComponent();
            destinationFilePath = string.Empty;
            foreach (var item in Enum.GetValues(typeof(Rating)))
            {
                cbbMovieRating.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                cbbGenre.Items.Add(item);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string[] movieRatingValues = Enum.GetNames(typeof(Rating));
            string[] movieGenreValues = Enum.GetNames(typeof(Genre));

            
            ProductManager productManager = new ProductManager(new ProductDAL());

            try
            {
                if (!movieRatingValues.Contains(cbbMovieRating.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }
                if (!movieGenreValues.Contains(cbbGenre.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new ArgumentException("Invalid name");
                }
                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    throw new ArgumentException("Invalid duration");
                }
                if (string.IsNullOrEmpty(destinationFilePath))
                {
                    MessageBox.Show("Select a Picture for the movie/serie");
                    return;
                }
                if (!int.TryParse(txtDuration.Text, out int duration))
                {
                    throw new ArgumentException("Invalid duration");
                }

                productManager.CreateObject(
                new Movie(txtName.Text,
                txtDescription.Text,
                (Rating)cbbMovieRating.SelectedItem,
                (Genre)cbbGenre.SelectedItem,
                duration,
                destinationFilePath));

                MessageBox.Show("Movie added successfully");

            }
            catch (ProductException ex) { MessageBox.Show(ex.Message); }
            catch (NumberOutOfRangeException ex) { MessageBox.Show(ex.Message); }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSelectAFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileManager fileManager = new FileManager();

                    string filePath = fileManager.SaveFile(openFileDialog.FileName);
                    destinationFilePath = fileManager.CreateRelativePath("images");

                    pbMovie.Image = Image.FromFile(filePath);
                    pbMovie.SizeMode = PictureBoxSizeMode.StretchImage;

                    MessageBox.Show("File selected successfully");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
