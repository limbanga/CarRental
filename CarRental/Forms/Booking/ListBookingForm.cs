using CarRental.Data;
using CarRental.Entities;
using CarRental.Forms.Car;
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
            LoadBooking();
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            Add_UpdateBookingForm form = new Add_UpdateBookingForm(_context);
            form.ShowDialog();
            LoadBooking();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            BookingNoteEntity entity = (BookingNoteEntity) dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Checkout"))
            {
                CheckoutBookingNoteForm form = new CheckoutBookingNoteForm();
                form.ShowDialog();
                //DialogResult = MessageBox.Show($"Do you want to remove {entity.NameCode}", "Confirm",
                //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (DialogResult == DialogResult.Yes)
                //{
                //    _context.Remove(entity);
                //    _context.SaveChanges();
                //}
            }

            LoadBooking();
        }

        //---------------------------------------------------------
        // fun
        //---------------------------------------------------------

        private void LoadBooking()
        {
            dataGridView1.DataSource = _context.BookingNotes.Include(b => b.Customer).Include(b => b.Car).ToList();
        }


    }
}
