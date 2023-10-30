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

        //------------------------------------------------------
        // event
        //------------------------------------------------------

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            bindYearCombobox();
            bindMonthCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _statictisForm.LoadCarBy(2);
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------
        // event
        //------------------------------------------------------

        private void bindYearCombobox()
        {
            yearComboBox.Items.Clear();
            List<int> list = new List<int>();
            for (int i = 2022; i <= DateTime.Now.Year; i++)
            {
                list.Add(i);
            }
            yearComboBox.DataSource = list;
        }

        private void bindMonthCombobox()
        {
            monthComboBox.Items.Clear();
            int[] months = new int[12];
            for (int i = 1; i <= 12; i++)
            {
                months[i - 1] = i;
            }
            monthComboBox.DataSource = months;
        }

        private void yearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            monthComboBox.Enabled = monthRadioButton.Checked;
        }
    }
}
