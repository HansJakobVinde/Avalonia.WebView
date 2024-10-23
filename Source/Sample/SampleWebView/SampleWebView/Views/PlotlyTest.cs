using Plotly.NET;
using Plotly.NET.LayoutObjects;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SampleWebView.Views
{
    public class PlotlyGraph
    {
        private GenericChart chart;

        public PlotlyGraph()
        {
            // Initialize the chart with a title
            chart = Chart2D.Chart.Scatter<double, double, string>(
                x: new List<double>(),
                y: new List<double>(),
                mode: StyleParam.Mode.Markers,
                Name: "Altitude Over Time",
                Line: Line.init(Width: 2) // Customize line appearance
            );

            // chart = Chart.withTitle(chart, "Real-Time Data Visualization");
            // chart = Chart.withX_Axis(chart, "Time");
            // chart = Chart.withY_Axis(chart, "Altitude");
        }

        public void UpdateGraph(List<(double x, double y)> dataPoints)
        {
            // Update chart data by adding a new trace
            chart = Chart2D.Chart.Scatter<double, double, string>(
                x: dataPoints.Select(dp => dp.x).ToList(),
                y: dataPoints.Select(dp => dp.y).ToList(),
                mode: StyleParam.Mode.Markers,
                Name: "Altitude Over Time",
                Line: Line.init(Width: 2)
            );
        }

        public string GetHtml()
        {
            // Get the HTML content of the chart
            return GenericChart.toEmbeddedHTML(chart);
        }

    }
}
