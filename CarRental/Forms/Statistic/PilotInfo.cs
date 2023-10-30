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
        public PilotInfo(string name, double value, SolidColorPaint paint)
        {
            Name = name;
            Paint = paint;
            Value = value;
        }

        public string Name { get; set; }
        public SolidColorPaint Paint { get; set; }
    }
}
