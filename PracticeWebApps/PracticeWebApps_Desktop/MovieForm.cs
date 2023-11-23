using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps_Desktop
{
    public partial class MovieForm : Form
    {
        private ProductManager productManager;
        private string _productName;
        private Product product;
        public MovieForm(string productName)
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            product = productManager.GetObject(productName);

            txtName.Text = product.Name;
            txtDescriptIon.Text = product.Description;
            txtDuration.Text = product.Duration.ToString();

            foreach (var item in Enum.GetValues(typeof(Rating)))
            {
                cbbMovieRating.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                cbbMovieGenre.Items.Add(item);
            }
            cbbMovieRating.SelectedItem = product.MovieRating;
            cbbMovieGenre.SelectedItem = product.Genre;

            _productName = productName;
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            string previousName = productManager.GetObject(_productName).Name;
            string[] movieRatingValues = Enum.GetNames(typeof(Rating));
            string[] movieGenreValues = Enum.GetNames(typeof(Genre));

            try
            {
                if (!int.TryParse(txtDuration.Text, out int duration))
                {
                    throw new ArgumentException("Invalid duration");
                }
                if (!movieRatingValues.Contains(cbbMovieRating.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }
                if (!movieGenreValues.Contains(cbbMovieGenre.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }

                if (productManager.EditObject(new Movie(
                        txtName.Text,
                        txtDescriptIon.Text,
                        (Rating)cbbMovieRating.SelectedItem,
                        (Genre)cbbMovieGenre.SelectedItem,
                        duration,
                        product.Picture), previousName))
                {
                    MessageBox.Show("Edit was successful");
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
            this.Close();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (productManager.DeleteObject(product))
                {
                    Console.WriteLine("User deleted successfully");
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
            this.Close();
        }
    }
}
