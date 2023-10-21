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
        CarRentalContext _context;
        CustomerEntity? customerEntity = null;

        public Add_UpdateCustomerForm(
            CarRentalContext context,
            CustomerEntity? customerEntity = null
            )
        {
            InitializeComponent();
            _context = context;
            this.customerEntity = customerEntity;
        }

        //-----------------------------------------------------------------
        // event
        //-----------------------------------------------------------------

        private void Add_UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            if (customerEntity != null)
            {
                Text = "Update customer";
                bindOldValue(customerEntity);
            }
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerEntity == null)
                {
                    customerEntity = new CustomerEntity();
                    getInput(customerEntity);
                    addCustomer(customerEntity);
                }
                else
                {
                    getInput(customerEntity);
                    updateCustomer(customerEntity);
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

        private void getInput(CustomerEntity customerEntity)
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

        private void bindOldValue(CustomerEntity customerEntity)
        {
            nameTextBox.Text = customerEntity.Name;
            phoneNumberTextBox.Text = customerEntity.PhoneNumber;
            addressTextBox.Text = customerEntity.Address;
        }

        private void updateCustomer(CustomerEntity customerEntity)
        {
            _context.Customers.Update(customerEntity);
            _context.SaveChanges();
            MessageBox.Show("Update customer successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addCustomer(CustomerEntity customerEntity)
        {
            _context.Customers.Add(customerEntity);
            _context.SaveChanges();
            MessageBox.Show("Add new customer successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
