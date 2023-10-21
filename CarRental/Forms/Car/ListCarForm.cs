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
        public ListCarForm(CarRentalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ListCarForm_Load(object sender, EventArgs e)
        {
            loadCarList();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            Add_UpdateCarForm form = new Add_UpdateCarForm(_context);
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
                DialogResult = MessageBox.Show($"Do you want to remove { entity.NameCode }", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    _context.Remove(entity);
                    _context.SaveChanges();
                }
            }
            else
            {
                Add_UpdateCarForm form = new Add_UpdateCarForm(_context, entity);
                form.ShowDialog();
            }
            loadCarList();
        }

        //------------------------------------------------------------
        // fun
        //------------------------------------------------------------

        private void loadCarList()
        {
            dataGridView1.DataSource = _context.Cars.ToList();
        }


    }
}
