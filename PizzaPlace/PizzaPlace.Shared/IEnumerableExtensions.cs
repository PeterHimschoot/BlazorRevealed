using System.Collections;

namespace PizzaPlace.Shared
{
  public static class IEnumerableExtensions
  {
    public static bool Any(this IEnumerable enumerable)
      => enumerable.GetEnumerator().MoveNext() == true;
  }
}
