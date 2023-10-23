using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace CarRental.Forms.Statistic
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }
        
        private void StatisticForm_Load(object sender, EventArgs e)
        {
            var viewModel = new ViewModel();

            var cartesianChart = new CartesianChart
            {
                Series = viewModel.Series,
                LegendPosition = LiveChartsCore.Measure.LegendPosition.Top,
                XAxes = viewModel.XAxis,
                YAxes = viewModel.YAxis,
                // out of livecharts properties...
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(200, 200),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(cartesianChart);

        }
    }
}
