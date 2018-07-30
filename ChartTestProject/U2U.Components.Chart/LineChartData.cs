using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace U2U.Components.Chart
{
  /// <summary>
  /// These are the data properties for a line chart
  /// </summary>
  /// <remarks>
  /// More information: http://www.chartjs.org/docs/latest/charts/line.html
  /// </remarks>
  public class LineChartData
  {
    public class DataSet
    {
      /// <summary>
      /// The label for the dataset which appears in the legend and tooltips.
      /// </summary>
      public string Label { get; set; }

      /// <summary>
      /// Actual data. This is an int array.
      /// </summary>
      public List<Point> Data { get; set; } = null;

      /// <summary>
      /// The fill color under the line. 
      /// </summary>
      public string BackgroundColor { get; set; }

      /// <summary>
      /// The color of the line
      /// </summary>
      public string BorderColor { get; set; }

      /// <summary>
      /// The thickness of the line
      /// </summary>
      public int BorderWidth { get; set; } = 2;
    }

    public string[] Labels { get; set; } = Array.Empty<string>();

    public DataSet[] Datasets { get; set; }
  }
}
