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

namespace CarRental.Forms.Booking
{
    public partial class Add_UpdateBookingForm : Form
    {
        CarRentalContext _context;

        public Add_UpdateBookingForm(CarRentalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        //----------------------------------------------------------------
        // event
        //----------------------------------------------------------------

        private void Add_UpdateBookingForm_Load(object sender, EventArgs e)
        {
            customerComboBox.DataSource = _context.Customers.ToList();
            carComboBox.DataSource = _context.Cars.ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------
        // fun
        //----------------------------------------------------------------
    }
}
