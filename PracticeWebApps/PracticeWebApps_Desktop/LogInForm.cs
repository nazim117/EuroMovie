﻿using Microsoft.VisualBasic.Logging;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_LogicLibrary.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWebApps_Desktop
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInManager logInManager = new LogInManager(new LogInDAL());
            string salt = logInManager.GetSalt(txtName.Text);
            string hashedPass = logInManager.GetHashedPassword(txtName.Text);

            PasswordHashingManager passwordHashing = new PasswordHashingManager();

            if (passwordHashing.ValidatePassword(txtPassword.Text, salt, hashedPass))
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }


        }
    }
}
