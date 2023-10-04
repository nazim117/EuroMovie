using PracticeWebApps_DAL_Library;
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
    public partial class CheckUserForm : Form
    {
        UserManager userManager;
        public CheckUserForm()
        {
            InitializeComponent();
            userManager = new UserManager(new UserDAL());
            lbUsers.DataSource = userManager.LoadObjects();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*UserForm userForm = new UserForm((UserModel)lbUsers.SelectedItem);
            userForm.ShowDialog();*/
        }
    }
}
