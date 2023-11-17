using CarRental.Data;
using CarRental.Entities;
using CarRental.Exceptions;
using CarRental.Forms.Auth;
using CarRental.Forms.Booking;
using CarRental.Forms.Car;
using CarRental.Forms.Customer;
using CarRental.Forms.Staff;
using CarRental.Forms.Statistic;
using CarRental.Helper;
using ClosedXML.Excel;
using Ganss.Excel;
using NPOI.SS.Formula.Functions;

namespace CarRental
{
    public partial class MainForm : Form
    {
        public CarRentalContext _context;
        public AppUserEntity user = null!;

        public MainForm()
        {
            InitializeComponent();
            _context = new CarRentalContext();
        }

        //---------------------------------------------------------
        // event
        //---------------------------------------------------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(_context, this);
            form.ShowDialog();
            Hide();

            LoadForm(new ListCarForm(this));
            Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ListCarForm(this));
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ListCustomerForm(this));
        }

        private void bookingNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ListBookingForm(_context));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm(_context, this);
            form.ShowDialog();

            if (user.Role != AppUserRole.Admin)
            {
                staffToolStripMenuItem.Visible = false;
            }

            LoadForm(new ListCarForm(this));
            Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(_context, user.Name);
            form.ShowDialog();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new StatisticForm(_context));
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook| *.xlsx";

            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "customers.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var customers = _context.Customers.ToList();

                    ExcelHelper.Export<CustomerEntity>(
                        customers,
                        saveFileDialog.FileName,
                        "Sheet1");

                    MessageBox.Show("Save to file successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Workbook| *.xlsx";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var tmpCustomers = ExcelHelper.Import<CustomerEntity>(openFileDialog.FileName);

                    List<CustomerEntity> customers = new List<CustomerEntity>(tmpCustomers.Count);
                    foreach (var customer in tmpCustomers)
                    {
                        customers.Add(new CustomerEntity
                        {
                            Name = customer.Name,
                            PhoneNumber = customer.PhoneNumber,
                            Address = customer.Address,
                        });
                    }

                    AddCustomers(customers);

                    MessageBox.Show("Import customer successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (AppContextException ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook| *.xlsx";

            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "cars.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var cars = _context.Cars.ToList();

                    ExcelHelper.Export<CarEntity>(
                        cars,
                        saveFileDialog.FileName,
                        "Sheet1");

                    MessageBox.Show("Save to file successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Workbook| *.xlsx";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var tmpCars = ExcelHelper.Import<CarEntity>(openFileDialog.FileName);
                    List<CarEntity> cars = new List<CarEntity>(tmpCars.Count);
                    foreach (var car in tmpCars)
                    {
                        cars.Add(new CarEntity
                        {
                            CarName = car.CarName,
                            NameCode = car.NameCode,
                            CarType = car.CarType,
                            FuelType = car.FuelType,
                            Brand = car.Brand,
                            PricePerDay = car.PricePerDay,
                            Map = car.Map,
                            MarginalCamera = car.MarginalCamera,
                            TireSensor = car.TireSensor,
                            ReversingCamera = car.ReversingCamera,
                            Sunroof = car.Sunroof,
                            USB = car.USB,
                            PickupTruckTrunkCover = car.PickupTruckTrunkCover,
                            SpeedWarningKit = car.SpeedWarningKit,
                            BlueTooth = car.BlueTooth,
                            DashCam = car.DashCam,
                            CollisionSensor = car.CollisionSensor,
                            GPS = car.GPS,
                            SpareTire = car.SpareTire,
                            Camera360 = car.Camera360
                        });
                    }

                    AddCars(cars);

                    MessageBox.Show("Import customer successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (AppContextException ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ListStaffForm(_context));
        }

        //---------------------------------------------------------
        // fun
        //---------------------------------------------------------

        private void LoadForm(Form form)
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.Clear();
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            panelMain.Tag = form;
            form.Show();
        }

        private void AddCustomers(List<CustomerEntity> customers)
        {
            string addFail = "";
            foreach (var customer in customers)
            {
                try
                {
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    addFail += $"{customer.PhoneNumber} - {customer.Name}\n";
                }
            }


            if (!string.IsNullOrEmpty(addFail))
            {
                throw new AppContextException($"Failed to insert: \n{addFail}");
            }
        }

        private void AddCars(List<CarEntity> cars)
        {
            string addFail = "";
            foreach (var car in cars)
            {
                try
                {
                    _context.Cars.Add(car);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    addFail += $"{car.NameCode} - {car.CarName}\n";
                }

            }


            if (!string.IsNullOrEmpty(addFail))
            {
                throw new AppContextException($"Failed to insert: \n{addFail}");
            }
        }

        public void DoAuthorization(bool isAdminRole)
        {
            staffToolStripMenuItem.Visible = isAdminRole;
            importToolStripMenuItem.Visible = isAdminRole;
            exportToolStripMenuItem.Visible = isAdminRole;
            importToolStripMenuItem1.Visible = isAdminRole;
            exportToolStripMenuItem1.Visible = isAdminRole;
        }
    }
}