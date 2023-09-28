using PracticeWebApps_DAL_Library;
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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            
            if (txtPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            UserManager userManager = new UserManager(new UserDAL());
            PasswordHashingManager passwordHashing = new PasswordHashingManager();
            string salt = passwordHashing.GetSalt();
            string passHash = passwordHashing.GetHash(txtPassword.Text, salt);

            userManager.CreateUser(txtName.Text, txtEmail.Text, txtPhone.Text, false, passHash, salt);

            MessageBox.Show("Account created successfully");
        }
    }
}
