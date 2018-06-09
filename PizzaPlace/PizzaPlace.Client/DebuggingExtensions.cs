using Microsoft.AspNetCore.Blazor;

namespace PizzaPlace.Client
{
  public static class DebuggingExtensions
  {
    public static string ToJson(this object obj) => JsonUtil.Serialize(obj);
  }
}
