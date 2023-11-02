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

namespace CarRental.Forms.Car
{
    public partial class ListCarForm : Form
    {
        private CarRentalContext _context;
        private MainForm _mainForm;
        public ListCarForm(MainForm mainForm)
        {
            InitializeComponent();
            _context = mainForm._context;
            _mainForm = mainForm;
        }

        //------------------------------------------------------------
        // event
        //------------------------------------------------------------

        private void ListCarForm_Load(object sender, EventArgs e)
        {
            if (_mainForm.user.Role != AppUserRole.Admin)
            {
                addCarButton.Enabled = false;
                Remove.Visible = false;
            }

            loadCarList();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            Add_UpdateCarForm form = new Add_UpdateCarForm(_mainForm, _context);
            form.ShowDialog();
            loadCarList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            CarEntity entity = (CarEntity)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Remove"))
            {
                DialogResult = MessageBox.Show($"Do you want to remove {entity.NameCode}", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    _context.Remove(entity);
                    _context.SaveChanges();
                }
            }
            else
            {
                Add_UpdateCarForm form = new Add_UpdateCarForm(_mainForm, _context, entity);
                form.ShowDialog();
            }
            loadCarList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }

            loadCarList(searchText);
        }

        //------------------------------------------------------------
        // fun
        //------------------------------------------------------------

        private void loadCarList(string? searchText = null)
        {
            var query = _context.Cars.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = _context.Cars.Where(c =>
                    c.Brand.Contains(searchText) ||
                    c.NameCode.Contains(searchText) ||
                    c.CarName.Contains(searchText)
                    );
            }

            dataGridView1.DataSource = query.ToList();
        }
    }
}
