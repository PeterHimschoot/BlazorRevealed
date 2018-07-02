using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorControlsDemo.Controls
{
  public class BingMap
  {
    public static string Load(string id, string key)
    {
      return RegisteredFunction.Invoke<string>("BlazorControlsDemo.Controls.getMap", id, key);
    }
  }
}
