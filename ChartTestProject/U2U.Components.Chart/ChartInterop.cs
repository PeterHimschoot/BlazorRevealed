using Microsoft.JSInterop;

namespace U2U.Components.Chart
{

  /// <summary>
  /// It is always a good idea to hide specific implementation details
  /// behind a service class
  /// </summary>
  public class ChartInterop : IChartInterop
  {
    public void CreateLineChart(string id, LineChartData data, 
                                           ChartOptions options)
    {
      JSRuntime.Current.InvokeAsync<string>("components.chart", id, data, options);
    }
  }
}
