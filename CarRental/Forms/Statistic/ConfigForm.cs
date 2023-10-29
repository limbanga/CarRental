using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Forms.Statistic
{
    public partial class ConfigForm : Form
    {
        private readonly StatisticForm _statictisForm;

        public ConfigForm(StatisticForm statictisForm)
        {
            InitializeComponent();
            _statictisForm = statictisForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _statictisForm.LoadCarBy(2);
            Close();
        }
    }
}
