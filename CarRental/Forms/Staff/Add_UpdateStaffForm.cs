using CarRental.Data;
using CarRental.Entities;
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
        }

        private void togglePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !togglePasswordCheckBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _staff = new AppUserEntity();
                GetInput();
                AddStaff();
                MessageBox.Show("Add new staff successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {

                throw;
            }
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
            _staff.Password = passwordTextBox.Text;
            _staff.Role = (AppUserRole)roleComboBox.SelectedItem;
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

            _staff.Password = BCrypt.Net.BCrypt.HashPassword(passwordTextBox.Text);
            _context.AppUsers.Add(_staff);
            _context.SaveChanges();
        }
    }
}
