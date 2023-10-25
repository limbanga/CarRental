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

        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviewPrice();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BookingNoteEntity entity = new BookingNoteEntity
            {
                CustomerId = (int)customerComboBox.SelectedValue,
                CarId = (int)carComboBox.SelectedValue,
                RentAt = rentAtDateTimePicker.Value,
                ReturnAt = returnAtDateTimePicker.Value
            };

            AddBooking(entity);
        }

        //----------------------------------------------------------------
        // fun
        //----------------------------------------------------------------

        private void PreviewPrice()
        {
            CarEntity car = (CarEntity)carComboBox.SelectedItem;

            DateTime rentAt = rentAtDateTimePicker.Value;
            DateTime returnAt = returnAtDateTimePicker.Value;

            int numOfDaysRent = returnAt.DayOfYear - rentAt.DayOfYear + 1;

            float totalPrice = car.PricePerDay * numOfDaysRent;

            priceLabel.Text =
                $"{rentAt.ToString("dd/mm/yyyy")} - {returnAt.ToString("dd/mm/yyyy")}," +
                $"      ${car.PricePerDay} x {numOfDaysRent} days,      Total: ${totalPrice}";
        }

        private void AddBooking(BookingNoteEntity entity)
        {
            _context.BookingNotes.Add(entity);
            _context.SaveChanges();
            MessageBox.Show("Add booking note successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
