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
        public CheckoutBookingNoteForm()
        {
            InitializeComponent();
        }

        //------------------------------------------------
        // event
        //------------------------------------------------

        private void CheckoutBookingNoteForm_Load(object sender, EventArgs e)
        {
            rentAtDateTimePicker.Value = new DateTime(2003, 3, 14);
        }

        //------------------------------------------------
        // fun
        //------------------------------------------------
    }
}
