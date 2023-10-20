using CarRental.Data;
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
        public ListCarForm()
        {
            InitializeComponent();
            _context = new CarRentalContext();
        }

        private void ListCarForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Cars.ToList();
        }
    }
}
