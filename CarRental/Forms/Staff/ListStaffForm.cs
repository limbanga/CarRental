using CarRental.Data;
using CarRental.Entities;
using CarRental.Forms.Customer;
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
    public partial class ListStaffForm : Form
    {
        CarRentalContext _context;

        public ListStaffForm(CarRentalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        //---------------------------------------------------
        // event
        //---------------------------------------------------

        private void ListStaffForm_Load(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add_UpdateStaffForm form = new Add_UpdateStaffForm(_context);
            form.ShowDialog();
            LoadStaffList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            AppUserEntity staffEntity = (AppUserEntity)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            Add_UpdateStaffForm form = new Add_UpdateStaffForm(_context, staffEntity);
            form.ShowDialog();

            LoadStaffList();
        }


        //---------------------------------------------------
        // fun
        //---------------------------------------------------

        private void LoadStaffList()
        {
            dataGridView1.DataSource = _context.AppUsers.ToList();
        }
    }
}
