using CarRental.Data;
using CarRental.Entities;
using CarRental.Helper;
using MathNet.Numerics.Statistics.Mcmc;
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
    public partial class CheckoutBookingNoteForm : Form
    {
        CarRentalContext _context;
        BookingNoteEntity _entity;

        private DateTime realReturnAt = DateTime.Now;
        private float totalFee = 0;
        private float lateFeeRate = 1;
        private float indemnity = 0;


        public CheckoutBookingNoteForm(
            BookingNoteEntity bookingNoteEntity,
            CarRentalContext context)
        {
            InitializeComponent();
            _entity = bookingNoteEntity;
            _context = context;
        }

        //------------------------------------------------
        // event
        //------------------------------------------------

        private void CheckoutBookingNoteForm_Load(object sender, EventArgs e)
        {
            lateFeeRateTextBox.Text = lateFeeRate.ToString();
            indemnityTextBox.Text = indemnity.ToString();
            BindValue();
        }

        private void lateFeeRateTextBox_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            if (Double.TryParse(lateFeeRateTextBox.Text, out tmp))
            {
                lateFeeRate = (float)tmp;
                if (tmp < 1)
                {
                    MessageBox.Show("Late fee rate should be greater than 1.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BindValue();
            }
        }

        private void indemnity_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            if (Double.TryParse(indemnityTextBox.Text, out tmp))
            {
                indemnity = (float)tmp;
                if (tmp < 0)
                {
                    MessageBox.Show("Indemnity should be greater than 0.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BindValue();
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                _entity.RealReturnAt = realReturnAt;
                _entity.TotalFee = totalFee;
                CheckoutBookingNote(_entity);
                MessageBox.Show("Checkout booking note successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //------------------------------------------------
        // fun
        //------------------------------------------------

        private void BindValue()
        {
            totalFee = indemnity;

            rentAtDateTimePicker.Value = _entity.RentAt;
            returnAtDateTimePicker.Value = _entity.ReturnAt;
            realReturnAtLabel.Text = _entity.IsReturn ? _entity.RealReturnAt.ToString("dd/MM/yyyy") : DateTime.Now.ToString("dd/MM/yyyy");

            customerComboBox.Text = _entity.Customer!.ComboboxDisplay;
            carComboBox.Text = _entity.CarName;

            int dayCount = DateHelper.CountDayInclusive(_entity.RentAt, _entity.ReturnAt);
            float carPrice = _entity.Car!.PricePerDay;
            float bookingFee = dayCount * carPrice;
            totalFee += bookingFee;

            bookingFeeLabel.Text =
                $"{_entity.RentAt.ToString("dd/MM/yyyy")} - {_entity.ReturnAt.ToString("dd/MM/yyyy")}" +
                $",      ${carPrice} x {dayCount} days,      Total: ${bookingFee}";


            if (_entity.IsReturn)
            {
                checkoutButton.Enabled = false;
                checkoutButton.Text = "Checked out";

                realReturnAt = _entity.RealReturnAt;
            }
            else
            {
                indemnityTextBox.Enabled = true;
                lateFeeRateTextBox.Enabled = true;
            }

            if (realReturnAt.Date <= _entity.ReturnAt.Date)
            {
                overDueFeeLabel.Text = "In term, no overdue fee";
            }
            else
            {
                DateTime aDateAfterDue = _entity.ReturnAt.AddDays(1);
                int countOverDays = DateHelper.CountDayInclusive(aDateAfterDue, realReturnAt);
                float overDueFee = countOverDays * carPrice * lateFeeRate;
                totalFee += overDueFee;

                overDueFeeLabel.Text =
                    $"{realReturnAt.ToString("dd/MM/yyyy")} - {aDateAfterDue.ToString("dd/MM/yyyy")},      " +
                    $"${carPrice} x {countOverDays} days x {lateFeeRate},      Total: ${overDueFee}";
            }

            totalFeeLabel.Text = $"TOTAL FREE: ${totalFee}";
        }

        private void CheckoutBookingNote(BookingNoteEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
