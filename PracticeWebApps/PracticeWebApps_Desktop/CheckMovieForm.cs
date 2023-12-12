using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;

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

            foreach (var item in algorithmManager.SearchProduct(txtNameSearch.Text, productManager.LoadObjects().ToList()))
            {
                if (item is Movie)
                {
                    lbMovies.Items.Add(item);
                }
            }
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
            foreach (var item in algorithmManager.MergeSort(productManager.LoadObjects().ToList(), comparer))
            {
                if (item is Movie)
                {
                    lbMovies.Items.Add(item);
                }
            }
        }

        private void chbAdventure_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdventure.Checked)
            {
                filterByGenre.Enqueue(Genre.Adventure);
            }
        }

        private void chbAction_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAction.Checked)
            {
                filterByGenre.Enqueue(Genre.Action);
            }
        }

        private void chbDrama_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDrama.Checked)
            {
                filterByGenre.Enqueue(Genre.Drama);
            }
        }

        private void chbComedy_CheckedChanged(object sender, EventArgs e)
        {
            if (chbComedy.Checked)
            {
                filterByGenre.Enqueue(Genre.Comedy);
            }
        }

        private void chbHorror_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHorror.Checked)
            {
                filterByGenre.Enqueue(Genre.Horror);
            }
        }

        private void chbDocumentary_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDocumentary.Checked)
            {
                filterByGenre.Enqueue(Genre.Documentary);
            }
        }

        private void chbEducational_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEducational.Checked)
            {
                filterByGenre.Enqueue(Genre.Educational);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lbMovies.Items.Clear();

            foreach (var item in algorithmManager.FilterByGenre(filterByGenre, productManager.LoadObjects().ToList()))
            {
                lbMovies.Items.Add(item);
            }
        }
    }
}
