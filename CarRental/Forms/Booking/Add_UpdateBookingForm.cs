using CarRental.Data;
using CarRental.Entities;
using CarRental.Exceptions;
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
    public partial class Add_UpdateBookingForm : Form
    {
        CarRentalContext _context;

        private bool _isFillterProcessing = false;

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
            LoadCarComboboxSource();
        }

        // ------------------------PREVIEW PRICE EVENT-------------------
        #region preview price
        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviewPrice();
        }

        private void rentAtDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (rentAtDateTimePicker.Value > returnAtDateTimePicker.Value)
            {
                MessageBox.Show("Rent day can't be after return day.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                rentAtDateTimePicker.Value = returnAtDateTimePicker.Value;
            }

            PreviewPrice();
        }

        private void returnAtDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (rentAtDateTimePicker.Value > returnAtDateTimePicker.Value)
            {
                MessageBox.Show("Return day can't be before rent day.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                returnAtDateTimePicker.Value = rentAtDateTimePicker.Value;
            }

            PreviewPrice();
        }
        #endregion
        //---------------------------------------------------------------

        // -------------------------FILLTER EVENT-----------------------
        #region fillter
        private void mapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void sunroofCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }
        private void blueToothCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void gPSCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void marginalCameraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void uSBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void dashCamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void spareTireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void tireSensorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void pickupTruckTrunkCoverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void collisionSensorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void camera360CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void reversingCameraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void SpeedWarningKitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }
        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void gasolineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void dieselRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void electricityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Fillter();
        }
        #endregion
        //--------------------------------------------------------------

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                BookingNoteEntity entity = new BookingNoteEntity
                {
                    CustomerId = (int)customerComboBox.SelectedValue,
                    CarId = (int)carComboBox.SelectedValue,
                    RentAt = rentAtDateTimePicker.Value,
                    ReturnAt = returnAtDateTimePicker.Value
                };

                AddBooking(entity);
                Close();
            }
            catch (AppContextException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void clearFillterButton_Click(object sender, EventArgs e)
        {
            _isFillterProcessing = true;

            allRadioButton.Checked = true;

            foreach (var ctr in groupBox1.Controls)
            {
                if (ctr is CheckBox)
                {
                    ((CheckBox)ctr).Checked = false;
                }
            }

            _isFillterProcessing = false;
            Fillter();
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

        private void Fillter()
        {
            if (_isFillterProcessing)
            {
                return;
            }

            FuelType? fuelType = null;

            if (gasolineRadioButton.Checked)
            {
                fuelType = FuelType.Gasoline;
            }
            else if (dieselRadioButton.Checked)
            {
                fuelType = FuelType.Diesel;
            }
            else if (electricityRadioButton.Checked)
            {
                fuelType = FuelType.Electricity;
            }

            LoadCarComboboxSource(
                fuelType: fuelType,
                isMap: mapCheckBox.Checked,
                isSunRoof: sunroofCheckBox.Checked,
                isBlueTooth: blueToothCheckBox.Checked,
                isGPS: gPSCheckBox.Checked,
                isMarginalCamera: marginalCameraCheckBox.Checked,
                isUSB: uSBCheckBox.Checked,
                isDashCam: dashCamCheckBox.Checked,
                isSpareTire: spareTireCheckBox.Checked,
                isTireSensor: tireSensorCheckBox.Checked,
                isPickupTruckTrunkCover: pickupTruckTrunkCoverCheckBox.Checked,
                isCollisionSensor: collisionSensorCheckBox.Checked,
                isCamera360: camera360CheckBox.Checked,
                isReversingCamera: reversingCameraCheckBox.Checked,
                isSpeedWarningKit: SpeedWarningKitCheckBox.Checked
                );

            if (carComboBox.Items.Count == 0)
            {
                addButton.Enabled = false;
                rentAtDateTimePicker.Enabled = false;
                returnAtDateTimePicker.Enabled = false;
                priceLabel.Text = "Not found car for your request.";
                carComboBox.Text = string.Empty;
            }
            else
            {
                addButton.Enabled = true;
                rentAtDateTimePicker.Enabled = true;
                returnAtDateTimePicker.Enabled = true;
                priceLabel.Text = "Please choose a car for preview price.";
            }
        }

        private void AddBooking(BookingNoteEntity entity)
        {
            BookingNoteEntity? isCarBusy = _context.BookingNotes.Where(x =>
                x.CarId.Equals(entity.CarId) &&
                (
                    (x.RentAt <= entity.ReturnAt && x.RentAt >= entity.RentAt) ||
                    (x.ReturnAt <= entity.ReturnAt && x.ReturnAt >= entity.RentAt) ||
                    (x.RentAt <= entity.RentAt && x.ReturnAt >= entity.ReturnAt)
                )
            ).FirstOrDefault();

            if (isCarBusy != null)
            {
                throw new AppContextException($"Car was hired by {isCarBusy.UserName} at that time.");
            }

            _context.BookingNotes.Add(entity);
            _context.SaveChanges();
            MessageBox.Show("Add booking note successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadCarComboboxSource(
            FuelType? fuelType = null,
            bool isMap = false,
            bool isSunRoof = false,
            bool isBlueTooth = false,
            bool isGPS = false,
            bool isMarginalCamera = false,
            bool isUSB = false,
            bool isDashCam = false,
            bool isSpareTire = false,
            bool isTireSensor = false,
            bool isPickupTruckTrunkCover = false,
            bool isCollisionSensor = false,
            bool isCamera360 = false,
            bool isReversingCamera = false,
            bool isSpeedWarningKit = false
            )
        {
            var query = _context.Cars.AsQueryable();
            #region fillter
            if (isMap)
            {
                query = query.Where(x => x.Map).AsQueryable();
            }

            if (isSunRoof)
            {
                query = query.Where(x => x.Sunroof).AsQueryable();
            }

            if (isBlueTooth)
            {
                query = query.Where(x => x.BlueTooth).AsQueryable();
            }

            if (isGPS)
            {
                query = query.Where(x => x.GPS).AsQueryable();
            }

            if (isMarginalCamera)
            {
                query = query.Where(x => x.MarginalCamera).AsQueryable();
            }

            if (isUSB)
            {
                query = query.Where(x => x.USB).AsQueryable();
            }

            if (isDashCam)
            {
                query = query.Where(x => x.DashCam).AsQueryable();
            }

            if (isSpareTire)
            {
                query = query.Where(x => x.SpareTire).AsQueryable();
            }

            if (isTireSensor)
            {
                query = query.Where(x => x.TireSensor).AsQueryable();
            }

            if (isPickupTruckTrunkCover)
            {
                query = query.Where(x => x.PickupTruckTrunkCover).AsQueryable();
            }

            if (isCollisionSensor)
            {
                query = query.Where(x => x.CollisionSensor).AsQueryable();
            }

            if (isCamera360)
            {
                query = query.Where(x => x.Camera360).AsQueryable();
            }

            if (isReversingCamera)
            {
                query = query.Where(x => x.ReversingCamera).AsQueryable();
            }

            if (isSpeedWarningKit)
            {
                query = query.Where(x => x.SpeedWarningKit).AsQueryable();
            }

            if (fuelType != null)
            {
                query = query.Where(x => x.FuelType.Equals(fuelType)).AsQueryable();
            }
            #endregion

            //MessageBox.Show("Test" + query.ToQueryString());

            carComboBox.DataSource = query.ToList();
        }

    }
}
