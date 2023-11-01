using CarRental.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Forms.Staff
{
    public partial class ListStaffForm : Form
    {
        CarRentalContext _context;

        public ListStaffForm(CarRentalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           Add_UpdateStaffForm form = new Add_UpdateStaffForm(_context);
           form.ShowDialog();
        }
    }
}
