using ModuleHomework.Models.Car;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Common
{
  class FuelConsumptionComparer : IComparer
  {
    public int Compare(object obj1, object obj2)
    {
      var car1 = obj1 as Car;
      var car2 = obj2 as Car;

      if (car1.FuelPer100km > car2.FuelPer100km)
      {
        return 1;
      }
      else if (car1.FuelPer100km < car2.FuelPer100km)
      {
        return -1;
      }

      return 0;
    }
  }
}
