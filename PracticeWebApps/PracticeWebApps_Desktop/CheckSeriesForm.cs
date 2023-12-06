using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;

namespace PracticeWebApps_Desktop
{
    public partial class CheckSeriesForm : Form
    {
        ProductManager productManager;
        AlgorithmManager<Product> algorithmManager;
        public CheckSeriesForm()
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            algorithmManager = new AlgorithmManager<Product>();

            PopulateList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbSeries.Items.Clear();
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                PopulateList();
            }

            foreach (var item in algorithmManager.SearchProduct(txtSearchName.Text, productManager.LoadObjects().ToList()))
            {
                if (item is Serie)
                {
                    lbSeries.Items.Add(item);
                }
            }
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
            foreach (var item in algorithmManager.MergeSort(productManager.LoadObjects().ToList(), comparer))
            {
                if (item is Serie)
                {
                    lbSeries.Items.Add(item);
                }
            }
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
    }
}
