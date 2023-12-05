﻿using Microsoft.VisualBasic.Devices;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;
using System;
using System.Collections;
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
    public partial class CheckMovieForm : Form
    {
        ProductManager productManager;
        AlgorithmManager<Product> algorithmManager;
        public CheckMovieForm()
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            algorithmManager = new AlgorithmManager<Product>();

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
    }
}
