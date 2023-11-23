using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PracticeWebApps_Desktop
{
    public partial class UserForm : Form
    {
        private UserManager _userManager;
        private string _userName;
        public UserForm(string userName)
        {
            InitializeComponent();
            _userManager = new UserManager(new UserDAL());
            txtName.Text = _userManager.GetObject(userName).Name;
            txtEmail.Text = _userManager.GetObject(userName).Email;
            txtPhone.Text = _userManager.GetObject(userName).Phone;
            _userName = userName;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string previousEmail = _userManager.GetObject(_userName).Email;
            try
            {
                if (_userManager.EditObject(new UserModel(
                        txtName.Text,
                        txtEmail.Text,
                        txtPhone.Text), previousEmail))
                {
                    MessageBox.Show("Edit was successful");
                }
                else
                {
                    MessageBox.Show("Error occurred. Edit was not successful");
                }

            }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); }
            catch (UserException ex) { MessageBox.Show(ex.Message); }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userManager.DeleteObject(_userManager.GetObject(_userName)))
                {
                    Console.WriteLine("User deleted successfully");
                }
                else
                {
                    Console.WriteLine("Problem occurred. User was not deleted");
                }
            }
            catch (SqlNullValueException ex) { MessageBox.Show(ex.Message); }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (TimeoutException ex) { MessageBox.Show(ex.Message); }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            this.Close();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
