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
    public partial class CheckSeriesForm : Form
    {
        ProductManager productManager;
        AlgorithmManager<Product> algorithmManager;
        Queue<Genre> filterByGenre;

        public CheckSeriesForm()
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            algorithmManager = new AlgorithmManager<Product>();
            filterByGenre = new Queue<Genre>();

            PopulateList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbSeries.Items.Clear();
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                PopulateList();
                return;
            }


            try
            {
                foreach (var item in algorithmManager.SearchProduct(txtSearchName.Text, productManager.LoadObjects().ToList()))
                {
                    if (item is Serie)
                    {
                        lbSeries.Items.Add(item);
                    }
                }
            }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); Application.Exit(); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); Application.Exit(); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); Application.Exit(); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); Application.Exit(); }
            catch (NumberOutOfRangeException ex) { MessageBox.Show(ex.Message); }
            catch (ProductException ex) { MessageBox.Show(ex.Message); }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void rbMovieRating_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void rbGenre_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            else if (rbMovieRating.Checked)
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

            lbSeries.Items.Clear();
            try
            {
                foreach (var item in algorithmManager.MergeSort(productManager.LoadObjects().ToList(), comparer))
                {
                    if (item is Serie)
                    {
                        lbSeries.Items.Add(item);
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

        private void CheckSeriesForm_Load(object sender, EventArgs e)
        {

        }

        private void lbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSeries.SelectedItem == null)
            {
                MessageBox.Show("Select a movie to edit/delete");
                return;
            }

            SeriesForm seriesForm = new SeriesForm(((Serie)lbSeries.SelectedItem).Name);
            this.Hide();
            seriesForm.ShowDialog();
            PopulateList();
            this.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();

        }

        private void Filter()
        {
            lbSeries.Items.Clear();

            try
            {
                foreach (var item in algorithmManager.FilterByGenre(filterByGenre, productManager.LoadObjects().ToList()))
                {
                    if (item is Serie)
                    {
                        lbSeries.Items.Add(item);
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
            lbSeries.Items.Clear();

            try
            {
                foreach (var item in productManager.LoadObjects())
                {
                    if (item is Serie)
                    {
                        lbSeries.Items.Add(item);
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
    }
}
