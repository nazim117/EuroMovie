using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWebApps_Desktop
{
    public partial class CheckSeriesForm : Form
    {
        ProductManager productManager;
        public CheckSeriesForm()
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            foreach (var item in productManager.LoadObjects())
            {
                if (item is Serie)
                {
                    lbSeries.Items.Add(item);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PopulateList();
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
            foreach (var item in productManager.Search(txtSearchName.Text, comparer))
            {
                if (item is Serie)
                {
                    lbSeries.Items.Add(item);
                }
            }
        }
    }
}
