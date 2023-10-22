using CarRental.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class ListBookingForm : Form
    {
        CarRentalContext _context;
        public ListBookingForm(CarRentalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        //----------------------------------------------------------
        // event
        //----------------------------------------------------------

        private void ListBookingForm_Load(object sender, EventArgs e)
        {
            loadBooking();
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            Add_UpdateBookingForm form = new Add_UpdateBookingForm(_context); 
            form.ShowDialog();
            loadBooking();
        }

        //---------------------------------------------------------
        // fun
        //---------------------------------------------------------

        private void loadBooking()
        {
            dataGridView1.DataSource = _context.BookingNotes.Include(b => b.Customer).Include(b => b.Car).ToList();
        }
    }
}
