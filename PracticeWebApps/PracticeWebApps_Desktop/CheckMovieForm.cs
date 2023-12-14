using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps_Desktop
{
    public partial class CheckMovieForm : Form
    {
        ProductManager productManager;
        AlgorithmManager<Product> algorithmManager;
        Queue<Genre> filterByGenre;
        public CheckMovieForm()
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            algorithmManager = new AlgorithmManager<Product>();
            filterByGenre = new Queue<Genre>();

            PopulateList();
        }

        private void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm(((Movie)lbMovies.SelectedItem).Name);
            this.Hide();
            movieForm.ShowDialog();
            PopulateList();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbMovies.Items.Clear();
            if (string.IsNullOrWhiteSpace(txtNameSearch.Text))
            {
                PopulateList();
                return;
            }

            try
            {
                foreach (var item in algorithmManager.SearchProduct(txtNameSearch.Text, productManager.LoadObjects().ToList()))
                {
                    if (item is Movie)
                    {
                        lbMovies.Items.Add(item);
                    }
                }
                Thread.Sleep(300);
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

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void rbRating_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void rbGenre_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void rbDuration_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }
        private void PopulateList()
        {

            IComparer<Product> comparer = new SortByName();

            if (rbName.Checked)
            {
                comparer = new SortByName();
            }
            else if (rbRating.Checked)
            {
                comparer = new SortByRating();
            }
            else if (rbGenre.Checked)
            {
                comparer = new SortByGenre();
            }
            else if (rbDuration.Checked)
            {
                comparer = new SortByDuration();
            }

            lbMovies.Items.Clear();

            try
            {
                if (filterByGenre.Count == 0)
                {

                    foreach (var item in algorithmManager.MergeSort(productManager.LoadObjects().ToList(), comparer))
                    {
                        if (item is Movie)
                        {
                            lbMovies.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in algorithmManager.MergeSort(
                        algorithmManager.FilterByGenre(filterByGenre, productManager.LoadObjects().ToList()).ToList(), comparer))
                    {
                        if (item is Movie)
                        {
                            lbMovies.Items.Add(item);
                        }
                    }
                }
                Thread.Sleep(300);
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

        private void chbAdventure_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdventure.Checked)
            {
                filterByGenre.Enqueue(Genre.Adventure);
            }
            else
            {
                filterByGenre = algorithmManager.RemoveGenreFromQueue(Genre.Adventure, filterByGenre);
            }
        }

        private void chbAction_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAction.Checked)
            {
                filterByGenre.Enqueue(Genre.Action);
            }
            else
            {
                filterByGenre = algorithmManager.RemoveGenreFromQueue(Genre.Action, filterByGenre);
            }
        }

        private void chbDrama_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDrama.Checked)
            {
                filterByGenre.Enqueue(Genre.Drama);
            }
            else
            {
                filterByGenre = algorithmManager.RemoveGenreFromQueue(Genre.Drama, filterByGenre);
            }
        }

        private void chbComedy_CheckedChanged(object sender, EventArgs e)
        {
            if (chbComedy.Checked)
            {
                filterByGenre.Enqueue(Genre.Comedy);
            }
            else
            {
                filterByGenre = algorithmManager.RemoveGenreFromQueue(Genre.Comedy, filterByGenre);
            }
        }

        private void chbHorror_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHorror.Checked)
            {
                filterByGenre.Enqueue(Genre.Horror);
            }
            else
            {
                filterByGenre = algorithmManager.RemoveGenreFromQueue(Genre.Horror, filterByGenre);
            }
        }

        private void chbDocumentary_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDocumentary.Checked)
            {
                filterByGenre.Enqueue(Genre.Documentary);
            }
            else
            {
                filterByGenre = algorithmManager.RemoveGenreFromQueue(Genre.Documentary, filterByGenre);
            }
        }

        private void chbEducational_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEducational.Checked)
            {
                filterByGenre.Enqueue(Genre.Educational);
            }
            else
            {
                filterByGenre = algorithmManager.RemoveGenreFromQueue(Genre.Educational, filterByGenre);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            lbMovies.Items.Clear();


            try
            {
                foreach (var item in algorithmManager.FilterByGenre(filterByGenre, productManager.LoadObjects().ToList()))
                {
                    if (item is Movie)
                    {
                        lbMovies.Items.Add(item);
                    }
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

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            lbMovies.Items.Clear();
            try
            {

                foreach (var item in productManager.LoadObjects())
                {
                    if (item is Movie)
                    {
                        lbMovies.Items.Add(item);
                    }
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
    }
}
