using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_Domain.SortTypes;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;

namespace PracticeWebApps_Desktop
{
    public partial class CheckUserForm : Form
    {
        private UserManager userManager;
        private AlgorithmManager<UserModel> algorithmManager;
        public CheckUserForm()
        {
            InitializeComponent();
            userManager = new UserManager(new UserDAL());
            algorithmManager = new AlgorithmManager<UserModel>();
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
            lbUsers.Items.Clear();
            foreach (var item in userManager.LoadObjects())
            {
                lbUsers.Items.Add(item);
            }
            this.Show();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                PopulateList();
            }

            foreach (var item in algorithmManager.SearchUser(txtSearchName.Text, userManager.LoadObjects().ToList()))
            {
                lbUsers.Items.Add(item);
            }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            IComparer<UserModel> comparer = new SortByName();

            if (rbName.Checked)
            {
                comparer = new SortByName();
            }
            else if (rbEmail.Checked)
            {
                comparer = new SortByEmail();
            }

            lbUsers.Items.Clear();
            foreach (var item in algorithmManager.MergeSort(userManager.LoadObjects().ToList(), comparer))
            {
                lbUsers.Items.Add(item);
                
            }
        }

        private void rbEmail_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
        }
    }
}
