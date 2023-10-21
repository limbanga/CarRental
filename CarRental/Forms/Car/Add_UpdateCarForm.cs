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
                bindOldValue(carEntity);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (carEntity == null)
                {
                    carEntity = new CarEntity();
                    getInput(carEntity);
                    addCar(carEntity);
                }
                else
                {
                    //carEntity.NameCode = entity.NameCode;
                    //carEntity.Brand = entity.Brand;
                    //carEntity.CarType = entity.CarType;
                    getInput(carEntity);
                    updateCar(carEntity);
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

        private void bindOldValue(CarEntity carEntity)
        {
            nameCodeTextBox.Text = carEntity.NameCode;
            brandTextBox.Text = carEntity.Brand;
            carTypeComboBox.SelectedItem = carEntity.CarType;
        }

        private void getInput(CarEntity entity)
        {
            if (nameCodeTextBox.Text.Length == 0)
            {
                throw new ValidateException("Name code can't be blank.");
            }

            if (brandTextBox.Text.Length == 0)
            {
                throw new ValidateException("Brand can't be blank.");
            }

            entity.NameCode = nameCodeTextBox.Text;
            entity.Brand = brandTextBox.Text;
            entity.CarType = ((CarType)carTypeComboBox.SelectedValue);
        }

        private void addCar(CarEntity entity)
        {
            _context.Cars.Add(entity);
            _context.SaveChanges();
            MessageBox.Show("Add new car successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateCar(CarEntity entity)
        {
            _context.Cars.Update(entity);
            _context.SaveChanges();
            MessageBox.Show("Update car successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
