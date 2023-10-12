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
		string relativeDestinationFilePath;
        public AddMovieForm()
        {
            InitializeComponent();
			relativeDestinationFilePath = string.Empty;
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
            if (relativeDestinationFilePath == string.Empty)
            {
                MessageBox.Show("Select a Picture for the movie/serie");
                return;
            }
            if (int.TryParse(txtDuration.Text, out int duration))
            {
                duration = int.Parse(txtDuration.Text);
                if (duration < 0 || duration > 1000)
                {
                    throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 1000.");
                }
            }
            ProductManager productManager = new ProductManager(new ProductDAL());
            try
            {
                productManager.CreateObject(
                    new Movie(txtName.Text,
                    txtDescription.Text,
                    (Rating)cbbMovieRating.SelectedItem,
                    (Genre)cbbGenre.SelectedItem,
                    duration,
					relativeDestinationFilePath));

                MessageBox.Show("Movie added successfully");

            }
            catch (MovieException ex) {MessageBox.Show(ex.Message);}
            catch (NumberOutOfRangeException ex) {MessageBox.Show(ex.Message);}
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message);}
            catch (InvalidOperationException ex) {MessageBox.Show(ex.Message);}
            catch (SqlException ex) {MessageBox.Show(ex.Message);}
            catch (TimeoutException ex) {MessageBox.Show(ex.Message);}
            catch (Exception ex) {MessageBox.Show(ex.Message);}
        }

        private void btnSelectAFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string currentDirectory = Environment.CurrentDirectory;
                string relativeFileLocation = Path.GetRelativePath(currentDirectory, selectedFilePath);
                MessageBox.Show("File selected successfully");

				string destinationFolderPath = Path.GetRelativePath(currentDirectory, "C:\\Sem2-project-repository\\individual-project-nazim-ahmedov-s2\\PracticeWebApps\\PracticeWebApps\\Pages\\Shared\\images\\");

                try
                {
                    string fileName = Path.GetFileName(relativeFileLocation);
                    relativeDestinationFilePath = Path.Combine(destinationFolderPath,fileName);

                    File.Copy(selectedFilePath, relativeDestinationFilePath);

                    MessageBox.Show($"File copied successfully to: {relativeDestinationFilePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
            }
        }
    }
}
