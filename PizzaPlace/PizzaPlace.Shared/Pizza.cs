﻿using System;
using System.Collections.Generic;

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
    public Pizza() { }

    public Pizza(int id, string name, decimal price, Spiciness spicyness)
    {
      this.Id = id;
      this.Name = name ?? throw new ArgumentNullException(nameof(name), "A pizza needs a name!");
      this.Price = price;
      this.Spicyness = spicyness;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Spiciness Spicyness { get; set; }

    public List<PizzaOrder> PizzaOrders { get; set; }
  }
}
