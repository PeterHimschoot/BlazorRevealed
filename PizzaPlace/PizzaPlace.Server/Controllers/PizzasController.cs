using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;

namespace PizzaPlace.Server.Controllers
{
  [ApiController]
  public class PizzasController : ControllerBase
  {
    private PizzaPlaceDbContext db;

    public PizzasController(PizzaPlaceDbContext db)
    {
      this.db = db;
    }

    [HttpGet("pizzas")]
    public IQueryable<Pizza> GetPizzas()
    {
      return db.Pizzas;
    }

    [HttpPost("pizzas")]
    public IActionResult InsertPizza([FromBody] Pizza pizza)
    {
      db.Pizzas.Add(pizza);
      db.SaveChanges();
      return Created($"pizzas/{pizza.Id}", pizza);
    }
  }
}