using ModuleHomework.Models.Car;

namespace ModuleHomework.Providers
{
  public interface ITaxiParkProvider
  {
    Car[] TaxiPark { get; }
  }
}