using ModuleHomework.Models.Car;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Providers
{
  public class SortService : ISortService
  {
    public void SortByFuelConsumption(Car[] taxiPark, IComparer comparer)
    {
      Array.Sort(taxiPark, comparer);
    }
  }
}
