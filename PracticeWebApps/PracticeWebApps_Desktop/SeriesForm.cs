using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWebApps_Desktop
{
    public partial class SeriesForm : Form
    {
        private ProductManager productManager;
        private string _productName;
        private Serie product;
        private string destinationFilePath;
        public SeriesForm(string productName)
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            product = (Serie)productManager.GetObject(productName);

            txtName.Text = product.Name;
            txtDescription.Text = product.Description;
            txtADuration.Text = product.Duration.ToString();

            foreach (var item in Enum.GetValues(typeof(Rating)))
            {
                cbbRating.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                cbbGenre.Items.Add(item);
            }
            cbbRating.SelectedItem = product.MovieRating;
            cbbGenre.SelectedItem = product.Genre;

            _productName = productName;

            string imagePath = Path.Combine("C:\\Sem2-project-repository\\individual-project-nazim-ahmedov-s2\\PracticeWebApps\\PracticeWebApps\\wwwroot\\", product.Picture);

            destinationFilePath = imagePath.Replace("~", "");
            Image image = Image.FromFile(imagePath.Replace("~", ""));

            pbSeries.Image = image;
            pbSeries.SizeMode = PictureBoxSizeMode.StretchImage;

            txtSeasons.Text = product.Seasons.ToString();
            txtEpisodes.Text = product.Episodes.ToString();
        }

        private void SeriesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string previousName = productManager.GetObject(_productName).Name;
            string[] movieRatingValues = Enum.GetNames(typeof(Rating));
            string[] movieGenreValues = Enum.GetNames(typeof(Genre));

            try
            {
                if (!int.TryParse(txtADuration.Text, out int duration))
                {
                    throw new ArgumentException("Invalid duration");
                }
                if (!movieRatingValues.Contains(cbbRating.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }
                if (!movieGenreValues.Contains(cbbGenre.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }
                if (string.IsNullOrWhiteSpace(destinationFilePath))
                {
                    throw new ArgumentException("Invalid picture");
                }
                if (!int.TryParse(txtSeasons.Text, out int seasons))
                {
                    throw new ArgumentException("Invalid seasons");
                }
                if (!int.TryParse(txtEpisodes.Text, out int episodes))
                {
                    throw new ArgumentException("Invalid episodes");
                }

                if (productManager.EditObject(new Serie(
                        txtName.Text,
                        txtDescription.Text,
                        (Rating)cbbRating.SelectedItem,
                        (Genre)cbbGenre.SelectedItem,
                        duration,
                        destinationFilePath,
                        seasons,
                        episodes), previousName))
                {
                    MessageBox.Show("Edit was successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error occurred. Edit was not successful");
                }

            }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); }
            catch (NumberOutOfRangeException ex) { MessageBox.Show(ex.Message); }
            catch (ProductException ex) { MessageBox.Show(ex.Message); }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (productManager.DeleteObject(product))
                {
                    Console.WriteLine("User deleted successfully");
                    this.Close();
                }
                else
                {
                    Console.WriteLine("Problem occurred. User was not deleted");
                }
            }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBrowsePicture_Click(object sender, EventArgs e)
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

                    pbSeries.Image = Image.FromFile(filePath);
                    pbSeries.SizeMode = PictureBoxSizeMode.StretchImage;

                    MessageBox.Show("File selected successfully");
                }
                catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
