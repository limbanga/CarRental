using CarRental.Data;
using CarRental.Forms.Car;
using CarRental.Forms.Customer;

namespace CarRental
{
    public partial class MainForm : Form
    {
        CarRentalContext _context;
        public MainForm()
        {
            InitializeComponent();
            _context = new CarRentalContext();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadForm(new ListCarForm(_context));
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ListCarForm(_context));
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ListCustomerForm(_context));
        }

        //---------------------------------------------------------
        // fun
        //---------------------------------------------------------
        private void loadForm(Form form)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.Show();
        }
    }
}