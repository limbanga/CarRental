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
using CarRental.Data;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using DocumentFormat.OpenXml.Drawing.Charts;
using LiveChartsCore.Measure;
using LiveChartsCore.Defaults;
using LiveChartsCore.ConditionalDraw;
using LiveChartsCore.Themes;

namespace CarRental.Forms.Statistic
{
    public partial class StatisticForm : Form
    {
        CarRentalContext _context;

        /*
         NGHIEN CUU SAU
        https://livecharts.dev/docs/WinForms/2.0.0-rc1/CartesianChart.Cartesian%20chart%20control#axes
         */
        private Axis[] XAxis = { new Axis {
            Name="Number of car by type",
            IsVisible = true,
            SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
            MinStep = 1,
            MinLimit = 0,
            }
        };
        private Axis[] YAxis = { new Axis { IsVisible = false } };

        public StatisticForm(CarRentalContext context)
        {
            InitializeComponent();
            _context = context;
        }

        //--------------------------------------------------
        // event
        //--------------------------------------------------

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            PilotInfo[] data = new PilotInfo[0];

            var viewModel = new ViewModel(data);

            cartesianChart1.Series = viewModel.Series;
            cartesianChart1.XAxes = XAxis;
            cartesianChart1.YAxes = YAxis;

            LoadCarByType();
        }

        //--------------------------------------------------
        // fun
        //--------------------------------------------------

        private void LoadCarByType()
        {
            var listCar = _context.Cars.ToList();
            int numberOfCar = listCar.Count();
            totalCarLabel.Text = $"Total car : {numberOfCar}";


            var groups = listCar.GroupBy(x => x.CarType);
            List<PilotInfo> list = new List<PilotInfo>();
            int i = 0;
            foreach (var group in groups)
            {
                list.Add(new PilotInfo(
                                group.Key.ToString(),
                                group.Count(),
                                new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                i++;
            }

            var rowSeries = new RowSeries<PilotInfo>
            {
                Name = "Car",
                Values = list.OrderBy(x => x.Value).ToArray(),
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new(-1, 0),
                DataLabelsFormatter = point => $"{point.Model!.Name} {point.Coordinate.PrimaryValue}",
                MaxBarWidth = 50,
                Padding = 10,
            }
            .OnPointMeasured(point =>
            {
                // assign a different color to each point
                if (point.Visual is null) return;
                point.Visual.Fill = point.Model!.Paint;
            });

            ISeries[] Series = new[] { rowSeries };
            cartesianChart1.Series = Series;
        }
    }
}
