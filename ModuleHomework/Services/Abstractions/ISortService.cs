using ModuleHomework.Models.Car;
using System.Collections;

namespace ModuleHomework.Providers
{
  public interface ISortService
  {
    void SortByFuelConsumption(Car[] taxiPark, IComparer comparer);
  }
}