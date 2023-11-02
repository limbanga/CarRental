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

namespace CarRental.Forms.Staff
{
    public partial class Add_UpdateStaffForm : Form
    {
        CarRentalContext _context;
        AppUserEntity? _staff = null;

        public Add_UpdateStaffForm(CarRentalContext context, AppUserEntity? staff = null)
        {
            InitializeComponent();
            _context = context;
            _staff = staff;
        }

        //----------------------------------------------------
        // event
        //----------------------------------------------------

        private void Add_UpdateStaffForm_Load(object sender, EventArgs e)
        {
            BindRoleCombobox();
            BindOldValue();

        }

        private void togglePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !togglePasswordCheckBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_staff is null)
                {
                    _staff = new AppUserEntity();
                    GetInput();
                    AddStaff();
                    MessageBox.Show("Add new staff successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetInput();
                    UpdateStaff();
                    MessageBox.Show("Add new staff successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
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

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = string.Empty;
        }

        //----------------------------------------------------
        // fun
        //----------------------------------------------------

        private void GetInput()
        {
            if (_staff is null)
            {
                throw new Exception("Add_UpdateStaffForm.GetInput: _staff is null");
            }

            _staff.Name = loginNametextBox.Text;
            _staff.Role = (AppUserRole)roleComboBox.SelectedItem;
            _staff.IsLocked = isLockedcheckBox.Checked;
        }

        private void BindRoleCombobox()
        {
            var roles = Enum.GetValues(typeof(AppUserRole));
            List<AppUserRole> acceptRoles = new List<AppUserRole>();
            foreach (var role in roles)
            {
                if (((AppUserRole)role) != AppUserRole.Admin)
                {
                    acceptRoles.Add((AppUserRole)role);
                }
            }

            roleComboBox.DataSource = acceptRoles;
        }

        private void AddStaff()
        {
            if (_staff is null)
            {
                throw new Exception("AddStaff: _staff is null");
            }

            if (passwordTextBox.Text.Length < 8)
            {
                throw new ValidateException("Password must be at least 8 characters.");
            }

            var isLoginNameExist = _context.AppUsers
                .Where(u => u.Name.Equals(loginNametextBox.Text))
                .Any();

            if (isLoginNameExist)
            {
                throw new ValidateException("Login name already exist.");
            }

            _staff.Password = BCrypt.Net.BCrypt.HashPassword(passwordTextBox.Text);
            _context.AppUsers.Add(_staff);
            _context.SaveChanges();
        }

        private void UpdateStaff()
        {
            if (_staff is null)
            {
                throw new Exception("AddStaff: _staff is null");
            }

            var isLoginNameExist = _context.AppUsers
                .Where(u => 
                    !u.Id.Equals(_staff.Id) &&
                    u.Name.Equals(loginNametextBox.Text))
                .Any();

            if (isLoginNameExist)
            {
                throw new ValidateException("Login name already exist.");
            }

            if (passwordTextBox.Text.Length < 8)
            {
                throw new ValidateException("Password must be at least 8 characters.");
            }

            if (!passwordTextBox.Text.Equals(_staff.Password))
            {
                _staff.Password = BCrypt.Net.BCrypt.HashPassword(passwordTextBox.Text);
            }

            _context.AppUsers.Update(_staff);
            _context.SaveChanges();
        }

        private void BindOldValue()
        {
            if (_staff is null)
            {
                return;
            }

            loginNametextBox.Text = _staff.Name;
            passwordTextBox.Text = _staff.Password;
            isLockedcheckBox.Checked = _staff.IsLocked;

            Text = "Update staff";
        }
    }
}
