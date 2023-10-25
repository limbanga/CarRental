using CarRental.Data;
using CarRental.Entities;
using CarRental.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Forms.Auth
{
    public partial class ChangePasswordForm : Form
    {
        CarRentalContext _context;
        string userName;
        public ChangePasswordForm(CarRentalContext context, string userName)
        {
            InitializeComponent();
            _context = context;
            this.userName = userName;
        }

        //--------------------------------------------------------------
        // event
        //--------------------------------------------------------------

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();
                ChangePassword();
            }
            catch (ValidateException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //--------------------------------------------------------------
        // fun
        //--------------------------------------------------------------

        private void ValidateInput()
        {
            if (oldPasswordTextBox.Text.Length < 8 ||
                newPasswordTextBox.Text.Length < 8)
            {
                throw new ValidateException("Password must be at least 8 chacracters.");
            }

            if (!string.Equals(newPasswordTextBox.Text, confirmTextBox.Text))
            {
                throw new ValidateException("Confirm password doesn't match.");
            }
        }

        private void ChangePassword()
        {
            string oldPassword = oldPasswordTextBox.Text;
            AppUserEntity? user =
                _context.AppUsers.FirstOrDefault(u => u.Name.Equals(userName));

            if (user == null)
            {
                MessageBox.Show("Your account doesn't exist or has been remove.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isVerified = BCrypt.Net.BCrypt.Verify(oldPassword, user.Password);
            if (!isVerified)
            {
                MessageBox.Show("Old password is incorect.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newPassword = newPasswordTextBox.Text;
            user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            _context.AppUsers.Update(user);
            _context.SaveChanges();
            MessageBox.Show("Your password has been changed.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

    }
}
