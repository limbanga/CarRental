using CarRental.Data;
using CarRental.Forms.Auth;
using CarRental.Forms.Booking;
using CarRental.Forms.Car;
using CarRental.Forms.Customer;

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

    }
}