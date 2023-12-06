using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net.Http.Headers;

namespace PracticeWebApps_Desktop
{
    public partial class AddSeriesForm : Form
    {
        private string relativeDestinationFilePath;

        public AddSeriesForm()
        {
            InitializeComponent();
            relativeDestinationFilePath = string.Empty;
            foreach (var item in Enum.GetValues(typeof(Rating)))
            {
                cbbSeriesRating.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                cbbSeriesGenre.Items.Add(item);
            }
        }

        private void CheckSeriesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSerie_Click(object sender, EventArgs e)
        {
            string[] movieRatingValues = Enum.GetNames(typeof(Rating));
            string[] movieGenreValues = Enum.GetNames(typeof(Genre));


            ProductManager productManager;

            try
            {
                if (!int.TryParse(txtSeriesDuration.Text, out int duration))
                {
                    throw new ArgumentException("Invalid duration");
                }
                if (!movieRatingValues.Contains(cbbSeriesRating.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }
                if (!movieGenreValues.Contains(cbbSeriesGenre.Text))
                {
                    throw new ArgumentException("Invalid rating");
                }
                if (string.IsNullOrWhiteSpace(relativeDestinationFilePath))
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

                productManager = new ProductManager(new ProductDAL());

                productManager.CreateObject(
                    new Serie(txtSeriesName.Text,
                    txtSerieDescription.Text,
                    (Rating)cbbSeriesRating.SelectedItem,
                    (Genre)cbbSeriesGenre.SelectedItem,
                    duration,
                    relativeDestinationFilePath,
                    seasons,
                    episodes));

                MessageBox.Show("Series added successfully");

            }
            catch (ProductException ex) { MessageBox.Show(ex.Message); }
            catch (NumberOutOfRangeException ex) { MessageBox.Show(ex.Message); }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSelectASeriesPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileManager fileManager = new FileManager();
                    relativeDestinationFilePath = fileManager.SaveFile(openFileDialog.FileName);

                    pbSeries.Image = Image.FromFile(relativeDestinationFilePath);
                    pbSeries.SizeMode = PictureBoxSizeMode.StretchImage;

                    MessageBox.Show("File selected successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSeriesDuration_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
