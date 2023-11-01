    using CarRental.Data;
using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Forms.Auth
{
    public partial class LoginForm : Form
    {
        CarRentalContext _context;
        private bool _isExit = true;
        MainForm _mainForm;

        public LoginForm(CarRentalContext context, MainForm mainForm)
        {
            InitializeComponent();
            _context = context;
            _mainForm = mainForm;
        }

        //---------------------------------------------------------
        // event
        //---------------------------------------------------------

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!_context.AppUsers.Any())
            {
                CreateAdminAccount();
            }

            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            AppUserEntity? user =
                _context.AppUsers.FirstOrDefault(u => u.Name.Equals(userName));

            if (user == null)
            {
                MessageBox.Show("User name doesn't exist.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isVerified = BCrypt.Net.BCrypt.Verify(password, user.Password);
            if (!isVerified)
            {
                MessageBox.Show("Password is incorect.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _mainForm.user = user;

            _isExit = false;
            Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isExit)
            {
                Application.Exit();
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        //---------------------------------------------------------
        // fun
        //---------------------------------------------------------

        private void CreateAdminAccount()
        {
            AppUserEntity admin = new AppUserEntity()
            {
                Name = "admin",
                Role = AppUserRole.Admin,
            };

            admin.Password = BCrypt.Net.BCrypt.HashPassword("admin");
            _context.AppUsers.Add(admin);
            _context.SaveChanges();
        }

    }
}
