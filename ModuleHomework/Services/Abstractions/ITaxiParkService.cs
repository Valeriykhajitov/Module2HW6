using ModuleHomework.Models.Car;

namespace ModuleHomework.Services
{
  public interface ITaxiParkService
  {
    public Car[] Cars { get; }
    public double TotalCost { get; }
    public int Capacity { get; }
    public void Add(Car cars);
    public void Remove();
  }
}