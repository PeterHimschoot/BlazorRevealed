using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using U2U.Components.Chart;

namespace ChartTestProject
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCharts();
    }

    public void Configure(IBlazorApplicationBuilder app)
    {
      app.AddComponent<App>("app");
    }
  }
}
