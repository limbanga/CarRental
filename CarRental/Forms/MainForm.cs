using CarRental.Data;
using CarRental.Entities;
using CarRental.Forms.Auth;
using CarRental.Forms.Booking;
using CarRental.Forms.Car;
using CarRental.Forms.Customer;
using CarRental.Forms.Statistic;
using CarRental.Helper;
using ClosedXML.Excel;
using Ganss.Excel;
using NPOI.SS.Formula.Functions;

namespace CarRental
{
    public partial class MainForm : Form
    {
        CarRentalContext _context;
        public string userName = null!;

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

            LoadForm(new ListCarForm(_context));
            Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ListCarForm(_context));
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ListCustomerForm(_context));
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

            LoadForm(new ListCarForm(_context));
            Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(_context, userName);
            form.ShowDialog();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new StatisticForm(_context));
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

                    var customers = ExcelHelper.Import<CustomerEntity>(openFileDialog.FileName);

                    string temp = "";
                    foreach (var item in customers)
                    {
                        temp += item.ComboboxDisplay.ToString() + "\n";
                    }

                    //MessageBox.Show("Load to file successfully.", "Success",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MessageBox.Show("Test" + temp);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}