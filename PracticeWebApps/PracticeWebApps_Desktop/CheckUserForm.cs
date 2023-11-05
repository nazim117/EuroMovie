using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;

namespace PracticeWebApps_Desktop
{
    public partial class CheckUserForm : Form
    {
        private UserManager userManager;
        public CheckUserForm()
        {
            InitializeComponent();
            userManager = new UserManager(new UserDAL());
            foreach (var item in userManager.LoadObjects())
            {
                lbUsers.Items.Add(item);
            }
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(((UserModel)lbUsers.SelectedItem).Name);
            this.Hide();
            userForm.ShowDialog();
            this.Show();
        }
    }
}
