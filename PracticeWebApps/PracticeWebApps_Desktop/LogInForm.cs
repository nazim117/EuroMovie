using PracticeWebApps_DAL_Library;
using PracticeWebApps_LogicLibrary.Managers;

namespace PracticeWebApps_Desktop
{
    //Authentication with Dictionary
    public partial class LogInForm : Form
    {
        Dictionary<string, bool> admins;
        public LogInForm()
        {
            InitializeComponent();
            admins = new Dictionary<string, bool>
            {
                { "Michael", true },
                { "Sterling", true },
                { "Joe", true }
            };
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (!admins.ContainsKey(txtName.Text))
            {
                MessageBox.Show("User does not have permission for this application");
                return;
            }

            LogInManager logInManager = new LogInManager(new LogInDAL());
            string salt = logInManager.GetSalt(txtName.Text);
            string hashedPass = logInManager.GetHashedPassword(txtName.Text);

            PasswordHashingManager passwordHashing = new PasswordHashingManager();

            if (passwordHashing.ValidatePassword(txtPassword.Text, salt, hashedPass))
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
