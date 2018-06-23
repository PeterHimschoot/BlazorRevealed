﻿using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using PizzaPlace.Shared;

namespace PizzaPlace.Client
{
  public class Program
  {
    static void Main(string[] args)
    {
      var serviceProvider = new BrowserServiceProvider(services =>
      {
        // Add any custom services here
        services.AddTransient<IMenuService, HardCodedMenuService>();
        services.AddTransient<IOrderService, ConsoleOrderService>();
      });

      new BrowserRenderer(serviceProvider).AddComponent<App>("app");
    }
  }
}
