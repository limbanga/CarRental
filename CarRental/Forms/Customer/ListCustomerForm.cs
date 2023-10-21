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

namespace CarRental.Forms.Customer
{
    public partial class ListCustomerForm : Form
    {
        CarRentalContext _context;
        public ListCustomerForm(CarRentalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        //----------------------------------------------------------
        // event
        //----------------------------------------------------------

        private void ListCustomerForm_Load(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Add_UpdateCustomerForm form = new Add_UpdateCustomerForm(_context);
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
                Add_UpdateCustomerForm form = new Add_UpdateCustomerForm(_context, customerEntity);
                form.ShowDialog();
            }

            loadCustomer();
        }

        //----------------------------------------------------------
        // fun
        //----------------------------------------------------------

        private void loadCustomer()
        {
            dataGridView1.DataSource = _context.Customers.ToList();
        }

    }
}
