using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;
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
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new ProductDAL());
            byte[] picture = null;
            try
            {
                productManager.Create(txtName.Text, 
                    txtDescription.Text, 
                    (Rating)cbbMovieRating.SelectedItem, 
                    int.Parse(txtDuration.Text), 
                    picture);

                MessageBox.Show("Account created successfully");
            }
            catch (MovieException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
