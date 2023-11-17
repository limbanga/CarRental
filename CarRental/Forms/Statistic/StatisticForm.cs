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
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.ExcelAc;

namespace CarRental.Forms.Statistic
{
    public partial class StatisticForm : Form
    {
        CarRentalContext _context;

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
            DateTime now = DateTime.Now;
            LoadSale(now.Year, now.Month);
        }

        private void configPictureBox_Click(object sender, EventArgs e)
        {
            ConfigForm form = new ConfigForm(this);
            form.ShowDialog();
        }

        //--------------------------------------------------
        // fun
        //--------------------------------------------------

        /// <summary>
        /// groupBy : 
        ///     1 -> CarType
        ///     2 -> Brand
        /// </summary>
        public void LoadSale(int year)
        {
            titleLabel.Text = $"Sales in {year}";
            var bookingnotes = _context.BookingNotes.Where(b => b.RealReturnAt.Year.Equals(year)).ToList();

            float totalSale = bookingnotes.Sum(b => b.TotalFee);
            totalCarLabel.Text = $"Total sale : {totalSale}";

            var groups = bookingnotes.GroupBy(x => x.RealReturnAt.Month);
            double[] list = new double[12];

            for (int i = 0; i < 12; i++)
            {
                list[i] = 0;
            }

            foreach (var group in groups)
            {
                list[group.Key - 1] = (group.Sum(b => b.TotalFee));
            }

            ISeries[] Series =
            {
                new LineSeries<double>
                {
                    Values = list,
                    Fill = null,
                }
            };

            Axis[] XAxis = { new Axis {
                    Name="Month",
                    IsVisible = true,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                    MinLimit = 0,
                    MaxLimit = 11,
                    MinStep = 1,
                    Labels = new[] {"1", "2", "3", "4", "5", "6", "7", "8", "9" , "10", "11", "12" }
                }
            };

            Axis[] YAxis = { new Axis {
                    Name = "$ Dollar",
                    IsVisible = true,
                    MinLimit= 0,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                }
            };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;
        }
        public void LoadSaleGroupBy(int year, int groupBy)
        {
            titleLabel.Text = $"Sales in {year} by {(groupBy == 2? "Brand": "Type")}";

            var listBookingNote = _context.BookingNotes
                        .Where(b => b.RealReturnAt.Year.Equals(year))
                        .ToList();

            float totalSale = listBookingNote.Sum(b => b.TotalFee);
            totalCarLabel.Text = $"Total sale : {totalSale}";

            List<PilotInfo> list = new List<PilotInfo>();

            if (groupBy == 2)
            {
                var groups = listBookingNote.GroupBy(x => x.Car!.Brand);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Sum(b => b.TotalFee),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
            }
            else
            {
                var groups = listBookingNote.GroupBy(x => x.Car!.CarType);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Sum(b => b.TotalFee),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
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
                if (point.Visual is null) return;
                point.Visual.Fill = point.Model!.Paint;
            });

            ISeries[] Series = new[] { rowSeries };


            Axis[] XAxis = { new Axis {
                Name= $"Sales in {year}",
                IsVisible = true,
                SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                MinStep = 1,
                MinLimit = 0,
                }
            };

            Axis[] YAxis = { new Axis { IsVisible = false } };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;
        }
        public void LoadSale(int year, int month)
        {
            titleLabel.Text = $"Sales in {month}/{year}";

            int numberOfDay = DateTime.DaysInMonth(year, month);
            var bookingnotes = _context.BookingNotes
                .Where(b =>
                    b.RealReturnAt.Year.Equals(year) &&
                    b.RealReturnAt.Month.Equals(month)
                    )
                .ToList();

            float totalSale = bookingnotes.Sum(b => b.TotalFee);
            totalCarLabel.Text = $"Total sale : {totalSale}";

            var groups = bookingnotes.GroupBy(x => x.RealReturnAt.Day);
            List<double> list = new List<double>(numberOfDay);
            string[] xLabels = new string[numberOfDay];

            for (int i = 0; i < numberOfDay; i++)
            {
                list.Add(0);
                xLabels[i] = $"D{i + 1}";
            }

            foreach (var group in groups)
            {
                list.Insert(group.Key - 1, group.Sum(b => b.TotalFee));
            }

            ISeries[] Series =
            {
                new LineSeries<double>
                {
                    Values = list,
                    Fill = null,
                }
            };

            Axis[] XAxis = { new Axis {
                    Name="Days",
                    IsVisible = true,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                    MinLimit = 0,
                    MaxLimit = numberOfDay,
                    MinStep = 1,
                    Labels = xLabels
                }
            };

            Axis[] YAxis = { new Axis {
                    Name = "$ Dollar",
                    IsVisible = true,
                    MinLimit= 0,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                }
            };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;

        }
        public void LoadSaleGroupBy(int year, int month, int groupBy)
        {
            titleLabel.Text = $"Sales in {month}/{year} by {(groupBy == 2 ? "Brand" : "Type")}";

            var listBookingNote = _context.BookingNotes
                                    .Where(b =>
                                        b.RealReturnAt.Year.Equals(year) &&
                                        b.RealReturnAt.Month.Equals(month)
                                        )
                                    .ToList();

            float totalSale = listBookingNote.Sum(b => b.TotalFee);
            totalCarLabel.Text = $"Total sale : {totalSale}";

            List<PilotInfo> list = new List<PilotInfo>();

            if (groupBy == 2)
            {
                var groups = listBookingNote.GroupBy(x => x.Car!.Brand);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Sum(b => b.TotalFee),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
            }
            else
            {
                var groups = listBookingNote.GroupBy(x => x.Car!.CarType);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Sum(b => b.TotalFee),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
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
                if (point.Visual is null) return;
                point.Visual.Fill = point.Model!.Paint;
            });

            ISeries[] Series = new[] { rowSeries };


            Axis[] XAxis = { new Axis {
                Name= $"Sales in {year}",
                IsVisible = true,
                SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                MinStep = 1,
                MinLimit = 0,
                }
            };

            Axis[] YAxis = { new Axis { IsVisible = false } };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;
        }
        public void LoadQuantity(int year)
        {
            titleLabel.Text = $"Quantity car was hired in {year}";

            var bookingnotes = _context.BookingNotes.Where(b => b.RealReturnAt.Year.Equals(year)).ToList();
            float numberOfCar = bookingnotes.Count;
            totalCarLabel.Text = $"Total car : {numberOfCar}";

            var groups = bookingnotes.GroupBy(x => x.RealReturnAt.Month);
            double[] list = new double[12];

            for (int i = 0; i < 12; i++)
            {
                list[i] = 0;
            }

            foreach (var group in groups)
            {
                list[group.Key - 1] = (group.Count());
            }

            ISeries[] Series =
            {
                new LineSeries<double>
                {
                    Values = list,
                    Fill = null,
                }
            };

            Axis[] XAxis = { new Axis {
                    Name="Month",
                    IsVisible = true,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                    MinLimit = 0,
                    MaxLimit = 11,
                    MinStep = 1,
                    Labels = new[] {"M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9" , "M10", "M11", "M12" }
                }
            };

            Axis[] YAxis = { new Axis {
                    Name = "Car",
                    IsVisible = true,
                    MinLimit= 0,
                    MinStep = 1,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                }
            };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;
        }
        public void LoadQuantityGroupBy(int year, int groupBy)
        {
            titleLabel.Text = $"Quantity car was hired in {year} by {(groupBy == 2? "Brand": "Type")}";
            var listCar = _context.BookingNotes
                                    .Where(b => b.RealReturnAt.Year.Equals(year))
                                    .ToList();

            int numberOfCar = listCar.Count();
            totalCarLabel.Text = $"Total car : {numberOfCar}";

            List<PilotInfo> list = new List<PilotInfo>();

            if (groupBy == 2)
            {
                var groups = listCar.GroupBy(x => x.Car!.Brand);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Count(),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
            }
            else
            {
                var groups = listCar.GroupBy(x => x.Car!.CarType);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Count(),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
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
                if (point.Visual is null) return;
                point.Visual.Fill = point.Model!.Paint;
            });

            ISeries[] Series = new[] { rowSeries };


            Axis[] XAxis = { new Axis {
                Name= $"Car was rent in {year}",
                IsVisible = true,
                SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                MinStep = 1,
                MinLimit = 0,
                }
            };

            Axis[] YAxis = { new Axis { IsVisible = false } };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;
        }
        public void LoadQuantity(int year, int month)
        {
            int numberOfDay = DateTime.DaysInMonth(year, month);

            titleLabel.Text = $"Quantity car was hired in {month}/{year}";

            var bookingnotes = _context.BookingNotes
                .Where(b =>
                        b.RealReturnAt.Year.Equals(year) &&
                        b.RealReturnAt.Month.Equals(month)
                        )
                .ToList();

            float numberOfCar = bookingnotes.Count;
            totalCarLabel.Text = $"Total car : {numberOfCar}";

            var groups = bookingnotes.GroupBy(x => x.RealReturnAt.Day);

            List<double> list = new List<double>(numberOfDay);
            string[] xLabels = new string[numberOfDay];
            for (int i = 0; i < numberOfDay; i++)
            {
                list.Add(0);
                xLabels[i] = $"D{i + 1}";
            }

            foreach (var group in groups)
            {
                list.Insert(group.Key - 1, group.Count());
            }

            ISeries[] Series =
            {
                new LineSeries<double>
                {
                    Values = list,
                    Fill = null,
                }
            };

            Axis[] XAxis = { new Axis {
                    Name="Month",
                    IsVisible = true,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                    MinLimit = 0,
                    MaxLimit = numberOfDay,
                    MinStep = 1,
                    Labels = xLabels
                }
            };

            Axis[] YAxis = { new Axis {
                    Name = "Car",
                    IsVisible = true,
                    MinLimit= 0,
                    MinStep = 1,
                    SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                }
            };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;
        }
        public void LoadQuantityGroupBy(int year, int month, int groupBy)
        {
           titleLabel.Text = $"Quantity car was hired in {month}/{year} by {(groupBy == 2 ? "Brand": "Type")}";

            var listCar = _context.BookingNotes
                            .Where(b =>
                                    b.RealReturnAt.Year.Equals(year) &&
                                    b.RealReturnAt.Month.Equals(month)
                             )
                            .ToList();

            int numberOfCar = listCar.Count();
            totalCarLabel.Text = $"Total car : {numberOfCar}";

            List<PilotInfo> list = new List<PilotInfo>();

            if (groupBy == 2)
            {
                var groups = listCar.GroupBy(x => x.Car!.Brand);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Count(),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
            }
            else
            {
                var groups = listCar.GroupBy(x => x.Car!.CarType);
                int i = 0;
                foreach (var group in groups)
                {
                    list.Add(new PilotInfo(
                                    group.Key.ToString(),
                                    group.Count(),
                                    new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor())));
                    i++;
                }
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
                if (point.Visual is null) return;
                point.Visual.Fill = point.Model!.Paint;
            });

            ISeries[] Series = new[] { rowSeries };


            Axis[] XAxis = { new Axis {
                Name= $"Car was rent in {year}",
                IsVisible = true,
                SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)),
                MinStep = 1,
                MinLimit = 0,
                }
            };

            Axis[] YAxis = { new Axis { IsVisible = false } };

            cartesianChart.XAxes = XAxis;
            cartesianChart.YAxes = YAxis;
            cartesianChart.Series = Series;
        }
    }
}
