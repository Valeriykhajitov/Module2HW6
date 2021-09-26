using ModuleHomework.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Services
{
  public class TaxiParkService : ITaxiParkService
  {

    private int iterator;

    public TaxiParkService(int capacity)
    {
      Cars = new Car[capacity];
      Capacity = capacity;
    }

    public Car[] Cars { get; }

    public int Capacity { get; }

    public double TotalCost
    {
      get
      {
        var Cost = 0d;
        foreach (var x in Cars)
        {
          Cost += x.Price;
        }

        return Cost;
      }
    }

    public void Add(Car cars)
    {
      if (iterator < Capacity)
      {
        Cars[iterator++] = cars;
      }
    }

    public void Remove()
    {
      Cars[iterator--] = null;
    }
  }
}
