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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CarRental.Forms.Customer
{
    public partial class ListCustomerForm : Form
    {
        CarRentalContext _context;
        MainForm _mainForm;

        public ListCustomerForm( MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _context = mainForm._context;
        }

        //----------------------------------------------------------
        // event
        //----------------------------------------------------------

        private void ListCustomerForm_Load(object sender, EventArgs e)
        {
            loadCustomer();
            if (_mainForm.user.Role != AppUserRole.Admin)
            {
                addCustomerButton.Enabled = false;
                Remove.Visible = false;
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Add_UpdateCustomerForm form = new Add_UpdateCustomerForm(_mainForm);
            form.ShowDialog();
            loadCustomer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            CustomerEntity customerEntity = (CustomerEntity)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Remove"))
            {
                DialogResult = MessageBox.Show($"Do you want to remove {customerEntity.Name}", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    _context.Remove(customerEntity);
                    _context.SaveChanges();
                }
            }
            else
            {
                Add_UpdateCustomerForm form = new Add_UpdateCustomerForm(_mainForm, customerEntity);
                form.ShowDialog();
            }

            loadCustomer();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return;
            }

            loadCustomer(searchText);
        }

        //----------------------------------------------------------
        // fun
        //----------------------------------------------------------

        private void loadCustomer(string? searchText = null)
        {
            var query = _context.Customers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = _context.Customers.Where(
                    x => x.Name.Contains(searchText) ||
                    x.PhoneNumber.Contains(searchText)
                    ).AsQueryable();
            }

            dataGridView1.DataSource = query.ToList();
        }

    }
}
