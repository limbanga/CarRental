using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using LiveChartsCore.Measure;
using LiveChartsCore.Defaults;
using LiveChartsCore.ConditionalDraw;
using LiveChartsCore.Themes;

namespace CarRental.Forms.Statistic
{
    public class PilotInfo : ObservableValue
    {
        public PilotInfo(string name, int value, SolidColorPaint paint)
        {
            Name = name;
            Paint = paint;
            // the ObservableValue.Value property is used by the chart
            Value = value;
        }

        public string Name { get; set; }
        public SolidColorPaint Paint { get; set; }
    }

    public class ViewModel : ObservableValue
    {
        private readonly Random _r = new();
        private readonly PilotInfo[] _data;
        public ISeries[] Series;

        public Axis[] XAxis = { new Axis { IsVisible = true, SeparatorsPaint = new SolidColorPaint(new SKColor(145, 145, 145)) } };

        public Axis[] YAxis = { new Axis { IsVisible = false} };

        public ViewModel()
        {
            // generate some paints for each pilot:
            var paints = Enumerable.Range(0, 7)
                .Select(i => new SolidColorPaint(ColorPalletes.MaterialDesign500[i].AsSKColor()))
                .ToArray();

            // generate some data for each pilot:
            _data = new PilotInfo[]
            {
                new("Tsunoda",   500,  paints[0]),
                new("Sainz",     450,  paints[1]),
                new("Riccardo",  520,  paints[2]),
                new("Bottas",    550,  paints[3]),
                new("Perez",     660,  paints[4]),
                new("Verstapen", 920,  paints[5]),
                new("Hamilton",  1000, paints[6])
            };

            var rowSeries = new RowSeries<PilotInfo>
            {
                Name = "USD",
                Values = _data.OrderBy(x => x.Value).ToArray(),
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

            Series = new[] { rowSeries };
        }
    }
}
