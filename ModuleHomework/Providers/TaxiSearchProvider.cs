using ModuleHomework.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Providers
{
  public static class TaxiSearchProvider
  {
    public static Car TaxiSearch(this Car[] CarsList, string CategoryName, string value)
    {

      foreach (Car car in CarsList)
      {
        try
        {
          if (car.GetType().GetProperty(CategoryName).GetValue(car, null).ToString().Contains(value))
          {
            Console.WriteLine("{0} {1} ", car.manufacturer, car.Model);
            return car;
          }
        }
        catch (Exception e)
        {
          continue;
        }
      }
      return null;
    }
  }
}
