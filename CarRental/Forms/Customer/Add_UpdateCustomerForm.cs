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

namespace CarRental.Forms.Customer
{
    public partial class Add_UpdateCustomerForm : Form
    {
        MainForm _mainForm;
        CarRentalContext _context;
        CustomerEntity? _customerEntity = null;

        public Add_UpdateCustomerForm(
            MainForm mainForm,
            CustomerEntity? customerEntity = null
            )
        {
            InitializeComponent();
            _mainForm = mainForm;
            _context = mainForm._context;
            _customerEntity = customerEntity;
        }

        //-----------------------------------------------------------------
        // event
        //-----------------------------------------------------------------

        private void Add_UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            if (_customerEntity != null)
            {
                Text = "Update customer";
                BindOldValue(_customerEntity);
            }

            if (_mainForm.user.Role != AppUserRole.Admin)
            {
                saveButton.Enabled = false;    
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_customerEntity == null)
                {
                    _customerEntity = new CustomerEntity();
                    GetInput(_customerEntity);
                    AddCustomer(_customerEntity);
                }
                else
                {
                    GetInput(_customerEntity);
                    UpdateCustomer(_customerEntity);
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

        //-----------------------------------------------------------------
        // fun
        //-----------------------------------------------------------------

        private void GetInput(CustomerEntity customerEntity)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                throw new ValidateException("Customer name can't be blank.");
            }

            if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                throw new ValidateException("Phone number can't be blank.");
            }

            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                throw new ValidateException("Address can't be blank.");
            }

            customerEntity.Name = nameTextBox.Text;
            customerEntity.PhoneNumber = phoneNumberTextBox.Text;
            customerEntity.Address = addressTextBox.Text;
        }

        private void BindOldValue(CustomerEntity customerEntity)
        {
            nameTextBox.Text = customerEntity.Name;
            phoneNumberTextBox.Text = customerEntity.PhoneNumber;
            addressTextBox.Text = customerEntity.Address;
        }

        private void UpdateCustomer(CustomerEntity customerEntity)
        {
            var isPhoneNumberExist = _context.Customers
            .Where(x => 
                !x.Id.Equals(customerEntity.Id) &&
                x.PhoneNumber.Equals(customerEntity.PhoneNumber))
            .Any();

            if (isPhoneNumberExist)
            {
                throw new ValidateException("Phone number is already exist.");
            }

            _context.Customers.Update(customerEntity);
            _context.SaveChanges();
            MessageBox.Show("Update customer successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddCustomer(CustomerEntity customerEntity)
        {
            var isPhoneNumberExist = _context.Customers
                        .Where(x => x.PhoneNumber.Equals(customerEntity.PhoneNumber)).Any();
            
            if (isPhoneNumberExist)
            {
                throw new ValidateException("Phone number is already exist.");
            }

            _context.Customers.Add(customerEntity);
            _context.SaveChanges();
            MessageBox.Show("Add new customer successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
