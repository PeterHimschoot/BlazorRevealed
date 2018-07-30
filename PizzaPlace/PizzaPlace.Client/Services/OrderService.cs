using PizzaPlace.Shared;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using System.Net.Http;

namespace PizzaPlace.Client.Services
{
  public class OrderService : IOrderService
  {
    private HttpClient httpClient;

    public OrderService( HttpClient httpClient)
    {
      this.httpClient = httpClient;
    }

    public async Task PlaceOrder(Basket basket)
    {
      await httpClient.PostJsonAsync("/orders", basket);
    }
  }
}
