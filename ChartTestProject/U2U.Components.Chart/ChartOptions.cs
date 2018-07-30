using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U2U.Components.Chart
{
  public class ChartOptions
  {

    public class TitleOptions
    {
      public static readonly TitleOptions Default = new TitleOptions { };

      public bool Display { get; set; } = false;
    }

    public class ScalesOptions
    {
      public static readonly ScalesOptions Default = new ScalesOptions();

      public class ScaleOptions
      {
        public static readonly ScaleOptions Default = new ScaleOptions { };

        public class TickOptions
        {
          public static readonly TickOptions Default = new TickOptions
          {
            BeginAtZero = true,
            Max = 100
          };

          public bool BeginAtZero { get; set; }

          public int Max { get; set; }
        }

        public bool Display { get; set; } = true;

        public TickOptions Ticks { get; set; } = TickOptions.Default;
      }

      public ScaleOptions[] YAxes { get; set; } = new ScaleOptions[] { ScaleOptions.Default };
    }


    public static readonly ChartOptions Default = new ChartOptions { };

    /// <summary>
    /// The chart title defines text to draw at the top of the chart.
    /// </summary>
    public TitleOptions Title { get; set; } = TitleOptions.Default;

    public bool Responsive { get; set; } = true;

    public bool MaintainAspectRatio { get; set; } = true;

    public ScalesOptions Scales { get; set; } = ScalesOptions.Default;
  }

}
