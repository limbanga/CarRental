using CarRental.Data;
using CarRental.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Forms.Auth
{
    public partial class LoginForm : Form
    {
        CarRentalContext _context;
        private bool _isExit = true;
        MainForm _mainForm;

        public LoginForm(CarRentalContext context, MainForm mainForm)
        {
            InitializeComponent();
            _context = context;
            _mainForm = mainForm;
        }

        //---------------------------------------------------------
        // event
        //---------------------------------------------------------

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!_context.AppUsers.Any())
            {
                CreateAdminAccount();
                SeedingData();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            AppUserEntity? user =
                _context.AppUsers.FirstOrDefault(u => u.Name.Equals(userName));

            if (user == null)
            {
                MessageBox.Show("User name doesn't exist.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.IsLocked)
            {
                MessageBox.Show("Your account is locked.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isVerified = BCrypt.Net.BCrypt.Verify(password, user.Password);
            if (!isVerified)
            {
                MessageBox.Show("Password is incorect.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _mainForm.user = user;

            _mainForm.DoAuthorization(user.Role == AppUserRole.Admin);

            _isExit = false;
            Close();
        }



        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isExit)
            {
                Application.Exit();
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        //---------------------------------------------------------
        // fun
        //---------------------------------------------------------

        private void CreateAdminAccount()
        {
            AppUserEntity admin = new AppUserEntity()
            {
                Name = "admin",
                Role = AppUserRole.Admin,
            };

            admin.Password = BCrypt.Net.BCrypt.HashPassword("Letmein12#");
            _context.AppUsers.Add(admin);
            _context.SaveChanges();
        }

        private void SeedingData()
        {
            _context.Cars.AddRange(
                new CarEntity 
                { 
                    CarName = "TOYOTA INNOVA 2016",
                    NameCode= "51F-738.29",
                    CarType=CarType.Sedan4, 
                    FuelType=FuelType.Gasoline,
                    Brand="TOYOTA",
                    PricePerDay=49,
                    Map= true,
                    MarginalCamera=true,
                    TireSensor=true,
                    Sunroof=true,
                    USB =true,
                    PickupTruckTrunkCover =true,
                    SpeedWarningKit = true,
                    BlueTooth =true,
                    DashCam = true,
                    CollisionSensor=true,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = true
                },
                new CarEntity
                {
                    CarName = "MITSUBISHI XPANDER 2022",
                    NameCode = "43C-834.14",
                    CarType = CarType.MPV7,
                    FuelType = FuelType.Gasoline,
                    Brand = "MITSUBISHI",
                    PricePerDay = 69,
                    Map = true,
                    MarginalCamera = true,
                    TireSensor = true,
                    Sunroof = true,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = true,
                    BlueTooth = true,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                },
                new CarEntity
                {
                    CarName = "TOYOTA VELOZ CROSS 2023",
                    NameCode = "56V-417.92",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Gasoline,
                    Brand = "TOYOTA",
                    PricePerDay = 89,
                    Map = true,
                    MarginalCamera = true,
                    TireSensor = true,
                    Sunroof = true,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = true,
                    BlueTooth = true,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                }, 
                new CarEntity
                {
                    CarName = "MITSUBISHI XPANDER 2019",
                    NameCode = "66S-635.74",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Gasoline,
                    Brand = "TOYOTA",
                    PricePerDay = 29,
                    Map = true,
                    MarginalCamera = true,
                    TireSensor = true,
                    Sunroof = true,
                    USB = true,
                    PickupTruckTrunkCover = true,
                    SpeedWarningKit = true,
                    BlueTooth = true,
                    DashCam = false,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                },
                new CarEntity
                {
                    CarName = "MITSUBISHI XPANDER 2019",
                    NameCode = "13Z-153.38",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Gasoline,
                    Brand = "TOYOTA",
                    PricePerDay = 99,
                    Map = true,
                    MarginalCamera = true,
                    TireSensor = true,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = true,
                    SpeedWarningKit = true,
                    BlueTooth = true,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                },
                new CarEntity
                {
                    CarName = "HONDA CITY 2020",
                    NameCode = "13Z-153.38",
                    CarType = CarType.Mini4,
                    FuelType = FuelType.Gasoline,
                    Brand = "HONDA",
                    PricePerDay = 39,
                    Map = true,
                    MarginalCamera = true,
                    TireSensor = true,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = true,
                    SpeedWarningKit = true,
                    BlueTooth = true,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                },
                new CarEntity
                {
                    CarName = "VINFAST LUX A 2021",
                    NameCode = "79X-246.87",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Gasoline,
                    Brand = "VINFAST",
                    PricePerDay = 59,
                    Map = true,
                    MarginalCamera = true,
                    TireSensor = true,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = true,
                    BlueTooth = true,
                    DashCam = false,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = true
                },
                new CarEntity
                {
                    CarName = "VINFAST VF8 ECO 2023",
                    NameCode = "45Z-829.12",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Electricity,
                    Brand = "VINFAST",
                    PricePerDay = 79,
                    Map = true,
                    MarginalCamera = false,
                    TireSensor = false,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = true,
                    BlueTooth = true,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = true
                },
                new CarEntity
                {
                    CarName = "VINFAST VF8 ECO 2023",
                    NameCode = "98P-218.61",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Electricity,
                    Brand = "VINFAST",
                    PricePerDay = 119,
                    Map = true,
                    MarginalCamera = false,
                    TireSensor = false,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = false,
                    BlueTooth = false,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = true
                },
                new CarEntity
                {
                    CarName = "TOYOTA INNOVA 2016",
                    NameCode = "45W-609.58",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Gasoline,
                    Brand = "TOYOTA",
                    PricePerDay = 24,
                    Map = true,
                    MarginalCamera = false,
                    TireSensor = false,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = false,
                    BlueTooth = false,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                },
                new CarEntity
                {
                    CarName = "FORD EVEREST 2009",
                    NameCode = "71S-230.54",
                    CarType = CarType.CUV5,
                    FuelType = FuelType.Diesel,
                    Brand = "FORD",
                    PricePerDay = 49,
                    Map = true,
                    MarginalCamera = false,
                    TireSensor = false,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = false,
                    BlueTooth = false,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                },
                new CarEntity
                {
                    CarName = "VINFAST VF E34 2022",
                    NameCode = "34S-244.63",
                    CarType = CarType.Mini4,
                    FuelType = FuelType.Electricity,
                    Brand = "VINFAST",
                    PricePerDay = 129,
                    Map = true,
                    MarginalCamera = false,
                    TireSensor = false,
                    Sunroof = false,
                    USB = true,
                    PickupTruckTrunkCover = false,
                    SpeedWarningKit = false,
                    BlueTooth = false,
                    DashCam = true,
                    CollisionSensor = false,
                    SpareTire = true,
                    GPS = true,
                    Camera360 = false
                });

            _context.Customers.AddRange(
                new CustomerEntity
                {
                    Name = "Huỳnh Thanh Liêm",
                    PhoneNumber = "093840238",
                    Address = "Long An"
                },
                new CustomerEntity
                {
                    Name = "Trần Dần",
                    PhoneNumber = "01231278",
                    Address = "Hoa Kỳ"
                },
                new CustomerEntity
                {
                    Name = "Nguyễn Quang Sáng",
                    PhoneNumber = "042893987",
                    Address = "Bắc Ninh"
                });
            _context.SaveChanges();
        }
    }
}
