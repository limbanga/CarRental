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
        private bool _fisrtRender = true;
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
            _fisrtRender = false;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(yearComboBox.Text);
            int month = Convert.ToInt32(monthComboBox.Text);

            if (salesRadioButton.Checked)
            {
                if (yearRadioButton.Checked)
                {
                    if (noneGroupRadioButton.Checked)
                    {
                        _statictisForm.LoadSale(year);
                    }
                    else if (carTypeRadioButton.Checked)
                    {
                        _statictisForm.LoadSaleGroupBy(year, 1);
                    }
                    else
                    {
                        _statictisForm.LoadSaleGroupBy(year, 2);
                    }
                }
                else
                {
                    if (noneGroupRadioButton.Checked)
                    {
                        _statictisForm.LoadSale(year, month);
                    }
                    else if (carTypeRadioButton.Checked)
                    {
                        _statictisForm.LoadSaleGroupBy(year, month, 1);
                    }
                    else
                    {
                        _statictisForm.LoadSaleGroupBy(year, month, 2);
                    }
                }
            }
            else
            {
                if (yearRadioButton.Checked)
                {
                    if (noneGroupRadioButton.Checked)
                    {
                        _statictisForm.LoadQuantity(year);
                    }
                    else if (carTypeRadioButton.Checked)
                    {
                        _statictisForm.LoadQuantityGroupBy(year, 1);
                    }
                    else
                    {
                        _statictisForm.LoadQuantityGroupBy(year, 2);
                    }
                }
                else
                {
                    if (noneGroupRadioButton.Checked)
                    {
                        _statictisForm.LoadQuantity(year, month);
                    }
                    else if (carTypeRadioButton.Checked)
                    {
                        _statictisForm.LoadQuantityGroupBy(year, month, 1);
                    }
                    else
                    {
                        _statictisForm.LoadQuantityGroupBy(year, month, 2);
                    }
                }
            }
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_fisrtRender)
            {
                bindMonthCombobox();
            }
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------
        // event
        //------------------------------------------------------

        private void bindYearCombobox()
        {
            List<int> list = new List<int>();
            for (int i = DateTime.Now.Year; i >= 2022 ; i--)
            {
                list.Add(i);
            }
            yearComboBox.DataSource = list;
        }

        private void bindMonthCombobox()
        {
            int maxMonth = 12;
            if (Convert.ToInt32(yearComboBox.Text) == DateTime.Now.Year)
            {
                maxMonth = DateTime.Now.Month;
            }

            List<int> months = new List<int>();
            for (int i = maxMonth; i >= 1; i--)
            {
                months.Add(i);
            }

            monthComboBox.DataSource = months;
        }

        private void yearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            monthComboBox.Enabled = monthRadioButton.Checked;
        }
    }
}
