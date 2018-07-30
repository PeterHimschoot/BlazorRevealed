using System;
using System.ComponentModel;
using System.Collections;

namespace PizzaPlace.Shared
{
  public class Customer : INotifyDataErrorInfo
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Street { get; set; }

    public string City { get; set; }

    public Order Order { get; set; }

    // The rest of the class omitted for clarity

    public bool HasErrors => GetErrors(string.Empty).Any();

    public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    public IEnumerable GetErrors(string propertyName)
    {
      Console.WriteLine($"Validating {propertyName}.");
      if( string.IsNullOrEmpty(propertyName) || propertyName == nameof(Name))
      {
      Console.WriteLine($"Inside {propertyName}.");
        if( string.IsNullOrEmpty(Name))
        {
          yield return $"A customer's name is mandatory";
        }
        else if( Name.Contains("Pizza"))
        {
          yield return $"A customer's name should not contain \"Pizza\"";
        }
      }
      if( string.IsNullOrEmpty(propertyName) || propertyName == nameof(Street))
      {
        if( string.IsNullOrEmpty(Street))
        {
          yield return $"Street is mandatory";
        }
      }
      if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(City))
      {
        if (string.IsNullOrEmpty(City))
        {
          yield return $"City is mandatory";
        }
      }
    }
  }
}
