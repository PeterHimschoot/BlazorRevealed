using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPlace.Shared
{
  public enum Spiciness
  {
    None,
    Spicy,
    Hot
  }

  public class Pizza
  {
    public Pizza(int id, string name, decimal price, Spiciness spicyness)
    {
      this.Id = id;
      this.Name = name ?? throw new ArgumentNullException(nameof(name), "A pizza needs a name!");
      this.Price = price;
      this.Spicyness = spicyness;
    }

    public int Id { get; }
    public string Name { get; }
    public decimal Price { get; }
    public Spiciness Spicyness { get; }
  }
}
