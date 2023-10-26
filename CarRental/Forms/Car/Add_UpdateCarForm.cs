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

namespace CarRental.Forms.Car
{
    public partial class Add_UpdateCarForm : Form
    {
        CarEntity? carEntity = null;
        CarRentalContext _context;

        public Add_UpdateCarForm(CarRentalContext context, CarEntity? carEntity = null)
        {
            InitializeComponent();
            _context = context;
            this.carEntity = carEntity;
        }

        //--------------------------------------------------------------
        // event
        //--------------------------------------------------------------

        private void Add_UpdateCarForm_Load(object sender, EventArgs e)
        {
            carTypeComboBox.DataSource = Enum.GetValues(typeof(CarType));
            if (carEntity != null)
            {
                Text = "Update car";
                BindOldValue(carEntity);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (carEntity == null)
                {
                    carEntity = new CarEntity();
                    GetInput(carEntity);
                    AddCar(carEntity);
                }
                else
                {
                    GetInput(carEntity);
                    UpdateCar(carEntity);
                }
                Close();
            }
            catch (ValidateException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                throw;
            }

        }

        //-------------------------------------------------------------------
        // fun
        //-------------------------------------------------------------------

        private void BindOldValue(CarEntity carEntity)
        {
            nameCodeTextBox.Text = carEntity.NameCode;
            brandTextBox.Text = carEntity.Brand;
            pricePerDayTextBox.Text = carEntity.PricePerDay.ToString();
            carTypeComboBox.SelectedItem = carEntity.CarType;


            mapCheckBox.Checked = carEntity.Map;
            marginalCameraCheckBox.Checked = carEntity.MarginalCamera;
            tireSensorCheckBox.Checked = carEntity.TireSensor;
            reversingCameraCheckBox.Checked = carEntity.ReversingCamera;
            sunroofCheckBox.Checked = carEntity.Sunroof;
            uSBCheckBox.Checked = carEntity.USB;
            pickupTruckTrunkCoverCheckBox.Checked = carEntity.PickupTruckTrunkCover;
            speedWarningKitCheckBox.Checked = carEntity.SpeedWarningKit;
            blueToothCheckBox.Checked = carEntity.BlueTooth;
            dashCamCheckBox.Checked = carEntity.DashCam;
            collisionSensorCheckBox.Checked = carEntity.CollisionSensor;
            gPSCheckBox.Checked = carEntity.GPS;
            spareTireCheckBox.Checked = carEntity.SpareTire;
            camera360CheckBox.Checked = carEntity.Camera360;

            switch (carEntity.FuelType)
            {
                case FuelType.Gasoline:
                    gasolineRadioButton.Checked = true;
                    break;
                case FuelType.Diesel:
                    dieselRadioButton.Checked = true;
                    break;
                case FuelType.Electricity:
                    ElectricityRadioButton.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void GetInput(CarEntity entity)
        {
            if (nameCodeTextBox.Text.Length == 0)
            {
                throw new ValidateException("Name code can't be blank.");
            }

            if (brandTextBox.Text.Length == 0)
            {
                throw new ValidateException("Brand can't be blank.");
            }

            double pricePerDay;
            if (!Double.TryParse(pricePerDayTextBox.Text, out pricePerDay))
            {
                throw new ValidateException("Price per day must be number.");
            }

            entity.NameCode = nameCodeTextBox.Text;
            entity.Brand = brandTextBox.Text;
            entity.PricePerDay = (float)pricePerDay;
            entity.CarType = ((CarType)carTypeComboBox.SelectedValue);

            entity.Map = mapCheckBox.Checked;
            entity.MarginalCamera = marginalCameraCheckBox.Checked;
            entity.TireSensor = tireSensorCheckBox.Checked;
            entity.ReversingCamera = reversingCameraCheckBox.Checked;
            entity.Sunroof = sunroofCheckBox.Checked;
            entity.USB = uSBCheckBox.Checked;
            entity.PickupTruckTrunkCover = pickupTruckTrunkCoverCheckBox.Checked;
            entity.SpeedWarningKit = speedWarningKitCheckBox.Checked;
            entity.BlueTooth = blueToothCheckBox.Checked;
            entity.DashCam = dashCamCheckBox.Checked;
            entity.CollisionSensor = collisionSensorCheckBox.Checked;
            entity.GPS = gPSCheckBox.Checked;
            entity.SpareTire = spareTireCheckBox.Checked;
            entity.Camera360 = camera360CheckBox.Checked;

            if (gasolineRadioButton.Checked)
            {
                entity.FuelType = FuelType.Gasoline;
            }
            else if (dieselRadioButton.Checked)
            {
                entity.FuelType = FuelType.Diesel;
            }
            else
            {
                entity.FuelType = FuelType.Electricity;
            }
        }

        private void AddCar(CarEntity entity)
        {
            _context.Cars.Add(entity);
            _context.SaveChanges();
            MessageBox.Show("Add new car successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCar(CarEntity entity)
        {
            _context.Cars.Update(entity);
            _context.SaveChanges();
            MessageBox.Show("Update car successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
