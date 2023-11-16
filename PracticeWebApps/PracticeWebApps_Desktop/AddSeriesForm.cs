using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps_Desktop
{
    public partial class AddSeriesForm : Form
    {
        string relativeDestinationFilePath;

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
            if (relativeDestinationFilePath == string.Empty)
            {
                MessageBox.Show("Select a Picture for the movie/serie");
                return;
            }

            if (int.TryParse(txtSeriesDuration.Text, out int duration))
            {
                duration = int.Parse(txtSeriesDuration.Text);
                if (duration < 0 || duration > 1000)
                {
                    throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 1000.");
                }
            }

            if (int.TryParse(txtSeasons.Text, out int seasons))
            {
                seasons = int.Parse(txtSeasons.Text);
                if (seasons < 0 || seasons > 100)
                {
                    throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 100.");
                }
            }

            if (int.TryParse(txtEpisodes.Text, out int episodes))
            {
                episodes = int.Parse(txtEpisodes.Text);
                if (episodes < 0 || episodes > 700)
                {
                    throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 700.");
                }
            }

            ProductManager productManager;

            try
            {
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

                MessageBox.Show("Movie added successfully");

            }
            catch (MovieException ex) { MessageBox.Show(ex.Message); }
            catch (NumberOutOfRangeException ex) { MessageBox.Show(ex.Message); }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); }
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
                    relativeDestinationFilePath = fileManager.SaveFilePath(openFileDialog.FileName);

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
    }
}
